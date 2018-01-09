// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_server_handler

typedef struct _cfx_server_handler_t {
    cef_server_handler_t cef_server_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_server_created)(gc_handle_t self, cef_server_t* server, int *server_release);
    void (CEF_CALLBACK *on_server_destroyed)(gc_handle_t self, cef_server_t* server, int *server_release);
    void (CEF_CALLBACK *on_client_connected)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id);
    void (CEF_CALLBACK *on_client_disconnected)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id);
    void (CEF_CALLBACK *on_http_request)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id, char16 *client_address_str, int client_address_length, cef_request_t* request, int *request_release);
    void (CEF_CALLBACK *on_web_socket_request)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id, char16 *client_address_str, int client_address_length, cef_request_t* request, int *request_release, cef_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_web_socket_connected)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id);
    void (CEF_CALLBACK *on_web_socket_message)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id, const void* data, size_t data_size);
} cfx_server_handler_t;

void CEF_CALLBACK _cfx_server_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_server_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_server_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_server_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_server_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_server_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_server_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_server_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_server_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_server_handler_t* cfx_server_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_server_handler_t* ptr = (cfx_server_handler_t*)calloc(1, sizeof(cfx_server_handler_t));
    if(!ptr) return 0;
    ptr->cef_server_handler.base.size = sizeof(cef_server_handler_t);
    ptr->cef_server_handler.base.add_ref = _cfx_server_handler_add_ref;
    ptr->cef_server_handler.base.release = _cfx_server_handler_release;
    ptr->cef_server_handler.base.has_one_ref = _cfx_server_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_server_created

void CEF_CALLBACK cfx_server_handler_on_server_created(cef_server_handler_t* self, cef_server_t* server) {
    int server_release;
    ((cfx_server_handler_t*)self)->on_server_created(((cfx_server_handler_t*)self)->gc_handle, server, &server_release);
    if(server_release && server) server->base.release((cef_base_ref_counted_t*)server);
}

// on_server_destroyed

void CEF_CALLBACK cfx_server_handler_on_server_destroyed(cef_server_handler_t* self, cef_server_t* server) {
    int server_release;
    ((cfx_server_handler_t*)self)->on_server_destroyed(((cfx_server_handler_t*)self)->gc_handle, server, &server_release);
    if(server_release && server) server->base.release((cef_base_ref_counted_t*)server);
}

// on_client_connected

void CEF_CALLBACK cfx_server_handler_on_client_connected(cef_server_handler_t* self, cef_server_t* server, int connection_id) {
    int server_release;
    ((cfx_server_handler_t*)self)->on_client_connected(((cfx_server_handler_t*)self)->gc_handle, server, &server_release, connection_id);
    if(server_release && server) server->base.release((cef_base_ref_counted_t*)server);
}

// on_client_disconnected

void CEF_CALLBACK cfx_server_handler_on_client_disconnected(cef_server_handler_t* self, cef_server_t* server, int connection_id) {
    int server_release;
    ((cfx_server_handler_t*)self)->on_client_disconnected(((cfx_server_handler_t*)self)->gc_handle, server, &server_release, connection_id);
    if(server_release && server) server->base.release((cef_base_ref_counted_t*)server);
}

// on_http_request

void CEF_CALLBACK cfx_server_handler_on_http_request(cef_server_handler_t* self, cef_server_t* server, int connection_id, const cef_string_t* client_address, cef_request_t* request) {
    int server_release;
    int request_release;
    ((cfx_server_handler_t*)self)->on_http_request(((cfx_server_handler_t*)self)->gc_handle, server, &server_release, connection_id, client_address ? client_address->str : 0, client_address ? (int)client_address->length : 0, request, &request_release);
    if(server_release && server) server->base.release((cef_base_ref_counted_t*)server);
    if(request_release && request) request->base.release((cef_base_ref_counted_t*)request);
}

// on_web_socket_request

