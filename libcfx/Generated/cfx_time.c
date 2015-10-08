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


// cef_time

static cef_time_t* cfx_time_ctor() {
    return (cef_time_t*)calloc(1, sizeof(cef_time_t));
}

static void cfx_time_dtor(cef_time_t* self) {
    free(self);
}

// cef_time_t->year
static void cfx_time_set_year(cef_time_t *self, int year) {
    self->year = year;
}
static void cfx_time_get_year(cef_time_t *self, int* year) {
    *year = self->year;
}

// cef_time_t->month
static void cfx_time_set_month(cef_time_t *self, int month) {
    self->month = month;
}
static void cfx_time_get_month(cef_time_t *self, int* month) {
    *month = self->month;
}

// cef_time_t->day_of_week
static void cfx_time_set_day_of_week(cef_time_t *self, int day_of_week) {
    self->day_of_week = day_of_week;
}
static void cfx_time_get_day_of_week(cef_time_t *self, int* day_of_week) {
    *day_of_week = self->day_of_week;
}

// cef_time_t->day_of_month
static void cfx_time_set_day_of_month(cef_time_t *self, int day_of_month) {
    self->day_of_month = day_of_month;
}
static void cfx_time_get_day_of_month(cef_time_t *self, int* day_of_month) {
    *day_of_month = self->day_of_month;
}

// cef_time_t->hour
static void cfx_time_set_hour(cef_time_t *self, int hour) {
    self->hour = hour;
}
static void cfx_time_get_hour(cef_time_t *self, int* hour) {
    *hour = self->hour;
}

// cef_time_t->minute
static void cfx_time_set_minute(cef_time_t *self, int minute) {
    self->minute = minute;
}
static void cfx_time_get_minute(cef_time_t *self, int* minute) {
    *minute = self->minute;
}

// cef_time_t->second
static void cfx_time_set_second(cef_time_t *self, int second) {
    self->second = second;
}
static void cfx_time_get_second(cef_time_t *self, int* second) {
    *second = self->second;
}

// cef_time_t->millisecond
static void cfx_time_set_millisecond(cef_time_t *self, int millisecond) {
    self->millisecond = millisecond;
}
static void cfx_time_get_millisecond(cef_time_t *self, int* millisecond) {
    *millisecond = self->millisecond;
}


