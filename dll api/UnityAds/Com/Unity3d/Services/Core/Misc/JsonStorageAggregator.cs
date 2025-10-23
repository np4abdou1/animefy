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
	// Token: 0x020000E2 RID: 226
	[Register("com/unity3d/services/core/misc/JsonStorageAggregator", DoNotGenerateAcw = true)]
	public class JsonStorageAggregator : Java.Lang.Object, IJsonStorageReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00019D5C File Offset: 0x00017F5C
		internal static IntPtr class_ref
		{
			get
			{
				return JsonStorageAggregator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00019D80 File Offset: 0x00017F80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JsonStorageAggregator._members;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00019D88 File Offset: 0x00017F88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JsonStorageAggregator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00019DAC File Offset: 0x00017FAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JsonStorageAggregator._members.ManagedPeerType;
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000021E8 File Offset: 0x000003E8
		protected JsonStorageAggregator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00019DB8 File Offset: 0x00017FB8
		[Register(".ctor", "(Ljava/util/List;)V", "")]
		public unsafe JsonStorageAggregator(IList<IJsonStorageReader> jsonStorageReaders) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<IJsonStorageReader>.ToLocalJniHandle(jsonStorageReaders);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(JsonStorageAggregator._members.InstanceMethods.StartCreateInstance("(Ljava/util/List;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				JsonStorageAggregator._members.InstanceMethods.FinishCreateInstance("(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(jsonStorageReaders);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00019E64 File Offset: 0x00018064
		private static Delegate GetGetDataHandler()
		{
			if (JsonStorageAggregator.cb_getData == null)
			{
				JsonStorageAggregator.cb_getData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JsonStorageAggregator.n_GetData));
			}
			return JsonStorageAggregator.cb_getData;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00019E88 File Offset: 0x00018088
		private static IntPtr n_GetData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JsonStorageAggregator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Data);
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00019E9C File Offset: 0x0001809C
		public virtual JSONObject Data
		{
			[Register("getData", "()Lorg/json/JSONObject;", "GetGetDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(JsonStorageAggregator._members.InstanceMethods.InvokeVirtualObjectMethod("getData.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00019ECE File Offset: 0x000180CE
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (JsonStorageAggregator.cb_get_Ljava_lang_String_ == null)
			{
				JsonStorageAggregator.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(JsonStorageAggregator.n_Get_Ljava_lang_String_));
			}
			return JsonStorageAggregator.cb_get_Ljava_lang_String_;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00019EF4 File Offset: 0x000180F4
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			JsonStorageAggregator @object = Java.Lang.Object.GetObject<JsonStorageAggregator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00019F1C File Offset: 0x0001811C
		[Register("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public unsafe virtual Java.Lang.Object Get(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JsonStorageAggregator._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0400021F RID: 543
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/JsonStorageAggregator", typeof(JsonStorageAggregator));

		// Token: 0x04000220 RID: 544
		private static Delegate cb_getData;

		// Token: 0x04000221 RID: 545
		private static Delegate cb_get_Ljava_lang_String_;
	}
}
