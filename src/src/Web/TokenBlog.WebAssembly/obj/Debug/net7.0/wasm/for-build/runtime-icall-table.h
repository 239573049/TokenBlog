[
{ "klass": "", "icalls": []},
 { "klass":"Mono.RuntimeClassHandle", "icalls": [{} 	,{ "name": "GetTypeFromClass", "func": "ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass", "handles": false }
]},
 { "klass":"Mono.RuntimeGPtrArrayHandle", "icalls": [{} 	,{ "name": "GPtrArrayFree", "func": "ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree", "handles": false }
]},
 { "klass":"Mono.RuntimeMarshal", "icalls": [{} 	,{ "name": "FreeAssemblyName", "func": "ves_icall_Mono_RuntimeMarshal_FreeAssemblyName", "handles": false }
]},
 { "klass":"Mono.SafeStringMarshal", "icalls": [{} 	,{ "name": "GFree", "func": "ves_icall_Mono_SafeStringMarshal_GFree", "handles": false }
	,{ "name": "StringToUtf8_icall", "func": "ves_icall_Mono_SafeStringMarshal_StringToUtf8", "handles": false }
]},
 { "klass":"System.ArgIterator", "icalls": [{} 	,{ "name": "IntGetNextArg", "func": "ves_icall_System_ArgIterator_IntGetNextArg", "handles": false }
	,{ "name": "IntGetNextArgType", "func": "ves_icall_System_ArgIterator_IntGetNextArgType", "handles": false }
	,{ "name": "IntGetNextArgWithType", "func": "ves_icall_System_ArgIterator_IntGetNextArgWithType", "handles": false }
	,{ "name": "Setup", "func": "ves_icall_System_ArgIterator_Setup", "handles": false }
]},
 { "klass":"System.Array", "icalls": [{} 	,{ "name": "CanChangePrimitive", "func": "ves_icall_System_Array_CanChangePrimitive", "handles": false }
	,{ "name": "FastCopy", "func": "ves_icall_System_Array_FastCopy_raw", "handles": true }
	,{ "name": "GetCorElementTypeOfElementType", "func": "ves_icall_System_Array_GetCorElementTypeOfElementType_raw", "handles": true }
	,{ "name": "GetGenericValue_icall", "func": "ves_icall_System_Array_GetGenericValue_icall", "handles": false }
	,{ "name": "GetLength", "func": "ves_icall_System_Array_GetLength_raw", "handles": true }
	,{ "name": "GetLowerBound", "func": "ves_icall_System_Array_GetLowerBound_raw", "handles": true }
	,{ "name": "GetValueImpl", "func": "ves_icall_System_Array_GetValueImpl_raw", "handles": true }
	,{ "name": "InternalCreate", "func": "ves_icall_System_Array_InternalCreate", "handles": false }
	,{ "name": "IsValueOfElementType", "func": "ves_icall_System_Array_IsValueOfElementType_raw", "handles": true }
	,{ "name": "SetGenericValue_icall", "func": "ves_icall_System_Array_SetGenericValue_icall", "handles": false }
	,{ "name": "SetValueImpl", "func": "ves_icall_System_Array_SetValueImpl_raw", "handles": true }
	,{ "name": "SetValueRelaxedImpl", "func": "ves_icall_System_Array_SetValueRelaxedImpl_raw", "handles": true }
]},
 { "klass":"System.Buffer", "icalls": [{} 	,{ "name": "BulkMoveWithWriteBarrier", "func": "ves_icall_System_Buffer_BulkMoveWithWriteBarrier", "handles": false }
	,{ "name": "__Memmove", "func": "ves_icall_System_Runtime_RuntimeImports_Memmove", "handles": false }
	,{ "name": "__ZeroMemory", "func": "ves_icall_System_Runtime_RuntimeImports_ZeroMemory", "handles": false }
]},
 { "klass":"System.Delegate", "icalls": [{} 	,{ "name": "AllocDelegateLike_internal", "func": "ves_icall_System_Delegate_AllocDelegateLike_internal_raw", "handles": true }
	,{ "name": "CreateDelegate_internal", "func": "ves_icall_System_Delegate_CreateDelegate_internal_raw", "handles": true }
	,{ "name": "GetVirtualMethod_internal", "func": "ves_icall_System_Delegate_GetVirtualMethod_internal_raw", "handles": true }
]},
 { "klass":"System.Diagnostics.Debugger", "icalls": [{} 	,{ "name": "IsAttached_internal", "func": "ves_icall_System_Diagnostics_Debugger_IsAttached_internal", "handles": false }
	,{ "name": "IsLogging", "func": "ves_icall_System_Diagnostics_Debugger_IsLogging", "handles": false }
	,{ "name": "Log_icall", "func": "ves_icall_System_Diagnostics_Debugger_Log", "handles": false }
]},
 { "klass":"System.Diagnostics.Tracing.EventPipeInternal", "icalls": [{} 	,{ "name": "CreateProvider", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_CreateProvider_raw", "handles": true }
	,{ "name": "DefineEvent", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_DefineEvent", "handles": false }
	,{ "name": "DeleteProvider", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_DeleteProvider", "handles": false }
	,{ "name": "Disable", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_Disable", "handles": false }
	,{ "name": "Enable", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_Enable", "handles": false }
	,{ "name": "EventActivityIdControl", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_EventActivityIdControl", "handles": false }
	,{ "name": "GetNextEvent", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_GetNextEvent", "handles": false }
	,{ "name": "GetProvider", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_GetProvider", "handles": false }
	,{ "name": "GetRuntimeCounterValue", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_GetRuntimeCounterValue", "handles": false }
	,{ "name": "GetSessionInfo", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_GetSessionInfo", "handles": false }
	,{ "name": "SignalSession", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_SignalSession", "handles": false }
	,{ "name": "WaitForSessionSignal", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_WaitForSessionSignal", "handles": false }
	,{ "name": "WriteEventData", "func": "ves_icall_System_Diagnostics_Tracing_EventPipeInternal_WriteEventData", "handles": false }
]},
 { "klass":"System.Diagnostics.Tracing.NativeRuntimeEventSource", "icalls": [{} 	,{ "name": "LogThreadPoolIODequeue", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolIODequeue", "handles": false }
	,{ "name": "LogThreadPoolIOEnqueue", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolIOEnqueue", "handles": false }
	,{ "name": "LogThreadPoolIOPack", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolIOPack", "handles": false }
	,{ "name": "LogThreadPoolMinMaxThreads", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolMinMaxThreads", "handles": false }
	,{ "name": "LogThreadPoolWorkerThreadAdjustmentAdjustment", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolWorkerThreadAdjustmentAdjustment", "handles": false }
	,{ "name": "LogThreadPoolWorkerThreadAdjustmentSample", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolWorkerThreadAdjustmentSample", "handles": false }
	,{ "name": "LogThreadPoolWorkerThreadAdjustmentStats", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolWorkerThreadAdjustmentStats", "handles": false }
	,{ "name": "LogThreadPoolWorkerThreadStart", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolWorkerThreadStart", "handles": false }
	,{ "name": "LogThreadPoolWorkerThreadStop", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolWorkerThreadStop", "handles": false }
	,{ "name": "LogThreadPoolWorkerThreadWait", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolWorkerThreadWait", "handles": false }
	,{ "name": "LogThreadPoolWorkingThreadCount", "func": "ves_icall_System_Diagnostics_Tracing_NativeRuntimeEventSource_LogThreadPoolWorkingThreadCount", "handles": false }
]},
 { "klass":"System.Enum", "icalls": [{} 	,{ "name": "GetEnumValuesAndNames", "func": "ves_icall_System_Enum_GetEnumValuesAndNames_raw", "handles": true }
	,{ "name": "InternalBoxEnum", "func": "ves_icall_System_Enum_InternalBoxEnum_raw", "handles": true }
	,{ "name": "InternalGetCorElementType", "func": "ves_icall_System_Enum_InternalGetCorElementType", "handles": false }
	,{ "name": "InternalGetUnderlyingType", "func": "ves_icall_System_Enum_InternalGetUnderlyingType_raw", "handles": true }
]},
 { "klass":"System.Environment", "icalls": [{} 	,{ "name": "Exit", "func": "ves_icall_System_Environment_Exit", "handles": false }
	,{ "name": "FailFast", "func": "ves_icall_System_Environment_FailFast_raw", "handles": true }
	,{ "name": "GetCommandLineArgs", "func": "ves_icall_System_Environment_GetCommandLineArgs_raw", "handles": true }
	,{ "name": "GetProcessorCount", "func": "ves_icall_System_Environment_get_ProcessorCount", "handles": false }
	,{ "name": "get_ExitCode", "func": "mono_environment_exitcode_get", "handles": false }
	,{ "name": "get_TickCount", "func": "ves_icall_System_Environment_get_TickCount", "handles": false }
	,{ "name": "get_TickCount64", "func": "ves_icall_System_Environment_get_TickCount64", "handles": false }
	,{ "name": "set_ExitCode", "func": "mono_environment_exitcode_set", "handles": false }
]},
 { "klass":"System.GC", "icalls": [{} 	,{ "name": "AllocPinnedArray", "func": "ves_icall_System_GC_AllocPinnedArray_raw", "handles": true }
	,{ "name": "GetAllocatedBytesForCurrentThread", "func": "ves_icall_System_GC_GetAllocatedBytesForCurrentThread", "handles": false }
	,{ "name": "GetCollectionCount", "func": "ves_icall_System_GC_GetCollectionCount", "handles": false }
	,{ "name": "GetGeneration", "func": "ves_icall_System_GC_GetGeneration_raw", "handles": true }
	,{ "name": "GetMaxGeneration", "func": "ves_icall_System_GC_GetMaxGeneration", "handles": false }
	,{ "name": "GetTotalAllocatedBytes", "func": "ves_icall_System_GC_GetTotalAllocatedBytes_raw", "handles": true }
	,{ "name": "GetTotalMemory", "func": "ves_icall_System_GC_GetTotalMemory", "handles": false }
	,{ "name": "InternalCollect", "func": "ves_icall_System_GC_InternalCollect", "handles": false }
	,{ "name": "RecordPressure", "func": "ves_icall_System_GC_RecordPressure", "handles": false }
	,{ "name": "WaitForPendingFinalizers", "func": "ves_icall_System_GC_WaitForPendingFinalizers", "handles": false }
	,{ "name": "_GetGCMemoryInfo", "func": "ves_icall_System_GC_GetGCMemoryInfo", "handles": false }
	,{ "name": "_ReRegisterForFinalize", "func": "ves_icall_System_GC_ReRegisterForFinalize_raw", "handles": true }
	,{ "name": "_SuppressFinalize", "func": "ves_icall_System_GC_SuppressFinalize_raw", "handles": true }
	,{ "name": "get_ephemeron_tombstone", "func": "ves_icall_System_GC_get_ephemeron_tombstone_raw", "handles": true }
	,{ "name": "register_ephemeron_array", "func": "ves_icall_System_GC_register_ephemeron_array_raw", "handles": true }
]},
 { "klass":"System.IO.Stream", "icalls": [{} 	,{ "name": "HasOverriddenBeginEndRead", "func": "ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw", "handles": true }
	,{ "name": "HasOverriddenBeginEndWrite", "func": "ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw", "handles": true }
]},
 { "klass":"System.Math", "icalls": [{} 	,{ "name": "Acos", "func": "ves_icall_System_Math_Acos", "handles": false }
	,{ "name": "Acosh", "func": "ves_icall_System_Math_Acosh", "handles": false }
	,{ "name": "Asin", "func": "ves_icall_System_Math_Asin", "handles": false }
	,{ "name": "Asinh", "func": "ves_icall_System_Math_Asinh", "handles": false }
	,{ "name": "Atan", "func": "ves_icall_System_Math_Atan", "handles": false }
	,{ "name": "Atan2", "func": "ves_icall_System_Math_Atan2", "handles": false }
	,{ "name": "Atanh", "func": "ves_icall_System_Math_Atanh", "handles": false }
	,{ "name": "Cbrt", "func": "ves_icall_System_Math_Cbrt", "handles": false }
	,{ "name": "Ceiling", "func": "ves_icall_System_Math_Ceiling", "handles": false }
	,{ "name": "Cos", "func": "ves_icall_System_Math_Cos", "handles": false }
	,{ "name": "Cosh", "func": "ves_icall_System_Math_Cosh", "handles": false }
	,{ "name": "Exp", "func": "ves_icall_System_Math_Exp", "handles": false }
	,{ "name": "FMod", "func": "ves_icall_System_Math_FMod", "handles": false }
	,{ "name": "Floor", "func": "ves_icall_System_Math_Floor", "handles": false }
	,{ "name": "FusedMultiplyAdd", "func": "ves_icall_System_Math_FusedMultiplyAdd", "handles": false }
	,{ "name": "Log", "func": "ves_icall_System_Math_Log", "handles": false }
	,{ "name": "Log10", "func": "ves_icall_System_Math_Log10", "handles": false }
	,{ "name": "Log2", "func": "ves_icall_System_Math_Log2", "handles": false }
	,{ "name": "ModF", "func": "ves_icall_System_Math_ModF", "handles": false }
	,{ "name": "Pow", "func": "ves_icall_System_Math_Pow", "handles": false }
	,{ "name": "Round", "func": "ves_icall_System_Math_Round", "handles": false }
	,{ "name": "Sin", "func": "ves_icall_System_Math_Sin", "handles": false }
	,{ "name": "Sinh", "func": "ves_icall_System_Math_Sinh", "handles": false }
	,{ "name": "Sqrt", "func": "ves_icall_System_Math_Sqrt", "handles": false }
	,{ "name": "Tan", "func": "ves_icall_System_Math_Tan", "handles": false }
	,{ "name": "Tanh", "func": "ves_icall_System_Math_Tanh", "handles": false }
]},
 { "klass":"System.MathF", "icalls": [{} 	,{ "name": "Acos", "func": "ves_icall_System_MathF_Acos", "handles": false }
	,{ "name": "Acosh", "func": "ves_icall_System_MathF_Acosh", "handles": false }
	,{ "name": "Asin", "func": "ves_icall_System_MathF_Asin", "handles": false }
	,{ "name": "Asinh", "func": "ves_icall_System_MathF_Asinh", "handles": false }
	,{ "name": "Atan", "func": "ves_icall_System_MathF_Atan", "handles": false }
	,{ "name": "Atan2", "func": "ves_icall_System_MathF_Atan2", "handles": false }
	,{ "name": "Atanh", "func": "ves_icall_System_MathF_Atanh", "handles": false }
	,{ "name": "Cbrt", "func": "ves_icall_System_MathF_Cbrt", "handles": false }
	,{ "name": "Ceiling", "func": "ves_icall_System_MathF_Ceiling", "handles": false }
	,{ "name": "Cos", "func": "ves_icall_System_MathF_Cos", "handles": false }
	,{ "name": "Cosh", "func": "ves_icall_System_MathF_Cosh", "handles": false }
	,{ "name": "Exp", "func": "ves_icall_System_MathF_Exp", "handles": false }
	,{ "name": "FMod", "func": "ves_icall_System_MathF_FMod", "handles": false }
	,{ "name": "Floor", "func": "ves_icall_System_MathF_Floor", "handles": false }
	,{ "name": "FusedMultiplyAdd", "func": "ves_icall_System_MathF_FusedMultiplyAdd", "handles": false }
	,{ "name": "Log", "func": "ves_icall_System_MathF_Log", "handles": false }
	,{ "name": "Log10", "func": "ves_icall_System_MathF_Log10", "handles": false }
	,{ "name": "Log2", "func": "ves_icall_System_MathF_Log2", "handles": false }
	,{ "name": "ModF(single,single*)", "func": "ves_icall_System_MathF_ModF", "handles": false }
	,{ "name": "Pow", "func": "ves_icall_System_MathF_Pow", "handles": false }
	,{ "name": "Sin", "func": "ves_icall_System_MathF_Sin", "handles": false }
	,{ "name": "Sinh", "func": "ves_icall_System_MathF_Sinh", "handles": false }
	,{ "name": "Sqrt", "func": "ves_icall_System_MathF_Sqrt", "handles": false }
	,{ "name": "Tan", "func": "ves_icall_System_MathF_Tan", "handles": false }
	,{ "name": "Tanh", "func": "ves_icall_System_MathF_Tanh", "handles": false }
]},
 { "klass":"System.Object", "icalls": [{} 	,{ "name": "MemberwiseClone", "func": "ves_icall_System_Object_MemberwiseClone_raw", "handles": true }
]},
 { "klass":"System.Reflection.Assembly", "icalls": [{} 	,{ "name": "GetCallingAssembly", "func": "ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw", "handles": true }
	,{ "name": "GetEntryAssemblyNative", "func": "ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw", "handles": true }
	,{ "name": "GetExecutingAssembly", "func": "ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw", "handles": true }
	,{ "name": "InternalGetType", "func": "ves_icall_System_Reflection_Assembly_InternalGetType_raw", "handles": true }
	,{ "name": "InternalLoad", "func": "ves_icall_System_Reflection_Assembly_InternalLoad_raw", "handles": true }
]},
 { "klass":"System.Reflection.AssemblyName", "icalls": [{} 	,{ "name": "GetNativeName", "func": "ves_icall_System_Reflection_AssemblyName_GetNativeName", "handles": false }
]},
 { "klass":"System.Reflection.CustomAttribute", "icalls": [{} 	,{ "name": "GetCustomAttributesDataInternal", "func": "ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw", "handles": true }
	,{ "name": "GetCustomAttributesInternal", "func": "ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw", "handles": true }
	,{ "name": "IsDefinedInternal", "func": "ves_icall_MonoCustomAttrs_IsDefinedInternal_raw", "handles": true }
]},
 { "klass":"System.Reflection.Emit.AssemblyBuilder", "icalls": [{} 	,{ "name": "UpdateNativeCustomAttributes", "func": "ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw", "handles": true }
	,{ "name": "basic_init", "func": "ves_icall_AssemblyBuilder_basic_init_raw", "handles": true }
]},
 { "klass":"System.Reflection.Emit.CustomAttributeBuilder", "icalls": [{} 	,{ "name": "GetBlob", "func": "ves_icall_CustomAttributeBuilder_GetBlob_raw", "handles": true }
]},
 { "klass":"System.Reflection.Emit.DynamicMethod", "icalls": [{} 	,{ "name": "create_dynamic_method", "func": "ves_icall_DynamicMethod_create_dynamic_method_raw", "handles": true }
]},
 { "klass":"System.Reflection.Emit.EnumBuilder", "icalls": [{} 	,{ "name": "setup_enum_type", "func": "ves_icall_EnumBuilder_setup_enum_type_raw", "handles": true }
]},
 { "klass":"System.Reflection.Emit.ModuleBuilder", "icalls": [{} 	,{ "name": "GetRegisteredToken", "func": "ves_icall_ModuleBuilder_GetRegisteredToken_raw", "handles": true }
	,{ "name": "RegisterToken", "func": "ves_icall_ModuleBuilder_RegisterToken_raw", "handles": true }
	,{ "name": "basic_init", "func": "ves_icall_ModuleBuilder_basic_init_raw", "handles": true }
	,{ "name": "getMethodToken", "func": "ves_icall_ModuleBuilder_getMethodToken_raw", "handles": true }
	,{ "name": "getToken", "func": "ves_icall_ModuleBuilder_getToken_raw", "handles": true }
	,{ "name": "getUSIndex", "func": "ves_icall_ModuleBuilder_getUSIndex_raw", "handles": true }
	,{ "name": "set_wrappers_type", "func": "ves_icall_ModuleBuilder_set_wrappers_type_raw", "handles": true }
]},
 { "klass":"System.Reflection.Emit.SignatureHelper", "icalls": [{} 	,{ "name": "get_signature_field", "func": "ves_icall_SignatureHelper_get_signature_field_raw", "handles": true }
	,{ "name": "get_signature_local", "func": "ves_icall_SignatureHelper_get_signature_local_raw", "handles": true }
]},
 { "klass":"System.Reflection.Emit.TypeBuilder", "icalls": [{} 	,{ "name": "create_runtime_class", "func": "ves_icall_TypeBuilder_create_runtime_class_raw", "handles": true }
]},
 { "klass":"System.Reflection.FieldInfo", "icalls": [{} 	,{ "name": "get_marshal_info", "func": "ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw", "handles": true }
	,{ "name": "internal_from_handle_type", "func": "ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw", "handles": true }
]},
 { "klass":"System.Reflection.Metadata.MetadataUpdater", "icalls": [{} 	,{ "name": "ApplyUpdateEnabled", "func": "ves_icall_AssemblyExtensions_ApplyUpdateEnabled", "handles": false }
	,{ "name": "ApplyUpdate_internal", "func": "ves_icall_AssemblyExtensions_ApplyUpdate", "handles": false }
	,{ "name": "GetApplyUpdateCapabilities", "func": "ves_icall_AssemblyExtensions_GetApplyUpdateCapabilities_raw", "handles": true }
]},
 { "klass":"System.Reflection.MethodBase", "icalls": [{} 	,{ "name": "GetCurrentMethod", "func": "ves_icall_GetCurrentMethod_raw", "handles": true }
]},
 { "klass":"System.Reflection.MonoMethodInfo", "icalls": [{} 	,{ "name": "get_method_attributes", "func": "ves_icall_get_method_attributes", "handles": false }
	,{ "name": "get_method_info", "func": "ves_icall_get_method_info_raw", "handles": true }
	,{ "name": "get_parameter_info", "func": "ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw", "handles": true }
	,{ "name": "get_retval_marshal", "func": "ves_icall_System_MonoMethodInfo_get_retval_marshal_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimeAssembly", "icalls": [{} 	,{ "name": "GetEntryPoint", "func": "ves_icall_System_Reflection_RuntimeAssembly_GetEntryPoint_raw", "handles": true }
	,{ "name": "GetExportedTypes", "func": "ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw", "handles": true }
	,{ "name": "GetInfo", "func": "ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw", "handles": true }
	,{ "name": "GetManifestModuleInternal", "func": "ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw", "handles": true }
	,{ "name": "GetManifestResourceInfoInternal", "func": "ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInfoInternal_raw", "handles": true }
	,{ "name": "GetManifestResourceInternal", "func": "ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw", "handles": true }
	,{ "name": "GetManifestResourceNames", "func": "ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw", "handles": true }
	,{ "name": "GetModulesInternal", "func": "ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw", "handles": true }
	,{ "name": "GetTopLevelForwardedTypes", "func": "ves_icall_System_Reflection_RuntimeAssembly_GetTopLevelForwardedTypes_raw", "handles": true }
	,{ "name": "InternalGetReferencedAssemblies", "func": "ves_icall_System_Reflection_Assembly_InternalGetReferencedAssemblies_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimeConstructorInfo", "icalls": [{} 	,{ "name": "GetGenericMethodDefinition_impl", "func": "ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw", "handles": true }
	,{ "name": "InternalInvoke", "func": "ves_icall_InternalInvoke_raw", "handles": true }
	,{ "name": "InvokeClassConstructor", "func": "ves_icall_InvokeClassConstructor_raw", "handles": true }
	,{ "name": "get_metadata_token", "func": "ves_icall_reflection_get_token_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimeCustomAttributeData", "icalls": [{} 	,{ "name": "ResolveArgumentsInternal", "func": "ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimeEventInfo", "icalls": [{} 	,{ "name": "get_event_info", "func": "ves_icall_RuntimeEventInfo_get_event_info_raw", "handles": true }
	,{ "name": "get_metadata_token", "func": "ves_icall_reflection_get_token_raw", "handles": true }
	,{ "name": "internal_from_handle_type", "func": "ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimeFieldInfo", "icalls": [{} 	,{ "name": "GetFieldOffset", "func": "ves_icall_RuntimeFieldInfo_GetFieldOffset_raw", "handles": true }
	,{ "name": "GetParentType", "func": "ves_icall_RuntimeFieldInfo_GetParentType_raw", "handles": true }
	,{ "name": "GetRawConstantValue", "func": "ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw", "handles": true }
	,{ "name": "GetTypeModifiers", "func": "ves_icall_System_Reflection_FieldInfo_GetTypeModifiers_raw", "handles": true }
	,{ "name": "GetValueInternal", "func": "ves_icall_RuntimeFieldInfo_GetValueInternal_raw", "handles": true }
	,{ "name": "ResolveType", "func": "ves_icall_RuntimeFieldInfo_ResolveType_raw", "handles": true }
	,{ "name": "SetValueInternal", "func": "ves_icall_RuntimeFieldInfo_SetValueInternal_raw", "handles": true }
	,{ "name": "UnsafeGetValue", "func": "ves_icall_RuntimeFieldInfo_GetValueInternal_raw", "handles": true }
	,{ "name": "get_metadata_token", "func": "ves_icall_reflection_get_token_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimeMethodInfo", "icalls": [{} 	,{ "name": "GetGenericArguments", "func": "ves_icall_RuntimeMethodInfo_GetGenericArguments_raw", "handles": true }
	,{ "name": "GetGenericMethodDefinition_impl", "func": "ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw", "handles": true }
	,{ "name": "GetMethodBodyInternal", "func": "ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodBodyInternal_raw", "handles": true }
	,{ "name": "GetMethodFromHandleInternalType_native", "func": "ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw", "handles": true }
	,{ "name": "GetPInvoke", "func": "ves_icall_RuntimeMethodInfo_GetPInvoke_raw", "handles": true }
	,{ "name": "InternalInvoke", "func": "ves_icall_InternalInvoke_raw", "handles": true }
	,{ "name": "MakeGenericMethod_impl", "func": "ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw", "handles": true }
	,{ "name": "get_IsGenericMethod", "func": "ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw", "handles": true }
	,{ "name": "get_IsGenericMethodDefinition", "func": "ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw", "handles": true }
	,{ "name": "get_base_method", "func": "ves_icall_RuntimeMethodInfo_get_base_method_raw", "handles": true }
	,{ "name": "get_metadata_token", "func": "ves_icall_reflection_get_token_raw", "handles": true }
	,{ "name": "get_name", "func": "ves_icall_RuntimeMethodInfo_get_name_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimeModule", "icalls": [{} 	,{ "name": "GetGlobalType", "func": "ves_icall_System_Reflection_RuntimeModule_GetGlobalType_raw", "handles": true }
	,{ "name": "GetGuidInternal", "func": "ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw", "handles": true }
	,{ "name": "GetMDStreamVersion", "func": "ves_icall_System_Reflection_RuntimeModule_GetMDStreamVersion_raw", "handles": true }
	,{ "name": "GetPEKind", "func": "ves_icall_System_Reflection_RuntimeModule_GetPEKind_raw", "handles": true }
	,{ "name": "InternalGetTypes", "func": "ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw", "handles": true }
	,{ "name": "ResolveFieldToken", "func": "ves_icall_System_Reflection_RuntimeModule_ResolveFieldToken_raw", "handles": true }
	,{ "name": "ResolveMemberToken", "func": "ves_icall_System_Reflection_RuntimeModule_ResolveMemberToken_raw", "handles": true }
	,{ "name": "ResolveMethodToken", "func": "ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw", "handles": true }
	,{ "name": "ResolveSignature", "func": "ves_icall_System_Reflection_RuntimeModule_ResolveSignature_raw", "handles": true }
	,{ "name": "ResolveStringToken", "func": "ves_icall_System_Reflection_RuntimeModule_ResolveStringToken_raw", "handles": true }
	,{ "name": "ResolveTypeToken", "func": "ves_icall_System_Reflection_RuntimeModule_ResolveTypeToken_raw", "handles": true }
	,{ "name": "get_MetadataToken", "func": "ves_icall_reflection_get_token_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimeParameterInfo", "icalls": [{} 	,{ "name": "GetMetadataToken", "func": "ves_icall_reflection_get_token_raw", "handles": true }
	,{ "name": "GetTypeModifiers", "func": "ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw", "handles": true }
]},
 { "klass":"System.Reflection.RuntimePropertyInfo", "icalls": [{} 	,{ "name": "GetTypeModifiers", "func": "ves_icall_RuntimePropertyInfo_GetTypeModifiers_raw", "handles": true }
	,{ "name": "get_default_value", "func": "ves_icall_property_info_get_default_value_raw", "handles": true }
	,{ "name": "get_metadata_token", "func": "ves_icall_reflection_get_token_raw", "handles": true }
	,{ "name": "get_property_info", "func": "ves_icall_RuntimePropertyInfo_get_property_info_raw", "handles": true }
	,{ "name": "internal_from_handle_type", "func": "ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw", "handles": true }
]},
 { "klass":"System.Runtime.CompilerServices.RuntimeHelpers", "icalls": [{} 	,{ "name": "GetObjectValue", "func": "ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw", "handles": true }
	,{ "name": "GetSpanDataFrom", "func": "ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw", "handles": true }
	,{ "name": "GetUninitializedObjectInternal", "func": "ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw", "handles": true }
	,{ "name": "InitializeArray", "func": "ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw", "handles": true }
	,{ "name": "InternalGetHashCode", "func": "mono_object_hash_icall_raw", "handles": true }
	,{ "name": "PrepareMethod", "func": "ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_PrepareMethod_raw", "handles": true }
	,{ "name": "RunClassConstructor", "func": "ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw", "handles": true }
	,{ "name": "RunModuleConstructor", "func": "ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunModuleConstructor_raw", "handles": true }
	,{ "name": "SufficientExecutionStack", "func": "ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack", "handles": false }
]},
 { "klass":"System.Runtime.InteropServices.GCHandle", "icalls": [{} 	,{ "name": "InternalAlloc", "func": "ves_icall_System_GCHandle_InternalAlloc_raw", "handles": true }
	,{ "name": "InternalFree", "func": "ves_icall_System_GCHandle_InternalFree_raw", "handles": true }
	,{ "name": "InternalGet", "func": "ves_icall_System_GCHandle_InternalGet_raw", "handles": true }
	,{ "name": "InternalSet", "func": "ves_icall_System_GCHandle_InternalSet_raw", "handles": true }
]},
 { "klass":"System.Runtime.InteropServices.Marshal", "icalls": [{} 	,{ "name": "DestroyStructure", "func": "ves_icall_System_Runtime_InteropServices_Marshal_DestroyStructure_raw", "handles": true }
	,{ "name": "GetDelegateForFunctionPointerInternal", "func": "ves_icall_System_Runtime_InteropServices_Marshal_GetDelegateForFunctionPointerInternal_raw", "handles": true }
	,{ "name": "GetFunctionPointerForDelegateInternal", "func": "ves_icall_System_Runtime_InteropServices_Marshal_GetFunctionPointerForDelegateInternal_raw", "handles": true }
	,{ "name": "GetLastPInvokeError", "func": "ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError", "handles": false }
	,{ "name": "OffsetOf", "func": "ves_icall_System_Runtime_InteropServices_Marshal_OffsetOf_raw", "handles": true }
	,{ "name": "PrelinkInternal", "func": "ves_icall_System_Runtime_InteropServices_Marshal_Prelink_raw", "handles": true }
	,{ "name": "PtrToStructureInternal", "func": "ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw", "handles": true }
	,{ "name": "SetLastPInvokeError", "func": "ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError", "handles": false }
	,{ "name": "SizeOfHelper", "func": "ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw", "handles": true }
	,{ "name": "StructureToPtr", "func": "ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw", "handles": true }
]},
 { "klass":"System.Runtime.InteropServices.NativeLibrary", "icalls": [{} 	,{ "name": "FreeLib", "func": "ves_icall_System_Runtime_InteropServices_NativeLibrary_FreeLib_raw", "handles": true }
	,{ "name": "GetSymbol", "func": "ves_icall_System_Runtime_InteropServices_NativeLibrary_GetSymbol_raw", "handles": true }
	,{ "name": "LoadByName", "func": "ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw", "handles": true }
	,{ "name": "LoadFromPath", "func": "ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadFromPath_raw", "handles": true }
]},
 { "klass":"System.Runtime.Loader.AssemblyLoadContext", "icalls": [{} 	,{ "name": "GetLoadContextForAssembly", "func": "ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw", "handles": true }
	,{ "name": "InternalGetLoadedAssemblies", "func": "ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw", "handles": true }
	,{ "name": "InternalInitializeNativeALC", "func": "ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw", "handles": true }
	,{ "name": "InternalLoadFile", "func": "ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw", "handles": true }
	,{ "name": "InternalLoadFromStream", "func": "ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw", "handles": true }
	,{ "name": "PrepareForAssemblyLoadContextRelease", "func": "ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw", "handles": true }
]},
 { "klass":"System.RuntimeFieldHandle", "icalls": [{} 	,{ "name": "GetValueDirect", "func": "ves_icall_System_RuntimeFieldHandle_GetValueDirect_raw", "handles": true }
	,{ "name": "SetValueDirect", "func": "ves_icall_System_RuntimeFieldHandle_SetValueDirect_raw", "handles": true }
	,{ "name": "SetValueInternal", "func": "ves_icall_RuntimeFieldInfo_SetValueInternal_raw", "handles": true }
]},
 { "klass":"System.RuntimeMethodHandle", "icalls": [{} 	,{ "name": "GetFunctionPointer", "func": "ves_icall_RuntimeMethodHandle_GetFunctionPointer_raw", "handles": true }
]},
 { "klass":"System.RuntimeType", "icalls": [{} 	,{ "name": "CreateInstanceInternal", "func": "ves_icall_System_RuntimeType_CreateInstanceInternal_raw", "handles": true }
	,{ "name": "GetConstructors_native", "func": "ves_icall_RuntimeType_GetConstructors_native_raw", "handles": true }
	,{ "name": "GetCorrespondingInflatedMethod", "func": "ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw", "handles": true }
	,{ "name": "GetDeclaringMethod", "func": "ves_icall_RuntimeType_GetDeclaringMethod_raw", "handles": true }
	,{ "name": "GetDeclaringType", "func": "ves_icall_RuntimeType_GetDeclaringType_raw", "handles": true }
	,{ "name": "GetEvents_native", "func": "ves_icall_RuntimeType_GetEvents_native_raw", "handles": true }
	,{ "name": "GetFields_native", "func": "ves_icall_RuntimeType_GetFields_native_raw", "handles": true }
	,{ "name": "GetGenericArgumentsInternal", "func": "ves_icall_RuntimeType_GetGenericArgumentsInternal_raw", "handles": true }
	,{ "name": "GetGenericParameterPosition", "func": "ves_icall_RuntimeType_GetGenericParameterPosition", "handles": false }
	,{ "name": "GetInterfaceMapData", "func": "ves_icall_RuntimeType_GetInterfaceMapData_raw", "handles": true }
	,{ "name": "GetInterfaces", "func": "ves_icall_RuntimeType_GetInterfaces_raw", "handles": true }
	,{ "name": "GetMethodsByName_native", "func": "ves_icall_RuntimeType_GetMethodsByName_native_raw", "handles": true }
	,{ "name": "GetName", "func": "ves_icall_RuntimeType_GetName_raw", "handles": true }
	,{ "name": "GetNamespace", "func": "ves_icall_RuntimeType_GetNamespace_raw", "handles": true }
	,{ "name": "GetNestedTypes_native", "func": "ves_icall_RuntimeType_GetNestedTypes_native_raw", "handles": true }
	,{ "name": "GetPacking", "func": "ves_icall_RuntimeType_GetPacking_raw", "handles": true }
	,{ "name": "GetPropertiesByName_native", "func": "ves_icall_RuntimeType_GetPropertiesByName_native_raw", "handles": true }
	,{ "name": "MakeGenericType", "func": "ves_icall_RuntimeType_MakeGenericType_raw", "handles": true }
	,{ "name": "getFullName", "func": "ves_icall_System_RuntimeType_getFullName_raw", "handles": true }
	,{ "name": "make_array_type", "func": "ves_icall_RuntimeType_make_array_type_raw", "handles": true }
	,{ "name": "make_byref_type", "func": "ves_icall_RuntimeType_make_byref_type_raw", "handles": true }
	,{ "name": "make_pointer_type", "func": "ves_icall_RuntimeType_make_pointer_type_raw", "handles": true }
]},
 { "klass":"System.RuntimeTypeHandle", "icalls": [{} 	,{ "name": "GetArrayRank", "func": "ves_icall_RuntimeTypeHandle_GetArrayRank_raw", "handles": true }
	,{ "name": "GetAssembly", "func": "ves_icall_RuntimeTypeHandle_GetAssembly_raw", "handles": true }
	,{ "name": "GetAttributes", "func": "ves_icall_RuntimeTypeHandle_GetAttributes", "handles": false }
	,{ "name": "GetBaseType", "func": "ves_icall_RuntimeTypeHandle_GetBaseType_raw", "handles": true }
	,{ "name": "GetCorElementType", "func": "ves_icall_RuntimeTypeHandle_GetCorElementType", "handles": false }
	,{ "name": "GetElementType", "func": "ves_icall_RuntimeTypeHandle_GetElementType_raw", "handles": true }
	,{ "name": "GetGenericParameterInfo", "func": "ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw", "handles": true }
	,{ "name": "GetGenericTypeDefinition_impl", "func": "ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw", "handles": true }
	,{ "name": "GetMetadataToken", "func": "ves_icall_RuntimeTypeHandle_GetMetadataToken_raw", "handles": true }
	,{ "name": "GetModule", "func": "ves_icall_RuntimeTypeHandle_GetModule_raw", "handles": true }
	,{ "name": "HasInstantiation", "func": "ves_icall_RuntimeTypeHandle_HasInstantiation", "handles": false }
	,{ "name": "HasReferences", "func": "ves_icall_RuntimeTypeHandle_HasReferences_raw", "handles": true }
	,{ "name": "IsByRefLike", "func": "ves_icall_RuntimeTypeHandle_IsByRefLike_raw", "handles": true }
	,{ "name": "IsComObject", "func": "ves_icall_RuntimeTypeHandle_IsComObject_raw", "handles": true }
	,{ "name": "IsGenericTypeDefinition", "func": "ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition", "handles": false }
	,{ "name": "IsInstanceOfType", "func": "ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw", "handles": true }
	,{ "name": "internal_from_name", "func": "ves_icall_System_RuntimeTypeHandle_internal_from_name_raw", "handles": true }
	,{ "name": "is_subclass_of", "func": "ves_icall_RuntimeTypeHandle_is_subclass_of_raw", "handles": true }
	,{ "name": "type_is_assignable_from", "func": "ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw", "handles": true }
]},
 { "klass":"System.String", "icalls": [{} 	,{ "name": ".ctor(System.ReadOnlySpan`1<char>)", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": ".ctor(char*)", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": ".ctor(char*,int,int)", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": ".ctor(char,int)", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": ".ctor(char[])", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": ".ctor(char[],int,int)", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": ".ctor(sbyte*)", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": ".ctor(sbyte*,int,int)", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": ".ctor(sbyte*,int,int,System.Text.Encoding)", "func": "ves_icall_System_String_ctor_RedirectToCreateString", "handles": false }
	,{ "name": "FastAllocateString", "func": "ves_icall_System_String_FastAllocateString_raw", "handles": true }
	,{ "name": "InternalIntern", "func": "ves_icall_System_String_InternalIntern_raw", "handles": true }
	,{ "name": "InternalIsInterned", "func": "ves_icall_System_String_InternalIsInterned_raw", "handles": true }
]},
 { "klass":"System.Threading.Interlocked", "icalls": [{} 	,{ "name": "Add(int&,int)", "func": "ves_icall_System_Threading_Interlocked_Add_Int", "handles": false }
	,{ "name": "Add(long&,long)", "func": "ves_icall_System_Threading_Interlocked_Add_Long", "handles": false }
	,{ "name": "CompareExchange(double&,double,double)", "func": "ves_icall_System_Threading_Interlocked_CompareExchange_Double", "handles": false }
	,{ "name": "CompareExchange(int&,int,int)", "func": "ves_icall_System_Threading_Interlocked_CompareExchange_Int", "handles": false }
	,{ "name": "CompareExchange(int&,int,int,bool&)", "func": "ves_icall_System_Threading_Interlocked_CompareExchange_Int_Success", "handles": false }
	,{ "name": "CompareExchange(long&,long,long)", "func": "ves_icall_System_Threading_Interlocked_CompareExchange_Long", "handles": false }
	,{ "name": "CompareExchange(object&,object&,object&,object&)", "func": "ves_icall_System_Threading_Interlocked_CompareExchange_Object", "handles": false }
	,{ "name": "CompareExchange(single&,single,single)", "func": "ves_icall_System_Threading_Interlocked_CompareExchange_Single", "handles": false }
	,{ "name": "Decrement(int&)", "func": "ves_icall_System_Threading_Interlocked_Decrement_Int", "handles": false }
	,{ "name": "Decrement(long&)", "func": "ves_icall_System_Threading_Interlocked_Decrement_Long", "handles": false }
	,{ "name": "Exchange(double&,double)", "func": "ves_icall_System_Threading_Interlocked_Exchange_Double", "handles": false }
	,{ "name": "Exchange(int&,int)", "func": "ves_icall_System_Threading_Interlocked_Exchange_Int", "handles": false }
	,{ "name": "Exchange(long&,long)", "func": "ves_icall_System_Threading_Interlocked_Exchange_Long", "handles": false }
	,{ "name": "Exchange(object&,object&,object&)", "func": "ves_icall_System_Threading_Interlocked_Exchange_Object", "handles": false }
	,{ "name": "Exchange(single&,single)", "func": "ves_icall_System_Threading_Interlocked_Exchange_Single", "handles": false }
	,{ "name": "Increment(int&)", "func": "ves_icall_System_Threading_Interlocked_Increment_Int", "handles": false }
	,{ "name": "Increment(long&)", "func": "ves_icall_System_Threading_Interlocked_Increment_Long", "handles": false }
	,{ "name": "MemoryBarrierProcessWide", "func": "ves_icall_System_Threading_Interlocked_MemoryBarrierProcessWide", "handles": false }
	,{ "name": "Read(long&)", "func": "ves_icall_System_Threading_Interlocked_Read_Long", "handles": false }
]},
 { "klass":"System.Threading.LowLevelLifoSemaphore", "icalls": [{} 	,{ "name": "DeleteInternal", "func": "ves_icall_System_Threading_LowLevelLifoSemaphore_DeleteInternal", "handles": false }
	,{ "name": "InitInternal", "func": "ves_icall_System_Threading_LowLevelLifoSemaphore_InitInternal", "handles": false }
	,{ "name": "ReleaseInternal", "func": "ves_icall_System_Threading_LowLevelLifoSemaphore_ReleaseInternal", "handles": false }
	,{ "name": "TimedWaitInternal", "func": "ves_icall_System_Threading_LowLevelLifoSemaphore_TimedWaitInternal", "handles": false }
]},
 { "klass":"System.Threading.Monitor", "icalls": [{} 	,{ "name": "Enter", "func": "ves_icall_System_Threading_Monitor_Monitor_Enter_raw", "handles": true }
	,{ "name": "Exit", "func": "mono_monitor_exit_icall_raw", "handles": true }
	,{ "name": "Monitor_pulse", "func": "ves_icall_System_Threading_Monitor_Monitor_pulse_raw", "handles": true }
	,{ "name": "Monitor_pulse_all", "func": "ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw", "handles": true }
	,{ "name": "Monitor_test_owner", "func": "ves_icall_System_Threading_Monitor_Monitor_test_owner_raw", "handles": true }
	,{ "name": "Monitor_test_synchronised", "func": "ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw", "handles": true }
	,{ "name": "Monitor_wait", "func": "ves_icall_System_Threading_Monitor_Monitor_wait_raw", "handles": true }
	,{ "name": "get_LockContentionCount", "func": "ves_icall_System_Threading_Monitor_Monitor_LockContentionCount", "handles": false }
	,{ "name": "try_enter_with_atomic_var", "func": "ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw", "handles": true }
]},
 { "klass":"System.Threading.Thread", "icalls": [{} 	,{ "name": "ClrState", "func": "ves_icall_System_Threading_Thread_ClrState_raw", "handles": true }
	,{ "name": "FreeInternal", "func": "ves_icall_System_Threading_InternalThread_Thread_free_internal_raw", "handles": true }
	,{ "name": "GetCurrentOSThreadId", "func": "ves_icall_System_Threading_Thread_GetCurrentOSThreadId_raw", "handles": true }
	,{ "name": "GetCurrentProcessorNumber", "func": "ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw", "handles": true }
	,{ "name": "GetCurrentThread", "func": "ves_icall_System_Threading_Thread_GetCurrentThread", "handles": false }
	,{ "name": "GetState", "func": "ves_icall_System_Threading_Thread_GetState_raw", "handles": true }
	,{ "name": "InitInternal", "func": "ves_icall_System_Threading_Thread_InitInternal_raw", "handles": true }
	,{ "name": "InterruptInternal", "func": "ves_icall_System_Threading_Thread_Interrupt_internal_raw", "handles": true }
	,{ "name": "JoinInternal", "func": "ves_icall_System_Threading_Thread_Join_internal_raw", "handles": true }
	,{ "name": "SetName_icall", "func": "ves_icall_System_Threading_Thread_SetName_icall_raw", "handles": true }
	,{ "name": "SetPriority", "func": "ves_icall_System_Threading_Thread_SetPriority_raw", "handles": true }
	,{ "name": "SetState", "func": "ves_icall_System_Threading_Thread_SetState_raw", "handles": true }
	,{ "name": "StartInternal", "func": "ves_icall_System_Threading_Thread_StartInternal_raw", "handles": true }
	,{ "name": "YieldInternal", "func": "ves_icall_System_Threading_Thread_YieldInternal", "handles": false }
]},
 { "klass":"System.Type", "icalls": [{} 	,{ "name": "internal_from_handle", "func": "ves_icall_System_Type_internal_from_handle_raw", "handles": true }
]},
 { "klass":"System.TypedReference", "icalls": [{} 	,{ "name": "InternalMakeTypedReference", "func": "ves_icall_System_TypedReference_InternalMakeTypedReference_raw", "handles": true }
	,{ "name": "InternalToObject", "func": "ves_icall_System_TypedReference_ToObject_raw", "handles": true }
]},
 { "klass":"System.ValueType", "icalls": [{} 	,{ "name": "InternalEquals", "func": "ves_icall_System_ValueType_Equals_raw", "handles": true }
	,{ "name": "InternalGetHashCode", "func": "ves_icall_System_ValueType_InternalGetHashCode_raw", "handles": true }
]}
]
