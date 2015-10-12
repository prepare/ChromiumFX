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


// cef_command_line

// CEF_EXPORT cef_command_line_t* cef_command_line_create();
static cef_command_line_t* cfx_command_line_create() {
    return cef_command_line_create();
}
// CEF_EXPORT cef_command_line_t* cef_command_line_get_global();
static cef_command_line_t* cfx_command_line_get_global() {
    return cef_command_line_get_global();
}
// is_valid
static int cfx_command_line_is_valid(cef_command_line_t* self) {
    return self->is_valid(self);
}

// is_read_only
static int cfx_command_line_is_read_only(cef_command_line_t* self) {
    return self->is_read_only(self);
}

// copy
static cef_command_line_t* cfx_command_line_copy(cef_command_line_t* self) {
    return self->copy(self);
}

// init_from_argv
static void cfx_command_line_init_from_argv(cef_command_line_t* self, int argc, const char* const* argv) {
    self->init_from_argv(self, argc, argv);
}

// init_from_string
static void cfx_command_line_init_from_string(cef_command_line_t* self, char16 *command_line_str, int command_line_length) {
    cef_string_t command_line = { command_line_str, command_line_length, 0 };
    self->init_from_string(self, &command_line);
}

// reset
static void cfx_command_line_reset(cef_command_line_t* self) {
    self->reset(self);
}

// get_argv
static void cfx_command_line_get_argv(cef_command_line_t* self, cef_string_list_t argv) {
    self->get_argv(self, argv);
}

// get_command_line_string
static cef_string_userfree_t cfx_command_line_get_command_line_string(cef_command_line_t* self) {
    return self->get_command_line_string(self);
}

// get_program
static cef_string_userfree_t cfx_command_line_get_program(cef_command_line_t* self) {
    return self->get_program(self);
}

// set_program
static void cfx_command_line_set_program(cef_command_line_t* self, char16 *program_str, int program_length) {
    cef_string_t program = { program_str, program_length, 0 };
    self->set_program(self, &program);
}

// has_switches
static int cfx_command_line_has_switches(cef_command_line_t* self) {
    return self->has_switches(self);
}

// has_switch
static int cfx_command_line_has_switch(cef_command_line_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return self->has_switch(self, &name);
}

// get_switch_value
static cef_string_userfree_t cfx_command_line_get_switch_value(cef_command_line_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return self->get_switch_value(self, &name);
}

// get_switches
static void cfx_command_line_get_switches(cef_command_line_t* self, cef_string_map_t switches) {
    self->get_switches(self, switches);
}

// append_switch
static void cfx_command_line_append_switch(cef_command_line_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    self->append_switch(self, &name);
}

// append_switch_with_value
static void cfx_command_line_append_switch_with_value(cef_command_line_t* self, char16 *name_str, int name_length, char16 *value_str, int value_length) {
    cef_string_t name = { name_str, name_length, 0 };
    cef_string_t value = { value_str, value_length, 0 };
    self->append_switch_with_value(self, &name, &value);
}

// has_arguments
static int cfx_command_line_has_arguments(cef_command_line_t* self) {
    return self->has_arguments(self);
}

// get_arguments
static void cfx_command_line_get_arguments(cef_command_line_t* self, cef_string_list_t arguments) {
    self->get_arguments(self, arguments);
}

// append_argument
static void cfx_command_line_append_argument(cef_command_line_t* self, char16 *argument_str, int argument_length) {
    cef_string_t argument = { argument_str, argument_length, 0 };
    self->append_argument(self, &argument);
}

// prepend_wrapper
static void cfx_command_line_prepend_wrapper(cef_command_line_t* self, char16 *wrapper_str, int wrapper_length) {
    cef_string_t wrapper = { wrapper_str, wrapper_length, 0 };
    self->prepend_wrapper(self, &wrapper);
}


