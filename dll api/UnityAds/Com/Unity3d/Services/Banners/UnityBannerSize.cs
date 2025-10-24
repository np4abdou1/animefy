using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001BA RID: 442
	[Register("com/unity3d/services/banners/UnityBannerSize", DoNotGenerateAcw = true)]
	public class UnityBannerSize : Java.Lang.Object
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00037620 File Offset: 0x00035820
		internal static IntPtr class_ref
		{
			get
			{
				return UnityBannerSize._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00037644 File Offset: 0x00035844
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityBannerSize._members;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0003764C File Offset: 0x0003584C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityBannerSize._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00037670 File Offset: 0x00035870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityBannerSize._members.ManagedPeerType;
			}
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x000021E8 File Offset: 0x000003E8
		protected UnityBannerSize(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0003767C File Offset: 0x0003587C
		[Register(".ctor", "(II)V", "")]
		public unsafe UnityBannerSize(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			base.SetHandle(UnityBannerSize._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			UnityBannerSize._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00037713 File Offset: 0x00035913
		private static Delegate GetGetHeightHandler()
		{
			if (UnityBannerSize.cb_getHeight == null)
			{
				UnityBannerSize.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(UnityBannerSize.n_GetHeight));
			}
			return UnityBannerSize.cb_getHeight;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00037737 File Offset: 0x00035937
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<UnityBannerSize>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00037746 File Offset: 0x00035946
		public virtual int Height
		{
			[Register("getHeight", "()I", "GetGetHeightHandler")]
			get
			{
				return UnityBannerSize._members.InstanceMethods.InvokeVirtualInt32Method("getHeight.()I", this, null);
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0003775F File Offset: 0x0003595F
		private static Delegate GetGetWidthHandler()
		{
			if (UnityBannerSize.cb_getWidth == null)
			{
				UnityBannerSize.cb_getWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(UnityBannerSize.n_GetWidth));
			}
			return UnityBannerSize.cb_getWidth;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00037783 File Offset: 0x00035983
		private static int n_GetWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<UnityBannerSize>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Width;
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00037792 File Offset: 0x00035992
		public virtual int Width
		{
			[Register("getWidth", "()I", "GetGetWidthHandler")]
			get
			{
				return UnityBannerSize._members.InstanceMethods.InvokeVirtualInt32Method("getWidth.()I", this, null);
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x000377AC File Offset: 0x000359AC
		[Register("getDynamicSize", "(Landroid/content/Context;)Lcom/unity3d/services/banners/UnityBannerSize;", "")]
		public unsafe static UnityBannerSize GetDynamicSize(Context context)
		{
			UnityBannerSize @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<UnityBannerSize>(UnityBannerSize._members.StaticMethods.InvokeObjectMethod("getDynamicSize.(Landroid/content/Context;)Lcom/unity3d/services/banners/UnityBannerSize;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x040004BC RID: 1212
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/UnityBannerSize", typeof(UnityBannerSize));

		// Token: 0x040004BD RID: 1213
		private static Delegate cb_getHeight;

		// Token: 0x040004BE RID: 1214
		private static Delegate cb_getWidth;
	}
}
