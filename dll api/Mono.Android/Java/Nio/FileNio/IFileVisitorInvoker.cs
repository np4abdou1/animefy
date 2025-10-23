using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Nio.FileNio.Attributes;

namespace Java.Nio.FileNio
{
	// Token: 0x0200037E RID: 894
	[Register("java/nio/file/FileVisitor", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IFileVisitorInvoker : Java.Lang.Object, IFileVisitor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x0006FBDC File Offset: 0x0006DDDC
		private static IntPtr java_class_ref
		{
			get
			{
				return IFileVisitorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x0006FC00 File Offset: 0x0006DE00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFileVisitorInvoker._members;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x0006FC07 File Offset: 0x0006DE07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x0006FC0F File Offset: 0x0006DE0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFileVisitorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0006FC1B File Offset: 0x0006DE1B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFileVisitorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.FileVisitor'.");
			}
			return handle;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x0006FC46 File Offset: 0x0006DE46
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x0006FC78 File Offset: 0x0006DE78
		public IFileVisitorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFileVisitorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0006FCB0 File Offset: 0x0006DEB0
		private static Delegate GetPostVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_Handler()
		{
			if (IFileVisitorInvoker.cb_postVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_ == null)
			{
				IFileVisitorInvoker.cb_postVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IFileVisitorInvoker.n_PostVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_));
			}
			return IFileVisitorInvoker.cb_postVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_;
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0006FCD4 File Offset: 0x0006DED4
		private static IntPtr n_PostVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_(IntPtr jnienv, IntPtr native__this, IntPtr native_dir, IntPtr native_exc)
		{
			IFileVisitor @object = Java.Lang.Object.GetObject<IFileVisitor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_dir, JniHandleOwnership.DoNotTransfer);
			IOException object3 = Java.Lang.Object.GetObject<IOException>(native_exc, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PostVisitDirectory(object2, object3));
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0006FD08 File Offset: 0x0006DF08
		public unsafe FileVisitResult PostVisitDirectory(Java.Lang.Object dir, IOException exc)
		{
			if (this.id_postVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_ == IntPtr.Zero)
			{
				this.id_postVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_ = JNIEnv.GetMethodID(this.class_ref, "postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(dir);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((exc == null) ? IntPtr.Zero : exc.Handle);
			FileVisitResult @object = Java.Lang.Object.GetObject<FileVisitResult>(JNIEnv.CallObjectMethod(base.Handle, this.id_postVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x0006FDA1 File Offset: 0x0006DFA1
		private static Delegate GetPreVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_Handler()
		{
			if (IFileVisitorInvoker.cb_preVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_ == null)
			{
				IFileVisitorInvoker.cb_preVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IFileVisitorInvoker.n_PreVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_));
			}
			return IFileVisitorInvoker.cb_preVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_;
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0006FDC8 File Offset: 0x0006DFC8
		private static IntPtr n_PreVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_(IntPtr jnienv, IntPtr native__this, IntPtr native_dir, IntPtr native_attrs)
		{
			IFileVisitor @object = Java.Lang.Object.GetObject<IFileVisitor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_dir, JniHandleOwnership.DoNotTransfer);
			IBasicFileAttributes object3 = Java.Lang.Object.GetObject<IBasicFileAttributes>(native_attrs, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PreVisitDirectory(object2, object3));
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0006FDFC File Offset: 0x0006DFFC
		public unsafe FileVisitResult PreVisitDirectory(Java.Lang.Object dir, IBasicFileAttributes attrs)
		{
			if (this.id_preVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_ == IntPtr.Zero)
			{
				this.id_preVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_ = JNIEnv.GetMethodID(this.class_ref, "preVisitDirectory", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(dir);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
			FileVisitResult @object = Java.Lang.Object.GetObject<FileVisitResult>(JNIEnv.CallObjectMethod(base.Handle, this.id_preVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0006FE9A File Offset: 0x0006E09A
		private static Delegate GetVisitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_Handler()
		{
			if (IFileVisitorInvoker.cb_visitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_ == null)
			{
				IFileVisitorInvoker.cb_visitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IFileVisitorInvoker.n_VisitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_));
			}
			return IFileVisitorInvoker.cb_visitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_;
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x0006FEC0 File Offset: 0x0006E0C0
		private static IntPtr n_VisitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_(IntPtr jnienv, IntPtr native__this, IntPtr native_file, IntPtr native_attrs)
		{
			IFileVisitor @object = Java.Lang.Object.GetObject<IFileVisitor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_file, JniHandleOwnership.DoNotTransfer);
			IBasicFileAttributes object3 = Java.Lang.Object.GetObject<IBasicFileAttributes>(native_attrs, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.VisitFile(object2, object3));
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x0006FEF4 File Offset: 0x0006E0F4
		public unsafe FileVisitResult VisitFile(Java.Lang.Object file, IBasicFileAttributes attrs)
		{
			if (this.id_visitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_ == IntPtr.Zero)
			{
				this.id_visitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_ = JNIEnv.GetMethodID(this.class_ref, "visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(file);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
			FileVisitResult @object = Java.Lang.Object.GetObject<FileVisitResult>(JNIEnv.CallObjectMethod(base.Handle, this.id_visitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x0006FF92 File Offset: 0x0006E192
		private static Delegate GetVisitFileFailed_Ljava_lang_Object_Ljava_io_IOException_Handler()
		{
			if (IFileVisitorInvoker.cb_visitFileFailed_Ljava_lang_Object_Ljava_io_IOException_ == null)
			{
				IFileVisitorInvoker.cb_visitFileFailed_Ljava_lang_Object_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IFileVisitorInvoker.n_VisitFileFailed_Ljava_lang_Object_Ljava_io_IOException_));
			}
			return IFileVisitorInvoker.cb_visitFileFailed_Ljava_lang_Object_Ljava_io_IOException_;
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x0006FFB8 File Offset: 0x0006E1B8
		private static IntPtr n_VisitFileFailed_Ljava_lang_Object_Ljava_io_IOException_(IntPtr jnienv, IntPtr native__this, IntPtr native_file, IntPtr native_exc)
		{
			IFileVisitor @object = Java.Lang.Object.GetObject<IFileVisitor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_file, JniHandleOwnership.DoNotTransfer);
			IOException object3 = Java.Lang.Object.GetObject<IOException>(native_exc, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.VisitFileFailed(object2, object3));
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x0006FFEC File Offset: 0x0006E1EC
		public unsafe FileVisitResult VisitFileFailed(Java.Lang.Object file, IOException exc)
		{
			if (this.id_visitFileFailed_Ljava_lang_Object_Ljava_io_IOException_ == IntPtr.Zero)
			{
				this.id_visitFileFailed_Ljava_lang_Object_Ljava_io_IOException_ = JNIEnv.GetMethodID(this.class_ref, "visitFileFailed", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(file);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((exc == null) ? IntPtr.Zero : exc.Handle);
			FileVisitResult @object = Java.Lang.Object.GetObject<FileVisitResult>(JNIEnv.CallObjectMethod(base.Handle, this.id_visitFileFailed_Ljava_lang_Object_Ljava_io_IOException_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04001020 RID: 4128
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/FileVisitor", typeof(IFileVisitorInvoker));

		// Token: 0x04001021 RID: 4129
		private IntPtr class_ref;

		// Token: 0x04001022 RID: 4130
		private static Delegate cb_postVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_;

		// Token: 0x04001023 RID: 4131
		private IntPtr id_postVisitDirectory_Ljava_lang_Object_Ljava_io_IOException_;

		// Token: 0x04001024 RID: 4132
		private static Delegate cb_preVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_;

		// Token: 0x04001025 RID: 4133
		private IntPtr id_preVisitDirectory_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_;

		// Token: 0x04001026 RID: 4134
		private static Delegate cb_visitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_;

		// Token: 0x04001027 RID: 4135
		private IntPtr id_visitFile_Ljava_lang_Object_Ljava_nio_file_attribute_BasicFileAttributes_;

		// Token: 0x04001028 RID: 4136
		private static Delegate cb_visitFileFailed_Ljava_lang_Object_Ljava_io_IOException_;

		// Token: 0x04001029 RID: 4137
		private IntPtr id_visitFileFailed_Ljava_lang_Object_Ljava_io_IOException_;
	}
}
