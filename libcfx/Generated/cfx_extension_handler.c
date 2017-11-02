// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_extension_handler

typedef struct _cfx_extension_handler_t {
    cef_extension_handler_t cef_extension_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_extension_load_failed)(gc_handle_t self, cef_errorcode_t result);
    void (CEF_CALLBACK *on_extension_loaded)(gc_handle_t self, cef_extension_t* extension, int *extension_release);
    void (CEF_CALLBACK *on_extension_unloaded)(gc_handle_t self, cef_extension_t* extension, int *extension_release);
    void (CEF_CALLBACK *on_before_background_browser)(gc_handle_t self, int* __retval, cef_extension_t* extension, int *extension_release, char16 *url_str, int url_length, cef_client_t** client, cef_browser_settings_t* settings);
    void (CEF_CALLBACK *on_before_browser)(gc_handle_t self, int* __retval, cef_extension_t* extension, int *extension_release, cef_browser_t* browser, int *browser_release, cef_browser_t* active_browser, int *active_browser_release, int index, char16 *url_str, int url_length, int active, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings);
    void (CEF_CALLBACK *get_active_browser)(gc_handle_t self, cef_browser_t** __retval, cef_extension_t* extension, int *extension_release, cef_browser_t* browser, int *browser_release, int include_incognito);
    void (CEF_CALLBACK *can_access_browser)(gc_handle_t self, int* __retval, cef_extension_t* extension, int *extension_release, cef_browser_t* browser, int *browser_release, int include_incognito, cef_browser_t* target_browser, int *target_browser_release);
    void (CEF_CALLBACK *get_extension_resource)(gc_handle_t self, int* __retval, cef_extension_t* extension, int *extension_release, cef_browser_t* browser, int *browser_release, char16 *file_str, int file_length, cef_get_extension_resource_callback_t* callback, int *callback_release);
} cfx_extension_handler_t;

void CEF_CALLBACK _cfx_extension_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_extension_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_extension_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_extension_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_extension_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_extension_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_extension_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_extension_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_extension_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_extension_handler_t* cfx_extension_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_extension_handler_t* ptr = (cfx_extension_handler_t*)calloc(1, sizeof(cfx_extension_handler_t));
    if(!ptr) return 0;
    ptr->cef_extension_handler.base.size = sizeof(cef_extension_handler_t);
    ptr->cef_extension_handler.base.add_ref = _cfx_extension_handler_add_ref;
    ptr->cef_extension_handler.base.release = _cfx_extension_handler_release;
    ptr->cef_extension_handler.base.has_one_ref = _cfx_extension_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_extension_handler_get_gc_handle(cfx_extension_handler_t* self) {
    return self->gc_handle;
}

// on_extension_load_failed

void CEF_CALLBACK cfx_extension_handler_on_extension_load_failed(cef_extension_handler_t* self, cef_errorcode_t result) {
    ((cfx_extension_handler_t*)self)->on_extension_load_failed(((cfx_extension_handler_t*)self)->gc_handle, result);
}

// on_extension_loaded

void CEF_CALLBACK cfx_extension_handler_on_extension_loaded(cef_extension_handler_t* self, cef_extension_t* extension) {
    int extension_release;
    ((cfx_extension_handler_t*)self)->on_extension_loaded(((cfx_extension_handler_t*)self)->gc_handle, extension, &extension_release);
    if(extension_release && extension) extension->base.release((cef_base_ref_counted_t*)extension);
}

// on_extension_unloaded

void CEF_CALLBACK cfx_extension_handler_on_extension_unloaded(cef_extension_handler_t* self, cef_extension_t* extension) {
    int extension_release;
    ((cfx_extension_handler_t*)self)->on_extension_unloaded(((cfx_extension_handler_t*)self)->gc_handle, extension, &extension_release);
    if(extension_release && extension) extension->base.release((cef_base_ref_counted_t*)extension);
}

// on_before_background_browser

int CEF_CALLBACK cfx_extension_handler_on_before_background_browser(cef_extension_handler_t* self, cef_extension_t* extension, const cef_string_t* url, cef_client_t** client, cef_browser_settings_t* settings) {
    int __retval;
    int extension_release;
    ((cfx_extension_handler_t*)self)->on_before_background_browser(((cfx_extension_handler_t*)self)->gc_handle, &__retval, extension, &extension_release, url ? url->str : 0, url ? (int)url->length : 0, client, settings);
    if(extension_release && extension) extension->base.release((cef_base_ref_counted_t*)extension);
    if(*client)((cef_base_ref_counted_t*)*client)->add_ref((cef_base_ref_counted_t*)*client);
    return __retval;
}

// on_before_browser

int CEF_CALLBACK cfx_extension_handler_on_before_browser(cef_extension_handler_t* self, cef_extension_t* extension, cef_browser_t* browser, cef_browser_t* active_browser, int index, const cef_string_t* url, int active, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings) {
    int __retval;
    int extension_release;
    int browser_release;
    int active_browser_release;
    ((cfx_extension_handler_t*)self)->on_before_browser(((cfx_extension_handler_t*)self)->gc_handle, &__retval, extension, &extension_release, browser, &browser_release, active_browser, &active_browser_release, index, url ? url->str : 0, url ? (int)url->length : 0, active, windowInfo, client, settings);
    if(extension_release && extension) extension->base.release((cef_base_ref_counted_t*)extension);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(active_browser_release && active_browser) active_browser->base.release((cef_base_ref_counted_t*)active_browser);
    if(*client)((cef_base_ref_counted_t*)*client)->add_ref((cef_base_ref_counted_t*)*client);
    return __retval;
}

