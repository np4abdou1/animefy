using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x0200006F RID: 111
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/Metadata", DoNotGenerateAcw = true)]
	internal class IMetadataInvoker : Java.Lang.Object, IMetadata, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00005AEC File Offset: 0x00003CEC
		private static IntPtr java_class_ref
		{
			get
			{
				return IMetadataInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00005B10 File Offset: 0x00003D10
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IMetadataInvoker._members;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00005B17 File Offset: 0x00003D17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00005B1F File Offset: 0x00003D1F
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IMetadataInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00005B2B File Offset: 0x00003D2B
		public static IMetadata GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMetadata>(handle, transfer);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00005B34 File Offset: 0x00003D34
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMetadataInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.Metadata'.");
			}
			return handle;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00005B5F File Offset: 0x00003D5F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00005B90 File Offset: 0x00003D90
		public IMetadataInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMetadataInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[NullableContext(1)]
		[Obsolete]
		private static Delegate GetBvHandler()
		{
			if (IMetadataInvoker.cb_bv == null)
			{
				IMetadataInvoker.cb_bv = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMetadataInvoker.n_Bv));
			}
			return IMetadataInvoker.cb_bv;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00005BEC File Offset: 0x00003DEC
		[Obsolete]
		private static IntPtr n_Bv(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Bv());
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00005C00 File Offset: 0x00003E00
		public int[] Bv()
		{
			if (this.id_bv == IntPtr.Zero)
			{
				this.id_bv = JNIEnv.GetMethodID(this.class_ref, "bv", "()[I");
			}
			return (int[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_bv), JniHandleOwnership.TransferLocalRef, typeof(int));
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00005C60 File Offset: 0x00003E60
		[NullableContext(1)]
		private static Delegate GetD1Handler()
		{
			if (IMetadataInvoker.cb_d1 == null)
			{
				IMetadataInvoker.cb_d1 = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMetadataInvoker.n_D1));
			}
			return IMetadataInvoker.cb_d1;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00005C84 File Offset: 0x00003E84
		private static IntPtr n_D1(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).D1());
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00005C98 File Offset: 0x00003E98
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] D1()
		{
			if (this.id_d1 == IntPtr.Zero)
			{
				this.id_d1 = JNIEnv.GetMethodID(this.class_ref, "d1", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_d1), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00005CF8 File Offset: 0x00003EF8
		[NullableContext(1)]
		private static Delegate GetD2Handler()
		{
			if (IMetadataInvoker.cb_d2 == null)
			{
				IMetadataInvoker.cb_d2 = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMetadataInvoker.n_D2));
			}
			return IMetadataInvoker.cb_d2;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00005D1C File Offset: 0x00003F1C
		private static IntPtr n_D2(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).D2());
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00005D30 File Offset: 0x00003F30
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] D2()
		{
			if (this.id_d2 == IntPtr.Zero)
			{
				this.id_d2 = JNIEnv.GetMethodID(this.class_ref, "d2", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_d2), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00005D90 File Offset: 0x00003F90
		[NullableContext(1)]
		private static Delegate GetKHandler()
		{
			if (IMetadataInvoker.cb_k == null)
			{
				IMetadataInvoker.cb_k = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMetadataInvoker.n_K));
			}
			return IMetadataInvoker.cb_k;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00005DB4 File Offset: 0x00003FB4
		private static int n_K(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).K();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00005DC3 File Offset: 0x00003FC3
		public int K()
		{
			if (this.id_k == IntPtr.Zero)
			{
				this.id_k = JNIEnv.GetMethodID(this.class_ref, "k", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_k);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00005E03 File Offset: 0x00004003
		[NullableContext(1)]
		private static Delegate GetMvHandler()
		{
			if (IMetadataInvoker.cb_mv == null)
			{
				IMetadataInvoker.cb_mv = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMetadataInvoker.n_Mv));
			}
			return IMetadataInvoker.cb_mv;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00005E27 File Offset: 0x00004027
		private static IntPtr n_Mv(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Mv());
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00005E3C File Offset: 0x0000403C
		public int[] Mv()
		{
			if (this.id_mv == IntPtr.Zero)
			{
				this.id_mv = JNIEnv.GetMethodID(this.class_ref, "mv", "()[I");
			}
			return (int[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_mv), JniHandleOwnership.TransferLocalRef, typeof(int));
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00005E9C File Offset: 0x0000409C
		[NullableContext(1)]
		private static Delegate GetPnHandler()
		{
			if (IMetadataInvoker.cb_pn == null)
			{
				IMetadataInvoker.cb_pn = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMetadataInvoker.n_Pn));
			}
			return IMetadataInvoker.cb_pn;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00005EC0 File Offset: 0x000040C0
		private static IntPtr n_Pn(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pn());
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00005ED4 File Offset: 0x000040D4
		public string Pn()
		{
			if (this.id_pn == IntPtr.Zero)
			{
				this.id_pn = JNIEnv.GetMethodID(this.class_ref, "pn", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_pn), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00005F25 File Offset: 0x00004125
		[NullableContext(1)]
		private static Delegate GetXiHandler()
		{
			if (IMetadataInvoker.cb_xi == null)
			{
				IMetadataInvoker.cb_xi = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMetadataInvoker.n_Xi));
			}
			return IMetadataInvoker.cb_xi;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00005F49 File Offset: 0x00004149
		private static int n_Xi(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Xi();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00005F58 File Offset: 0x00004158
		public int Xi()
		{
			if (this.id_xi == IntPtr.Zero)
			{
				this.id_xi = JNIEnv.GetMethodID(this.class_ref, "xi", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_xi);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00005F98 File Offset: 0x00004198
		[NullableContext(1)]
		private static Delegate GetXsHandler()
		{
			if (IMetadataInvoker.cb_xs == null)
			{
				IMetadataInvoker.cb_xs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMetadataInvoker.n_Xs));
			}
			return IMetadataInvoker.cb_xs;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00005FBC File Offset: 0x000041BC
		private static IntPtr n_Xs(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Xs());
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00005FD0 File Offset: 0x000041D0
		public string Xs()
		{
			if (this.id_xs == IntPtr.Zero)
			{
				this.id_xs = JNIEnv.GetMethodID(this.class_ref, "xs", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_xs), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00006021 File Offset: 0x00004221
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IMetadataInvoker.cb_annotationType == null)
			{
				IMetadataInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMetadataInvoker.n_AnnotationType));
			}
			return IMetadataInvoker.cb_annotationType;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00006045 File Offset: 0x00004245
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000605C File Offset: 0x0000425C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000060AD File Offset: 0x000042AD
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMetadataInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMetadataInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMetadataInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMetadataInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000060D4 File Offset: 0x000042D4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000060F8 File Offset: 0x000042F8
		public new unsafe bool Equals(Java.Lang.Object obj)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((obj == null) ? IntPtr.Zero : obj.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000616B File Offset: 0x0000436B
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMetadataInvoker.cb_hashCode == null)
			{
				IMetadataInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMetadataInvoker.n_GetHashCode));
			}
			return IMetadataInvoker.cb_hashCode;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000618F File Offset: 0x0000438F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000619E File Offset: 0x0000439E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000061DE File Offset: 0x000043DE
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (IMetadataInvoker.cb_toString == null)
			{
				IMetadataInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMetadataInvoker.n_ToString));
			}
			return IMetadataInvoker.cb_toString;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00006202 File Offset: 0x00004402
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00006218 File Offset: 0x00004418
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400009B RID: 155
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Metadata", typeof(IMetadataInvoker));

		// Token: 0x0400009C RID: 156
		private IntPtr class_ref;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_bv;

		// Token: 0x0400009E RID: 158
		private IntPtr id_bv;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_d1;

		// Token: 0x040000A0 RID: 160
		private IntPtr id_d1;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_d2;

		// Token: 0x040000A2 RID: 162
		private IntPtr id_d2;

		// Token: 0x040000A3 RID: 163
		private static Delegate cb_k;

		// Token: 0x040000A4 RID: 164
		private IntPtr id_k;

		// Token: 0x040000A5 RID: 165
		private static Delegate cb_mv;

		// Token: 0x040000A6 RID: 166
		private IntPtr id_mv;

		// Token: 0x040000A7 RID: 167
		private static Delegate cb_pn;

		// Token: 0x040000A8 RID: 168
		private IntPtr id_pn;

		// Token: 0x040000A9 RID: 169
		private static Delegate cb_xi;

		// Token: 0x040000AA RID: 170
		private IntPtr id_xi;

		// Token: 0x040000AB RID: 171
		private static Delegate cb_xs;

		// Token: 0x040000AC RID: 172
		private IntPtr id_xs;

		// Token: 0x040000AD RID: 173
		private static Delegate cb_annotationType;

		// Token: 0x040000AE RID: 174
		private IntPtr id_annotationType;

		// Token: 0x040000AF RID: 175
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000B0 RID: 176
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000B1 RID: 177
		private static Delegate cb_hashCode;

		// Token: 0x040000B2 RID: 178
		private IntPtr id_hashCode;

		// Token: 0x040000B3 RID: 179
		private static Delegate cb_toString;

		// Token: 0x040000B4 RID: 180
		private IntPtr id_toString;
	}
}
