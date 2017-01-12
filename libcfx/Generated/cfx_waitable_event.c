// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


