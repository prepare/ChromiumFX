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


// cef_register_cdm_callback

typedef struct _cfx_register_cdm_callback_t {
    cef_register_cdm_callback_t cef_register_cdm_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_register_cdm_callback_t;

void CEF_CALLBACK _cfx_register_cdm_callback_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_register_cdm_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_register_cdm_callback_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_register_cdm_callback_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_register_cdm_callback_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_register_cdm_callback_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_register_cdm_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_register_cdm_callback_t* cfx_register_cdm_callback_ctor(gc_handle_t gc_handle) {
    cfx_register_cdm_callback_t* ptr = (cfx_register_cdm_callback_t*)calloc(1, sizeof(cfx_register_cdm_callback_t));
    if(!ptr) return 0;
    ptr->cef_register_cdm_callback.base.size = sizeof(cef_register_cdm_callback_t);
    ptr->cef_register_cdm_callback.base.add_ref = _cfx_register_cdm_callback_add_ref;
    ptr->cef_register_cdm_callback.base.release = _cfx_register_cdm_callback_release;
    ptr->cef_register_cdm_callback.base.has_one_ref = _cfx_register_cdm_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_register_cdm_callback_get_gc_handle(cfx_register_cdm_callback_t* self) {
    return self->gc_handle;
}

// managed callbacks
void (CEF_CALLBACK *cfx_register_cdm_callback_on_cdm_registration_complete_callback)(gc_handle_t self, cef_cdm_registration_error_t result, char16 *error_message_str, int error_message_length);

static void cfx_register_cdm_callback_set_managed_callbacks(void *on_cdm_registration_complete) {
    cfx_register_cdm_callback_on_cdm_registration_complete_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_cdm_registration_error_t result, char16 *error_message_str, int error_message_length)) on_cdm_registration_complete;
}

// on_cdm_registration_complete

void CEF_CALLBACK cfx_register_cdm_callback_on_cdm_registration_complete(cef_register_cdm_callback_t* self, cef_cdm_registration_error_t result, const cef_string_t* error_message) {
    cfx_register_cdm_callback_on_cdm_registration_complete_callback(((cfx_register_cdm_callback_t*)self)->gc_handle, result, error_message ? error_message->str : 0, error_message ? (int)error_message->length : 0);
}


static void cfx_register_cdm_callback_activate_callback(cef_register_cdm_callback_t* self, int index, int active) {
    switch(index) {
    case 0:
        self->on_cdm_registration_complete = active ? cfx_register_cdm_callback_on_cdm_registration_complete : 0;
        break;
    }
}

