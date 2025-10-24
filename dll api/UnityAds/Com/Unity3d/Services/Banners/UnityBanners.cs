using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Unity3d.Services.Banners.View;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001AC RID: 428
	[Register("com/unity3d/services/banners/UnityBanners", DoNotGenerateAcw = true)]
	public sealed class UnityBanners : Java.Lang.Object
	{
		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00036E30 File Offset: 0x00035030
		internal static IntPtr class_ref
		{
			get
			{
				return UnityBanners._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00036E54 File Offset: 0x00035054
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityBanners._members;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00036E5C File Offset: 0x0003505C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityBanners._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00036E80 File Offset: 0x00035080
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityBanners._members.ManagedPeerType;
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000021E8 File Offset: 0x000003E8
		internal UnityBanners(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00036E8C File Offset: 0x0003508C
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x00036EC0 File Offset: 0x000350C0
		[Obsolete("deprecated")]
		public unsafe static IUnityBannerListener BannerListener
		{
			[Register("getBannerListener", "()Lcom/unity3d/services/banners/IUnityBannerListener;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IUnityBannerListener>(UnityBanners._members.StaticMethods.InvokeObjectMethod("getBannerListener.()Lcom/unity3d/services/banners/IUnityBannerListener;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setBannerListener", "(Lcom/unity3d/services/banners/IUnityBannerListener;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					UnityBanners._members.StaticMethods.InvokeVoidMethod("setBannerListener.(Lcom/unity3d/services/banners/IUnityBannerListener;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00036F28 File Offset: 0x00035128
		[Obsolete("deprecated")]
		[Register("destroy", "()V", "")]
		public static void Destroy()
		{
			UnityBanners._members.StaticMethods.InvokeVoidMethod("destroy.()V", null);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00036F40 File Offset: 0x00035140
		[Obsolete("deprecated")]
		[Register("loadBanner", "(Landroid/app/Activity;Ljava/lang/String;)V", "")]
		public unsafe static void LoadBanner(Activity activity, string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				UnityBanners._members.StaticMethods.InvokeVoidMethod("loadBanner.(Landroid/app/Activity;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00036FC4 File Offset: 0x000351C4
		[Obsolete("deprecated")]
		[Register("setBannerPosition", "(Lcom/unity3d/services/banners/view/BannerPosition;)V", "")]
		public unsafe static void SetBannerPosition(BannerPosition position)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((position == null) ? IntPtr.Zero : position.Handle);
				UnityBanners._members.StaticMethods.InvokeVoidMethod("setBannerPosition.(Lcom/unity3d/services/banners/view/BannerPosition;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(position);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06001365 RID: 4965 RVA: 0x00037028 File Offset: 0x00035228
		// (remove) Token: 0x06001366 RID: 4966 RVA: 0x00037084 File Offset: 0x00035284
		public event EventHandler<UnityBannerClickEventArgs> UnityBannerClick
		{
			add
			{
				EventHelper.AddEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor>(this.__CreateIUnityBannerListenerImplementor), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = __v;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerClickHandler = (EventHandler<UnityBannerClickEventArgs>)Delegate.Combine(__h.OnUnityBannerClickHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor, bool>(IUnityBannerListenerImplementor.__IsEmpty), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = null;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerClickHandler = (EventHandler<UnityBannerClickEventArgs>)Delegate.Remove(__h.OnUnityBannerClickHandler, value);
				});
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06001367 RID: 4967 RVA: 0x000370E0 File Offset: 0x000352E0
		// (remove) Token: 0x06001368 RID: 4968 RVA: 0x0003713C File Offset: 0x0003533C
		public event EventHandler<UnityBannerErrorEventArgs> UnityBannerError
		{
			add
			{
				EventHelper.AddEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor>(this.__CreateIUnityBannerListenerImplementor), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = __v;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerErrorHandler = (EventHandler<UnityBannerErrorEventArgs>)Delegate.Combine(__h.OnUnityBannerErrorHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor, bool>(IUnityBannerListenerImplementor.__IsEmpty), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = null;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerErrorHandler = (EventHandler<UnityBannerErrorEventArgs>)Delegate.Remove(__h.OnUnityBannerErrorHandler, value);
				});
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06001369 RID: 4969 RVA: 0x00037198 File Offset: 0x00035398
		// (remove) Token: 0x0600136A RID: 4970 RVA: 0x000371F4 File Offset: 0x000353F4
		public event EventHandler<UnityBannerHideEventArgs> UnityBannerHide
		{
			add
			{
				EventHelper.AddEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor>(this.__CreateIUnityBannerListenerImplementor), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = __v;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerHideHandler = (EventHandler<UnityBannerHideEventArgs>)Delegate.Combine(__h.OnUnityBannerHideHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor, bool>(IUnityBannerListenerImplementor.__IsEmpty), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = null;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerHideHandler = (EventHandler<UnityBannerHideEventArgs>)Delegate.Remove(__h.OnUnityBannerHideHandler, value);
				});
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600136B RID: 4971 RVA: 0x00037250 File Offset: 0x00035450
		// (remove) Token: 0x0600136C RID: 4972 RVA: 0x000372AC File Offset: 0x000354AC
		public event EventHandler<UnityBannerLoadedEventArgs> UnityBannerLoaded
		{
			add
			{
				EventHelper.AddEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor>(this.__CreateIUnityBannerListenerImplementor), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = __v;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerLoadedHandler = (EventHandler<UnityBannerLoadedEventArgs>)Delegate.Combine(__h.OnUnityBannerLoadedHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor, bool>(IUnityBannerListenerImplementor.__IsEmpty), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = null;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerLoadedHandler = (EventHandler<UnityBannerLoadedEventArgs>)Delegate.Remove(__h.OnUnityBannerLoadedHandler, value);
				});
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600136D RID: 4973 RVA: 0x00037308 File Offset: 0x00035508
		// (remove) Token: 0x0600136E RID: 4974 RVA: 0x00037364 File Offset: 0x00035564
		public event EventHandler<UnityBannerShowEventArgs> UnityBannerShow
		{
			add
			{
				EventHelper.AddEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor>(this.__CreateIUnityBannerListenerImplementor), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = __v;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerShowHandler = (EventHandler<UnityBannerShowEventArgs>)Delegate.Combine(__h.OnUnityBannerShowHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor, bool>(IUnityBannerListenerImplementor.__IsEmpty), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = null;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerShowHandler = (EventHandler<UnityBannerShowEventArgs>)Delegate.Remove(__h.OnUnityBannerShowHandler, value);
				});
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600136F RID: 4975 RVA: 0x000373C0 File Offset: 0x000355C0
		// (remove) Token: 0x06001370 RID: 4976 RVA: 0x0003741C File Offset: 0x0003561C
		public event EventHandler<UnityBannerUnloadedEventArgs> UnityBannerUnloaded
		{
			add
			{
				EventHelper.AddEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor>(this.__CreateIUnityBannerListenerImplementor), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = __v;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerUnloadedHandler = (EventHandler<UnityBannerUnloadedEventArgs>)Delegate.Combine(__h.OnUnityBannerUnloadedHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IUnityBannerListener, IUnityBannerListenerImplementor>(ref this.weak_implementor___SetBannerListener, new Func<IUnityBannerListenerImplementor, bool>(IUnityBannerListenerImplementor.__IsEmpty), delegate(IUnityBannerListener __v)
				{
					UnityBanners.BannerListener = null;
				}, delegate(IUnityBannerListenerImplementor __h)
				{
					__h.OnUnityBannerUnloadedHandler = (EventHandler<UnityBannerUnloadedEventArgs>)Delegate.Remove(__h.OnUnityBannerUnloadedHandler, value);
				});
			}
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00037478 File Offset: 0x00035678
		private IUnityBannerListenerImplementor __CreateIUnityBannerListenerImplementor()
		{
			return new IUnityBannerListenerImplementor(this);
		}

		// Token: 0x040004A1 RID: 1185
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/UnityBanners", typeof(UnityBanners));

		// Token: 0x040004A2 RID: 1186
		private WeakReference weak_implementor___SetBannerListener;
	}
}
