using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;

namespace Kotlin.Jvm.Optionals
{
	// Token: 0x0200018C RID: 396
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/optionals/OptionalsKt", DoNotGenerateAcw = true)]
	public sealed class OptionalsKt : Java.Lang.Object
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
		internal static IntPtr class_ref
		{
			get
			{
				return OptionalsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0003EFDC File Offset: 0x0003D1DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OptionalsKt._members;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0003EFE4 File Offset: 0x0003D1E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OptionalsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0003F008 File Offset: 0x0003D208
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OptionalsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0003F014 File Offset: 0x0003D214
		internal OptionalsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0003F020 File Offset: 0x0003D220
		[Register("asSequence", "(Ljava/util/Optional;)Lkotlin/sequences/Sequence;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISequence AsSequence(Optional obj)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(OptionalsKt._members.StaticMethods.InvokeObjectMethod("asSequence.(Ljava/util/Optional;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0003F094 File Offset: 0x0003D294
		[NullableContext(2)]
		[Register("getOrDefault", "(Ljava/util/Optional;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object GetOrDefault([Nullable(1)] Optional obj, Java.Lang.Object defaultValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(defaultValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(OptionalsKt._members.StaticMethods.InvokeObjectMethod("getOrDefault.(Ljava/util/Optional;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0003F12C File Offset: 0x0003D32C
		[Register("getOrElse", "(Ljava/util/Optional;Lkotlin/jvm/functions/Function0;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetOrElse(Optional obj, IFunction0 defaultValue)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((defaultValue == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultValue).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(OptionalsKt._members.StaticMethods.InvokeObjectMethod("getOrElse.(Ljava/util/Optional;Lkotlin/jvm/functions/Function0;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0003F1CC File Offset: 0x0003D3CC
		[Register("getOrNull", "(Ljava/util/Optional;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetOrNull(Optional obj)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(OptionalsKt._members.StaticMethods.InvokeObjectMethod("getOrNull.(Ljava/util/Optional;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0003F240 File Offset: 0x0003D440
		[Register("toCollection", "(Ljava/util/Optional;Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		public unsafe static Java.Lang.Object ToCollection(Optional obj, Java.Lang.Object destination)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(OptionalsKt._members.StaticMethods.InvokeObjectMethod("toCollection.(Ljava/util/Optional;Ljava/util/Collection;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0003F2D8 File Offset: 0x0003D4D8
		[Register("toList", "(Ljava/util/Optional;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList ToList(Optional obj)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaList.FromJniHandle(OptionalsKt._members.StaticMethods.InvokeObjectMethod("toList.(Ljava/util/Optional;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0003F34C File Offset: 0x0003D54C
		[Register("toSet", "(Ljava/util/Optional;)Ljava/util/Set;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.ICollection ToSet(Optional obj)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaSet.FromJniHandle(OptionalsKt._members.StaticMethods.InvokeObjectMethod("toSet.(Ljava/util/Optional;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x04000675 RID: 1653
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/optionals/OptionalsKt", typeof(OptionalsKt));
	}
}
