using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Collections
{
	// Token: 0x020002C8 RID: 712
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/GroupingKt", DoNotGenerateAcw = true)]
	public sealed class GroupingKt : Java.Lang.Object
	{
		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x000AB9BC File Offset: 0x000A9BBC
		internal static IntPtr class_ref
		{
			get
			{
				return GroupingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x000AB9E0 File Offset: 0x000A9BE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GroupingKt._members;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x000AB9E8 File Offset: 0x000A9BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GroupingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000ABA0C File Offset: 0x000A9C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GroupingKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000ABA18 File Offset: 0x000A9C18
		internal GroupingKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x000ABA24 File Offset: 0x000A9C24
		[Register("aggregate", "(Lkotlin/collections/Grouping;Lkotlin/jvm/functions/Function4;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"R"
		})]
		public unsafe static IDictionary Aggregate(IGrouping _this_aggregate, IFunction4 operation)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_aggregate == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_aggregate).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaDictionary.FromJniHandle(GroupingKt._members.StaticMethods.InvokeObjectMethod("aggregate.(Lkotlin/collections/Grouping;Lkotlin/jvm/functions/Function4;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_aggregate);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x000ABAC8 File Offset: 0x000A9CC8
		[Register("aggregateTo", "(Lkotlin/collections/Grouping;Ljava/util/Map;Lkotlin/jvm/functions/Function4;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"R",
			"M extends java.util.Map<? super K, R>"
		})]
		public unsafe static Java.Lang.Object AggregateTo(IGrouping _this_aggregateTo, Java.Lang.Object destination, IFunction4 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_aggregateTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_aggregateTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GroupingKt._members.StaticMethods.InvokeObjectMethod("aggregateTo.(Lkotlin/collections/Grouping;Ljava/util/Map;Lkotlin/jvm/functions/Function4;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_aggregateTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x000ABB98 File Offset: 0x000A9D98
		[Register("eachCountTo", "(Lkotlin/collections/Grouping;Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"M extends java.util.Map<? super K, java.lang.Integer>"
		})]
		public unsafe static Java.Lang.Object EachCountTo(IGrouping _this_eachCountTo, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_eachCountTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_eachCountTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GroupingKt._members.StaticMethods.InvokeObjectMethod("eachCountTo.(Lkotlin/collections/Grouping;Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_eachCountTo);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x000ABC38 File Offset: 0x000A9E38
		[Register("fold", "(Lkotlin/collections/Grouping;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function3;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"R"
		})]
		public unsafe static IDictionary Fold(IGrouping _this_fold, IFunction2 initialValueSelector, IFunction3 operation)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_fold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_fold).Handle);
				ptr[1] = new JniArgumentValue((initialValueSelector == null) ? IntPtr.Zero : ((Java.Lang.Object)initialValueSelector).Handle);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaDictionary.FromJniHandle(GroupingKt._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlin/collections/Grouping;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function3;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_fold);
				GC.KeepAlive(initialValueSelector);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x000ABD0C File Offset: 0x000A9F0C
		[Register("fold", "(Lkotlin/collections/Grouping;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"R"
		})]
		public unsafe static IDictionary Fold(IGrouping _this_fold, [Nullable(2)] Java.Lang.Object initialValue, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initialValue);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_fold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_fold).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaDictionary.FromJniHandle(GroupingKt._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlin/collections/Grouping;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_fold);
				GC.KeepAlive(initialValue);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000ABDDC File Offset: 0x000A9FDC
		[Register("foldTo", "(Lkotlin/collections/Grouping;Ljava/util/Map;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function3;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"R",
			"M extends java.util.Map<? super K, R>"
		})]
		public unsafe static Java.Lang.Object FoldTo(IGrouping _this_foldTo, Java.Lang.Object destination, IFunction2 initialValueSelector, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_foldTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_foldTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((initialValueSelector == null) ? IntPtr.Zero : ((Java.Lang.Object)initialValueSelector).Handle);
				ptr[3] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GroupingKt._members.StaticMethods.InvokeObjectMethod("foldTo.(Lkotlin/collections/Grouping;Ljava/util/Map;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function3;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_foldTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(initialValueSelector);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000ABEDC File Offset: 0x000AA0DC
		[Register("foldTo", "(Lkotlin/collections/Grouping;Ljava/util/Map;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K",
			"R",
			"M extends java.util.Map<? super K, R>"
		})]
		public unsafe static Java.Lang.Object FoldTo(IGrouping _this_foldTo, Java.Lang.Object destination, [Nullable(2)] Java.Lang.Object initialValue, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(initialValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_foldTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_foldTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GroupingKt._members.StaticMethods.InvokeObjectMethod("foldTo.(Lkotlin/collections/Grouping;Ljava/util/Map;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_foldTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(initialValue);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x000ABFD4 File Offset: 0x000AA1D4
		[Register("reduce", "(Lkotlin/collections/Grouping;Lkotlin/jvm/functions/Function3;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S",
			"K"
		})]
		public unsafe static IDictionary Reduce(IGrouping _this_reduce, IFunction3 operation)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduce).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				result = JavaDictionary.FromJniHandle(GroupingKt._members.StaticMethods.InvokeObjectMethod("reduce.(Lkotlin/collections/Grouping;Lkotlin/jvm/functions/Function3;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduce);
				GC.KeepAlive(operation);
			}
			return result;
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000AC078 File Offset: 0x000AA278
		[Register("reduceTo", "(Lkotlin/collections/Grouping;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S",
			"K",
			"M extends java.util.Map<? super K, S>"
		})]
		public unsafe static Java.Lang.Object ReduceTo(IGrouping _this_reduceTo, Java.Lang.Object destination, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduceTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduceTo).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GroupingKt._members.StaticMethods.InvokeObjectMethod("reduceTo.(Lkotlin/collections/Grouping;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_reduceTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000AC148 File Offset: 0x000AA348
		[Register("eachCount", "(Lkotlin/collections/Grouping;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static IDictionary EachCount(IGrouping _this_eachCount)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_eachCount == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_eachCount).Handle);
				result = JavaDictionary.FromJniHandle(GroupingKt._members.StaticMethods.InvokeObjectMethod("eachCount.(Lkotlin/collections/Grouping;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_eachCount);
			}
			return result;
		}

		// Token: 0x040009A9 RID: 2473
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/GroupingKt", typeof(GroupingKt));
	}
}
