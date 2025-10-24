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
	// Token: 0x02000145 RID: 325
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/properties/PropertyDelegateProvider", DoNotGenerateAcw = true)]
	internal class IPropertyDelegateProviderInvoker : Java.Lang.Object, IPropertyDelegateProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x000393F0 File Offset: 0x000375F0
		private static IntPtr java_class_ref
		{
			get
			{
				return IPropertyDelegateProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00039414 File Offset: 0x00037614
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPropertyDelegateProviderInvoker._members;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0003941B File Offset: 0x0003761B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x00039423 File Offset: 0x00037623
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPropertyDelegateProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0003942F File Offset: 0x0003762F
		[NullableContext(2)]
		public static IPropertyDelegateProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPropertyDelegateProvider>(handle, transfer);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00039438 File Offset: 0x00037638
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPropertyDelegateProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.properties.PropertyDelegateProvider'.");
			}
			return handle;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00039463 File Offset: 0x00037663
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00039494 File Offset: 0x00037694
		public IPropertyDelegateProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPropertyDelegateProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000394CC File Offset: 0x000376CC
		private static Delegate GetProvideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_Handler()
		{
			if (IPropertyDelegateProviderInvoker.cb_provideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_ == null)
			{
				IPropertyDelegateProviderInvoker.cb_provideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IPropertyDelegateProviderInvoker.n_ProvideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_));
			}
			return IPropertyDelegateProviderInvoker.cb_provideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x000394F0 File Offset: 0x000376F0
		private static IntPtr n_ProvideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_(IntPtr jnienv, IntPtr native__this, IntPtr native_thisRef, IntPtr native_property)
		{
			IPropertyDelegateProvider @object = Java.Lang.Object.GetObject<IPropertyDelegateProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_thisRef, JniHandleOwnership.DoNotTransfer);
			IKProperty object3 = Java.Lang.Object.GetObject<IKProperty>(native_property, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ProvideDelegate(object2, object3));
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00039524 File Offset: 0x00037724
		[NullableContext(2)]
		public unsafe Java.Lang.Object ProvideDelegate(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property)
		{
			if (this.id_provideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_ == IntPtr.Zero)
			{
				this.id_provideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_ = JNIEnv.GetMethodID(this.class_ref, "provideDelegate", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(thisRef);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((property == null) ? IntPtr.Zero : ((Java.Lang.Object)property).Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_provideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04000587 RID: 1415
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/properties/PropertyDelegateProvider", typeof(IPropertyDelegateProviderInvoker));

		// Token: 0x04000588 RID: 1416
		private IntPtr class_ref;

		// Token: 0x04000589 RID: 1417
		[Nullable(2)]
		private static Delegate cb_provideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_;

		// Token: 0x0400058A RID: 1418
		private IntPtr id_provideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_;
	}
}
