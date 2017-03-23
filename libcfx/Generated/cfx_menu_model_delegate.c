// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_menu_model_delegate

typedef struct _cfx_menu_model_delegate_t {
    cef_menu_model_delegate_t cef_menu_model_delegate;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *execute_command)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release, int command_id, cef_event_flags_t event_flags);
    void (CEF_CALLBACK *mouse_outside_menu)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release, const cef_point_t* screen_point);
    void (CEF_CALLBACK *unhandled_open_submenu)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release, int is_rtl);
    void (CEF_CALLBACK *unhandled_close_submenu)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release, int is_rtl);
    void (CEF_CALLBACK *menu_will_show)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release);
    void (CEF_CALLBACK *menu_closed)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release);
    void (CEF_CALLBACK *format_label)(gc_handle_t self, int* __retval, cef_menu_model_t* menu_model, int *menu_model_release, char16 **label_str, int *label_length);
} cfx_menu_model_delegate_t;

void CEF_CALLBACK _cfx_menu_model_delegate_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_menu_model_delegate_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_menu_model_delegate_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_menu_model_delegate_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_menu_model_delegate_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_menu_model_delegate_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_menu_model_delegate_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_menu_model_delegate_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_menu_model_delegate_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_menu_model_delegate_t* cfx_menu_model_delegate_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_menu_model_delegate_t* ptr = (cfx_menu_model_delegate_t*)calloc(1, sizeof(cfx_menu_model_delegate_t));
    if(!ptr) return 0;
    ptr->cef_menu_model_delegate.base.size = sizeof(cef_menu_model_delegate_t);
    ptr->cef_menu_model_delegate.base.add_ref = _cfx_menu_model_delegate_add_ref;
    ptr->cef_menu_model_delegate.base.release = _cfx_menu_model_delegate_release;
    ptr->cef_menu_model_delegate.base.has_one_ref = _cfx_menu_model_delegate_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_menu_model_delegate_get_gc_handle(cfx_menu_model_delegate_t* self) {
    return self->gc_handle;
}

// execute_command

void CEF_CALLBACK cfx_menu_model_delegate_execute_command(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int command_id, cef_event_flags_t event_flags) {
    int menu_model_release;
    ((cfx_menu_model_delegate_t*)self)->execute_command(((cfx_menu_model_delegate_t*)self)->gc_handle, menu_model, &menu_model_release, command_id, event_flags);
    if(menu_model_release) menu_model->base.release((cef_base_t*)menu_model);
}

// mouse_outside_menu

void CEF_CALLBACK cfx_menu_model_delegate_mouse_outside_menu(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, const cef_point_t* screen_point) {
    int menu_model_release;
    ((cfx_menu_model_delegate_t*)self)->mouse_outside_menu(((cfx_menu_model_delegate_t*)self)->gc_handle, menu_model, &menu_model_release, screen_point);
    if(menu_model_release) menu_model->base.release((cef_base_t*)menu_model);
}

// unhandled_open_submenu

void CEF_CALLBACK cfx_menu_model_delegate_unhandled_open_submenu(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int is_rtl) {
    int menu_model_release;
    ((cfx_menu_model_delegate_t*)self)->unhandled_open_submenu(((cfx_menu_model_delegate_t*)self)->gc_handle, menu_model, &menu_model_release, is_rtl);
    if(menu_model_release) menu_model->base.release((cef_base_t*)menu_model);
}

// unhandled_close_submenu

void CEF_CALLBACK cfx_menu_model_delegate_unhandled_close_submenu(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int is_rtl) {
    int menu_model_release;
    ((cfx_menu_model_delegate_t*)self)->unhandled_close_submenu(((cfx_menu_model_delegate_t*)self)->gc_handle, menu_model, &menu_model_release, is_rtl);
    if(menu_model_release) menu_model->base.release((cef_base_t*)menu_model);
}

// menu_will_show

void CEF_CALLBACK cfx_menu_model_delegate_menu_will_show(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model) {
    int menu_model_release;
    ((cfx_menu_model_delegate_t*)self)->menu_will_show(((cfx_menu_model_delegate_t*)self)->gc_handle, menu_model, &menu_model_release);
    if(menu_model_release) menu_model->base.release((cef_base_t*)menu_model);
}

// menu_closed

void CEF_CALLBACK cfx_menu_model_delegate_menu_closed(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model) {
    int menu_model_release;
    ((cfx_menu_model_delegate_t*)self)->menu_closed(((cfx_menu_model_delegate_t*)self)->gc_handle, menu_model, &menu_model_release);
    if(menu_model_release) menu_model->base.release((cef_base_t*)menu_model);
}

// format_label

int CEF_CALLBACK cfx_menu_model_delegate_format_label(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, cef_string_t* label) {
    int __retval;
    int menu_model_release;
    char16* label_tmp_str = label->str; int label_tmp_length = (int)label->length;
    ((cfx_menu_model_delegate_t*)self)->format_label(((cfx_menu_model_delegate_t*)self)->gc_handle, &__retval, menu_model, &menu_model_release, &(label_tmp_str), &(label_tmp_length));
    if(menu_model_release) menu_model->base.release((cef_base_t*)menu_model);
    if(label_tmp_str != label->str) {
        if(label->dtor) label->dtor(label->str);
        cef_string_set(label_tmp_str, label_tmp_length, label, 1);
        cfx_gc_handle_free((gc_handle_t)label_tmp_str);
    }
    return __retval;
}

static void cfx_menu_model_delegate_set_callback(cef_menu_model_delegate_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_menu_model_delegate_t*)self)->execute_command = (void (CEF_CALLBACK *)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release, int command_id, cef_event_flags_t event_flags))callback;
        self->execute_command = callback ? cfx_menu_model_delegate_execute_command : 0;
        break;
    case 1:
        ((cfx_menu_model_delegate_t*)self)->mouse_outside_menu = (void (CEF_CALLBACK *)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release, const cef_point_t* screen_point))callback;
        self->mouse_outside_menu = callback ? cfx_menu_model_delegate_mouse_outside_menu : 0;
        break;
    case 2:
        ((cfx_menu_model_delegate_t*)self)->unhandled_open_submenu = (void (CEF_CALLBACK *)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release, int is_rtl))callback;
        self->unhandled_open_submenu = callback ? cfx_menu_model_delegate_unhandled_open_submenu : 0;
        break;
    case 3:
        ((cfx_menu_model_delegate_t*)self)->unhandled_close_submenu = (void (CEF_CALLBACK *)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release, int is_rtl))callback;
        self->unhandled_close_submenu = callback ? cfx_menu_model_delegate_unhandled_close_submenu : 0;
        break;
    case 4:
        ((cfx_menu_model_delegate_t*)self)->menu_will_show = (void (CEF_CALLBACK *)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release))callback;
        self->menu_will_show = callback ? cfx_menu_model_delegate_menu_will_show : 0;
        break;
    case 5:
        ((cfx_menu_model_delegate_t*)self)->menu_closed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_menu_model_t* menu_model, int *menu_model_release))callback;
        self->menu_closed = callback ? cfx_menu_model_delegate_menu_closed : 0;
        break;
    case 6:
        ((cfx_menu_model_delegate_t*)self)->format_label = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_menu_model_t* menu_model, int *menu_model_release, char16 **label_str, int *label_length))callback;
        self->format_label = callback ? cfx_menu_model_delegate_format_label : 0;
        break;
    }
}

