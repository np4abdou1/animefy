using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Properties
{
	// Token: 0x02000149 RID: 329
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/properties/ReadWriteProperty", DoNotGenerateAcw = true)]
	internal class IReadWritePropertyInvoker : Java.Lang.Object, IReadWriteProperty, IReadOnlyProperty, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x000397D0 File Offset: 0x000379D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IReadWritePropertyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x000397F4 File Offset: 0x000379F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IReadWritePropertyInvoker._members;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000397FB File Offset: 0x000379FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00039803 File Offset: 0x00037A03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IReadWritePropertyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0003980F File Offset: 0x00037A0F
		[NullableContext(2)]
		public static IReadWriteProperty GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IReadWriteProperty>(handle, transfer);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00039818 File Offset: 0x00037A18
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReadWritePropertyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.properties.ReadWriteProperty'.");
			}
			return handle;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00039843 File Offset: 0x00037A43
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00039874 File Offset: 0x00037A74
		public IReadWritePropertyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReadWritePropertyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000398AC File Offset: 0x00037AAC
		private static Delegate GetGetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Handler()
		{
			if (IReadWritePropertyInvoker.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_ == null)
			{
				IReadWritePropertyInvoker.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IReadWritePropertyInvoker.n_GetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_));
			}
			return IReadWritePropertyInvoker.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_;
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x000398D0 File Offset: 0x00037AD0
		private static IntPtr n_GetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_(IntPtr jnienv, IntPtr native__this, IntPtr native_thisRef, IntPtr native_property)
		{
			IReadWriteProperty @object = Java.Lang.Object.GetObject<IReadWriteProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_thisRef, JniHandleOwnership.DoNotTransfer);
			IKProperty object3 = Java.Lang.Object.GetObject<IKProperty>(native_property, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetValue(object2, object3));
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00039904 File Offset: 0x00037B04
		[NullableContext(2)]
		public unsafe Java.Lang.Object GetValue(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property)
		{
			if (this.id_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_ == IntPtr.Zero)
			{
				this.id_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_ = JNIEnv.GetMethodID(this.class_ref, "getValue", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(thisRef);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((property == null) ? IntPtr.Zero : ((Java.Lang.Object)property).Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000399A2 File Offset: 0x00037BA2
		private static Delegate GetSetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_Handler()
		{
			if (IReadWritePropertyInvoker.cb_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_ == null)
			{
				IReadWritePropertyInvoker.cb_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IReadWritePropertyInvoker.n_SetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_));
			}
			return IReadWritePropertyInvoker.cb_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_;
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x000399C8 File Offset: 0x00037BC8
		private static void n_SetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_thisRef, IntPtr native_property, IntPtr native_value)
		{
			IReadWriteProperty @object = Java.Lang.Object.GetObject<IReadWriteProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_thisRef, JniHandleOwnership.DoNotTransfer);
			IKProperty object3 = Java.Lang.Object.GetObject<IKProperty>(native_property, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.SetValue(object2, object3, object4);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00039A00 File Offset: 0x00037C00
		[NullableContext(2)]
		public unsafe void SetValue(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property, Java.Lang.Object value)
		{
			if (this.id_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "setValue", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(thisRef);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((property == null) ? IntPtr.Zero : ((Java.Lang.Object)property).Handle);
			ptr[2] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x0400058F RID: 1423
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/properties/ReadWriteProperty", typeof(IReadWritePropertyInvoker));

		// Token: 0x04000590 RID: 1424
		private IntPtr class_ref;

		// Token: 0x04000591 RID: 1425
		[Nullable(2)]
		private static Delegate cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_;

		// Token: 0x04000592 RID: 1426
		private IntPtr id_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_;

		// Token: 0x04000593 RID: 1427
		[Nullable(2)]
		private static Delegate cb_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_;

		// Token: 0x04000594 RID: 1428
		private IntPtr id_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_;
	}
}
