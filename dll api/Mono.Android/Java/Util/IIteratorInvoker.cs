using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x0200030D RID: 781
	[Register("java/util/Iterator", DoNotGenerateAcw = true)]
	internal class IIteratorInvoker : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000564B8 File Offset: 0x000546B8
		private static IntPtr java_class_ref
		{
			get
			{
				return IIteratorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x000564DC File Offset: 0x000546DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIteratorInvoker._members;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000564E3 File Offset: 0x000546E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000564EB File Offset: 0x000546EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x000564F7 File Offset: 0x000546F7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIteratorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Iterator'.");
			}
			return handle;
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00056522 File Offset: 0x00054722
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00056554 File Offset: 0x00054754
		public IIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIteratorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0005658C File Offset: 0x0005478C
		private static Delegate GetHasNextHandler()
		{
			if (IIteratorInvoker.cb_hasNext == null)
			{
				IIteratorInvoker.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IIteratorInvoker.n_HasNext));
			}
			return IIteratorInvoker.cb_hasNext;
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000565B0 File Offset: 0x000547B0
		private static bool n_HasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x000565BF File Offset: 0x000547BF
		public bool HasNext
		{
			get
			{
				if (this.id_hasNext == IntPtr.Zero)
				{
					this.id_hasNext = JNIEnv.GetMethodID(this.class_ref, "hasNext", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasNext);
			}
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x000565FF File Offset: 0x000547FF
		private static Delegate GetNextHandler()
		{
			if (IIteratorInvoker.cb_next == null)
			{
				IIteratorInvoker.cb_next = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIteratorInvoker.n_Next));
			}
			return IIteratorInvoker.cb_next;
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00056623 File Offset: 0x00054823
		private static IntPtr n_Next(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Next());
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x00056638 File Offset: 0x00054838
		public Java.Lang.Object Next()
		{
			if (this.id_next == IntPtr.Zero)
			{
				this.id_next = JNIEnv.GetMethodID(this.class_ref, "next", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_next), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00056689 File Offset: 0x00054889
		private static Delegate GetRemoveHandler()
		{
			if (IIteratorInvoker.cb_remove == null)
			{
				IIteratorInvoker.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IIteratorInvoker.n_Remove));
			}
			return IIteratorInvoker.cb_remove;
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000566AD File Offset: 0x000548AD
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000566BC File Offset: 0x000548BC
		public void Remove()
		{
			if (this.id_remove == IntPtr.Zero)
			{
				this.id_remove = JNIEnv.GetMethodID(this.class_ref, "remove", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_remove);
		}

		// Token: 0x04000CEF RID: 3311
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Iterator", typeof(IIteratorInvoker));

		// Token: 0x04000CF0 RID: 3312
		private IntPtr class_ref;

		// Token: 0x04000CF1 RID: 3313
		private static Delegate cb_hasNext;

		// Token: 0x04000CF2 RID: 3314
		private IntPtr id_hasNext;

		// Token: 0x04000CF3 RID: 3315
		private static Delegate cb_next;

		// Token: 0x04000CF4 RID: 3316
		private IntPtr id_next;

		// Token: 0x04000CF5 RID: 3317
		private static Delegate cb_remove;

		// Token: 0x04000CF6 RID: 3318
		private IntPtr id_remove;
	}
}
