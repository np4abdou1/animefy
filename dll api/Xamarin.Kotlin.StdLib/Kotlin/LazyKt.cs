using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin
{
	// Token: 0x0200008A RID: 138
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/LazyKt", DoNotGenerateAcw = true)]
	public sealed class LazyKt : Java.Lang.Object
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00009268 File Offset: 0x00007468
		internal static IntPtr class_ref
		{
			get
			{
				return LazyKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0000928C File Offset: 0x0000748C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LazyKt._members;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00009294 File Offset: 0x00007494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LazyKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x000092B8 File Offset: 0x000074B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LazyKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000092C4 File Offset: 0x000074C4
		internal LazyKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000092D0 File Offset: 0x000074D0
		[Register("lazyOf", "(Ljava/lang/Object;)Lkotlin/Lazy;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ILazy LazyOf([Nullable(2)] Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			ILazy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ILazy>(LazyKt._members.StaticMethods.InvokeObjectMethod("lazyOf.(Ljava/lang/Object;)Lkotlin/Lazy;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00009340 File Offset: 0x00007540
		[Register("lazy", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function0;)Lkotlin/Lazy;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ILazy Lazy([Nullable(2)] Java.Lang.Object @lock, IFunction0 initializer)
		{
			ILazy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@lock == null) ? IntPtr.Zero : @lock.Handle);
				ptr[1] = new JniArgumentValue((initializer == null) ? IntPtr.Zero : ((Java.Lang.Object)initializer).Handle);
				@object = Java.Lang.Object.GetObject<ILazy>(LazyKt._members.StaticMethods.InvokeObjectMethod("lazy.(Ljava/lang/Object;Lkotlin/jvm/functions/Function0;)Lkotlin/Lazy;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(@lock);
				GC.KeepAlive(initializer);
			}
			return @object;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000093E0 File Offset: 0x000075E0
		[Register("lazy", "(Lkotlin/jvm/functions/Function0;)Lkotlin/Lazy;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ILazy Lazy(IFunction0 initializer)
		{
			ILazy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((initializer == null) ? IntPtr.Zero : ((Java.Lang.Object)initializer).Handle);
				@object = Java.Lang.Object.GetObject<ILazy>(LazyKt._members.StaticMethods.InvokeObjectMethod("lazy.(Lkotlin/jvm/functions/Function0;)Lkotlin/Lazy;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(initializer);
			}
			return @object;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00009458 File Offset: 0x00007658
		[Register("lazy", "(Lkotlin/LazyThreadSafetyMode;Lkotlin/jvm/functions/Function0;)Lkotlin/Lazy;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ILazy Lazy(LazyThreadSafetyMode mode, IFunction0 initializer)
		{
			ILazy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				ptr[1] = new JniArgumentValue((initializer == null) ? IntPtr.Zero : ((Java.Lang.Object)initializer).Handle);
				@object = Java.Lang.Object.GetObject<ILazy>(LazyKt._members.StaticMethods.InvokeObjectMethod("lazy.(Lkotlin/LazyThreadSafetyMode;Lkotlin/jvm/functions/Function0;)Lkotlin/Lazy;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(mode);
				GC.KeepAlive(initializer);
			}
			return @object;
		}

		// Token: 0x0400013A RID: 314
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/LazyKt", typeof(LazyKt));
	}
}