// get_active_browser

cef_browser_t* CEF_CALLBACK cfx_extension_handler_get_active_browser(cef_extension_handler_t* self, cef_extension_t* extension, cef_browser_t* browser, int include_incognito) {
    cef_browser_t* __retval;
    int extension_release;
    int browser_release;
    ((cfx_extension_handler_t*)self)->get_active_browser(((cfx_extension_handler_t*)self)->gc_handle, &__retval, extension, &extension_release, browser, &browser_release, include_incognito);
    if(extension_release && extension) extension->base.release((cef_base_ref_counted_t*)extension);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

// can_access_browser

int CEF_CALLBACK cfx_extension_handler_can_access_browser(cef_extension_handler_t* self, cef_extension_t* extension, cef_browser_t* browser, int include_incognito, cef_browser_t* target_browser) {
    int __retval;
    int extension_release;
    int browser_release;
    int target_browser_release;
    ((cfx_extension_handler_t*)self)->can_access_browser(((cfx_extension_handler_t*)self)->gc_handle, &__retval, extension, &extension_release, browser, &browser_release, include_incognito, target_browser, &target_browser_release);
    if(extension_release && extension) extension->base.release((cef_base_ref_counted_t*)extension);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(target_browser_release && target_browser) target_browser->base.release((cef_base_ref_counted_t*)target_browser);
    return __retval;
}

// get_extension_resource

int CEF_CALLBACK cfx_extension_handler_get_extension_resource(cef_extension_handler_t* self, cef_extension_t* extension, cef_browser_t* browser, const cef_string_t* file, cef_get_extension_resource_callback_t* callback) {
    int __retval;
    int extension_release;
    int browser_release;
    int callback_release;
    ((cfx_extension_handler_t*)self)->get_extension_resource(((cfx_extension_handler_t*)self)->gc_handle, &__retval, extension, &extension_release, browser, &browser_release, file ? file->str : 0, file ? (int)file->length : 0, callback, &callback_release);
    if(extension_release && extension) extension->base.release((cef_base_ref_counted_t*)extension);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(callback_release && callback) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

static void cfx_extension_handler_set_callback(cef_extension_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_extension_handler_t*)self)->on_extension_load_failed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_errorcode_t result))callback;
        self->on_extension_load_failed = callback ? cfx_extension_handler_on_extension_load_failed : 0;
        break;
    case 1:
        ((cfx_extension_handler_t*)self)->on_extension_loaded = (void (CEF_CALLBACK *)(gc_handle_t self, cef_extension_t* extension, int *extension_release))callback;
        self->on_extension_loaded = callback ? cfx_extension_handler_on_extension_loaded : 0;
        break;
    case 2:
        ((cfx_extension_handler_t*)self)->on_extension_unloaded = (void (CEF_CALLBACK *)(gc_handle_t self, cef_extension_t* extension, int *extension_release))callback;
        self->on_extension_unloaded = callback ? cfx_extension_handler_on_extension_unloaded : 0;
        break;
    case 3:
        ((cfx_extension_handler_t*)self)->on_before_background_browser = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_extension_t* extension, int *extension_release, char16 *url_str, int url_length, cef_client_t** client, cef_browser_settings_t* settings))callback;
        self->on_before_background_browser = callback ? cfx_extension_handler_on_before_background_browser : 0;
        break;
    case 4:
        ((cfx_extension_handler_t*)self)->on_before_browser = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_extension_t* extension, int *extension_release, cef_browser_t* browser, int *browser_release, cef_browser_t* active_browser, int *active_browser_release, int index, char16 *url_str, int url_length, int active, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings))callback;
        self->on_before_browser = callback ? cfx_extension_handler_on_before_browser : 0;
        break;
    case 5:
        ((cfx_extension_handler_t*)self)->get_active_browser = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t** __retval, cef_extension_t* extension, int *extension_release, cef_browser_t* browser, int *browser_release, int include_incognito))callback;
        self->get_active_browser = callback ? cfx_extension_handler_get_active_browser : 0;
        break;
    case 6:
        ((cfx_extension_handler_t*)self)->can_access_browser = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_extension_t* extension, int *extension_release, cef_browser_t* browser, int *browser_release, int include_incognito, cef_browser_t* target_browser, int *target_browser_release))callback;
        self->can_access_browser = callback ? cfx_extension_handler_can_access_browser : 0;
        break;
    case 7:
        ((cfx_extension_handler_t*)self)->get_extension_resource = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_extension_t* extension, int *extension_release, cef_browser_t* browser, int *browser_release, char16 *file_str, int file_length, cef_get_extension_resource_callback_t* callback, int *callback_release))callback;
        self->get_extension_resource = callback ? cfx_extension_handler_get_extension_resource : 0;
        break;
    }
}

