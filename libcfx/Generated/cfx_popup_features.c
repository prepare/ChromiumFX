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


// cef_popup_features

#ifdef __cplusplus
extern "C" {
#endif

CFX_EXPORT cef_popup_features_t* cfx_popup_features_ctor() {
    return (cef_popup_features_t*)calloc(1, sizeof(cef_popup_features_t));
}

CFX_EXPORT void cfx_popup_features_dtor(cef_popup_features_t* self) {
    free(self);
}

// cef_popup_features_t->x
CFX_EXPORT void cfx_popup_features_set_x(cef_popup_features_t *self, int x) {
    self->x = x;
}
CFX_EXPORT void cfx_popup_features_get_x(cef_popup_features_t *self, int* x) {
    *x = self->x;
}

// cef_popup_features_t->xSet
CFX_EXPORT void cfx_popup_features_set_xSet(cef_popup_features_t *self, int xSet) {
    self->xSet = xSet;
}
CFX_EXPORT void cfx_popup_features_get_xSet(cef_popup_features_t *self, int* xSet) {
    *xSet = self->xSet;
}

// cef_popup_features_t->y
CFX_EXPORT void cfx_popup_features_set_y(cef_popup_features_t *self, int y) {
    self->y = y;
}
CFX_EXPORT void cfx_popup_features_get_y(cef_popup_features_t *self, int* y) {
    *y = self->y;
}

// cef_popup_features_t->ySet
CFX_EXPORT void cfx_popup_features_set_ySet(cef_popup_features_t *self, int ySet) {
    self->ySet = ySet;
}
CFX_EXPORT void cfx_popup_features_get_ySet(cef_popup_features_t *self, int* ySet) {
    *ySet = self->ySet;
}

// cef_popup_features_t->width
CFX_EXPORT void cfx_popup_features_set_width(cef_popup_features_t *self, int width) {
    self->width = width;
}
CFX_EXPORT void cfx_popup_features_get_width(cef_popup_features_t *self, int* width) {
    *width = self->width;
}

// cef_popup_features_t->widthSet
CFX_EXPORT void cfx_popup_features_set_widthSet(cef_popup_features_t *self, int widthSet) {
    self->widthSet = widthSet;
}
CFX_EXPORT void cfx_popup_features_get_widthSet(cef_popup_features_t *self, int* widthSet) {
    *widthSet = self->widthSet;
}

// cef_popup_features_t->height
CFX_EXPORT void cfx_popup_features_set_height(cef_popup_features_t *self, int height) {
    self->height = height;
}
CFX_EXPORT void cfx_popup_features_get_height(cef_popup_features_t *self, int* height) {
    *height = self->height;
}

// cef_popup_features_t->heightSet
CFX_EXPORT void cfx_popup_features_set_heightSet(cef_popup_features_t *self, int heightSet) {
    self->heightSet = heightSet;
}
CFX_EXPORT void cfx_popup_features_get_heightSet(cef_popup_features_t *self, int* heightSet) {
    *heightSet = self->heightSet;
}

// cef_popup_features_t->menuBarVisible
CFX_EXPORT void cfx_popup_features_set_menuBarVisible(cef_popup_features_t *self, int menuBarVisible) {
    self->menuBarVisible = menuBarVisible;
}
CFX_EXPORT void cfx_popup_features_get_menuBarVisible(cef_popup_features_t *self, int* menuBarVisible) {
    *menuBarVisible = self->menuBarVisible;
}

// cef_popup_features_t->statusBarVisible
CFX_EXPORT void cfx_popup_features_set_statusBarVisible(cef_popup_features_t *self, int statusBarVisible) {
    self->statusBarVisible = statusBarVisible;
}
CFX_EXPORT void cfx_popup_features_get_statusBarVisible(cef_popup_features_t *self, int* statusBarVisible) {
    *statusBarVisible = self->statusBarVisible;
}

// cef_popup_features_t->toolBarVisible
CFX_EXPORT void cfx_popup_features_set_toolBarVisible(cef_popup_features_t *self, int toolBarVisible) {
    self->toolBarVisible = toolBarVisible;
}
CFX_EXPORT void cfx_popup_features_get_toolBarVisible(cef_popup_features_t *self, int* toolBarVisible) {
    *toolBarVisible = self->toolBarVisible;
}

// cef_popup_features_t->locationBarVisible
CFX_EXPORT void cfx_popup_features_set_locationBarVisible(cef_popup_features_t *self, int locationBarVisible) {
    self->locationBarVisible = locationBarVisible;
}
CFX_EXPORT void cfx_popup_features_get_locationBarVisible(cef_popup_features_t *self, int* locationBarVisible) {
    *locationBarVisible = self->locationBarVisible;
}

// cef_popup_features_t->scrollbarsVisible
CFX_EXPORT void cfx_popup_features_set_scrollbarsVisible(cef_popup_features_t *self, int scrollbarsVisible) {
    self->scrollbarsVisible = scrollbarsVisible;
}
CFX_EXPORT void cfx_popup_features_get_scrollbarsVisible(cef_popup_features_t *self, int* scrollbarsVisible) {
    *scrollbarsVisible = self->scrollbarsVisible;
}

// cef_popup_features_t->resizable
CFX_EXPORT void cfx_popup_features_set_resizable(cef_popup_features_t *self, int resizable) {
    self->resizable = resizable;
}
CFX_EXPORT void cfx_popup_features_get_resizable(cef_popup_features_t *self, int* resizable) {
    *resizable = self->resizable;
}

// cef_popup_features_t->fullscreen
CFX_EXPORT void cfx_popup_features_set_fullscreen(cef_popup_features_t *self, int fullscreen) {
    self->fullscreen = fullscreen;
}
CFX_EXPORT void cfx_popup_features_get_fullscreen(cef_popup_features_t *self, int* fullscreen) {
    *fullscreen = self->fullscreen;
}

// cef_popup_features_t->dialog
CFX_EXPORT void cfx_popup_features_set_dialog(cef_popup_features_t *self, int dialog) {
    self->dialog = dialog;
}
CFX_EXPORT void cfx_popup_features_get_dialog(cef_popup_features_t *self, int* dialog) {
    *dialog = self->dialog;
}

// cef_popup_features_t->additionalFeatures
CFX_EXPORT void cfx_popup_features_set_additionalFeatures(cef_popup_features_t *self, cef_string_list_t additionalFeatures) {
    self->additionalFeatures = additionalFeatures;
}
CFX_EXPORT void cfx_popup_features_get_additionalFeatures(cef_popup_features_t *self, cef_string_list_t* additionalFeatures) {
    *additionalFeatures = self->additionalFeatures;
}


#ifdef __cplusplus
} // extern "C"
#endif

