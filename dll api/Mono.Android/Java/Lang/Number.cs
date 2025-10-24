using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Lang
{
	// Token: 0x020003E8 RID: 1000
	[Register("java/lang/Number", DoNotGenerateAcw = true)]
	public abstract class Number : Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x00079807 File Offset: 0x00077A07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Number._members;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x00079810 File Offset: 0x00077A10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Number._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x00079834 File Offset: 0x00077A34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Number._members.ManagedPeerType;
			}
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Number(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00079840 File Offset: 0x00077A40
		private static Delegate GetByteValueHandler()
		{
			if (Number.cb_byteValue == null)
			{
				Number.cb_byteValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_B(Number.n_ByteValue));
			}
			return Number.cb_byteValue;
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00079864 File Offset: 0x00077A64
		private static sbyte n_ByteValue(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Number>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ByteValue();
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00079873 File Offset: 0x00077A73
		public virtual sbyte ByteValue()
		{
			return Number._members.InstanceMethods.InvokeVirtualSByteMethod("byteValue.()B", this, null);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0007988C File Offset: 0x00077A8C
		private static Delegate GetDoubleValueHandler()
		{
			if (Number.cb_doubleValue == null)
			{
				Number.cb_doubleValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(Number.n_DoubleValue));
			}
			return Number.cb_doubleValue;
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000798B0 File Offset: 0x00077AB0
		private static double n_DoubleValue(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Number>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DoubleValue();
		}

		// Token: 0x06002BE8 RID: 11240
		public abstract double DoubleValue();

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000798BF File Offset: 0x00077ABF
		private static Delegate GetFloatValueHandler()
		{
			if (Number.cb_floatValue == null)
			{
				Number.cb_floatValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(Number.n_FloatValue));
			}
			return Number.cb_floatValue;
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000798E3 File Offset: 0x00077AE3
		private static float n_FloatValue(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Number>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FloatValue();
		}

		// Token: 0x06002BEB RID: 11243
		public abstract float FloatValue();

		// Token: 0x06002BEC RID: 11244 RVA: 0x000798F2 File Offset: 0x00077AF2
		private static Delegate GetIntValueHandler()
		{
			if (Number.cb_intValue == null)
			{
				Number.cb_intValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Number.n_IntValue));
			}
			return Number.cb_intValue;
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00079916 File Offset: 0x00077B16
		private static int n_IntValue(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Number>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IntValue();
		}

		// Token: 0x06002BEE RID: 11246
		public abstract int IntValue();

		// Token: 0x06002BEF RID: 11247 RVA: 0x00079925 File Offset: 0x00077B25
		private static Delegate GetLongValueHandler()
		{
			if (Number.cb_longValue == null)
			{
				Number.cb_longValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(Number.n_LongValue));
			}
			return Number.cb_longValue;
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x00079949 File Offset: 0x00077B49
		private static long n_LongValue(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Number>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LongValue();
		}

		// Token: 0x06002BF1 RID: 11249
		public abstract long LongValue();

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00079958 File Offset: 0x00077B58
		private static Delegate GetShortValueHandler()
		{
			if (Number.cb_shortValue == null)
			{
				Number.cb_shortValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_S(Number.n_ShortValue));
			}
			return Number.cb_shortValue;
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0007997C File Offset: 0x00077B7C
		private static short n_ShortValue(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Number>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShortValue();
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x0007998B File Offset: 0x00077B8B
		public virtual short ShortValue()
		{
			return Number._members.InstanceMethods.InvokeVirtualInt16Method("shortValue.()S", this, null);
		}

		// Token: 0x04001178 RID: 4472
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Number", typeof(Number));

		// Token: 0x04001179 RID: 4473
		private static Delegate cb_byteValue;

		// Token: 0x0400117A RID: 4474
		private static Delegate cb_doubleValue;

		// Token: 0x0400117B RID: 4475
		private static Delegate cb_floatValue;

		// Token: 0x0400117C RID: 4476
		private static Delegate cb_intValue;

		// Token: 0x0400117D RID: 4477
		private static Delegate cb_longValue;

		// Token: 0x0400117E RID: 4478
		private static Delegate cb_shortValue;
	}
}
