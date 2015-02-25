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

// Generated file. Do not edit.


using System;

namespace Chromium {
    /// <summary>
    /// Structure used to represent a download item.
    /// </summary>
    public class CfxDownloadItem : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxDownloadItem Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxDownloadItem)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxDownloadItem(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxDownloadItem(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns true (1) if this object is valid. Do not call any other functions
        /// if this function returns false (0).
        /// </summary>
        public bool IsValid {
            get {
                return 0 != CfxApi.cfx_download_item_is_valid(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the download is in progress.
        /// </summary>
        public bool IsInProgress {
            get {
                return 0 != CfxApi.cfx_download_item_is_in_progress(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the download is complete.
        /// </summary>
        public bool IsComplete {
            get {
                return 0 != CfxApi.cfx_download_item_is_complete(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the download has been canceled or interrupted.
        /// </summary>
        public bool IsCanceled {
            get {
                return 0 != CfxApi.cfx_download_item_is_canceled(NativePtr);
            }
        }

        /// <summary>
        /// Returns a simple speed estimate in bytes/s.
        /// </summary>
        public long CurrentSpeed {
            get {
                return CfxApi.cfx_download_item_get_current_speed(NativePtr);
            }
        }

        /// <summary>
        /// Returns the rough percent complete or -1 if the receive total size is
        /// unknown.
        /// </summary>
        public int PercentComplete {
            get {
                return CfxApi.cfx_download_item_get_percent_complete(NativePtr);
            }
        }

        /// <summary>
        /// Returns the total number of bytes.
        /// </summary>
        public long TotalBytes {
            get {
                return CfxApi.cfx_download_item_get_total_bytes(NativePtr);
            }
        }

        /// <summary>
        /// Returns the number of received bytes.
        /// </summary>
        public long ReceivedBytes {
            get {
                return CfxApi.cfx_download_item_get_received_bytes(NativePtr);
            }
        }

        /// <summary>
        /// Returns the time that the download started.
        /// </summary>
        public CfxTime StartTime {
            get {
                return CfxTime.Wrap(CfxApi.cfx_download_item_get_start_time(NativePtr));
            }
        }

        /// <summary>
        /// Returns the time that the download ended.
        /// </summary>
        public CfxTime EndTime {
            get {
                return CfxTime.Wrap(CfxApi.cfx_download_item_get_end_time(NativePtr));
            }
        }

        /// <summary>
        /// Returns the full path to the downloaded or downloading file.
        /// </summary>
        public String FullPath {
            get {
                return StringUserfree.Convert(CfxApi.cfx_download_item_get_full_path(NativePtr));
            }
        }

        /// <summary>
        /// Returns the unique identifier for this download.
        /// </summary>
        public uint Id {
            get {
                return CfxApi.cfx_download_item_get_id(NativePtr);
            }
        }

        /// <summary>
        /// Returns the URL.
        /// </summary>
        public String Url {
            get {
                return StringUserfree.Convert(CfxApi.cfx_download_item_get_url(NativePtr));
            }
        }

        /// <summary>
        /// Returns the suggested file name.
        /// </summary>
        public String SuggestedFileName {
            get {
                return StringUserfree.Convert(CfxApi.cfx_download_item_get_suggested_file_name(NativePtr));
            }
        }

        /// <summary>
        /// Returns the content disposition.
        /// </summary>
        public String ContentDisposition {
            get {
                return StringUserfree.Convert(CfxApi.cfx_download_item_get_content_disposition(NativePtr));
            }
        }

        /// <summary>
        /// Returns the mime type.
        /// </summary>
        public String MimeType {
            get {
                return StringUserfree.Convert(CfxApi.cfx_download_item_get_mime_type(NativePtr));
            }
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
