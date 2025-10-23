using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001CF RID: 463
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/SpreadBuilder", DoNotGenerateAcw = true)]
	public class SpreadBuilder : Java.Lang.Object
	{
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x0004B2D8 File Offset: 0x000494D8
		internal static IntPtr class_ref
		{
			get
			{
				return SpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x0004B2FC File Offset: 0x000494FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SpreadBuilder._members;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x0004B304 File Offset: 0x00049504
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x0004B328 File Offset: 0x00049528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0004B334 File Offset: 0x00049534
		protected SpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0004B340 File Offset: 0x00049540
		[Register(".ctor", "(I)V", "")]
		public unsafe SpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(SpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			SpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0004B3C4 File Offset: 0x000495C4
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (SpreadBuilder.cb_add_Ljava_lang_Object_ == null)
			{
				SpreadBuilder.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SpreadBuilder.n_Add_Ljava_lang_Object_));
			}
			return SpreadBuilder.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0004B3E8 File Offset: 0x000495E8
		private static void n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			SpreadBuilder @object = Java.Lang.Object.GetObject<SpreadBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			@object.Add(object2);
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0004B40C File Offset: 0x0004960C
		[NullableContext(2)]
		[Register("add", "(Ljava/lang/Object;)V", "GetAdd_Ljava_lang_Object_Handler")]
		public unsafe virtual void Add(Java.Lang.Object element)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				SpreadBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("add.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0004B470 File Offset: 0x00049670
		private static Delegate GetAddSpread_Ljava_lang_Object_Handler()
		{
			if (SpreadBuilder.cb_addSpread_Ljava_lang_Object_ == null)
			{
				SpreadBuilder.cb_addSpread_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SpreadBuilder.n_AddSpread_Ljava_lang_Object_));
			}
			return SpreadBuilder.cb_addSpread_Ljava_lang_Object_;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0004B494 File Offset: 0x00049694
		private static void n_AddSpread_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			SpreadBuilder @object = Java.Lang.Object.GetObject<SpreadBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.AddSpread(object2);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0004B4B8 File Offset: 0x000496B8
		[NullableContext(2)]
		[Register("addSpread", "(Ljava/lang/Object;)V", "GetAddSpread_Ljava_lang_Object_Handler")]
		public unsafe virtual void AddSpread(Java.Lang.Object container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				SpreadBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("addSpread.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0004B51C File Offset: 0x0004971C
		private static Delegate GetSizeHandler()
		{
			if (SpreadBuilder.cb_size == null)
			{
				SpreadBuilder.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SpreadBuilder.n_Size));
			}
			return SpreadBuilder.cb_size;
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0004B540 File Offset: 0x00049740
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SpreadBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0004B54F File Offset: 0x0004974F
		[Register("size", "()I", "GetSizeHandler")]
		public virtual int Size()
		{
			return SpreadBuilder._members.InstanceMethods.InvokeVirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0004B568 File Offset: 0x00049768
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (SpreadBuilder.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				SpreadBuilder.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SpreadBuilder.n_ToArray_arrayLjava_lang_Object_));
			}
			return SpreadBuilder.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0004B58C File Offset: 0x0004978C
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			SpreadBuilder @object = Java.Lang.Object.GetObject<SpreadBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_a, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_a);
			}
			return result;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0004B5D0 File Offset: 0x000497D0
		[Register("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "GetToArray_arrayLjava_lang_Object_Handler")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public unsafe virtual Java.Lang.Object[] ToArray([Nullable(new byte[]
		{
			2,
			1
		})] Java.Lang.Object[] a)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(a);
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (Java.Lang.Object[])JNIEnv.GetArray(SpreadBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("toArray.([Ljava/lang/Object;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				if (a != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, a);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(a);
			}
			return result;
		}

		// Token: 0x04000740 RID: 1856
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/SpreadBuilder", typeof(SpreadBuilder));

		// Token: 0x04000741 RID: 1857
		[Nullable(2)]
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000742 RID: 1858
		[Nullable(2)]
		private static Delegate cb_addSpread_Ljava_lang_Object_;

		// Token: 0x04000743 RID: 1859
		[Nullable(2)]
		private static Delegate cb_size;

		// Token: 0x04000744 RID: 1860
		[Nullable(2)]
		private static Delegate cb_toArray_arrayLjava_lang_Object_;
	}
}
