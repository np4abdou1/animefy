using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Java.Util.Concurrent;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;

namespace Kotlin.Collections
{
	// Token: 0x020002D1 RID: 721
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/MapsKt", DoNotGenerateAcw = true)]
	public sealed class MapsKt : Java.Lang.Object
	{
		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x000ACB90 File Offset: 0x000AAD90
		internal static IntPtr class_ref
		{
			get
			{
				return MapsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000ACBB4 File Offset: 0x000AADB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MapsKt._members;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x000ACBBC File Offset: 0x000AADBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MapsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x000ACBE0 File Offset: 0x000AADE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MapsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000ACBEC File Offset: 0x000AADEC
		internal MapsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000ACBF8 File Offset: 0x000AADF8
		[Register("all", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static bool All(IDictionary _this_all, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_all);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = MapsKt._members.StaticMethods.InvokeBooleanMethod("all.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_all);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x000ACC88 File Offset: 0x000AAE88
		[Register("any", "(Ljava/util/Map;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static bool Any(IDictionary _this_any)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_any);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = MapsKt._members.StaticMethods.InvokeBooleanMethod("any.(Ljava/util/Map;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_any);
			}
			return result;
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x000ACCEC File Offset: 0x000AAEEC
		[Register("any", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static bool Any(IDictionary _this_any, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_any);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = MapsKt._members.StaticMethods.InvokeBooleanMethod("any.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_any);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000ACD7C File Offset: 0x000AAF7C
		[Register("asSequence", "(Ljava/util/Map;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static ISequence AsSequence(IDictionary _this_asSequence)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_asSequence);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(MapsKt._members.StaticMethods.InvokeObjectMethod("asSequence.(Ljava/util/Map;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_asSequence);
			}
			return @object;
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000ACDEC File Offset: 0x000AAFEC
		[Register("count", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)I", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static int Count(IDictionary _this_count, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_count);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = MapsKt._members.StaticMethods.InvokeInt32Method("count.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_count);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000ACE7C File Offset: 0x000AB07C
		[Register("flatMap", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R"
		})]
		public unsafe static System.Collections.IList FlatMap(IDictionary _this_flatMap, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_flatMap);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("flatMap.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_flatMap);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000ACF1C File Offset: 0x000AB11C
		[Register("flatMapSequence", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R"
		})]
		public unsafe static System.Collections.IList FlatMapSequence(IDictionary _this_flatMap, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_flatMap);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("flatMapSequence.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_flatMap);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000ACFBC File Offset: 0x000AB1BC
		[Register("flatMapSequenceTo", "(Ljava/util/Map;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object FlatMapSequenceTo(IDictionary _this_flatMapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_flatMapTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("flatMapSequenceTo.(Ljava/util/Map;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060027D4 RID: 10196 RVA: 0x000AD084 File Offset: 0x000AB284
		[Register("flatMapTo", "(Ljava/util/Map;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object FlatMapTo(IDictionary _this_flatMapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_flatMapTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("flatMapTo.(Ljava/util/Map;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060027D5 RID: 10197 RVA: 0x000AD14C File Offset: 0x000AB34C
		[Register("forEach", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static void ForEach(IDictionary _this_forEach, IFunction1 action)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_forEach);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				MapsKt._members.StaticMethods.InvokeVoidMethod("forEach.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_forEach);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000AD1DC File Offset: 0x000AB3DC
		[Register("map", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R"
		})]
		public unsafe static System.Collections.IList Map(IDictionary _this_map, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_map);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("map.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_map);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000AD27C File Offset: 0x000AB47C
		[Register("mapNotNull", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R"
		})]
		public unsafe static System.Collections.IList MapNotNull(IDictionary _this_mapNotNull, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_mapNotNull);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaList.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("mapNotNull.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapNotNull);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000AD31C File Offset: 0x000AB51C
		[Register("mapNotNullTo", "(Ljava/util/Map;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapNotNullTo(IDictionary _this_mapNotNullTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_mapNotNullTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("mapNotNullTo.(Ljava/util/Map;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060027D9 RID: 10201 RVA: 0x000AD3E4 File Offset: 0x000AB5E4
		[Register("mapTo", "(Ljava/util/Map;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R",
			"C extends java.util.Collection<? super R>"
		})]
		public unsafe static Java.Lang.Object MapTo(IDictionary _this_mapTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_mapTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("mapTo.(Ljava/util/Map;Ljava/util/Collection;Lkotlin/jvm/functions/Function1;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060027DA RID: 10202 RVA: 0x000AD4AC File Offset: 0x000AB6AC
		[Register("none", "(Ljava/util/Map;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static bool None(IDictionary _this_none)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_none);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = MapsKt._members.StaticMethods.InvokeBooleanMethod("none.(Ljava/util/Map;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_none);
			}
			return result;
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000AD510 File Offset: 0x000AB710
		[Register("none", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static bool None(IDictionary _this_none, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_none);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = MapsKt._members.StaticMethods.InvokeBooleanMethod("none.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_none);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000AD5A0 File Offset: 0x000AB7A0
		[Register("onEach", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? extends K, ? extends V>"
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("onEach.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_onEach);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000AD640 File Offset: 0x000AB840
		[Register("onEachIndexed", "(Ljava/util/Map;Lkotlin/jvm/functions/Function2;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? extends K, ? extends V>"
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("onEachIndexed.(Ljava/util/Map;Lkotlin/jvm/functions/Function2;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_onEachIndexed);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000AD6E0 File Offset: 0x000AB8E0
		[Register("toList", "(Ljava/util/Map;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static System.Collections.IList ToList(IDictionary _this_toList)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_toList);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toList.(Ljava/util/Map;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toList);
			}
			return result;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x000AD750 File Offset: 0x000AB950
		[Register("emptyMap", "()Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public static IDictionary EmptyMap()
		{
			return JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("emptyMap.()Ljava/util/Map;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x000AD784 File Offset: 0x000AB984
		[Register("filter", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Filter(IDictionary _this_filter, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_filter);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("filter.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filter);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000AD824 File Offset: 0x000ABA24
		[Register("filterKeys", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary FilterKeys(IDictionary _this_filterKeys, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_filterKeys);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("filterKeys.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterKeys);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000AD8C4 File Offset: 0x000ABAC4
		[Register("filterNot", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary FilterNot(IDictionary _this_filterNot, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_filterNot);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("filterNot.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterNot);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000AD964 File Offset: 0x000ABB64
		[Register("filterNotTo", "(Ljava/util/Map;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object FilterNotTo(IDictionary _this_filterNotTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_filterNotTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("filterNotTo.(Ljava/util/Map;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060027E4 RID: 10212 RVA: 0x000ADA2C File Offset: 0x000ABC2C
		[Register("filterTo", "(Ljava/util/Map;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object FilterTo(IDictionary _this_filterTo, Java.Lang.Object destination, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_filterTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("filterTo.(Ljava/util/Map;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060027E5 RID: 10213 RVA: 0x000ADAF4 File Offset: 0x000ABCF4
		[Register("filterValues", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary FilterValues(IDictionary _this_filterValues, IFunction1 predicate)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_filterValues);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("filterValues.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_filterValues);
				GC.KeepAlive(predicate);
			}
			return result;
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x000ADB94 File Offset: 0x000ABD94
		[Register("getOrElseNullable", "(Ljava/util/Map;Ljava/lang/Object;Lkotlin/jvm/functions/Function0;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetOrElseNullable(IDictionary _this_getOrElseNullable, [Nullable(2)] Java.Lang.Object key, IFunction0 defaultValue)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_getOrElseNullable);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("getOrElseNullable.(Ljava/util/Map;Ljava/lang/Object;Lkotlin/jvm/functions/Function0;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_getOrElseNullable);
				GC.KeepAlive(key);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000ADC5C File Offset: 0x000ABE5C
		[Register("getOrPut", "(Ljava/util/Map;Ljava/lang/Object;Lkotlin/jvm/functions/Function0;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetOrPut(IDictionary _this_getOrPut, [Nullable(2)] Java.Lang.Object key, IFunction0 defaultValue)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_getOrPut);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("getOrPut.(Ljava/util/Map;Ljava/lang/Object;Lkotlin/jvm/functions/Function0;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_getOrPut);
				GC.KeepAlive(key);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000ADD24 File Offset: 0x000ABF24
		[NullableContext(2)]
		[Register("getValue", "(Ljava/util/Map;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static Java.Lang.Object GetValue([Nullable(1)] IDictionary _this_getValue, Java.Lang.Object key)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_getValue);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("getValue.(Ljava/util/Map;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_getValue);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000ADDBC File Offset: 0x000ABFBC
		[Register("hashMapOf", "([Lkotlin/Pair;)Ljava/util/HashMap;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary HashMapOf(params Pair[] pairs)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(pairs);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("hashMapOf.([Lkotlin/Pair;)Ljava/util/HashMap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (pairs != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, pairs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(pairs);
			}
			return result;
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000ADE38 File Offset: 0x000AC038
		[Register("linkedMapOf", "([Lkotlin/Pair;)Ljava/util/LinkedHashMap;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static LinkedHashMap LinkedMapOf(params Pair[] pairs)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(pairs);
			LinkedHashMap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LinkedHashMap>(MapsKt._members.StaticMethods.InvokeObjectMethod("linkedMapOf.([Lkotlin/Pair;)Ljava/util/LinkedHashMap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (pairs != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, pairs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(pairs);
			}
			return @object;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000ADEB4 File Offset: 0x000AC0B4
		[Register("mapKeys", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R"
		})]
		public unsafe static IDictionary MapKeys(IDictionary _this_mapKeys, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_mapKeys);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("mapKeys.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapKeys);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x000ADF54 File Offset: 0x000AC154
		[Register("mapKeysTo", "(Ljava/util/Map;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R",
			"M extends java.util.Map<? super R, ? super V>"
		})]
		public unsafe static Java.Lang.Object MapKeysTo(IDictionary _this_mapKeysTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_mapKeysTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("mapKeysTo.(Ljava/util/Map;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_mapKeysTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x000AE01C File Offset: 0x000AC21C
		[Register("mapOf", "([Lkotlin/Pair;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary MapOf(params Pair[] pairs)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(pairs);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("mapOf.([Lkotlin/Pair;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (pairs != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, pairs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(pairs);
			}
			return result;
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000AE098 File Offset: 0x000AC298
		[Register("mapValues", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R"
		})]
		public unsafe static IDictionary MapValues(IDictionary _this_mapValues, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_mapValues);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("mapValues.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_mapValues);
				GC.KeepAlive(transform);
			}
			return result;
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000AE138 File Offset: 0x000AC338
		[Register("mapValuesTo", "(Ljava/util/Map;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"R",
			"M extends java.util.Map<? super K, ? super R>"
		})]
		public unsafe static Java.Lang.Object MapValuesTo(IDictionary _this_mapValuesTo, Java.Lang.Object destination, IFunction1 transform)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_mapValuesTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("mapValuesTo.(Ljava/util/Map;Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_mapValuesTo);
				GC.KeepAlive(destination);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000AE200 File Offset: 0x000AC400
		[Register("minus", "(Ljava/util/Map;Ljava/lang/Iterable;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Minus(IDictionary _this_minus, IIterable keys)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_minus);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((keys == null) ? IntPtr.Zero : ((Java.Lang.Object)keys).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/util/Map;Ljava/lang/Iterable;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(keys);
			}
			return result;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000AE2A0 File Offset: 0x000AC4A0
		[Register("minus", "(Ljava/util/Map;Ljava/lang/Object;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Minus(IDictionary _this_minus, [Nullable(2)] Java.Lang.Object key)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_minus);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(key);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/util/Map;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(key);
			}
			return result;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000AE338 File Offset: 0x000AC538
		[Register("minus", "(Ljava/util/Map;[Ljava/lang/Object;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Minus(IDictionary _this_minus, Java.Lang.Object[] keys)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_minus);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(keys);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/util/Map;[Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (keys != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, keys);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(keys);
			}
			return result;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000AE3DC File Offset: 0x000AC5DC
		[Register("minus", "(Ljava/util/Map;Lkotlin/sequences/Sequence;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Minus(IDictionary _this_minus, ISequence keys)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_minus);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((keys == null) ? IntPtr.Zero : ((Java.Lang.Object)keys).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("minus.(Ljava/util/Map;Lkotlin/sequences/Sequence;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_minus);
				GC.KeepAlive(keys);
			}
			return result;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000AE47C File Offset: 0x000AC67C
		[Register("mutableMapOf", "([Lkotlin/Pair;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary MutableMapOf(params Pair[] pairs)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(pairs);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("mutableMapOf.([Lkotlin/Pair;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (pairs != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, pairs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(pairs);
			}
			return result;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000AE4F8 File Offset: 0x000AC6F8
		[Register("optimizeReadOnlyMap", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary OptimizeReadOnlyMap(IDictionary _this_optimizeReadOnlyMap)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_optimizeReadOnlyMap);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("optimizeReadOnlyMap.(Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_optimizeReadOnlyMap);
			}
			return result;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000AE568 File Offset: 0x000AC768
		[Register("plus", "(Ljava/util/Map;Ljava/lang/Iterable;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Plus(IDictionary _this_plus, IIterable pairs)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_plus);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((pairs == null) ? IntPtr.Zero : ((Java.Lang.Object)pairs).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Map;Ljava/lang/Iterable;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(pairs);
			}
			return result;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x000AE608 File Offset: 0x000AC808
		[Register("plus", "(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Plus(IDictionary _this_plus, IDictionary map)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_plus);
			IntPtr intPtr2 = JavaDictionary.ToLocalJniHandle(map);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(map);
			}
			return result;
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x000AE6A0 File Offset: 0x000AC8A0
		[Register("plus", "(Ljava/util/Map;Lkotlin/Pair;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Plus(IDictionary _this_plus, Pair pair)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_plus);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((pair == null) ? IntPtr.Zero : pair.Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Map;Lkotlin/Pair;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(pair);
			}
			return result;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x000AE738 File Offset: 0x000AC938
		[Register("plus", "(Ljava/util/Map;[Lkotlin/Pair;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Plus(IDictionary _this_plus, Pair[] pairs)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_plus);
			IntPtr intPtr2 = JNIEnv.NewArray<Pair>(pairs);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Map;[Lkotlin/Pair;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (pairs != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr2, pairs);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(pairs);
			}
			return result;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000AE7DC File Offset: 0x000AC9DC
		[Register("plus", "(Ljava/util/Map;Lkotlin/sequences/Sequence;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Plus(IDictionary _this_plus, ISequence pairs)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_plus);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((pairs == null) ? IntPtr.Zero : ((Java.Lang.Object)pairs).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("plus.(Ljava/util/Map;Lkotlin/sequences/Sequence;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_plus);
				GC.KeepAlive(pairs);
			}
			return result;
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000AE87C File Offset: 0x000ACA7C
		[Register("putAll", "(Ljava/util/Map;Ljava/lang/Iterable;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static void PutAll(IDictionary _this_putAll, IIterable pairs)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_putAll);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((pairs == null) ? IntPtr.Zero : ((Java.Lang.Object)pairs).Handle);
				MapsKt._members.StaticMethods.InvokeVoidMethod("putAll.(Ljava/util/Map;Ljava/lang/Iterable;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_putAll);
				GC.KeepAlive(pairs);
			}
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000AE90C File Offset: 0x000ACB0C
		[Register("putAll", "(Ljava/util/Map;[Lkotlin/Pair;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static void PutAll(IDictionary _this_putAll, Pair[] pairs)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_putAll);
			IntPtr intPtr2 = JNIEnv.NewArray<Pair>(pairs);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				MapsKt._members.StaticMethods.InvokeVoidMethod("putAll.(Ljava/util/Map;[Lkotlin/Pair;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (pairs != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr2, pairs);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_putAll);
				GC.KeepAlive(pairs);
			}
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000AE99C File Offset: 0x000ACB9C
		[Register("putAll", "(Ljava/util/Map;Lkotlin/sequences/Sequence;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static void PutAll(IDictionary _this_putAll, ISequence pairs)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_putAll);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((pairs == null) ? IntPtr.Zero : ((Java.Lang.Object)pairs).Handle);
				MapsKt._members.StaticMethods.InvokeVoidMethod("putAll.(Ljava/util/Map;Lkotlin/sequences/Sequence;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_putAll);
				GC.KeepAlive(pairs);
			}
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000AEA2C File Offset: 0x000ACC2C
		[Register("toMap", "(Ljava/lang/Iterable;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary ToMap(IIterable _this_toMap)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMap).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toMap.(Ljava/lang/Iterable;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toMap);
			}
			return result;
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000AEAA4 File Offset: 0x000ACCA4
		[Register("toMap", "(Ljava/lang/Iterable;Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object ToMap(IIterable _this_toMap, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMap).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("toMap.(Ljava/lang/Iterable;Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toMap);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000AEB44 File Offset: 0x000ACD44
		[Register("toMap", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary ToMap(IDictionary _this_toMap)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_toMap);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toMap.(Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toMap);
			}
			return result;
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000AEBB4 File Offset: 0x000ACDB4
		[Register("toMap", "(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object ToMap(IDictionary _this_toMap, Java.Lang.Object destination)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_toMap);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("toMap.(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_toMap);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x000AEC4C File Offset: 0x000ACE4C
		[Register("toMap", "([Lkotlin/Pair;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary ToMap(Pair[] _this_toMap)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(_this_toMap);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toMap.([Lkotlin/Pair;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_toMap != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, _this_toMap);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_toMap);
			}
			return result;
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000AECC8 File Offset: 0x000ACEC8
		[Register("toMap", "([Lkotlin/Pair;Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object ToMap(Pair[] _this_toMap, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(_this_toMap);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("toMap.([Lkotlin/Pair;Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_toMap != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, _this_toMap);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_toMap);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000AED6C File Offset: 0x000ACF6C
		[Register("toMap", "(Lkotlin/sequences/Sequence;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary ToMap(ISequence _this_toMap)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMap).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toMap.(Lkotlin/sequences/Sequence;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toMap);
			}
			return result;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000AEDE4 File Offset: 0x000ACFE4
		[Register("toMap", "(Lkotlin/sequences/Sequence;Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		public unsafe static Java.Lang.Object ToMap(ISequence _this_toMap, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMap).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("toMap.(Lkotlin/sequences/Sequence;Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toMap);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000AEE84 File Offset: 0x000AD084
		[Register("toMutableMap", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary ToMutableMap(IDictionary _this_toMutableMap)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_toMutableMap);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toMutableMap.(Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toMutableMap);
			}
			return result;
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000AEEF4 File Offset: 0x000AD0F4
		[Register("build", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Build(IDictionary builder)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(builder);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("build.(Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(builder);
			}
			return result;
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000AEF64 File Offset: 0x000AD164
		[Register("createMapBuilder", "()Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public static IDictionary CreateMapBuilder()
		{
			return JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("createMapBuilder.()Ljava/util/Map;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000AEF98 File Offset: 0x000AD198
		[Register("createMapBuilder", "(I)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary CreateMapBuilder(int capacity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(capacity);
			return JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("createMapBuilder.(I)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000AEFE0 File Offset: 0x000AD1E0
		[Register("getOrPut", "(Ljava/util/concurrent/ConcurrentMap;Ljava/lang/Object;Lkotlin/jvm/functions/Function0;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetOrPut(IConcurrentMap _this_getOrPut, [Nullable(2)] Java.Lang.Object key, IFunction0 defaultValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getOrPut == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_getOrPut).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("getOrPut.(Ljava/util/concurrent/ConcurrentMap;Ljava/lang/Object;Lkotlin/jvm/functions/Function0;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_getOrPut);
				GC.KeepAlive(key);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x000AF0B0 File Offset: 0x000AD2B0
		[Register("mapCapacity", "(I)I", "")]
		public unsafe static int MapCapacity(int expectedSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(expectedSize);
			return MapsKt._members.StaticMethods.InvokeInt32Method("mapCapacity.(I)I", ptr);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000AF0EC File Offset: 0x000AD2EC
		[Register("mapOf", "(Lkotlin/Pair;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary MapOf(Pair pair)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pair == null) ? IntPtr.Zero : pair.Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("mapOf.(Lkotlin/Pair;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pair);
			}
			return result;
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000AF160 File Offset: 0x000AD360
		[Register("sortedMapOf", "(Ljava/util/Comparator;[Lkotlin/Pair;)Ljava/util/SortedMap;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary SortedMapOf(IComparator comparator, params Pair[] pairs)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(pairs);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("sortedMapOf.(Ljava/util/Comparator;[Lkotlin/Pair;)Ljava/util/SortedMap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (pairs != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, pairs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(comparator);
				GC.KeepAlive(pairs);
			}
			return result;
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000AF208 File Offset: 0x000AD408
		[Register("sortedMapOf", "([Lkotlin/Pair;)Ljava/util/SortedMap;", "")]
		[JavaTypeParameters(new string[]
		{
			"K extends java.lang.Comparable<? super K>",
			"V"
		})]
		public unsafe static IDictionary SortedMapOf(params Pair[] pairs)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(pairs);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("sortedMapOf.([Lkotlin/Pair;)Ljava/util/SortedMap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (pairs != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, pairs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(pairs);
			}
			return result;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000AF284 File Offset: 0x000AD484
		[Register("toSingletonMap", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary ToSingletonMap(IDictionary _this_toSingletonMap)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_toSingletonMap);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toSingletonMap.(Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toSingletonMap);
			}
			return result;
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000AF2F4 File Offset: 0x000AD4F4
		[Register("toSortedMap", "(Ljava/util/Map;)Ljava/util/SortedMap;", "")]
		[JavaTypeParameters(new string[]
		{
			"K extends java.lang.Comparable<? super K>",
			"V"
		})]
		public unsafe static IDictionary ToSortedMap(IDictionary _this_toSortedMap)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_toSortedMap);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toSortedMap.(Ljava/util/Map;)Ljava/util/SortedMap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toSortedMap);
			}
			return result;
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000AF364 File Offset: 0x000AD564
		[Register("toSortedMap", "(Ljava/util/Map;Ljava/util/Comparator;)Ljava/util/SortedMap;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary ToSortedMap(IDictionary _this_toSortedMap, IComparator comparator)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_toSortedMap);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("toSortedMap.(Ljava/util/Map;Ljava/util/Comparator;)Ljava/util/SortedMap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toSortedMap);
				GC.KeepAlive(comparator);
			}
			return result;
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000AF404 File Offset: 0x000AD604
		[NullableContext(2)]
		[Register("getOrImplicitDefaultNullable", "(Ljava/util/Map;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static Java.Lang.Object GetOrImplicitDefaultNullable([Nullable(1)] IDictionary _this_getOrImplicitDefault, Java.Lang.Object key)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_getOrImplicitDefault);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MapsKt._members.StaticMethods.InvokeObjectMethod("getOrImplicitDefaultNullable.(Ljava/util/Map;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_getOrImplicitDefault);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x000AF49C File Offset: 0x000AD69C
		[Register("withDefault", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary WithDefault(IDictionary _this_withDefault, IFunction1 defaultValue)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_withDefault);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("withDefault.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_withDefault);
				GC.KeepAlive(defaultValue);
			}
			return result;
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000AF53C File Offset: 0x000AD73C
		[Register("withDefaultMutable", "(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary WithDefaultMutable(IDictionary _this_withDefault, IFunction1 defaultValue)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(_this_withDefault);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				result = JavaDictionary.FromJniHandle(MapsKt._members.StaticMethods.InvokeObjectMethod("withDefaultMutable.(Ljava/util/Map;Lkotlin/jvm/functions/Function1;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_withDefault);
				GC.KeepAlive(defaultValue);
			}
			return result;
		}

		// Token: 0x040009BC RID: 2492
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/MapsKt", typeof(MapsKt));
	}
}
