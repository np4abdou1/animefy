using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Bumptech.Glide.Load.Engine.Executor
{
	// Token: 0x02000185 RID: 389
	[Register("com/bumptech/glide/load/engine/executor/GlideExecutor", DoNotGenerateAcw = true)]
	public sealed class GlideExecutor : Java.Lang.Object, IExecutorService, IExecutor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001383 RID: 4995 RVA: 0x0003E51D File Offset: 0x0003C71D
		IList IExecutorService.InvokeAll(ICollection tasks)
		{
			return this.InvokeAll(tasks.Cast<ICallable>().ToList<ICallable>()).ToList<IFuture>();
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0003E535 File Offset: 0x0003C735
		IList IExecutorService.InvokeAll(ICollection tasks, long timeout, TimeUnit unit)
		{
			return this.InvokeAll(tasks.Cast<ICallable>().ToList<ICallable>(), timeout, unit).ToList<IFuture>();
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0003E54F File Offset: 0x0003C74F
		Java.Lang.Object IExecutorService.InvokeAny(ICollection tasks)
		{
			return this.InvokeAny(tasks.Cast<ICallable>().ToList<ICallable>());
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0003E562 File Offset: 0x0003C762
		Java.Lang.Object IExecutorService.InvokeAny(ICollection tasks, long timeout, TimeUnit unit)
		{
			return this.InvokeAny(tasks.Cast<ICallable>().ToList<ICallable>(), timeout, unit);
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0003E578 File Offset: 0x0003C778
		internal static IntPtr class_ref
		{
			get
			{
				return GlideExecutor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x0003E59C File Offset: 0x0003C79C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlideExecutor._members;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlideExecutor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0003E5C8 File Offset: 0x0003C7C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlideExecutor._members.ManagedPeerType;
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0003E5D4 File Offset: 0x0003C7D4
		internal GlideExecutor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0003E5DE File Offset: 0x0003C7DE
		public bool IsShutdown
		{
			[Register("isShutdown", "()Z", "")]
			get
			{
				return GlideExecutor._members.InstanceMethods.InvokeAbstractBooleanMethod("isShutdown.()Z", this, null);
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0003E5F7 File Offset: 0x0003C7F7
		public bool IsTerminated
		{
			[Register("isTerminated", "()Z", "")]
			get
			{
				return GlideExecutor._members.InstanceMethods.InvokeAbstractBooleanMethod("isTerminated.()Z", this, null);
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0003E610 File Offset: 0x0003C810
		[Register("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", "")]
		public unsafe bool AwaitTermination(long timeout, TimeUnit unit)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeout);
				ptr[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = GlideExecutor._members.InstanceMethods.InvokeAbstractBooleanMethod("awaitTermination.(JLjava/util/concurrent/TimeUnit;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0003E688 File Offset: 0x0003C888
		[Register("calculateBestThreadCount", "()I", "")]
		public static int CalculateBestThreadCount()
		{
			return GlideExecutor._members.StaticMethods.InvokeInt32Method("calculateBestThreadCount.()I", null);
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0003E6A0 File Offset: 0x0003C8A0
		[Register("execute", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void Execute(IRunnable command)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
				GlideExecutor._members.InstanceMethods.InvokeAbstractVoidMethod("execute.(Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(command);
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0003E708 File Offset: 0x0003C908
		[Register("invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe IList<IFuture> InvokeAll(ICollection<ICallable> tasks)
		{
			IntPtr intPtr = JavaCollection<ICallable>.ToLocalJniHandle(tasks);
			IList<IFuture> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<IFuture>.FromJniHandle(GlideExecutor._members.InstanceMethods.InvokeAbstractObjectMethod("invokeAll.(Ljava/util/Collection;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tasks);
			}
			return result;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0003E77C File Offset: 0x0003C97C
		[Register("invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe IList<IFuture> InvokeAll(ICollection<ICallable> tasks, long timeout, TimeUnit unit)
		{
			IntPtr intPtr = JavaCollection<ICallable>.ToLocalJniHandle(tasks);
			IList<IFuture> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(timeout);
				ptr[2] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = JavaList<IFuture>.FromJniHandle(GlideExecutor._members.InstanceMethods.InvokeAbstractObjectMethod("invokeAll.(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tasks);
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0003E82C File Offset: 0x0003CA2C
		[Register("invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe Java.Lang.Object InvokeAny(ICollection<ICallable> tasks)
		{
			IntPtr intPtr = JavaCollection<ICallable>.ToLocalJniHandle(tasks);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GlideExecutor._members.InstanceMethods.InvokeAbstractObjectMethod("invokeAny.(Ljava/util/Collection;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tasks);
			}
			return @object;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0003E8A0 File Offset: 0x0003CAA0
		[Register("invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe Java.Lang.Object InvokeAny(ICollection<ICallable> tasks, long timeout, TimeUnit unit)
		{
			IntPtr intPtr = JavaCollection<ICallable>.ToLocalJniHandle(tasks);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(timeout);
				ptr[2] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GlideExecutor._members.InstanceMethods.InvokeAbstractObjectMethod("invokeAny.(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tasks);
				GC.KeepAlive(unit);
			}
			return @object;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0003E950 File Offset: 0x0003CB50
		[Register("newAnimationBuilder", "()Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", "")]
		public static GlideExecutor.Builder NewAnimationBuilder()
		{
			return Java.Lang.Object.GetObject<GlideExecutor.Builder>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newAnimationBuilder.()Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0003E984 File Offset: 0x0003CB84
		[Register("newAnimationExecutor", "()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public static GlideExecutor NewAnimationExecutor()
		{
			return Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newAnimationExecutor.()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0003E9B8 File Offset: 0x0003CBB8
		[Obsolete("deprecated")]
		[Register("newAnimationExecutor", "(ILcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public unsafe static GlideExecutor NewAnimationExecutor(int threadCount, GlideExecutor.IUncaughtThrowableStrategy uncaughtThrowableStrategy)
		{
			GlideExecutor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(threadCount);
				ptr[1] = new JniArgumentValue((uncaughtThrowableStrategy == null) ? IntPtr.Zero : ((Java.Lang.Object)uncaughtThrowableStrategy).Handle);
				@object = Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newAnimationExecutor.(ILcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uncaughtThrowableStrategy);
			}
			return @object;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0003EA44 File Offset: 0x0003CC44
		[Register("newDiskCacheBuilder", "()Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", "")]
		public static GlideExecutor.Builder NewDiskCacheBuilder()
		{
			return Java.Lang.Object.GetObject<GlideExecutor.Builder>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newDiskCacheBuilder.()Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0003EA78 File Offset: 0x0003CC78
		[Register("newDiskCacheExecutor", "()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public static GlideExecutor NewDiskCacheExecutor()
		{
			return Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newDiskCacheExecutor.()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0003EAAC File Offset: 0x0003CCAC
		[Obsolete("deprecated")]
		[Register("newDiskCacheExecutor", "(Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public unsafe static GlideExecutor NewDiskCacheExecutor(GlideExecutor.IUncaughtThrowableStrategy uncaughtThrowableStrategy)
		{
			GlideExecutor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uncaughtThrowableStrategy == null) ? IntPtr.Zero : ((Java.Lang.Object)uncaughtThrowableStrategy).Handle);
				@object = Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newDiskCacheExecutor.(Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uncaughtThrowableStrategy);
			}
			return @object;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0003EB24 File Offset: 0x0003CD24
		[Obsolete("deprecated")]
		[Register("newDiskCacheExecutor", "(ILjava/lang/String;Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public unsafe static GlideExecutor NewDiskCacheExecutor(int threadCount, string name, GlideExecutor.IUncaughtThrowableStrategy uncaughtThrowableStrategy)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			GlideExecutor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(threadCount);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((uncaughtThrowableStrategy == null) ? IntPtr.Zero : ((Java.Lang.Object)uncaughtThrowableStrategy).Handle);
				@object = Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newDiskCacheExecutor.(ILjava/lang/String;Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(uncaughtThrowableStrategy);
			}
			return @object;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0003EBD4 File Offset: 0x0003CDD4
		[Register("newSourceBuilder", "()Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", "")]
		public static GlideExecutor.Builder NewSourceBuilder()
		{
			return Java.Lang.Object.GetObject<GlideExecutor.Builder>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newSourceBuilder.()Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0003EC08 File Offset: 0x0003CE08
		[Register("newSourceExecutor", "()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public static GlideExecutor NewSourceExecutor()
		{
			return Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newSourceExecutor.()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0003EC3C File Offset: 0x0003CE3C
		[Obsolete("deprecated")]
		[Register("newSourceExecutor", "(Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public unsafe static GlideExecutor NewSourceExecutor(GlideExecutor.IUncaughtThrowableStrategy uncaughtThrowableStrategy)
		{
			GlideExecutor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uncaughtThrowableStrategy == null) ? IntPtr.Zero : ((Java.Lang.Object)uncaughtThrowableStrategy).Handle);
				@object = Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newSourceExecutor.(Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uncaughtThrowableStrategy);
			}
			return @object;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0003ECB4 File Offset: 0x0003CEB4
		[Obsolete("deprecated")]
		[Register("newSourceExecutor", "(ILjava/lang/String;Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public unsafe static GlideExecutor NewSourceExecutor(int threadCount, string name, GlideExecutor.IUncaughtThrowableStrategy uncaughtThrowableStrategy)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			GlideExecutor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(threadCount);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((uncaughtThrowableStrategy == null) ? IntPtr.Zero : ((Java.Lang.Object)uncaughtThrowableStrategy).Handle);
				@object = Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newSourceExecutor.(ILjava/lang/String;Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(uncaughtThrowableStrategy);
			}
			return @object;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0003ED64 File Offset: 0x0003CF64
		[Register("newUnlimitedSourceExecutor", "()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
		public static GlideExecutor NewUnlimitedSourceExecutor()
		{
			return Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor._members.StaticMethods.InvokeObjectMethod("newUnlimitedSourceExecutor.()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0003ED95 File Offset: 0x0003CF95
		[Register("shutdown", "()V", "")]
		public void Shutdown()
		{
			GlideExecutor._members.InstanceMethods.InvokeAbstractVoidMethod("shutdown.()V", this, null);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0003EDB0 File Offset: 0x0003CFB0
		[Register("shutdownNow", "()Ljava/util/List;", "")]
		public IList<IRunnable> ShutdownNow()
		{
			return JavaList<IRunnable>.FromJniHandle(GlideExecutor._members.InstanceMethods.InvokeAbstractObjectMethod("shutdownNow.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0003EDE4 File Offset: 0x0003CFE4
		[Register("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", "")]
		public unsafe IFuture Submit(IRunnable task)
		{
			IFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
				@object = Java.Lang.Object.GetObject<IFuture>(GlideExecutor._members.InstanceMethods.InvokeAbstractObjectMethod("submit.(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(task);
			}
			return @object;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0003EE5C File Offset: 0x0003D05C
		[Register("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe IFuture Submit(IRunnable task, Java.Lang.Object result)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			IFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFuture>(GlideExecutor._members.InstanceMethods.InvokeAbstractObjectMethod("submit.(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(task);
				GC.KeepAlive(result);
			}
			return @object;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0003EEFC File Offset: 0x0003D0FC
		[Register("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe IFuture Submit(ICallable task)
		{
			IFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
				@object = Java.Lang.Object.GetObject<IFuture>(GlideExecutor._members.InstanceMethods.InvokeAbstractObjectMethod("submit.(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(task);
			}
			return @object;
		}

		// Token: 0x040004A5 RID: 1189
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/executor/GlideExecutor", typeof(GlideExecutor));

		// Token: 0x02000201 RID: 513
		[Register("com/bumptech/glide/load/engine/executor/GlideExecutor$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x0600180F RID: 6159 RVA: 0x0004A404 File Offset: 0x00048604
			internal static IntPtr class_ref
			{
				get
				{
					return GlideExecutor.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x06001810 RID: 6160 RVA: 0x0004A428 File Offset: 0x00048628
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GlideExecutor.Builder._members;
				}
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x06001811 RID: 6161 RVA: 0x0004A430 File Offset: 0x00048630
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return GlideExecutor.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x06001812 RID: 6162 RVA: 0x0004A454 File Offset: 0x00048654
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GlideExecutor.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06001813 RID: 6163 RVA: 0x0004A460 File Offset: 0x00048660
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x0004A46C File Offset: 0x0004866C
			[Register("build", "()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", "")]
			public GlideExecutor Build()
			{
				return Java.Lang.Object.GetObject<GlideExecutor>(GlideExecutor.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/bumptech/glide/load/engine/executor/GlideExecutor;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06001815 RID: 6165 RVA: 0x0004A4A0 File Offset: 0x000486A0
			[Register("setName", "(Ljava/lang/String;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", "")]
			public unsafe GlideExecutor.Builder SetName(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				GlideExecutor.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<GlideExecutor.Builder>(GlideExecutor.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setName.(Ljava/lang/String;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06001816 RID: 6166 RVA: 0x0004A50C File Offset: 0x0004870C
			[Register("setThreadCount", "(I)Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", "")]
			public unsafe GlideExecutor.Builder SetThreadCount(int threadCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(threadCount);
				return Java.Lang.Object.GetObject<GlideExecutor.Builder>(GlideExecutor.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setThreadCount.(I)Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06001817 RID: 6167 RVA: 0x0004A558 File Offset: 0x00048758
			[Register("setThreadTimeoutMillis", "(J)Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", "")]
			public unsafe GlideExecutor.Builder SetThreadTimeoutMillis(long threadTimeoutMillis)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(threadTimeoutMillis);
				return Java.Lang.Object.GetObject<GlideExecutor.Builder>(GlideExecutor.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setThreadTimeoutMillis.(J)Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06001818 RID: 6168 RVA: 0x0004A5A4 File Offset: 0x000487A4
			[Register("setUncaughtThrowableStrategy", "(Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", "")]
			public unsafe GlideExecutor.Builder SetUncaughtThrowableStrategy(GlideExecutor.IUncaughtThrowableStrategy strategy)
			{
				GlideExecutor.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((strategy == null) ? IntPtr.Zero : ((Java.Lang.Object)strategy).Handle);
					@object = Java.Lang.Object.GetObject<GlideExecutor.Builder>(GlideExecutor.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setUncaughtThrowableStrategy.(Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;)Lcom/bumptech/glide/load/engine/executor/GlideExecutor$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(strategy);
				}
				return @object;
			}

			// Token: 0x040005C0 RID: 1472
			[Register("NO_THREAD_TIMEOUT")]
			public const long NoThreadTimeout = 0L;

			// Token: 0x040005C1 RID: 1473
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/executor/GlideExecutor$Builder", typeof(GlideExecutor.Builder));
		}

		// Token: 0x02000202 RID: 514
		[Register("com/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy", DoNotGenerateAcw = true)]
		public abstract class UncaughtThrowableStrategy : Java.Lang.Object
		{
			// Token: 0x0600181A RID: 6170 RVA: 0x0004A637 File Offset: 0x00048837
			internal UncaughtThrowableStrategy()
			{
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x0600181B RID: 6171 RVA: 0x0004A640 File Offset: 0x00048840
			[Register("DEFAULT")]
			public static GlideExecutor.IUncaughtThrowableStrategy Default
			{
				get
				{
					return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(GlideExecutor.UncaughtThrowableStrategy._members.StaticFields.GetObjectValue("DEFAULT.Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x0600181C RID: 6172 RVA: 0x0004A670 File Offset: 0x00048870
			[Register("IGNORE")]
			public static GlideExecutor.IUncaughtThrowableStrategy Ignore
			{
				get
				{
					return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(GlideExecutor.UncaughtThrowableStrategy._members.StaticFields.GetObjectValue("IGNORE.Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x0600181D RID: 6173 RVA: 0x0004A6A0 File Offset: 0x000488A0
			[Register("LOG")]
			public static GlideExecutor.IUncaughtThrowableStrategy Log
			{
				get
				{
					return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(GlideExecutor.UncaughtThrowableStrategy._members.StaticFields.GetObjectValue("LOG.Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x0600181E RID: 6174 RVA: 0x0004A6D0 File Offset: 0x000488D0
			[Register("THROW")]
			public static GlideExecutor.IUncaughtThrowableStrategy Throw
			{
				get
				{
					return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(GlideExecutor.UncaughtThrowableStrategy._members.StaticFields.GetObjectValue("THROW.Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040005C2 RID: 1474
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy", typeof(GlideExecutor.UncaughtThrowableStrategy));
		}

		// Token: 0x02000203 RID: 515
		[Register("com/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy", DoNotGenerateAcw = true)]
		[Obsolete("Use the 'UncaughtThrowableStrategy' type. This type will be removed in a future release.", true)]
		public abstract class UncaughtThrowableStrategyConsts : GlideExecutor.UncaughtThrowableStrategy
		{
			// Token: 0x06001820 RID: 6176 RVA: 0x0004A71A File Offset: 0x0004891A
			private UncaughtThrowableStrategyConsts()
			{
			}
		}

		// Token: 0x02000204 RID: 516
		[Register("com/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy", "", "Bumptech.Glide.Load.Engine.Executor.GlideExecutor/IUncaughtThrowableStrategyInvoker")]
		public interface IUncaughtThrowableStrategy : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x06001821 RID: 6177 RVA: 0x0004A724 File Offset: 0x00048924
			[Register("DEFAULT")]
			GlideExecutor.IUncaughtThrowableStrategy Default
			{
				get
				{
					return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(GlideExecutor.IUncaughtThrowableStrategy._members.StaticFields.GetObjectValue("DEFAULT.Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x06001822 RID: 6178 RVA: 0x0004A754 File Offset: 0x00048954
			[Register("IGNORE")]
			GlideExecutor.IUncaughtThrowableStrategy Ignore
			{
				get
				{
					return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(GlideExecutor.IUncaughtThrowableStrategy._members.StaticFields.GetObjectValue("IGNORE.Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06001823 RID: 6179 RVA: 0x0004A784 File Offset: 0x00048984
			[Register("LOG")]
			GlideExecutor.IUncaughtThrowableStrategy Log
			{
				get
				{
					return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(GlideExecutor.IUncaughtThrowableStrategy._members.StaticFields.GetObjectValue("LOG.Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06001824 RID: 6180 RVA: 0x0004A7B4 File Offset: 0x000489B4
			[Register("THROW")]
			GlideExecutor.IUncaughtThrowableStrategy Throw
			{
				get
				{
					return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(GlideExecutor.IUncaughtThrowableStrategy._members.StaticFields.GetObjectValue("THROW.Lcom/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06001825 RID: 6181
			[Register("handle", "(Ljava/lang/Throwable;)V", "GetHandle_Ljava_lang_Throwable_Handler:Bumptech.Glide.Load.Engine.Executor.GlideExecutor/IUncaughtThrowableStrategyInvoker, Xamarin.Android.Glide")]
			void Handle(Throwable p0);

			// Token: 0x040005C3 RID: 1475
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy", typeof(GlideExecutor.IUncaughtThrowableStrategy), true);
		}

		// Token: 0x02000205 RID: 517
		[Register("com/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy", DoNotGenerateAcw = true)]
		internal class IUncaughtThrowableStrategyInvoker : Java.Lang.Object, GlideExecutor.IUncaughtThrowableStrategy, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06001827 RID: 6183 RVA: 0x0004A800 File Offset: 0x00048A00
			private static IntPtr java_class_ref
			{
				get
				{
					return GlideExecutor.IUncaughtThrowableStrategyInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x06001828 RID: 6184 RVA: 0x0004A824 File Offset: 0x00048A24
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GlideExecutor.IUncaughtThrowableStrategyInvoker._members;
				}
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x06001829 RID: 6185 RVA: 0x0004A82B File Offset: 0x00048A2B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x0600182A RID: 6186 RVA: 0x0004A833 File Offset: 0x00048A33
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GlideExecutor.IUncaughtThrowableStrategyInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600182B RID: 6187 RVA: 0x0004A83F File Offset: 0x00048A3F
			public static GlideExecutor.IUncaughtThrowableStrategy GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(handle, transfer);
			}

			// Token: 0x0600182C RID: 6188 RVA: 0x0004A848 File Offset: 0x00048A48
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, GlideExecutor.IUncaughtThrowableStrategyInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.executor.GlideExecutor.UncaughtThrowableStrategy'.");
				}
				return handle;
			}

			// Token: 0x0600182D RID: 6189 RVA: 0x0004A873 File Offset: 0x00048A73
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600182E RID: 6190 RVA: 0x0004A8A4 File Offset: 0x00048AA4
			public IUncaughtThrowableStrategyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(GlideExecutor.IUncaughtThrowableStrategyInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600182F RID: 6191 RVA: 0x0004A8DC File Offset: 0x00048ADC
			private static Delegate GetHandle_Ljava_lang_Throwable_Handler()
			{
				if (GlideExecutor.IUncaughtThrowableStrategyInvoker.cb_handle_Ljava_lang_Throwable_ == null)
				{
					GlideExecutor.IUncaughtThrowableStrategyInvoker.cb_handle_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GlideExecutor.IUncaughtThrowableStrategyInvoker.n_Handle_Ljava_lang_Throwable_));
				}
				return GlideExecutor.IUncaughtThrowableStrategyInvoker.cb_handle_Ljava_lang_Throwable_;
			}

			// Token: 0x06001830 RID: 6192 RVA: 0x0004A900 File Offset: 0x00048B00
			private static void n_Handle_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				GlideExecutor.IUncaughtThrowableStrategy @object = Java.Lang.Object.GetObject<GlideExecutor.IUncaughtThrowableStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.Handle(object2);
			}

			// Token: 0x06001831 RID: 6193 RVA: 0x0004A924 File Offset: 0x00048B24
			public new unsafe void Handle(Throwable p0)
			{
				if (this.id_handle_Ljava_lang_Throwable_ == IntPtr.Zero)
				{
					this.id_handle_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "handle", "(Ljava/lang/Throwable;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_handle_Ljava_lang_Throwable_, ptr);
			}

			// Token: 0x040005C4 RID: 1476
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/executor/GlideExecutor$UncaughtThrowableStrategy", typeof(GlideExecutor.IUncaughtThrowableStrategyInvoker));

			// Token: 0x040005C5 RID: 1477
			private IntPtr class_ref;

			// Token: 0x040005C6 RID: 1478
			private static Delegate cb_handle_Ljava_lang_Throwable_;

			// Token: 0x040005C7 RID: 1479
			private IntPtr id_handle_Ljava_lang_Throwable_;
		}
	}
}
