using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result.Contract
{
	// Token: 0x0200002C RID: 44
	[Register("androidx/activity/result/contract/ActivityResultContract", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"I",
		"O"
	})]
	public abstract class ActivityResultContract : Java.Lang.Object
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000053B4 File Offset: 0x000035B4
		internal static IntPtr class_ref
		{
			get
			{
				return ActivityResultContract._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000053D8 File Offset: 0x000035D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActivityResultContract._members;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000053E0 File Offset: 0x000035E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActivityResultContract._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00005404 File Offset: 0x00003604
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActivityResultContract._members.ManagedPeerType;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003484 File Offset: 0x00001684
		protected ActivityResultContract(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005410 File Offset: 0x00003610
		[Register(".ctor", "()V", "")]
		public ActivityResultContract() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ActivityResultContract._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ActivityResultContract._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000547E File Offset: 0x0000367E
		private static Delegate GetCreateIntent_Landroid_content_Context_Ljava_lang_Object_Handler()
		{
			if (ActivityResultContract.cb_createIntent_Landroid_content_Context_Ljava_lang_Object_ == null)
			{
				ActivityResultContract.cb_createIntent_Landroid_content_Context_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ActivityResultContract.n_CreateIntent_Landroid_content_Context_Ljava_lang_Object_));
			}
			return ActivityResultContract.cb_createIntent_Landroid_content_Context_Ljava_lang_Object_;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000054A4 File Offset: 0x000036A4
		private static IntPtr n_CreateIntent_Landroid_content_Context_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_input)
		{
			ActivityResultContract @object = Java.Lang.Object.GetObject<ActivityResultContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_input, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateIntent(object2, object3));
		}

		// Token: 0x06000154 RID: 340
		[Register("createIntent", "(Landroid/content/Context;Ljava/lang/Object;)Landroid/content/Intent;", "GetCreateIntent_Landroid_content_Context_Ljava_lang_Object_Handler")]
		public abstract Intent CreateIntent(Context context, Java.Lang.Object input);

		// Token: 0x06000155 RID: 341 RVA: 0x000054D5 File Offset: 0x000036D5
		private static Delegate GetGetSynchronousResult_Landroid_content_Context_Ljava_lang_Object_Handler()
		{
			if (ActivityResultContract.cb_getSynchronousResult_Landroid_content_Context_Ljava_lang_Object_ == null)
			{
				ActivityResultContract.cb_getSynchronousResult_Landroid_content_Context_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ActivityResultContract.n_GetSynchronousResult_Landroid_content_Context_Ljava_lang_Object_));
			}
			return ActivityResultContract.cb_getSynchronousResult_Landroid_content_Context_Ljava_lang_Object_;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000054FC File Offset: 0x000036FC
		private static IntPtr n_GetSynchronousResult_Landroid_content_Context_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_input)
		{
			ActivityResultContract @object = Java.Lang.Object.GetObject<ActivityResultContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_input, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetSynchronousResult(object2, object3));
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005530 File Offset: 0x00003730
		[Register("getSynchronousResult", "(Landroid/content/Context;Ljava/lang/Object;)Landroidx/activity/result/contract/ActivityResultContract$SynchronousResult;", "GetGetSynchronousResult_Landroid_content_Context_Ljava_lang_Object_Handler")]
		public unsafe virtual ActivityResultContract.SynchronousResult GetSynchronousResult(Context context, Java.Lang.Object input)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(input);
			ActivityResultContract.SynchronousResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ActivityResultContract.SynchronousResult>(ActivityResultContract._members.InstanceMethods.InvokeVirtualObjectMethod("getSynchronousResult.(Landroid/content/Context;Ljava/lang/Object;)Landroidx/activity/result/contract/ActivityResultContract$SynchronousResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(input);
			}
			return @object;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000055CC File Offset: 0x000037CC
		private static Delegate GetParseResult_ILandroid_content_Intent_Handler()
		{
			if (ActivityResultContract.cb_parseResult_ILandroid_content_Intent_ == null)
			{
				ActivityResultContract.cb_parseResult_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(ActivityResultContract.n_ParseResult_ILandroid_content_Intent_));
			}
			return ActivityResultContract.cb_parseResult_ILandroid_content_Intent_;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000055F0 File Offset: 0x000037F0
		private static IntPtr n_ParseResult_ILandroid_content_Intent_(IntPtr jnienv, IntPtr native__this, int resultCode, IntPtr native_intent)
		{
			ActivityResultContract @object = Java.Lang.Object.GetObject<ActivityResultContract>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ParseResult(resultCode, object2));
		}

		// Token: 0x0600015A RID: 346
		[Register("parseResult", "(ILandroid/content/Intent;)Ljava/lang/Object;", "GetParseResult_ILandroid_content_Intent_Handler")]
		public abstract Java.Lang.Object ParseResult(int resultCode, Intent intent);

		// Token: 0x0400004E RID: 78
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/contract/ActivityResultContract", typeof(ActivityResultContract));

		// Token: 0x0400004F RID: 79
		private static Delegate cb_createIntent_Landroid_content_Context_Ljava_lang_Object_;

		// Token: 0x04000050 RID: 80
		private static Delegate cb_getSynchronousResult_Landroid_content_Context_Ljava_lang_Object_;

		// Token: 0x04000051 RID: 81
		private static Delegate cb_parseResult_ILandroid_content_Intent_;

		// Token: 0x0200002D RID: 45
		[Register("androidx/activity/result/contract/ActivityResultContract$SynchronousResult", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public sealed class SynchronousResult : Java.Lang.Object
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x0600015C RID: 348 RVA: 0x00005634 File Offset: 0x00003834
			internal static IntPtr class_ref
			{
				get
				{
					return ActivityResultContract.SynchronousResult._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600015D RID: 349 RVA: 0x00005658 File Offset: 0x00003858
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActivityResultContract.SynchronousResult._members;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x0600015E RID: 350 RVA: 0x00005660 File Offset: 0x00003860
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ActivityResultContract.SynchronousResult._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600015F RID: 351 RVA: 0x00005684 File Offset: 0x00003884
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActivityResultContract.SynchronousResult._members.ManagedPeerType;
				}
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00003484 File Offset: 0x00001684
			internal SynchronousResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00005690 File Offset: 0x00003890
			[Register(".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe SynchronousResult(Java.Lang.Object value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					base.SetHandle(ActivityResultContract.SynchronousResult._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ActivityResultContract.SynchronousResult._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000162 RID: 354 RVA: 0x0000573C File Offset: 0x0000393C
			public Java.Lang.Object Value
			{
				[Register("getValue", "()Ljava/lang/Object;", "")]
				get
				{
					return Java.Lang.Object.GetObject<Java.Lang.Object>(ActivityResultContract.SynchronousResult._members.InstanceMethods.InvokeNonvirtualObjectMethod("getValue.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x04000052 RID: 82
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/contract/ActivityResultContract$SynchronousResult", typeof(ActivityResultContract.SynchronousResult));
		}
	}
}
