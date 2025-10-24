using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Random;
using Kotlin.Ranges;

namespace Kotlin.Collections.Unsigned
{
	// Token: 0x020002D9 RID: 729
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/unsigned/UArraysKt", DoNotGenerateAcw = true)]
	public sealed class UArraysKt : Java.Lang.Object
	{
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x000B0978 File Offset: 0x000AEB78
		internal static IntPtr class_ref
		{
			get
			{
				return UArraysKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x000B099C File Offset: 0x000AEB9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UArraysKt._members;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x000B09A4 File Offset: 0x000AEBA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UArraysKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x000B09C8 File Offset: 0x000AEBC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UArraysKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x000B09D4 File Offset: 0x000AEBD4
		internal UArraysKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x000B09E0 File Offset: 0x000AEBE0
		[NullableContext(2)]
		[Register("contentEquals-FGO6Aew", "([S[S)Z", "")]
		public unsafe static bool ContentEquals(short[] _this_contentEquals_u2dFGO6Aew, short[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentEquals_u2dFGO6Aew);
			IntPtr intPtr2 = JNIEnv.NewArray(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = UArraysKt._members.StaticMethods.InvokeBooleanMethod("contentEquals-FGO6Aew.([S[S)Z", ptr);
			}
			finally
			{
				if (_this_contentEquals_u2dFGO6Aew != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentEquals_u2dFGO6Aew);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_contentEquals_u2dFGO6Aew);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x000B0A7C File Offset: 0x000AEC7C
		[NullableContext(2)]
		[Register("contentEquals-KJPZfPQ", "([I[I)Z", "")]
		public unsafe static bool ContentEquals(int[] _this_contentEquals_u2dKJPZfPQ, int[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentEquals_u2dKJPZfPQ);
			IntPtr intPtr2 = JNIEnv.NewArray(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = UArraysKt._members.StaticMethods.InvokeBooleanMethod("contentEquals-KJPZfPQ.([I[I)Z", ptr);
			}
			finally
			{
				if (_this_contentEquals_u2dKJPZfPQ != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentEquals_u2dKJPZfPQ);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_contentEquals_u2dKJPZfPQ);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x000B0B18 File Offset: 0x000AED18
		[NullableContext(2)]
		[Register("contentEquals-kV0jMPg", "([B[B)Z", "")]
		public unsafe static bool ContentEquals(byte[] _this_contentEquals_u2dkV0jMPg, byte[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentEquals_u2dkV0jMPg);
			IntPtr intPtr2 = JNIEnv.NewArray(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = UArraysKt._members.StaticMethods.InvokeBooleanMethod("contentEquals-kV0jMPg.([B[B)Z", ptr);
			}
			finally
			{
				if (_this_contentEquals_u2dkV0jMPg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentEquals_u2dkV0jMPg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_contentEquals_u2dkV0jMPg);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x000B0BB4 File Offset: 0x000AEDB4
		[NullableContext(2)]
		[Register("contentEquals-lec5QzE", "([J[J)Z", "")]
		public unsafe static bool ContentEquals(long[] _this_contentEquals_u2dlec5QzE, long[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentEquals_u2dlec5QzE);
			IntPtr intPtr2 = JNIEnv.NewArray(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = UArraysKt._members.StaticMethods.InvokeBooleanMethod("contentEquals-lec5QzE.([J[J)Z", ptr);
			}
			finally
			{
				if (_this_contentEquals_u2dlec5QzE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentEquals_u2dlec5QzE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_contentEquals_u2dlec5QzE);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x000B0C50 File Offset: 0x000AEE50
		[NullableContext(2)]
		[Register("contentHashCode-2csIQuQ", "([B)I", "")]
		public unsafe static int ContentHashCode(byte[] _this_contentHashCode_u2d2csIQuQ)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentHashCode_u2d2csIQuQ);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("contentHashCode-2csIQuQ.([B)I", ptr);
			}
			finally
			{
				if (_this_contentHashCode_u2d2csIQuQ != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentHashCode_u2d2csIQuQ);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_contentHashCode_u2d2csIQuQ);
			}
			return result;
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000B0CBC File Offset: 0x000AEEBC
		[NullableContext(2)]
		[Register("contentHashCode-XUkPCBk", "([I)I", "")]
		public unsafe static int ContentHashCode(int[] _this_contentHashCode_u2dXUkPCBk)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentHashCode_u2dXUkPCBk);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("contentHashCode-XUkPCBk.([I)I", ptr);
			}
			finally
			{
				if (_this_contentHashCode_u2dXUkPCBk != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentHashCode_u2dXUkPCBk);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_contentHashCode_u2dXUkPCBk);
			}
			return result;
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000B0D28 File Offset: 0x000AEF28
		[NullableContext(2)]
		[Register("contentHashCode-d-6D3K8", "([S)I", "")]
		public unsafe static int ContentHashCode(short[] _this_contentHashCode_u2dd_u2d6D3K8)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentHashCode_u2dd_u2d6D3K8);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("contentHashCode-d-6D3K8.([S)I", ptr);
			}
			finally
			{
				if (_this_contentHashCode_u2dd_u2d6D3K8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentHashCode_u2dd_u2d6D3K8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_contentHashCode_u2dd_u2d6D3K8);
			}
			return result;
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000B0D94 File Offset: 0x000AEF94
		[NullableContext(2)]
		[Register("contentHashCode-uLth9ew", "([J)I", "")]
		public unsafe static int ContentHashCode(long[] _this_contentHashCode_u2duLth9ew)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentHashCode_u2duLth9ew);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("contentHashCode-uLth9ew.([J)I", ptr);
			}
			finally
			{
				if (_this_contentHashCode_u2duLth9ew != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentHashCode_u2duLth9ew);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_contentHashCode_u2duLth9ew);
			}
			return result;
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000B0E00 File Offset: 0x000AF000
		[Register("contentToString-2csIQuQ", "([B)Ljava/lang/String;", "")]
		public unsafe static string ContentToString([Nullable(2)] byte[] _this_contentToString_u2d2csIQuQ)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentToString_u2d2csIQuQ);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(UArraysKt._members.StaticMethods.InvokeObjectMethod("contentToString-2csIQuQ.([B)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_contentToString_u2d2csIQuQ != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentToString_u2d2csIQuQ);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_contentToString_u2d2csIQuQ);
			}
			return @string;
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000B0E7C File Offset: 0x000AF07C
		[Register("contentToString-XUkPCBk", "([I)Ljava/lang/String;", "")]
		public unsafe static string ContentToString([Nullable(2)] int[] _this_contentToString_u2dXUkPCBk)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentToString_u2dXUkPCBk);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(UArraysKt._members.StaticMethods.InvokeObjectMethod("contentToString-XUkPCBk.([I)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_contentToString_u2dXUkPCBk != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentToString_u2dXUkPCBk);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_contentToString_u2dXUkPCBk);
			}
			return @string;
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000B0EF8 File Offset: 0x000AF0F8
		[Register("contentToString-d-6D3K8", "([S)Ljava/lang/String;", "")]
		public unsafe static string ContentToString([Nullable(2)] short[] _this_contentToString_u2dd_u2d6D3K8)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentToString_u2dd_u2d6D3K8);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(UArraysKt._members.StaticMethods.InvokeObjectMethod("contentToString-d-6D3K8.([S)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_contentToString_u2dd_u2d6D3K8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentToString_u2dd_u2d6D3K8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_contentToString_u2dd_u2d6D3K8);
			}
			return @string;
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000B0F74 File Offset: 0x000AF174
		[Register("contentToString-uLth9ew", "([J)Ljava/lang/String;", "")]
		public unsafe static string ContentToString([Nullable(2)] long[] _this_contentToString_u2duLth9ew)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_contentToString_u2duLth9ew);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(UArraysKt._members.StaticMethods.InvokeObjectMethod("contentToString-uLth9ew.([J)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_contentToString_u2duLth9ew != null)
				{
					JNIEnv.CopyArray(intPtr, _this_contentToString_u2duLth9ew);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_contentToString_u2duLth9ew);
			}
			return @string;
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000B0FF0 File Offset: 0x000AF1F0
		[Register("drop-PpDY95g", "([BI)Ljava/util/List;", "")]
		public unsafe static IList<UByte> Drop(byte[] _this_drop_u2dPpDY95g, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_drop_u2dPpDY95g);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("drop-PpDY95g.([BI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_drop_u2dPpDY95g != null)
				{
					JNIEnv.CopyArray(intPtr, _this_drop_u2dPpDY95g);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_drop_u2dPpDY95g);
			}
			return result;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000B1080 File Offset: 0x000AF280
		[Register("drop-nggk6HY", "([SI)Ljava/util/List;", "")]
		public unsafe static IList<UShort> Drop(short[] _this_drop_u2dnggk6HY, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_drop_u2dnggk6HY);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("drop-nggk6HY.([SI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_drop_u2dnggk6HY != null)
				{
					JNIEnv.CopyArray(intPtr, _this_drop_u2dnggk6HY);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_drop_u2dnggk6HY);
			}
			return result;
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000B1110 File Offset: 0x000AF310
		[Register("drop-qFRl0hI", "([II)Ljava/util/List;", "")]
		public unsafe static IList<UInt> Drop(int[] _this_drop_u2dqFRl0hI, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_drop_u2dqFRl0hI);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("drop-qFRl0hI.([II)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_drop_u2dqFRl0hI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_drop_u2dqFRl0hI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_drop_u2dqFRl0hI);
			}
			return result;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000B11A0 File Offset: 0x000AF3A0
		[Register("drop-r7IrZao", "([JI)Ljava/util/List;", "")]
		public unsafe static IList<ULong> Drop(long[] _this_drop_u2dr7IrZao, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_drop_u2dr7IrZao);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("drop-r7IrZao.([JI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_drop_u2dr7IrZao != null)
				{
					JNIEnv.CopyArray(intPtr, _this_drop_u2dr7IrZao);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_drop_u2dr7IrZao);
			}
			return result;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000B1230 File Offset: 0x000AF430
		[Register("dropLast-PpDY95g", "([BI)Ljava/util/List;", "")]
		public unsafe static IList<UByte> DropLast(byte[] _this_dropLast_u2dPpDY95g, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_dropLast_u2dPpDY95g);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("dropLast-PpDY95g.([BI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_dropLast_u2dPpDY95g != null)
				{
					JNIEnv.CopyArray(intPtr, _this_dropLast_u2dPpDY95g);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_dropLast_u2dPpDY95g);
			}
			return result;
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000B12C0 File Offset: 0x000AF4C0
		[Register("dropLast-nggk6HY", "([SI)Ljava/util/List;", "")]
		public unsafe static IList<UShort> DropLast(short[] _this_dropLast_u2dnggk6HY, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_dropLast_u2dnggk6HY);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("dropLast-nggk6HY.([SI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_dropLast_u2dnggk6HY != null)
				{
					JNIEnv.CopyArray(intPtr, _this_dropLast_u2dnggk6HY);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_dropLast_u2dnggk6HY);
			}
			return result;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000B1350 File Offset: 0x000AF550
		[Register("dropLast-qFRl0hI", "([II)Ljava/util/List;", "")]
		public unsafe static IList<UInt> DropLast(int[] _this_dropLast_u2dqFRl0hI, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_dropLast_u2dqFRl0hI);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("dropLast-qFRl0hI.([II)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_dropLast_u2dqFRl0hI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_dropLast_u2dqFRl0hI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_dropLast_u2dqFRl0hI);
			}
			return result;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000B13E0 File Offset: 0x000AF5E0
		[Register("dropLast-r7IrZao", "([JI)Ljava/util/List;", "")]
		public unsafe static IList<ULong> DropLast(long[] _this_dropLast_u2dr7IrZao, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_dropLast_u2dr7IrZao);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("dropLast-r7IrZao.([JI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_dropLast_u2dr7IrZao != null)
				{
					JNIEnv.CopyArray(intPtr, _this_dropLast_u2dr7IrZao);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_dropLast_u2dr7IrZao);
			}
			return result;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000B1470 File Offset: 0x000AF670
		[Register("fill-2fe2U9s", "([IIII)V", "")]
		public unsafe static void Fill(int[] _this_fill_u2d2fe2U9s, int element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_fill_u2d2fe2U9s);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("fill-2fe2U9s.([IIII)V", ptr);
			}
			finally
			{
				if (_this_fill_u2d2fe2U9s != null)
				{
					JNIEnv.CopyArray(intPtr, _this_fill_u2d2fe2U9s);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_fill_u2d2fe2U9s);
			}
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000B151C File Offset: 0x000AF71C
		[Register("fill-EtDCXyQ", "([SSII)V", "")]
		public unsafe static void Fill(short[] _this_fill_u2dEtDCXyQ, short element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_fill_u2dEtDCXyQ);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("fill-EtDCXyQ.([SSII)V", ptr);
			}
			finally
			{
				if (_this_fill_u2dEtDCXyQ != null)
				{
					JNIEnv.CopyArray(intPtr, _this_fill_u2dEtDCXyQ);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_fill_u2dEtDCXyQ);
			}
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000B15C8 File Offset: 0x000AF7C8
		[Register("fill-K6DWlUc", "([JJII)V", "")]
		public unsafe static void Fill(long[] _this_fill_u2dK6DWlUc, long element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_fill_u2dK6DWlUc);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("fill-K6DWlUc.([JJII)V", ptr);
			}
			finally
			{
				if (_this_fill_u2dK6DWlUc != null)
				{
					JNIEnv.CopyArray(intPtr, _this_fill_u2dK6DWlUc);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_fill_u2dK6DWlUc);
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000B1674 File Offset: 0x000AF874
		[Register("fill-WpHrYlw", "([BBII)V", "")]
		public unsafe static void Fill(byte[] _this_fill_u2dWpHrYlw, sbyte element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_fill_u2dWpHrYlw);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("fill-WpHrYlw.([BBII)V", ptr);
			}
			finally
			{
				if (_this_fill_u2dWpHrYlw != null)
				{
					JNIEnv.CopyArray(intPtr, _this_fill_u2dWpHrYlw);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_fill_u2dWpHrYlw);
			}
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000B1720 File Offset: 0x000AF920
		[Register("firstOrNull--ajY-9A", "([I)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt FirstOrNull(int[] _this_firstOrNull_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_firstOrNull_u2d_u2dajY_u2d9A);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("firstOrNull--ajY-9A.([I)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_firstOrNull_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_firstOrNull_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_firstOrNull_u2d_u2dajY_u2d9A);
			}
			return @object;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000B179C File Offset: 0x000AF99C
		[Register("firstOrNull-GBYM_sE", "([B)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte FirstOrNull(byte[] _this_firstOrNull_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_firstOrNull_u2dGBYM_sE);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("firstOrNull-GBYM_sE.([B)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_firstOrNull_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_firstOrNull_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_firstOrNull_u2dGBYM_sE);
			}
			return @object;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000B1818 File Offset: 0x000AFA18
		[Register("firstOrNull-QwZRm1k", "([J)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong FirstOrNull(long[] _this_firstOrNull_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_firstOrNull_u2dQwZRm1k);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("firstOrNull-QwZRm1k.([J)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_firstOrNull_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_firstOrNull_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_firstOrNull_u2dQwZRm1k);
			}
			return @object;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000B1894 File Offset: 0x000AFA94
		[Register("firstOrNull-rL5Bavg", "([S)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort FirstOrNull(short[] _this_firstOrNull_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_firstOrNull_u2drL5Bavg);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("firstOrNull-rL5Bavg.([S)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_firstOrNull_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_firstOrNull_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_firstOrNull_u2drL5Bavg);
			}
			return @object;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000B1910 File Offset: 0x000AFB10
		[Register("getIndices--ajY-9A", "([I)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange GetIndices(int[] _this_indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_indices);
			IntRange @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IntRange>(UArraysKt._members.StaticMethods.InvokeObjectMethod("getIndices--ajY-9A.([I)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_indices != null)
				{
					JNIEnv.CopyArray(intPtr, _this_indices);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_indices);
			}
			return @object;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000B198C File Offset: 0x000AFB8C
		[Register("getIndices-GBYM_sE", "([B)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange GetIndices(byte[] _this_indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_indices);
			IntRange @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IntRange>(UArraysKt._members.StaticMethods.InvokeObjectMethod("getIndices-GBYM_sE.([B)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_indices != null)
				{
					JNIEnv.CopyArray(intPtr, _this_indices);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_indices);
			}
			return @object;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000B1A08 File Offset: 0x000AFC08
		[Register("getIndices-QwZRm1k", "([J)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange GetIndices(long[] _this_indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_indices);
			IntRange @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IntRange>(UArraysKt._members.StaticMethods.InvokeObjectMethod("getIndices-QwZRm1k.([J)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_indices != null)
				{
					JNIEnv.CopyArray(intPtr, _this_indices);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_indices);
			}
			return @object;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000B1A84 File Offset: 0x000AFC84
		[Register("getIndices-rL5Bavg", "([S)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange GetIndices(short[] _this_indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_indices);
			IntRange @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IntRange>(UArraysKt._members.StaticMethods.InvokeObjectMethod("getIndices-rL5Bavg.([S)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_indices != null)
				{
					JNIEnv.CopyArray(intPtr, _this_indices);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_indices);
			}
			return @object;
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000B1B00 File Offset: 0x000AFD00
		[Register("getLastIndex--ajY-9A", "([I)I", "")]
		public unsafe static int GetLastIndex(int[] _this_lastIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_lastIndex);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("getLastIndex--ajY-9A.([I)I", ptr);
			}
			finally
			{
				if (_this_lastIndex != null)
				{
					JNIEnv.CopyArray(intPtr, _this_lastIndex);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_lastIndex);
			}
			return result;
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x000B1B6C File Offset: 0x000AFD6C
		[Register("getLastIndex-GBYM_sE", "([B)I", "")]
		public unsafe static int GetLastIndex(byte[] _this_lastIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_lastIndex);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("getLastIndex-GBYM_sE.([B)I", ptr);
			}
			finally
			{
				if (_this_lastIndex != null)
				{
					JNIEnv.CopyArray(intPtr, _this_lastIndex);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_lastIndex);
			}
			return result;
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000B1BD8 File Offset: 0x000AFDD8
		[Register("getLastIndex-QwZRm1k", "([J)I", "")]
		public unsafe static int GetLastIndex(long[] _this_lastIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_lastIndex);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("getLastIndex-QwZRm1k.([J)I", ptr);
			}
			finally
			{
				if (_this_lastIndex != null)
				{
					JNIEnv.CopyArray(intPtr, _this_lastIndex);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_lastIndex);
			}
			return result;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000B1C44 File Offset: 0x000AFE44
		[Register("getLastIndex-rL5Bavg", "([S)I", "")]
		public unsafe static int GetLastIndex(short[] _this_lastIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_lastIndex);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("getLastIndex-rL5Bavg.([S)I", ptr);
			}
			finally
			{
				if (_this_lastIndex != null)
				{
					JNIEnv.CopyArray(intPtr, _this_lastIndex);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_lastIndex);
			}
			return result;
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000B1CB0 File Offset: 0x000AFEB0
		[Register("getOrNull-PpDY95g", "([BI)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte GetOrNull(byte[] _this_getOrNull_u2dPpDY95g, int index)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_getOrNull_u2dPpDY95g);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("getOrNull-PpDY95g.([BI)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_getOrNull_u2dPpDY95g != null)
				{
					JNIEnv.CopyArray(intPtr, _this_getOrNull_u2dPpDY95g);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_getOrNull_u2dPpDY95g);
			}
			return @object;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000B1D40 File Offset: 0x000AFF40
		[Register("getOrNull-nggk6HY", "([SI)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort GetOrNull(short[] _this_getOrNull_u2dnggk6HY, int index)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_getOrNull_u2dnggk6HY);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("getOrNull-nggk6HY.([SI)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_getOrNull_u2dnggk6HY != null)
				{
					JNIEnv.CopyArray(intPtr, _this_getOrNull_u2dnggk6HY);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_getOrNull_u2dnggk6HY);
			}
			return @object;
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000B1DD0 File Offset: 0x000AFFD0
		[Register("getOrNull-qFRl0hI", "([II)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt GetOrNull(int[] _this_getOrNull_u2dqFRl0hI, int index)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_getOrNull_u2dqFRl0hI);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("getOrNull-qFRl0hI.([II)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_getOrNull_u2dqFRl0hI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_getOrNull_u2dqFRl0hI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_getOrNull_u2dqFRl0hI);
			}
			return @object;
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000B1E60 File Offset: 0x000B0060
		[Register("getOrNull-r7IrZao", "([JI)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong GetOrNull(long[] _this_getOrNull_u2dr7IrZao, int index)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_getOrNull_u2dr7IrZao);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("getOrNull-r7IrZao.([JI)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_getOrNull_u2dr7IrZao != null)
				{
					JNIEnv.CopyArray(intPtr, _this_getOrNull_u2dr7IrZao);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_getOrNull_u2dr7IrZao);
			}
			return @object;
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000B1EF0 File Offset: 0x000B00F0
		[Register("lastOrNull--ajY-9A", "([I)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt LastOrNull(int[] _this_lastOrNull_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_lastOrNull_u2d_u2dajY_u2d9A);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("lastOrNull--ajY-9A.([I)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_lastOrNull_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_lastOrNull_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_lastOrNull_u2d_u2dajY_u2d9A);
			}
			return @object;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000B1F6C File Offset: 0x000B016C
		[Register("lastOrNull-GBYM_sE", "([B)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte LastOrNull(byte[] _this_lastOrNull_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_lastOrNull_u2dGBYM_sE);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("lastOrNull-GBYM_sE.([B)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_lastOrNull_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_lastOrNull_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_lastOrNull_u2dGBYM_sE);
			}
			return @object;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000B1FE8 File Offset: 0x000B01E8
		[Register("lastOrNull-QwZRm1k", "([J)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong LastOrNull(long[] _this_lastOrNull_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_lastOrNull_u2dQwZRm1k);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("lastOrNull-QwZRm1k.([J)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_lastOrNull_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_lastOrNull_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_lastOrNull_u2dQwZRm1k);
			}
			return @object;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000B2064 File Offset: 0x000B0264
		[Register("lastOrNull-rL5Bavg", "([S)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort LastOrNull(short[] _this_lastOrNull_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_lastOrNull_u2drL5Bavg);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("lastOrNull-rL5Bavg.([S)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_lastOrNull_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_lastOrNull_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_lastOrNull_u2drL5Bavg);
			}
			return @object;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000B20E0 File Offset: 0x000B02E0
		[Register("maxOrNull--ajY-9A", "([I)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt MaxOrNull(int[] _this_maxOrNull_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxOrNull_u2d_u2dajY_u2d9A);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("maxOrNull--ajY-9A.([I)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_maxOrNull_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxOrNull_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxOrNull_u2d_u2dajY_u2d9A);
			}
			return @object;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000B215C File Offset: 0x000B035C
		[Register("maxOrNull-GBYM_sE", "([B)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte MaxOrNull(byte[] _this_maxOrNull_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxOrNull_u2dGBYM_sE);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("maxOrNull-GBYM_sE.([B)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_maxOrNull_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxOrNull_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxOrNull_u2dGBYM_sE);
			}
			return @object;
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x000B21D8 File Offset: 0x000B03D8
		[Register("maxOrNull-QwZRm1k", "([J)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong MaxOrNull(long[] _this_maxOrNull_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxOrNull_u2dQwZRm1k);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("maxOrNull-QwZRm1k.([J)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_maxOrNull_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxOrNull_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxOrNull_u2dQwZRm1k);
			}
			return @object;
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000B2254 File Offset: 0x000B0454
		[Register("maxOrNull-rL5Bavg", "([S)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort MaxOrNull(short[] _this_maxOrNull_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxOrNull_u2drL5Bavg);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("maxOrNull-rL5Bavg.([S)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_maxOrNull_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxOrNull_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxOrNull_u2drL5Bavg);
			}
			return @object;
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x000B22D0 File Offset: 0x000B04D0
		[Register("maxOrThrow-U", "([B)B", "")]
		public unsafe static sbyte MaxOrThrow_U(byte[] _this_max_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_max_u2dGBYM_sE);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeSByteMethod("maxOrThrow-U.([B)B", ptr);
			}
			finally
			{
				if (_this_max_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_max_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_max_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x000B233C File Offset: 0x000B053C
		[Register("maxOrThrow-U", "([I)I", "")]
		public unsafe static int MaxOrThrow_U(int[] _this_max_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_max_u2d_u2dajY_u2d9A);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("maxOrThrow-U.([I)I", ptr);
			}
			finally
			{
				if (_this_max_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_max_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_max_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x000B23A8 File Offset: 0x000B05A8
		[Register("maxOrThrow-U", "([J)J", "")]
		public unsafe static long MaxOrThrow_U(long[] _this_max_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_max_u2dQwZRm1k);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt64Method("maxOrThrow-U.([J)J", ptr);
			}
			finally
			{
				if (_this_max_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_max_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_max_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000B2414 File Offset: 0x000B0614
		[Register("maxOrThrow-U", "([S)S", "")]
		public unsafe static short MaxOrThrow_U(short[] _this_max_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_max_u2drL5Bavg);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt16Method("maxOrThrow-U.([S)S", ptr);
			}
			finally
			{
				if (_this_max_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_max_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_max_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x000B2480 File Offset: 0x000B0680
		[Register("maxWithOrNull-XMRcp5o", "([BLjava/util/Comparator;)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte MaxWithOrNull(byte[] _this_maxWithOrNull_u2dXMRcp5o, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxWithOrNull_u2dXMRcp5o);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("maxWithOrNull-XMRcp5o.([BLjava/util/Comparator;)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_maxWithOrNull_u2dXMRcp5o != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxWithOrNull_u2dXMRcp5o);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxWithOrNull_u2dXMRcp5o);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x000B2528 File Offset: 0x000B0728
		[Register("maxWithOrNull-YmdZ_VM", "([ILjava/util/Comparator;)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt MaxWithOrNull(int[] _this_maxWithOrNull_u2dYmdZ_VM, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxWithOrNull_u2dYmdZ_VM);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("maxWithOrNull-YmdZ_VM.([ILjava/util/Comparator;)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_maxWithOrNull_u2dYmdZ_VM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxWithOrNull_u2dYmdZ_VM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxWithOrNull_u2dYmdZ_VM);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x000B25D0 File Offset: 0x000B07D0
		[Register("maxWithOrNull-eOHTfZs", "([SLjava/util/Comparator;)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort MaxWithOrNull(short[] _this_maxWithOrNull_u2deOHTfZs, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxWithOrNull_u2deOHTfZs);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("maxWithOrNull-eOHTfZs.([SLjava/util/Comparator;)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_maxWithOrNull_u2deOHTfZs != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxWithOrNull_u2deOHTfZs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxWithOrNull_u2deOHTfZs);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000B2678 File Offset: 0x000B0878
		[Register("maxWithOrNull-zrEWJaI", "([JLjava/util/Comparator;)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong MaxWithOrNull(long[] _this_maxWithOrNull_u2dzrEWJaI, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxWithOrNull_u2dzrEWJaI);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("maxWithOrNull-zrEWJaI.([JLjava/util/Comparator;)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_maxWithOrNull_u2dzrEWJaI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxWithOrNull_u2dzrEWJaI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxWithOrNull_u2dzrEWJaI);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x000B2720 File Offset: 0x000B0920
		[Register("maxWithOrThrow-U", "([BLjava/util/Comparator;)B", "")]
		public unsafe static sbyte MaxWithOrThrow_U(byte[] _this_maxWith_u2dXMRcp5o, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxWith_u2dXMRcp5o);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = UArraysKt._members.StaticMethods.InvokeSByteMethod("maxWithOrThrow-U.([BLjava/util/Comparator;)B", ptr);
			}
			finally
			{
				if (_this_maxWith_u2dXMRcp5o != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxWith_u2dXMRcp5o);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxWith_u2dXMRcp5o);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x000B27BC File Offset: 0x000B09BC
		[Register("maxWithOrThrow-U", "([ILjava/util/Comparator;)I", "")]
		public unsafe static int MaxWithOrThrow_U(int[] _this_maxWith_u2dYmdZ_VM, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxWith_u2dYmdZ_VM);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("maxWithOrThrow-U.([ILjava/util/Comparator;)I", ptr);
			}
			finally
			{
				if (_this_maxWith_u2dYmdZ_VM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxWith_u2dYmdZ_VM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxWith_u2dYmdZ_VM);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x000B2858 File Offset: 0x000B0A58
		[Register("maxWithOrThrow-U", "([JLjava/util/Comparator;)J", "")]
		public unsafe static long MaxWithOrThrow_U(long[] _this_maxWith_u2dzrEWJaI, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxWith_u2dzrEWJaI);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt64Method("maxWithOrThrow-U.([JLjava/util/Comparator;)J", ptr);
			}
			finally
			{
				if (_this_maxWith_u2dzrEWJaI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxWith_u2dzrEWJaI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxWith_u2dzrEWJaI);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x000B28F4 File Offset: 0x000B0AF4
		[Register("maxWithOrThrow-U", "([SLjava/util/Comparator;)S", "")]
		public unsafe static short MaxWithOrThrow_U(short[] _this_maxWith_u2deOHTfZs, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_maxWith_u2deOHTfZs);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt16Method("maxWithOrThrow-U.([SLjava/util/Comparator;)S", ptr);
			}
			finally
			{
				if (_this_maxWith_u2deOHTfZs != null)
				{
					JNIEnv.CopyArray(intPtr, _this_maxWith_u2deOHTfZs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_maxWith_u2deOHTfZs);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000B2990 File Offset: 0x000B0B90
		[Register("minOrNull--ajY-9A", "([I)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt MinOrNull(int[] _this_minOrNull_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minOrNull_u2d_u2dajY_u2d9A);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("minOrNull--ajY-9A.([I)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_minOrNull_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minOrNull_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minOrNull_u2d_u2dajY_u2d9A);
			}
			return @object;
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000B2A0C File Offset: 0x000B0C0C
		[Register("minOrNull-GBYM_sE", "([B)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte MinOrNull(byte[] _this_minOrNull_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minOrNull_u2dGBYM_sE);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("minOrNull-GBYM_sE.([B)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_minOrNull_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minOrNull_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minOrNull_u2dGBYM_sE);
			}
			return @object;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000B2A88 File Offset: 0x000B0C88
		[Register("minOrNull-QwZRm1k", "([J)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong MinOrNull(long[] _this_minOrNull_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minOrNull_u2dQwZRm1k);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("minOrNull-QwZRm1k.([J)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_minOrNull_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minOrNull_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minOrNull_u2dQwZRm1k);
			}
			return @object;
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000B2B04 File Offset: 0x000B0D04
		[Register("minOrNull-rL5Bavg", "([S)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort MinOrNull(short[] _this_minOrNull_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minOrNull_u2drL5Bavg);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("minOrNull-rL5Bavg.([S)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_minOrNull_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minOrNull_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minOrNull_u2drL5Bavg);
			}
			return @object;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000B2B80 File Offset: 0x000B0D80
		[Register("minOrThrow-U", "([B)B", "")]
		public unsafe static sbyte MinOrThrow_U(byte[] _this_min_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_min_u2dGBYM_sE);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeSByteMethod("minOrThrow-U.([B)B", ptr);
			}
			finally
			{
				if (_this_min_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_min_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_min_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000B2BEC File Offset: 0x000B0DEC
		[Register("minOrThrow-U", "([I)I", "")]
		public unsafe static int MinOrThrow_U(int[] _this_min_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_min_u2d_u2dajY_u2d9A);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("minOrThrow-U.([I)I", ptr);
			}
			finally
			{
				if (_this_min_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_min_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_min_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x000B2C58 File Offset: 0x000B0E58
		[Register("minOrThrow-U", "([J)J", "")]
		public unsafe static long MinOrThrow_U(long[] _this_min_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_min_u2dQwZRm1k);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt64Method("minOrThrow-U.([J)J", ptr);
			}
			finally
			{
				if (_this_min_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_min_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_min_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x000B2CC4 File Offset: 0x000B0EC4
		[Register("minOrThrow-U", "([S)S", "")]
		public unsafe static short MinOrThrow_U(short[] _this_min_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_min_u2drL5Bavg);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt16Method("minOrThrow-U.([S)S", ptr);
			}
			finally
			{
				if (_this_min_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_min_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_min_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x000B2D30 File Offset: 0x000B0F30
		[Register("minWithOrNull-XMRcp5o", "([BLjava/util/Comparator;)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte MinWithOrNull(byte[] _this_minWithOrNull_u2dXMRcp5o, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minWithOrNull_u2dXMRcp5o);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("minWithOrNull-XMRcp5o.([BLjava/util/Comparator;)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_minWithOrNull_u2dXMRcp5o != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minWithOrNull_u2dXMRcp5o);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minWithOrNull_u2dXMRcp5o);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x000B2DD8 File Offset: 0x000B0FD8
		[Register("minWithOrNull-YmdZ_VM", "([ILjava/util/Comparator;)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt MinWithOrNull(int[] _this_minWithOrNull_u2dYmdZ_VM, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minWithOrNull_u2dYmdZ_VM);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("minWithOrNull-YmdZ_VM.([ILjava/util/Comparator;)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_minWithOrNull_u2dYmdZ_VM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minWithOrNull_u2dYmdZ_VM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minWithOrNull_u2dYmdZ_VM);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000B2E80 File Offset: 0x000B1080
		[Register("minWithOrNull-eOHTfZs", "([SLjava/util/Comparator;)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort MinWithOrNull(short[] _this_minWithOrNull_u2deOHTfZs, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minWithOrNull_u2deOHTfZs);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("minWithOrNull-eOHTfZs.([SLjava/util/Comparator;)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_minWithOrNull_u2deOHTfZs != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minWithOrNull_u2deOHTfZs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minWithOrNull_u2deOHTfZs);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000B2F28 File Offset: 0x000B1128
		[Register("minWithOrNull-zrEWJaI", "([JLjava/util/Comparator;)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong MinWithOrNull(long[] _this_minWithOrNull_u2dzrEWJaI, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minWithOrNull_u2dzrEWJaI);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("minWithOrNull-zrEWJaI.([JLjava/util/Comparator;)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_minWithOrNull_u2dzrEWJaI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minWithOrNull_u2dzrEWJaI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minWithOrNull_u2dzrEWJaI);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000B2FD0 File Offset: 0x000B11D0
		[Register("minWithOrThrow-U", "([BLjava/util/Comparator;)B", "")]
		public unsafe static sbyte MinWithOrThrow_U(byte[] _this_minWith_u2dXMRcp5o, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minWith_u2dXMRcp5o);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = UArraysKt._members.StaticMethods.InvokeSByteMethod("minWithOrThrow-U.([BLjava/util/Comparator;)B", ptr);
			}
			finally
			{
				if (_this_minWith_u2dXMRcp5o != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minWith_u2dXMRcp5o);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minWith_u2dXMRcp5o);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000B306C File Offset: 0x000B126C
		[Register("minWithOrThrow-U", "([ILjava/util/Comparator;)I", "")]
		public unsafe static int MinWithOrThrow_U(int[] _this_minWith_u2dYmdZ_VM, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minWith_u2dYmdZ_VM);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("minWithOrThrow-U.([ILjava/util/Comparator;)I", ptr);
			}
			finally
			{
				if (_this_minWith_u2dYmdZ_VM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minWith_u2dYmdZ_VM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minWith_u2dYmdZ_VM);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000B3108 File Offset: 0x000B1308
		[Register("minWithOrThrow-U", "([JLjava/util/Comparator;)J", "")]
		public unsafe static long MinWithOrThrow_U(long[] _this_minWith_u2dzrEWJaI, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minWith_u2dzrEWJaI);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt64Method("minWithOrThrow-U.([JLjava/util/Comparator;)J", ptr);
			}
			finally
			{
				if (_this_minWith_u2dzrEWJaI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minWith_u2dzrEWJaI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minWith_u2dzrEWJaI);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000B31A4 File Offset: 0x000B13A4
		[Register("minWithOrThrow-U", "([SLjava/util/Comparator;)S", "")]
		public unsafe static short MinWithOrThrow_U(short[] _this_minWith_u2deOHTfZs, IComparator comparator)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_minWith_u2deOHTfZs);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt16Method("minWithOrThrow-U.([SLjava/util/Comparator;)S", ptr);
			}
			finally
			{
				if (_this_minWith_u2deOHTfZs != null)
				{
					JNIEnv.CopyArray(intPtr, _this_minWith_u2deOHTfZs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minWith_u2deOHTfZs);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x000B3240 File Offset: 0x000B1440
		[Register("plus-CFIt9YE", "([ILjava/util/Collection;)[I", "")]
		public unsafe static int[] Plus(int[] _this_plus_u2dCFIt9YE, ICollection<UInt> elements)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_plus_u2dCFIt9YE);
			IntPtr intPtr2 = JavaCollection<UInt>.ToLocalJniHandle(elements);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (int[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("plus-CFIt9YE.([ILjava/util/Collection;)[I", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				if (_this_plus_u2dCFIt9YE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_plus_u2dCFIt9YE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_plus_u2dCFIt9YE);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000B32F4 File Offset: 0x000B14F4
		[Register("plus-kzHmqpY", "([JLjava/util/Collection;)[J", "")]
		public unsafe static long[] Plus(long[] _this_plus_u2dkzHmqpY, ICollection<ULong> elements)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_plus_u2dkzHmqpY);
			IntPtr intPtr2 = JavaCollection<ULong>.ToLocalJniHandle(elements);
			long[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (long[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("plus-kzHmqpY.([JLjava/util/Collection;)[J", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}
			finally
			{
				if (_this_plus_u2dkzHmqpY != null)
				{
					JNIEnv.CopyArray(intPtr, _this_plus_u2dkzHmqpY);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_plus_u2dkzHmqpY);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000B33A8 File Offset: 0x000B15A8
		[Register("plus-ojwP5H8", "([SLjava/util/Collection;)[S", "")]
		public unsafe static short[] Plus(short[] _this_plus_u2dojwP5H8, ICollection<UShort> elements)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_plus_u2dojwP5H8);
			IntPtr intPtr2 = JavaCollection<UShort>.ToLocalJniHandle(elements);
			short[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (short[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("plus-ojwP5H8.([SLjava/util/Collection;)[S", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
			}
			finally
			{
				if (_this_plus_u2dojwP5H8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_plus_u2dojwP5H8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_plus_u2dojwP5H8);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000B345C File Offset: 0x000B165C
		[Register("plus-xo_DsdI", "([BLjava/util/Collection;)[B", "")]
		public unsafe static byte[] Plus(byte[] _this_plus_u2dxo_DsdI, ICollection<UByte> elements)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_plus_u2dxo_DsdI);
			IntPtr intPtr2 = JavaCollection<UByte>.ToLocalJniHandle(elements);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (byte[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("plus-xo_DsdI.([BLjava/util/Collection;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (_this_plus_u2dxo_DsdI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_plus_u2dxo_DsdI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_plus_u2dxo_DsdI);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000B3510 File Offset: 0x000B1710
		[Register("random-2D5oskM", "([ILkotlin/random/Random;)I", "")]
		public unsafe static int Random(int[] _this_random_u2d2D5oskM, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_random_u2d2D5oskM);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("random-2D5oskM.([ILkotlin/random/Random;)I", ptr);
			}
			finally
			{
				if (_this_random_u2d2D5oskM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_random_u2d2D5oskM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_random_u2d2D5oskM);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000B35A4 File Offset: 0x000B17A4
		[Register("random-JzugnMA", "([JLkotlin/random/Random;)J", "")]
		public unsafe static long Random(long[] _this_random_u2dJzugnMA, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_random_u2dJzugnMA);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt64Method("random-JzugnMA.([JLkotlin/random/Random;)J", ptr);
			}
			finally
			{
				if (_this_random_u2dJzugnMA != null)
				{
					JNIEnv.CopyArray(intPtr, _this_random_u2dJzugnMA);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_random_u2dJzugnMA);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000B3638 File Offset: 0x000B1838
		[Register("random-oSF2wD8", "([BLkotlin/random/Random;)B", "")]
		public unsafe static sbyte Random(byte[] _this_random_u2doSF2wD8, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_random_u2doSF2wD8);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = UArraysKt._members.StaticMethods.InvokeSByteMethod("random-oSF2wD8.([BLkotlin/random/Random;)B", ptr);
			}
			finally
			{
				if (_this_random_u2doSF2wD8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_random_u2doSF2wD8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_random_u2doSF2wD8);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000B36CC File Offset: 0x000B18CC
		[Register("random-s5X_as8", "([SLkotlin/random/Random;)S", "")]
		public unsafe static short Random(short[] _this_random_u2ds5X_as8, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_random_u2ds5X_as8);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = UArraysKt._members.StaticMethods.InvokeInt16Method("random-s5X_as8.([SLkotlin/random/Random;)S", ptr);
			}
			finally
			{
				if (_this_random_u2ds5X_as8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_random_u2ds5X_as8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_random_u2ds5X_as8);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000B3760 File Offset: 0x000B1960
		[Register("randomOrNull-2D5oskM", "([ILkotlin/random/Random;)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt RandomOrNull(int[] _this_randomOrNull_u2d2D5oskM, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_randomOrNull_u2d2D5oskM);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("randomOrNull-2D5oskM.([ILkotlin/random/Random;)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_randomOrNull_u2d2D5oskM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_randomOrNull_u2d2D5oskM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_randomOrNull_u2d2D5oskM);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000B3804 File Offset: 0x000B1A04
		[Register("randomOrNull-JzugnMA", "([JLkotlin/random/Random;)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong RandomOrNull(long[] _this_randomOrNull_u2dJzugnMA, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_randomOrNull_u2dJzugnMA);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("randomOrNull-JzugnMA.([JLkotlin/random/Random;)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_randomOrNull_u2dJzugnMA != null)
				{
					JNIEnv.CopyArray(intPtr, _this_randomOrNull_u2dJzugnMA);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_randomOrNull_u2dJzugnMA);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000B38A8 File Offset: 0x000B1AA8
		[Register("randomOrNull-oSF2wD8", "([BLkotlin/random/Random;)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte RandomOrNull(byte[] _this_randomOrNull_u2doSF2wD8, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_randomOrNull_u2doSF2wD8);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("randomOrNull-oSF2wD8.([BLkotlin/random/Random;)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_randomOrNull_u2doSF2wD8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_randomOrNull_u2doSF2wD8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_randomOrNull_u2doSF2wD8);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000B394C File Offset: 0x000B1B4C
		[Register("randomOrNull-s5X_as8", "([SLkotlin/random/Random;)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort RandomOrNull(short[] _this_randomOrNull_u2ds5X_as8, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_randomOrNull_u2ds5X_as8);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("randomOrNull-s5X_as8.([SLkotlin/random/Random;)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_randomOrNull_u2ds5X_as8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_randomOrNull_u2ds5X_as8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_randomOrNull_u2ds5X_as8);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000B39F0 File Offset: 0x000B1BF0
		[Register("reversed--ajY-9A", "([I)Ljava/util/List;", "")]
		public unsafe static IList<UInt> Reversed(int[] _this_reversed_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_reversed_u2d_u2dajY_u2d9A);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("reversed--ajY-9A.([I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_reversed_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_reversed_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_reversed_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000B3A6C File Offset: 0x000B1C6C
		[Register("reversed-GBYM_sE", "([B)Ljava/util/List;", "")]
		public unsafe static IList<UByte> Reversed(byte[] _this_reversed_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_reversed_u2dGBYM_sE);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("reversed-GBYM_sE.([B)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_reversed_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_reversed_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_reversed_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000B3AE8 File Offset: 0x000B1CE8
		[Register("reversed-QwZRm1k", "([J)Ljava/util/List;", "")]
		public unsafe static IList<ULong> Reversed(long[] _this_reversed_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_reversed_u2dQwZRm1k);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("reversed-QwZRm1k.([J)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_reversed_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_reversed_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_reversed_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000B3B64 File Offset: 0x000B1D64
		[Register("reversed-rL5Bavg", "([S)Ljava/util/List;", "")]
		public unsafe static IList<UShort> Reversed(short[] _this_reversed_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_reversed_u2drL5Bavg);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("reversed-rL5Bavg.([S)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_reversed_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_reversed_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_reversed_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000B3BE0 File Offset: 0x000B1DE0
		[Register("shuffle--ajY-9A", "([I)V", "")]
		public unsafe static void Shuffle(int[] _this_shuffle_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_shuffle_u2d_u2dajY_u2d9A);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("shuffle--ajY-9A.([I)V", ptr);
			}
			finally
			{
				if (_this_shuffle_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_shuffle_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_shuffle_u2d_u2dajY_u2d9A);
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x000B3C4C File Offset: 0x000B1E4C
		[Register("shuffle-2D5oskM", "([ILkotlin/random/Random;)V", "")]
		public unsafe static void Shuffle(int[] _this_shuffle_u2d2D5oskM, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_shuffle_u2d2D5oskM);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("shuffle-2D5oskM.([ILkotlin/random/Random;)V", ptr);
			}
			finally
			{
				if (_this_shuffle_u2d2D5oskM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_shuffle_u2d2D5oskM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_shuffle_u2d2D5oskM);
				GC.KeepAlive(random);
			}
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000B3CE0 File Offset: 0x000B1EE0
		[Register("shuffle-GBYM_sE", "([B)V", "")]
		public unsafe static void Shuffle(byte[] _this_shuffle_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_shuffle_u2dGBYM_sE);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("shuffle-GBYM_sE.([B)V", ptr);
			}
			finally
			{
				if (_this_shuffle_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_shuffle_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_shuffle_u2dGBYM_sE);
			}
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000B3D4C File Offset: 0x000B1F4C
		[Register("shuffle-JzugnMA", "([JLkotlin/random/Random;)V", "")]
		public unsafe static void Shuffle(long[] _this_shuffle_u2dJzugnMA, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_shuffle_u2dJzugnMA);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("shuffle-JzugnMA.([JLkotlin/random/Random;)V", ptr);
			}
			finally
			{
				if (_this_shuffle_u2dJzugnMA != null)
				{
					JNIEnv.CopyArray(intPtr, _this_shuffle_u2dJzugnMA);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_shuffle_u2dJzugnMA);
				GC.KeepAlive(random);
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000B3DE0 File Offset: 0x000B1FE0
		[Register("shuffle-QwZRm1k", "([J)V", "")]
		public unsafe static void Shuffle(long[] _this_shuffle_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_shuffle_u2dQwZRm1k);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("shuffle-QwZRm1k.([J)V", ptr);
			}
			finally
			{
				if (_this_shuffle_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_shuffle_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_shuffle_u2dQwZRm1k);
			}
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000B3E4C File Offset: 0x000B204C
		[Register("shuffle-oSF2wD8", "([BLkotlin/random/Random;)V", "")]
		public unsafe static void Shuffle(byte[] _this_shuffle_u2doSF2wD8, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_shuffle_u2doSF2wD8);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("shuffle-oSF2wD8.([BLkotlin/random/Random;)V", ptr);
			}
			finally
			{
				if (_this_shuffle_u2doSF2wD8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_shuffle_u2doSF2wD8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_shuffle_u2doSF2wD8);
				GC.KeepAlive(random);
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000B3EE0 File Offset: 0x000B20E0
		[Register("shuffle-rL5Bavg", "([S)V", "")]
		public unsafe static void Shuffle(short[] _this_shuffle_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_shuffle_u2drL5Bavg);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("shuffle-rL5Bavg.([S)V", ptr);
			}
			finally
			{
				if (_this_shuffle_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_shuffle_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_shuffle_u2drL5Bavg);
			}
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000B3F4C File Offset: 0x000B214C
		[Register("shuffle-s5X_as8", "([SLkotlin/random/Random;)V", "")]
		public unsafe static void Shuffle(short[] _this_shuffle_u2ds5X_as8, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_shuffle_u2ds5X_as8);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("shuffle-s5X_as8.([SLkotlin/random/Random;)V", ptr);
			}
			finally
			{
				if (_this_shuffle_u2ds5X_as8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_shuffle_u2ds5X_as8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_shuffle_u2ds5X_as8);
				GC.KeepAlive(random);
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000B3FE0 File Offset: 0x000B21E0
		[Register("singleOrNull--ajY-9A", "([I)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt SingleOrNull(int[] _this_singleOrNull_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_singleOrNull_u2d_u2dajY_u2d9A);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UInt>(UArraysKt._members.StaticMethods.InvokeObjectMethod("singleOrNull--ajY-9A.([I)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_singleOrNull_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_singleOrNull_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_singleOrNull_u2d_u2dajY_u2d9A);
			}
			return @object;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000B405C File Offset: 0x000B225C
		[Register("singleOrNull-GBYM_sE", "([B)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte SingleOrNull(byte[] _this_singleOrNull_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_singleOrNull_u2dGBYM_sE);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UByte>(UArraysKt._members.StaticMethods.InvokeObjectMethod("singleOrNull-GBYM_sE.([B)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_singleOrNull_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_singleOrNull_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_singleOrNull_u2dGBYM_sE);
			}
			return @object;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000B40D8 File Offset: 0x000B22D8
		[Register("singleOrNull-QwZRm1k", "([J)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong SingleOrNull(long[] _this_singleOrNull_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_singleOrNull_u2dQwZRm1k);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ULong>(UArraysKt._members.StaticMethods.InvokeObjectMethod("singleOrNull-QwZRm1k.([J)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_singleOrNull_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_singleOrNull_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_singleOrNull_u2dQwZRm1k);
			}
			return @object;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000B4154 File Offset: 0x000B2354
		[Register("singleOrNull-rL5Bavg", "([S)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort SingleOrNull(short[] _this_singleOrNull_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_singleOrNull_u2drL5Bavg);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UShort>(UArraysKt._members.StaticMethods.InvokeObjectMethod("singleOrNull-rL5Bavg.([S)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_singleOrNull_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_singleOrNull_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_singleOrNull_u2drL5Bavg);
			}
			return @object;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000B41D0 File Offset: 0x000B23D0
		[Register("slice-F7u83W8", "([JLjava/lang/Iterable;)Ljava/util/List;", "")]
		public unsafe static IList<ULong> Slice(long[] _this_slice_u2dF7u83W8, IIterable indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_slice_u2dF7u83W8);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : ((Java.Lang.Object)indices).Handle);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("slice-F7u83W8.([JLjava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_slice_u2dF7u83W8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_slice_u2dF7u83W8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_slice_u2dF7u83W8);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000B4278 File Offset: 0x000B2478
		[Register("slice-HwE9HBo", "([ILjava/lang/Iterable;)Ljava/util/List;", "")]
		public unsafe static IList<UInt> Slice(int[] _this_slice_u2dHwE9HBo, IIterable indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_slice_u2dHwE9HBo);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : ((Java.Lang.Object)indices).Handle);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("slice-HwE9HBo.([ILjava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_slice_u2dHwE9HBo != null)
				{
					JNIEnv.CopyArray(intPtr, _this_slice_u2dHwE9HBo);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_slice_u2dHwE9HBo);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000B4320 File Offset: 0x000B2520
		[Register("slice-JGPC0-M", "([SLjava/lang/Iterable;)Ljava/util/List;", "")]
		public unsafe static IList<UShort> Slice(short[] _this_slice_u2dJGPC0_u2dM, IIterable indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_slice_u2dJGPC0_u2dM);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : ((Java.Lang.Object)indices).Handle);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("slice-JGPC0-M.([SLjava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_slice_u2dJGPC0_u2dM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_slice_u2dJGPC0_u2dM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_slice_u2dJGPC0_u2dM);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000B43C8 File Offset: 0x000B25C8
		[Register("slice-JQknh5Q", "([BLjava/lang/Iterable;)Ljava/util/List;", "")]
		public unsafe static IList<UByte> Slice(byte[] _this_slice_u2dJQknh5Q, IIterable indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_slice_u2dJQknh5Q);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : ((Java.Lang.Object)indices).Handle);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("slice-JQknh5Q.([BLjava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_slice_u2dJQknh5Q != null)
				{
					JNIEnv.CopyArray(intPtr, _this_slice_u2dJQknh5Q);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_slice_u2dJQknh5Q);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000B4470 File Offset: 0x000B2670
		[Register("slice-Q6IL4kU", "([SLkotlin/ranges/IntRange;)Ljava/util/List;", "")]
		public unsafe static IList<UShort> Slice(short[] _this_slice_u2dQ6IL4kU, IntRange indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_slice_u2dQ6IL4kU);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("slice-Q6IL4kU.([SLkotlin/ranges/IntRange;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_slice_u2dQ6IL4kU != null)
				{
					JNIEnv.CopyArray(intPtr, _this_slice_u2dQ6IL4kU);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_slice_u2dQ6IL4kU);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000B4514 File Offset: 0x000B2714
		[Register("slice-ZRhS8yI", "([JLkotlin/ranges/IntRange;)Ljava/util/List;", "")]
		public unsafe static IList<ULong> Slice(long[] _this_slice_u2dZRhS8yI, IntRange indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_slice_u2dZRhS8yI);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("slice-ZRhS8yI.([JLkotlin/ranges/IntRange;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_slice_u2dZRhS8yI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_slice_u2dZRhS8yI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_slice_u2dZRhS8yI);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x000B45B8 File Offset: 0x000B27B8
		[Register("slice-c0bezYM", "([BLkotlin/ranges/IntRange;)Ljava/util/List;", "")]
		public unsafe static IList<UByte> Slice(byte[] _this_slice_u2dc0bezYM, IntRange indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_slice_u2dc0bezYM);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("slice-c0bezYM.([BLkotlin/ranges/IntRange;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_slice_u2dc0bezYM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_slice_u2dc0bezYM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_slice_u2dc0bezYM);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000B465C File Offset: 0x000B285C
		[Register("slice-tAntMlw", "([ILkotlin/ranges/IntRange;)Ljava/util/List;", "")]
		public unsafe static IList<UInt> Slice(int[] _this_slice_u2dtAntMlw, IntRange indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_slice_u2dtAntMlw);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("slice-tAntMlw.([ILkotlin/ranges/IntRange;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_slice_u2dtAntMlw != null)
				{
					JNIEnv.CopyArray(intPtr, _this_slice_u2dtAntMlw);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_slice_u2dtAntMlw);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000B4700 File Offset: 0x000B2900
		[Register("sliceArray-CFIt9YE", "([ILjava/util/Collection;)[I", "")]
		public unsafe static int[] SliceArray(int[] _this_sliceArray_u2dCFIt9YE, ICollection<Integer> indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sliceArray_u2dCFIt9YE);
			IntPtr intPtr2 = JavaCollection<Integer>.ToLocalJniHandle(indices);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (int[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sliceArray-CFIt9YE.([ILjava/util/Collection;)[I", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				if (_this_sliceArray_u2dCFIt9YE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sliceArray_u2dCFIt9YE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_sliceArray_u2dCFIt9YE);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000B47B4 File Offset: 0x000B29B4
		[Register("sliceArray-Q6IL4kU", "([SLkotlin/ranges/IntRange;)[S", "")]
		public unsafe static short[] SliceArray(short[] _this_sliceArray_u2dQ6IL4kU, IntRange indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sliceArray_u2dQ6IL4kU);
			short[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = (short[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sliceArray-Q6IL4kU.([SLkotlin/ranges/IntRange;)[S", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
			}
			finally
			{
				if (_this_sliceArray_u2dQ6IL4kU != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sliceArray_u2dQ6IL4kU);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sliceArray_u2dQ6IL4kU);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000B4868 File Offset: 0x000B2A68
		[Register("sliceArray-ZRhS8yI", "([JLkotlin/ranges/IntRange;)[J", "")]
		public unsafe static long[] SliceArray(long[] _this_sliceArray_u2dZRhS8yI, IntRange indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sliceArray_u2dZRhS8yI);
			long[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = (long[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sliceArray-ZRhS8yI.([JLkotlin/ranges/IntRange;)[J", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}
			finally
			{
				if (_this_sliceArray_u2dZRhS8yI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sliceArray_u2dZRhS8yI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sliceArray_u2dZRhS8yI);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000B491C File Offset: 0x000B2B1C
		[Register("sliceArray-c0bezYM", "([BLkotlin/ranges/IntRange;)[B", "")]
		public unsafe static byte[] SliceArray(byte[] _this_sliceArray_u2dc0bezYM, IntRange indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sliceArray_u2dc0bezYM);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = (byte[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sliceArray-c0bezYM.([BLkotlin/ranges/IntRange;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (_this_sliceArray_u2dc0bezYM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sliceArray_u2dc0bezYM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sliceArray_u2dc0bezYM);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000B49D0 File Offset: 0x000B2BD0
		[Register("sliceArray-kzHmqpY", "([JLjava/util/Collection;)[J", "")]
		public unsafe static long[] SliceArray(long[] _this_sliceArray_u2dkzHmqpY, ICollection<Integer> indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sliceArray_u2dkzHmqpY);
			IntPtr intPtr2 = JavaCollection<Integer>.ToLocalJniHandle(indices);
			long[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (long[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sliceArray-kzHmqpY.([JLjava/util/Collection;)[J", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}
			finally
			{
				if (_this_sliceArray_u2dkzHmqpY != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sliceArray_u2dkzHmqpY);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_sliceArray_u2dkzHmqpY);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000B4A84 File Offset: 0x000B2C84
		[Register("sliceArray-ojwP5H8", "([SLjava/util/Collection;)[S", "")]
		public unsafe static short[] SliceArray(short[] _this_sliceArray_u2dojwP5H8, ICollection<Integer> indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sliceArray_u2dojwP5H8);
			IntPtr intPtr2 = JavaCollection<Integer>.ToLocalJniHandle(indices);
			short[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (short[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sliceArray-ojwP5H8.([SLjava/util/Collection;)[S", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
			}
			finally
			{
				if (_this_sliceArray_u2dojwP5H8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sliceArray_u2dojwP5H8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_sliceArray_u2dojwP5H8);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000B4B38 File Offset: 0x000B2D38
		[Register("sliceArray-tAntMlw", "([ILkotlin/ranges/IntRange;)[I", "")]
		public unsafe static int[] SliceArray(int[] _this_sliceArray_u2dtAntMlw, IntRange indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sliceArray_u2dtAntMlw);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = (int[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sliceArray-tAntMlw.([ILkotlin/ranges/IntRange;)[I", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				if (_this_sliceArray_u2dtAntMlw != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sliceArray_u2dtAntMlw);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sliceArray_u2dtAntMlw);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000B4BEC File Offset: 0x000B2DEC
		[Register("sliceArray-xo_DsdI", "([BLjava/util/Collection;)[B", "")]
		public unsafe static byte[] SliceArray(byte[] _this_sliceArray_u2dxo_DsdI, ICollection<Integer> indices)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sliceArray_u2dxo_DsdI);
			IntPtr intPtr2 = JavaCollection<Integer>.ToLocalJniHandle(indices);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (byte[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sliceArray-xo_DsdI.([BLjava/util/Collection;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (_this_sliceArray_u2dxo_DsdI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sliceArray_u2dxo_DsdI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_sliceArray_u2dxo_DsdI);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000B4CA0 File Offset: 0x000B2EA0
		[Register("sort--ajY-9A", "([I)V", "")]
		public unsafe static void Sort(int[] _this_sort_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sort_u2d_u2dajY_u2d9A);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sort--ajY-9A.([I)V", ptr);
			}
			finally
			{
				if (_this_sort_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sort_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sort_u2d_u2dajY_u2d9A);
			}
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000B4D0C File Offset: 0x000B2F0C
		[Register("sort--nroSd4", "([JII)V", "")]
		public unsafe static void Sort(long[] _this_sort_u2d_u2dnroSd4, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sort_u2d_u2dnroSd4);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sort--nroSd4.([JII)V", ptr);
			}
			finally
			{
				if (_this_sort_u2d_u2dnroSd4 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sort_u2d_u2dnroSd4);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sort_u2d_u2dnroSd4);
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000B4DA0 File Offset: 0x000B2FA0
		[Register("sort-4UcCI2c", "([BII)V", "")]
		public unsafe static void Sort(byte[] _this_sort_u2d4UcCI2c, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sort_u2d4UcCI2c);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sort-4UcCI2c.([BII)V", ptr);
			}
			finally
			{
				if (_this_sort_u2d4UcCI2c != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sort_u2d4UcCI2c);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sort_u2d4UcCI2c);
			}
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000B4E34 File Offset: 0x000B3034
		[Register("sort-Aa5vz7o", "([SII)V", "")]
		public unsafe static void Sort(short[] _this_sort_u2dAa5vz7o, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sort_u2dAa5vz7o);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sort-Aa5vz7o.([SII)V", ptr);
			}
			finally
			{
				if (_this_sort_u2dAa5vz7o != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sort_u2dAa5vz7o);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sort_u2dAa5vz7o);
			}
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000B4EC8 File Offset: 0x000B30C8
		[Register("sort-GBYM_sE", "([B)V", "")]
		public unsafe static void Sort(byte[] _this_sort_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sort_u2dGBYM_sE);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sort-GBYM_sE.([B)V", ptr);
			}
			finally
			{
				if (_this_sort_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sort_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sort_u2dGBYM_sE);
			}
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000B4F34 File Offset: 0x000B3134
		[Register("sort-QwZRm1k", "([J)V", "")]
		public unsafe static void Sort(long[] _this_sort_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sort_u2dQwZRm1k);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sort-QwZRm1k.([J)V", ptr);
			}
			finally
			{
				if (_this_sort_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sort_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sort_u2dQwZRm1k);
			}
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000B4FA0 File Offset: 0x000B31A0
		[Register("sort-oBK06Vg", "([III)V", "")]
		public unsafe static void Sort(int[] _this_sort_u2doBK06Vg, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sort_u2doBK06Vg);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sort-oBK06Vg.([III)V", ptr);
			}
			finally
			{
				if (_this_sort_u2doBK06Vg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sort_u2doBK06Vg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sort_u2doBK06Vg);
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000B5034 File Offset: 0x000B3234
		[Register("sort-rL5Bavg", "([S)V", "")]
		public unsafe static void Sort(short[] _this_sort_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sort_u2drL5Bavg);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sort-rL5Bavg.([S)V", ptr);
			}
			finally
			{
				if (_this_sort_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sort_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sort_u2drL5Bavg);
			}
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000B50A0 File Offset: 0x000B32A0
		[Register("sortDescending--ajY-9A", "([I)V", "")]
		public unsafe static void SortDescending(int[] _this_sortDescending_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortDescending_u2d_u2dajY_u2d9A);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sortDescending--ajY-9A.([I)V", ptr);
			}
			finally
			{
				if (_this_sortDescending_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortDescending_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortDescending_u2d_u2dajY_u2d9A);
			}
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x000B510C File Offset: 0x000B330C
		[Register("sortDescending--nroSd4", "([JII)V", "")]
		public unsafe static void SortDescending(long[] _this_sortDescending_u2d_u2dnroSd4, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortDescending_u2d_u2dnroSd4);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sortDescending--nroSd4.([JII)V", ptr);
			}
			finally
			{
				if (_this_sortDescending_u2d_u2dnroSd4 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortDescending_u2d_u2dnroSd4);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortDescending_u2d_u2dnroSd4);
			}
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000B51A0 File Offset: 0x000B33A0
		[Register("sortDescending-4UcCI2c", "([BII)V", "")]
		public unsafe static void SortDescending(byte[] _this_sortDescending_u2d4UcCI2c, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortDescending_u2d4UcCI2c);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sortDescending-4UcCI2c.([BII)V", ptr);
			}
			finally
			{
				if (_this_sortDescending_u2d4UcCI2c != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortDescending_u2d4UcCI2c);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortDescending_u2d4UcCI2c);
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000B5234 File Offset: 0x000B3434
		[Register("sortDescending-Aa5vz7o", "([SII)V", "")]
		public unsafe static void SortDescending(short[] _this_sortDescending_u2dAa5vz7o, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortDescending_u2dAa5vz7o);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sortDescending-Aa5vz7o.([SII)V", ptr);
			}
			finally
			{
				if (_this_sortDescending_u2dAa5vz7o != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortDescending_u2dAa5vz7o);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortDescending_u2dAa5vz7o);
			}
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000B52C8 File Offset: 0x000B34C8
		[Register("sortDescending-GBYM_sE", "([B)V", "")]
		public unsafe static void SortDescending(byte[] _this_sortDescending_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortDescending_u2dGBYM_sE);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sortDescending-GBYM_sE.([B)V", ptr);
			}
			finally
			{
				if (_this_sortDescending_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortDescending_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortDescending_u2dGBYM_sE);
			}
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000B5334 File Offset: 0x000B3534
		[Register("sortDescending-QwZRm1k", "([J)V", "")]
		public unsafe static void SortDescending(long[] _this_sortDescending_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortDescending_u2dQwZRm1k);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sortDescending-QwZRm1k.([J)V", ptr);
			}
			finally
			{
				if (_this_sortDescending_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortDescending_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortDescending_u2dQwZRm1k);
			}
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000B53A0 File Offset: 0x000B35A0
		[Register("sortDescending-oBK06Vg", "([III)V", "")]
		public unsafe static void SortDescending(int[] _this_sortDescending_u2doBK06Vg, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortDescending_u2doBK06Vg);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sortDescending-oBK06Vg.([III)V", ptr);
			}
			finally
			{
				if (_this_sortDescending_u2doBK06Vg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortDescending_u2doBK06Vg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortDescending_u2doBK06Vg);
			}
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000B5434 File Offset: 0x000B3634
		[Register("sortDescending-rL5Bavg", "([S)V", "")]
		public unsafe static void SortDescending(short[] _this_sortDescending_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortDescending_u2drL5Bavg);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UArraysKt._members.StaticMethods.InvokeVoidMethod("sortDescending-rL5Bavg.([S)V", ptr);
			}
			finally
			{
				if (_this_sortDescending_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortDescending_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortDescending_u2drL5Bavg);
			}
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000B54A0 File Offset: 0x000B36A0
		[Register("sorted--ajY-9A", "([I)Ljava/util/List;", "")]
		public unsafe static IList<UInt> Sorted(int[] _this_sorted_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sorted_u2d_u2dajY_u2d9A);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("sorted--ajY-9A.([I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_sorted_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sorted_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sorted_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000B551C File Offset: 0x000B371C
		[Register("sorted-GBYM_sE", "([B)Ljava/util/List;", "")]
		public unsafe static IList<UByte> Sorted(byte[] _this_sorted_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sorted_u2dGBYM_sE);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("sorted-GBYM_sE.([B)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_sorted_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sorted_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sorted_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000B5598 File Offset: 0x000B3798
		[Register("sorted-QwZRm1k", "([J)Ljava/util/List;", "")]
		public unsafe static IList<ULong> Sorted(long[] _this_sorted_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sorted_u2dQwZRm1k);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("sorted-QwZRm1k.([J)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_sorted_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sorted_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sorted_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000B5614 File Offset: 0x000B3814
		[Register("sorted-rL5Bavg", "([S)Ljava/util/List;", "")]
		public unsafe static IList<UShort> Sorted(short[] _this_sorted_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sorted_u2drL5Bavg);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("sorted-rL5Bavg.([S)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_sorted_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sorted_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sorted_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000B5690 File Offset: 0x000B3890
		[Register("sortedArray--ajY-9A", "([I)[I", "")]
		public unsafe static int[] SortedArray(int[] _this_sortedArray_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedArray_u2d_u2dajY_u2d9A);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (int[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedArray--ajY-9A.([I)[I", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				if (_this_sortedArray_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedArray_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedArray_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000B571C File Offset: 0x000B391C
		[Register("sortedArray-GBYM_sE", "([B)[B", "")]
		public unsafe static byte[] SortedArray(byte[] _this_sortedArray_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedArray_u2dGBYM_sE);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedArray-GBYM_sE.([B)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (_this_sortedArray_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedArray_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedArray_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000B57A8 File Offset: 0x000B39A8
		[Register("sortedArray-QwZRm1k", "([J)[J", "")]
		public unsafe static long[] SortedArray(long[] _this_sortedArray_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedArray_u2dQwZRm1k);
			long[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (long[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedArray-QwZRm1k.([J)[J", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}
			finally
			{
				if (_this_sortedArray_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedArray_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedArray_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000B5834 File Offset: 0x000B3A34
		[Register("sortedArray-rL5Bavg", "([S)[S", "")]
		public unsafe static short[] SortedArray(short[] _this_sortedArray_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedArray_u2drL5Bavg);
			short[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (short[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedArray-rL5Bavg.([S)[S", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
			}
			finally
			{
				if (_this_sortedArray_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedArray_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedArray_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x000B58C0 File Offset: 0x000B3AC0
		[Register("sortedArrayDescending--ajY-9A", "([I)[I", "")]
		public unsafe static int[] SortedArrayDescending(int[] _this_sortedArrayDescending_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedArrayDescending_u2d_u2dajY_u2d9A);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (int[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedArrayDescending--ajY-9A.([I)[I", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				if (_this_sortedArrayDescending_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedArrayDescending_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedArrayDescending_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x000B594C File Offset: 0x000B3B4C
		[Register("sortedArrayDescending-GBYM_sE", "([B)[B", "")]
		public unsafe static byte[] SortedArrayDescending(byte[] _this_sortedArrayDescending_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedArrayDescending_u2dGBYM_sE);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedArrayDescending-GBYM_sE.([B)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (_this_sortedArrayDescending_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedArrayDescending_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedArrayDescending_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000B59D8 File Offset: 0x000B3BD8
		[Register("sortedArrayDescending-QwZRm1k", "([J)[J", "")]
		public unsafe static long[] SortedArrayDescending(long[] _this_sortedArrayDescending_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedArrayDescending_u2dQwZRm1k);
			long[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (long[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedArrayDescending-QwZRm1k.([J)[J", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}
			finally
			{
				if (_this_sortedArrayDescending_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedArrayDescending_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedArrayDescending_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x000B5A64 File Offset: 0x000B3C64
		[Register("sortedArrayDescending-rL5Bavg", "([S)[S", "")]
		public unsafe static short[] SortedArrayDescending(short[] _this_sortedArrayDescending_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedArrayDescending_u2drL5Bavg);
			short[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (short[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedArrayDescending-rL5Bavg.([S)[S", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
			}
			finally
			{
				if (_this_sortedArrayDescending_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedArrayDescending_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedArrayDescending_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000B5AF0 File Offset: 0x000B3CF0
		[Register("sortedDescending--ajY-9A", "([I)Ljava/util/List;", "")]
		public unsafe static IList<UInt> SortedDescending(int[] _this_sortedDescending_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedDescending_u2d_u2dajY_u2d9A);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedDescending--ajY-9A.([I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_sortedDescending_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedDescending_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedDescending_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x000B5B6C File Offset: 0x000B3D6C
		[Register("sortedDescending-GBYM_sE", "([B)Ljava/util/List;", "")]
		public unsafe static IList<UByte> SortedDescending(byte[] _this_sortedDescending_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedDescending_u2dGBYM_sE);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedDescending-GBYM_sE.([B)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_sortedDescending_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedDescending_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedDescending_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000B5BE8 File Offset: 0x000B3DE8
		[Register("sortedDescending-QwZRm1k", "([J)Ljava/util/List;", "")]
		public unsafe static IList<ULong> SortedDescending(long[] _this_sortedDescending_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedDescending_u2dQwZRm1k);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedDescending-QwZRm1k.([J)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_sortedDescending_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedDescending_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedDescending_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x000B5C64 File Offset: 0x000B3E64
		[Register("sortedDescending-rL5Bavg", "([S)Ljava/util/List;", "")]
		public unsafe static IList<UShort> SortedDescending(short[] _this_sortedDescending_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_sortedDescending_u2drL5Bavg);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("sortedDescending-rL5Bavg.([S)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_sortedDescending_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_sortedDescending_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sortedDescending_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x000B5CE0 File Offset: 0x000B3EE0
		[Register("sumOfUByte", "([Lkotlin/UByte;)I", "")]
		public unsafe static int SumOfUByte(UByte[] _this_sum)
		{
			IntPtr intPtr = JNIEnv.NewArray<UByte>(_this_sum);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("sumOfUByte.([Lkotlin/UByte;)I", ptr);
			}
			finally
			{
				if (_this_sum != null)
				{
					JNIEnv.CopyArray<UByte>(intPtr, _this_sum);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x000B5D4C File Offset: 0x000B3F4C
		[Register("sumOfUInt", "([Lkotlin/UInt;)I", "")]
		public unsafe static int SumOfUInt(UInt[] _this_sum)
		{
			IntPtr intPtr = JNIEnv.NewArray<UInt>(_this_sum);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("sumOfUInt.([Lkotlin/UInt;)I", ptr);
			}
			finally
			{
				if (_this_sum != null)
				{
					JNIEnv.CopyArray<UInt>(intPtr, _this_sum);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000B5DB8 File Offset: 0x000B3FB8
		[Register("sumOfULong", "([Lkotlin/ULong;)J", "")]
		public unsafe static long SumOfULong(ULong[] _this_sum)
		{
			IntPtr intPtr = JNIEnv.NewArray<ULong>(_this_sum);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt64Method("sumOfULong.([Lkotlin/ULong;)J", ptr);
			}
			finally
			{
				if (_this_sum != null)
				{
					JNIEnv.CopyArray<ULong>(intPtr, _this_sum);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000B5E24 File Offset: 0x000B4024
		[Register("sumOfUShort", "([Lkotlin/UShort;)I", "")]
		public unsafe static int SumOfUShort(UShort[] _this_sum)
		{
			IntPtr intPtr = JNIEnv.NewArray<UShort>(_this_sum);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("sumOfUShort.([Lkotlin/UShort;)I", ptr);
			}
			finally
			{
				if (_this_sum != null)
				{
					JNIEnv.CopyArray<UShort>(intPtr, _this_sum);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000B5E90 File Offset: 0x000B4090
		[Register("take-PpDY95g", "([BI)Ljava/util/List;", "")]
		public unsafe static IList<UByte> Take(byte[] _this_take_u2dPpDY95g, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_take_u2dPpDY95g);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("take-PpDY95g.([BI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_take_u2dPpDY95g != null)
				{
					JNIEnv.CopyArray(intPtr, _this_take_u2dPpDY95g);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_take_u2dPpDY95g);
			}
			return result;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000B5F20 File Offset: 0x000B4120
		[Register("take-nggk6HY", "([SI)Ljava/util/List;", "")]
		public unsafe static IList<UShort> Take(short[] _this_take_u2dnggk6HY, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_take_u2dnggk6HY);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("take-nggk6HY.([SI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_take_u2dnggk6HY != null)
				{
					JNIEnv.CopyArray(intPtr, _this_take_u2dnggk6HY);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_take_u2dnggk6HY);
			}
			return result;
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000B5FB0 File Offset: 0x000B41B0
		[Register("take-qFRl0hI", "([II)Ljava/util/List;", "")]
		public unsafe static IList<UInt> Take(int[] _this_take_u2dqFRl0hI, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_take_u2dqFRl0hI);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("take-qFRl0hI.([II)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_take_u2dqFRl0hI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_take_u2dqFRl0hI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_take_u2dqFRl0hI);
			}
			return result;
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000B6040 File Offset: 0x000B4240
		[Register("take-r7IrZao", "([JI)Ljava/util/List;", "")]
		public unsafe static IList<ULong> Take(long[] _this_take_u2dr7IrZao, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_take_u2dr7IrZao);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("take-r7IrZao.([JI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_take_u2dr7IrZao != null)
				{
					JNIEnv.CopyArray(intPtr, _this_take_u2dr7IrZao);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_take_u2dr7IrZao);
			}
			return result;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000B60D0 File Offset: 0x000B42D0
		[Register("takeLast-PpDY95g", "([BI)Ljava/util/List;", "")]
		public unsafe static IList<UByte> TakeLast(byte[] _this_takeLast_u2dPpDY95g, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_takeLast_u2dPpDY95g);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("takeLast-PpDY95g.([BI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_takeLast_u2dPpDY95g != null)
				{
					JNIEnv.CopyArray(intPtr, _this_takeLast_u2dPpDY95g);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_takeLast_u2dPpDY95g);
			}
			return result;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000B6160 File Offset: 0x000B4360
		[Register("takeLast-nggk6HY", "([SI)Ljava/util/List;", "")]
		public unsafe static IList<UShort> TakeLast(short[] _this_takeLast_u2dnggk6HY, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_takeLast_u2dnggk6HY);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("takeLast-nggk6HY.([SI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_takeLast_u2dnggk6HY != null)
				{
					JNIEnv.CopyArray(intPtr, _this_takeLast_u2dnggk6HY);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_takeLast_u2dnggk6HY);
			}
			return result;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000B61F0 File Offset: 0x000B43F0
		[Register("takeLast-qFRl0hI", "([II)Ljava/util/List;", "")]
		public unsafe static IList<UInt> TakeLast(int[] _this_takeLast_u2dqFRl0hI, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_takeLast_u2dqFRl0hI);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("takeLast-qFRl0hI.([II)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_takeLast_u2dqFRl0hI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_takeLast_u2dqFRl0hI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_takeLast_u2dqFRl0hI);
			}
			return result;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000B6280 File Offset: 0x000B4480
		[Register("takeLast-r7IrZao", "([JI)Ljava/util/List;", "")]
		public unsafe static IList<ULong> TakeLast(long[] _this_takeLast_u2dr7IrZao, int n)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_takeLast_u2dr7IrZao);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("takeLast-r7IrZao.([JI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_takeLast_u2dr7IrZao != null)
				{
					JNIEnv.CopyArray(intPtr, _this_takeLast_u2dr7IrZao);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_takeLast_u2dr7IrZao);
			}
			return result;
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000B6310 File Offset: 0x000B4510
		[Register("toTypedArray--ajY-9A", "([I)[Lkotlin/UInt;", "")]
		public unsafe static UInt[] ToTypedArray(int[] _this_toTypedArray_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_toTypedArray_u2d_u2dajY_u2d9A);
			UInt[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (UInt[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("toTypedArray--ajY-9A.([I)[Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(UInt));
			}
			finally
			{
				if (_this_toTypedArray_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_toTypedArray_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toTypedArray_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000B639C File Offset: 0x000B459C
		[Register("toTypedArray-GBYM_sE", "([B)[Lkotlin/UByte;", "")]
		public unsafe static UByte[] ToTypedArray(byte[] _this_toTypedArray_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_toTypedArray_u2dGBYM_sE);
			UByte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (UByte[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("toTypedArray-GBYM_sE.([B)[Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(UByte));
			}
			finally
			{
				if (_this_toTypedArray_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_toTypedArray_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toTypedArray_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000B6428 File Offset: 0x000B4628
		[Register("toTypedArray-QwZRm1k", "([J)[Lkotlin/ULong;", "")]
		public unsafe static ULong[] ToTypedArray(long[] _this_toTypedArray_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_toTypedArray_u2dQwZRm1k);
			ULong[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (ULong[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("toTypedArray-QwZRm1k.([J)[Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(ULong));
			}
			finally
			{
				if (_this_toTypedArray_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_toTypedArray_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toTypedArray_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000B64B4 File Offset: 0x000B46B4
		[Register("toTypedArray-rL5Bavg", "([S)[Lkotlin/UShort;", "")]
		public unsafe static UShort[] ToTypedArray(short[] _this_toTypedArray_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_toTypedArray_u2drL5Bavg);
			UShort[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (UShort[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("toTypedArray-rL5Bavg.([S)[Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(UShort));
			}
			finally
			{
				if (_this_toTypedArray_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_toTypedArray_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toTypedArray_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000B6540 File Offset: 0x000B4740
		[Register("toUByteArray", "([Lkotlin/UByte;)[B", "")]
		public unsafe static byte[] ToUByteArray(UByte[] _this_toUByteArray)
		{
			IntPtr intPtr = JNIEnv.NewArray<UByte>(_this_toUByteArray);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("toUByteArray.([Lkotlin/UByte;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (_this_toUByteArray != null)
				{
					JNIEnv.CopyArray<UByte>(intPtr, _this_toUByteArray);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toUByteArray);
			}
			return result;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000B65CC File Offset: 0x000B47CC
		[Register("toUIntArray", "([Lkotlin/UInt;)[I", "")]
		public unsafe static int[] ToUIntArray(UInt[] _this_toUIntArray)
		{
			IntPtr intPtr = JNIEnv.NewArray<UInt>(_this_toUIntArray);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (int[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("toUIntArray.([Lkotlin/UInt;)[I", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				if (_this_toUIntArray != null)
				{
					JNIEnv.CopyArray<UInt>(intPtr, _this_toUIntArray);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toUIntArray);
			}
			return result;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000B6658 File Offset: 0x000B4858
		[Register("toULongArray", "([Lkotlin/ULong;)[J", "")]
		public unsafe static long[] ToULongArray(ULong[] _this_toULongArray)
		{
			IntPtr intPtr = JNIEnv.NewArray<ULong>(_this_toULongArray);
			long[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (long[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("toULongArray.([Lkotlin/ULong;)[J", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}
			finally
			{
				if (_this_toULongArray != null)
				{
					JNIEnv.CopyArray<ULong>(intPtr, _this_toULongArray);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toULongArray);
			}
			return result;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000B66E4 File Offset: 0x000B48E4
		[Register("toUShortArray", "([Lkotlin/UShort;)[S", "")]
		public unsafe static short[] ToUShortArray(UShort[] _this_toUShortArray)
		{
			IntPtr intPtr = JNIEnv.NewArray<UShort>(_this_toUShortArray);
			short[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (short[])JNIEnv.GetArray(UArraysKt._members.StaticMethods.InvokeObjectMethod("toUShortArray.([Lkotlin/UShort;)[S", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
			}
			finally
			{
				if (_this_toUShortArray != null)
				{
					JNIEnv.CopyArray<UShort>(intPtr, _this_toUShortArray);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toUShortArray);
			}
			return result;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000B6770 File Offset: 0x000B4970
		[Register("withIndex--ajY-9A", "([I)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable WithIndex(int[] _this_withIndex_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_withIndex_u2d_u2dajY_u2d9A);
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterable>(UArraysKt._members.StaticMethods.InvokeObjectMethod("withIndex--ajY-9A.([I)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_withIndex_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_withIndex_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_withIndex_u2d_u2dajY_u2d9A);
			}
			return @object;
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000B67EC File Offset: 0x000B49EC
		[Register("withIndex-GBYM_sE", "([B)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable WithIndex(byte[] _this_withIndex_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_withIndex_u2dGBYM_sE);
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterable>(UArraysKt._members.StaticMethods.InvokeObjectMethod("withIndex-GBYM_sE.([B)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_withIndex_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_withIndex_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_withIndex_u2dGBYM_sE);
			}
			return @object;
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000B6868 File Offset: 0x000B4A68
		[Register("withIndex-QwZRm1k", "([J)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable WithIndex(long[] _this_withIndex_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_withIndex_u2dQwZRm1k);
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterable>(UArraysKt._members.StaticMethods.InvokeObjectMethod("withIndex-QwZRm1k.([J)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_withIndex_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_withIndex_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_withIndex_u2dQwZRm1k);
			}
			return @object;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000B68E4 File Offset: 0x000B4AE4
		[Register("withIndex-rL5Bavg", "([S)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable WithIndex(short[] _this_withIndex_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_withIndex_u2drL5Bavg);
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterable>(UArraysKt._members.StaticMethods.InvokeObjectMethod("withIndex-rL5Bavg.([S)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_withIndex_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_withIndex_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_withIndex_u2drL5Bavg);
			}
			return @object;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000B6960 File Offset: 0x000B4B60
		[Register("zip-C-E_24M", "([I[Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Zip(int[] _this_zip_u2dC_u2dE_24M, Java.Lang.Object[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dC_u2dE_24M);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(other);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-C-E_24M.([I[Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dC_u2dE_24M != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dC_u2dE_24M);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_zip_u2dC_u2dE_24M);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000B6A0C File Offset: 0x000B4C0C
		[Register("zip-F7u83W8", "([JLjava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Zip(long[] _this_zip_u2dF7u83W8, IIterable other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dF7u83W8);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = JavaList.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-F7u83W8.([JLjava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dF7u83W8 != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dF7u83W8);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_zip_u2dF7u83W8);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000B6AB4 File Offset: 0x000B4CB4
		[Register("zip-HwE9HBo", "([ILjava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Zip(int[] _this_zip_u2dHwE9HBo, IIterable other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dHwE9HBo);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = JavaList.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-HwE9HBo.([ILjava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dHwE9HBo != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dHwE9HBo);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_zip_u2dHwE9HBo);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000B6B5C File Offset: 0x000B4D5C
		[Register("zip-JGPC0-M", "([SLjava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Zip(short[] _this_zip_u2dJGPC0_u2dM, IIterable other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dJGPC0_u2dM);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = JavaList.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-JGPC0-M.([SLjava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dJGPC0_u2dM != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dJGPC0_u2dM);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_zip_u2dJGPC0_u2dM);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000B6C04 File Offset: 0x000B4E04
		[Register("zip-JQknh5Q", "([BLjava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Zip(byte[] _this_zip_u2dJQknh5Q, IIterable other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dJQknh5Q);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = JavaList.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-JQknh5Q.([BLjava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dJQknh5Q != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dJQknh5Q);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_zip_u2dJQknh5Q);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000B6CAC File Offset: 0x000B4EAC
		[Register("zip-ctEhBpI", "([I[I)Ljava/util/List;", "")]
		public unsafe static IList<Pair> Zip(int[] _this_zip_u2dctEhBpI, int[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dctEhBpI);
			IntPtr intPtr2 = JNIEnv.NewArray(other);
			IList<Pair> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList<Pair>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-ctEhBpI.([I[I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dctEhBpI != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dctEhBpI);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_zip_u2dctEhBpI);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000B6D58 File Offset: 0x000B4F58
		[Register("zip-f7H3mmw", "([J[Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Zip(long[] _this_zip_u2df7H3mmw, Java.Lang.Object[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2df7H3mmw);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(other);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-f7H3mmw.([J[Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2df7H3mmw != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2df7H3mmw);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_zip_u2df7H3mmw);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000B6E04 File Offset: 0x000B5004
		[Register("zip-kdPth3s", "([B[B)Ljava/util/List;", "")]
		public unsafe static IList<Pair> Zip(byte[] _this_zip_u2dkdPth3s, byte[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dkdPth3s);
			IntPtr intPtr2 = JNIEnv.NewArray(other);
			IList<Pair> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList<Pair>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-kdPth3s.([B[B)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dkdPth3s != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dkdPth3s);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_zip_u2dkdPth3s);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000B6EB0 File Offset: 0x000B50B0
		[Register("zip-mazbYpA", "([S[S)Ljava/util/List;", "")]
		public unsafe static IList<Pair> Zip(short[] _this_zip_u2dmazbYpA, short[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dmazbYpA);
			IntPtr intPtr2 = JNIEnv.NewArray(other);
			IList<Pair> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList<Pair>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-mazbYpA.([S[S)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dmazbYpA != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dmazbYpA);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_zip_u2dmazbYpA);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000B6F5C File Offset: 0x000B515C
		[Register("zip-nl983wc", "([B[Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Zip(byte[] _this_zip_u2dnl983wc, Java.Lang.Object[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dnl983wc);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(other);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-nl983wc.([B[Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dnl983wc != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dnl983wc);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_zip_u2dnl983wc);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000B7008 File Offset: 0x000B5208
		[Register("zip-uaTIQ5s", "([S[Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Zip(short[] _this_zip_u2duaTIQ5s, Java.Lang.Object[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2duaTIQ5s);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(other);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-uaTIQ5s.([S[Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2duaTIQ5s != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2duaTIQ5s);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_zip_u2duaTIQ5s);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000B70B4 File Offset: 0x000B52B4
		[Register("zip-us8wMrg", "([J[J)Ljava/util/List;", "")]
		public unsafe static IList<Pair> Zip(long[] _this_zip_u2dus8wMrg, long[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_zip_u2dus8wMrg);
			IntPtr intPtr2 = JNIEnv.NewArray(other);
			IList<Pair> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList<Pair>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("zip-us8wMrg.([J[J)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_zip_u2dus8wMrg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_zip_u2dus8wMrg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (other != null)
				{
					JNIEnv.CopyArray(intPtr2, other);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_zip_u2dus8wMrg);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000B7160 File Offset: 0x000B5360
		[Register("asList--ajY-9A", "([I)Ljava/util/List;", "")]
		public unsafe static IList<UInt> AsList(int[] _this_asList_u2d_u2dajY_u2d9A)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_asList_u2d_u2dajY_u2d9A);
			IList<UInt> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UInt>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("asList--ajY-9A.([I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_asList_u2d_u2dajY_u2d9A != null)
				{
					JNIEnv.CopyArray(intPtr, _this_asList_u2d_u2dajY_u2d9A);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_asList_u2d_u2dajY_u2d9A);
			}
			return result;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000B71DC File Offset: 0x000B53DC
		[Register("asList-GBYM_sE", "([B)Ljava/util/List;", "")]
		public unsafe static IList<UByte> AsList(byte[] _this_asList_u2dGBYM_sE)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_asList_u2dGBYM_sE);
			IList<UByte> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UByte>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("asList-GBYM_sE.([B)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_asList_u2dGBYM_sE != null)
				{
					JNIEnv.CopyArray(intPtr, _this_asList_u2dGBYM_sE);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_asList_u2dGBYM_sE);
			}
			return result;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000B7258 File Offset: 0x000B5458
		[Register("asList-QwZRm1k", "([J)Ljava/util/List;", "")]
		public unsafe static IList<ULong> AsList(long[] _this_asList_u2dQwZRm1k)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_asList_u2dQwZRm1k);
			IList<ULong> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<ULong>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("asList-QwZRm1k.([J)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_asList_u2dQwZRm1k != null)
				{
					JNIEnv.CopyArray(intPtr, _this_asList_u2dQwZRm1k);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_asList_u2dQwZRm1k);
			}
			return result;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000B72D4 File Offset: 0x000B54D4
		[Register("asList-rL5Bavg", "([S)Ljava/util/List;", "")]
		public unsafe static IList<UShort> AsList(short[] _this_asList_u2drL5Bavg)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_asList_u2drL5Bavg);
			IList<UShort> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<UShort>.FromJniHandle(UArraysKt._members.StaticMethods.InvokeObjectMethod("asList-rL5Bavg.([S)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_asList_u2drL5Bavg != null)
				{
					JNIEnv.CopyArray(intPtr, _this_asList_u2drL5Bavg);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_asList_u2drL5Bavg);
			}
			return result;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000B7350 File Offset: 0x000B5550
		[Register("binarySearch-2fe2U9s", "([IIII)I", "")]
		public unsafe static int BinarySearch(int[] _this_binarySearch_u2d2fe2U9s, int element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_binarySearch_u2d2fe2U9s);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("binarySearch-2fe2U9s.([IIII)I", ptr);
			}
			finally
			{
				if (_this_binarySearch_u2d2fe2U9s != null)
				{
					JNIEnv.CopyArray(intPtr, _this_binarySearch_u2d2fe2U9s);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_binarySearch_u2d2fe2U9s);
			}
			return result;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000B73FC File Offset: 0x000B55FC
		[Register("binarySearch-EtDCXyQ", "([SSII)I", "")]
		public unsafe static int BinarySearch(short[] _this_binarySearch_u2dEtDCXyQ, short element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_binarySearch_u2dEtDCXyQ);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("binarySearch-EtDCXyQ.([SSII)I", ptr);
			}
			finally
			{
				if (_this_binarySearch_u2dEtDCXyQ != null)
				{
					JNIEnv.CopyArray(intPtr, _this_binarySearch_u2dEtDCXyQ);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_binarySearch_u2dEtDCXyQ);
			}
			return result;
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000B74A8 File Offset: 0x000B56A8
		[Register("binarySearch-K6DWlUc", "([JJII)I", "")]
		public unsafe static int BinarySearch(long[] _this_binarySearch_u2dK6DWlUc, long element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_binarySearch_u2dK6DWlUc);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("binarySearch-K6DWlUc.([JJII)I", ptr);
			}
			finally
			{
				if (_this_binarySearch_u2dK6DWlUc != null)
				{
					JNIEnv.CopyArray(intPtr, _this_binarySearch_u2dK6DWlUc);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_binarySearch_u2dK6DWlUc);
			}
			return result;
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000B7554 File Offset: 0x000B5754
		[Register("binarySearch-WpHrYlw", "([BBII)I", "")]
		public unsafe static int BinarySearch(byte[] _this_binarySearch_u2dWpHrYlw, sbyte element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_binarySearch_u2dWpHrYlw);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				result = UArraysKt._members.StaticMethods.InvokeInt32Method("binarySearch-WpHrYlw.([BBII)I", ptr);
			}
			finally
			{
				if (_this_binarySearch_u2dWpHrYlw != null)
				{
					JNIEnv.CopyArray(intPtr, _this_binarySearch_u2dWpHrYlw);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_binarySearch_u2dWpHrYlw);
			}
			return result;
		}

		// Token: 0x040009C7 RID: 2503
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/unsigned/UArraysKt", typeof(UArraysKt));
	}
}
