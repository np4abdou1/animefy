using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Data;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load.Resource.Bytes
{
	// Token: 0x020000F7 RID: 247
	[Register("com/bumptech/glide/load/resource/bytes/ByteBufferRewinder", DoNotGenerateAcw = true)]
	public class ByteBufferRewinder : Java.Lang.Object, IDataRewinder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000265BC File Offset: 0x000247BC
		internal static IntPtr class_ref
		{
			get
			{
				return ByteBufferRewinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000265E0 File Offset: 0x000247E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBufferRewinder._members;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x000265E8 File Offset: 0x000247E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteBufferRewinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0002660C File Offset: 0x0002480C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBufferRewinder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00026618 File Offset: 0x00024818
		protected ByteBufferRewinder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00026624 File Offset: 0x00024824
		[Register(".ctor", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe ByteBufferRewinder(ByteBuffer buffer) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				base.SetHandle(ByteBufferRewinder._members.InstanceMethods.StartCreateInstance("(Ljava/nio/ByteBuffer;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ByteBufferRewinder._members.InstanceMethods.FinishCreateInstance("(Ljava/nio/ByteBuffer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(buffer);
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000266D4 File Offset: 0x000248D4
		private static Delegate GetCleanupHandler()
		{
			if (ByteBufferRewinder.cb_cleanup == null)
			{
				ByteBufferRewinder.cb_cleanup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ByteBufferRewinder.n_Cleanup));
			}
			return ByteBufferRewinder.cb_cleanup;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000266F8 File Offset: 0x000248F8
		private static void n_Cleanup(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ByteBufferRewinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cleanup();
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00026707 File Offset: 0x00024907
		[Register("cleanup", "()V", "GetCleanupHandler")]
		public virtual void Cleanup()
		{
			ByteBufferRewinder._members.InstanceMethods.InvokeVirtualVoidMethod("cleanup.()V", this, null);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00026720 File Offset: 0x00024920
		private static Delegate GetRewindAndGetHandler()
		{
			if (ByteBufferRewinder.cb_rewindAndGet == null)
			{
				ByteBufferRewinder.cb_rewindAndGet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ByteBufferRewinder.n_RewindAndGet));
			}
			return ByteBufferRewinder.cb_rewindAndGet;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00026744 File Offset: 0x00024944
		private static IntPtr n_RewindAndGet(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ByteBufferRewinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RewindAndGet());
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00026758 File Offset: 0x00024958
		[Register("rewindAndGet", "()Ljava/nio/ByteBuffer;", "GetRewindAndGetHandler")]
		public virtual ByteBuffer RewindAndGet()
		{
			return Java.Lang.Object.GetObject<ByteBuffer>(ByteBufferRewinder._members.InstanceMethods.InvokeVirtualObjectMethod("rewindAndGet.()Ljava/nio/ByteBuffer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0002678A File Offset: 0x0002498A
		Java.Lang.Object IDataRewinder.RewindAndGet()
		{
			return this.RewindAndGet().JavaCast<Java.Lang.Object>();
		}

		// Token: 0x040002F5 RID: 757
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bytes/ByteBufferRewinder", typeof(ByteBufferRewinder));

		// Token: 0x040002F6 RID: 758
		private static Delegate cb_cleanup;

		// Token: 0x040002F7 RID: 759
		private static Delegate cb_rewindAndGet;

		// Token: 0x020001C7 RID: 455
		[Register("com/bumptech/glide/load/resource/bytes/ByteBufferRewinder$Factory", DoNotGenerateAcw = true)]
		public class Factory : Java.Lang.Object, IDataRewinderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00044B30 File Offset: 0x00042D30
			internal static IntPtr class_ref
			{
				get
				{
					return ByteBufferRewinder.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00044B54 File Offset: 0x00042D54
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ByteBufferRewinder.Factory._members;
				}
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x060015E4 RID: 5604 RVA: 0x00044B5C File Offset: 0x00042D5C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ByteBufferRewinder.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00044B80 File Offset: 0x00042D80
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ByteBufferRewinder.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x060015E6 RID: 5606 RVA: 0x00044B8C File Offset: 0x00042D8C
			protected Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060015E7 RID: 5607 RVA: 0x00044B98 File Offset: 0x00042D98
			[Register(".ctor", "()V", "")]
			public Factory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ByteBufferRewinder.Factory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ByteBufferRewinder.Factory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060015E8 RID: 5608 RVA: 0x00044C06 File Offset: 0x00042E06
			private static Delegate GetGetDataClassHandler()
			{
				if (ByteBufferRewinder.Factory.cb_getDataClass == null)
				{
					ByteBufferRewinder.Factory.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ByteBufferRewinder.Factory.n_GetDataClass));
				}
				return ByteBufferRewinder.Factory.cb_getDataClass;
			}

			// Token: 0x060015E9 RID: 5609 RVA: 0x00044C2A File Offset: 0x00042E2A
			private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ByteBufferRewinder.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x060015EA RID: 5610 RVA: 0x00044C40 File Offset: 0x00042E40
			public virtual Class DataClass
			{
				[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Class>(ByteBufferRewinder.Factory._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060015EB RID: 5611 RVA: 0x00044C72 File Offset: 0x00042E72
			private static Delegate GetBuild_Ljava_nio_ByteBuffer_Handler()
			{
				if (ByteBufferRewinder.Factory.cb_build_Ljava_nio_ByteBuffer_ == null)
				{
					ByteBufferRewinder.Factory.cb_build_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ByteBufferRewinder.Factory.n_Build_Ljava_nio_ByteBuffer_));
				}
				return ByteBufferRewinder.Factory.cb_build_Ljava_nio_ByteBuffer_;
			}

			// Token: 0x060015EC RID: 5612 RVA: 0x00044C98 File Offset: 0x00042E98
			private static IntPtr n_Build_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				ByteBufferRewinder.Factory @object = Java.Lang.Object.GetObject<ByteBufferRewinder.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_data, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x060015ED RID: 5613 RVA: 0x00044CC0 File Offset: 0x00042EC0
			[Register("build", "(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/data/DataRewinder;", "GetBuild_Ljava_nio_ByteBuffer_Handler")]
			public unsafe virtual IDataRewinder Build(ByteBuffer data)
			{
				IDataRewinder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
					@object = Java.Lang.Object.GetObject<IDataRewinder>(ByteBufferRewinder.Factory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/data/DataRewinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(data);
				}
				return @object;
			}

			// Token: 0x060015EE RID: 5614 RVA: 0x00044D34 File Offset: 0x00042F34
			IDataRewinder IDataRewinderFactory.Build(Java.Lang.Object p0)
			{
				return this.Build(p0.JavaCast<ByteBuffer>()).JavaCast<IDataRewinder>();
			}

			// Token: 0x0400053D RID: 1341
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bytes/ByteBufferRewinder$Factory", typeof(ByteBufferRewinder.Factory));

			// Token: 0x0400053E RID: 1342
			private static Delegate cb_getDataClass;

			// Token: 0x0400053F RID: 1343
			private static Delegate cb_build_Ljava_nio_ByteBuffer_;
		}
	}
}
