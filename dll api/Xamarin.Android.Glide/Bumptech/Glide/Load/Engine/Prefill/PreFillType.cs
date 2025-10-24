using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Prefill
{
	// Token: 0x0200015A RID: 346
	[Register("com/bumptech/glide/load/engine/prefill/PreFillType", DoNotGenerateAcw = true)]
	public sealed class PreFillType : Java.Lang.Object
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00038584 File Offset: 0x00036784
		internal static IntPtr class_ref
		{
			get
			{
				return PreFillType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x000385A8 File Offset: 0x000367A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PreFillType._members;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x000385B0 File Offset: 0x000367B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PreFillType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x000385D4 File Offset: 0x000367D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PreFillType._members.ManagedPeerType;
			}
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000385E0 File Offset: 0x000367E0
		internal PreFillType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000401 RID: 1025
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/prefill/PreFillType", typeof(PreFillType));

		// Token: 0x020001F6 RID: 502
		[Register("com/bumptech/glide/load/engine/prefill/PreFillType$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00049AE4 File Offset: 0x00047CE4
			internal static IntPtr class_ref
			{
				get
				{
					return PreFillType.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00049B08 File Offset: 0x00047D08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return PreFillType.Builder._members;
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00049B10 File Offset: 0x00047D10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return PreFillType.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x060017D8 RID: 6104 RVA: 0x00049B34 File Offset: 0x00047D34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return PreFillType.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060017D9 RID: 6105 RVA: 0x00049B40 File Offset: 0x00047D40
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060017DA RID: 6106 RVA: 0x00049B4C File Offset: 0x00047D4C
			[Register(".ctor", "(I)V", "")]
			public unsafe Builder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(size);
				base.SetHandle(PreFillType.Builder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PreFillType.Builder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
			}

			// Token: 0x060017DB RID: 6107 RVA: 0x00049BD0 File Offset: 0x00047DD0
			[Register(".ctor", "(II)V", "")]
			public unsafe Builder(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				base.SetHandle(PreFillType.Builder._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PreFillType.Builder._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
			}

			// Token: 0x060017DC RID: 6108 RVA: 0x00049C67 File Offset: 0x00047E67
			private static Delegate GetSetConfig_Landroid_graphics_Bitmap_Config_Handler()
			{
				if (PreFillType.Builder.cb_setConfig_Landroid_graphics_Bitmap_Config_ == null)
				{
					PreFillType.Builder.cb_setConfig_Landroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(PreFillType.Builder.n_SetConfig_Landroid_graphics_Bitmap_Config_));
				}
				return PreFillType.Builder.cb_setConfig_Landroid_graphics_Bitmap_Config_;
			}

			// Token: 0x060017DD RID: 6109 RVA: 0x00049C8C File Offset: 0x00047E8C
			private static IntPtr n_SetConfig_Landroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, IntPtr native_config)
			{
				PreFillType.Builder @object = Java.Lang.Object.GetObject<PreFillType.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_config, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetConfig(object2));
			}

			// Token: 0x060017DE RID: 6110 RVA: 0x00049CB4 File Offset: 0x00047EB4
			[Register("setConfig", "(Landroid/graphics/Bitmap$Config;)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;", "GetSetConfig_Landroid_graphics_Bitmap_Config_Handler")]
			public unsafe virtual PreFillType.Builder SetConfig(Bitmap.Config config)
			{
				PreFillType.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
					@object = Java.Lang.Object.GetObject<PreFillType.Builder>(PreFillType.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setConfig.(Landroid/graphics/Bitmap$Config;)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(config);
				}
				return @object;
			}

			// Token: 0x060017DF RID: 6111 RVA: 0x00049D28 File Offset: 0x00047F28
			private static Delegate GetSetWeight_IHandler()
			{
				if (PreFillType.Builder.cb_setWeight_I == null)
				{
					PreFillType.Builder.cb_setWeight_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(PreFillType.Builder.n_SetWeight_I));
				}
				return PreFillType.Builder.cb_setWeight_I;
			}

			// Token: 0x060017E0 RID: 6112 RVA: 0x00049D4C File Offset: 0x00047F4C
			private static IntPtr n_SetWeight_I(IntPtr jnienv, IntPtr native__this, int weight)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PreFillType.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetWeight(weight));
			}

			// Token: 0x060017E1 RID: 6113 RVA: 0x00049D64 File Offset: 0x00047F64
			[Register("setWeight", "(I)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;", "GetSetWeight_IHandler")]
			public unsafe virtual PreFillType.Builder SetWeight(int weight)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(weight);
				return Java.Lang.Object.GetObject<PreFillType.Builder>(PreFillType.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setWeight.(I)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040005AE RID: 1454
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/prefill/PreFillType$Builder", typeof(PreFillType.Builder));

			// Token: 0x040005AF RID: 1455
			private static Delegate cb_setConfig_Landroid_graphics_Bitmap_Config_;

			// Token: 0x040005B0 RID: 1456
			private static Delegate cb_setWeight_I;
		}
	}
}
