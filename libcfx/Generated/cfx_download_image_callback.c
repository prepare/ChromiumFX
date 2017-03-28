// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_download_image_callback

typedef struct _cfx_download_image_callback_t {
    cef_download_image_callback_t cef_download_image_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_download_image_finished)(gc_handle_t self, char16 *image_url_str, int image_url_length, int http_status_code, cef_image_t* image, int *image_release);
} cfx_download_image_callback_t;

void CEF_CALLBACK _cfx_download_image_callback_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_download_image_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_download_image_callback_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_download_image_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_download_image_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_download_image_callback_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_download_image_callback_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_download_image_callback_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_download_image_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_download_image_callback_t* cfx_download_image_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_download_image_callback_t* ptr = (cfx_download_image_callback_t*)calloc(1, sizeof(cfx_download_image_callback_t));
    if(!ptr) return 0;
    ptr->cef_download_image_callback.base.size = sizeof(cef_download_image_callback_t);
    ptr->cef_download_image_callback.base.add_ref = _cfx_download_image_callback_add_ref;
    ptr->cef_download_image_callback.base.release = _cfx_download_image_callback_release;
    ptr->cef_download_image_callback.base.has_one_ref = _cfx_download_image_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_download_image_finished

void CEF_CALLBACK cfx_download_image_callback_on_download_image_finished(cef_download_image_callback_t* self, const cef_string_t* image_url, int http_status_code, cef_image_t* image) {
    int image_release;
    ((cfx_download_image_callback_t*)self)->on_download_image_finished(((cfx_download_image_callback_t*)self)->gc_handle, image_url ? image_url->str : 0, image_url ? (int)image_url->length : 0, http_status_code, image, &image_release);
    if(image_release) image->base.release((cef_base_ref_counted_t*)image);
}

static void cfx_download_image_callback_set_callback(cef_download_image_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_download_image_callback_t*)self)->on_download_image_finished = (void (CEF_CALLBACK *)(gc_handle_t self, char16 *image_url_str, int image_url_length, int http_status_code, cef_image_t* image, int *image_release))callback;
        self->on_download_image_finished = callback ? cfx_download_image_callback_on_download_image_finished : 0;
        break;
    }
}

