using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util
{
	// Token: 0x0200031F RID: 799
	[Register("java/util/Spliterator", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class ISpliteratorInvoker : Java.Lang.Object, ISpliterator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002208 RID: 8712 RVA: 0x000602E8 File Offset: 0x0005E4E8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISpliteratorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x0006030C File Offset: 0x0005E50C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISpliteratorInvoker._members;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x00060313 File Offset: 0x0005E513
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x0006031B File Offset: 0x0005E51B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISpliteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00060327 File Offset: 0x0005E527
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISpliteratorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Spliterator'.");
			}
			return handle;
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x00060352 File Offset: 0x0005E552
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00060384 File Offset: 0x0005E584
		public ISpliteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISpliteratorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000603BC File Offset: 0x0005E5BC
		private static Delegate GetCharacteristicsHandler()
		{
			if (ISpliteratorInvoker.cb_characteristics == null)
			{
				ISpliteratorInvoker.cb_characteristics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISpliteratorInvoker.n_Characteristics));
			}
			return ISpliteratorInvoker.cb_characteristics;
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000603E0 File Offset: 0x0005E5E0
		private static int n_Characteristics(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<ISpliterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Characteristics();
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000603EF File Offset: 0x0005E5EF
		public SpliteratorCharacteristics Characteristics()
		{
			if (this.id_characteristics == IntPtr.Zero)
			{
				this.id_characteristics = JNIEnv.GetMethodID(this.class_ref, "characteristics", "()I");
			}
			return (SpliteratorCharacteristics)JNIEnv.CallIntMethod(base.Handle, this.id_characteristics);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0006042F File Offset: 0x0005E62F
		private static Delegate GetEstimateSizeHandler()
		{
			if (ISpliteratorInvoker.cb_estimateSize == null)
			{
				ISpliteratorInvoker.cb_estimateSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(ISpliteratorInvoker.n_EstimateSize));
			}
			return ISpliteratorInvoker.cb_estimateSize;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00060453 File Offset: 0x0005E653
		private static long n_EstimateSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISpliterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EstimateSize();
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00060462 File Offset: 0x0005E662
		public long EstimateSize()
		{
			if (this.id_estimateSize == IntPtr.Zero)
			{
				this.id_estimateSize = JNIEnv.GetMethodID(this.class_ref, "estimateSize", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_estimateSize);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000604A2 File Offset: 0x0005E6A2
		private static Delegate GetTryAdvance_Ljava_util_function_Consumer_Handler()
		{
			if (ISpliteratorInvoker.cb_tryAdvance_Ljava_util_function_Consumer_ == null)
			{
				ISpliteratorInvoker.cb_tryAdvance_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISpliteratorInvoker.n_TryAdvance_Ljava_util_function_Consumer_));
			}
			return ISpliteratorInvoker.cb_tryAdvance_Ljava_util_function_Consumer_;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x000604C8 File Offset: 0x0005E6C8
		private static bool n_TryAdvance_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			ISpliterator @object = Java.Lang.Object.GetObject<ISpliterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return @object.TryAdvance(object2);
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x000604EC File Offset: 0x0005E6EC
		public unsafe bool TryAdvance(IConsumer action)
		{
			if (this.id_tryAdvance_Ljava_util_function_Consumer_ == IntPtr.Zero)
			{
				this.id_tryAdvance_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "tryAdvance", "(Ljava/util/function/Consumer;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_tryAdvance_Ljava_util_function_Consumer_, ptr);
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x00060564 File Offset: 0x0005E764
		private static Delegate GetTrySplitHandler()
		{
			if (ISpliteratorInvoker.cb_trySplit == null)
			{
				ISpliteratorInvoker.cb_trySplit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISpliteratorInvoker.n_TrySplit));
			}
			return ISpliteratorInvoker.cb_trySplit;
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00060588 File Offset: 0x0005E788
		private static IntPtr n_TrySplit(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISpliterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrySplit());
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0006059C File Offset: 0x0005E79C
		public ISpliterator TrySplit()
		{
			if (this.id_trySplit == IntPtr.Zero)
			{
				this.id_trySplit = JNIEnv.GetMethodID(this.class_ref, "trySplit", "()Ljava/util/Spliterator;");
			}
			return Java.Lang.Object.GetObject<ISpliterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_trySplit), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000E0D RID: 3597
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Spliterator", typeof(ISpliteratorInvoker));

		// Token: 0x04000E0E RID: 3598
		private IntPtr class_ref;

		// Token: 0x04000E0F RID: 3599
		private static Delegate cb_characteristics;

		// Token: 0x04000E10 RID: 3600
		private IntPtr id_characteristics;

		// Token: 0x04000E11 RID: 3601
		private static Delegate cb_estimateSize;

		// Token: 0x04000E12 RID: 3602
		private IntPtr id_estimateSize;

		// Token: 0x04000E13 RID: 3603
		private static Delegate cb_tryAdvance_Ljava_util_function_Consumer_;

		// Token: 0x04000E14 RID: 3604
		private IntPtr id_tryAdvance_Ljava_util_function_Consumer_;

		// Token: 0x04000E15 RID: 3605
		private static Delegate cb_trySplit;

		// Token: 0x04000E16 RID: 3606
		private IntPtr id_trySplit;
	}
}
