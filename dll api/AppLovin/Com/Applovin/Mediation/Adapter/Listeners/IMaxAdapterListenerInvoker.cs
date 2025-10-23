using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000118 RID: 280
	[Register("com/applovin/mediation/adapter/listeners/MaxAdapterListener", DoNotGenerateAcw = true)]
	internal class IMaxAdapterListenerInvoker : Java.Lang.Object, IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0002091C File Offset: 0x0001EB1C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdapterListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00020940 File Offset: 0x0001EB40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdapterListenerInvoker._members;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00020947 File Offset: 0x0001EB47
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0002094F File Offset: 0x0001EB4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdapterListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0002095B File Offset: 0x0001EB5B
		public static IMaxAdapterListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterListener>(handle, transfer);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00020964 File Offset: 0x0001EB64
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdapterListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.listeners.MaxAdapterListener'.");
			}
			return handle;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0002098F File Offset: 0x0001EB8F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000209C0 File Offset: 0x0001EBC0
		public IMaxAdapterListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdapterListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000419 RID: 1049
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/listeners/MaxAdapterListener", typeof(IMaxAdapterListenerInvoker));

		// Token: 0x0400041A RID: 1050
		private IntPtr class_ref;
	}
}
