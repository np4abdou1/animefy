using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Content
{
	// Token: 0x0200005B RID: 91
	[Register("androidx/core/content/OnTrimMemoryProvider", DoNotGenerateAcw = true)]
	internal class IOnTrimMemoryProviderInvoker : Java.Lang.Object, IOnTrimMemoryProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00008F7C File Offset: 0x0000717C
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnTrimMemoryProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00008FA0 File Offset: 0x000071A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnTrimMemoryProviderInvoker._members;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00008FA7 File Offset: 0x000071A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00008FAF File Offset: 0x000071AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnTrimMemoryProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00008FBB File Offset: 0x000071BB
		public static IOnTrimMemoryProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnTrimMemoryProvider>(handle, transfer);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00008FC4 File Offset: 0x000071C4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnTrimMemoryProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.content.OnTrimMemoryProvider'.");
			}
			return handle;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00008FEF File Offset: 0x000071EF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00009020 File Offset: 0x00007220
		public IOnTrimMemoryProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnTrimMemoryProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00009058 File Offset: 0x00007258
		private static Delegate GetAddOnTrimMemoryListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnTrimMemoryProviderInvoker.cb_addOnTrimMemoryListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnTrimMemoryProviderInvoker.cb_addOnTrimMemoryListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnTrimMemoryProviderInvoker.n_AddOnTrimMemoryListener_Landroidx_core_util_Consumer_));
			}
			return IOnTrimMemoryProviderInvoker.cb_addOnTrimMemoryListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000907C File Offset: 0x0000727C
		private static void n_AddOnTrimMemoryListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnTrimMemoryProvider @object = Java.Lang.Object.GetObject<IOnTrimMemoryProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddOnTrimMemoryListener(object2);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000090A0 File Offset: 0x000072A0
		public unsafe void AddOnTrimMemoryListener(IConsumer p0)
		{
			if (this.id_addOnTrimMemoryListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_addOnTrimMemoryListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "addOnTrimMemoryListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addOnTrimMemoryListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00009118 File Offset: 0x00007318
		private static Delegate GetRemoveOnTrimMemoryListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnTrimMemoryProviderInvoker.cb_removeOnTrimMemoryListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnTrimMemoryProviderInvoker.cb_removeOnTrimMemoryListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnTrimMemoryProviderInvoker.n_RemoveOnTrimMemoryListener_Landroidx_core_util_Consumer_));
			}
			return IOnTrimMemoryProviderInvoker.cb_removeOnTrimMemoryListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000913C File Offset: 0x0000733C
		private static void n_RemoveOnTrimMemoryListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnTrimMemoryProvider @object = Java.Lang.Object.GetObject<IOnTrimMemoryProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnTrimMemoryListener(object2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00009160 File Offset: 0x00007360
		public unsafe void RemoveOnTrimMemoryListener(IConsumer p0)
		{
			if (this.id_removeOnTrimMemoryListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_removeOnTrimMemoryListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "removeOnTrimMemoryListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeOnTrimMemoryListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x040000D2 RID: 210
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/content/OnTrimMemoryProvider", typeof(IOnTrimMemoryProviderInvoker));

		// Token: 0x040000D3 RID: 211
		private IntPtr class_ref;

		// Token: 0x040000D4 RID: 212
		private static Delegate cb_addOnTrimMemoryListener_Landroidx_core_util_Consumer_;

		// Token: 0x040000D5 RID: 213
		private IntPtr id_addOnTrimMemoryListener_Landroidx_core_util_Consumer_;

		// Token: 0x040000D6 RID: 214
		private static Delegate cb_removeOnTrimMemoryListener_Landroidx_core_util_Consumer_;

		// Token: 0x040000D7 RID: 215
		private IntPtr id_removeOnTrimMemoryListener_Landroidx_core_util_Consumer_;
	}
}
