using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x0200000B RID: 11
	[Register("com/google/android/datatransport/Event", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class Event : Java.Lang.Object
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002264 File Offset: 0x00000464
		internal static IntPtr class_ref
		{
			get
			{
				return Event._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002288 File Offset: 0x00000488
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Event._members;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002290 File Offset: 0x00000490
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Event._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000022B4 File Offset: 0x000004B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Event._members.ManagedPeerType;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020B4 File Offset: 0x000002B4
		protected Event(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000022C0 File Offset: 0x000004C0
		[Register(".ctor", "()V", "")]
		public Event() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Event._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Event._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000232E File Offset: 0x0000052E
		private static Delegate GetGetCodeHandler()
		{
			if (Event.cb_getCode == null)
			{
				Event.cb_getCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Event.n_GetCode));
			}
			return Event.cb_getCode;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002352 File Offset: 0x00000552
		private static IntPtr n_GetCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Event>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Code);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000031 RID: 49
		public abstract Integer Code { [Register("getCode", "()Ljava/lang/Integer;", "GetGetCodeHandler")] get; }

		// Token: 0x06000032 RID: 50 RVA: 0x00002366 File Offset: 0x00000566
		private static Delegate GetGetPriorityHandler()
		{
			if (Event.cb_getPriority == null)
			{
				Event.cb_getPriority = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Event.n_GetPriority));
			}
			return Event.cb_getPriority;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000238A File Offset: 0x0000058A
		private static IntPtr n_GetPriority(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Event>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Priority);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000034 RID: 52
		public abstract Priority Priority { [Register("getPriority", "()Lcom/google/android/datatransport/Priority;", "GetGetPriorityHandler")] get; }

		// Token: 0x06000035 RID: 53 RVA: 0x0000239E File Offset: 0x0000059E
		private static Delegate GetGetPayloadHandler()
		{
			if (Event.cb_getPayload == null)
			{
				Event.cb_getPayload = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Event.n_GetPayload));
			}
			return Event.cb_getPayload;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000023C2 File Offset: 0x000005C2
		private static IntPtr n_GetPayload(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Event>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RawPayload);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000037 RID: 55
		protected abstract Java.Lang.Object RawPayload { [Register("getPayload", "()Ljava/lang/Object;", "GetGetPayloadHandler")] get; }

		// Token: 0x06000038 RID: 56 RVA: 0x000023D8 File Offset: 0x000005D8
		[Register("ofData", "(ILjava/lang/Object;)Lcom/google/android/datatransport/Event;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Event OfData(int code, Java.Lang.Object payload)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(payload);
			Event @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(code);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Event>(Event._members.StaticMethods.InvokeObjectMethod("ofData.(ILjava/lang/Object;)Lcom/google/android/datatransport/Event;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(payload);
			}
			return @object;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000245C File Offset: 0x0000065C
		[Register("ofData", "(Ljava/lang/Object;)Lcom/google/android/datatransport/Event;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Event OfData(Java.Lang.Object payload)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(payload);
			Event @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Event>(Event._members.StaticMethods.InvokeObjectMethod("ofData.(Ljava/lang/Object;)Lcom/google/android/datatransport/Event;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(payload);
			}
			return @object;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000024CC File Offset: 0x000006CC
		[Register("ofTelemetry", "(ILjava/lang/Object;)Lcom/google/android/datatransport/Event;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Event OfTelemetry(int code, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Event @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(code);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Event>(Event._members.StaticMethods.InvokeObjectMethod("ofTelemetry.(ILjava/lang/Object;)Lcom/google/android/datatransport/Event;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002550 File Offset: 0x00000750
		[Register("ofTelemetry", "(Ljava/lang/Object;)Lcom/google/android/datatransport/Event;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Event OfTelemetry(Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Event @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Event>(Event._members.StaticMethods.InvokeObjectMethod("ofTelemetry.(Ljava/lang/Object;)Lcom/google/android/datatransport/Event;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000025C0 File Offset: 0x000007C0
		[Register("ofUrgent", "(ILjava/lang/Object;)Lcom/google/android/datatransport/Event;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Event OfUrgent(int code, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Event @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(code);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Event>(Event._members.StaticMethods.InvokeObjectMethod("ofUrgent.(ILjava/lang/Object;)Lcom/google/android/datatransport/Event;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002644 File Offset: 0x00000844
		[Register("ofUrgent", "(Ljava/lang/Object;)Lcom/google/android/datatransport/Event;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Event OfUrgent(Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Event @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Event>(Event._members.StaticMethods.InvokeObjectMethod("ofUrgent.(Ljava/lang/Object;)Lcom/google/android/datatransport/Event;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/Event", typeof(Event));

		// Token: 0x0400000A RID: 10
		private static Delegate cb_getCode;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_getPriority;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_getPayload;
	}
}
