using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Apis;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000040 RID: 64
	[Register("com/google/android/gms/common/api/internal/zabq", DoNotGenerateAcw = true)]
	public sealed class Zabq : Java.Lang.Object, GoogleApiClient.IConnectionCallbacks, IConnectionCallbacks, IJavaObject, IDisposable, IJavaPeerable, GoogleApiClient.IOnConnectionFailedListener, IOnConnectionFailedListener, IZau
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00008218 File Offset: 0x00006418
		internal static IntPtr class_ref
		{
			get
			{
				return Zabq._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000823C File Offset: 0x0000643C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Zabq._members;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00008244 File Offset: 0x00006444
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Zabq._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00008268 File Offset: 0x00006468
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Zabq._members.ManagedPeerType;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003280 File Offset: 0x00001480
		internal Zabq(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00008274 File Offset: 0x00006474
		[Register(".ctor", "(Lcom/google/android/gms/common/api/internal/GoogleApiManager;Lcom/google/android/gms/common/api/GoogleApi;)V", "")]
		public unsafe Zabq(GoogleApiManager p0, GoogleApi p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				base.SetHandle(Zabq._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/internal/GoogleApiManager;Lcom/google/android/gms/common/api/GoogleApi;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Zabq._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/internal/GoogleApiManager;Lcom/google/android/gms/common/api/GoogleApi;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000834C File Offset: 0x0000654C
		[Register("onConnected", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnConnected(Bundle p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("onConnected.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000083B0 File Offset: 0x000065B0
		[Register("onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V", "")]
		public unsafe void OnConnectionFailed(ConnectionResult p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("onConnectionFailed.(Lcom/google/android/gms/common/ConnectionResult;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00008414 File Offset: 0x00006614
		[Register("onConnectionSuspended", "(I)V", "")]
		public unsafe void OnConnectionSuspended(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("onConnectionSuspended.(I)V", this, ptr);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000844F File Offset: 0x0000664F
		[Register("zaA", "()Z", "")]
		public bool ZaA()
		{
			return Zabq._members.InstanceMethods.InvokeNonvirtualBooleanMethod("zaA.()Z", this, null);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00008468 File Offset: 0x00006668
		[Register("zaa", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/common/api/Api;Z)V", "")]
		public unsafe void Zaa(ConnectionResult p0, Api p1, bool p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(p2);
				Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zaa.(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/common/api/Api;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000850C File Offset: 0x0000670C
		[Register("zab", "()I", "")]
		public int Zab()
		{
			return Zabq._members.InstanceMethods.InvokeNonvirtualInt32Method("zab.()I", this, null);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00008528 File Offset: 0x00006728
		[Register("zad", "()Lcom/google/android/gms/common/ConnectionResult;", "")]
		public ConnectionResult Zad()
		{
			return Java.Lang.Object.GetObject<ConnectionResult>(Zabq._members.InstanceMethods.InvokeNonvirtualObjectMethod("zad.()Lcom/google/android/gms/common/ConnectionResult;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000855C File Offset: 0x0000675C
		[Register("zaf", "()Lcom/google/android/gms/common/api/Api$Client;", "")]
		public Api.IClient Zaf()
		{
			return Java.Lang.Object.GetObject<Api.IClient>(Zabq._members.InstanceMethods.InvokeNonvirtualObjectMethod("zaf.()Lcom/google/android/gms/common/api/Api$Client;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00008590 File Offset: 0x00006790
		[Register("zah", "()Ljava/util/Map;", "")]
		public IDictionary Zah()
		{
			return JavaDictionary.FromJniHandle(Zabq._members.InstanceMethods.InvokeNonvirtualObjectMethod("zah.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000085C2 File Offset: 0x000067C2
		[Register("zan", "()V", "")]
		public void Zan()
		{
			Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zan.()V", this, null);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000085DB File Offset: 0x000067DB
		[Register("zao", "()V", "")]
		public void Zao()
		{
			Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zao.()V", this, null);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000085F4 File Offset: 0x000067F4
		[Register("zap", "(Lcom/google/android/gms/common/api/internal/zai;)V", "")]
		public unsafe void Zap(Zai p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zap.(Lcom/google/android/gms/common/api/internal/zai;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00008658 File Offset: 0x00006858
		[Register("zar", "(Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/Exception;)V", "")]
		public unsafe void Zar(ConnectionResult p0, Java.Lang.Exception p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zar.(Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/Exception;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000086E4 File Offset: 0x000068E4
		[Register("zas", "(Lcom/google/android/gms/common/ConnectionResult;)V", "")]
		public unsafe void Zas(ConnectionResult p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zas.(Lcom/google/android/gms/common/ConnectionResult;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00008748 File Offset: 0x00006948
		[Register("zat", "(Lcom/google/android/gms/common/api/internal/zal;)V", "")]
		public unsafe void Zat(Zal p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zat.(Lcom/google/android/gms/common/api/internal/zal;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000087AC File Offset: 0x000069AC
		[Register("zau", "()V", "")]
		public void Zau()
		{
			Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zau.()V", this, null);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000087C5 File Offset: 0x000069C5
		[Register("zav", "()V", "")]
		public void Zav()
		{
			Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zav.()V", this, null);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000087DE File Offset: 0x000069DE
		[Register("zaw", "()V", "")]
		public void Zaw()
		{
			Zabq._members.InstanceMethods.InvokeNonvirtualVoidMethod("zaw.()V", this, null);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000087F7 File Offset: 0x000069F7
		[Register("zaz", "()Z", "")]
		public bool Zaz()
		{
			return Zabq._members.InstanceMethods.InvokeNonvirtualBooleanMethod("zaz.()Z", this, null);
		}

		// Token: 0x04000081 RID: 129
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zabq", typeof(Zabq));
	}
}
