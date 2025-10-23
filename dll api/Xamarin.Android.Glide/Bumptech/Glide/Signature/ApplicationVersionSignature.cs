using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Signature
{
	// Token: 0x0200005B RID: 91
	[Register("com/bumptech/glide/signature/ApplicationVersionSignature", DoNotGenerateAcw = true)]
	public sealed class ApplicationVersionSignature : Java.Lang.Object
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000DE10 File Offset: 0x0000C010
		internal static IntPtr class_ref
		{
			get
			{
				return ApplicationVersionSignature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000DE34 File Offset: 0x0000C034
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ApplicationVersionSignature._members;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000DE3C File Offset: 0x0000C03C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ApplicationVersionSignature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0000DE60 File Offset: 0x0000C060
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ApplicationVersionSignature._members.ManagedPeerType;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000DE6C File Offset: 0x0000C06C
		internal ApplicationVersionSignature(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000DE78 File Offset: 0x0000C078
		[Register("obtain", "(Landroid/content/Context;)Lcom/bumptech/glide/load/Key;", "")]
		public unsafe static IKey Obtain(Context context)
		{
			IKey @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IKey>(ApplicationVersionSignature._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/content/Context;)Lcom/bumptech/glide/load/Key;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x040000D8 RID: 216
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/signature/ApplicationVersionSignature", typeof(ApplicationVersionSignature));
	}
}
