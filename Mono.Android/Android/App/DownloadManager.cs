using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x0200025F RID: 607
	[Register("android/app/DownloadManager", DoNotGenerateAcw = true)]
	public class DownloadManager : Java.Lang.Object
	{
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x0003C60F File Offset: 0x0003A80F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DownloadManager._members;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x0003C618 File Offset: 0x0003A818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DownloadManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x0003C63C File Offset: 0x0003A83C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DownloadManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x000021E0 File Offset: 0x000003E0
		protected DownloadManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0003C648 File Offset: 0x0003A848
		private static Delegate GetEnqueue_Landroid_app_DownloadManager_Request_Handler()
		{
			if (DownloadManager.cb_enqueue_Landroid_app_DownloadManager_Request_ == null)
			{
				DownloadManager.cb_enqueue_Landroid_app_DownloadManager_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(DownloadManager.n_Enqueue_Landroid_app_DownloadManager_Request_));
			}
			return DownloadManager.cb_enqueue_Landroid_app_DownloadManager_Request_;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0003C66C File Offset: 0x0003A86C
		private static long n_Enqueue_Landroid_app_DownloadManager_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			DownloadManager @object = Java.Lang.Object.GetObject<DownloadManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DownloadManager.Request object2 = Java.Lang.Object.GetObject<DownloadManager.Request>(native_request, JniHandleOwnership.DoNotTransfer);
			return @object.Enqueue(object2);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0003C690 File Offset: 0x0003A890
		public unsafe virtual long Enqueue(DownloadManager.Request request)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : request.Handle);
				result = DownloadManager._members.InstanceMethods.InvokeVirtualInt64Method("enqueue.(Landroid/app/DownloadManager$Request;)J", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x040009F9 RID: 2553
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/DownloadManager", typeof(DownloadManager));

		// Token: 0x040009FA RID: 2554
		private static Delegate cb_enqueue_Landroid_app_DownloadManager_Request_;

		// Token: 0x02000260 RID: 608
		[Register("android/app/DownloadManager$Request", DoNotGenerateAcw = true)]
		public class Request : Java.Lang.Object
		{
			// Token: 0x170004ED RID: 1261
			// (get) Token: 0x06001745 RID: 5957 RVA: 0x0003C713 File Offset: 0x0003A913
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DownloadManager.Request._members;
				}
			}

			// Token: 0x170004EE RID: 1262
			// (get) Token: 0x06001746 RID: 5958 RVA: 0x0003C71C File Offset: 0x0003A91C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DownloadManager.Request._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170004EF RID: 1263
			// (get) Token: 0x06001747 RID: 5959 RVA: 0x0003C740 File Offset: 0x0003A940
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DownloadManager.Request._members.ManagedPeerType;
				}
			}

			// Token: 0x06001748 RID: 5960 RVA: 0x000021E0 File Offset: 0x000003E0
			protected Request(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001749 RID: 5961 RVA: 0x0003C74C File Offset: 0x0003A94C
			[Register(".ctor", "(Landroid/net/Uri;)V", "")]
			public unsafe Request(Android.Net.Uri uri) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
					base.SetHandle(DownloadManager.Request._members.InstanceMethods.StartCreateInstance("(Landroid/net/Uri;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					DownloadManager.Request._members.InstanceMethods.FinishCreateInstance("(Landroid/net/Uri;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(uri);
				}
			}

			// Token: 0x0600174A RID: 5962 RVA: 0x0003C7FC File Offset: 0x0003A9FC
			private static Delegate GetAllowScanningByMediaScannerHandler()
			{
				if (DownloadManager.Request.cb_allowScanningByMediaScanner == null)
				{
					DownloadManager.Request.cb_allowScanningByMediaScanner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DownloadManager.Request.n_AllowScanningByMediaScanner));
				}
				return DownloadManager.Request.cb_allowScanningByMediaScanner;
			}

			// Token: 0x0600174B RID: 5963 RVA: 0x0003C820 File Offset: 0x0003AA20
			private static void n_AllowScanningByMediaScanner(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<DownloadManager.Request>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowScanningByMediaScanner();
			}

			// Token: 0x0600174C RID: 5964 RVA: 0x0003C82F File Offset: 0x0003AA2F
			[Register("allowScanningByMediaScanner", "()V", "GetAllowScanningByMediaScannerHandler")]
			public virtual void AllowScanningByMediaScanner()
			{
				DownloadManager.Request._members.InstanceMethods.InvokeVirtualVoidMethod("allowScanningByMediaScanner.()V", this, null);
			}

			// Token: 0x0600174D RID: 5965 RVA: 0x0003C848 File Offset: 0x0003AA48
			private static Delegate GetSetAllowedNetworkTypes_IHandler()
			{
				if (DownloadManager.Request.cb_setAllowedNetworkTypes_I == null)
				{
					DownloadManager.Request.cb_setAllowedNetworkTypes_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(DownloadManager.Request.n_SetAllowedNetworkTypes_I));
				}
				return DownloadManager.Request.cb_setAllowedNetworkTypes_I;
			}

			// Token: 0x0600174E RID: 5966 RVA: 0x0003C86C File Offset: 0x0003AA6C
			private static IntPtr n_SetAllowedNetworkTypes_I(IntPtr jnienv, IntPtr native__this, int native_flags)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DownloadManager.Request>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAllowedNetworkTypes((DownloadNetwork)native_flags));
			}

			// Token: 0x0600174F RID: 5967 RVA: 0x0003C890 File Offset: 0x0003AA90
			[Register("setAllowedNetworkTypes", "(I)Landroid/app/DownloadManager$Request;", "GetSetAllowedNetworkTypes_IHandler")]
			public unsafe virtual DownloadManager.Request SetAllowedNetworkTypes([GeneratedEnum] DownloadNetwork flags)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)flags);
				return Java.Lang.Object.GetObject<DownloadManager.Request>(DownloadManager.Request._members.InstanceMethods.InvokeVirtualObjectMethod("setAllowedNetworkTypes.(I)Landroid/app/DownloadManager$Request;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06001750 RID: 5968 RVA: 0x0003C8D9 File Offset: 0x0003AAD9
			private static Delegate GetSetDescription_Ljava_lang_CharSequence_Handler()
			{
				if (DownloadManager.Request.cb_setDescription_Ljava_lang_CharSequence_ == null)
				{
					DownloadManager.Request.cb_setDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DownloadManager.Request.n_SetDescription_Ljava_lang_CharSequence_));
				}
				return DownloadManager.Request.cb_setDescription_Ljava_lang_CharSequence_;
			}

			// Token: 0x06001751 RID: 5969 RVA: 0x0003C900 File Offset: 0x0003AB00
			private static IntPtr n_SetDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_description)
			{
				DownloadManager.Request @object = Java.Lang.Object.GetObject<DownloadManager.Request>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_description, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetDescription(object2));
			}

			// Token: 0x06001752 RID: 5970 RVA: 0x0003C928 File Offset: 0x0003AB28
			[Register("setDescription", "(Ljava/lang/CharSequence;)Landroid/app/DownloadManager$Request;", "GetSetDescription_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual DownloadManager.Request SetDescription(ICharSequence description)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(description);
				DownloadManager.Request @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<DownloadManager.Request>(DownloadManager.Request._members.InstanceMethods.InvokeVirtualObjectMethod("setDescription.(Ljava/lang/CharSequence;)Landroid/app/DownloadManager$Request;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(description);
				}
				return @object;
			}

			// Token: 0x06001753 RID: 5971 RVA: 0x0003C99C File Offset: 0x0003AB9C
			public DownloadManager.Request SetDescription(string description)
			{
				Java.Lang.String @string = (description == null) ? null : new Java.Lang.String(description);
				DownloadManager.Request result = this.SetDescription(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06001754 RID: 5972 RVA: 0x0003C9C6 File Offset: 0x0003ABC6
			private static Delegate GetSetDestinationInExternalPublicDir_Ljava_lang_String_Ljava_lang_String_Handler()
			{
				if (DownloadManager.Request.cb_setDestinationInExternalPublicDir_Ljava_lang_String_Ljava_lang_String_ == null)
				{
					DownloadManager.Request.cb_setDestinationInExternalPublicDir_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(DownloadManager.Request.n_SetDestinationInExternalPublicDir_Ljava_lang_String_Ljava_lang_String_));
				}
				return DownloadManager.Request.cb_setDestinationInExternalPublicDir_Ljava_lang_String_Ljava_lang_String_;
			}

			// Token: 0x06001755 RID: 5973 RVA: 0x0003C9EC File Offset: 0x0003ABEC
			private static IntPtr n_SetDestinationInExternalPublicDir_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_dirType, IntPtr native_subPath)
			{
				DownloadManager.Request @object = Java.Lang.Object.GetObject<DownloadManager.Request>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_dirType, JniHandleOwnership.DoNotTransfer);
				string string2 = JNIEnv.GetString(native_subPath, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetDestinationInExternalPublicDir(@string, string2));
			}

			// Token: 0x06001756 RID: 5974 RVA: 0x0003CA20 File Offset: 0x0003AC20
			[Register("setDestinationInExternalPublicDir", "(Ljava/lang/String;Ljava/lang/String;)Landroid/app/DownloadManager$Request;", "GetSetDestinationInExternalPublicDir_Ljava_lang_String_Ljava_lang_String_Handler")]
			public unsafe virtual DownloadManager.Request SetDestinationInExternalPublicDir(string dirType, string subPath)
			{
				IntPtr intPtr = JNIEnv.NewString(dirType);
				IntPtr intPtr2 = JNIEnv.NewString(subPath);
				DownloadManager.Request @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(intPtr2);
					@object = Java.Lang.Object.GetObject<DownloadManager.Request>(DownloadManager.Request._members.InstanceMethods.InvokeVirtualObjectMethod("setDestinationInExternalPublicDir.(Ljava/lang/String;Ljava/lang/String;)Landroid/app/DownloadManager$Request;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				return @object;
			}

			// Token: 0x06001757 RID: 5975 RVA: 0x0003CAB0 File Offset: 0x0003ACB0
			private static Delegate GetSetNotificationVisibility_IHandler()
			{
				if (DownloadManager.Request.cb_setNotificationVisibility_I == null)
				{
					DownloadManager.Request.cb_setNotificationVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(DownloadManager.Request.n_SetNotificationVisibility_I));
				}
				return DownloadManager.Request.cb_setNotificationVisibility_I;
			}

			// Token: 0x06001758 RID: 5976 RVA: 0x0003CAD4 File Offset: 0x0003ACD4
			private static IntPtr n_SetNotificationVisibility_I(IntPtr jnienv, IntPtr native__this, int native_visibility)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DownloadManager.Request>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNotificationVisibility((DownloadVisibility)native_visibility));
			}

			// Token: 0x06001759 RID: 5977 RVA: 0x0003CAF8 File Offset: 0x0003ACF8
			[Register("setNotificationVisibility", "(I)Landroid/app/DownloadManager$Request;", "GetSetNotificationVisibility_IHandler")]
			public unsafe virtual DownloadManager.Request SetNotificationVisibility([GeneratedEnum] DownloadVisibility visibility)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)visibility);
				return Java.Lang.Object.GetObject<DownloadManager.Request>(DownloadManager.Request._members.InstanceMethods.InvokeVirtualObjectMethod("setNotificationVisibility.(I)Landroid/app/DownloadManager$Request;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600175A RID: 5978 RVA: 0x0003CB41 File Offset: 0x0003AD41
			private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
			{
				if (DownloadManager.Request.cb_setTitle_Ljava_lang_CharSequence_ == null)
				{
					DownloadManager.Request.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DownloadManager.Request.n_SetTitle_Ljava_lang_CharSequence_));
				}
				return DownloadManager.Request.cb_setTitle_Ljava_lang_CharSequence_;
			}

			// Token: 0x0600175B RID: 5979 RVA: 0x0003CB68 File Offset: 0x0003AD68
			private static IntPtr n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
			{
				DownloadManager.Request @object = Java.Lang.Object.GetObject<DownloadManager.Request>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTitle(object2));
			}

			// Token: 0x0600175C RID: 5980 RVA: 0x0003CB90 File Offset: 0x0003AD90
			[Register("setTitle", "(Ljava/lang/CharSequence;)Landroid/app/DownloadManager$Request;", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual DownloadManager.Request SetTitle(ICharSequence title)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				DownloadManager.Request @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<DownloadManager.Request>(DownloadManager.Request._members.InstanceMethods.InvokeVirtualObjectMethod("setTitle.(Ljava/lang/CharSequence;)Landroid/app/DownloadManager$Request;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(title);
				}
				return @object;
			}

			// Token: 0x0600175D RID: 5981 RVA: 0x0003CC04 File Offset: 0x0003AE04
			public DownloadManager.Request SetTitle(string title)
			{
				Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
				DownloadManager.Request result = this.SetTitle(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x0600175E RID: 5982 RVA: 0x0003CC2E File Offset: 0x0003AE2E
			private static Delegate GetSetVisibleInDownloadsUi_ZHandler()
			{
				if (DownloadManager.Request.cb_setVisibleInDownloadsUi_Z == null)
				{
					DownloadManager.Request.cb_setVisibleInDownloadsUi_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(DownloadManager.Request.n_SetVisibleInDownloadsUi_Z));
				}
				return DownloadManager.Request.cb_setVisibleInDownloadsUi_Z;
			}

			// Token: 0x0600175F RID: 5983 RVA: 0x0003CC52 File Offset: 0x0003AE52
			private static IntPtr n_SetVisibleInDownloadsUi_Z(IntPtr jnienv, IntPtr native__this, bool isVisible)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DownloadManager.Request>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVisibleInDownloadsUi(isVisible));
			}

			// Token: 0x06001760 RID: 5984 RVA: 0x0003CC68 File Offset: 0x0003AE68
			[Register("setVisibleInDownloadsUi", "(Z)Landroid/app/DownloadManager$Request;", "GetSetVisibleInDownloadsUi_ZHandler")]
			public unsafe virtual DownloadManager.Request SetVisibleInDownloadsUi(bool isVisible)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(isVisible);
				return Java.Lang.Object.GetObject<DownloadManager.Request>(DownloadManager.Request._members.InstanceMethods.InvokeVirtualObjectMethod("setVisibleInDownloadsUi.(Z)Landroid/app/DownloadManager$Request;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040009FB RID: 2555
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/DownloadManager$Request", typeof(DownloadManager.Request));

			// Token: 0x040009FC RID: 2556
			private static Delegate cb_allowScanningByMediaScanner;

			// Token: 0x040009FD RID: 2557
			private static Delegate cb_setAllowedNetworkTypes_I;

			// Token: 0x040009FE RID: 2558
			private static Delegate cb_setDescription_Ljava_lang_CharSequence_;

			// Token: 0x040009FF RID: 2559
			private static Delegate cb_setDestinationInExternalPublicDir_Ljava_lang_String_Ljava_lang_String_;

			// Token: 0x04000A00 RID: 2560
			private static Delegate cb_setNotificationVisibility_I;

			// Token: 0x04000A01 RID: 2561
			private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

			// Token: 0x04000A02 RID: 2562
			private static Delegate cb_setVisibleInDownloadsUi_Z;
		}
	}
}
