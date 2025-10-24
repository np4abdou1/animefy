using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000D6 RID: 214
	[Register("com/google/android/datatransport/runtime/dagger/internal/ProviderOfLazy", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class ProviderOfLazy : Java.Lang.Object, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x000157A0 File Offset: 0x000139A0
		[Register("get", "()Lcom/google/android/datatransport/runtime/dagger/Lazy;", "")]
		public Java.Lang.Object Get()
		{
			return (Java.Lang.Object)Java.Lang.Object.GetObject<ILazy>(ProviderOfLazy._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/dagger/Lazy;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000157D8 File Offset: 0x000139D8
		internal static IntPtr class_ref
		{
			get
			{
				return ProviderOfLazy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x000157FC File Offset: 0x000139FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProviderOfLazy._members;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00015804 File Offset: 0x00013A04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ProviderOfLazy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00015828 File Offset: 0x00013A28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProviderOfLazy._members.ManagedPeerType;
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000026C4 File Offset: 0x000008C4
		internal ProviderOfLazy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00015834 File Offset: 0x00013A34
		[Register("create", "(Ljavax/inject/Provider;)Ljavax/inject/Provider;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IProvider Create(IProvider provider)
		{
			IProvider @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				@object = Java.Lang.Object.GetObject<IProvider>(ProviderOfLazy._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;)Ljavax/inject/Provider;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(provider);
			}
			return @object;
		}

		// Token: 0x04000227 RID: 551
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/ProviderOfLazy", typeof(ProviderOfLazy));
	}
}
