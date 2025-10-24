using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000181 RID: 385
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/Poolable", DoNotGenerateAcw = true)]
	internal class IPoolableInvoker : Java.Lang.Object, IPoolable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x0003D39C File Offset: 0x0003B59C
		private static IntPtr java_class_ref
		{
			get
			{
				return IPoolableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0003D3C0 File Offset: 0x0003B5C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPoolableInvoker._members;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x0003D3C7 File Offset: 0x0003B5C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x0003D3CF File Offset: 0x0003B5CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPoolableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0003D3DB File Offset: 0x0003B5DB
		public static IPoolable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPoolable>(handle, transfer);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0003D3E4 File Offset: 0x0003B5E4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPoolableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.bitmap_recycle.Poolable'.");
			}
			return handle;
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0003D40F File Offset: 0x0003B60F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0003D440 File Offset: 0x0003B640
		public IPoolableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPoolableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0003D478 File Offset: 0x0003B678
		private static Delegate GetOfferHandler()
		{
			if (IPoolableInvoker.cb_offer == null)
			{
				IPoolableInvoker.cb_offer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IPoolableInvoker.n_Offer));
			}
			return IPoolableInvoker.cb_offer;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0003D49C File Offset: 0x0003B69C
		private static void n_Offer(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IPoolable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Offer();
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0003D4AB File Offset: 0x0003B6AB
		public void Offer()
		{
			if (this.id_offer == IntPtr.Zero)
			{
				this.id_offer = JNIEnv.GetMethodID(this.class_ref, "offer", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_offer);
		}

		// Token: 0x0400048D RID: 1165
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/Poolable", typeof(IPoolableInvoker));

		// Token: 0x0400048E RID: 1166
		private IntPtr class_ref;

		// Token: 0x0400048F RID: 1167
		private static Delegate cb_offer;

		// Token: 0x04000490 RID: 1168
		private IntPtr id_offer;
	}
}
