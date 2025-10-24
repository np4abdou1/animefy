using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient
{
	// Token: 0x0200005B RID: 91
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/BillingClientBuilderFactory", DoNotGenerateAcw = true)]
	public class BillingClientBuilderFactory : Java.Lang.Object
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00006BBC File Offset: 0x00004DBC
		internal static IntPtr class_ref
		{
			get
			{
				return BillingClientBuilderFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00006BE0 File Offset: 0x00004DE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingClientBuilderFactory._members;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BillingClientBuilderFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00006C0C File Offset: 0x00004E0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingClientBuilderFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BillingClientBuilderFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00006C18 File Offset: 0x00004E18
		[Register(".ctor", "()V", "")]
		public BillingClientBuilderFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BillingClientBuilderFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BillingClientBuilderFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00006C88 File Offset: 0x00004E88
		[Register("getBillingClientBuilder", "(Landroid/content/Context;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;", "")]
		public unsafe static IBillingClientBuilderBridge GetBillingClientBuilder(Context context)
		{
			IBillingClientBuilderBridge @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IBillingClientBuilderBridge>(BillingClientBuilderFactory._members.StaticMethods.InvokeObjectMethod("getBillingClientBuilder.(Landroid/content/Context;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x04000063 RID: 99
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/BillingClientBuilderFactory", typeof(BillingClientBuilderFactory));
	}
}
