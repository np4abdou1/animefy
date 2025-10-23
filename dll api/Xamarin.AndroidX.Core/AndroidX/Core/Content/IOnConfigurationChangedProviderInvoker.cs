using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Content
{
	// Token: 0x02000059 RID: 89
	[Register("androidx/core/content/OnConfigurationChangedProvider", DoNotGenerateAcw = true)]
	internal class IOnConfigurationChangedProviderInvoker : Java.Lang.Object, IOnConfigurationChangedProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00008D04 File Offset: 0x00006F04
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnConfigurationChangedProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00008D28 File Offset: 0x00006F28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnConfigurationChangedProviderInvoker._members;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00008D2F File Offset: 0x00006F2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00008D37 File Offset: 0x00006F37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnConfigurationChangedProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00008D43 File Offset: 0x00006F43
		public static IOnConfigurationChangedProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnConfigurationChangedProvider>(handle, transfer);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00008D4C File Offset: 0x00006F4C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnConfigurationChangedProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.content.OnConfigurationChangedProvider'.");
			}
			return handle;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00008D77 File Offset: 0x00006F77
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00008DA8 File Offset: 0x00006FA8
		public IOnConfigurationChangedProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnConfigurationChangedProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00008DE0 File Offset: 0x00006FE0
		private static Delegate GetAddOnConfigurationChangedListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnConfigurationChangedProviderInvoker.cb_addOnConfigurationChangedListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnConfigurationChangedProviderInvoker.cb_addOnConfigurationChangedListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnConfigurationChangedProviderInvoker.n_AddOnConfigurationChangedListener_Landroidx_core_util_Consumer_));
			}
			return IOnConfigurationChangedProviderInvoker.cb_addOnConfigurationChangedListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00008E04 File Offset: 0x00007004
		private static void n_AddOnConfigurationChangedListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnConfigurationChangedProvider @object = Java.Lang.Object.GetObject<IOnConfigurationChangedProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddOnConfigurationChangedListener(object2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00008E28 File Offset: 0x00007028
		public unsafe void AddOnConfigurationChangedListener(IConsumer p0)
		{
			if (this.id_addOnConfigurationChangedListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_addOnConfigurationChangedListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "addOnConfigurationChangedListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addOnConfigurationChangedListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00008EA0 File Offset: 0x000070A0
		private static Delegate GetRemoveOnConfigurationChangedListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnConfigurationChangedProviderInvoker.cb_removeOnConfigurationChangedListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnConfigurationChangedProviderInvoker.cb_removeOnConfigurationChangedListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnConfigurationChangedProviderInvoker.n_RemoveOnConfigurationChangedListener_Landroidx_core_util_Consumer_));
			}
			return IOnConfigurationChangedProviderInvoker.cb_removeOnConfigurationChangedListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00008EC4 File Offset: 0x000070C4
		private static void n_RemoveOnConfigurationChangedListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnConfigurationChangedProvider @object = Java.Lang.Object.GetObject<IOnConfigurationChangedProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnConfigurationChangedListener(object2);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00008EE8 File Offset: 0x000070E8
		public unsafe void RemoveOnConfigurationChangedListener(IConsumer p0)
		{
			if (this.id_removeOnConfigurationChangedListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_removeOnConfigurationChangedListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "removeOnConfigurationChangedListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeOnConfigurationChangedListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x040000CC RID: 204
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/content/OnConfigurationChangedProvider", typeof(IOnConfigurationChangedProviderInvoker));

		// Token: 0x040000CD RID: 205
		private IntPtr class_ref;

		// Token: 0x040000CE RID: 206
		private static Delegate cb_addOnConfigurationChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x040000CF RID: 207
		private IntPtr id_addOnConfigurationChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x040000D0 RID: 208
		private static Delegate cb_removeOnConfigurationChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x040000D1 RID: 209
		private IntPtr id_removeOnConfigurationChangedListener_Landroidx_core_util_Consumer_;
	}
}
