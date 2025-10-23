using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000157 RID: 343
	[Register("com/bumptech/glide/load/engine/Resource", DoNotGenerateAcw = true)]
	internal class IResourceInvoker : Java.Lang.Object, IResource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00037E48 File Offset: 0x00036048
		private static IntPtr java_class_ref
		{
			get
			{
				return IResourceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00037E6C File Offset: 0x0003606C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IResourceInvoker._members;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x00037E73 File Offset: 0x00036073
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00037E7B File Offset: 0x0003607B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IResourceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00037E87 File Offset: 0x00036087
		public static IResource GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IResource>(handle, transfer);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00037E90 File Offset: 0x00036090
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IResourceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.Resource'.");
			}
			return handle;
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00037EBB File Offset: 0x000360BB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00037EEC File Offset: 0x000360EC
		public IResourceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IResourceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00037F24 File Offset: 0x00036124
		private static Delegate GetGetResourceClassHandler()
		{
			if (IResourceInvoker.cb_getResourceClass == null)
			{
				IResourceInvoker.cb_getResourceClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IResourceInvoker.n_GetResourceClass));
			}
			return IResourceInvoker.cb_getResourceClass;
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00037F48 File Offset: 0x00036148
		private static IntPtr n_GetResourceClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResourceClass);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00037F5C File Offset: 0x0003615C
		public Class ResourceClass
		{
			get
			{
				if (this.id_getResourceClass == IntPtr.Zero)
				{
					this.id_getResourceClass = JNIEnv.GetMethodID(this.class_ref, "getResourceClass", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_getResourceClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00037FAD File Offset: 0x000361AD
		private static Delegate GetGetSizeHandler()
		{
			if (IResourceInvoker.cb_getSize == null)
			{
				IResourceInvoker.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IResourceInvoker.n_GetSize));
			}
			return IResourceInvoker.cb_getSize;
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00037FD1 File Offset: 0x000361D1
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00037FE0 File Offset: 0x000361E0
		public int Size
		{
			get
			{
				if (this.id_getSize == IntPtr.Zero)
				{
					this.id_getSize = JNIEnv.GetMethodID(this.class_ref, "getSize", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getSize);
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00038020 File Offset: 0x00036220
		private static Delegate GetGetHandler()
		{
			if (IResourceInvoker.cb_get == null)
			{
				IResourceInvoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IResourceInvoker.n_Get));
			}
			return IResourceInvoker.cb_get;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00038044 File Offset: 0x00036244
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00038058 File Offset: 0x00036258
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x000380A9 File Offset: 0x000362A9
		private static Delegate GetRecycleHandler()
		{
			if (IResourceInvoker.cb_recycle == null)
			{
				IResourceInvoker.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IResourceInvoker.n_Recycle));
			}
			return IResourceInvoker.cb_recycle;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x000380CD File Offset: 0x000362CD
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x000380DC File Offset: 0x000362DC
		public void Recycle()
		{
			if (this.id_recycle == IntPtr.Zero)
			{
				this.id_recycle = JNIEnv.GetMethodID(this.class_ref, "recycle", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_recycle);
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/Resource", typeof(IResourceInvoker));

		// Token: 0x040003F5 RID: 1013
		private IntPtr class_ref;

		// Token: 0x040003F6 RID: 1014
		private static Delegate cb_getResourceClass;

		// Token: 0x040003F7 RID: 1015
		private IntPtr id_getResourceClass;

		// Token: 0x040003F8 RID: 1016
		private static Delegate cb_getSize;

		// Token: 0x040003F9 RID: 1017
		private IntPtr id_getSize;

		// Token: 0x040003FA RID: 1018
		private static Delegate cb_get;

		// Token: 0x040003FB RID: 1019
		private IntPtr id_get;

		// Token: 0x040003FC RID: 1020
		private static Delegate cb_recycle;

		// Token: 0x040003FD RID: 1021
		private IntPtr id_recycle;
	}
}
