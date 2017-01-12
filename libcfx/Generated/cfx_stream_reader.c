// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_stream_reader

// CEF_EXPORT cef_stream_reader_t* cef_stream_reader_create_for_file(const cef_string_t* fileName);
static cef_stream_reader_t* cfx_stream_reader_create_for_file(char16 *fileName_str, int fileName_length) {
    cef_string_t fileName = { fileName_str, fileName_length, 0 };
    return cef_stream_reader_create_for_file(&fileName);
}
// CEF_EXPORT cef_stream_reader_t* cef_stream_reader_create_for_data(void* data, size_t size);
static cef_stream_reader_t* cfx_stream_reader_create_for_data(void* data, size_t size) {
    return cef_stream_reader_create_for_data(data, size);
}
// CEF_EXPORT cef_stream_reader_t* cef_stream_reader_create_for_handler(cef_read_handler_t* handler);
static cef_stream_reader_t* cfx_stream_reader_create_for_handler(cef_read_handler_t* handler) {
    if(handler) ((cef_base_t*)handler)->add_ref((cef_base_t*)handler);
    return cef_stream_reader_create_for_handler(handler);
}
// read
static size_t cfx_stream_reader_read(cef_stream_reader_t* self, void* ptr, size_t size, size_t n) {
    return self->read(self, ptr, size, n);
}

// seek
static int cfx_stream_reader_seek(cef_stream_reader_t* self, int64 offset, int whence) {
    return self->seek(self, offset, whence);
}

// tell
static int64 cfx_stream_reader_tell(cef_stream_reader_t* self) {
    return self->tell(self);
}

// eof
static int cfx_stream_reader_eof(cef_stream_reader_t* self) {
    return self->eof(self);
}

// may_block
static int cfx_stream_reader_may_block(cef_stream_reader_t* self) {
    return self->may_block(self);
}


