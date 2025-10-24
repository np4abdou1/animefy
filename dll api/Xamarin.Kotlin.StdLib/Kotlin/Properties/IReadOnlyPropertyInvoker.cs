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
	// Token: 0x02000147 RID: 327
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/properties/ReadOnlyProperty", DoNotGenerateAcw = true)]
	internal class IReadOnlyPropertyInvoker : Java.Lang.Object, IReadOnlyProperty, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x000395E0 File Offset: 0x000377E0
		private static IntPtr java_class_ref
		{
			get
			{
				return IReadOnlyPropertyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x00039604 File Offset: 0x00037804
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IReadOnlyPropertyInvoker._members;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0003960B File Offset: 0x0003780B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x00039613 File Offset: 0x00037813
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IReadOnlyPropertyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0003961F File Offset: 0x0003781F
		[NullableContext(2)]
		public static IReadOnlyProperty GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IReadOnlyProperty>(handle, transfer);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00039628 File Offset: 0x00037828
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReadOnlyPropertyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.properties.ReadOnlyProperty'.");
			}
			return handle;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00039653 File Offset: 0x00037853
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00039684 File Offset: 0x00037884
		public IReadOnlyPropertyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReadOnlyPropertyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x000396BC File Offset: 0x000378BC
		private static Delegate GetGetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Handler()
		{
			if (IReadOnlyPropertyInvoker.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_ == null)
			{
				IReadOnlyPropertyInvoker.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IReadOnlyPropertyInvoker.n_GetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_));
			}
			return IReadOnlyPropertyInvoker.cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_;
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x000396E0 File Offset: 0x000378E0
		private static IntPtr n_GetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_(IntPtr jnienv, IntPtr native__this, IntPtr native_thisRef, IntPtr native_property)
		{
			IReadOnlyProperty @object = Java.Lang.Object.GetObject<IReadOnlyProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_thisRef, JniHandleOwnership.DoNotTransfer);
			IKProperty object3 = Java.Lang.Object.GetObject<IKProperty>(native_property, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetValue(object2, object3));
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00039714 File Offset: 0x00037914
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

		// Token: 0x0400058B RID: 1419
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/properties/ReadOnlyProperty", typeof(IReadOnlyPropertyInvoker));

		// Token: 0x0400058C RID: 1420
		private IntPtr class_ref;

		// Token: 0x0400058D RID: 1421
		[Nullable(2)]
		private static Delegate cb_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_;

		// Token: 0x0400058E RID: 1422
		private IntPtr id_getValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_;
	}
}
