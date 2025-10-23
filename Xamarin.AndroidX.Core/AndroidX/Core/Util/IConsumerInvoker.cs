using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Util
{
	// Token: 0x0200004B RID: 75
	[Register("androidx/core/util/Consumer", DoNotGenerateAcw = true)]
	internal class IConsumerInvoker : Java.Lang.Object, IConsumer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002080 File Offset: 0x00000280
		private static IntPtr java_class_ref
		{
			get
			{
				return IConsumerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConsumerInvoker._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000020AB File Offset: 0x000002AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000020B3 File Offset: 0x000002B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConsumerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000020BF File Offset: 0x000002BF
		public static IConsumer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConsumer>(handle, transfer);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000020C8 File Offset: 0x000002C8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConsumerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.util.Consumer'.");
			}
			return handle;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000020F3 File Offset: 0x000002F3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002124 File Offset: 0x00000324
		public IConsumerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConsumerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000215C File Offset: 0x0000035C
		private static Delegate GetAccept_Ljava_lang_Object_Handler()
		{
			if (IConsumerInvoker.cb_accept_Ljava_lang_Object_ == null)
			{
				IConsumerInvoker.cb_accept_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConsumerInvoker.n_Accept_Ljava_lang_Object_));
			}
			return IConsumerInvoker.cb_accept_Ljava_lang_Object_;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002180 File Offset: 0x00000380
		private static void n_Accept_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			IConsumer @object = Java.Lang.Object.GetObject<IConsumer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_t, JniHandleOwnership.DoNotTransfer);
			@object.Accept(object2);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000021A4 File Offset: 0x000003A4
		public unsafe void Accept(Java.Lang.Object t)
		{
			if (this.id_accept_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_accept_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "accept", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(t);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_accept_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/util/Consumer", typeof(IConsumerInvoker));

		// Token: 0x04000004 RID: 4
		private IntPtr class_ref;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_accept_Ljava_lang_Object_;

		// Token: 0x04000006 RID: 6
		private IntPtr id_accept_Ljava_lang_Object_;
	}
}
