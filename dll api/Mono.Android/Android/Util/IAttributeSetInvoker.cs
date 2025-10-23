using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Util
{
	// Token: 0x02000193 RID: 403
	[Register("android/util/AttributeSet", DoNotGenerateAcw = true)]
	internal class IAttributeSetInvoker : Java.Lang.Object, IAttributeSet, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x000237F4 File Offset: 0x000219F4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAttributeSetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00023818 File Offset: 0x00021A18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAttributeSetInvoker._members;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0002381F File Offset: 0x00021A1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00023827 File Offset: 0x00021A27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAttributeSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00023833 File Offset: 0x00021A33
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAttributeSetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.util.AttributeSet'.");
			}
			return handle;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0002385E File Offset: 0x00021A5E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00023890 File Offset: 0x00021A90
		public IAttributeSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAttributeSetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000238C8 File Offset: 0x00021AC8
		private static Delegate GetGetAttributeCountHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeCount == null)
			{
				IAttributeSetInvoker.cb_getAttributeCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IAttributeSetInvoker.n_GetAttributeCount));
			}
			return IAttributeSetInvoker.cb_getAttributeCount;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000238EC File Offset: 0x00021AEC
		private static int n_GetAttributeCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AttributeCount;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x000238FB File Offset: 0x00021AFB
		public int AttributeCount
		{
			get
			{
				if (this.id_getAttributeCount == IntPtr.Zero)
				{
					this.id_getAttributeCount = JNIEnv.GetMethodID(this.class_ref, "getAttributeCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeCount);
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0002393B File Offset: 0x00021B3B
		private static Delegate GetGetClassAttributeHandler()
		{
			if (IAttributeSetInvoker.cb_getClassAttribute == null)
			{
				IAttributeSetInvoker.cb_getClassAttribute = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAttributeSetInvoker.n_GetClassAttribute));
			}
			return IAttributeSetInvoker.cb_getClassAttribute;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0002395F File Offset: 0x00021B5F
		private static IntPtr n_GetClassAttribute(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassAttribute);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00023974 File Offset: 0x00021B74
		public string ClassAttribute
		{
			get
			{
				if (this.id_getClassAttribute == IntPtr.Zero)
				{
					this.id_getClassAttribute = JNIEnv.GetMethodID(this.class_ref, "getClassAttribute", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getClassAttribute), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x000239C5 File Offset: 0x00021BC5
		private static Delegate GetGetIdAttributeHandler()
		{
			if (IAttributeSetInvoker.cb_getIdAttribute == null)
			{
				IAttributeSetInvoker.cb_getIdAttribute = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAttributeSetInvoker.n_GetIdAttribute));
			}
			return IAttributeSetInvoker.cb_getIdAttribute;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000239E9 File Offset: 0x00021BE9
		private static IntPtr n_GetIdAttribute(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IdAttribute);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00023A00 File Offset: 0x00021C00
		public string IdAttribute
		{
			get
			{
				if (this.id_getIdAttribute == IntPtr.Zero)
				{
					this.id_getIdAttribute = JNIEnv.GetMethodID(this.class_ref, "getIdAttribute", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getIdAttribute), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00023A51 File Offset: 0x00021C51
		private static Delegate GetGetPositionDescriptionHandler()
		{
			if (IAttributeSetInvoker.cb_getPositionDescription == null)
			{
				IAttributeSetInvoker.cb_getPositionDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAttributeSetInvoker.n_GetPositionDescription));
			}
			return IAttributeSetInvoker.cb_getPositionDescription;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00023A75 File Offset: 0x00021C75
		private static IntPtr n_GetPositionDescription(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PositionDescription);
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00023A8C File Offset: 0x00021C8C
		public string PositionDescription
		{
			get
			{
				if (this.id_getPositionDescription == IntPtr.Zero)
				{
					this.id_getPositionDescription = JNIEnv.GetMethodID(this.class_ref, "getPositionDescription", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getPositionDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00023ADD File Offset: 0x00021CDD
		private static Delegate GetGetStyleAttributeHandler()
		{
			if (IAttributeSetInvoker.cb_getStyleAttribute == null)
			{
				IAttributeSetInvoker.cb_getStyleAttribute = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IAttributeSetInvoker.n_GetStyleAttribute));
			}
			return IAttributeSetInvoker.cb_getStyleAttribute;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00023B01 File Offset: 0x00021D01
		private static int n_GetStyleAttribute(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StyleAttribute;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00023B10 File Offset: 0x00021D10
		public int StyleAttribute
		{
			get
			{
				if (this.id_getStyleAttribute == IntPtr.Zero)
				{
					this.id_getStyleAttribute = JNIEnv.GetMethodID(this.class_ref, "getStyleAttribute", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getStyleAttribute);
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00023B50 File Offset: 0x00021D50
		private static Delegate GetGetAttributeBooleanValue_IZHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeBooleanValue_IZ == null)
			{
				IAttributeSetInvoker.cb_getAttributeBooleanValue_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_Z(IAttributeSetInvoker.n_GetAttributeBooleanValue_IZ));
			}
			return IAttributeSetInvoker.cb_getAttributeBooleanValue_IZ;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00023B74 File Offset: 0x00021D74
		private static bool n_GetAttributeBooleanValue_IZ(IntPtr jnienv, IntPtr native__this, int index, bool defaultValue)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeBooleanValue(index, defaultValue);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00023B88 File Offset: 0x00021D88
		public unsafe bool GetAttributeBooleanValue(int index, bool defaultValue)
		{
			if (this.id_getAttributeBooleanValue_IZ == IntPtr.Zero)
			{
				this.id_getAttributeBooleanValue_IZ = JNIEnv.GetMethodID(this.class_ref, "getAttributeBooleanValue", "(IZ)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(defaultValue);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_getAttributeBooleanValue_IZ, ptr);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00023BFF File Offset: 0x00021DFF
		private static Delegate GetGetAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_ZHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z == null)
			{
				IAttributeSetInvoker.cb_getAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_Z(IAttributeSetInvoker.n_GetAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z));
			}
			return IAttributeSetInvoker.cb_getAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00023C24 File Offset: 0x00021E24
		private static bool n_GetAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native__namespace, IntPtr native_attribute, bool defaultValue)
		{
			IAttributeSet @object = Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__namespace, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_attribute, JniHandleOwnership.DoNotTransfer);
			return @object.GetAttributeBooleanValue(@string, string2, defaultValue);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00023C54 File Offset: 0x00021E54
		public unsafe bool GetAttributeBooleanValue(string @namespace, string attribute, bool defaultValue)
		{
			if (this.id_getAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
			{
				this.id_getAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID(this.class_ref, "getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(@namespace);
			IntPtr intPtr2 = JNIEnv.NewString(attribute);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(defaultValue);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_getAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00023CFB File Offset: 0x00021EFB
		private static Delegate GetGetAttributeFloatValue_IFHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeFloatValue_IF == null)
			{
				IAttributeSetInvoker.cb_getAttributeFloatValue_IF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIF_F(IAttributeSetInvoker.n_GetAttributeFloatValue_IF));
			}
			return IAttributeSetInvoker.cb_getAttributeFloatValue_IF;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00023D1F File Offset: 0x00021F1F
		private static float n_GetAttributeFloatValue_IF(IntPtr jnienv, IntPtr native__this, int index, float defaultValue)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeFloatValue(index, defaultValue);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00023D30 File Offset: 0x00021F30
		public unsafe float GetAttributeFloatValue(int index, float defaultValue)
		{
			if (this.id_getAttributeFloatValue_IF == IntPtr.Zero)
			{
				this.id_getAttributeFloatValue_IF = JNIEnv.GetMethodID(this.class_ref, "getAttributeFloatValue", "(IF)F");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(defaultValue);
			return JNIEnv.CallFloatMethod(base.Handle, this.id_getAttributeFloatValue_IF, ptr);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00023DA7 File Offset: 0x00021FA7
		private static Delegate GetGetAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_FHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F == null)
			{
				IAttributeSetInvoker.cb_getAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLF_F(IAttributeSetInvoker.n_GetAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F));
			}
			return IAttributeSetInvoker.cb_getAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00023DCC File Offset: 0x00021FCC
		private static float n_GetAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F(IntPtr jnienv, IntPtr native__this, IntPtr native__namespace, IntPtr native_attribute, float defaultValue)
		{
			IAttributeSet @object = Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__namespace, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_attribute, JniHandleOwnership.DoNotTransfer);
			return @object.GetAttributeFloatValue(@string, string2, defaultValue);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00023DFC File Offset: 0x00021FFC
		public unsafe float GetAttributeFloatValue(string @namespace, string attribute, float defaultValue)
		{
			if (this.id_getAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F == IntPtr.Zero)
			{
				this.id_getAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F = JNIEnv.GetMethodID(this.class_ref, "getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F");
			}
			IntPtr intPtr = JNIEnv.NewString(@namespace);
			IntPtr intPtr2 = JNIEnv.NewString(attribute);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(defaultValue);
			float result = JNIEnv.CallFloatMethod(base.Handle, this.id_getAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00023EA3 File Offset: 0x000220A3
		private static Delegate GetGetAttributeIntValue_IIHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeIntValue_II == null)
			{
				IAttributeSetInvoker.cb_getAttributeIntValue_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(IAttributeSetInvoker.n_GetAttributeIntValue_II));
			}
			return IAttributeSetInvoker.cb_getAttributeIntValue_II;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00023EC7 File Offset: 0x000220C7
		private static int n_GetAttributeIntValue_II(IntPtr jnienv, IntPtr native__this, int index, int defaultValue)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeIntValue(index, defaultValue);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00023ED8 File Offset: 0x000220D8
		public unsafe int GetAttributeIntValue(int index, int defaultValue)
		{
			if (this.id_getAttributeIntValue_II == IntPtr.Zero)
			{
				this.id_getAttributeIntValue_II = JNIEnv.GetMethodID(this.class_ref, "getAttributeIntValue", "(II)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(defaultValue);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeIntValue_II, ptr);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00023F4F File Offset: 0x0002214F
		private static Delegate GetGetAttributeIntValue_Ljava_lang_String_Ljava_lang_String_IHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I == null)
			{
				IAttributeSetInvoker.cb_getAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_I(IAttributeSetInvoker.n_GetAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I));
			}
			return IAttributeSetInvoker.cb_getAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00023F74 File Offset: 0x00022174
		private static int n_GetAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native__namespace, IntPtr native_attribute, int defaultValue)
		{
			IAttributeSet @object = Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__namespace, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_attribute, JniHandleOwnership.DoNotTransfer);
			return @object.GetAttributeIntValue(@string, string2, defaultValue);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00023FA4 File Offset: 0x000221A4
		public unsafe int GetAttributeIntValue(string @namespace, string attribute, int defaultValue)
		{
			if (this.id_getAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
			{
				this.id_getAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			}
			IntPtr intPtr = JNIEnv.NewString(@namespace);
			IntPtr intPtr2 = JNIEnv.NewString(attribute);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(defaultValue);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0002404B File Offset: 0x0002224B
		private static Delegate GetGetAttributeListValue_IarrayLjava_lang_String_IHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeListValue_IarrayLjava_lang_String_I == null)
			{
				IAttributeSetInvoker.cb_getAttributeListValue_IarrayLjava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILI_I(IAttributeSetInvoker.n_GetAttributeListValue_IarrayLjava_lang_String_I));
			}
			return IAttributeSetInvoker.cb_getAttributeListValue_IarrayLjava_lang_String_I;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00024070 File Offset: 0x00022270
		private static int n_GetAttributeListValue_IarrayLjava_lang_String_I(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_options, int defaultValue)
		{
			IAttributeSet @object = Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_options, JniHandleOwnership.DoNotTransfer, typeof(string));
			int attributeListValue = @object.GetAttributeListValue(index, array, defaultValue);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_options);
			}
			return attributeListValue;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000240B0 File Offset: 0x000222B0
		public unsafe int GetAttributeListValue(int index, string[] options, int defaultValue)
		{
			if (this.id_getAttributeListValue_IarrayLjava_lang_String_I == IntPtr.Zero)
			{
				this.id_getAttributeListValue_IarrayLjava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "getAttributeListValue", "(I[Ljava/lang/String;I)I");
			}
			IntPtr intPtr = JNIEnv.NewArray(options);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(defaultValue);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeListValue_IarrayLjava_lang_String_I, ptr);
			if (options != null)
			{
				JNIEnv.CopyArray(intPtr, options);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00024154 File Offset: 0x00022354
		private static Delegate GetGetAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_IHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I == null)
			{
				IAttributeSetInvoker.cb_getAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLI_I(IAttributeSetInvoker.n_GetAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I));
			}
			return IAttributeSetInvoker.cb_getAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00024178 File Offset: 0x00022378
		private static int n_GetAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native__namespace, IntPtr native_attribute, IntPtr native_options, int defaultValue)
		{
			IAttributeSet @object = Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__namespace, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_attribute, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_options, JniHandleOwnership.DoNotTransfer, typeof(string));
			int attributeListValue = @object.GetAttributeListValue(@string, string2, array, defaultValue);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_options);
			}
			return attributeListValue;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000241CC File Offset: 0x000223CC
		public unsafe int GetAttributeListValue(string @namespace, string attribute, string[] options, int defaultValue)
		{
			if (this.id_getAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I == IntPtr.Zero)
			{
				this.id_getAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I");
			}
			IntPtr intPtr = JNIEnv.NewString(@namespace);
			IntPtr intPtr2 = JNIEnv.NewString(attribute);
			IntPtr intPtr3 = JNIEnv.NewArray(options);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(intPtr3);
			ptr[3] = new JValue(defaultValue);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			if (options != null)
			{
				JNIEnv.CopyArray(intPtr3, options);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return result;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000242A1 File Offset: 0x000224A1
		private static Delegate GetGetAttributeName_IHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeName_I == null)
			{
				IAttributeSetInvoker.cb_getAttributeName_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IAttributeSetInvoker.n_GetAttributeName_I));
			}
			return IAttributeSetInvoker.cb_getAttributeName_I;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000242C5 File Offset: 0x000224C5
		private static IntPtr n_GetAttributeName_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeName(index));
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000242DC File Offset: 0x000224DC
		public unsafe string GetAttributeName(int index)
		{
			if (this.id_getAttributeName_I == IntPtr.Zero)
			{
				this.id_getAttributeName_I = JNIEnv.GetMethodID(this.class_ref, "getAttributeName", "(I)Ljava/lang/String;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAttributeName_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00024346 File Offset: 0x00022546
		private static Delegate GetGetAttributeNameResource_IHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeNameResource_I == null)
			{
				IAttributeSetInvoker.cb_getAttributeNameResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(IAttributeSetInvoker.n_GetAttributeNameResource_I));
			}
			return IAttributeSetInvoker.cb_getAttributeNameResource_I;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0002436A File Offset: 0x0002256A
		private static int n_GetAttributeNameResource_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeNameResource(index);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0002437C File Offset: 0x0002257C
		public unsafe int GetAttributeNameResource(int index)
		{
			if (this.id_getAttributeNameResource_I == IntPtr.Zero)
			{
				this.id_getAttributeNameResource_I = JNIEnv.GetMethodID(this.class_ref, "getAttributeNameResource", "(I)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeNameResource_I, ptr);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x000243E0 File Offset: 0x000225E0
		private static Delegate GetGetAttributeResourceValue_IIHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeResourceValue_II == null)
			{
				IAttributeSetInvoker.cb_getAttributeResourceValue_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(IAttributeSetInvoker.n_GetAttributeResourceValue_II));
			}
			return IAttributeSetInvoker.cb_getAttributeResourceValue_II;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00024404 File Offset: 0x00022604
		private static int n_GetAttributeResourceValue_II(IntPtr jnienv, IntPtr native__this, int index, int defaultValue)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeResourceValue(index, defaultValue);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00024418 File Offset: 0x00022618
		public unsafe int GetAttributeResourceValue(int index, int defaultValue)
		{
			if (this.id_getAttributeResourceValue_II == IntPtr.Zero)
			{
				this.id_getAttributeResourceValue_II = JNIEnv.GetMethodID(this.class_ref, "getAttributeResourceValue", "(II)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(defaultValue);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeResourceValue_II, ptr);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0002448F File Offset: 0x0002268F
		private static Delegate GetGetAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_IHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I == null)
			{
				IAttributeSetInvoker.cb_getAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_I(IAttributeSetInvoker.n_GetAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I));
			}
			return IAttributeSetInvoker.cb_getAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x000244B4 File Offset: 0x000226B4
		private static int n_GetAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native__namespace, IntPtr native_attribute, int defaultValue)
		{
			IAttributeSet @object = Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__namespace, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_attribute, JniHandleOwnership.DoNotTransfer);
			return @object.GetAttributeResourceValue(@string, string2, defaultValue);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000244E4 File Offset: 0x000226E4
		public unsafe int GetAttributeResourceValue(string @namespace, string attribute, int defaultValue)
		{
			if (this.id_getAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
			{
				this.id_getAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			}
			IntPtr intPtr = JNIEnv.NewString(@namespace);
			IntPtr intPtr2 = JNIEnv.NewString(attribute);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(defaultValue);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0002458B File Offset: 0x0002278B
		private static Delegate GetGetAttributeUnsignedIntValue_IIHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeUnsignedIntValue_II == null)
			{
				IAttributeSetInvoker.cb_getAttributeUnsignedIntValue_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(IAttributeSetInvoker.n_GetAttributeUnsignedIntValue_II));
			}
			return IAttributeSetInvoker.cb_getAttributeUnsignedIntValue_II;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000245AF File Offset: 0x000227AF
		private static int n_GetAttributeUnsignedIntValue_II(IntPtr jnienv, IntPtr native__this, int index, int defaultValue)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeUnsignedIntValue(index, defaultValue);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000245C0 File Offset: 0x000227C0
		public unsafe int GetAttributeUnsignedIntValue(int index, int defaultValue)
		{
			if (this.id_getAttributeUnsignedIntValue_II == IntPtr.Zero)
			{
				this.id_getAttributeUnsignedIntValue_II = JNIEnv.GetMethodID(this.class_ref, "getAttributeUnsignedIntValue", "(II)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(defaultValue);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeUnsignedIntValue_II, ptr);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00024637 File Offset: 0x00022837
		private static Delegate GetGetAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_IHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I == null)
			{
				IAttributeSetInvoker.cb_getAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_I(IAttributeSetInvoker.n_GetAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I));
			}
			return IAttributeSetInvoker.cb_getAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0002465C File Offset: 0x0002285C
		private static int n_GetAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native__namespace, IntPtr native_attribute, int defaultValue)
		{
			IAttributeSet @object = Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__namespace, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_attribute, JniHandleOwnership.DoNotTransfer);
			return @object.GetAttributeUnsignedIntValue(@string, string2, defaultValue);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0002468C File Offset: 0x0002288C
		public unsafe int GetAttributeUnsignedIntValue(string @namespace, string attribute, int defaultValue)
		{
			if (this.id_getAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
			{
				this.id_getAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			}
			IntPtr intPtr = JNIEnv.NewString(@namespace);
			IntPtr intPtr2 = JNIEnv.NewString(attribute);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(defaultValue);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00024733 File Offset: 0x00022933
		private static Delegate GetGetAttributeValue_IHandler()
		{
			if (IAttributeSetInvoker.cb_getAttributeValue_I == null)
			{
				IAttributeSetInvoker.cb_getAttributeValue_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IAttributeSetInvoker.n_GetAttributeValue_I));
			}
			return IAttributeSetInvoker.cb_getAttributeValue_I;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00024757 File Offset: 0x00022957
		private static IntPtr n_GetAttributeValue_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeValue(index));
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0002476C File Offset: 0x0002296C
		public unsafe string GetAttributeValue(int index)
		{
			if (this.id_getAttributeValue_I == IntPtr.Zero)
			{
				this.id_getAttributeValue_I = JNIEnv.GetMethodID(this.class_ref, "getAttributeValue", "(I)Ljava/lang/String;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAttributeValue_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x000247D6 File Offset: 0x000229D6
		private static Delegate GetGetAttributeValue_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (IAttributeSetInvoker.cb_getAttributeValue_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				IAttributeSetInvoker.cb_getAttributeValue_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IAttributeSetInvoker.n_GetAttributeValue_Ljava_lang_String_Ljava_lang_String_));
			}
			return IAttributeSetInvoker.cb_getAttributeValue_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000247FC File Offset: 0x000229FC
		private static IntPtr n_GetAttributeValue_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native__namespace, IntPtr native_name)
		{
			IAttributeSet @object = Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__namespace, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetAttributeValue(@string, string2));
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00024830 File Offset: 0x00022A30
		public unsafe string GetAttributeValue(string @namespace, string name)
		{
			if (this.id_getAttributeValue_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getAttributeValue_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			}
			IntPtr intPtr = JNIEnv.NewString(@namespace);
			IntPtr intPtr2 = JNIEnv.NewString(name);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			string @string = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAttributeValue_Ljava_lang_String_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @string;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000248C7 File Offset: 0x00022AC7
		private static Delegate GetGetIdAttributeResourceValue_IHandler()
		{
			if (IAttributeSetInvoker.cb_getIdAttributeResourceValue_I == null)
			{
				IAttributeSetInvoker.cb_getIdAttributeResourceValue_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(IAttributeSetInvoker.n_GetIdAttributeResourceValue_I));
			}
			return IAttributeSetInvoker.cb_getIdAttributeResourceValue_I;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000248EB File Offset: 0x00022AEB
		private static int n_GetIdAttributeResourceValue_I(IntPtr jnienv, IntPtr native__this, int defaultValue)
		{
			return Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetIdAttributeResourceValue(defaultValue);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000248FC File Offset: 0x00022AFC
		public unsafe int GetIdAttributeResourceValue(int defaultValue)
		{
			if (this.id_getIdAttributeResourceValue_I == IntPtr.Zero)
			{
				this.id_getIdAttributeResourceValue_I = JNIEnv.GetMethodID(this.class_ref, "getIdAttributeResourceValue", "(I)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(defaultValue);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getIdAttributeResourceValue_I, ptr);
		}

		// Token: 0x04000675 RID: 1653
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/util/AttributeSet", typeof(IAttributeSetInvoker));

		// Token: 0x04000676 RID: 1654
		private IntPtr class_ref;

		// Token: 0x04000677 RID: 1655
		private static Delegate cb_getAttributeCount;

		// Token: 0x04000678 RID: 1656
		private IntPtr id_getAttributeCount;

		// Token: 0x04000679 RID: 1657
		private static Delegate cb_getClassAttribute;

		// Token: 0x0400067A RID: 1658
		private IntPtr id_getClassAttribute;

		// Token: 0x0400067B RID: 1659
		private static Delegate cb_getIdAttribute;

		// Token: 0x0400067C RID: 1660
		private IntPtr id_getIdAttribute;

		// Token: 0x0400067D RID: 1661
		private static Delegate cb_getPositionDescription;

		// Token: 0x0400067E RID: 1662
		private IntPtr id_getPositionDescription;

		// Token: 0x0400067F RID: 1663
		private static Delegate cb_getStyleAttribute;

		// Token: 0x04000680 RID: 1664
		private IntPtr id_getStyleAttribute;

		// Token: 0x04000681 RID: 1665
		private static Delegate cb_getAttributeBooleanValue_IZ;

		// Token: 0x04000682 RID: 1666
		private IntPtr id_getAttributeBooleanValue_IZ;

		// Token: 0x04000683 RID: 1667
		private static Delegate cb_getAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;

		// Token: 0x04000684 RID: 1668
		private IntPtr id_getAttributeBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;

		// Token: 0x04000685 RID: 1669
		private static Delegate cb_getAttributeFloatValue_IF;

		// Token: 0x04000686 RID: 1670
		private IntPtr id_getAttributeFloatValue_IF;

		// Token: 0x04000687 RID: 1671
		private static Delegate cb_getAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F;

		// Token: 0x04000688 RID: 1672
		private IntPtr id_getAttributeFloatValue_Ljava_lang_String_Ljava_lang_String_F;

		// Token: 0x04000689 RID: 1673
		private static Delegate cb_getAttributeIntValue_II;

		// Token: 0x0400068A RID: 1674
		private IntPtr id_getAttributeIntValue_II;

		// Token: 0x0400068B RID: 1675
		private static Delegate cb_getAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I;

		// Token: 0x0400068C RID: 1676
		private IntPtr id_getAttributeIntValue_Ljava_lang_String_Ljava_lang_String_I;

		// Token: 0x0400068D RID: 1677
		private static Delegate cb_getAttributeListValue_IarrayLjava_lang_String_I;

		// Token: 0x0400068E RID: 1678
		private IntPtr id_getAttributeListValue_IarrayLjava_lang_String_I;

		// Token: 0x0400068F RID: 1679
		private static Delegate cb_getAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I;

		// Token: 0x04000690 RID: 1680
		private IntPtr id_getAttributeListValue_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_I;

		// Token: 0x04000691 RID: 1681
		private static Delegate cb_getAttributeName_I;

		// Token: 0x04000692 RID: 1682
		private IntPtr id_getAttributeName_I;

		// Token: 0x04000693 RID: 1683
		private static Delegate cb_getAttributeNameResource_I;

		// Token: 0x04000694 RID: 1684
		private IntPtr id_getAttributeNameResource_I;

		// Token: 0x04000695 RID: 1685
		private static Delegate cb_getAttributeResourceValue_II;

		// Token: 0x04000696 RID: 1686
		private IntPtr id_getAttributeResourceValue_II;

		// Token: 0x04000697 RID: 1687
		private static Delegate cb_getAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I;

		// Token: 0x04000698 RID: 1688
		private IntPtr id_getAttributeResourceValue_Ljava_lang_String_Ljava_lang_String_I;

		// Token: 0x04000699 RID: 1689
		private static Delegate cb_getAttributeUnsignedIntValue_II;

		// Token: 0x0400069A RID: 1690
		private IntPtr id_getAttributeUnsignedIntValue_II;

		// Token: 0x0400069B RID: 1691
		private static Delegate cb_getAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I;

		// Token: 0x0400069C RID: 1692
		private IntPtr id_getAttributeUnsignedIntValue_Ljava_lang_String_Ljava_lang_String_I;

		// Token: 0x0400069D RID: 1693
		private static Delegate cb_getAttributeValue_I;

		// Token: 0x0400069E RID: 1694
		private IntPtr id_getAttributeValue_I;

		// Token: 0x0400069F RID: 1695
		private static Delegate cb_getAttributeValue_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040006A0 RID: 1696
		private IntPtr id_getAttributeValue_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040006A1 RID: 1697
		private static Delegate cb_getIdAttributeResourceValue_I;

		// Token: 0x040006A2 RID: 1698
		private IntPtr id_getIdAttributeResourceValue_I;
	}
}
