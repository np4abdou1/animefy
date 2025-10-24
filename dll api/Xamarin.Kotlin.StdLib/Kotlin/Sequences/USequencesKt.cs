using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Sequences
{
	// Token: 0x020000FB RID: 251
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/sequences/USequencesKt", DoNotGenerateAcw = true)]
	public sealed class USequencesKt : Java.Lang.Object
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00028B28 File Offset: 0x00026D28
		internal static IntPtr class_ref
		{
			get
			{
				return USequencesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00028B4C File Offset: 0x00026D4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return USequencesKt._members;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00028B54 File Offset: 0x00026D54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return USequencesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00028B78 File Offset: 0x00026D78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return USequencesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00028B84 File Offset: 0x00026D84
		internal USequencesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00028B90 File Offset: 0x00026D90
		[Register("sumOfUByte", "(Lkotlin/sequences/Sequence;)I", "")]
		public unsafe static int SumOfUByte(ISequence _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = USequencesKt._members.StaticMethods.InvokeInt32Method("sumOfUByte.(Lkotlin/sequences/Sequence;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00028BFC File Offset: 0x00026DFC
		[Register("sumOfUInt", "(Lkotlin/sequences/Sequence;)I", "")]
		public unsafe static int SumOfUInt(ISequence _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = USequencesKt._members.StaticMethods.InvokeInt32Method("sumOfUInt.(Lkotlin/sequences/Sequence;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00028C68 File Offset: 0x00026E68
		[Register("sumOfULong", "(Lkotlin/sequences/Sequence;)J", "")]
		public unsafe static long SumOfULong(ISequence _this_sum)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = USequencesKt._members.StaticMethods.InvokeInt64Method("sumOfULong.(Lkotlin/sequences/Sequence;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00028CD4 File Offset: 0x00026ED4
		[Register("sumOfUShort", "(Lkotlin/sequences/Sequence;)I", "")]
		public unsafe static int SumOfUShort(ISequence _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = USequencesKt._members.StaticMethods.InvokeInt32Method("sumOfUShort.(Lkotlin/sequences/Sequence;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x04000267 RID: 615
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/sequences/USequencesKt", typeof(USequencesKt));
	}
}
