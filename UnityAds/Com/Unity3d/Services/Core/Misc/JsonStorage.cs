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
	// Token: 0x020000E1 RID: 225
	[Register("com/unity3d/services/core/misc/JsonStorage", DoNotGenerateAcw = true)]
	public class JsonStorage : Java.Lang.Object, IJsonStorageReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00019770 File Offset: 0x00017970
		internal static IntPtr class_ref
		{
			get
			{
				return JsonStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00019794 File Offset: 0x00017994
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JsonStorage._members;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0001979C File Offset: 0x0001799C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JsonStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x000197C0 File Offset: 0x000179C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JsonStorage._members.ManagedPeerType;
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000021E8 File Offset: 0x000003E8
		protected JsonStorage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000197CC File Offset: 0x000179CC
		[Register(".ctor", "()V", "")]
		public JsonStorage() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(JsonStorage._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			JsonStorage._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0001983A File Offset: 0x00017A3A
		private static Delegate GetGetDataHandler()
		{
			if (JsonStorage.cb_getData == null)
			{
				JsonStorage.cb_getData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JsonStorage.n_GetData));
			}
			return JsonStorage.cb_getData;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0001985E File Offset: 0x00017A5E
		private static IntPtr n_GetData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Data);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00019872 File Offset: 0x00017A72
		private static Delegate GetSetData_Lorg_json_JSONObject_Handler()
		{
			if (JsonStorage.cb_setData_Lorg_json_JSONObject_ == null)
			{
				JsonStorage.cb_setData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(JsonStorage.n_SetData_Lorg_json_JSONObject_));
			}
			return JsonStorage.cb_setData_Lorg_json_JSONObject_;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00019898 File Offset: 0x00017A98
		private static void n_SetData_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			JsonStorage @object = Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_data, JniHandleOwnership.DoNotTransfer);
			@object.Data = object2;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000198BC File Offset: 0x00017ABC
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x000198F0 File Offset: 0x00017AF0
		public unsafe virtual JSONObject Data
		{
			[Register("getData", "()Lorg/json/JSONObject;", "GetGetDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(JsonStorage._members.InstanceMethods.InvokeVirtualObjectMethod("getData.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setData", "(Lorg/json/JSONObject;)V", "GetSetData_Lorg_json_JSONObject_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					JsonStorage._members.InstanceMethods.InvokeVirtualVoidMethod("setData.(Lorg/json/JSONObject;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00019954 File Offset: 0x00017B54
		private static Delegate GetHasDataHandler()
		{
			if (JsonStorage.cb_hasData == null)
			{
				JsonStorage.cb_hasData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(JsonStorage.n_HasData));
			}
			return JsonStorage.cb_hasData;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00019978 File Offset: 0x00017B78
		private static bool n_HasData(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasData;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00019987 File Offset: 0x00017B87
		public virtual bool HasData
		{
			[Register("hasData", "()Z", "GetHasDataHandler")]
			get
			{
				return JsonStorage._members.InstanceMethods.InvokeVirtualBooleanMethod("hasData.()Z", this, null);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000199A0 File Offset: 0x00017BA0
		private static Delegate GetClearDataHandler()
		{
			if (JsonStorage.cb_clearData == null)
			{
				JsonStorage.cb_clearData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(JsonStorage.n_ClearData));
			}
			return JsonStorage.cb_clearData;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000199C4 File Offset: 0x00017BC4
		private static void n_ClearData(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearData();
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000199D3 File Offset: 0x00017BD3
		[Register("clearData", "()V", "GetClearDataHandler")]
		public virtual void ClearData()
		{
			JsonStorage._members.InstanceMethods.InvokeVirtualVoidMethod("clearData.()V", this, null);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000199EC File Offset: 0x00017BEC
		private static Delegate GetDelete_Ljava_lang_String_Handler()
		{
			if (JsonStorage.cb_delete_Ljava_lang_String_ == null)
			{
				JsonStorage.cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JsonStorage.n_Delete_Ljava_lang_String_));
			}
			return JsonStorage.cb_delete_Ljava_lang_String_;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00019A10 File Offset: 0x00017C10
		private static bool n_Delete_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			JsonStorage @object = Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.Delete(@string);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00019A34 File Offset: 0x00017C34
		[Register("delete", "(Ljava/lang/String;)Z", "GetDelete_Ljava_lang_String_Handler")]
		public unsafe virtual bool Delete(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JsonStorage._members.InstanceMethods.InvokeVirtualBooleanMethod("delete.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00019A94 File Offset: 0x00017C94
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (JsonStorage.cb_get_Ljava_lang_String_ == null)
			{
				JsonStorage.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(JsonStorage.n_Get_Ljava_lang_String_));
			}
			return JsonStorage.cb_get_Ljava_lang_String_;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00019AB8 File Offset: 0x00017CB8
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			JsonStorage @object = Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00019AE0 File Offset: 0x00017CE0
		[Register("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public unsafe virtual Java.Lang.Object Get(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JsonStorage._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00019B4C File Offset: 0x00017D4C
		private static Delegate GetGetKeys_Ljava_lang_String_ZHandler()
		{
			if (JsonStorage.cb_getKeys_Ljava_lang_String_Z == null)
			{
				JsonStorage.cb_getKeys_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(JsonStorage.n_GetKeys_Ljava_lang_String_Z));
			}
			return JsonStorage.cb_getKeys_Ljava_lang_String_Z;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00019B70 File Offset: 0x00017D70
		private static IntPtr n_GetKeys_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_key, bool recursive)
		{
			JsonStorage @object = Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JavaList<string>.ToLocalJniHandle(@object.GetKeys(@string, recursive));
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00019B9C File Offset: 0x00017D9C
		[Register("getKeys", "(Ljava/lang/String;Z)Ljava/util/List;", "GetGetKeys_Ljava_lang_String_ZHandler")]
		public unsafe virtual IList<string> GetKeys(string key, bool recursive)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(recursive);
				result = JavaList<string>.FromJniHandle(JsonStorage._members.InstanceMethods.InvokeVirtualObjectMethod("getKeys.(Ljava/lang/String;Z)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00019C1C File Offset: 0x00017E1C
		private static Delegate GetInitDataHandler()
		{
			if (JsonStorage.cb_initData == null)
			{
				JsonStorage.cb_initData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(JsonStorage.n_InitData));
			}
			return JsonStorage.cb_initData;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00019C40 File Offset: 0x00017E40
		private static bool n_InitData(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitData();
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00019C4F File Offset: 0x00017E4F
		[Register("initData", "()Z", "GetInitDataHandler")]
		public virtual bool InitData()
		{
			return JsonStorage._members.InstanceMethods.InvokeVirtualBooleanMethod("initData.()Z", this, null);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00019C68 File Offset: 0x00017E68
		private static Delegate GetSet_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (JsonStorage.cb_set_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				JsonStorage.cb_set_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(JsonStorage.n_Set_Ljava_lang_String_Ljava_lang_Object_));
			}
			return JsonStorage.cb_set_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00019C8C File Offset: 0x00017E8C
		private static bool n_Set_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			JsonStorage @object = Java.Lang.Object.GetObject<JsonStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Set(@string, object2);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00019CB8 File Offset: 0x00017EB8
		[Register("set", "(Ljava/lang/String;Ljava/lang/Object;)Z", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual bool Set(string key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = JsonStorage._members.InstanceMethods.InvokeVirtualBooleanMethod("set.(Ljava/lang/String;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x04000215 RID: 533
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/JsonStorage", typeof(JsonStorage));

		// Token: 0x04000216 RID: 534
		private static Delegate cb_getData;

		// Token: 0x04000217 RID: 535
		private static Delegate cb_setData_Lorg_json_JSONObject_;

		// Token: 0x04000218 RID: 536
		private static Delegate cb_hasData;

		// Token: 0x04000219 RID: 537
		private static Delegate cb_clearData;

		// Token: 0x0400021A RID: 538
		private static Delegate cb_delete_Ljava_lang_String_;

		// Token: 0x0400021B RID: 539
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x0400021C RID: 540
		private static Delegate cb_getKeys_Ljava_lang_String_Z;

		// Token: 0x0400021D RID: 541
		private static Delegate cb_initData;

		// Token: 0x0400021E RID: 542
		private static Delegate cb_set_Ljava_lang_String_Ljava_lang_Object_;
	}
}
