using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result.Contract
{
	// Token: 0x0200002E RID: 46
	[Register("androidx/activity/result/contract/ActivityResultContract", DoNotGenerateAcw = true)]
	internal class ActivityResultContractInvoker : ActivityResultContract
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00005789 File Offset: 0x00003989
		public ActivityResultContractInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00005793 File Offset: 0x00003993
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActivityResultContractInvoker._members;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000579A File Offset: 0x0000399A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActivityResultContractInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000057A8 File Offset: 0x000039A8
		[Register("createIntent", "(Landroid/content/Context;Ljava/lang/Object;)Landroid/content/Intent;", "GetCreateIntent_Landroid_content_Context_Ljava_lang_Object_Handler")]
		public unsafe override Intent CreateIntent(Context context, Java.Lang.Object input)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(input);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Intent>(ActivityResultContractInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("createIntent.(Landroid/content/Context;Ljava/lang/Object;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(input);
			}
			return @object;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005844 File Offset: 0x00003A44
		[Register("parseResult", "(ILandroid/content/Intent;)Ljava/lang/Object;", "GetParseResult_ILandroid_content_Intent_Handler")]
		public unsafe override Java.Lang.Object ParseResult(int resultCode, Intent intent)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resultCode);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ActivityResultContractInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("parseResult.(ILandroid/content/Intent;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
			return @object;
		}

		// Token: 0x04000053 RID: 83
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/contract/ActivityResultContract", typeof(ActivityResultContractInvoker));
	}
}
