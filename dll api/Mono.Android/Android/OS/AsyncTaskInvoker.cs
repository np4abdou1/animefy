using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001DB RID: 475
	[Register("android/os/AsyncTask", DoNotGenerateAcw = true)]
	internal class AsyncTaskInvoker : AsyncTask
	{
		// Token: 0x06001147 RID: 4423 RVA: 0x0002D910 File Offset: 0x0002BB10
		public AsyncTaskInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0002D91A File Offset: 0x0002BB1A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AsyncTaskInvoker._members;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0002D921 File Offset: 0x0002BB21
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AsyncTaskInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0002D930 File Offset: 0x0002BB30
		protected unsafe override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(@params);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AsyncTaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("doInBackground.([Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (@params != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, @params);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(@params);
			}
			return @object;
		}

		// Token: 0x040007CB RID: 1995
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/AsyncTask", typeof(AsyncTaskInvoker));
	}
}
