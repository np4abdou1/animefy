using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Reflect
{
	// Token: 0x020000FD RID: 253
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KAnnotatedElement", DoNotGenerateAcw = true)]
	internal class IKAnnotatedElementInvoker : Java.Lang.Object, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00028D5C File Offset: 0x00026F5C
		private static IntPtr java_class_ref
		{
			get
			{
				return IKAnnotatedElementInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00028D80 File Offset: 0x00026F80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKAnnotatedElementInvoker._members;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00028D87 File Offset: 0x00026F87
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00028D8F File Offset: 0x00026F8F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKAnnotatedElementInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00028D9B File Offset: 0x00026F9B
		[NullableContext(2)]
		public static IKAnnotatedElement GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKAnnotatedElement>(handle, transfer);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00028DA4 File Offset: 0x00026FA4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKAnnotatedElementInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KAnnotatedElement'.");
			}
			return handle;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00028DCF File Offset: 0x00026FCF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00028E00 File Offset: 0x00027000
		public IKAnnotatedElementInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKAnnotatedElementInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00028E38 File Offset: 0x00027038
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKAnnotatedElementInvoker.cb_getAnnotations == null)
			{
				IKAnnotatedElementInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKAnnotatedElementInvoker.n_GetAnnotations));
			}
			return IKAnnotatedElementInvoker.cb_getAnnotations;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00028E5C File Offset: 0x0002705C
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKAnnotatedElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00028E70 File Offset: 0x00027070
		public IList<IAnnotation> Annotations
		{
			get
			{
				if (this.id_getAnnotations == IntPtr.Zero)
				{
					this.id_getAnnotations = JNIEnv.GetMethodID(this.class_ref, "getAnnotations", "()Ljava/util/List;");
				}
				return JavaList<IAnnotation>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getAnnotations), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000268 RID: 616
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KAnnotatedElement", typeof(IKAnnotatedElementInvoker));

		// Token: 0x04000269 RID: 617
		private IntPtr class_ref;

		// Token: 0x0400026A RID: 618
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x0400026B RID: 619
		private IntPtr id_getAnnotations;
	}
}
