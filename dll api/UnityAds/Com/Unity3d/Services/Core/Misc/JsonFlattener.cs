using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000DF RID: 223
	[Register("com/unity3d/services/core/misc/JsonFlattener", DoNotGenerateAcw = true)]
	public class JsonFlattener : Java.Lang.Object
	{
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00018FD4 File Offset: 0x000171D4
		internal static IntPtr class_ref
		{
			get
			{
				return JsonFlattener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00018FF8 File Offset: 0x000171F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JsonFlattener._members;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00019000 File Offset: 0x00017200
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JsonFlattener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x00019024 File Offset: 0x00017224
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JsonFlattener._members.ManagedPeerType;
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000021E8 File Offset: 0x000003E8
		protected JsonFlattener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00019030 File Offset: 0x00017230
		[Register(".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe JsonFlattener(JSONObject jsonData) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((jsonData == null) ? IntPtr.Zero : jsonData.Handle);
				base.SetHandle(JsonFlattener._members.InstanceMethods.StartCreateInstance("(Lorg/json/JSONObject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				JsonFlattener._members.InstanceMethods.FinishCreateInstance("(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(jsonData);
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000190E0 File Offset: 0x000172E0
		private static Delegate GetFlattenJson_Ljava_lang_String_Lcom_unity3d_services_core_misc_JsonFlattenerRules_Handler()
		{
			if (JsonFlattener.cb_flattenJson_Ljava_lang_String_Lcom_unity3d_services_core_misc_JsonFlattenerRules_ == null)
			{
				JsonFlattener.cb_flattenJson_Ljava_lang_String_Lcom_unity3d_services_core_misc_JsonFlattenerRules_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(JsonFlattener.n_FlattenJson_Ljava_lang_String_Lcom_unity3d_services_core_misc_JsonFlattenerRules_));
			}
			return JsonFlattener.cb_flattenJson_Ljava_lang_String_Lcom_unity3d_services_core_misc_JsonFlattenerRules_;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00019104 File Offset: 0x00017304
		private static IntPtr n_FlattenJson_Ljava_lang_String_Lcom_unity3d_services_core_misc_JsonFlattenerRules_(IntPtr jnienv, IntPtr native__this, IntPtr native_separator, IntPtr native_jsonFlattenerRules)
		{
			JsonFlattener @object = Java.Lang.Object.GetObject<JsonFlattener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_separator, JniHandleOwnership.DoNotTransfer);
			JsonFlattenerRules object2 = Java.Lang.Object.GetObject<JsonFlattenerRules>(native_jsonFlattenerRules, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FlattenJson(@string, object2));
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00019138 File Offset: 0x00017338
		[Register("flattenJson", "(Ljava/lang/String;Lcom/unity3d/services/core/misc/JsonFlattenerRules;)Lorg/json/JSONObject;", "GetFlattenJson_Ljava_lang_String_Lcom_unity3d_services_core_misc_JsonFlattenerRules_Handler")]
		public unsafe virtual JSONObject FlattenJson(string separator, JsonFlattenerRules jsonFlattenerRules)
		{
			IntPtr intPtr = JNIEnv.NewString(separator);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((jsonFlattenerRules == null) ? IntPtr.Zero : jsonFlattenerRules.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(JsonFlattener._members.InstanceMethods.InvokeVirtualObjectMethod("flattenJson.(Ljava/lang/String;Lcom/unity3d/services/core/misc/JsonFlattenerRules;)Lorg/json/JSONObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(jsonFlattenerRules);
			}
			return @object;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000191CC File Offset: 0x000173CC
		private static Delegate GetFlattenJson_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Ljava_util_List_Ljava_util_List_Handler()
		{
			if (JsonFlattener.cb_flattenJson_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Ljava_util_List_Ljava_util_List_ == null)
			{
				JsonFlattener.cb_flattenJson_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLL_V(JsonFlattener.n_FlattenJson_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Ljava_util_List_Ljava_util_List_));
			}
			return JsonFlattener.cb_flattenJson_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Ljava_util_List_Ljava_util_List_;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000191F0 File Offset: 0x000173F0
		private static void n_FlattenJson_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Ljava_util_List_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_separator, IntPtr native_parentName, IntPtr native_outputDictionary, IntPtr native_reduceKeys, IntPtr native_skipKeys)
		{
			JsonFlattener @object = Java.Lang.Object.GetObject<JsonFlattener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_separator, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_parentName, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_outputDictionary, JniHandleOwnership.DoNotTransfer);
			IList<string> reduceKeys = JavaList<string>.FromJniHandle(native_reduceKeys, JniHandleOwnership.DoNotTransfer);
			IList<string> skipKeys = JavaList<string>.FromJniHandle(native_skipKeys, JniHandleOwnership.DoNotTransfer);
			@object.FlattenJson(@string, string2, object2, reduceKeys, skipKeys);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0001923C File Offset: 0x0001743C
		[Register("flattenJson", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Ljava/util/List;Ljava/util/List;)V", "GetFlattenJson_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Ljava_util_List_Ljava_util_List_Handler")]
		public unsafe virtual void FlattenJson(string separator, string parentName, JSONObject outputDictionary, IList<string> reduceKeys, IList<string> skipKeys)
		{
			IntPtr intPtr = JNIEnv.NewString(separator);
			IntPtr intPtr2 = JNIEnv.NewString(parentName);
			IntPtr intPtr3 = JavaList<string>.ToLocalJniHandle(reduceKeys);
			IntPtr intPtr4 = JavaList<string>.ToLocalJniHandle(skipKeys);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((outputDictionary == null) ? IntPtr.Zero : outputDictionary.Handle);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue(intPtr4);
				JsonFlattener._members.InstanceMethods.InvokeVirtualVoidMethod("flattenJson.(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Ljava/util/List;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(outputDictionary);
				GC.KeepAlive(reduceKeys);
				GC.KeepAlive(skipKeys);
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00019340 File Offset: 0x00017540
		private static Delegate GetFlattenJson_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler()
		{
			if (JsonFlattener.cb_flattenJson_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == null)
			{
				JsonFlattener.cb_flattenJson_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(JsonFlattener.n_FlattenJson_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_));
			}
			return JsonFlattener.cb_flattenJson_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00019364 File Offset: 0x00017564
		private static IntPtr n_FlattenJson_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_separator, IntPtr native_topLevelToInclude, IntPtr native_reduceKeys, IntPtr native_skipKeys)
		{
			JsonFlattener @object = Java.Lang.Object.GetObject<JsonFlattener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_separator, JniHandleOwnership.DoNotTransfer);
			IList<string> topLevelToInclude = JavaList<string>.FromJniHandle(native_topLevelToInclude, JniHandleOwnership.DoNotTransfer);
			IList<string> reduceKeys = JavaList<string>.FromJniHandle(native_reduceKeys, JniHandleOwnership.DoNotTransfer);
			IList<string> skipKeys = JavaList<string>.FromJniHandle(native_skipKeys, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FlattenJson(@string, topLevelToInclude, reduceKeys, skipKeys));
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000193AC File Offset: 0x000175AC
		[Register("flattenJson", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lorg/json/JSONObject;", "GetFlattenJson_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler")]
		public unsafe virtual JSONObject FlattenJson(string separator, IList<string> topLevelToInclude, IList<string> reduceKeys, IList<string> skipKeys)
		{
			IntPtr intPtr = JNIEnv.NewString(separator);
			IntPtr intPtr2 = JavaList<string>.ToLocalJniHandle(topLevelToInclude);
			IntPtr intPtr3 = JavaList<string>.ToLocalJniHandle(reduceKeys);
			IntPtr intPtr4 = JavaList<string>.ToLocalJniHandle(skipKeys);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				@object = Java.Lang.Object.GetObject<JSONObject>(JsonFlattener._members.InstanceMethods.InvokeVirtualObjectMethod("flattenJson.(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lorg/json/JSONObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(topLevelToInclude);
				GC.KeepAlive(reduceKeys);
				GC.KeepAlive(skipKeys);
			}
			return @object;
		}

		// Token: 0x0400020D RID: 525
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/JsonFlattener", typeof(JsonFlattener));

		// Token: 0x0400020E RID: 526
		private static Delegate cb_flattenJson_Ljava_lang_String_Lcom_unity3d_services_core_misc_JsonFlattenerRules_;

		// Token: 0x0400020F RID: 527
		private static Delegate cb_flattenJson_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Ljava_util_List_Ljava_util_List_;

		// Token: 0x04000210 RID: 528
		private static Delegate cb_flattenJson_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
	}
}
