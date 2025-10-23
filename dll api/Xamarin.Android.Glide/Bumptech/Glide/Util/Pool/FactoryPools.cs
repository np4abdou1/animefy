using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util.Pool
{
	// Token: 0x02000056 RID: 86
	[Register("com/bumptech/glide/util/pool/FactoryPools", DoNotGenerateAcw = true)]
	public sealed class FactoryPools : Java.Lang.Object
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000D594 File Offset: 0x0000B794
		internal static IntPtr class_ref
		{
			get
			{
				return FactoryPools._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FactoryPools._members;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FactoryPools._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FactoryPools._members.ManagedPeerType;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		internal FactoryPools(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		[Register("simple", "(ILcom/bumptech/glide/util/pool/FactoryPools$Factory;)Landroidx/core/util/Pools$Pool;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends com.bumptech.glide.util.pool.FactoryPools.Poolable"
		})]
		public unsafe static Pools.IPool Simple(int size, FactoryPools.IFactory factory)
		{
			Pools.IPool @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(size);
				ptr[1] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				@object = Java.Lang.Object.GetObject<Pools.IPool>(FactoryPools._members.StaticMethods.InvokeObjectMethod("simple.(ILcom/bumptech/glide/util/pool/FactoryPools$Factory;)Landroidx/core/util/Pools$Pool;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(factory);
			}
			return @object;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000D688 File Offset: 0x0000B888
		[Register("threadSafe", "(ILcom/bumptech/glide/util/pool/FactoryPools$Factory;)Landroidx/core/util/Pools$Pool;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends com.bumptech.glide.util.pool.FactoryPools.Poolable"
		})]
		public unsafe static Pools.IPool ThreadSafe(int size, FactoryPools.IFactory factory)
		{
			Pools.IPool @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(size);
				ptr[1] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				@object = Java.Lang.Object.GetObject<Pools.IPool>(FactoryPools._members.StaticMethods.InvokeObjectMethod("threadSafe.(ILcom/bumptech/glide/util/pool/FactoryPools$Factory;)Landroidx/core/util/Pools$Pool;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(factory);
			}
			return @object;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000D714 File Offset: 0x0000B914
		[Register("threadSafeList", "()Landroidx/core/util/Pools$Pool;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static Pools.IPool ThreadSafeList()
		{
			return Java.Lang.Object.GetObject<Pools.IPool>(FactoryPools._members.StaticMethods.InvokeObjectMethod("threadSafeList.()Landroidx/core/util/Pools$Pool;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000D748 File Offset: 0x0000B948
		[Register("threadSafeList", "(I)Landroidx/core/util/Pools$Pool;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Pools.IPool ThreadSafeList(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return Java.Lang.Object.GetObject<Pools.IPool>(FactoryPools._members.StaticMethods.InvokeObjectMethod("threadSafeList.(I)Landroidx/core/util/Pools$Pool;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000D2 RID: 210
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/pool/FactoryPools", typeof(FactoryPools));

		// Token: 0x020001B1 RID: 433
		[Register("com/bumptech/glide/util/pool/FactoryPools$Factory", "", "Bumptech.Glide.Util.Pool.FactoryPools/IFactoryInvoker")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public interface IFactory : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001577 RID: 5495
			[Register("create", "()Ljava/lang/Object;", "GetCreateHandler:Bumptech.Glide.Util.Pool.FactoryPools/IFactoryInvoker, Xamarin.Android.Glide")]
			Java.Lang.Object Create();
		}

		// Token: 0x020001B2 RID: 434
		[Register("com/bumptech/glide/util/pool/FactoryPools$Factory", DoNotGenerateAcw = true)]
		internal class IFactoryInvoker : Java.Lang.Object, FactoryPools.IFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x06001578 RID: 5496 RVA: 0x00043B2C File Offset: 0x00041D2C
			private static IntPtr java_class_ref
			{
				get
				{
					return FactoryPools.IFactoryInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06001579 RID: 5497 RVA: 0x00043B50 File Offset: 0x00041D50
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FactoryPools.IFactoryInvoker._members;
				}
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x0600157A RID: 5498 RVA: 0x00043B57 File Offset: 0x00041D57
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x0600157B RID: 5499 RVA: 0x00043B5F File Offset: 0x00041D5F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FactoryPools.IFactoryInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600157C RID: 5500 RVA: 0x00043B6B File Offset: 0x00041D6B
			public static FactoryPools.IFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<FactoryPools.IFactory>(handle, transfer);
			}

			// Token: 0x0600157D RID: 5501 RVA: 0x00043B74 File Offset: 0x00041D74
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, FactoryPools.IFactoryInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.util.pool.FactoryPools.Factory'.");
				}
				return handle;
			}

			// Token: 0x0600157E RID: 5502 RVA: 0x00043B9F File Offset: 0x00041D9F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600157F RID: 5503 RVA: 0x00043BD0 File Offset: 0x00041DD0
			public IFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(FactoryPools.IFactoryInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001580 RID: 5504 RVA: 0x00043C08 File Offset: 0x00041E08
			private static Delegate GetCreateHandler()
			{
				if (FactoryPools.IFactoryInvoker.cb_create == null)
				{
					FactoryPools.IFactoryInvoker.cb_create = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FactoryPools.IFactoryInvoker.n_Create));
				}
				return FactoryPools.IFactoryInvoker.cb_create;
			}

			// Token: 0x06001581 RID: 5505 RVA: 0x00043C2C File Offset: 0x00041E2C
			private static IntPtr n_Create(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FactoryPools.IFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Create());
			}

			// Token: 0x06001582 RID: 5506 RVA: 0x00043C40 File Offset: 0x00041E40
			public Java.Lang.Object Create()
			{
				if (this.id_create == IntPtr.Zero)
				{
					this.id_create = JNIEnv.GetMethodID(this.class_ref, "create", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_create), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000518 RID: 1304
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/pool/FactoryPools$Factory", typeof(FactoryPools.IFactoryInvoker));

			// Token: 0x04000519 RID: 1305
			private IntPtr class_ref;

			// Token: 0x0400051A RID: 1306
			private static Delegate cb_create;

			// Token: 0x0400051B RID: 1307
			private IntPtr id_create;
		}

		// Token: 0x020001B3 RID: 435
		[Register("com/bumptech/glide/util/pool/FactoryPools$Poolable", "", "Bumptech.Glide.Util.Pool.FactoryPools/IPoolableInvoker")]
		public interface IPoolable : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06001584 RID: 5508
			StateVerifier Verifier { [Register("getVerifier", "()Lcom/bumptech/glide/util/pool/StateVerifier;", "GetGetVerifierHandler:Bumptech.Glide.Util.Pool.FactoryPools/IPoolableInvoker, Xamarin.Android.Glide")] get; }
		}

		// Token: 0x020001B4 RID: 436
		[Register("com/bumptech/glide/util/pool/FactoryPools$Poolable", DoNotGenerateAcw = true)]
		internal class IPoolableInvoker : Java.Lang.Object, FactoryPools.IPoolable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x06001585 RID: 5509 RVA: 0x00043CAC File Offset: 0x00041EAC
			private static IntPtr java_class_ref
			{
				get
				{
					return FactoryPools.IPoolableInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005C7 RID: 1479
			// (get) Token: 0x06001586 RID: 5510 RVA: 0x00043CD0 File Offset: 0x00041ED0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FactoryPools.IPoolableInvoker._members;
				}
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x06001587 RID: 5511 RVA: 0x00043CD7 File Offset: 0x00041ED7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x06001588 RID: 5512 RVA: 0x00043CDF File Offset: 0x00041EDF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FactoryPools.IPoolableInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06001589 RID: 5513 RVA: 0x00043CEB File Offset: 0x00041EEB
			public static FactoryPools.IPoolable GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<FactoryPools.IPoolable>(handle, transfer);
			}

			// Token: 0x0600158A RID: 5514 RVA: 0x00043CF4 File Offset: 0x00041EF4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, FactoryPools.IPoolableInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.util.pool.FactoryPools.Poolable'.");
				}
				return handle;
			}

			// Token: 0x0600158B RID: 5515 RVA: 0x00043D1F File Offset: 0x00041F1F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600158C RID: 5516 RVA: 0x00043D50 File Offset: 0x00041F50
			public IPoolableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(FactoryPools.IPoolableInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600158D RID: 5517 RVA: 0x00043D88 File Offset: 0x00041F88
			private static Delegate GetGetVerifierHandler()
			{
				if (FactoryPools.IPoolableInvoker.cb_getVerifier == null)
				{
					FactoryPools.IPoolableInvoker.cb_getVerifier = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FactoryPools.IPoolableInvoker.n_GetVerifier));
				}
				return FactoryPools.IPoolableInvoker.cb_getVerifier;
			}

			// Token: 0x0600158E RID: 5518 RVA: 0x00043DAC File Offset: 0x00041FAC
			private static IntPtr n_GetVerifier(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FactoryPools.IPoolable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Verifier);
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x0600158F RID: 5519 RVA: 0x00043DC0 File Offset: 0x00041FC0
			public StateVerifier Verifier
			{
				get
				{
					if (this.id_getVerifier == IntPtr.Zero)
					{
						this.id_getVerifier = JNIEnv.GetMethodID(this.class_ref, "getVerifier", "()Lcom/bumptech/glide/util/pool/StateVerifier;");
					}
					return Java.Lang.Object.GetObject<StateVerifier>(JNIEnv.CallObjectMethod(base.Handle, this.id_getVerifier), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0400051C RID: 1308
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/pool/FactoryPools$Poolable", typeof(FactoryPools.IPoolableInvoker));

			// Token: 0x0400051D RID: 1309
			private IntPtr class_ref;

			// Token: 0x0400051E RID: 1310
			private static Delegate cb_getVerifier;

			// Token: 0x0400051F RID: 1311
			private IntPtr id_getVerifier;
		}

		// Token: 0x020001B5 RID: 437
		[Register("com/bumptech/glide/util/pool/FactoryPools$Resetter", "", "Bumptech.Glide.Util.Pool.FactoryPools/IResetterInvoker")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public interface IResetter : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001591 RID: 5521
			[Register("reset", "(Ljava/lang/Object;)V", "GetReset_Ljava_lang_Object_Handler:Bumptech.Glide.Util.Pool.FactoryPools/IResetterInvoker, Xamarin.Android.Glide")]
			void Reset(Java.Lang.Object p0);
		}

		// Token: 0x020001B6 RID: 438
		[Register("com/bumptech/glide/util/pool/FactoryPools$Resetter", DoNotGenerateAcw = true)]
		internal class IResetterInvoker : Java.Lang.Object, FactoryPools.IResetter, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x06001592 RID: 5522 RVA: 0x00043E2C File Offset: 0x0004202C
			private static IntPtr java_class_ref
			{
				get
				{
					return FactoryPools.IResetterInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x06001593 RID: 5523 RVA: 0x00043E50 File Offset: 0x00042050
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FactoryPools.IResetterInvoker._members;
				}
			}

			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x06001594 RID: 5524 RVA: 0x00043E57 File Offset: 0x00042057
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x06001595 RID: 5525 RVA: 0x00043E5F File Offset: 0x0004205F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FactoryPools.IResetterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06001596 RID: 5526 RVA: 0x00043E6B File Offset: 0x0004206B
			public static FactoryPools.IResetter GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<FactoryPools.IResetter>(handle, transfer);
			}

			// Token: 0x06001597 RID: 5527 RVA: 0x00043E74 File Offset: 0x00042074
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, FactoryPools.IResetterInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.util.pool.FactoryPools.Resetter'.");
				}
				return handle;
			}

			// Token: 0x06001598 RID: 5528 RVA: 0x00043E9F File Offset: 0x0004209F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001599 RID: 5529 RVA: 0x00043ED0 File Offset: 0x000420D0
			public IResetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(FactoryPools.IResetterInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600159A RID: 5530 RVA: 0x00043F08 File Offset: 0x00042108
			private static Delegate GetReset_Ljava_lang_Object_Handler()
			{
				if (FactoryPools.IResetterInvoker.cb_reset_Ljava_lang_Object_ == null)
				{
					FactoryPools.IResetterInvoker.cb_reset_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FactoryPools.IResetterInvoker.n_Reset_Ljava_lang_Object_));
				}
				return FactoryPools.IResetterInvoker.cb_reset_Ljava_lang_Object_;
			}

			// Token: 0x0600159B RID: 5531 RVA: 0x00043F2C File Offset: 0x0004212C
			private static void n_Reset_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				FactoryPools.IResetter @object = Java.Lang.Object.GetObject<FactoryPools.IResetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.Reset(object2);
			}

			// Token: 0x0600159C RID: 5532 RVA: 0x00043F50 File Offset: 0x00042150
			public unsafe void Reset(Java.Lang.Object p0)
			{
				if (this.id_reset_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_reset_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "reset", "(Ljava/lang/Object;)V");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_reset_Ljava_lang_Object_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x04000520 RID: 1312
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/pool/FactoryPools$Resetter", typeof(FactoryPools.IResetterInvoker));

			// Token: 0x04000521 RID: 1313
			private IntPtr class_ref;

			// Token: 0x04000522 RID: 1314
			private static Delegate cb_reset_Ljava_lang_Object_;

			// Token: 0x04000523 RID: 1315
			private IntPtr id_reset_Ljava_lang_Object_;
		}
	}
}
