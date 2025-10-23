using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000B5 RID: 181
	[Register("com/unity3d/services/core/request/WebRequestError", DoNotGenerateAcw = true)]
	public sealed class WebRequestError : Java.Lang.Enum
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0001254C File Offset: 0x0001074C
		[Register("MAPPING_HEADERS_FAILED")]
		public static WebRequestError MappingHeadersFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<WebRequestError>(WebRequestError._members.StaticFields.GetObjectValue("MAPPING_HEADERS_FAILED.Lcom/unity3d/services/core/request/WebRequestError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0001257C File Offset: 0x0001077C
		internal static IntPtr class_ref
		{
			get
			{
				return WebRequestError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000125A0 File Offset: 0x000107A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebRequestError._members;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x000125A8 File Offset: 0x000107A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebRequestError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000125CC File Offset: 0x000107CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebRequestError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000256C File Offset: 0x0000076C
		internal WebRequestError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000125D8 File Offset: 0x000107D8
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/request/WebRequestError;", "")]
		public unsafe static WebRequestError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			WebRequestError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<WebRequestError>(WebRequestError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/request/WebRequestError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00012644 File Offset: 0x00010844
		[Register("values", "()[Lcom/unity3d/services/core/request/WebRequestError;", "")]
		public static WebRequestError[] Values()
		{
			return (WebRequestError[])JNIEnv.GetArray(WebRequestError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/request/WebRequestError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(WebRequestError));
		}

		// Token: 0x0400019B RID: 411
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/WebRequestError", typeof(WebRequestError));
	}
}
