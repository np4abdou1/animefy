using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000199 RID: 409
	[Register("com/bumptech/glide/load/data/InputStreamRewinder", DoNotGenerateAcw = true)]
	public sealed class InputStreamRewinder : Java.Lang.Object
	{
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00041990 File Offset: 0x0003FB90
		internal static IntPtr class_ref
		{
			get
			{
				return InputStreamRewinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x000419B4 File Offset: 0x0003FBB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InputStreamRewinder._members;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x000419BC File Offset: 0x0003FBBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InputStreamRewinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x000419E0 File Offset: 0x0003FBE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InputStreamRewinder._members.ManagedPeerType;
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000419EC File Offset: 0x0003FBEC
		internal InputStreamRewinder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x000419F8 File Offset: 0x0003FBF8
		[Register(".ctor", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe InputStreamRewinder(Stream @is, IArrayPool byteArrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				base.SetHandle(InputStreamRewinder._members.InstanceMethods.StartCreateInstance("(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				InputStreamRewinder._members.InstanceMethods.FinishCreateInstance("(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
				GC.KeepAlive(byteArrayPool);
			}
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00041AD0 File Offset: 0x0003FCD0
		[Register("cleanup", "()V", "")]
		public void Cleanup()
		{
			InputStreamRewinder._members.InstanceMethods.InvokeAbstractVoidMethod("cleanup.()V", this, null);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00041AE9 File Offset: 0x0003FCE9
		[Register("fixMarkLimits", "()V", "")]
		public void FixMarkLimits()
		{
			InputStreamRewinder._members.InstanceMethods.InvokeAbstractVoidMethod("fixMarkLimits.()V", this, null);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00041B04 File Offset: 0x0003FD04
		[Register("rewindAndGet", "()Ljava/io/InputStream;", "")]
		public Stream RewindAndGet()
		{
			return InputStreamInvoker.FromJniHandle(InputStreamRewinder._members.InstanceMethods.InvokeAbstractObjectMethod("rewindAndGet.()Ljava/io/InputStream;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040004E9 RID: 1257
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/InputStreamRewinder", typeof(InputStreamRewinder));

		// Token: 0x02000206 RID: 518
		[Register("com/bumptech/glide/load/data/InputStreamRewinder$Factory", DoNotGenerateAcw = true)]
		public sealed class Factory : Java.Lang.Object
		{
			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x06001833 RID: 6195 RVA: 0x0004A9B4 File Offset: 0x00048BB4
			internal static IntPtr class_ref
			{
				get
				{
					return InputStreamRewinder.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x06001834 RID: 6196 RVA: 0x0004A9D8 File Offset: 0x00048BD8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return InputStreamRewinder.Factory._members;
				}
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x06001835 RID: 6197 RVA: 0x0004A9E0 File Offset: 0x00048BE0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return InputStreamRewinder.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x06001836 RID: 6198 RVA: 0x0004AA04 File Offset: 0x00048C04
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return InputStreamRewinder.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001837 RID: 6199 RVA: 0x0004AA10 File Offset: 0x00048C10
			internal Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001838 RID: 6200 RVA: 0x0004AA1C File Offset: 0x00048C1C
			[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
			public unsafe Factory(IArrayPool byteArrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
					base.SetHandle(InputStreamRewinder.Factory._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					InputStreamRewinder.Factory._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(byteArrayPool);
				}
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x06001839 RID: 6201 RVA: 0x0004AAD0 File Offset: 0x00048CD0
			public Class DataClass
			{
				[Register("getDataClass", "()Ljava/lang/Class;", "")]
				get
				{
					return Java.Lang.Object.GetObject<Class>(InputStreamRewinder.Factory._members.InstanceMethods.InvokeAbstractObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600183A RID: 6202 RVA: 0x0004AB04 File Offset: 0x00048D04
			[Register("build", "(Ljava/io/InputStream;)Lcom/bumptech/glide/load/data/DataRewinder;", "")]
			public unsafe IDataRewinder Build(Stream data)
			{
				IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(data);
				IDataRewinder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<IDataRewinder>(InputStreamRewinder.Factory._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Ljava/io/InputStream;)Lcom/bumptech/glide/load/data/DataRewinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(data);
				}
				return @object;
			}

			// Token: 0x040005C8 RID: 1480
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/InputStreamRewinder$Factory", typeof(InputStreamRewinder.Factory));
		}
	}
}
