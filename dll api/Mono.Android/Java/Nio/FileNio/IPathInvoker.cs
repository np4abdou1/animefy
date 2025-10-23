using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Net;
using Java.Util;

namespace Java.Nio.FileNio
{
	// Token: 0x02000382 RID: 898
	[Register("java/nio/file/Path", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IPathInvoker : Java.Lang.Object, IPath, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable, IIterable, IWatchable
	{
		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x00070190 File Offset: 0x0006E390
		private static IntPtr java_class_ref
		{
			get
			{
				return IPathInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x000701B4 File Offset: 0x0006E3B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPathInvoker._members;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x000701BB File Offset: 0x0006E3BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000701C3 File Offset: 0x0006E3C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPathInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000701CF File Offset: 0x0006E3CF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPathInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.Path'.");
			}
			return handle;
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000701FA File Offset: 0x0006E3FA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0007022C File Offset: 0x0006E42C
		public IPathInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPathInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00070264 File Offset: 0x0006E464
		private static Delegate GetGetFileNameHandler()
		{
			if (IPathInvoker.cb_getFileName == null)
			{
				IPathInvoker.cb_getFileName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_GetFileName));
			}
			return IPathInvoker.cb_getFileName;
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00070288 File Offset: 0x0006E488
		private static IntPtr n_GetFileName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FileName);
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x0007029C File Offset: 0x0006E49C
		public IPath FileName
		{
			get
			{
				if (this.id_getFileName == IntPtr.Zero)
				{
					this.id_getFileName = JNIEnv.GetMethodID(this.class_ref, "getFileName", "()Ljava/nio/file/Path;");
				}
				return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_getFileName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000702ED File Offset: 0x0006E4ED
		private static Delegate GetGetFileSystemHandler()
		{
			if (IPathInvoker.cb_getFileSystem == null)
			{
				IPathInvoker.cb_getFileSystem = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_GetFileSystem));
			}
			return IPathInvoker.cb_getFileSystem;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00070311 File Offset: 0x0006E511
		private static IntPtr n_GetFileSystem(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FileSystem);
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x00070328 File Offset: 0x0006E528
		public FileSystem FileSystem
		{
			get
			{
				if (this.id_getFileSystem == IntPtr.Zero)
				{
					this.id_getFileSystem = JNIEnv.GetMethodID(this.class_ref, "getFileSystem", "()Ljava/nio/file/FileSystem;");
				}
				return Java.Lang.Object.GetObject<FileSystem>(JNIEnv.CallObjectMethod(base.Handle, this.id_getFileSystem), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00070379 File Offset: 0x0006E579
		private static Delegate GetIsAbsoluteHandler()
		{
			if (IPathInvoker.cb_isAbsolute == null)
			{
				IPathInvoker.cb_isAbsolute = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IPathInvoker.n_IsAbsolute));
			}
			return IPathInvoker.cb_isAbsolute;
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x0007039D File Offset: 0x0006E59D
		private static bool n_IsAbsolute(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbsolute;
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000703AC File Offset: 0x0006E5AC
		public bool IsAbsolute
		{
			get
			{
				if (this.id_isAbsolute == IntPtr.Zero)
				{
					this.id_isAbsolute = JNIEnv.GetMethodID(this.class_ref, "isAbsolute", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isAbsolute);
			}
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000703EC File Offset: 0x0006E5EC
		private static Delegate GetGetNameCountHandler()
		{
			if (IPathInvoker.cb_getNameCount == null)
			{
				IPathInvoker.cb_getNameCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IPathInvoker.n_GetNameCount));
			}
			return IPathInvoker.cb_getNameCount;
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00070410 File Offset: 0x0006E610
		private static int n_GetNameCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NameCount;
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x0007041F File Offset: 0x0006E61F
		public int NameCount
		{
			get
			{
				if (this.id_getNameCount == IntPtr.Zero)
				{
					this.id_getNameCount = JNIEnv.GetMethodID(this.class_ref, "getNameCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getNameCount);
			}
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x0007045F File Offset: 0x0006E65F
		private static Delegate GetGetParentHandler()
		{
			if (IPathInvoker.cb_getParent == null)
			{
				IPathInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_GetParent));
			}
			return IPathInvoker.cb_getParent;
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00070483 File Offset: 0x0006E683
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x00070498 File Offset: 0x0006E698
		public IPath Parent
		{
			get
			{
				if (this.id_getParent == IntPtr.Zero)
				{
					this.id_getParent = JNIEnv.GetMethodID(this.class_ref, "getParent", "()Ljava/nio/file/Path;");
				}
				return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_getParent), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x000704E9 File Offset: 0x0006E6E9
		private static Delegate GetGetRootHandler()
		{
			if (IPathInvoker.cb_getRoot == null)
			{
				IPathInvoker.cb_getRoot = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_GetRoot));
			}
			return IPathInvoker.cb_getRoot;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x0007050D File Offset: 0x0006E70D
		private static IntPtr n_GetRoot(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Root);
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x00070524 File Offset: 0x0006E724
		public IPath Root
		{
			get
			{
				if (this.id_getRoot == IntPtr.Zero)
				{
					this.id_getRoot = JNIEnv.GetMethodID(this.class_ref, "getRoot", "()Ljava/nio/file/Path;");
				}
				return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_getRoot), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00070575 File Offset: 0x0006E775
		private static Delegate GetCompareTo_Ljava_nio_file_Path_Handler()
		{
			if (IPathInvoker.cb_compareTo_Ljava_nio_file_Path_ == null)
			{
				IPathInvoker.cb_compareTo_Ljava_nio_file_Path_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IPathInvoker.n_CompareTo_Ljava_nio_file_Path_));
			}
			return IPathInvoker.cb_compareTo_Ljava_nio_file_Path_;
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x0007059C File Offset: 0x0006E79C
		private static int n_CompareTo_Ljava_nio_file_Path_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPath object2 = Java.Lang.Object.GetObject<IPath>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000705C0 File Offset: 0x0006E7C0
		public unsafe int CompareTo(IPath other)
		{
			if (this.id_compareTo_Ljava_nio_file_Path_ == IntPtr.Zero)
			{
				this.id_compareTo_Ljava_nio_file_Path_ = JNIEnv.GetMethodID(this.class_ref, "compareTo", "(Ljava/nio/file/Path;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_compareTo_Ljava_nio_file_Path_, ptr);
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00070638 File Offset: 0x0006E838
		private static Delegate GetEndsWith_Ljava_lang_String_Handler()
		{
			if (IPathInvoker.cb_endsWith_Ljava_lang_String_ == null)
			{
				IPathInvoker.cb_endsWith_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPathInvoker.n_EndsWith_Ljava_lang_String_));
			}
			return IPathInvoker.cb_endsWith_Ljava_lang_String_;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x0007065C File Offset: 0x0006E85C
		private static bool n_EndsWith_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.EndsWith(@string);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00070680 File Offset: 0x0006E880
		public unsafe bool EndsWith(string other)
		{
			if (this.id_endsWith_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_endsWith_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "endsWith", "(Ljava/lang/String;)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(other);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_endsWith_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000706F1 File Offset: 0x0006E8F1
		private static Delegate GetEndsWith_Ljava_nio_file_Path_Handler()
		{
			if (IPathInvoker.cb_endsWith_Ljava_nio_file_Path_ == null)
			{
				IPathInvoker.cb_endsWith_Ljava_nio_file_Path_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPathInvoker.n_EndsWith_Ljava_nio_file_Path_));
			}
			return IPathInvoker.cb_endsWith_Ljava_nio_file_Path_;
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00070718 File Offset: 0x0006E918
		private static bool n_EndsWith_Ljava_nio_file_Path_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPath object2 = Java.Lang.Object.GetObject<IPath>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.EndsWith(object2);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0007073C File Offset: 0x0006E93C
		public unsafe bool EndsWith(IPath other)
		{
			if (this.id_endsWith_Ljava_nio_file_Path_ == IntPtr.Zero)
			{
				this.id_endsWith_Ljava_nio_file_Path_ = JNIEnv.GetMethodID(this.class_ref, "endsWith", "(Ljava/nio/file/Path;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_endsWith_Ljava_nio_file_Path_, ptr);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000707B4 File Offset: 0x0006E9B4
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IPathInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IPathInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPathInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IPathInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000707D8 File Offset: 0x0006E9D8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000707FC File Offset: 0x0006E9FC
		public new unsafe bool Equals(Java.Lang.Object other)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : other.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x0007086F File Offset: 0x0006EA6F
		private static Delegate GetGetName_IHandler()
		{
			if (IPathInvoker.cb_getName_I == null)
			{
				IPathInvoker.cb_getName_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IPathInvoker.n_GetName_I));
			}
			return IPathInvoker.cb_getName_I;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00070893 File Offset: 0x0006EA93
		private static IntPtr n_GetName_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetName(index));
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000708A8 File Offset: 0x0006EAA8
		public unsafe IPath GetName(int index)
		{
			if (this.id_getName_I == IntPtr.Zero)
			{
				this.id_getName_I = JNIEnv.GetMethodID(this.class_ref, "getName", "(I)Ljava/nio/file/Path;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_getName_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00070912 File Offset: 0x0006EB12
		private static Delegate GetGetHashCodeHandler()
		{
			if (IPathInvoker.cb_hashCode == null)
			{
				IPathInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IPathInvoker.n_GetHashCode));
			}
			return IPathInvoker.cb_hashCode;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00070936 File Offset: 0x0006EB36
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00070945 File Offset: 0x0006EB45
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00070985 File Offset: 0x0006EB85
		private static Delegate GetIteratorHandler()
		{
			if (IPathInvoker.cb_iterator == null)
			{
				IPathInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_Iterator));
			}
			return IPathInvoker.cb_iterator;
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000709A9 File Offset: 0x0006EBA9
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000709C0 File Offset: 0x0006EBC0
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00070A11 File Offset: 0x0006EC11
		private static Delegate GetNormalizeHandler()
		{
			if (IPathInvoker.cb_normalize == null)
			{
				IPathInvoker.cb_normalize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_Normalize));
			}
			return IPathInvoker.cb_normalize;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x00070A35 File Offset: 0x0006EC35
		private static IntPtr n_Normalize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Normalize());
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00070A4C File Offset: 0x0006EC4C
		public IPath Normalize()
		{
			if (this.id_normalize == IntPtr.Zero)
			{
				this.id_normalize = JNIEnv.GetMethodID(this.class_ref, "normalize", "()Ljava/nio/file/Path;");
			}
			return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_normalize), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00070A9D File Offset: 0x0006EC9D
		private static Delegate GetRegister_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_Handler()
		{
			if (IPathInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_ == null)
			{
				IPathInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IPathInvoker.n_Register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_));
			}
			return IPathInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00070AC4 File Offset: 0x0006ECC4
		private static IntPtr n_Register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_(IntPtr jnienv, IntPtr native__this, IntPtr native_watcher, IntPtr native_events)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWatchService object2 = Java.Lang.Object.GetObject<IWatchService>(native_watcher, JniHandleOwnership.DoNotTransfer);
			IWatchEventKind[] array = (IWatchEventKind[])JNIEnv.GetArray(native_events, JniHandleOwnership.DoNotTransfer, typeof(IWatchEventKind));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Register(object2, array));
			if (array != null)
			{
				JNIEnv.CopyArray<IWatchEventKind>(array, native_events);
			}
			return result;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00070B10 File Offset: 0x0006ED10
		public unsafe IWatchKey Register(IWatchService watcher, params IWatchEventKind[] events)
		{
			if (this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_ == IntPtr.Zero)
			{
				this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_ = JNIEnv.GetMethodID(this.class_ref, "register", "(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent$Kind;)Ljava/nio/file/WatchKey;");
			}
			IntPtr intPtr = JNIEnv.NewArray<IWatchEventKind>(events);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((watcher == null) ? IntPtr.Zero : ((Java.Lang.Object)watcher).Handle);
			ptr[1] = new JValue(intPtr);
			IWatchKey @object = Java.Lang.Object.GetObject<IWatchKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_, ptr), JniHandleOwnership.TransferLocalRef);
			if (events != null)
			{
				JNIEnv.CopyArray<IWatchEventKind>(intPtr, events);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00070BB8 File Offset: 0x0006EDB8
		private static Delegate GetRegister_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_Handler()
		{
			if (IPathInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_ == null)
			{
				IPathInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IPathInvoker.n_Register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_));
			}
			return IPathInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00070BDC File Offset: 0x0006EDDC
		private static IntPtr n_Register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_(IntPtr jnienv, IntPtr native__this, IntPtr native_watcher, IntPtr native_events, IntPtr native_modifiers)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWatchService object2 = Java.Lang.Object.GetObject<IWatchService>(native_watcher, JniHandleOwnership.DoNotTransfer);
			IWatchEventKind[] array = (IWatchEventKind[])JNIEnv.GetArray(native_events, JniHandleOwnership.DoNotTransfer, typeof(IWatchEventKind));
			IWatchEventModifier[] array2 = (IWatchEventModifier[])JNIEnv.GetArray(native_modifiers, JniHandleOwnership.DoNotTransfer, typeof(IWatchEventModifier));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Register(object2, array, array2));
			if (array != null)
			{
				JNIEnv.CopyArray<IWatchEventKind>(array, native_events);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray<IWatchEventModifier>(array2, native_modifiers);
			}
			return result;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00070C4C File Offset: 0x0006EE4C
		public unsafe IWatchKey Register(IWatchService watcher, IWatchEventKind[] events, params IWatchEventModifier[] modifiers)
		{
			if (this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_ == IntPtr.Zero)
			{
				this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_ = JNIEnv.GetMethodID(this.class_ref, "register", "(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent$Kind;[Ljava/nio/file/WatchEvent$Modifier;)Ljava/nio/file/WatchKey;");
			}
			IntPtr intPtr = JNIEnv.NewArray<IWatchEventKind>(events);
			IntPtr intPtr2 = JNIEnv.NewArray<IWatchEventModifier>(modifiers);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((watcher == null) ? IntPtr.Zero : ((Java.Lang.Object)watcher).Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(intPtr2);
			IWatchKey @object = Java.Lang.Object.GetObject<IWatchKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_, ptr), JniHandleOwnership.TransferLocalRef);
			if (events != null)
			{
				JNIEnv.CopyArray<IWatchEventKind>(intPtr, events);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			if (modifiers != null)
			{
				JNIEnv.CopyArray<IWatchEventModifier>(intPtr2, modifiers);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00070D21 File Offset: 0x0006EF21
		private static Delegate GetRelativize_Ljava_nio_file_Path_Handler()
		{
			if (IPathInvoker.cb_relativize_Ljava_nio_file_Path_ == null)
			{
				IPathInvoker.cb_relativize_Ljava_nio_file_Path_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IPathInvoker.n_Relativize_Ljava_nio_file_Path_));
			}
			return IPathInvoker.cb_relativize_Ljava_nio_file_Path_;
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00070D48 File Offset: 0x0006EF48
		private static IntPtr n_Relativize_Ljava_nio_file_Path_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPath object2 = Java.Lang.Object.GetObject<IPath>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Relativize(object2));
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00070D70 File Offset: 0x0006EF70
		public unsafe IPath Relativize(IPath other)
		{
			if (this.id_relativize_Ljava_nio_file_Path_ == IntPtr.Zero)
			{
				this.id_relativize_Ljava_nio_file_Path_ = JNIEnv.GetMethodID(this.class_ref, "relativize", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_relativize_Ljava_nio_file_Path_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00070DEE File Offset: 0x0006EFEE
		private static Delegate GetResolve_Ljava_lang_String_Handler()
		{
			if (IPathInvoker.cb_resolve_Ljava_lang_String_ == null)
			{
				IPathInvoker.cb_resolve_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IPathInvoker.n_Resolve_Ljava_lang_String_));
			}
			return IPathInvoker.cb_resolve_Ljava_lang_String_;
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00070E14 File Offset: 0x0006F014
		private static IntPtr n_Resolve_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Resolve(@string));
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00070E3C File Offset: 0x0006F03C
		public unsafe IPath Resolve(string other)
		{
			if (this.id_resolve_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_resolve_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "resolve", "(Ljava/lang/String;)Ljava/nio/file/Path;");
			}
			IntPtr intPtr = JNIEnv.NewString(other);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IPath @object = Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_resolve_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00070EB3 File Offset: 0x0006F0B3
		private static Delegate GetResolve_Ljava_nio_file_Path_Handler()
		{
			if (IPathInvoker.cb_resolve_Ljava_nio_file_Path_ == null)
			{
				IPathInvoker.cb_resolve_Ljava_nio_file_Path_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IPathInvoker.n_Resolve_Ljava_nio_file_Path_));
			}
			return IPathInvoker.cb_resolve_Ljava_nio_file_Path_;
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x00070ED8 File Offset: 0x0006F0D8
		private static IntPtr n_Resolve_Ljava_nio_file_Path_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPath object2 = Java.Lang.Object.GetObject<IPath>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Resolve(object2));
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00070F00 File Offset: 0x0006F100
		public unsafe IPath Resolve(IPath other)
		{
			if (this.id_resolve_Ljava_nio_file_Path_ == IntPtr.Zero)
			{
				this.id_resolve_Ljava_nio_file_Path_ = JNIEnv.GetMethodID(this.class_ref, "resolve", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_resolve_Ljava_nio_file_Path_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00070F7E File Offset: 0x0006F17E
		private static Delegate GetResolveSibling_Ljava_lang_String_Handler()
		{
			if (IPathInvoker.cb_resolveSibling_Ljava_lang_String_ == null)
			{
				IPathInvoker.cb_resolveSibling_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IPathInvoker.n_ResolveSibling_Ljava_lang_String_));
			}
			return IPathInvoker.cb_resolveSibling_Ljava_lang_String_;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x00070FA4 File Offset: 0x0006F1A4
		private static IntPtr n_ResolveSibling_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ResolveSibling(@string));
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00070FCC File Offset: 0x0006F1CC
		public unsafe IPath ResolveSibling(string other)
		{
			if (this.id_resolveSibling_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_resolveSibling_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "resolveSibling", "(Ljava/lang/String;)Ljava/nio/file/Path;");
			}
			IntPtr intPtr = JNIEnv.NewString(other);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IPath @object = Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_resolveSibling_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00071043 File Offset: 0x0006F243
		private static Delegate GetResolveSibling_Ljava_nio_file_Path_Handler()
		{
			if (IPathInvoker.cb_resolveSibling_Ljava_nio_file_Path_ == null)
			{
				IPathInvoker.cb_resolveSibling_Ljava_nio_file_Path_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IPathInvoker.n_ResolveSibling_Ljava_nio_file_Path_));
			}
			return IPathInvoker.cb_resolveSibling_Ljava_nio_file_Path_;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00071068 File Offset: 0x0006F268
		private static IntPtr n_ResolveSibling_Ljava_nio_file_Path_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPath object2 = Java.Lang.Object.GetObject<IPath>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ResolveSibling(object2));
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00071090 File Offset: 0x0006F290
		public unsafe IPath ResolveSibling(IPath other)
		{
			if (this.id_resolveSibling_Ljava_nio_file_Path_ == IntPtr.Zero)
			{
				this.id_resolveSibling_Ljava_nio_file_Path_ = JNIEnv.GetMethodID(this.class_ref, "resolveSibling", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_resolveSibling_Ljava_nio_file_Path_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0007110E File Offset: 0x0006F30E
		private static Delegate GetStartsWith_Ljava_lang_String_Handler()
		{
			if (IPathInvoker.cb_startsWith_Ljava_lang_String_ == null)
			{
				IPathInvoker.cb_startsWith_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPathInvoker.n_StartsWith_Ljava_lang_String_));
			}
			return IPathInvoker.cb_startsWith_Ljava_lang_String_;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00071134 File Offset: 0x0006F334
		private static bool n_StartsWith_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.StartsWith(@string);
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00071158 File Offset: 0x0006F358
		public unsafe bool StartsWith(string other)
		{
			if (this.id_startsWith_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_startsWith_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "startsWith", "(Ljava/lang/String;)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(other);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_startsWith_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000711C9 File Offset: 0x0006F3C9
		private static Delegate GetStartsWith_Ljava_nio_file_Path_Handler()
		{
			if (IPathInvoker.cb_startsWith_Ljava_nio_file_Path_ == null)
			{
				IPathInvoker.cb_startsWith_Ljava_nio_file_Path_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPathInvoker.n_StartsWith_Ljava_nio_file_Path_));
			}
			return IPathInvoker.cb_startsWith_Ljava_nio_file_Path_;
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000711F0 File Offset: 0x0006F3F0
		private static bool n_StartsWith_Ljava_nio_file_Path_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPath object2 = Java.Lang.Object.GetObject<IPath>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.StartsWith(object2);
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00071214 File Offset: 0x0006F414
		public unsafe bool StartsWith(IPath other)
		{
			if (this.id_startsWith_Ljava_nio_file_Path_ == IntPtr.Zero)
			{
				this.id_startsWith_Ljava_nio_file_Path_ = JNIEnv.GetMethodID(this.class_ref, "startsWith", "(Ljava/nio/file/Path;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_startsWith_Ljava_nio_file_Path_, ptr);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0007128C File Offset: 0x0006F48C
		private static Delegate GetSubpath_IIHandler()
		{
			if (IPathInvoker.cb_subpath_II == null)
			{
				IPathInvoker.cb_subpath_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(IPathInvoker.n_Subpath_II));
			}
			return IPathInvoker.cb_subpath_II;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000712B0 File Offset: 0x0006F4B0
		private static IntPtr n_Subpath_II(IntPtr jnienv, IntPtr native__this, int beginIndex, int endIndex)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Subpath(beginIndex, endIndex));
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000712C8 File Offset: 0x0006F4C8
		public unsafe IPath Subpath(int beginIndex, int endIndex)
		{
			if (this.id_subpath_II == IntPtr.Zero)
			{
				this.id_subpath_II = JNIEnv.GetMethodID(this.class_ref, "subpath", "(II)Ljava/nio/file/Path;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(beginIndex);
			ptr[1] = new JValue(endIndex);
			return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_subpath_II, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x00071345 File Offset: 0x0006F545
		private static Delegate GetToAbsolutePathHandler()
		{
			if (IPathInvoker.cb_toAbsolutePath == null)
			{
				IPathInvoker.cb_toAbsolutePath = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_ToAbsolutePath));
			}
			return IPathInvoker.cb_toAbsolutePath;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x00071369 File Offset: 0x0006F569
		private static IntPtr n_ToAbsolutePath(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToAbsolutePath());
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00071380 File Offset: 0x0006F580
		public IPath ToAbsolutePath()
		{
			if (this.id_toAbsolutePath == IntPtr.Zero)
			{
				this.id_toAbsolutePath = JNIEnv.GetMethodID(this.class_ref, "toAbsolutePath", "()Ljava/nio/file/Path;");
			}
			return Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_toAbsolutePath), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000713D1 File Offset: 0x0006F5D1
		private static Delegate GetToFileHandler()
		{
			if (IPathInvoker.cb_toFile == null)
			{
				IPathInvoker.cb_toFile = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_ToFile));
			}
			return IPathInvoker.cb_toFile;
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000713F5 File Offset: 0x0006F5F5
		private static IntPtr n_ToFile(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToFile());
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x0007140C File Offset: 0x0006F60C
		public File ToFile()
		{
			if (this.id_toFile == IntPtr.Zero)
			{
				this.id_toFile = JNIEnv.GetMethodID(this.class_ref, "toFile", "()Ljava/io/File;");
			}
			return Java.Lang.Object.GetObject<File>(JNIEnv.CallObjectMethod(base.Handle, this.id_toFile), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x0007145D File Offset: 0x0006F65D
		private static Delegate GetToRealPath_arrayLjava_nio_file_LinkOption_Handler()
		{
			if (IPathInvoker.cb_toRealPath_arrayLjava_nio_file_LinkOption_ == null)
			{
				IPathInvoker.cb_toRealPath_arrayLjava_nio_file_LinkOption_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IPathInvoker.n_ToRealPath_arrayLjava_nio_file_LinkOption_));
			}
			return IPathInvoker.cb_toRealPath_arrayLjava_nio_file_LinkOption_;
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00071484 File Offset: 0x0006F684
		private static IntPtr n_ToRealPath_arrayLjava_nio_file_LinkOption_(IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			IPath @object = Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LinkOption[] array = (LinkOption[])JNIEnv.GetArray(native_options, JniHandleOwnership.DoNotTransfer, typeof(LinkOption));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.ToRealPath(array));
			if (array != null)
			{
				JNIEnv.CopyArray<LinkOption>(array, native_options);
			}
			return result;
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000714C8 File Offset: 0x0006F6C8
		public unsafe IPath ToRealPath(params LinkOption[] options)
		{
			if (this.id_toRealPath_arrayLjava_nio_file_LinkOption_ == IntPtr.Zero)
			{
				this.id_toRealPath_arrayLjava_nio_file_LinkOption_ = JNIEnv.GetMethodID(this.class_ref, "toRealPath", "([Ljava/nio/file/LinkOption;)Ljava/nio/file/Path;");
			}
			IntPtr intPtr = JNIEnv.NewArray<LinkOption>(options);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IPath @object = Java.Lang.Object.GetObject<IPath>(JNIEnv.CallObjectMethod(base.Handle, this.id_toRealPath_arrayLjava_nio_file_LinkOption_, ptr), JniHandleOwnership.TransferLocalRef);
			if (options != null)
			{
				JNIEnv.CopyArray<LinkOption>(intPtr, options);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00071549 File Offset: 0x0006F749
		private static Delegate GetToStringHandler()
		{
			if (IPathInvoker.cb_toString == null)
			{
				IPathInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_ToString));
			}
			return IPathInvoker.cb_toString;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x0007156D File Offset: 0x0006F76D
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00071584 File Offset: 0x0006F784
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000715D5 File Offset: 0x0006F7D5
		private static Delegate GetToUriHandler()
		{
			if (IPathInvoker.cb_toUri == null)
			{
				IPathInvoker.cb_toUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPathInvoker.n_ToUri));
			}
			return IPathInvoker.cb_toUri;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000715F9 File Offset: 0x0006F7F9
		private static IntPtr n_ToUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToUri());
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00071610 File Offset: 0x0006F810
		public URI ToUri()
		{
			if (this.id_toUri == IntPtr.Zero)
			{
				this.id_toUri = JNIEnv.GetMethodID(this.class_ref, "toUri", "()Ljava/net/URI;");
			}
			return Java.Lang.Object.GetObject<URI>(JNIEnv.CallObjectMethod(base.Handle, this.id_toUri), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00071664 File Offset: 0x0006F864
		public unsafe int CompareTo(Java.Lang.Object o)
		{
			if (this.id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "compareTo", "(Ljava/lang/Object;)I");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(o);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_compareTo_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0400102C RID: 4140
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/Path", typeof(IPathInvoker));

		// Token: 0x0400102D RID: 4141
		private IntPtr class_ref;

		// Token: 0x0400102E RID: 4142
		private static Delegate cb_getFileName;

		// Token: 0x0400102F RID: 4143
		private IntPtr id_getFileName;

		// Token: 0x04001030 RID: 4144
		private static Delegate cb_getFileSystem;

		// Token: 0x04001031 RID: 4145
		private IntPtr id_getFileSystem;

		// Token: 0x04001032 RID: 4146
		private static Delegate cb_isAbsolute;

		// Token: 0x04001033 RID: 4147
		private IntPtr id_isAbsolute;

		// Token: 0x04001034 RID: 4148
		private static Delegate cb_getNameCount;

		// Token: 0x04001035 RID: 4149
		private IntPtr id_getNameCount;

		// Token: 0x04001036 RID: 4150
		private static Delegate cb_getParent;

		// Token: 0x04001037 RID: 4151
		private IntPtr id_getParent;

		// Token: 0x04001038 RID: 4152
		private static Delegate cb_getRoot;

		// Token: 0x04001039 RID: 4153
		private IntPtr id_getRoot;

		// Token: 0x0400103A RID: 4154
		private static Delegate cb_compareTo_Ljava_nio_file_Path_;

		// Token: 0x0400103B RID: 4155
		private IntPtr id_compareTo_Ljava_nio_file_Path_;

		// Token: 0x0400103C RID: 4156
		private static Delegate cb_endsWith_Ljava_lang_String_;

		// Token: 0x0400103D RID: 4157
		private IntPtr id_endsWith_Ljava_lang_String_;

		// Token: 0x0400103E RID: 4158
		private static Delegate cb_endsWith_Ljava_nio_file_Path_;

		// Token: 0x0400103F RID: 4159
		private IntPtr id_endsWith_Ljava_nio_file_Path_;

		// Token: 0x04001040 RID: 4160
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04001041 RID: 4161
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04001042 RID: 4162
		private static Delegate cb_getName_I;

		// Token: 0x04001043 RID: 4163
		private IntPtr id_getName_I;

		// Token: 0x04001044 RID: 4164
		private static Delegate cb_hashCode;

		// Token: 0x04001045 RID: 4165
		private IntPtr id_hashCode;

		// Token: 0x04001046 RID: 4166
		private static Delegate cb_iterator;

		// Token: 0x04001047 RID: 4167
		private IntPtr id_iterator;

		// Token: 0x04001048 RID: 4168
		private static Delegate cb_normalize;

		// Token: 0x04001049 RID: 4169
		private IntPtr id_normalize;

		// Token: 0x0400104A RID: 4170
		private static Delegate cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_;

		// Token: 0x0400104B RID: 4171
		private IntPtr id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_;

		// Token: 0x0400104C RID: 4172
		private static Delegate cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_;

		// Token: 0x0400104D RID: 4173
		private IntPtr id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_;

		// Token: 0x0400104E RID: 4174
		private static Delegate cb_relativize_Ljava_nio_file_Path_;

		// Token: 0x0400104F RID: 4175
		private IntPtr id_relativize_Ljava_nio_file_Path_;

		// Token: 0x04001050 RID: 4176
		private static Delegate cb_resolve_Ljava_lang_String_;

		// Token: 0x04001051 RID: 4177
		private IntPtr id_resolve_Ljava_lang_String_;

		// Token: 0x04001052 RID: 4178
		private static Delegate cb_resolve_Ljava_nio_file_Path_;

		// Token: 0x04001053 RID: 4179
		private IntPtr id_resolve_Ljava_nio_file_Path_;

		// Token: 0x04001054 RID: 4180
		private static Delegate cb_resolveSibling_Ljava_lang_String_;

		// Token: 0x04001055 RID: 4181
		private IntPtr id_resolveSibling_Ljava_lang_String_;

		// Token: 0x04001056 RID: 4182
		private static Delegate cb_resolveSibling_Ljava_nio_file_Path_;

		// Token: 0x04001057 RID: 4183
		private IntPtr id_resolveSibling_Ljava_nio_file_Path_;

		// Token: 0x04001058 RID: 4184
		private static Delegate cb_startsWith_Ljava_lang_String_;

		// Token: 0x04001059 RID: 4185
		private IntPtr id_startsWith_Ljava_lang_String_;

		// Token: 0x0400105A RID: 4186
		private static Delegate cb_startsWith_Ljava_nio_file_Path_;

		// Token: 0x0400105B RID: 4187
		private IntPtr id_startsWith_Ljava_nio_file_Path_;

		// Token: 0x0400105C RID: 4188
		private static Delegate cb_subpath_II;

		// Token: 0x0400105D RID: 4189
		private IntPtr id_subpath_II;

		// Token: 0x0400105E RID: 4190
		private static Delegate cb_toAbsolutePath;

		// Token: 0x0400105F RID: 4191
		private IntPtr id_toAbsolutePath;

		// Token: 0x04001060 RID: 4192
		private static Delegate cb_toFile;

		// Token: 0x04001061 RID: 4193
		private IntPtr id_toFile;

		// Token: 0x04001062 RID: 4194
		private static Delegate cb_toRealPath_arrayLjava_nio_file_LinkOption_;

		// Token: 0x04001063 RID: 4195
		private IntPtr id_toRealPath_arrayLjava_nio_file_LinkOption_;

		// Token: 0x04001064 RID: 4196
		private static Delegate cb_toString;

		// Token: 0x04001065 RID: 4197
		private IntPtr id_toString;

		// Token: 0x04001066 RID: 4198
		private static Delegate cb_toUri;

		// Token: 0x04001067 RID: 4199
		private IntPtr id_toUri;

		// Token: 0x04001068 RID: 4200
		private IntPtr id_compareTo_Ljava_lang_Object_;
	}
}
