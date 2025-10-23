using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Module;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x02000036 RID: 54
	[Register("com/bumptech/glide/GeneratedAppGlideModule", DoNotGenerateAcw = true)]
	public abstract class GeneratedAppGlideModule : AppGlideModule
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000493C File Offset: 0x00002B3C
		internal new static IntPtr class_ref
		{
			get
			{
				return GeneratedAppGlideModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00004960 File Offset: 0x00002B60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GeneratedAppGlideModule._members;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00004968 File Offset: 0x00002B68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GeneratedAppGlideModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000498C File Offset: 0x00002B8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GeneratedAppGlideModule._members.ManagedPeerType;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004998 File Offset: 0x00002B98
		protected GeneratedAppGlideModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000049A4 File Offset: 0x00002BA4
		[Register(".ctor", "()V", "")]
		public GeneratedAppGlideModule() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GeneratedAppGlideModule._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GeneratedAppGlideModule._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00004A12 File Offset: 0x00002C12
		private static Delegate GetGetExcludedModuleClassesHandler()
		{
			if (GeneratedAppGlideModule.cb_getExcludedModuleClasses == null)
			{
				GeneratedAppGlideModule.cb_getExcludedModuleClasses = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GeneratedAppGlideModule.n_GetExcludedModuleClasses));
			}
			return GeneratedAppGlideModule.cb_getExcludedModuleClasses;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00004A36 File Offset: 0x00002C36
		private static IntPtr n_GetExcludedModuleClasses(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<Class>.ToLocalJniHandle(Java.Lang.Object.GetObject<GeneratedAppGlideModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExcludedModuleClasses);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600016E RID: 366
		public abstract ICollection<Class> ExcludedModuleClasses { [Register("getExcludedModuleClasses", "()Ljava/util/Set;", "GetGetExcludedModuleClassesHandler")] get; }

		// Token: 0x0600016F RID: 367 RVA: 0x00004A4A File Offset: 0x00002C4A
		private static Delegate GetGetRequestManagerFactoryHandler()
		{
			if (GeneratedAppGlideModule.cb_getRequestManagerFactory == null)
			{
				GeneratedAppGlideModule.cb_getRequestManagerFactory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GeneratedAppGlideModule.n_GetRequestManagerFactory));
			}
			return GeneratedAppGlideModule.cb_getRequestManagerFactory;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00004A6E File Offset: 0x00002C6E
		private static IntPtr n_GetRequestManagerFactory(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GeneratedAppGlideModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestManagerFactory);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00004A84 File Offset: 0x00002C84
		public virtual RequestManagerRetriever.IRequestManagerFactory RequestManagerFactory
		{
			[Register("getRequestManagerFactory", "()Lcom/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory;", "GetGetRequestManagerFactoryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<RequestManagerRetriever.IRequestManagerFactory>(GeneratedAppGlideModule._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestManagerFactory.()Lcom/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400003B RID: 59
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GeneratedAppGlideModule", typeof(GeneratedAppGlideModule));

		// Token: 0x0400003C RID: 60
		private static Delegate cb_getExcludedModuleClasses;

		// Token: 0x0400003D RID: 61
		private static Delegate cb_getRequestManagerFactory;
	}
}
