using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model.Stream
{
	// Token: 0x0200014B RID: 331
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/load/model/stream/HttpUriLoader", DoNotGenerateAcw = true)]
	public class HttpUriLoader : UrlUriLoader
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00035F64 File Offset: 0x00034164
		internal new static IntPtr class_ref
		{
			get
			{
				return HttpUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00035F88 File Offset: 0x00034188
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HttpUriLoader._members;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00035F90 File Offset: 0x00034190
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HttpUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00035FB4 File Offset: 0x000341B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HttpUriLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00035FC0 File Offset: 0x000341C0
		protected HttpUriLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00035FCC File Offset: 0x000341CC
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe HttpUriLoader(IModelLoader urlLoader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((urlLoader == null) ? IntPtr.Zero : ((Java.Lang.Object)urlLoader).Handle);
				base.SetHandle(HttpUriLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				HttpUriLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(urlLoader);
			}
		}

		// Token: 0x040003D8 RID: 984
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/HttpUriLoader", typeof(HttpUriLoader));

		// Token: 0x020001F1 RID: 497
		[Obsolete("This class is obsoleted in this android platform")]
		[Register("com/bumptech/glide/load/model/stream/HttpUriLoader$Factory", DoNotGenerateAcw = true)]
		public class Factory : UrlUriLoader.StreamFactory
		{
			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x0600179B RID: 6043 RVA: 0x00049270 File Offset: 0x00047470
			internal new static IntPtr class_ref
			{
				get
				{
					return HttpUriLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x0600179C RID: 6044 RVA: 0x00049294 File Offset: 0x00047494
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return HttpUriLoader.Factory._members;
				}
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x0600179D RID: 6045 RVA: 0x0004929C File Offset: 0x0004749C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return HttpUriLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x0600179E RID: 6046 RVA: 0x000492C0 File Offset: 0x000474C0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return HttpUriLoader.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x0600179F RID: 6047 RVA: 0x000492CC File Offset: 0x000474CC
			protected Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060017A0 RID: 6048 RVA: 0x000492D8 File Offset: 0x000474D8
			[Register(".ctor", "()V", "")]
			public Factory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(HttpUriLoader.Factory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				HttpUriLoader.Factory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040005A2 RID: 1442
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/HttpUriLoader$Factory", typeof(HttpUriLoader.Factory));
		}
	}
}
