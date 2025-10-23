using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Collections
{
	// Token: 0x020002B4 RID: 692
	[Register("kotlin/collections/AbstractMutableList", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractMutableList : AbstractList, IList, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMutableList, IKMutableCollection, IKMutableIterable, IKMappedMarker
	{
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x0006B7C8 File Offset: 0x000699C8
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractMutableList._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0006B7EC File Offset: 0x000699EC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return AbstractMutableList._members;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x0006B7F4 File Offset: 0x000699F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractMutableList._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0006B818 File Offset: 0x00069A18
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return AbstractMutableList._members.ManagedPeerType;
			}
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x0006B824 File Offset: 0x00069A24
		protected AbstractMutableList(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x0006B830 File Offset: 0x00069A30
		[Register(".ctor", "()V", "")]
		protected AbstractMutableList() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractMutableList._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractMutableList._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0006B89E File Offset: 0x00069A9E
		[NullableContext(1)]
		private static Delegate GetAdd_ILjava_lang_Object_Handler()
		{
			if (AbstractMutableList.cb_add_ILjava_lang_Object_ == null)
			{
				AbstractMutableList.cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(AbstractMutableList.n_Add_ILjava_lang_Object_));
			}
			return AbstractMutableList.cb_add_ILjava_lang_Object_;
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0006B8C4 File Offset: 0x00069AC4
		private static void n_Add_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			AbstractMutableList @object = Java.Lang.Object.GetObject<AbstractMutableList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			@object.Add(index, object2);
		}

		// Token: 0x0600203E RID: 8254
		[NullableContext(2)]
		[Register("add", "(ILjava/lang/Object;)V", "GetAdd_ILjava_lang_Object_Handler")]
		public new abstract void Add(int index, Java.Lang.Object element);

		// Token: 0x0600203F RID: 8255 RVA: 0x0006B8E8 File Offset: 0x00069AE8
		[NullableContext(1)]
		private static Delegate GetGetSizeHandler()
		{
			if (AbstractMutableList.cb_getSize == null)
			{
				AbstractMutableList.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AbstractMutableList.n_GetSize));
			}
			return AbstractMutableList.cb_getSize;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0006B90C File Offset: 0x00069B0C
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractMutableList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSize();
		}

		// Token: 0x06002041 RID: 8257
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public abstract int GetSize();

		// Token: 0x06002042 RID: 8258 RVA: 0x0006B91C File Offset: 0x00069B1C
		[NullableContext(2)]
		[Register("remove", "(I)Ljava/lang/Object;", "")]
		public unsafe sealed override Java.Lang.Object Remove(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMutableList._members.InstanceMethods.InvokeNonvirtualObjectMethod("remove.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0006B965 File Offset: 0x00069B65
		[NullableContext(1)]
		private static Delegate GetRemoveAt_IHandler()
		{
			if (AbstractMutableList.cb_removeAt_I == null)
			{
				AbstractMutableList.cb_removeAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AbstractMutableList.n_RemoveAt_I));
			}
			return AbstractMutableList.cb_removeAt_I;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0006B989 File Offset: 0x00069B89
		private static IntPtr n_RemoveAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMutableList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveAt(index));
		}

		// Token: 0x06002045 RID: 8261
		[NullableContext(2)]
		[Register("removeAt", "(I)Ljava/lang/Object;", "GetRemoveAt_IHandler")]
		public abstract Java.Lang.Object RemoveAt(int index);

		// Token: 0x06002046 RID: 8262 RVA: 0x0006B99E File Offset: 0x00069B9E
		[NullableContext(1)]
		private static Delegate GetSet_ILjava_lang_Object_Handler()
		{
			if (AbstractMutableList.cb_set_ILjava_lang_Object_ == null)
			{
				AbstractMutableList.cb_set_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(AbstractMutableList.n_Set_ILjava_lang_Object_));
			}
			return AbstractMutableList.cb_set_ILjava_lang_Object_;
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0006B9C4 File Offset: 0x00069BC4
		private static IntPtr n_Set_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			AbstractMutableList @object = Java.Lang.Object.GetObject<AbstractMutableList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Set(index, object2));
		}

		// Token: 0x06002048 RID: 8264
		[NullableContext(2)]
		[Register("set", "(ILjava/lang/Object;)Ljava/lang/Object;", "GetSet_ILjava_lang_Object_Handler")]
		public new abstract Java.Lang.Object Set(int index, Java.Lang.Object element);

		// Token: 0x06002049 RID: 8265 RVA: 0x0006B9ED File Offset: 0x00069BED
		[Register("size", "()I", "")]
		public sealed override int Size()
		{
			return AbstractMutableList._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0400097A RID: 2426
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMutableList", typeof(AbstractMutableList));

		// Token: 0x0400097B RID: 2427
		[Nullable(2)]
		private static Delegate cb_add_ILjava_lang_Object_;

		// Token: 0x0400097C RID: 2428
		[Nullable(2)]
		private static Delegate cb_getSize;

		// Token: 0x0400097D RID: 2429
		[Nullable(2)]
		private static Delegate cb_removeAt_I;

		// Token: 0x0400097E RID: 2430
		[Nullable(2)]
		private static Delegate cb_set_ILjava_lang_Object_;
	}
}
