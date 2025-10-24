using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines
{
	// Token: 0x02000252 RID: 594
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/Continuation", DoNotGenerateAcw = true)]
	internal class IContinuationInvoker : Java.Lang.Object, IContinuation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0005BBA4 File Offset: 0x00059DA4
		private static IntPtr java_class_ref
		{
			get
			{
				return IContinuationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0005BBC8 File Offset: 0x00059DC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContinuationInvoker._members;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0005BBCF File Offset: 0x00059DCF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0005BBD7 File Offset: 0x00059DD7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContinuationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0005BBE3 File Offset: 0x00059DE3
		[NullableContext(2)]
		public static IContinuation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IContinuation>(handle, transfer);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0005BBEC File Offset: 0x00059DEC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContinuationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.coroutines.Continuation'.");
			}
			return handle;
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0005BC17 File Offset: 0x00059E17
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0005BC48 File Offset: 0x00059E48
		public IContinuationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContinuationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0005BC80 File Offset: 0x00059E80
		private static Delegate GetGetContextHandler()
		{
			if (IContinuationInvoker.cb_getContext == null)
			{
				IContinuationInvoker.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContinuationInvoker.n_GetContext));
			}
			return IContinuationInvoker.cb_getContext;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0005BCA4 File Offset: 0x00059EA4
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x0005BCB8 File Offset: 0x00059EB8
		public ICoroutineContext Context
		{
			get
			{
				if (this.id_getContext == IntPtr.Zero)
				{
					this.id_getContext = JNIEnv.GetMethodID(this.class_ref, "getContext", "()Lkotlin/coroutines/CoroutineContext;");
				}
				return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_getContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0005BD09 File Offset: 0x00059F09
		private static Delegate GetResumeWith_Ljava_lang_Object_Handler()
		{
			if (IContinuationInvoker.cb_resumeWith_Ljava_lang_Object_ == null)
			{
				IContinuationInvoker.cb_resumeWith_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IContinuationInvoker.n_ResumeWith_Ljava_lang_Object_));
			}
			return IContinuationInvoker.cb_resumeWith_Ljava_lang_Object_;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0005BD30 File Offset: 0x00059F30
		private static void n_ResumeWith_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			IContinuation @object = Java.Lang.Object.GetObject<IContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			@object.ResumeWith(object2);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0005BD54 File Offset: 0x00059F54
		public unsafe void ResumeWith(Java.Lang.Object result)
		{
			if (this.id_resumeWith_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_resumeWith_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "resumeWith", "(Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((result == null) ? IntPtr.Zero : result.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_resumeWith_Ljava_lang_Object_, ptr);
		}

		// Token: 0x0400086A RID: 2154
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/Continuation", typeof(IContinuationInvoker));

		// Token: 0x0400086B RID: 2155
		private IntPtr class_ref;

		// Token: 0x0400086C RID: 2156
		[Nullable(2)]
		private static Delegate cb_getContext;

		// Token: 0x0400086D RID: 2157
		private IntPtr id_getContext;

		// Token: 0x0400086E RID: 2158
		[Nullable(2)]
		private static Delegate cb_resumeWith_Ljava_lang_Object_;

		// Token: 0x0400086F RID: 2159
		private IntPtr id_resumeWith_Ljava_lang_Object_;
	}
}
