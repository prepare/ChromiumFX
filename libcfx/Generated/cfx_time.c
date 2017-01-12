// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


