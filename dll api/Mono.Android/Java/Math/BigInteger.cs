using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Math
{
	// Token: 0x020003B8 RID: 952
	[Register("java/math/BigInteger", DoNotGenerateAcw = true)]
	public class BigInteger : Number, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.IComparable
	{
		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x00075BF5 File Offset: 0x00073DF5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BigInteger._members;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x00075BFC File Offset: 0x00073DFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BigInteger._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x00075C20 File Offset: 0x00073E20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BigInteger._members.ManagedPeerType;
			}
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000759E0 File Offset: 0x00073BE0
		protected BigInteger(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00075C2C File Offset: 0x00073E2C
		private static Delegate GetCompareTo_Ljava_math_BigInteger_Handler()
		{
			if (BigInteger.cb_compareTo_Ljava_math_BigInteger_ == null)
			{
				BigInteger.cb_compareTo_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(BigInteger.n_CompareTo_Ljava_math_BigInteger_));
			}
			return BigInteger.cb_compareTo_Ljava_math_BigInteger_;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00075C50 File Offset: 0x00073E50
		private static int n_CompareTo_Ljava_math_BigInteger_(IntPtr jnienv, IntPtr native__this, IntPtr native_val)
		{
			BigInteger @object = Java.Lang.Object.GetObject<BigInteger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BigInteger object2 = Java.Lang.Object.GetObject<BigInteger>(native_val, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00075C74 File Offset: 0x00073E74
		public unsafe virtual int CompareTo(BigInteger val)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((val == null) ? IntPtr.Zero : val.Handle);
				result = BigInteger._members.InstanceMethods.InvokeVirtualInt32Method("compareTo.(Ljava/math/BigInteger;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(val);
			}
			return result;
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00075CDC File Offset: 0x00073EDC
		private static Delegate GetDoubleValueHandler()
		{
			if (BigInteger.cb_doubleValue == null)
			{
				BigInteger.cb_doubleValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(BigInteger.n_DoubleValue));
			}
			return BigInteger.cb_doubleValue;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00075D00 File Offset: 0x00073F00
		private static double n_DoubleValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BigInteger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DoubleValue();
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00075D0F File Offset: 0x00073F0F
		public override double DoubleValue()
		{
			return BigInteger._members.InstanceMethods.InvokeVirtualDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00075D28 File Offset: 0x00073F28
		private static Delegate GetFloatValueHandler()
		{
			if (BigInteger.cb_floatValue == null)
			{
				BigInteger.cb_floatValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(BigInteger.n_FloatValue));
			}
			return BigInteger.cb_floatValue;
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00075D4C File Offset: 0x00073F4C
		private static float n_FloatValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BigInteger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FloatValue();
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00075D5B File Offset: 0x00073F5B
		public override float FloatValue()
		{
			return BigInteger._members.InstanceMethods.InvokeVirtualSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00075D74 File Offset: 0x00073F74
		private static Delegate GetIntValueHandler()
		{
			if (BigInteger.cb_intValue == null)
			{
				BigInteger.cb_intValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BigInteger.n_IntValue));
			}
			return BigInteger.cb_intValue;
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00075D98 File Offset: 0x00073F98
		private static int n_IntValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BigInteger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IntValue();
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00075DA7 File Offset: 0x00073FA7
		public override int IntValue()
		{
			return BigInteger._members.InstanceMethods.InvokeVirtualInt32Method("intValue.()I", this, null);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00075DC0 File Offset: 0x00073FC0
		private static Delegate GetLongValueHandler()
		{
			if (BigInteger.cb_longValue == null)
			{
				BigInteger.cb_longValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(BigInteger.n_LongValue));
			}
			return BigInteger.cb_longValue;
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00075DE4 File Offset: 0x00073FE4
		private static long n_LongValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BigInteger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LongValue();
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00075DF3 File Offset: 0x00073FF3
		public override long LongValue()
		{
			return BigInteger._members.InstanceMethods.InvokeVirtualInt64Method("longValue.()J", this, null);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00075E0C File Offset: 0x0007400C
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<BigInteger>());
		}

		// Token: 0x04001117 RID: 4375
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/math/BigInteger", typeof(BigInteger));

		// Token: 0x04001118 RID: 4376
		private static Delegate cb_compareTo_Ljava_math_BigInteger_;

		// Token: 0x04001119 RID: 4377
		private static Delegate cb_doubleValue;

		// Token: 0x0400111A RID: 4378
		private static Delegate cb_floatValue;

		// Token: 0x0400111B RID: 4379
		private static Delegate cb_intValue;

		// Token: 0x0400111C RID: 4380
		private static Delegate cb_longValue;
	}
}
