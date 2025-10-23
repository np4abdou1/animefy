using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000311 RID: 785
	[Register("java/util/ListIterator", DoNotGenerateAcw = true)]
	internal class IListIteratorInvoker : Java.Lang.Object, IListIterator, IIterator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00058850 File Offset: 0x00056A50
		private static IntPtr java_class_ref
		{
			get
			{
				return IListIteratorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00058874 File Offset: 0x00056A74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IListIteratorInvoker._members;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x0005887B File Offset: 0x00056A7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x00058883 File Offset: 0x00056A83
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IListIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0005888F File Offset: 0x00056A8F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IListIteratorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.ListIterator'.");
			}
			return handle;
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000588BA File Offset: 0x00056ABA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000588EC File Offset: 0x00056AEC
		public IListIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IListIteratorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00058924 File Offset: 0x00056B24
		private static Delegate GetHasNextHandler()
		{
			if (IListIteratorInvoker.cb_hasNext == null)
			{
				IListIteratorInvoker.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IListIteratorInvoker.n_HasNext));
			}
			return IListIteratorInvoker.cb_hasNext;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00058948 File Offset: 0x00056B48
		private static bool n_HasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x00058957 File Offset: 0x00056B57
		public bool HasNext
		{
			get
			{
				if (this.id_hasNext == IntPtr.Zero)
				{
					this.id_hasNext = JNIEnv.GetMethodID(this.class_ref, "hasNext", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasNext);
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00058997 File Offset: 0x00056B97
		private static Delegate GetHasPreviousHandler()
		{
			if (IListIteratorInvoker.cb_hasPrevious == null)
			{
				IListIteratorInvoker.cb_hasPrevious = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IListIteratorInvoker.n_HasPrevious));
			}
			return IListIteratorInvoker.cb_hasPrevious;
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000589BB File Offset: 0x00056BBB
		private static bool n_HasPrevious(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasPrevious;
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x000589CA File Offset: 0x00056BCA
		public bool HasPrevious
		{
			get
			{
				if (this.id_hasPrevious == IntPtr.Zero)
				{
					this.id_hasPrevious = JNIEnv.GetMethodID(this.class_ref, "hasPrevious", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasPrevious);
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00058A0A File Offset: 0x00056C0A
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (IListIteratorInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				IListIteratorInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IListIteratorInvoker.n_Add_Ljava_lang_Object_));
			}
			return IListIteratorInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00058A30 File Offset: 0x00056C30
		private static void n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IListIterator @object = Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.Add(object2);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00058A54 File Offset: 0x00056C54
		public unsafe void Add(Java.Lang.Object e)
		{
			if (this.id_add_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "add", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_add_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00058AC5 File Offset: 0x00056CC5
		private static Delegate GetNextHandler()
		{
			if (IListIteratorInvoker.cb_next == null)
			{
				IListIteratorInvoker.cb_next = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IListIteratorInvoker.n_Next));
			}
			return IListIteratorInvoker.cb_next;
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00058AE9 File Offset: 0x00056CE9
		private static IntPtr n_Next(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Next());
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00058B00 File Offset: 0x00056D00
		public Java.Lang.Object Next()
		{
			if (this.id_next == IntPtr.Zero)
			{
				this.id_next = JNIEnv.GetMethodID(this.class_ref, "next", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_next), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00058B51 File Offset: 0x00056D51
		private static Delegate GetNextIndexHandler()
		{
			if (IListIteratorInvoker.cb_nextIndex == null)
			{
				IListIteratorInvoker.cb_nextIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IListIteratorInvoker.n_NextIndex));
			}
			return IListIteratorInvoker.cb_nextIndex;
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00058B75 File Offset: 0x00056D75
		private static int n_NextIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextIndex();
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00058B84 File Offset: 0x00056D84
		public int NextIndex()
		{
			if (this.id_nextIndex == IntPtr.Zero)
			{
				this.id_nextIndex = JNIEnv.GetMethodID(this.class_ref, "nextIndex", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_nextIndex);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00058BC4 File Offset: 0x00056DC4
		private static Delegate GetPreviousHandler()
		{
			if (IListIteratorInvoker.cb_previous == null)
			{
				IListIteratorInvoker.cb_previous = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IListIteratorInvoker.n_Previous));
			}
			return IListIteratorInvoker.cb_previous;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00058BE8 File Offset: 0x00056DE8
		private static IntPtr n_Previous(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Previous());
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00058BFC File Offset: 0x00056DFC
		public Java.Lang.Object Previous()
		{
			if (this.id_previous == IntPtr.Zero)
			{
				this.id_previous = JNIEnv.GetMethodID(this.class_ref, "previous", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_previous), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00058C4D File Offset: 0x00056E4D
		private static Delegate GetPreviousIndexHandler()
		{
			if (IListIteratorInvoker.cb_previousIndex == null)
			{
				IListIteratorInvoker.cb_previousIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IListIteratorInvoker.n_PreviousIndex));
			}
			return IListIteratorInvoker.cb_previousIndex;
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00058C71 File Offset: 0x00056E71
		private static int n_PreviousIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreviousIndex();
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00058C80 File Offset: 0x00056E80
		public int PreviousIndex()
		{
			if (this.id_previousIndex == IntPtr.Zero)
			{
				this.id_previousIndex = JNIEnv.GetMethodID(this.class_ref, "previousIndex", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_previousIndex);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00058CC0 File Offset: 0x00056EC0
		private static Delegate GetRemoveHandler()
		{
			if (IListIteratorInvoker.cb_remove == null)
			{
				IListIteratorInvoker.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IListIteratorInvoker.n_Remove));
			}
			return IListIteratorInvoker.cb_remove;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00058CE4 File Offset: 0x00056EE4
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00058CF3 File Offset: 0x00056EF3
		public void Remove()
		{
			if (this.id_remove == IntPtr.Zero)
			{
				this.id_remove = JNIEnv.GetMethodID(this.class_ref, "remove", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_remove);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00058D33 File Offset: 0x00056F33
		private static Delegate GetSet_Ljava_lang_Object_Handler()
		{
			if (IListIteratorInvoker.cb_set_Ljava_lang_Object_ == null)
			{
				IListIteratorInvoker.cb_set_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IListIteratorInvoker.n_Set_Ljava_lang_Object_));
			}
			return IListIteratorInvoker.cb_set_Ljava_lang_Object_;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00058D58 File Offset: 0x00056F58
		private static void n_Set_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IListIterator @object = Java.Lang.Object.GetObject<IListIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00058D7C File Offset: 0x00056F7C
		public unsafe void Set(Java.Lang.Object e)
		{
			if (this.id_set_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_set_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "set", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_set_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000D2F RID: 3375
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/ListIterator", typeof(IListIteratorInvoker));

		// Token: 0x04000D30 RID: 3376
		private IntPtr class_ref;

		// Token: 0x04000D31 RID: 3377
		private static Delegate cb_hasNext;

		// Token: 0x04000D32 RID: 3378
		private IntPtr id_hasNext;

		// Token: 0x04000D33 RID: 3379
		private static Delegate cb_hasPrevious;

		// Token: 0x04000D34 RID: 3380
		private IntPtr id_hasPrevious;

		// Token: 0x04000D35 RID: 3381
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000D36 RID: 3382
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000D37 RID: 3383
		private static Delegate cb_next;

		// Token: 0x04000D38 RID: 3384
		private IntPtr id_next;

		// Token: 0x04000D39 RID: 3385
		private static Delegate cb_nextIndex;

		// Token: 0x04000D3A RID: 3386
		private IntPtr id_nextIndex;

		// Token: 0x04000D3B RID: 3387
		private static Delegate cb_previous;

		// Token: 0x04000D3C RID: 3388
		private IntPtr id_previous;

		// Token: 0x04000D3D RID: 3389
		private static Delegate cb_previousIndex;

		// Token: 0x04000D3E RID: 3390
		private IntPtr id_previousIndex;

		// Token: 0x04000D3F RID: 3391
		private static Delegate cb_remove;

		// Token: 0x04000D40 RID: 3392
		private IntPtr id_remove;

		// Token: 0x04000D41 RID: 3393
		private static Delegate cb_set_Ljava_lang_Object_;

		// Token: 0x04000D42 RID: 3394
		private IntPtr id_set_Ljava_lang_Object_;
	}
}
