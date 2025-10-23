using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Provider
{
	// Token: 0x02000060 RID: 96
	[Register("com/bumptech/glide/provider/ImageHeaderParserRegistry", DoNotGenerateAcw = true)]
	public sealed class ImageHeaderParserRegistry : Java.Lang.Object
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000E730 File Offset: 0x0000C930
		internal static IntPtr class_ref
		{
			get
			{
				return ImageHeaderParserRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000E754 File Offset: 0x0000C954
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImageHeaderParserRegistry._members;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000E75C File Offset: 0x0000C95C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ImageHeaderParserRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000E780 File Offset: 0x0000C980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImageHeaderParserRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000E78C File Offset: 0x0000C98C
		internal ImageHeaderParserRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000E798 File Offset: 0x0000C998
		[Register(".ctor", "()V", "")]
		public ImageHeaderParserRegistry() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ImageHeaderParserRegistry._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ImageHeaderParserRegistry._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0000E808 File Offset: 0x0000CA08
		public IList<IImageHeaderParser> Parsers
		{
			[Register("getParsers", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<IImageHeaderParser>.FromJniHandle(ImageHeaderParserRegistry._members.InstanceMethods.InvokeAbstractObjectMethod("getParsers.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000E83C File Offset: 0x0000CA3C
		[Register("add", "(Lcom/bumptech/glide/load/ImageHeaderParser;)V", "")]
		public unsafe void Add(IImageHeaderParser parser)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parser == null) ? IntPtr.Zero : ((Java.Lang.Object)parser).Handle);
				ImageHeaderParserRegistry._members.InstanceMethods.InvokeAbstractVoidMethod("add.(Lcom/bumptech/glide/load/ImageHeaderParser;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parser);
			}
		}

		// Token: 0x040000E1 RID: 225
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/provider/ImageHeaderParserRegistry", typeof(ImageHeaderParserRegistry));
	}
}
