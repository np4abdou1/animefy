using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001E7 RID: 487
	[Register("android/os/IBinder", DoNotGenerateAcw = true)]
	internal class IBinderInvoker : Java.Lang.Object, IBinder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0002ED40 File Offset: 0x0002CF40
		private static IntPtr java_class_ref
		{
			get
			{
				return IBinderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x0002ED64 File Offset: 0x0002CF64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBinderInvoker._members;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x0002ED6B File Offset: 0x0002CF6B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0002ED73 File Offset: 0x0002CF73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBinderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0002ED7F File Offset: 0x0002CF7F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBinderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.os.IBinder'.");
			}
			return handle;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0002EDAA File Offset: 0x0002CFAA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0002EDDC File Offset: 0x0002CFDC
		public IBinderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBinderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0002EE14 File Offset: 0x0002D014
		private static Delegate GetGetInterfaceDescriptorHandler()
		{
			if (IBinderInvoker.cb_getInterfaceDescriptor == null)
			{
				IBinderInvoker.cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBinderInvoker.n_GetInterfaceDescriptor));
			}
			return IBinderInvoker.cb_getInterfaceDescriptor;
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0002EE38 File Offset: 0x0002D038
		private static IntPtr n_GetInterfaceDescriptor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InterfaceDescriptor);
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0002EE4C File Offset: 0x0002D04C
		public string InterfaceDescriptor
		{
			get
			{
				if (this.id_getInterfaceDescriptor == IntPtr.Zero)
				{
					this.id_getInterfaceDescriptor = JNIEnv.GetMethodID(this.class_ref, "getInterfaceDescriptor", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0002EE9D File Offset: 0x0002D09D
		private static Delegate GetIsBinderAliveHandler()
		{
			if (IBinderInvoker.cb_isBinderAlive == null)
			{
				IBinderInvoker.cb_isBinderAlive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBinderInvoker.n_IsBinderAlive));
			}
			return IBinderInvoker.cb_isBinderAlive;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0002EEC1 File Offset: 0x0002D0C1
		private static bool n_IsBinderAlive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsBinderAlive;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0002EED0 File Offset: 0x0002D0D0
		public bool IsBinderAlive
		{
			get
			{
				if (this.id_isBinderAlive == IntPtr.Zero)
				{
					this.id_isBinderAlive = JNIEnv.GetMethodID(this.class_ref, "isBinderAlive", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isBinderAlive);
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0002EF10 File Offset: 0x0002D110
		private static Delegate GetDump_Ljava_io_FileDescriptor_arrayLjava_lang_String_Handler()
		{
			if (IBinderInvoker.cb_dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_ == null)
			{
				IBinderInvoker.cb_dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IBinderInvoker.n_Dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_));
			}
			return IBinderInvoker.cb_dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0002EF34 File Offset: 0x0002D134
		private static void n_Dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_fd, IntPtr native_args)
		{
			IBinder @object = Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_fd, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.Dump(object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_args);
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0002EF7C File Offset: 0x0002D17C
		public unsafe void Dump(FileDescriptor fd, string[] args)
		{
			if (this.id_dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_ == IntPtr.Zero)
			{
				this.id_dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(args);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fd == null) ? IntPtr.Zero : fd.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_, ptr);
			if (args != null)
			{
				JNIEnv.CopyArray(intPtr, args);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0002F019 File Offset: 0x0002D219
		private static Delegate GetDumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_Handler()
		{
			if (IBinderInvoker.cb_dumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_ == null)
			{
				IBinderInvoker.cb_dumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IBinderInvoker.n_DumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_));
			}
			return IBinderInvoker.cb_dumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0002F040 File Offset: 0x0002D240
		private static void n_DumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_fd, IntPtr native_args)
		{
			IBinder @object = Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_fd, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.DumpAsync(object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_args);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0002F088 File Offset: 0x0002D288
		public unsafe void DumpAsync(FileDescriptor fd, string[] args)
		{
			if (this.id_dumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_ == IntPtr.Zero)
			{
				this.id_dumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "dumpAsync", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(args);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fd == null) ? IntPtr.Zero : fd.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_dumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_, ptr);
			if (args != null)
			{
				JNIEnv.CopyArray(intPtr, args);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0002F125 File Offset: 0x0002D325
		private static Delegate GetLinkToDeath_Landroid_os_IBinder_DeathRecipient_IHandler()
		{
			if (IBinderInvoker.cb_linkToDeath_Landroid_os_IBinder_DeathRecipient_I == null)
			{
				IBinderInvoker.cb_linkToDeath_Landroid_os_IBinder_DeathRecipient_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(IBinderInvoker.n_LinkToDeath_Landroid_os_IBinder_DeathRecipient_I));
			}
			return IBinderInvoker.cb_linkToDeath_Landroid_os_IBinder_DeathRecipient_I;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0002F14C File Offset: 0x0002D34C
		private static void n_LinkToDeath_Landroid_os_IBinder_DeathRecipient_I(IntPtr jnienv, IntPtr native__this, IntPtr native_recipient, int flags)
		{
			IBinder @object = Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBinderDeathRecipient object2 = Java.Lang.Object.GetObject<IBinderDeathRecipient>(native_recipient, JniHandleOwnership.DoNotTransfer);
			@object.LinkToDeath(object2, flags);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0002F170 File Offset: 0x0002D370
		public unsafe void LinkToDeath(IBinderDeathRecipient recipient, int flags)
		{
			if (this.id_linkToDeath_Landroid_os_IBinder_DeathRecipient_I == IntPtr.Zero)
			{
				this.id_linkToDeath_Landroid_os_IBinder_DeathRecipient_I = JNIEnv.GetMethodID(this.class_ref, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((recipient == null) ? IntPtr.Zero : ((Java.Lang.Object)recipient).Handle);
			ptr[1] = new JValue(flags);
			JNIEnv.CallVoidMethod(base.Handle, this.id_linkToDeath_Landroid_os_IBinder_DeathRecipient_I, ptr);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0002F1FB File Offset: 0x0002D3FB
		private static Delegate GetPingBinderHandler()
		{
			if (IBinderInvoker.cb_pingBinder == null)
			{
				IBinderInvoker.cb_pingBinder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBinderInvoker.n_PingBinder));
			}
			return IBinderInvoker.cb_pingBinder;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0002F21F File Offset: 0x0002D41F
		private static bool n_PingBinder(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PingBinder();
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0002F22E File Offset: 0x0002D42E
		public bool PingBinder()
		{
			if (this.id_pingBinder == IntPtr.Zero)
			{
				this.id_pingBinder = JNIEnv.GetMethodID(this.class_ref, "pingBinder", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_pingBinder);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0002F26E File Offset: 0x0002D46E
		private static Delegate GetQueryLocalInterface_Ljava_lang_String_Handler()
		{
			if (IBinderInvoker.cb_queryLocalInterface_Ljava_lang_String_ == null)
			{
				IBinderInvoker.cb_queryLocalInterface_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IBinderInvoker.n_QueryLocalInterface_Ljava_lang_String_));
			}
			return IBinderInvoker.cb_queryLocalInterface_Ljava_lang_String_;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0002F294 File Offset: 0x0002D494
		private static IntPtr n_QueryLocalInterface_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor)
		{
			IBinder @object = Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_descriptor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.QueryLocalInterface(@string));
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0002F2BC File Offset: 0x0002D4BC
		public unsafe IInterface QueryLocalInterface(string descriptor)
		{
			if (this.id_queryLocalInterface_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_queryLocalInterface_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;");
			}
			IntPtr intPtr = JNIEnv.NewString(descriptor);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IInterface @object = Java.Lang.Object.GetObject<IInterface>(JNIEnv.CallObjectMethod(base.Handle, this.id_queryLocalInterface_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0002F333 File Offset: 0x0002D533
		private static Delegate GetTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler()
		{
			if (IBinderInvoker.cb_transact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
			{
				IBinderInvoker.cb_transact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILLI_Z(IBinderInvoker.n_Transact_ILandroid_os_Parcel_Landroid_os_Parcel_I));
			}
			return IBinderInvoker.cb_transact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0002F358 File Offset: 0x0002D558
		private static bool n_Transact_ILandroid_os_Parcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int native_flags)
		{
			IBinder @object = Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_data, JniHandleOwnership.DoNotTransfer);
			Parcel object3 = Java.Lang.Object.GetObject<Parcel>(native_reply, JniHandleOwnership.DoNotTransfer);
			return @object.Transact(code, object2, object3, (TransactionFlags)native_flags);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0002F38C File Offset: 0x0002D58C
		public unsafe bool Transact(int code, Parcel data, Parcel reply, [GeneratedEnum] TransactionFlags flags)
		{
			if (this.id_transact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
			{
				this.id_transact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID(this.class_ref, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(code);
			ptr[1] = new JValue((data == null) ? IntPtr.Zero : data.Handle);
			ptr[2] = new JValue((reply == null) ? IntPtr.Zero : reply.Handle);
			ptr[3] = new JValue((int)flags);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_transact_ILandroid_os_Parcel_Landroid_os_Parcel_I, ptr);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0002F44E File Offset: 0x0002D64E
		private static Delegate GetUnlinkToDeath_Landroid_os_IBinder_DeathRecipient_IHandler()
		{
			if (IBinderInvoker.cb_unlinkToDeath_Landroid_os_IBinder_DeathRecipient_I == null)
			{
				IBinderInvoker.cb_unlinkToDeath_Landroid_os_IBinder_DeathRecipient_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_Z(IBinderInvoker.n_UnlinkToDeath_Landroid_os_IBinder_DeathRecipient_I));
			}
			return IBinderInvoker.cb_unlinkToDeath_Landroid_os_IBinder_DeathRecipient_I;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0002F474 File Offset: 0x0002D674
		private static bool n_UnlinkToDeath_Landroid_os_IBinder_DeathRecipient_I(IntPtr jnienv, IntPtr native__this, IntPtr native_recipient, int flags)
		{
			IBinder @object = Java.Lang.Object.GetObject<IBinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBinderDeathRecipient object2 = Java.Lang.Object.GetObject<IBinderDeathRecipient>(native_recipient, JniHandleOwnership.DoNotTransfer);
			return @object.UnlinkToDeath(object2, flags);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0002F498 File Offset: 0x0002D698
		public unsafe bool UnlinkToDeath(IBinderDeathRecipient recipient, int flags)
		{
			if (this.id_unlinkToDeath_Landroid_os_IBinder_DeathRecipient_I == IntPtr.Zero)
			{
				this.id_unlinkToDeath_Landroid_os_IBinder_DeathRecipient_I = JNIEnv.GetMethodID(this.class_ref, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((recipient == null) ? IntPtr.Zero : ((Java.Lang.Object)recipient).Handle);
			ptr[1] = new JValue(flags);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_unlinkToDeath_Landroid_os_IBinder_DeathRecipient_I, ptr);
		}

		// Token: 0x040007E3 RID: 2019
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/IBinder", typeof(IBinderInvoker));

		// Token: 0x040007E4 RID: 2020
		private IntPtr class_ref;

		// Token: 0x040007E5 RID: 2021
		private static Delegate cb_getInterfaceDescriptor;

		// Token: 0x040007E6 RID: 2022
		private IntPtr id_getInterfaceDescriptor;

		// Token: 0x040007E7 RID: 2023
		private static Delegate cb_isBinderAlive;

		// Token: 0x040007E8 RID: 2024
		private IntPtr id_isBinderAlive;

		// Token: 0x040007E9 RID: 2025
		private static Delegate cb_dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_;

		// Token: 0x040007EA RID: 2026
		private IntPtr id_dump_Ljava_io_FileDescriptor_arrayLjava_lang_String_;

		// Token: 0x040007EB RID: 2027
		private static Delegate cb_dumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_;

		// Token: 0x040007EC RID: 2028
		private IntPtr id_dumpAsync_Ljava_io_FileDescriptor_arrayLjava_lang_String_;

		// Token: 0x040007ED RID: 2029
		private static Delegate cb_linkToDeath_Landroid_os_IBinder_DeathRecipient_I;

		// Token: 0x040007EE RID: 2030
		private IntPtr id_linkToDeath_Landroid_os_IBinder_DeathRecipient_I;

		// Token: 0x040007EF RID: 2031
		private static Delegate cb_pingBinder;

		// Token: 0x040007F0 RID: 2032
		private IntPtr id_pingBinder;

		// Token: 0x040007F1 RID: 2033
		private static Delegate cb_queryLocalInterface_Ljava_lang_String_;

		// Token: 0x040007F2 RID: 2034
		private IntPtr id_queryLocalInterface_Ljava_lang_String_;

		// Token: 0x040007F3 RID: 2035
		private static Delegate cb_transact_ILandroid_os_Parcel_Landroid_os_Parcel_I;

		// Token: 0x040007F4 RID: 2036
		private IntPtr id_transact_ILandroid_os_Parcel_Landroid_os_Parcel_I;

		// Token: 0x040007F5 RID: 2037
		private static Delegate cb_unlinkToDeath_Landroid_os_IBinder_DeathRecipient_I;

		// Token: 0x040007F6 RID: 2038
		private IntPtr id_unlinkToDeath_Landroid_os_IBinder_DeathRecipient_I;
	}
}
