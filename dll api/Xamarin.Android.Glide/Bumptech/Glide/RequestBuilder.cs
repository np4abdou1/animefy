using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Net;
using Android.Runtime;
using Android.Widget;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Resource.Bitmap;
using Bumptech.Glide.Request;
using Bumptech.Glide.Request.Target;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Net;

namespace Bumptech.Glide
{
	// Token: 0x02000035 RID: 53
	[Register("com/bumptech/glide/RequestBuilder", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"TranscodeType"
	})]
	public class RequestBuilder : BaseRequestOptions, Java.Lang.ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000DC RID: 220 RVA: 0x000030A7 File Offset: 0x000012A7
		public virtual RequestBuilder Apply(BaseRequestOptions o)
		{
			return (RequestBuilder)this.Apply_T(o);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000030B5 File Offset: 0x000012B5
		public virtual RequestBuilder AutoClone()
		{
			return (RequestBuilder)this.AutoClone_T();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000030C2 File Offset: 0x000012C2
		public virtual RequestBuilder CenterCrop()
		{
			return (RequestBuilder)this.CenterCrop_T();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000030CF File Offset: 0x000012CF
		public virtual RequestBuilder CenterInside()
		{
			return (RequestBuilder)this.CenterInside_T();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000030DC File Offset: 0x000012DC
		public virtual RequestBuilder CircleCrop()
		{
			return (RequestBuilder)this.CircleCrop_T();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000030E9 File Offset: 0x000012E9
		public virtual RequestBuilder Clone()
		{
			return (RequestBuilder)this.Clone_T();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000030F6 File Offset: 0x000012F6
		public virtual RequestBuilder Decode(Class resourceClass)
		{
			return (RequestBuilder)this.Decode_T(resourceClass);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003104 File Offset: 0x00001304
		public virtual RequestBuilder DisallowHardwareConfig()
		{
			return (RequestBuilder)this.DisallowHardwareConfig_T();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003111 File Offset: 0x00001311
		public virtual RequestBuilder Downsample(DownsampleStrategy strategy)
		{
			return (RequestBuilder)this.Downsample_T(strategy);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000311F File Offset: 0x0000131F
		public virtual RequestBuilder DontAnimate()
		{
			return (RequestBuilder)this.DontAnimate_T();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000312C File Offset: 0x0000132C
		public virtual RequestBuilder DontTransform()
		{
			return (RequestBuilder)this.DontTransform_T();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003139 File Offset: 0x00001339
		public virtual RequestBuilder EncodeFormat(Bitmap.CompressFormat format)
		{
			return (RequestBuilder)this.EncodeFormat_T(format);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003147 File Offset: 0x00001347
		public virtual RequestBuilder EncodeQuality(int quality)
		{
			return (RequestBuilder)this.EncodeQuality_T(quality);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003155 File Offset: 0x00001355
		public virtual RequestBuilder Error(Drawable drawable)
		{
			return (RequestBuilder)this.Error_T(drawable);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003163 File Offset: 0x00001363
		public virtual RequestBuilder Error(int resourceId)
		{
			return (RequestBuilder)this.Error_T(resourceId);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003171 File Offset: 0x00001371
		public virtual RequestBuilder Fallback(Drawable drawable)
		{
			return (RequestBuilder)this.Fallback_T(drawable);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000317F File Offset: 0x0000137F
		public virtual RequestBuilder Fallback(int resourceId)
		{
			return (RequestBuilder)this.Fallback_T(resourceId);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000318D File Offset: 0x0000138D
		public virtual RequestBuilder FitCenter()
		{
			return (RequestBuilder)this.FitCenter_T();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000319A File Offset: 0x0000139A
		public virtual RequestBuilder Format(DecodeFormat format)
		{
			return (RequestBuilder)this.Format_T(format);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000031A8 File Offset: 0x000013A8
		public virtual RequestBuilder Frame(long frameTimeMicros)
		{
			return (RequestBuilder)this.Frame_T(frameTimeMicros);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000031B6 File Offset: 0x000013B6
		public virtual RequestBuilder Lock()
		{
			return (RequestBuilder)this.Lock_T();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000031C3 File Offset: 0x000013C3
		public virtual RequestBuilder OptionalCenterCrop()
		{
			return (RequestBuilder)this.OptionalCenterCrop_T();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000031D0 File Offset: 0x000013D0
		public virtual RequestBuilder OptionalCenterInside()
		{
			return (RequestBuilder)this.OptionalCenterInside_T();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000031DD File Offset: 0x000013DD
		public virtual RequestBuilder OptionalCircleCrop()
		{
			return (RequestBuilder)this.OptionalCircleCrop_T();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000031EA File Offset: 0x000013EA
		public virtual RequestBuilder OptionalFitCenter()
		{
			return (RequestBuilder)this.OptionalFitCenter_T();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000031F7 File Offset: 0x000013F7
		public virtual RequestBuilder OptionalTransform(Class resourceClass, ITransformation transformation)
		{
			return (RequestBuilder)this.OptionalTransform_T(resourceClass, transformation);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003206 File Offset: 0x00001406
		public virtual RequestBuilder OptionalTransform(ITransformation transformation)
		{
			return (RequestBuilder)this.OptionalTransform_T(transformation);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003214 File Offset: 0x00001414
		public virtual RequestBuilder Override(int width, int height)
		{
			return (RequestBuilder)this.Override_T(width, height);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003223 File Offset: 0x00001423
		public virtual RequestBuilder Override(int size)
		{
			return (RequestBuilder)this.Override_T(size);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003231 File Offset: 0x00001431
		public virtual RequestBuilder Placeholder(Drawable drawable)
		{
			return (RequestBuilder)this.Placeholder_T(drawable);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000323F File Offset: 0x0000143F
		public virtual RequestBuilder Placeholder(int resourceId)
		{
			return (RequestBuilder)this.Placeholder_T(resourceId);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000324D File Offset: 0x0000144D
		public virtual RequestBuilder Set(Option option, Java.Lang.Object value)
		{
			return (RequestBuilder)this.Set_T(option, value);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000325C File Offset: 0x0000145C
		public virtual RequestBuilder SetDiskCacheStrategy(DiskCacheStrategy strategy)
		{
			return (RequestBuilder)this.DiskCacheStrategy_T(strategy);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000326A File Offset: 0x0000146A
		public virtual RequestBuilder SetOnlyRetrieveFromCache(bool flag)
		{
			return (RequestBuilder)this.OnlyRetrieveFromCache_T(flag);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003278 File Offset: 0x00001478
		public virtual RequestBuilder SetPriority(Priority priority)
		{
			return (RequestBuilder)this.Priority_T(priority);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003286 File Offset: 0x00001486
		public virtual RequestBuilder SetSignature(IKey signature)
		{
			return (RequestBuilder)this.Signature_T(signature);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003294 File Offset: 0x00001494
		public virtual RequestBuilder SetSizeMultiplier(float sizeMultiplier)
		{
			return (RequestBuilder)this.SizeMultiplier_T(sizeMultiplier);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000032A2 File Offset: 0x000014A2
		public virtual RequestBuilder SetTheme(Resources.Theme theme)
		{
			return (RequestBuilder)this.Theme_T(theme);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000032B0 File Offset: 0x000014B0
		public virtual RequestBuilder SetUseAnimationPool(bool flag)
		{
			return (RequestBuilder)this.UseAnimationPool_T(flag);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000032BE File Offset: 0x000014BE
		public virtual RequestBuilder SetUseUnlimitedSourceGeneratorsPool(bool flag)
		{
			return (RequestBuilder)this.UseUnlimitedSourceGeneratorsPool_T(flag);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000032CC File Offset: 0x000014CC
		public virtual RequestBuilder SkipMemoryCache(bool skip)
		{
			return (RequestBuilder)this.SkipMemoryCache_T(skip);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000032DA File Offset: 0x000014DA
		public virtual RequestBuilder Timeout(int timeoutMs)
		{
			return (RequestBuilder)this.Timeout_T(timeoutMs);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000032E8 File Offset: 0x000014E8
		public virtual RequestBuilder Transform(Class resourceClass, ITransformation transformation)
		{
			return (RequestBuilder)this.Transform_T(resourceClass, transformation);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000032F7 File Offset: 0x000014F7
		public virtual RequestBuilder Transform(params ITransformation[] transformations)
		{
			return (RequestBuilder)this.Transform_T(transformations);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003305 File Offset: 0x00001505
		public virtual RequestBuilder Transform(ITransformation transformation)
		{
			return (RequestBuilder)this.Transform_T(transformation);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00003314 File Offset: 0x00001514
		[Register("DOWNLOAD_ONLY_OPTIONS")]
		protected static RequestOptions DownloadOnlyOptions
		{
			get
			{
				return Java.Lang.Object.GetObject<RequestOptions>(RequestBuilder._members.StaticFields.GetObjectValue("DOWNLOAD_ONLY_OPTIONS.Lcom/bumptech/glide/request/RequestOptions;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00003344 File Offset: 0x00001544
		internal new static IntPtr class_ref
		{
			get
			{
				return RequestBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00003368 File Offset: 0x00001568
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestBuilder._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00003370 File Offset: 0x00001570
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00003394 File Offset: 0x00001594
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000033A0 File Offset: 0x000015A0
		protected RequestBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000033AC File Offset: 0x000015AC
		[Register(".ctor", "(Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/RequestManager;Ljava/lang/Class;Landroid/content/Context;)V", "")]
		protected unsafe RequestBuilder(Glide glide, RequestManager requestManager, Class transcodeClass, Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((glide == null) ? IntPtr.Zero : glide.Handle);
				ptr[1] = new JniArgumentValue((requestManager == null) ? IntPtr.Zero : requestManager.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[3] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(RequestBuilder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/RequestManager;Ljava/lang/Class;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RequestBuilder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/RequestManager;Ljava/lang/Class;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(glide);
				GC.KeepAlive(requestManager);
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000034DC File Offset: 0x000016DC
		[Register(".ctor", "(Ljava/lang/Class;Lcom/bumptech/glide/RequestBuilder;)V", "")]
		protected unsafe RequestBuilder(Class transcodeClass, RequestBuilder other) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				base.SetHandle(RequestBuilder._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Lcom/bumptech/glide/RequestBuilder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RequestBuilder._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Lcom/bumptech/glide/RequestBuilder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(other);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000035B4 File Offset: 0x000017B4
		private static Delegate GetGetDownloadOnlyRequestHandler()
		{
			if (RequestBuilder.cb_getDownloadOnlyRequest == null)
			{
				RequestBuilder.cb_getDownloadOnlyRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestBuilder.n_GetDownloadOnlyRequest));
			}
			return RequestBuilder.cb_getDownloadOnlyRequest;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000035D8 File Offset: 0x000017D8
		private static IntPtr n_GetDownloadOnlyRequest(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DownloadOnlyRequest);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000035EC File Offset: 0x000017EC
		protected virtual RequestBuilder DownloadOnlyRequest
		{
			[Register("getDownloadOnlyRequest", "()Lcom/bumptech/glide/RequestBuilder;", "GetGetDownloadOnlyRequestHandler")]
			get
			{
				return Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getDownloadOnlyRequest.()Lcom/bumptech/glide/RequestBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000361E File Offset: 0x0000181E
		private static Delegate GetAddListener_Lcom_bumptech_glide_request_RequestListener_Handler()
		{
			if (RequestBuilder.cb_addListener_Lcom_bumptech_glide_request_RequestListener_ == null)
			{
				RequestBuilder.cb_addListener_Lcom_bumptech_glide_request_RequestListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_AddListener_Lcom_bumptech_glide_request_RequestListener_));
			}
			return RequestBuilder.cb_addListener_Lcom_bumptech_glide_request_RequestListener_;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003644 File Offset: 0x00001844
		private static IntPtr n_AddListener_Lcom_bumptech_glide_request_RequestListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestListener)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequestListener object2 = Java.Lang.Object.GetObject<IRequestListener>(native_requestListener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddListener(object2));
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000366C File Offset: 0x0000186C
		[Register("addListener", "(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/RequestBuilder;", "GetAddListener_Lcom_bumptech_glide_request_RequestListener_Handler")]
		public unsafe virtual RequestBuilder AddListener(IRequestListener requestListener)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestListener == null) ? IntPtr.Zero : ((Java.Lang.Object)requestListener).Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("addListener.(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(requestListener);
			}
			return @object;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000036E4 File Offset: 0x000018E4
		[Obsolete]
		private static Delegate GetDownloadOnly_IIHandler()
		{
			if (RequestBuilder.cb_downloadOnly_II == null)
			{
				RequestBuilder.cb_downloadOnly_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(RequestBuilder.n_DownloadOnly_II));
			}
			return RequestBuilder.cb_downloadOnly_II;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00003708 File Offset: 0x00001908
		[Obsolete]
		private static IntPtr n_DownloadOnly_II(IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DownloadOnly(width, height));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003720 File Offset: 0x00001920
		[Obsolete("deprecated")]
		[Register("downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;", "GetDownloadOnly_IIHandler")]
		public unsafe virtual IFutureTarget DownloadOnly(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			return Java.Lang.Object.GetObject<IFutureTarget>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("downloadOnly.(II)Lcom/bumptech/glide/request/FutureTarget;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000377C File Offset: 0x0000197C
		[Obsolete]
		private static Delegate GetDownloadOnly_Lcom_bumptech_glide_request_target_Target_Handler()
		{
			if (RequestBuilder.cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_ == null)
			{
				RequestBuilder.cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_DownloadOnly_Lcom_bumptech_glide_request_target_Target_));
			}
			return RequestBuilder.cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000037A0 File Offset: 0x000019A0
		[Obsolete]
		private static IntPtr n_DownloadOnly_Lcom_bumptech_glide_request_target_Target_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_target, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DownloadOnly(object2));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000037C8 File Offset: 0x000019C8
		[Obsolete("deprecated")]
		[Register("downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;", "GetDownloadOnly_Lcom_bumptech_glide_request_target_Target_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Y extends com.bumptech.glide.request.target.Target<java.io.File>"
		})]
		public unsafe virtual Java.Lang.Object DownloadOnly(Java.Lang.Object target)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(target);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("downloadOnly.(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(target);
			}
			return @object;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000383C File Offset: 0x00001A3C
		private static Delegate GetError_Lcom_bumptech_glide_RequestBuilder_Handler()
		{
			if (RequestBuilder.cb_error_Lcom_bumptech_glide_RequestBuilder_ == null)
			{
				RequestBuilder.cb_error_Lcom_bumptech_glide_RequestBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Error_Lcom_bumptech_glide_RequestBuilder_));
			}
			return RequestBuilder.cb_error_Lcom_bumptech_glide_RequestBuilder_;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003860 File Offset: 0x00001A60
		private static IntPtr n_Error_Lcom_bumptech_glide_RequestBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorBuilder)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RequestBuilder object2 = Java.Lang.Object.GetObject<RequestBuilder>(native_errorBuilder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Error(object2));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003888 File Offset: 0x00001A88
		[Register("error", "(Lcom/bumptech/glide/RequestBuilder;)Lcom/bumptech/glide/RequestBuilder;", "GetError_Lcom_bumptech_glide_RequestBuilder_Handler")]
		public unsafe virtual RequestBuilder Error(RequestBuilder errorBuilder)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorBuilder == null) ? IntPtr.Zero : errorBuilder.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("error.(Lcom/bumptech/glide/RequestBuilder;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(errorBuilder);
			}
			return @object;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000038FC File Offset: 0x00001AFC
		private static Delegate GetError_Ljava_lang_Object_Handler()
		{
			if (RequestBuilder.cb_error_Ljava_lang_Object_ == null)
			{
				RequestBuilder.cb_error_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Error_Ljava_lang_Object_));
			}
			return RequestBuilder.cb_error_Ljava_lang_Object_;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00003920 File Offset: 0x00001B20
		private static IntPtr n_Error_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Error(object2));
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003948 File Offset: 0x00001B48
		[Register("error", "(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", "GetError_Ljava_lang_Object_Handler")]
		public unsafe virtual RequestBuilder Error(Java.Lang.Object model)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("error.(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return @object;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000039BC File Offset: 0x00001BBC
		private static Delegate GetInto_Landroid_widget_ImageView_Handler()
		{
			if (RequestBuilder.cb_into_Landroid_widget_ImageView_ == null)
			{
				RequestBuilder.cb_into_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Into_Landroid_widget_ImageView_));
			}
			return RequestBuilder.cb_into_Landroid_widget_ImageView_;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000039E0 File Offset: 0x00001BE0
		private static IntPtr n_Into_Landroid_widget_ImageView_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ImageView object2 = Java.Lang.Object.GetObject<ImageView>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Into(object2));
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003A08 File Offset: 0x00001C08
		[Register("into", "(Landroid/widget/ImageView;)Lcom/bumptech/glide/request/target/ViewTarget;", "GetInto_Landroid_widget_ImageView_Handler")]
		public unsafe virtual ViewTarget Into(ImageView view)
		{
			ViewTarget @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<ViewTarget>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("into.(Landroid/widget/ImageView;)Lcom/bumptech/glide/request/target/ViewTarget;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Obsolete]
		private static Delegate GetInto_IIHandler()
		{
			if (RequestBuilder.cb_into_II == null)
			{
				RequestBuilder.cb_into_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(RequestBuilder.n_Into_II));
			}
			return RequestBuilder.cb_into_II;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003AA0 File Offset: 0x00001CA0
		[Obsolete]
		private static IntPtr n_Into_II(IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Into(width, height));
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[Obsolete("deprecated")]
		[Register("into", "(II)Lcom/bumptech/glide/request/FutureTarget;", "GetInto_IIHandler")]
		public unsafe virtual IFutureTarget Into(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			return Java.Lang.Object.GetObject<IFutureTarget>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("into.(II)Lcom/bumptech/glide/request/FutureTarget;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003B14 File Offset: 0x00001D14
		private static Delegate GetInto_Lcom_bumptech_glide_request_target_Target_Handler()
		{
			if (RequestBuilder.cb_into_Lcom_bumptech_glide_request_target_Target_ == null)
			{
				RequestBuilder.cb_into_Lcom_bumptech_glide_request_target_Target_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Into_Lcom_bumptech_glide_request_target_Target_));
			}
			return RequestBuilder.cb_into_Lcom_bumptech_glide_request_target_Target_;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003B38 File Offset: 0x00001D38
		private static IntPtr n_Into_Lcom_bumptech_glide_request_target_Target_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_target, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Into(object2));
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00003B60 File Offset: 0x00001D60
		[Register("into", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;", "GetInto_Lcom_bumptech_glide_request_target_Target_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Y extends com.bumptech.glide.request.target.Target<TranscodeType>"
		})]
		public unsafe virtual Java.Lang.Object Into(Java.Lang.Object target)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(target);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("into.(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(target);
			}
			return @object;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003BD4 File Offset: 0x00001DD4
		private static Delegate GetListener_Lcom_bumptech_glide_request_RequestListener_Handler()
		{
			if (RequestBuilder.cb_listener_Lcom_bumptech_glide_request_RequestListener_ == null)
			{
				RequestBuilder.cb_listener_Lcom_bumptech_glide_request_RequestListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Listener_Lcom_bumptech_glide_request_RequestListener_));
			}
			return RequestBuilder.cb_listener_Lcom_bumptech_glide_request_RequestListener_;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003BF8 File Offset: 0x00001DF8
		private static IntPtr n_Listener_Lcom_bumptech_glide_request_RequestListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestListener)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequestListener object2 = Java.Lang.Object.GetObject<IRequestListener>(native_requestListener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Listener(object2));
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00003C20 File Offset: 0x00001E20
		[Register("listener", "(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/RequestBuilder;", "GetListener_Lcom_bumptech_glide_request_RequestListener_Handler")]
		public unsafe virtual RequestBuilder Listener(IRequestListener requestListener)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestListener == null) ? IntPtr.Zero : ((Java.Lang.Object)requestListener).Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("listener.(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(requestListener);
			}
			return @object;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003C98 File Offset: 0x00001E98
		private static Delegate GetLoad_Landroid_graphics_Bitmap_Handler()
		{
			if (RequestBuilder.cb_load_Landroid_graphics_Bitmap_ == null)
			{
				RequestBuilder.cb_load_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_Landroid_graphics_Bitmap_));
			}
			return RequestBuilder.cb_load_Landroid_graphics_Bitmap_;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003CBC File Offset: 0x00001EBC
		private static IntPtr n_Load_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_bitmap, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003CE4 File Offset: 0x00001EE4
		[Register("load", "(Landroid/graphics/Bitmap;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Landroid_graphics_Bitmap_Handler")]
		public unsafe virtual RequestBuilder Load(Bitmap bitmap)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Landroid/graphics/Bitmap;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
			return @object;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003D58 File Offset: 0x00001F58
		private static Delegate GetLoad_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (RequestBuilder.cb_load_Landroid_graphics_drawable_Drawable_ == null)
			{
				RequestBuilder.cb_load_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_Landroid_graphics_drawable_Drawable_));
			}
			return RequestBuilder.cb_load_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003D7C File Offset: 0x00001F7C
		private static IntPtr n_Load_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003DA4 File Offset: 0x00001FA4
		[Register("load", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual RequestBuilder Load(Drawable drawable)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
			return @object;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003E18 File Offset: 0x00002018
		private static Delegate GetLoad_Landroid_net_Uri_Handler()
		{
			if (RequestBuilder.cb_load_Landroid_net_Uri_ == null)
			{
				RequestBuilder.cb_load_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_Landroid_net_Uri_));
			}
			return RequestBuilder.cb_load_Landroid_net_Uri_;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003E3C File Offset: 0x0000203C
		private static IntPtr n_Load_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003E64 File Offset: 0x00002064
		[Register("load", "(Landroid/net/Uri;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Landroid_net_Uri_Handler")]
		public unsafe virtual RequestBuilder Load(Android.Net.Uri uri)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Landroid/net/Uri;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return @object;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003ED8 File Offset: 0x000020D8
		private static Delegate GetLoad_arrayBHandler()
		{
			if (RequestBuilder.cb_load_arrayB == null)
			{
				RequestBuilder.cb_load_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_arrayB));
			}
			return RequestBuilder.cb_load_arrayB;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003EFC File Offset: 0x000020FC
		private static IntPtr n_Load_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_model, JniHandleOwnership.DoNotTransfer, typeof(byte));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Load(array));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_model);
			}
			return result;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003F40 File Offset: 0x00002140
		[Register("load", "([B)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_arrayBHandler")]
		public unsafe virtual RequestBuilder Load(byte[] model)
		{
			IntPtr intPtr = JNIEnv.NewArray(model);
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.([B)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (model != null)
				{
					JNIEnv.CopyArray(intPtr, model);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(model);
			}
			return @object;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003FBC File Offset: 0x000021BC
		private static Delegate GetLoad_Ljava_io_File_Handler()
		{
			if (RequestBuilder.cb_load_Ljava_io_File_ == null)
			{
				RequestBuilder.cb_load_Ljava_io_File_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_Ljava_io_File_));
			}
			return RequestBuilder.cb_load_Ljava_io_File_;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003FE0 File Offset: 0x000021E0
		private static IntPtr n_Load_Ljava_io_File_(IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_file, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004008 File Offset: 0x00002208
		[Register("load", "(Ljava/io/File;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_io_File_Handler")]
		public unsafe virtual RequestBuilder Load(File file)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/io/File;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(file);
			}
			return @object;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000407C File Offset: 0x0000227C
		private static Delegate GetLoad_Ljava_lang_Integer_Handler()
		{
			if (RequestBuilder.cb_load_Ljava_lang_Integer_ == null)
			{
				RequestBuilder.cb_load_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_Ljava_lang_Integer_));
			}
			return RequestBuilder.cb_load_Ljava_lang_Integer_;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000040A0 File Offset: 0x000022A0
		private static IntPtr n_Load_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceId)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Integer object2 = Java.Lang.Object.GetObject<Integer>(native_resourceId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000040C8 File Offset: 0x000022C8
		[Register("load", "(Ljava/lang/Integer;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_lang_Integer_Handler")]
		public unsafe virtual RequestBuilder Load(Integer resourceId)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceId == null) ? IntPtr.Zero : resourceId.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/lang/Integer;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceId);
			}
			return @object;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000413C File Offset: 0x0000233C
		private static Delegate GetLoad_Ljava_lang_Object_Handler()
		{
			if (RequestBuilder.cb_load_Ljava_lang_Object_ == null)
			{
				RequestBuilder.cb_load_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_Ljava_lang_Object_));
			}
			return RequestBuilder.cb_load_Ljava_lang_Object_;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004160 File Offset: 0x00002360
		private static IntPtr n_Load_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004188 File Offset: 0x00002388
		[Register("load", "(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_lang_Object_Handler")]
		public unsafe virtual RequestBuilder Load(Java.Lang.Object model)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return @object;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000041FC File Offset: 0x000023FC
		private static Delegate GetLoad_Ljava_lang_String_Handler()
		{
			if (RequestBuilder.cb_load_Ljava_lang_String_ == null)
			{
				RequestBuilder.cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_Ljava_lang_String_));
			}
			return RequestBuilder.cb_load_Ljava_lang_String_;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00004220 File Offset: 0x00002420
		private static IntPtr n_Load_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native__string)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__string, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(@string));
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00004248 File Offset: 0x00002448
		[Register("load", "(Ljava/lang/String;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_lang_String_Handler")]
		public unsafe virtual RequestBuilder Load(string @string)
		{
			IntPtr intPtr = JNIEnv.NewString(@string);
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/lang/String;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000042B4 File Offset: 0x000024B4
		[Obsolete]
		private static Delegate GetLoad_Ljava_net_URL_Handler()
		{
			if (RequestBuilder.cb_load_Ljava_net_URL_ == null)
			{
				RequestBuilder.cb_load_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Load_Ljava_net_URL_));
			}
			return RequestBuilder.cb_load_Ljava_net_URL_;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000042D8 File Offset: 0x000024D8
		[Obsolete]
		private static IntPtr n_Load_Ljava_net_URL_(IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			URL object2 = Java.Lang.Object.GetObject<URL>(native_url, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00004300 File Offset: 0x00002500
		[Obsolete("deprecated")]
		[Register("load", "(Ljava/net/URL;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_net_URL_Handler")]
		public unsafe virtual RequestBuilder Load(URL url)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((url == null) ? IntPtr.Zero : url.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/net/URL;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(url);
			}
			return @object;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00004374 File Offset: 0x00002574
		private static Delegate GetPreloadHandler()
		{
			if (RequestBuilder.cb_preload == null)
			{
				RequestBuilder.cb_preload = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestBuilder.n_Preload));
			}
			return RequestBuilder.cb_preload;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004398 File Offset: 0x00002598
		private static IntPtr n_Preload(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Preload());
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000043AC File Offset: 0x000025AC
		[Register("preload", "()Lcom/bumptech/glide/request/target/Target;", "GetPreloadHandler")]
		public virtual ITarget Preload()
		{
			return Java.Lang.Object.GetObject<ITarget>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("preload.()Lcom/bumptech/glide/request/target/Target;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000043DE File Offset: 0x000025DE
		private static Delegate GetPreload_IIHandler()
		{
			if (RequestBuilder.cb_preload_II == null)
			{
				RequestBuilder.cb_preload_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(RequestBuilder.n_Preload_II));
			}
			return RequestBuilder.cb_preload_II;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004402 File Offset: 0x00002602
		private static IntPtr n_Preload_II(IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Preload(width, height));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004418 File Offset: 0x00002618
		[Register("preload", "(II)Lcom/bumptech/glide/request/target/Target;", "GetPreload_IIHandler")]
		public unsafe virtual ITarget Preload(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			return Java.Lang.Object.GetObject<ITarget>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("preload.(II)Lcom/bumptech/glide/request/target/Target;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00004474 File Offset: 0x00002674
		private static Delegate GetSubmitHandler()
		{
			if (RequestBuilder.cb_submit == null)
			{
				RequestBuilder.cb_submit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestBuilder.n_Submit));
			}
			return RequestBuilder.cb_submit;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00004498 File Offset: 0x00002698
		private static IntPtr n_Submit(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Submit());
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000044AC File Offset: 0x000026AC
		[Register("submit", "()Lcom/bumptech/glide/request/FutureTarget;", "GetSubmitHandler")]
		public virtual IFutureTarget Submit()
		{
			return Java.Lang.Object.GetObject<IFutureTarget>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("submit.()Lcom/bumptech/glide/request/FutureTarget;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000044DE File Offset: 0x000026DE
		private static Delegate GetSubmit_IIHandler()
		{
			if (RequestBuilder.cb_submit_II == null)
			{
				RequestBuilder.cb_submit_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(RequestBuilder.n_Submit_II));
			}
			return RequestBuilder.cb_submit_II;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00004502 File Offset: 0x00002702
		private static IntPtr n_Submit_II(IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Submit(width, height));
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00004518 File Offset: 0x00002718
		[Register("submit", "(II)Lcom/bumptech/glide/request/FutureTarget;", "GetSubmit_IIHandler")]
		public unsafe virtual IFutureTarget Submit(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			return Java.Lang.Object.GetObject<IFutureTarget>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("submit.(II)Lcom/bumptech/glide/request/FutureTarget;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00004574 File Offset: 0x00002774
		private static Delegate GetThumbnail_Lcom_bumptech_glide_RequestBuilder_Handler()
		{
			if (RequestBuilder.cb_thumbnail_Lcom_bumptech_glide_RequestBuilder_ == null)
			{
				RequestBuilder.cb_thumbnail_Lcom_bumptech_glide_RequestBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Thumbnail_Lcom_bumptech_glide_RequestBuilder_));
			}
			return RequestBuilder.cb_thumbnail_Lcom_bumptech_glide_RequestBuilder_;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00004598 File Offset: 0x00002798
		private static IntPtr n_Thumbnail_Lcom_bumptech_glide_RequestBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_thumbnailRequest)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RequestBuilder object2 = Java.Lang.Object.GetObject<RequestBuilder>(native_thumbnailRequest, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Thumbnail(object2));
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000045C0 File Offset: 0x000027C0
		[Register("thumbnail", "(Lcom/bumptech/glide/RequestBuilder;)Lcom/bumptech/glide/RequestBuilder;", "GetThumbnail_Lcom_bumptech_glide_RequestBuilder_Handler")]
		public unsafe virtual RequestBuilder Thumbnail(RequestBuilder thumbnailRequest)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((thumbnailRequest == null) ? IntPtr.Zero : thumbnailRequest.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbnail.(Lcom/bumptech/glide/RequestBuilder;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(thumbnailRequest);
			}
			return @object;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00004634 File Offset: 0x00002834
		private static Delegate GetThumbnail_arrayLcom_bumptech_glide_RequestBuilder_Handler()
		{
			if (RequestBuilder.cb_thumbnail_arrayLcom_bumptech_glide_RequestBuilder_ == null)
			{
				RequestBuilder.cb_thumbnail_arrayLcom_bumptech_glide_RequestBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Thumbnail_arrayLcom_bumptech_glide_RequestBuilder_));
			}
			return RequestBuilder.cb_thumbnail_arrayLcom_bumptech_glide_RequestBuilder_;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00004658 File Offset: 0x00002858
		private static IntPtr n_Thumbnail_arrayLcom_bumptech_glide_RequestBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_thumbnails)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RequestBuilder[] array = (RequestBuilder[])JNIEnv.GetArray(native_thumbnails, JniHandleOwnership.DoNotTransfer, typeof(RequestBuilder));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Thumbnail(array));
			if (array != null)
			{
				JNIEnv.CopyArray<RequestBuilder>(array, native_thumbnails);
			}
			return result;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000469C File Offset: 0x0000289C
		[Register("thumbnail", "([Lcom/bumptech/glide/RequestBuilder;)Lcom/bumptech/glide/RequestBuilder;", "GetThumbnail_arrayLcom_bumptech_glide_RequestBuilder_Handler")]
		public unsafe virtual RequestBuilder Thumbnail(params RequestBuilder[] thumbnails)
		{
			IntPtr intPtr = JNIEnv.NewArray<RequestBuilder>(thumbnails);
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbnail.([Lcom/bumptech/glide/RequestBuilder;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (thumbnails != null)
				{
					JNIEnv.CopyArray<RequestBuilder>(intPtr, thumbnails);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(thumbnails);
			}
			return @object;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00004718 File Offset: 0x00002918
		[Obsolete]
		private static Delegate GetThumbnail_FHandler()
		{
			if (RequestBuilder.cb_thumbnail_F == null)
			{
				RequestBuilder.cb_thumbnail_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_L(RequestBuilder.n_Thumbnail_F));
			}
			return RequestBuilder.cb_thumbnail_F;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000473C File Offset: 0x0000293C
		[Obsolete]
		private static IntPtr n_Thumbnail_F(IntPtr jnienv, IntPtr native__this, float sizeMultiplier)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Thumbnail(sizeMultiplier));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00004754 File Offset: 0x00002954
		[Obsolete("deprecated")]
		[Register("thumbnail", "(F)Lcom/bumptech/glide/RequestBuilder;", "GetThumbnail_FHandler")]
		public unsafe virtual RequestBuilder Thumbnail(float sizeMultiplier)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(sizeMultiplier);
			return Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbnail.(F)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000479D File Offset: 0x0000299D
		private static Delegate GetThumbnail_Ljava_util_List_Handler()
		{
			if (RequestBuilder.cb_thumbnail_Ljava_util_List_ == null)
			{
				RequestBuilder.cb_thumbnail_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Thumbnail_Ljava_util_List_));
			}
			return RequestBuilder.cb_thumbnail_Ljava_util_List_;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000047C4 File Offset: 0x000029C4
		private static IntPtr n_Thumbnail_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_thumbnails)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList thumbnails = JavaList.FromJniHandle(native_thumbnails, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Thumbnail(thumbnails));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000047EC File Offset: 0x000029EC
		[Register("thumbnail", "(Ljava/util/List;)Lcom/bumptech/glide/RequestBuilder;", "GetThumbnail_Ljava_util_List_Handler")]
		public unsafe virtual RequestBuilder Thumbnail(IList thumbnails)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(thumbnails);
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbnail.(Ljava/util/List;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(thumbnails);
			}
			return @object;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00004860 File Offset: 0x00002A60
		private static Delegate GetTransition_Lcom_bumptech_glide_TransitionOptions_Handler()
		{
			if (RequestBuilder.cb_transition_Lcom_bumptech_glide_TransitionOptions_ == null)
			{
				RequestBuilder.cb_transition_Lcom_bumptech_glide_TransitionOptions_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestBuilder.n_Transition_Lcom_bumptech_glide_TransitionOptions_));
			}
			return RequestBuilder.cb_transition_Lcom_bumptech_glide_TransitionOptions_;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00004884 File Offset: 0x00002A84
		private static IntPtr n_Transition_Lcom_bumptech_glide_TransitionOptions_(IntPtr jnienv, IntPtr native__this, IntPtr native_transitionOptions)
		{
			RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransitionOptions object2 = Java.Lang.Object.GetObject<TransitionOptions>(native_transitionOptions, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transition(object2));
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000048AC File Offset: 0x00002AAC
		[Register("transition", "(Lcom/bumptech/glide/TransitionOptions;)Lcom/bumptech/glide/RequestBuilder;", "GetTransition_Lcom_bumptech_glide_TransitionOptions_Handler")]
		public unsafe virtual RequestBuilder Transition(TransitionOptions transitionOptions)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transitionOptions == null) ? IntPtr.Zero : transitionOptions.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("transition.(Lcom/bumptech/glide/TransitionOptions;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transitionOptions);
			}
			return @object;
		}

		// Token: 0x0400001E RID: 30
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/RequestBuilder", typeof(RequestBuilder));

		// Token: 0x0400001F RID: 31
		private static Delegate cb_getDownloadOnlyRequest;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_addListener_Lcom_bumptech_glide_request_RequestListener_;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_downloadOnly_II;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_error_Lcom_bumptech_glide_RequestBuilder_;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_error_Ljava_lang_Object_;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_into_Landroid_widget_ImageView_;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_into_II;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_into_Lcom_bumptech_glide_request_target_Target_;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_listener_Lcom_bumptech_glide_request_RequestListener_;

		// Token: 0x04000029 RID: 41
		private static Delegate cb_load_Landroid_graphics_Bitmap_;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_load_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_load_Landroid_net_Uri_;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_load_arrayB;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_load_Ljava_io_File_;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_load_Ljava_lang_Integer_;

		// Token: 0x0400002F RID: 47
		private static Delegate cb_load_Ljava_lang_Object_;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_load_Ljava_lang_String_;

		// Token: 0x04000031 RID: 49
		private static Delegate cb_load_Ljava_net_URL_;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_preload;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_preload_II;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_submit;

		// Token: 0x04000035 RID: 53
		private static Delegate cb_submit_II;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_thumbnail_Lcom_bumptech_glide_RequestBuilder_;

		// Token: 0x04000037 RID: 55
		private static Delegate cb_thumbnail_arrayLcom_bumptech_glide_RequestBuilder_;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_thumbnail_F;

		// Token: 0x04000039 RID: 57
		private static Delegate cb_thumbnail_Ljava_util_List_;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_transition_Lcom_bumptech_glide_TransitionOptions_;
	}
}
