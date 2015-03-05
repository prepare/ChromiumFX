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


using System;

namespace Chromium {
    public enum CfxColorModel {
        Unknown,
        Gray,
        Color,
        Cmyk,
        Cmy,
        Kcmy,
        CmyK,
        Black,
        Grayscale,
        Rgb,
        Rgb16,
        Rgba,
        ColorModeColor,
        ColorModeMonochrome,
        HpColorColor,
        HpColorBlack,
        PrintoutModeNormal,
        PrintoutModeNormalGray,
        ProcessColorModelCmyk,
        ProcessColorModelGreyscale,
        ProcessColorModelRgb
    }
    [Flags()]
    public enum CfxContextMenuEditStateFlags {
        None = unchecked((int)0),
        CanUndo = unchecked((int)1 << 0),
        CanRedo = unchecked((int)1 << 1),
        CanCut = unchecked((int)1 << 2),
        CanCopy = unchecked((int)1 << 3),
        CanPaste = unchecked((int)1 << 4),
        CanDelete = unchecked((int)1 << 5),
        CanSelectAll = unchecked((int)1 << 6),
        CanTranslate = unchecked((int)1 << 7)
    }
    [Flags()]
    public enum CfxContextMenuMediaStateFlags {
        None = unchecked((int)0),
        Error = unchecked((int)1 << 0),
        Paused = unchecked((int)1 << 1),
        Muted = unchecked((int)1 << 2),
        Loop = unchecked((int)1 << 3),
        CanSave = unchecked((int)1 << 4),
        HasAudio = unchecked((int)1 << 5),
        HasVideo = unchecked((int)1 << 6),
        ControlRootElement = unchecked((int)1 << 7),
        CanPrint = unchecked((int)1 << 8),
        CanRotate = unchecked((int)1 << 9)
    }
    public enum CfxContextMenuMediaType {
        None,
        Image,
        Video,
        Audio,
        File,
        Plugin
    }
    [Flags()]
    public enum CfxContextMenuTypeFlags {
        None = unchecked((int)0),
        Page = unchecked((int)1 << 0),
        Frame = unchecked((int)1 << 1),
        Link = unchecked((int)1 << 2),
        Media = unchecked((int)1 << 3),
        Selection = unchecked((int)1 << 4),
        Editable = unchecked((int)1 << 5)
    }
    public enum CfxCursorType {
        Pointer = unchecked((int)0),
        Cross,
        Hand,
        Ibeam,
        Wait,
        Help,
        Eastresize,
        Northresize,
        Northeastresize,
        Northwestresize,
        Southresize,
        Southeastresize,
        Southwestresize,
        Westresize,
        Northsouthresize,
        Eastwestresize,
        Northeastsouthwestresize,
        Northwestsoutheastresize,
        Columnresize,
        Rowresize,
        Middlepanning,
        Eastpanning,
        Northpanning,
        Northeastpanning,
        Northwestpanning,
        Southpanning,
        Southeastpanning,
        Southwestpanning,
        Westpanning,
        Move,
        VerticalText,
        Cell,
        Contextmenu,
        Alias,
        Progress,
        Nodrop,
        Copy,
        None,
        Notallowed,
        Zoomin,
        Zoomout,
        Grab,
        Grabbing,
        Custom
    }
    public enum CfxDomDocumentType {
        Unknown = unchecked((int)0),
        Html,
        Xhtml,
        Plugin
    }
    public enum CfxDomEventCategory {
        Unknown = unchecked((int)0x0),
        Ui = unchecked((int)0x1),
        Mouse = unchecked((int)0x2),
        Mutation = unchecked((int)0x4),
        Keyboard = unchecked((int)0x8),
        Text = unchecked((int)0x10),
        Composition = unchecked((int)0x20),
        Drag = unchecked((int)0x40),
        Clipboard = unchecked((int)0x80),
        Message = unchecked((int)0x100),
        Wheel = unchecked((int)0x200),
        BeforeTextInserted = unchecked((int)0x400),
        Overflow = unchecked((int)0x800),
        PageTransition = unchecked((int)0x1000),
        Popstate = unchecked((int)0x2000),
        Progress = unchecked((int)0x4000),
        XmlhttpRequestProgress = unchecked((int)0x8000)
    }
    public enum CfxDomEventPhase {
        Unknown = unchecked((int)0),
        CaptUring,
        AtTarget,
        Bubbling
    }
    public enum CfxDomNodeType {
        Unsupported = unchecked((int)0),
        Element,
        Attribute,
        Text,
        CdataSection,
        ProcessingInstructions,
        Comment,
        Document,
        DocumentType,
        DocumentFragment
    }
    public enum CfxDragOperationsMask {
        DragOperationNone = unchecked((int)0),
        DragOperationCopy = unchecked((int)1),
        DragOperationLink = unchecked((int)2),
        DragOperationGeneric = unchecked((int)4),
        DragOperationPrivate = unchecked((int)8),
        DragOperationMove = unchecked((int)16),
        DragOperationDelete = unchecked((int)32),
        DragOperationEvery,
        UintMax
    }
    public enum CfxDuplexMode {
        Unknown = unchecked((int)-1),
        Simplex,
        LongEdge,
        ShortEdge
    }
    public enum CfxErrorCode {
        None = unchecked((int)0),
        Failed = unchecked((int)-2),
        Aborted = unchecked((int)-3),
        InvalidArgument = unchecked((int)-4),
        InvalidHandle = unchecked((int)-5),
        FileNotFound = unchecked((int)-6),
        TimedOut = unchecked((int)-7),
        FileTooBig = unchecked((int)-8),
        Unexpected = unchecked((int)-9),
        AccessDenied = unchecked((int)-10),
        NotImplemented = unchecked((int)-11),
        ConnectionClosed = unchecked((int)-100),
        ConnectionReset = unchecked((int)-101),
        ConnectionRefused = unchecked((int)-102),
        ConnectionAborted = unchecked((int)-103),
        ConnectionFailed = unchecked((int)-104),
        NameNotResolved = unchecked((int)-105),
        InternetDisconnected = unchecked((int)-106),
        SslProtocolError = unchecked((int)-107),
        AddressInvalid = unchecked((int)-108),
        AddressUnreachable = unchecked((int)-109),
        SslClientAuthCertNeeded = unchecked((int)-110),
        TunnelConnectionFailed = unchecked((int)-111),
        NoSslVersionsEnabled = unchecked((int)-112),
        SslVersionOrCipherMismatch = unchecked((int)-113),
        SslRenegotiationRequested = unchecked((int)-114),
        CertCommonNameInvalid = unchecked((int)-200),
        CertDateInvalid = unchecked((int)-201),
        CertAuthorityInvalid = unchecked((int)-202),
        CertContainsErrors = unchecked((int)-203),
        CertNoRevocationMechanism = unchecked((int)-204),
        CertUnableToCheckRevocation = unchecked((int)-205),
        CertRevoked = unchecked((int)-206),
        CertInvalid = unchecked((int)-207),
        CertEnd = unchecked((int)-208),
        InvalidUrl = unchecked((int)-300),
        DisallowedUrlScheme = unchecked((int)-301),
        UnknownUrlScheme = unchecked((int)-302),
        TooManyRedirects = unchecked((int)-310),
        UnsafeRedirect = unchecked((int)-311),
        UnsafePort = unchecked((int)-312),
        InvalidResponse = unchecked((int)-320),
        InvalidChunkedEncoding = unchecked((int)-321),
        MethodNotSupported = unchecked((int)-322),
        UnexpectedProxyAuth = unchecked((int)-323),
        EmptyResponse = unchecked((int)-324),
        ResponseHeadersTooBig = unchecked((int)-325),
        CacheMiss = unchecked((int)-400),
        InsecureResponse = unchecked((int)-501)
    }
    [Flags()]
    public enum CfxEventFlags {
        None = unchecked((int)0),
        CapsLockOn = unchecked((int)1 << 0),
        ShiftDown = unchecked((int)1 << 1),
        ControlDown = unchecked((int)1 << 2),
        AltDown = unchecked((int)1 << 3),
        LeftMouseButton = unchecked((int)1 << 4),
        MiddleMouseButton = unchecked((int)1 << 5),
        RightMouseButton = unchecked((int)1 << 6),
        CommandDown = unchecked((int)1 << 7),
        NumLockOn = unchecked((int)1 << 8),
        IsKeyPad = unchecked((int)1 << 9),
        IsLeft = unchecked((int)1 << 10),
        IsRight = unchecked((int)1 << 11)
    }
    public enum CfxFileDialogMode {
        Open = unchecked((int)0),
        OpenMultiple,
        Save
    }
    public enum CfxFocusSource {
        Navigation = unchecked((int)0),
        System
    }
    public enum CfxGeopositionErrorCode {
        None = unchecked((int)0),
        PermissionDenied,
        PositionUnavailable,
        Timeout
    }
    public enum CfxJsDialogType {
        Alert = unchecked((int)0),
        Confirm,
        Prompt
    }
    public enum CfxKeyEventType {
        RawKeydown = unchecked((int)0),
        Keydown,
        Keyup,
        Char
    }
    public enum CfxLogSeverity {
        Default,
        Verbose,
        Info,
        Warning,
        Error,
        Disable = unchecked((int)99)
    }
    public enum CfxMenuId {
        Back = unchecked((int)100),
        Forward = unchecked((int)101),
        Reload = unchecked((int)102),
        ReloadNocache = unchecked((int)103),
        Stopload = unchecked((int)104),
        Undo = unchecked((int)110),
        Redo = unchecked((int)111),
        Cut = unchecked((int)112),
        Copy = unchecked((int)113),
        Paste = unchecked((int)114),
        Delete = unchecked((int)115),
        SelectAll = unchecked((int)116),
        Find = unchecked((int)130),
        Print = unchecked((int)131),
        ViewSource = unchecked((int)132),
        SpellcheckSuggestion0 = unchecked((int)200),
        SpellcheckSuggestion1 = unchecked((int)201),
        SpellcheckSuggestion2 = unchecked((int)202),
        SpellcheckSuggestion3 = unchecked((int)203),
        SpellcheckSuggestion4 = unchecked((int)204),
        SpellcheckSuggestionLast = unchecked((int)204),
        NoSpellingSuggestions = unchecked((int)205),
        AddToDictionary = unchecked((int)206),
        UserFirst = unchecked((int)26500),
        UserLast = unchecked((int)28500)
    }
    public enum CfxMenuItemType {
        None,
        Command,
        Check,
        Radio,
        Separator,
        Submenu
    }
    public enum CfxMouseButtonType {
        Left = unchecked((int)0),
        Middle,
        Right
    }
    public enum CfxNavigationType {
        LinkClicked = unchecked((int)0),
        FormSubmitted,
        BackForward,
        Reload,
        FormResubmitted,
        Other
    }
    public enum CfxPaintElementType {
        View = unchecked((int)0),
        Popup
    }
    public enum CfxPathKey {
        DirCurrent,
        DirExe,
        DirModule,
        DirTemp,
        FileExe,
        FileModule
    }
    public enum CfxPostdataElementType {
        Empty = unchecked((int)0),
        Bytes,
        File
    }
    public enum CfxProcessId {
        Browser,
        Renderer
    }
    public enum CfxResourceType {
        MainFrame = unchecked((int)0),
        SubFrame,
        Stylesheet,
        Script,
        Image,
        FontResource,
        SubResource,
        Object,
        Media,
        Worker,
        SharedWorker,
        Prefetch,
        Favicon,
        Xhr,
        Ping,
        ServiceWorker
    }
    public enum CfxState {
        Default = unchecked((int)0),
        Enabled,
        Disabled
    }
    public enum CfxStorageType {
        LocalStorage = unchecked((int)0),
        SessionStorage
    }
    public enum CfxTerminationStatus {
        AbnormalTermination,
        ProcessWasKilled,
        ProcessCrashed
    }
    public enum CfxThreadId {
        Ui,
        Db,
        File,
        FileUserBlocking,
        ProcessLauncher,
        Cache,
        Io,
        Renderer
    }
    public enum CfxTransitionType {
        Link = unchecked((int)0),
        Explicit = unchecked((int)1),
        AutoSubframe = unchecked((int)3),
        ManualSubframe = unchecked((int)4),
        FormSubmit = unchecked((int)7),
        Reload = unchecked((int)8),
        SourceMask = unchecked((int)0xFF),
        BlockedFlag = unchecked((int)0x00800000),
        ForwardBackFlag = unchecked((int)0x01000000),
        ChainStartFlag = unchecked((int)0x10000000),
        ChainEndFlag = unchecked((int)0x20000000),
        ClientRedirectFlag = unchecked((int)0x40000000),
        ServerRedirectFlag = unchecked((int)0x80000000),
        IsRedirectMask = unchecked((int)0xC0000000),
        QualifierMask = unchecked((int)0xFFFFFF00)
    }
    [Flags()]
    public enum CfxUrlRequestFlags {
        None = unchecked((int)0),
        SkipCache = unchecked((int)1 << 0),
        AllowCachedCredentials = unchecked((int)1 << 1),
        ReportUploadProgress = unchecked((int)1 << 3),
        ReportRawHeaders = unchecked((int)1 << 5),
        NoDownloadData = unchecked((int)1 << 6),
        NoRetryOn5xx = unchecked((int)1 << 7)
    }
    public enum CfxUrlRequestStatus {
        Unknown = unchecked((int)0),
        Success,
        IoPending,
        Canceled,
        Failed
    }
    public enum CfxV8AccessControl {
        Default = unchecked((int)0),
        AllCanRead = unchecked((int)1),
        AllCanWrite = unchecked((int)1 << 1),
        ProhibitsOverwriting = unchecked((int)1 << 2)
    }
    [Flags()]
    public enum CfxV8PropertyAttribute {
        None = unchecked((int)0),
        ReadOnly = unchecked((int)1 << 0),
        DontEnum = unchecked((int)1 << 1),
        DontDelete = unchecked((int)1 << 2)
    }
    public enum CfxValueType {
        Invalid = unchecked((int)0),
        Null,
        Bool,
        Int,
        Double,
        String,
        Binary,
        Dictionary,
        List
    }
    public enum CfxXmlEncodingType {
        None = unchecked((int)0),
        Utf8,
        Utf16le,
        Utf16be,
        Ascii
    }
    public enum CfxXmlNodeType {
        Unsupported = unchecked((int)0),
        ProcessingInstruction,
        DocumentType,
        ElementStart,
        ElementEnd,
        Attribute,
        Text,
        Cdata,
        EntityReference,
        Whitespace,
        Comment
    }
}
