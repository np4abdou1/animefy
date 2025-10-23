using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Nio.Charset;
using Kotlin.Jvm.Functions;

namespace Kotlin.IO
{
	// Token: 0x02000221 RID: 545
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/FilesKt", DoNotGenerateAcw = true)]
	public sealed class FilesKt : Java.Lang.Object
	{
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x00053D54 File Offset: 0x00051F54
		internal static IntPtr class_ref
		{
			get
			{
				return FilesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00053D78 File Offset: 0x00051F78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FilesKt._members;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00053D80 File Offset: 0x00051F80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FilesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00053DA4 File Offset: 0x00051FA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FilesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00053DB0 File Offset: 0x00051FB0
		internal FilesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00053DBC File Offset: 0x00051FBC
		[Register("copyRecursively", "(Ljava/io/File;Ljava/io/File;ZLkotlin/jvm/functions/Function2;)Z", "")]
		public unsafe static bool CopyRecursively(File _this_copyRecursively, File target, bool overwrite, IFunction2 onError)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_copyRecursively == null) ? IntPtr.Zero : _this_copyRecursively.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue(overwrite);
				ptr[3] = new JniArgumentValue((onError == null) ? IntPtr.Zero : ((Java.Lang.Object)onError).Handle);
				result = FilesKt._members.StaticMethods.InvokeBooleanMethod("copyRecursively.(Ljava/io/File;Ljava/io/File;ZLkotlin/jvm/functions/Function2;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_copyRecursively);
				GC.KeepAlive(target);
				GC.KeepAlive(onError);
			}
			return result;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00053E90 File Offset: 0x00052090
		[Register("copyTo", "(Ljava/io/File;Ljava/io/File;ZI)Ljava/io/File;", "")]
		public unsafe static File CopyTo(File _this_copyTo, File target, bool overwrite, int bufferSize)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_copyTo == null) ? IntPtr.Zero : _this_copyTo.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue(overwrite);
				ptr[3] = new JniArgumentValue(bufferSize);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("copyTo.(Ljava/io/File;Ljava/io/File;ZI)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_copyTo);
				GC.KeepAlive(target);
			}
			return @object;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00053F58 File Offset: 0x00052158
		[Obsolete("deprecated")]
		[Register("createTempDir", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", "")]
		public unsafe static File CreateTempDir(string prefix, [Nullable(2)] string suffix, [Nullable(2)] File directory)
		{
			IntPtr intPtr = JNIEnv.NewString(prefix);
			IntPtr intPtr2 = JNIEnv.NewString(suffix);
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((directory == null) ? IntPtr.Zero : directory.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("createTempDir.(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(directory);
			}
			return @object;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00054010 File Offset: 0x00052210
		[Obsolete("deprecated")]
		[Register("createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", "")]
		public unsafe static File CreateTempFile(string prefix, [Nullable(2)] string suffix, [Nullable(2)] File directory)
		{
			IntPtr intPtr = JNIEnv.NewString(prefix);
			IntPtr intPtr2 = JNIEnv.NewString(suffix);
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((directory == null) ? IntPtr.Zero : directory.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("createTempFile.(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(directory);
			}
			return @object;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000540C8 File Offset: 0x000522C8
		[Register("deleteRecursively", "(Ljava/io/File;)Z", "")]
		public unsafe static bool DeleteRecursively(File _this_deleteRecursively)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_deleteRecursively == null) ? IntPtr.Zero : _this_deleteRecursively.Handle);
				result = FilesKt._members.StaticMethods.InvokeBooleanMethod("deleteRecursively.(Ljava/io/File;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_deleteRecursively);
			}
			return result;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0005412C File Offset: 0x0005232C
		[Register("endsWith", "(Ljava/io/File;Ljava/io/File;)Z", "")]
		public unsafe static bool EndsWith(File _this_endsWith, File other)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_endsWith == null) ? IntPtr.Zero : _this_endsWith.Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				result = FilesKt._members.StaticMethods.InvokeBooleanMethod("endsWith.(Ljava/io/File;Ljava/io/File;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_endsWith);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000541B8 File Offset: 0x000523B8
		[Register("endsWith", "(Ljava/io/File;Ljava/lang/String;)Z", "")]
		public unsafe static bool EndsWith(File _this_endsWith, string other)
		{
			IntPtr intPtr = JNIEnv.NewString(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_endsWith == null) ? IntPtr.Zero : _this_endsWith.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = FilesKt._members.StaticMethods.InvokeBooleanMethod("endsWith.(Ljava/io/File;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_endsWith);
			}
			return result;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0005423C File Offset: 0x0005243C
		[Register("getExtension", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public unsafe static string GetExtension(File _this_extension)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_extension == null) ? IntPtr.Zero : _this_extension.Handle);
				@string = JNIEnv.GetString(FilesKt._members.StaticMethods.InvokeObjectMethod("getExtension.(Ljava/io/File;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_extension);
			}
			return @string;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000542B0 File Offset: 0x000524B0
		[Register("getInvariantSeparatorsPath", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public unsafe static string GetInvariantSeparatorsPath(File _this_invariantSeparatorsPath)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_invariantSeparatorsPath == null) ? IntPtr.Zero : _this_invariantSeparatorsPath.Handle);
				@string = JNIEnv.GetString(FilesKt._members.StaticMethods.InvokeObjectMethod("getInvariantSeparatorsPath.(Ljava/io/File;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_invariantSeparatorsPath);
			}
			return @string;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00054324 File Offset: 0x00052524
		[Register("getNameWithoutExtension", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public unsafe static string GetNameWithoutExtension(File _this_nameWithoutExtension)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_nameWithoutExtension == null) ? IntPtr.Zero : _this_nameWithoutExtension.Handle);
				@string = JNIEnv.GetString(FilesKt._members.StaticMethods.InvokeObjectMethod("getNameWithoutExtension.(Ljava/io/File;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_nameWithoutExtension);
			}
			return @string;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00054398 File Offset: 0x00052598
		[Register("normalize", "(Ljava/io/File;)Ljava/io/File;", "")]
		public unsafe static File Normalize(File _this_normalize)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_normalize == null) ? IntPtr.Zero : _this_normalize.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("normalize.(Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_normalize);
			}
			return @object;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0005440C File Offset: 0x0005260C
		[Register("relativeTo", "(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", "")]
		public unsafe static File RelativeTo(File _this_relativeTo, File @base)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_relativeTo == null) ? IntPtr.Zero : _this_relativeTo.Handle);
				ptr[1] = new JniArgumentValue((@base == null) ? IntPtr.Zero : @base.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("relativeTo.(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_relativeTo);
				GC.KeepAlive(@base);
			}
			return @object;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000544A8 File Offset: 0x000526A8
		[Register("relativeToOrNull", "(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", "")]
		[return: Nullable(2)]
		public unsafe static File RelativeToOrNull(File _this_relativeToOrNull, File @base)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_relativeToOrNull == null) ? IntPtr.Zero : _this_relativeToOrNull.Handle);
				ptr[1] = new JniArgumentValue((@base == null) ? IntPtr.Zero : @base.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("relativeToOrNull.(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_relativeToOrNull);
				GC.KeepAlive(@base);
			}
			return @object;
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00054544 File Offset: 0x00052744
		[Register("relativeToOrSelf", "(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", "")]
		public unsafe static File RelativeToOrSelf(File _this_relativeToOrSelf, File @base)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_relativeToOrSelf == null) ? IntPtr.Zero : _this_relativeToOrSelf.Handle);
				ptr[1] = new JniArgumentValue((@base == null) ? IntPtr.Zero : @base.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("relativeToOrSelf.(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_relativeToOrSelf);
				GC.KeepAlive(@base);
			}
			return @object;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000545E0 File Offset: 0x000527E0
		[Register("resolve", "(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", "")]
		public unsafe static File Resolve(File _this_resolve, File relative)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_resolve == null) ? IntPtr.Zero : _this_resolve.Handle);
				ptr[1] = new JniArgumentValue((relative == null) ? IntPtr.Zero : relative.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("resolve.(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_resolve);
				GC.KeepAlive(relative);
			}
			return @object;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0005467C File Offset: 0x0005287C
		[Register("resolve", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", "")]
		public unsafe static File Resolve(File _this_resolve, string relative)
		{
			IntPtr intPtr = JNIEnv.NewString(relative);
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_resolve == null) ? IntPtr.Zero : _this_resolve.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("resolve.(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_resolve);
			}
			return @object;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00054710 File Offset: 0x00052910
		[Register("resolveSibling", "(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", "")]
		public unsafe static File ResolveSibling(File _this_resolveSibling, File relative)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_resolveSibling == null) ? IntPtr.Zero : _this_resolveSibling.Handle);
				ptr[1] = new JniArgumentValue((relative == null) ? IntPtr.Zero : relative.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("resolveSibling.(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_resolveSibling);
				GC.KeepAlive(relative);
			}
			return @object;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000547AC File Offset: 0x000529AC
		[Register("resolveSibling", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", "")]
		public unsafe static File ResolveSibling(File _this_resolveSibling, string relative)
		{
			IntPtr intPtr = JNIEnv.NewString(relative);
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_resolveSibling == null) ? IntPtr.Zero : _this_resolveSibling.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("resolveSibling.(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_resolveSibling);
			}
			return @object;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00054840 File Offset: 0x00052A40
		[Register("startsWith", "(Ljava/io/File;Ljava/io/File;)Z", "")]
		public unsafe static bool StartsWith(File _this_startsWith, File other)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_startsWith == null) ? IntPtr.Zero : _this_startsWith.Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				result = FilesKt._members.StaticMethods.InvokeBooleanMethod("startsWith.(Ljava/io/File;Ljava/io/File;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_startsWith);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000548CC File Offset: 0x00052ACC
		[Register("startsWith", "(Ljava/io/File;Ljava/lang/String;)Z", "")]
		public unsafe static bool StartsWith(File _this_startsWith, string other)
		{
			IntPtr intPtr = JNIEnv.NewString(other);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_startsWith == null) ? IntPtr.Zero : _this_startsWith.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = FilesKt._members.StaticMethods.InvokeBooleanMethod("startsWith.(Ljava/io/File;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_startsWith);
			}
			return result;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00054950 File Offset: 0x00052B50
		[Register("toRelativeString", "(Ljava/io/File;Ljava/io/File;)Ljava/lang/String;", "")]
		public unsafe static string ToRelativeString(File _this_toRelativeString, File @base)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toRelativeString == null) ? IntPtr.Zero : _this_toRelativeString.Handle);
				ptr[1] = new JniArgumentValue((@base == null) ? IntPtr.Zero : @base.Handle);
				@string = JNIEnv.GetString(FilesKt._members.StaticMethods.InvokeObjectMethod("toRelativeString.(Ljava/io/File;Ljava/io/File;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toRelativeString);
				GC.KeepAlive(@base);
			}
			return @string;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000549EC File Offset: 0x00052BEC
		[Register("walk", "(Ljava/io/File;Lkotlin/io/FileWalkDirection;)Lkotlin/io/FileTreeWalk;", "")]
		public unsafe static FileTreeWalk Walk(File _this_walk, FileWalkDirection direction)
		{
			FileTreeWalk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_walk == null) ? IntPtr.Zero : _this_walk.Handle);
				ptr[1] = new JniArgumentValue((direction == null) ? IntPtr.Zero : direction.Handle);
				@object = Java.Lang.Object.GetObject<FileTreeWalk>(FilesKt._members.StaticMethods.InvokeObjectMethod("walk.(Ljava/io/File;Lkotlin/io/FileWalkDirection;)Lkotlin/io/FileTreeWalk;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_walk);
				GC.KeepAlive(direction);
			}
			return @object;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00054A88 File Offset: 0x00052C88
		[Register("walkBottomUp", "(Ljava/io/File;)Lkotlin/io/FileTreeWalk;", "")]
		public unsafe static FileTreeWalk WalkBottomUp(File _this_walkBottomUp)
		{
			FileTreeWalk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_walkBottomUp == null) ? IntPtr.Zero : _this_walkBottomUp.Handle);
				@object = Java.Lang.Object.GetObject<FileTreeWalk>(FilesKt._members.StaticMethods.InvokeObjectMethod("walkBottomUp.(Ljava/io/File;)Lkotlin/io/FileTreeWalk;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_walkBottomUp);
			}
			return @object;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00054AFC File Offset: 0x00052CFC
		[Register("walkTopDown", "(Ljava/io/File;)Lkotlin/io/FileTreeWalk;", "")]
		public unsafe static FileTreeWalk WalkTopDown(File _this_walkTopDown)
		{
			FileTreeWalk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_walkTopDown == null) ? IntPtr.Zero : _this_walkTopDown.Handle);
				@object = Java.Lang.Object.GetObject<FileTreeWalk>(FilesKt._members.StaticMethods.InvokeObjectMethod("walkTopDown.(Ljava/io/File;)Lkotlin/io/FileTreeWalk;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_walkTopDown);
			}
			return @object;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00054B70 File Offset: 0x00052D70
		[Register("appendBytes", "(Ljava/io/File;[B)V", "")]
		public unsafe static void AppendBytes(File _this_appendBytes, byte[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_appendBytes == null) ? IntPtr.Zero : _this_appendBytes.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				FilesKt._members.StaticMethods.InvokeVoidMethod("appendBytes.(Ljava/io/File;[B)V", ptr);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_appendBytes);
				GC.KeepAlive(array);
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00054C04 File Offset: 0x00052E04
		[Register("appendText", "(Ljava/io/File;Ljava/lang/String;Ljava/nio/charset/Charset;)V", "")]
		public unsafe static void AppendText(File _this_appendText, string text, Charset charset)
		{
			IntPtr intPtr = JNIEnv.NewString(text);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_appendText == null) ? IntPtr.Zero : _this_appendText.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				FilesKt._members.StaticMethods.InvokeVoidMethod("appendText.(Ljava/io/File;Ljava/lang/String;Ljava/nio/charset/Charset;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_appendText);
				GC.KeepAlive(charset);
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00054CB4 File Offset: 0x00052EB4
		[Register("forEachBlock", "(Ljava/io/File;ILkotlin/jvm/functions/Function2;)V", "")]
		public unsafe static void ForEachBlock(File _this_forEachBlock, int blockSize, IFunction2 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEachBlock == null) ? IntPtr.Zero : _this_forEachBlock.Handle);
				ptr[1] = new JniArgumentValue(blockSize);
				ptr[2] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				FilesKt._members.StaticMethods.InvokeVoidMethod("forEachBlock.(Ljava/io/File;ILkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEachBlock);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00054D5C File Offset: 0x00052F5C
		[Register("forEachBlock", "(Ljava/io/File;Lkotlin/jvm/functions/Function2;)V", "")]
		public unsafe static void ForEachBlock(File _this_forEachBlock, IFunction2 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEachBlock == null) ? IntPtr.Zero : _this_forEachBlock.Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				FilesKt._members.StaticMethods.InvokeVoidMethod("forEachBlock.(Ljava/io/File;Lkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEachBlock);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00054DEC File Offset: 0x00052FEC
		[Register("forEachLine", "(Ljava/io/File;Ljava/nio/charset/Charset;Lkotlin/jvm/functions/Function1;)V", "")]
		public unsafe static void ForEachLine(File _this_forEachLine, Charset charset, IFunction1 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEachLine == null) ? IntPtr.Zero : _this_forEachLine.Handle);
				ptr[1] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				ptr[2] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				FilesKt._members.StaticMethods.InvokeVoidMethod("forEachLine.(Ljava/io/File;Ljava/nio/charset/Charset;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEachLine);
				GC.KeepAlive(charset);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00054EA8 File Offset: 0x000530A8
		[Register("readBytes", "(Ljava/io/File;)[B", "")]
		public unsafe static byte[] ReadBytes(File _this_readBytes)
		{
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_readBytes == null) ? IntPtr.Zero : _this_readBytes.Handle);
				result = (byte[])JNIEnv.GetArray(FilesKt._members.StaticMethods.InvokeObjectMethod("readBytes.(Ljava/io/File;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				GC.KeepAlive(_this_readBytes);
			}
			return result;
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00054F2C File Offset: 0x0005312C
		[Register("readLines", "(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/util/List;", "")]
		public unsafe static IList<string> ReadLines(File _this_readLines, Charset charset)
		{
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_readLines == null) ? IntPtr.Zero : _this_readLines.Handle);
				ptr[1] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				result = JavaList<string>.FromJniHandle(FilesKt._members.StaticMethods.InvokeObjectMethod("readLines.(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_readLines);
				GC.KeepAlive(charset);
			}
			return result;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00054FC8 File Offset: 0x000531C8
		[Register("readText", "(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public unsafe static string ReadText(File _this_readText, Charset charset)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_readText == null) ? IntPtr.Zero : _this_readText.Handle);
				ptr[1] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				@string = JNIEnv.GetString(FilesKt._members.StaticMethods.InvokeObjectMethod("readText.(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_readText);
				GC.KeepAlive(charset);
			}
			return @string;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00055064 File Offset: 0x00053264
		[Register("useLines", "(Ljava/io/File;Ljava/nio/charset/Charset;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object UseLines(File _this_useLines, Charset charset, IFunction1 block)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_useLines == null) ? IntPtr.Zero : _this_useLines.Handle);
				ptr[1] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				ptr[2] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FilesKt._members.StaticMethods.InvokeObjectMethod("useLines.(Ljava/io/File;Ljava/nio/charset/Charset;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_useLines);
				GC.KeepAlive(charset);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00055130 File Offset: 0x00053330
		[Register("writeBytes", "(Ljava/io/File;[B)V", "")]
		public unsafe static void WriteBytes(File _this_writeBytes, byte[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_writeBytes == null) ? IntPtr.Zero : _this_writeBytes.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				FilesKt._members.StaticMethods.InvokeVoidMethod("writeBytes.(Ljava/io/File;[B)V", ptr);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_writeBytes);
				GC.KeepAlive(array);
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000551C4 File Offset: 0x000533C4
		[Register("writeText", "(Ljava/io/File;Ljava/lang/String;Ljava/nio/charset/Charset;)V", "")]
		public unsafe static void WriteText(File _this_writeText, string text, Charset charset)
		{
			IntPtr intPtr = JNIEnv.NewString(text);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_writeText == null) ? IntPtr.Zero : _this_writeText.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				FilesKt._members.StaticMethods.InvokeVoidMethod("writeText.(Ljava/io/File;Ljava/lang/String;Ljava/nio/charset/Charset;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_writeText);
				GC.KeepAlive(charset);
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00055274 File Offset: 0x00053474
		[Register("getRoot", "(Ljava/io/File;)Ljava/io/File;", "")]
		public unsafe static File GetRoot(File _this_root)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_root == null) ? IntPtr.Zero : _this_root.Handle);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("getRoot.(Ljava/io/File;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_root);
			}
			return @object;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000552E8 File Offset: 0x000534E8
		[Register("getRootName", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public unsafe static string GetRootName(File _this_rootName)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_rootName == null) ? IntPtr.Zero : _this_rootName.Handle);
				@string = JNIEnv.GetString(FilesKt._members.StaticMethods.InvokeObjectMethod("getRootName.(Ljava/io/File;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_rootName);
			}
			return @string;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x0005535C File Offset: 0x0005355C
		[Register("isRooted", "(Ljava/io/File;)Z", "")]
		public unsafe static bool IsRooted(File _this_isRooted)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_isRooted == null) ? IntPtr.Zero : _this_isRooted.Handle);
				result = FilesKt._members.StaticMethods.InvokeBooleanMethod("isRooted.(Ljava/io/File;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_isRooted);
			}
			return result;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x000553C0 File Offset: 0x000535C0
		[Register("subPath", "(Ljava/io/File;II)Ljava/io/File;", "")]
		public unsafe static File SubPath(File _this_subPath, int beginIndex, int endIndex)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_subPath == null) ? IntPtr.Zero : _this_subPath.Handle);
				ptr[1] = new JniArgumentValue(beginIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				@object = Java.Lang.Object.GetObject<File>(FilesKt._members.StaticMethods.InvokeObjectMethod("subPath.(Ljava/io/File;II)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_subPath);
			}
			return @object;
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0005545C File Offset: 0x0005365C
		[Register("toComponents", "(Ljava/io/File;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object ToComponents(File _this_toComponents)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toComponents == null) ? IntPtr.Zero : _this_toComponents.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FilesKt._members.StaticMethods.InvokeObjectMethod("toComponents.(Ljava/io/File;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toComponents);
			}
			return @object;
		}

		// Token: 0x040007D2 RID: 2002
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/FilesKt", typeof(FilesKt));
	}
}
