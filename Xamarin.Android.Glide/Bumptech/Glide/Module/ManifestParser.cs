using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Module
{
	// Token: 0x0200006F RID: 111
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/module/ManifestParser", DoNotGenerateAcw = true)]
	public sealed class ManifestParser : Java.Lang.Object
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00010588 File Offset: 0x0000E788
		internal static IntPtr class_ref
		{
			get
			{
				return ManifestParser._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x000105AC File Offset: 0x0000E7AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ManifestParser._members;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000105B4 File Offset: 0x0000E7B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ManifestParser._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ManifestParser._members.ManagedPeerType;
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000105E4 File Offset: 0x0000E7E4
		internal ManifestParser(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000105F0 File Offset: 0x0000E7F0
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ManifestParser(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ManifestParser._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ManifestParser._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000106A0 File Offset: 0x0000E8A0
		[Register("parse", "()Ljava/util/List;", "")]
		public IList<IGlideModule> Parse()
		{
			return JavaList<IGlideModule>.FromJniHandle(ManifestParser._members.InstanceMethods.InvokeAbstractObjectMethod("parse.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000109 RID: 265
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/module/ManifestParser", typeof(ManifestParser));
	}
}
