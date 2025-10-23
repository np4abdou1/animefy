using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Collections
{
	// Token: 0x020002CA RID: 714
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/Grouping", DoNotGenerateAcw = true)]
	internal class IGroupingInvoker : Java.Lang.Object, IGrouping, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000AC1DC File Offset: 0x000AA3DC
		private static IntPtr java_class_ref
		{
			get
			{
				return IGroupingInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000AC200 File Offset: 0x000AA400
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGroupingInvoker._members;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000AC207 File Offset: 0x000AA407
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000AC20F File Offset: 0x000AA40F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGroupingInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000AC21B File Offset: 0x000AA41B
		[NullableContext(2)]
		public static IGrouping GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGrouping>(handle, transfer);
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000AC224 File Offset: 0x000AA424
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGroupingInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.collections.Grouping'.");
			}
			return handle;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000AC24F File Offset: 0x000AA44F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000AC280 File Offset: 0x000AA480
		public IGroupingInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGroupingInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000AC2B8 File Offset: 0x000AA4B8
		private static Delegate GetKeyOf_Ljava_lang_Object_Handler()
		{
			if (IGroupingInvoker.cb_keyOf_Ljava_lang_Object_ == null)
			{
				IGroupingInvoker.cb_keyOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IGroupingInvoker.n_KeyOf_Ljava_lang_Object_));
			}
			return IGroupingInvoker.cb_keyOf_Ljava_lang_Object_;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000AC2DC File Offset: 0x000AA4DC
		private static IntPtr n_KeyOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			IGrouping @object = Java.Lang.Object.GetObject<IGrouping>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.KeyOf(object2));
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000AC304 File Offset: 0x000AA504
		[NullableContext(2)]
		public unsafe Java.Lang.Object KeyOf(Java.Lang.Object element)
		{
			if (this.id_keyOf_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_keyOf_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "keyOf", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_keyOf_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000AC37B File Offset: 0x000AA57B
		private static Delegate GetSourceIteratorHandler()
		{
			if (IGroupingInvoker.cb_sourceIterator == null)
			{
				IGroupingInvoker.cb_sourceIterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGroupingInvoker.n_SourceIterator));
			}
			return IGroupingInvoker.cb_sourceIterator;
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000AC39F File Offset: 0x000AA59F
		private static IntPtr n_SourceIterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGrouping>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SourceIterator());
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000AC3B4 File Offset: 0x000AA5B4
		public IIterator SourceIterator()
		{
			if (this.id_sourceIterator == IntPtr.Zero)
			{
				this.id_sourceIterator = JNIEnv.GetMethodID(this.class_ref, "sourceIterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_sourceIterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040009AA RID: 2474
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/Grouping", typeof(IGroupingInvoker));

		// Token: 0x040009AB RID: 2475
		private IntPtr class_ref;

		// Token: 0x040009AC RID: 2476
		[Nullable(2)]
		private static Delegate cb_keyOf_Ljava_lang_Object_;

		// Token: 0x040009AD RID: 2477
		private IntPtr id_keyOf_Ljava_lang_Object_;

		// Token: 0x040009AE RID: 2478
		[Nullable(2)]
		private static Delegate cb_sourceIterator;

		// Token: 0x040009AF RID: 2479
		private IntPtr id_sourceIterator;
	}
}
