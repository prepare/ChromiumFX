// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_v8stack_trace

// CEF_EXPORT cef_v8stack_trace_t* cef_v8stack_trace_get_current(int frame_limit);
static cef_v8stack_trace_t* cfx_v8stack_trace_get_current(int frame_limit) {
    return cef_v8stack_trace_get_current(frame_limit);
}
// is_valid
static int cfx_v8stack_trace_is_valid(cef_v8stack_trace_t* self) {
    return self->is_valid(self);
}

// get_frame_count
static int cfx_v8stack_trace_get_frame_count(cef_v8stack_trace_t* self) {
    return self->get_frame_count(self);
}

// get_frame
static cef_v8stack_frame_t* cfx_v8stack_trace_get_frame(cef_v8stack_trace_t* self, int index) {
    return self->get_frame(self, index);
}


