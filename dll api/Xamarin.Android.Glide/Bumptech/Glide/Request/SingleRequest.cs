using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Request.Target;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000098 RID: 152
	[Register("com/bumptech/glide/request/SingleRequest", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public sealed class SingleRequest : Java.Lang.Object, IRequest, IJavaObject, IDisposable, IJavaPeerable, IResourceCallback, ISizeReadyCallback
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000187C0 File Offset: 0x000169C0
		internal static IntPtr class_ref
		{
			get
			{
				return SingleRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x000187E4 File Offset: 0x000169E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SingleRequest._members;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000187EC File Offset: 0x000169EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SingleRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00018810 File Offset: 0x00016A10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SingleRequest._members.ManagedPeerType;
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0001881C File Offset: 0x00016A1C
		internal SingleRequest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00018826 File Offset: 0x00016A26
		public bool IsAnyResourceSet
		{
			[Register("isAnyResourceSet", "()Z", "")]
			get
			{
				return SingleRequest._members.InstanceMethods.InvokeAbstractBooleanMethod("isAnyResourceSet.()Z", this, null);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001883F File Offset: 0x00016A3F
		public bool IsCleared
		{
			[Register("isCleared", "()Z", "")]
			get
			{
				return SingleRequest._members.InstanceMethods.InvokeAbstractBooleanMethod("isCleared.()Z", this, null);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00018858 File Offset: 0x00016A58
		public bool IsComplete
		{
			[Register("isComplete", "()Z", "")]
			get
			{
				return SingleRequest._members.InstanceMethods.InvokeAbstractBooleanMethod("isComplete.()Z", this, null);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00018871 File Offset: 0x00016A71
		public bool IsRunning
		{
			[Register("isRunning", "()Z", "")]
			get
			{
				return SingleRequest._members.InstanceMethods.InvokeAbstractBooleanMethod("isRunning.()Z", this, null);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x0001888C File Offset: 0x00016A8C
		public Java.Lang.Object Lock
		{
			[Register("getLock", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(SingleRequest._members.InstanceMethods.InvokeAbstractObjectMethod("getLock.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000188BE File Offset: 0x00016ABE
		[Register("begin", "()V", "")]
		public void Begin()
		{
			SingleRequest._members.InstanceMethods.InvokeAbstractVoidMethod("begin.()V", this, null);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000188D7 File Offset: 0x00016AD7
		[Register("clear", "()V", "")]
		public void Clear()
		{
			SingleRequest._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000188F0 File Offset: 0x00016AF0
		[Register("isEquivalentTo", "(Lcom/bumptech/glide/request/Request;)Z", "")]
		public unsafe bool IsEquivalentTo(IRequest o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : ((Java.Lang.Object)o).Handle);
				result = SingleRequest._members.InstanceMethods.InvokeAbstractBooleanMethod("isEquivalentTo.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0001895C File Offset: 0x00016B5C
		[Register("obtain", "(Landroid/content/Context;Lcom/bumptech/glide/GlideContext;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Class;Lcom/bumptech/glide/request/BaseRequestOptions;IILcom/bumptech/glide/Priority;Lcom/bumptech/glide/request/target/Target;Lcom/bumptech/glide/request/RequestListener;Ljava/util/List;Lcom/bumptech/glide/request/RequestCoordinator;Lcom/bumptech/glide/load/engine/Engine;Lcom/bumptech/glide/request/transition/TransitionFactory;Ljava/util/concurrent/Executor;)Lcom/bumptech/glide/request/SingleRequest;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static SingleRequest Obtain(Context context, GlideContext glideContext, Java.Lang.Object requestLock, Java.Lang.Object model, Class transcodeClass, BaseRequestOptions requestOptions, int overrideWidth, int overrideHeight, Priority priority, ITarget target, IRequestListener targetListener, IList requestListeners, IRequestCoordinator requestCoordinator, Engine engine, ITransitionFactory animationFactory, IExecutor callbackExecutor)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(requestListeners);
			SingleRequest @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((glideContext == null) ? IntPtr.Zero : glideContext.Handle);
				ptr[2] = new JniArgumentValue((requestLock == null) ? IntPtr.Zero : requestLock.Handle);
				ptr[3] = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[4] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[5] = new JniArgumentValue((requestOptions == null) ? IntPtr.Zero : requestOptions.Handle);
				ptr[6] = new JniArgumentValue(overrideWidth);
				ptr[7] = new JniArgumentValue(overrideHeight);
				ptr[8] = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ptr[9] = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				ptr[10] = new JniArgumentValue((targetListener == null) ? IntPtr.Zero : ((Java.Lang.Object)targetListener).Handle);
				ptr[11] = new JniArgumentValue(intPtr);
				ptr[12] = new JniArgumentValue((requestCoordinator == null) ? IntPtr.Zero : ((Java.Lang.Object)requestCoordinator).Handle);
				ptr[13] = new JniArgumentValue((engine == null) ? IntPtr.Zero : engine.Handle);
				ptr[14] = new JniArgumentValue((animationFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)animationFactory).Handle);
				ptr[15] = new JniArgumentValue((callbackExecutor == null) ? IntPtr.Zero : ((Java.Lang.Object)callbackExecutor).Handle);
				@object = Java.Lang.Object.GetObject<SingleRequest>(SingleRequest._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/content/Context;Lcom/bumptech/glide/GlideContext;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Class;Lcom/bumptech/glide/request/BaseRequestOptions;IILcom/bumptech/glide/Priority;Lcom/bumptech/glide/request/target/Target;Lcom/bumptech/glide/request/RequestListener;Ljava/util/List;Lcom/bumptech/glide/request/RequestCoordinator;Lcom/bumptech/glide/load/engine/Engine;Lcom/bumptech/glide/request/transition/TransitionFactory;Ljava/util/concurrent/Executor;)Lcom/bumptech/glide/request/SingleRequest;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(glideContext);
				GC.KeepAlive(requestLock);
				GC.KeepAlive(model);
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(requestOptions);
				GC.KeepAlive(priority);
				GC.KeepAlive(target);
				GC.KeepAlive(targetListener);
				GC.KeepAlive(requestListeners);
				GC.KeepAlive(requestCoordinator);
				GC.KeepAlive(engine);
				GC.KeepAlive(animationFactory);
				GC.KeepAlive(callbackExecutor);
			}
			return @object;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00018C70 File Offset: 0x00016E70
		[Register("onLoadFailed", "(Lcom/bumptech/glide/load/engine/GlideException;)V", "")]
		public unsafe void OnLoadFailed(GlideException e)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				SingleRequest._members.InstanceMethods.InvokeAbstractVoidMethod("onLoadFailed.(Lcom/bumptech/glide/load/engine/GlideException;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00018CD4 File Offset: 0x00016ED4
		[Register("onResourceReady", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/DataSource;Z)V", "")]
		public unsafe void OnResourceReady(IResource resource, DataSource dataSource, bool isLoadedFromAlternateCacheKey)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				ptr[1] = new JniArgumentValue((dataSource == null) ? IntPtr.Zero : dataSource.Handle);
				ptr[2] = new JniArgumentValue(isLoadedFromAlternateCacheKey);
				SingleRequest._members.InstanceMethods.InvokeAbstractVoidMethod("onResourceReady.(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/DataSource;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
				GC.KeepAlive(dataSource);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00018D7C File Offset: 0x00016F7C
		[Register("onSizeReady", "(II)V", "")]
		public unsafe void OnSizeReady(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			SingleRequest._members.InstanceMethods.InvokeAbstractVoidMethod("onSizeReady.(II)V", this, ptr);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00018DCA File Offset: 0x00016FCA
		[Register("pause", "()V", "")]
		public void Pause()
		{
			SingleRequest._members.InstanceMethods.InvokeAbstractVoidMethod("pause.()V", this, null);
		}

		// Token: 0x040001F5 RID: 501
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/SingleRequest", typeof(SingleRequest));
	}
}
