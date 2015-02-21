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

CFX_EXPORT void cfx_popup_features_dtor(cef_popup_features_t* ptr) {
    free(ptr);
}

CFX_EXPORT void cfx_popup_features_copy_to_native(cef_popup_features_t* self, int x, int xSet, int y, int ySet, int width, int widthSet, int height, int heightSet, int menuBarVisible, int statusBarVisible, int toolBarVisible, int locationBarVisible, int scrollbarsVisible, int resizable, int fullscreen, int dialog, cef_string_list_t additionalFeatures) {
    self->x = x;
    self->xSet = xSet;
    self->y = y;
    self->ySet = ySet;
    self->width = width;
    self->widthSet = widthSet;
    self->height = height;
    self->heightSet = heightSet;
    self->menuBarVisible = menuBarVisible;
    self->statusBarVisible = statusBarVisible;
    self->toolBarVisible = toolBarVisible;
    self->locationBarVisible = locationBarVisible;
    self->scrollbarsVisible = scrollbarsVisible;
    self->resizable = resizable;
    self->fullscreen = fullscreen;
    self->dialog = dialog;
    self->additionalFeatures = additionalFeatures;
}

CFX_EXPORT void cfx_popup_features_copy_to_managed(cef_popup_features_t* self, int* x, int* xSet, int* y, int* ySet, int* width, int* widthSet, int* height, int* heightSet, int* menuBarVisible, int* statusBarVisible, int* toolBarVisible, int* locationBarVisible, int* scrollbarsVisible, int* resizable, int* fullscreen, int* dialog, cef_string_list_t* additionalFeatures) {
    *x = self->x;
    *xSet = self->xSet;
    *y = self->y;
    *ySet = self->ySet;
    *width = self->width;
    *widthSet = self->widthSet;
    *height = self->height;
    *heightSet = self->heightSet;
    *menuBarVisible = self->menuBarVisible;
    *statusBarVisible = self->statusBarVisible;
    *toolBarVisible = self->toolBarVisible;
    *locationBarVisible = self->locationBarVisible;
    *scrollbarsVisible = self->scrollbarsVisible;
    *resizable = self->resizable;
    *fullscreen = self->fullscreen;
    *dialog = self->dialog;
    *additionalFeatures = self->additionalFeatures;
}

#ifdef __cplusplus
} // extern "C"
#endif

