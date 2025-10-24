using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000141 RID: 321
	[Register("com/bumptech/glide/load/model/ModelCache", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"A",
		"B"
	})]
	public class ModelCache : Java.Lang.Object
	{
		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00033C98 File Offset: 0x00031E98
		internal static IntPtr class_ref
		{
			get
			{
				return ModelCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00033CBC File Offset: 0x00031EBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ModelCache._members;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x00033CC4 File Offset: 0x00031EC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ModelCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00033CE8 File Offset: 0x00031EE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ModelCache._members.ManagedPeerType;
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00033CF4 File Offset: 0x00031EF4
		protected ModelCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00033D00 File Offset: 0x00031F00
		[Register(".ctor", "()V", "")]
		public ModelCache() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ModelCache._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ModelCache._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00033D70 File Offset: 0x00031F70
		[Register(".ctor", "(J)V", "")]
		public unsafe ModelCache(long size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(ModelCache._members.InstanceMethods.StartCreateInstance("(J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ModelCache._members.InstanceMethods.FinishCreateInstance("(J)V", this, ptr);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00033DF4 File Offset: 0x00031FF4
		private static Delegate GetClearHandler()
		{
			if (ModelCache.cb_clear == null)
			{
				ModelCache.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ModelCache.n_Clear));
			}
			return ModelCache.cb_clear;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00033E18 File Offset: 0x00032018
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ModelCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00033E27 File Offset: 0x00032027
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			ModelCache._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00033E40 File Offset: 0x00032040
		private static Delegate GetGet_Ljava_lang_Object_IIHandler()
		{
			if (ModelCache.cb_get_Ljava_lang_Object_II == null)
			{
				ModelCache.cb_get_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(ModelCache.n_Get_Ljava_lang_Object_II));
			}
			return ModelCache.cb_get_Ljava_lang_Object_II;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00033E64 File Offset: 0x00032064
		private static IntPtr n_Get_Ljava_lang_Object_II(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height)
		{
			ModelCache @object = Java.Lang.Object.GetObject<ModelCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2, width, height));
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00033E90 File Offset: 0x00032090
		[Register("get", "(Ljava/lang/Object;II)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_IIHandler")]
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object model, int width, int height)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ModelCache._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;II)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
			}
			return @object;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00033F2C File Offset: 0x0003212C
		private static Delegate GetPut_Ljava_lang_Object_IILjava_lang_Object_Handler()
		{
			if (ModelCache.cb_put_Ljava_lang_Object_IILjava_lang_Object_ == null)
			{
				ModelCache.cb_put_Ljava_lang_Object_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_V(ModelCache.n_Put_Ljava_lang_Object_IILjava_lang_Object_));
			}
			return ModelCache.cb_put_Ljava_lang_Object_IILjava_lang_Object_;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00033F50 File Offset: 0x00032150
		private static void n_Put_Ljava_lang_Object_IILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_value)
		{
			ModelCache @object = Java.Lang.Object.GetObject<ModelCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2, width, height, object3);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00033F80 File Offset: 0x00032180
		[Register("put", "(Ljava/lang/Object;IILjava/lang/Object;)V", "GetPut_Ljava_lang_Object_IILjava_lang_Object_Handler")]
		public unsafe virtual void Put(Java.Lang.Object model, int width, int height, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue(intPtr2);
				ModelCache._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Ljava/lang/Object;IILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(model);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x040003B9 RID: 953
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ModelCache", typeof(ModelCache));

		// Token: 0x040003BA RID: 954
		private static Delegate cb_clear;

		// Token: 0x040003BB RID: 955
		private static Delegate cb_get_Ljava_lang_Object_II;

		// Token: 0x040003BC RID: 956
		private static Delegate cb_put_Ljava_lang_Object_IILjava_lang_Object_;
	}
}
