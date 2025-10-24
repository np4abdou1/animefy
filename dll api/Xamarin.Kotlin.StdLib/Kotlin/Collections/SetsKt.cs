using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Sequences;

namespace Kotlin.Collections
{
	// Token: 0x020002D2 RID: 722
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/SetsKt", DoNotGenerateAcw = true)]
	public sealed class SetsKt : Java.Lang.Object
	{
		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x000AF5F8 File Offset: 0x000AD7F8
		internal static IntPtr class_ref
		{
			get
			{
				return SetsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x000AF61C File Offset: 0x000AD81C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SetsKt._members;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x000AF624 File Offset: 0x000AD824
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SetsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x000AF648 File Offset: 0x000AD848
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SetsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000AF654 File Offset: 0x000AD854
		internal SetsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x000AF660 File Offset: 0x000AD860
		[Register("minus", "(Ljava/util/Set;Ljava/lang/Iterable;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Minus(System.Collections.ICollection _this_minus, IIterable elements)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_minus);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/util/Set;Ljava/lang/Iterable;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000AF700 File Offset: 0x000AD900
		[Register("minus", "(Ljava/util/Set;Lkotlin/sequences/Sequence;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Minus(System.Collections.ICollection _this_minus, ISequence elements)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_minus);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/util/Set;Lkotlin/sequences/Sequence;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x000AF7A0 File Offset: 0x000AD9A0
		[Register("minus", "(Ljava/util/Set;Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Minus(System.Collections.ICollection _this_minus, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_minus);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(element);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/util/Set;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x000AF838 File Offset: 0x000ADA38
		[Register("minus", "(Ljava/util/Set;[Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Minus(System.Collections.ICollection _this_minus, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_minus);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/util/Set;[Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, elements);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000AF8DC File Offset: 0x000ADADC
		[Register("plus", "(Ljava/util/Set;Ljava/lang/Iterable;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Plus(System.Collections.ICollection _this_plus, IIterable elements)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_plus);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Set;Ljava/lang/Iterable;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000AF97C File Offset: 0x000ADB7C
		[Register("plus", "(Ljava/util/Set;Lkotlin/sequences/Sequence;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Plus(System.Collections.ICollection _this_plus, ISequence elements)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_plus);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Set;Lkotlin/sequences/Sequence;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x000AFA1C File Offset: 0x000ADC1C
		[Register("plus", "(Ljava/util/Set;Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Plus(System.Collections.ICollection _this_plus, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_plus);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(element);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Set;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x000AFAB4 File Offset: 0x000ADCB4
		[Register("plus", "(Ljava/util/Set;[Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Plus(System.Collections.ICollection _this_plus, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_plus);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Set;[Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, elements);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000AFB58 File Offset: 0x000ADD58
		[Register("emptySet", "()Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static System.Collections.ICollection EmptySet()
		{
			return JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("emptySet.()Ljava/util/Set;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x000AFB8C File Offset: 0x000ADD8C
		[Register("hashSetOf", "([Ljava/lang/Object;)Ljava/util/HashSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static HashSet HashSetOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			HashSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<HashSet>(SetsKt._members.StaticMethods.InvokeObjectMethod("hashSetOf.([Ljava/lang/Object;)Ljava/util/HashSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x000AFC08 File Offset: 0x000ADE08
		[Register("linkedSetOf", "([Ljava/lang/Object;)Ljava/util/LinkedHashSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static LinkedHashSet LinkedSetOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			LinkedHashSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LinkedHashSet>(SetsKt._members.StaticMethods.InvokeObjectMethod("linkedSetOf.([Ljava/lang/Object;)Ljava/util/LinkedHashSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000AFC84 File Offset: 0x000ADE84
		[Register("mutableSetOf", "([Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection MutableSetOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("mutableSetOf.([Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000AFD00 File Offset: 0x000ADF00
		[Register("optimizeReadOnlySet", "(Ljava/util/Set;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection OptimizeReadOnlySet(System.Collections.ICollection _this_optimizeReadOnlySet)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(_this_optimizeReadOnlySet);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("optimizeReadOnlySet.(Ljava/util/Set;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_optimizeReadOnlySet);
			}
			return result;
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000AFD70 File Offset: 0x000ADF70
		[Register("setOf", "([Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection SetOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("setOf.([Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000AFDEC File Offset: 0x000ADFEC
		[Register("setOfNotNull", "(Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection SetOfNotNull([Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("setOfNotNull.(Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x000AFE5C File Offset: 0x000AE05C
		[Register("setOfNotNull", "([Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection SetOfNotNull(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("setOfNotNull.([Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000AFED8 File Offset: 0x000AE0D8
		[Register("build", "(Ljava/util/Set;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static System.Collections.ICollection Build(System.Collections.ICollection builder)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(builder);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("build.(Ljava/util/Set;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(builder);
			}
			return result;
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000AFF48 File Offset: 0x000AE148
		[Register("createSetBuilder", "()Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public static System.Collections.ICollection CreateSetBuilder()
		{
			return JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("createSetBuilder.()Ljava/util/Set;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x000AFF7C File Offset: 0x000AE17C
		[Register("createSetBuilder", "(I)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static System.Collections.ICollection CreateSetBuilder(int capacity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(capacity);
			return JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("createSetBuilder.(I)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x000AFFC4 File Offset: 0x000AE1C4
		[Register("setOf", "(Ljava/lang/Object;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection SetOf([Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(SetsKt._members.StaticMethods.InvokeObjectMethod("setOf.(Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x000B0034 File Offset: 0x000AE234
		[Register("sortedSetOf", "(Ljava/util/Comparator;[Ljava/lang/Object;)Ljava/util/TreeSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static TreeSet SortedSetOf(IComparator comparator, params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			TreeSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<TreeSet>(SetsKt._members.StaticMethods.InvokeObjectMethod("sortedSetOf.(Ljava/util/Comparator;[Ljava/lang/Object;)Ljava/util/TreeSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(comparator);
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x000B00DC File Offset: 0x000AE2DC
		[Register("sortedSetOf", "([Ljava/lang/Object;)Ljava/util/TreeSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static TreeSet SortedSetOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			TreeSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<TreeSet>(SetsKt._members.StaticMethods.InvokeObjectMethod("sortedSetOf.([Ljava/lang/Object;)Ljava/util/TreeSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x040009BD RID: 2493
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/SetsKt", typeof(SetsKt));
	}
}
