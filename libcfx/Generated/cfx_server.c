// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_server

// CEF_EXPORT void cef_server_create(const cef_string_t* address, uint16 port, int backlog, cef_server_handler_t* handler);
static void cfx_server_create(char16 *address_str, int address_length, uint16 port, int backlog, cef_server_handler_t* handler) {
    cef_string_t address = { address_str, address_length, 0 };
    if(handler) ((cef_base_ref_counted_t*)handler)->add_ref((cef_base_ref_counted_t*)handler);
    cef_server_create(&address, port, backlog, handler);
}
// get_task_runner
static cef_task_runner_t* cfx_server_get_task_runner(cef_server_t* self) {
    return self->get_task_runner(self);
}

// shutdown
static void cfx_server_shutdown(cef_server_t* self) {
    self->shutdown(self);
}

// is_running
static int cfx_server_is_running(cef_server_t* self) {
    return self->is_running(self);
}

// get_address
static cef_string_userfree_t cfx_server_get_address(cef_server_t* self) {
    return self->get_address(self);
}

// has_connection
static int cfx_server_has_connection(cef_server_t* self) {
    return self->has_connection(self);
}

// is_valid_connection
static int cfx_server_is_valid_connection(cef_server_t* self, int connection_id) {
    return self->is_valid_connection(self, connection_id);
}

// send_http200response
static void cfx_server_send_http200response(cef_server_t* self, int connection_id, char16 *content_type_str, int content_type_length, const void* data, size_t data_size) {
    cef_string_t content_type = { content_type_str, content_type_length, 0 };
    self->send_http200response(self, connection_id, &content_type, data, data_size);
}

// send_http404response
static void cfx_server_send_http404response(cef_server_t* self, int connection_id) {
    self->send_http404response(self, connection_id);
}

// send_http500response
static void cfx_server_send_http500response(cef_server_t* self, int connection_id, char16 *error_message_str, int error_message_length) {
    cef_string_t error_message = { error_message_str, error_message_length, 0 };
    self->send_http500response(self, connection_id, &error_message);
}

// send_http_response
static void cfx_server_send_http_response(cef_server_t* self, int connection_id, int response_code, char16 *content_type_str, int content_type_length, int64 content_length, cef_string_multimap_t extra_headers) {
    cef_string_t content_type = { content_type_str, content_type_length, 0 };
    self->send_http_response(self, connection_id, response_code, &content_type, content_length, extra_headers);
}

// send_raw_data
static void cfx_server_send_raw_data(cef_server_t* self, int connection_id, const void* data, size_t data_size) {
    self->send_raw_data(self, connection_id, data, data_size);
}

// close_connection
static void cfx_server_close_connection(cef_server_t* self, int connection_id) {
    self->close_connection(self, connection_id);
}

// send_web_socket_message
static void cfx_server_send_web_socket_message(cef_server_t* self, int connection_id, const void* data, size_t data_size) {
    self->send_web_socket_message(self, connection_id, data, data_size);
}


