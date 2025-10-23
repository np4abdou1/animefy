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
	// Token: 0x02000231 RID: 561
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/path/OnErrorResult", DoNotGenerateAcw = true)]
	public sealed class OnErrorResult : Java.Lang.Enum
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00056E6C File Offset: 0x0005506C
		[Nullable(2)]
		[Register("SKIP_SUBTREE")]
		public static OnErrorResult SkipSubtree
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<OnErrorResult>(OnErrorResult._members.StaticFields.GetObjectValue("SKIP_SUBTREE.Lkotlin/io/path/OnErrorResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x00056E9C File Offset: 0x0005509C
		[Nullable(2)]
		[Register("TERMINATE")]
		public static OnErrorResult Terminate
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<OnErrorResult>(OnErrorResult._members.StaticFields.GetObjectValue("TERMINATE.Lkotlin/io/path/OnErrorResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00056ECC File Offset: 0x000550CC
		internal static IntPtr class_ref
		{
			get
			{
				return OnErrorResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00056EF0 File Offset: 0x000550F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OnErrorResult._members;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x00056EF8 File Offset: 0x000550F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OnErrorResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x00056F1C File Offset: 0x0005511C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OnErrorResult._members.ManagedPeerType;
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00056F28 File Offset: 0x00055128
		internal OnErrorResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00056F34 File Offset: 0x00055134
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(OnErrorResult._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00056F68 File Offset: 0x00055168
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/io/path/OnErrorResult;", "")]
		public unsafe static OnErrorResult ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			OnErrorResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<OnErrorResult>(OnErrorResult._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/io/path/OnErrorResult;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00056FD4 File Offset: 0x000551D4
		[Register("values", "()[Lkotlin/io/path/OnErrorResult;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static OnErrorResult[] Values()
		{
			return (OnErrorResult[])JNIEnv.GetArray(OnErrorResult._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/io/path/OnErrorResult;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(OnErrorResult));
		}

		// Token: 0x040007F3 RID: 2035
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/path/OnErrorResult", typeof(OnErrorResult));
	}
}
