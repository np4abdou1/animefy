using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle.ViewModels
{
	// Token: 0x02000018 RID: 24
	[Register("androidx/lifecycle/viewmodel/CreationExtras", DoNotGenerateAcw = true)]
	internal class CreationExtrasInvoker : CreationExtras
	{
		// Token: 0x0600008E RID: 142 RVA: 0x000034C7 File Offset: 0x000016C7
		public CreationExtrasInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000034D1 File Offset: 0x000016D1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CreationExtrasInvoker._members;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000034D8 File Offset: 0x000016D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CreationExtrasInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000034E4 File Offset: 0x000016E4
		[Register("get", "(Landroidx/lifecycle/viewmodel/CreationExtras$Key;)Ljava/lang/Object;", "GetGet_Landroidx_lifecycle_viewmodel_CreationExtras_Key_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe override Java.Lang.Object Get(CreationExtras.IKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CreationExtrasInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("get.(Landroidx/lifecycle/viewmodel/CreationExtras$Key;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0400001F RID: 31
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/viewmodel/CreationExtras", typeof(CreationExtrasInvoker));
	}
}
