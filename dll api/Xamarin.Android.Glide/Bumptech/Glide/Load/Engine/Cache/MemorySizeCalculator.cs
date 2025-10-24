using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000171 RID: 369
	[Register("com/bumptech/glide/load/engine/cache/MemorySizeCalculator", DoNotGenerateAcw = true)]
	public sealed class MemorySizeCalculator : Java.Lang.Object
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0003B5E8 File Offset: 0x000397E8
		internal static IntPtr class_ref
		{
			get
			{
				return MemorySizeCalculator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0003B60C File Offset: 0x0003980C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MemorySizeCalculator._members;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0003B614 File Offset: 0x00039814
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MemorySizeCalculator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0003B638 File Offset: 0x00039838
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MemorySizeCalculator._members.ManagedPeerType;
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0003B644 File Offset: 0x00039844
		internal MemorySizeCalculator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x0003B64E File Offset: 0x0003984E
		public int ArrayPoolSizeInBytes
		{
			[Register("getArrayPoolSizeInBytes", "()I", "")]
			get
			{
				return MemorySizeCalculator._members.InstanceMethods.InvokeAbstractInt32Method("getArrayPoolSizeInBytes.()I", this, null);
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0003B667 File Offset: 0x00039867
		public int BitmapPoolSize
		{
			[Register("getBitmapPoolSize", "()I", "")]
			get
			{
				return MemorySizeCalculator._members.InstanceMethods.InvokeAbstractInt32Method("getBitmapPoolSize.()I", this, null);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x0003B680 File Offset: 0x00039880
		public int MemoryCacheSize
		{
			[Register("getMemoryCacheSize", "()I", "")]
			get
			{
				return MemorySizeCalculator._members.InstanceMethods.InvokeAbstractInt32Method("getMemoryCacheSize.()I", this, null);
			}
		}

		// Token: 0x04000450 RID: 1104
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/MemorySizeCalculator", typeof(MemorySizeCalculator));

		// Token: 0x020001FF RID: 511
		[Register("com/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x06001802 RID: 6146 RVA: 0x0004A124 File Offset: 0x00048324
			internal static IntPtr class_ref
			{
				get
				{
					return MemorySizeCalculator.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x06001803 RID: 6147 RVA: 0x0004A148 File Offset: 0x00048348
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MemorySizeCalculator.Builder._members;
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06001804 RID: 6148 RVA: 0x0004A150 File Offset: 0x00048350
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return MemorySizeCalculator.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06001805 RID: 6149 RVA: 0x0004A174 File Offset: 0x00048374
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MemorySizeCalculator.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06001806 RID: 6150 RVA: 0x0004A180 File Offset: 0x00048380
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001807 RID: 6151 RVA: 0x0004A18C File Offset: 0x0004838C
			[Register(".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					base.SetHandle(MemorySizeCalculator.Builder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					MemorySizeCalculator.Builder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
				}
			}

			// Token: 0x06001808 RID: 6152 RVA: 0x0004A23C File Offset: 0x0004843C
			[Register("build", "()Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator;", "")]
			public MemorySizeCalculator Build()
			{
				return Java.Lang.Object.GetObject<MemorySizeCalculator>(MemorySizeCalculator.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06001809 RID: 6153 RVA: 0x0004A270 File Offset: 0x00048470
			[Register("setArrayPoolSize", "(I)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", "")]
			public unsafe MemorySizeCalculator.Builder SetArrayPoolSize(int arrayPoolSizeBytes)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(arrayPoolSizeBytes);
				return Java.Lang.Object.GetObject<MemorySizeCalculator.Builder>(MemorySizeCalculator.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setArrayPoolSize.(I)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600180A RID: 6154 RVA: 0x0004A2BC File Offset: 0x000484BC
			[Register("setBitmapPoolScreens", "(F)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", "")]
			public unsafe MemorySizeCalculator.Builder SetBitmapPoolScreens(float bitmapPoolScreens)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(bitmapPoolScreens);
				return Java.Lang.Object.GetObject<MemorySizeCalculator.Builder>(MemorySizeCalculator.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBitmapPoolScreens.(F)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600180B RID: 6155 RVA: 0x0004A308 File Offset: 0x00048508
			[Register("setLowMemoryMaxSizeMultiplier", "(F)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", "")]
			public unsafe MemorySizeCalculator.Builder SetLowMemoryMaxSizeMultiplier(float lowMemoryMaxSizeMultiplier)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(lowMemoryMaxSizeMultiplier);
				return Java.Lang.Object.GetObject<MemorySizeCalculator.Builder>(MemorySizeCalculator.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setLowMemoryMaxSizeMultiplier.(F)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600180C RID: 6156 RVA: 0x0004A354 File Offset: 0x00048554
			[Register("setMaxSizeMultiplier", "(F)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", "")]
			public unsafe MemorySizeCalculator.Builder SetMaxSizeMultiplier(float maxSizeMultiplier)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(maxSizeMultiplier);
				return Java.Lang.Object.GetObject<MemorySizeCalculator.Builder>(MemorySizeCalculator.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setMaxSizeMultiplier.(F)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600180D RID: 6157 RVA: 0x0004A3A0 File Offset: 0x000485A0
			[Register("setMemoryCacheScreens", "(F)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", "")]
			public unsafe MemorySizeCalculator.Builder SetMemoryCacheScreens(float memoryCacheScreens)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(memoryCacheScreens);
				return Java.Lang.Object.GetObject<MemorySizeCalculator.Builder>(MemorySizeCalculator.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setMemoryCacheScreens.(F)Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040005BE RID: 1470
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder", typeof(MemorySizeCalculator.Builder));
		}
	}
}
