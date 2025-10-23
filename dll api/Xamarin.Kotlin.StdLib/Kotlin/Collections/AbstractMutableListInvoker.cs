using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002B5 RID: 693
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractMutableList", DoNotGenerateAcw = true)]
	internal class AbstractMutableListInvoker : AbstractMutableList
	{
		// Token: 0x0600204B RID: 8267 RVA: 0x0006BA21 File Offset: 0x00069C21
		public AbstractMutableListInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x0006BA2B File Offset: 0x00069C2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractMutableListInvoker._members;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x0006BA32 File Offset: 0x00069C32
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractMutableListInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0006BA40 File Offset: 0x00069C40
		[NullableContext(2)]
		[Register("add", "(ILjava/lang/Object;)V", "GetAdd_ILjava_lang_Object_Handler")]
		public unsafe override void Add(int index, Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				AbstractMutableListInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("add.(ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0006BAB4 File Offset: 0x00069CB4
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public override int GetSize()
		{
			return AbstractMutableListInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0006BAD0 File Offset: 0x00069CD0
		[NullableContext(2)]
		[Register("removeAt", "(I)Ljava/lang/Object;", "GetRemoveAt_IHandler")]
		public unsafe override Java.Lang.Object RemoveAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMutableListInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("removeAt.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0006BB1C File Offset: 0x00069D1C
		[NullableContext(2)]
		[Register("set", "(ILjava/lang/Object;)Ljava/lang/Object;", "GetSet_ILjava_lang_Object_Handler")]
		public unsafe override Java.Lang.Object Set(int index, Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMutableListInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("set.(ILjava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return @object;
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0006BBA0 File Offset: 0x00069DA0
		[NullableContext(2)]
		[Register("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public unsafe override Java.Lang.Object Get(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMutableListInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("get.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400097F RID: 2431
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMutableList", typeof(AbstractMutableListInvoker));
	}
}
