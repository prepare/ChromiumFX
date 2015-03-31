// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.


using System;
using System.Drawing;
using System.Windows.Forms;
using Chromium;

namespace Windowless {
    /// <summary>
    /// A minimum and very incomplete implementation of a
    /// control with windowless browser.
    /// </summary>
    class BrowserControl : Control {

        internal CfxBrowser browser;

        private CfxClient client;
        private CfxLifeSpanHandler lifeSpanHandler;
        private CfxLoadHandler loadHandler;
        private CfxRenderHandler renderHandler;

        private Bitmap pixelBuffer;
        private object pbLock = new object();
                
        public BrowserControl() {

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            lifeSpanHandler = new CfxLifeSpanHandler();
            lifeSpanHandler.OnAfterCreated += lifeSpanHandler_OnAfterCreated;
            
            renderHandler = new CfxRenderHandler();
            
            renderHandler.GetRootScreenRect += renderHandler_GetRootScreenRect;
            renderHandler.GetScreenInfo += renderHandler_GetScreenInfo;
            renderHandler.GetScreenPoint += renderHandler_GetScreenPoint;
            renderHandler.GetViewRect += renderHandler_GetViewRect;
            renderHandler.OnCursorChange += renderHandler_OnCursorChange;
            renderHandler.OnPaint += renderHandler_OnPaint;
            //renderHandler.OnPopupShow += renderHandler_OnPopupShow;
            //renderHandler.OnPopupSize += renderHandler_OnPopupSize;
            //renderHandler.OnScrollOffsetChanged += renderHandler_OnScrollOffsetChanged;
            //renderHandler.StartDragging += renderHandler_StartDragging;
            //renderHandler.UpdateDragCursor += renderHandler_UpdateDragCursor;

            loadHandler = new CfxLoadHandler();

            loadHandler.OnLoadError += loadHandler_OnLoadError;
            
            client = new CfxClient();
            client.GetLifeSpanHandler += (sender, e) => e.SetReturnValue(lifeSpanHandler);
            client.GetRenderHandler += (sender, e) => e.SetReturnValue(renderHandler);
            client.GetLoadHandler += (sender, e) => e.SetReturnValue(loadHandler);

            var settings = new CfxBrowserSettings();

            var windowInfo = new CfxWindowInfo();
            windowInfo.WindowlessRenderingEnabled = true;
            windowInfo.Width = 800;
            windowInfo.Height = 600;
            
            // Create handle now for InvokeRequired to work properly 
            CreateHandle();
            CfxBrowserHost.CreateBrowser(windowInfo, client, "about:blank", settings, null);

        }

        void loadHandler_OnLoadError(object sender, Chromium.Event.CfxOnLoadErrorEventArgs e) {
            if(e.ErrorCode == CfxErrorCode.Aborted) {
                // this seems to happen when calling LoadUrl and the browser is not yet ready
                var url = e.FailedUrl;
                var frame = e.Frame;
                System.Threading.ThreadPool.QueueUserWorkItem((state) => {
                    System.Threading.Thread.Sleep(200);
                    frame.LoadUrl(url);
                });
            }
        }

        void renderHandler_UpdateDragCursor(object sender, Chromium.Event.CfxUpdateDragCursorEventArgs e) {
            throw new NotImplementedException();
        }

        void renderHandler_StartDragging(object sender, Chromium.Event.CfxStartDraggingEventArgs e) {
            throw new NotImplementedException();
        }

        void renderHandler_OnScrollOffsetChanged(object sender, Chromium.Event.CfxOnScrollOffsetChangedEventArgs e) {
            throw new NotImplementedException();
        }

        void renderHandler_OnPopupSize(object sender, Chromium.Event.CfxOnPopupSizeEventArgs e) {
            throw new NotImplementedException();
        }

        void renderHandler_OnPopupShow(object sender, Chromium.Event.CfxOnPopupShowEventArgs e) {
            throw new NotImplementedException();
        }

