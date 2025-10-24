using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200019C RID: 412
	[Register("com/bumptech/glide/load/data/ParcelFileDescriptorRewinder", DoNotGenerateAcw = true)]
	public sealed class ParcelFileDescriptorRewinder : Java.Lang.Object, IDataRewinder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x00042088 File Offset: 0x00040288
		internal static IntPtr class_ref
		{
			get
			{
				return ParcelFileDescriptorRewinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x000420AC File Offset: 0x000402AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ParcelFileDescriptorRewinder._members;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x000420B4 File Offset: 0x000402B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ParcelFileDescriptorRewinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x000420D8 File Offset: 0x000402D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ParcelFileDescriptorRewinder._members.ManagedPeerType;
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000420E4 File Offset: 0x000402E4
		internal ParcelFileDescriptorRewinder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000420F0 File Offset: 0x000402F0
		[Register(".ctor", "(Landroid/os/ParcelFileDescriptor;)V", "")]
		public unsafe ParcelFileDescriptorRewinder(ParcelFileDescriptor parcelFileDescriptor) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcelFileDescriptor == null) ? IntPtr.Zero : parcelFileDescriptor.Handle);
				base.SetHandle(ParcelFileDescriptorRewinder._members.InstanceMethods.StartCreateInstance("(Landroid/os/ParcelFileDescriptor;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ParcelFileDescriptorRewinder._members.InstanceMethods.FinishCreateInstance("(Landroid/os/ParcelFileDescriptor;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcelFileDescriptor);
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x000421A0 File Offset: 0x000403A0
		public static bool IsSupported
		{
			[Register("isSupported", "()Z", "")]
			get
			{
				return ParcelFileDescriptorRewinder._members.StaticMethods.InvokeBooleanMethod("isSupported.()Z", null);
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000421B8 File Offset: 0x000403B8
		[Register("cleanup", "()V", "")]
		public void Cleanup()
		{
			ParcelFileDescriptorRewinder._members.InstanceMethods.InvokeAbstractVoidMethod("cleanup.()V", this, null);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000421D4 File Offset: 0x000403D4
		[Register("rewindAndGet", "()Landroid/os/ParcelFileDescriptor;", "")]
		public ParcelFileDescriptor RewindAndGet()
		{
			return Java.Lang.Object.GetObject<ParcelFileDescriptor>(ParcelFileDescriptorRewinder._members.InstanceMethods.InvokeAbstractObjectMethod("rewindAndGet.()Landroid/os/ParcelFileDescriptor;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00042206 File Offset: 0x00040406
		Java.Lang.Object IDataRewinder.RewindAndGet()
		{
			return this.RewindAndGet().JavaCast<Java.Lang.Object>();
		}

		// Token: 0x040004F2 RID: 1266
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/ParcelFileDescriptorRewinder", typeof(ParcelFileDescriptorRewinder));

		// Token: 0x02000207 RID: 519
		[Register("com/bumptech/glide/load/data/ParcelFileDescriptorRewinder$Factory", DoNotGenerateAcw = true)]
		public sealed class Factory : Java.Lang.Object, IDataRewinderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x0600183C RID: 6204 RVA: 0x0004AB94 File Offset: 0x00048D94
			internal static IntPtr class_ref
			{
				get
				{
					return ParcelFileDescriptorRewinder.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x0600183D RID: 6205 RVA: 0x0004ABB8 File Offset: 0x00048DB8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ParcelFileDescriptorRewinder.Factory._members;
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x0600183E RID: 6206 RVA: 0x0004ABC0 File Offset: 0x00048DC0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ParcelFileDescriptorRewinder.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x0600183F RID: 6207 RVA: 0x0004ABE4 File Offset: 0x00048DE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ParcelFileDescriptorRewinder.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001840 RID: 6208 RVA: 0x0004ABF0 File Offset: 0x00048DF0
			internal Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001841 RID: 6209 RVA: 0x0004ABFC File Offset: 0x00048DFC
			[Register(".ctor", "()V", "")]
			public Factory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ParcelFileDescriptorRewinder.Factory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ParcelFileDescriptorRewinder.Factory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x06001842 RID: 6210 RVA: 0x0004AC6C File Offset: 0x00048E6C
			public Class DataClass
			{
				[Register("getDataClass", "()Ljava/lang/Class;", "")]
				get
				{
					return Java.Lang.Object.GetObject<Class>(ParcelFileDescriptorRewinder.Factory._members.InstanceMethods.InvokeAbstractObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06001843 RID: 6211 RVA: 0x0004ACA0 File Offset: 0x00048EA0
			[Register("build", "(Landroid/os/ParcelFileDescriptor;)Lcom/bumptech/glide/load/data/DataRewinder;", "")]
			public unsafe IDataRewinder Build(ParcelFileDescriptor parcelFileDescriptor)
			{
				IDataRewinder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parcelFileDescriptor == null) ? IntPtr.Zero : parcelFileDescriptor.Handle);
					@object = Java.Lang.Object.GetObject<IDataRewinder>(ParcelFileDescriptorRewinder.Factory._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Landroid/os/ParcelFileDescriptor;)Lcom/bumptech/glide/load/data/DataRewinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(parcelFileDescriptor);
				}
				return @object;
			}

			// Token: 0x06001844 RID: 6212 RVA: 0x0004AD14 File Offset: 0x00048F14
			IDataRewinder IDataRewinderFactory.Build(Java.Lang.Object p0)
			{
				return this.Build(p0.JavaCast<ParcelFileDescriptor>()).JavaCast<IDataRewinder>();
			}

			// Token: 0x040005C9 RID: 1481
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/ParcelFileDescriptorRewinder$Factory", typeof(ParcelFileDescriptorRewinder.Factory));
		}
	}
}
