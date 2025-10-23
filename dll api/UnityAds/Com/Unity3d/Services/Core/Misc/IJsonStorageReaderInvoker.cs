using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000DC RID: 220
	[Register("com/unity3d/services/core/misc/IJsonStorageReader", DoNotGenerateAcw = true)]
	internal class IJsonStorageReaderInvoker : Java.Lang.Object, IJsonStorageReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00018BDC File Offset: 0x00016DDC
		private static IntPtr java_class_ref
		{
			get
			{
				return IJsonStorageReaderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00018C00 File Offset: 0x00016E00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJsonStorageReaderInvoker._members;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00018C07 File Offset: 0x00016E07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00018C0F File Offset: 0x00016E0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJsonStorageReaderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00018C1B File Offset: 0x00016E1B
		public static IJsonStorageReader GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJsonStorageReader>(handle, transfer);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00018C24 File Offset: 0x00016E24
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJsonStorageReaderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.misc.IJsonStorageReader'.");
			}
			return handle;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00018C4F File Offset: 0x00016E4F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00018C80 File Offset: 0x00016E80
		public IJsonStorageReaderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJsonStorageReaderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00018CB8 File Offset: 0x00016EB8
		private static Delegate GetGetDataHandler()
		{
			if (IJsonStorageReaderInvoker.cb_getData == null)
			{
				IJsonStorageReaderInvoker.cb_getData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJsonStorageReaderInvoker.n_GetData));
			}
			return IJsonStorageReaderInvoker.cb_getData;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00018CDC File Offset: 0x00016EDC
		private static IntPtr n_GetData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJsonStorageReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Data);
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00018CF0 File Offset: 0x00016EF0
		public JSONObject Data
		{
			get
			{
				if (this.id_getData == IntPtr.Zero)
				{
					this.id_getData = JNIEnv.GetMethodID(this.class_ref, "getData", "()Lorg/json/JSONObject;");
				}
				return Java.Lang.Object.GetObject<JSONObject>(JNIEnv.CallObjectMethod(base.Handle, this.id_getData), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00018D41 File Offset: 0x00016F41
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (IJsonStorageReaderInvoker.cb_get_Ljava_lang_String_ == null)
			{
				IJsonStorageReaderInvoker.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IJsonStorageReaderInvoker.n_Get_Ljava_lang_String_));
			}
			return IJsonStorageReaderInvoker.cb_get_Ljava_lang_String_;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00018D68 File Offset: 0x00016F68
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IJsonStorageReader @object = Java.Lang.Object.GetObject<IJsonStorageReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00018D90 File Offset: 0x00016F90
		public unsafe Java.Lang.Object Get(string p0)
		{
			if (this.id_get_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04000203 RID: 515
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/IJsonStorageReader", typeof(IJsonStorageReaderInvoker));

		// Token: 0x04000204 RID: 516
		private IntPtr class_ref;

		// Token: 0x04000205 RID: 517
		private static Delegate cb_getData;

		// Token: 0x04000206 RID: 518
		private IntPtr id_getData;

		// Token: 0x04000207 RID: 519
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x04000208 RID: 520
		private IntPtr id_get_Ljava_lang_String_;
	}
}
