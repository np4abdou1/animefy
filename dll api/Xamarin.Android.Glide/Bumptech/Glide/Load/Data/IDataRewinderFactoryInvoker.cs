using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000196 RID: 406
	[Register("com/bumptech/glide/load/data/DataRewinder$Factory", DoNotGenerateAcw = true)]
	internal class IDataRewinderFactoryInvoker : Java.Lang.Object, IDataRewinderFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x00041554 File Offset: 0x0003F754
		private static IntPtr java_class_ref
		{
			get
			{
				return IDataRewinderFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x00041578 File Offset: 0x0003F778
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDataRewinderFactoryInvoker._members;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0004157F File Offset: 0x0003F77F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x00041587 File Offset: 0x0003F787
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDataRewinderFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00041593 File Offset: 0x0003F793
		public static IDataRewinderFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDataRewinderFactory>(handle, transfer);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0004159C File Offset: 0x0003F79C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDataRewinderFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.data.DataRewinder.Factory'.");
			}
			return handle;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x000415C7 File Offset: 0x0003F7C7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x000415F8 File Offset: 0x0003F7F8
		public IDataRewinderFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDataRewinderFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00041630 File Offset: 0x0003F830
		private static Delegate GetGetDataClassHandler()
		{
			if (IDataRewinderFactoryInvoker.cb_getDataClass == null)
			{
				IDataRewinderFactoryInvoker.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDataRewinderFactoryInvoker.n_GetDataClass));
			}
			return IDataRewinderFactoryInvoker.cb_getDataClass;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00041654 File Offset: 0x0003F854
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDataRewinderFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x00041668 File Offset: 0x0003F868
		public Class DataClass
		{
			get
			{
				if (this.id_getDataClass == IntPtr.Zero)
				{
					this.id_getDataClass = JNIEnv.GetMethodID(this.class_ref, "getDataClass", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDataClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x000416B9 File Offset: 0x0003F8B9
		private static Delegate GetBuild_Ljava_lang_Object_Handler()
		{
			if (IDataRewinderFactoryInvoker.cb_build_Ljava_lang_Object_ == null)
			{
				IDataRewinderFactoryInvoker.cb_build_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDataRewinderFactoryInvoker.n_Build_Ljava_lang_Object_));
			}
			return IDataRewinderFactoryInvoker.cb_build_Ljava_lang_Object_;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000416E0 File Offset: 0x0003F8E0
		private static IntPtr n_Build_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDataRewinderFactory @object = Java.Lang.Object.GetObject<IDataRewinderFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2));
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00041708 File Offset: 0x0003F908
		public unsafe IDataRewinder Build(Java.Lang.Object p0)
		{
			if (this.id_build_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_build_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "build", "(Ljava/lang/Object;)Lcom/bumptech/glide/load/data/DataRewinder;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IDataRewinder @object = Java.Lang.Object.GetObject<IDataRewinder>(JNIEnv.CallObjectMethod(base.Handle, this.id_build_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x040004DD RID: 1245
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/DataRewinder$Factory", typeof(IDataRewinderFactoryInvoker));

		// Token: 0x040004DE RID: 1246
		private IntPtr class_ref;

		// Token: 0x040004DF RID: 1247
		private static Delegate cb_getDataClass;

		// Token: 0x040004E0 RID: 1248
		private IntPtr id_getDataClass;

		// Token: 0x040004E1 RID: 1249
		private static Delegate cb_build_Ljava_lang_Object_;

		// Token: 0x040004E2 RID: 1250
		private IntPtr id_build_Ljava_lang_Object_;
	}
}
