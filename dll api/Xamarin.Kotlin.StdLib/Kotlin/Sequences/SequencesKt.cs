using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Collections;
using Kotlin.Jvm.Functions;
using Kotlin.Random;

namespace Kotlin.Sequences
{
	// Token: 0x020000FA RID: 250
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/sequences/SequencesKt", DoNotGenerateAcw = true)]
	public sealed class SequencesKt : Java.Lang.Object
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0002214C File Offset: 0x0002034C
		internal static IntPtr class_ref
		{
			get
			{
				return SequencesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00022170 File Offset: 0x00020370
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SequencesKt._members;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00022178 File Offset: 0x00020378
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SequencesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0002219C File Offset: 0x0002039C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SequencesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000221A8 File Offset: 0x000203A8
		internal SequencesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000221B4 File Offset: 0x000203B4
		[Register("all", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool All(ISequence _this_all, IFunction1 predicate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_all == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_all).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = SequencesKt._members.StaticMethods.InvokeBooleanMethod("all.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_all);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0002224C File Offset: 0x0002044C
		[Register("any", "(Lkotlin/sequences/Sequence;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool Any(ISequence _this_any)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_any == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_any).Handle);
				result = SequencesKt._members.StaticMethods.InvokeBooleanMethod("any.(Lkotlin/sequences/Sequence;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_any);
			}
			return result;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000222B8 File Offset: 0x000204B8
		[Register("any", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool Any(ISequence _this_any, IFunction1 predicate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_any == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_any).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = SequencesKt._members.StaticMethods.InvokeBooleanMethod("any.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_any);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00022350 File Offset: 0x00020550
		[Register("asIterable", "(Lkotlin/sequences/Sequence;)Ljava/lang/Iterable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IIterable AsIterable(ISequence _this_asIterable)
		{
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asIterable == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asIterable).Handle);
				@object = Java.Lang.Object.GetObject<IIterable>(SequencesKt._members.StaticMethods.InvokeObjectMethod("asIterable.(Lkotlin/sequences/Sequence;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asIterable);
			}
			return @object;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000223C8 File Offset: 0x000205C8
		[Register("associate", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V"
		})]
		public unsafe static IDictionary Associate(ISequence _this_associate, IFunction1 transform)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associate == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associate).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaDictionary.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("associate.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_associate);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002246C File Offset: 0x0002066C
		[Register("associateBy", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static IDictionary AssociateBy(ISequence _this_associateBy, IFunction1 keySelector)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				result = JavaDictionary.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("associateBy.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_associateBy);
				GC.KeepAlive(keySelector);
			}
			return result;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00022510 File Offset: 0x00020710
		[Register("associateBy", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V"
		})]
		public unsafe static IDictionary AssociateBy(ISequence _this_associateBy, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[2] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				result = JavaDictionary.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("associateBy.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_associateBy);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return result;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000225E4 File Offset: 0x000207E4
		[Register("associateByTo", "(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"M extends java.util.Map<? super K, ? super T>"
		})]
		public unsafe static Java.Lang.Object AssociateByTo(ISequence _this_associateByTo, Java.Lang.Object destination, IFunction1 keySelector)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateByTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateByTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("associateByTo.(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A36 RID: 2614 RVA: 0x000226B4 File Offset: 0x000208B4
		[Register("associateByTo", "(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateByTo(ISequence _this_associateByTo, Java.Lang.Object destination, IFunction1 keySelector, IFunction1 valueTransform)
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("associateByTo.(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A37 RID: 2615 RVA: 0x000227B4 File Offset: 0x000209B4
		[Register("associateTo", "(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateTo(ISequence _this_associateTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("associateTo.(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A38 RID: 2616 RVA: 0x00022884 File Offset: 0x00020A84
		[Register("associateWith", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary AssociateWith(ISequence _this_associateWith, IFunction1 valueSelector)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateWith).Handle);
				ptr[1] = new JniArgumentValue((valueSelector == null) ? IntPtr.Zero : ((Java.Lang.Object)valueSelector).Handle);
				result = JavaDictionary.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("associateWith.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_associateWith);
				GC.KeepAlive(valueSelector);
			}
			return result;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00022928 File Offset: 0x00020B28
		[Register("associateWithTo", "(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateWithTo(ISequence _this_associateWithTo, Java.Lang.Object destination, IFunction1 valueSelector)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_associateWithTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_associateWithTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((valueSelector == null) ? IntPtr.Zero : ((Java.Lang.Object)valueSelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("associateWithTo.(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A3A RID: 2618 RVA: 0x000229F8 File Offset: 0x00020BF8
		[Register("averageOfByte", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double AverageOfByte(ISequence _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("averageOfByte.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00022A64 File Offset: 0x00020C64
		[Register("averageOfDouble", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double AverageOfDouble(ISequence _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("averageOfDouble.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00022AD0 File Offset: 0x00020CD0
		[Register("averageOfFloat", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double AverageOfFloat(ISequence _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("averageOfFloat.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00022B3C File Offset: 0x00020D3C
		[Register("averageOfInt", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double AverageOfInt(ISequence _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("averageOfInt.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00022BA8 File Offset: 0x00020DA8
		[Register("averageOfLong", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double AverageOfLong(ISequence _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("averageOfLong.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00022C14 File Offset: 0x00020E14
		[Register("averageOfShort", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double AverageOfShort(ISequence _this_average)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_average == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_average).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("averageOfShort.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_average);
			}
			return result;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00022C80 File Offset: 0x00020E80
		[Register("chunked", "(Lkotlin/sequences/Sequence;I)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Chunked(ISequence _this_chunked, int size)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_chunked == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_chunked).Handle);
				ptr[1] = new JniArgumentValue(size);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("chunked.(Lkotlin/sequences/Sequence;I)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_chunked);
			}
			return @object;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00022D0C File Offset: 0x00020F0C
		[Register("chunked", "(Lkotlin/sequences/Sequence;ILkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence Chunked(ISequence _this_chunked, int size, IFunction1 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_chunked == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_chunked).Handle);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("chunked.(Lkotlin/sequences/Sequence;ILkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_chunked);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00022DC8 File Offset: 0x00020FC8
		[Register("contains", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool Contains(ISequence _this_contains, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = SequencesKt._members.StaticMethods.InvokeBooleanMethod("contains.(Lkotlin/sequences/Sequence;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_contains);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00022E58 File Offset: 0x00021058
		[Register("count", "(Lkotlin/sequences/Sequence;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int Count(ISequence _this_count)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_count == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_count).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("count.(Lkotlin/sequences/Sequence;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_count);
			}
			return result;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00022EC4 File Offset: 0x000210C4
		[Register("count", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int Count(ISequence _this_count, IFunction1 predicate)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_count == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_count).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("count.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_count);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00022F5C File Offset: 0x0002115C
		[Register("distinct", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Distinct(ISequence _this_distinct)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_distinct == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_distinct).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("distinct.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_distinct);
			}
			return @object;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00022FD4 File Offset: 0x000211D4
		[Register("distinctBy", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static ISequence DistinctBy(ISequence _this_distinctBy, IFunction1 selector)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_distinctBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_distinctBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("distinctBy.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_distinctBy);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00023078 File Offset: 0x00021278
		[Register("drop", "(Lkotlin/sequences/Sequence;I)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Drop(ISequence _this_drop, int n)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_drop == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_drop).Handle);
				ptr[1] = new JniArgumentValue(n);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("drop.(Lkotlin/sequences/Sequence;I)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_drop);
			}
			return @object;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00023104 File Offset: 0x00021304
		[Register("dropWhile", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence DropWhile(ISequence _this_dropWhile, IFunction1 predicate)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_dropWhile == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_dropWhile).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("dropWhile.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_dropWhile);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000231A8 File Offset: 0x000213A8
		[Register("elementAt", "(Lkotlin/sequences/Sequence;I)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ElementAt(ISequence _this_elementAt, int index)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_elementAt == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_elementAt).Handle);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("elementAt.(Lkotlin/sequences/Sequence;I)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_elementAt);
			}
			return @object;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00023234 File Offset: 0x00021434
		[Register("elementAtOrElse", "(Lkotlin/sequences/Sequence;ILkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ElementAtOrElse(ISequence _this_elementAtOrElse, int index, IFunction1 defaultValue)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_elementAtOrElse == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_elementAtOrElse).Handle);
				ptr[1] = new JniArgumentValue(index);
				ptr[2] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("elementAtOrElse.(Lkotlin/sequences/Sequence;ILkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_elementAtOrElse);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000232F0 File Offset: 0x000214F0
		[Register("elementAtOrNull", "(Lkotlin/sequences/Sequence;I)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ElementAtOrNull(ISequence _this_elementAtOrNull, int index)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_elementAtOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_elementAtOrNull).Handle);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("elementAtOrNull.(Lkotlin/sequences/Sequence;I)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_elementAtOrNull);
			}
			return @object;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002337C File Offset: 0x0002157C
		[Register("filter", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Filter(ISequence _this_filter, IFunction1 predicate)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filter == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filter).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filter.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filter);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00023420 File Offset: 0x00021620
		[Register("filterIndexed", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence FilterIndexed(ISequence _this_filterIndexed, IFunction2 predicate)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIndexed).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterIndexed.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterIndexed);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000234C4 File Offset: 0x000216C4
		[Register("filterIndexedTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object FilterIndexedTo(ISequence _this_filterIndexedTo, Java.Lang.Object destination, IFunction2 predicate)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIndexedTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIndexedTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterIndexedTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A4F RID: 2639 RVA: 0x00023594 File Offset: 0x00021794
		[Register("filterNot", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence FilterNot(ISequence _this_filterNot, IFunction1 predicate)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNot == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNot).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterNot.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterNot);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00023638 File Offset: 0x00021838
		[Register("filterNotNull", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence FilterNotNull(ISequence _this_filterNotNull)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNotNull).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterNotNull.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterNotNull);
			}
			return @object;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000236B0 File Offset: 0x000218B0
		[Register("filterNotNullTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"C extends java.util.Collection<? super T>",
			"T"
		})]
		public unsafe static Java.Lang.Object FilterNotNullTo(ISequence _this_filterNotNullTo, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNotNullTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNotNullTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterNotNullTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterNotNullTo);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00023750 File Offset: 0x00021950
		[Register("filterNotTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object FilterNotTo(ISequence _this_filterNotTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNotTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNotTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterNotTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A53 RID: 2643 RVA: 0x00023820 File Offset: 0x00021A20
		[Register("filterTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object FilterTo(ISequence _this_filterTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A54 RID: 2644 RVA: 0x000238F0 File Offset: 0x00021AF0
		[Register("first", "(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object First(ISequence _this_first)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_first).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("first.(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_first);
			}
			return @object;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00023968 File Offset: 0x00021B68
		[Register("first", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object First(ISequence _this_first, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_first).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("first.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_first);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00023A0C File Offset: 0x00021C0C
		[Register("firstOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FirstOrNull(ISequence _this_firstOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_firstOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00023A84 File Offset: 0x00021C84
		[Register("firstOrNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FirstOrNull(ISequence _this_firstOrNull, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_firstOrNull).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00023B28 File Offset: 0x00021D28
		[Register("flatMap", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence FlatMap(ISequence _this_flatMap, IFunction1 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMap).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flatMap.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMap);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00023BCC File Offset: 0x00021DCC
		[Register("flatMapIndexedIterable", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence FlatMapIndexedIterable(ISequence _this_flatMapIndexed, IFunction2 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapIndexed).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flatMapIndexedIterable.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMapIndexed);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00023C70 File Offset: 0x00021E70
		[Register("flatMapIndexedSequence", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence FlatMapIndexedSequence(ISequence _this_flatMapIndexed, IFunction2 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapIndexed).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flatMapIndexedSequence.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMapIndexed);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00023D14 File Offset: 0x00021F14
		[Register("flatMapIterable", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence FlatMapIterable(ISequence _this_flatMap, IFunction1 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMap).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flatMapIterable.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMap);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00023DB8 File Offset: 0x00021FB8
		[Register("flatMapIterableTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object FlatMapIterableTo(ISequence _this_flatMapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flatMapIterableTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A5D RID: 2653 RVA: 0x00023E88 File Offset: 0x00022088
		[Register("flatMapTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object FlatMapTo(ISequence _this_flatMapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flatMapTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A5E RID: 2654 RVA: 0x00023F58 File Offset: 0x00022158
		[Register("fold", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(ISequence _this_fold, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_fold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_fold).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A5F RID: 2655 RVA: 0x00024028 File Offset: 0x00022228
		[Register("foldIndexed", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FoldIndexed(ISequence _this_foldIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_foldIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_foldIndexed).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("foldIndexed.(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A60 RID: 2656 RVA: 0x000240F8 File Offset: 0x000222F8
		[Register("forEach", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void ForEach(ISequence _this_forEach, IFunction1 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_forEach).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				SequencesKt._members.StaticMethods.InvokeVoidMethod("forEach.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEach);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0002418C File Offset: 0x0002238C
		[Register("forEachIndexed", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void ForEachIndexed(ISequence _this_forEachIndexed, IFunction2 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEachIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_forEachIndexed).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				SequencesKt._members.StaticMethods.InvokeVoidMethod("forEachIndexed.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEachIndexed);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00024220 File Offset: 0x00022420
		[Register("groupBy", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static IDictionary GroupBy(ISequence _this_groupBy, IFunction1 keySelector)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				result = JavaDictionary.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("groupBy.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_groupBy);
				GC.KeepAlive(keySelector);
			}
			return result;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x000242C4 File Offset: 0x000224C4
		[Register("groupBy", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V"
		})]
		public unsafe static IDictionary GroupBy(ISequence _this_groupBy, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[2] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				result = JavaDictionary.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("groupBy.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_groupBy);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return result;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00024398 File Offset: 0x00022598
		[Register("groupByTo", "(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"M extends java.util.Map<? super K, java.util.List<T>>"
		})]
		public unsafe static Java.Lang.Object GroupByTo(ISequence _this_groupByTo, Java.Lang.Object destination, IFunction1 keySelector)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupByTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupByTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("groupByTo.(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A65 RID: 2661 RVA: 0x00024468 File Offset: 0x00022668
		[Register("groupByTo", "(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"V",
			"M extends java.util.Map<? super K, java.util.List<V>>"
		})]
		public unsafe static Java.Lang.Object GroupByTo(ISequence _this_groupByTo, Java.Lang.Object destination, IFunction1 keySelector, IFunction1 valueTransform)
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("groupByTo.(Lkotlin/sequences/Sequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A66 RID: 2662 RVA: 0x00024568 File Offset: 0x00022768
		[Register("groupingBy", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/collections/Grouping;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static IGrouping GroupingBy(ISequence _this_groupingBy, IFunction1 keySelector)
		{
			IGrouping @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_groupingBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_groupingBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<IGrouping>(SequencesKt._members.StaticMethods.InvokeObjectMethod("groupingBy.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/collections/Grouping;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_groupingBy);
				GC.KeepAlive(keySelector);
			}
			return @object;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002460C File Offset: 0x0002280C
		[Register("indexOf", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOf(ISequence _this_indexOf, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_indexOf == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_indexOf).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("indexOf.(Lkotlin/sequences/Sequence;Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indexOf);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002469C File Offset: 0x0002289C
		[Register("indexOfFirst", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOfFirst(ISequence _this_indexOfFirst, IFunction1 predicate)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_indexOfFirst == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_indexOfFirst).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("indexOfFirst.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_indexOfFirst);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00024734 File Offset: 0x00022934
		[Register("indexOfLast", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int IndexOfLast(ISequence _this_indexOfLast, IFunction1 predicate)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_indexOfLast == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_indexOfLast).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("indexOfLast.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_indexOfLast);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000247CC File Offset: 0x000229CC
		[Register("joinTo", "(Lkotlin/sequences/Sequence;Ljava/lang/Appendable;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ILjava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Appendable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"A extends java.lang.Appendable"
		})]
		public unsafe static Java.Lang.Object JoinTo(ISequence _this_joinTo, Java.Lang.Object buffer, ICharSequence separator, ICharSequence prefix, ICharSequence postfix, int limit, ICharSequence truncated, [Nullable(2)] IFunction1 transform)
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("joinTo.(Lkotlin/sequences/Sequence;Ljava/lang/Appendable;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ILjava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Appendable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A6B RID: 2667 RVA: 0x00024978 File Offset: 0x00022B78
		public static Java.Lang.Object JoinTo(ISequence _this_joinTo, Java.Lang.Object buffer, string separator, string prefix, string postfix, int limit, string truncated, [Nullable(2)] IFunction1 transform)
		{
			Java.Lang.String @string = (separator == null) ? null : new Java.Lang.String(separator);
			Java.Lang.String string2 = (prefix == null) ? null : new Java.Lang.String(prefix);
			Java.Lang.String string3 = (postfix == null) ? null : new Java.Lang.String(postfix);
			Java.Lang.String string4 = (truncated == null) ? null : new Java.Lang.String(truncated);
			Java.Lang.Object result = SequencesKt.JoinTo(_this_joinTo, buffer, @string, string2, string3, limit, string4, transform);
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

		// Token: 0x06000A6C RID: 2668 RVA: 0x000249F0 File Offset: 0x00022BF0
		[Register("joinToString", "(Lkotlin/sequences/Sequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ILjava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/String;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static string JoinToString(ISequence _this_joinToString, ICharSequence separator, ICharSequence prefix, ICharSequence postfix, int limit, ICharSequence truncated, [Nullable(2)] IFunction1 transform)
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
				@string = JNIEnv.GetString(SequencesKt._members.StaticMethods.InvokeObjectMethod("joinToString.(Lkotlin/sequences/Sequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ILjava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A6D RID: 2669 RVA: 0x00024B60 File Offset: 0x00022D60
		public static string JoinToString(ISequence _this_joinToString, string separator, string prefix, string postfix, int limit, string truncated, [Nullable(2)] IFunction1 transform)
		{
			Java.Lang.String @string = (separator == null) ? null : new Java.Lang.String(separator);
			Java.Lang.String string2 = (prefix == null) ? null : new Java.Lang.String(prefix);
			Java.Lang.String string3 = (postfix == null) ? null : new Java.Lang.String(postfix);
			Java.Lang.String string4 = (truncated == null) ? null : new Java.Lang.String(truncated);
			string result = SequencesKt.JoinToString(_this_joinToString, @string, string2, string3, limit, string4, transform);
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

		// Token: 0x06000A6E RID: 2670 RVA: 0x00024BD8 File Offset: 0x00022DD8
		[Register("last", "(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Last(ISequence _this_last)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_last).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("last.(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_last);
			}
			return @object;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00024C50 File Offset: 0x00022E50
		[Register("last", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Last(ISequence _this_last, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_last).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("last.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_last);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00024CF4 File Offset: 0x00022EF4
		[Register("lastIndexOf", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int LastIndexOf(ISequence _this_lastIndexOf, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastIndexOf == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_lastIndexOf).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("lastIndexOf.(Lkotlin/sequences/Sequence;Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastIndexOf);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00024D84 File Offset: 0x00022F84
		[Register("lastOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object LastOrNull(ISequence _this_lastOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_lastOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00024DFC File Offset: 0x00022FFC
		[Register("lastOrNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object LastOrNull(ISequence _this_lastOrNull, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_lastOrNull).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00024EA0 File Offset: 0x000230A0
		[Register("map", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence Map(ISequence _this_map, IFunction1 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_map == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_map).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("map.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_map);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00024F44 File Offset: 0x00023144
		[Register("mapIndexed", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence MapIndexed(ISequence _this_mapIndexed, IFunction2 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexed).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("mapIndexed.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapIndexed);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00024FE8 File Offset: 0x000231E8
		[Register("mapIndexedNotNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence MapIndexedNotNull(ISequence _this_mapIndexedNotNull, IFunction2 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexedNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexedNotNull).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("mapIndexedNotNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapIndexedNotNull);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0002508C File Offset: 0x0002328C
		[Register("mapIndexedNotNullTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapIndexedNotNullTo(ISequence _this_mapIndexedNotNullTo, Java.Lang.Object destination, IFunction2 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexedNotNullTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexedNotNullTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("mapIndexedNotNullTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A77 RID: 2679 RVA: 0x0002515C File Offset: 0x0002335C
		[Register("mapIndexedTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapIndexedTo(ISequence _this_mapIndexedTo, Java.Lang.Object destination, IFunction2 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexedTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexedTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("mapIndexedTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002522C File Offset: 0x0002342C
		[Register("mapNotNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence MapNotNull(ISequence _this_mapNotNull, IFunction1 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapNotNull).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("mapNotNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapNotNull);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000252D0 File Offset: 0x000234D0
		[Register("mapNotNullTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapNotNullTo(ISequence _this_mapNotNullTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapNotNullTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapNotNullTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("mapNotNullTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A7A RID: 2682 RVA: 0x000253A0 File Offset: 0x000235A0
		[Register("mapTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapTo(ISequence _this_mapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("mapTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000A7B RID: 2683 RVA: 0x00025470 File Offset: 0x00023670
		[Register("maxByOrNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxByOrNull(ISequence _this_maxByOrNull, IFunction1 selector)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxByOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxByOrNull).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("maxByOrNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxByOrNull);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00025514 File Offset: 0x00023714
		[Register("maxByOrThrow", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxByOrThrow(ISequence _this_maxBy, IFunction1 selector)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("maxByOrThrow.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxBy);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000255B8 File Offset: 0x000237B8
		[Register("maxOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxOrNull(ISequence _this_maxOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("maxOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxOrNull);
			}
			return @object;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00025630 File Offset: 0x00023830
		[Register("maxOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Double;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Double MaxOrNullOfDouble(ISequence _this_maxOrNull)
		{
			Java.Lang.Double @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Double>(SequencesKt._members.StaticMethods.InvokeObjectMethod("maxOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Double;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxOrNull);
			}
			return @object;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000256A8 File Offset: 0x000238A8
		[Register("maxOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Float;", "")]
		[return: Nullable(2)]
		public unsafe static Float MaxOrNullOfFloat(ISequence _this_maxOrNull)
		{
			Float @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Float>(SequencesKt._members.StaticMethods.InvokeObjectMethod("maxOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Float;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxOrNull);
			}
			return @object;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00025720 File Offset: 0x00023920
		[Register("maxOrThrow", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double MaxOrThrowDouble(ISequence _this_max)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_max == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_max).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("maxOrThrow.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_max);
			}
			return result;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0002578C File Offset: 0x0002398C
		[Register("maxOrThrow", "(Lkotlin/sequences/Sequence;)F", "")]
		public unsafe static float MaxOrThrowFloat(ISequence _this_max)
		{
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_max == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_max).Handle);
				result = SequencesKt._members.StaticMethods.InvokeSingleMethod("maxOrThrow.(Lkotlin/sequences/Sequence;)F", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_max);
			}
			return result;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000257F8 File Offset: 0x000239F8
		[Register("maxOrThrow", "(Lkotlin/sequences/Sequence;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MaxOrThrow(ISequence _this_max)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_max == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_max).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("maxOrThrow.(Lkotlin/sequences/Sequence;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_max);
			}
			return @object;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00025870 File Offset: 0x00023A70
		[Register("maxWithOrNull", "(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxWithOrNull(ISequence _this_maxWithOrNull, IComparator comparator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxWithOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxWithOrNull).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("maxWithOrNull.(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxWithOrNull);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00025914 File Offset: 0x00023B14
		[Register("maxWithOrThrow", "(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MaxWithOrThrow(ISequence _this_maxWith, IComparator comparator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_maxWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_maxWith).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("maxWithOrThrow.(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_maxWith);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000259B8 File Offset: 0x00023BB8
		[Register("minByOrNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinByOrNull(ISequence _this_minByOrNull, IFunction1 selector)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minByOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minByOrNull).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minByOrNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minByOrNull);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00025A5C File Offset: 0x00023C5C
		[Register("minByOrThrow", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinByOrThrow(ISequence _this_minBy, IFunction1 selector)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minByOrThrow.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minBy);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00025B00 File Offset: 0x00023D00
		[Register("minOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinOrNull(ISequence _this_minOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minOrNull);
			}
			return @object;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00025B78 File Offset: 0x00023D78
		[Register("minOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Double;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Double MinOrNullOfDouble(ISequence _this_minOrNull)
		{
			Java.Lang.Double @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Double>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Double;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minOrNull);
			}
			return @object;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00025BF0 File Offset: 0x00023DF0
		[Register("minOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Float;", "")]
		[return: Nullable(2)]
		public unsafe static Float MinOrNullOfFloat(ISequence _this_minOrNull)
		{
			Float @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Float>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Float;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minOrNull);
			}
			return @object;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00025C68 File Offset: 0x00023E68
		[Register("minOrThrow", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double MinOrThrowDouble(ISequence _this_min)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_min == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_min).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("minOrThrow.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_min);
			}
			return result;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00025CD4 File Offset: 0x00023ED4
		[Register("minOrThrow", "(Lkotlin/sequences/Sequence;)F", "")]
		public unsafe static float MinOrThrowFloat(ISequence _this_min)
		{
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_min == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_min).Handle);
				result = SequencesKt._members.StaticMethods.InvokeSingleMethod("minOrThrow.(Lkotlin/sequences/Sequence;)F", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_min);
			}
			return result;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00025D40 File Offset: 0x00023F40
		[Register("minOrThrow", "(Lkotlin/sequences/Sequence;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object MinOrThrow(ISequence _this_min)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_min == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_min).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minOrThrow.(Lkotlin/sequences/Sequence;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_min);
			}
			return @object;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00025DB8 File Offset: 0x00023FB8
		[Register("minWithOrNull", "(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinWithOrNull(ISequence _this_minWithOrNull, IComparator comparator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minWithOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minWithOrNull).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minWithOrNull.(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minWithOrNull);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00025E5C File Offset: 0x0002405C
		[Register("minWithOrThrow", "(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object MinWithOrThrow(ISequence _this_minWith, IComparator comparator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minWith).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minWithOrThrow.(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minWith);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00025F00 File Offset: 0x00024100
		[Register("minus", "(Lkotlin/sequences/Sequence;Ljava/lang/Iterable;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Minus(ISequence _this_minus, IIterable elements)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minus).Handle);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minus.(Lkotlin/sequences/Sequence;Ljava/lang/Iterable;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00025FA4 File Offset: 0x000241A4
		[Register("minus", "(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Minus(ISequence _this_minus, ISequence elements)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minus).Handle);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minus.(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00026048 File Offset: 0x00024248
		[Register("minus", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Minus(ISequence _this_minus, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minus).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minus.(Lkotlin/sequences/Sequence;Ljava/lang/Object;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(element);
			}
			return @object;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000260E8 File Offset: 0x000242E8
		[Register("minus", "(Lkotlin/sequences/Sequence;[Ljava/lang/Object;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Minus(ISequence _this_minus, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_minus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_minus).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("minus.(Lkotlin/sequences/Sequence;[Ljava/lang/Object;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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
			return @object;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00026190 File Offset: 0x00024390
		[Register("none", "(Lkotlin/sequences/Sequence;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool None(ISequence _this_none)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_none == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_none).Handle);
				result = SequencesKt._members.StaticMethods.InvokeBooleanMethod("none.(Lkotlin/sequences/Sequence;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_none);
			}
			return result;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000261FC File Offset: 0x000243FC
		[Register("none", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool None(ISequence _this_none, IFunction1 predicate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_none == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_none).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = SequencesKt._members.StaticMethods.InvokeBooleanMethod("none.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_none);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00026294 File Offset: 0x00024494
		[Register("onEach", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence OnEach(ISequence _this_onEach, IFunction1 action)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onEach).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("onEach.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onEach);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00026338 File Offset: 0x00024538
		[Register("onEachIndexed", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence OnEachIndexed(ISequence _this_onEachIndexed, IFunction2 action)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onEachIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onEachIndexed).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("onEachIndexed.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onEachIndexed);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000263DC File Offset: 0x000245DC
		[Register("partition", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/Pair;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Pair Partition(ISequence _this_partition, IFunction1 predicate)
		{
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_partition == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_partition).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Pair>(SequencesKt._members.StaticMethods.InvokeObjectMethod("partition.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_partition);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00026480 File Offset: 0x00024680
		[Register("plus", "(Lkotlin/sequences/Sequence;Ljava/lang/Iterable;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Plus(ISequence _this_plus, IIterable elements)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_plus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_plus).Handle);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlin/sequences/Sequence;Ljava/lang/Iterable;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00026524 File Offset: 0x00024724
		[Register("plus", "(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Plus(ISequence _this_plus, ISequence elements)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_plus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_plus).Handle);
				ptr[1] = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000265C8 File Offset: 0x000247C8
		[Register("plus", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Plus(ISequence _this_plus, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_plus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_plus).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlin/sequences/Sequence;Ljava/lang/Object;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(element);
			}
			return @object;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00026668 File Offset: 0x00024868
		[Register("plus", "(Lkotlin/sequences/Sequence;[Ljava/lang/Object;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Plus(ISequence _this_plus, Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_plus == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_plus).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlin/sequences/Sequence;[Ljava/lang/Object;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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
			return @object;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00026710 File Offset: 0x00024910
		[Register("reduce", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Reduce(ISequence _this_reduce, IFunction2 operation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduce).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("reduce.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduce);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000267B4 File Offset: 0x000249B4
		[Register("reduceIndexed", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceIndexed(ISequence _this_reduceIndexed, IFunction3 operation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduceIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduceIndexed).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("reduceIndexed.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduceIndexed);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00026858 File Offset: 0x00024A58
		[Register("reduceIndexedOrNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceIndexedOrNull(ISequence _this_reduceIndexedOrNull, IFunction3 operation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduceIndexedOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduceIndexedOrNull).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("reduceIndexedOrNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduceIndexedOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000268FC File Offset: 0x00024AFC
		[Register("reduceOrNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReduceOrNull(ISequence _this_reduceOrNull, IFunction2 operation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduceOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduceOrNull).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("reduceOrNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduceOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000269A0 File Offset: 0x00024BA0
		[Register("requireNoNulls", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence RequireNoNulls(ISequence _this_requireNoNulls)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_requireNoNulls == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_requireNoNulls).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("requireNoNulls.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_requireNoNulls);
			}
			return @object;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00026A18 File Offset: 0x00024C18
		[Register("runningFold", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence RunningFold(ISequence _this_runningFold, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningFold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningFold).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("runningFold.(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_runningFold);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00026AE8 File Offset: 0x00024CE8
		[Register("runningFoldIndexed", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence RunningFoldIndexed(ISequence _this_runningFoldIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningFoldIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningFoldIndexed).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("runningFoldIndexed.(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_runningFoldIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00026BB8 File Offset: 0x00024DB8
		[Register("runningReduce", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		public unsafe static ISequence RunningReduce(ISequence _this_runningReduce, IFunction2 operation)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningReduce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningReduce).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("runningReduce.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_runningReduce);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00026C5C File Offset: 0x00024E5C
		[Register("runningReduceIndexed", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function3;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		public unsafe static ISequence RunningReduceIndexed(ISequence _this_runningReduceIndexed, IFunction3 operation)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningReduceIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningReduceIndexed).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("runningReduceIndexed.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function3;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_runningReduceIndexed);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00026D00 File Offset: 0x00024F00
		[Register("scan", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence Scan(ISequence _this_scan, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_scan == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_scan).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("scan.(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_scan);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00026DD0 File Offset: 0x00024FD0
		[Register("scanIndexed", "(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence ScanIndexed(ISequence _this_scanIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_scanIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_scanIndexed).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("scanIndexed.(Lkotlin/sequences/Sequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_scanIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00026EA0 File Offset: 0x000250A0
		[Register("single", "(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Single(ISequence _this_single)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_single == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_single).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("single.(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_single);
			}
			return @object;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00026F18 File Offset: 0x00025118
		[Register("single", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Single(ISequence _this_single, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_single == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_single).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("single.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_single);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00026FBC File Offset: 0x000251BC
		[Register("singleOrNull", "(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SingleOrNull(ISequence _this_singleOrNull)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_singleOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_singleOrNull).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("singleOrNull.(Lkotlin/sequences/Sequence;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_singleOrNull);
			}
			return @object;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00027034 File Offset: 0x00025234
		[Register("singleOrNull", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SingleOrNull(ISequence _this_singleOrNull, IFunction1 predicate)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_singleOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_singleOrNull).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("singleOrNull.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_singleOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000270D8 File Offset: 0x000252D8
		[Register("sorted", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static ISequence Sorted(ISequence _this_sorted)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sorted == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sorted).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("sorted.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sorted);
			}
			return @object;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00027150 File Offset: 0x00025350
		[Register("sortedBy", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		public unsafe static ISequence SortedBy(ISequence _this_sortedBy, IFunction1 selector)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sortedBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sortedBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("sortedBy.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sortedBy);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000271F4 File Offset: 0x000253F4
		[Register("sortedByDescending", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R extends java.lang.Comparable<? super R>"
		})]
		public unsafe static ISequence SortedByDescending(ISequence _this_sortedByDescending, IFunction1 selector)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sortedByDescending == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sortedByDescending).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("sortedByDescending.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sortedByDescending);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00027298 File Offset: 0x00025498
		[Register("sortedDescending", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static ISequence SortedDescending(ISequence _this_sortedDescending)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sortedDescending == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sortedDescending).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("sortedDescending.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sortedDescending);
			}
			return @object;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00027310 File Offset: 0x00025510
		[Register("sortedWith", "(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence SortedWith(ISequence _this_sortedWith, IComparator comparator)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sortedWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sortedWith).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("sortedWith.(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sortedWith);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x000273B4 File Offset: 0x000255B4
		[Obsolete("deprecated")]
		[Register("sumBy", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static int SumBy(ISequence _this_sumBy, IFunction1 selector)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sumBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sumBy).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("sumBy.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sumBy);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0002744C File Offset: 0x0002564C
		[Obsolete("deprecated")]
		[Register("sumByDouble", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)D", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static double SumByDouble(ISequence _this_sumByDouble, IFunction1 selector)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sumByDouble == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sumByDouble).Handle);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("sumByDouble.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sumByDouble);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000274E4 File Offset: 0x000256E4
		[Register("sumOfByte", "(Lkotlin/sequences/Sequence;)I", "")]
		public unsafe static int SumOfByte(ISequence _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("sumOfByte.(Lkotlin/sequences/Sequence;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00027550 File Offset: 0x00025750
		[Register("sumOfDouble", "(Lkotlin/sequences/Sequence;)D", "")]
		public unsafe static double SumOfDouble(ISequence _this_sum)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = SequencesKt._members.StaticMethods.InvokeDoubleMethod("sumOfDouble.(Lkotlin/sequences/Sequence;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x000275BC File Offset: 0x000257BC
		[Register("sumOfFloat", "(Lkotlin/sequences/Sequence;)F", "")]
		public unsafe static float SumOfFloat(ISequence _this_sum)
		{
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = SequencesKt._members.StaticMethods.InvokeSingleMethod("sumOfFloat.(Lkotlin/sequences/Sequence;)F", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00027628 File Offset: 0x00025828
		[Register("sumOfInt", "(Lkotlin/sequences/Sequence;)I", "")]
		public unsafe static int SumOfInt(ISequence _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("sumOfInt.(Lkotlin/sequences/Sequence;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00027694 File Offset: 0x00025894
		[Register("sumOfLong", "(Lkotlin/sequences/Sequence;)J", "")]
		public unsafe static long SumOfLong(ISequence _this_sum)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt64Method("sumOfLong.(Lkotlin/sequences/Sequence;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00027700 File Offset: 0x00025900
		[Register("sumOfShort", "(Lkotlin/sequences/Sequence;)I", "")]
		public unsafe static int SumOfShort(ISequence _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = SequencesKt._members.StaticMethods.InvokeInt32Method("sumOfShort.(Lkotlin/sequences/Sequence;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002776C File Offset: 0x0002596C
		[Register("take", "(Lkotlin/sequences/Sequence;I)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Take(ISequence _this_take, int n)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_take == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_take).Handle);
				ptr[1] = new JniArgumentValue(n);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("take.(Lkotlin/sequences/Sequence;I)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_take);
			}
			return @object;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000277F8 File Offset: 0x000259F8
		[Register("takeWhile", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence TakeWhile(ISequence _this_takeWhile, IFunction1 predicate)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_takeWhile == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_takeWhile).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("takeWhile.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_takeWhile);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0002789C File Offset: 0x00025A9C
		[Register("toCollection", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object ToCollection(ISequence _this_toCollection, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toCollection == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toCollection).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("toCollection.(Lkotlin/sequences/Sequence;Ljava/util/Collection;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toCollection);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0002793C File Offset: 0x00025B3C
		[Register("toHashSet", "(Lkotlin/sequences/Sequence;)Ljava/util/HashSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static HashSet ToHashSet(ISequence _this_toHashSet)
		{
			HashSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toHashSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toHashSet).Handle);
				@object = Java.Lang.Object.GetObject<HashSet>(SequencesKt._members.StaticMethods.InvokeObjectMethod("toHashSet.(Lkotlin/sequences/Sequence;)Ljava/util/HashSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toHashSet);
			}
			return @object;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x000279B4 File Offset: 0x00025BB4
		[Register("toList", "(Lkotlin/sequences/Sequence;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ToList(ISequence _this_toList)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toList == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toList).Handle);
				result = JavaList.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("toList.(Lkotlin/sequences/Sequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toList);
			}
			return result;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00027A2C File Offset: 0x00025C2C
		[Register("toMutableList", "(Lkotlin/sequences/Sequence;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ToMutableList(ISequence _this_toMutableList)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMutableList == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMutableList).Handle);
				result = JavaList.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("toMutableList.(Lkotlin/sequences/Sequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toMutableList);
			}
			return result;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00027AA4 File Offset: 0x00025CA4
		[Register("toMutableSet", "(Lkotlin/sequences/Sequence;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection ToMutableSet(ISequence _this_toMutableSet)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMutableSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMutableSet).Handle);
				result = JavaSet.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("toMutableSet.(Lkotlin/sequences/Sequence;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toMutableSet);
			}
			return result;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00027B1C File Offset: 0x00025D1C
		[Register("toSet", "(Lkotlin/sequences/Sequence;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection ToSet(ISequence _this_toSet)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toSet).Handle);
				result = JavaSet.FromJniHandle(SequencesKt._members.StaticMethods.InvokeObjectMethod("toSet.(Lkotlin/sequences/Sequence;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toSet);
			}
			return result;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00027B94 File Offset: 0x00025D94
		[Register("windowed", "(Lkotlin/sequences/Sequence;IIZ)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Windowed(ISequence _this_windowed, int size, int step, bool partialWindows)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_windowed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_windowed).Handle);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue(partialWindows);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("windowed.(Lkotlin/sequences/Sequence;IIZ)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_windowed);
			}
			return @object;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00027C4C File Offset: 0x00025E4C
		[Register("windowed", "(Lkotlin/sequences/Sequence;IIZLkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence Windowed(ISequence _this_windowed, int size, int step, bool partialWindows, IFunction1 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_windowed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_windowed).Handle);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue(partialWindows);
				ptr[4] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("windowed.(Lkotlin/sequences/Sequence;IIZLkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_windowed);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00027D38 File Offset: 0x00025F38
		[Register("withIndex", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence WithIndex(ISequence _this_withIndex)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_withIndex == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_withIndex).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("withIndex.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_withIndex);
			}
			return @object;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00027DB0 File Offset: 0x00025FB0
		[Register("zip", "(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence Zip(ISequence _this_zip, ISequence other)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zip).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("zip.(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00027E54 File Offset: 0x00026054
		[Register("zip", "(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R",
			"V"
		})]
		public unsafe static ISequence Zip(ISequence _this_zip, ISequence other, IFunction2 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zip).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("zip.(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00027F28 File Offset: 0x00026128
		[Register("zipWithNext", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence ZipWithNext(ISequence _this_zipWithNext)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zipWithNext == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zipWithNext).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("zipWithNext.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zipWithNext);
			}
			return @object;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00027FA0 File Offset: 0x000261A0
		[Register("zipWithNext", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static ISequence ZipWithNext(ISequence _this_zipWithNext, IFunction2 transform)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zipWithNext == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zipWithNext).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("zipWithNext.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zipWithNext);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00028044 File Offset: 0x00026244
		[Register("filterIsInstance", "(Lkotlin/sequences/Sequence;Ljava/lang/Class;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static ISequence FilterIsInstance(ISequence _this_filterIsInstance, Class klass)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIsInstance == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIsInstance).Handle);
				ptr[1] = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterIsInstance.(Lkotlin/sequences/Sequence;Ljava/lang/Class;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterIsInstance);
				GC.KeepAlive(klass);
			}
			return @object;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000280E4 File Offset: 0x000262E4
		[Register("filterIsInstanceTo", "(Lkotlin/sequences/Sequence;Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"C extends java.util.Collection<? super R>",
			"R"
		})]
		public unsafe static Java.Lang.Object FilterIsInstanceTo(ISequence _this_filterIsInstanceTo, Java.Lang.Object destination, Class klass)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIsInstanceTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIsInstanceTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequencesKt._members.StaticMethods.InvokeObjectMethod("filterIsInstanceTo.(Lkotlin/sequences/Sequence;Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000281AC File Offset: 0x000263AC
		[Register("toSortedSet", "(Lkotlin/sequences/Sequence;)Ljava/util/SortedSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static ISortedSet ToSortedSet(ISequence _this_toSortedSet)
		{
			ISortedSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toSortedSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toSortedSet).Handle);
				@object = Java.Lang.Object.GetObject<ISortedSet>(SequencesKt._members.StaticMethods.InvokeObjectMethod("toSortedSet.(Lkotlin/sequences/Sequence;)Ljava/util/SortedSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toSortedSet);
			}
			return @object;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00028224 File Offset: 0x00026424
		[Register("toSortedSet", "(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/util/SortedSet;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISortedSet ToSortedSet(ISequence _this_toSortedSet, IComparator comparator)
		{
			ISortedSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toSortedSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toSortedSet).Handle);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<ISortedSet>(SequencesKt._members.StaticMethods.InvokeObjectMethod("toSortedSet.(Lkotlin/sequences/Sequence;Ljava/util/Comparator;)Ljava/util/SortedSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toSortedSet);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000282C8 File Offset: 0x000264C8
		[Register("asSequence", "(Ljava/util/Iterator;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence AsSequence(IIterator _this_asSequence)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asSequence == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asSequence).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("asSequence.(Ljava/util/Iterator;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asSequence);
			}
			return @object;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00028340 File Offset: 0x00026540
		[Register("constrainOnce", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence ConstrainOnce(ISequence _this_constrainOnce)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_constrainOnce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_constrainOnce).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("constrainOnce.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_constrainOnce);
			}
			return @object;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000283B8 File Offset: 0x000265B8
		[Register("emptySequence", "()Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static ISequence EmptySequence()
		{
			return Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("emptySequence.()Lkotlin/sequences/Sequence;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000283EC File Offset: 0x000265EC
		[Register("flatMapIndexed", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C",
			"R"
		})]
		public unsafe static ISequence FlatMapIndexed(ISequence source, IFunction2 transform, IFunction1 iterator)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : ((Java.Lang.Object)source).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				ptr[2] = new JniArgumentValue((iterator == null) ? IntPtr.Zero : ((Java.Lang.Object)iterator).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flatMapIndexed.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(transform);
				GC.KeepAlive(iterator);
			}
			return @object;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000284C0 File Offset: 0x000266C0
		[Register("flatten", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Flatten(ISequence _this_flatten)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatten == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatten).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flatten.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatten);
			}
			return @object;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00028538 File Offset: 0x00026738
		[Register("flattenSequenceOfIterable", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence FlattenSequenceOfIterable(ISequence _this_flatten)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatten == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatten).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("flattenSequenceOfIterable.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatten);
			}
			return @object;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000285B0 File Offset: 0x000267B0
		[Register("generateSequence", "(Lkotlin/jvm/functions/Function0;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence GenerateSequence(IFunction0 nextFunction)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((nextFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)nextFunction).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("generateSequence.(Lkotlin/jvm/functions/Function0;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(nextFunction);
			}
			return @object;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00028628 File Offset: 0x00026828
		[Register("generateSequence", "(Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence GenerateSequence(IFunction0 seedFunction, IFunction1 nextFunction)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((seedFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)seedFunction).Handle);
				ptr[1] = new JniArgumentValue((nextFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)nextFunction).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("generateSequence.(Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(seedFunction);
				GC.KeepAlive(nextFunction);
			}
			return @object;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000286CC File Offset: 0x000268CC
		[Register("generateSequence", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence GenerateSequence([Nullable(2)] Java.Lang.Object seed, IFunction1 nextFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(seed);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((nextFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)nextFunction).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("generateSequence.(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(seed);
				GC.KeepAlive(nextFunction);
			}
			return @object;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0002876C File Offset: 0x0002696C
		[Register("ifEmpty", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function0;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence IfEmpty(ISequence _this_ifEmpty, IFunction0 defaultValue)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_ifEmpty == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_ifEmpty).Handle);
				ptr[1] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("ifEmpty.(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function0;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_ifEmpty);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00028810 File Offset: 0x00026A10
		[Register("sequenceOf", "([Ljava/lang/Object;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence SequenceOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("sequenceOf.([Ljava/lang/Object;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0002888C File Offset: 0x00026A8C
		[Register("shuffled", "(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Shuffled(ISequence _this_shuffled)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_shuffled == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_shuffled).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("shuffled.(Lkotlin/sequences/Sequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_shuffled);
			}
			return @object;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00028904 File Offset: 0x00026B04
		[Register("shuffled", "(Lkotlin/sequences/Sequence;Lkotlin/random/Random;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Shuffled(ISequence _this_shuffled, Kotlin.Random.Random random)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_shuffled == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_shuffled).Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("shuffled.(Lkotlin/sequences/Sequence;Lkotlin/random/Random;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_shuffled);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000289A4 File Offset: 0x00026BA4
		[Register("unzip", "(Lkotlin/sequences/Sequence;)Lkotlin/Pair;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static Pair Unzip(ISequence _this_unzip)
		{
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_unzip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_unzip).Handle);
				@object = Java.Lang.Object.GetObject<Pair>(SequencesKt._members.StaticMethods.InvokeObjectMethod("unzip.(Lkotlin/sequences/Sequence;)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_unzip);
			}
			return @object;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00028A1C File Offset: 0x00026C1C
		[Register("iterator", "(Lkotlin/jvm/functions/Function2;)Ljava/util/Iterator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IIterator Iterator(IFunction2 block)
		{
			IIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IIterator>(SequencesKt._members.StaticMethods.InvokeObjectMethod("iterator.(Lkotlin/jvm/functions/Function2;)Ljava/util/Iterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00028A94 File Offset: 0x00026C94
		[Register("sequence", "(Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence Sequence(IFunction2 block)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(SequencesKt._members.StaticMethods.InvokeObjectMethod("sequence.(Lkotlin/jvm/functions/Function2;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x04000266 RID: 614
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/sequences/SequencesKt", typeof(SequencesKt));
	}
}
