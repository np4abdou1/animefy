using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200001C RID: 28
	[Register("com/google/android/datatransport/runtime/EventInternal", DoNotGenerateAcw = true)]
	public abstract class EventInternal : Java.Lang.Object
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002924 File Offset: 0x00000B24
		internal static IntPtr class_ref
		{
			get
			{
				return EventInternal._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002948 File Offset: 0x00000B48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventInternal._members;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002950 File Offset: 0x00000B50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventInternal._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002974 File Offset: 0x00000B74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventInternal._members.ManagedPeerType;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000026C4 File Offset: 0x000008C4
		protected EventInternal(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002980 File Offset: 0x00000B80
		[Register(".ctor", "()V", "")]
		public EventInternal() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(EventInternal._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			EventInternal._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000029EE File Offset: 0x00000BEE
		private static Delegate GetGetAutoMetadataHandler()
		{
			if (EventInternal.cb_getAutoMetadata == null)
			{
				EventInternal.cb_getAutoMetadata = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventInternal.n_GetAutoMetadata));
			}
			return EventInternal.cb_getAutoMetadata;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002A12 File Offset: 0x00000C12
		private static IntPtr n_GetAutoMetadata(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<EventInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AutoMetadata);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000081 RID: 129
		protected abstract IDictionary<string, string> AutoMetadata { [Register("getAutoMetadata", "()Ljava/util/Map;", "GetGetAutoMetadataHandler")] get; }

		// Token: 0x06000082 RID: 130 RVA: 0x00002A26 File Offset: 0x00000C26
		private static Delegate GetGetCodeHandler()
		{
			if (EventInternal.cb_getCode == null)
			{
				EventInternal.cb_getCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventInternal.n_GetCode));
			}
			return EventInternal.cb_getCode;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002A4A File Offset: 0x00000C4A
		private static IntPtr n_GetCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<EventInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Code);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000084 RID: 132
		public abstract Integer Code { [Register("getCode", "()Ljava/lang/Integer;", "GetGetCodeHandler")] get; }

		// Token: 0x06000085 RID: 133 RVA: 0x00002A5E File Offset: 0x00000C5E
		private static Delegate GetGetEncodedPayloadHandler()
		{
			if (EventInternal.cb_getEncodedPayload == null)
			{
				EventInternal.cb_getEncodedPayload = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventInternal.n_GetEncodedPayload));
			}
			return EventInternal.cb_getEncodedPayload;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002A82 File Offset: 0x00000C82
		private static IntPtr n_GetEncodedPayload(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<EventInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EncodedPayload);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000087 RID: 135
		public abstract EncodedPayload EncodedPayload { [Register("getEncodedPayload", "()Lcom/google/android/datatransport/runtime/EncodedPayload;", "GetGetEncodedPayloadHandler")] get; }

		// Token: 0x06000088 RID: 136 RVA: 0x00002A96 File Offset: 0x00000C96
		private static Delegate GetGetEventMillisHandler()
		{
			if (EventInternal.cb_getEventMillis == null)
			{
				EventInternal.cb_getEventMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(EventInternal.n_GetEventMillis));
			}
			return EventInternal.cb_getEventMillis;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002ABA File Offset: 0x00000CBA
		private static long n_GetEventMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<EventInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EventMillis;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600008A RID: 138
		public abstract long EventMillis { [Register("getEventMillis", "()J", "GetGetEventMillisHandler")] get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002ACC File Offset: 0x00000CCC
		public IDictionary<string, string> Metadata
		{
			[Register("getMetadata", "()Ljava/util/Map;", "")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(EventInternal._members.InstanceMethods.InvokeNonvirtualObjectMethod("getMetadata.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002AFE File Offset: 0x00000CFE
		private static Delegate GetGetTransportNameHandler()
		{
			if (EventInternal.cb_getTransportName == null)
			{
				EventInternal.cb_getTransportName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventInternal.n_GetTransportName));
			}
			return EventInternal.cb_getTransportName;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002B22 File Offset: 0x00000D22
		private static IntPtr n_GetTransportName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<EventInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TransportName);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600008E RID: 142
		public abstract string TransportName { [Register("getTransportName", "()Ljava/lang/String;", "GetGetTransportNameHandler")] get; }

		// Token: 0x0600008F RID: 143 RVA: 0x00002B36 File Offset: 0x00000D36
		private static Delegate GetGetUptimeMillisHandler()
		{
			if (EventInternal.cb_getUptimeMillis == null)
			{
				EventInternal.cb_getUptimeMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(EventInternal.n_GetUptimeMillis));
			}
			return EventInternal.cb_getUptimeMillis;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002B5A File Offset: 0x00000D5A
		private static long n_GetUptimeMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<EventInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UptimeMillis;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000091 RID: 145
		public abstract long UptimeMillis { [Register("getUptimeMillis", "()J", "GetGetUptimeMillisHandler")] get; }

		// Token: 0x06000092 RID: 146 RVA: 0x00002B6C File Offset: 0x00000D6C
		[Register("builder", "()Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "")]
		public static EventInternal.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/runtime/EventInternal$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002BA0 File Offset: 0x00000DA0
		[Register("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Get(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(EventInternal._members.InstanceMethods.InvokeNonvirtualObjectMethod("get.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Register("getInteger", "(Ljava/lang/String;)I", "")]
		public unsafe int GetInteger(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = EventInternal._members.InstanceMethods.InvokeNonvirtualInt32Method("getInteger.(Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Register("getLong", "(Ljava/lang/String;)J", "")]
		public unsafe long GetLong(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = EventInternal._members.InstanceMethods.InvokeNonvirtualInt64Method("getLong.(Ljava/lang/String;)J", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Register("getOrDefault", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetOrDefault(string key, string defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(defaultValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(EventInternal._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOrDefault.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Obsolete]
		private static Delegate GetGetPayloadHandler()
		{
			if (EventInternal.cb_getPayload == null)
			{
				EventInternal.cb_getPayload = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventInternal.n_GetPayload));
			}
			return EventInternal.cb_getPayload;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002D80 File Offset: 0x00000F80
		[Obsolete]
		private static IntPtr n_GetPayload(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<EventInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetPayload());
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002D94 File Offset: 0x00000F94
		[Obsolete("deprecated")]
		[Register("getPayload", "()[B", "GetGetPayloadHandler")]
		public virtual byte[] GetPayload()
		{
			return (byte[])JNIEnv.GetArray(EventInternal._members.InstanceMethods.InvokeVirtualObjectMethod("getPayload.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002DD5 File Offset: 0x00000FD5
		private static Delegate GetToBuilderHandler()
		{
			if (EventInternal.cb_toBuilder == null)
			{
				EventInternal.cb_toBuilder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventInternal.n_ToBuilder));
			}
			return EventInternal.cb_toBuilder;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002DF9 File Offset: 0x00000FF9
		private static IntPtr n_ToBuilder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<EventInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBuilder());
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002E10 File Offset: 0x00001010
		[Register("toBuilder", "()Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetToBuilderHandler")]
		public virtual EventInternal.Builder ToBuilder()
		{
			return Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal._members.InstanceMethods.InvokeVirtualObjectMethod("toBuilder.()Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000013 RID: 19
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/EventInternal", typeof(EventInternal));

		// Token: 0x04000014 RID: 20
		private static Delegate cb_getAutoMetadata;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_getCode;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_getEncodedPayload;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_getEventMillis;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_getTransportName;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_getUptimeMillis;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_getPayload;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_toBuilder;

		// Token: 0x0200001D RID: 29
		[Register("com/google/android/datatransport/runtime/EventInternal$Builder", DoNotGenerateAcw = true)]
		public abstract class Builder : Java.Lang.Object
		{
			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00002E60 File Offset: 0x00001060
			internal static IntPtr class_ref
			{
				get
				{
					return EventInternal.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600009F RID: 159 RVA: 0x00002E84 File Offset: 0x00001084
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return EventInternal.Builder._members;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002E8C File Offset: 0x0000108C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return EventInternal.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002EB0 File Offset: 0x000010B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return EventInternal.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x000026C4 File Offset: 0x000008C4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00002EBC File Offset: 0x000010BC
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(EventInternal.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				EventInternal.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00002F2A File Offset: 0x0000112A
			private static Delegate GetGetAutoMetadataHandler()
			{
				if (EventInternal.Builder.cb_getAutoMetadata == null)
				{
					EventInternal.Builder.cb_getAutoMetadata = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventInternal.Builder.n_GetAutoMetadata));
				}
				return EventInternal.Builder.cb_getAutoMetadata;
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00002F4E File Offset: 0x0000114E
			private static IntPtr n_GetAutoMetadata(IntPtr jnienv, IntPtr native__this)
			{
				return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<EventInternal.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AutoMetadata);
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000A6 RID: 166
			protected abstract IDictionary<string, string> AutoMetadata { [Register("getAutoMetadata", "()Ljava/util/Map;", "GetGetAutoMetadataHandler")] get; }

			// Token: 0x060000A7 RID: 167 RVA: 0x00002F64 File Offset: 0x00001164
			[Register("addMetadata", "(Ljava/lang/String;I)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "")]
			public unsafe EventInternal.Builder AddMetadata(string key, int value)
			{
				IntPtr intPtr = JNIEnv.NewString(key);
				EventInternal.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(value);
					@object = Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("addMetadata.(Ljava/lang/String;I)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00002FE4 File Offset: 0x000011E4
			[Register("addMetadata", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "")]
			public unsafe EventInternal.Builder AddMetadata(string key, string value)
			{
				IntPtr intPtr = JNIEnv.NewString(key);
				IntPtr intPtr2 = JNIEnv.NewString(value);
				EventInternal.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(intPtr2);
					@object = Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("addMetadata.(Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				return @object;
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00003074 File Offset: 0x00001274
			[Register("addMetadata", "(Ljava/lang/String;J)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "")]
			public unsafe EventInternal.Builder AddMetadata(string key, long value)
			{
				IntPtr intPtr = JNIEnv.NewString(key);
				EventInternal.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(value);
					@object = Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("addMetadata.(Ljava/lang/String;J)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000AA RID: 170 RVA: 0x000030F4 File Offset: 0x000012F4
			private static Delegate GetBuildHandler()
			{
				if (EventInternal.Builder.cb_build == null)
				{
					EventInternal.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventInternal.Builder.n_Build));
				}
				return EventInternal.Builder.cb_build;
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00003118 File Offset: 0x00001318
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<EventInternal.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060000AC RID: 172
			[Register("build", "()Lcom/google/android/datatransport/runtime/EventInternal;", "GetBuildHandler")]
			public abstract EventInternal Build();

			// Token: 0x060000AD RID: 173 RVA: 0x0000312C File Offset: 0x0000132C
			private static Delegate GetSetAutoMetadata_Ljava_util_Map_Handler()
			{
				if (EventInternal.Builder.cb_setAutoMetadata_Ljava_util_Map_ == null)
				{
					EventInternal.Builder.cb_setAutoMetadata_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(EventInternal.Builder.n_SetAutoMetadata_Ljava_util_Map_));
				}
				return EventInternal.Builder.cb_setAutoMetadata_Ljava_util_Map_;
			}

			// Token: 0x060000AE RID: 174 RVA: 0x00003150 File Offset: 0x00001350
			private static IntPtr n_SetAutoMetadata_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				EventInternal.Builder @object = Java.Lang.Object.GetObject<EventInternal.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDictionary<string, string> autoMetadata = JavaDictionary<string, string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetAutoMetadata(autoMetadata));
			}

			// Token: 0x060000AF RID: 175
			[Register("setAutoMetadata", "(Ljava/util/Map;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetAutoMetadata_Ljava_util_Map_Handler")]
			protected abstract EventInternal.Builder SetAutoMetadata(IDictionary<string, string> p0);

			// Token: 0x060000B0 RID: 176 RVA: 0x00003178 File Offset: 0x00001378
			private static Delegate GetSetCode_Ljava_lang_Integer_Handler()
			{
				if (EventInternal.Builder.cb_setCode_Ljava_lang_Integer_ == null)
				{
					EventInternal.Builder.cb_setCode_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(EventInternal.Builder.n_SetCode_Ljava_lang_Integer_));
				}
				return EventInternal.Builder.cb_setCode_Ljava_lang_Integer_;
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x0000319C File Offset: 0x0000139C
			private static IntPtr n_SetCode_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				EventInternal.Builder @object = Java.Lang.Object.GetObject<EventInternal.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Integer object2 = Java.Lang.Object.GetObject<Integer>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCode(object2));
			}

			// Token: 0x060000B2 RID: 178
			[Register("setCode", "(Ljava/lang/Integer;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetCode_Ljava_lang_Integer_Handler")]
			public abstract EventInternal.Builder SetCode(Integer p0);

			// Token: 0x060000B3 RID: 179 RVA: 0x000031C4 File Offset: 0x000013C4
			private static Delegate GetSetEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_Handler()
			{
				if (EventInternal.Builder.cb_setEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_ == null)
				{
					EventInternal.Builder.cb_setEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(EventInternal.Builder.n_SetEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_));
				}
				return EventInternal.Builder.cb_setEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_;
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000031E8 File Offset: 0x000013E8
			private static IntPtr n_SetEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				EventInternal.Builder @object = Java.Lang.Object.GetObject<EventInternal.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				EncodedPayload object2 = Java.Lang.Object.GetObject<EncodedPayload>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetEncodedPayload(object2));
			}

			// Token: 0x060000B5 RID: 181
			[Register("setEncodedPayload", "(Lcom/google/android/datatransport/runtime/EncodedPayload;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_Handler")]
			public abstract EventInternal.Builder SetEncodedPayload(EncodedPayload p0);

			// Token: 0x060000B6 RID: 182 RVA: 0x00003210 File Offset: 0x00001410
			private static Delegate GetSetEventMillis_JHandler()
			{
				if (EventInternal.Builder.cb_setEventMillis_J == null)
				{
					EventInternal.Builder.cb_setEventMillis_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(EventInternal.Builder.n_SetEventMillis_J));
				}
				return EventInternal.Builder.cb_setEventMillis_J;
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00003234 File Offset: 0x00001434
			private static IntPtr n_SetEventMillis_J(IntPtr jnienv, IntPtr native__this, long p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<EventInternal.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEventMillis(p0));
			}

			// Token: 0x060000B8 RID: 184
			[Register("setEventMillis", "(J)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetEventMillis_JHandler")]
			public abstract EventInternal.Builder SetEventMillis(long p0);

			// Token: 0x060000B9 RID: 185 RVA: 0x00003249 File Offset: 0x00001449
			private static Delegate GetSetTransportName_Ljava_lang_String_Handler()
			{
				if (EventInternal.Builder.cb_setTransportName_Ljava_lang_String_ == null)
				{
					EventInternal.Builder.cb_setTransportName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(EventInternal.Builder.n_SetTransportName_Ljava_lang_String_));
				}
				return EventInternal.Builder.cb_setTransportName_Ljava_lang_String_;
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00003270 File Offset: 0x00001470
			private static IntPtr n_SetTransportName_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				EventInternal.Builder @object = Java.Lang.Object.GetObject<EventInternal.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTransportName(@string));
			}

			// Token: 0x060000BB RID: 187
			[Register("setTransportName", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetTransportName_Ljava_lang_String_Handler")]
			public abstract EventInternal.Builder SetTransportName(string p0);

			// Token: 0x060000BC RID: 188 RVA: 0x00003298 File Offset: 0x00001498
			private static Delegate GetSetUptimeMillis_JHandler()
			{
				if (EventInternal.Builder.cb_setUptimeMillis_J == null)
				{
					EventInternal.Builder.cb_setUptimeMillis_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(EventInternal.Builder.n_SetUptimeMillis_J));
				}
				return EventInternal.Builder.cb_setUptimeMillis_J;
			}

			// Token: 0x060000BD RID: 189 RVA: 0x000032BC File Offset: 0x000014BC
			private static IntPtr n_SetUptimeMillis_J(IntPtr jnienv, IntPtr native__this, long p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<EventInternal.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUptimeMillis(p0));
			}

			// Token: 0x060000BE RID: 190
			[Register("setUptimeMillis", "(J)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetUptimeMillis_JHandler")]
			public abstract EventInternal.Builder SetUptimeMillis(long p0);

			// Token: 0x0400001C RID: 28
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/EventInternal$Builder", typeof(EventInternal.Builder));

			// Token: 0x0400001D RID: 29
			private static Delegate cb_getAutoMetadata;

			// Token: 0x0400001E RID: 30
			private static Delegate cb_build;

			// Token: 0x0400001F RID: 31
			private static Delegate cb_setAutoMetadata_Ljava_util_Map_;

			// Token: 0x04000020 RID: 32
			private static Delegate cb_setCode_Ljava_lang_Integer_;

			// Token: 0x04000021 RID: 33
			private static Delegate cb_setEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_;

			// Token: 0x04000022 RID: 34
			private static Delegate cb_setEventMillis_J;

			// Token: 0x04000023 RID: 35
			private static Delegate cb_setTransportName_Ljava_lang_String_;

			// Token: 0x04000024 RID: 36
			private static Delegate cb_setUptimeMillis_J;
		}

		// Token: 0x0200001E RID: 30
		[Register("com/google/android/datatransport/runtime/EventInternal$Builder", DoNotGenerateAcw = true)]
		internal class BuilderInvoker : EventInternal.Builder
		{
			// Token: 0x060000C0 RID: 192 RVA: 0x000032EC File Offset: 0x000014EC
			public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x000032F6 File Offset: 0x000014F6
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return EventInternal.BuilderInvoker._members;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x000032FD File Offset: 0x000014FD
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return EventInternal.BuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000330C File Offset: 0x0000150C
			protected override IDictionary<string, string> AutoMetadata
			{
				[Register("getAutoMetadata", "()Ljava/util/Map;", "GetGetAutoMetadataHandler")]
				get
				{
					return JavaDictionary<string, string>.FromJniHandle(EventInternal.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAutoMetadata.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00003340 File Offset: 0x00001540
			[Register("build", "()Lcom/google/android/datatransport/runtime/EventInternal;", "GetBuildHandler")]
			public override EventInternal Build()
			{
				return Java.Lang.Object.GetObject<EventInternal>(EventInternal.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/EventInternal;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x00003374 File Offset: 0x00001574
			[Register("setAutoMetadata", "(Ljava/util/Map;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetAutoMetadata_Ljava_util_Map_Handler")]
			protected unsafe override EventInternal.Builder SetAutoMetadata(IDictionary<string, string> p0)
			{
				IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(p0);
				EventInternal.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setAutoMetadata.(Ljava/util/Map;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x000033E8 File Offset: 0x000015E8
			[Register("setCode", "(Ljava/lang/Integer;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetCode_Ljava_lang_Integer_Handler")]
			public unsafe override EventInternal.Builder SetCode(Integer p0)
			{
				EventInternal.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setCode.(Ljava/lang/Integer;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x0000345C File Offset: 0x0000165C
			[Register("setEncodedPayload", "(Lcom/google/android/datatransport/runtime/EncodedPayload;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetEncodedPayload_Lcom_google_android_datatransport_runtime_EncodedPayload_Handler")]
			public unsafe override EventInternal.Builder SetEncodedPayload(EncodedPayload p0)
			{
				EventInternal.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setEncodedPayload.(Lcom/google/android/datatransport/runtime/EncodedPayload;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x000034D0 File Offset: 0x000016D0
			[Register("setEventMillis", "(J)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetEventMillis_JHandler")]
			public unsafe override EventInternal.Builder SetEventMillis(long p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setEventMillis.(J)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x0000351C File Offset: 0x0000171C
			[Register("setTransportName", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetTransportName_Ljava_lang_String_Handler")]
			public unsafe override EventInternal.Builder SetTransportName(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				EventInternal.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setTransportName.(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000CA RID: 202 RVA: 0x00003588 File Offset: 0x00001788
			[Register("setUptimeMillis", "(J)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", "GetSetUptimeMillis_JHandler")]
			public unsafe override EventInternal.Builder SetUptimeMillis(long p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<EventInternal.Builder>(EventInternal.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setUptimeMillis.(J)Lcom/google/android/datatransport/runtime/EventInternal$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000025 RID: 37
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/EventInternal$Builder", typeof(EventInternal.BuilderInvoker));
		}
	}
}
