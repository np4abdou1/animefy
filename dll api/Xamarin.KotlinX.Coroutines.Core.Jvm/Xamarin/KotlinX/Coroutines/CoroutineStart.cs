using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000029 RID: 41
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineStart", DoNotGenerateAcw = true)]
	public sealed class CoroutineStart : Java.Lang.Enum
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004308 File Offset: 0x00002508
		[Register("ATOMIC")]
		public static CoroutineStart Atomic
		{
			get
			{
				return Java.Lang.Object.GetObject<CoroutineStart>(CoroutineStart._members.StaticFields.GetObjectValue("ATOMIC.Lkotlinx/coroutines/CoroutineStart;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00004338 File Offset: 0x00002538
		[Register("DEFAULT")]
		public static CoroutineStart Default
		{
			get
			{
				return Java.Lang.Object.GetObject<CoroutineStart>(CoroutineStart._members.StaticFields.GetObjectValue("DEFAULT.Lkotlinx/coroutines/CoroutineStart;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00004368 File Offset: 0x00002568
		[Register("LAZY")]
		public static CoroutineStart Lazy
		{
			get
			{
				return Java.Lang.Object.GetObject<CoroutineStart>(CoroutineStart._members.StaticFields.GetObjectValue("LAZY.Lkotlinx/coroutines/CoroutineStart;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00004398 File Offset: 0x00002598
		[Register("UNDISPATCHED")]
		public static CoroutineStart Undispatched
		{
			get
			{
				return Java.Lang.Object.GetObject<CoroutineStart>(CoroutineStart._members.StaticFields.GetObjectValue("UNDISPATCHED.Lkotlinx/coroutines/CoroutineStart;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000043C8 File Offset: 0x000025C8
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineStart._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000043EC File Offset: 0x000025EC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return CoroutineStart._members;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000043F4 File Offset: 0x000025F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineStart._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00004418 File Offset: 0x00002618
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return CoroutineStart._members.ManagedPeerType;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004424 File Offset: 0x00002624
		internal CoroutineStart(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000442E File Offset: 0x0000262E
		public bool IsLazy
		{
			[Register("isLazy", "()Z", "")]
			get
			{
				return CoroutineStart._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isLazy.()Z", this, null);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004448 File Offset: 0x00002648
		[NullableContext(1)]
		[Register("invoke", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe void Invoke(IFunction1 block, IContinuation completion)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[1] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				CoroutineStart._members.InstanceMethods.InvokeNonvirtualVoidMethod("invoke.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(block);
				GC.KeepAlive(completion);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000044E0 File Offset: 0x000026E0
		[NullableContext(1)]
		[Register("invoke", "(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"T"
		})]
		public unsafe void Invoke(IFunction2 block, [Nullable(2)] Java.Lang.Object receiver, IContinuation completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				CoroutineStart._members.InstanceMethods.InvokeNonvirtualVoidMethod("invoke.(Lkotlin/jvm/functions/Function2;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(block);
				GC.KeepAlive(receiver);
				GC.KeepAlive(completion);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000045A0 File Offset: 0x000027A0
		[Register("valueOf", "(Ljava/lang/String;)Lkotlinx/coroutines/CoroutineStart;", "")]
		public unsafe static CoroutineStart ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			CoroutineStart @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CoroutineStart>(CoroutineStart._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlinx/coroutines/CoroutineStart;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000460C File Offset: 0x0000280C
		[Register("values", "()[Lkotlinx/coroutines/CoroutineStart;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static CoroutineStart[] Values()
		{
			return (CoroutineStart[])JNIEnv.GetArray(CoroutineStart._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlinx/coroutines/CoroutineStart;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CoroutineStart));
		}

		// Token: 0x0400001B RID: 27
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineStart", typeof(CoroutineStart));

		// Token: 0x020000E7 RID: 231
		[NullableContext(1)]
		[Nullable(0)]
		[Register("kotlinx/coroutines/CoroutineStart$WhenMappings", DoNotGenerateAcw = true)]
		public sealed class WhenMappings : Java.Lang.Object
		{
			// Token: 0x17000330 RID: 816
			// (get) Token: 0x06000ABA RID: 2746 RVA: 0x000268F0 File Offset: 0x00024AF0
			internal static IntPtr class_ref
			{
				get
				{
					return CoroutineStart.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00026914 File Offset: 0x00024B14
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CoroutineStart.WhenMappings._members;
				}
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002691C File Offset: 0x00024B1C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return CoroutineStart.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00026940 File Offset: 0x00024B40
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CoroutineStart.WhenMappings._members.ManagedPeerType;
				}
			}

			// Token: 0x06000ABE RID: 2750 RVA: 0x0002694C File Offset: 0x00024B4C
			internal WhenMappings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400038A RID: 906
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineStart$WhenMappings", typeof(CoroutineStart.WhenMappings));
		}
	}
}
