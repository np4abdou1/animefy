using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Gms.Common.Apis;
using Android.Gms.Common.Apis.Internal;
using Android.Gms.Tasks;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000026 RID: 38
	[Register("com/google/android/gms/common/api/internal/GoogleApiManager", DoNotGenerateAcw = true)]
	public class GoogleApiManager : Java.Lang.Object, Handler.ICallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00005094 File Offset: 0x00003294
		internal static IntPtr class_ref
		{
			get
			{
				return GoogleApiManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000050B8 File Offset: 0x000032B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleApiManager._members;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000050C0 File Offset: 0x000032C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GoogleApiManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000050E4 File Offset: 0x000032E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleApiManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003280 File Offset: 0x00001480
		protected GoogleApiManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000050F0 File Offset: 0x000032F0
		[Register("handleMessage", "(Landroid/os/Message;)Z", "")]
		public unsafe bool HandleMessage(Message p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = GoogleApiManager._members.InstanceMethods.InvokeNonvirtualBooleanMethod("handleMessage.(Landroid/os/Message;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005158 File Offset: 0x00003358
		[Register("reportSignOut", "()V", "")]
		public static void ReportSignOut()
		{
			GoogleApiManager._members.StaticMethods.InvokeVoidMethod("reportSignOut.()V", null);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005170 File Offset: 0x00003370
		[Register("zaA", "(Lcom/google/android/gms/common/api/internal/zaae;)V", "")]
		public unsafe void ZaA(Zaae p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				GoogleApiManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("zaA.(Lcom/google/android/gms/common/api/internal/zaae;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000051D4 File Offset: 0x000033D4
		[Register("zaa", "()I", "")]
		public int Zaa()
		{
			return GoogleApiManager._members.InstanceMethods.InvokeNonvirtualInt32Method("zaa.()I", this, null);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000051F0 File Offset: 0x000033F0
		[Register("zaj", "()Lcom/google/android/gms/common/api/internal/GoogleApiManager;", "")]
		public static GoogleApiManager Zaj()
		{
			return Java.Lang.Object.GetObject<GoogleApiManager>(GoogleApiManager._members.StaticMethods.InvokeObjectMethod("zaj.()Lcom/google/android/gms/common/api/internal/GoogleApiManager;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005224 File Offset: 0x00003424
		[Register("zak", "(Landroid/content/Context;)Lcom/google/android/gms/common/api/internal/GoogleApiManager;", "")]
		public unsafe static GoogleApiManager Zak(Context p0)
		{
			GoogleApiManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<GoogleApiManager>(GoogleApiManager._members.StaticMethods.InvokeObjectMethod("zak.(Landroid/content/Context;)Lcom/google/android/gms/common/api/internal/GoogleApiManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005298 File Offset: 0x00003498
		[Register("zam", "(Ljava/lang/Iterable;)Lcom/google/android/gms/tasks/Task;", "")]
		public unsafe Task Zam(IIterable p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApiManager._members.InstanceMethods.InvokeNonvirtualObjectMethod("zam.(Ljava/lang/Iterable;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005310 File Offset: 0x00003510
		[Register("zan", "(Lcom/google/android/gms/common/api/GoogleApi;)Lcom/google/android/gms/tasks/Task;", "")]
		public unsafe Task Zan(GoogleApi p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApiManager._members.InstanceMethods.InvokeNonvirtualObjectMethod("zan.(Lcom/google/android/gms/common/api/GoogleApi;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005384 File Offset: 0x00003584
		[Register("zao", "(Lcom/google/android/gms/common/api/GoogleApi;Lcom/google/android/gms/common/api/internal/RegisterListenerMethod;Lcom/google/android/gms/common/api/internal/UnregisterListenerMethod;Ljava/lang/Runnable;)Lcom/google/android/gms/tasks/Task;", "")]
		public unsafe Task Zao(GoogleApi p0, RegisterListenerMethod p1, UnregisterListenerMethod p2, IRunnable p3)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApiManager._members.InstanceMethods.InvokeNonvirtualObjectMethod("zao.(Lcom/google/android/gms/common/api/GoogleApi;Lcom/google/android/gms/common/api/internal/RegisterListenerMethod;Lcom/google/android/gms/common/api/internal/UnregisterListenerMethod;Ljava/lang/Runnable;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
			}
			return @object;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005480 File Offset: 0x00003680
		[Register("zap", "(Lcom/google/android/gms/common/api/GoogleApi;Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;I)Lcom/google/android/gms/tasks/Task;", "")]
		public unsafe Task Zap(GoogleApi p0, ListenerHolder.ListenerKey p1, int p2)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(p2);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApiManager._members.InstanceMethods.InvokeNonvirtualObjectMethod("zap.(Lcom/google/android/gms/common/api/GoogleApi;Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;I)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005534 File Offset: 0x00003734
		[Register("zau", "(Lcom/google/android/gms/common/api/GoogleApi;ILcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)V", "")]
		public unsafe void Zau(GoogleApi p0, int p1, BaseImplementation.ApiMethodImpl p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				GoogleApiManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("zau.(Lcom/google/android/gms/common/api/GoogleApi;ILcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000055D8 File Offset: 0x000037D8
		[Register("zav", "(Lcom/google/android/gms/common/api/GoogleApi;ILcom/google/android/gms/common/api/internal/TaskApiCall;Lcom/google/android/gms/tasks/TaskCompletionSource;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", "")]
		public unsafe void Zav(GoogleApi p0, int p1, TaskApiCall p2, TaskCompletionSource p3, IStatusExceptionMapper p4)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				ptr[4] = new JniArgumentValue((p4 == null) ? IntPtr.Zero : ((Java.Lang.Object)p4).Handle);
				GoogleApiManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("zav.(Lcom/google/android/gms/common/api/GoogleApi;ILcom/google/android/gms/common/api/internal/TaskApiCall;Lcom/google/android/gms/tasks/TaskCompletionSource;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
				GC.KeepAlive(p4);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000056DC File Offset: 0x000038DC
		[Register("zax", "(Lcom/google/android/gms/common/ConnectionResult;I)V", "")]
		public unsafe void Zax(ConnectionResult p0, int p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				GoogleApiManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("zax.(Lcom/google/android/gms/common/ConnectionResult;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005754 File Offset: 0x00003954
		[Register("zay", "()V", "")]
		public void Zay()
		{
			GoogleApiManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("zay.()V", this, null);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005770 File Offset: 0x00003970
		[Register("zaz", "(Lcom/google/android/gms/common/api/GoogleApi;)V", "")]
		public unsafe void Zaz(GoogleApi p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				GoogleApiManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("zaz.(Lcom/google/android/gms/common/api/GoogleApi;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0400003D RID: 61
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/GoogleApiManager", typeof(GoogleApiManager));
	}
}
