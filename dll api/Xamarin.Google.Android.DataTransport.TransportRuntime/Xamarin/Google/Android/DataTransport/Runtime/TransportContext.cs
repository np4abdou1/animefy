using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000028 RID: 40
	[Register("com/google/android/datatransport/runtime/TransportContext", DoNotGenerateAcw = true)]
	public abstract class TransportContext : Java.Lang.Object
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000040A0 File Offset: 0x000022A0
		internal static IntPtr class_ref
		{
			get
			{
				return TransportContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000040C4 File Offset: 0x000022C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransportContext._members;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000040CC File Offset: 0x000022CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TransportContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000040F0 File Offset: 0x000022F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransportContext._members.ManagedPeerType;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000026C4 File Offset: 0x000008C4
		protected TransportContext(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000040FC File Offset: 0x000022FC
		[Register(".ctor", "()V", "")]
		public TransportContext() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TransportContext._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TransportContext._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000416A File Offset: 0x0000236A
		private static Delegate GetGetBackendNameHandler()
		{
			if (TransportContext.cb_getBackendName == null)
			{
				TransportContext.cb_getBackendName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TransportContext.n_GetBackendName));
			}
			return TransportContext.cb_getBackendName;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000418E File Offset: 0x0000238E
		private static IntPtr n_GetBackendName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<TransportContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BackendName);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000123 RID: 291
		public abstract string BackendName { [Register("getBackendName", "()Ljava/lang/String;", "GetGetBackendNameHandler")] get; }

		// Token: 0x06000124 RID: 292 RVA: 0x000041A2 File Offset: 0x000023A2
		private static Delegate GetGetPriorityHandler()
		{
			if (TransportContext.cb_getPriority == null)
			{
				TransportContext.cb_getPriority = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TransportContext.n_GetPriority));
			}
			return TransportContext.cb_getPriority;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000041C6 File Offset: 0x000023C6
		private static IntPtr n_GetPriority(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TransportContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Priority);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000126 RID: 294
		public abstract Priority Priority { [Register("getPriority", "()Lcom/google/android/datatransport/Priority;", "GetGetPriorityHandler")] get; }

		// Token: 0x06000127 RID: 295 RVA: 0x000041DC File Offset: 0x000023DC
		[Register("builder", "()Lcom/google/android/datatransport/runtime/TransportContext$Builder;", "")]
		public static TransportContext.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<TransportContext.Builder>(TransportContext._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/runtime/TransportContext$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000420D File Offset: 0x0000240D
		private static Delegate GetGetExtrasHandler()
		{
			if (TransportContext.cb_getExtras == null)
			{
				TransportContext.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TransportContext.n_GetExtras));
			}
			return TransportContext.cb_getExtras;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004231 File Offset: 0x00002431
		private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<TransportContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetExtras());
		}

		// Token: 0x0600012A RID: 298
		[Register("getExtras", "()[B", "GetGetExtrasHandler")]
		public abstract byte[] GetExtras();

		// Token: 0x0600012B RID: 299 RVA: 0x00004245 File Offset: 0x00002445
		private static Delegate GetShouldUploadClientHealthMetricsHandler()
		{
			if (TransportContext.cb_shouldUploadClientHealthMetrics == null)
			{
				TransportContext.cb_shouldUploadClientHealthMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TransportContext.n_ShouldUploadClientHealthMetrics));
			}
			return TransportContext.cb_shouldUploadClientHealthMetrics;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004269 File Offset: 0x00002469
		private static bool n_ShouldUploadClientHealthMetrics(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TransportContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldUploadClientHealthMetrics();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004278 File Offset: 0x00002478
		[Register("shouldUploadClientHealthMetrics", "()Z", "GetShouldUploadClientHealthMetricsHandler")]
		public virtual bool ShouldUploadClientHealthMetrics()
		{
			return TransportContext._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldUploadClientHealthMetrics.()Z", this, null);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004294 File Offset: 0x00002494
		[Register("toString", "()Ljava/lang/String;", "")]
		public sealed override string ToString()
		{
			return JNIEnv.GetString(TransportContext._members.InstanceMethods.InvokeNonvirtualObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000042C6 File Offset: 0x000024C6
		private static Delegate GetWithPriority_Lcom_google_android_datatransport_Priority_Handler()
		{
			if (TransportContext.cb_withPriority_Lcom_google_android_datatransport_Priority_ == null)
			{
				TransportContext.cb_withPriority_Lcom_google_android_datatransport_Priority_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TransportContext.n_WithPriority_Lcom_google_android_datatransport_Priority_));
			}
			return TransportContext.cb_withPriority_Lcom_google_android_datatransport_Priority_;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000042EC File Offset: 0x000024EC
		private static IntPtr n_WithPriority_Lcom_google_android_datatransport_Priority_(IntPtr jnienv, IntPtr native__this, IntPtr native_priority)
		{
			TransportContext @object = Java.Lang.Object.GetObject<TransportContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Priority object2 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WithPriority(object2));
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004314 File Offset: 0x00002514
		[Register("withPriority", "(Lcom/google/android/datatransport/Priority;)Lcom/google/android/datatransport/runtime/TransportContext;", "GetWithPriority_Lcom_google_android_datatransport_Priority_Handler")]
		public unsafe virtual TransportContext WithPriority(Priority priority)
		{
			TransportContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				@object = Java.Lang.Object.GetObject<TransportContext>(TransportContext._members.InstanceMethods.InvokeVirtualObjectMethod("withPriority.(Lcom/google/android/datatransport/Priority;)Lcom/google/android/datatransport/runtime/TransportContext;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(priority);
			}
			return @object;
		}

		// Token: 0x0400003A RID: 58
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/TransportContext", typeof(TransportContext));

		// Token: 0x0400003B RID: 59
		private static Delegate cb_getBackendName;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_getPriority;

		// Token: 0x0400003D RID: 61
		private static Delegate cb_getExtras;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_shouldUploadClientHealthMetrics;

		// Token: 0x0400003F RID: 63
		private static Delegate cb_withPriority_Lcom_google_android_datatransport_Priority_;

		// Token: 0x02000029 RID: 41
		[Register("com/google/android/datatransport/runtime/TransportContext$Builder", DoNotGenerateAcw = true)]
		public abstract class Builder : Java.Lang.Object
		{
			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000133 RID: 307 RVA: 0x000043A4 File Offset: 0x000025A4
			internal static IntPtr class_ref
			{
				get
				{
					return TransportContext.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000134 RID: 308 RVA: 0x000043C8 File Offset: 0x000025C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TransportContext.Builder._members;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000135 RID: 309 RVA: 0x000043D0 File Offset: 0x000025D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TransportContext.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000136 RID: 310 RVA: 0x000043F4 File Offset: 0x000025F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TransportContext.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000137 RID: 311 RVA: 0x000026C4 File Offset: 0x000008C4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00004400 File Offset: 0x00002600
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(TransportContext.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				TransportContext.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000139 RID: 313 RVA: 0x0000446E File Offset: 0x0000266E
			private static Delegate GetBuildHandler()
			{
				if (TransportContext.Builder.cb_build == null)
				{
					TransportContext.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TransportContext.Builder.n_Build));
				}
				return TransportContext.Builder.cb_build;
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00004492 File Offset: 0x00002692
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TransportContext.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x0600013B RID: 315
			[Register("build", "()Lcom/google/android/datatransport/runtime/TransportContext;", "GetBuildHandler")]
			public abstract TransportContext Build();

			// Token: 0x0600013C RID: 316 RVA: 0x000044A6 File Offset: 0x000026A6
			private static Delegate GetSetBackendName_Ljava_lang_String_Handler()
			{
				if (TransportContext.Builder.cb_setBackendName_Ljava_lang_String_ == null)
				{
					TransportContext.Builder.cb_setBackendName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TransportContext.Builder.n_SetBackendName_Ljava_lang_String_));
				}
				return TransportContext.Builder.cb_setBackendName_Ljava_lang_String_;
			}

			// Token: 0x0600013D RID: 317 RVA: 0x000044CC File Offset: 0x000026CC
			private static IntPtr n_SetBackendName_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				TransportContext.Builder @object = Java.Lang.Object.GetObject<TransportContext.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetBackendName(@string));
			}

			// Token: 0x0600013E RID: 318
			[Register("setBackendName", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", "GetSetBackendName_Ljava_lang_String_Handler")]
			public abstract TransportContext.Builder SetBackendName(string p0);

			// Token: 0x0600013F RID: 319 RVA: 0x000044F4 File Offset: 0x000026F4
			private static Delegate GetSetExtras_arrayBHandler()
			{
				if (TransportContext.Builder.cb_setExtras_arrayB == null)
				{
					TransportContext.Builder.cb_setExtras_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TransportContext.Builder.n_SetExtras_arrayB));
				}
				return TransportContext.Builder.cb_setExtras_arrayB;
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00004518 File Offset: 0x00002718
			private static IntPtr n_SetExtras_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				TransportContext.Builder @object = Java.Lang.Object.GetObject<TransportContext.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] array = (byte[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetExtras(array));
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_p0);
				}
				return result;
			}

			// Token: 0x06000141 RID: 321
			[Register("setExtras", "([B)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", "GetSetExtras_arrayBHandler")]
			public abstract TransportContext.Builder SetExtras(byte[] p0);

			// Token: 0x06000142 RID: 322 RVA: 0x00004559 File Offset: 0x00002759
			private static Delegate GetSetPriority_Lcom_google_android_datatransport_Priority_Handler()
			{
				if (TransportContext.Builder.cb_setPriority_Lcom_google_android_datatransport_Priority_ == null)
				{
					TransportContext.Builder.cb_setPriority_Lcom_google_android_datatransport_Priority_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TransportContext.Builder.n_SetPriority_Lcom_google_android_datatransport_Priority_));
				}
				return TransportContext.Builder.cb_setPriority_Lcom_google_android_datatransport_Priority_;
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00004580 File Offset: 0x00002780
			private static IntPtr n_SetPriority_Lcom_google_android_datatransport_Priority_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				TransportContext.Builder @object = Java.Lang.Object.GetObject<TransportContext.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Priority object2 = Java.Lang.Object.GetObject<Priority>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetPriority(object2));
			}

			// Token: 0x06000144 RID: 324
			[Register("setPriority", "(Lcom/google/android/datatransport/Priority;)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", "GetSetPriority_Lcom_google_android_datatransport_Priority_Handler")]
			public abstract TransportContext.Builder SetPriority(Priority p0);

			// Token: 0x04000040 RID: 64
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/TransportContext$Builder", typeof(TransportContext.Builder));

			// Token: 0x04000041 RID: 65
			private static Delegate cb_build;

			// Token: 0x04000042 RID: 66
			private static Delegate cb_setBackendName_Ljava_lang_String_;

			// Token: 0x04000043 RID: 67
			private static Delegate cb_setExtras_arrayB;

			// Token: 0x04000044 RID: 68
			private static Delegate cb_setPriority_Lcom_google_android_datatransport_Priority_;
		}

		// Token: 0x0200002A RID: 42
		[Register("com/google/android/datatransport/runtime/TransportContext$Builder", DoNotGenerateAcw = true)]
		internal class BuilderInvoker : TransportContext.Builder
		{
			// Token: 0x06000146 RID: 326 RVA: 0x000045C3 File Offset: 0x000027C3
			public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000147 RID: 327 RVA: 0x000045CD File Offset: 0x000027CD
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TransportContext.BuilderInvoker._members;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000148 RID: 328 RVA: 0x000045D4 File Offset: 0x000027D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TransportContext.BuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000149 RID: 329 RVA: 0x000045E0 File Offset: 0x000027E0
			[Register("build", "()Lcom/google/android/datatransport/runtime/TransportContext;", "GetBuildHandler")]
			public override TransportContext Build()
			{
				return Java.Lang.Object.GetObject<TransportContext>(TransportContext.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/TransportContext;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00004614 File Offset: 0x00002814
			[Register("setBackendName", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", "GetSetBackendName_Ljava_lang_String_Handler")]
			public unsafe override TransportContext.Builder SetBackendName(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				TransportContext.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<TransportContext.Builder>(TransportContext.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setBackendName.(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600014B RID: 331 RVA: 0x00004680 File Offset: 0x00002880
			[Register("setExtras", "([B)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", "GetSetExtras_arrayBHandler")]
			public unsafe override TransportContext.Builder SetExtras(byte[] p0)
			{
				IntPtr intPtr = JNIEnv.NewArray(p0);
				TransportContext.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<TransportContext.Builder>(TransportContext.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setExtras.([B)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

			// Token: 0x0600014C RID: 332 RVA: 0x000046FC File Offset: 0x000028FC
			[Register("setPriority", "(Lcom/google/android/datatransport/Priority;)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", "GetSetPriority_Lcom_google_android_datatransport_Priority_Handler")]
			public unsafe override TransportContext.Builder SetPriority(Priority p0)
			{
				TransportContext.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<TransportContext.Builder>(TransportContext.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setPriority.(Lcom/google/android/datatransport/Priority;)Lcom/google/android/datatransport/runtime/TransportContext$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x04000045 RID: 69
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/TransportContext$Builder", typeof(TransportContext.BuilderInvoker));
		}
	}
}
