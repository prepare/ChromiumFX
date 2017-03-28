// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_print_handler

typedef struct _cfx_print_handler_t {
    cef_print_handler_t cef_print_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_print_start)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
    void (CEF_CALLBACK *on_print_settings)(gc_handle_t self, cef_print_settings_t* settings, int *settings_release, int get_defaults);
    void (CEF_CALLBACK *on_print_dialog)(gc_handle_t self, int* __retval, int has_selection, cef_print_dialog_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_print_job)(gc_handle_t self, int* __retval, char16 *document_name_str, int document_name_length, char16 *pdf_file_path_str, int pdf_file_path_length, cef_print_job_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_print_reset)(gc_handle_t self);
    void (CEF_CALLBACK *get_pdf_paper_size)(gc_handle_t self, cef_size_t** __retval, gc_handle_t *__retval_handle, int device_units_per_inch);
} cfx_print_handler_t;

void CEF_CALLBACK _cfx_print_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_print_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_print_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_print_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_print_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_print_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_print_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_print_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_print_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_print_handler_t* cfx_print_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_print_handler_t* ptr = (cfx_print_handler_t*)calloc(1, sizeof(cfx_print_handler_t));
    if(!ptr) return 0;
    ptr->cef_print_handler.base.size = sizeof(cef_print_handler_t);
    ptr->cef_print_handler.base.add_ref = _cfx_print_handler_add_ref;
    ptr->cef_print_handler.base.release = _cfx_print_handler_release;
    ptr->cef_print_handler.base.has_one_ref = _cfx_print_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_print_start

void CEF_CALLBACK cfx_print_handler_on_print_start(cef_print_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_print_handler_t*)self)->on_print_start(((cfx_print_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

// on_print_settings

void CEF_CALLBACK cfx_print_handler_on_print_settings(cef_print_handler_t* self, cef_print_settings_t* settings, int get_defaults) {
    int settings_release;
    ((cfx_print_handler_t*)self)->on_print_settings(((cfx_print_handler_t*)self)->gc_handle, settings, &settings_release, get_defaults);
    if(settings_release) settings->base.release((cef_base_ref_counted_t*)settings);
}

// on_print_dialog

int CEF_CALLBACK cfx_print_handler_on_print_dialog(cef_print_handler_t* self, int has_selection, cef_print_dialog_callback_t* callback) {
    int __retval;
    int callback_release;
    ((cfx_print_handler_t*)self)->on_print_dialog(((cfx_print_handler_t*)self)->gc_handle, &__retval, has_selection, callback, &callback_release);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_print_job

int CEF_CALLBACK cfx_print_handler_on_print_job(cef_print_handler_t* self, const cef_string_t* document_name, const cef_string_t* pdf_file_path, cef_print_job_callback_t* callback) {
    int __retval;
    int callback_release;
    ((cfx_print_handler_t*)self)->on_print_job(((cfx_print_handler_t*)self)->gc_handle, &__retval, document_name ? document_name->str : 0, document_name ? (int)document_name->length : 0, pdf_file_path ? pdf_file_path->str : 0, pdf_file_path ? (int)pdf_file_path->length : 0, callback, &callback_release);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_print_reset

void CEF_CALLBACK cfx_print_handler_on_print_reset(cef_print_handler_t* self) {
    ((cfx_print_handler_t*)self)->on_print_reset(((cfx_print_handler_t*)self)->gc_handle);
}

// get_pdf_paper_size

cef_size_t CEF_CALLBACK cfx_print_handler_get_pdf_paper_size(cef_print_handler_t* self, int device_units_per_inch) {
    cef_size_t* __retval;
    gc_handle_t __retval_handle;
    ((cfx_print_handler_t*)self)->get_pdf_paper_size(((cfx_print_handler_t*)self)->gc_handle, &__retval, &__retval_handle, device_units_per_inch);
    cef_size_t __retval_value = {0};
    if(__retval) __retval_value = *__retval;
    if(__retval_handle) cfx_gc_handle_switch(&__retval_handle, GC_HANDLE_FREE);
    return __retval_value;
}

static void cfx_print_handler_set_callback(cef_print_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_print_handler_t*)self)->on_print_start = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_print_start = callback ? cfx_print_handler_on_print_start : 0;
        break;
    case 1:
        ((cfx_print_handler_t*)self)->on_print_settings = (void (CEF_CALLBACK *)(gc_handle_t self, cef_print_settings_t* settings, int *settings_release, int get_defaults))callback;
        self->on_print_settings = callback ? cfx_print_handler_on_print_settings : 0;
        break;
    case 2:
        ((cfx_print_handler_t*)self)->on_print_dialog = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int has_selection, cef_print_dialog_callback_t* callback, int *callback_release))callback;
        self->on_print_dialog = callback ? cfx_print_handler_on_print_dialog : 0;
        break;
    case 3:
        ((cfx_print_handler_t*)self)->on_print_job = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, char16 *document_name_str, int document_name_length, char16 *pdf_file_path_str, int pdf_file_path_length, cef_print_job_callback_t* callback, int *callback_release))callback;
        self->on_print_job = callback ? cfx_print_handler_on_print_job : 0;
        break;
    case 4:
        ((cfx_print_handler_t*)self)->on_print_reset = (void (CEF_CALLBACK *)(gc_handle_t self))callback;
        self->on_print_reset = callback ? cfx_print_handler_on_print_reset : 0;
        break;
    case 5:
        ((cfx_print_handler_t*)self)->get_pdf_paper_size = (void (CEF_CALLBACK *)(gc_handle_t self, cef_size_t** __retval, gc_handle_t *__retval_handle, int device_units_per_inch))callback;
        self->get_pdf_paper_size = callback ? cfx_print_handler_get_pdf_paper_size : 0;
        break;
    }
}

