using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000DC RID: 220
	[Register("com/google/android/datatransport/runtime/dagger/internal/DelegateFactory", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class DelegateFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00015D1C File Offset: 0x00013F1C
		internal static IntPtr class_ref
		{
			get
			{
				return DelegateFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00015D40 File Offset: 0x00013F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DelegateFactory._members;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00015D48 File Offset: 0x00013F48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DelegateFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00015D6C File Offset: 0x00013F6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DelegateFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000026C4 File Offset: 0x000008C4
		internal DelegateFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00015D78 File Offset: 0x00013F78
		[Register(".ctor", "()V", "")]
		public DelegateFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DelegateFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DelegateFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00015DE8 File Offset: 0x00013FE8
		[Register("get", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(DelegateFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00015E1C File Offset: 0x0001401C
		[Register("setDelegate", "(Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void SetDelegate(IProvider delegateFactory, IProvider @delegate)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((delegateFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)delegateFactory).Handle);
				ptr[1] = new JniArgumentValue((@delegate == null) ? IntPtr.Zero : ((Java.Lang.Object)@delegate).Handle);
				DelegateFactory._members.StaticMethods.InvokeVoidMethod("setDelegate.(Ljavax/inject/Provider;Ljavax/inject/Provider;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(delegateFactory);
				GC.KeepAlive(@delegate);
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00015EB0 File Offset: 0x000140B0
		[Obsolete("deprecated")]
		[Register("setDelegatedProvider", "(Ljavax/inject/Provider;)V", "")]
		public unsafe void SetDelegatedProvider(IProvider @delegate)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@delegate == null) ? IntPtr.Zero : ((Java.Lang.Object)@delegate).Handle);
				DelegateFactory._members.InstanceMethods.InvokeAbstractVoidMethod("setDelegatedProvider.(Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@delegate);
			}
		}

		// Token: 0x0400022C RID: 556
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/DelegateFactory", typeof(DelegateFactory));
	}
}
