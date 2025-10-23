using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002CB RID: 715
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/IndexedValue", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class IndexedValue : Java.Lang.Object
	{
		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x000AC420 File Offset: 0x000AA620
		internal static IntPtr class_ref
		{
			get
			{
				return IndexedValue._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x000AC444 File Offset: 0x000AA644
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IndexedValue._members;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000AC44C File Offset: 0x000AA64C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IndexedValue._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x000AC470 File Offset: 0x000AA670
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IndexedValue._members.ManagedPeerType;
			}
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000AC47C File Offset: 0x000AA67C
		internal IndexedValue(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x000AC488 File Offset: 0x000AA688
		[NullableContext(2)]
		[Register(".ctor", "(ILjava/lang/Object;)V", "")]
		public unsafe IndexedValue(int index, Java.Lang.Object value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(IndexedValue._members.InstanceMethods.StartCreateInstance("(ILjava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				IndexedValue._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000AC548 File Offset: 0x000AA748
		public int Index
		{
			[Register("getIndex", "()I", "")]
			get
			{
				return IndexedValue._members.InstanceMethods.InvokeNonvirtualInt32Method("getIndex.()I", this, null);
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x000AC564 File Offset: 0x000AA764
		[Nullable(2)]
		public Java.Lang.Object Value
		{
			[NullableContext(2)]
			[Register("getValue", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(IndexedValue._members.InstanceMethods.InvokeNonvirtualObjectMethod("getValue.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x000AC596 File Offset: 0x000AA796
		[Register("component1", "()I", "")]
		public int Component1()
		{
			return IndexedValue._members.InstanceMethods.InvokeNonvirtualInt32Method("component1.()I", this, null);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000AC5B0 File Offset: 0x000AA7B0
		[NullableContext(2)]
		[Register("component2", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Component2()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(IndexedValue._members.InstanceMethods.InvokeNonvirtualObjectMethod("component2.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x000AC5E4 File Offset: 0x000AA7E4
		[Register("copy", "(ILjava/lang/Object;)Lkotlin/collections/IndexedValue;", "")]
		public unsafe IndexedValue Copy(int index, [Nullable(2)] Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			IndexedValue @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IndexedValue>(IndexedValue._members.InstanceMethods.InvokeNonvirtualObjectMethod("copy.(ILjava/lang/Object;)Lkotlin/collections/IndexedValue;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x040009B0 RID: 2480
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/IndexedValue", typeof(IndexedValue));
	}
}
