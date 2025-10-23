using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001BE RID: 446
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/PrimitiveSpreadBuilder", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class PrimitiveSpreadBuilder : Java.Lang.Object
	{
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00047374 File Offset: 0x00045574
		internal static IntPtr class_ref
		{
			get
			{
				return PrimitiveSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x00047398 File Offset: 0x00045598
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PrimitiveSpreadBuilder._members;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x000473A0 File Offset: 0x000455A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PrimitiveSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x000473C4 File Offset: 0x000455C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PrimitiveSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000473D0 File Offset: 0x000455D0
		protected PrimitiveSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000473DC File Offset: 0x000455DC
		[Register(".ctor", "(I)V", "")]
		public unsafe PrimitiveSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(PrimitiveSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			PrimitiveSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00047460 File Offset: 0x00045660
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x0004747C File Offset: 0x0004567C
		protected unsafe int Position
		{
			[Register("getPosition", "()I", "")]
			get
			{
				return PrimitiveSpreadBuilder._members.InstanceMethods.InvokeNonvirtualInt32Method("getPosition.()I", this, null);
			}
			[Register("setPosition", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				PrimitiveSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setPosition.(I)V", this, ptr);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000474B8 File Offset: 0x000456B8
		[Register("addSpread", "(Ljava/lang/Object;)V", "")]
		public unsafe void AddSpread(Java.Lang.Object spreadArgument)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(spreadArgument);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				PrimitiveSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("addSpread.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(spreadArgument);
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0004751C File Offset: 0x0004571C
		private static Delegate GetGetSize_Ljava_lang_Object_Handler()
		{
			if (PrimitiveSpreadBuilder.cb_getSize_Ljava_lang_Object_ == null)
			{
				PrimitiveSpreadBuilder.cb_getSize_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(PrimitiveSpreadBuilder.n_GetSize_Ljava_lang_Object_));
			}
			return PrimitiveSpreadBuilder.cb_getSize_Ljava_lang_Object_;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00047540 File Offset: 0x00045740
		private static int n_GetSize_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PrimitiveSpreadBuilder @object = Java.Lang.Object.GetObject<PrimitiveSpreadBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetSize(object2);
		}

		// Token: 0x0600160A RID: 5642
		[Register("getSize", "(Ljava/lang/Object;)I", "GetGetSize_Ljava_lang_Object_Handler")]
		protected abstract int GetSize(Java.Lang.Object p0);

		// Token: 0x0600160B RID: 5643 RVA: 0x00047563 File Offset: 0x00045763
		[Register("size", "()I", "")]
		protected int Size()
		{
			return PrimitiveSpreadBuilder._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0004757C File Offset: 0x0004577C
		[Register("toArray", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		protected unsafe Java.Lang.Object ToArray(Java.Lang.Object values, Java.Lang.Object result)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(values);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(result);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PrimitiveSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(values);
				GC.KeepAlive(result);
			}
			return @object;
		}

		// Token: 0x04000709 RID: 1801
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PrimitiveSpreadBuilder", typeof(PrimitiveSpreadBuilder));

		// Token: 0x0400070A RID: 1802
		[Nullable(2)]
		private static Delegate cb_getSize_Ljava_lang_Object_;
	}
}
