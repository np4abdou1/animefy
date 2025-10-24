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
	// Token: 0x020000A2 RID: 162
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/Triple", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"A",
		"B",
		"C"
	})]
	public sealed class Triple : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0000A534 File Offset: 0x00008734
		internal static IntPtr class_ref
		{
			get
			{
				return Triple._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000A558 File Offset: 0x00008758
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return Triple._members;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000A560 File Offset: 0x00008760
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Triple._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000A584 File Offset: 0x00008784
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return Triple._members.ManagedPeerType;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000A590 File Offset: 0x00008790
		internal Triple(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000A59C File Offset: 0x0000879C
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe Triple(Java.Lang.Object first, Java.Lang.Object second, Java.Lang.Object third) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(first);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(second);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(third);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				base.SetHandle(Triple._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Triple._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(first);
				GC.KeepAlive(second);
				GC.KeepAlive(third);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000A698 File Offset: 0x00008898
		public Java.Lang.Object First
		{
			[Register("getFirst", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Triple._members.InstanceMethods.InvokeNonvirtualObjectMethod("getFirst.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000A6CC File Offset: 0x000088CC
		public Java.Lang.Object Second
		{
			[Register("getSecond", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Triple._members.InstanceMethods.InvokeNonvirtualObjectMethod("getSecond.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000A700 File Offset: 0x00008900
		public Java.Lang.Object Third
		{
			[Register("getThird", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Triple._members.InstanceMethods.InvokeNonvirtualObjectMethod("getThird.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000A734 File Offset: 0x00008934
		[Register("component1", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Component1()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(Triple._members.InstanceMethods.InvokeNonvirtualObjectMethod("component1.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000A768 File Offset: 0x00008968
		[Register("component2", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Component2()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(Triple._members.InstanceMethods.InvokeNonvirtualObjectMethod("component2.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000A79C File Offset: 0x0000899C
		[Register("component3", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Component3()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(Triple._members.InstanceMethods.InvokeNonvirtualObjectMethod("component3.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Register("copy", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lkotlin/Triple;", "")]
		[return: Nullable(1)]
		public unsafe Triple Copy(Java.Lang.Object first, Java.Lang.Object second, Java.Lang.Object third)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(first);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(second);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(third);
			Triple @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@object = Java.Lang.Object.GetObject<Triple>(Triple._members.InstanceMethods.InvokeNonvirtualObjectMethod("copy.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lkotlin/Triple;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(first);
				GC.KeepAlive(second);
				GC.KeepAlive(third);
			}
			return @object;
		}

		// Token: 0x04000157 RID: 343
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Triple", typeof(Triple));
	}
}
