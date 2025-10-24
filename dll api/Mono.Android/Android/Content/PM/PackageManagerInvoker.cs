using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content.PM
{
	// Token: 0x020002AF RID: 687
	[Register("android/content/pm/PackageManager", DoNotGenerateAcw = true)]
	internal class PackageManagerInvoker : PackageManager
	{
		// Token: 0x06001A69 RID: 6761 RVA: 0x00044707 File Offset: 0x00042907
		public PackageManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00044711 File Offset: 0x00042911
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PackageManagerInvoker._members;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x00044718 File Offset: 0x00042918
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PackageManagerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00044724 File Offset: 0x00042924
		public unsafe override Intent GetLaunchIntentForPackage(string packageName)
		{
			IntPtr intPtr = JNIEnv.NewString(packageName);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Intent>(PackageManagerInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getLaunchIntentForPackage.(Ljava/lang/String;)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000B37 RID: 2871
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/pm/PackageManager", typeof(PackageManagerInvoker));
	}
}
