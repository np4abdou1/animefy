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
	// Token: 0x0200014A RID: 330
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/properties/ObservableProperty", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public abstract class ObservableProperty : Java.Lang.Object, IReadWriteProperty, IReadOnlyProperty, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00039AD8 File Offset: 0x00037CD8
		internal static IntPtr class_ref
		{
			get
			{
				return ObservableProperty._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00039AFC File Offset: 0x00037CFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ObservableProperty._members;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00039B04 File Offset: 0x00037D04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ObservableProperty._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00039B28 File Offset: 0x00037D28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ObservableProperty._members.ManagedPeerType;
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00039B34 File Offset: 0x00037D34
		protected ObservableProperty(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00039B40 File Offset: 0x00037D40
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe ObservableProperty(Java.Lang.Object initialValue) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initialValue);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(ObservableProperty._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ObservableProperty._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(initialValue);
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00039BEC File Offset: 0x00037DEC
		private static Delegate GetAfterChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (ObservableProperty.cb_afterChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				ObservableProperty.cb_afterChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ObservableProperty.n_AfterChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return ObservableProperty.cb_afterChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00039C10 File Offset: 0x00037E10
		private static void n_AfterChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_property, IntPtr native_oldValue, IntPtr native_newValue)
		{
			ObservableProperty @object = Java.Lang.Object.GetObject<ObservableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKProperty object2 = Java.Lang.Object.GetObject<IKProperty>(native_property, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_oldValue, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_newValue, JniHandleOwnership.DoNotTransfer);
			@object.AfterChange(object2, object3, object4);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00039C48 File Offset: 0x00037E48
		[NullableContext(2)]
		[Register("afterChange", "(Lkotlin/reflect/KProperty;Ljava/lang/Object;Ljava/lang/Object;)V", "GetAfterChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		protected unsafe virtual void AfterChange([Nullable(1)] IKProperty property, Java.Lang.Object oldValue, Java.Lang.Object newValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(oldValue);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(newValue);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((property == null) ? IntPtr.Zero : ((Java.Lang.Object)property).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ObservableProperty._members.InstanceMethods.InvokeVirtualVoidMethod("afterChange.(Lkotlin/reflect/KProperty;Ljava/lang/Object;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(property);
				GC.KeepAlive(oldValue);
				GC.KeepAlive(newValue);
			}
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00039D00 File Offset: 0x00037F00
		private static Delegate GetBeforeChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (ObservableProperty.cb_beforeChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				ObservableProperty.cb_beforeChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(ObservableProperty.n_BeforeChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return ObservableProperty.cb_beforeChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00039D24 File Offset: 0x00037F24
		private static bool n_BeforeChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_property, IntPtr native_oldValue, IntPtr native_newValue)
		{
			ObservableProperty @object = Java.Lang.Object.GetObject<ObservableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKProperty object2 = Java.Lang.Object.GetObject<IKProperty>(native_property, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_oldValue, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_newValue, JniHandleOwnership.DoNotTransfer);
			return @object.BeforeChange(object2, object3, object4);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00039D5C File Offset: 0x00037F5C
		[NullableContext(2)]
		[Register("beforeChange", "(Lkotlin/reflect/KProperty;Ljava/lang/Object;Ljava/lang/Object;)Z", "GetBeforeChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		protected unsafe virtual bool BeforeChange([Nullable(1)] IKProperty property, Java.Lang.Object oldValue, Java.Lang.Object newValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(oldValue);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(newValue);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((property == null) ? IntPtr.Zero : ((Java.Lang.Object)property).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				result = ObservableProperty._members.InstanceMethods.InvokeVirtualBooleanMethod("beforeChange.(Lkotlin/reflect/KProperty;Ljava/lang/Object;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(property);
				GC.KeepAlive(oldValue);
				GC.KeepAlive(newValue);
			}
			return result;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00039E18 File Offset: 0x00038018
		private static Delegate GetGetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Handler()
		{
			if (ObservableProperty.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_ == null)
			{
				ObservableProperty.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ObservableProperty.n_GetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_));
			}
			return ObservableProperty.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00039E3C File Offset: 0x0003803C
		private static IntPtr n_GetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_(IntPtr jnienv, IntPtr native__this, IntPtr native_thisRef, IntPtr native_property)
		{
			ObservableProperty @object = Java.Lang.Object.GetObject<ObservableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_thisRef, JniHandleOwnership.DoNotTransfer);
			IKProperty object3 = Java.Lang.Object.GetObject<IKProperty>(native_property, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetValue(object2, object3));
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00039E70 File Offset: 0x00038070
		[NullableContext(2)]
		[Register("getValue", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;)Ljava/lang/Object;", "GetGetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Handler")]
		public unsafe virtual Java.Lang.Object GetValue(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((thisRef == null) ? IntPtr.Zero : thisRef.Handle);
				ptr[1] = new JniArgumentValue((property == null) ? IntPtr.Zero : ((Java.Lang.Object)property).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ObservableProperty._members.InstanceMethods.InvokeVirtualObjectMethod("getValue.(Ljava/lang/Object;Lkotlin/reflect/KProperty;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(thisRef);
				GC.KeepAlive(property);
			}
			return @object;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00039F10 File Offset: 0x00038110
		private static Delegate GetSetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_Handler()
		{
			if (ObservableProperty.cb_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_ == null)
			{
				ObservableProperty.cb_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ObservableProperty.n_SetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_));
			}
			return ObservableProperty.cb_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00039F34 File Offset: 0x00038134
		private static void n_SetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_thisRef, IntPtr native_property, IntPtr native_value)
		{
			ObservableProperty @object = Java.Lang.Object.GetObject<ObservableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_thisRef, JniHandleOwnership.DoNotTransfer);
			IKProperty object3 = Java.Lang.Object.GetObject<IKProperty>(native_property, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.SetValue(object2, object3, object4);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00039F6C File Offset: 0x0003816C
		[NullableContext(2)]
		[Register("setValue", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetValue(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((thisRef == null) ? IntPtr.Zero : thisRef.Handle);
				ptr[1] = new JniArgumentValue((property == null) ? IntPtr.Zero : ((Java.Lang.Object)property).Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ObservableProperty._members.InstanceMethods.InvokeVirtualVoidMethod("setValue.(Ljava/lang/Object;Lkotlin/reflect/KProperty;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(thisRef);
				GC.KeepAlive(property);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x04000595 RID: 1429
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/properties/ObservableProperty", typeof(ObservableProperty));

		// Token: 0x04000596 RID: 1430
		[Nullable(2)]
		private static Delegate cb_afterChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000597 RID: 1431
		[Nullable(2)]
		private static Delegate cb_beforeChange_Lkotlin_reflect_KProperty_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000598 RID: 1432
		[Nullable(2)]
		private static Delegate cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_;

		// Token: 0x04000599 RID: 1433
		[Nullable(2)]
		private static Delegate cb_setValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_;
	}
}
