using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio.Attributes
{
	// Token: 0x02000392 RID: 914
	[Register("java/nio/file/attribute/BasicFileAttributes", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IBasicFileAttributesInvoker : Java.Lang.Object, IBasicFileAttributes, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x00072820 File Offset: 0x00070A20
		private static IntPtr java_class_ref
		{
			get
			{
				return IBasicFileAttributesInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x00072844 File Offset: 0x00070A44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBasicFileAttributesInvoker._members;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x0007284B File Offset: 0x00070A4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x00072853 File Offset: 0x00070A53
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBasicFileAttributesInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x0007285F File Offset: 0x00070A5F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBasicFileAttributesInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.attribute.BasicFileAttributes'.");
			}
			return handle;
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x0007288A File Offset: 0x00070A8A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000728BC File Offset: 0x00070ABC
		public IBasicFileAttributesInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBasicFileAttributesInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000728F4 File Offset: 0x00070AF4
		private static Delegate GetIsDirectoryHandler()
		{
			if (IBasicFileAttributesInvoker.cb_isDirectory == null)
			{
				IBasicFileAttributesInvoker.cb_isDirectory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBasicFileAttributesInvoker.n_IsDirectory));
			}
			return IBasicFileAttributesInvoker.cb_isDirectory;
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00072918 File Offset: 0x00070B18
		private static bool n_IsDirectory(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDirectory;
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x00072927 File Offset: 0x00070B27
		public bool IsDirectory
		{
			get
			{
				if (this.id_isDirectory == IntPtr.Zero)
				{
					this.id_isDirectory = JNIEnv.GetMethodID(this.class_ref, "isDirectory", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isDirectory);
			}
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00072967 File Offset: 0x00070B67
		private static Delegate GetIsOtherHandler()
		{
			if (IBasicFileAttributesInvoker.cb_isOther == null)
			{
				IBasicFileAttributesInvoker.cb_isOther = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBasicFileAttributesInvoker.n_IsOther));
			}
			return IBasicFileAttributesInvoker.cb_isOther;
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0007298B File Offset: 0x00070B8B
		private static bool n_IsOther(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOther;
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x0007299A File Offset: 0x00070B9A
		public bool IsOther
		{
			get
			{
				if (this.id_isOther == IntPtr.Zero)
				{
					this.id_isOther = JNIEnv.GetMethodID(this.class_ref, "isOther", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOther);
			}
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000729DA File Offset: 0x00070BDA
		private static Delegate GetIsRegularFileHandler()
		{
			if (IBasicFileAttributesInvoker.cb_isRegularFile == null)
			{
				IBasicFileAttributesInvoker.cb_isRegularFile = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBasicFileAttributesInvoker.n_IsRegularFile));
			}
			return IBasicFileAttributesInvoker.cb_isRegularFile;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000729FE File Offset: 0x00070BFE
		private static bool n_IsRegularFile(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRegularFile;
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x00072A0D File Offset: 0x00070C0D
		public bool IsRegularFile
		{
			get
			{
				if (this.id_isRegularFile == IntPtr.Zero)
				{
					this.id_isRegularFile = JNIEnv.GetMethodID(this.class_ref, "isRegularFile", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isRegularFile);
			}
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00072A4D File Offset: 0x00070C4D
		private static Delegate GetIsSymbolicLinkHandler()
		{
			if (IBasicFileAttributesInvoker.cb_isSymbolicLink == null)
			{
				IBasicFileAttributesInvoker.cb_isSymbolicLink = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBasicFileAttributesInvoker.n_IsSymbolicLink));
			}
			return IBasicFileAttributesInvoker.cb_isSymbolicLink;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00072A71 File Offset: 0x00070C71
		private static bool n_IsSymbolicLink(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSymbolicLink;
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x00072A80 File Offset: 0x00070C80
		public bool IsSymbolicLink
		{
			get
			{
				if (this.id_isSymbolicLink == IntPtr.Zero)
				{
					this.id_isSymbolicLink = JNIEnv.GetMethodID(this.class_ref, "isSymbolicLink", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isSymbolicLink);
			}
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00072AC0 File Offset: 0x00070CC0
		private static Delegate GetCreationTimeHandler()
		{
			if (IBasicFileAttributesInvoker.cb_creationTime == null)
			{
				IBasicFileAttributesInvoker.cb_creationTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBasicFileAttributesInvoker.n_CreationTime));
			}
			return IBasicFileAttributesInvoker.cb_creationTime;
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00072AE4 File Offset: 0x00070CE4
		private static IntPtr n_CreationTime(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreationTime());
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x00072AF8 File Offset: 0x00070CF8
		public FileTime CreationTime()
		{
			if (this.id_creationTime == IntPtr.Zero)
			{
				this.id_creationTime = JNIEnv.GetMethodID(this.class_ref, "creationTime", "()Ljava/nio/file/attribute/FileTime;");
			}
			return Java.Lang.Object.GetObject<FileTime>(JNIEnv.CallObjectMethod(base.Handle, this.id_creationTime), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00072B49 File Offset: 0x00070D49
		private static Delegate GetFileKeyHandler()
		{
			if (IBasicFileAttributesInvoker.cb_fileKey == null)
			{
				IBasicFileAttributesInvoker.cb_fileKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBasicFileAttributesInvoker.n_FileKey));
			}
			return IBasicFileAttributesInvoker.cb_fileKey;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00072B6D File Offset: 0x00070D6D
		private static IntPtr n_FileKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FileKey());
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00072B84 File Offset: 0x00070D84
		public Java.Lang.Object FileKey()
		{
			if (this.id_fileKey == IntPtr.Zero)
			{
				this.id_fileKey = JNIEnv.GetMethodID(this.class_ref, "fileKey", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_fileKey), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00072BD5 File Offset: 0x00070DD5
		private static Delegate GetLastAccessTimeHandler()
		{
			if (IBasicFileAttributesInvoker.cb_lastAccessTime == null)
			{
				IBasicFileAttributesInvoker.cb_lastAccessTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBasicFileAttributesInvoker.n_LastAccessTime));
			}
			return IBasicFileAttributesInvoker.cb_lastAccessTime;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00072BF9 File Offset: 0x00070DF9
		private static IntPtr n_LastAccessTime(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LastAccessTime());
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x00072C10 File Offset: 0x00070E10
		public FileTime LastAccessTime()
		{
			if (this.id_lastAccessTime == IntPtr.Zero)
			{
				this.id_lastAccessTime = JNIEnv.GetMethodID(this.class_ref, "lastAccessTime", "()Ljava/nio/file/attribute/FileTime;");
			}
			return Java.Lang.Object.GetObject<FileTime>(JNIEnv.CallObjectMethod(base.Handle, this.id_lastAccessTime), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x00072C61 File Offset: 0x00070E61
		private static Delegate GetLastModifiedTimeHandler()
		{
			if (IBasicFileAttributesInvoker.cb_lastModifiedTime == null)
			{
				IBasicFileAttributesInvoker.cb_lastModifiedTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBasicFileAttributesInvoker.n_LastModifiedTime));
			}
			return IBasicFileAttributesInvoker.cb_lastModifiedTime;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00072C85 File Offset: 0x00070E85
		private static IntPtr n_LastModifiedTime(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LastModifiedTime());
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00072C9C File Offset: 0x00070E9C
		public FileTime LastModifiedTime()
		{
			if (this.id_lastModifiedTime == IntPtr.Zero)
			{
				this.id_lastModifiedTime = JNIEnv.GetMethodID(this.class_ref, "lastModifiedTime", "()Ljava/nio/file/attribute/FileTime;");
			}
			return Java.Lang.Object.GetObject<FileTime>(JNIEnv.CallObjectMethod(base.Handle, this.id_lastModifiedTime), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00072CED File Offset: 0x00070EED
		private static Delegate GetSizeHandler()
		{
			if (IBasicFileAttributesInvoker.cb_size == null)
			{
				IBasicFileAttributesInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IBasicFileAttributesInvoker.n_Size));
			}
			return IBasicFileAttributesInvoker.cb_size;
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x00072D11 File Offset: 0x00070F11
		private static long n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBasicFileAttributes>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00072D20 File Offset: 0x00070F20
		public long Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_size);
		}

		// Token: 0x04001099 RID: 4249
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/attribute/BasicFileAttributes", typeof(IBasicFileAttributesInvoker));

		// Token: 0x0400109A RID: 4250
		private IntPtr class_ref;

		// Token: 0x0400109B RID: 4251
		private static Delegate cb_isDirectory;

		// Token: 0x0400109C RID: 4252
		private IntPtr id_isDirectory;

		// Token: 0x0400109D RID: 4253
		private static Delegate cb_isOther;

		// Token: 0x0400109E RID: 4254
		private IntPtr id_isOther;

		// Token: 0x0400109F RID: 4255
		private static Delegate cb_isRegularFile;

		// Token: 0x040010A0 RID: 4256
		private IntPtr id_isRegularFile;

		// Token: 0x040010A1 RID: 4257
		private static Delegate cb_isSymbolicLink;

		// Token: 0x040010A2 RID: 4258
		private IntPtr id_isSymbolicLink;

		// Token: 0x040010A3 RID: 4259
		private static Delegate cb_creationTime;

		// Token: 0x040010A4 RID: 4260
		private IntPtr id_creationTime;

		// Token: 0x040010A5 RID: 4261
		private static Delegate cb_fileKey;

		// Token: 0x040010A6 RID: 4262
		private IntPtr id_fileKey;

		// Token: 0x040010A7 RID: 4263
		private static Delegate cb_lastAccessTime;

		// Token: 0x040010A8 RID: 4264
		private IntPtr id_lastAccessTime;

		// Token: 0x040010A9 RID: 4265
		private static Delegate cb_lastModifiedTime;

		// Token: 0x040010AA RID: 4266
		private IntPtr id_lastModifiedTime;

		// Token: 0x040010AB RID: 4267
		private static Delegate cb_size;

		// Token: 0x040010AC RID: 4268
		private IntPtr id_size;
	}
}