void CEF_CALLBACK cfx_server_handler_on_web_socket_request(cef_server_handler_t* self, cef_server_t* server, int connection_id, const cef_string_t* client_address, cef_request_t* request, cef_callback_t* callback) {
    int server_release;
    int request_release;
    int callback_release;
    ((cfx_server_handler_t*)self)->on_web_socket_request(((cfx_server_handler_t*)self)->gc_handle, server, &server_release, connection_id, client_address ? client_address->str : 0, client_address ? (int)client_address->length : 0, request, &request_release, callback, &callback_release);
    if(server_release && server) server->base.release((cef_base_ref_counted_t*)server);
    if(request_release && request) request->base.release((cef_base_ref_counted_t*)request);
    if(callback_release && callback) callback->base.release((cef_base_ref_counted_t*)callback);
}

// on_web_socket_connected

void CEF_CALLBACK cfx_server_handler_on_web_socket_connected(cef_server_handler_t* self, cef_server_t* server, int connection_id) {
    int server_release;
    ((cfx_server_handler_t*)self)->on_web_socket_connected(((cfx_server_handler_t*)self)->gc_handle, server, &server_release, connection_id);
    if(server_release && server) server->base.release((cef_base_ref_counted_t*)server);
}

// on_web_socket_message

void CEF_CALLBACK cfx_server_handler_on_web_socket_message(cef_server_handler_t* self, cef_server_t* server, int connection_id, const void* data, size_t data_size) {
    int server_release;
    ((cfx_server_handler_t*)self)->on_web_socket_message(((cfx_server_handler_t*)self)->gc_handle, server, &server_release, connection_id, data, data_size);
    if(server_release && server) server->base.release((cef_base_ref_counted_t*)server);
}

static void cfx_server_handler_set_callback(cef_server_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_server_handler_t*)self)->on_server_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_server_t* server, int *server_release))callback;
        self->on_server_created = callback ? cfx_server_handler_on_server_created : 0;
        break;
    case 1:
        ((cfx_server_handler_t*)self)->on_server_destroyed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_server_t* server, int *server_release))callback;
        self->on_server_destroyed = callback ? cfx_server_handler_on_server_destroyed : 0;
        break;
    case 2:
        ((cfx_server_handler_t*)self)->on_client_connected = (void (CEF_CALLBACK *)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id))callback;
        self->on_client_connected = callback ? cfx_server_handler_on_client_connected : 0;
        break;
    case 3:
        ((cfx_server_handler_t*)self)->on_client_disconnected = (void (CEF_CALLBACK *)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id))callback;
        self->on_client_disconnected = callback ? cfx_server_handler_on_client_disconnected : 0;
        break;
    case 4:
        ((cfx_server_handler_t*)self)->on_http_request = (void (CEF_CALLBACK *)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id, char16 *client_address_str, int client_address_length, cef_request_t* request, int *request_release))callback;
        self->on_http_request = callback ? cfx_server_handler_on_http_request : 0;
        break;
    case 5:
        ((cfx_server_handler_t*)self)->on_web_socket_request = (void (CEF_CALLBACK *)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id, char16 *client_address_str, int client_address_length, cef_request_t* request, int *request_release, cef_callback_t* callback, int *callback_release))callback;
        self->on_web_socket_request = callback ? cfx_server_handler_on_web_socket_request : 0;
        break;
    case 6:
        ((cfx_server_handler_t*)self)->on_web_socket_connected = (void (CEF_CALLBACK *)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id))callback;
        self->on_web_socket_connected = callback ? cfx_server_handler_on_web_socket_connected : 0;
        break;
    case 7:
        ((cfx_server_handler_t*)self)->on_web_socket_message = (void (CEF_CALLBACK *)(gc_handle_t self, cef_server_t* server, int *server_release, int connection_id, const void* data, size_t data_size))callback;
        self->on_web_socket_message = callback ? cfx_server_handler_on_web_socket_message : 0;
        break;
    }
}

