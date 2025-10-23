using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio.Charset;
using Java.Nio.FileNio;
using Java.Nio.FileNio.Attributes;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;

namespace Kotlin.IO.Path
{
	// Token: 0x02000232 RID: 562
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/path/PathsKt", DoNotGenerateAcw = true)]
	public sealed class PathsKt : Java.Lang.Object
	{
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00057030 File Offset: 0x00055230
		internal static IntPtr class_ref
		{
			get
			{
				return PathsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00057054 File Offset: 0x00055254
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PathsKt._members;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0005705C File Offset: 0x0005525C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PathsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00057080 File Offset: 0x00055280
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PathsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0005708C File Offset: 0x0005528C
		internal PathsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00057098 File Offset: 0x00055298
		[Register("createParentDirectories", "(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", "")]
		public unsafe static IPath CreateParentDirectories(IPath _this_createParentDirectories, params IFileAttribute[] attributes)
		{
			IntPtr intPtr = JNIEnv.NewArray<IFileAttribute>(attributes);
			IPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_createParentDirectories == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_createParentDirectories).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IPath>(PathsKt._members.StaticMethods.InvokeObjectMethod("createParentDirectories.(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (attributes != null)
				{
					JNIEnv.CopyArray<IFileAttribute>(intPtr, attributes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_createParentDirectories);
				GC.KeepAlive(attributes);
			}
			return @object;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00057140 File Offset: 0x00055340
		[Register("createTempDirectory", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", "")]
		public unsafe static IPath CreateTempDirectory([Nullable(2)] IPath directory, [Nullable(2)] string prefix, params IFileAttribute[] attributes)
		{
			IntPtr intPtr = JNIEnv.NewString(prefix);
			IntPtr intPtr2 = JNIEnv.NewArray<IFileAttribute>(attributes);
			IPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((directory == null) ? IntPtr.Zero : ((Java.Lang.Object)directory).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<IPath>(PathsKt._members.StaticMethods.InvokeObjectMethod("createTempDirectory.(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (attributes != null)
				{
					JNIEnv.CopyArray<IFileAttribute>(intPtr2, attributes);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(directory);
				GC.KeepAlive(attributes);
			}
			return @object;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0005720C File Offset: 0x0005540C
		[NullableContext(2)]
		[Register("createTempFile", "(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", "")]
		[return: Nullable(1)]
		public unsafe static IPath CreateTempFile(IPath directory, string prefix, string suffix, [Nullable(1)] params IFileAttribute[] attributes)
		{
			IntPtr intPtr = JNIEnv.NewString(prefix);
			IntPtr intPtr2 = JNIEnv.NewString(suffix);
			IntPtr intPtr3 = JNIEnv.NewArray<IFileAttribute>(attributes);
			IPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((directory == null) ? IntPtr.Zero : ((Java.Lang.Object)directory).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				@object = Java.Lang.Object.GetObject<IPath>(PathsKt._members.StaticMethods.InvokeObjectMethod("createTempFile.(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (attributes != null)
				{
					JNIEnv.CopyArray<IFileAttribute>(intPtr3, attributes);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(directory);
				GC.KeepAlive(attributes);
			}
			return @object;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000572FC File Offset: 0x000554FC
		[Register("fileAttributeViewNotAvailable", "(Ljava/nio/file/Path;Ljava/lang/Class;)Ljava/lang/Void;", "")]
		public unsafe static Java.Lang.Void FileAttributeViewNotAvailable(IPath path, Class attributeViewClass)
		{
			Java.Lang.Void @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((path == null) ? IntPtr.Zero : ((Java.Lang.Object)path).Handle);
				ptr[1] = new JniArgumentValue((attributeViewClass == null) ? IntPtr.Zero : attributeViewClass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Void>(PathsKt._members.StaticMethods.InvokeObjectMethod("fileAttributeViewNotAvailable.(Ljava/nio/file/Path;Ljava/lang/Class;)Ljava/lang/Void;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(path);
				GC.KeepAlive(attributeViewClass);
			}
			return @object;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0005739C File Offset: 0x0005559C
		[Register("fileVisitor", "(Lkotlin/jvm/functions/Function1;)Ljava/nio/file/FileVisitor;", "")]
		public unsafe static IFileVisitor FileVisitor(IFunction1 builderAction)
		{
			IFileVisitor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builderAction == null) ? IntPtr.Zero : ((Java.Lang.Object)builderAction).Handle);
				@object = Java.Lang.Object.GetObject<IFileVisitor>(PathsKt._members.StaticMethods.InvokeObjectMethod("fileVisitor.(Lkotlin/jvm/functions/Function1;)Ljava/nio/file/FileVisitor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builderAction);
			}
			return @object;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00057414 File Offset: 0x00055614
		[Register("getExtension", "(Ljava/nio/file/Path;)Ljava/lang/String;", "")]
		public unsafe static string GetExtension(IPath _this_extension)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_extension == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_extension).Handle);
				@string = JNIEnv.GetString(PathsKt._members.StaticMethods.InvokeObjectMethod("getExtension.(Ljava/nio/file/Path;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_extension);
			}
			return @string;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0005748C File Offset: 0x0005568C
		[Register("getInvariantSeparatorsPathString", "(Ljava/nio/file/Path;)Ljava/lang/String;", "")]
		public unsafe static string GetInvariantSeparatorsPathString(IPath _this_invariantSeparatorsPathString)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_invariantSeparatorsPathString == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_invariantSeparatorsPathString).Handle);
				@string = JNIEnv.GetString(PathsKt._members.StaticMethods.InvokeObjectMethod("getInvariantSeparatorsPathString.(Ljava/nio/file/Path;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_invariantSeparatorsPathString);
			}
			return @string;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00057504 File Offset: 0x00055704
		[Register("getName", "(Ljava/nio/file/Path;)Ljava/lang/String;", "")]
		public unsafe static string GetName(IPath _this_name)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_name == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_name).Handle);
				@string = JNIEnv.GetString(PathsKt._members.StaticMethods.InvokeObjectMethod("getName.(Ljava/nio/file/Path;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_name);
			}
			return @string;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0005757C File Offset: 0x0005577C
		[Register("getNameWithoutExtension", "(Ljava/nio/file/Path;)Ljava/lang/String;", "")]
		public unsafe static string GetNameWithoutExtension(IPath _this_nameWithoutExtension)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_nameWithoutExtension == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_nameWithoutExtension).Handle);
				@string = JNIEnv.GetString(PathsKt._members.StaticMethods.InvokeObjectMethod("getNameWithoutExtension.(Ljava/nio/file/Path;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_nameWithoutExtension);
			}
			return @string;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000575F4 File Offset: 0x000557F4
		[Register("listDirectoryEntries", "(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe static IList<IPath> ListDirectoryEntries(IPath _this_listDirectoryEntries, string glob)
		{
			IntPtr intPtr = JNIEnv.NewString(glob);
			IList<IPath> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_listDirectoryEntries == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_listDirectoryEntries).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaList<IPath>.FromJniHandle(PathsKt._members.StaticMethods.InvokeObjectMethod("listDirectoryEntries.(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_listDirectoryEntries);
			}
			return result;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0005768C File Offset: 0x0005588C
		[Register("relativeTo", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)Ljava/nio/file/Path;", "")]
		public unsafe static IPath RelativeTo(IPath _this_relativeTo, IPath @base)
		{
			IPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_relativeTo == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_relativeTo).Handle);
				ptr[1] = new JniArgumentValue((@base == null) ? IntPtr.Zero : ((Java.Lang.Object)@base).Handle);
				@object = Java.Lang.Object.GetObject<IPath>(PathsKt._members.StaticMethods.InvokeObjectMethod("relativeTo.(Ljava/nio/file/Path;Ljava/nio/file/Path;)Ljava/nio/file/Path;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_relativeTo);
				GC.KeepAlive(@base);
			}
			return @object;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00057730 File Offset: 0x00055930
		[Register("relativeToOrNull", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)Ljava/nio/file/Path;", "")]
		[return: Nullable(2)]
		public unsafe static IPath RelativeToOrNull(IPath _this_relativeToOrNull, IPath @base)
		{
			IPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_relativeToOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_relativeToOrNull).Handle);
				ptr[1] = new JniArgumentValue((@base == null) ? IntPtr.Zero : ((Java.Lang.Object)@base).Handle);
				@object = Java.Lang.Object.GetObject<IPath>(PathsKt._members.StaticMethods.InvokeObjectMethod("relativeToOrNull.(Ljava/nio/file/Path;Ljava/nio/file/Path;)Ljava/nio/file/Path;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_relativeToOrNull);
				GC.KeepAlive(@base);
			}
			return @object;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000577D4 File Offset: 0x000559D4
		[Register("relativeToOrSelf", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)Ljava/nio/file/Path;", "")]
		public unsafe static IPath RelativeToOrSelf(IPath _this_relativeToOrSelf, IPath @base)
		{
			IPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_relativeToOrSelf == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_relativeToOrSelf).Handle);
				ptr[1] = new JniArgumentValue((@base == null) ? IntPtr.Zero : ((Java.Lang.Object)@base).Handle);
				@object = Java.Lang.Object.GetObject<IPath>(PathsKt._members.StaticMethods.InvokeObjectMethod("relativeToOrSelf.(Ljava/nio/file/Path;Ljava/nio/file/Path;)Ljava/nio/file/Path;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_relativeToOrSelf);
				GC.KeepAlive(@base);
			}
			return @object;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00057878 File Offset: 0x00055A78
		[Register("visitFileTree", "(Ljava/nio/file/Path;IZLkotlin/jvm/functions/Function1;)V", "")]
		public unsafe static void VisitFileTree(IPath _this_visitFileTree, int maxDepth, bool followLinks, IFunction1 builderAction)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_visitFileTree == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_visitFileTree).Handle);
				ptr[1] = new JniArgumentValue(maxDepth);
				ptr[2] = new JniArgumentValue(followLinks);
				ptr[3] = new JniArgumentValue((builderAction == null) ? IntPtr.Zero : ((Java.Lang.Object)builderAction).Handle);
				PathsKt._members.StaticMethods.InvokeVoidMethod("visitFileTree.(Ljava/nio/file/Path;IZLkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_visitFileTree);
				GC.KeepAlive(builderAction);
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00057938 File Offset: 0x00055B38
		[Register("visitFileTree", "(Ljava/nio/file/Path;Ljava/nio/file/FileVisitor;IZ)V", "")]
		public unsafe static void VisitFileTree(IPath _this_visitFileTree, IFileVisitor visitor, int maxDepth, bool followLinks)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_visitFileTree == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_visitFileTree).Handle);
				ptr[1] = new JniArgumentValue((visitor == null) ? IntPtr.Zero : ((Java.Lang.Object)visitor).Handle);
				ptr[2] = new JniArgumentValue(maxDepth);
				ptr[3] = new JniArgumentValue(followLinks);
				PathsKt._members.StaticMethods.InvokeVoidMethod("visitFileTree.(Ljava/nio/file/Path;Ljava/nio/file/FileVisitor;IZ)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_visitFileTree);
				GC.KeepAlive(visitor);
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000579F8 File Offset: 0x00055BF8
		[Register("walk", "(Ljava/nio/file/Path;[Lkotlin/io/path/PathWalkOption;)Lkotlin/sequences/Sequence;", "")]
		public unsafe static ISequence Walk(IPath _this_walk, params PathWalkOption[] options)
		{
			IntPtr intPtr = JNIEnv.NewArray<PathWalkOption>(options);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_walk == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_walk).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISequence>(PathsKt._members.StaticMethods.InvokeObjectMethod("walk.(Ljava/nio/file/Path;[Lkotlin/io/path/PathWalkOption;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (options != null)
				{
					JNIEnv.CopyArray<PathWalkOption>(intPtr, options);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_walk);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00057AA0 File Offset: 0x00055CA0
		[Register("copyToRecursively", "(Ljava/nio/file/Path;Ljava/nio/file/Path;Lkotlin/jvm/functions/Function3;ZZ)Ljava/nio/file/Path;", "")]
		public unsafe static IPath CopyToRecursively(IPath _this_copyToRecursively, IPath target, IFunction3 onError, bool followLinks, bool overwrite)
		{
			IPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_copyToRecursively == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_copyToRecursively).Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				ptr[2] = new JniArgumentValue((onError == null) ? IntPtr.Zero : ((Java.Lang.Object)onError).Handle);
				ptr[3] = new JniArgumentValue(followLinks);
				ptr[4] = new JniArgumentValue(overwrite);
				@object = Java.Lang.Object.GetObject<IPath>(PathsKt._members.StaticMethods.InvokeObjectMethod("copyToRecursively.(Ljava/nio/file/Path;Ljava/nio/file/Path;Lkotlin/jvm/functions/Function3;ZZ)Ljava/nio/file/Path;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_copyToRecursively);
				GC.KeepAlive(target);
				GC.KeepAlive(onError);
			}
			return @object;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00057BA4 File Offset: 0x00055DA4
		[Register("copyToRecursively", "(Ljava/nio/file/Path;Ljava/nio/file/Path;Lkotlin/jvm/functions/Function3;ZLkotlin/jvm/functions/Function3;)Ljava/nio/file/Path;", "")]
		public unsafe static IPath CopyToRecursively(IPath _this_copyToRecursively, IPath target, IFunction3 onError, bool followLinks, IFunction3 copyAction)
		{
			IPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_copyToRecursively == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_copyToRecursively).Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				ptr[2] = new JniArgumentValue((onError == null) ? IntPtr.Zero : ((Java.Lang.Object)onError).Handle);
				ptr[3] = new JniArgumentValue(followLinks);
				ptr[4] = new JniArgumentValue((copyAction == null) ? IntPtr.Zero : ((Java.Lang.Object)copyAction).Handle);
				@object = Java.Lang.Object.GetObject<IPath>(PathsKt._members.StaticMethods.InvokeObjectMethod("copyToRecursively.(Ljava/nio/file/Path;Ljava/nio/file/Path;Lkotlin/jvm/functions/Function3;ZLkotlin/jvm/functions/Function3;)Ljava/nio/file/Path;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_copyToRecursively);
				GC.KeepAlive(target);
				GC.KeepAlive(onError);
				GC.KeepAlive(copyAction);
			}
			return @object;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00057CC4 File Offset: 0x00055EC4
		[Register("deleteRecursively", "(Ljava/nio/file/Path;)V", "")]
		public unsafe static void DeleteRecursively(IPath _this_deleteRecursively)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_deleteRecursively == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_deleteRecursively).Handle);
				PathsKt._members.StaticMethods.InvokeVoidMethod("deleteRecursively.(Ljava/nio/file/Path;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_deleteRecursively);
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00057D2C File Offset: 0x00055F2C
		[Register("appendText", "(Ljava/nio/file/Path;Ljava/lang/CharSequence;Ljava/nio/charset/Charset;)V", "")]
		public unsafe static void AppendText(IPath _this_appendText, ICharSequence text, Charset charset)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_appendText == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_appendText).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				PathsKt._members.StaticMethods.InvokeVoidMethod("appendText.(Ljava/nio/file/Path;Ljava/lang/CharSequence;Ljava/nio/charset/Charset;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_appendText);
				GC.KeepAlive(text);
				GC.KeepAlive(charset);
			}
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00057DE4 File Offset: 0x00055FE4
		public static void AppendText(IPath _this_appendText, string text, Charset charset)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			PathsKt.AppendText(_this_appendText, @string, charset);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00057E10 File Offset: 0x00056010
		[Register("readText", "(Ljava/nio/file/Path;Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public unsafe static string ReadText(IPath _this_readText, Charset charset)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_readText == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_readText).Handle);
				ptr[1] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				@string = JNIEnv.GetString(PathsKt._members.StaticMethods.InvokeObjectMethod("readText.(Ljava/nio/file/Path;Ljava/nio/charset/Charset;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_readText);
				GC.KeepAlive(charset);
			}
			return @string;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00057EB0 File Offset: 0x000560B0
		[Register("writeText", "(Ljava/nio/file/Path;Ljava/lang/CharSequence;Ljava/nio/charset/Charset;[Ljava/nio/file/OpenOption;)V", "")]
		public unsafe static void WriteText(IPath _this_writeText, ICharSequence text, Charset charset, params IOpenOption[] options)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			IntPtr intPtr2 = JNIEnv.NewArray<IOpenOption>(options);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_writeText == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_writeText).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((charset == null) ? IntPtr.Zero : charset.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				PathsKt._members.StaticMethods.InvokeVoidMethod("writeText.(Ljava/nio/file/Path;Ljava/lang/CharSequence;Ljava/nio/charset/Charset;[Ljava/nio/file/OpenOption;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (options != null)
				{
					JNIEnv.CopyArray<IOpenOption>(intPtr2, options);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(_this_writeText);
				GC.KeepAlive(text);
				GC.KeepAlive(charset);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00057F9C File Offset: 0x0005619C
		public static void WriteText(IPath _this_writeText, string text, Charset charset, params IOpenOption[] options)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			PathsKt.WriteText(_this_writeText, @string, charset, options);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x040007F4 RID: 2036
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/path/PathsKt", typeof(PathsKt));
	}
}
