using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x0200018C RID: 396
	[Register("com/unity3d/services/core/api/Intent", DoNotGenerateAcw = true)]
	public class Intent : Java.Lang.Object
	{
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00031E14 File Offset: 0x00030014
		internal static IntPtr class_ref
		{
			get
			{
				return Intent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x00031E38 File Offset: 0x00030038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Intent._members;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00031E40 File Offset: 0x00030040
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Intent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x00031E64 File Offset: 0x00030064
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Intent._members.ManagedPeerType;
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Intent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00031E70 File Offset: 0x00030070
		[Register(".ctor", "()V", "")]
		public Intent() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Intent._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Intent._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00031EE0 File Offset: 0x000300E0
		[Register("canOpenIntent", "(Lorg/json/JSONObject;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void CanOpenIntent(JSONObject intentData, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intentData == null) ? IntPtr.Zero : intentData.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Intent._members.StaticMethods.InvokeVoidMethod("canOpenIntent.(Lorg/json/JSONObject;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(intentData);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00031F6C File Offset: 0x0003016C
		[Register("canOpenIntents", "(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void CanOpenIntents(JSONArray intents, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intents == null) ? IntPtr.Zero : intents.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Intent._members.StaticMethods.InvokeVoidMethod("canOpenIntents.(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(intents);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00031FF8 File Offset: 0x000301F8
		[Register("launch", "(Lorg/json/JSONObject;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Launch(JSONObject intentData, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intentData == null) ? IntPtr.Zero : intentData.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Intent._members.StaticMethods.InvokeVoidMethod("launch.(Lorg/json/JSONObject;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(intentData);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00032084 File Offset: 0x00030284
		[Register("removeActiveActivity", "(Landroid/app/Activity;)V", "")]
		public unsafe static void RemoveActiveActivity(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				Intent._members.StaticMethods.InvokeVoidMethod("removeActiveActivity.(Landroid/app/Activity;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000320E8 File Offset: 0x000302E8
		[Register("setActiveActivity", "(Landroid/app/Activity;)V", "")]
		public unsafe static void SetActiveActivity(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				Intent._members.StaticMethods.InvokeVoidMethod("setActiveActivity.(Landroid/app/Activity;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x0400044F RID: 1103
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Intent", typeof(Intent));

		// Token: 0x0200018D RID: 397
		[Register("com/unity3d/services/core/api/Intent$IntentError", DoNotGenerateAcw = true)]
		public sealed class IntentError : Java.Lang.Enum
		{
			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x06001217 RID: 4631 RVA: 0x00032168 File Offset: 0x00030368
			[Register("ACTIVITY_WAS_NULL")]
			public static Intent.IntentError ActivityWasNull
			{
				get
				{
					return Java.Lang.Object.GetObject<Intent.IntentError>(Intent.IntentError._members.StaticFields.GetObjectValue("ACTIVITY_WAS_NULL.Lcom/unity3d/services/core/api/Intent$IntentError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x06001218 RID: 4632 RVA: 0x00032198 File Offset: 0x00030398
			[Register("COULDNT_PARSE_CATEGORIES")]
			public static Intent.IntentError CouldntParseCategories
			{
				get
				{
					return Java.Lang.Object.GetObject<Intent.IntentError>(Intent.IntentError._members.StaticFields.GetObjectValue("COULDNT_PARSE_CATEGORIES.Lcom/unity3d/services/core/api/Intent$IntentError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x06001219 RID: 4633 RVA: 0x000321C8 File Offset: 0x000303C8
			[Register("COULDNT_PARSE_EXTRAS")]
			public static Intent.IntentError CouldntParseExtras
			{
				get
				{
					return Java.Lang.Object.GetObject<Intent.IntentError>(Intent.IntentError._members.StaticFields.GetObjectValue("COULDNT_PARSE_EXTRAS.Lcom/unity3d/services/core/api/Intent$IntentError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x0600121A RID: 4634 RVA: 0x000321F8 File Offset: 0x000303F8
			[Register("INTENT_WAS_NULL")]
			public static Intent.IntentError IntentWasNull
			{
				get
				{
					return Java.Lang.Object.GetObject<Intent.IntentError>(Intent.IntentError._members.StaticFields.GetObjectValue("INTENT_WAS_NULL.Lcom/unity3d/services/core/api/Intent$IntentError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x0600121B RID: 4635 RVA: 0x00032228 File Offset: 0x00030428
			[Register("JSON_EXCEPTION")]
			public static Intent.IntentError JsonException
			{
				get
				{
					return Java.Lang.Object.GetObject<Intent.IntentError>(Intent.IntentError._members.StaticFields.GetObjectValue("JSON_EXCEPTION.Lcom/unity3d/services/core/api/Intent$IntentError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x0600121C RID: 4636 RVA: 0x00032258 File Offset: 0x00030458
			internal static IntPtr class_ref
			{
				get
				{
					return Intent.IntentError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x0600121D RID: 4637 RVA: 0x0003227C File Offset: 0x0003047C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Intent.IntentError._members;
				}
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x0600121E RID: 4638 RVA: 0x00032284 File Offset: 0x00030484
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Intent.IntentError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x0600121F RID: 4639 RVA: 0x000322A8 File Offset: 0x000304A8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Intent.IntentError._members.ManagedPeerType;
				}
			}

			// Token: 0x06001220 RID: 4640 RVA: 0x0000256C File Offset: 0x0000076C
			internal IntentError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001221 RID: 4641 RVA: 0x000322B4 File Offset: 0x000304B4
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/api/Intent$IntentError;", "")]
			public unsafe static Intent.IntentError ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				Intent.IntentError @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Intent.IntentError>(Intent.IntentError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/api/Intent$IntentError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06001222 RID: 4642 RVA: 0x00032320 File Offset: 0x00030520
			[Register("values", "()[Lcom/unity3d/services/core/api/Intent$IntentError;", "")]
			public static Intent.IntentError[] Values()
			{
				return (Intent.IntentError[])JNIEnv.GetArray(Intent.IntentError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/api/Intent$IntentError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Intent.IntentError));
			}

			// Token: 0x04000450 RID: 1104
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Intent$IntentError", typeof(Intent.IntentError));
		}
	}
}
