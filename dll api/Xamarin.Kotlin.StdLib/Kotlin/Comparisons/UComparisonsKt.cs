using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Comparisons
{
	// Token: 0x02000285 RID: 645
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/comparisons/UComparisonsKt", DoNotGenerateAcw = true)]
	public sealed class UComparisonsKt : Java.Lang.Object
	{
		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00060DF8 File Offset: 0x0005EFF8
		internal static IntPtr class_ref
		{
			get
			{
				return UComparisonsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00060E1C File Offset: 0x0005F01C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UComparisonsKt._members;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00060E24 File Offset: 0x0005F024
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UComparisonsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00060E48 File Offset: 0x0005F048
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UComparisonsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00060E54 File Offset: 0x0005F054
		internal UComparisonsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00060E60 File Offset: 0x0005F060
		[Register("maxOf-5PvTz6A", "(SS)S", "")]
		public unsafe static short MaxOf(short a, short b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			ptr[1] = new JniArgumentValue(b);
			return UComparisonsKt._members.StaticMethods.InvokeInt16Method("maxOf-5PvTz6A.(SS)S", ptr);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00060EB0 File Offset: 0x0005F0B0
		[Register("maxOf-J1ME1BU", "(II)I", "")]
		public unsafe static int MaxOf(int a, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			ptr[1] = new JniArgumentValue(b);
			return UComparisonsKt._members.StaticMethods.InvokeInt32Method("maxOf-J1ME1BU.(II)I", ptr);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00060F00 File Offset: 0x0005F100
		[Register("maxOf-Kr8caGY", "(BB)B", "")]
		public unsafe static sbyte MaxOf(sbyte a, sbyte b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			ptr[1] = new JniArgumentValue(b);
			return UComparisonsKt._members.StaticMethods.InvokeSByteMethod("maxOf-Kr8caGY.(BB)B", ptr);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00060F50 File Offset: 0x0005F150
		[Register("maxOf-Md2H83M", "(I[I)I", "")]
		public unsafe static int MaxOf(int a, params int[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = UComparisonsKt._members.StaticMethods.InvokeInt32Method("maxOf-Md2H83M.(I[I)I", ptr);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00060FD0 File Offset: 0x0005F1D0
		[Register("maxOf-R03FKyM", "(J[J)J", "")]
		public unsafe static long MaxOf(long a, params long[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = UComparisonsKt._members.StaticMethods.InvokeInt64Method("maxOf-R03FKyM.(J[J)J", ptr);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00061050 File Offset: 0x0005F250
		[Register("maxOf-Wr6uiD8", "(B[B)B", "")]
		public unsafe static sbyte MaxOf(sbyte a, params byte[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = UComparisonsKt._members.StaticMethods.InvokeSByteMethod("maxOf-Wr6uiD8.(B[B)B", ptr);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000610D0 File Offset: 0x0005F2D0
		[Register("maxOf-eb3DHEI", "(JJ)J", "")]
		public unsafe static long MaxOf(long a, long b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			ptr[1] = new JniArgumentValue(b);
			return UComparisonsKt._members.StaticMethods.InvokeInt64Method("maxOf-eb3DHEI.(JJ)J", ptr);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00061120 File Offset: 0x0005F320
		[Register("maxOf-t1qELG4", "(S[S)S", "")]
		public unsafe static short MaxOf(short a, params short[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = UComparisonsKt._members.StaticMethods.InvokeInt16Method("maxOf-t1qELG4.(S[S)S", ptr);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000611A0 File Offset: 0x0005F3A0
		[Register("minOf-5PvTz6A", "(SS)S", "")]
		public unsafe static short MinOf(short a, short b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			ptr[1] = new JniArgumentValue(b);
			return UComparisonsKt._members.StaticMethods.InvokeInt16Method("minOf-5PvTz6A.(SS)S", ptr);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000611F0 File Offset: 0x0005F3F0
		[Register("minOf-J1ME1BU", "(II)I", "")]
		public unsafe static int MinOf(int a, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			ptr[1] = new JniArgumentValue(b);
			return UComparisonsKt._members.StaticMethods.InvokeInt32Method("minOf-J1ME1BU.(II)I", ptr);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00061240 File Offset: 0x0005F440
		[Register("minOf-Kr8caGY", "(BB)B", "")]
		public unsafe static sbyte MinOf(sbyte a, sbyte b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			ptr[1] = new JniArgumentValue(b);
			return UComparisonsKt._members.StaticMethods.InvokeSByteMethod("minOf-Kr8caGY.(BB)B", ptr);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00061290 File Offset: 0x0005F490
		[Register("minOf-Md2H83M", "(I[I)I", "")]
		public unsafe static int MinOf(int a, params int[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = UComparisonsKt._members.StaticMethods.InvokeInt32Method("minOf-Md2H83M.(I[I)I", ptr);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00061310 File Offset: 0x0005F510
		[Register("minOf-R03FKyM", "(J[J)J", "")]
		public unsafe static long MinOf(long a, params long[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = UComparisonsKt._members.StaticMethods.InvokeInt64Method("minOf-R03FKyM.(J[J)J", ptr);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00061390 File Offset: 0x0005F590
		[Register("minOf-Wr6uiD8", "(B[B)B", "")]
		public unsafe static sbyte MinOf(sbyte a, params byte[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = UComparisonsKt._members.StaticMethods.InvokeSByteMethod("minOf-Wr6uiD8.(B[B)B", ptr);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00061410 File Offset: 0x0005F610
		[Register("minOf-eb3DHEI", "(JJ)J", "")]
		public unsafe static long MinOf(long a, long b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			ptr[1] = new JniArgumentValue(b);
			return UComparisonsKt._members.StaticMethods.InvokeInt64Method("minOf-eb3DHEI.(JJ)J", ptr);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00061460 File Offset: 0x0005F660
		[Register("minOf-t1qELG4", "(S[S)S", "")]
		public unsafe static short MinOf(short a, params short[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = UComparisonsKt._members.StaticMethods.InvokeInt16Method("minOf-t1qELG4.(S[S)S", ptr);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x040008E1 RID: 2273
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/comparisons/UComparisonsKt", typeof(UComparisonsKt));
	}
}
