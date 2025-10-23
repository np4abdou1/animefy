using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000169 RID: 361
	[Register("com/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener", DoNotGenerateAcw = true)]
	internal class IMemoryCacheResourceRemovedListenerInvoker : Java.Lang.Object, IMemoryCacheResourceRemovedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00039EC8 File Offset: 0x000380C8
		private static IntPtr java_class_ref
		{
			get
			{
				return IMemoryCacheResourceRemovedListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00039EEC File Offset: 0x000380EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMemoryCacheResourceRemovedListenerInvoker._members;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00039EF3 File Offset: 0x000380F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00039EFB File Offset: 0x000380FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMemoryCacheResourceRemovedListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00039F07 File Offset: 0x00038107
		public static IMemoryCacheResourceRemovedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMemoryCacheResourceRemovedListener>(handle, transfer);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00039F10 File Offset: 0x00038110
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMemoryCacheResourceRemovedListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.cache.MemoryCache.ResourceRemovedListener'.");
			}
			return handle;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00039F3B File Offset: 0x0003813B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00039F6C File Offset: 0x0003816C
		public IMemoryCacheResourceRemovedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMemoryCacheResourceRemovedListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00039FA4 File Offset: 0x000381A4
		private static Delegate GetOnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (IMemoryCacheResourceRemovedListenerInvoker.cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				IMemoryCacheResourceRemovedListenerInvoker.cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMemoryCacheResourceRemovedListenerInvoker.n_OnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return IMemoryCacheResourceRemovedListenerInvoker.cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00039FC8 File Offset: 0x000381C8
		private static void n_OnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMemoryCacheResourceRemovedListener @object = Java.Lang.Object.GetObject<IMemoryCacheResourceRemovedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceRemoved(object2);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00039FEC File Offset: 0x000381EC
		public unsafe void OnResourceRemoved(IResource p0)
		{
			if (this.id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
			{
				this.id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID(this.class_ref, "onResourceRemoved", "(Lcom/bumptech/glide/load/engine/Resource;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_, ptr);
		}

		// Token: 0x04000424 RID: 1060
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener", typeof(IMemoryCacheResourceRemovedListenerInvoker));

		// Token: 0x04000425 RID: 1061
		private IntPtr class_ref;

		// Token: 0x04000426 RID: 1062
		private static Delegate cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x04000427 RID: 1063
		private IntPtr id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;
	}
}
