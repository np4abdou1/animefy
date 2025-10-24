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
	// Token: 0x020002B2 RID: 690
	[Register("kotlin/collections/AbstractMutableCollection", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractMutableCollection : AbstractCollection, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMutableCollection, IKMutableIterable, IKMappedMarker
	{
		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x0006B554 File Offset: 0x00069754
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractMutableCollection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x0006B578 File Offset: 0x00069778
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return AbstractMutableCollection._members;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x0006B580 File Offset: 0x00069780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractMutableCollection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x0006B5A4 File Offset: 0x000697A4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return AbstractMutableCollection._members.ManagedPeerType;
			}
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x0006B5B0 File Offset: 0x000697B0
		protected AbstractMutableCollection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0006B5BC File Offset: 0x000697BC
		[Register(".ctor", "()V", "")]
		protected AbstractMutableCollection() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractMutableCollection._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractMutableCollection._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0006B62A File Offset: 0x0006982A
		[NullableContext(1)]
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (AbstractMutableCollection.cb_add_Ljava_lang_Object_ == null)
			{
				AbstractMutableCollection.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractMutableCollection.n_Add_Ljava_lang_Object_));
			}
			return AbstractMutableCollection.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0006B650 File Offset: 0x00069850
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			AbstractMutableCollection @object = Java.Lang.Object.GetObject<AbstractMutableCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x06002029 RID: 8233
		[NullableContext(2)]
		[Register("add", "(Ljava/lang/Object;)Z", "GetAdd_Ljava_lang_Object_Handler")]
		public new abstract bool Add(Java.Lang.Object element);

		// Token: 0x0600202A RID: 8234 RVA: 0x0006B673 File Offset: 0x00069873
		[NullableContext(1)]
		private static Delegate GetGetSizeHandler()
		{
			if (AbstractMutableCollection.cb_getSize == null)
			{
				AbstractMutableCollection.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AbstractMutableCollection.n_GetSize));
			}
			return AbstractMutableCollection.cb_getSize;
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0006B697 File Offset: 0x00069897
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractMutableCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSize();
		}

		// Token: 0x0600202C RID: 8236
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public abstract int GetSize();

		// Token: 0x0600202D RID: 8237 RVA: 0x0006B6A6 File Offset: 0x000698A6
		[Register("size", "()I", "")]
		public sealed override int Size()
		{
			return AbstractMutableCollection._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x04000976 RID: 2422
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMutableCollection", typeof(AbstractMutableCollection));

		// Token: 0x04000977 RID: 2423
		[Nullable(2)]
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000978 RID: 2424
		[Nullable(2)]
		private static Delegate cb_getSize;
	}
}
