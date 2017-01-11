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


// cef_waitable_event

// CEF_EXPORT cef_waitable_event_t* cef_waitable_event_create(int automatic_reset, int initially_signaled);
static cef_waitable_event_t* cfx_waitable_event_create(int automatic_reset, int initially_signaled) {
    return cef_waitable_event_create(automatic_reset, initially_signaled);
}
// reset
static void cfx_waitable_event_reset(cef_waitable_event_t* self) {
    self->reset(self);
}

// signal
static void cfx_waitable_event_signal(cef_waitable_event_t* self) {
    self->signal(self);
}

// is_signaled
static int cfx_waitable_event_is_signaled(cef_waitable_event_t* self) {
    return self->is_signaled(self);
}

// wait
static void cfx_waitable_event_wait(cef_waitable_event_t* self) {
    self->wait(self);
}

// timed_wait
static int cfx_waitable_event_timed_wait(cef_waitable_event_t* self, int64 max_ms) {
    return self->timed_wait(self, max_ms);
}


