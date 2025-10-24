using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x02000070 RID: 112
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent", DoNotGenerateAcw = true)]
	public abstract class PersistedEvent : Java.Lang.Object
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000BE00 File Offset: 0x0000A000
		internal static IntPtr class_ref
		{
			get
			{
				return PersistedEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000BE24 File Offset: 0x0000A024
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PersistedEvent._members;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000BE2C File Offset: 0x0000A02C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PersistedEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0000BE50 File Offset: 0x0000A050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PersistedEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000026C4 File Offset: 0x000008C4
		protected PersistedEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000BE5C File Offset: 0x0000A05C
		[Register(".ctor", "()V", "")]
		public PersistedEvent() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PersistedEvent._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PersistedEvent._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000BECA File Offset: 0x0000A0CA
		private static Delegate GetGetEventHandler()
		{
			if (PersistedEvent.cb_getEvent == null)
			{
				PersistedEvent.cb_getEvent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PersistedEvent.n_GetEvent));
			}
			return PersistedEvent.cb_getEvent;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000BEEE File Offset: 0x0000A0EE
		private static IntPtr n_GetEvent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PersistedEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Event);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003D6 RID: 982
		public abstract EventInternal Event { [Register("getEvent", "()Lcom/google/android/datatransport/runtime/EventInternal;", "GetGetEventHandler")] get; }

		// Token: 0x060003D7 RID: 983 RVA: 0x0000BF02 File Offset: 0x0000A102
		private static Delegate GetGetIdHandler()
		{
			if (PersistedEvent.cb_getId == null)
			{
				PersistedEvent.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(PersistedEvent.n_GetId));
			}
			return PersistedEvent.cb_getId;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000BF26 File Offset: 0x0000A126
		private static long n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PersistedEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003D9 RID: 985
		public abstract long Id { [Register("getId", "()J", "GetGetIdHandler")] get; }

		// Token: 0x060003DA RID: 986 RVA: 0x0000BF35 File Offset: 0x0000A135
		private static Delegate GetGetTransportContextHandler()
		{
			if (PersistedEvent.cb_getTransportContext == null)
			{
				PersistedEvent.cb_getTransportContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PersistedEvent.n_GetTransportContext));
			}
			return PersistedEvent.cb_getTransportContext;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000BF59 File Offset: 0x0000A159
		private static IntPtr n_GetTransportContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PersistedEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TransportContext);
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003DC RID: 988
		public abstract TransportContext TransportContext { [Register("getTransportContext", "()Lcom/google/android/datatransport/runtime/TransportContext;", "GetGetTransportContextHandler")] get; }

		// Token: 0x060003DD RID: 989 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Register("create", "(JLcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;)Lcom/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent;", "")]
		public unsafe static PersistedEvent Create(long id, TransportContext transportContext, EventInternal @object)
		{
			PersistedEvent object2;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[2] = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				object2 = Java.Lang.Object.GetObject<PersistedEvent>(PersistedEvent._members.StaticMethods.InvokeObjectMethod("create.(JLcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;)Lcom/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transportContext);
				GC.KeepAlive(@object);
			}
			return object2;
		}

		// Token: 0x040000E2 RID: 226
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent", typeof(PersistedEvent));

		// Token: 0x040000E3 RID: 227
		private static Delegate cb_getEvent;

		// Token: 0x040000E4 RID: 228
		private static Delegate cb_getId;

		// Token: 0x040000E5 RID: 229
		private static Delegate cb_getTransportContext;
	}
}
