using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Net;
using Java.Nio.Charset;
using Java.Security;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000131 RID: 305
	[Register("com/bumptech/glide/load/model/GlideUrl", DoNotGenerateAcw = true)]
	public class GlideUrl : Java.Lang.Object, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x000324D0 File Offset: 0x000306D0
		internal static IntPtr class_ref
		{
			get
			{
				return GlideUrl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x000324F4 File Offset: 0x000306F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlideUrl._members;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x000324FC File Offset: 0x000306FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlideUrl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00032520 File Offset: 0x00030720
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlideUrl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0003252C File Offset: 0x0003072C
		protected GlideUrl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00032538 File Offset: 0x00030738
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GlideUrl(string url) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(GlideUrl._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GlideUrl._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000325DC File Offset: 0x000307DC
		[Register(".ctor", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/Headers;)V", "")]
		public unsafe GlideUrl(string url, IHeaders headers) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((headers == null) ? IntPtr.Zero : ((Java.Lang.Object)headers).Handle);
				base.SetHandle(GlideUrl._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/bumptech/glide/load/model/Headers;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GlideUrl._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/bumptech/glide/load/model/Headers;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(headers);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000326B0 File Offset: 0x000308B0
		[Register(".ctor", "(Ljava/net/URL;)V", "")]
		public unsafe GlideUrl(URL url) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((url == null) ? IntPtr.Zero : url.Handle);
				base.SetHandle(GlideUrl._members.InstanceMethods.StartCreateInstance("(Ljava/net/URL;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GlideUrl._members.InstanceMethods.FinishCreateInstance("(Ljava/net/URL;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(url);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00032760 File Offset: 0x00030960
		[Register(".ctor", "(Ljava/net/URL;Lcom/bumptech/glide/load/model/Headers;)V", "")]
		public unsafe GlideUrl(URL url, IHeaders headers) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((url == null) ? IntPtr.Zero : url.Handle);
				ptr[1] = new JniArgumentValue((headers == null) ? IntPtr.Zero : ((Java.Lang.Object)headers).Handle);
				base.SetHandle(GlideUrl._members.InstanceMethods.StartCreateInstance("(Ljava/net/URL;Lcom/bumptech/glide/load/model/Headers;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GlideUrl._members.InstanceMethods.FinishCreateInstance("(Ljava/net/URL;Lcom/bumptech/glide/load/model/Headers;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(url);
				GC.KeepAlive(headers);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0003283C File Offset: 0x00030A3C
		private static Delegate GetGetCacheKeyHandler()
		{
			if (GlideUrl.cb_getCacheKey == null)
			{
				GlideUrl.cb_getCacheKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideUrl.n_GetCacheKey));
			}
			return GlideUrl.cb_getCacheKey;
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00032860 File Offset: 0x00030A60
		private static IntPtr n_GetCacheKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GlideUrl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CacheKey);
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00032874 File Offset: 0x00030A74
		public virtual string CacheKey
		{
			[Register("getCacheKey", "()Ljava/lang/String;", "GetGetCacheKeyHandler")]
			get
			{
				return JNIEnv.GetString(GlideUrl._members.InstanceMethods.InvokeVirtualObjectMethod("getCacheKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000328A6 File Offset: 0x00030AA6
		private static Delegate GetGetHeadersHandler()
		{
			if (GlideUrl.cb_getHeaders == null)
			{
				GlideUrl.cb_getHeaders = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideUrl.n_GetHeaders));
			}
			return GlideUrl.cb_getHeaders;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x000328CA File Offset: 0x00030ACA
		private static IntPtr n_GetHeaders(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideUrl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Headers);
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x000328E0 File Offset: 0x00030AE0
		public virtual IDictionary<string, string> Headers
		{
			[Register("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(GlideUrl._members.InstanceMethods.InvokeVirtualObjectMethod("getHeaders.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00032912 File Offset: 0x00030B12
		private static Delegate GetToStringUrlHandler()
		{
			if (GlideUrl.cb_toStringUrl == null)
			{
				GlideUrl.cb_toStringUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideUrl.n_ToStringUrl));
			}
			return GlideUrl.cb_toStringUrl;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00032936 File Offset: 0x00030B36
		private static IntPtr n_ToStringUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GlideUrl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToStringUrl());
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0003294C File Offset: 0x00030B4C
		[Register("toStringUrl", "()Ljava/lang/String;", "GetToStringUrlHandler")]
		public virtual string ToStringUrl()
		{
			return JNIEnv.GetString(GlideUrl._members.InstanceMethods.InvokeVirtualObjectMethod("toStringUrl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0003297E File Offset: 0x00030B7E
		private static Delegate GetToURLHandler()
		{
			if (GlideUrl.cb_toURL == null)
			{
				GlideUrl.cb_toURL = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideUrl.n_ToURL));
			}
			return GlideUrl.cb_toURL;
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000329A2 File Offset: 0x00030BA2
		private static IntPtr n_ToURL(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideUrl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToURL());
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000329B8 File Offset: 0x00030BB8
		[Register("toURL", "()Ljava/net/URL;", "GetToURLHandler")]
		public virtual URL ToURL()
		{
			return Java.Lang.Object.GetObject<URL>(GlideUrl._members.InstanceMethods.InvokeVirtualObjectMethod("toURL.()Ljava/net/URL;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000329EA File Offset: 0x00030BEA
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (GlideUrl.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				GlideUrl.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GlideUrl.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return GlideUrl.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00032A10 File Offset: 0x00030C10
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			GlideUrl @object = Java.Lang.Object.GetObject<GlideUrl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00032A34 File Offset: 0x00030C34
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe virtual void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				GlideUrl._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x04000396 RID: 918
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/GlideUrl", typeof(GlideUrl));

		// Token: 0x04000397 RID: 919
		private static Delegate cb_getCacheKey;

		// Token: 0x04000398 RID: 920
		private static Delegate cb_getHeaders;

		// Token: 0x04000399 RID: 921
		private static Delegate cb_toStringUrl;

		// Token: 0x0400039A RID: 922
		private static Delegate cb_toURL;

		// Token: 0x0400039B RID: 923
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;

		// Token: 0x020001EB RID: 491
		public static class InterfaceConsts
		{
			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x06001766 RID: 5990 RVA: 0x00048854 File Offset: 0x00046A54
			[Register("CHARSET")]
			public static Charset Charset
			{
				get
				{
					return Java.Lang.Object.GetObject<Charset>(GlideUrl._members.StaticFields.GetObjectValue("CHARSET.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x04000599 RID: 1433
			[Register("STRING_CHARSET_NAME")]
			public const string StringCharsetName = "UTF-8";
		}
	}
}
