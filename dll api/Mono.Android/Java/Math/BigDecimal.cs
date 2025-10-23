using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Math
{
	// Token: 0x020003B7 RID: 951
	[Register("java/math/BigDecimal", DoNotGenerateAcw = true)]
	public class BigDecimal : Number, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.IComparable
	{
		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x000759A7 File Offset: 0x00073BA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BigDecimal._members;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x000759B0 File Offset: 0x00073BB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BigDecimal._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x000759D4 File Offset: 0x00073BD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BigDecimal._members.ManagedPeerType;
			}
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000759E0 File Offset: 0x00073BE0
		protected BigDecimal(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000759EA File Offset: 0x00073BEA
		private static Delegate GetCompareTo_Ljava_math_BigDecimal_Handler()
		{
			if (BigDecimal.cb_compareTo_Ljava_math_BigDecimal_ == null)
			{
				BigDecimal.cb_compareTo_Ljava_math_BigDecimal_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(BigDecimal.n_CompareTo_Ljava_math_BigDecimal_));
			}
			return BigDecimal.cb_compareTo_Ljava_math_BigDecimal_;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00075A10 File Offset: 0x00073C10
		private static int n_CompareTo_Ljava_math_BigDecimal_(IntPtr jnienv, IntPtr native__this, IntPtr native_val)
		{
			BigDecimal @object = Java.Lang.Object.GetObject<BigDecimal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BigDecimal object2 = Java.Lang.Object.GetObject<BigDecimal>(native_val, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00075A34 File Offset: 0x00073C34
		public unsafe virtual int CompareTo(BigDecimal val)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((val == null) ? IntPtr.Zero : val.Handle);
				result = BigDecimal._members.InstanceMethods.InvokeVirtualInt32Method("compareTo.(Ljava/math/BigDecimal;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(val);
			}
			return result;
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00075A9C File Offset: 0x00073C9C
		private static Delegate GetDoubleValueHandler()
		{
			if (BigDecimal.cb_doubleValue == null)
			{
				BigDecimal.cb_doubleValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(BigDecimal.n_DoubleValue));
			}
			return BigDecimal.cb_doubleValue;
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00075AC0 File Offset: 0x00073CC0
		private static double n_DoubleValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BigDecimal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DoubleValue();
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00075ACF File Offset: 0x00073CCF
		public override double DoubleValue()
		{
			return BigDecimal._members.InstanceMethods.InvokeVirtualDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00075AE8 File Offset: 0x00073CE8
		private static Delegate GetFloatValueHandler()
		{
			if (BigDecimal.cb_floatValue == null)
			{
				BigDecimal.cb_floatValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(BigDecimal.n_FloatValue));
			}
			return BigDecimal.cb_floatValue;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00075B0C File Offset: 0x00073D0C
		private static float n_FloatValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BigDecimal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FloatValue();
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00075B1B File Offset: 0x00073D1B
		public override float FloatValue()
		{
			return BigDecimal._members.InstanceMethods.InvokeVirtualSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00075B34 File Offset: 0x00073D34
		private static Delegate GetIntValueHandler()
		{
			if (BigDecimal.cb_intValue == null)
			{
				BigDecimal.cb_intValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BigDecimal.n_IntValue));
			}
			return BigDecimal.cb_intValue;
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00075B58 File Offset: 0x00073D58
		private static int n_IntValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BigDecimal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IntValue();
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00075B67 File Offset: 0x00073D67
		public override int IntValue()
		{
			return BigDecimal._members.InstanceMethods.InvokeVirtualInt32Method("intValue.()I", this, null);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00075B80 File Offset: 0x00073D80
		private static Delegate GetLongValueHandler()
		{
			if (BigDecimal.cb_longValue == null)
			{
				BigDecimal.cb_longValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(BigDecimal.n_LongValue));
			}
			return BigDecimal.cb_longValue;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00075BA4 File Offset: 0x00073DA4
		private static long n_LongValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BigDecimal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LongValue();
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x00075BB3 File Offset: 0x00073DB3
		public override long LongValue()
		{
			return BigDecimal._members.InstanceMethods.InvokeVirtualInt64Method("longValue.()J", this, null);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00075BCC File Offset: 0x00073DCC
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<BigDecimal>());
		}

		// Token: 0x04001111 RID: 4369
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/math/BigDecimal", typeof(BigDecimal));

		// Token: 0x04001112 RID: 4370
		private static Delegate cb_compareTo_Ljava_math_BigDecimal_;

		// Token: 0x04001113 RID: 4371
		private static Delegate cb_doubleValue;

		// Token: 0x04001114 RID: 4372
		private static Delegate cb_floatValue;

		// Token: 0x04001115 RID: 4373
		private static Delegate cb_intValue;

		// Token: 0x04001116 RID: 4374
		private static Delegate cb_longValue;
	}
}
