using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Text;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Internal
{
	// Token: 0x02000095 RID: 149
	[Register("com/google/android/material/internal/StaticLayoutBuilderConfigurer", DoNotGenerateAcw = true)]
	internal class IStaticLayoutBuilderConfigurerInvoker : Java.Lang.Object, IStaticLayoutBuilderConfigurer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0001B604 File Offset: 0x00019804
		private static IntPtr java_class_ref
		{
			get
			{
				return IStaticLayoutBuilderConfigurerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0001B628 File Offset: 0x00019828
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IStaticLayoutBuilderConfigurerInvoker._members;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0001B62F File Offset: 0x0001982F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0001B637 File Offset: 0x00019837
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IStaticLayoutBuilderConfigurerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001B643 File Offset: 0x00019843
		public static IStaticLayoutBuilderConfigurer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IStaticLayoutBuilderConfigurer>(handle, transfer);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001B64C File Offset: 0x0001984C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IStaticLayoutBuilderConfigurerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.internal.StaticLayoutBuilderConfigurer'.");
			}
			return handle;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0001B677 File Offset: 0x00019877
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0001B6A8 File Offset: 0x000198A8
		public IStaticLayoutBuilderConfigurerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IStaticLayoutBuilderConfigurerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0001B6E0 File Offset: 0x000198E0
		private static Delegate GetConfigure_Landroid_text_StaticLayout_Builder_Handler()
		{
			if (IStaticLayoutBuilderConfigurerInvoker.cb_configure_Landroid_text_StaticLayout_Builder_ == null)
			{
				IStaticLayoutBuilderConfigurerInvoker.cb_configure_Landroid_text_StaticLayout_Builder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IStaticLayoutBuilderConfigurerInvoker.n_Configure_Landroid_text_StaticLayout_Builder_));
			}
			return IStaticLayoutBuilderConfigurerInvoker.cb_configure_Landroid_text_StaticLayout_Builder_;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001B704 File Offset: 0x00019904
		private static void n_Configure_Landroid_text_StaticLayout_Builder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IStaticLayoutBuilderConfigurer @object = Java.Lang.Object.GetObject<IStaticLayoutBuilderConfigurer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			StaticLayout.Builder object2 = Java.Lang.Object.GetObject<StaticLayout.Builder>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Configure(object2);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0001B728 File Offset: 0x00019928
		public unsafe void Configure(StaticLayout.Builder p0)
		{
			if (this.id_configure_Landroid_text_StaticLayout_Builder_ == IntPtr.Zero)
			{
				this.id_configure_Landroid_text_StaticLayout_Builder_ = JNIEnv.GetMethodID(this.class_ref, "configure", "(Landroid/text/StaticLayout$Builder;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_configure_Landroid_text_StaticLayout_Builder_, ptr);
		}

		// Token: 0x040002E8 RID: 744
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/internal/StaticLayoutBuilderConfigurer", typeof(IStaticLayoutBuilderConfigurerInvoker));

		// Token: 0x040002E9 RID: 745
		private IntPtr class_ref;

		// Token: 0x040002EA RID: 746
		private static Delegate cb_configure_Landroid_text_StaticLayout_Builder_;

		// Token: 0x040002EB RID: 747
		private IntPtr id_configure_Landroid_text_StaticLayout_Builder_;
	}
}
