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

namespace Chromium.Remote {
    internal class RemoteCallSwitch {
        internal static RemoteCall ForCallId(RemoteCallId id) {
            switch(id) {
                case RemoteCallId.CfxRuntimeAddCrossOriginWhitelistEntryRenderProcessCall:
                    return new CfxRuntimeAddCrossOriginWhitelistEntryRenderProcessCall();
                case RemoteCallId.CfxRuntimeClearCrossOriginWhitelistRenderProcessCall:
                    return new CfxRuntimeClearCrossOriginWhitelistRenderProcessCall();
                case RemoteCallId.CfxRuntimeCreateUrlRenderProcessCall:
                    return new CfxRuntimeCreateUrlRenderProcessCall();
                case RemoteCallId.CfxRuntimeCurrentlyOnRenderProcessCall:
                    return new CfxRuntimeCurrentlyOnRenderProcessCall();
                case RemoteCallId.CfxRuntimeEndTracingRenderProcessCall:
                    return new CfxRuntimeEndTracingRenderProcessCall();
                case RemoteCallId.CfxRuntimeGetExtensionsForMimeTypeRenderProcessCall:
                    return new CfxRuntimeGetExtensionsForMimeTypeRenderProcessCall();
                case RemoteCallId.CfxRuntimeGetGeolocationRenderProcessCall:
                    return new CfxRuntimeGetGeolocationRenderProcessCall();
                case RemoteCallId.CfxRuntimeGetMimeTypeRenderProcessCall:
                    return new CfxRuntimeGetMimeTypeRenderProcessCall();
                case RemoteCallId.CfxRuntimeNowFromSystemTraceTimeRenderProcessCall:
                    return new CfxRuntimeNowFromSystemTraceTimeRenderProcessCall();
                case RemoteCallId.CfxRuntimeParseUrlRenderProcessCall:
                    return new CfxRuntimeParseUrlRenderProcessCall();
                case RemoteCallId.CfxRuntimePostDelayedTaskRenderProcessCall:
                    return new CfxRuntimePostDelayedTaskRenderProcessCall();
                case RemoteCallId.CfxRuntimePostTaskRenderProcessCall:
                    return new CfxRuntimePostTaskRenderProcessCall();
                case RemoteCallId.CfxRuntimeRegisterExtensionRenderProcessCall:
                    return new CfxRuntimeRegisterExtensionRenderProcessCall();
                case RemoteCallId.CfxRuntimeRemoveCrossOriginWhitelistEntryRenderProcessCall:
                    return new CfxRuntimeRemoveCrossOriginWhitelistEntryRenderProcessCall();
                case RemoteCallId.CfxRuntimeSetOsModalLoopRenderProcessCall:
                    return new CfxRuntimeSetOsModalLoopRenderProcessCall();
                case RemoteCallId.CfxAppCtorRenderProcessCall:
                    return new CfxAppCtorRenderProcessCall();
                case RemoteCallId.CfxOnBeforeCommandLineProcessingBrowserProcessCall:
                    return new CfxOnBeforeCommandLineProcessingBrowserProcessCall();
                case RemoteCallId.CfxOnBeforeCommandLineProcessingActivateRenderProcessCall:
                    return new CfxOnBeforeCommandLineProcessingActivateRenderProcessCall();
                case RemoteCallId.CfxOnBeforeCommandLineProcessingDeactivateRenderProcessCall:
                    return new CfxOnBeforeCommandLineProcessingDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnBeforeCommandLineProcessingGetProcessTypeRenderProcessCall:
                    return new CfxOnBeforeCommandLineProcessingGetProcessTypeRenderProcessCall();
                case RemoteCallId.CfxOnBeforeCommandLineProcessingGetCommandLineRenderProcessCall:
                    return new CfxOnBeforeCommandLineProcessingGetCommandLineRenderProcessCall();
                case RemoteCallId.CfxOnRegisterCustomSchemesBrowserProcessCall:
                    return new CfxOnRegisterCustomSchemesBrowserProcessCall();
                case RemoteCallId.CfxOnRegisterCustomSchemesActivateRenderProcessCall:
                    return new CfxOnRegisterCustomSchemesActivateRenderProcessCall();
                case RemoteCallId.CfxOnRegisterCustomSchemesDeactivateRenderProcessCall:
                    return new CfxOnRegisterCustomSchemesDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnRegisterCustomSchemesGetRegistrarRenderProcessCall:
                    return new CfxOnRegisterCustomSchemesGetRegistrarRenderProcessCall();
                case RemoteCallId.CfxGetResourceBundleHandlerBrowserProcessCall:
                    return new CfxGetResourceBundleHandlerBrowserProcessCall();
                case RemoteCallId.CfxGetResourceBundleHandlerActivateRenderProcessCall:
                    return new CfxGetResourceBundleHandlerActivateRenderProcessCall();
                case RemoteCallId.CfxGetResourceBundleHandlerDeactivateRenderProcessCall:
                    return new CfxGetResourceBundleHandlerDeactivateRenderProcessCall();
                case RemoteCallId.CfxGetResourceBundleHandlerSetReturnValueRenderProcessCall:
                    return new CfxGetResourceBundleHandlerSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxGetRenderProcessHandlerBrowserProcessCall:
                    return new CfxGetRenderProcessHandlerBrowserProcessCall();
                case RemoteCallId.CfxGetRenderProcessHandlerActivateRenderProcessCall:
                    return new CfxGetRenderProcessHandlerActivateRenderProcessCall();
                case RemoteCallId.CfxGetRenderProcessHandlerDeactivateRenderProcessCall:
                    return new CfxGetRenderProcessHandlerDeactivateRenderProcessCall();
                case RemoteCallId.CfxGetRenderProcessHandlerSetReturnValueRenderProcessCall:
                    return new CfxGetRenderProcessHandlerSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxBinaryValueCreateRenderProcessCall:
                    return new CfxBinaryValueCreateRenderProcessCall();
                case RemoteCallId.CfxBinaryValueIsValidRenderProcessCall:
                    return new CfxBinaryValueIsValidRenderProcessCall();
                case RemoteCallId.CfxBinaryValueIsOwnedRenderProcessCall:
                    return new CfxBinaryValueIsOwnedRenderProcessCall();
                case RemoteCallId.CfxBinaryValueCopyRenderProcessCall:
                    return new CfxBinaryValueCopyRenderProcessCall();
                case RemoteCallId.CfxBinaryValueGetSizeRenderProcessCall:
                    return new CfxBinaryValueGetSizeRenderProcessCall();
                case RemoteCallId.CfxBinaryValueGetDataRenderProcessCall:
                    return new CfxBinaryValueGetDataRenderProcessCall();
                case RemoteCallId.CfxBrowserCanGoBackRenderProcessCall:
                    return new CfxBrowserCanGoBackRenderProcessCall();
                case RemoteCallId.CfxBrowserGoBackRenderProcessCall:
                    return new CfxBrowserGoBackRenderProcessCall();
                case RemoteCallId.CfxBrowserCanGoForwardRenderProcessCall:
                    return new CfxBrowserCanGoForwardRenderProcessCall();
                case RemoteCallId.CfxBrowserGoForwardRenderProcessCall:
                    return new CfxBrowserGoForwardRenderProcessCall();
                case RemoteCallId.CfxBrowserIsLoadingRenderProcessCall:
                    return new CfxBrowserIsLoadingRenderProcessCall();
                case RemoteCallId.CfxBrowserReloadRenderProcessCall:
                    return new CfxBrowserReloadRenderProcessCall();
                case RemoteCallId.CfxBrowserReloadIgnoreCacheRenderProcessCall:
                    return new CfxBrowserReloadIgnoreCacheRenderProcessCall();
                case RemoteCallId.CfxBrowserStopLoadRenderProcessCall:
                    return new CfxBrowserStopLoadRenderProcessCall();
                case RemoteCallId.CfxBrowserGetIdentifierRenderProcessCall:
                    return new CfxBrowserGetIdentifierRenderProcessCall();
                case RemoteCallId.CfxBrowserIsSameRenderProcessCall:
                    return new CfxBrowserIsSameRenderProcessCall();
                case RemoteCallId.CfxBrowserIsPopupRenderProcessCall:
                    return new CfxBrowserIsPopupRenderProcessCall();
                case RemoteCallId.CfxBrowserHasDocumentRenderProcessCall:
                    return new CfxBrowserHasDocumentRenderProcessCall();
                case RemoteCallId.CfxBrowserGetMainFrameRenderProcessCall:
                    return new CfxBrowserGetMainFrameRenderProcessCall();
                case RemoteCallId.CfxBrowserGetFocusedFrameRenderProcessCall:
                    return new CfxBrowserGetFocusedFrameRenderProcessCall();
                case RemoteCallId.CfxBrowserGetFrameByIdentifierRenderProcessCall:
                    return new CfxBrowserGetFrameByIdentifierRenderProcessCall();
                case RemoteCallId.CfxBrowserGetFrameRenderProcessCall:
                    return new CfxBrowserGetFrameRenderProcessCall();
                case RemoteCallId.CfxBrowserGetFrameCountRenderProcessCall:
                    return new CfxBrowserGetFrameCountRenderProcessCall();
                case RemoteCallId.CfxBrowserGetFrameIdentifiersRenderProcessCall:
                    return new CfxBrowserGetFrameIdentifiersRenderProcessCall();
                case RemoteCallId.CfxBrowserGetFrameNamesRenderProcessCall:
                    return new CfxBrowserGetFrameNamesRenderProcessCall();
                case RemoteCallId.CfxBrowserSendProcessMessageRenderProcessCall:
                    return new CfxBrowserSendProcessMessageRenderProcessCall();
                case RemoteCallId.CfxCommandLineCreateRenderProcessCall:
                    return new CfxCommandLineCreateRenderProcessCall();
                case RemoteCallId.CfxCommandLineGetGlobalRenderProcessCall:
                    return new CfxCommandLineGetGlobalRenderProcessCall();
                case RemoteCallId.CfxCommandLineIsValidRenderProcessCall:
                    return new CfxCommandLineIsValidRenderProcessCall();
                case RemoteCallId.CfxCommandLineIsReadOnlyRenderProcessCall:
                    return new CfxCommandLineIsReadOnlyRenderProcessCall();
                case RemoteCallId.CfxCommandLineCopyRenderProcessCall:
                    return new CfxCommandLineCopyRenderProcessCall();
                case RemoteCallId.CfxCommandLineInitFromArgvRenderProcessCall:
                    return new CfxCommandLineInitFromArgvRenderProcessCall();
                case RemoteCallId.CfxCommandLineInitFromStringRenderProcessCall:
                    return new CfxCommandLineInitFromStringRenderProcessCall();
                case RemoteCallId.CfxCommandLineResetRenderProcessCall:
                    return new CfxCommandLineResetRenderProcessCall();
                case RemoteCallId.CfxCommandLineGetArgvRenderProcessCall:
                    return new CfxCommandLineGetArgvRenderProcessCall();
                case RemoteCallId.CfxCommandLineGetCommandLineStringRenderProcessCall:
                    return new CfxCommandLineGetCommandLineStringRenderProcessCall();
                case RemoteCallId.CfxCommandLineGetProgramRenderProcessCall:
                    return new CfxCommandLineGetProgramRenderProcessCall();
                case RemoteCallId.CfxCommandLineSetProgramRenderProcessCall:
                    return new CfxCommandLineSetProgramRenderProcessCall();
                case RemoteCallId.CfxCommandLineHasSwitchesRenderProcessCall:
                    return new CfxCommandLineHasSwitchesRenderProcessCall();
                case RemoteCallId.CfxCommandLineHasSwitchRenderProcessCall:
                    return new CfxCommandLineHasSwitchRenderProcessCall();
                case RemoteCallId.CfxCommandLineGetSwitchValueRenderProcessCall:
                    return new CfxCommandLineGetSwitchValueRenderProcessCall();
                case RemoteCallId.CfxCommandLineGetSwitchesRenderProcessCall:
                    return new CfxCommandLineGetSwitchesRenderProcessCall();
                case RemoteCallId.CfxCommandLineAppendSwitchRenderProcessCall:
                    return new CfxCommandLineAppendSwitchRenderProcessCall();
                case RemoteCallId.CfxCommandLineAppendSwitchWithValueRenderProcessCall:
                    return new CfxCommandLineAppendSwitchWithValueRenderProcessCall();
                case RemoteCallId.CfxCommandLineHasArgumentsRenderProcessCall:
                    return new CfxCommandLineHasArgumentsRenderProcessCall();
                case RemoteCallId.CfxCommandLineGetArgumentsRenderProcessCall:
                    return new CfxCommandLineGetArgumentsRenderProcessCall();
                case RemoteCallId.CfxCommandLineAppendArgumentRenderProcessCall:
                    return new CfxCommandLineAppendArgumentRenderProcessCall();
                case RemoteCallId.CfxCommandLinePrependWrapperRenderProcessCall:
                    return new CfxCommandLinePrependWrapperRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueCreateRenderProcessCall:
                    return new CfxDictionaryValueCreateRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueIsValidRenderProcessCall:
                    return new CfxDictionaryValueIsValidRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueIsOwnedRenderProcessCall:
                    return new CfxDictionaryValueIsOwnedRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueIsReadOnlyRenderProcessCall:
                    return new CfxDictionaryValueIsReadOnlyRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueCopyRenderProcessCall:
                    return new CfxDictionaryValueCopyRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetSizeRenderProcessCall:
                    return new CfxDictionaryValueGetSizeRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueClearRenderProcessCall:
                    return new CfxDictionaryValueClearRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueHasKeyRenderProcessCall:
                    return new CfxDictionaryValueHasKeyRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetKeysRenderProcessCall:
                    return new CfxDictionaryValueGetKeysRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueRemoveRenderProcessCall:
                    return new CfxDictionaryValueRemoveRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetTypeRenderProcessCall:
                    return new CfxDictionaryValueGetTypeRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetBoolRenderProcessCall:
                    return new CfxDictionaryValueGetBoolRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetIntRenderProcessCall:
                    return new CfxDictionaryValueGetIntRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetDoubleRenderProcessCall:
                    return new CfxDictionaryValueGetDoubleRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetStringRenderProcessCall:
                    return new CfxDictionaryValueGetStringRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetBinaryRenderProcessCall:
                    return new CfxDictionaryValueGetBinaryRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetDictionaryRenderProcessCall:
                    return new CfxDictionaryValueGetDictionaryRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueGetListRenderProcessCall:
                    return new CfxDictionaryValueGetListRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueSetNullRenderProcessCall:
                    return new CfxDictionaryValueSetNullRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueSetBoolRenderProcessCall:
                    return new CfxDictionaryValueSetBoolRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueSetIntRenderProcessCall:
                    return new CfxDictionaryValueSetIntRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueSetDoubleRenderProcessCall:
                    return new CfxDictionaryValueSetDoubleRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueSetStringRenderProcessCall:
                    return new CfxDictionaryValueSetStringRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueSetBinaryRenderProcessCall:
                    return new CfxDictionaryValueSetBinaryRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueSetDictionaryRenderProcessCall:
                    return new CfxDictionaryValueSetDictionaryRenderProcessCall();
                case RemoteCallId.CfxDictionaryValueSetListRenderProcessCall:
                    return new CfxDictionaryValueSetListRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetTypeRenderProcessCall:
                    return new CfxDomDocumentGetTypeRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetDocumentRenderProcessCall:
                    return new CfxDomDocumentGetDocumentRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetBodyRenderProcessCall:
                    return new CfxDomDocumentGetBodyRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetHeadRenderProcessCall:
                    return new CfxDomDocumentGetHeadRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetTitleRenderProcessCall:
                    return new CfxDomDocumentGetTitleRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetElementByIdRenderProcessCall:
                    return new CfxDomDocumentGetElementByIdRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetFocusedNodeRenderProcessCall:
                    return new CfxDomDocumentGetFocusedNodeRenderProcessCall();
                case RemoteCallId.CfxDomDocumentHasSelectionRenderProcessCall:
                    return new CfxDomDocumentHasSelectionRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetSelectionStartNodeRenderProcessCall:
                    return new CfxDomDocumentGetSelectionStartNodeRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetSelectionStartOffsetRenderProcessCall:
                    return new CfxDomDocumentGetSelectionStartOffsetRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetSelectionEndNodeRenderProcessCall:
                    return new CfxDomDocumentGetSelectionEndNodeRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetSelectionEndOffsetRenderProcessCall:
                    return new CfxDomDocumentGetSelectionEndOffsetRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetSelectionAsMarkupRenderProcessCall:
                    return new CfxDomDocumentGetSelectionAsMarkupRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetSelectionAsTextRenderProcessCall:
                    return new CfxDomDocumentGetSelectionAsTextRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetBaseUrlRenderProcessCall:
                    return new CfxDomDocumentGetBaseUrlRenderProcessCall();
                case RemoteCallId.CfxDomDocumentGetCompleteUrlRenderProcessCall:
                    return new CfxDomDocumentGetCompleteUrlRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetTypeRenderProcessCall:
                    return new CfxDomNodeGetTypeRenderProcessCall();
                case RemoteCallId.CfxDomNodeIsTextRenderProcessCall:
                    return new CfxDomNodeIsTextRenderProcessCall();
                case RemoteCallId.CfxDomNodeIsElementRenderProcessCall:
                    return new CfxDomNodeIsElementRenderProcessCall();
                case RemoteCallId.CfxDomNodeIsEditableRenderProcessCall:
                    return new CfxDomNodeIsEditableRenderProcessCall();
                case RemoteCallId.CfxDomNodeIsFormControlElementRenderProcessCall:
                    return new CfxDomNodeIsFormControlElementRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetFormControlElementTypeRenderProcessCall:
                    return new CfxDomNodeGetFormControlElementTypeRenderProcessCall();
                case RemoteCallId.CfxDomNodeIsSameRenderProcessCall:
                    return new CfxDomNodeIsSameRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetNameRenderProcessCall:
                    return new CfxDomNodeGetNameRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetValueRenderProcessCall:
                    return new CfxDomNodeGetValueRenderProcessCall();
                case RemoteCallId.CfxDomNodeSetValueRenderProcessCall:
                    return new CfxDomNodeSetValueRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetAsMarkupRenderProcessCall:
                    return new CfxDomNodeGetAsMarkupRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetDocumentRenderProcessCall:
                    return new CfxDomNodeGetDocumentRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetParentRenderProcessCall:
                    return new CfxDomNodeGetParentRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetPreviousSiblingRenderProcessCall:
                    return new CfxDomNodeGetPreviousSiblingRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetNextSiblingRenderProcessCall:
                    return new CfxDomNodeGetNextSiblingRenderProcessCall();
                case RemoteCallId.CfxDomNodeHasChildrenRenderProcessCall:
                    return new CfxDomNodeHasChildrenRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetFirstChildRenderProcessCall:
                    return new CfxDomNodeGetFirstChildRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetLastChildRenderProcessCall:
                    return new CfxDomNodeGetLastChildRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetElementTagNameRenderProcessCall:
                    return new CfxDomNodeGetElementTagNameRenderProcessCall();
                case RemoteCallId.CfxDomNodeHasElementAttributesRenderProcessCall:
                    return new CfxDomNodeHasElementAttributesRenderProcessCall();
                case RemoteCallId.CfxDomNodeHasElementAttributeRenderProcessCall:
                    return new CfxDomNodeHasElementAttributeRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetElementAttributeRenderProcessCall:
                    return new CfxDomNodeGetElementAttributeRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetElementAttributesRenderProcessCall:
                    return new CfxDomNodeGetElementAttributesRenderProcessCall();
                case RemoteCallId.CfxDomNodeSetElementAttributeRenderProcessCall:
                    return new CfxDomNodeSetElementAttributeRenderProcessCall();
                case RemoteCallId.CfxDomNodeGetElementInnerTextRenderProcessCall:
                    return new CfxDomNodeGetElementInnerTextRenderProcessCall();
                case RemoteCallId.CfxDomVisitorCtorRenderProcessCall:
                    return new CfxDomVisitorCtorRenderProcessCall();
                case RemoteCallId.CfxDomVisitorVisitBrowserProcessCall:
                    return new CfxDomVisitorVisitBrowserProcessCall();
                case RemoteCallId.CfxDomVisitorVisitActivateRenderProcessCall:
                    return new CfxDomVisitorVisitActivateRenderProcessCall();
                case RemoteCallId.CfxDomVisitorVisitDeactivateRenderProcessCall:
                    return new CfxDomVisitorVisitDeactivateRenderProcessCall();
                case RemoteCallId.CfxDomVisitorVisitGetDocumentRenderProcessCall:
                    return new CfxDomVisitorVisitGetDocumentRenderProcessCall();
                case RemoteCallId.CfxEndTracingCallbackOnEndTracingCompleteRenderProcessCall:
                    return new CfxEndTracingCallbackOnEndTracingCompleteRenderProcessCall();
                case RemoteCallId.CfxFrameIsValidRenderProcessCall:
                    return new CfxFrameIsValidRenderProcessCall();
                case RemoteCallId.CfxFrameUndoRenderProcessCall:
                    return new CfxFrameUndoRenderProcessCall();
                case RemoteCallId.CfxFrameRedoRenderProcessCall:
                    return new CfxFrameRedoRenderProcessCall();
                case RemoteCallId.CfxFrameCutRenderProcessCall:
                    return new CfxFrameCutRenderProcessCall();
                case RemoteCallId.CfxFrameCopyRenderProcessCall:
                    return new CfxFrameCopyRenderProcessCall();
                case RemoteCallId.CfxFramePasteRenderProcessCall:
                    return new CfxFramePasteRenderProcessCall();
                case RemoteCallId.CfxFrameDelRenderProcessCall:
                    return new CfxFrameDelRenderProcessCall();
                case RemoteCallId.CfxFrameSelectAllRenderProcessCall:
                    return new CfxFrameSelectAllRenderProcessCall();
                case RemoteCallId.CfxFrameGetSourceRenderProcessCall:
                    return new CfxFrameGetSourceRenderProcessCall();
                case RemoteCallId.CfxFrameGetTextRenderProcessCall:
                    return new CfxFrameGetTextRenderProcessCall();
                case RemoteCallId.CfxFrameLoadRequestRenderProcessCall:
                    return new CfxFrameLoadRequestRenderProcessCall();
                case RemoteCallId.CfxFrameLoadUrlRenderProcessCall:
                    return new CfxFrameLoadUrlRenderProcessCall();
                case RemoteCallId.CfxFrameLoadStringRenderProcessCall:
                    return new CfxFrameLoadStringRenderProcessCall();
                case RemoteCallId.CfxFrameExecuteJavaScriptRenderProcessCall:
                    return new CfxFrameExecuteJavaScriptRenderProcessCall();
                case RemoteCallId.CfxFrameIsMainRenderProcessCall:
                    return new CfxFrameIsMainRenderProcessCall();
                case RemoteCallId.CfxFrameIsFocusedRenderProcessCall:
                    return new CfxFrameIsFocusedRenderProcessCall();
                case RemoteCallId.CfxFrameGetNameRenderProcessCall:
                    return new CfxFrameGetNameRenderProcessCall();
                case RemoteCallId.CfxFrameGetIdentifierRenderProcessCall:
                    return new CfxFrameGetIdentifierRenderProcessCall();
                case RemoteCallId.CfxFrameGetParentRenderProcessCall:
                    return new CfxFrameGetParentRenderProcessCall();
                case RemoteCallId.CfxFrameGetUrlRenderProcessCall:
                    return new CfxFrameGetUrlRenderProcessCall();
                case RemoteCallId.CfxFrameGetBrowserRenderProcessCall:
                    return new CfxFrameGetBrowserRenderProcessCall();
                case RemoteCallId.CfxFrameGetV8ContextRenderProcessCall:
                    return new CfxFrameGetV8ContextRenderProcessCall();
                case RemoteCallId.CfxFrameVisitDomRenderProcessCall:
                    return new CfxFrameVisitDomRenderProcessCall();
                case RemoteCallId.CfxGeopositionCtorRenderProcessCall:
                    return new CfxGeopositionCtorRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetLatitudeRenderProcessCall:
                    return new CfxGeopositionGetLatitudeRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetLatitudeRenderProcessCall:
                    return new CfxGeopositionSetLatitudeRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetLongitudeRenderProcessCall:
                    return new CfxGeopositionGetLongitudeRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetLongitudeRenderProcessCall:
                    return new CfxGeopositionSetLongitudeRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetAltitudeRenderProcessCall:
                    return new CfxGeopositionGetAltitudeRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetAltitudeRenderProcessCall:
                    return new CfxGeopositionSetAltitudeRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetAccuracyRenderProcessCall:
                    return new CfxGeopositionGetAccuracyRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetAccuracyRenderProcessCall:
                    return new CfxGeopositionSetAccuracyRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetAltitudeAccuracyRenderProcessCall:
                    return new CfxGeopositionGetAltitudeAccuracyRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetAltitudeAccuracyRenderProcessCall:
                    return new CfxGeopositionSetAltitudeAccuracyRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetHeadingRenderProcessCall:
                    return new CfxGeopositionGetHeadingRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetHeadingRenderProcessCall:
                    return new CfxGeopositionSetHeadingRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetSpeedRenderProcessCall:
                    return new CfxGeopositionGetSpeedRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetSpeedRenderProcessCall:
                    return new CfxGeopositionSetSpeedRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetTimestampRenderProcessCall:
                    return new CfxGeopositionGetTimestampRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetTimestampRenderProcessCall:
                    return new CfxGeopositionSetTimestampRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetErrorCodeRenderProcessCall:
                    return new CfxGeopositionGetErrorCodeRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetErrorCodeRenderProcessCall:
                    return new CfxGeopositionSetErrorCodeRenderProcessCall();
                case RemoteCallId.CfxGeopositionGetErrorMessageRenderProcessCall:
                    return new CfxGeopositionGetErrorMessageRenderProcessCall();
                case RemoteCallId.CfxGeopositionSetErrorMessageRenderProcessCall:
                    return new CfxGeopositionSetErrorMessageRenderProcessCall();
                case RemoteCallId.CfxGetGeolocationCallbackCtorRenderProcessCall:
                    return new CfxGetGeolocationCallbackCtorRenderProcessCall();
                case RemoteCallId.CfxGetGeolocationCallbackOnLocationUpdateBrowserProcessCall:
                    return new CfxGetGeolocationCallbackOnLocationUpdateBrowserProcessCall();
                case RemoteCallId.CfxGetGeolocationCallbackOnLocationUpdateActivateRenderProcessCall:
                    return new CfxGetGeolocationCallbackOnLocationUpdateActivateRenderProcessCall();
                case RemoteCallId.CfxGetGeolocationCallbackOnLocationUpdateDeactivateRenderProcessCall:
                    return new CfxGetGeolocationCallbackOnLocationUpdateDeactivateRenderProcessCall();
                case RemoteCallId.CfxGetGeolocationCallbackOnLocationUpdateGetPositionRenderProcessCall:
                    return new CfxGetGeolocationCallbackOnLocationUpdateGetPositionRenderProcessCall();
                case RemoteCallId.CfxListValueCreateRenderProcessCall:
                    return new CfxListValueCreateRenderProcessCall();
                case RemoteCallId.CfxListValueIsValidRenderProcessCall:
                    return new CfxListValueIsValidRenderProcessCall();
                case RemoteCallId.CfxListValueIsOwnedRenderProcessCall:
                    return new CfxListValueIsOwnedRenderProcessCall();
                case RemoteCallId.CfxListValueIsReadOnlyRenderProcessCall:
                    return new CfxListValueIsReadOnlyRenderProcessCall();
                case RemoteCallId.CfxListValueCopyRenderProcessCall:
                    return new CfxListValueCopyRenderProcessCall();
                case RemoteCallId.CfxListValueSetSizeRenderProcessCall:
                    return new CfxListValueSetSizeRenderProcessCall();
                case RemoteCallId.CfxListValueGetSizeRenderProcessCall:
                    return new CfxListValueGetSizeRenderProcessCall();
                case RemoteCallId.CfxListValueClearRenderProcessCall:
                    return new CfxListValueClearRenderProcessCall();
                case RemoteCallId.CfxListValueRemoveRenderProcessCall:
                    return new CfxListValueRemoveRenderProcessCall();
                case RemoteCallId.CfxListValueGetTypeRenderProcessCall:
                    return new CfxListValueGetTypeRenderProcessCall();
                case RemoteCallId.CfxListValueGetBoolRenderProcessCall:
                    return new CfxListValueGetBoolRenderProcessCall();
                case RemoteCallId.CfxListValueGetIntRenderProcessCall:
                    return new CfxListValueGetIntRenderProcessCall();
                case RemoteCallId.CfxListValueGetDoubleRenderProcessCall:
                    return new CfxListValueGetDoubleRenderProcessCall();
                case RemoteCallId.CfxListValueGetStringRenderProcessCall:
                    return new CfxListValueGetStringRenderProcessCall();
                case RemoteCallId.CfxListValueGetBinaryRenderProcessCall:
                    return new CfxListValueGetBinaryRenderProcessCall();
                case RemoteCallId.CfxListValueGetDictionaryRenderProcessCall:
                    return new CfxListValueGetDictionaryRenderProcessCall();
                case RemoteCallId.CfxListValueGetListRenderProcessCall:
                    return new CfxListValueGetListRenderProcessCall();
                case RemoteCallId.CfxListValueSetNullRenderProcessCall:
                    return new CfxListValueSetNullRenderProcessCall();
                case RemoteCallId.CfxListValueSetBoolRenderProcessCall:
                    return new CfxListValueSetBoolRenderProcessCall();
                case RemoteCallId.CfxListValueSetIntRenderProcessCall:
                    return new CfxListValueSetIntRenderProcessCall();
                case RemoteCallId.CfxListValueSetDoubleRenderProcessCall:
                    return new CfxListValueSetDoubleRenderProcessCall();
                case RemoteCallId.CfxListValueSetStringRenderProcessCall:
                    return new CfxListValueSetStringRenderProcessCall();
                case RemoteCallId.CfxListValueSetBinaryRenderProcessCall:
                    return new CfxListValueSetBinaryRenderProcessCall();
                case RemoteCallId.CfxListValueSetDictionaryRenderProcessCall:
                    return new CfxListValueSetDictionaryRenderProcessCall();
                case RemoteCallId.CfxListValueSetListRenderProcessCall:
                    return new CfxListValueSetListRenderProcessCall();
                case RemoteCallId.CfxLoadHandlerCtorRenderProcessCall:
                    return new CfxLoadHandlerCtorRenderProcessCall();
                case RemoteCallId.CfxOnLoadingStateChangeBrowserProcessCall:
                    return new CfxOnLoadingStateChangeBrowserProcessCall();
                case RemoteCallId.CfxOnLoadingStateChangeActivateRenderProcessCall:
                    return new CfxOnLoadingStateChangeActivateRenderProcessCall();
                case RemoteCallId.CfxOnLoadingStateChangeDeactivateRenderProcessCall:
                    return new CfxOnLoadingStateChangeDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnLoadingStateChangeGetBrowserRenderProcessCall:
                    return new CfxOnLoadingStateChangeGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnLoadingStateChangeGetIsLoadingRenderProcessCall:
                    return new CfxOnLoadingStateChangeGetIsLoadingRenderProcessCall();
                case RemoteCallId.CfxOnLoadingStateChangeGetCanGoBackRenderProcessCall:
                    return new CfxOnLoadingStateChangeGetCanGoBackRenderProcessCall();
                case RemoteCallId.CfxOnLoadingStateChangeGetCanGoForwardRenderProcessCall:
                    return new CfxOnLoadingStateChangeGetCanGoForwardRenderProcessCall();
                case RemoteCallId.CfxOnLoadStartBrowserProcessCall:
                    return new CfxOnLoadStartBrowserProcessCall();
                case RemoteCallId.CfxOnLoadStartActivateRenderProcessCall:
                    return new CfxOnLoadStartActivateRenderProcessCall();
                case RemoteCallId.CfxOnLoadStartDeactivateRenderProcessCall:
                    return new CfxOnLoadStartDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnLoadStartGetBrowserRenderProcessCall:
                    return new CfxOnLoadStartGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnLoadStartGetFrameRenderProcessCall:
                    return new CfxOnLoadStartGetFrameRenderProcessCall();
                case RemoteCallId.CfxOnLoadEndBrowserProcessCall:
                    return new CfxOnLoadEndBrowserProcessCall();
                case RemoteCallId.CfxOnLoadEndActivateRenderProcessCall:
                    return new CfxOnLoadEndActivateRenderProcessCall();
                case RemoteCallId.CfxOnLoadEndDeactivateRenderProcessCall:
                    return new CfxOnLoadEndDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnLoadEndGetBrowserRenderProcessCall:
                    return new CfxOnLoadEndGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnLoadEndGetFrameRenderProcessCall:
                    return new CfxOnLoadEndGetFrameRenderProcessCall();
                case RemoteCallId.CfxOnLoadEndGetHttpStatusCodeRenderProcessCall:
                    return new CfxOnLoadEndGetHttpStatusCodeRenderProcessCall();
                case RemoteCallId.CfxOnLoadErrorBrowserProcessCall:
                    return new CfxOnLoadErrorBrowserProcessCall();
                case RemoteCallId.CfxOnLoadErrorActivateRenderProcessCall:
                    return new CfxOnLoadErrorActivateRenderProcessCall();
                case RemoteCallId.CfxOnLoadErrorDeactivateRenderProcessCall:
                    return new CfxOnLoadErrorDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnLoadErrorGetBrowserRenderProcessCall:
                    return new CfxOnLoadErrorGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnLoadErrorGetFrameRenderProcessCall:
                    return new CfxOnLoadErrorGetFrameRenderProcessCall();
                case RemoteCallId.CfxOnLoadErrorGetErrorCodeRenderProcessCall:
                    return new CfxOnLoadErrorGetErrorCodeRenderProcessCall();
                case RemoteCallId.CfxOnLoadErrorGetErrorTextRenderProcessCall:
                    return new CfxOnLoadErrorGetErrorTextRenderProcessCall();
                case RemoteCallId.CfxOnLoadErrorGetFailedUrlRenderProcessCall:
                    return new CfxOnLoadErrorGetFailedUrlRenderProcessCall();
                case RemoteCallId.CfxPostDataCreateRenderProcessCall:
                    return new CfxPostDataCreateRenderProcessCall();
                case RemoteCallId.CfxPostDataIsReadOnlyRenderProcessCall:
                    return new CfxPostDataIsReadOnlyRenderProcessCall();
                case RemoteCallId.CfxPostDataGetElementCountRenderProcessCall:
                    return new CfxPostDataGetElementCountRenderProcessCall();
                case RemoteCallId.CfxPostDataGetElementsRenderProcessCall:
                    return new CfxPostDataGetElementsRenderProcessCall();
                case RemoteCallId.CfxPostDataRemoveElementRenderProcessCall:
                    return new CfxPostDataRemoveElementRenderProcessCall();
                case RemoteCallId.CfxPostDataAddElementRenderProcessCall:
                    return new CfxPostDataAddElementRenderProcessCall();
                case RemoteCallId.CfxPostDataRemoveElementsRenderProcessCall:
                    return new CfxPostDataRemoveElementsRenderProcessCall();
                case RemoteCallId.CfxPostDataElementCreateRenderProcessCall:
                    return new CfxPostDataElementCreateRenderProcessCall();
                case RemoteCallId.CfxPostDataElementIsReadOnlyRenderProcessCall:
                    return new CfxPostDataElementIsReadOnlyRenderProcessCall();
                case RemoteCallId.CfxPostDataElementSetToEmptyRenderProcessCall:
                    return new CfxPostDataElementSetToEmptyRenderProcessCall();
                case RemoteCallId.CfxPostDataElementSetToFileRenderProcessCall:
                    return new CfxPostDataElementSetToFileRenderProcessCall();
                case RemoteCallId.CfxPostDataElementSetToBytesRenderProcessCall:
                    return new CfxPostDataElementSetToBytesRenderProcessCall();
                case RemoteCallId.CfxPostDataElementGetTypeRenderProcessCall:
                    return new CfxPostDataElementGetTypeRenderProcessCall();
                case RemoteCallId.CfxPostDataElementGetFileRenderProcessCall:
                    return new CfxPostDataElementGetFileRenderProcessCall();
                case RemoteCallId.CfxPostDataElementGetBytesCountRenderProcessCall:
                    return new CfxPostDataElementGetBytesCountRenderProcessCall();
                case RemoteCallId.CfxPostDataElementGetBytesRenderProcessCall:
                    return new CfxPostDataElementGetBytesRenderProcessCall();
                case RemoteCallId.CfxProcessMessageCreateRenderProcessCall:
                    return new CfxProcessMessageCreateRenderProcessCall();
                case RemoteCallId.CfxProcessMessageIsValidRenderProcessCall:
                    return new CfxProcessMessageIsValidRenderProcessCall();
                case RemoteCallId.CfxProcessMessageIsReadOnlyRenderProcessCall:
                    return new CfxProcessMessageIsReadOnlyRenderProcessCall();
                case RemoteCallId.CfxProcessMessageCopyRenderProcessCall:
                    return new CfxProcessMessageCopyRenderProcessCall();
                case RemoteCallId.CfxProcessMessageGetNameRenderProcessCall:
                    return new CfxProcessMessageGetNameRenderProcessCall();
                case RemoteCallId.CfxProcessMessageGetArgumentListRenderProcessCall:
                    return new CfxProcessMessageGetArgumentListRenderProcessCall();
                case RemoteCallId.CfxRenderProcessHandlerCtorRenderProcessCall:
                    return new CfxRenderProcessHandlerCtorRenderProcessCall();
                case RemoteCallId.CfxOnRenderThreadCreatedBrowserProcessCall:
                    return new CfxOnRenderThreadCreatedBrowserProcessCall();
                case RemoteCallId.CfxOnRenderThreadCreatedActivateRenderProcessCall:
                    return new CfxOnRenderThreadCreatedActivateRenderProcessCall();
                case RemoteCallId.CfxOnRenderThreadCreatedDeactivateRenderProcessCall:
                    return new CfxOnRenderThreadCreatedDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnRenderThreadCreatedGetExtraInfoRenderProcessCall:
                    return new CfxOnRenderThreadCreatedGetExtraInfoRenderProcessCall();
                case RemoteCallId.CfxOnWebKitInitializedBrowserProcessCall:
                    return new CfxOnWebKitInitializedBrowserProcessCall();
                case RemoteCallId.CfxOnWebKitInitializedActivateRenderProcessCall:
                    return new CfxOnWebKitInitializedActivateRenderProcessCall();
                case RemoteCallId.CfxOnWebKitInitializedDeactivateRenderProcessCall:
                    return new CfxOnWebKitInitializedDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnBrowserCreatedBrowserProcessCall:
                    return new CfxOnBrowserCreatedBrowserProcessCall();
                case RemoteCallId.CfxOnBrowserCreatedActivateRenderProcessCall:
                    return new CfxOnBrowserCreatedActivateRenderProcessCall();
                case RemoteCallId.CfxOnBrowserCreatedDeactivateRenderProcessCall:
                    return new CfxOnBrowserCreatedDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnBrowserCreatedGetBrowserRenderProcessCall:
                    return new CfxOnBrowserCreatedGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnBrowserDestroyedBrowserProcessCall:
                    return new CfxOnBrowserDestroyedBrowserProcessCall();
                case RemoteCallId.CfxOnBrowserDestroyedActivateRenderProcessCall:
                    return new CfxOnBrowserDestroyedActivateRenderProcessCall();
                case RemoteCallId.CfxOnBrowserDestroyedDeactivateRenderProcessCall:
                    return new CfxOnBrowserDestroyedDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnBrowserDestroyedGetBrowserRenderProcessCall:
                    return new CfxOnBrowserDestroyedGetBrowserRenderProcessCall();
                case RemoteCallId.CfxGetLoadHandlerBrowserProcessCall:
                    return new CfxGetLoadHandlerBrowserProcessCall();
                case RemoteCallId.CfxGetLoadHandlerActivateRenderProcessCall:
                    return new CfxGetLoadHandlerActivateRenderProcessCall();
                case RemoteCallId.CfxGetLoadHandlerDeactivateRenderProcessCall:
                    return new CfxGetLoadHandlerDeactivateRenderProcessCall();
                case RemoteCallId.CfxGetLoadHandlerSetReturnValueRenderProcessCall:
                    return new CfxGetLoadHandlerSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationBrowserProcessCall:
                    return new CfxOnBeforeNavigationBrowserProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationActivateRenderProcessCall:
                    return new CfxOnBeforeNavigationActivateRenderProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationDeactivateRenderProcessCall:
                    return new CfxOnBeforeNavigationDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationGetBrowserRenderProcessCall:
                    return new CfxOnBeforeNavigationGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationGetFrameRenderProcessCall:
                    return new CfxOnBeforeNavigationGetFrameRenderProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationGetRequestRenderProcessCall:
                    return new CfxOnBeforeNavigationGetRequestRenderProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationGetNavigationTypeRenderProcessCall:
                    return new CfxOnBeforeNavigationGetNavigationTypeRenderProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationGetIsRedirectRenderProcessCall:
                    return new CfxOnBeforeNavigationGetIsRedirectRenderProcessCall();
                case RemoteCallId.CfxOnBeforeNavigationSetReturnValueRenderProcessCall:
                    return new CfxOnBeforeNavigationSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxOnContextCreatedBrowserProcessCall:
                    return new CfxOnContextCreatedBrowserProcessCall();
                case RemoteCallId.CfxOnContextCreatedActivateRenderProcessCall:
                    return new CfxOnContextCreatedActivateRenderProcessCall();
                case RemoteCallId.CfxOnContextCreatedDeactivateRenderProcessCall:
                    return new CfxOnContextCreatedDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnContextCreatedGetBrowserRenderProcessCall:
                    return new CfxOnContextCreatedGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnContextCreatedGetFrameRenderProcessCall:
                    return new CfxOnContextCreatedGetFrameRenderProcessCall();
                case RemoteCallId.CfxOnContextCreatedGetContextRenderProcessCall:
                    return new CfxOnContextCreatedGetContextRenderProcessCall();
                case RemoteCallId.CfxOnContextReleasedBrowserProcessCall:
                    return new CfxOnContextReleasedBrowserProcessCall();
                case RemoteCallId.CfxOnContextReleasedActivateRenderProcessCall:
                    return new CfxOnContextReleasedActivateRenderProcessCall();
                case RemoteCallId.CfxOnContextReleasedDeactivateRenderProcessCall:
                    return new CfxOnContextReleasedDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnContextReleasedGetBrowserRenderProcessCall:
                    return new CfxOnContextReleasedGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnContextReleasedGetFrameRenderProcessCall:
                    return new CfxOnContextReleasedGetFrameRenderProcessCall();
                case RemoteCallId.CfxOnContextReleasedGetContextRenderProcessCall:
                    return new CfxOnContextReleasedGetContextRenderProcessCall();
                case RemoteCallId.CfxOnUncaughtExceptionBrowserProcessCall:
                    return new CfxOnUncaughtExceptionBrowserProcessCall();
                case RemoteCallId.CfxOnUncaughtExceptionActivateRenderProcessCall:
                    return new CfxOnUncaughtExceptionActivateRenderProcessCall();
                case RemoteCallId.CfxOnUncaughtExceptionDeactivateRenderProcessCall:
                    return new CfxOnUncaughtExceptionDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnUncaughtExceptionGetBrowserRenderProcessCall:
                    return new CfxOnUncaughtExceptionGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnUncaughtExceptionGetFrameRenderProcessCall:
                    return new CfxOnUncaughtExceptionGetFrameRenderProcessCall();
                case RemoteCallId.CfxOnUncaughtExceptionGetContextRenderProcessCall:
                    return new CfxOnUncaughtExceptionGetContextRenderProcessCall();
                case RemoteCallId.CfxOnUncaughtExceptionGetExceptionRenderProcessCall:
                    return new CfxOnUncaughtExceptionGetExceptionRenderProcessCall();
                case RemoteCallId.CfxOnUncaughtExceptionGetStackTraceRenderProcessCall:
                    return new CfxOnUncaughtExceptionGetStackTraceRenderProcessCall();
                case RemoteCallId.CfxOnFocusedNodeChangedBrowserProcessCall:
                    return new CfxOnFocusedNodeChangedBrowserProcessCall();
                case RemoteCallId.CfxOnFocusedNodeChangedActivateRenderProcessCall:
                    return new CfxOnFocusedNodeChangedActivateRenderProcessCall();
                case RemoteCallId.CfxOnFocusedNodeChangedDeactivateRenderProcessCall:
                    return new CfxOnFocusedNodeChangedDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnFocusedNodeChangedGetBrowserRenderProcessCall:
                    return new CfxOnFocusedNodeChangedGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnFocusedNodeChangedGetFrameRenderProcessCall:
                    return new CfxOnFocusedNodeChangedGetFrameRenderProcessCall();
                case RemoteCallId.CfxOnFocusedNodeChangedGetNodeRenderProcessCall:
                    return new CfxOnFocusedNodeChangedGetNodeRenderProcessCall();
                case RemoteCallId.CfxOnProcessMessageReceivedBrowserProcessCall:
                    return new CfxOnProcessMessageReceivedBrowserProcessCall();
                case RemoteCallId.CfxOnProcessMessageReceivedActivateRenderProcessCall:
                    return new CfxOnProcessMessageReceivedActivateRenderProcessCall();
                case RemoteCallId.CfxOnProcessMessageReceivedDeactivateRenderProcessCall:
                    return new CfxOnProcessMessageReceivedDeactivateRenderProcessCall();
                case RemoteCallId.CfxOnProcessMessageReceivedGetBrowserRenderProcessCall:
                    return new CfxOnProcessMessageReceivedGetBrowserRenderProcessCall();
                case RemoteCallId.CfxOnProcessMessageReceivedGetSourceProcessRenderProcessCall:
                    return new CfxOnProcessMessageReceivedGetSourceProcessRenderProcessCall();
                case RemoteCallId.CfxOnProcessMessageReceivedGetMessageRenderProcessCall:
                    return new CfxOnProcessMessageReceivedGetMessageRenderProcessCall();
                case RemoteCallId.CfxOnProcessMessageReceivedSetReturnValueRenderProcessCall:
                    return new CfxOnProcessMessageReceivedSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxRequestCreateRenderProcessCall:
                    return new CfxRequestCreateRenderProcessCall();
                case RemoteCallId.CfxRequestIsReadOnlyRenderProcessCall:
                    return new CfxRequestIsReadOnlyRenderProcessCall();
                case RemoteCallId.CfxRequestGetUrlRenderProcessCall:
                    return new CfxRequestGetUrlRenderProcessCall();
                case RemoteCallId.CfxRequestSetUrlRenderProcessCall:
                    return new CfxRequestSetUrlRenderProcessCall();
                case RemoteCallId.CfxRequestGetMethodRenderProcessCall:
                    return new CfxRequestGetMethodRenderProcessCall();
                case RemoteCallId.CfxRequestSetMethodRenderProcessCall:
                    return new CfxRequestSetMethodRenderProcessCall();
                case RemoteCallId.CfxRequestGetPostDataRenderProcessCall:
                    return new CfxRequestGetPostDataRenderProcessCall();
                case RemoteCallId.CfxRequestSetPostDataRenderProcessCall:
                    return new CfxRequestSetPostDataRenderProcessCall();
                case RemoteCallId.CfxRequestGetHeaderMapRenderProcessCall:
                    return new CfxRequestGetHeaderMapRenderProcessCall();
                case RemoteCallId.CfxRequestSetHeaderMapRenderProcessCall:
                    return new CfxRequestSetHeaderMapRenderProcessCall();
                case RemoteCallId.CfxRequestSetRenderProcessCall:
                    return new CfxRequestSetRenderProcessCall();
                case RemoteCallId.CfxRequestGetFlagsRenderProcessCall:
                    return new CfxRequestGetFlagsRenderProcessCall();
                case RemoteCallId.CfxRequestSetFlagsRenderProcessCall:
                    return new CfxRequestSetFlagsRenderProcessCall();
                case RemoteCallId.CfxRequestGetFirstPartyForCookiesRenderProcessCall:
                    return new CfxRequestGetFirstPartyForCookiesRenderProcessCall();
                case RemoteCallId.CfxRequestSetFirstPartyForCookiesRenderProcessCall:
                    return new CfxRequestSetFirstPartyForCookiesRenderProcessCall();
                case RemoteCallId.CfxRequestGetResourceTypeRenderProcessCall:
                    return new CfxRequestGetResourceTypeRenderProcessCall();
                case RemoteCallId.CfxRequestGetTransitionTypeRenderProcessCall:
                    return new CfxRequestGetTransitionTypeRenderProcessCall();
                case RemoteCallId.CfxResourceBundleHandlerCtorRenderProcessCall:
                    return new CfxResourceBundleHandlerCtorRenderProcessCall();
                case RemoteCallId.CfxGetLocalizedStringBrowserProcessCall:
                    return new CfxGetLocalizedStringBrowserProcessCall();
                case RemoteCallId.CfxGetLocalizedStringActivateRenderProcessCall:
                    return new CfxGetLocalizedStringActivateRenderProcessCall();
                case RemoteCallId.CfxGetLocalizedStringDeactivateRenderProcessCall:
                    return new CfxGetLocalizedStringDeactivateRenderProcessCall();
                case RemoteCallId.CfxGetLocalizedStringGetMessageIdRenderProcessCall:
                    return new CfxGetLocalizedStringGetMessageIdRenderProcessCall();
                case RemoteCallId.CfxGetLocalizedStringSetStringRenderProcessCall:
                    return new CfxGetLocalizedStringSetStringRenderProcessCall();
                case RemoteCallId.CfxGetLocalizedStringGetStringRenderProcessCall:
                    return new CfxGetLocalizedStringGetStringRenderProcessCall();
                case RemoteCallId.CfxGetLocalizedStringSetReturnValueRenderProcessCall:
                    return new CfxGetLocalizedStringSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxGetDataResourceBrowserProcessCall:
                    return new CfxGetDataResourceBrowserProcessCall();
                case RemoteCallId.CfxGetDataResourceActivateRenderProcessCall:
                    return new CfxGetDataResourceActivateRenderProcessCall();
                case RemoteCallId.CfxGetDataResourceDeactivateRenderProcessCall:
                    return new CfxGetDataResourceDeactivateRenderProcessCall();
                case RemoteCallId.CfxGetDataResourceGetResourceIdRenderProcessCall:
                    return new CfxGetDataResourceGetResourceIdRenderProcessCall();
                case RemoteCallId.CfxGetDataResourceSetDataRenderProcessCall:
                    return new CfxGetDataResourceSetDataRenderProcessCall();
                case RemoteCallId.CfxGetDataResourceSetDataSizeRenderProcessCall:
                    return new CfxGetDataResourceSetDataSizeRenderProcessCall();
                case RemoteCallId.CfxGetDataResourceSetReturnValueRenderProcessCall:
                    return new CfxGetDataResourceSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxSchemeRegistrarAddCustomSchemeRenderProcessCall:
                    return new CfxSchemeRegistrarAddCustomSchemeRenderProcessCall();
                case RemoteCallId.CfxStringVisitorCtorRenderProcessCall:
                    return new CfxStringVisitorCtorRenderProcessCall();
                case RemoteCallId.CfxStringVisitorVisitBrowserProcessCall:
                    return new CfxStringVisitorVisitBrowserProcessCall();
                case RemoteCallId.CfxStringVisitorVisitActivateRenderProcessCall:
                    return new CfxStringVisitorVisitActivateRenderProcessCall();
                case RemoteCallId.CfxStringVisitorVisitDeactivateRenderProcessCall:
                    return new CfxStringVisitorVisitDeactivateRenderProcessCall();
                case RemoteCallId.CfxStringVisitorVisitGetStringRenderProcessCall:
                    return new CfxStringVisitorVisitGetStringRenderProcessCall();
                case RemoteCallId.CfxTaskCtorRenderProcessCall:
                    return new CfxTaskCtorRenderProcessCall();
                case RemoteCallId.CfxTaskExecuteBrowserProcessCall:
                    return new CfxTaskExecuteBrowserProcessCall();
                case RemoteCallId.CfxTaskExecuteActivateRenderProcessCall:
                    return new CfxTaskExecuteActivateRenderProcessCall();
                case RemoteCallId.CfxTaskExecuteDeactivateRenderProcessCall:
                    return new CfxTaskExecuteDeactivateRenderProcessCall();
                case RemoteCallId.CfxTaskRunnerGetForCurrentThreadRenderProcessCall:
                    return new CfxTaskRunnerGetForCurrentThreadRenderProcessCall();
                case RemoteCallId.CfxTaskRunnerGetForThreadRenderProcessCall:
                    return new CfxTaskRunnerGetForThreadRenderProcessCall();
                case RemoteCallId.CfxTaskRunnerIsSameRenderProcessCall:
                    return new CfxTaskRunnerIsSameRenderProcessCall();
                case RemoteCallId.CfxTaskRunnerBelongsToCurrentThreadRenderProcessCall:
                    return new CfxTaskRunnerBelongsToCurrentThreadRenderProcessCall();
                case RemoteCallId.CfxTaskRunnerBelongsToThreadRenderProcessCall:
                    return new CfxTaskRunnerBelongsToThreadRenderProcessCall();
                case RemoteCallId.CfxTaskRunnerPostTaskRenderProcessCall:
                    return new CfxTaskRunnerPostTaskRenderProcessCall();
                case RemoteCallId.CfxTaskRunnerPostDelayedTaskRenderProcessCall:
                    return new CfxTaskRunnerPostDelayedTaskRenderProcessCall();
                case RemoteCallId.CfxTimeCtorRenderProcessCall:
                    return new CfxTimeCtorRenderProcessCall();
                case RemoteCallId.CfxTimeGetYearRenderProcessCall:
                    return new CfxTimeGetYearRenderProcessCall();
                case RemoteCallId.CfxTimeSetYearRenderProcessCall:
                    return new CfxTimeSetYearRenderProcessCall();
                case RemoteCallId.CfxTimeGetMonthRenderProcessCall:
                    return new CfxTimeGetMonthRenderProcessCall();
                case RemoteCallId.CfxTimeSetMonthRenderProcessCall:
                    return new CfxTimeSetMonthRenderProcessCall();
                case RemoteCallId.CfxTimeGetDayOfWeekRenderProcessCall:
                    return new CfxTimeGetDayOfWeekRenderProcessCall();
                case RemoteCallId.CfxTimeSetDayOfWeekRenderProcessCall:
                    return new CfxTimeSetDayOfWeekRenderProcessCall();
                case RemoteCallId.CfxTimeGetDayOfMonthRenderProcessCall:
                    return new CfxTimeGetDayOfMonthRenderProcessCall();
                case RemoteCallId.CfxTimeSetDayOfMonthRenderProcessCall:
                    return new CfxTimeSetDayOfMonthRenderProcessCall();
                case RemoteCallId.CfxTimeGetHourRenderProcessCall:
                    return new CfxTimeGetHourRenderProcessCall();
                case RemoteCallId.CfxTimeSetHourRenderProcessCall:
                    return new CfxTimeSetHourRenderProcessCall();
                case RemoteCallId.CfxTimeGetMinuteRenderProcessCall:
                    return new CfxTimeGetMinuteRenderProcessCall();
                case RemoteCallId.CfxTimeSetMinuteRenderProcessCall:
                    return new CfxTimeSetMinuteRenderProcessCall();
                case RemoteCallId.CfxTimeGetSecondRenderProcessCall:
                    return new CfxTimeGetSecondRenderProcessCall();
                case RemoteCallId.CfxTimeSetSecondRenderProcessCall:
                    return new CfxTimeSetSecondRenderProcessCall();
                case RemoteCallId.CfxTimeGetMillisecondRenderProcessCall:
                    return new CfxTimeGetMillisecondRenderProcessCall();
                case RemoteCallId.CfxTimeSetMillisecondRenderProcessCall:
                    return new CfxTimeSetMillisecondRenderProcessCall();
                case RemoteCallId.CfxUrlPartsCtorRenderProcessCall:
                    return new CfxUrlPartsCtorRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetSpecRenderProcessCall:
                    return new CfxUrlPartsGetSpecRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetSpecRenderProcessCall:
                    return new CfxUrlPartsSetSpecRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetSchemeRenderProcessCall:
                    return new CfxUrlPartsGetSchemeRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetSchemeRenderProcessCall:
                    return new CfxUrlPartsSetSchemeRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetUserNameRenderProcessCall:
                    return new CfxUrlPartsGetUserNameRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetUserNameRenderProcessCall:
                    return new CfxUrlPartsSetUserNameRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetPasswordRenderProcessCall:
                    return new CfxUrlPartsGetPasswordRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetPasswordRenderProcessCall:
                    return new CfxUrlPartsSetPasswordRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetHostRenderProcessCall:
                    return new CfxUrlPartsGetHostRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetHostRenderProcessCall:
                    return new CfxUrlPartsSetHostRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetPortRenderProcessCall:
                    return new CfxUrlPartsGetPortRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetPortRenderProcessCall:
                    return new CfxUrlPartsSetPortRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetOriginRenderProcessCall:
                    return new CfxUrlPartsGetOriginRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetOriginRenderProcessCall:
                    return new CfxUrlPartsSetOriginRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetPathRenderProcessCall:
                    return new CfxUrlPartsGetPathRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetPathRenderProcessCall:
                    return new CfxUrlPartsSetPathRenderProcessCall();
                case RemoteCallId.CfxUrlPartsGetQueryRenderProcessCall:
                    return new CfxUrlPartsGetQueryRenderProcessCall();
                case RemoteCallId.CfxUrlPartsSetQueryRenderProcessCall:
                    return new CfxUrlPartsSetQueryRenderProcessCall();
                case RemoteCallId.CfxV8AccessorCtorRenderProcessCall:
                    return new CfxV8AccessorCtorRenderProcessCall();
                case RemoteCallId.CfxV8AccessorGetBrowserProcessCall:
                    return new CfxV8AccessorGetBrowserProcessCall();
                case RemoteCallId.CfxV8AccessorGetActivateRenderProcessCall:
                    return new CfxV8AccessorGetActivateRenderProcessCall();
                case RemoteCallId.CfxV8AccessorGetDeactivateRenderProcessCall:
                    return new CfxV8AccessorGetDeactivateRenderProcessCall();
                case RemoteCallId.CfxV8AccessorGetGetNameRenderProcessCall:
                    return new CfxV8AccessorGetGetNameRenderProcessCall();
                case RemoteCallId.CfxV8AccessorGetGetObjectRenderProcessCall:
                    return new CfxV8AccessorGetGetObjectRenderProcessCall();
                case RemoteCallId.CfxV8AccessorGetSetRetvalRenderProcessCall:
                    return new CfxV8AccessorGetSetRetvalRenderProcessCall();
                case RemoteCallId.CfxV8AccessorGetSetExceptionRenderProcessCall:
                    return new CfxV8AccessorGetSetExceptionRenderProcessCall();
                case RemoteCallId.CfxV8AccessorGetGetExceptionRenderProcessCall:
                    return new CfxV8AccessorGetGetExceptionRenderProcessCall();
                case RemoteCallId.CfxV8AccessorGetSetReturnValueRenderProcessCall:
                    return new CfxV8AccessorGetSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxV8AccessorSetBrowserProcessCall:
                    return new CfxV8AccessorSetBrowserProcessCall();
                case RemoteCallId.CfxV8AccessorSetActivateRenderProcessCall:
                    return new CfxV8AccessorSetActivateRenderProcessCall();
                case RemoteCallId.CfxV8AccessorSetDeactivateRenderProcessCall:
                    return new CfxV8AccessorSetDeactivateRenderProcessCall();
                case RemoteCallId.CfxV8AccessorSetGetNameRenderProcessCall:
                    return new CfxV8AccessorSetGetNameRenderProcessCall();
                case RemoteCallId.CfxV8AccessorSetGetObjectRenderProcessCall:
                    return new CfxV8AccessorSetGetObjectRenderProcessCall();
                case RemoteCallId.CfxV8AccessorSetGetValueRenderProcessCall:
                    return new CfxV8AccessorSetGetValueRenderProcessCall();
                case RemoteCallId.CfxV8AccessorSetSetExceptionRenderProcessCall:
                    return new CfxV8AccessorSetSetExceptionRenderProcessCall();
                case RemoteCallId.CfxV8AccessorSetGetExceptionRenderProcessCall:
                    return new CfxV8AccessorSetGetExceptionRenderProcessCall();
                case RemoteCallId.CfxV8AccessorSetSetReturnValueRenderProcessCall:
                    return new CfxV8AccessorSetSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxV8ContextGetCurrentContextRenderProcessCall:
                    return new CfxV8ContextGetCurrentContextRenderProcessCall();
                case RemoteCallId.CfxV8ContextGetEnteredContextRenderProcessCall:
                    return new CfxV8ContextGetEnteredContextRenderProcessCall();
                case RemoteCallId.CfxV8ContextInContextRenderProcessCall:
                    return new CfxV8ContextInContextRenderProcessCall();
                case RemoteCallId.CfxV8ContextGetTaskRunnerRenderProcessCall:
                    return new CfxV8ContextGetTaskRunnerRenderProcessCall();
                case RemoteCallId.CfxV8ContextIsValidRenderProcessCall:
                    return new CfxV8ContextIsValidRenderProcessCall();
                case RemoteCallId.CfxV8ContextGetBrowserRenderProcessCall:
                    return new CfxV8ContextGetBrowserRenderProcessCall();
                case RemoteCallId.CfxV8ContextGetFrameRenderProcessCall:
                    return new CfxV8ContextGetFrameRenderProcessCall();
                case RemoteCallId.CfxV8ContextGetGlobalRenderProcessCall:
                    return new CfxV8ContextGetGlobalRenderProcessCall();
                case RemoteCallId.CfxV8ContextEnterRenderProcessCall:
                    return new CfxV8ContextEnterRenderProcessCall();
                case RemoteCallId.CfxV8ContextExitRenderProcessCall:
                    return new CfxV8ContextExitRenderProcessCall();
                case RemoteCallId.CfxV8ContextIsSameRenderProcessCall:
                    return new CfxV8ContextIsSameRenderProcessCall();
                case RemoteCallId.CfxV8ContextEvalRenderProcessCall:
                    return new CfxV8ContextEvalRenderProcessCall();
                case RemoteCallId.CfxV8ExceptionGetMessageRenderProcessCall:
                    return new CfxV8ExceptionGetMessageRenderProcessCall();
                case RemoteCallId.CfxV8ExceptionGetSourceLineRenderProcessCall:
                    return new CfxV8ExceptionGetSourceLineRenderProcessCall();
                case RemoteCallId.CfxV8ExceptionGetScriptResourceNameRenderProcessCall:
                    return new CfxV8ExceptionGetScriptResourceNameRenderProcessCall();
                case RemoteCallId.CfxV8ExceptionGetLineNumberRenderProcessCall:
                    return new CfxV8ExceptionGetLineNumberRenderProcessCall();
                case RemoteCallId.CfxV8ExceptionGetStartPositionRenderProcessCall:
                    return new CfxV8ExceptionGetStartPositionRenderProcessCall();
                case RemoteCallId.CfxV8ExceptionGetEndPositionRenderProcessCall:
                    return new CfxV8ExceptionGetEndPositionRenderProcessCall();
                case RemoteCallId.CfxV8ExceptionGetStartColumnRenderProcessCall:
                    return new CfxV8ExceptionGetStartColumnRenderProcessCall();
                case RemoteCallId.CfxV8ExceptionGetEndColumnRenderProcessCall:
                    return new CfxV8ExceptionGetEndColumnRenderProcessCall();
                case RemoteCallId.CfxV8HandlerCtorRenderProcessCall:
                    return new CfxV8HandlerCtorRenderProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteBrowserProcessCall:
                    return new CfxV8HandlerExecuteBrowserProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteActivateRenderProcessCall:
                    return new CfxV8HandlerExecuteActivateRenderProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteDeactivateRenderProcessCall:
                    return new CfxV8HandlerExecuteDeactivateRenderProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteGetNameRenderProcessCall:
                    return new CfxV8HandlerExecuteGetNameRenderProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteGetObjectRenderProcessCall:
                    return new CfxV8HandlerExecuteGetObjectRenderProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteGetArgumentsRenderProcessCall:
                    return new CfxV8HandlerExecuteGetArgumentsRenderProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteSetExceptionRenderProcessCall:
                    return new CfxV8HandlerExecuteSetExceptionRenderProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteGetExceptionRenderProcessCall:
                    return new CfxV8HandlerExecuteGetExceptionRenderProcessCall();
                case RemoteCallId.CfxV8HandlerExecuteSetReturnValueRenderProcessCall:
                    return new CfxV8HandlerExecuteSetReturnValueRenderProcessCall();
                case RemoteCallId.CfxV8StackFrameIsValidRenderProcessCall:
                    return new CfxV8StackFrameIsValidRenderProcessCall();
                case RemoteCallId.CfxV8StackFrameGetScriptNameRenderProcessCall:
                    return new CfxV8StackFrameGetScriptNameRenderProcessCall();
                case RemoteCallId.CfxV8StackFrameGetScriptNameOrSourceUrlRenderProcessCall:
                    return new CfxV8StackFrameGetScriptNameOrSourceUrlRenderProcessCall();
                case RemoteCallId.CfxV8StackFrameGetFunctionNameRenderProcessCall:
                    return new CfxV8StackFrameGetFunctionNameRenderProcessCall();
                case RemoteCallId.CfxV8StackFrameGetLineNumberRenderProcessCall:
                    return new CfxV8StackFrameGetLineNumberRenderProcessCall();
                case RemoteCallId.CfxV8StackFrameGetColumnRenderProcessCall:
                    return new CfxV8StackFrameGetColumnRenderProcessCall();
                case RemoteCallId.CfxV8StackFrameIsEvalRenderProcessCall:
                    return new CfxV8StackFrameIsEvalRenderProcessCall();
                case RemoteCallId.CfxV8StackFrameIsConstructorRenderProcessCall:
                    return new CfxV8StackFrameIsConstructorRenderProcessCall();
                case RemoteCallId.CfxV8StackTraceGetCurrentRenderProcessCall:
                    return new CfxV8StackTraceGetCurrentRenderProcessCall();
                case RemoteCallId.CfxV8StackTraceIsValidRenderProcessCall:
                    return new CfxV8StackTraceIsValidRenderProcessCall();
                case RemoteCallId.CfxV8StackTraceGetFrameCountRenderProcessCall:
                    return new CfxV8StackTraceGetFrameCountRenderProcessCall();
                case RemoteCallId.CfxV8StackTraceGetFrameRenderProcessCall:
                    return new CfxV8StackTraceGetFrameRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateUndefinedRenderProcessCall:
                    return new CfxV8ValueCreateUndefinedRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateNullRenderProcessCall:
                    return new CfxV8ValueCreateNullRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateBoolRenderProcessCall:
                    return new CfxV8ValueCreateBoolRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateIntRenderProcessCall:
                    return new CfxV8ValueCreateIntRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateUintRenderProcessCall:
                    return new CfxV8ValueCreateUintRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateDoubleRenderProcessCall:
                    return new CfxV8ValueCreateDoubleRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateDateRenderProcessCall:
                    return new CfxV8ValueCreateDateRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateStringRenderProcessCall:
                    return new CfxV8ValueCreateStringRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateObjectRenderProcessCall:
                    return new CfxV8ValueCreateObjectRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateArrayRenderProcessCall:
                    return new CfxV8ValueCreateArrayRenderProcessCall();
                case RemoteCallId.CfxV8ValueCreateFunctionRenderProcessCall:
                    return new CfxV8ValueCreateFunctionRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsValidRenderProcessCall:
                    return new CfxV8ValueIsValidRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsUndefinedRenderProcessCall:
                    return new CfxV8ValueIsUndefinedRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsNullRenderProcessCall:
                    return new CfxV8ValueIsNullRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsBoolRenderProcessCall:
                    return new CfxV8ValueIsBoolRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsIntRenderProcessCall:
                    return new CfxV8ValueIsIntRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsUintRenderProcessCall:
                    return new CfxV8ValueIsUintRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsDoubleRenderProcessCall:
                    return new CfxV8ValueIsDoubleRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsDateRenderProcessCall:
                    return new CfxV8ValueIsDateRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsStringRenderProcessCall:
                    return new CfxV8ValueIsStringRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsObjectRenderProcessCall:
                    return new CfxV8ValueIsObjectRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsArrayRenderProcessCall:
                    return new CfxV8ValueIsArrayRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsFunctionRenderProcessCall:
                    return new CfxV8ValueIsFunctionRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsSameRenderProcessCall:
                    return new CfxV8ValueIsSameRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetBoolValueRenderProcessCall:
                    return new CfxV8ValueGetBoolValueRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetIntValueRenderProcessCall:
                    return new CfxV8ValueGetIntValueRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetUintValueRenderProcessCall:
                    return new CfxV8ValueGetUintValueRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetDoubleValueRenderProcessCall:
                    return new CfxV8ValueGetDoubleValueRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetDateValueRenderProcessCall:
                    return new CfxV8ValueGetDateValueRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetStringValueRenderProcessCall:
                    return new CfxV8ValueGetStringValueRenderProcessCall();
                case RemoteCallId.CfxV8ValueIsUserCreatedRenderProcessCall:
                    return new CfxV8ValueIsUserCreatedRenderProcessCall();
                case RemoteCallId.CfxV8ValueHasExceptionRenderProcessCall:
                    return new CfxV8ValueHasExceptionRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetExceptionRenderProcessCall:
                    return new CfxV8ValueGetExceptionRenderProcessCall();
                case RemoteCallId.CfxV8ValueClearExceptionRenderProcessCall:
                    return new CfxV8ValueClearExceptionRenderProcessCall();
                case RemoteCallId.CfxV8ValueWillRethrowExceptionsRenderProcessCall:
                    return new CfxV8ValueWillRethrowExceptionsRenderProcessCall();
                case RemoteCallId.CfxV8ValueSetRethrowExceptionsRenderProcessCall:
                    return new CfxV8ValueSetRethrowExceptionsRenderProcessCall();
                case RemoteCallId.CfxV8ValueHasValueByKeyRenderProcessCall:
                    return new CfxV8ValueHasValueByKeyRenderProcessCall();
                case RemoteCallId.CfxV8ValueHasValueByIndexRenderProcessCall:
                    return new CfxV8ValueHasValueByIndexRenderProcessCall();
                case RemoteCallId.CfxV8ValueDeleteValueByKeyRenderProcessCall:
                    return new CfxV8ValueDeleteValueByKeyRenderProcessCall();
                case RemoteCallId.CfxV8ValueDeleteValueByIndexRenderProcessCall:
                    return new CfxV8ValueDeleteValueByIndexRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetValueByKeyRenderProcessCall:
                    return new CfxV8ValueGetValueByKeyRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetValueByIndexRenderProcessCall:
                    return new CfxV8ValueGetValueByIndexRenderProcessCall();
                case RemoteCallId.CfxV8ValueSetValueByKeyRenderProcessCall:
                    return new CfxV8ValueSetValueByKeyRenderProcessCall();
                case RemoteCallId.CfxV8ValueSetValueByIndexRenderProcessCall:
                    return new CfxV8ValueSetValueByIndexRenderProcessCall();
                case RemoteCallId.CfxV8ValueSetValueByAccessorRenderProcessCall:
                    return new CfxV8ValueSetValueByAccessorRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetKeysRenderProcessCall:
                    return new CfxV8ValueGetKeysRenderProcessCall();
                case RemoteCallId.CfxV8ValueSetUserDataRenderProcessCall:
                    return new CfxV8ValueSetUserDataRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetUserDataRenderProcessCall:
                    return new CfxV8ValueGetUserDataRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetExternallyAllocatedMemoryRenderProcessCall:
                    return new CfxV8ValueGetExternallyAllocatedMemoryRenderProcessCall();
                case RemoteCallId.CfxV8ValueAdjustExternallyAllocatedMemoryRenderProcessCall:
                    return new CfxV8ValueAdjustExternallyAllocatedMemoryRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetArrayLengthRenderProcessCall:
                    return new CfxV8ValueGetArrayLengthRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetFunctionNameRenderProcessCall:
                    return new CfxV8ValueGetFunctionNameRenderProcessCall();
                case RemoteCallId.CfxV8ValueGetFunctionHandlerRenderProcessCall:
                    return new CfxV8ValueGetFunctionHandlerRenderProcessCall();
                case RemoteCallId.CfxV8ValueExecuteFunctionRenderProcessCall:
                    return new CfxV8ValueExecuteFunctionRenderProcessCall();
                case RemoteCallId.CfxV8ValueExecuteFunctionWithContextRenderProcessCall:
                    return new CfxV8ValueExecuteFunctionWithContextRenderProcessCall();
                case RemoteCallId.ExecuteRemoteProcessRemoteCall:
                    return new ExecuteRemoteProcessRemoteCall();
                case RemoteCallId.ReleaseProxyRemoteCall:
                    return new ReleaseProxyRemoteCall();
                case RemoteCallId.GetRemotePtrRemoteCall:
                    return new GetRemotePtrRemoteCall();
                case RemoteCallId.CfrMarshalAllocHGlobalRenderProcessCall:
                    return new CfrMarshalAllocHGlobalRenderProcessCall();
                case RemoteCallId.CfrMarshalFreeHGlobalRenderProcessCall:
                    return new CfrMarshalFreeHGlobalRenderProcessCall();
                case RemoteCallId.CfrMarshalCopyToNativeRenderProcessCall:
                    return new CfrMarshalCopyToNativeRenderProcessCall();
                case RemoteCallId.CfrMarshalCopyToManagedRenderProcessCall:
                    return new CfrMarshalCopyToManagedRenderProcessCall();
                case RemoteCallId.CfxBinaryValueCreateFromArrayRenderProcessCall:
                    return new CfxBinaryValueCreateFromArrayRenderProcessCall();
                case RemoteCallId.CfxRuntimeExecuteProcessRenderProcessCall:
                    return new CfxRuntimeExecuteProcessRenderProcessCall();
                default:
                // unreached
                return null;
            }
        }
    }
}
