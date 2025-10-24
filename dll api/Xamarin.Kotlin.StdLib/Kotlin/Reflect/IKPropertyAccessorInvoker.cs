using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000120 RID: 288
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty$Accessor", DoNotGenerateAcw = true)]
	internal class IKPropertyAccessorInvoker : Java.Lang.Object, IKPropertyAccessor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00031358 File Offset: 0x0002F558
		private static IntPtr java_class_ref
		{
			get
			{
				return IKPropertyAccessorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x0003137C File Offset: 0x0002F57C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKPropertyAccessorInvoker._members;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00031383 File Offset: 0x0002F583
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0003138B File Offset: 0x0002F58B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKPropertyAccessorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00031397 File Offset: 0x0002F597
		[NullableContext(2)]
		public static IKPropertyAccessor GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKPropertyAccessor>(handle, transfer);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000313A0 File Offset: 0x0002F5A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKPropertyAccessorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty.Accessor'.");
			}
			return handle;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000313CB File Offset: 0x0002F5CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000313FC File Offset: 0x0002F5FC
		public IKPropertyAccessorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKPropertyAccessorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00031434 File Offset: 0x0002F634
		private static Delegate GetGetPropertyHandler()
		{
			if (IKPropertyAccessorInvoker.cb_getProperty == null)
			{
				IKPropertyAccessorInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyAccessorInvoker.n_GetProperty));
			}
			return IKPropertyAccessorInvoker.cb_getProperty;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00031458 File Offset: 0x0002F658
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKPropertyAccessor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0003146C File Offset: 0x0002F66C
		public IKProperty Property
		{
			get
			{
				if (this.id_getProperty == IntPtr.Zero)
				{
					this.id_getProperty = JNIEnv.GetMethodID(this.class_ref, "getProperty", "()Lkotlin/reflect/KProperty;");
				}
				return Java.Lang.Object.GetObject<IKProperty>(JNIEnv.CallObjectMethod(base.Handle, this.id_getProperty), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000429 RID: 1065
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty$Accessor", typeof(IKPropertyAccessorInvoker));

		// Token: 0x0400042A RID: 1066
		private IntPtr class_ref;

		// Token: 0x0400042B RID: 1067
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x0400042C RID: 1068
		private IntPtr id_getProperty;
	}
}
