using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200008F RID: 143
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/NumbersKt", DoNotGenerateAcw = true)]
	public sealed class NumbersKt : Java.Lang.Object
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00009C44 File Offset: 0x00007E44
		internal static IntPtr class_ref
		{
			get
			{
				return NumbersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00009C68 File Offset: 0x00007E68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NumbersKt._members;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00009C70 File Offset: 0x00007E70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NumbersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00009C94 File Offset: 0x00007E94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NumbersKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00009CA0 File Offset: 0x00007EA0
		internal NumbersKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00009CAC File Offset: 0x00007EAC
		[Register("rotateLeft", "(BI)B", "")]
		public unsafe static sbyte RotateLeft(sbyte _this_rotateLeft, int bitCount)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_rotateLeft);
			ptr[1] = new JniArgumentValue(bitCount);
			return NumbersKt._members.StaticMethods.InvokeSByteMethod("rotateLeft.(BI)B", ptr);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00009CFC File Offset: 0x00007EFC
		[Register("rotateLeft", "(SI)S", "")]
		public unsafe static short RotateLeft(short _this_rotateLeft, int bitCount)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_rotateLeft);
			ptr[1] = new JniArgumentValue(bitCount);
			return NumbersKt._members.StaticMethods.InvokeInt16Method("rotateLeft.(SI)S", ptr);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00009D4C File Offset: 0x00007F4C
		[Register("rotateRight", "(BI)B", "")]
		public unsafe static sbyte RotateRight(sbyte _this_rotateRight, int bitCount)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_rotateRight);
			ptr[1] = new JniArgumentValue(bitCount);
			return NumbersKt._members.StaticMethods.InvokeSByteMethod("rotateRight.(BI)B", ptr);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00009D9C File Offset: 0x00007F9C
		[Register("rotateRight", "(SI)S", "")]
		public unsafe static short RotateRight(short _this_rotateRight, int bitCount)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_rotateRight);
			ptr[1] = new JniArgumentValue(bitCount);
			return NumbersKt._members.StaticMethods.InvokeInt16Method("rotateRight.(SI)S", ptr);
		}

		// Token: 0x04000146 RID: 326
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/NumbersKt", typeof(NumbersKt));
	}
}
