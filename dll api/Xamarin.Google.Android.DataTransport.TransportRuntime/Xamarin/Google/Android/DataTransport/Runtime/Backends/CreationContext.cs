using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x0200008C RID: 140
	[Register("com/google/android/datatransport/runtime/backends/CreationContext", DoNotGenerateAcw = true)]
	public abstract class CreationContext : Java.Lang.Object
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		internal static IntPtr class_ref
		{
			get
			{
				return CreationContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000F818 File Offset: 0x0000DA18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CreationContext._members;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0000F820 File Offset: 0x0000DA20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CreationContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000F844 File Offset: 0x0000DA44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CreationContext._members.ManagedPeerType;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000026C4 File Offset: 0x000008C4
		protected CreationContext(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000F850 File Offset: 0x0000DA50
		[Register(".ctor", "()V", "")]
		public CreationContext() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CreationContext._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CreationContext._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000F8BE File Offset: 0x0000DABE
		private static Delegate GetGetApplicationContextHandler()
		{
			if (CreationContext.cb_getApplicationContext == null)
			{
				CreationContext.cb_getApplicationContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CreationContext.n_GetApplicationContext));
			}
			return CreationContext.cb_getApplicationContext;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000F8E2 File Offset: 0x0000DAE2
		private static IntPtr n_GetApplicationContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CreationContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ApplicationContext);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000527 RID: 1319
		public abstract Context ApplicationContext { [Register("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")] get; }

		// Token: 0x06000528 RID: 1320 RVA: 0x0000F8F6 File Offset: 0x0000DAF6
		private static Delegate GetGetBackendNameHandler()
		{
			if (CreationContext.cb_getBackendName == null)
			{
				CreationContext.cb_getBackendName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CreationContext.n_GetBackendName));
			}
			return CreationContext.cb_getBackendName;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000F91A File Offset: 0x0000DB1A
		private static IntPtr n_GetBackendName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<CreationContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BackendName);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600052A RID: 1322
		public abstract string BackendName { [Register("getBackendName", "()Ljava/lang/String;", "GetGetBackendNameHandler")] get; }

		// Token: 0x0600052B RID: 1323 RVA: 0x0000F92E File Offset: 0x0000DB2E
		private static Delegate GetGetMonotonicClockHandler()
		{
			if (CreationContext.cb_getMonotonicClock == null)
			{
				CreationContext.cb_getMonotonicClock = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CreationContext.n_GetMonotonicClock));
			}
			return CreationContext.cb_getMonotonicClock;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0000F952 File Offset: 0x0000DB52
		private static IntPtr n_GetMonotonicClock(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CreationContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MonotonicClock);
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600052D RID: 1325
		public abstract IClock MonotonicClock { [Register("getMonotonicClock", "()Lcom/google/android/datatransport/runtime/time/Clock;", "GetGetMonotonicClockHandler")] get; }

		// Token: 0x0600052E RID: 1326 RVA: 0x0000F966 File Offset: 0x0000DB66
		private static Delegate GetGetWallClockHandler()
		{
			if (CreationContext.cb_getWallClock == null)
			{
				CreationContext.cb_getWallClock = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CreationContext.n_GetWallClock));
			}
			return CreationContext.cb_getWallClock;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000F98A File Offset: 0x0000DB8A
		private static IntPtr n_GetWallClock(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CreationContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WallClock);
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000530 RID: 1328
		public abstract IClock WallClock { [Register("getWallClock", "()Lcom/google/android/datatransport/runtime/time/Clock;", "GetGetWallClockHandler")] get; }

		// Token: 0x06000531 RID: 1329 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
		[Register("create", "(Landroid/content/Context;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/backends/CreationContext;", "")]
		public unsafe static CreationContext Create(Context applicationContext, IClock wallClock, IClock monotonicClock)
		{
			CreationContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContext == null) ? IntPtr.Zero : applicationContext.Handle);
				ptr[1] = new JniArgumentValue((wallClock == null) ? IntPtr.Zero : ((Java.Lang.Object)wallClock).Handle);
				ptr[2] = new JniArgumentValue((monotonicClock == null) ? IntPtr.Zero : ((Java.Lang.Object)monotonicClock).Handle);
				@object = Java.Lang.Object.GetObject<CreationContext>(CreationContext._members.StaticMethods.InvokeObjectMethod("create.(Landroid/content/Context;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/backends/CreationContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(applicationContext);
				GC.KeepAlive(wallClock);
				GC.KeepAlive(monotonicClock);
			}
			return @object;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000FA70 File Offset: 0x0000DC70
		[Register("create", "(Landroid/content/Context;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Ljava/lang/String;)Lcom/google/android/datatransport/runtime/backends/CreationContext;", "")]
		public unsafe static CreationContext Create(Context applicationContext, IClock wallClock, IClock monotonicClock, string backendName)
		{
			IntPtr intPtr = JNIEnv.NewString(backendName);
			CreationContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContext == null) ? IntPtr.Zero : applicationContext.Handle);
				ptr[1] = new JniArgumentValue((wallClock == null) ? IntPtr.Zero : ((Java.Lang.Object)wallClock).Handle);
				ptr[2] = new JniArgumentValue((monotonicClock == null) ? IntPtr.Zero : ((Java.Lang.Object)monotonicClock).Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CreationContext>(CreationContext._members.StaticMethods.InvokeObjectMethod("create.(Landroid/content/Context;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Ljava/lang/String;)Lcom/google/android/datatransport/runtime/backends/CreationContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(applicationContext);
				GC.KeepAlive(wallClock);
				GC.KeepAlive(monotonicClock);
			}
			return @object;
		}

		// Token: 0x04000117 RID: 279
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/CreationContext", typeof(CreationContext));

		// Token: 0x04000118 RID: 280
		private static Delegate cb_getApplicationContext;

		// Token: 0x04000119 RID: 281
		private static Delegate cb_getBackendName;

		// Token: 0x0400011A RID: 282
		private static Delegate cb_getMonotonicClock;

		// Token: 0x0400011B RID: 283
		private static Delegate cb_getWallClock;
	}
}
