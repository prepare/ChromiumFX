// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_geoposition

static cef_geoposition_t* cfx_geoposition_ctor() {
    return (cef_geoposition_t*)calloc(1, sizeof(cef_geoposition_t));
}

static void cfx_geoposition_dtor(cef_geoposition_t* self) {
    if(self->error_message.dtor) self->error_message.dtor(self->error_message.str);
    free(self);
}

// cef_geoposition_t->latitude
static void cfx_geoposition_set_latitude(cef_geoposition_t *self, double latitude) {
    self->latitude = latitude;
}
static void cfx_geoposition_get_latitude(cef_geoposition_t *self, double* latitude) {
    *latitude = self->latitude;
}

// cef_geoposition_t->longitude
static void cfx_geoposition_set_longitude(cef_geoposition_t *self, double longitude) {
    self->longitude = longitude;
}
static void cfx_geoposition_get_longitude(cef_geoposition_t *self, double* longitude) {
    *longitude = self->longitude;
}

// cef_geoposition_t->altitude
static void cfx_geoposition_set_altitude(cef_geoposition_t *self, double altitude) {
    self->altitude = altitude;
}
static void cfx_geoposition_get_altitude(cef_geoposition_t *self, double* altitude) {
    *altitude = self->altitude;
}

// cef_geoposition_t->accuracy
static void cfx_geoposition_set_accuracy(cef_geoposition_t *self, double accuracy) {
    self->accuracy = accuracy;
}
static void cfx_geoposition_get_accuracy(cef_geoposition_t *self, double* accuracy) {
    *accuracy = self->accuracy;
}

// cef_geoposition_t->altitude_accuracy
static void cfx_geoposition_set_altitude_accuracy(cef_geoposition_t *self, double altitude_accuracy) {
    self->altitude_accuracy = altitude_accuracy;
}
static void cfx_geoposition_get_altitude_accuracy(cef_geoposition_t *self, double* altitude_accuracy) {
    *altitude_accuracy = self->altitude_accuracy;
}

// cef_geoposition_t->heading
static void cfx_geoposition_set_heading(cef_geoposition_t *self, double heading) {
    self->heading = heading;
}
static void cfx_geoposition_get_heading(cef_geoposition_t *self, double* heading) {
    *heading = self->heading;
}

// cef_geoposition_t->speed
static void cfx_geoposition_set_speed(cef_geoposition_t *self, double speed) {
    self->speed = speed;
}
static void cfx_geoposition_get_speed(cef_geoposition_t *self, double* speed) {
    *speed = self->speed;
}

// cef_geoposition_t->timestamp
static void cfx_geoposition_set_timestamp(cef_geoposition_t *self, cef_time_t* timestamp) {
    self->timestamp = *(timestamp);
}
static void cfx_geoposition_get_timestamp(cef_geoposition_t *self, cef_time_t** timestamp) {
    *timestamp = &(self->timestamp);
}

// cef_geoposition_t->error_code
static void cfx_geoposition_set_error_code(cef_geoposition_t *self, cef_geoposition_error_code_t error_code) {
    self->error_code = error_code;
}
static void cfx_geoposition_get_error_code(cef_geoposition_t *self, cef_geoposition_error_code_t* error_code) {
    *error_code = self->error_code;
}

// cef_geoposition_t->error_message
static void cfx_geoposition_set_error_message(cef_geoposition_t *self, char16 *error_message_str, int error_message_length) {
    cef_string_utf16_set(error_message_str, error_message_length, &(self->error_message), 1);
}
static void cfx_geoposition_get_error_message(cef_geoposition_t *self, char16 **error_message_str, int *error_message_length) {
    *error_message_str = self->error_message.str;
    *error_message_length = (int)self->error_message.length;
}


