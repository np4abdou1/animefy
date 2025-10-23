using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Internal;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000027 RID: 39
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineName", DoNotGenerateAcw = true)]
	public sealed class CoroutineName : AbstractCoroutineContextElement
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003C04 File Offset: 0x00001E04
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineName._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003C28 File Offset: 0x00001E28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineName._members;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003C30 File Offset: 0x00001E30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineName._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003C54 File Offset: 0x00001E54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineName._members.ManagedPeerType;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003C60 File Offset: 0x00001E60
		internal CoroutineName(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003C6C File Offset: 0x00001E6C
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CoroutineName(string name) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(CoroutineName._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CoroutineName._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003D10 File Offset: 0x00001F10
		public string Name
		{
			[Register("getName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(CoroutineName._members.InstanceMethods.InvokeNonvirtualObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003D44 File Offset: 0x00001F44
		[Register("component1", "()Ljava/lang/String;", "")]
		public string Component1()
		{
			return JNIEnv.GetString(CoroutineName._members.InstanceMethods.InvokeNonvirtualObjectMethod("component1.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003D78 File Offset: 0x00001F78
		[Register("copy", "(Ljava/lang/String;)Lkotlinx/coroutines/CoroutineName;", "")]
		public unsafe CoroutineName Copy(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			CoroutineName @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CoroutineName>(CoroutineName._members.InstanceMethods.InvokeNonvirtualObjectMethod("copy.(Ljava/lang/String;)Lkotlinx/coroutines/CoroutineName;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000019 RID: 25
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineName", typeof(CoroutineName));

		// Token: 0x020000E6 RID: 230
		[NullableContext(0)]
		[Register("kotlinx/coroutines/CoroutineName$Key", DoNotGenerateAcw = true)]
		public new sealed class Key : Java.Lang.Object, ICoroutineContextKey, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700032C RID: 812
			// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x000267BC File Offset: 0x000249BC
			internal static IntPtr class_ref
			{
				get
				{
					return CoroutineName.Key._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000267E0 File Offset: 0x000249E0
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return CoroutineName.Key._members;
				}
			}

			// Token: 0x1700032E RID: 814
			// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x000267E8 File Offset: 0x000249E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return CoroutineName.Key._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0002680C File Offset: 0x00024A0C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return CoroutineName.Key._members.ManagedPeerType;
				}
			}

			// Token: 0x06000AB7 RID: 2743 RVA: 0x00026818 File Offset: 0x00024A18
			internal Key(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000AB8 RID: 2744 RVA: 0x00026824 File Offset: 0x00024A24
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Key(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(CoroutineName.Key._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CoroutineName.Key._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x04000389 RID: 905
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineName$Key", typeof(CoroutineName.Key));
		}
	}
}
