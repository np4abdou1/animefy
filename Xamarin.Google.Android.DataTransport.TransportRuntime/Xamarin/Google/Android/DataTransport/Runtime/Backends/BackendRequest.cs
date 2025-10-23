using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000085 RID: 133
	[Register("com/google/android/datatransport/runtime/backends/BackendRequest", DoNotGenerateAcw = true)]
	public abstract class BackendRequest : Java.Lang.Object
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0000ED70 File Offset: 0x0000CF70
		internal static IntPtr class_ref
		{
			get
			{
				return BackendRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0000ED94 File Offset: 0x0000CF94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BackendRequest._members;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0000ED9C File Offset: 0x0000CF9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BackendRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BackendRequest._members.ManagedPeerType;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000026C4 File Offset: 0x000008C4
		protected BackendRequest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		[Register(".ctor", "()V", "")]
		public BackendRequest() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BackendRequest._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BackendRequest._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000EE3A File Offset: 0x0000D03A
		private static Delegate GetGetEventsHandler()
		{
			if (BackendRequest.cb_getEvents == null)
			{
				BackendRequest.cb_getEvents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BackendRequest.n_GetEvents));
			}
			return BackendRequest.cb_getEvents;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000EE5E File Offset: 0x0000D05E
		private static IntPtr n_GetEvents(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BackendRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Events);
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004D8 RID: 1240
		public abstract IIterable Events { [Register("getEvents", "()Ljava/lang/Iterable;", "GetGetEventsHandler")] get; }

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000EE74 File Offset: 0x0000D074
		[Register("builder", "()Lcom/google/android/datatransport/runtime/backends/BackendRequest$Builder;", "")]
		public static BackendRequest.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<BackendRequest.Builder>(BackendRequest._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/runtime/backends/BackendRequest$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		[Register("create", "(Ljava/lang/Iterable;)Lcom/google/android/datatransport/runtime/backends/BackendRequest;", "")]
		public unsafe static BackendRequest Create(IIterable events)
		{
			BackendRequest @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((events == null) ? IntPtr.Zero : ((Java.Lang.Object)events).Handle);
				@object = Java.Lang.Object.GetObject<BackendRequest>(BackendRequest._members.StaticMethods.InvokeObjectMethod("create.(Ljava/lang/Iterable;)Lcom/google/android/datatransport/runtime/backends/BackendRequest;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(events);
			}
			return @object;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000EF20 File Offset: 0x0000D120
		private static Delegate GetGetExtrasHandler()
		{
			if (BackendRequest.cb_getExtras == null)
			{
				BackendRequest.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BackendRequest.n_GetExtras));
			}
			return BackendRequest.cb_getExtras;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000EF44 File Offset: 0x0000D144
		private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<BackendRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetExtras());
		}

		// Token: 0x060004DD RID: 1245
		[Register("getExtras", "()[B", "GetGetExtrasHandler")]
		public abstract byte[] GetExtras();

		// Token: 0x04000109 RID: 265
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendRequest", typeof(BackendRequest));

		// Token: 0x0400010A RID: 266
		private static Delegate cb_getEvents;

		// Token: 0x0400010B RID: 267
		private static Delegate cb_getExtras;

		// Token: 0x02000086 RID: 134
		[Register("com/google/android/datatransport/runtime/backends/BackendRequest$Builder", DoNotGenerateAcw = true)]
		public abstract class Builder : Java.Lang.Object
		{
			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x0000EF74 File Offset: 0x0000D174
			internal static IntPtr class_ref
			{
				get
				{
					return BackendRequest.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0000EF98 File Offset: 0x0000D198
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BackendRequest.Builder._members;
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BackendRequest.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BackendRequest.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x000026C4 File Offset: 0x000008C4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(BackendRequest.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				BackendRequest.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060004E5 RID: 1253 RVA: 0x0000F03E File Offset: 0x0000D23E
			private static Delegate GetBuildHandler()
			{
				if (BackendRequest.Builder.cb_build == null)
				{
					BackendRequest.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BackendRequest.Builder.n_Build));
				}
				return BackendRequest.Builder.cb_build;
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x0000F062 File Offset: 0x0000D262
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BackendRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060004E7 RID: 1255
			[Register("build", "()Lcom/google/android/datatransport/runtime/backends/BackendRequest;", "GetBuildHandler")]
			public abstract BackendRequest Build();

			// Token: 0x060004E8 RID: 1256 RVA: 0x0000F076 File Offset: 0x0000D276
			private static Delegate GetSetEvents_Ljava_lang_Iterable_Handler()
			{
				if (BackendRequest.Builder.cb_setEvents_Ljava_lang_Iterable_ == null)
				{
					BackendRequest.Builder.cb_setEvents_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BackendRequest.Builder.n_SetEvents_Ljava_lang_Iterable_));
				}
				return BackendRequest.Builder.cb_setEvents_Ljava_lang_Iterable_;
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x0000F09C File Offset: 0x0000D29C
			private static IntPtr n_SetEvents_Ljava_lang_Iterable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BackendRequest.Builder @object = Java.Lang.Object.GetObject<BackendRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IIterable object2 = Java.Lang.Object.GetObject<IIterable>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetEvents(object2));
			}

			// Token: 0x060004EA RID: 1258
			[Register("setEvents", "(Ljava/lang/Iterable;)Lcom/google/android/datatransport/runtime/backends/BackendRequest$Builder;", "GetSetEvents_Ljava_lang_Iterable_Handler")]
			public abstract BackendRequest.Builder SetEvents(IIterable p0);

			// Token: 0x060004EB RID: 1259 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
			private static Delegate GetSetExtras_arrayBHandler()
			{
				if (BackendRequest.Builder.cb_setExtras_arrayB == null)
				{
					BackendRequest.Builder.cb_setExtras_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BackendRequest.Builder.n_SetExtras_arrayB));
				}
				return BackendRequest.Builder.cb_setExtras_arrayB;
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
			private static IntPtr n_SetExtras_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BackendRequest.Builder @object = Java.Lang.Object.GetObject<BackendRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] array = (byte[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetExtras(array));
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_p0);
				}
				return result;
			}

			// Token: 0x060004ED RID: 1261
			[Register("setExtras", "([B)Lcom/google/android/datatransport/runtime/backends/BackendRequest$Builder;", "GetSetExtras_arrayBHandler")]
			public abstract BackendRequest.Builder SetExtras(byte[] p0);

			// Token: 0x0400010C RID: 268
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendRequest$Builder", typeof(BackendRequest.Builder));

			// Token: 0x0400010D RID: 269
			private static Delegate cb_build;

			// Token: 0x0400010E RID: 270
			private static Delegate cb_setEvents_Ljava_lang_Iterable_;

			// Token: 0x0400010F RID: 271
			private static Delegate cb_setExtras_arrayB;
		}

		// Token: 0x02000087 RID: 135
		[Register("com/google/android/datatransport/runtime/backends/BackendRequest$Builder", DoNotGenerateAcw = true)]
		internal class BuilderInvoker : BackendRequest.Builder
		{
			// Token: 0x060004EF RID: 1263 RVA: 0x0000F144 File Offset: 0x0000D344
			public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0000F14E File Offset: 0x0000D34E
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BackendRequest.BuilderInvoker._members;
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0000F155 File Offset: 0x0000D355
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BackendRequest.BuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x0000F164 File Offset: 0x0000D364
			[Register("build", "()Lcom/google/android/datatransport/runtime/backends/BackendRequest;", "GetBuildHandler")]
			public override BackendRequest Build()
			{
				return Java.Lang.Object.GetObject<BackendRequest>(BackendRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/backends/BackendRequest;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x0000F198 File Offset: 0x0000D398
			[Register("setEvents", "(Ljava/lang/Iterable;)Lcom/google/android/datatransport/runtime/backends/BackendRequest$Builder;", "GetSetEvents_Ljava_lang_Iterable_Handler")]
			public unsafe override BackendRequest.Builder SetEvents(IIterable p0)
			{
				BackendRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
					@object = Java.Lang.Object.GetObject<BackendRequest.Builder>(BackendRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setEvents.(Ljava/lang/Iterable;)Lcom/google/android/datatransport/runtime/backends/BackendRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x060004F4 RID: 1268 RVA: 0x0000F210 File Offset: 0x0000D410
			[Register("setExtras", "([B)Lcom/google/android/datatransport/runtime/backends/BackendRequest$Builder;", "GetSetExtras_arrayBHandler")]
			public unsafe override BackendRequest.Builder SetExtras(byte[] p0)
			{
				IntPtr intPtr = JNIEnv.NewArray(p0);
				BackendRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<BackendRequest.Builder>(BackendRequest.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setExtras.([B)Lcom/google/android/datatransport/runtime/backends/BackendRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (p0 != null)
					{
						JNIEnv.CopyArray(intPtr, p0);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x04000110 RID: 272
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendRequest$Builder", typeof(BackendRequest.BuilderInvoker));
		}
	}
}
