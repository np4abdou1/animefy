using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Core
{
	// Token: 0x0200006A RID: 106
	[Register("com/unity3d/services/store/core/StoreWebViewError", DoNotGenerateAcw = true)]
	public class StoreWebViewError : WebViewAdsError
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000340 RID: 832 RVA: 0x000091D4 File Offset: 0x000073D4
		internal new static IntPtr class_ref
		{
			get
			{
				return StoreWebViewError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000091F8 File Offset: 0x000073F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StoreWebViewError._members;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00009200 File Offset: 0x00007400
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StoreWebViewError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00009224 File Offset: 0x00007424
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StoreWebViewError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00009230 File Offset: 0x00007430
		protected StoreWebViewError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000923C File Offset: 0x0000743C
		[Register(".ctor", "(Ljava/lang/Enum;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe StoreWebViewError(Java.Lang.Enum errorCategory, string description, params Java.Lang.Object[] errorArguments) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(description);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(errorArguments);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorCategory == null) ? IntPtr.Zero : errorCategory.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				base.SetHandle(StoreWebViewError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Enum;Ljava/lang/String;[Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StoreWebViewError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Enum;Ljava/lang/String;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (errorArguments != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, errorArguments);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(errorCategory);
				GC.KeepAlive(errorArguments);
			}
		}

		// Token: 0x040000A4 RID: 164
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/core/StoreWebViewError", typeof(StoreWebViewError));
	}
}
