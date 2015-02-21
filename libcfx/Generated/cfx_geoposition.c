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

CFX_EXPORT void cfx_geoposition_copy_to_native(cef_geoposition_t* self, double latitude, double longitude, double altitude, double accuracy, double altitude_accuracy, double heading, double speed, cef_time_t* timestamp, cef_geoposition_error_code_t error_code, char16 *error_message_str, int error_message_length) {
    self->latitude = latitude;
    self->longitude = longitude;
    self->altitude = altitude;
    self->accuracy = accuracy;
    self->altitude_accuracy = altitude_accuracy;
    self->heading = heading;
    self->speed = speed;
    self->timestamp = *(timestamp);
    self->error_code = error_code;
    cef_string_utf16_set(error_message_str, error_message_length, &(self->error_message), 1);
}

CFX_EXPORT void cfx_geoposition_copy_to_managed(cef_geoposition_t* self, double* latitude, double* longitude, double* altitude, double* accuracy, double* altitude_accuracy, double* heading, double* speed, cef_time_t** timestamp, cef_geoposition_error_code_t* error_code, char16 **error_message_str, int *error_message_length) {
    *latitude = self->latitude;
    *longitude = self->longitude;
    *altitude = self->altitude;
    *accuracy = self->accuracy;
    *altitude_accuracy = self->altitude_accuracy;
    *heading = self->heading;
    *speed = self->speed;
    *timestamp = &(self->timestamp);
    *error_code = self->error_code;
    *error_message_str = self->error_message.str;
    *error_message_length = self->error_message.length;
}

#ifdef __cplusplus
} // extern "C"
#endif

