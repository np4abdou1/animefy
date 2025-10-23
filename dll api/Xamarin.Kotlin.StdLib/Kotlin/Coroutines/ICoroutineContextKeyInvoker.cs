using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines
{
	// Token: 0x0200025E RID: 606
	[Register("kotlin/coroutines/CoroutineContext$Key", DoNotGenerateAcw = true)]
	internal class ICoroutineContextKeyInvoker : Java.Lang.Object, ICoroutineContextKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x0005D21C File Offset: 0x0005B41C
		private static IntPtr java_class_ref
		{
			get
			{
				return ICoroutineContextKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x0005D240 File Offset: 0x0005B440
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ICoroutineContextKeyInvoker._members;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x0005D247 File Offset: 0x0005B447
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0005D24F File Offset: 0x0005B44F
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ICoroutineContextKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0005D25B File Offset: 0x0005B45B
		[NullableContext(2)]
		public static ICoroutineContextKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICoroutineContextKey>(handle, transfer);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0005D264 File Offset: 0x0005B464
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICoroutineContextKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.coroutines.CoroutineContext.Key'.");
			}
			return handle;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0005D28F File Offset: 0x0005B48F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0005D2C0 File Offset: 0x0005B4C0
		public ICoroutineContextKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICoroutineContextKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000891 RID: 2193
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/CoroutineContext$Key", typeof(ICoroutineContextKeyInvoker));

		// Token: 0x04000892 RID: 2194
		private IntPtr class_ref;
	}
}
