using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x0200017A RID: 378
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/ArrayPool", DoNotGenerateAcw = true)]
	internal class IArrayPoolInvoker : Java.Lang.Object, IArrayPool, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0003C0DC File Offset: 0x0003A2DC
		private static IntPtr java_class_ref
		{
			get
			{
				return IArrayPoolInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x0003C100 File Offset: 0x0003A300
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IArrayPoolInvoker._members;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0003C107 File Offset: 0x0003A307
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x0003C10F File Offset: 0x0003A30F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IArrayPoolInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0003C11B File Offset: 0x0003A31B
		public static IArrayPool GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IArrayPool>(handle, transfer);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0003C124 File Offset: 0x0003A324
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IArrayPoolInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.bitmap_recycle.ArrayPool'.");
			}
			return handle;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0003C14F File Offset: 0x0003A34F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0003C180 File Offset: 0x0003A380
		public IArrayPoolInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IArrayPoolInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0003C1B8 File Offset: 0x0003A3B8
		private static Delegate GetClearMemoryHandler()
		{
			if (IArrayPoolInvoker.cb_clearMemory == null)
			{
				IArrayPoolInvoker.cb_clearMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IArrayPoolInvoker.n_ClearMemory));
			}
			return IArrayPoolInvoker.cb_clearMemory;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0003C1DC File Offset: 0x0003A3DC
		private static void n_ClearMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IArrayPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearMemory();
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0003C1EB File Offset: 0x0003A3EB
		public void ClearMemory()
		{
			if (this.id_clearMemory == IntPtr.Zero)
			{
				this.id_clearMemory = JNIEnv.GetMethodID(this.class_ref, "clearMemory", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearMemory);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0003C22B File Offset: 0x0003A42B
		private static Delegate GetGet_ILjava_lang_Class_Handler()
		{
			if (IArrayPoolInvoker.cb_get_ILjava_lang_Class_ == null)
			{
				IArrayPoolInvoker.cb_get_ILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(IArrayPoolInvoker.n_Get_ILjava_lang_Class_));
			}
			return IArrayPoolInvoker.cb_get_ILjava_lang_Class_;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0003C250 File Offset: 0x0003A450
		private static IntPtr n_Get_ILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IArrayPool @object = Java.Lang.Object.GetObject<IArrayPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(p0, object2));
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0003C27C File Offset: 0x0003A47C
		public unsafe Java.Lang.Object Get(int p0, Class p1)
		{
			if (this.id_get_ILjava_lang_Class_ == IntPtr.Zero)
			{
				this.id_get_ILjava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "get", "(ILjava/lang/Class;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_ILjava_lang_Class_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0003C308 File Offset: 0x0003A508
		private static Delegate GetGetExact_ILjava_lang_Class_Handler()
		{
			if (IArrayPoolInvoker.cb_getExact_ILjava_lang_Class_ == null)
			{
				IArrayPoolInvoker.cb_getExact_ILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(IArrayPoolInvoker.n_GetExact_ILjava_lang_Class_));
			}
			return IArrayPoolInvoker.cb_getExact_ILjava_lang_Class_;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0003C32C File Offset: 0x0003A52C
		private static IntPtr n_GetExact_ILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IArrayPool @object = Java.Lang.Object.GetObject<IArrayPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetExact(p0, object2));
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0003C358 File Offset: 0x0003A558
		public unsafe Java.Lang.Object GetExact(int p0, Class p1)
		{
			if (this.id_getExact_ILjava_lang_Class_ == IntPtr.Zero)
			{
				this.id_getExact_ILjava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "getExact", "(ILjava/lang/Class;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getExact_ILjava_lang_Class_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0003C3E4 File Offset: 0x0003A5E4
		private static Delegate GetPut_Ljava_lang_Object_Handler()
		{
			if (IArrayPoolInvoker.cb_put_Ljava_lang_Object_ == null)
			{
				IArrayPoolInvoker.cb_put_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IArrayPoolInvoker.n_Put_Ljava_lang_Object_));
			}
			return IArrayPoolInvoker.cb_put_Ljava_lang_Object_;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0003C408 File Offset: 0x0003A608
		private static void n_Put_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IArrayPool @object = Java.Lang.Object.GetObject<IArrayPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0003C42C File Offset: 0x0003A62C
		public unsafe void Put(Java.Lang.Object p0)
		{
			if (this.id_put_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_put_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "put", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_put_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0003C49D File Offset: 0x0003A69D
		[Obsolete]
		private static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Class_Handler()
		{
			if (IArrayPoolInvoker.cb_put_Ljava_lang_Object_Ljava_lang_Class_ == null)
			{
				IArrayPoolInvoker.cb_put_Ljava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IArrayPoolInvoker.n_Put_Ljava_lang_Object_Ljava_lang_Class_));
			}
			return IArrayPoolInvoker.cb_put_Ljava_lang_Object_Ljava_lang_Class_;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0003C4C4 File Offset: 0x0003A6C4
		[Obsolete]
		private static void n_Put_Ljava_lang_Object_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IArrayPool @object = Java.Lang.Object.GetObject<IArrayPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2, object3);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0003C4F0 File Offset: 0x0003A6F0
		public unsafe void Put(Java.Lang.Object p0, Class p1)
		{
			if (this.id_put_Ljava_lang_Object_Ljava_lang_Class_ == IntPtr.Zero)
			{
				this.id_put_Ljava_lang_Object_Ljava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Class;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_put_Ljava_lang_Object_Ljava_lang_Class_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0003C583 File Offset: 0x0003A783
		private static Delegate GetTrimMemory_IHandler()
		{
			if (IArrayPoolInvoker.cb_trimMemory_I == null)
			{
				IArrayPoolInvoker.cb_trimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IArrayPoolInvoker.n_TrimMemory_I));
			}
			return IArrayPoolInvoker.cb_trimMemory_I;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0003C5A7 File Offset: 0x0003A7A7
		private static void n_TrimMemory_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IArrayPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimMemory(p0);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0003C5B8 File Offset: 0x0003A7B8
		public unsafe void TrimMemory(int p0)
		{
			if (this.id_trimMemory_I == IntPtr.Zero)
			{
				this.id_trimMemory_I = JNIEnv.GetMethodID(this.class_ref, "trimMemory", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_trimMemory_I, ptr);
		}

		// Token: 0x04000460 RID: 1120
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/ArrayPool", typeof(IArrayPoolInvoker));

		// Token: 0x04000461 RID: 1121
		private IntPtr class_ref;

		// Token: 0x04000462 RID: 1122
		private static Delegate cb_clearMemory;

		// Token: 0x04000463 RID: 1123
		private IntPtr id_clearMemory;

		// Token: 0x04000464 RID: 1124
		private static Delegate cb_get_ILjava_lang_Class_;

		// Token: 0x04000465 RID: 1125
		private IntPtr id_get_ILjava_lang_Class_;

		// Token: 0x04000466 RID: 1126
		private static Delegate cb_getExact_ILjava_lang_Class_;

		// Token: 0x04000467 RID: 1127
		private IntPtr id_getExact_ILjava_lang_Class_;

		// Token: 0x04000468 RID: 1128
		private static Delegate cb_put_Ljava_lang_Object_;

		// Token: 0x04000469 RID: 1129
		private IntPtr id_put_Ljava_lang_Object_;

		// Token: 0x0400046A RID: 1130
		private static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Class_;

		// Token: 0x0400046B RID: 1131
		private IntPtr id_put_Ljava_lang_Object_Ljava_lang_Class_;

		// Token: 0x0400046C RID: 1132
		private static Delegate cb_trimMemory_I;

		// Token: 0x0400046D RID: 1133
		private IntPtr id_trimMemory_I;
	}
}
