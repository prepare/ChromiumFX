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
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Chromium.WebBrowser {

    public class FindToolbar {

        private ChromiumWebBrowser wb;

        private Panel panel = new Panel();
        private TextBox textBox = new TextBox();
        private Button downButton = new Button();
        private Button upButton = new Button();
        private Button matchCaseButton = new Button();
        private Label resultLabel = new Label();
        private Button closeButton = new Button();

        private ToolTip toolTip = new ToolTip();

        private bool m_visible;

        private int lastFindId;
        private bool m_matchCase;


        internal FindToolbar(ChromiumWebBrowser wb) {

            this.wb = wb;

            textBox.Font = new Font(textBox.Font.FontFamily, 10, FontStyle.Italic);
            textBox.Left = 10;
            textBox.Top = 8;
            textBox.Width = 200;
            textBox.ForeColor = Color.DimGray;

            textBox.TextChanged += (s, e) => {
                if(textBox.Text.Length == 0 && textBox.Font.Style != FontStyle.Italic) {
                    textBox.Font = new Font(textBox.Font, FontStyle.Italic);
                } else if(textBox.Text.Length > 0 && textBox.Font.Style == FontStyle.Italic) {
                    textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                }
                Find(true);
            };

            textBox.KeyDown += (s, e) => {
                if(e.KeyCode == Keys.Return)
                    Find(true);
            };

            upButton.SetBounds(textBox.Left + textBox.Width - 1, textBox.Top, textBox.Height, textBox.Height);
            SetButtonStyle(upButton);
            upButton.Text = "▲";
            upButton.Click += (s, e) => {
                Find(false);
            };
            upButton.Parent = panel;
            toolTip.SetToolTip(upButton, "Goto previous match");

            downButton.SetBounds(upButton.Left + upButton.Width - 1, textBox.Top, textBox.Height, textBox.Height);
            SetButtonStyle(downButton);
            downButton.Text = "▼";
            downButton.Click += (s, e) => {
                Find(true);
            };
            downButton.Parent = panel;
            toolTip.SetToolTip(downButton, "Goto next match");

            matchCaseButton.Text = "Match Case";
            matchCaseButton.ForeColor = Color.DimGray;
            matchCaseButton.Left = downButton.Left + downButton.Width + 10;
            matchCaseButton.Top = downButton.Top;
            matchCaseButton.Width = 90;
            matchCaseButton.Height = downButton.Height;
            matchCaseButton.Font = new Font(textBox.Font.FontFamily, 10);
            matchCaseButton.FlatStyle = FlatStyle.Flat;
            matchCaseButton.FlatAppearance.BorderSize = 0;
            matchCaseButton.BackColor = Color.Transparent;
            matchCaseButton.TextAlign = ContentAlignment.MiddleCenter;

            matchCaseButton.Click += (s, e) => {
                ChangeMatchCase();
            };

            matchCaseButton.GotFocus += (s, e) => { textBox.Focus(); };

            matchCaseButton.Parent = panel;

            resultLabel.Font = new Font(textBox.Font.FontFamily, 10);
            resultLabel.ForeColor = Color.DimGray;
            resultLabel.Left = matchCaseButton.Left + matchCaseButton.Width + 10;
            resultLabel.Top = matchCaseButton.Top + 3;
            resultLabel.AutoSize = true;
            resultLabel.Parent = panel;

            panel.Width = wb.Width + 4;
            panel.Height = textBox.Height + 15;
            panel.Left = -2;
            panel.Top = wb.Height - panel.Height + 2;
            panel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.WhiteSmoke;

            textBox.Parent = panel;

            closeButton.Height = upButton.Height;
            closeButton.Width = closeButton.Height;
            closeButton.Left = panel.Width - closeButton.Width - 10;
            closeButton.Top = upButton.Top;
            closeButton.Text = "❌";
            closeButton.ForeColor = Color.DimGray;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.BackColor = Color.Transparent;
            toolTip.SetToolTip(closeButton, "Close the Find Bar");

            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Parent = panel;
            

            closeButton.Click += (s, e) => {
                Visible = false;
            };

            SendMessage(textBox.Handle, 0x1501, 1, "Find in page");

            // Once a find toolbar is created for a browser, it is kept until the browser is destroyed.
            // So there is no need to unsubscribe from this event.
            wb.FindHandler.OnFindResult += (s, e) => {
                if(e.Identifier == lastFindId) {
                    var count = e.Count;
                    BeginInvoke(() => {
                        if(count == 0 && textBox.Text.Length > 0) {
                            textBox.BackColor = Color.LightCoral;
                            textBox.ForeColor = Color.White;
                            resultLabel.Text = "Phrase not found";
                        } else {
                            textBox.BackColor = TextBox.DefaultBackColor;
                            textBox.ForeColor = Color.DimGray;
                            if(textBox.Text.Length > 0) {
                                resultLabel.Text = String.Format("{0} match{1}", 
                                    count, count == 1 ? "" : "es");
                            } else {
                                resultLabel.Text = String.Empty;
                            }
                        }
                    });
                }
            };
        }

        private void ChangeMatchCase() {
            m_matchCase = !m_matchCase;
            if(m_matchCase) {
                matchCaseButton.BackColor = Color.LightGray;
                matchCaseButton.FlatAppearance.BorderSize = 1;
            } else {
                matchCaseButton.BackColor = Color.Transparent;
                matchCaseButton.FlatAppearance.BorderSize = 0;
            }
            Find(true);
            Find(false);
        }

        private void BeginInvoke(MethodInvoker m) {
            wb.BeginInvoke(m);
        }

        private void SetButtonStyle(Button b) {
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = textBox.BackColor;
            b.ForeColor = textBox.ForeColor;
            b.FlatAppearance.BorderColor = Color.Gray;
            b.FlatAppearance.MouseOverBackColor = b.BackColor;
        }

        private void Find(bool forward) {
            lastFindId = wb.Find(textBox.Text, forward, m_matchCase);
        }

        internal int Top {
            get {
                return panel.Top;
            }
        }

        /// <summary>
        /// Get or set a value indicating wether to show the find toolbar.
        /// </summary>
        public bool Visible {
            get {
                return m_visible;
            }
            set {
                m_visible = value;
                if(m_visible) {
                    panel.Parent = wb;
                    if(textBox.Text.Length > 0)
                        wb.Find(null);
                    
                } else {
                    if(textBox.Text.Length == 0)
                        wb.Find(null);
                    panel.Parent = null;
                }
                wb.ResizeBrowserWindow();
            }
        }

        /// <summary>
        /// Get or set a value indicating wether to show the close button.
        /// </summary>
        public bool CloseButtonVisible {
            get {
                return closeButton.Visible;
            }
            set {
                closeButton.Visible = value;
            }
        }

        /// <summary>
        /// Get or set the state of the match case button.
        /// </summary>
        public bool MatchCase {
            get {
                return m_matchCase;
            }
            set {
                if(m_matchCase != value)
                    ChangeMatchCase();
            }
        }

        /// <summary>
        /// Sets the text and performs a search.
        /// </summary>
        public void SetSearchText(string text) {
            textBox.Text = text;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

    }
}
