using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin.IO.Path
{
	// Token: 0x02000234 RID: 564
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/path/PathWalkOption", DoNotGenerateAcw = true)]
	public sealed class PathWalkOption : Java.Lang.Enum
	{
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00058068 File Offset: 0x00056268
		[Nullable(2)]
		[Register("BREADTH_FIRST")]
		public static PathWalkOption BreadthFirst
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<PathWalkOption>(PathWalkOption._members.StaticFields.GetObjectValue("BREADTH_FIRST.Lkotlin/io/path/PathWalkOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x00058098 File Offset: 0x00056298
		[Nullable(2)]
		[Register("FOLLOW_LINKS")]
		public static PathWalkOption FollowLinks
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<PathWalkOption>(PathWalkOption._members.StaticFields.GetObjectValue("FOLLOW_LINKS.Lkotlin/io/path/PathWalkOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x000580C8 File Offset: 0x000562C8
		[Nullable(2)]
		[Register("INCLUDE_DIRECTORIES")]
		public static PathWalkOption IncludeDirectories
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<PathWalkOption>(PathWalkOption._members.StaticFields.GetObjectValue("INCLUDE_DIRECTORIES.Lkotlin/io/path/PathWalkOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x000580F8 File Offset: 0x000562F8
		internal static IntPtr class_ref
		{
			get
			{
				return PathWalkOption._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0005811C File Offset: 0x0005631C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PathWalkOption._members;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00058124 File Offset: 0x00056324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PathWalkOption._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00058148 File Offset: 0x00056348
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PathWalkOption._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00058154 File Offset: 0x00056354
		internal PathWalkOption(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x00058160 File Offset: 0x00056360
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(PathWalkOption._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00058194 File Offset: 0x00056394
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/io/path/PathWalkOption;", "")]
		public unsafe static PathWalkOption ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			PathWalkOption @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PathWalkOption>(PathWalkOption._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/io/path/PathWalkOption;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00058200 File Offset: 0x00056400
		[Register("values", "()[Lkotlin/io/path/PathWalkOption;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static PathWalkOption[] Values()
		{
			return (PathWalkOption[])JNIEnv.GetArray(PathWalkOption._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/io/path/PathWalkOption;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(PathWalkOption));
		}

		// Token: 0x040007F6 RID: 2038
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/path/PathWalkOption", typeof(PathWalkOption));
	}
}
