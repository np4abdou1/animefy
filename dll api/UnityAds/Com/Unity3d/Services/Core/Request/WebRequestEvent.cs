using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000B6 RID: 182
	[Register("com/unity3d/services/core/request/WebRequestEvent", DoNotGenerateAcw = true)]
	public sealed class WebRequestEvent : Java.Lang.Enum
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000126A0 File Offset: 0x000108A0
		[Register("COMPLETE")]
		public static WebRequestEvent Complete
		{
			get
			{
				return Java.Lang.Object.GetObject<WebRequestEvent>(WebRequestEvent._members.StaticFields.GetObjectValue("COMPLETE.Lcom/unity3d/services/core/request/WebRequestEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x000126D0 File Offset: 0x000108D0
		[Register("FAILED")]
		public static WebRequestEvent Failed
		{
			get
			{
				return Java.Lang.Object.GetObject<WebRequestEvent>(WebRequestEvent._members.StaticFields.GetObjectValue("FAILED.Lcom/unity3d/services/core/request/WebRequestEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00012700 File Offset: 0x00010900
		internal static IntPtr class_ref
		{
			get
			{
				return WebRequestEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00012724 File Offset: 0x00010924
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebRequestEvent._members;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0001272C File Offset: 0x0001092C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebRequestEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00012750 File Offset: 0x00010950
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebRequestEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0000256C File Offset: 0x0000076C
		internal WebRequestEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001275C File Offset: 0x0001095C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/request/WebRequestEvent;", "")]
		public unsafe static WebRequestEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			WebRequestEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<WebRequestEvent>(WebRequestEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/request/WebRequestEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000127C8 File Offset: 0x000109C8
		[Register("values", "()[Lcom/unity3d/services/core/request/WebRequestEvent;", "")]
		public static WebRequestEvent[] Values()
		{
			return (WebRequestEvent[])JNIEnv.GetArray(WebRequestEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/request/WebRequestEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(WebRequestEvent));
		}

		// Token: 0x0400019C RID: 412
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/WebRequestEvent", typeof(WebRequestEvent));
	}
}
