using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Provider
{
	// Token: 0x02000062 RID: 98
	[Register("com/bumptech/glide/provider/ModelToResourceClassCache", DoNotGenerateAcw = true)]
	public class ModelToResourceClassCache : Java.Lang.Object
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000ECD4 File Offset: 0x0000CED4
		internal static IntPtr class_ref
		{
			get
			{
				return ModelToResourceClassCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ModelToResourceClassCache._members;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000ED00 File Offset: 0x0000CF00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ModelToResourceClassCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0000ED24 File Offset: 0x0000CF24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ModelToResourceClassCache._members.ManagedPeerType;
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000ED30 File Offset: 0x0000CF30
		protected ModelToResourceClassCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000ED3C File Offset: 0x0000CF3C
		[Register(".ctor", "()V", "")]
		public ModelToResourceClassCache() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ModelToResourceClassCache._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ModelToResourceClassCache._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000EDAA File Offset: 0x0000CFAA
		private static Delegate GetClearHandler()
		{
			if (ModelToResourceClassCache.cb_clear == null)
			{
				ModelToResourceClassCache.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ModelToResourceClassCache.n_Clear));
			}
			return ModelToResourceClassCache.cb_clear;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000EDCE File Offset: 0x0000CFCE
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ModelToResourceClassCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000EDDD File Offset: 0x0000CFDD
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			ModelToResourceClassCache._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
		private static Delegate GetGet_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (ModelToResourceClassCache.cb_get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				ModelToResourceClassCache.cb_get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ModelToResourceClassCache.n_Get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return ModelToResourceClassCache.cb_get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000EE1C File Offset: 0x0000D01C
		private static IntPtr n_Get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_resourceClass, IntPtr native_transcodeClass)
		{
			ModelToResourceClassCache @object = Java.Lang.Object.GetObject<ModelToResourceClassCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			return JavaList<Class>.ToLocalJniHandle(@object.Get(object2, object3, object4));
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000EE58 File Offset: 0x0000D058
		[Register("get", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", "GetGet_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		public unsafe virtual IList<Class> Get(Class modelClass, Class resourceClass, Class transcodeClass)
		{
			IList<Class> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				result = JavaList<Class>.FromJniHandle(ModelToResourceClassCache._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
			}
			return result;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000EF20 File Offset: 0x0000D120
		private static Delegate GetPut_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Ljava_util_List_Handler()
		{
			if (ModelToResourceClassCache.cb_put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Ljava_util_List_ == null)
			{
				ModelToResourceClassCache.cb_put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(ModelToResourceClassCache.n_Put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Ljava_util_List_));
			}
			return ModelToResourceClassCache.cb_put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Ljava_util_List_;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000EF44 File Offset: 0x0000D144
		private static void n_Put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_resourceClass, IntPtr native_transcodeClass, IntPtr native_resourceClasses)
		{
			ModelToResourceClassCache @object = Java.Lang.Object.GetObject<ModelToResourceClassCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			IList<Class> resourceClasses = JavaList<Class>.FromJniHandle(native_resourceClasses, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2, object3, object4, resourceClasses);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000EF84 File Offset: 0x0000D184
		[Register("put", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/util/List;)V", "GetPut_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Ljava_util_List_Handler")]
		public unsafe virtual void Put(Class modelClass, Class resourceClass, Class transcodeClass, IList<Class> resourceClasses)
		{
			IntPtr intPtr = JavaList<Class>.ToLocalJniHandle(resourceClasses);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				ModelToResourceClassCache._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(modelClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(resourceClasses);
			}
		}

		// Token: 0x040000E6 RID: 230
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/provider/ModelToResourceClassCache", typeof(ModelToResourceClassCache));

		// Token: 0x040000E7 RID: 231
		private static Delegate cb_clear;

		// Token: 0x040000E8 RID: 232
		private static Delegate cb_get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040000E9 RID: 233
		private static Delegate cb_put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Ljava_util_List_;
	}
}
