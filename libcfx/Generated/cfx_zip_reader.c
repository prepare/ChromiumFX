// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_zip_reader

// CEF_EXPORT cef_zip_reader_t* cef_zip_reader_create(cef_stream_reader_t* stream);
static cef_zip_reader_t* cfx_zip_reader_create(cef_stream_reader_t* stream) {
    if(stream) ((cef_base_t*)stream)->add_ref((cef_base_t*)stream);
    return cef_zip_reader_create(stream);
}
// move_to_first_file
static int cfx_zip_reader_move_to_first_file(cef_zip_reader_t* self) {
    return self->move_to_first_file(self);
}

// move_to_next_file
static int cfx_zip_reader_move_to_next_file(cef_zip_reader_t* self) {
    return self->move_to_next_file(self);
}

// move_to_file
static int cfx_zip_reader_move_to_file(cef_zip_reader_t* self, char16 *fileName_str, int fileName_length, int caseSensitive) {
    cef_string_t fileName = { fileName_str, fileName_length, 0 };
    return self->move_to_file(self, &fileName, caseSensitive);
}

// close
static int cfx_zip_reader_close(cef_zip_reader_t* self) {
    return self->close(self);
}

// get_file_name
static cef_string_userfree_t cfx_zip_reader_get_file_name(cef_zip_reader_t* self) {
    return self->get_file_name(self);
}

// get_file_size
static int64 cfx_zip_reader_get_file_size(cef_zip_reader_t* self) {
    return self->get_file_size(self);
}

// get_file_last_modified
static cef_time_t* cfx_zip_reader_get_file_last_modified(cef_zip_reader_t* self) {
    cef_time_t __retval_tmp = self->get_file_last_modified(self);
    return (cef_time_t*)cfx_copy_structure(&__retval_tmp, sizeof(cef_time_t));
}

// open_file
static int cfx_zip_reader_open_file(cef_zip_reader_t* self, char16 *password_str, int password_length) {
    cef_string_t password = { password_str, password_length, 0 };
    return self->open_file(self, &password);
}

// close_file
static int cfx_zip_reader_close_file(cef_zip_reader_t* self) {
    return self->close_file(self);
}

// read_file
static int cfx_zip_reader_read_file(cef_zip_reader_t* self, void* buffer, size_t bufferSize) {
    return self->read_file(self, buffer, bufferSize);
}

// tell
static int64 cfx_zip_reader_tell(cef_zip_reader_t* self) {
    return self->tell(self);
}

// eof
static int cfx_zip_reader_eof(cef_zip_reader_t* self) {
    return self->eof(self);
}


