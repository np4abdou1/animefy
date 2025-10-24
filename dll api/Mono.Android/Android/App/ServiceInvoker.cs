using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x0200026C RID: 620
	[Register("android/app/Service", DoNotGenerateAcw = true)]
	internal class ServiceInvoker : Service
	{
		// Token: 0x060017CA RID: 6090 RVA: 0x0003DBB2 File Offset: 0x0003BDB2
		public ServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0003DBBC File Offset: 0x0003BDBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServiceInvoker._members;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0003DBC3 File Offset: 0x0003BDC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0003DBD0 File Offset: 0x0003BDD0
		public unsafe override IBinder OnBind(Intent intent)
		{
			IBinder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				@object = Java.Lang.Object.GetObject<IBinder>(ServiceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("onBind.(Landroid/content/Intent;)Landroid/os/IBinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
			return @object;
		}

		// Token: 0x04000A19 RID: 2585
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Service", typeof(ServiceInvoker));
	}
}
