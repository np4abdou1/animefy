using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Math
{
	// Token: 0x0200014C RID: 332
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/math/MathKt", DoNotGenerateAcw = true)]
	public sealed class MathKt : Java.Lang.Object
	{
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0003A07C File Offset: 0x0003827C
		internal static IntPtr class_ref
		{
			get
			{
				return MathKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0003A0A0 File Offset: 0x000382A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MathKt._members;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0003A0A8 File Offset: 0x000382A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MathKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x0003A0CC File Offset: 0x000382CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MathKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0003A0D8 File Offset: 0x000382D8
		internal MathKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0003A0E4 File Offset: 0x000382E4
		[Register("acosh", "(D)D", "")]
		public unsafe static double Acosh(double x)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			return MathKt._members.StaticMethods.InvokeDoubleMethod("acosh.(D)D", ptr);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0003A120 File Offset: 0x00038320
		[Register("asinh", "(D)D", "")]
		public unsafe static double Asinh(double x)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			return MathKt._members.StaticMethods.InvokeDoubleMethod("asinh.(D)D", ptr);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0003A15C File Offset: 0x0003835C
		[Register("atanh", "(D)D", "")]
		public unsafe static double Atanh(double x)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			return MathKt._members.StaticMethods.InvokeDoubleMethod("atanh.(D)D", ptr);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0003A198 File Offset: 0x00038398
		[Register("getSign", "(I)I", "")]
		public unsafe static int GetSign(int _this_sign)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_sign);
			return MathKt._members.StaticMethods.InvokeInt32Method("getSign.(I)I", ptr);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0003A1D4 File Offset: 0x000383D4
		[Register("getSign", "(J)I", "")]
		public unsafe static int GetSign(long _this_sign)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_sign);
			return MathKt._members.StaticMethods.InvokeInt32Method("getSign.(J)I", ptr);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0003A210 File Offset: 0x00038410
		[Register("log", "(DD)D", "")]
		public unsafe static double Log(double x, double @base)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			ptr[1] = new JniArgumentValue(@base);
			return MathKt._members.StaticMethods.InvokeDoubleMethod("log.(DD)D", ptr);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0003A260 File Offset: 0x00038460
		[Register("log", "(FF)F", "")]
		public unsafe static float Log(float x, float @base)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			ptr[1] = new JniArgumentValue(@base);
			return MathKt._members.StaticMethods.InvokeSingleMethod("log.(FF)F", ptr);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0003A2B0 File Offset: 0x000384B0
		[Register("log2", "(D)D", "")]
		public unsafe static double Log2(double x)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			return MathKt._members.StaticMethods.InvokeDoubleMethod("log2.(D)D", ptr);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0003A2EC File Offset: 0x000384EC
		[Register("log2", "(F)F", "")]
		public unsafe static float Log2(float x)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			return MathKt._members.StaticMethods.InvokeSingleMethod("log2.(F)F", ptr);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0003A328 File Offset: 0x00038528
		[Register("roundToInt", "(D)I", "")]
		public unsafe static int RoundToInt(double _this_roundToInt)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_roundToInt);
			return MathKt._members.StaticMethods.InvokeInt32Method("roundToInt.(D)I", ptr);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0003A364 File Offset: 0x00038564
		[Register("roundToInt", "(F)I", "")]
		public unsafe static int RoundToInt(float _this_roundToInt)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_roundToInt);
			return MathKt._members.StaticMethods.InvokeInt32Method("roundToInt.(F)I", ptr);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0003A3A0 File Offset: 0x000385A0
		[Register("roundToLong", "(D)J", "")]
		public unsafe static long RoundToLong(double _this_roundToLong)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_roundToLong);
			return MathKt._members.StaticMethods.InvokeInt64Method("roundToLong.(D)J", ptr);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0003A3DC File Offset: 0x000385DC
		[Register("roundToLong", "(F)J", "")]
		public unsafe static long RoundToLong(float _this_roundToLong)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_roundToLong);
			return MathKt._members.StaticMethods.InvokeInt64Method("roundToLong.(F)J", ptr);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0003A418 File Offset: 0x00038618
		[Register("truncate", "(D)D", "")]
		public unsafe static double Truncate(double x)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			return MathKt._members.StaticMethods.InvokeDoubleMethod("truncate.(D)D", ptr);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0003A454 File Offset: 0x00038654
		[Register("truncate", "(F)F", "")]
		public unsafe static float Truncate(float x)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			return MathKt._members.StaticMethods.InvokeSingleMethod("truncate.(F)F", ptr);
		}

		// Token: 0x0400059B RID: 1435
		[Register("E")]
		public const double E = 2.718281828459045;

		// Token: 0x0400059C RID: 1436
		[Register("PI")]
		public const double Pi = 3.141592653589793;

		// Token: 0x0400059D RID: 1437
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/math/MathKt", typeof(MathKt));
	}
}
