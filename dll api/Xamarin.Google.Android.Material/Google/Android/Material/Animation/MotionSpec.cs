using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Animation;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Animation
{
	// Token: 0x0200009F RID: 159
	[Register("com/google/android/material/animation/MotionSpec", DoNotGenerateAcw = true)]
	public class MotionSpec : Java.Lang.Object
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0001EACC File Offset: 0x0001CCCC
		internal static IntPtr class_ref
		{
			get
			{
				return MotionSpec._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0001EAF0 File Offset: 0x0001CCF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MotionSpec._members;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MotionSpec._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0001EB1C File Offset: 0x0001CD1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MotionSpec._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000020DC File Offset: 0x000002DC
		protected MotionSpec(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0001EB28 File Offset: 0x0001CD28
		[Register(".ctor", "()V", "")]
		public MotionSpec() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MotionSpec._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MotionSpec._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0001EB96 File Offset: 0x0001CD96
		private static Delegate GetGetTotalDurationHandler()
		{
			if (MotionSpec.cb_getTotalDuration == null)
			{
				MotionSpec.cb_getTotalDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(MotionSpec.n_GetTotalDuration));
			}
			return MotionSpec.cb_getTotalDuration;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0001EBBA File Offset: 0x0001CDBA
		private static long n_GetTotalDuration(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MotionSpec>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TotalDuration;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0001EBC9 File Offset: 0x0001CDC9
		public virtual long TotalDuration
		{
			[Register("getTotalDuration", "()J", "GetGetTotalDurationHandler")]
			get
			{
				return MotionSpec._members.InstanceMethods.InvokeVirtualInt64Method("getTotalDuration.()J", this, null);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0001EBE4 File Offset: 0x0001CDE4
		[Register("createFromAttribute", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)Lcom/google/android/material/animation/MotionSpec;", "")]
		public unsafe static MotionSpec CreateFromAttribute(Context context, TypedArray attributes, int index)
		{
			MotionSpec @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attributes == null) ? IntPtr.Zero : attributes.Handle);
				ptr[2] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<MotionSpec>(MotionSpec._members.StaticMethods.InvokeObjectMethod("createFromAttribute.(Landroid/content/Context;Landroid/content/res/TypedArray;I)Lcom/google/android/material/animation/MotionSpec;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attributes);
			}
			return @object;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0001EC94 File Offset: 0x0001CE94
		[Register("createFromResource", "(Landroid/content/Context;I)Lcom/google/android/material/animation/MotionSpec;", "")]
		public unsafe static MotionSpec CreateFromResource(Context context, int id)
		{
			MotionSpec @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(id);
				@object = Java.Lang.Object.GetObject<MotionSpec>(MotionSpec._members.StaticMethods.InvokeObjectMethod("createFromResource.(Landroid/content/Context;I)Lcom/google/android/material/animation/MotionSpec;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0001ED1C File Offset: 0x0001CF1C
		private static Delegate GetGetAnimator_Ljava_lang_String_Ljava_lang_Object_Landroid_util_Property_Handler()
		{
			if (MotionSpec.cb_getAnimator_Ljava_lang_String_Ljava_lang_Object_Landroid_util_Property_ == null)
			{
				MotionSpec.cb_getAnimator_Ljava_lang_String_Ljava_lang_Object_Landroid_util_Property_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(MotionSpec.n_GetAnimator_Ljava_lang_String_Ljava_lang_Object_Landroid_util_Property_));
			}
			return MotionSpec.cb_getAnimator_Ljava_lang_String_Ljava_lang_Object_Landroid_util_Property_;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0001ED40 File Offset: 0x0001CF40
		private static IntPtr n_GetAnimator_Ljava_lang_String_Ljava_lang_Object_Landroid_util_Property_(IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_target, IntPtr native_property)
		{
			MotionSpec @object = Java.Lang.Object.GetObject<MotionSpec>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_target, JniHandleOwnership.DoNotTransfer);
			Property object3 = Java.Lang.Object.GetObject<Property>(native_property, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetAnimator(@string, object2, object3));
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0001ED7C File Offset: 0x0001CF7C
		[Register("getAnimator", "(Ljava/lang/String;Ljava/lang/Object;Landroid/util/Property;)Landroid/animation/ObjectAnimator;", "GetGetAnimator_Ljava_lang_String_Ljava_lang_Object_Landroid_util_Property_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual ObjectAnimator GetAnimator(string name, Java.Lang.Object target, Property property)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(target);
			ObjectAnimator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((property == null) ? IntPtr.Zero : property.Handle);
				@object = Java.Lang.Object.GetObject<ObjectAnimator>(MotionSpec._members.InstanceMethods.InvokeVirtualObjectMethod("getAnimator.(Ljava/lang/String;Ljava/lang/Object;Landroid/util/Property;)Landroid/animation/ObjectAnimator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(target);
				GC.KeepAlive(property);
			}
			return @object;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0001EE3C File Offset: 0x0001D03C
		private static Delegate GetGetPropertyValues_Ljava_lang_String_Handler()
		{
			if (MotionSpec.cb_getPropertyValues_Ljava_lang_String_ == null)
			{
				MotionSpec.cb_getPropertyValues_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MotionSpec.n_GetPropertyValues_Ljava_lang_String_));
			}
			return MotionSpec.cb_getPropertyValues_Ljava_lang_String_;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0001EE60 File Offset: 0x0001D060
		private static IntPtr n_GetPropertyValues_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			MotionSpec @object = Java.Lang.Object.GetObject<MotionSpec>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<PropertyValuesHolder>(@object.GetPropertyValues(@string));
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0001EE88 File Offset: 0x0001D088
		[Register("getPropertyValues", "(Ljava/lang/String;)[Landroid/animation/PropertyValuesHolder;", "GetGetPropertyValues_Ljava_lang_String_Handler")]
		public unsafe virtual PropertyValuesHolder[] GetPropertyValues(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			PropertyValuesHolder[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (PropertyValuesHolder[])JNIEnv.GetArray(MotionSpec._members.InstanceMethods.InvokeVirtualObjectMethod("getPropertyValues.(Ljava/lang/String;)[Landroid/animation/PropertyValuesHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(PropertyValuesHolder));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0001EF04 File Offset: 0x0001D104
		private static Delegate GetGetTiming_Ljava_lang_String_Handler()
		{
			if (MotionSpec.cb_getTiming_Ljava_lang_String_ == null)
			{
				MotionSpec.cb_getTiming_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MotionSpec.n_GetTiming_Ljava_lang_String_));
			}
			return MotionSpec.cb_getTiming_Ljava_lang_String_;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0001EF28 File Offset: 0x0001D128
		private static IntPtr n_GetTiming_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			MotionSpec @object = Java.Lang.Object.GetObject<MotionSpec>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetTiming(@string));
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0001EF50 File Offset: 0x0001D150
		[Register("getTiming", "(Ljava/lang/String;)Lcom/google/android/material/animation/MotionTiming;", "GetGetTiming_Ljava_lang_String_Handler")]
		public unsafe virtual MotionTiming GetTiming(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			MotionTiming @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<MotionTiming>(MotionSpec._members.InstanceMethods.InvokeVirtualObjectMethod("getTiming.(Ljava/lang/String;)Lcom/google/android/material/animation/MotionTiming;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0001EFBC File Offset: 0x0001D1BC
		private static Delegate GetHasPropertyValues_Ljava_lang_String_Handler()
		{
			if (MotionSpec.cb_hasPropertyValues_Ljava_lang_String_ == null)
			{
				MotionSpec.cb_hasPropertyValues_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(MotionSpec.n_HasPropertyValues_Ljava_lang_String_));
			}
			return MotionSpec.cb_hasPropertyValues_Ljava_lang_String_;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0001EFE0 File Offset: 0x0001D1E0
		private static bool n_HasPropertyValues_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			MotionSpec @object = Java.Lang.Object.GetObject<MotionSpec>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return @object.HasPropertyValues(@string);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0001F004 File Offset: 0x0001D204
		[Register("hasPropertyValues", "(Ljava/lang/String;)Z", "GetHasPropertyValues_Ljava_lang_String_Handler")]
		public unsafe virtual bool HasPropertyValues(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = MotionSpec._members.InstanceMethods.InvokeVirtualBooleanMethod("hasPropertyValues.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0001F064 File Offset: 0x0001D264
		private static Delegate GetHasTiming_Ljava_lang_String_Handler()
		{
			if (MotionSpec.cb_hasTiming_Ljava_lang_String_ == null)
			{
				MotionSpec.cb_hasTiming_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(MotionSpec.n_HasTiming_Ljava_lang_String_));
			}
			return MotionSpec.cb_hasTiming_Ljava_lang_String_;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0001F088 File Offset: 0x0001D288
		private static bool n_HasTiming_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			MotionSpec @object = Java.Lang.Object.GetObject<MotionSpec>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return @object.HasTiming(@string);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0001F0AC File Offset: 0x0001D2AC
		[Register("hasTiming", "(Ljava/lang/String;)Z", "GetHasTiming_Ljava_lang_String_Handler")]
		public unsafe virtual bool HasTiming(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = MotionSpec._members.InstanceMethods.InvokeVirtualBooleanMethod("hasTiming.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0001F10C File Offset: 0x0001D30C
		private static Delegate GetSetPropertyValues_Ljava_lang_String_arrayLandroid_animation_PropertyValuesHolder_Handler()
		{
			if (MotionSpec.cb_setPropertyValues_Ljava_lang_String_arrayLandroid_animation_PropertyValuesHolder_ == null)
			{
				MotionSpec.cb_setPropertyValues_Ljava_lang_String_arrayLandroid_animation_PropertyValuesHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MotionSpec.n_SetPropertyValues_Ljava_lang_String_arrayLandroid_animation_PropertyValuesHolder_));
			}
			return MotionSpec.cb_setPropertyValues_Ljava_lang_String_arrayLandroid_animation_PropertyValuesHolder_;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001F130 File Offset: 0x0001D330
		private static void n_SetPropertyValues_Ljava_lang_String_arrayLandroid_animation_PropertyValuesHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_values)
		{
			MotionSpec @object = Java.Lang.Object.GetObject<MotionSpec>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			PropertyValuesHolder[] array = (PropertyValuesHolder[])JNIEnv.GetArray(native_values, JniHandleOwnership.DoNotTransfer, typeof(PropertyValuesHolder));
			@object.SetPropertyValues(@string, array);
			if (array != null)
			{
				JNIEnv.CopyArray<PropertyValuesHolder>(array, native_values);
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001F178 File Offset: 0x0001D378
		[Register("setPropertyValues", "(Ljava/lang/String;[Landroid/animation/PropertyValuesHolder;)V", "GetSetPropertyValues_Ljava_lang_String_arrayLandroid_animation_PropertyValuesHolder_Handler")]
		public unsafe virtual void SetPropertyValues(string name, PropertyValuesHolder[] values)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewArray<PropertyValuesHolder>(values);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				MotionSpec._members.InstanceMethods.InvokeVirtualVoidMethod("setPropertyValues.(Ljava/lang/String;[Landroid/animation/PropertyValuesHolder;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (values != null)
				{
					JNIEnv.CopyArray<PropertyValuesHolder>(intPtr2, values);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(values);
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0001F204 File Offset: 0x0001D404
		private static Delegate GetSetTiming_Ljava_lang_String_Lcom_google_android_material_animation_MotionTiming_Handler()
		{
			if (MotionSpec.cb_setTiming_Ljava_lang_String_Lcom_google_android_material_animation_MotionTiming_ == null)
			{
				MotionSpec.cb_setTiming_Ljava_lang_String_Lcom_google_android_material_animation_MotionTiming_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MotionSpec.n_SetTiming_Ljava_lang_String_Lcom_google_android_material_animation_MotionTiming_));
			}
			return MotionSpec.cb_setTiming_Ljava_lang_String_Lcom_google_android_material_animation_MotionTiming_;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0001F228 File Offset: 0x0001D428
		private static void n_SetTiming_Ljava_lang_String_Lcom_google_android_material_animation_MotionTiming_(IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_timing)
		{
			MotionSpec @object = Java.Lang.Object.GetObject<MotionSpec>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			MotionTiming object2 = Java.Lang.Object.GetObject<MotionTiming>(native_timing, JniHandleOwnership.DoNotTransfer);
			@object.SetTiming(@string, object2);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0001F254 File Offset: 0x0001D454
		[Register("setTiming", "(Ljava/lang/String;Lcom/google/android/material/animation/MotionTiming;)V", "GetSetTiming_Ljava_lang_String_Lcom_google_android_material_animation_MotionTiming_Handler")]
		public unsafe virtual void SetTiming(string name, MotionTiming timing)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((timing == null) ? IntPtr.Zero : timing.Handle);
				MotionSpec._members.InstanceMethods.InvokeVirtualVoidMethod("setTiming.(Ljava/lang/String;Lcom/google/android/material/animation/MotionTiming;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(timing);
			}
		}

		// Token: 0x04000352 RID: 850
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/animation/MotionSpec", typeof(MotionSpec));

		// Token: 0x04000353 RID: 851
		private static Delegate cb_getTotalDuration;

		// Token: 0x04000354 RID: 852
		private static Delegate cb_getAnimator_Ljava_lang_String_Ljava_lang_Object_Landroid_util_Property_;

		// Token: 0x04000355 RID: 853
		private static Delegate cb_getPropertyValues_Ljava_lang_String_;

		// Token: 0x04000356 RID: 854
		private static Delegate cb_getTiming_Ljava_lang_String_;

		// Token: 0x04000357 RID: 855
		private static Delegate cb_hasPropertyValues_Ljava_lang_String_;

		// Token: 0x04000358 RID: 856
		private static Delegate cb_hasTiming_Ljava_lang_String_;

		// Token: 0x04000359 RID: 857
		private static Delegate cb_setPropertyValues_Ljava_lang_String_arrayLandroid_animation_PropertyValuesHolder_;

		// Token: 0x0400035A RID: 858
		private static Delegate cb_setTiming_Ljava_lang_String_Lcom_google_android_material_animation_MotionTiming_;
	}
}
