using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Functions;

namespace Kotlin.Comparisons
{
	// Token: 0x02000284 RID: 644
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/comparisons/ComparisonsKt", DoNotGenerateAcw = true)]
	public sealed class ComparisonsKt : Java.Lang.Object
	{
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0005F978 File Offset: 0x0005DB78
		internal static IntPtr class_ref
		{
			get
			{
				return ComparisonsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0005F99C File Offset: 0x0005DB9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ComparisonsKt._members;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ComparisonsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x0005F9C8 File Offset: 0x0005DBC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ComparisonsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0005F9D4 File Offset: 0x0005DBD4
		internal ComparisonsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0005F9E0 File Offset: 0x0005DBE0
		[NullableContext(2)]
		[Register("maxOf", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object MaxOf(Java.Lang.Object a, Java.Lang.Object b, [Nullable(1)] IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("maxOf.(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0005FAA8 File Offset: 0x0005DCA8
		[NullableContext(2)]
		[Register("maxOf", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object MaxOf(Java.Lang.Object a, Java.Lang.Object b, Java.Lang.Object c, [Nullable(1)] IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(c);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("maxOf.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
				GC.KeepAlive(c);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0005FB9C File Offset: 0x0005DD9C
		[Register("maxOf", "(Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxOf([Nullable(2)] Java.Lang.Object a, Java.Lang.Object[] other, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(other);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("maxOf.(Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(a);
				GC.KeepAlive(other);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0005FC70 File Offset: 0x0005DE70
		[NullableContext(2)]
		[Register("minOf", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object MinOf(Java.Lang.Object a, Java.Lang.Object b, [Nullable(1)] IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("minOf.(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0005FD38 File Offset: 0x0005DF38
		[NullableContext(2)]
		[Register("minOf", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object MinOf(Java.Lang.Object a, Java.Lang.Object b, Java.Lang.Object c, [Nullable(1)] IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(c);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("minOf.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
				GC.KeepAlive(c);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0005FE2C File Offset: 0x0005E02C
		[Register("minOf", "(Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinOf([Nullable(2)] Java.Lang.Object a, Java.Lang.Object[] other, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(other);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("minOf.(Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(a);
				GC.KeepAlive(other);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0005FF00 File Offset: 0x0005E100
		[Register("maxOf", "(B[B)B", "")]
		public unsafe static sbyte MaxOf(sbyte a, params byte[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeSByteMethod("maxOf.(B[B)B", ptr);
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

		// Token: 0x06001CED RID: 7405 RVA: 0x0005FF80 File Offset: 0x0005E180
		[Register("maxOf", "(D[D)D", "")]
		public unsafe static double MaxOf(double a, params double[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeDoubleMethod("maxOf.(D[D)D", ptr);
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

		// Token: 0x06001CEE RID: 7406 RVA: 0x00060000 File Offset: 0x0005E200
		[Register("maxOf", "(F[F)F", "")]
		public unsafe static float MaxOf(float a, params float[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeSingleMethod("maxOf.(F[F)F", ptr);
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

		// Token: 0x06001CEF RID: 7407 RVA: 0x00060080 File Offset: 0x0005E280
		[Register("maxOf", "(I[I)I", "")]
		public unsafe static int MaxOf(int a, params int[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeInt32Method("maxOf.(I[I)I", ptr);
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

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00060100 File Offset: 0x0005E300
		[Register("maxOf", "(J[J)J", "")]
		public unsafe static long MaxOf(long a, params long[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeInt64Method("maxOf.(J[J)J", ptr);
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

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00060180 File Offset: 0x0005E380
		[Register("maxOf", "(S[S)S", "")]
		public unsafe static short MaxOf(short a, params short[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeInt16Method("maxOf.(S[S)S", ptr);
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

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00060200 File Offset: 0x0005E400
		[Register("maxOf", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MaxOf(Java.Lang.Object a, Java.Lang.Object b)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("maxOf.(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return @object;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00060298 File Offset: 0x0005E498
		[Register("maxOf", "(Ljava/lang/Comparable;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MaxOf(Java.Lang.Object a, Java.Lang.Object b, Java.Lang.Object c)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(c);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("maxOf.(Ljava/lang/Comparable;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
				GC.KeepAlive(c);
			}
			return @object;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0006035C File Offset: 0x0005E55C
		[Register("maxOf", "(Ljava/lang/Comparable;[Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MaxOf(Java.Lang.Object a, params Java.Lang.Object[] other)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(other);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("maxOf.(Ljava/lang/Comparable;[Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(a);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00060400 File Offset: 0x0005E600
		[Register("minOf", "(B[B)B", "")]
		public unsafe static sbyte MinOf(sbyte a, params byte[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeSByteMethod("minOf.(B[B)B", ptr);
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

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00060480 File Offset: 0x0005E680
		[Register("minOf", "(D[D)D", "")]
		public unsafe static double MinOf(double a, params double[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeDoubleMethod("minOf.(D[D)D", ptr);
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

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00060500 File Offset: 0x0005E700
		[Register("minOf", "(F[F)F", "")]
		public unsafe static float MinOf(float a, params float[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeSingleMethod("minOf.(F[F)F", ptr);
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

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00060580 File Offset: 0x0005E780
		[Register("minOf", "(I[I)I", "")]
		public unsafe static int MinOf(int a, params int[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeInt32Method("minOf.(I[I)I", ptr);
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

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00060600 File Offset: 0x0005E800
		[Register("minOf", "(J[J)J", "")]
		public unsafe static long MinOf(long a, params long[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeInt64Method("minOf.(J[J)J", ptr);
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

		// Token: 0x06001CFA RID: 7418 RVA: 0x00060680 File Offset: 0x0005E880
		[Register("minOf", "(S[S)S", "")]
		public unsafe static short MinOf(short a, params short[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(other);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(a);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ComparisonsKt._members.StaticMethods.InvokeInt16Method("minOf.(S[S)S", ptr);
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

		// Token: 0x06001CFB RID: 7419 RVA: 0x00060700 File Offset: 0x0005E900
		[Register("minOf", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MinOf(Java.Lang.Object a, Java.Lang.Object b)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("minOf.(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return @object;
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00060798 File Offset: 0x0005E998
		[Register("minOf", "(Ljava/lang/Comparable;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MinOf(Java.Lang.Object a, Java.Lang.Object b, Java.Lang.Object c)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(c);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("minOf.(Ljava/lang/Comparable;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
				GC.KeepAlive(c);
			}
			return @object;
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0006085C File Offset: 0x0005EA5C
		[Register("minOf", "(Ljava/lang/Comparable;[Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MinOf(Java.Lang.Object a, params Java.Lang.Object[] other)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(other);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("minOf.(Ljava/lang/Comparable;[Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(a);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00060900 File Offset: 0x0005EB00
		[Register("compareBy", "([Lkotlin/jvm/functions/Function1;)Ljava/util/Comparator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator CompareBy(params IFunction1[] selectors)
		{
			IntPtr intPtr = JNIEnv.NewArray<IFunction1>(selectors);
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IComparator>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("compareBy.([Lkotlin/jvm/functions/Function1;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (selectors != null)
				{
					JNIEnv.CopyArray<IFunction1>(intPtr, selectors);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(selectors);
			}
			return @object;
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0006097C File Offset: 0x0005EB7C
		[NullableContext(2)]
		[Register("compareValues", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<?>"
		})]
		public unsafe static int CompareValues(Java.Lang.Object a, Java.Lang.Object b)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = ComparisonsKt._members.StaticMethods.InvokeInt32Method("compareValues.(Ljava/lang/Comparable;Ljava/lang/Comparable;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return result;
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00060A04 File Offset: 0x0005EC04
		[NullableContext(2)]
		[Register("compareValuesBy", "(Ljava/lang/Object;Ljava/lang/Object;[Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int CompareValuesBy(Java.Lang.Object a, Java.Lang.Object b, [Nullable(1)] params IFunction1[] selectors)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			IntPtr intPtr3 = JNIEnv.NewArray<IFunction1>(selectors);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				result = ComparisonsKt._members.StaticMethods.InvokeInt32Method("compareValuesBy.(Ljava/lang/Object;Ljava/lang/Object;[Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (selectors != null)
				{
					JNIEnv.CopyArray<IFunction1>(intPtr3, selectors);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(a);
				GC.KeepAlive(b);
				GC.KeepAlive(selectors);
			}
			return result;
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00060AC4 File Offset: 0x0005ECC4
		[Register("naturalOrder", "()Ljava/util/Comparator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public static IComparator NaturalOrder()
		{
			return Java.Lang.Object.GetObject<IComparator>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("naturalOrder.()Ljava/util/Comparator;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00060AF8 File Offset: 0x0005ECF8
		[Register("nullsFirst", "(Ljava/util/Comparator;)Ljava/util/Comparator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator NullsFirst(IComparator comparator)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("nullsFirst.(Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00060B70 File Offset: 0x0005ED70
		[Register("nullsLast", "(Ljava/util/Comparator;)Ljava/util/Comparator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator NullsLast(IComparator comparator)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("nullsLast.(Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00060BE8 File Offset: 0x0005EDE8
		[Register("reverseOrder", "()Ljava/util/Comparator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public static IComparator ReverseOrder()
		{
			return Java.Lang.Object.GetObject<IComparator>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("reverseOrder.()Ljava/util/Comparator;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00060C1C File Offset: 0x0005EE1C
		[Register("reversed", "(Ljava/util/Comparator;)Ljava/util/Comparator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator Reversed(IComparator _this_reversed)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reversed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reversed).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("reversed.(Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reversed);
			}
			return @object;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00060C94 File Offset: 0x0005EE94
		[Register("then", "(Ljava/util/Comparator;Ljava/util/Comparator;)Ljava/util/Comparator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator Then(IComparator _this_then, IComparator comparator)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_then == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_then).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("then.(Ljava/util/Comparator;Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_then);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00060D38 File Offset: 0x0005EF38
		[Register("thenDescending", "(Ljava/util/Comparator;Ljava/util/Comparator;)Ljava/util/Comparator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator ThenDescending(IComparator _this_thenDescending, IComparator comparator)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_thenDescending == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_thenDescending).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(ComparisonsKt._members.StaticMethods.InvokeObjectMethod("thenDescending.(Ljava/util/Comparator;Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_thenDescending);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x040008E0 RID: 2272
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/comparisons/ComparisonsKt", typeof(ComparisonsKt));
	}
}
