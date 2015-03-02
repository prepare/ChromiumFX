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


// cef_geoposition

#ifdef __cplusplus
extern "C" {
#endif

CFX_EXPORT cef_geoposition_t* cfx_geoposition_ctor() {
    return (cef_geoposition_t*)calloc(1, sizeof(cef_geoposition_t));
}

CFX_EXPORT void cfx_geoposition_dtor(cef_geoposition_t* ptr) {
    if(ptr->error_message.dtor) ptr->error_message.dtor(ptr->error_message.str);
    free(ptr);
}

// cef_geoposition_t->latitude
CFX_EXPORT void cfx_geoposition_set_latitude(cef_geoposition_t *self, double latitude) {
    self->latitude = latitude;
}
CFX_EXPORT void cfx_geoposition_get_latitude(cef_geoposition_t *self, double* latitude) {
    *latitude = self->latitude;
}

// cef_geoposition_t->longitude
CFX_EXPORT void cfx_geoposition_set_longitude(cef_geoposition_t *self, double longitude) {
    self->longitude = longitude;
}
CFX_EXPORT void cfx_geoposition_get_longitude(cef_geoposition_t *self, double* longitude) {
    *longitude = self->longitude;
}

// cef_geoposition_t->altitude
CFX_EXPORT void cfx_geoposition_set_altitude(cef_geoposition_t *self, double altitude) {
    self->altitude = altitude;
}
CFX_EXPORT void cfx_geoposition_get_altitude(cef_geoposition_t *self, double* altitude) {
    *altitude = self->altitude;
}

// cef_geoposition_t->accuracy
CFX_EXPORT void cfx_geoposition_set_accuracy(cef_geoposition_t *self, double accuracy) {
    self->accuracy = accuracy;
}
CFX_EXPORT void cfx_geoposition_get_accuracy(cef_geoposition_t *self, double* accuracy) {
    *accuracy = self->accuracy;
}

// cef_geoposition_t->altitude_accuracy
CFX_EXPORT void cfx_geoposition_set_altitude_accuracy(cef_geoposition_t *self, double altitude_accuracy) {
    self->altitude_accuracy = altitude_accuracy;
}
CFX_EXPORT void cfx_geoposition_get_altitude_accuracy(cef_geoposition_t *self, double* altitude_accuracy) {
    *altitude_accuracy = self->altitude_accuracy;
}

// cef_geoposition_t->heading
CFX_EXPORT void cfx_geoposition_set_heading(cef_geoposition_t *self, double heading) {
    self->heading = heading;
}
CFX_EXPORT void cfx_geoposition_get_heading(cef_geoposition_t *self, double* heading) {
    *heading = self->heading;
}

// cef_geoposition_t->speed
CFX_EXPORT void cfx_geoposition_set_speed(cef_geoposition_t *self, double speed) {
    self->speed = speed;
}
CFX_EXPORT void cfx_geoposition_get_speed(cef_geoposition_t *self, double* speed) {
    *speed = self->speed;
}

// cef_geoposition_t->timestamp
CFX_EXPORT void cfx_geoposition_set_timestamp(cef_geoposition_t *self, cef_time_t* timestamp) {
    self->timestamp = *(timestamp);
}
CFX_EXPORT void cfx_geoposition_get_timestamp(cef_geoposition_t *self, cef_time_t** timestamp) {
    *timestamp = &(self->timestamp);
}

// cef_geoposition_t->error_code
CFX_EXPORT void cfx_geoposition_set_error_code(cef_geoposition_t *self, cef_geoposition_error_code_t error_code) {
    self->error_code = error_code;
}
CFX_EXPORT void cfx_geoposition_get_error_code(cef_geoposition_t *self, cef_geoposition_error_code_t* error_code) {
    *error_code = self->error_code;
}

// cef_geoposition_t->error_message
CFX_EXPORT void cfx_geoposition_set_error_message(cef_geoposition_t *self, char16 *error_message_str, int error_message_length) {
    cef_string_utf16_set(error_message_str, error_message_length, &(self->error_message), 1);
}
CFX_EXPORT void cfx_geoposition_get_error_message(cef_geoposition_t *self, char16 **error_message_str, int *error_message_length) {
    *error_message_str = self->error_message.str;
    *error_message_length = self->error_message.length;
}


#ifdef __cplusplus
} // extern "C"
#endif

