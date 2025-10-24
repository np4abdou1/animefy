using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Bumptech.Glide.Request.Target;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000055 RID: 85
	[Register("com/bumptech/glide/util/ViewPreloadSizeProvider", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class ViewPreloadSizeProvider : Java.Lang.Object, ListPreloader.IPreloadSizeProvider, IJavaObject, IDisposable, IJavaPeerable, ISizeReadyCallback
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000D1C0 File Offset: 0x0000B3C0
		internal static IntPtr class_ref
		{
			get
			{
				return ViewPreloadSizeProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewPreloadSizeProvider._members;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000D1EC File Offset: 0x0000B3EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewPreloadSizeProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000D210 File Offset: 0x0000B410
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewPreloadSizeProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000D21C File Offset: 0x0000B41C
		protected ViewPreloadSizeProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000D228 File Offset: 0x0000B428
		[Register(".ctor", "()V", "")]
		public ViewPreloadSizeProvider() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ViewPreloadSizeProvider._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ViewPreloadSizeProvider._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000D298 File Offset: 0x0000B498
		[Register(".ctor", "(Landroid/view/View;)V", "")]
		public unsafe ViewPreloadSizeProvider(View view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				base.SetHandle(ViewPreloadSizeProvider._members.InstanceMethods.StartCreateInstance("(Landroid/view/View;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPreloadSizeProvider._members.InstanceMethods.FinishCreateInstance("(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000D348 File Offset: 0x0000B548
		private static Delegate GetGetPreloadSize_Ljava_lang_Object_IIHandler()
		{
			if (ViewPreloadSizeProvider.cb_getPreloadSize_Ljava_lang_Object_II == null)
			{
				ViewPreloadSizeProvider.cb_getPreloadSize_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(ViewPreloadSizeProvider.n_GetPreloadSize_Ljava_lang_Object_II));
			}
			return ViewPreloadSizeProvider.cb_getPreloadSize_Ljava_lang_Object_II;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000D36C File Offset: 0x0000B56C
		private static IntPtr n_GetPreloadSize_Ljava_lang_Object_II(IntPtr jnienv, IntPtr native__this, IntPtr native_item, int adapterPosition, int itemPosition)
		{
			ViewPreloadSizeProvider @object = Java.Lang.Object.GetObject<ViewPreloadSizeProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_item, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(@object.GetPreloadSize(object2, adapterPosition, itemPosition));
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000D398 File Offset: 0x0000B598
		[Register("getPreloadSize", "(Ljava/lang/Object;II)[I", "GetGetPreloadSize_Ljava_lang_Object_IIHandler")]
		public unsafe virtual int[] GetPreloadSize(Java.Lang.Object item, int adapterPosition, int itemPosition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(item);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(adapterPosition);
				ptr[2] = new JniArgumentValue(itemPosition);
				result = (int[])JNIEnv.GetArray(ViewPreloadSizeProvider._members.InstanceMethods.InvokeVirtualObjectMethod("getPreloadSize.(Ljava/lang/Object;II)[I", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000D444 File Offset: 0x0000B644
		private static Delegate GetOnSizeReady_IIHandler()
		{
			if (ViewPreloadSizeProvider.cb_onSizeReady_II == null)
			{
				ViewPreloadSizeProvider.cb_onSizeReady_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(ViewPreloadSizeProvider.n_OnSizeReady_II));
			}
			return ViewPreloadSizeProvider.cb_onSizeReady_II;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000D468 File Offset: 0x0000B668
		private static void n_OnSizeReady_II(IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			Java.Lang.Object.GetObject<ViewPreloadSizeProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSizeReady(width, height);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000D47C File Offset: 0x0000B67C
		[Register("onSizeReady", "(II)V", "GetOnSizeReady_IIHandler")]
		public unsafe virtual void OnSizeReady(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			ViewPreloadSizeProvider._members.InstanceMethods.InvokeVirtualVoidMethod("onSizeReady.(II)V", this, ptr);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000D4CA File Offset: 0x0000B6CA
		private static Delegate GetSetView_Landroid_view_View_Handler()
		{
			if (ViewPreloadSizeProvider.cb_setView_Landroid_view_View_ == null)
			{
				ViewPreloadSizeProvider.cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPreloadSizeProvider.n_SetView_Landroid_view_View_));
			}
			return ViewPreloadSizeProvider.cb_setView_Landroid_view_View_;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		private static void n_SetView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			ViewPreloadSizeProvider @object = Java.Lang.Object.GetObject<ViewPreloadSizeProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.SetView(object2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000D514 File Offset: 0x0000B714
		[Register("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
		public unsafe virtual void SetView(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ViewPreloadSizeProvider._members.InstanceMethods.InvokeVirtualVoidMethod("setView.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x040000CE RID: 206
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/ViewPreloadSizeProvider", typeof(ViewPreloadSizeProvider));

		// Token: 0x040000CF RID: 207
		private static Delegate cb_getPreloadSize_Ljava_lang_Object_II;

		// Token: 0x040000D0 RID: 208
		private static Delegate cb_onSizeReady_II;

		// Token: 0x040000D1 RID: 209
		private static Delegate cb_setView_Landroid_view_View_;
	}
}
