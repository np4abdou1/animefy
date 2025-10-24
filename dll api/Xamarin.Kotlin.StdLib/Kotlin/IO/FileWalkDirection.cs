using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin.IO
{
	// Token: 0x02000224 RID: 548
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/FileWalkDirection", DoNotGenerateAcw = true)]
	public sealed class FileWalkDirection : Java.Lang.Enum
	{
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x00055970 File Offset: 0x00053B70
		[Nullable(2)]
		[Register("BOTTOM_UP")]
		public static FileWalkDirection BottomUp
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<FileWalkDirection>(FileWalkDirection._members.StaticFields.GetObjectValue("BOTTOM_UP.Lkotlin/io/FileWalkDirection;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x000559A0 File Offset: 0x00053BA0
		[Nullable(2)]
		[Register("TOP_DOWN")]
		public static FileWalkDirection TopDown
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<FileWalkDirection>(FileWalkDirection._members.StaticFields.GetObjectValue("TOP_DOWN.Lkotlin/io/FileWalkDirection;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x000559D0 File Offset: 0x00053BD0
		internal static IntPtr class_ref
		{
			get
			{
				return FileWalkDirection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x000559F4 File Offset: 0x00053BF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileWalkDirection._members;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x000559FC File Offset: 0x00053BFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileWalkDirection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x00055A20 File Offset: 0x00053C20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileWalkDirection._members.ManagedPeerType;
			}
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00055A2C File Offset: 0x00053C2C
		internal FileWalkDirection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x00055A38 File Offset: 0x00053C38
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(FileWalkDirection._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00055A6C File Offset: 0x00053C6C
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/io/FileWalkDirection;", "")]
		public unsafe static FileWalkDirection ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			FileWalkDirection @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FileWalkDirection>(FileWalkDirection._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/io/FileWalkDirection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00055AD8 File Offset: 0x00053CD8
		[Register("values", "()[Lkotlin/io/FileWalkDirection;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static FileWalkDirection[] Values()
		{
			return (FileWalkDirection[])JNIEnv.GetArray(FileWalkDirection._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/io/FileWalkDirection;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(FileWalkDirection));
		}

		// Token: 0x040007D5 RID: 2005
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/FileWalkDirection", typeof(FileWalkDirection));
	}
}
