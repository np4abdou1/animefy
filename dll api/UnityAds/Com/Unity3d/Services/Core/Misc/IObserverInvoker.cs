using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000DE RID: 222
	[Register("com/unity3d/services/core/misc/IObserver", DoNotGenerateAcw = true)]
	internal class IObserverInvoker : Java.Lang.Object, IObserver, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00018E24 File Offset: 0x00017024
		private static IntPtr java_class_ref
		{
			get
			{
				return IObserverInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00018E48 File Offset: 0x00017048
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IObserverInvoker._members;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00018E4F File Offset: 0x0001704F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00018E57 File Offset: 0x00017057
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IObserverInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00018E63 File Offset: 0x00017063
		public static IObserver GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IObserver>(handle, transfer);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00018E6C File Offset: 0x0001706C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IObserverInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.misc.IObserver'.");
			}
			return handle;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00018E97 File Offset: 0x00017097
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00018EC8 File Offset: 0x000170C8
		public IObserverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IObserverInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00018F00 File Offset: 0x00017100
		private static Delegate GetUpdated_Ljava_lang_Object_Handler()
		{
			if (IObserverInvoker.cb_updated_Ljava_lang_Object_ == null)
			{
				IObserverInvoker.cb_updated_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IObserverInvoker.n_Updated_Ljava_lang_Object_));
			}
			return IObserverInvoker.cb_updated_Ljava_lang_Object_;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00018F24 File Offset: 0x00017124
		private static void n_Updated_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IObserver @object = Java.Lang.Object.GetObject<IObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Updated(object2);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00018F48 File Offset: 0x00017148
		public unsafe void Updated(Java.Lang.Object p0)
		{
			if (this.id_updated_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_updated_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "updated", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_updated_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000209 RID: 521
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/IObserver", typeof(IObserverInvoker));

		// Token: 0x0400020A RID: 522
		private IntPtr class_ref;

		// Token: 0x0400020B RID: 523
		private static Delegate cb_updated_Ljava_lang_Object_;

		// Token: 0x0400020C RID: 524
		private IntPtr id_updated_Ljava_lang_Object_;
	}
}
