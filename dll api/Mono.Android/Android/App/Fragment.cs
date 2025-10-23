using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x02000261 RID: 609
	[Register("android/app/Fragment", DoNotGenerateAcw = true)]
	public class Fragment : Java.Lang.Object, IComponentCallbacks2, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable, View.IOnCreateContextMenuListener
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0003CCCC File Offset: 0x0003AECC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Fragment._members;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0003CCD4 File Offset: 0x0003AED4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Fragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x0003CCF8 File Offset: 0x0003AEF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Fragment._members.ManagedPeerType;
			}
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Fragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0003CD04 File Offset: 0x0003AF04
		public unsafe sealed override bool Equals(Java.Lang.Object o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				result = Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0003CD6C File Offset: 0x0003AF6C
		public sealed override int GetHashCode()
		{
			return Fragment._members.InstanceMethods.InvokeNonvirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0003CD85 File Offset: 0x0003AF85
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (Fragment.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				Fragment.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return Fragment.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0003CDAC File Offset: 0x0003AFAC
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0003CDD0 File Offset: 0x0003AFD0
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0003CE34 File Offset: 0x0003B034
		private static Delegate GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler()
		{
			if (Fragment.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ == null)
			{
				Fragment.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Fragment.n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_));
			}
			return Fragment.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0003CE58 File Offset: 0x0003B058
		private static void n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu, IntPtr native_v, IntPtr native_menuInfo)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContextMenu object2 = Java.Lang.Object.GetObject<IContextMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			IContextMenuContextMenuInfo object4 = Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(native_menuInfo, JniHandleOwnership.DoNotTransfer);
			@object.OnCreateContextMenu(object2, object3, object4);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0003CE90 File Offset: 0x0003B090
		public unsafe virtual void OnCreateContextMenu(IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				ptr[1] = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[2] = new JniArgumentValue((menuInfo == null) ? IntPtr.Zero : ((Java.Lang.Object)menuInfo).Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onCreateContextMenu.(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
				GC.KeepAlive(v);
				GC.KeepAlive(menuInfo);
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0003CF50 File Offset: 0x0003B150
		private static Delegate GetOnLowMemoryHandler()
		{
			if (Fragment.cb_onLowMemory == null)
			{
				Fragment.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnLowMemory));
			}
			return Fragment.cb_onLowMemory;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0003CF74 File Offset: 0x0003B174
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0003CF83 File Offset: 0x0003B183
		public virtual void OnLowMemory()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onLowMemory.()V", this, null);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0003CF9C File Offset: 0x0003B19C
		private static Delegate GetOnTrimMemory_IHandler()
		{
			if (Fragment.cb_onTrimMemory_I == null)
			{
				Fragment.cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Fragment.n_OnTrimMemory_I));
			}
			return Fragment.cb_onTrimMemory_I;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0003CFC0 File Offset: 0x0003B1C0
		private static void n_OnTrimMemory_I(IntPtr jnienv, IntPtr native__this, int native_level)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTrimMemory((TrimMemory)native_level);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0003CFE0 File Offset: 0x0003B1E0
		public unsafe virtual void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)level);
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onTrimMemory.(I)V", this, ptr);
		}

		// Token: 0x04000A03 RID: 2563
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Fragment", typeof(Fragment));

		// Token: 0x04000A04 RID: 2564
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000A05 RID: 2565
		private static Delegate cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;

		// Token: 0x04000A06 RID: 2566
		private static Delegate cb_onLowMemory;

		// Token: 0x04000A07 RID: 2567
		private static Delegate cb_onTrimMemory_I;
	}
}
