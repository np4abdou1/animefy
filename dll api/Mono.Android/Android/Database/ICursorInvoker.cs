using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Android.Database
{
	// Token: 0x02000245 RID: 581
	[Register("android/database/Cursor", DoNotGenerateAcw = true)]
	internal class ICursorInvoker : Java.Lang.Object, ICursor, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x00034C24 File Offset: 0x00032E24
		private static IntPtr java_class_ref
		{
			get
			{
				return ICursorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x00034C48 File Offset: 0x00032E48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICursorInvoker._members;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00034C4F File Offset: 0x00032E4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x00034C57 File Offset: 0x00032E57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICursorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00034C63 File Offset: 0x00032E63
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICursorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.database.Cursor'.");
			}
			return handle;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00034C8E File Offset: 0x00032E8E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00034CC0 File Offset: 0x00032EC0
		public ICursorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICursorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00034CF8 File Offset: 0x00032EF8
		private static Delegate GetGetColumnCountHandler()
		{
			if (ICursorInvoker.cb_getColumnCount == null)
			{
				ICursorInvoker.cb_getColumnCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICursorInvoker.n_GetColumnCount));
			}
			return ICursorInvoker.cb_getColumnCount;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00034D1C File Offset: 0x00032F1C
		private static int n_GetColumnCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ColumnCount;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00034D2B File Offset: 0x00032F2B
		public int ColumnCount
		{
			get
			{
				if (this.id_getColumnCount == IntPtr.Zero)
				{
					this.id_getColumnCount = JNIEnv.GetMethodID(this.class_ref, "getColumnCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getColumnCount);
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00034D6B File Offset: 0x00032F6B
		private static Delegate GetGetCountHandler()
		{
			if (ICursorInvoker.cb_getCount == null)
			{
				ICursorInvoker.cb_getCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICursorInvoker.n_GetCount));
			}
			return ICursorInvoker.cb_getCount;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00034D8F File Offset: 0x00032F8F
		private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count;
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x00034D9E File Offset: 0x00032F9E
		public int Count
		{
			get
			{
				if (this.id_getCount == IntPtr.Zero)
				{
					this.id_getCount = JNIEnv.GetMethodID(this.class_ref, "getCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getCount);
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00034DDE File Offset: 0x00032FDE
		private static Delegate GetGetExtrasHandler()
		{
			if (ICursorInvoker.cb_getExtras == null)
			{
				ICursorInvoker.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICursorInvoker.n_GetExtras));
			}
			return ICursorInvoker.cb_getExtras;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00034E02 File Offset: 0x00033002
		private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Extras);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00034E16 File Offset: 0x00033016
		private static Delegate GetSetExtras_Landroid_os_Bundle_Handler()
		{
			if (ICursorInvoker.cb_setExtras_Landroid_os_Bundle_ == null)
			{
				ICursorInvoker.cb_setExtras_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICursorInvoker.n_SetExtras_Landroid_os_Bundle_));
			}
			return ICursorInvoker.cb_setExtras_Landroid_os_Bundle_;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00034E3C File Offset: 0x0003303C
		private static void n_SetExtras_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_extras, JniHandleOwnership.DoNotTransfer);
			@object.Extras = object2;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x00034E60 File Offset: 0x00033060
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00034EB4 File Offset: 0x000330B4
		public unsafe Bundle Extras
		{
			get
			{
				if (this.id_getExtras == IntPtr.Zero)
				{
					this.id_getExtras = JNIEnv.GetMethodID(this.class_ref, "getExtras", "()Landroid/os/Bundle;");
				}
				return Java.Lang.Object.GetObject<Bundle>(JNIEnv.CallObjectMethod(base.Handle, this.id_getExtras), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setExtras_Landroid_os_Bundle_ == IntPtr.Zero)
				{
					this.id_setExtras_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "setExtras", "(Landroid/os/Bundle;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setExtras_Landroid_os_Bundle_, ptr);
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00034F27 File Offset: 0x00033127
		private static Delegate GetIsAfterLastHandler()
		{
			if (ICursorInvoker.cb_isAfterLast == null)
			{
				ICursorInvoker.cb_isAfterLast = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_IsAfterLast));
			}
			return ICursorInvoker.cb_isAfterLast;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00034F4B File Offset: 0x0003314B
		private static bool n_IsAfterLast(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAfterLast;
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00034F5A File Offset: 0x0003315A
		public bool IsAfterLast
		{
			get
			{
				if (this.id_isAfterLast == IntPtr.Zero)
				{
					this.id_isAfterLast = JNIEnv.GetMethodID(this.class_ref, "isAfterLast", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isAfterLast);
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00034F9A File Offset: 0x0003319A
		private static Delegate GetIsBeforeFirstHandler()
		{
			if (ICursorInvoker.cb_isBeforeFirst == null)
			{
				ICursorInvoker.cb_isBeforeFirst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_IsBeforeFirst));
			}
			return ICursorInvoker.cb_isBeforeFirst;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00034FBE File Offset: 0x000331BE
		private static bool n_IsBeforeFirst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsBeforeFirst;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00034FCD File Offset: 0x000331CD
		public bool IsBeforeFirst
		{
			get
			{
				if (this.id_isBeforeFirst == IntPtr.Zero)
				{
					this.id_isBeforeFirst = JNIEnv.GetMethodID(this.class_ref, "isBeforeFirst", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isBeforeFirst);
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0003500D File Offset: 0x0003320D
		private static Delegate GetIsClosedHandler()
		{
			if (ICursorInvoker.cb_isClosed == null)
			{
				ICursorInvoker.cb_isClosed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_IsClosed));
			}
			return ICursorInvoker.cb_isClosed;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00035031 File Offset: 0x00033231
		private static bool n_IsClosed(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsClosed;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00035040 File Offset: 0x00033240
		public bool IsClosed
		{
			get
			{
				if (this.id_isClosed == IntPtr.Zero)
				{
					this.id_isClosed = JNIEnv.GetMethodID(this.class_ref, "isClosed", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isClosed);
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00035080 File Offset: 0x00033280
		private static Delegate GetIsFirstHandler()
		{
			if (ICursorInvoker.cb_isFirst == null)
			{
				ICursorInvoker.cb_isFirst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_IsFirst));
			}
			return ICursorInvoker.cb_isFirst;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000350A4 File Offset: 0x000332A4
		private static bool n_IsFirst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFirst;
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x000350B3 File Offset: 0x000332B3
		public bool IsFirst
		{
			get
			{
				if (this.id_isFirst == IntPtr.Zero)
				{
					this.id_isFirst = JNIEnv.GetMethodID(this.class_ref, "isFirst", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isFirst);
			}
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000350F3 File Offset: 0x000332F3
		private static Delegate GetIsLastHandler()
		{
			if (ICursorInvoker.cb_isLast == null)
			{
				ICursorInvoker.cb_isLast = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_IsLast));
			}
			return ICursorInvoker.cb_isLast;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00035117 File Offset: 0x00033317
		private static bool n_IsLast(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLast;
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00035126 File Offset: 0x00033326
		public bool IsLast
		{
			get
			{
				if (this.id_isLast == IntPtr.Zero)
				{
					this.id_isLast = JNIEnv.GetMethodID(this.class_ref, "isLast", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isLast);
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00035166 File Offset: 0x00033366
		private static Delegate GetGetNotificationUriHandler()
		{
			if (ICursorInvoker.cb_getNotificationUri == null)
			{
				ICursorInvoker.cb_getNotificationUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICursorInvoker.n_GetNotificationUri));
			}
			return ICursorInvoker.cb_getNotificationUri;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0003518A File Offset: 0x0003338A
		private static IntPtr n_GetNotificationUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NotificationUri);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x000351A0 File Offset: 0x000333A0
		public Android.Net.Uri NotificationUri
		{
			get
			{
				if (this.id_getNotificationUri == IntPtr.Zero)
				{
					this.id_getNotificationUri = JNIEnv.GetMethodID(this.class_ref, "getNotificationUri", "()Landroid/net/Uri;");
				}
				return Java.Lang.Object.GetObject<Android.Net.Uri>(JNIEnv.CallObjectMethod(base.Handle, this.id_getNotificationUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000351F1 File Offset: 0x000333F1
		private static Delegate GetGetPositionHandler()
		{
			if (ICursorInvoker.cb_getPosition == null)
			{
				ICursorInvoker.cb_getPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICursorInvoker.n_GetPosition));
			}
			return ICursorInvoker.cb_getPosition;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00035215 File Offset: 0x00033415
		private static int n_GetPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Position;
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x00035224 File Offset: 0x00033424
		public int Position
		{
			get
			{
				if (this.id_getPosition == IntPtr.Zero)
				{
					this.id_getPosition = JNIEnv.GetMethodID(this.class_ref, "getPosition", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getPosition);
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00035264 File Offset: 0x00033464
		private static Delegate GetGetWantsAllOnMoveCallsHandler()
		{
			if (ICursorInvoker.cb_getWantsAllOnMoveCalls == null)
			{
				ICursorInvoker.cb_getWantsAllOnMoveCalls = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_GetWantsAllOnMoveCalls));
			}
			return ICursorInvoker.cb_getWantsAllOnMoveCalls;
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00035288 File Offset: 0x00033488
		private static bool n_GetWantsAllOnMoveCalls(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WantsAllOnMoveCalls;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00035297 File Offset: 0x00033497
		public bool WantsAllOnMoveCalls
		{
			get
			{
				if (this.id_getWantsAllOnMoveCalls == IntPtr.Zero)
				{
					this.id_getWantsAllOnMoveCalls = JNIEnv.GetMethodID(this.class_ref, "getWantsAllOnMoveCalls", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_getWantsAllOnMoveCalls);
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000352D7 File Offset: 0x000334D7
		private static Delegate GetCloseHandler()
		{
			if (ICursorInvoker.cb_close == null)
			{
				ICursorInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICursorInvoker.n_Close));
			}
			return ICursorInvoker.cb_close;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000352FB File Offset: 0x000334FB
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0003530A File Offset: 0x0003350A
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0003534A File Offset: 0x0003354A
		private static Delegate GetCopyStringToBuffer_ILandroid_database_CharArrayBuffer_Handler()
		{
			if (ICursorInvoker.cb_copyStringToBuffer_ILandroid_database_CharArrayBuffer_ == null)
			{
				ICursorInvoker.cb_copyStringToBuffer_ILandroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(ICursorInvoker.n_CopyStringToBuffer_ILandroid_database_CharArrayBuffer_));
			}
			return ICursorInvoker.cb_copyStringToBuffer_ILandroid_database_CharArrayBuffer_;
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00035370 File Offset: 0x00033570
		private static void n_CopyStringToBuffer_ILandroid_database_CharArrayBuffer_(IntPtr jnienv, IntPtr native__this, int columnIndex, IntPtr native_buffer)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CharArrayBuffer object2 = Java.Lang.Object.GetObject<CharArrayBuffer>(native_buffer, JniHandleOwnership.DoNotTransfer);
			@object.CopyStringToBuffer(columnIndex, object2);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00035394 File Offset: 0x00033594
		public unsafe void CopyStringToBuffer(int columnIndex, CharArrayBuffer buffer)
		{
			if (this.id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_ == IntPtr.Zero)
			{
				this.id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID(this.class_ref, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			ptr[1] = new JValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_, ptr);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0003541A File Offset: 0x0003361A
		private static Delegate GetDeactivateHandler()
		{
			if (ICursorInvoker.cb_deactivate == null)
			{
				ICursorInvoker.cb_deactivate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICursorInvoker.n_Deactivate));
			}
			return ICursorInvoker.cb_deactivate;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0003543E File Offset: 0x0003363E
		private static void n_Deactivate(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Deactivate();
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0003544D File Offset: 0x0003364D
		public void Deactivate()
		{
			if (this.id_deactivate == IntPtr.Zero)
			{
				this.id_deactivate = JNIEnv.GetMethodID(this.class_ref, "deactivate", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_deactivate);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0003548D File Offset: 0x0003368D
		private static Delegate GetGetBlob_IHandler()
		{
			if (ICursorInvoker.cb_getBlob_I == null)
			{
				ICursorInvoker.cb_getBlob_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ICursorInvoker.n_GetBlob_I));
			}
			return ICursorInvoker.cb_getBlob_I;
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000354B1 File Offset: 0x000336B1
		private static IntPtr n_GetBlob_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetBlob(columnIndex));
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000354C8 File Offset: 0x000336C8
		public unsafe byte[] GetBlob(int columnIndex)
		{
			if (this.id_getBlob_I == IntPtr.Zero)
			{
				this.id_getBlob_I = JNIEnv.GetMethodID(this.class_ref, "getBlob", "(I)[B");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getBlob_I, ptr), JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00035541 File Offset: 0x00033741
		private static Delegate GetGetColumnIndex_Ljava_lang_String_Handler()
		{
			if (ICursorInvoker.cb_getColumnIndex_Ljava_lang_String_ == null)
			{
				ICursorInvoker.cb_getColumnIndex_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ICursorInvoker.n_GetColumnIndex_Ljava_lang_String_));
			}
			return ICursorInvoker.cb_getColumnIndex_Ljava_lang_String_;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00035568 File Offset: 0x00033768
		private static int n_GetColumnIndex_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_columnName)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_columnName, JniHandleOwnership.DoNotTransfer);
			return @object.GetColumnIndex(@string);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0003558C File Offset: 0x0003378C
		public unsafe int GetColumnIndex(string columnName)
		{
			if (this.id_getColumnIndex_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getColumnIndex_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getColumnIndex", "(Ljava/lang/String;)I");
			}
			IntPtr intPtr = JNIEnv.NewString(columnName);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getColumnIndex_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000355FD File Offset: 0x000337FD
		private static Delegate GetGetColumnIndexOrThrow_Ljava_lang_String_Handler()
		{
			if (ICursorInvoker.cb_getColumnIndexOrThrow_Ljava_lang_String_ == null)
			{
				ICursorInvoker.cb_getColumnIndexOrThrow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ICursorInvoker.n_GetColumnIndexOrThrow_Ljava_lang_String_));
			}
			return ICursorInvoker.cb_getColumnIndexOrThrow_Ljava_lang_String_;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00035624 File Offset: 0x00033824
		private static int n_GetColumnIndexOrThrow_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_columnName)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_columnName, JniHandleOwnership.DoNotTransfer);
			return @object.GetColumnIndexOrThrow(@string);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00035648 File Offset: 0x00033848
		public unsafe int GetColumnIndexOrThrow(string columnName)
		{
			if (this.id_getColumnIndexOrThrow_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getColumnIndexOrThrow_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			}
			IntPtr intPtr = JNIEnv.NewString(columnName);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getColumnIndexOrThrow_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000356B9 File Offset: 0x000338B9
		private static Delegate GetGetColumnName_IHandler()
		{
			if (ICursorInvoker.cb_getColumnName_I == null)
			{
				ICursorInvoker.cb_getColumnName_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ICursorInvoker.n_GetColumnName_I));
			}
			return ICursorInvoker.cb_getColumnName_I;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x000356DD File Offset: 0x000338DD
		private static IntPtr n_GetColumnName_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetColumnName(columnIndex));
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000356F4 File Offset: 0x000338F4
		public unsafe string GetColumnName(int columnIndex)
		{
			if (this.id_getColumnName_I == IntPtr.Zero)
			{
				this.id_getColumnName_I = JNIEnv.GetMethodID(this.class_ref, "getColumnName", "(I)Ljava/lang/String;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getColumnName_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0003575E File Offset: 0x0003395E
		private static Delegate GetGetColumnNamesHandler()
		{
			if (ICursorInvoker.cb_getColumnNames == null)
			{
				ICursorInvoker.cb_getColumnNames = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICursorInvoker.n_GetColumnNames));
			}
			return ICursorInvoker.cb_getColumnNames;
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00035782 File Offset: 0x00033982
		private static IntPtr n_GetColumnNames(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetColumnNames());
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00035798 File Offset: 0x00033998
		public string[] GetColumnNames()
		{
			if (this.id_getColumnNames == IntPtr.Zero)
			{
				this.id_getColumnNames = JNIEnv.GetMethodID(this.class_ref, "getColumnNames", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getColumnNames), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000357F8 File Offset: 0x000339F8
		private static Delegate GetGetDouble_IHandler()
		{
			if (ICursorInvoker.cb_getDouble_I == null)
			{
				ICursorInvoker.cb_getDouble_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_D(ICursorInvoker.n_GetDouble_I));
			}
			return ICursorInvoker.cb_getDouble_I;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0003581C File Offset: 0x00033A1C
		private static double n_GetDouble_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDouble(columnIndex);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0003582C File Offset: 0x00033A2C
		public unsafe double GetDouble(int columnIndex)
		{
			if (this.id_getDouble_I == IntPtr.Zero)
			{
				this.id_getDouble_I = JNIEnv.GetMethodID(this.class_ref, "getDouble", "(I)D");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return JNIEnv.CallDoubleMethod(base.Handle, this.id_getDouble_I, ptr);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00035890 File Offset: 0x00033A90
		private static Delegate GetGetFloat_IHandler()
		{
			if (ICursorInvoker.cb_getFloat_I == null)
			{
				ICursorInvoker.cb_getFloat_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_F(ICursorInvoker.n_GetFloat_I));
			}
			return ICursorInvoker.cb_getFloat_I;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000358B4 File Offset: 0x00033AB4
		private static float n_GetFloat_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetFloat(columnIndex);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000358C4 File Offset: 0x00033AC4
		public unsafe float GetFloat(int columnIndex)
		{
			if (this.id_getFloat_I == IntPtr.Zero)
			{
				this.id_getFloat_I = JNIEnv.GetMethodID(this.class_ref, "getFloat", "(I)F");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return JNIEnv.CallFloatMethod(base.Handle, this.id_getFloat_I, ptr);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00035928 File Offset: 0x00033B28
		private static Delegate GetGetInt_IHandler()
		{
			if (ICursorInvoker.cb_getInt_I == null)
			{
				ICursorInvoker.cb_getInt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(ICursorInvoker.n_GetInt_I));
			}
			return ICursorInvoker.cb_getInt_I;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0003594C File Offset: 0x00033B4C
		private static int n_GetInt_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetInt(columnIndex);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0003595C File Offset: 0x00033B5C
		public unsafe int GetInt(int columnIndex)
		{
			if (this.id_getInt_I == IntPtr.Zero)
			{
				this.id_getInt_I = JNIEnv.GetMethodID(this.class_ref, "getInt", "(I)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getInt_I, ptr);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x000359C0 File Offset: 0x00033BC0
		private static Delegate GetGetLong_IHandler()
		{
			if (ICursorInvoker.cb_getLong_I == null)
			{
				ICursorInvoker.cb_getLong_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_J(ICursorInvoker.n_GetLong_I));
			}
			return ICursorInvoker.cb_getLong_I;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000359E4 File Offset: 0x00033BE4
		private static long n_GetLong_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetLong(columnIndex);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000359F4 File Offset: 0x00033BF4
		public unsafe long GetLong(int columnIndex)
		{
			if (this.id_getLong_I == IntPtr.Zero)
			{
				this.id_getLong_I = JNIEnv.GetMethodID(this.class_ref, "getLong", "(I)J");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return JNIEnv.CallLongMethod(base.Handle, this.id_getLong_I, ptr);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00035A58 File Offset: 0x00033C58
		private static Delegate GetGetShort_IHandler()
		{
			if (ICursorInvoker.cb_getShort_I == null)
			{
				ICursorInvoker.cb_getShort_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_S(ICursorInvoker.n_GetShort_I));
			}
			return ICursorInvoker.cb_getShort_I;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00035A7C File Offset: 0x00033C7C
		private static short n_GetShort_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetShort(columnIndex);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00035A8C File Offset: 0x00033C8C
		public unsafe short GetShort(int columnIndex)
		{
			if (this.id_getShort_I == IntPtr.Zero)
			{
				this.id_getShort_I = JNIEnv.GetMethodID(this.class_ref, "getShort", "(I)S");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return JNIEnv.CallShortMethod(base.Handle, this.id_getShort_I, ptr);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00035AF0 File Offset: 0x00033CF0
		private static Delegate GetGetString_IHandler()
		{
			if (ICursorInvoker.cb_getString_I == null)
			{
				ICursorInvoker.cb_getString_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ICursorInvoker.n_GetString_I));
			}
			return ICursorInvoker.cb_getString_I;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00035B14 File Offset: 0x00033D14
		private static IntPtr n_GetString_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetString(columnIndex));
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00035B2C File Offset: 0x00033D2C
		public unsafe string GetString(int columnIndex)
		{
			if (this.id_getString_I == IntPtr.Zero)
			{
				this.id_getString_I = JNIEnv.GetMethodID(this.class_ref, "getString", "(I)Ljava/lang/String;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getString_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00035B96 File Offset: 0x00033D96
		private static Delegate GetGetType_IHandler()
		{
			if (ICursorInvoker.cb_getType_I == null)
			{
				ICursorInvoker.cb_getType_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(ICursorInvoker.n_GetType_I));
			}
			return ICursorInvoker.cb_getType_I;
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00035BBA File Offset: 0x00033DBA
		private static int n_GetType_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return (int)Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetType(columnIndex);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00035BCC File Offset: 0x00033DCC
		public unsafe FieldType GetType(int columnIndex)
		{
			if (this.id_getType_I == IntPtr.Zero)
			{
				this.id_getType_I = JNIEnv.GetMethodID(this.class_ref, "getType", "(I)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return (FieldType)JNIEnv.CallIntMethod(base.Handle, this.id_getType_I, ptr);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00035C30 File Offset: 0x00033E30
		private static Delegate GetIsNull_IHandler()
		{
			if (ICursorInvoker.cb_isNull_I == null)
			{
				ICursorInvoker.cb_isNull_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(ICursorInvoker.n_IsNull_I));
			}
			return ICursorInvoker.cb_isNull_I;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00035C54 File Offset: 0x00033E54
		private static bool n_IsNull_I(IntPtr jnienv, IntPtr native__this, int columnIndex)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNull(columnIndex);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00035C64 File Offset: 0x00033E64
		public unsafe bool IsNull(int columnIndex)
		{
			if (this.id_isNull_I == IntPtr.Zero)
			{
				this.id_isNull_I = JNIEnv.GetMethodID(this.class_ref, "isNull", "(I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(columnIndex);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_isNull_I, ptr);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00035CC8 File Offset: 0x00033EC8
		private static Delegate GetMove_IHandler()
		{
			if (ICursorInvoker.cb_move_I == null)
			{
				ICursorInvoker.cb_move_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(ICursorInvoker.n_Move_I));
			}
			return ICursorInvoker.cb_move_I;
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00035CEC File Offset: 0x00033EEC
		private static bool n_Move_I(IntPtr jnienv, IntPtr native__this, int offset)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Move(offset);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00035CFC File Offset: 0x00033EFC
		public unsafe bool Move(int offset)
		{
			if (this.id_move_I == IntPtr.Zero)
			{
				this.id_move_I = JNIEnv.GetMethodID(this.class_ref, "move", "(I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(offset);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_move_I, ptr);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00035D60 File Offset: 0x00033F60
		private static Delegate GetMoveToFirstHandler()
		{
			if (ICursorInvoker.cb_moveToFirst == null)
			{
				ICursorInvoker.cb_moveToFirst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_MoveToFirst));
			}
			return ICursorInvoker.cb_moveToFirst;
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00035D84 File Offset: 0x00033F84
		private static bool n_MoveToFirst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveToFirst();
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00035D93 File Offset: 0x00033F93
		public bool MoveToFirst()
		{
			if (this.id_moveToFirst == IntPtr.Zero)
			{
				this.id_moveToFirst = JNIEnv.GetMethodID(this.class_ref, "moveToFirst", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_moveToFirst);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00035DD3 File Offset: 0x00033FD3
		private static Delegate GetMoveToLastHandler()
		{
			if (ICursorInvoker.cb_moveToLast == null)
			{
				ICursorInvoker.cb_moveToLast = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_MoveToLast));
			}
			return ICursorInvoker.cb_moveToLast;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00035DF7 File Offset: 0x00033FF7
		private static bool n_MoveToLast(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveToLast();
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00035E06 File Offset: 0x00034006
		public bool MoveToLast()
		{
			if (this.id_moveToLast == IntPtr.Zero)
			{
				this.id_moveToLast = JNIEnv.GetMethodID(this.class_ref, "moveToLast", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_moveToLast);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00035E46 File Offset: 0x00034046
		private static Delegate GetMoveToNextHandler()
		{
			if (ICursorInvoker.cb_moveToNext == null)
			{
				ICursorInvoker.cb_moveToNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_MoveToNext));
			}
			return ICursorInvoker.cb_moveToNext;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00035E6A File Offset: 0x0003406A
		private static bool n_MoveToNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveToNext();
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00035E79 File Offset: 0x00034079
		public bool MoveToNext()
		{
			if (this.id_moveToNext == IntPtr.Zero)
			{
				this.id_moveToNext = JNIEnv.GetMethodID(this.class_ref, "moveToNext", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_moveToNext);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00035EB9 File Offset: 0x000340B9
		private static Delegate GetMoveToPosition_IHandler()
		{
			if (ICursorInvoker.cb_moveToPosition_I == null)
			{
				ICursorInvoker.cb_moveToPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(ICursorInvoker.n_MoveToPosition_I));
			}
			return ICursorInvoker.cb_moveToPosition_I;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00035EDD File Offset: 0x000340DD
		private static bool n_MoveToPosition_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveToPosition(position);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00035EF0 File Offset: 0x000340F0
		public unsafe bool MoveToPosition(int position)
		{
			if (this.id_moveToPosition_I == IntPtr.Zero)
			{
				this.id_moveToPosition_I = JNIEnv.GetMethodID(this.class_ref, "moveToPosition", "(I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(position);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_moveToPosition_I, ptr);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00035F54 File Offset: 0x00034154
		private static Delegate GetMoveToPreviousHandler()
		{
			if (ICursorInvoker.cb_moveToPrevious == null)
			{
				ICursorInvoker.cb_moveToPrevious = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_MoveToPrevious));
			}
			return ICursorInvoker.cb_moveToPrevious;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00035F78 File Offset: 0x00034178
		private static bool n_MoveToPrevious(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveToPrevious();
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00035F87 File Offset: 0x00034187
		public bool MoveToPrevious()
		{
			if (this.id_moveToPrevious == IntPtr.Zero)
			{
				this.id_moveToPrevious = JNIEnv.GetMethodID(this.class_ref, "moveToPrevious", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_moveToPrevious);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00035FC7 File Offset: 0x000341C7
		private static Delegate GetRegisterContentObserver_Landroid_database_ContentObserver_Handler()
		{
			if (ICursorInvoker.cb_registerContentObserver_Landroid_database_ContentObserver_ == null)
			{
				ICursorInvoker.cb_registerContentObserver_Landroid_database_ContentObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICursorInvoker.n_RegisterContentObserver_Landroid_database_ContentObserver_));
			}
			return ICursorInvoker.cb_registerContentObserver_Landroid_database_ContentObserver_;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00035FEC File Offset: 0x000341EC
		private static void n_RegisterContentObserver_Landroid_database_ContentObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ContentObserver object2 = Java.Lang.Object.GetObject<ContentObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RegisterContentObserver(object2);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00036010 File Offset: 0x00034210
		public unsafe void RegisterContentObserver(ContentObserver observer)
		{
			if (this.id_registerContentObserver_Landroid_database_ContentObserver_ == IntPtr.Zero)
			{
				this.id_registerContentObserver_Landroid_database_ContentObserver_ = JNIEnv.GetMethodID(this.class_ref, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((observer == null) ? IntPtr.Zero : observer.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_registerContentObserver_Landroid_database_ContentObserver_, ptr);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00036083 File Offset: 0x00034283
		private static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler()
		{
			if (ICursorInvoker.cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
			{
				ICursorInvoker.cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICursorInvoker.n_RegisterDataSetObserver_Landroid_database_DataSetObserver_));
			}
			return ICursorInvoker.cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000360A8 File Offset: 0x000342A8
		private static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSetObserver object2 = Java.Lang.Object.GetObject<DataSetObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RegisterDataSetObserver(object2);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000360CC File Offset: 0x000342CC
		public unsafe void RegisterDataSetObserver(DataSetObserver observer)
		{
			if (this.id_registerDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
			{
				this.id_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID(this.class_ref, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((observer == null) ? IntPtr.Zero : observer.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_registerDataSetObserver_Landroid_database_DataSetObserver_, ptr);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0003613F File Offset: 0x0003433F
		private static Delegate GetRequeryHandler()
		{
			if (ICursorInvoker.cb_requery == null)
			{
				ICursorInvoker.cb_requery = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICursorInvoker.n_Requery));
			}
			return ICursorInvoker.cb_requery;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00036163 File Offset: 0x00034363
		private static bool n_Requery(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Requery();
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00036172 File Offset: 0x00034372
		public bool Requery()
		{
			if (this.id_requery == IntPtr.Zero)
			{
				this.id_requery = JNIEnv.GetMethodID(this.class_ref, "requery", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_requery);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000361B2 File Offset: 0x000343B2
		private static Delegate GetRespond_Landroid_os_Bundle_Handler()
		{
			if (ICursorInvoker.cb_respond_Landroid_os_Bundle_ == null)
			{
				ICursorInvoker.cb_respond_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICursorInvoker.n_Respond_Landroid_os_Bundle_));
			}
			return ICursorInvoker.cb_respond_Landroid_os_Bundle_;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000361D8 File Offset: 0x000343D8
		private static IntPtr n_Respond_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_extras, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Respond(object2));
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00036200 File Offset: 0x00034400
		public unsafe Bundle Respond(Bundle extras)
		{
			if (this.id_respond_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_respond_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((extras == null) ? IntPtr.Zero : extras.Handle);
			return Java.Lang.Object.GetObject<Bundle>(JNIEnv.CallObjectMethod(base.Handle, this.id_respond_Landroid_os_Bundle_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00036279 File Offset: 0x00034479
		private static Delegate GetSetNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_Handler()
		{
			if (ICursorInvoker.cb_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ == null)
			{
				ICursorInvoker.cb_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ICursorInvoker.n_SetNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_));
			}
			return ICursorInvoker.cb_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000362A0 File Offset: 0x000344A0
		private static void n_SetNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_cr, IntPtr native_uri)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ContentResolver object2 = Java.Lang.Object.GetObject<ContentResolver>(native_cr, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object3 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			@object.SetNotificationUri(object2, object3);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000362CC File Offset: 0x000344CC
		public unsafe void SetNotificationUri(ContentResolver cr, Android.Net.Uri uri)
		{
			if (this.id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ == IntPtr.Zero)
			{
				this.id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_ = JNIEnv.GetMethodID(this.class_ref, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((cr == null) ? IntPtr.Zero : cr.Handle);
			ptr[1] = new JValue((uri == null) ? IntPtr.Zero : uri.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_, ptr);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00036361 File Offset: 0x00034561
		private static Delegate GetUnregisterContentObserver_Landroid_database_ContentObserver_Handler()
		{
			if (ICursorInvoker.cb_unregisterContentObserver_Landroid_database_ContentObserver_ == null)
			{
				ICursorInvoker.cb_unregisterContentObserver_Landroid_database_ContentObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICursorInvoker.n_UnregisterContentObserver_Landroid_database_ContentObserver_));
			}
			return ICursorInvoker.cb_unregisterContentObserver_Landroid_database_ContentObserver_;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00036388 File Offset: 0x00034588
		private static void n_UnregisterContentObserver_Landroid_database_ContentObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ContentObserver object2 = Java.Lang.Object.GetObject<ContentObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterContentObserver(object2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000363AC File Offset: 0x000345AC
		public unsafe void UnregisterContentObserver(ContentObserver observer)
		{
			if (this.id_unregisterContentObserver_Landroid_database_ContentObserver_ == IntPtr.Zero)
			{
				this.id_unregisterContentObserver_Landroid_database_ContentObserver_ = JNIEnv.GetMethodID(this.class_ref, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((observer == null) ? IntPtr.Zero : observer.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_unregisterContentObserver_Landroid_database_ContentObserver_, ptr);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0003641F File Offset: 0x0003461F
		private static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler()
		{
			if (ICursorInvoker.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
			{
				ICursorInvoker.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICursorInvoker.n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_));
			}
			return ICursorInvoker.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00036444 File Offset: 0x00034644
		private static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSetObserver object2 = Java.Lang.Object.GetObject<DataSetObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterDataSetObserver(object2);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00036468 File Offset: 0x00034668
		public unsafe void UnregisterDataSetObserver(DataSetObserver observer)
		{
			if (this.id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
			{
				this.id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID(this.class_ref, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((observer == null) ? IntPtr.Zero : observer.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, ptr);
		}

		// Token: 0x040008EE RID: 2286
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/database/Cursor", typeof(ICursorInvoker));

		// Token: 0x040008EF RID: 2287
		private IntPtr class_ref;

		// Token: 0x040008F0 RID: 2288
		private static Delegate cb_getColumnCount;

		// Token: 0x040008F1 RID: 2289
		private IntPtr id_getColumnCount;

		// Token: 0x040008F2 RID: 2290
		private static Delegate cb_getCount;

		// Token: 0x040008F3 RID: 2291
		private IntPtr id_getCount;

		// Token: 0x040008F4 RID: 2292
		private static Delegate cb_getExtras;

		// Token: 0x040008F5 RID: 2293
		private static Delegate cb_setExtras_Landroid_os_Bundle_;

		// Token: 0x040008F6 RID: 2294
		private IntPtr id_getExtras;

		// Token: 0x040008F7 RID: 2295
		private IntPtr id_setExtras_Landroid_os_Bundle_;

		// Token: 0x040008F8 RID: 2296
		private static Delegate cb_isAfterLast;

		// Token: 0x040008F9 RID: 2297
		private IntPtr id_isAfterLast;

		// Token: 0x040008FA RID: 2298
		private static Delegate cb_isBeforeFirst;

		// Token: 0x040008FB RID: 2299
		private IntPtr id_isBeforeFirst;

		// Token: 0x040008FC RID: 2300
		private static Delegate cb_isClosed;

		// Token: 0x040008FD RID: 2301
		private IntPtr id_isClosed;

		// Token: 0x040008FE RID: 2302
		private static Delegate cb_isFirst;

		// Token: 0x040008FF RID: 2303
		private IntPtr id_isFirst;

		// Token: 0x04000900 RID: 2304
		private static Delegate cb_isLast;

		// Token: 0x04000901 RID: 2305
		private IntPtr id_isLast;

		// Token: 0x04000902 RID: 2306
		private static Delegate cb_getNotificationUri;

		// Token: 0x04000903 RID: 2307
		private IntPtr id_getNotificationUri;

		// Token: 0x04000904 RID: 2308
		private static Delegate cb_getPosition;

		// Token: 0x04000905 RID: 2309
		private IntPtr id_getPosition;

		// Token: 0x04000906 RID: 2310
		private static Delegate cb_getWantsAllOnMoveCalls;

		// Token: 0x04000907 RID: 2311
		private IntPtr id_getWantsAllOnMoveCalls;

		// Token: 0x04000908 RID: 2312
		private static Delegate cb_close;

		// Token: 0x04000909 RID: 2313
		private IntPtr id_close;

		// Token: 0x0400090A RID: 2314
		private static Delegate cb_copyStringToBuffer_ILandroid_database_CharArrayBuffer_;

		// Token: 0x0400090B RID: 2315
		private IntPtr id_copyStringToBuffer_ILandroid_database_CharArrayBuffer_;

		// Token: 0x0400090C RID: 2316
		private static Delegate cb_deactivate;

		// Token: 0x0400090D RID: 2317
		private IntPtr id_deactivate;

		// Token: 0x0400090E RID: 2318
		private static Delegate cb_getBlob_I;

		// Token: 0x0400090F RID: 2319
		private IntPtr id_getBlob_I;

		// Token: 0x04000910 RID: 2320
		private static Delegate cb_getColumnIndex_Ljava_lang_String_;

		// Token: 0x04000911 RID: 2321
		private IntPtr id_getColumnIndex_Ljava_lang_String_;

		// Token: 0x04000912 RID: 2322
		private static Delegate cb_getColumnIndexOrThrow_Ljava_lang_String_;

		// Token: 0x04000913 RID: 2323
		private IntPtr id_getColumnIndexOrThrow_Ljava_lang_String_;

		// Token: 0x04000914 RID: 2324
		private static Delegate cb_getColumnName_I;

		// Token: 0x04000915 RID: 2325
		private IntPtr id_getColumnName_I;

		// Token: 0x04000916 RID: 2326
		private static Delegate cb_getColumnNames;

		// Token: 0x04000917 RID: 2327
		private IntPtr id_getColumnNames;

		// Token: 0x04000918 RID: 2328
		private static Delegate cb_getDouble_I;

		// Token: 0x04000919 RID: 2329
		private IntPtr id_getDouble_I;

		// Token: 0x0400091A RID: 2330
		private static Delegate cb_getFloat_I;

		// Token: 0x0400091B RID: 2331
		private IntPtr id_getFloat_I;

		// Token: 0x0400091C RID: 2332
		private static Delegate cb_getInt_I;

		// Token: 0x0400091D RID: 2333
		private IntPtr id_getInt_I;

		// Token: 0x0400091E RID: 2334
		private static Delegate cb_getLong_I;

		// Token: 0x0400091F RID: 2335
		private IntPtr id_getLong_I;

		// Token: 0x04000920 RID: 2336
		private static Delegate cb_getShort_I;

		// Token: 0x04000921 RID: 2337
		private IntPtr id_getShort_I;

		// Token: 0x04000922 RID: 2338
		private static Delegate cb_getString_I;

		// Token: 0x04000923 RID: 2339
		private IntPtr id_getString_I;

		// Token: 0x04000924 RID: 2340
		private static Delegate cb_getType_I;

		// Token: 0x04000925 RID: 2341
		private IntPtr id_getType_I;

		// Token: 0x04000926 RID: 2342
		private static Delegate cb_isNull_I;

		// Token: 0x04000927 RID: 2343
		private IntPtr id_isNull_I;

		// Token: 0x04000928 RID: 2344
		private static Delegate cb_move_I;

		// Token: 0x04000929 RID: 2345
		private IntPtr id_move_I;

		// Token: 0x0400092A RID: 2346
		private static Delegate cb_moveToFirst;

		// Token: 0x0400092B RID: 2347
		private IntPtr id_moveToFirst;

		// Token: 0x0400092C RID: 2348
		private static Delegate cb_moveToLast;

		// Token: 0x0400092D RID: 2349
		private IntPtr id_moveToLast;

		// Token: 0x0400092E RID: 2350
		private static Delegate cb_moveToNext;

		// Token: 0x0400092F RID: 2351
		private IntPtr id_moveToNext;

		// Token: 0x04000930 RID: 2352
		private static Delegate cb_moveToPosition_I;

		// Token: 0x04000931 RID: 2353
		private IntPtr id_moveToPosition_I;

		// Token: 0x04000932 RID: 2354
		private static Delegate cb_moveToPrevious;

		// Token: 0x04000933 RID: 2355
		private IntPtr id_moveToPrevious;

		// Token: 0x04000934 RID: 2356
		private static Delegate cb_registerContentObserver_Landroid_database_ContentObserver_;

		// Token: 0x04000935 RID: 2357
		private IntPtr id_registerContentObserver_Landroid_database_ContentObserver_;

		// Token: 0x04000936 RID: 2358
		private static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x04000937 RID: 2359
		private IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x04000938 RID: 2360
		private static Delegate cb_requery;

		// Token: 0x04000939 RID: 2361
		private IntPtr id_requery;

		// Token: 0x0400093A RID: 2362
		private static Delegate cb_respond_Landroid_os_Bundle_;

		// Token: 0x0400093B RID: 2363
		private IntPtr id_respond_Landroid_os_Bundle_;

		// Token: 0x0400093C RID: 2364
		private static Delegate cb_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_;

		// Token: 0x0400093D RID: 2365
		private IntPtr id_setNotificationUri_Landroid_content_ContentResolver_Landroid_net_Uri_;

		// Token: 0x0400093E RID: 2366
		private static Delegate cb_unregisterContentObserver_Landroid_database_ContentObserver_;

		// Token: 0x0400093F RID: 2367
		private IntPtr id_unregisterContentObserver_Landroid_database_ContentObserver_;

		// Token: 0x04000940 RID: 2368
		private static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x04000941 RID: 2369
		private IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
	}
}
