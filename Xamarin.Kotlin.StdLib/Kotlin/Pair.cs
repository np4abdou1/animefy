using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000093 RID: 147
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/Pair", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"A",
		"B"
	})]
	public sealed class Pair : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00009E30 File Offset: 0x00008030
		internal static IntPtr class_ref
		{
			get
			{
				return Pair._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00009E54 File Offset: 0x00008054
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return Pair._members;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00009E5C File Offset: 0x0000805C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Pair._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00009E80 File Offset: 0x00008080
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return Pair._members.ManagedPeerType;
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00009E8C File Offset: 0x0000808C
		internal Pair(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00009E98 File Offset: 0x00008098
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe Pair(Java.Lang.Object first, Java.Lang.Object second) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(first);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(second);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				base.SetHandle(Pair._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Pair._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00009F68 File Offset: 0x00008168
		public Java.Lang.Object First
		{
			[Register("getFirst", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Pair._members.InstanceMethods.InvokeNonvirtualObjectMethod("getFirst.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00009F9C File Offset: 0x0000819C
		public Java.Lang.Object Second
		{
			[Register("getSecond", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Pair._members.InstanceMethods.InvokeNonvirtualObjectMethod("getSecond.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00009FD0 File Offset: 0x000081D0
		[Register("component1", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Component1()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(Pair._members.InstanceMethods.InvokeNonvirtualObjectMethod("component1.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000A004 File Offset: 0x00008204
		[Register("component2", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Component2()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(Pair._members.InstanceMethods.InvokeNonvirtualObjectMethod("component2.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000A038 File Offset: 0x00008238
		[Register("copy", "(Ljava/lang/Object;Ljava/lang/Object;)Lkotlin/Pair;", "")]
		[return: Nullable(1)]
		public unsafe Pair Copy(Java.Lang.Object first, Java.Lang.Object second)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(first);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(second);
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Pair>(Pair._members.InstanceMethods.InvokeNonvirtualObjectMethod("copy.(Ljava/lang/Object;Ljava/lang/Object;)Lkotlin/Pair;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
			return @object;
		}

		// Token: 0x04000148 RID: 328
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Pair", typeof(Pair));
	}
}