        void renderHandler_OnPaint(object sender, Chromium.Event.CfxOnPaintEventArgs e) {
            
            lock(pbLock) {
                if(pixelBuffer == null || pixelBuffer.Width < e.Width || pixelBuffer.Height < e.Height) {
                    pixelBuffer = new Bitmap(e.Width, e.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                }
                using(var bm = new Bitmap(e.Width, e.Height, e.Width * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, e.Buffer)) {
                    using(var g = Graphics.FromImage(pixelBuffer)) {
                        g.DrawImageUnscaled(bm, 0, 0);
                    }
                }
            }
            foreach(var r in e.DirtyRects) {
                Invalidate(new Rectangle(r.X, r.Y, r.Width, r.Height));
            }
        }

        void renderHandler_OnCursorChange(object sender, Chromium.Event.CfxOnCursorChangeEventArgs e) {
            switch(e.Type) {
                case CfxCursorType.Hand:
                    Cursor = Cursors.Hand;
                    break;
                default:
                    Cursor = Cursors.Default;
                    break;
            }
        }

        void renderHandler_GetViewRect(object sender, Chromium.Event.CfxGetViewRectEventArgs e) {
            
            if(InvokeRequired) {
                Invoke((MethodInvoker)(() => renderHandler_GetViewRect(sender, e)));
                return;
            }

            if(!IsDisposed) {
                var origin = PointToScreen(new Point(0, 0));
                e.Rect.X = origin.X;
                e.Rect.Y = origin.Y;
                e.Rect.Width = Width;
                e.Rect.Height = Height;
                e.SetReturnValue(true);
            }
        }

        void renderHandler_GetScreenPoint(object sender, Chromium.Event.CfxGetScreenPointEventArgs e) {

            if(InvokeRequired) {
                Invoke((MethodInvoker)(() => renderHandler_GetScreenPoint(sender, e)));
                return;
            }

            if(!IsDisposed) {
                var origin = PointToScreen(new Point(e.ViewX , e.ViewY));
                e.ScreenX = origin.X;
                e.ScreenY = origin.Y;
                e.SetReturnValue(true);
            }
        }

        void renderHandler_GetScreenInfo(object sender, Chromium.Event.CfxGetScreenInfoEventArgs e) {
        }

        void renderHandler_GetRootScreenRect(object sender, Chromium.Event.CfxGetRootScreenRectEventArgs e) {
        }


        void lifeSpanHandler_OnAfterCreated(object sender, Chromium.Event.CfxOnAfterCreatedEventArgs e) {
            browser = e.Browser;
            browser.MainFrame.LoadUrl("about:credit");
        }


        // control overrides

        protected override void OnResize(EventArgs e) {
            if(browser != null) {
                browser.Host.WasResized();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent) {
            // do nothing
        }

        protected override void OnPaint(PaintEventArgs e) {
            lock(pbLock) {
                if(pixelBuffer != null)
                    e.Graphics.DrawImage(pixelBuffer, e.ClipRectangle, e.ClipRectangle, GraphicsUnit.Pixel);
            }
        }

        
        // mouse events
        // this is not complete

        private readonly CfxMouseEvent mouseEventProxy = new CfxMouseEvent();

        private void SetMouseEvent(MouseEventArgs e) {
                mouseEventProxy.X = e.X;
                mouseEventProxy.Y = e.Y;
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            if(browser != null) {
                SetMouseEvent(e);
                browser.Host.SendMouseMoveEvent(mouseEventProxy, false);
            }
        }

        protected override void OnMouseLeave(EventArgs e) {
            if(browser != null) {
                browser.Host.SendMouseMoveEvent(mouseEventProxy, true);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            if(browser != null) {
                SetMouseEvent(e);
                CfxMouseButtonType t;
                switch(e.Button) {
                    case System.Windows.Forms.MouseButtons.Right:
                        t = CfxMouseButtonType.Left;
                        break;
                    case System.Windows.Forms.MouseButtons.Middle:
                        t = CfxMouseButtonType.Middle;
                        break;
                    default:
                        t = CfxMouseButtonType.Left;
                        break;
                }
                browser.Host.SendMouseClickEvent(mouseEventProxy, t, false, e.Clicks);
            }
        }
        protected override void OnMouseUp(MouseEventArgs e) {
            if(browser != null) {
                SetMouseEvent(e);
                CfxMouseButtonType t;
                switch(e.Button) {
                    case System.Windows.Forms.MouseButtons.Right:
                        t = CfxMouseButtonType.Left;
                        break;
                    case System.Windows.Forms.MouseButtons.Middle:
                        t = CfxMouseButtonType.Middle;
                        break;
                    default:
                        t = CfxMouseButtonType.Left;
                        break;
                }
                browser.Host.SendMouseClickEvent(mouseEventProxy, t, true, e.Clicks);
            }
        }
    }
}
