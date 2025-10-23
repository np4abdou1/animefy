using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000D8 RID: 216
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ChannelIterator", DoNotGenerateAcw = true)]
	internal class IChannelIteratorInvoker : Java.Lang.Object, IChannelIterator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00023EB4 File Offset: 0x000220B4
		private static IntPtr java_class_ref
		{
			get
			{
				return IChannelIteratorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00023ED8 File Offset: 0x000220D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IChannelIteratorInvoker._members;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00023EDF File Offset: 0x000220DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00023EE7 File Offset: 0x000220E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IChannelIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00023EF3 File Offset: 0x000220F3
		[NullableContext(2)]
		public static IChannelIterator GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IChannelIterator>(handle, transfer);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00023EFC File Offset: 0x000220FC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IChannelIteratorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.channels.ChannelIterator'.");
			}
			return handle;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00023F27 File Offset: 0x00022127
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00023F58 File Offset: 0x00022158
		public IChannelIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IChannelIteratorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00023F90 File Offset: 0x00022190
		private static Delegate GetHasNext_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IChannelIteratorInvoker.cb_hasNext_Lkotlin_coroutines_Continuation_ == null)
			{
				IChannelIteratorInvoker.cb_hasNext_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChannelIteratorInvoker.n_HasNext_Lkotlin_coroutines_Continuation_));
			}
			return IChannelIteratorInvoker.cb_hasNext_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00023FB4 File Offset: 0x000221B4
		private static IntPtr n_HasNext_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IChannelIterator @object = Java.Lang.Object.GetObject<IChannelIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HasNext(object2));
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00023FDC File Offset: 0x000221DC
		[return: Nullable(2)]
		public unsafe Java.Lang.Object HasNext(IContinuation p0)
		{
			if (this.id_hasNext_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_hasNext_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "hasNext", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_hasNext_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002405A File Offset: 0x0002225A
		private static Delegate GetNextHandler()
		{
			if (IChannelIteratorInvoker.cb_next == null)
			{
				IChannelIteratorInvoker.cb_next = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChannelIteratorInvoker.n_Next));
			}
			return IChannelIteratorInvoker.cb_next;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002407E File Offset: 0x0002227E
		private static IntPtr n_Next(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChannelIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Next());
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00024094 File Offset: 0x00022294
		[NullableContext(2)]
		public Java.Lang.Object Next()
		{
			if (this.id_next == IntPtr.Zero)
			{
				this.id_next = JNIEnv.GetMethodID(this.class_ref, "next", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_next), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000335 RID: 821
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ChannelIterator", typeof(IChannelIteratorInvoker));

		// Token: 0x04000336 RID: 822
		private IntPtr class_ref;

		// Token: 0x04000337 RID: 823
		[Nullable(2)]
		private static Delegate cb_hasNext_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000338 RID: 824
		private IntPtr id_hasNext_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000339 RID: 825
		[Nullable(2)]
		private static Delegate cb_next;

		// Token: 0x0400033A RID: 826
		private IntPtr id_next;
	}
}
