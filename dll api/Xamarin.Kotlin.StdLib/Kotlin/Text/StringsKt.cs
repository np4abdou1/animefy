using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Math;
using Java.Util;
using Java.Util.Regex;
using Kotlin.Collections;
using Kotlin.Jvm.Functions;
using Kotlin.Random;
using Kotlin.Ranges;
using Kotlin.Sequences;

namespace Kotlin.Text
{
	// Token: 0x020000EC RID: 236
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/StringsKt", DoNotGenerateAcw = true)]
	public sealed class StringsKt : Java.Lang.Object
	{
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00015410 File Offset: 0x00013610
		internal static IntPtr class_ref
		{
			get
			{
				return StringsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00015434 File Offset: 0x00013634
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StringsKt._members;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x0001543C File Offset: 0x0001363C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StringsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00015460 File Offset: 0x00013660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StringsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0001546C File Offset: 0x0001366C
		internal StringsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00015478 File Offset: 0x00013678
		[Register("all", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Z", "")]
		public unsafe static bool All(ICharSequence _this_all, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_all);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("all.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_all);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00015508 File Offset: 0x00013708
		public static bool All(string _this_all, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_all == null) ? null : new Java.Lang.String(_this_all);
			bool result = StringsKt.All(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00015534 File Offset: 0x00013734
		[Register("any", "(Ljava/lang/CharSequence;)Z", "")]
		public unsafe static bool Any(ICharSequence _this_any)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_any);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("any.(Ljava/lang/CharSequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_any);
			}
			return result;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00015598 File Offset: 0x00013798
		public static bool Any(string _this_any)
		{
			Java.Lang.String @string = (_this_any == null) ? null : new Java.Lang.String(_this_any);
			bool result = StringsKt.Any(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000155C4 File Offset: 0x000137C4
		[Register("any", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Z", "")]
		public unsafe static bool Any(ICharSequence _this_any, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_any);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("any.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_any);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00015654 File Offset: 0x00013854
		public static bool Any(string _this_any, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_any == null) ? null : new Java.Lang.String(_this_any);
			bool result = StringsKt.Any(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00015680 File Offset: 0x00013880
		[Register("asIterable", "(Ljava/lang/CharSequence;)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable AsIterable(ICharSequence _this_asIterable)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_asIterable);
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterable>(StringsKt._members.StaticMethods.InvokeObjectMethod("asIterable.(Ljava/lang/CharSequence;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_asIterable);
			}
			return @object;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000156F0 File Offset: 0x000138F0
		public static IIterable AsIterable(string _this_asIterable)
		{
			Java.Lang.String @string = (_this_asIterable == null) ? null : new Java.Lang.String(_this_asIterable);
			IIterable result = StringsKt.AsIterable(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0001571C File Offset: 0x0001391C
		[Register("asSequence", "(Ljava/lang/CharSequence;)Lkotlin/sequences/Sequence;", "")]
		public unsafe static ISequence AsSequence(ICharSequence _this_asSequence)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_asSequence);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("asSequence.(Ljava/lang/CharSequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_asSequence);
			}
			return @object;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0001578C File Offset: 0x0001398C
		public static ISequence AsSequence(string _this_asSequence)
		{
			Java.Lang.String @string = (_this_asSequence == null) ? null : new Java.Lang.String(_this_asSequence);
			ISequence result = StringsKt.AsSequence(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000157B8 File Offset: 0x000139B8
		[Register("associate", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Associate(ICharSequence _this_associate, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_associate);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaDictionary.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("associate.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_associate);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00015858 File Offset: 0x00013A58
		public static IDictionary Associate(string _this_associate, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_associate == null) ? null : new Java.Lang.String(_this_associate);
			IDictionary result = StringsKt.Associate(@string, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00015884 File Offset: 0x00013A84
		[Register("associateBy", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K"
		})]
		public unsafe static IDictionary AssociateBy(ICharSequence _this_associateBy, IFunction1 keySelector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_associateBy);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				result = JavaDictionary.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("associateBy.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_associateBy);
				GC.KeepAlive(keySelector);
			}
			return result;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00015924 File Offset: 0x00013B24
		public static IDictionary AssociateBy(string _this_associateBy, IFunction1 keySelector)
		{
			Java.Lang.String @string = (_this_associateBy == null) ? null : new Java.Lang.String(_this_associateBy);
			IDictionary result = StringsKt.AssociateBy(@string, keySelector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00015950 File Offset: 0x00013B50
		[Register("associateBy", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary AssociateBy(ICharSequence _this_associateBy, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_associateBy);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[2] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				result = JavaDictionary.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("associateBy.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_associateBy);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return result;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00015A20 File Offset: 0x00013C20
		public static IDictionary AssociateBy(string _this_associateBy, IFunction1 keySelector, IFunction1 valueTransform)
		{
			Java.Lang.String @string = (_this_associateBy == null) ? null : new Java.Lang.String(_this_associateBy);
			IDictionary result = StringsKt.AssociateBy(@string, keySelector, valueTransform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00015A4C File Offset: 0x00013C4C
		[Register("associateByTo", "(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"M extends java.util.Map<? super K, ? super java.lang.Character>"
		})]
		public unsafe static Java.Lang.Object AssociateByTo(ICharSequence _this_associateByTo, Java.Lang.Object destination, IFunction1 keySelector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_associateByTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("associateByTo.(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_associateByTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(keySelector);
			}
			return @object;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00015B14 File Offset: 0x00013D14
		public static Java.Lang.Object AssociateByTo(string _this_associateByTo, Java.Lang.Object destination, IFunction1 keySelector)
		{
			Java.Lang.String @string = (_this_associateByTo == null) ? null : new Java.Lang.String(_this_associateByTo);
			Java.Lang.Object result = StringsKt.AssociateByTo(@string, destination, keySelector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00015B40 File Offset: 0x00013D40
		[Register("associateByTo", "(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateByTo(ICharSequence _this_associateByTo, Java.Lang.Object destination, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_associateByTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[3] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("associateByTo.(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_associateByTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return @object;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00015C38 File Offset: 0x00013E38
		public static Java.Lang.Object AssociateByTo(string _this_associateByTo, Java.Lang.Object destination, IFunction1 keySelector, IFunction1 valueTransform)
		{
			Java.Lang.String @string = (_this_associateByTo == null) ? null : new Java.Lang.String(_this_associateByTo);
			Java.Lang.Object result = StringsKt.AssociateByTo(@string, destination, keySelector, valueTransform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00015C64 File Offset: 0x00013E64
		[Register("associateTo", "(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateTo(ICharSequence _this_associateTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_associateTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("associateTo.(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_associateTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00015D2C File Offset: 0x00013F2C
		public static Java.Lang.Object AssociateTo(string _this_associateTo, Java.Lang.Object destination, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_associateTo == null) ? null : new Java.Lang.String(_this_associateTo);
			Java.Lang.Object result = StringsKt.AssociateTo(@string, destination, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00015D58 File Offset: 0x00013F58
		[Register("associateWith", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"V"
		})]
		public unsafe static IDictionary AssociateWith(ICharSequence _this_associateWith, IFunction1 valueSelector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_associateWith);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((valueSelector == null) ? IntPtr.Zero : ((Java.Lang.Object)valueSelector).Handle);
				result = JavaDictionary.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("associateWith.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_associateWith);
				GC.KeepAlive(valueSelector);
			}
			return result;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00015DF8 File Offset: 0x00013FF8
		public static IDictionary AssociateWith(string _this_associateWith, IFunction1 valueSelector)
		{
			Java.Lang.String @string = (_this_associateWith == null) ? null : new Java.Lang.String(_this_associateWith);
			IDictionary result = StringsKt.AssociateWith(@string, valueSelector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00015E24 File Offset: 0x00014024
		[Register("associateWithTo", "(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"V",
			"M extends java.util.Map<? super java.lang.Character, ? super V>"
		})]
		public unsafe static Java.Lang.Object AssociateWithTo(ICharSequence _this_associateWithTo, Java.Lang.Object destination, IFunction1 valueSelector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_associateWithTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((valueSelector == null) ? IntPtr.Zero : ((Java.Lang.Object)valueSelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("associateWithTo.(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_associateWithTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(valueSelector);
			}
			return @object;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00015EEC File Offset: 0x000140EC
		public static Java.Lang.Object AssociateWithTo(string _this_associateWithTo, Java.Lang.Object destination, IFunction1 valueSelector)
		{
			Java.Lang.String @string = (_this_associateWithTo == null) ? null : new Java.Lang.String(_this_associateWithTo);
			Java.Lang.Object result = StringsKt.AssociateWithTo(@string, destination, valueSelector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00015F18 File Offset: 0x00014118
		[Register("chunked", "(Ljava/lang/CharSequence;I)Ljava/util/List;", "")]
		public unsafe static IList<string> Chunked(ICharSequence _this_chunked, int size)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_chunked);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(size);
				result = JavaList<string>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("chunked.(Ljava/lang/CharSequence;I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_chunked);
			}
			return result;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00015F9C File Offset: 0x0001419C
		public static IList<string> Chunked(string _this_chunked, int size)
		{
			Java.Lang.String @string = (_this_chunked == null) ? null : new Java.Lang.String(_this_chunked);
			IList<string> result = StringsKt.Chunked(@string, size);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00015FC8 File Offset: 0x000141C8
		[Register("chunked", "(Ljava/lang/CharSequence;ILkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Chunked(ICharSequence _this_chunked, int size, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_chunked);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("chunked.(Ljava/lang/CharSequence;ILkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_chunked);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0001607C File Offset: 0x0001427C
		public static System.Collections.IList Chunked(string _this_chunked, int size, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_chunked == null) ? null : new Java.Lang.String(_this_chunked);
			System.Collections.IList result = StringsKt.Chunked(@string, size, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000160A8 File Offset: 0x000142A8
		[Register("chunkedSequence", "(Ljava/lang/CharSequence;I)Lkotlin/sequences/Sequence;", "")]
		public unsafe static ISequence ChunkedSequence(ICharSequence _this_chunkedSequence, int size)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_chunkedSequence);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(size);
				@object = Java.Lang.Object.GetObject<ISequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("chunkedSequence.(Ljava/lang/CharSequence;I)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_chunkedSequence);
			}
			return @object;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0001612C File Offset: 0x0001432C
		public static ISequence ChunkedSequence(string _this_chunkedSequence, int size)
		{
			Java.Lang.String @string = (_this_chunkedSequence == null) ? null : new Java.Lang.String(_this_chunkedSequence);
			ISequence result = StringsKt.ChunkedSequence(@string, size);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00016158 File Offset: 0x00014358
		[Register("chunkedSequence", "(Ljava/lang/CharSequence;ILkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static ISequence ChunkedSequence(ICharSequence _this_chunkedSequence, int size, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_chunkedSequence);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("chunkedSequence.(Ljava/lang/CharSequence;ILkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_chunkedSequence);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001620C File Offset: 0x0001440C
		public static ISequence ChunkedSequence(string _this_chunkedSequence, int size, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_chunkedSequence == null) ? null : new Java.Lang.String(_this_chunkedSequence);
			ISequence result = StringsKt.ChunkedSequence(@string, size, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00016238 File Offset: 0x00014438
		[Register("count", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)I", "")]
		public unsafe static int Count(ICharSequence _this_count, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_count);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("count.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_count);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000162C8 File Offset: 0x000144C8
		public static int Count(string _this_count, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_count == null) ? null : new Java.Lang.String(_this_count);
			int result = StringsKt.Count(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000162F4 File Offset: 0x000144F4
		[Register("drop", "(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence DropFormatted(ICharSequence _this_drop, int n)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_drop);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("drop.(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_drop);
			}
			return @object;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00016378 File Offset: 0x00014578
		public static string Drop(string _this_drop, int n)
		{
			Java.Lang.String @string = (_this_drop == null) ? null : new Java.Lang.String(_this_drop);
			ICharSequence charSequence = StringsKt.DropFormatted(@string, n);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000163B0 File Offset: 0x000145B0
		[Register("dropLast", "(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence DropLastFormatted(ICharSequence _this_dropLast, int n)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_dropLast);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("dropLast.(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_dropLast);
			}
			return @object;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00016434 File Offset: 0x00014634
		public static string DropLast(string _this_dropLast, int n)
		{
			Java.Lang.String @string = (_this_dropLast == null) ? null : new Java.Lang.String(_this_dropLast);
			ICharSequence charSequence = StringsKt.DropLastFormatted(@string, n);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0001646C File Offset: 0x0001466C
		[Register("dropLastWhile", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence DropLastWhileFormatted(ICharSequence _this_dropLastWhile, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_dropLastWhile);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("dropLastWhile.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_dropLastWhile);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0001650C File Offset: 0x0001470C
		public static string DropLastWhile(string _this_dropLastWhile, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_dropLastWhile == null) ? null : new Java.Lang.String(_this_dropLastWhile);
			ICharSequence charSequence = StringsKt.DropLastWhileFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00016544 File Offset: 0x00014744
		[Register("dropWhile", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence DropWhileFormatted(ICharSequence _this_dropWhile, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_dropWhile);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("dropWhile.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_dropWhile);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000165E4 File Offset: 0x000147E4
		public static string DropWhile(string _this_dropWhile, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_dropWhile == null) ? null : new Java.Lang.String(_this_dropWhile);
			ICharSequence charSequence = StringsKt.DropWhileFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0001661C File Offset: 0x0001481C
		[Register("filter", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence FilterFormatted(ICharSequence _this_filter, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_filter);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("filter.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filter);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000166BC File Offset: 0x000148BC
		public static string Filter(string _this_filter, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_filter == null) ? null : new Java.Lang.String(_this_filter);
			ICharSequence charSequence = StringsKt.FilterFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000166F4 File Offset: 0x000148F4
		[Register("filterIndexed", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence FilterIndexedFormatted(ICharSequence _this_filterIndexed, IFunction2 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_filterIndexed);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("filterIndexed.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterIndexed);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00016794 File Offset: 0x00014994
		public static string FilterIndexed(string _this_filterIndexed, IFunction2 predicate)
		{
			Java.Lang.String @string = (_this_filterIndexed == null) ? null : new Java.Lang.String(_this_filterIndexed);
			ICharSequence charSequence = StringsKt.FilterIndexedFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000167CC File Offset: 0x000149CC
		[Register("filterIndexedTo", "(Ljava/lang/CharSequence;Ljava/lang/Appendable;Lkotlin/jvm/functions/Function2;)Ljava/lang/Appendable;", "")]
		[JavaTypeParameters(new string[]
		{
			"C extends java.lang.Appendable"
		})]
		public unsafe static Java.Lang.Object FilterIndexedTo(ICharSequence _this_filterIndexedTo, Java.Lang.Object destination, IFunction2 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_filterIndexedTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("filterIndexedTo.(Ljava/lang/CharSequence;Ljava/lang/Appendable;Lkotlin/jvm/functions/Function2;)Ljava/lang/Appendable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_filterIndexedTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00016894 File Offset: 0x00014A94
		public static Java.Lang.Object FilterIndexedTo(string _this_filterIndexedTo, Java.Lang.Object destination, IFunction2 predicate)
		{
			Java.Lang.String @string = (_this_filterIndexedTo == null) ? null : new Java.Lang.String(_this_filterIndexedTo);
			Java.Lang.Object result = StringsKt.FilterIndexedTo(@string, destination, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000168C0 File Offset: 0x00014AC0
		[Register("filterNot", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence FilterNotFormatted(ICharSequence _this_filterNot, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_filterNot);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("filterNot.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterNot);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00016960 File Offset: 0x00014B60
		public static string FilterNot(string _this_filterNot, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_filterNot == null) ? null : new Java.Lang.String(_this_filterNot);
			ICharSequence charSequence = StringsKt.FilterNotFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00016998 File Offset: 0x00014B98
		[Register("filterNotTo", "(Ljava/lang/CharSequence;Ljava/lang/Appendable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Appendable;", "")]
		[JavaTypeParameters(new string[]
		{
			"C extends java.lang.Appendable"
		})]
		public unsafe static Java.Lang.Object FilterNotTo(ICharSequence _this_filterNotTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_filterNotTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("filterNotTo.(Ljava/lang/CharSequence;Ljava/lang/Appendable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Appendable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_filterNotTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00016A60 File Offset: 0x00014C60
		public static Java.Lang.Object FilterNotTo(string _this_filterNotTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_filterNotTo == null) ? null : new Java.Lang.String(_this_filterNotTo);
			Java.Lang.Object result = StringsKt.FilterNotTo(@string, destination, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00016A8C File Offset: 0x00014C8C
		[Register("filterTo", "(Ljava/lang/CharSequence;Ljava/lang/Appendable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Appendable;", "")]
		[JavaTypeParameters(new string[]
		{
			"C extends java.lang.Appendable"
		})]
		public unsafe static Java.Lang.Object FilterTo(ICharSequence _this_filterTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_filterTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("filterTo.(Ljava/lang/CharSequence;Ljava/lang/Appendable;Lkotlin/jvm/functions/Function1;)Ljava/lang/Appendable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_filterTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00016B54 File Offset: 0x00014D54
		public static Java.Lang.Object FilterTo(string _this_filterTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_filterTo == null) ? null : new Java.Lang.String(_this_filterTo);
			Java.Lang.Object result = StringsKt.FilterTo(@string, destination, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00016B80 File Offset: 0x00014D80
		[Register("first", "(Ljava/lang/CharSequence;)C", "")]
		public unsafe static char First(ICharSequence _this_first)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_first);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("first.(Ljava/lang/CharSequence;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_first);
			}
			return result;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00016BE4 File Offset: 0x00014DE4
		public static char First(string _this_first)
		{
			Java.Lang.String @string = (_this_first == null) ? null : new Java.Lang.String(_this_first);
			char result = StringsKt.First(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00016C10 File Offset: 0x00014E10
		[Register("first", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", "")]
		public unsafe static char First(ICharSequence _this_first, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_first);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("first.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_first);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00016CA0 File Offset: 0x00014EA0
		public static char First(string _this_first, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_first == null) ? null : new Java.Lang.String(_this_first);
			char result = StringsKt.First(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00016CCC File Offset: 0x00014ECC
		[Register("firstOrNull", "(Ljava/lang/CharSequence;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character FirstOrNull(ICharSequence _this_firstOrNull)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_firstOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Ljava/lang/CharSequence;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00016D3C File Offset: 0x00014F3C
		[return: Nullable(2)]
		public static Character FirstOrNull(string _this_firstOrNull)
		{
			Java.Lang.String @string = (_this_firstOrNull == null) ? null : new Java.Lang.String(_this_firstOrNull);
			Character result = StringsKt.FirstOrNull(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00016D68 File Offset: 0x00014F68
		[Register("firstOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character FirstOrNull(ICharSequence _this_firstOrNull, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_firstOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_firstOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00016E08 File Offset: 0x00015008
		[return: Nullable(2)]
		public static Character FirstOrNull(string _this_firstOrNull, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_firstOrNull == null) ? null : new Java.Lang.String(_this_firstOrNull);
			Character result = StringsKt.FirstOrNull(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00016E34 File Offset: 0x00015034
		[Register("flatMap", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList FlatMap(ICharSequence _this_flatMap, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_flatMap);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("flatMap.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_flatMap);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00016ED4 File Offset: 0x000150D4
		public static System.Collections.IList FlatMap(string _this_flatMap, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_flatMap == null) ? null : new Java.Lang.String(_this_flatMap);
			System.Collections.IList result = StringsKt.FlatMap(@string, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00016F00 File Offset: 0x00015100
		[Register("flatMapTo", "(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object FlatMapTo(ICharSequence _this_flatMapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_flatMapTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("flatMapTo.(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_flatMapTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00016FC8 File Offset: 0x000151C8
		public static Java.Lang.Object FlatMapTo(string _this_flatMapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_flatMapTo == null) ? null : new Java.Lang.String(_this_flatMapTo);
			Java.Lang.Object result = StringsKt.FlatMapTo(@string, destination, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00016FF4 File Offset: 0x000151F4
		[Register("fold", "(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(ICharSequence _this_fold, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_fold);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("fold.(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_fold);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000170BC File Offset: 0x000152BC
		[return: Nullable(2)]
		public static Java.Lang.Object Fold(string _this_fold, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_fold == null) ? null : new Java.Lang.String(_this_fold);
			Java.Lang.Object result = StringsKt.Fold(@string, initial, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000170E8 File Offset: 0x000152E8
		[Register("foldIndexed", "(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FoldIndexed(ICharSequence _this_foldIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_foldIndexed);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("foldIndexed.(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_foldIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000171B0 File Offset: 0x000153B0
		[return: Nullable(2)]
		public static Java.Lang.Object FoldIndexed(string _this_foldIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_foldIndexed == null) ? null : new Java.Lang.String(_this_foldIndexed);
			Java.Lang.Object result = StringsKt.FoldIndexed(@string, initial, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000171DC File Offset: 0x000153DC
		[Register("foldRight", "(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FoldRight(ICharSequence _this_foldRight, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_foldRight);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("foldRight.(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600085B RID: 2139 RVA: 0x000172A4 File Offset: 0x000154A4
		[return: Nullable(2)]
		public static Java.Lang.Object FoldRight(string _this_foldRight, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_foldRight == null) ? null : new Java.Lang.String(_this_foldRight);
			Java.Lang.Object result = StringsKt.FoldRight(@string, initial, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000172D0 File Offset: 0x000154D0
		[Register("foldRightIndexed", "(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FoldRightIndexed(ICharSequence _this_foldRightIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_foldRightIndexed);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("foldRightIndexed.(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600085D RID: 2141 RVA: 0x00017398 File Offset: 0x00015598
		[return: Nullable(2)]
		public static Java.Lang.Object FoldRightIndexed(string _this_foldRightIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_foldRightIndexed == null) ? null : new Java.Lang.String(_this_foldRightIndexed);
			Java.Lang.Object result = StringsKt.FoldRightIndexed(@string, initial, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000173C4 File Offset: 0x000155C4
		[Register("forEach", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)V", "")]
		public unsafe static void ForEach(ICharSequence _this_forEach, IFunction1 action)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_forEach);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				StringsKt._members.StaticMethods.InvokeVoidMethod("forEach.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_forEach);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00017454 File Offset: 0x00015654
		public static void ForEach(string _this_forEach, IFunction1 action)
		{
			object obj = (_this_forEach == null) ? null : new Java.Lang.String(_this_forEach);
			StringsKt.ForEach(obj, action);
			if (obj == null)
			{
				return;
			}
			obj.Dispose();
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00017474 File Offset: 0x00015674
		[Register("forEachIndexed", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)V", "")]
		public unsafe static void ForEachIndexed(ICharSequence _this_forEachIndexed, IFunction2 action)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_forEachIndexed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				StringsKt._members.StaticMethods.InvokeVoidMethod("forEachIndexed.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_forEachIndexed);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00017504 File Offset: 0x00015704
		public static void ForEachIndexed(string _this_forEachIndexed, IFunction2 action)
		{
			object obj = (_this_forEachIndexed == null) ? null : new Java.Lang.String(_this_forEachIndexed);
			StringsKt.ForEachIndexed(obj, action);
			if (obj == null)
			{
				return;
			}
			obj.Dispose();
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00017524 File Offset: 0x00015724
		[Register("getOrNull", "(Ljava/lang/CharSequence;I)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character GetOrNull(ICharSequence _this_getOrNull, int index)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_getOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("getOrNull.(Ljava/lang/CharSequence;I)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_getOrNull);
			}
			return @object;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000175A8 File Offset: 0x000157A8
		[return: Nullable(2)]
		public static Character GetOrNull(string _this_getOrNull, int index)
		{
			Java.Lang.String @string = (_this_getOrNull == null) ? null : new Java.Lang.String(_this_getOrNull);
			Character orNull = StringsKt.GetOrNull(@string, index);
			if (@string != null)
			{
				@string.Dispose();
			}
			return orNull;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000175D4 File Offset: 0x000157D4
		[Register("groupBy", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K"
		})]
		public unsafe static IDictionary GroupBy(ICharSequence _this_groupBy, IFunction1 keySelector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_groupBy);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				result = JavaDictionary.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("groupBy.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_groupBy);
				GC.KeepAlive(keySelector);
			}
			return result;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00017674 File Offset: 0x00015874
		public static IDictionary GroupBy(string _this_groupBy, IFunction1 keySelector)
		{
			Java.Lang.String @string = (_this_groupBy == null) ? null : new Java.Lang.String(_this_groupBy);
			IDictionary result = StringsKt.GroupBy(@string, keySelector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000176A0 File Offset: 0x000158A0
		[Register("groupBy", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary GroupBy(ICharSequence _this_groupBy, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_groupBy);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[2] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				result = JavaDictionary.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("groupBy.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_groupBy);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return result;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00017770 File Offset: 0x00015970
		public static IDictionary GroupBy(string _this_groupBy, IFunction1 keySelector, IFunction1 valueTransform)
		{
			Java.Lang.String @string = (_this_groupBy == null) ? null : new Java.Lang.String(_this_groupBy);
			IDictionary result = StringsKt.GroupBy(@string, keySelector, valueTransform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001779C File Offset: 0x0001599C
		[Register("groupByTo", "(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"M extends java.util.Map<? super K, java.util.List<java.lang.Character>>"
		})]
		public unsafe static Java.Lang.Object GroupByTo(ICharSequence _this_groupByTo, Java.Lang.Object destination, IFunction1 keySelector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_groupByTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("groupByTo.(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_groupByTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(keySelector);
			}
			return @object;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00017864 File Offset: 0x00015A64
		public static Java.Lang.Object GroupByTo(string _this_groupByTo, Java.Lang.Object destination, IFunction1 keySelector)
		{
			Java.Lang.String @string = (_this_groupByTo == null) ? null : new Java.Lang.String(_this_groupByTo);
			Java.Lang.Object result = StringsKt.GroupByTo(@string, destination, keySelector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00017890 File Offset: 0x00015A90
		[Register("groupByTo", "(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, java.util.List<V>>"
		})]
		public unsafe static Java.Lang.Object GroupByTo(ICharSequence _this_groupByTo, Java.Lang.Object destination, IFunction1 keySelector, IFunction1 valueTransform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_groupByTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				ptr[3] = new JniArgumentValue((valueTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)valueTransform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("groupByTo.(Ljava/lang/CharSequence;Ljava/util/Map;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_groupByTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(keySelector);
				GC.KeepAlive(valueTransform);
			}
			return @object;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00017988 File Offset: 0x00015B88
		public static Java.Lang.Object GroupByTo(string _this_groupByTo, Java.Lang.Object destination, IFunction1 keySelector, IFunction1 valueTransform)
		{
			Java.Lang.String @string = (_this_groupByTo == null) ? null : new Java.Lang.String(_this_groupByTo);
			Java.Lang.Object result = StringsKt.GroupByTo(@string, destination, keySelector, valueTransform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000179B4 File Offset: 0x00015BB4
		[Register("groupingBy", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Lkotlin/collections/Grouping;", "")]
		[JavaTypeParameters(new string[]
		{
			"K"
		})]
		public unsafe static IGrouping GroupingBy(ICharSequence _this_groupingBy, IFunction1 keySelector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_groupingBy);
			IGrouping @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<IGrouping>(StringsKt._members.StaticMethods.InvokeObjectMethod("groupingBy.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Lkotlin/collections/Grouping;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_groupingBy);
				GC.KeepAlive(keySelector);
			}
			return @object;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00017A54 File Offset: 0x00015C54
		public static IGrouping GroupingBy(string _this_groupingBy, IFunction1 keySelector)
		{
			Java.Lang.String @string = (_this_groupingBy == null) ? null : new Java.Lang.String(_this_groupingBy);
			IGrouping result = StringsKt.GroupingBy(@string, keySelector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00017A80 File Offset: 0x00015C80
		[Register("indexOfFirst", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)I", "")]
		public unsafe static int IndexOfFirst(ICharSequence _this_indexOfFirst, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_indexOfFirst);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("indexOfFirst.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indexOfFirst);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00017B10 File Offset: 0x00015D10
		public static int IndexOfFirst(string _this_indexOfFirst, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_indexOfFirst == null) ? null : new Java.Lang.String(_this_indexOfFirst);
			int result = StringsKt.IndexOfFirst(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00017B3C File Offset: 0x00015D3C
		[Register("indexOfLast", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)I", "")]
		public unsafe static int IndexOfLast(ICharSequence _this_indexOfLast, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_indexOfLast);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("indexOfLast.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indexOfLast);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00017BCC File Offset: 0x00015DCC
		public static int IndexOfLast(string _this_indexOfLast, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_indexOfLast == null) ? null : new Java.Lang.String(_this_indexOfLast);
			int result = StringsKt.IndexOfLast(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00017BF8 File Offset: 0x00015DF8
		[Register("last", "(Ljava/lang/CharSequence;)C", "")]
		public unsafe static char Last(ICharSequence _this_last)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_last);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("last.(Ljava/lang/CharSequence;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_last);
			}
			return result;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00017C5C File Offset: 0x00015E5C
		public static char Last(string _this_last)
		{
			Java.Lang.String @string = (_this_last == null) ? null : new Java.Lang.String(_this_last);
			char result = StringsKt.Last(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00017C88 File Offset: 0x00015E88
		[Register("last", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", "")]
		public unsafe static char Last(ICharSequence _this_last, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_last);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("last.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_last);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00017D18 File Offset: 0x00015F18
		public static char Last(string _this_last, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_last == null) ? null : new Java.Lang.String(_this_last);
			char result = StringsKt.Last(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00017D44 File Offset: 0x00015F44
		[Register("lastOrNull", "(Ljava/lang/CharSequence;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character LastOrNull(ICharSequence _this_lastOrNull)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lastOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Ljava/lang/CharSequence;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00017DB4 File Offset: 0x00015FB4
		[return: Nullable(2)]
		public static Character LastOrNull(string _this_lastOrNull)
		{
			Java.Lang.String @string = (_this_lastOrNull == null) ? null : new Java.Lang.String(_this_lastOrNull);
			Character result = StringsKt.LastOrNull(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00017DE0 File Offset: 0x00015FE0
		[Register("lastOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character LastOrNull(ICharSequence _this_lastOrNull, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lastOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00017E80 File Offset: 0x00016080
		[return: Nullable(2)]
		public static Character LastOrNull(string _this_lastOrNull, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_lastOrNull == null) ? null : new Java.Lang.String(_this_lastOrNull);
			Character result = StringsKt.LastOrNull(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00017EAC File Offset: 0x000160AC
		[Register("map", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Map(ICharSequence _this_map, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_map);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("map.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_map);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00017F4C File Offset: 0x0001614C
		public static System.Collections.IList Map(string _this_map, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_map == null) ? null : new Java.Lang.String(_this_map);
			System.Collections.IList result = StringsKt.Map(@string, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00017F78 File Offset: 0x00016178
		[Register("mapIndexed", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList MapIndexed(ICharSequence _this_mapIndexed, IFunction2 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_mapIndexed);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("mapIndexed.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapIndexed);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00018018 File Offset: 0x00016218
		public static System.Collections.IList MapIndexed(string _this_mapIndexed, IFunction2 transform)
		{
			Java.Lang.String @string = (_this_mapIndexed == null) ? null : new Java.Lang.String(_this_mapIndexed);
			System.Collections.IList result = StringsKt.MapIndexed(@string, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00018044 File Offset: 0x00016244
		[Register("mapIndexedNotNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList MapIndexedNotNull(ICharSequence _this_mapIndexedNotNull, IFunction2 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_mapIndexedNotNull);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("mapIndexedNotNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapIndexedNotNull);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000180E4 File Offset: 0x000162E4
		public static System.Collections.IList MapIndexedNotNull(string _this_mapIndexedNotNull, IFunction2 transform)
		{
			Java.Lang.String @string = (_this_mapIndexedNotNull == null) ? null : new Java.Lang.String(_this_mapIndexedNotNull);
			System.Collections.IList result = StringsKt.MapIndexedNotNull(@string, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00018110 File Offset: 0x00016310
		[Register("mapIndexedNotNullTo", "(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapIndexedNotNullTo(ICharSequence _this_mapIndexedNotNullTo, Java.Lang.Object destination, IFunction2 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_mapIndexedNotNullTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("mapIndexedNotNullTo.(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_mapIndexedNotNullTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000181D8 File Offset: 0x000163D8
		public static Java.Lang.Object MapIndexedNotNullTo(string _this_mapIndexedNotNullTo, Java.Lang.Object destination, IFunction2 transform)
		{
			Java.Lang.String @string = (_this_mapIndexedNotNullTo == null) ? null : new Java.Lang.String(_this_mapIndexedNotNullTo);
			Java.Lang.Object result = StringsKt.MapIndexedNotNullTo(@string, destination, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00018204 File Offset: 0x00016404
		[Register("mapIndexedTo", "(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapIndexedTo(ICharSequence _this_mapIndexedTo, Java.Lang.Object destination, IFunction2 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_mapIndexedTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("mapIndexedTo.(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function2;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_mapIndexedTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000182CC File Offset: 0x000164CC
		public static Java.Lang.Object MapIndexedTo(string _this_mapIndexedTo, Java.Lang.Object destination, IFunction2 transform)
		{
			Java.Lang.String @string = (_this_mapIndexedTo == null) ? null : new Java.Lang.String(_this_mapIndexedTo);
			Java.Lang.Object result = StringsKt.MapIndexedTo(@string, destination, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000182F8 File Offset: 0x000164F8
		[Register("mapNotNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList MapNotNull(ICharSequence _this_mapNotNull, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_mapNotNull);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("mapNotNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapNotNull);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00018398 File Offset: 0x00016598
		public static System.Collections.IList MapNotNull(string _this_mapNotNull, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_mapNotNull == null) ? null : new Java.Lang.String(_this_mapNotNull);
			System.Collections.IList result = StringsKt.MapNotNull(@string, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000183C4 File Offset: 0x000165C4
		[Register("mapNotNullTo", "(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapNotNullTo(ICharSequence _this_mapNotNullTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_mapNotNullTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("mapNotNullTo.(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_mapNotNullTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001848C File Offset: 0x0001668C
		public static Java.Lang.Object MapNotNullTo(string _this_mapNotNullTo, Java.Lang.Object destination, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_mapNotNullTo == null) ? null : new Java.Lang.String(_this_mapNotNullTo);
			Java.Lang.Object result = StringsKt.MapNotNullTo(@string, destination, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000184B8 File Offset: 0x000166B8
		[Register("mapTo", "(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapTo(ICharSequence _this_mapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_mapTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("mapTo.(Ljava/lang/CharSequence;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_mapTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00018580 File Offset: 0x00016780
		public static Java.Lang.Object MapTo(string _this_mapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_mapTo == null) ? null : new Java.Lang.String(_this_mapTo);
			Java.Lang.Object result = StringsKt.MapTo(@string, destination, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000185AC File Offset: 0x000167AC
		[Register("maxByOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", "")]
		[JavaTypeParameters(new string[]
		{
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Character MaxByOrNull(ICharSequence _this_maxByOrNull, IFunction1 selector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_maxByOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("maxByOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_maxByOrNull);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0001864C File Offset: 0x0001684C
		[return: Nullable(2)]
		public static Character MaxByOrNull(string _this_maxByOrNull, IFunction1 selector)
		{
			Java.Lang.String @string = (_this_maxByOrNull == null) ? null : new Java.Lang.String(_this_maxByOrNull);
			Character result = StringsKt.MaxByOrNull(@string, selector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00018678 File Offset: 0x00016878
		[Register("maxByOrThrow", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", "")]
		[JavaTypeParameters(new string[]
		{
			"R extends java.lang.Comparable<? super R>"
		})]
		public unsafe static char MaxByOrThrow(ICharSequence _this_maxBy, IFunction1 selector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_maxBy);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("maxByOrThrow.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_maxBy);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00018708 File Offset: 0x00016908
		public static char MaxByOrThrow(string _this_maxBy, IFunction1 selector)
		{
			Java.Lang.String @string = (_this_maxBy == null) ? null : new Java.Lang.String(_this_maxBy);
			char result = StringsKt.MaxByOrThrow(@string, selector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00018734 File Offset: 0x00016934
		[Register("maxOrNull", "(Ljava/lang/CharSequence;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character MaxOrNull(ICharSequence _this_maxOrNull)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_maxOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("maxOrNull.(Ljava/lang/CharSequence;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_maxOrNull);
			}
			return @object;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000187A4 File Offset: 0x000169A4
		[return: Nullable(2)]
		public static Character MaxOrNull(string _this_maxOrNull)
		{
			Java.Lang.String @string = (_this_maxOrNull == null) ? null : new Java.Lang.String(_this_maxOrNull);
			Character result = StringsKt.MaxOrNull(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000187D0 File Offset: 0x000169D0
		[Register("maxOrThrow", "(Ljava/lang/CharSequence;)C", "")]
		public unsafe static char MaxOrThrow(ICharSequence _this_max)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_max);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("maxOrThrow.(Ljava/lang/CharSequence;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_max);
			}
			return result;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00018834 File Offset: 0x00016A34
		public static char MaxOrThrow(string _this_max)
		{
			Java.Lang.String @string = (_this_max == null) ? null : new Java.Lang.String(_this_max);
			char result = StringsKt.MaxOrThrow(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00018860 File Offset: 0x00016A60
		[Register("maxWithOrNull", "(Ljava/lang/CharSequence;Ljava/util/Comparator;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character MaxWithOrNull(ICharSequence _this_maxWithOrNull, IComparator comparator)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_maxWithOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("maxWithOrNull.(Ljava/lang/CharSequence;Ljava/util/Comparator;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_maxWithOrNull);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00018900 File Offset: 0x00016B00
		[return: Nullable(2)]
		public static Character MaxWithOrNull(string _this_maxWithOrNull, IComparator comparator)
		{
			Java.Lang.String @string = (_this_maxWithOrNull == null) ? null : new Java.Lang.String(_this_maxWithOrNull);
			Character result = StringsKt.MaxWithOrNull(@string, comparator);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0001892C File Offset: 0x00016B2C
		[Register("maxWithOrThrow", "(Ljava/lang/CharSequence;Ljava/util/Comparator;)C", "")]
		public unsafe static char MaxWithOrThrow(ICharSequence _this_maxWith, IComparator comparator)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_maxWith);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("maxWithOrThrow.(Ljava/lang/CharSequence;Ljava/util/Comparator;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_maxWith);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000189BC File Offset: 0x00016BBC
		public static char MaxWithOrThrow(string _this_maxWith, IComparator comparator)
		{
			Java.Lang.String @string = (_this_maxWith == null) ? null : new Java.Lang.String(_this_maxWith);
			char result = StringsKt.MaxWithOrThrow(@string, comparator);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000189E8 File Offset: 0x00016BE8
		[Register("minByOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", "")]
		[JavaTypeParameters(new string[]
		{
			"R extends java.lang.Comparable<? super R>"
		})]
		[return: Nullable(2)]
		public unsafe static Character MinByOrNull(ICharSequence _this_minByOrNull, IFunction1 selector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_minByOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("minByOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minByOrNull);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00018A88 File Offset: 0x00016C88
		[return: Nullable(2)]
		public static Character MinByOrNull(string _this_minByOrNull, IFunction1 selector)
		{
			Java.Lang.String @string = (_this_minByOrNull == null) ? null : new Java.Lang.String(_this_minByOrNull);
			Character result = StringsKt.MinByOrNull(@string, selector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00018AB4 File Offset: 0x00016CB4
		[Register("minByOrThrow", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", "")]
		[JavaTypeParameters(new string[]
		{
			"R extends java.lang.Comparable<? super R>"
		})]
		public unsafe static char MinByOrThrow(ICharSequence _this_minBy, IFunction1 selector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_minBy);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("minByOrThrow.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minBy);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00018B44 File Offset: 0x00016D44
		public static char MinByOrThrow(string _this_minBy, IFunction1 selector)
		{
			Java.Lang.String @string = (_this_minBy == null) ? null : new Java.Lang.String(_this_minBy);
			char result = StringsKt.MinByOrThrow(@string, selector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00018B70 File Offset: 0x00016D70
		[Register("minOrNull", "(Ljava/lang/CharSequence;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character MinOrNull(ICharSequence _this_minOrNull)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_minOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("minOrNull.(Ljava/lang/CharSequence;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minOrNull);
			}
			return @object;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00018BE0 File Offset: 0x00016DE0
		[return: Nullable(2)]
		public static Character MinOrNull(string _this_minOrNull)
		{
			Java.Lang.String @string = (_this_minOrNull == null) ? null : new Java.Lang.String(_this_minOrNull);
			Character result = StringsKt.MinOrNull(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00018C0C File Offset: 0x00016E0C
		[Register("minOrThrow", "(Ljava/lang/CharSequence;)C", "")]
		public unsafe static char MinOrThrow(ICharSequence _this_min)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_min);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("minOrThrow.(Ljava/lang/CharSequence;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_min);
			}
			return result;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00018C70 File Offset: 0x00016E70
		public static char MinOrThrow(string _this_min)
		{
			Java.Lang.String @string = (_this_min == null) ? null : new Java.Lang.String(_this_min);
			char result = StringsKt.MinOrThrow(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00018C9C File Offset: 0x00016E9C
		[Register("minWithOrNull", "(Ljava/lang/CharSequence;Ljava/util/Comparator;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character MinWithOrNull(ICharSequence _this_minWithOrNull, IComparator comparator)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_minWithOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("minWithOrNull.(Ljava/lang/CharSequence;Ljava/util/Comparator;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minWithOrNull);
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00018D3C File Offset: 0x00016F3C
		[return: Nullable(2)]
		public static Character MinWithOrNull(string _this_minWithOrNull, IComparator comparator)
		{
			Java.Lang.String @string = (_this_minWithOrNull == null) ? null : new Java.Lang.String(_this_minWithOrNull);
			Character result = StringsKt.MinWithOrNull(@string, comparator);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00018D68 File Offset: 0x00016F68
		[Register("minWithOrThrow", "(Ljava/lang/CharSequence;Ljava/util/Comparator;)C", "")]
		public unsafe static char MinWithOrThrow(ICharSequence _this_minWith, IComparator comparator)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_minWith);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("minWithOrThrow.(Ljava/lang/CharSequence;Ljava/util/Comparator;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minWith);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00018DF8 File Offset: 0x00016FF8
		public static char MinWithOrThrow(string _this_minWith, IComparator comparator)
		{
			Java.Lang.String @string = (_this_minWith == null) ? null : new Java.Lang.String(_this_minWith);
			char result = StringsKt.MinWithOrThrow(@string, comparator);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00018E24 File Offset: 0x00017024
		[Register("none", "(Ljava/lang/CharSequence;)Z", "")]
		public unsafe static bool None(ICharSequence _this_none)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_none);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("none.(Ljava/lang/CharSequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_none);
			}
			return result;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00018E88 File Offset: 0x00017088
		public static bool None(string _this_none)
		{
			Java.Lang.String @string = (_this_none == null) ? null : new Java.Lang.String(_this_none);
			bool result = StringsKt.None(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00018EB4 File Offset: 0x000170B4
		[Register("none", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Z", "")]
		public unsafe static bool None(ICharSequence _this_none, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_none);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("none.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_none);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00018F44 File Offset: 0x00017144
		public static bool None(string _this_none, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_none == null) ? null : new Java.Lang.String(_this_none);
			bool result = StringsKt.None(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00018F70 File Offset: 0x00017170
		[Register("partition", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Lkotlin/Pair;", "")]
		public unsafe static Pair Partition(ICharSequence _this_partition, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_partition);
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Pair>(StringsKt._members.StaticMethods.InvokeObjectMethod("partition.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_partition);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00019010 File Offset: 0x00017210
		[Register("partition", "(Ljava/lang/String;Lkotlin/jvm/functions/Function1;)Lkotlin/Pair;", "")]
		public unsafe static Pair Partition(string _this_partition, IFunction1 predicate)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_partition);
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Pair>(StringsKt._members.StaticMethods.InvokeObjectMethod("partition.(Ljava/lang/String;Lkotlin/jvm/functions/Function1;)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000190A8 File Offset: 0x000172A8
		[Register("random", "(Ljava/lang/CharSequence;Lkotlin/random/Random;)C", "")]
		public unsafe static char Random(ICharSequence _this_random, Kotlin.Random.Random random)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_random);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("random.(Ljava/lang/CharSequence;Lkotlin/random/Random;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_random);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00019134 File Offset: 0x00017334
		public static char Random(string _this_random, Kotlin.Random.Random random)
		{
			Java.Lang.String @string = (_this_random == null) ? null : new Java.Lang.String(_this_random);
			char result = StringsKt.Random(@string, random);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00019160 File Offset: 0x00017360
		[Register("randomOrNull", "(Ljava/lang/CharSequence;Lkotlin/random/Random;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character RandomOrNull(ICharSequence _this_randomOrNull, Kotlin.Random.Random random)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_randomOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("randomOrNull.(Ljava/lang/CharSequence;Lkotlin/random/Random;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_randomOrNull);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000191F8 File Offset: 0x000173F8
		[return: Nullable(2)]
		public static Character RandomOrNull(string _this_randomOrNull, Kotlin.Random.Random random)
		{
			Java.Lang.String @string = (_this_randomOrNull == null) ? null : new Java.Lang.String(_this_randomOrNull);
			Character result = StringsKt.RandomOrNull(@string, random);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00019224 File Offset: 0x00017424
		[Register("reduce", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)C", "")]
		public unsafe static char Reduce(ICharSequence _this_reduce, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reduce);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("reduce.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduce);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000192B4 File Offset: 0x000174B4
		public static char Reduce(string _this_reduce, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_reduce == null) ? null : new Java.Lang.String(_this_reduce);
			char result = StringsKt.Reduce(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x000192E0 File Offset: 0x000174E0
		[Register("reduceIndexed", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)C", "")]
		public unsafe static char ReduceIndexed(ICharSequence _this_reduceIndexed, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reduceIndexed);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("reduceIndexed.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceIndexed);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00019370 File Offset: 0x00017570
		public static char ReduceIndexed(string _this_reduceIndexed, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_reduceIndexed == null) ? null : new Java.Lang.String(_this_reduceIndexed);
			char result = StringsKt.ReduceIndexed(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0001939C File Offset: 0x0001759C
		[Register("reduceIndexedOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character ReduceIndexedOrNull(ICharSequence _this_reduceIndexedOrNull, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reduceIndexedOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("reduceIndexedOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceIndexedOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0001943C File Offset: 0x0001763C
		[return: Nullable(2)]
		public static Character ReduceIndexedOrNull(string _this_reduceIndexedOrNull, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_reduceIndexedOrNull == null) ? null : new Java.Lang.String(_this_reduceIndexedOrNull);
			Character result = StringsKt.ReduceIndexedOrNull(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00019468 File Offset: 0x00017668
		[Register("reduceOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character ReduceOrNull(ICharSequence _this_reduceOrNull, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reduceOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("reduceOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00019508 File Offset: 0x00017708
		[return: Nullable(2)]
		public static Character ReduceOrNull(string _this_reduceOrNull, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_reduceOrNull == null) ? null : new Java.Lang.String(_this_reduceOrNull);
			Character result = StringsKt.ReduceOrNull(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00019534 File Offset: 0x00017734
		[Register("reduceRight", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)C", "")]
		public unsafe static char ReduceRight(ICharSequence _this_reduceRight, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reduceRight);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("reduceRight.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceRight);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000195C4 File Offset: 0x000177C4
		public static char ReduceRight(string _this_reduceRight, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_reduceRight == null) ? null : new Java.Lang.String(_this_reduceRight);
			char result = StringsKt.ReduceRight(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000195F0 File Offset: 0x000177F0
		[Register("reduceRightIndexed", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)C", "")]
		public unsafe static char ReduceRightIndexed(ICharSequence _this_reduceRightIndexed, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reduceRightIndexed);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("reduceRightIndexed.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceRightIndexed);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00019680 File Offset: 0x00017880
		public static char ReduceRightIndexed(string _this_reduceRightIndexed, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_reduceRightIndexed == null) ? null : new Java.Lang.String(_this_reduceRightIndexed);
			char result = StringsKt.ReduceRightIndexed(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000196AC File Offset: 0x000178AC
		[Register("reduceRightIndexedOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character ReduceRightIndexedOrNull(ICharSequence _this_reduceRightIndexedOrNull, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reduceRightIndexedOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("reduceRightIndexedOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceRightIndexedOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0001974C File Offset: 0x0001794C
		[return: Nullable(2)]
		public static Character ReduceRightIndexedOrNull(string _this_reduceRightIndexedOrNull, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_reduceRightIndexedOrNull == null) ? null : new Java.Lang.String(_this_reduceRightIndexedOrNull);
			Character result = StringsKt.ReduceRightIndexedOrNull(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00019778 File Offset: 0x00017978
		[Register("reduceRightOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character ReduceRightOrNull(ICharSequence _this_reduceRightOrNull, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reduceRightOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("reduceRightOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceRightOrNull);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00019818 File Offset: 0x00017A18
		[return: Nullable(2)]
		public static Character ReduceRightOrNull(string _this_reduceRightOrNull, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_reduceRightOrNull == null) ? null : new Java.Lang.String(_this_reduceRightOrNull);
			Character result = StringsKt.ReduceRightOrNull(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00019844 File Offset: 0x00017A44
		[Register("reversed", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence ReversedFormatted(ICharSequence _this_reversed)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_reversed);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("reversed.(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reversed);
			}
			return @object;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x000198B4 File Offset: 0x00017AB4
		public static string Reversed(string _this_reversed)
		{
			Java.Lang.String @string = (_this_reversed == null) ? null : new Java.Lang.String(_this_reversed);
			ICharSequence charSequence = StringsKt.ReversedFormatted(@string);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000198EC File Offset: 0x00017AEC
		[Register("runningFold", "(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList RunningFold(ICharSequence _this_runningFold, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_runningFold);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("runningFold.(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_runningFold);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000199B4 File Offset: 0x00017BB4
		public static System.Collections.IList RunningFold(string _this_runningFold, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_runningFold == null) ? null : new Java.Lang.String(_this_runningFold);
			System.Collections.IList result = StringsKt.RunningFold(@string, initial, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000199E0 File Offset: 0x00017BE0
		[Register("runningFoldIndexed", "(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList RunningFoldIndexed(ICharSequence _this_runningFoldIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_runningFoldIndexed);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("runningFoldIndexed.(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_runningFoldIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00019AA8 File Offset: 0x00017CA8
		public static System.Collections.IList RunningFoldIndexed(string _this_runningFoldIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_runningFoldIndexed == null) ? null : new Java.Lang.String(_this_runningFoldIndexed);
			System.Collections.IList result = StringsKt.RunningFoldIndexed(@string, initial, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00019AD4 File Offset: 0x00017CD4
		[Register("runningReduce", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		public unsafe static IList<Character> RunningReduce(ICharSequence _this_runningReduce, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_runningReduce);
			IList<Character> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList<Character>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("runningReduce.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_runningReduce);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00019B74 File Offset: 0x00017D74
		public static IList<Character> RunningReduce(string _this_runningReduce, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_runningReduce == null) ? null : new Java.Lang.String(_this_runningReduce);
			IList<Character> result = StringsKt.RunningReduce(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00019BA0 File Offset: 0x00017DA0
		[Register("runningReduceIndexed", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", "")]
		public unsafe static IList<Character> RunningReduceIndexed(ICharSequence _this_runningReduceIndexed, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_runningReduceIndexed);
			IList<Character> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList<Character>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("runningReduceIndexed.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_runningReduceIndexed);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00019C40 File Offset: 0x00017E40
		public static IList<Character> RunningReduceIndexed(string _this_runningReduceIndexed, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_runningReduceIndexed == null) ? null : new Java.Lang.String(_this_runningReduceIndexed);
			IList<Character> result = StringsKt.RunningReduceIndexed(@string, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00019C6C File Offset: 0x00017E6C
		[Register("scan", "(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Scan(ICharSequence _this_scan, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_scan);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("scan.(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_scan);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00019D34 File Offset: 0x00017F34
		public static System.Collections.IList Scan(string _this_scan, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			Java.Lang.String @string = (_this_scan == null) ? null : new Java.Lang.String(_this_scan);
			System.Collections.IList result = StringsKt.Scan(@string, initial, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00019D60 File Offset: 0x00017F60
		[Register("scanIndexed", "(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList ScanIndexed(ICharSequence _this_scanIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_scanIndexed);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initial);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("scanIndexed.(Ljava/lang/CharSequence;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_scanIndexed);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00019E28 File Offset: 0x00018028
		public static System.Collections.IList ScanIndexed(string _this_scanIndexed, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			Java.Lang.String @string = (_this_scanIndexed == null) ? null : new Java.Lang.String(_this_scanIndexed);
			System.Collections.IList result = StringsKt.ScanIndexed(@string, initial, operation);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00019E54 File Offset: 0x00018054
		[Register("single", "(Ljava/lang/CharSequence;)C", "")]
		public unsafe static char Single(ICharSequence _this_single)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_single);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("single.(Ljava/lang/CharSequence;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_single);
			}
			return result;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00019EB8 File Offset: 0x000180B8
		public static char Single(string _this_single)
		{
			Java.Lang.String @string = (_this_single == null) ? null : new Java.Lang.String(_this_single);
			char result = StringsKt.Single(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00019EE4 File Offset: 0x000180E4
		[Register("single", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", "")]
		public unsafe static char Single(ICharSequence _this_single, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_single);
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = StringsKt._members.StaticMethods.InvokeCharMethod("single.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)C", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_single);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00019F74 File Offset: 0x00018174
		public static char Single(string _this_single, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_single == null) ? null : new Java.Lang.String(_this_single);
			char result = StringsKt.Single(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00019FA0 File Offset: 0x000181A0
		[Register("singleOrNull", "(Ljava/lang/CharSequence;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character SingleOrNull(ICharSequence _this_singleOrNull)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_singleOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("singleOrNull.(Ljava/lang/CharSequence;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_singleOrNull);
			}
			return @object;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0001A010 File Offset: 0x00018210
		[return: Nullable(2)]
		public static Character SingleOrNull(string _this_singleOrNull)
		{
			Java.Lang.String @string = (_this_singleOrNull == null) ? null : new Java.Lang.String(_this_singleOrNull);
			Character result = StringsKt.SingleOrNull(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0001A03C File Offset: 0x0001823C
		[Register("singleOrNull", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character SingleOrNull(ICharSequence _this_singleOrNull, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_singleOrNull);
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Character>(StringsKt._members.StaticMethods.InvokeObjectMethod("singleOrNull.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_singleOrNull);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001A0DC File Offset: 0x000182DC
		[return: Nullable(2)]
		public static Character SingleOrNull(string _this_singleOrNull, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_singleOrNull == null) ? null : new Java.Lang.String(_this_singleOrNull);
			Character result = StringsKt.SingleOrNull(@string, predicate);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0001A108 File Offset: 0x00018308
		[Register("slice", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence SliceFormatted(ICharSequence _this_slice, IIterable indices)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_slice);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : ((Java.Lang.Object)indices).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("slice.(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_slice);
				GC.KeepAlive(indices);
			}
			return @object;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0001A1A8 File Offset: 0x000183A8
		public static string Slice(string _this_slice, IIterable indices)
		{
			Java.Lang.String @string = (_this_slice == null) ? null : new Java.Lang.String(_this_slice);
			ICharSequence charSequence = StringsKt.SliceFormatted(@string, indices);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0001A1E0 File Offset: 0x000183E0
		[Register("slice", "(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence SliceFormatted(ICharSequence _this_slice, IntRange indices)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_slice);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((indices == null) ? IntPtr.Zero : indices.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("slice.(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_slice);
				GC.KeepAlive(indices);
			}
			return @object;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0001A278 File Offset: 0x00018478
		public static string Slice(string _this_slice, IntRange indices)
		{
			Java.Lang.String @string = (_this_slice == null) ? null : new Java.Lang.String(_this_slice);
			ICharSequence charSequence = StringsKt.SliceFormatted(@string, indices);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0001A2B0 File Offset: 0x000184B0
		[Obsolete("deprecated")]
		[Register("sumBy", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)I", "")]
		public unsafe static int SumBy(ICharSequence _this_sumBy, IFunction1 selector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_sumBy);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("sumBy.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_sumBy);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0001A340 File Offset: 0x00018540
		[Obsolete("deprecated")]
		public static int SumBy(string _this_sumBy, IFunction1 selector)
		{
			Java.Lang.String @string = (_this_sumBy == null) ? null : new Java.Lang.String(_this_sumBy);
			int result = StringsKt.SumBy(@string, selector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0001A36C File Offset: 0x0001856C
		[Obsolete("deprecated")]
		[Register("sumByDouble", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)D", "")]
		public unsafe static double SumByDouble(ICharSequence _this_sumByDouble, IFunction1 selector)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_sumByDouble);
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				result = StringsKt._members.StaticMethods.InvokeDoubleMethod("sumByDouble.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)D", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_sumByDouble);
				GC.KeepAlive(selector);
			}
			return result;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0001A3FC File Offset: 0x000185FC
		[Obsolete("deprecated")]
		public static double SumByDouble(string _this_sumByDouble, IFunction1 selector)
		{
			Java.Lang.String @string = (_this_sumByDouble == null) ? null : new Java.Lang.String(_this_sumByDouble);
			double result = StringsKt.SumByDouble(@string, selector);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0001A428 File Offset: 0x00018628
		[Register("take", "(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TakeFormatted(ICharSequence _this_take, int n)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_take);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("take.(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_take);
			}
			return @object;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0001A4AC File Offset: 0x000186AC
		public static string Take(string _this_take, int n)
		{
			Java.Lang.String @string = (_this_take == null) ? null : new Java.Lang.String(_this_take);
			ICharSequence charSequence = StringsKt.TakeFormatted(@string, n);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0001A4E4 File Offset: 0x000186E4
		[Register("takeLast", "(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TakeLastFormatted(ICharSequence _this_takeLast, int n)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_takeLast);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("takeLast.(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_takeLast);
			}
			return @object;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0001A568 File Offset: 0x00018768
		public static string TakeLast(string _this_takeLast, int n)
		{
			Java.Lang.String @string = (_this_takeLast == null) ? null : new Java.Lang.String(_this_takeLast);
			ICharSequence charSequence = StringsKt.TakeLastFormatted(@string, n);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0001A5A0 File Offset: 0x000187A0
		[Register("takeLastWhile", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TakeLastWhileFormatted(ICharSequence _this_takeLastWhile, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_takeLastWhile);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("takeLastWhile.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_takeLastWhile);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0001A640 File Offset: 0x00018840
		public static string TakeLastWhile(string _this_takeLastWhile, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_takeLastWhile == null) ? null : new Java.Lang.String(_this_takeLastWhile);
			ICharSequence charSequence = StringsKt.TakeLastWhileFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001A678 File Offset: 0x00018878
		[Register("takeWhile", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TakeWhileFormatted(ICharSequence _this_takeWhile, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_takeWhile);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("takeWhile.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_takeWhile);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001A718 File Offset: 0x00018918
		public static string TakeWhile(string _this_takeWhile, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_takeWhile == null) ? null : new Java.Lang.String(_this_takeWhile);
			ICharSequence charSequence = StringsKt.TakeWhileFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0001A750 File Offset: 0x00018950
		[Register("toCollection", "(Ljava/lang/CharSequence;Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"C extends java.util.Collection<? super java.lang.Character>"
		})]
		public unsafe static Java.Lang.Object ToCollection(ICharSequence _this_toCollection, Java.Lang.Object destination)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_toCollection);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("toCollection.(Ljava/lang/CharSequence;Ljava/util/Collection;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_toCollection);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0001A7E8 File Offset: 0x000189E8
		public static Java.Lang.Object ToCollection(string _this_toCollection, Java.Lang.Object destination)
		{
			Java.Lang.String @string = (_this_toCollection == null) ? null : new Java.Lang.String(_this_toCollection);
			Java.Lang.Object result = StringsKt.ToCollection(@string, destination);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0001A814 File Offset: 0x00018A14
		[Register("toHashSet", "(Ljava/lang/CharSequence;)Ljava/util/HashSet;", "")]
		public unsafe static HashSet ToHashSet(ICharSequence _this_toHashSet)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_toHashSet);
			HashSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<HashSet>(StringsKt._members.StaticMethods.InvokeObjectMethod("toHashSet.(Ljava/lang/CharSequence;)Ljava/util/HashSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toHashSet);
			}
			return @object;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001A884 File Offset: 0x00018A84
		public static HashSet ToHashSet(string _this_toHashSet)
		{
			Java.Lang.String @string = (_this_toHashSet == null) ? null : new Java.Lang.String(_this_toHashSet);
			HashSet result = StringsKt.ToHashSet(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0001A8B0 File Offset: 0x00018AB0
		[Register("toList", "(Ljava/lang/CharSequence;)Ljava/util/List;", "")]
		public unsafe static IList<Character> ToList(ICharSequence _this_toList)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_toList);
			IList<Character> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<Character>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("toList.(Ljava/lang/CharSequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toList);
			}
			return result;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0001A920 File Offset: 0x00018B20
		public static IList<Character> ToList(string _this_toList)
		{
			Java.Lang.String @string = (_this_toList == null) ? null : new Java.Lang.String(_this_toList);
			IList<Character> result = StringsKt.ToList(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0001A94C File Offset: 0x00018B4C
		[Register("toMutableList", "(Ljava/lang/CharSequence;)Ljava/util/List;", "")]
		public unsafe static IList<Character> ToMutableList(ICharSequence _this_toMutableList)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_toMutableList);
			IList<Character> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<Character>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("toMutableList.(Ljava/lang/CharSequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toMutableList);
			}
			return result;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0001A9BC File Offset: 0x00018BBC
		public static IList<Character> ToMutableList(string _this_toMutableList)
		{
			Java.Lang.String @string = (_this_toMutableList == null) ? null : new Java.Lang.String(_this_toMutableList);
			IList<Character> result = StringsKt.ToMutableList(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		[Register("toSet", "(Ljava/lang/CharSequence;)Ljava/util/Set;", "")]
		public unsafe static ICollection<Character> ToSet(ICharSequence _this_toSet)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_toSet);
			ICollection<Character> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet<Character>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("toSet.(Ljava/lang/CharSequence;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toSet);
			}
			return result;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0001AA58 File Offset: 0x00018C58
		public static ICollection<Character> ToSet(string _this_toSet)
		{
			Java.Lang.String @string = (_this_toSet == null) ? null : new Java.Lang.String(_this_toSet);
			ICollection<Character> result = StringsKt.ToSet(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0001AA84 File Offset: 0x00018C84
		[Register("windowed", "(Ljava/lang/CharSequence;IIZ)Ljava/util/List;", "")]
		public unsafe static IList<string> Windowed(ICharSequence _this_windowed, int size, int step, bool partialWindows)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_windowed);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue(partialWindows);
				result = JavaList<string>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("windowed.(Ljava/lang/CharSequence;IIZ)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_windowed);
			}
			return result;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0001AB34 File Offset: 0x00018D34
		public static IList<string> Windowed(string _this_windowed, int size, int step, bool partialWindows)
		{
			Java.Lang.String @string = (_this_windowed == null) ? null : new Java.Lang.String(_this_windowed);
			IList<string> result = StringsKt.Windowed(@string, size, step, partialWindows);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0001AB60 File Offset: 0x00018D60
		[Register("windowed", "(Ljava/lang/CharSequence;IIZLkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList Windowed(ICharSequence _this_windowed, int size, int step, bool partialWindows, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_windowed);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue(partialWindows);
				ptr[4] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("windowed.(Ljava/lang/CharSequence;IIZLkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_windowed);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0001AC44 File Offset: 0x00018E44
		public static System.Collections.IList Windowed(string _this_windowed, int size, int step, bool partialWindows, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_windowed == null) ? null : new Java.Lang.String(_this_windowed);
			System.Collections.IList result = StringsKt.Windowed(@string, size, step, partialWindows, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0001AC74 File Offset: 0x00018E74
		[Register("windowedSequence", "(Ljava/lang/CharSequence;IIZ)Lkotlin/sequences/Sequence;", "")]
		public unsafe static ISequence WindowedSequence(ICharSequence _this_windowedSequence, int size, int step, bool partialWindows)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_windowedSequence);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue(partialWindows);
				@object = Java.Lang.Object.GetObject<ISequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("windowedSequence.(Ljava/lang/CharSequence;IIZ)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_windowedSequence);
			}
			return @object;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0001AD24 File Offset: 0x00018F24
		public static ISequence WindowedSequence(string _this_windowedSequence, int size, int step, bool partialWindows)
		{
			Java.Lang.String @string = (_this_windowedSequence == null) ? null : new Java.Lang.String(_this_windowedSequence);
			ISequence result = StringsKt.WindowedSequence(@string, size, step, partialWindows);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0001AD50 File Offset: 0x00018F50
		[Register("windowedSequence", "(Ljava/lang/CharSequence;IIZLkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static ISequence WindowedSequence(ICharSequence _this_windowedSequence, int size, int step, bool partialWindows, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_windowedSequence);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(size);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue(partialWindows);
				ptr[4] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("windowedSequence.(Ljava/lang/CharSequence;IIZLkotlin/jvm/functions/Function1;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_windowedSequence);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0001AE34 File Offset: 0x00019034
		public static ISequence WindowedSequence(string _this_windowedSequence, int size, int step, bool partialWindows, IFunction1 transform)
		{
			Java.Lang.String @string = (_this_windowedSequence == null) ? null : new Java.Lang.String(_this_windowedSequence);
			ISequence result = StringsKt.WindowedSequence(@string, size, step, partialWindows, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0001AE64 File Offset: 0x00019064
		[Register("withIndex", "(Ljava/lang/CharSequence;)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable WithIndex(ICharSequence _this_withIndex)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_withIndex);
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterable>(StringsKt._members.StaticMethods.InvokeObjectMethod("withIndex.(Ljava/lang/CharSequence;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_withIndex);
			}
			return @object;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0001AED4 File Offset: 0x000190D4
		public static IIterable WithIndex(string _this_withIndex)
		{
			Java.Lang.String @string = (_this_withIndex == null) ? null : new Java.Lang.String(_this_withIndex);
			IIterable result = StringsKt.WithIndex(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0001AF00 File Offset: 0x00019100
		[Register("zip", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/util/List;", "")]
		public unsafe static IList<Pair> Zip(ICharSequence _this_zip, ICharSequence other)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_zip);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			IList<Pair> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList<Pair>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("zip.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0001AF98 File Offset: 0x00019198
		public static IList<Pair> Zip(string _this_zip, string other)
		{
			object obj = (_this_zip == null) ? null : new Java.Lang.String(_this_zip);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			IList<Pair> result = StringsKt.Zip(obj2, @string);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0001AFDC File Offset: 0x000191DC
		[Register("zip", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"V"
		})]
		public unsafe static System.Collections.IList Zip(ICharSequence _this_zip, ICharSequence other, IFunction2 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_zip);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("zip.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0001B0A4 File Offset: 0x000192A4
		public static System.Collections.IList Zip(string _this_zip, string other, IFunction2 transform)
		{
			object obj = (_this_zip == null) ? null : new Java.Lang.String(_this_zip);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			System.Collections.IList result = StringsKt.Zip(obj2, @string, transform);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0001B0E8 File Offset: 0x000192E8
		[Register("zipWithNext", "(Ljava/lang/CharSequence;)Ljava/util/List;", "")]
		public unsafe static IList<Pair> ZipWithNext(ICharSequence _this_zipWithNext)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_zipWithNext);
			IList<Pair> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<Pair>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("zipWithNext.(Ljava/lang/CharSequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_zipWithNext);
			}
			return result;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0001B158 File Offset: 0x00019358
		public static IList<Pair> ZipWithNext(string _this_zipWithNext)
		{
			Java.Lang.String @string = (_this_zipWithNext == null) ? null : new Java.Lang.String(_this_zipWithNext);
			IList<Pair> result = StringsKt.ZipWithNext(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0001B184 File Offset: 0x00019384
		[Register("zipWithNext", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static System.Collections.IList ZipWithNext(ICharSequence _this_zipWithNext, IFunction2 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_zipWithNext);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("zipWithNext.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function2;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_zipWithNext);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0001B224 File Offset: 0x00019424
		public static System.Collections.IList ZipWithNext(string _this_zipWithNext, IFunction2 transform)
		{
			Java.Lang.String @string = (_this_zipWithNext == null) ? null : new Java.Lang.String(_this_zipWithNext);
			System.Collections.IList result = StringsKt.ZipWithNext(@string, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0001B250 File Offset: 0x00019450
		[Register("toSortedSet", "(Ljava/lang/CharSequence;)Ljava/util/SortedSet;", "")]
		public unsafe static ISortedSet ToSortedSet(ICharSequence _this_toSortedSet)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_toSortedSet);
			ISortedSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISortedSet>(StringsKt._members.StaticMethods.InvokeObjectMethod("toSortedSet.(Ljava/lang/CharSequence;)Ljava/util/SortedSet;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toSortedSet);
			}
			return @object;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0001B2C0 File Offset: 0x000194C0
		public static ISortedSet ToSortedSet(string _this_toSortedSet)
		{
			Java.Lang.String @string = (_this_toSortedSet == null) ? null : new Java.Lang.String(_this_toSortedSet);
			ISortedSet result = StringsKt.ToSortedSet(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0001B2EC File Offset: 0x000194EC
		[Register("commonPrefixWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Ljava/lang/String;", "")]
		public unsafe static string CommonPrefixWith(ICharSequence _this_commonPrefixWith, ICharSequence other, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_commonPrefixWith);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("commonPrefixWith.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_commonPrefixWith);
				GC.KeepAlive(other);
			}
			return @string;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001B39C File Offset: 0x0001959C
		public static string CommonPrefixWith(string _this_commonPrefixWith, string other, bool ignoreCase)
		{
			object obj = (_this_commonPrefixWith == null) ? null : new Java.Lang.String(_this_commonPrefixWith);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			string result = StringsKt.CommonPrefixWith(obj2, @string, ignoreCase);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0001B3E0 File Offset: 0x000195E0
		[Register("commonSuffixWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Ljava/lang/String;", "")]
		public unsafe static string CommonSuffixWith(ICharSequence _this_commonSuffixWith, ICharSequence other, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_commonSuffixWith);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("commonSuffixWith.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_commonSuffixWith);
				GC.KeepAlive(other);
			}
			return @string;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0001B490 File Offset: 0x00019690
		public static string CommonSuffixWith(string _this_commonSuffixWith, string other, bool ignoreCase)
		{
			object obj = (_this_commonSuffixWith == null) ? null : new Java.Lang.String(_this_commonSuffixWith);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			string result = StringsKt.CommonSuffixWith(obj2, @string, ignoreCase);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0001B4D4 File Offset: 0x000196D4
		[Register("contains", "(Ljava/lang/CharSequence;CZ)Z", "")]
		public unsafe static bool Contains(ICharSequence _this_contains, char @char, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_contains);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(@char);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("contains.(Ljava/lang/CharSequence;CZ)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001B560 File Offset: 0x00019760
		public static bool Contains(string _this_contains, char @char, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_contains == null) ? null : new Java.Lang.String(_this_contains);
			bool result = StringsKt.Contains(@string, @char, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0001B58C File Offset: 0x0001978C
		[Register("contains", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Z", "")]
		public unsafe static bool Contains(ICharSequence _this_contains, ICharSequence other, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_contains);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("contains.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_contains);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001B62C File Offset: 0x0001982C
		public static bool Contains(string _this_contains, string other, bool ignoreCase)
		{
			object obj = (_this_contains == null) ? null : new Java.Lang.String(_this_contains);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			bool result = StringsKt.Contains(obj2, @string, ignoreCase);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0001B670 File Offset: 0x00019870
		[NullableContext(2)]
		[Register("contentEqualsIgnoreCaseImpl", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public unsafe static bool ContentEqualsIgnoreCaseImpl(ICharSequence _this_contentEqualsIgnoreCaseImpl, ICharSequence other)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_contentEqualsIgnoreCaseImpl);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("contentEqualsIgnoreCaseImpl.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_contentEqualsIgnoreCaseImpl);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0001B6F8 File Offset: 0x000198F8
		[NullableContext(2)]
		public static bool ContentEqualsIgnoreCaseImpl(string _this_contentEqualsIgnoreCaseImpl, string other)
		{
			object obj = (_this_contentEqualsIgnoreCaseImpl == null) ? null : new Java.Lang.String(_this_contentEqualsIgnoreCaseImpl);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			bool result = StringsKt.ContentEqualsIgnoreCaseImpl(obj2, @string);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0001B73C File Offset: 0x0001993C
		[NullableContext(2)]
		[Register("contentEqualsImpl", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public unsafe static bool ContentEqualsImpl(ICharSequence _this_contentEqualsImpl, ICharSequence other)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_contentEqualsImpl);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("contentEqualsImpl.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_contentEqualsImpl);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0001B7C4 File Offset: 0x000199C4
		[NullableContext(2)]
		public static bool ContentEqualsImpl(string _this_contentEqualsImpl, string other)
		{
			object obj = (_this_contentEqualsImpl == null) ? null : new Java.Lang.String(_this_contentEqualsImpl);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			bool result = StringsKt.ContentEqualsImpl(obj2, @string);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0001B808 File Offset: 0x00019A08
		[Register("endsWith", "(Ljava/lang/CharSequence;CZ)Z", "")]
		public unsafe static bool EndsWith(ICharSequence _this_endsWith, char @char, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_endsWith);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(@char);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("endsWith.(Ljava/lang/CharSequence;CZ)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_endsWith);
			}
			return result;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0001B894 File Offset: 0x00019A94
		public static bool EndsWith(string _this_endsWith, char @char, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_endsWith == null) ? null : new Java.Lang.String(_this_endsWith);
			bool result = StringsKt.EndsWith(@string, @char, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001B8C0 File Offset: 0x00019AC0
		[Register("endsWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Z", "")]
		public unsafe static bool EndsWith(ICharSequence _this_endsWith, ICharSequence suffix, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_endsWith);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(suffix);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("endsWith.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_endsWith);
				GC.KeepAlive(suffix);
			}
			return result;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001B960 File Offset: 0x00019B60
		[Register("findAnyOf", "(Ljava/lang/CharSequence;Ljava/util/Collection;IZ)Lkotlin/Pair;", "")]
		[return: Nullable(2)]
		public unsafe static Pair FindAnyOf(ICharSequence _this_findAnyOf, ICollection<string> strings, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_findAnyOf);
			IntPtr intPtr2 = JavaCollection<string>.ToLocalJniHandle(strings);
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				@object = Java.Lang.Object.GetObject<Pair>(StringsKt._members.StaticMethods.InvokeObjectMethod("findAnyOf.(Ljava/lang/CharSequence;Ljava/util/Collection;IZ)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_findAnyOf);
				GC.KeepAlive(strings);
			}
			return @object;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0001BA24 File Offset: 0x00019C24
		[return: Nullable(2)]
		public static Pair FindAnyOf(string _this_findAnyOf, ICollection<string> strings, int startIndex, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_findAnyOf == null) ? null : new Java.Lang.String(_this_findAnyOf);
			Pair result = StringsKt.FindAnyOf(@string, strings, startIndex, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0001BA50 File Offset: 0x00019C50
		[Register("findLastAnyOf", "(Ljava/lang/CharSequence;Ljava/util/Collection;IZ)Lkotlin/Pair;", "")]
		[return: Nullable(2)]
		public unsafe static Pair FindLastAnyOf(ICharSequence _this_findLastAnyOf, ICollection<string> strings, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_findLastAnyOf);
			IntPtr intPtr2 = JavaCollection<string>.ToLocalJniHandle(strings);
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				@object = Java.Lang.Object.GetObject<Pair>(StringsKt._members.StaticMethods.InvokeObjectMethod("findLastAnyOf.(Ljava/lang/CharSequence;Ljava/util/Collection;IZ)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_findLastAnyOf);
				GC.KeepAlive(strings);
			}
			return @object;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0001BB14 File Offset: 0x00019D14
		[return: Nullable(2)]
		public static Pair FindLastAnyOf(string _this_findLastAnyOf, ICollection<string> strings, int startIndex, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_findLastAnyOf == null) ? null : new Java.Lang.String(_this_findLastAnyOf);
			Pair result = StringsKt.FindLastAnyOf(@string, strings, startIndex, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0001BB40 File Offset: 0x00019D40
		[Register("getIndices", "(Ljava/lang/CharSequence;)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange GetIndices(ICharSequence _this_indices)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_indices);
			IntRange @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IntRange>(StringsKt._members.StaticMethods.InvokeObjectMethod("getIndices.(Ljava/lang/CharSequence;)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indices);
			}
			return @object;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0001BBB0 File Offset: 0x00019DB0
		public static IntRange GetIndices(string _this_indices)
		{
			Java.Lang.String @string = (_this_indices == null) ? null : new Java.Lang.String(_this_indices);
			IntRange indices = StringsKt.GetIndices(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return indices;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0001BBDC File Offset: 0x00019DDC
		[Register("getLastIndex", "(Ljava/lang/CharSequence;)I", "")]
		public unsafe static int GetLastIndex(ICharSequence _this_lastIndex)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lastIndex);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("getLastIndex.(Ljava/lang/CharSequence;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastIndex);
			}
			return result;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0001BC40 File Offset: 0x00019E40
		public static int GetLastIndex(string _this_lastIndex)
		{
			Java.Lang.String @string = (_this_lastIndex == null) ? null : new Java.Lang.String(_this_lastIndex);
			int lastIndex = StringsKt.GetLastIndex(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return lastIndex;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0001BC6C File Offset: 0x00019E6C
		[Register("hasSurrogatePairAt", "(Ljava/lang/CharSequence;I)Z", "")]
		public unsafe static bool HasSurrogatePairAt(ICharSequence _this_hasSurrogatePairAt, int index)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_hasSurrogatePairAt);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("hasSurrogatePairAt.(Ljava/lang/CharSequence;I)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_hasSurrogatePairAt);
			}
			return result;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0001BCE4 File Offset: 0x00019EE4
		public static bool HasSurrogatePairAt(string _this_hasSurrogatePairAt, int index)
		{
			Java.Lang.String @string = (_this_hasSurrogatePairAt == null) ? null : new Java.Lang.String(_this_hasSurrogatePairAt);
			bool result = StringsKt.HasSurrogatePairAt(@string, index);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001BD10 File Offset: 0x00019F10
		[Register("indexOf", "(Ljava/lang/CharSequence;CIZ)I", "")]
		public unsafe static int IndexOf(ICharSequence _this_indexOf, char @char, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_indexOf);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(@char);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("indexOf.(Ljava/lang/CharSequence;CIZ)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_indexOf);
			}
			return result;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001BDB4 File Offset: 0x00019FB4
		public static int IndexOf(string _this_indexOf, char @char, int startIndex, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_indexOf == null) ? null : new Java.Lang.String(_this_indexOf);
			int result = StringsKt.IndexOf(@string, @char, startIndex, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		[Register("indexOf", "(Ljava/lang/CharSequence;Ljava/lang/String;IZ)I", "")]
		public unsafe static int IndexOf(ICharSequence _this_indexOf, string @string, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_indexOf);
			IntPtr intPtr2 = JNIEnv.NewString(@string);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("indexOf.(Ljava/lang/CharSequence;Ljava/lang/String;IZ)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_indexOf);
			}
			return result;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0001BE90 File Offset: 0x0001A090
		public static int IndexOf(string _this_indexOf, string @string, int startIndex, bool ignoreCase)
		{
			Java.Lang.String string2 = (_this_indexOf == null) ? null : new Java.Lang.String(_this_indexOf);
			int result = StringsKt.IndexOf(string2, @string, startIndex, ignoreCase);
			if (string2 != null)
			{
				string2.Dispose();
			}
			return result;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0001BEBC File Offset: 0x0001A0BC
		[Register("indexOfAny", "(Ljava/lang/CharSequence;[CIZ)I", "")]
		public unsafe static int IndexOfAny(ICharSequence _this_indexOfAny, char[] chars, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_indexOfAny);
			IntPtr intPtr2 = JNIEnv.NewArray(chars);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("indexOfAny.(Ljava/lang/CharSequence;[CIZ)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (chars != null)
				{
					JNIEnv.CopyArray(intPtr2, chars);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_indexOfAny);
				GC.KeepAlive(chars);
			}
			return result;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0001BF7C File Offset: 0x0001A17C
		public static int IndexOfAny(string _this_indexOfAny, char[] chars, int startIndex, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_indexOfAny == null) ? null : new Java.Lang.String(_this_indexOfAny);
			int result = StringsKt.IndexOfAny(@string, chars, startIndex, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		[Register("indexOfAny", "(Ljava/lang/CharSequence;Ljava/util/Collection;IZ)I", "")]
		public unsafe static int IndexOfAny(ICharSequence _this_indexOfAny, ICollection<string> strings, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_indexOfAny);
			IntPtr intPtr2 = JavaCollection<string>.ToLocalJniHandle(strings);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("indexOfAny.(Ljava/lang/CharSequence;Ljava/util/Collection;IZ)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_indexOfAny);
				GC.KeepAlive(strings);
			}
			return result;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0001C05C File Offset: 0x0001A25C
		public static int IndexOfAny(string _this_indexOfAny, ICollection<string> strings, int startIndex, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_indexOfAny == null) ? null : new Java.Lang.String(_this_indexOfAny);
			int result = StringsKt.IndexOfAny(@string, strings, startIndex, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0001C088 File Offset: 0x0001A288
		[Register("iterator", "(Ljava/lang/CharSequence;)Lkotlin/collections/CharIterator;", "")]
		public unsafe static CharIterator Iterator(ICharSequence _this_iterator)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_iterator);
			CharIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CharIterator>(StringsKt._members.StaticMethods.InvokeObjectMethod("iterator.(Ljava/lang/CharSequence;)Lkotlin/collections/CharIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_iterator);
			}
			return @object;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		public static CharIterator Iterator(string _this_iterator)
		{
			Java.Lang.String @string = (_this_iterator == null) ? null : new Java.Lang.String(_this_iterator);
			CharIterator result = StringsKt.Iterator(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0001C124 File Offset: 0x0001A324
		[Register("lastIndexOf", "(Ljava/lang/CharSequence;CIZ)I", "")]
		public unsafe static int LastIndexOf(ICharSequence _this_lastIndexOf, char @char, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lastIndexOf);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(@char);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("lastIndexOf.(Ljava/lang/CharSequence;CIZ)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lastIndexOf);
			}
			return result;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		public static int LastIndexOf(string _this_lastIndexOf, char @char, int startIndex, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_lastIndexOf == null) ? null : new Java.Lang.String(_this_lastIndexOf);
			int result = StringsKt.LastIndexOf(@string, @char, startIndex, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
		[Register("lastIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/String;IZ)I", "")]
		public unsafe static int LastIndexOf(ICharSequence _this_lastIndexOf, string @string, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lastIndexOf);
			IntPtr intPtr2 = JNIEnv.NewString(@string);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("lastIndexOf.(Ljava/lang/CharSequence;Ljava/lang/String;IZ)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_lastIndexOf);
			}
			return result;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
		public static int LastIndexOf(string _this_lastIndexOf, string @string, int startIndex, bool ignoreCase)
		{
			Java.Lang.String string2 = (_this_lastIndexOf == null) ? null : new Java.Lang.String(_this_lastIndexOf);
			int result = StringsKt.LastIndexOf(string2, @string, startIndex, ignoreCase);
			if (string2 != null)
			{
				string2.Dispose();
			}
			return result;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
		[Register("lastIndexOfAny", "(Ljava/lang/CharSequence;[CIZ)I", "")]
		public unsafe static int LastIndexOfAny(ICharSequence _this_lastIndexOfAny, char[] chars, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lastIndexOfAny);
			IntPtr intPtr2 = JNIEnv.NewArray(chars);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("lastIndexOfAny.(Ljava/lang/CharSequence;[CIZ)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (chars != null)
				{
					JNIEnv.CopyArray(intPtr2, chars);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_lastIndexOfAny);
				GC.KeepAlive(chars);
			}
			return result;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0001C390 File Offset: 0x0001A590
		public static int LastIndexOfAny(string _this_lastIndexOfAny, char[] chars, int startIndex, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_lastIndexOfAny == null) ? null : new Java.Lang.String(_this_lastIndexOfAny);
			int result = StringsKt.LastIndexOfAny(@string, chars, startIndex, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0001C3BC File Offset: 0x0001A5BC
		[Register("lastIndexOfAny", "(Ljava/lang/CharSequence;Ljava/util/Collection;IZ)I", "")]
		public unsafe static int LastIndexOfAny(ICharSequence _this_lastIndexOfAny, ICollection<string> strings, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lastIndexOfAny);
			IntPtr intPtr2 = JavaCollection<string>.ToLocalJniHandle(strings);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("lastIndexOfAny.(Ljava/lang/CharSequence;Ljava/util/Collection;IZ)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_lastIndexOfAny);
				GC.KeepAlive(strings);
			}
			return result;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0001C470 File Offset: 0x0001A670
		public static int LastIndexOfAny(string _this_lastIndexOfAny, ICollection<string> strings, int startIndex, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_lastIndexOfAny == null) ? null : new Java.Lang.String(_this_lastIndexOfAny);
			int result = StringsKt.LastIndexOfAny(@string, strings, startIndex, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0001C49C File Offset: 0x0001A69C
		[Register("lineSequence", "(Ljava/lang/CharSequence;)Lkotlin/sequences/Sequence;", "")]
		public unsafe static ISequence LineSequence(ICharSequence _this_lineSequence)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lineSequence);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("lineSequence.(Ljava/lang/CharSequence;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lineSequence);
			}
			return @object;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0001C50C File Offset: 0x0001A70C
		public static ISequence LineSequence(string _this_lineSequence)
		{
			Java.Lang.String @string = (_this_lineSequence == null) ? null : new Java.Lang.String(_this_lineSequence);
			ISequence result = StringsKt.LineSequence(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0001C538 File Offset: 0x0001A738
		[Register("lines", "(Ljava/lang/CharSequence;)Ljava/util/List;", "")]
		public unsafe static IList<string> Lines(ICharSequence _this_lines)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_lines);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<string>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("lines.(Ljava/lang/CharSequence;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_lines);
			}
			return result;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		public static IList<string> Lines(string _this_lines)
		{
			Java.Lang.String @string = (_this_lines == null) ? null : new Java.Lang.String(_this_lines);
			IList<string> result = StringsKt.Lines(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0001C5D4 File Offset: 0x0001A7D4
		[Register("padEnd", "(Ljava/lang/CharSequence;IC)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence PadEndFormatted(ICharSequence _this_padEnd, int length, char padChar)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_padEnd);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(length);
				ptr[2] = new JniArgumentValue(padChar);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("padEnd.(Ljava/lang/CharSequence;IC)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_padEnd);
			}
			return @object;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0001C670 File Offset: 0x0001A870
		public static string PadEnd(string _this_padEnd, int length, char padChar)
		{
			Java.Lang.String @string = (_this_padEnd == null) ? null : new Java.Lang.String(_this_padEnd);
			ICharSequence charSequence = StringsKt.PadEndFormatted(@string, length, padChar);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
		[Register("padStart", "(Ljava/lang/CharSequence;IC)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence PadStartFormatted(ICharSequence _this_padStart, int length, char padChar)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_padStart);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(length);
				ptr[2] = new JniArgumentValue(padChar);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("padStart.(Ljava/lang/CharSequence;IC)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_padStart);
			}
			return @object;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001C744 File Offset: 0x0001A944
		public static string PadStart(string _this_padStart, int length, char padChar)
		{
			Java.Lang.String @string = (_this_padStart == null) ? null : new Java.Lang.String(_this_padStart);
			ICharSequence charSequence = StringsKt.PadStartFormatted(@string, length, padChar);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0001C77C File Offset: 0x0001A97C
		[Register("regionMatchesImpl", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;IIZ)Z", "")]
		public unsafe static bool RegionMatchesImpl(ICharSequence _this_regionMatchesImpl, int thisOffset, ICharSequence other, int otherOffset, int length, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_regionMatchesImpl);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(thisOffset);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(otherOffset);
				ptr[4] = new JniArgumentValue(length);
				ptr[5] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("regionMatchesImpl.(Ljava/lang/CharSequence;ILjava/lang/CharSequence;IIZ)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_regionMatchesImpl);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0001C860 File Offset: 0x0001AA60
		public static bool RegionMatchesImpl(string _this_regionMatchesImpl, int thisOffset, string other, int otherOffset, int length, bool ignoreCase)
		{
			object obj = (_this_regionMatchesImpl == null) ? null : new Java.Lang.String(_this_regionMatchesImpl);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			bool result = StringsKt.RegionMatchesImpl(obj2, thisOffset, @string, otherOffset, length, ignoreCase);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0001C8AC File Offset: 0x0001AAAC
		[Register("removePrefix", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence RemovePrefixFormatted(ICharSequence _this_removePrefix, ICharSequence prefix)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_removePrefix);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(prefix);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("removePrefix.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_removePrefix);
				GC.KeepAlive(prefix);
			}
			return @object;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0001C944 File Offset: 0x0001AB44
		public static string RemovePrefix(string _this_removePrefix, string prefix)
		{
			object obj = (_this_removePrefix == null) ? null : new Java.Lang.String(_this_removePrefix);
			Java.Lang.String @string = (prefix == null) ? null : new Java.Lang.String(prefix);
			object obj2 = obj;
			ICharSequence charSequence = StringsKt.RemovePrefixFormatted(obj2, @string);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0001C994 File Offset: 0x0001AB94
		[Register("removeRange", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence RemoveRangeFormatted(ICharSequence _this_removeRange, int startIndex, int endIndex)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_removeRange);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("removeRange.(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeRange);
			}
			return @object;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0001CA30 File Offset: 0x0001AC30
		public static string RemoveRange(string _this_removeRange, int startIndex, int endIndex)
		{
			Java.Lang.String @string = (_this_removeRange == null) ? null : new Java.Lang.String(_this_removeRange);
			ICharSequence charSequence = StringsKt.RemoveRangeFormatted(@string, startIndex, endIndex);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0001CA68 File Offset: 0x0001AC68
		[Register("removeRange", "(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence RemoveRangeFormatted(ICharSequence _this_removeRange, IntRange range)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_removeRange);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("removeRange.(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_removeRange);
				GC.KeepAlive(range);
			}
			return @object;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0001CB00 File Offset: 0x0001AD00
		public static string RemoveRange(string _this_removeRange, IntRange range)
		{
			Java.Lang.String @string = (_this_removeRange == null) ? null : new Java.Lang.String(_this_removeRange);
			ICharSequence charSequence = StringsKt.RemoveRangeFormatted(@string, range);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0001CB38 File Offset: 0x0001AD38
		[Register("removeSuffix", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence RemoveSuffixFormatted(ICharSequence _this_removeSuffix, ICharSequence suffix)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_removeSuffix);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(suffix);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("removeSuffix.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_removeSuffix);
				GC.KeepAlive(suffix);
			}
			return @object;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0001CBD0 File Offset: 0x0001ADD0
		public static string RemoveSuffix(string _this_removeSuffix, string suffix)
		{
			object obj = (_this_removeSuffix == null) ? null : new Java.Lang.String(_this_removeSuffix);
			Java.Lang.String @string = (suffix == null) ? null : new Java.Lang.String(suffix);
			object obj2 = obj;
			ICharSequence charSequence = StringsKt.RemoveSuffixFormatted(obj2, @string);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0001CC20 File Offset: 0x0001AE20
		[Register("removeSurrounding", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence RemoveSurroundingFormatted(ICharSequence _this_removeSurrounding, ICharSequence delimiter)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_removeSurrounding);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(delimiter);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("removeSurrounding.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_removeSurrounding);
				GC.KeepAlive(delimiter);
			}
			return @object;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
		public static string RemoveSurrounding(string _this_removeSurrounding, string delimiter)
		{
			object obj = (_this_removeSurrounding == null) ? null : new Java.Lang.String(_this_removeSurrounding);
			Java.Lang.String @string = (delimiter == null) ? null : new Java.Lang.String(delimiter);
			object obj2 = obj;
			ICharSequence charSequence = StringsKt.RemoveSurroundingFormatted(obj2, @string);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0001CD08 File Offset: 0x0001AF08
		[Register("removeSurrounding", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence RemoveSurroundingFormatted(ICharSequence _this_removeSurrounding, ICharSequence prefix, ICharSequence suffix)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_removeSurrounding);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(prefix);
			IntPtr intPtr3 = CharSequence.ToLocalJniHandle(suffix);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("removeSurrounding.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(_this_removeSurrounding);
				GC.KeepAlive(prefix);
				GC.KeepAlive(suffix);
			}
			return @object;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0001CDCC File Offset: 0x0001AFCC
		public static string RemoveSurrounding(string _this_removeSurrounding, string prefix, string suffix)
		{
			object obj = (_this_removeSurrounding == null) ? null : new Java.Lang.String(_this_removeSurrounding);
			Java.Lang.String @string = (prefix == null) ? null : new Java.Lang.String(prefix);
			Java.Lang.String string2 = (suffix == null) ? null : new Java.Lang.String(suffix);
			object obj2 = obj;
			ICharSequence charSequence = StringsKt.RemoveSurroundingFormatted(obj2, @string, string2);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			if (string2 != null)
			{
				string2.Dispose();
			}
			return result;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0001CE34 File Offset: 0x0001B034
		[Register("replaceAfter", "(Ljava/lang/String;CLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceAfter(string _this_replaceAfter, char delimiter, string replacement, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceAfter);
			IntPtr intPtr2 = JNIEnv.NewString(replacement);
			IntPtr intPtr3 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(delimiter);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceAfter.(Ljava/lang/String;CLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0001CEFC File Offset: 0x0001B0FC
		[Register("replaceAfter", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceAfter(string _this_replaceAfter, string delimiter, string replacement, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceAfter);
			IntPtr intPtr2 = JNIEnv.NewString(delimiter);
			IntPtr intPtr3 = JNIEnv.NewString(replacement);
			IntPtr intPtr4 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceAfter.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
			}
			return @string;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		[Register("replaceAfterLast", "(Ljava/lang/String;CLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceAfterLast(string _this_replaceAfterLast, char delimiter, string replacement, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceAfterLast);
			IntPtr intPtr2 = JNIEnv.NewString(replacement);
			IntPtr intPtr3 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(delimiter);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceAfterLast.(Ljava/lang/String;CLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		[Register("replaceAfterLast", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceAfterLast(string _this_replaceAfterLast, string delimiter, string replacement, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceAfterLast);
			IntPtr intPtr2 = JNIEnv.NewString(delimiter);
			IntPtr intPtr3 = JNIEnv.NewString(replacement);
			IntPtr intPtr4 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceAfterLast.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
			}
			return @string;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0001D17C File Offset: 0x0001B37C
		[Register("replaceBefore", "(Ljava/lang/String;CLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceBefore(string _this_replaceBefore, char delimiter, string replacement, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceBefore);
			IntPtr intPtr2 = JNIEnv.NewString(replacement);
			IntPtr intPtr3 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(delimiter);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceBefore.(Ljava/lang/String;CLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0001D244 File Offset: 0x0001B444
		[Register("replaceBefore", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceBefore(string _this_replaceBefore, string delimiter, string replacement, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceBefore);
			IntPtr intPtr2 = JNIEnv.NewString(delimiter);
			IntPtr intPtr3 = JNIEnv.NewString(replacement);
			IntPtr intPtr4 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceBefore.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
			}
			return @string;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0001D320 File Offset: 0x0001B520
		[Register("replaceBeforeLast", "(Ljava/lang/String;CLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceBeforeLast(string _this_replaceBeforeLast, char delimiter, string replacement, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceBeforeLast);
			IntPtr intPtr2 = JNIEnv.NewString(replacement);
			IntPtr intPtr3 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(delimiter);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceBeforeLast.(Ljava/lang/String;CLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		[Register("replaceBeforeLast", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceBeforeLast(string _this_replaceBeforeLast, string delimiter, string replacement, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceBeforeLast);
			IntPtr intPtr2 = JNIEnv.NewString(delimiter);
			IntPtr intPtr3 = JNIEnv.NewString(replacement);
			IntPtr intPtr4 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceBeforeLast.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
			}
			return @string;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
		[Register("replaceRange", "(Ljava/lang/CharSequence;IILjava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence ReplaceRangeFormatted(ICharSequence _this_replaceRange, int startIndex, int endIndex, ICharSequence replacement)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_replaceRange);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(replacement);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				ptr[3] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceRange.(Ljava/lang/CharSequence;IILjava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_replaceRange);
				GC.KeepAlive(replacement);
			}
			return @object;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0001D588 File Offset: 0x0001B788
		public static string ReplaceRange(string _this_replaceRange, int startIndex, int endIndex, string replacement)
		{
			Java.Lang.String @string = (_this_replaceRange == null) ? null : new Java.Lang.String(_this_replaceRange);
			Java.Lang.String string2 = (replacement == null) ? null : new Java.Lang.String(replacement);
			ICharSequence charSequence = StringsKt.ReplaceRangeFormatted(@string, startIndex, endIndex, string2);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			if (string2 != null)
			{
				string2.Dispose();
			}
			return result;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0001D5D8 File Offset: 0x0001B7D8
		[Register("replaceRange", "(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence ReplaceRangeFormatted(ICharSequence _this_replaceRange, IntRange range, ICharSequence replacement)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_replaceRange);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(replacement);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceRange.(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_replaceRange);
				GC.KeepAlive(range);
				GC.KeepAlive(replacement);
			}
			return @object;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0001D69C File Offset: 0x0001B89C
		public static string ReplaceRange(string _this_replaceRange, IntRange range, string replacement)
		{
			Java.Lang.String @string = (_this_replaceRange == null) ? null : new Java.Lang.String(_this_replaceRange);
			Java.Lang.String string2 = (replacement == null) ? null : new Java.Lang.String(replacement);
			ICharSequence charSequence = StringsKt.ReplaceRangeFormatted(@string, range, string2);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			if (string2 != null)
			{
				string2.Dispose();
			}
			return result;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0001D6EC File Offset: 0x0001B8EC
		[Register("requireNonNegativeLimit", "(I)V", "")]
		public unsafe static void RequireNonNegativeLimit(int limit)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(limit);
			StringsKt._members.StaticMethods.InvokeVoidMethod("requireNonNegativeLimit.(I)V", ptr);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0001D728 File Offset: 0x0001B928
		[Register("split", "(Ljava/lang/CharSequence;[CZI)Ljava/util/List;", "")]
		public unsafe static IList<string> Split(ICharSequence _this_split, char[] delimiters, bool ignoreCase, int limit)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_split);
			IntPtr intPtr2 = JNIEnv.NewArray(delimiters);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				ptr[3] = new JniArgumentValue(limit);
				result = JavaList<string>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("split.(Ljava/lang/CharSequence;[CZI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (delimiters != null)
				{
					JNIEnv.CopyArray(intPtr2, delimiters);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_split);
				GC.KeepAlive(delimiters);
			}
			return result;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
		public static IList<string> Split(string _this_split, char[] delimiters, bool ignoreCase, int limit)
		{
			Java.Lang.String @string = (_this_split == null) ? null : new Java.Lang.String(_this_split);
			IList<string> result = StringsKt.Split(@string, delimiters, ignoreCase, limit);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0001D824 File Offset: 0x0001BA24
		[Register("split", "(Ljava/lang/CharSequence;[Ljava/lang/String;ZI)Ljava/util/List;", "")]
		public unsafe static IList<string> Split(ICharSequence _this_split, string[] delimiters, bool ignoreCase, int limit)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_split);
			IntPtr intPtr2 = JNIEnv.NewArray(delimiters);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				ptr[3] = new JniArgumentValue(limit);
				result = JavaList<string>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("split.(Ljava/lang/CharSequence;[Ljava/lang/String;ZI)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (delimiters != null)
				{
					JNIEnv.CopyArray(intPtr2, delimiters);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_split);
				GC.KeepAlive(delimiters);
			}
			return result;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
		public static IList<string> Split(string _this_split, string[] delimiters, bool ignoreCase, int limit)
		{
			Java.Lang.String @string = (_this_split == null) ? null : new Java.Lang.String(_this_split);
			IList<string> result = StringsKt.Split(@string, delimiters, ignoreCase, limit);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0001D920 File Offset: 0x0001BB20
		[Register("splitToSequence", "(Ljava/lang/CharSequence;[CZI)Lkotlin/sequences/Sequence;", "")]
		public unsafe static ISequence SplitToSequence(ICharSequence _this_splitToSequence, char[] delimiters, bool ignoreCase, int limit)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_splitToSequence);
			IntPtr intPtr2 = JNIEnv.NewArray(delimiters);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				ptr[3] = new JniArgumentValue(limit);
				@object = Java.Lang.Object.GetObject<ISequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("splitToSequence.(Ljava/lang/CharSequence;[CZI)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (delimiters != null)
				{
					JNIEnv.CopyArray(intPtr2, delimiters);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_splitToSequence);
				GC.KeepAlive(delimiters);
			}
			return @object;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		public static ISequence SplitToSequence(string _this_splitToSequence, char[] delimiters, bool ignoreCase, int limit)
		{
			Java.Lang.String @string = (_this_splitToSequence == null) ? null : new Java.Lang.String(_this_splitToSequence);
			ISequence result = StringsKt.SplitToSequence(@string, delimiters, ignoreCase, limit);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001DA1C File Offset: 0x0001BC1C
		[Register("splitToSequence", "(Ljava/lang/CharSequence;[Ljava/lang/String;ZI)Lkotlin/sequences/Sequence;", "")]
		public unsafe static ISequence SplitToSequence(ICharSequence _this_splitToSequence, string[] delimiters, bool ignoreCase, int limit)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_splitToSequence);
			IntPtr intPtr2 = JNIEnv.NewArray(delimiters);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				ptr[3] = new JniArgumentValue(limit);
				@object = Java.Lang.Object.GetObject<ISequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("splitToSequence.(Ljava/lang/CharSequence;[Ljava/lang/String;ZI)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (delimiters != null)
				{
					JNIEnv.CopyArray(intPtr2, delimiters);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_splitToSequence);
				GC.KeepAlive(delimiters);
			}
			return @object;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0001DAEC File Offset: 0x0001BCEC
		public static ISequence SplitToSequence(string _this_splitToSequence, string[] delimiters, bool ignoreCase, int limit)
		{
			Java.Lang.String @string = (_this_splitToSequence == null) ? null : new Java.Lang.String(_this_splitToSequence);
			ISequence result = StringsKt.SplitToSequence(@string, delimiters, ignoreCase, limit);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0001DB18 File Offset: 0x0001BD18
		[Register("startsWith", "(Ljava/lang/CharSequence;CZ)Z", "")]
		public unsafe static bool StartsWith(ICharSequence _this_startsWith, char @char, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_startsWith);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(@char);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("startsWith.(Ljava/lang/CharSequence;CZ)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_startsWith);
			}
			return result;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0001DBA4 File Offset: 0x0001BDA4
		public static bool StartsWith(string _this_startsWith, char @char, bool ignoreCase)
		{
			Java.Lang.String @string = (_this_startsWith == null) ? null : new Java.Lang.String(_this_startsWith);
			bool result = StringsKt.StartsWith(@string, @char, ignoreCase);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
		[Register("startsWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Z", "")]
		public unsafe static bool StartsWith(ICharSequence _this_startsWith, ICharSequence prefix, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_startsWith);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(prefix);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("startsWith.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_startsWith);
				GC.KeepAlive(prefix);
			}
			return result;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0001DC70 File Offset: 0x0001BE70
		[Register("startsWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;IZ)Z", "")]
		public unsafe static bool StartsWith(ICharSequence _this_startsWith, ICharSequence prefix, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_startsWith);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(prefix);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("startsWith.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;IZ)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_startsWith);
				GC.KeepAlive(prefix);
			}
			return result;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0001DD24 File Offset: 0x0001BF24
		[Register("subSequence", "(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence SubSequenceFormatted(ICharSequence _this_subSequence, IntRange range)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_subSequence);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("subSequence.(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_subSequence);
				GC.KeepAlive(range);
			}
			return @object;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0001DDBC File Offset: 0x0001BFBC
		public static string SubSequence(string _this_subSequence, IntRange range)
		{
			Java.Lang.String @string = (_this_subSequence == null) ? null : new Java.Lang.String(_this_subSequence);
			ICharSequence charSequence = StringsKt.SubSequenceFormatted(@string, range);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0001DDF4 File Offset: 0x0001BFF4
		[Register("substring", "(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;)Ljava/lang/String;", "")]
		public unsafe static string Substring(ICharSequence _this_substring, IntRange range)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_substring);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substring.(Ljava/lang/CharSequence;Lkotlin/ranges/IntRange;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_substring);
				GC.KeepAlive(range);
			}
			return @string;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0001DE8C File Offset: 0x0001C08C
		[Register("substring", "(Ljava/lang/String;Lkotlin/ranges/IntRange;)Ljava/lang/String;", "")]
		public unsafe static string Substring(string _this_substring, IntRange range)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substring);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substring.(Ljava/lang/String;Lkotlin/ranges/IntRange;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(range);
			}
			return @string;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0001DF20 File Offset: 0x0001C120
		[Register("substringAfter", "(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string SubstringAfter(string _this_substringAfter, char delimiter, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substringAfter);
			IntPtr intPtr2 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(delimiter);
				ptr[2] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substringAfter.(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0001DFC4 File Offset: 0x0001C1C4
		[Register("substringAfter", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string SubstringAfter(string _this_substringAfter, string delimiter, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substringAfter);
			IntPtr intPtr2 = JNIEnv.NewString(delimiter);
			IntPtr intPtr3 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substringAfter.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0001E074 File Offset: 0x0001C274
		[Register("substringAfterLast", "(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string SubstringAfterLast(string _this_substringAfterLast, char delimiter, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substringAfterLast);
			IntPtr intPtr2 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(delimiter);
				ptr[2] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substringAfterLast.(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0001E118 File Offset: 0x0001C318
		[Register("substringAfterLast", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string SubstringAfterLast(string _this_substringAfterLast, string delimiter, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substringAfterLast);
			IntPtr intPtr2 = JNIEnv.NewString(delimiter);
			IntPtr intPtr3 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substringAfterLast.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		[Register("substringBefore", "(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string SubstringBefore(string _this_substringBefore, char delimiter, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substringBefore);
			IntPtr intPtr2 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(delimiter);
				ptr[2] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substringBefore.(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0001E26C File Offset: 0x0001C46C
		[Register("substringBefore", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string SubstringBefore(string _this_substringBefore, string delimiter, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substringBefore);
			IntPtr intPtr2 = JNIEnv.NewString(delimiter);
			IntPtr intPtr3 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substringBefore.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0001E31C File Offset: 0x0001C51C
		[Register("substringBeforeLast", "(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string SubstringBeforeLast(string _this_substringBeforeLast, char delimiter, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substringBeforeLast);
			IntPtr intPtr2 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(delimiter);
				ptr[2] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substringBeforeLast.(Ljava/lang/String;CLjava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		[Register("substringBeforeLast", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string SubstringBeforeLast(string _this_substringBeforeLast, string delimiter, string missingDelimiterValue)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_substringBeforeLast);
			IntPtr intPtr2 = JNIEnv.NewString(delimiter);
			IntPtr intPtr3 = JNIEnv.NewString(missingDelimiterValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("substringBeforeLast.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0001E470 File Offset: 0x0001C670
		[Register("toBooleanStrict", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool ToBooleanStrict(string _this_toBooleanStrict)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toBooleanStrict);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("toBooleanStrict.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0001E4CC File Offset: 0x0001C6CC
		[Register("toBooleanStrictOrNull", "(Ljava/lang/String;)Ljava/lang/Boolean;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Boolean ToBooleanStrictOrNull(string _this_toBooleanStrictOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toBooleanStrictOrNull);
			Java.Lang.Boolean @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Boolean>(StringsKt._members.StaticMethods.InvokeObjectMethod("toBooleanStrictOrNull.(Ljava/lang/String;)Ljava/lang/Boolean;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0001E538 File Offset: 0x0001C738
		[Register("trim", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimFormatted(ICharSequence _this_trim)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trim);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trim.(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_trim);
			}
			return @object;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0001E5A8 File Offset: 0x0001C7A8
		public static string Trim(string _this_trim)
		{
			Java.Lang.String @string = (_this_trim == null) ? null : new Java.Lang.String(_this_trim);
			ICharSequence charSequence = StringsKt.TrimFormatted(@string);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		[Register("trim", "(Ljava/lang/CharSequence;[C)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimFormatted(ICharSequence _this_trim, params char[] chars)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trim);
			IntPtr intPtr2 = JNIEnv.NewArray(chars);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trim.(Ljava/lang/CharSequence;[C)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (chars != null)
				{
					JNIEnv.CopyArray(intPtr2, chars);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_trim);
				GC.KeepAlive(chars);
			}
			return @object;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0001E684 File Offset: 0x0001C884
		public static string Trim(string _this_trim, params char[] chars)
		{
			Java.Lang.String @string = (_this_trim == null) ? null : new Java.Lang.String(_this_trim);
			ICharSequence charSequence = StringsKt.TrimFormatted(@string, chars);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0001E6BC File Offset: 0x0001C8BC
		[Register("trim", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimFormatted(ICharSequence _this_trim, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trim);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trim.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_trim);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0001E75C File Offset: 0x0001C95C
		public static string Trim(string _this_trim, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_trim == null) ? null : new Java.Lang.String(_this_trim);
			ICharSequence charSequence = StringsKt.TrimFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0001E794 File Offset: 0x0001C994
		[Register("trimEnd", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimEndFormatted(ICharSequence _this_trimEnd)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trimEnd);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trimEnd.(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_trimEnd);
			}
			return @object;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0001E804 File Offset: 0x0001CA04
		public static string TrimEnd(string _this_trimEnd)
		{
			Java.Lang.String @string = (_this_trimEnd == null) ? null : new Java.Lang.String(_this_trimEnd);
			ICharSequence charSequence = StringsKt.TrimEndFormatted(@string);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0001E83C File Offset: 0x0001CA3C
		[Register("trimEnd", "(Ljava/lang/CharSequence;[C)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimEndFormatted(ICharSequence _this_trimEnd, params char[] chars)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trimEnd);
			IntPtr intPtr2 = JNIEnv.NewArray(chars);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trimEnd.(Ljava/lang/CharSequence;[C)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (chars != null)
				{
					JNIEnv.CopyArray(intPtr2, chars);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_trimEnd);
				GC.KeepAlive(chars);
			}
			return @object;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0001E8E0 File Offset: 0x0001CAE0
		public static string TrimEnd(string _this_trimEnd, params char[] chars)
		{
			Java.Lang.String @string = (_this_trimEnd == null) ? null : new Java.Lang.String(_this_trimEnd);
			ICharSequence charSequence = StringsKt.TrimEndFormatted(@string, chars);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0001E918 File Offset: 0x0001CB18
		[Register("trimEnd", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimEndFormatted(ICharSequence _this_trimEnd, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trimEnd);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trimEnd.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_trimEnd);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0001E9B8 File Offset: 0x0001CBB8
		public static string TrimEnd(string _this_trimEnd, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_trimEnd == null) ? null : new Java.Lang.String(_this_trimEnd);
			ICharSequence charSequence = StringsKt.TrimEndFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
		[Register("trimStart", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimStartFormatted(ICharSequence _this_trimStart)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trimStart);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trimStart.(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_trimStart);
			}
			return @object;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0001EA60 File Offset: 0x0001CC60
		public static string TrimStart(string _this_trimStart)
		{
			Java.Lang.String @string = (_this_trimStart == null) ? null : new Java.Lang.String(_this_trimStart);
			ICharSequence charSequence = StringsKt.TrimStartFormatted(@string);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0001EA98 File Offset: 0x0001CC98
		[Register("trimStart", "(Ljava/lang/CharSequence;[C)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimStartFormatted(ICharSequence _this_trimStart, params char[] chars)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trimStart);
			IntPtr intPtr2 = JNIEnv.NewArray(chars);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trimStart.(Ljava/lang/CharSequence;[C)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (chars != null)
				{
					JNIEnv.CopyArray(intPtr2, chars);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_trimStart);
				GC.KeepAlive(chars);
			}
			return @object;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0001EB3C File Offset: 0x0001CD3C
		public static string TrimStart(string _this_trimStart, params char[] chars)
		{
			Java.Lang.String @string = (_this_trimStart == null) ? null : new Java.Lang.String(_this_trimStart);
			ICharSequence charSequence = StringsKt.TrimStartFormatted(@string, chars);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0001EB74 File Offset: 0x0001CD74
		[Register("trimStart", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence TrimStartFormatted(ICharSequence _this_trimStart, IFunction1 predicate)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_trimStart);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(StringsKt._members.StaticMethods.InvokeObjectMethod("trimStart.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_trimStart);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0001EC14 File Offset: 0x0001CE14
		public static string TrimStart(string _this_trimStart, IFunction1 predicate)
		{
			Java.Lang.String @string = (_this_trimStart == null) ? null : new Java.Lang.String(_this_trimStart);
			ICharSequence charSequence = StringsKt.TrimStartFormatted(@string, predicate);
			string result = (charSequence != null) ? charSequence.ToString() : null;
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		[Obsolete("deprecated")]
		[Register("capitalize", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string Capitalize(string _this_capitalize)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_capitalize);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("capitalize.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
		[Obsolete("deprecated")]
		[Register("capitalize", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public unsafe static string Capitalize(string _this_capitalize, Locale locale)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_capitalize);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((locale == null) ? IntPtr.Zero : locale.Handle);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("capitalize.(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(locale);
			}
			return @string;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0001ED4C File Offset: 0x0001CF4C
		[Register("compareTo", "(Ljava/lang/String;Ljava/lang/String;Z)I", "")]
		public unsafe static int CompareTo(string _this_compareTo, string other, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_compareTo);
			IntPtr intPtr2 = JNIEnv.NewString(other);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeInt32Method("compareTo.(Ljava/lang/String;Ljava/lang/String;Z)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		[Register("concatToString", "([C)Ljava/lang/String;", "")]
		public unsafe static string ConcatToString(char[] _this_concatToString)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_concatToString);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("concatToString.([C)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_concatToString != null)
				{
					JNIEnv.CopyArray(intPtr, _this_concatToString);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_concatToString);
			}
			return @string;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0001EE5C File Offset: 0x0001D05C
		[Register("concatToString", "([CII)Ljava/lang/String;", "")]
		public unsafe static string ConcatToString(char[] _this_concatToString, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_concatToString);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("concatToString.([CII)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_concatToString != null)
				{
					JNIEnv.CopyArray(intPtr, _this_concatToString);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_concatToString);
			}
			return @string;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0001EF00 File Offset: 0x0001D100
		[NullableContext(2)]
		[Register("contentEquals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public unsafe static bool ContentEquals(ICharSequence _this_contentEquals, ICharSequence other)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_contentEquals);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("contentEquals.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_contentEquals);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0001EF88 File Offset: 0x0001D188
		[NullableContext(2)]
		public static bool ContentEquals(string _this_contentEquals, string other)
		{
			object obj = (_this_contentEquals == null) ? null : new Java.Lang.String(_this_contentEquals);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			bool result = StringsKt.ContentEquals(obj2, @string);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		[NullableContext(2)]
		[Register("contentEquals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Z", "")]
		public unsafe static bool ContentEquals(ICharSequence _this_contentEquals, ICharSequence other, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_contentEquals);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("contentEquals.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_contentEquals);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0001F06C File Offset: 0x0001D26C
		[NullableContext(2)]
		public static bool ContentEquals(string _this_contentEquals, string other, bool ignoreCase)
		{
			object obj = (_this_contentEquals == null) ? null : new Java.Lang.String(_this_contentEquals);
			Java.Lang.String @string = (other == null) ? null : new Java.Lang.String(other);
			object obj2 = obj;
			bool result = StringsKt.ContentEquals(obj2, @string, ignoreCase);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		[Obsolete("deprecated")]
		[Register("decapitalize", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string Decapitalize(string _this_decapitalize)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_decapitalize);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("decapitalize.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0001F11C File Offset: 0x0001D31C
		[Obsolete("deprecated")]
		[Register("decapitalize", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public unsafe static string Decapitalize(string _this_decapitalize, Locale locale)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_decapitalize);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((locale == null) ? IntPtr.Zero : locale.Handle);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("decapitalize.(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(locale);
			}
			return @string;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
		[Register("decodeToString", "([B)Ljava/lang/String;", "")]
		public unsafe static string DecodeToString(byte[] _this_decodeToString)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_decodeToString);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("decodeToString.([B)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_decodeToString != null)
				{
					JNIEnv.CopyArray(intPtr, _this_decodeToString);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_decodeToString);
			}
			return @string;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0001F22C File Offset: 0x0001D42C
		[Register("decodeToString", "([BIIZ)Ljava/lang/String;", "")]
		public unsafe static string DecodeToString(byte[] _this_decodeToString, int startIndex, int endIndex, bool throwOnInvalidSequence)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_decodeToString);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				ptr[3] = new JniArgumentValue(throwOnInvalidSequence);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("decodeToString.([BIIZ)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_decodeToString != null)
				{
					JNIEnv.CopyArray(intPtr, _this_decodeToString);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_decodeToString);
			}
			return @string;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
		[Register("encodeToByteArray", "(Ljava/lang/String;)[B", "")]
		public unsafe static byte[] EncodeToByteArray(string _this_encodeToByteArray)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_encodeToByteArray);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(StringsKt._members.StaticMethods.InvokeObjectMethod("encodeToByteArray.(Ljava/lang/String;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0001F364 File Offset: 0x0001D564
		[Register("encodeToByteArray", "(Ljava/lang/String;IIZ)[B", "")]
		public unsafe static byte[] EncodeToByteArray(string _this_encodeToByteArray, int startIndex, int endIndex, bool throwOnInvalidSequence)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_encodeToByteArray);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				ptr[3] = new JniArgumentValue(throwOnInvalidSequence);
				result = (byte[])JNIEnv.GetArray(StringsKt._members.StaticMethods.InvokeObjectMethod("encodeToByteArray.(Ljava/lang/String;IIZ)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0001F41C File Offset: 0x0001D61C
		[Register("endsWith", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "")]
		public unsafe static bool EndsWith(string _this_endsWith, string suffix, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_endsWith);
			IntPtr intPtr2 = JNIEnv.NewString(suffix);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("endsWith.(Ljava/lang/String;Ljava/lang/String;Z)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		[NullableContext(2)]
		[Register("equals", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "")]
		public unsafe static bool Equals(string _this_equals, string other, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_equals);
			IntPtr intPtr2 = JNIEnv.NewString(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("equals.(Ljava/lang/String;Ljava/lang/String;Z)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0001F544 File Offset: 0x0001D744
		[Register("getCASE_INSENSITIVE_ORDER", "(Ljava/lang/Object;)Ljava/util/Comparator;", "")]
		public unsafe static IComparator GetCASE_INSENSITIVE_ORDER(Java.Lang.Object _this_CASE_INSENSITIVE_ORDER)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_CASE_INSENSITIVE_ORDER == null) ? IntPtr.Zero : _this_CASE_INSENSITIVE_ORDER.Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(StringsKt._members.StaticMethods.InvokeObjectMethod("getCASE_INSENSITIVE_ORDER.(Ljava/lang/Object;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_CASE_INSENSITIVE_ORDER);
			}
			return @object;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0001F5B8 File Offset: 0x0001D7B8
		[Register("isBlank", "(Ljava/lang/CharSequence;)Z", "")]
		public unsafe static bool IsBlank(ICharSequence _this_isBlank)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_isBlank);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("isBlank.(Ljava/lang/CharSequence;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_isBlank);
			}
			return result;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0001F61C File Offset: 0x0001D81C
		public static bool IsBlank(string _this_isBlank)
		{
			Java.Lang.String @string = (_this_isBlank == null) ? null : new Java.Lang.String(_this_isBlank);
			bool result = StringsKt.IsBlank(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0001F648 File Offset: 0x0001D848
		[Register("regionMatches", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;IIZ)Z", "")]
		public unsafe static bool RegionMatches(ICharSequence _this_regionMatches, int thisOffset, ICharSequence other, int otherOffset, int length, bool ignoreCase)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_regionMatches);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(thisOffset);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(otherOffset);
				ptr[4] = new JniArgumentValue(length);
				ptr[5] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("regionMatches.(Ljava/lang/CharSequence;ILjava/lang/CharSequence;IIZ)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_regionMatches);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0001F72C File Offset: 0x0001D92C
		[Register("regionMatches", "(Ljava/lang/String;ILjava/lang/String;IIZ)Z", "")]
		public unsafe static bool RegionMatches(string _this_regionMatches, int thisOffset, string other, int otherOffset, int length, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_regionMatches);
			IntPtr intPtr2 = JNIEnv.NewString(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(thisOffset);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(otherOffset);
				ptr[4] = new JniArgumentValue(length);
				ptr[5] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("regionMatches.(Ljava/lang/String;ILjava/lang/String;IIZ)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001F804 File Offset: 0x0001DA04
		[Register("repeat", "(Ljava/lang/CharSequence;I)Ljava/lang/String;", "")]
		public unsafe static string Repeat(ICharSequence _this_repeat, int n)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_repeat);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(n);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("repeat.(Ljava/lang/CharSequence;I)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_repeat);
			}
			return @string;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0001F888 File Offset: 0x0001DA88
		public static string Repeat(string _this_repeat, int n)
		{
			Java.Lang.String @string = (_this_repeat == null) ? null : new Java.Lang.String(_this_repeat);
			string result = StringsKt.Repeat(@string, n);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0001F8B4 File Offset: 0x0001DAB4
		[Register("replace", "(Ljava/lang/String;CCZ)Ljava/lang/String;", "")]
		public unsafe static string Replace(string _this_replace, char oldChar, char newChar, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replace);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(oldChar);
				ptr[2] = new JniArgumentValue(newChar);
				ptr[3] = new JniArgumentValue(ignoreCase);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replace.(Ljava/lang/String;CCZ)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0001F960 File Offset: 0x0001DB60
		[Register("replace", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", "")]
		public unsafe static string Replace(string _this_replace, string oldValue, string newValue, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replace);
			IntPtr intPtr2 = JNIEnv.NewString(oldValue);
			IntPtr intPtr3 = JNIEnv.NewString(newValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(ignoreCase);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replace.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0001FA28 File Offset: 0x0001DC28
		[Register("replaceFirst", "(Ljava/lang/String;CCZ)Ljava/lang/String;", "")]
		public unsafe static string ReplaceFirst(string _this_replaceFirst, char oldChar, char newChar, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceFirst);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(oldChar);
				ptr[2] = new JniArgumentValue(newChar);
				ptr[3] = new JniArgumentValue(ignoreCase);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceFirst.(Ljava/lang/String;CCZ)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0001FAD4 File Offset: 0x0001DCD4
		[Register("replaceFirst", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", "")]
		public unsafe static string ReplaceFirst(string _this_replaceFirst, string oldValue, string newValue, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceFirst);
			IntPtr intPtr2 = JNIEnv.NewString(oldValue);
			IntPtr intPtr3 = JNIEnv.NewString(newValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(ignoreCase);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceFirst.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0001FB9C File Offset: 0x0001DD9C
		[Register("split", "(Ljava/lang/CharSequence;Ljava/util/regex/Pattern;I)Ljava/util/List;", "")]
		public unsafe static IList<string> Split(ICharSequence _this_split, Pattern regex, int limit)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(_this_split);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((regex == null) ? IntPtr.Zero : regex.Handle);
				ptr[2] = new JniArgumentValue(limit);
				result = JavaList<string>.FromJniHandle(StringsKt._members.StaticMethods.InvokeObjectMethod("split.(Ljava/lang/CharSequence;Ljava/util/regex/Pattern;I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_split);
				GC.KeepAlive(regex);
			}
			return result;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0001FC4C File Offset: 0x0001DE4C
		public static IList<string> Split(string _this_split, Pattern regex, int limit)
		{
			Java.Lang.String @string = (_this_split == null) ? null : new Java.Lang.String(_this_split);
			IList<string> result = StringsKt.Split(@string, regex, limit);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0001FC78 File Offset: 0x0001DE78
		[Register("startsWith", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "")]
		public unsafe static bool StartsWith(string _this_startsWith, string prefix, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_startsWith);
			IntPtr intPtr2 = JNIEnv.NewString(prefix);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("startsWith.(Ljava/lang/String;Ljava/lang/String;Z)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001FD0C File Offset: 0x0001DF0C
		[Register("startsWith", "(Ljava/lang/String;Ljava/lang/String;IZ)Z", "")]
		public unsafe static bool StartsWith(string _this_startsWith, string prefix, int startIndex, bool ignoreCase)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_startsWith);
			IntPtr intPtr2 = JNIEnv.NewString(prefix);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(ignoreCase);
				result = StringsKt._members.StaticMethods.InvokeBooleanMethod("startsWith.(Ljava/lang/String;Ljava/lang/String;IZ)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0001FDB4 File Offset: 0x0001DFB4
		[Register("toCharArray", "(Ljava/lang/String;II)[C", "")]
		public unsafe static char[] ToCharArray(string _this_toCharArray, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toCharArray);
			char[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				result = (char[])JNIEnv.GetArray(StringsKt._members.StaticMethods.InvokeObjectMethod("toCharArray.(Ljava/lang/String;II)[C", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(char));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0001FE58 File Offset: 0x0001E058
		[Register("numberFormatError", "(Ljava/lang/String;)Ljava/lang/Void;", "")]
		public unsafe static Java.Lang.Void NumberFormatError(string input)
		{
			IntPtr intPtr = JNIEnv.NewString(input);
			Java.Lang.Void @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Void>(StringsKt._members.StaticMethods.InvokeObjectMethod("numberFormatError.(Ljava/lang/String;)Ljava/lang/Void;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0001FEC4 File Offset: 0x0001E0C4
		[Register("toByteOrNull", "(Ljava/lang/String;)Ljava/lang/Byte;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Byte ToByteOrNull(string _this_toByteOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toByteOrNull);
			Java.Lang.Byte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Byte>(StringsKt._members.StaticMethods.InvokeObjectMethod("toByteOrNull.(Ljava/lang/String;)Ljava/lang/Byte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0001FF30 File Offset: 0x0001E130
		[Register("toByteOrNull", "(Ljava/lang/String;I)Ljava/lang/Byte;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Byte ToByteOrNull(string _this_toByteOrNull, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toByteOrNull);
			Java.Lang.Byte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<Java.Lang.Byte>(StringsKt._members.StaticMethods.InvokeObjectMethod("toByteOrNull.(Ljava/lang/String;I)Ljava/lang/Byte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
		[Register("toIntOrNull", "(Ljava/lang/String;)Ljava/lang/Integer;", "")]
		[return: Nullable(2)]
		public unsafe static Integer ToIntOrNull(string _this_toIntOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toIntOrNull);
			Integer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Integer>(StringsKt._members.StaticMethods.InvokeObjectMethod("toIntOrNull.(Ljava/lang/String;)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0002001C File Offset: 0x0001E21C
		[Register("toIntOrNull", "(Ljava/lang/String;I)Ljava/lang/Integer;", "")]
		[return: Nullable(2)]
		public unsafe static Integer ToIntOrNull(string _this_toIntOrNull, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toIntOrNull);
			Integer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<Integer>(StringsKt._members.StaticMethods.InvokeObjectMethod("toIntOrNull.(Ljava/lang/String;I)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0002009C File Offset: 0x0001E29C
		[Register("toLongOrNull", "(Ljava/lang/String;)Ljava/lang/Long;", "")]
		[return: Nullable(2)]
		public unsafe static Long ToLongOrNull(string _this_toLongOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toLongOrNull);
			Long @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Long>(StringsKt._members.StaticMethods.InvokeObjectMethod("toLongOrNull.(Ljava/lang/String;)Ljava/lang/Long;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00020108 File Offset: 0x0001E308
		[Register("toLongOrNull", "(Ljava/lang/String;I)Ljava/lang/Long;", "")]
		[return: Nullable(2)]
		public unsafe static Long ToLongOrNull(string _this_toLongOrNull, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toLongOrNull);
			Long @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<Long>(StringsKt._members.StaticMethods.InvokeObjectMethod("toLongOrNull.(Ljava/lang/String;I)Ljava/lang/Long;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00020188 File Offset: 0x0001E388
		[Register("toShortOrNull", "(Ljava/lang/String;)Ljava/lang/Short;", "")]
		[return: Nullable(2)]
		public unsafe static Short ToShortOrNull(string _this_toShortOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toShortOrNull);
			Short @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Short>(StringsKt._members.StaticMethods.InvokeObjectMethod("toShortOrNull.(Ljava/lang/String;)Ljava/lang/Short;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000201F4 File Offset: 0x0001E3F4
		[Register("toShortOrNull", "(Ljava/lang/String;I)Ljava/lang/Short;", "")]
		[return: Nullable(2)]
		public unsafe static Short ToShortOrNull(string _this_toShortOrNull, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toShortOrNull);
			Short @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<Short>(StringsKt._members.StaticMethods.InvokeObjectMethod("toShortOrNull.(Ljava/lang/String;I)Ljava/lang/Short;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00020274 File Offset: 0x0001E474
		[Register("toBigDecimalOrNull", "(Ljava/lang/String;)Ljava/math/BigDecimal;", "")]
		[return: Nullable(2)]
		public unsafe static BigDecimal ToBigDecimalOrNull(string _this_toBigDecimalOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toBigDecimalOrNull);
			BigDecimal @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BigDecimal>(StringsKt._members.StaticMethods.InvokeObjectMethod("toBigDecimalOrNull.(Ljava/lang/String;)Ljava/math/BigDecimal;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000202E0 File Offset: 0x0001E4E0
		[Register("toBigDecimalOrNull", "(Ljava/lang/String;Ljava/math/MathContext;)Ljava/math/BigDecimal;", "")]
		[return: Nullable(2)]
		public unsafe static BigDecimal ToBigDecimalOrNull(string _this_toBigDecimalOrNull, MathContext mathContext)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toBigDecimalOrNull);
			BigDecimal @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((mathContext == null) ? IntPtr.Zero : mathContext.Handle);
				@object = Java.Lang.Object.GetObject<BigDecimal>(StringsKt._members.StaticMethods.InvokeObjectMethod("toBigDecimalOrNull.(Ljava/lang/String;Ljava/math/MathContext;)Ljava/math/BigDecimal;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(mathContext);
			}
			return @object;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00020374 File Offset: 0x0001E574
		[Register("toBigIntegerOrNull", "(Ljava/lang/String;)Ljava/math/BigInteger;", "")]
		[return: Nullable(2)]
		public unsafe static BigInteger ToBigIntegerOrNull(string _this_toBigIntegerOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toBigIntegerOrNull);
			BigInteger @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BigInteger>(StringsKt._members.StaticMethods.InvokeObjectMethod("toBigIntegerOrNull.(Ljava/lang/String;)Ljava/math/BigInteger;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000203E0 File Offset: 0x0001E5E0
		[Register("toBigIntegerOrNull", "(Ljava/lang/String;I)Ljava/math/BigInteger;", "")]
		[return: Nullable(2)]
		public unsafe static BigInteger ToBigIntegerOrNull(string _this_toBigIntegerOrNull, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toBigIntegerOrNull);
			BigInteger @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<BigInteger>(StringsKt._members.StaticMethods.InvokeObjectMethod("toBigIntegerOrNull.(Ljava/lang/String;I)Ljava/math/BigInteger;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00020460 File Offset: 0x0001E660
		[Register("toDoubleOrNull", "(Ljava/lang/String;)Ljava/lang/Double;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Double ToDoubleOrNull(string _this_toDoubleOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toDoubleOrNull);
			Java.Lang.Double @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Double>(StringsKt._members.StaticMethods.InvokeObjectMethod("toDoubleOrNull.(Ljava/lang/String;)Ljava/lang/Double;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000204CC File Offset: 0x0001E6CC
		[Register("toFloatOrNull", "(Ljava/lang/String;)Ljava/lang/Float;", "")]
		[return: Nullable(2)]
		public unsafe static Float ToFloatOrNull(string _this_toFloatOrNull)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_toFloatOrNull);
			Float @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Float>(StringsKt._members.StaticMethods.InvokeObjectMethod("toFloatOrNull.(Ljava/lang/String;)Ljava/lang/Float;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00020538 File Offset: 0x0001E738
		[Register("append", "(Ljava/lang/StringBuilder;[Ljava/lang/Object;)Ljava/lang/StringBuilder;", "")]
		public unsafe static StringBuilder Append(StringBuilder _this_append, params Java.Lang.Object[] value)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(value);
			StringBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_append == null) ? IntPtr.Zero : _this_append.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<StringBuilder>(StringsKt._members.StaticMethods.InvokeObjectMethod("append.(Ljava/lang/StringBuilder;[Ljava/lang/Object;)Ljava/lang/StringBuilder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (value != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, value);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_append);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000205DC File Offset: 0x0001E7DC
		[Register("append", "(Ljava/lang/StringBuilder;[Ljava/lang/String;)Ljava/lang/StringBuilder;", "")]
		public unsafe static StringBuilder Append(StringBuilder _this_append, params string[] value)
		{
			IntPtr intPtr = JNIEnv.NewArray(value);
			StringBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_append == null) ? IntPtr.Zero : _this_append.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<StringBuilder>(StringsKt._members.StaticMethods.InvokeObjectMethod("append.(Ljava/lang/StringBuilder;[Ljava/lang/String;)Ljava/lang/StringBuilder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (value != null)
				{
					JNIEnv.CopyArray(intPtr, value);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_append);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00020680 File Offset: 0x0001E880
		[Obsolete("deprecated")]
		[Register("appendln", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;", "")]
		public unsafe static IAppendable Appendln(IAppendable _this_appendln)
		{
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_appendln == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_appendln).Handle);
				@object = Java.Lang.Object.GetObject<IAppendable>(StringsKt._members.StaticMethods.InvokeObjectMethod("appendln.(Ljava/lang/Appendable;)Ljava/lang/Appendable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_appendln);
			}
			return @object;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000206F8 File Offset: 0x0001E8F8
		[Obsolete("deprecated")]
		[Register("appendln", "(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;", "")]
		public unsafe static StringBuilder Appendln(StringBuilder _this_appendln)
		{
			StringBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_appendln == null) ? IntPtr.Zero : _this_appendln.Handle);
				@object = Java.Lang.Object.GetObject<StringBuilder>(StringsKt._members.StaticMethods.InvokeObjectMethod("appendln.(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_appendln);
			}
			return @object;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0002076C File Offset: 0x0001E96C
		[Register("clear", "(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;", "")]
		public unsafe static StringBuilder Clear(StringBuilder _this_clear)
		{
			StringBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_clear == null) ? IntPtr.Zero : _this_clear.Handle);
				@object = Java.Lang.Object.GetObject<StringBuilder>(StringsKt._members.StaticMethods.InvokeObjectMethod("clear.(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_clear);
			}
			return @object;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x000207E0 File Offset: 0x0001E9E0
		[Register("prependIndent", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string PrependIndent(string _this_prependIndent, string indent)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_prependIndent);
			IntPtr intPtr2 = JNIEnv.NewString(indent);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("prependIndent.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002086C File Offset: 0x0001EA6C
		[Register("replaceIndent", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceIndent(string _this_replaceIndent, string newIndent)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceIndent);
			IntPtr intPtr2 = JNIEnv.NewString(newIndent);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceIndent.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000208F8 File Offset: 0x0001EAF8
		[Register("replaceIndentByMargin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ReplaceIndentByMargin(string _this_replaceIndentByMargin, string newIndent, string marginPrefix)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_replaceIndentByMargin);
			IntPtr intPtr2 = JNIEnv.NewString(newIndent);
			IntPtr intPtr3 = JNIEnv.NewString(marginPrefix);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("replaceIndentByMargin.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000209A8 File Offset: 0x0001EBA8
		[Register("trimIndent", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string TrimIndent(string _this_trimIndent)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_trimIndent);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("trimIndent.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00020A14 File Offset: 0x0001EC14
		[Register("trimMargin", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string TrimMargin(string _this_trimMargin, string marginPrefix)
		{
			IntPtr intPtr = JNIEnv.NewString(_this_trimMargin);
			IntPtr intPtr2 = JNIEnv.NewString(marginPrefix);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(StringsKt._members.StaticMethods.InvokeObjectMethod("trimMargin.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00020AA0 File Offset: 0x0001ECA0
		[Register("append", "(Ljava/lang/Appendable;[Ljava/lang/CharSequence;)Ljava/lang/Appendable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Appendable"
		})]
		public unsafe static Java.Lang.Object Append(Java.Lang.Object _this_append, params ICharSequence[] value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_append);
			IntPtr intPtr2 = JNIEnv.NewArray<ICharSequence>(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("append.(Ljava/lang/Appendable;[Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (value != null)
				{
					JNIEnv.CopyArray<ICharSequence>(intPtr2, value);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_append);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00020B44 File Offset: 0x0001ED44
		public static Java.Lang.Object Append(Java.Lang.Object _this_append, params string[] value)
		{
			ICharSequence[] value2 = CharSequence.ArrayFromStringArray(value);
			return StringsKt.Append(_this_append, value2);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00020B60 File Offset: 0x0001ED60
		[NullableContext(2)]
		[Register("appendElement", "(Ljava/lang/Appendable;Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void AppendElement([Nullable(1)] IAppendable _this_appendElement, Java.Lang.Object element, IFunction1 transform)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_appendElement == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_appendElement).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				StringsKt._members.StaticMethods.InvokeVoidMethod("appendElement.(Ljava/lang/Appendable;Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_appendElement);
				GC.KeepAlive(element);
				GC.KeepAlive(transform);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00020C20 File Offset: 0x0001EE20
		[Register("appendRange", "(Ljava/lang/Appendable;Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Appendable"
		})]
		public unsafe static Java.Lang.Object AppendRange(Java.Lang.Object _this_appendRange, ICharSequence value, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_appendRange);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(endIndex);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StringsKt._members.StaticMethods.InvokeObjectMethod("appendRange.(Ljava/lang/Appendable;Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_appendRange);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00020CE4 File Offset: 0x0001EEE4
		public static Java.Lang.Object AppendRange(Java.Lang.Object _this_appendRange, string value, int startIndex, int endIndex)
		{
			Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
			Java.Lang.Object result = StringsKt.AppendRange(_this_appendRange, @string, startIndex, endIndex);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0400022B RID: 555
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/StringsKt", typeof(StringsKt));
	}
}
