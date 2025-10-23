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
	// Token: 0x020002B8 RID: 696
	[Register("kotlin/collections/AbstractMutableSet", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractMutableSet : AbstractSet, ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMutableSet, IKMutableCollection, IKMutableIterable, IKMappedMarker
	{
		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x0006C068 File Offset: 0x0006A268
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractMutableSet._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0006C08C File Offset: 0x0006A28C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return AbstractMutableSet._members;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x0006C094 File Offset: 0x0006A294
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractMutableSet._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0006C0B8 File Offset: 0x0006A2B8
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return AbstractMutableSet._members.ManagedPeerType;
			}
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x0006C0C4 File Offset: 0x0006A2C4
		protected AbstractMutableSet(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x0006C0D0 File Offset: 0x0006A2D0
		[Register(".ctor", "()V", "")]
		protected AbstractMutableSet() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractMutableSet._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractMutableSet._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x0006C13E File Offset: 0x0006A33E
		[NullableContext(1)]
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (AbstractMutableSet.cb_add_Ljava_lang_Object_ == null)
			{
				AbstractMutableSet.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractMutableSet.n_Add_Ljava_lang_Object_));
			}
			return AbstractMutableSet.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x0006C164 File Offset: 0x0006A364
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			AbstractMutableSet @object = Java.Lang.Object.GetObject<AbstractMutableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x0600207C RID: 8316
		[NullableContext(2)]
		[Register("add", "(Ljava/lang/Object;)Z", "GetAdd_Ljava_lang_Object_Handler")]
		public new abstract bool Add(Java.Lang.Object element);

		// Token: 0x0600207D RID: 8317 RVA: 0x0006C187 File Offset: 0x0006A387
		[NullableContext(1)]
		private static Delegate GetGetSizeHandler()
		{
			if (AbstractMutableSet.cb_getSize == null)
			{
				AbstractMutableSet.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AbstractMutableSet.n_GetSize));
			}
			return AbstractMutableSet.cb_getSize;
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x0006C1AB File Offset: 0x0006A3AB
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractMutableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSize();
		}

		// Token: 0x0600207F RID: 8319
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public abstract int GetSize();

		// Token: 0x06002080 RID: 8320 RVA: 0x0006C1BA File Offset: 0x0006A3BA
		[Register("size", "()I", "")]
		public sealed override int Size()
		{
			return AbstractMutableSet._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x04000987 RID: 2439
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMutableSet", typeof(AbstractMutableSet));

		// Token: 0x04000988 RID: 2440
		[Nullable(2)]
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000989 RID: 2441
		[Nullable(2)]
		private static Delegate cb_getSize;
	}
}
