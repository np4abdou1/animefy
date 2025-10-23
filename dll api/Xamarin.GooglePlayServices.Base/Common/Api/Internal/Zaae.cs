using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200003F RID: 63
	[Register("com/google/android/gms/common/api/internal/zaae", DoNotGenerateAcw = true)]
	public sealed class Zaae : Zap
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00007FFC File Offset: 0x000061FC
		internal new static IntPtr class_ref
		{
			get
			{
				return Zaae._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00008020 File Offset: 0x00006220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Zaae._members;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00008028 File Offset: 0x00006228
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Zaae._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000804C File Offset: 0x0000624C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Zaae._members.ManagedPeerType;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00008058 File Offset: 0x00006258
		internal Zaae(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00008062 File Offset: 0x00006262
		[Register("onResume", "()V", "")]
		public sealed override void OnResume()
		{
			Zaae._members.InstanceMethods.InvokeNonvirtualVoidMethod("onResume.()V", this, null);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000807B File Offset: 0x0000627B
		[Register("onStart", "()V", "")]
		public sealed override void OnStart()
		{
			Zaae._members.InstanceMethods.InvokeNonvirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00008094 File Offset: 0x00006294
		[Register("onStop", "()V", "")]
		public sealed override void OnStop()
		{
			Zaae._members.InstanceMethods.InvokeNonvirtualVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000080B0 File Offset: 0x000062B0
		[Register("zab", "(Lcom/google/android/gms/common/ConnectionResult;I)V", "")]
		protected unsafe sealed override void Zab(ConnectionResult p0, int p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				Zaae._members.InstanceMethods.InvokeNonvirtualVoidMethod("zab.(Lcom/google/android/gms/common/ConnectionResult;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00008128 File Offset: 0x00006328
		[Register("zac", "()V", "")]
		protected sealed override void Zac()
		{
			Zaae._members.InstanceMethods.InvokeNonvirtualVoidMethod("zac.()V", this, null);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00008144 File Offset: 0x00006344
		[Register("zad", "(Landroid/app/Activity;Lcom/google/android/gms/common/api/internal/GoogleApiManager;Lcom/google/android/gms/common/api/internal/ApiKey;)V", "")]
		public unsafe static void Zad(Activity p0, GoogleApiManager p1, ApiKey p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				Zaae._members.StaticMethods.InvokeVoidMethod("zad.(Landroid/app/Activity;Lcom/google/android/gms/common/api/internal/GoogleApiManager;Lcom/google/android/gms/common/api/internal/ApiKey;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x04000080 RID: 128
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zaae", typeof(Zaae));
	}
}
