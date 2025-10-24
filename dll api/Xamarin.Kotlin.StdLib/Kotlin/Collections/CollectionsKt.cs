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
using Kotlin.Jvm.Functions;
using Kotlin.Random;
using Kotlin.Ranges;
using Kotlin.Sequences;

namespace Kotlin.Collections
{
	// Token: 0x020002C3 RID: 707
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/CollectionsKt", DoNotGenerateAcw = true)]
	public sealed class CollectionsKt : Java.Lang.Object
	{
		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x000A1DA0 File Offset: 0x0009FFA0
		internal static IntPtr class_ref
		{
			get
			{
				return CollectionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x0600262F RID: 9775 RVA: 0x000A1DC4 File Offset: 0x0009FFC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CollectionsKt._members;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x000A1DCC File Offset: 0x0009FFCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CollectionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x000A1DF0 File Offset: 0x0009FFF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CollectionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000A1DFC File Offset: 0x0009FFFC
		internal CollectionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000A1E08 File Offset: 0x000A0008
		[Register("all", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool All(IIterable _this_all, IFunction1 predicate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_all == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_all).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("all.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_all);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000A1EA0 File Offset: 0x000A00A0
		[Register("any", "(Ljava/lang/Iterable;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool Any(IIterable _this_any)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_any == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_any).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("any.(Ljava/lang/Iterable;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_any);
			}
			return result;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000A1F0C File Offset: 0x000A010C
		[Register("any", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool Any(IIterable _this_any, IFunction1 predicate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_any == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_any).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("any.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_any);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000A1FA4 File Offset: 0x000A01A4
		[Register("asSequence", "(Ljava/lang/Iterable;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence AsSequence(IIterable _this_asSequence)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asSequence == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asSequence).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("asSequence.(Ljava/lang/Iterable;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asSequence);
			}
			return @object;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000A201C File Offset: 0x000A021C
		[Register("associate", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V"
		})]
		public unsafe static IDictionary Associate(IIterable _this_associate, IFunction1 transform)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associate == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associate).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaDictionary.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("associate.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_associate);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x000A20C0 File Offset: 0x000A02C0
		[Register("associateBy", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static IDictionary AssociateBy(IIterable _this_associateBy, IFunction1 keySelector)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				result = JavaDictionary.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("associateBy.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_associateBy);
				GC.KeepAlive(keySelector);
			}
			return result;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x000A2164 File Offset: 0x000A0364
		[Register("associateBy", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V"
		})]
		public unsafe static IDictionary AssociateBy(IIterable _this_associateBy, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[2] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				result = JavaDictionary.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("associateBy.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_associateBy);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return result;
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000A2238 File Offset: 0x000A0438
		[Register("associateByTo", "(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"M extends java.util.Map<? super K, ? super T>"
		})]
		public unsafe static Java.Lang.Object AssociateByTo(IIterable _this_associateByTo, Java.Lang.Object destination, IFunction1 keySelector)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateByTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateByTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("associateByTo.(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_associateByTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(keySelector);
			}
			return @object;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000A2308 File Offset: 0x000A0508
		[Register("associateByTo", "(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateByTo(IIterable _this_associateByTo, Java.Lang.Object destination, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateByTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateByTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[3] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("associateByTo.(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_associateByTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return @object;
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000A2408 File Offset: 0x000A0608
		[Register("associateTo", "(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateTo(IIterable _this_associateTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("associateTo.(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_associateTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000A24D8 File Offset: 0x000A06D8
		[Register("associateWith", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary AssociateWith(IIterable _this_associateWith, IFunction1 valueSelector)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateWith).Handle);
				ptr[1] = new JniArgumentValue((valueSelector == null) ? IntPtr.Zero : ((Java.Lang.Object)valueSelector).Handle);
				result = JavaDictionary.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("associateWith.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_associateWith);
				GC.KeepAlive(valueSelector);
			}
			return result;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000A257C File Offset: 0x000A077C
		[Register("associateWithTo", "(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateWithTo(IIterable _this_associateWithTo, Java.Lang.Object destination, IFunction1 valueSelector)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateWithTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateWithTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((valueSelector == null) ? IntPtr.Zero : ((Java.Lang.Object)valueSelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("associateWithTo.(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_associateWithTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(valueSelector);
			}
			return @object;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000A264C File Offset: 0x000A084C
		[Register("averageOfByte", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double AverageOfByte(IIterable _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("averageOfByte.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000A26B8 File Offset: 0x000A08B8
		[Register("averageOfDouble", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double AverageOfDouble(IIterable _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("averageOfDouble.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000A2724 File Offset: 0x000A0924
		[Register("averageOfFloat", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double AverageOfFloat(IIterable _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("averageOfFloat.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000A2790 File Offset: 0x000A0990
		[Register("averageOfInt", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double AverageOfInt(IIterable _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("averageOfInt.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000A27FC File Offset: 0x000A09FC
		[Register("averageOfLong", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double AverageOfLong(IIterable _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("averageOfLong.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000A2868 File Offset: 0x000A0A68
		[Register("averageOfShort", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double AverageOfShort(IIterable _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("averageOfShort.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000A28D4 File Offset: 0x000A0AD4
		[Register("chunked", "(Ljava/lang/Iterable;I)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IList<System.Collections.IList> Chunked(IIterable _this_chunked, int size)
		{
			IList<System.Collections.IList> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_chunked == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_chunked).Handle);
				ptr[1] = new JniArgumentValue(size);
				result = JavaList<System.Collections.IList>.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("chunked.(Ljava/lang/Iterable;I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_chunked);
			}
			return result;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000A2960 File Offset: 0x000A0B60
		[Register("chunked", "(Ljava/lang/Iterable;ILkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList Chunked(IIterable _this_chunked, int size, IFunction1 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_chunked == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_chunked).Handle);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("chunked.(Ljava/lang/Iterable;ILkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_chunked);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000A2A1C File Offset: 0x000A0C1C
		[Register("contains", "(Ljava/lang/Iterable;Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool Contains(IIterable _this_contains, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("contains.(Ljava/lang/Iterable;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_contains);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000A2AAC File Offset: 0x000A0CAC
		[Register("count", "(Ljava/lang/Iterable;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int Count(IIterable _this_count)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_count == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_count).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("count.(Ljava/lang/Iterable;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_count);
			}
			return result;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000A2B18 File Offset: 0x000A0D18
		[Register("count", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int Count(IIterable _this_count, IFunction1 predicate)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_count == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_count).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("count.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_count);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000A2BB0 File Offset: 0x000A0DB0
		[Register("distinct", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Distinct(IIterable _this_distinct)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_distinct == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_distinct).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("distinct.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_distinct);
			}
			return result;
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000A2C28 File Offset: 0x000A0E28
		[Register("distinctBy", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static System.Collections.IList DistinctBy(IIterable _this_distinctBy, IFunction1 selector)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_distinctBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_distinctBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("distinctBy.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_distinctBy);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000A2CCC File Offset: 0x000A0ECC
		[Register("drop", "(Ljava/lang/Iterable;I)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Drop(IIterable _this_drop, int n)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_drop == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_drop).Handle);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("drop.(Ljava/lang/Iterable;I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_drop);
			}
			return result;
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x000A2D58 File Offset: 0x000A0F58
		[Register("dropLast", "(Ljava/util/List;I)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList DropLast(System.Collections.IList _this_dropLast, int n)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_dropLast);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("dropLast.(Ljava/util/List;I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_dropLast);
			}
			return result;
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000A2DDC File Offset: 0x000A0FDC
		[Register("dropLastWhile", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList DropLastWhile(System.Collections.IList _this_dropLastWhile, IFunction1 predicate)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_dropLastWhile);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("dropLastWhile.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_dropLastWhile);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000A2E7C File Offset: 0x000A107C
		[Register("dropWhile", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList DropWhile(IIterable _this_dropWhile, IFunction1 predicate)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_dropWhile == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_dropWhile).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("dropWhile.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_dropWhile);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x000A2F20 File Offset: 0x000A1120
		[Register("elementAt", "(Ljava/lang/Iterable;I)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ElementAt(IIterable _this_elementAt, int index)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_elementAt == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_elementAt).Handle);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("elementAt.(Ljava/lang/Iterable;I)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_elementAt);
			}
			return @object;
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000A2FAC File Offset: 0x000A11AC
		[Register("elementAtOrElse", "(Ljava/lang/Iterable;ILkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ElementAtOrElse(IIterable _this_elementAtOrElse, int index, IFunction1 defaultValue)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_elementAtOrElse == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_elementAtOrElse).Handle);
				ptr[1] = new JniArgumentValue(index);
				ptr[2] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("elementAtOrElse.(Ljava/lang/Iterable;ILkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_elementAtOrElse);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000A3068 File Offset: 0x000A1268
		[Register("elementAtOrNull", "(Ljava/lang/Iterable;I)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ElementAtOrNull(IIterable _this_elementAtOrNull, int index)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_elementAtOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_elementAtOrNull).Handle);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("elementAtOrNull.(Ljava/lang/Iterable;I)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_elementAtOrNull);
			}
			return @object;
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000A30F4 File Offset: 0x000A12F4
		[Register("filter", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Filter(IIterable _this_filter, IFunction1 predicate)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filter == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filter).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filter.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filter);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000A3198 File Offset: 0x000A1398
		[Register("filterIndexed", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList FilterIndexed(IIterable _this_filterIndexed, IFunction2 predicate)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIndexed).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterIndexed.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterIndexed);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x000A323C File Offset: 0x000A143C
		[Register("filterIndexedTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object FilterIndexedTo(IIterable _this_filterIndexedTo, Java.Lang.Object destination, IFunction2 predicate)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIndexedTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIndexedTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterIndexedTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterIndexedTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000A330C File Offset: 0x000A150C
		[Register("filterNot", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList FilterNot(IIterable _this_filterNot, IFunction1 predicate)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNot == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNot).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterNot.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterNot);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000A33B0 File Offset: 0x000A15B0
		[Register("filterNotNull", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList FilterNotNull(IIterable _this_filterNotNull)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNotNull).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterNotNull.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterNotNull);
			}
			return result;
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x000A3428 File Offset: 0x000A1628
		[Register("filterNotNullTo", "(Ljava/lang/Iterable;Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"C extends java.util.Collection<? super T>",
			"T"
		})]
		public unsafe static Java.Lang.Object FilterNotNullTo(IIterable _this_filterNotNullTo, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNotNullTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNotNullTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterNotNullTo.(Ljava/lang/Iterable;Ljava/util/Collection;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterNotNullTo);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000A34C8 File Offset: 0x000A16C8
		[Register("filterNotTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object FilterNotTo(IIterable _this_filterNotTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNotTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNotTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterNotTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterNotTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000A3598 File Offset: 0x000A1798
		[Register("filterTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object FilterTo(IIterable _this_filterTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000A3668 File Offset: 0x000A1868
		[Register("first", "(Ljava/lang/Iterable;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object First(IIterable _this_first)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_first).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("first.(Ljava/lang/Iterable;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_first);
			}
			return @object;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000A36E0 File Offset: 0x000A18E0
		[Register("first", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object First(IIterable _this_first, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_first).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("first.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_first);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000A3784 File Offset: 0x000A1984
		[Register("first", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object First(System.Collections.IList _this_first)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_first);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("first.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_first);
			}
			return @object;
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x000A37F4 File Offset: 0x000A19F4
		[Register("firstOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FirstOrNull(IIterable _this_firstOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_firstOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Ljava/lang/Iterable;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x000A386C File Offset: 0x000A1A6C
		[Register("firstOrNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FirstOrNull(IIterable _this_firstOrNull, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_firstOrNull).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000A3910 File Offset: 0x000A1B10
		[Register("firstOrNull", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FirstOrNull(System.Collections.IList _this_firstOrNull)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_firstOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000A3980 File Offset: 0x000A1B80
		[Register("flatMap", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList FlatMap(IIterable _this_flatMap, IFunction1 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMap).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("flatMap.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMap);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000A3A24 File Offset: 0x000A1C24
		[Register("flatMapSequence", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList FlatMapSequence(IIterable _this_flatMap, IFunction1 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMap).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("flatMapSequence.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMap);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000A3AC8 File Offset: 0x000A1CC8
		[Register("flatMapSequenceTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object FlatMapSequenceTo(IIterable _this_flatMapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("flatMapSequenceTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_flatMapTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000A3B98 File Offset: 0x000A1D98
		[Register("flatMapTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object FlatMapTo(IIterable _this_flatMapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("flatMapTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_flatMapTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000A3C68 File Offset: 0x000A1E68
		[Register("fold", "(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(IIterable _this_fold, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_fold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_fold).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("fold.(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_fold);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000A3D38 File Offset: 0x000A1F38
		[Register("foldIndexed", "(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FoldIndexed(IIterable _this_foldIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_foldIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_foldIndexed).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("foldIndexed.(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_foldIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000A3E08 File Offset: 0x000A2008
		[Register("foldRight", "(Ljava/util/List;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FoldRight(System.Collections.IList _this_foldRight, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_foldRight);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("foldRight.(Ljava/util/List;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_foldRight);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000A3ED0 File Offset: 0x000A20D0
		[Register("foldRightIndexed", "(Ljava/util/List;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FoldRightIndexed(System.Collections.IList _this_foldRightIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_foldRightIndexed);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("foldRightIndexed.(Ljava/util/List;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_foldRightIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000A3F98 File Offset: 0x000A2198
		[Register("forEach", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void ForEach(IIterable _this_forEach, IFunction1 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_forEach).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("forEach.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEach);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x000A402C File Offset: 0x000A222C
		[Register("forEachIndexed", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void ForEachIndexed(IIterable _this_forEachIndexed, IFunction2 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEachIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_forEachIndexed).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("forEachIndexed.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEachIndexed);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x000A40C0 File Offset: 0x000A22C0
		[Register("getOrNull", "(Ljava/util/List;I)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetOrNull(System.Collections.IList _this_getOrNull, int index)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_getOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("getOrNull.(Ljava/util/List;I)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_getOrNull);
			}
			return @object;
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000A4144 File Offset: 0x000A2344
		[Register("groupBy", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static IDictionary GroupBy(IIterable _this_groupBy, IFunction1 keySelector)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				result = JavaDictionary.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("groupBy.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_groupBy);
				GC.KeepAlive(keySelector);
			}
			return result;
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x000A41E8 File Offset: 0x000A23E8
		[Register("groupBy", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V"
		})]
		public unsafe static IDictionary GroupBy(IIterable _this_groupBy, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[2] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				result = JavaDictionary.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("groupBy.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_groupBy);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return result;
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x000A42BC File Offset: 0x000A24BC
		[Register("groupByTo", "(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"M extends java.util.Map<? super K, java.util.List<T>>"
		})]
		public unsafe static Java.Lang.Object GroupByTo(IIterable _this_groupByTo, Java.Lang.Object destination, IFunction1 keySelector)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupByTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupByTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("groupByTo.(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_groupByTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(keySelector);
			}
			return @object;
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x000A438C File Offset: 0x000A258C
		[Register("groupByTo", "(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V",
			"M extends java.util.Map<? super K, java.util.List<V>>"
		})]
		public unsafe static Java.Lang.Object GroupByTo(IIterable _this_groupByTo, Java.Lang.Object destination, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupByTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupByTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[3] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("groupByTo.(Ljava/lang/Iterable;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_groupByTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return @object;
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x000A448C File Offset: 0x000A268C
		[Register("groupingBy", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Lkotlin/collections/Grouping;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static IGrouping GroupingBy(IIterable _this_groupingBy, IFunction1 keySelector)
		{
			IGrouping @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupingBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupingBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<IGrouping>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("groupingBy.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Lkotlin/collections/Grouping;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_groupingBy);
				GC.KeepAlive(keySelector);
			}
			return @object;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000A4530 File Offset: 0x000A2730
		[Register("indexOf", "(Ljava/lang/Iterable;Ljava/lang/Object;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOf(IIterable _this_indexOf, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_indexOf == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_indexOf).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("indexOf.(Ljava/lang/Iterable;Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indexOf);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000A45C0 File Offset: 0x000A27C0
		[Register("indexOf", "(Ljava/util/List;Ljava/lang/Object;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOf(System.Collections.IList _this_indexOf, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_indexOf);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("indexOf.(Ljava/util/List;Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_indexOf);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000A4648 File Offset: 0x000A2848
		[Register("indexOfFirst", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOfFirst(IIterable _this_indexOfFirst, IFunction1 predicate)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_indexOfFirst == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_indexOfFirst).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("indexOfFirst.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_indexOfFirst);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x000A46E0 File Offset: 0x000A28E0
		[Register("indexOfFirst", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOfFirst(System.Collections.IList _this_indexOfFirst, IFunction1 predicate)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_indexOfFirst);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("indexOfFirst.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indexOfFirst);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x000A4770 File Offset: 0x000A2970
		[Register("indexOfLast", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOfLast(IIterable _this_indexOfLast, IFunction1 predicate)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_indexOfLast == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_indexOfLast).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("indexOfLast.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_indexOfLast);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x000A4808 File Offset: 0x000A2A08
		[Register("indexOfLast", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOfLast(System.Collections.IList _this_indexOfLast, IFunction1 predicate)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_indexOfLast);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("indexOfLast.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indexOfLast);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000A4898 File Offset: 0x000A2A98
		[Register("intersect", "(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Intersect(IIterable _this_intersect, IIterable other)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_intersect == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_intersect).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = JavaSet.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("intersect.(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_intersect);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000A493C File Offset: 0x000A2B3C
		[Register("joinTo", "(Ljava/lang/Iterable;Ljava/lang/Appendable;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ILjava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Appendable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"A extends java.lang.Appendable"
		})]
		public unsafe static Java.Lang.Object JoinTo(IIterable _this_joinTo, Java.Lang.Object buffer, ICharSequence separator, ICharSequence prefix, ICharSequence postfix, int limit, ICharSequence truncated, [Nullable(2)] IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(buffer);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(separator);
			IntPtr intPtr3 = CharSequence.ToLocalJniHandle(prefix);
			IntPtr intPtr4 = CharSequence.ToLocalJniHandle(postfix);
			IntPtr intPtr5 = CharSequence.ToLocalJniHandle(truncated);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_joinTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_joinTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue(intPtr4);
				ptr[5] = new JniArgumentValue(limit);
				ptr[6] = new JniArgumentValue(intPtr5);
				ptr[7] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("joinTo.(Ljava/lang/Iterable;Ljava/lang/Appendable;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ILjava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Appendable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				GC.KeepAlive(_this_joinTo);
				GC.KeepAlive(buffer);
				GC.KeepAlive(separator);
				GC.KeepAlive(prefix);
				GC.KeepAlive(postfix);
				GC.KeepAlive(truncated);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000A4AE8 File Offset: 0x000A2CE8
		public static Java.Lang.Object JoinTo(IIterable _this_joinTo, Java.Lang.Object buffer, string separator, string prefix, string postfix, int limit, string truncated, [Nullable(2)] IFunction1 transform)
		{
			Java.Lang.String @string = (separator == null) ? null : new Java.Lang.String(separator);
			Java.Lang.String string2 = (prefix == null) ? null : new Java.Lang.String(prefix);
			Java.Lang.String string3 = (postfix == null) ? null : new Java.Lang.String(postfix);
			Java.Lang.String string4 = (truncated == null) ? null : new Java.Lang.String(truncated);
			Java.Lang.Object result = CollectionsKt.JoinTo(_this_joinTo, buffer, @string, string2, string3, limit, string4, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			if (string2 != null)
			{
				string2.Dispose();
			}
			if (string3 != null)
			{
				string3.Dispose();
			}
			if (string4 != null)
			{
				string4.Dispose();
			}
			return result;
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x000A4B60 File Offset: 0x000A2D60
		[Register("joinToString", "(Ljava/lang/Iterable;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ILjava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/String;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static string JoinToString(IIterable _this_joinToString, ICharSequence separator, ICharSequence prefix, ICharSequence postfix, int limit, ICharSequence truncated, [Nullable(2)] IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(separator);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(prefix);
			IntPtr intPtr3 = CharSequence.ToLocalJniHandle(postfix);
			IntPtr intPtr4 = CharSequence.ToLocalJniHandle(truncated);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_joinToString == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_joinToString).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue(limit);
				ptr[5] = new JniArgumentValue(intPtr4);
				ptr[6] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@string = JNIEnv.GetString(CollectionsKt._members.StaticMethods.InvokeObjectMethod("joinToString.(Ljava/lang/Iterable;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ILjava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(_this_joinToString);
				GC.KeepAlive(separator);
				GC.KeepAlive(prefix);
				GC.KeepAlive(postfix);
				GC.KeepAlive(truncated);
				GC.KeepAlive(transform);
			}
			return @string;
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x000A4CD0 File Offset: 0x000A2ED0
		public static string JoinToString(IIterable _this_joinToString, string separator, string prefix, string postfix, int limit, string truncated, [Nullable(2)] IFunction1 transform)
		{
			Java.Lang.String @string = (separator == null) ? null : new Java.Lang.String(separator);
			Java.Lang.String string2 = (prefix == null) ? null : new Java.Lang.String(prefix);
			Java.Lang.String string3 = (postfix == null) ? null : new Java.Lang.String(postfix);
			Java.Lang.String string4 = (truncated == null) ? null : new Java.Lang.String(truncated);
			string result = CollectionsKt.JoinToString(_this_joinToString, @string, string2, string3, limit, string4, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			if (string2 != null)
			{
				string2.Dispose();
			}
			if (string3 != null)
			{
				string3.Dispose();
			}
			if (string4 != null)
			{
				string4.Dispose();
			}
			return result;
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x000A4D48 File Offset: 0x000A2F48
		[Register("last", "(Ljava/lang/Iterable;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Last(IIterable _this_last)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_last).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("last.(Ljava/lang/Iterable;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_last);
			}
			return @object;
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x000A4DC0 File Offset: 0x000A2FC0
		[Register("last", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Last(IIterable _this_last, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_last).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("last.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_last);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000A4E64 File Offset: 0x000A3064
		[Register("last", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Last(System.Collections.IList _this_last)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_last);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("last.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_last);
			}
			return @object;
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x000A4ED4 File Offset: 0x000A30D4
		[Register("last", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Last(System.Collections.IList _this_last, IFunction1 predicate)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_last);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("last.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_last);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x000A4F74 File Offset: 0x000A3174
		[Register("lastIndexOf", "(Ljava/lang/Iterable;Ljava/lang/Object;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int LastIndexOf(IIterable _this_lastIndexOf, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastIndexOf == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_lastIndexOf).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("lastIndexOf.(Ljava/lang/Iterable;Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastIndexOf);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x000A5004 File Offset: 0x000A3204
		[Register("lastIndexOf", "(Ljava/util/List;Ljava/lang/Object;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int LastIndexOf(System.Collections.IList _this_lastIndexOf, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_lastIndexOf);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("lastIndexOf.(Ljava/util/List;Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_lastIndexOf);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x000A508C File Offset: 0x000A328C
		[Register("lastOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object LastOrNull(IIterable _this_lastOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_lastOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Ljava/lang/Iterable;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x000A5104 File Offset: 0x000A3304
		[Register("lastOrNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object LastOrNull(IIterable _this_lastOrNull, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_lastOrNull).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x000A51A8 File Offset: 0x000A33A8
		[Register("lastOrNull", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object LastOrNull(System.Collections.IList _this_lastOrNull)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_lastOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000A5218 File Offset: 0x000A3418
		[Register("lastOrNull", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object LastOrNull(System.Collections.IList _this_lastOrNull, IFunction1 predicate)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_lastOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000A52B8 File Offset: 0x000A34B8
		[Register("map", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList Map(IIterable _this_map, IFunction1 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_map == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_map).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("map.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_map);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000A535C File Offset: 0x000A355C
		[Register("mapIndexed", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList MapIndexed(IIterable _this_mapIndexed, IFunction2 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexed).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("mapIndexed.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapIndexed);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000A5400 File Offset: 0x000A3600
		[Register("mapIndexedNotNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList MapIndexedNotNull(IIterable _this_mapIndexedNotNull, IFunction2 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexedNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexedNotNull).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("mapIndexedNotNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapIndexedNotNull);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000A54A4 File Offset: 0x000A36A4
		[Register("mapIndexedNotNullTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapIndexedNotNullTo(IIterable _this_mapIndexedNotNullTo, Java.Lang.Object destination, IFunction2 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexedNotNullTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexedNotNullTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("mapIndexedNotNullTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapIndexedNotNullTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000A5574 File Offset: 0x000A3774
		[Register("mapIndexedTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapIndexedTo(IIterable _this_mapIndexedTo, Java.Lang.Object destination, IFunction2 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexedTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexedTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("mapIndexedTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapIndexedTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000A5644 File Offset: 0x000A3844
		[Register("mapNotNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList MapNotNull(IIterable _this_mapNotNull, IFunction1 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapNotNull).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("mapNotNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapNotNull);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000A56E8 File Offset: 0x000A38E8
		[Register("mapNotNullTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapNotNullTo(IIterable _this_mapNotNullTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapNotNullTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapNotNullTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("mapNotNullTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapNotNullTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000A57B8 File Offset: 0x000A39B8
		[Register("mapTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapTo(IIterable _this_mapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("mapTo.(Ljava/lang/Iterable;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000A5888 File Offset: 0x000A3A88
		[Register("maxByOrNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxByOrNull(IIterable _this_maxByOrNull, IFunction1 selector)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxByOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxByOrNull).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("maxByOrNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxByOrNull);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000A592C File Offset: 0x000A3B2C
		[Register("maxByOrThrow", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxByOrThrow(IIterable _this_maxBy, IFunction1 selector)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("maxByOrThrow.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxBy);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000A59D0 File Offset: 0x000A3BD0
		[Register("maxOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxOrNull(IIterable _this_maxOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("maxOrNull.(Ljava/lang/Iterable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxOrNull);
			}
			return @object;
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x000A5A48 File Offset: 0x000A3C48
		[Register("maxOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Double;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Double MaxOrNullOfDouble(IIterable _this_maxOrNull)
		{
			Java.Lang.Double @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Double>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("maxOrNull.(Ljava/lang/Iterable;)Ljava/lang/Double;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxOrNull);
			}
			return @object;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000A5AC0 File Offset: 0x000A3CC0
		[Register("maxOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Float;", "")]
		[return: Nullable(2)]
		public unsafe static Float MaxOrNullOfFloat(IIterable _this_maxOrNull)
		{
			Float @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Float>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("maxOrNull.(Ljava/lang/Iterable;)Ljava/lang/Float;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxOrNull);
			}
			return @object;
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000A5B38 File Offset: 0x000A3D38
		[Register("maxOrThrow", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double MaxOrThrowDouble(IIterable _this_max)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_max == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_max).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("maxOrThrow.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_max);
			}
			return result;
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000A5BA4 File Offset: 0x000A3DA4
		[Register("maxOrThrow", "(Ljava/lang/Iterable;)F", "")]
		public unsafe static float MaxOrThrowFloat(IIterable _this_max)
		{
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_max == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_max).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeSingleMethod("maxOrThrow.(Ljava/lang/Iterable;)F", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_max);
			}
			return result;
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000A5C10 File Offset: 0x000A3E10
		[Register("maxOrThrow", "(Ljava/lang/Iterable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MaxOrThrow(IIterable _this_max)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_max == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_max).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("maxOrThrow.(Ljava/lang/Iterable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_max);
			}
			return @object;
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000A5C88 File Offset: 0x000A3E88
		[Register("maxWithOrNull", "(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxWithOrNull(IIterable _this_maxWithOrNull, IComparator comparator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxWithOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxWithOrNull).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("maxWithOrNull.(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxWithOrNull);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000A5D2C File Offset: 0x000A3F2C
		[Register("maxWithOrThrow", "(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxWithOrThrow(IIterable _this_maxWith, IComparator comparator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxWith).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("maxWithOrThrow.(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxWith);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000A5DD0 File Offset: 0x000A3FD0
		[Register("minByOrNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinByOrNull(IIterable _this_minByOrNull, IFunction1 selector)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minByOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minByOrNull).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minByOrNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minByOrNull);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000A5E74 File Offset: 0x000A4074
		[Register("minByOrThrow", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinByOrThrow(IIterable _this_minBy, IFunction1 selector)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minByOrThrow.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minBy);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000A5F18 File Offset: 0x000A4118
		[Register("minOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinOrNull(IIterable _this_minOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minOrNull.(Ljava/lang/Iterable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minOrNull);
			}
			return @object;
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000A5F90 File Offset: 0x000A4190
		[Register("minOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Double;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Double MinOrNullOfDouble(IIterable _this_minOrNull)
		{
			Java.Lang.Double @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Double>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minOrNull.(Ljava/lang/Iterable;)Ljava/lang/Double;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minOrNull);
			}
			return @object;
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000A6008 File Offset: 0x000A4208
		[Register("minOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Float;", "")]
		[return: Nullable(2)]
		public unsafe static Float MinOrNullOfFloat(IIterable _this_minOrNull)
		{
			Float @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Float>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minOrNull.(Ljava/lang/Iterable;)Ljava/lang/Float;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minOrNull);
			}
			return @object;
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000A6080 File Offset: 0x000A4280
		[Register("minOrThrow", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double MinOrThrowDouble(IIterable _this_min)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_min == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_min).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("minOrThrow.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_min);
			}
			return result;
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000A60EC File Offset: 0x000A42EC
		[Register("minOrThrow", "(Ljava/lang/Iterable;)F", "")]
		public unsafe static float MinOrThrowFloat(IIterable _this_min)
		{
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_min == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_min).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeSingleMethod("minOrThrow.(Ljava/lang/Iterable;)F", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_min);
			}
			return result;
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000A6158 File Offset: 0x000A4358
		[Register("minOrThrow", "(Ljava/lang/Iterable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MinOrThrow(IIterable _this_min)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_min == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_min).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minOrThrow.(Ljava/lang/Iterable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_min);
			}
			return @object;
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000A61D0 File Offset: 0x000A43D0
		[Register("minWithOrNull", "(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinWithOrNull(IIterable _this_minWithOrNull, IComparator comparator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minWithOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minWithOrNull).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minWithOrNull.(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minWithOrNull);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000A6274 File Offset: 0x000A4474
		[Register("minWithOrThrow", "(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinWithOrThrow(IIterable _this_minWith, IComparator comparator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minWith).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minWithOrThrow.(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minWith);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x000A6318 File Offset: 0x000A4518
		[Register("minus", "(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Minus(IIterable _this_minus, IIterable elements)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minus).Handle);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x000A63BC File Offset: 0x000A45BC
		[Register("minus", "(Ljava/lang/Iterable;Lkotlin/sequences/Sequence;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Minus(IIterable _this_minus, ISequence elements)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minus).Handle);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/lang/Iterable;Lkotlin/sequences/Sequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x000A6460 File Offset: 0x000A4660
		[Register("minus", "(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Minus(IIterable _this_minus, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minus).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x000A6500 File Offset: 0x000A4700
		[Register("minus", "(Ljava/lang/Iterable;[Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Minus(IIterable _this_minus, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minus).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/lang/Iterable;[Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x000A65A8 File Offset: 0x000A47A8
		[Register("none", "(Ljava/lang/Iterable;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool None(IIterable _this_none)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_none == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_none).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("none.(Ljava/lang/Iterable;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_none);
			}
			return result;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x000A6614 File Offset: 0x000A4814
		[Register("none", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool None(IIterable _this_none, IFunction1 predicate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_none == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_none).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("none.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_none);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x000A66AC File Offset: 0x000A48AC
		[Register("onEach", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Iterable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.lang.Iterable<? extends T>"
		})]
		public unsafe static Java.Lang.Object OnEach(Java.Lang.Object _this_onEach, IFunction1 action)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_onEach);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("onEach.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_onEach);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x000A674C File Offset: 0x000A494C
		[Register("onEachIndexed", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/lang/Iterable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.lang.Iterable<? extends T>"
		})]
		public unsafe static Java.Lang.Object OnEachIndexed(Java.Lang.Object _this_onEachIndexed, IFunction2 action)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_onEachIndexed);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("onEachIndexed.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_onEachIndexed);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000A67EC File Offset: 0x000A49EC
		[Register("partition", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Lkotlin/Pair;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Pair Partition(IIterable _this_partition, IFunction1 predicate)
		{
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_partition == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_partition).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Pair>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("partition.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_partition);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x000A6890 File Offset: 0x000A4A90
		[Register("plus", "(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Plus(IIterable _this_plus, IIterable elements)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_plus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_plus).Handle);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000A6934 File Offset: 0x000A4B34
		[Register("plus", "(Ljava/lang/Iterable;Lkotlin/sequences/Sequence;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Plus(IIterable _this_plus, ISequence elements)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_plus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_plus).Handle);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/lang/Iterable;Lkotlin/sequences/Sequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000A69D8 File Offset: 0x000A4BD8
		[Register("plus", "(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Plus(IIterable _this_plus, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_plus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_plus).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x000A6A78 File Offset: 0x000A4C78
		[Register("plus", "(Ljava/lang/Iterable;[Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Plus(IIterable _this_plus, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_plus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_plus).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/lang/Iterable;[Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000A6B20 File Offset: 0x000A4D20
		[Register("plus", "(Ljava/util/Collection;Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Plus(System.Collections.ICollection _this_plus, IIterable elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_plus);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Collection;Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000A6BC0 File Offset: 0x000A4DC0
		[Register("plus", "(Ljava/util/Collection;Lkotlin/sequences/Sequence;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Plus(System.Collections.ICollection _this_plus, ISequence elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_plus);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Collection;Lkotlin/sequences/Sequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000A6C60 File Offset: 0x000A4E60
		[Register("plus", "(Ljava/util/Collection;Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Plus(System.Collections.ICollection _this_plus, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_plus);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(element);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Collection;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060026B2 RID: 9906 RVA: 0x000A6CF8 File Offset: 0x000A4EF8
		[Register("plus", "(Ljava/util/Collection;[Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Plus(System.Collections.ICollection _this_plus, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_plus);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Collection;[Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060026B3 RID: 9907 RVA: 0x000A6D9C File Offset: 0x000A4F9C
		[Register("random", "(Ljava/util/Collection;Lkotlin/random/Random;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Random(System.Collections.ICollection _this_random, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_random);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("random.(Ljava/util/Collection;Lkotlin/random/Random;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_random);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x000A6E34 File Offset: 0x000A5034
		[Register("randomOrNull", "(Ljava/util/Collection;Lkotlin/random/Random;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object RandomOrNull(System.Collections.ICollection _this_randomOrNull, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_randomOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("randomOrNull.(Ljava/util/Collection;Lkotlin/random/Random;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_randomOrNull);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x000A6ECC File Offset: 0x000A50CC
		[Register("reduce", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Reduce(IIterable _this_reduce, IFunction2 operation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduce).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reduce.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduce);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000A6F70 File Offset: 0x000A5170
		[Register("reduceIndexed", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceIndexed(IIterable _this_reduceIndexed, IFunction3 operation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduceIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduceIndexed).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reduceIndexed.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduceIndexed);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x000A7014 File Offset: 0x000A5214
		[Register("reduceIndexedOrNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceIndexedOrNull(IIterable _this_reduceIndexedOrNull, IFunction3 operation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduceIndexedOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduceIndexedOrNull).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reduceIndexedOrNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduceIndexedOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x000A70B8 File Offset: 0x000A52B8
		[Register("reduceOrNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceOrNull(IIterable _this_reduceOrNull, IFunction2 operation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduceOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduceOrNull).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reduceOrNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduceOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000A715C File Offset: 0x000A535C
		[Register("reduceRight", "(Ljava/util/List;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceRight(System.Collections.IList _this_reduceRight, IFunction2 operation)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_reduceRight);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reduceRight.(Ljava/util/List;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceRight);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000A71FC File Offset: 0x000A53FC
		[Register("reduceRightIndexed", "(Ljava/util/List;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceRightIndexed(System.Collections.IList _this_reduceRightIndexed, IFunction3 operation)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_reduceRightIndexed);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reduceRightIndexed.(Ljava/util/List;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceRightIndexed);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x000A729C File Offset: 0x000A549C
		[Register("reduceRightIndexedOrNull", "(Ljava/util/List;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceRightIndexedOrNull(System.Collections.IList _this_reduceRightIndexedOrNull, IFunction3 operation)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_reduceRightIndexedOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reduceRightIndexedOrNull.(Ljava/util/List;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceRightIndexedOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x000A733C File Offset: 0x000A553C
		[Register("reduceRightOrNull", "(Ljava/util/List;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceRightOrNull(System.Collections.IList _this_reduceRightOrNull, IFunction2 operation)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_reduceRightOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reduceRightOrNull.(Ljava/util/List;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceRightOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000A73DC File Offset: 0x000A55DC
		[Register("requireNoNulls", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IIterable RequireNoNulls(IIterable _this_requireNoNulls)
		{
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_requireNoNulls == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_requireNoNulls).Handle);
				@object = Java.Lang.Object.GetObject<IIterable>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("requireNoNulls.(Ljava/lang/Iterable;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_requireNoNulls);
			}
			return @object;
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000A7454 File Offset: 0x000A5654
		[Register("requireNoNulls", "(Ljava/util/List;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList RequireNoNulls(System.Collections.IList _this_requireNoNulls)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_requireNoNulls);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("requireNoNulls.(Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_requireNoNulls);
			}
			return result;
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000A74C4 File Offset: 0x000A56C4
		[Register("reversed", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Reversed(IIterable _this_reversed)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reversed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reversed).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("reversed.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reversed);
			}
			return result;
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000A753C File Offset: 0x000A573C
		[Register("runningFold", "(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList RunningFold(IIterable _this_runningFold, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningFold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningFold).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("runningFold.(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_runningFold);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000A760C File Offset: 0x000A580C
		[Register("runningFoldIndexed", "(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList RunningFoldIndexed(IIterable _this_runningFoldIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningFoldIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningFoldIndexed).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("runningFoldIndexed.(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_runningFoldIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x000A76DC File Offset: 0x000A58DC
		[Register("runningReduce", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		public unsafe static System.Collections.IList RunningReduce(IIterable _this_runningReduce, IFunction2 operation)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningReduce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningReduce).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("runningReduce.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_runningReduce);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x000A7780 File Offset: 0x000A5980
		[Register("runningReduceIndexed", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		public unsafe static System.Collections.IList RunningReduceIndexed(IIterable _this_runningReduceIndexed, IFunction3 operation)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningReduceIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningReduceIndexed).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("runningReduceIndexed.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_runningReduceIndexed);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x000A7824 File Offset: 0x000A5A24
		[Register("scan", "(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList Scan(IIterable _this_scan, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_scan == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_scan).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("scan.(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_scan);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x000A78F4 File Offset: 0x000A5AF4
		[Register("scanIndexed", "(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList ScanIndexed(IIterable _this_scanIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_scanIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_scanIndexed).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("scanIndexed.(Ljava/lang/Iterable;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_scanIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x000A79C4 File Offset: 0x000A5BC4
		[Register("shuffle", "(Ljava/util/List;Lkotlin/random/Random;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void Shuffle(System.Collections.IList _this_shuffle, Kotlin.Random.Random random)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_shuffle);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("shuffle.(Ljava/util/List;Lkotlin/random/Random;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_shuffle);
				GC.KeepAlive(random);
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x000A7A4C File Offset: 0x000A5C4C
		[Register("single", "(Ljava/lang/Iterable;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Single(IIterable _this_single)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_single == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_single).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("single.(Ljava/lang/Iterable;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_single);
			}
			return @object;
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x000A7AC4 File Offset: 0x000A5CC4
		[Register("single", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Single(IIterable _this_single, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_single == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_single).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("single.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_single);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x000A7B68 File Offset: 0x000A5D68
		[Register("single", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Single(System.Collections.IList _this_single)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_single);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("single.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_single);
			}
			return @object;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000A7BD8 File Offset: 0x000A5DD8
		[Register("singleOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SingleOrNull(IIterable _this_singleOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_singleOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_singleOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("singleOrNull.(Ljava/lang/Iterable;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_singleOrNull);
			}
			return @object;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x000A7C50 File Offset: 0x000A5E50
		[Register("singleOrNull", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SingleOrNull(IIterable _this_singleOrNull, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_singleOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_singleOrNull).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("singleOrNull.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_singleOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x000A7CF4 File Offset: 0x000A5EF4
		[Register("singleOrNull", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SingleOrNull(System.Collections.IList _this_singleOrNull)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_singleOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("singleOrNull.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_singleOrNull);
			}
			return @object;
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x000A7D64 File Offset: 0x000A5F64
		[Register("slice", "(Ljava/util/List;Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Slice(System.Collections.IList _this_slice, IIterable indices)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_slice);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : ((Java.Lang.Object)indices).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("slice.(Ljava/util/List;Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_slice);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000A7E04 File Offset: 0x000A6004
		[Register("slice", "(Ljava/util/List;Lkotlin/ranges/IntRange;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Slice(System.Collections.IList _this_slice, IntRange indices)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_slice);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("slice.(Ljava/util/List;Lkotlin/ranges/IntRange;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_slice);
				GC.KeepAlive(indices);
			}
			return result;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x000A7E9C File Offset: 0x000A609C
		[Register("sortBy", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		public unsafe static void SortBy(System.Collections.IList _this_sortBy, IFunction1 selector)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_sortBy);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("sortBy.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_sortBy);
				GC.KeepAlive(selector);
			}
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000A7F2C File Offset: 0x000A612C
		[Register("sortByDescending", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		public unsafe static void SortByDescending(System.Collections.IList _this_sortByDescending, IFunction1 selector)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_sortByDescending);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("sortByDescending.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_sortByDescending);
				GC.KeepAlive(selector);
			}
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000A7FBC File Offset: 0x000A61BC
		[Register("sortDescending", "(Ljava/util/List;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static void SortDescending(System.Collections.IList _this_sortDescending)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_sortDescending);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("sortDescending.(Ljava/util/List;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_sortDescending);
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000A801C File Offset: 0x000A621C
		[Register("sorted", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static System.Collections.IList Sorted(IIterable _this_sorted)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sorted == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sorted).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("sorted.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sorted);
			}
			return result;
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x000A8094 File Offset: 0x000A6294
		[Register("sortedBy", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		public unsafe static System.Collections.IList SortedBy(IIterable _this_sortedBy, IFunction1 selector)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sortedBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sortedBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("sortedBy.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sortedBy);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x000A8138 File Offset: 0x000A6338
		[Register("sortedByDescending", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		public unsafe static System.Collections.IList SortedByDescending(IIterable _this_sortedByDescending, IFunction1 selector)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sortedByDescending == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sortedByDescending).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("sortedByDescending.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sortedByDescending);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x000A81DC File Offset: 0x000A63DC
		[Register("sortedDescending", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static System.Collections.IList SortedDescending(IIterable _this_sortedDescending)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sortedDescending == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sortedDescending).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("sortedDescending.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sortedDescending);
			}
			return result;
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x000A8254 File Offset: 0x000A6454
		[Register("sortedWith", "(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList SortedWith(IIterable _this_sortedWith, IComparator comparator)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sortedWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sortedWith).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("sortedWith.(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sortedWith);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x000A82F8 File Offset: 0x000A64F8
		[Register("subtract", "(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Subtract(IIterable _this_subtract, IIterable other)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_subtract == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_subtract).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = JavaSet.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("subtract.(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_subtract);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x000A839C File Offset: 0x000A659C
		[Obsolete("deprecated")]
		[Register("sumBy", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int SumBy(IIterable _this_sumBy, IFunction1 selector)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sumBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sumBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("sumBy.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sumBy);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x000A8434 File Offset: 0x000A6634
		[Obsolete("deprecated")]
		[Register("sumByDouble", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)D", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static double SumByDouble(IIterable _this_sumByDouble, IFunction1 selector)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sumByDouble == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sumByDouble).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("sumByDouble.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sumByDouble);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x000A84CC File Offset: 0x000A66CC
		[Register("sumOfByte", "(Ljava/lang/Iterable;)I", "")]
		public unsafe static int SumOfByte(IIterable _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("sumOfByte.(Ljava/lang/Iterable;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x000A8538 File Offset: 0x000A6738
		[Register("sumOfDouble", "(Ljava/lang/Iterable;)D", "")]
		public unsafe static double SumOfDouble(IIterable _this_sum)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeDoubleMethod("sumOfDouble.(Ljava/lang/Iterable;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000A85A4 File Offset: 0x000A67A4
		[Register("sumOfFloat", "(Ljava/lang/Iterable;)F", "")]
		public unsafe static float SumOfFloat(IIterable _this_sum)
		{
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeSingleMethod("sumOfFloat.(Ljava/lang/Iterable;)F", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x000A8610 File Offset: 0x000A6810
		[Register("sumOfInt", "(Ljava/lang/Iterable;)I", "")]
		public unsafe static int SumOfInt(IIterable _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("sumOfInt.(Ljava/lang/Iterable;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x000A867C File Offset: 0x000A687C
		[Register("sumOfLong", "(Ljava/lang/Iterable;)J", "")]
		public unsafe static long SumOfLong(IIterable _this_sum)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt64Method("sumOfLong.(Ljava/lang/Iterable;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x000A86E8 File Offset: 0x000A68E8
		[Register("sumOfShort", "(Ljava/lang/Iterable;)I", "")]
		public unsafe static int SumOfShort(IIterable _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("sumOfShort.(Ljava/lang/Iterable;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000A8754 File Offset: 0x000A6954
		[Register("take", "(Ljava/lang/Iterable;I)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Take(IIterable _this_take, int n)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_take == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_take).Handle);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("take.(Ljava/lang/Iterable;I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_take);
			}
			return result;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000A87E0 File Offset: 0x000A69E0
		[Register("takeLast", "(Ljava/util/List;I)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList TakeLast(System.Collections.IList _this_takeLast, int n)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_takeLast);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("takeLast.(Ljava/util/List;I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_takeLast);
			}
			return result;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000A8864 File Offset: 0x000A6A64
		[Register("takeLastWhile", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList TakeLastWhile(System.Collections.IList _this_takeLastWhile, IFunction1 predicate)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_takeLastWhile);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("takeLastWhile.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_takeLastWhile);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x000A8904 File Offset: 0x000A6B04
		[Register("takeWhile", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList TakeWhile(IIterable _this_takeWhile, IFunction1 predicate)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_takeWhile == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_takeWhile).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("takeWhile.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_takeWhile);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000A89A8 File Offset: 0x000A6BA8
		[Register("toBooleanArray", "(Ljava/util/Collection;)[Z", "")]
		public unsafe static bool[] ToBooleanArray(ICollection<Java.Lang.Boolean> _this_toBooleanArray)
		{
			IntPtr intPtr = JavaCollection<Java.Lang.Boolean>.ToLocalJniHandle(_this_toBooleanArray);
			bool[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (bool[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toBooleanArray.(Ljava/util/Collection;)[Z", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(bool));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toBooleanArray);
			}
			return result;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x000A8A28 File Offset: 0x000A6C28
		[Register("toByteArray", "(Ljava/util/Collection;)[B", "")]
		public unsafe static byte[] ToByteArray(ICollection<Java.Lang.Byte> _this_toByteArray)
		{
			IntPtr intPtr = JavaCollection<Java.Lang.Byte>.ToLocalJniHandle(_this_toByteArray);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toByteArray.(Ljava/util/Collection;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toByteArray);
			}
			return result;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x000A8AA8 File Offset: 0x000A6CA8
		[Register("toCharArray", "(Ljava/util/Collection;)[C", "")]
		public unsafe static char[] ToCharArray(ICollection<Character> _this_toCharArray)
		{
			IntPtr intPtr = JavaCollection<Character>.ToLocalJniHandle(_this_toCharArray);
			char[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (char[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toCharArray.(Ljava/util/Collection;)[C", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(char));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toCharArray);
			}
			return result;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x000A8B28 File Offset: 0x000A6D28
		[Register("toCollection", "(Ljava/lang/Iterable;Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object ToCollection(IIterable _this_toCollection, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toCollection == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toCollection).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toCollection.(Ljava/lang/Iterable;Ljava/util/Collection;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toCollection);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x000A8BC8 File Offset: 0x000A6DC8
		[Register("toDoubleArray", "(Ljava/util/Collection;)[D", "")]
		public unsafe static double[] ToDoubleArray(ICollection<Java.Lang.Double> _this_toDoubleArray)
		{
			IntPtr intPtr = JavaCollection<Java.Lang.Double>.ToLocalJniHandle(_this_toDoubleArray);
			double[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (double[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toDoubleArray.(Ljava/util/Collection;)[D", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(double));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toDoubleArray);
			}
			return result;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000A8C48 File Offset: 0x000A6E48
		[Register("toFloatArray", "(Ljava/util/Collection;)[F", "")]
		public unsafe static float[] ToFloatArray(ICollection<Float> _this_toFloatArray)
		{
			IntPtr intPtr = JavaCollection<Float>.ToLocalJniHandle(_this_toFloatArray);
			float[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (float[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toFloatArray.(Ljava/util/Collection;)[F", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(float));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toFloatArray);
			}
			return result;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000A8CC8 File Offset: 0x000A6EC8
		[Register("toHashSet", "(Ljava/lang/Iterable;)Ljava/util/HashSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static HashSet ToHashSet(IIterable _this_toHashSet)
		{
			HashSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toHashSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toHashSet).Handle);
				@object = Java.Lang.Object.GetObject<HashSet>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toHashSet.(Ljava/lang/Iterable;)Ljava/util/HashSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toHashSet);
			}
			return @object;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000A8D40 File Offset: 0x000A6F40
		[Register("toIntArray", "(Ljava/util/Collection;)[I", "")]
		public unsafe static int[] ToIntArray(ICollection<Integer> _this_toIntArray)
		{
			IntPtr intPtr = JavaCollection<Integer>.ToLocalJniHandle(_this_toIntArray);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (int[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toIntArray.(Ljava/util/Collection;)[I", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toIntArray);
			}
			return result;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000A8DC0 File Offset: 0x000A6FC0
		[Register("toList", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ToList(IIterable _this_toList)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toList == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toList).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toList.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toList);
			}
			return result;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000A8E38 File Offset: 0x000A7038
		[Register("toLongArray", "(Ljava/util/Collection;)[J", "")]
		public unsafe static long[] ToLongArray(ICollection<Long> _this_toLongArray)
		{
			IntPtr intPtr = JavaCollection<Long>.ToLocalJniHandle(_this_toLongArray);
			long[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (long[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toLongArray.(Ljava/util/Collection;)[J", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toLongArray);
			}
			return result;
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000A8EB8 File Offset: 0x000A70B8
		[Register("toMutableList", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ToMutableList(IIterable _this_toMutableList)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMutableList == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMutableList).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toMutableList.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toMutableList);
			}
			return result;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000A8F30 File Offset: 0x000A7130
		[Register("toMutableList", "(Ljava/util/Collection;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ToMutableList(System.Collections.ICollection _this_toMutableList)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_toMutableList);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toMutableList.(Ljava/util/Collection;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toMutableList);
			}
			return result;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000A8FA0 File Offset: 0x000A71A0
		[Register("toMutableSet", "(Ljava/lang/Iterable;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection ToMutableSet(IIterable _this_toMutableSet)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMutableSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMutableSet).Handle);
				result = JavaSet.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toMutableSet.(Ljava/lang/Iterable;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toMutableSet);
			}
			return result;
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000A9018 File Offset: 0x000A7218
		[Register("toSet", "(Ljava/lang/Iterable;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection ToSet(IIterable _this_toSet)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toSet).Handle);
				result = JavaSet.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toSet.(Ljava/lang/Iterable;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toSet);
			}
			return result;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000A9090 File Offset: 0x000A7290
		[Register("toShortArray", "(Ljava/util/Collection;)[S", "")]
		public unsafe static short[] ToShortArray(ICollection<Short> _this_toShortArray)
		{
			IntPtr intPtr = JavaCollection<Short>.ToLocalJniHandle(_this_toShortArray);
			short[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (short[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toShortArray.(Ljava/util/Collection;)[S", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toShortArray);
			}
			return result;
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000A9110 File Offset: 0x000A7310
		[Register("union", "(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection Union(IIterable _this_union, IIterable other)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_union == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_union).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = JavaSet.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("union.(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_union);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000A91B4 File Offset: 0x000A73B4
		[Register("windowed", "(Ljava/lang/Iterable;IIZ)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IList<System.Collections.IList> Windowed(IIterable _this_windowed, int size, int step, bool partialWindows)
		{
			IList<System.Collections.IList> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_windowed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_windowed).Handle);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue(partialWindows);
				result = JavaList<System.Collections.IList>.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("windowed.(Ljava/lang/Iterable;IIZ)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_windowed);
			}
			return result;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x000A926C File Offset: 0x000A746C
		[Register("windowed", "(Ljava/lang/Iterable;IIZLkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList Windowed(IIterable _this_windowed, int size, int step, bool partialWindows, IFunction1 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_windowed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_windowed).Handle);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue(partialWindows);
				ptr[4] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("windowed.(Ljava/lang/Iterable;IIZLkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_windowed);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000A9358 File Offset: 0x000A7558
		[Register("withIndex", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IIterable WithIndex(IIterable _this_withIndex)
		{
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_withIndex == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_withIndex).Handle);
				@object = Java.Lang.Object.GetObject<IIterable>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("withIndex.(Ljava/lang/Iterable;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_withIndex);
			}
			return @object;
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000A93D0 File Offset: 0x000A75D0
		[Register("zip", "(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList Zip(IIterable _this_zip, IIterable other)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zip).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("zip.(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x000A9474 File Offset: 0x000A7674
		[Register("zip", "(Ljava/lang/Iterable;Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"V"
		})]
		public unsafe static System.Collections.IList Zip(IIterable _this_zip, IIterable other, IFunction2 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zip).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("zip.(Ljava/lang/Iterable;Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x000A9548 File Offset: 0x000A7748
		[Register("zip", "(Ljava/lang/Iterable;[Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList Zip(IIterable _this_zip, Java.Lang.Object[] other)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(other);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zip).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("zip.(Ljava/lang/Iterable;[Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x000A95F0 File Offset: 0x000A77F0
		[Register("zip", "(Ljava/lang/Iterable;[Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"V"
		})]
		public unsafe static System.Collections.IList Zip(IIterable _this_zip, Java.Lang.Object[] other, IFunction2 transform)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(other);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zip).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("zip.(Ljava/lang/Iterable;[Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (other != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, other);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x000A96C8 File Offset: 0x000A78C8
		[Register("zipWithNext", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ZipWithNext(IIterable _this_zipWithNext)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zipWithNext == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zipWithNext).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("zipWithNext.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zipWithNext);
			}
			return result;
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x000A9740 File Offset: 0x000A7940
		[Register("zipWithNext", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static System.Collections.IList ZipWithNext(IIterable _this_zipWithNext, IFunction2 transform)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zipWithNext == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zipWithNext).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("zipWithNext.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zipWithNext);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x000A97E4 File Offset: 0x000A79E4
		[Register("filterIsInstance", "(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList FilterIsInstance(IIterable _this_filterIsInstance, Class klass)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIsInstance == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIsInstance).Handle);
				ptr[1] = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterIsInstance.(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterIsInstance);
				GC.KeepAlive(klass);
			}
			return result;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000A9884 File Offset: 0x000A7A84
		[Register("filterIsInstanceTo", "(Ljava/lang/Iterable;Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"C extends java.util.Collection<? super R>",
			"R"
		})]
		public unsafe static Java.Lang.Object FilterIsInstanceTo(IIterable _this_filterIsInstanceTo, Java.Lang.Object destination, Class klass)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIsInstanceTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIsInstanceTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("filterIsInstanceTo.(Ljava/lang/Iterable;Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterIsInstanceTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(klass);
			}
			return @object;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x000A994C File Offset: 0x000A7B4C
		[Register("reverse", "(Ljava/util/List;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void Reverse(System.Collections.IList _this_reverse)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_reverse);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("reverse.(Ljava/util/List;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reverse);
			}
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000A99AC File Offset: 0x000A7BAC
		[Register("toSortedSet", "(Ljava/lang/Iterable;)Ljava/util/SortedSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static ISortedSet ToSortedSet(IIterable _this_toSortedSet)
		{
			ISortedSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toSortedSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toSortedSet).Handle);
				@object = Java.Lang.Object.GetObject<ISortedSet>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toSortedSet.(Ljava/lang/Iterable;)Ljava/util/SortedSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toSortedSet);
			}
			return @object;
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x000A9A24 File Offset: 0x000A7C24
		[Register("toSortedSet", "(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/util/SortedSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISortedSet ToSortedSet(IIterable _this_toSortedSet, IComparator comparator)
		{
			ISortedSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toSortedSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toSortedSet).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<ISortedSet>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("toSortedSet.(Ljava/lang/Iterable;Ljava/util/Comparator;)Ljava/util/SortedSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toSortedSet);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000A9AC8 File Offset: 0x000A7CC8
		[Register("asReversed", "(Ljava/util/List;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList AsReversed(System.Collections.IList _this_asReversed)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_asReversed);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("asReversed.(Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_asReversed);
			}
			return result;
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000A9B38 File Offset: 0x000A7D38
		[Register("asReversedMutable", "(Ljava/util/List;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList AsReversedMutable(System.Collections.IList _this_asReversed)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_asReversed);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("asReversedMutable.(Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_asReversed);
			}
			return result;
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000A9BA8 File Offset: 0x000A7DA8
		[Register("addAll", "(Ljava/util/Collection;Ljava/lang/Iterable;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool AddAll(System.Collections.ICollection _this_addAll, IIterable elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_addAll);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("addAll.(Ljava/util/Collection;Ljava/lang/Iterable;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_addAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000A9C38 File Offset: 0x000A7E38
		[Register("addAll", "(Ljava/util/Collection;Lkotlin/sequences/Sequence;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool AddAll(System.Collections.ICollection _this_addAll, ISequence elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_addAll);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("addAll.(Ljava/util/Collection;Lkotlin/sequences/Sequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_addAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000A9CC8 File Offset: 0x000A7EC8
		[Register("addAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool AddAll(System.Collections.ICollection _this_addAll, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_addAll);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("addAll.(Ljava/util/Collection;[Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, elements);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_addAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000A9D5C File Offset: 0x000A7F5C
		[Register("convertToListIfNotCollection", "(Ljava/lang/Iterable;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection ConvertToListIfNotCollection(IIterable _this_convertToListIfNotCollection)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_convertToListIfNotCollection == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_convertToListIfNotCollection).Handle);
				result = JavaCollection.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("convertToListIfNotCollection.(Ljava/lang/Iterable;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_convertToListIfNotCollection);
			}
			return result;
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x000A9DD4 File Offset: 0x000A7FD4
		[Register("removeAll", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RemoveAll(IIterable _this_removeAll, IFunction1 predicate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_removeAll == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_removeAll).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("removeAll.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_removeAll);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000A9E6C File Offset: 0x000A806C
		[Register("removeAll", "(Ljava/util/Collection;Ljava/lang/Iterable;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RemoveAll(System.Collections.ICollection _this_removeAll, IIterable elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_removeAll);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("removeAll.(Ljava/util/Collection;Ljava/lang/Iterable;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000A9EFC File Offset: 0x000A80FC
		[Register("removeAll", "(Ljava/util/Collection;Lkotlin/sequences/Sequence;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RemoveAll(System.Collections.ICollection _this_removeAll, ISequence elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_removeAll);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("removeAll.(Ljava/util/Collection;Lkotlin/sequences/Sequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x000A9F8C File Offset: 0x000A818C
		[Register("removeAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RemoveAll(System.Collections.ICollection _this_removeAll, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_removeAll);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("removeAll.(Ljava/util/Collection;[Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, elements);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_removeAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x000AA020 File Offset: 0x000A8220
		[Register("removeAll", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RemoveAll(System.Collections.IList _this_removeAll, IFunction1 predicate)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_removeAll);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("removeAll.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeAll);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x000AA0B0 File Offset: 0x000A82B0
		[Register("removeFirst", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object RemoveFirst(System.Collections.IList _this_removeFirst)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_removeFirst);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("removeFirst.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeFirst);
			}
			return @object;
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x000AA120 File Offset: 0x000A8320
		[Register("removeFirstOrNull", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object RemoveFirstOrNull(System.Collections.IList _this_removeFirstOrNull)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_removeFirstOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("removeFirstOrNull.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeFirstOrNull);
			}
			return @object;
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000AA190 File Offset: 0x000A8390
		[Register("removeLast", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object RemoveLast(System.Collections.IList _this_removeLast)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_removeLast);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("removeLast.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeLast);
			}
			return @object;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x000AA200 File Offset: 0x000A8400
		[Register("removeLastOrNull", "(Ljava/util/List;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object RemoveLastOrNull(System.Collections.IList _this_removeLastOrNull)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_removeLastOrNull);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("removeLastOrNull.(Ljava/util/List;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeLastOrNull);
			}
			return @object;
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x000AA270 File Offset: 0x000A8470
		[Register("retainAll", "(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RetainAll(IIterable _this_retainAll, IFunction1 predicate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_retainAll == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_retainAll).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("retainAll.(Ljava/lang/Iterable;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_retainAll);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000AA308 File Offset: 0x000A8508
		[Register("retainAll", "(Ljava/util/Collection;Ljava/lang/Iterable;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RetainAll(System.Collections.ICollection _this_retainAll, IIterable elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_retainAll);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("retainAll.(Ljava/util/Collection;Ljava/lang/Iterable;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_retainAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x000AA398 File Offset: 0x000A8598
		[Register("retainAll", "(Ljava/util/Collection;Lkotlin/sequences/Sequence;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RetainAll(System.Collections.ICollection _this_retainAll, ISequence elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_retainAll);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("retainAll.(Ljava/util/Collection;Lkotlin/sequences/Sequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_retainAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000AA428 File Offset: 0x000A8628
		[Register("retainAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RetainAll(System.Collections.ICollection _this_retainAll, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(_this_retainAll);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("retainAll.(Ljava/util/Collection;[Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, elements);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_retainAll);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000AA4BC File Offset: 0x000A86BC
		[Register("retainAll", "(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool RetainAll(System.Collections.IList _this_retainAll, IFunction1 predicate)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_retainAll);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeBooleanMethod("retainAll.(Ljava/util/List;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_retainAll);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000AA54C File Offset: 0x000A874C
		[Register("sort", "(Ljava/util/List;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static void Sort(System.Collections.IList _this_sort)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_sort);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("sort.(Ljava/util/List;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_sort);
			}
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000AA5AC File Offset: 0x000A87AC
		[Register("sortWith", "(Ljava/util/List;Ljava/util/Comparator;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void SortWith(System.Collections.IList _this_sortWith, IComparator comparator)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_sortWith);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("sortWith.(Ljava/util/List;Ljava/util/Comparator;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_sortWith);
				GC.KeepAlive(comparator);
			}
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000AA63C File Offset: 0x000A883C
		[Register("forEach", "(Ljava/util/Iterator;Lkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void ForEach(IIterator _this_forEach, IFunction1 operation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_forEach).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				CollectionsKt._members.StaticMethods.InvokeVoidMethod("forEach.(Ljava/util/Iterator;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEach);
				GC.KeepAlive(operation);
			}
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000AA6D0 File Offset: 0x000A88D0
		[Register("withIndex", "(Ljava/util/Iterator;)Ljava/util/Iterator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IIterator WithIndex(IIterator _this_withIndex)
		{
			IIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_withIndex == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_withIndex).Handle);
				@object = Java.Lang.Object.GetObject<IIterator>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("withIndex.(Ljava/util/Iterator;)Ljava/util/Iterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_withIndex);
			}
			return @object;
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000AA748 File Offset: 0x000A8948
		[Register("iterator", "(Ljava/util/Enumeration;)Ljava/util/Iterator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IIterator Iterator(IEnumeration _this_iterator)
		{
			IIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_iterator == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_iterator).Handle);
				@object = Java.Lang.Object.GetObject<IIterator>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("iterator.(Ljava/util/Enumeration;)Ljava/util/Iterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_iterator);
			}
			return @object;
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000AA7C0 File Offset: 0x000A89C0
		[Register("collectionSizeOrDefault", "(Ljava/lang/Iterable;I)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int CollectionSizeOrDefault(IIterable _this_collectionSizeOrDefault, int @default)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_collectionSizeOrDefault == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_collectionSizeOrDefault).Handle);
				ptr[1] = new JniArgumentValue(@default);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("collectionSizeOrDefault.(Ljava/lang/Iterable;I)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_collectionSizeOrDefault);
			}
			return result;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000AA83C File Offset: 0x000A8A3C
		[Register("collectionSizeOrNull", "(Ljava/lang/Iterable;)Ljava/lang/Integer;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Integer CollectionSizeOrNull(IIterable _this_collectionSizeOrNull)
		{
			Integer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_collectionSizeOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_collectionSizeOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Integer>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("collectionSizeOrNull.(Ljava/lang/Iterable;)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_collectionSizeOrNull);
			}
			return @object;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000AA8B4 File Offset: 0x000A8AB4
		[Register("flatten", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Flatten(IIterable _this_flatten)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatten == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatten).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("flatten.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatten);
			}
			return result;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000AA92C File Offset: 0x000A8B2C
		[Register("unzip", "(Ljava/lang/Iterable;)Lkotlin/Pair;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static Pair Unzip(IIterable _this_unzip)
		{
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_unzip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_unzip).Handle);
				@object = Java.Lang.Object.GetObject<Pair>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("unzip.(Ljava/lang/Iterable;)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_unzip);
			}
			return @object;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000AA9A4 File Offset: 0x000A8BA4
		[Register("arrayListOf", "([Ljava/lang/Object;)Ljava/util/ArrayList;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ArrayListOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("arrayListOf.([Ljava/lang/Object;)Ljava/util/ArrayList;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002720 RID: 10016 RVA: 0x000AAA20 File Offset: 0x000A8C20
		[Register("asCollection", "([Ljava/lang/Object;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection AsCollection(Java.Lang.Object[] _this_asCollection)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(_this_asCollection);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaCollection.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("asCollection.([Ljava/lang/Object;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_asCollection != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, _this_asCollection);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_asCollection);
			}
			return result;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000AAA9C File Offset: 0x000A8C9C
		[Register("binarySearch", "(Ljava/util/List;IILkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int BinarySearch(System.Collections.IList _this_binarySearch, int fromIndex, int toIndex, IFunction1 comparison)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_binarySearch);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				ptr[3] = new JniArgumentValue((comparison == null) ? IntPtr.Zero : ((Java.Lang.Object)comparison).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("binarySearch.(Ljava/util/List;IILkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_binarySearch);
				GC.KeepAlive(comparison);
			}
			return result;
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000AAB58 File Offset: 0x000A8D58
		[Register("binarySearch", "(Ljava/util/List;Ljava/lang/Comparable;II)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static int BinarySearch(System.Collections.IList _this_binarySearch, [Nullable(2)] Java.Lang.Object element, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_binarySearch);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("binarySearch.(Ljava/util/List;Ljava/lang/Comparable;II)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_binarySearch);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000AAC0C File Offset: 0x000A8E0C
		[Register("binarySearch", "(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;II)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int BinarySearch(System.Collections.IList _this_binarySearch, [Nullable(2)] Java.Lang.Object element, IComparator comparator, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_binarySearch);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				ptr[3] = new JniArgumentValue(fromIndex);
				ptr[4] = new JniArgumentValue(toIndex);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("binarySearch.(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;II)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_binarySearch);
				GC.KeepAlive(element);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000AACF4 File Offset: 0x000A8EF4
		[Register("binarySearchBy", "(Ljava/util/List;Ljava/lang/Comparable;IILkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K extends java.lang.Comparable<? super K>"
		})]
		public unsafe static int BinarySearchBy(System.Collections.IList _this_binarySearchBy, [Nullable(2)] Java.Lang.Object key, int fromIndex, int toIndex, IFunction1 selector)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_binarySearchBy);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(key);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				ptr[4] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("binarySearchBy.(Ljava/util/List;Ljava/lang/Comparable;IILkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_binarySearchBy);
				GC.KeepAlive(key);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000AADDC File Offset: 0x000A8FDC
		[Register("emptyList", "()Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static System.Collections.IList EmptyList()
		{
			return JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("emptyList.()Ljava/util/List;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000AAE10 File Offset: 0x000A9010
		[Register("getIndices", "(Ljava/util/Collection;)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange GetIndices(ICollection<object> _this_indices)
		{
			IntPtr intPtr = JavaCollection<object>.ToLocalJniHandle(_this_indices);
			IntRange @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IntRange>(CollectionsKt._members.StaticMethods.InvokeObjectMethod("getIndices.(Ljava/util/Collection;)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indices);
			}
			return @object;
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000AAE80 File Offset: 0x000A9080
		[Register("getLastIndex", "(Ljava/util/List;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int GetLastIndex(System.Collections.IList _this_lastIndex)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_lastIndex);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = CollectionsKt._members.StaticMethods.InvokeInt32Method("getLastIndex.(Ljava/util/List;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastIndex);
			}
			return result;
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000AAEE4 File Offset: 0x000A90E4
		[Register("listOf", "([Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ListOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("listOf.([Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002729 RID: 10025 RVA: 0x000AAF60 File Offset: 0x000A9160
		[Register("listOfNotNull", "(Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ListOfNotNull([Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("listOfNotNull.(Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x000AAFD0 File Offset: 0x000A91D0
		[Register("listOfNotNull", "([Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ListOfNotNull(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("listOfNotNull.([Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600272B RID: 10027 RVA: 0x000AB04C File Offset: 0x000A924C
		[Register("mutableListOf", "([Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList MutableListOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("mutableListOf.([Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600272C RID: 10028 RVA: 0x000AB0C8 File Offset: 0x000A92C8
		[Register("optimizeReadOnlyList", "(Ljava/util/List;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList OptimizeReadOnlyList(System.Collections.IList _this_optimizeReadOnlyList)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(_this_optimizeReadOnlyList);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("optimizeReadOnlyList.(Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_optimizeReadOnlyList);
			}
			return result;
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000AB138 File Offset: 0x000A9338
		[Register("shuffled", "(Ljava/lang/Iterable;Lkotlin/random/Random;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Shuffled(IIterable _this_shuffled, Kotlin.Random.Random random)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_shuffled == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_shuffled).Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("shuffled.(Ljava/lang/Iterable;Lkotlin/random/Random;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_shuffled);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000AB1D8 File Offset: 0x000A93D8
		[Register("throwCountOverflow", "()V", "")]
		public static void ThrowCountOverflow()
		{
			CollectionsKt._members.StaticMethods.InvokeVoidMethod("throwCountOverflow.()V", null);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000AB1F0 File Offset: 0x000A93F0
		[Register("throwIndexOverflow", "()V", "")]
		public static void ThrowIndexOverflow()
		{
			CollectionsKt._members.StaticMethods.InvokeVoidMethod("throwIndexOverflow.()V", null);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000AB208 File Offset: 0x000A9408
		[Register("build", "(Ljava/util/List;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static System.Collections.IList Build(System.Collections.IList builder)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(builder);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("build.(Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(builder);
			}
			return result;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000AB278 File Offset: 0x000A9478
		[Register("copyToArrayOfAny", "([Ljava/lang/Object;Z)[Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object[] CopyToArrayOfAny(Java.Lang.Object[] _this_copyToArrayOfAny, bool isVarargs)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(_this_copyToArrayOfAny);
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(isVarargs);
				result = (Java.Lang.Object[])JNIEnv.GetArray(CollectionsKt._members.StaticMethods.InvokeObjectMethod("copyToArrayOfAny.([Ljava/lang/Object;Z)[Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				if (_this_copyToArrayOfAny != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, _this_copyToArrayOfAny);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_copyToArrayOfAny);
			}
			return result;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000AB314 File Offset: 0x000A9514
		[Register("createListBuilder", "()Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public static System.Collections.IList CreateListBuilder()
		{
			return JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("createListBuilder.()Ljava/util/List;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000AB348 File Offset: 0x000A9548
		[Register("createListBuilder", "(I)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static System.Collections.IList CreateListBuilder(int capacity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(capacity);
			return JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("createListBuilder.(I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000AB390 File Offset: 0x000A9590
		[Register("listOf", "(Ljava/lang/Object;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ListOf([Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("listOf.(Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000AB400 File Offset: 0x000A9600
		[Register("shuffled", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Shuffled(IIterable _this_shuffled)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_shuffled == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_shuffled).Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("shuffled.(Ljava/lang/Iterable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_shuffled);
			}
			return result;
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000AB478 File Offset: 0x000A9678
		[Register("shuffled", "(Ljava/lang/Iterable;Ljava/util/Random;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList Shuffled(IIterable _this_shuffled, Java.Util.Random random)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_shuffled == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_shuffled).Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = JavaList.FromJniHandle(CollectionsKt._members.StaticMethods.InvokeObjectMethod("shuffled.(Ljava/lang/Iterable;Ljava/util/Random;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_shuffled);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x0400099E RID: 2462
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/CollectionsKt", typeof(CollectionsKt));
	}
}
