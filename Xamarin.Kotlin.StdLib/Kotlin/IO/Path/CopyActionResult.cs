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
	// Token: 0x02000229 RID: 553
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/path/CopyActionResult", DoNotGenerateAcw = true)]
	public sealed class CopyActionResult : Java.Lang.Enum
	{
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00056330 File Offset: 0x00054530
		[Nullable(2)]
		[Register("CONTINUE")]
		public static CopyActionResult Continue
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<CopyActionResult>(CopyActionResult._members.StaticFields.GetObjectValue("CONTINUE.Lkotlin/io/path/CopyActionResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x00056360 File Offset: 0x00054560
		[Nullable(2)]
		[Register("SKIP_SUBTREE")]
		public static CopyActionResult SkipSubtree
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<CopyActionResult>(CopyActionResult._members.StaticFields.GetObjectValue("SKIP_SUBTREE.Lkotlin/io/path/CopyActionResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00056390 File Offset: 0x00054590
		[Nullable(2)]
		[Register("TERMINATE")]
		public static CopyActionResult Terminate
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<CopyActionResult>(CopyActionResult._members.StaticFields.GetObjectValue("TERMINATE.Lkotlin/io/path/CopyActionResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x000563C0 File Offset: 0x000545C0
		internal static IntPtr class_ref
		{
			get
			{
				return CopyActionResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x000563E4 File Offset: 0x000545E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CopyActionResult._members;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x000563EC File Offset: 0x000545EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CopyActionResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x00056410 File Offset: 0x00054610
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CopyActionResult._members.ManagedPeerType;
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0005641C File Offset: 0x0005461C
		internal CopyActionResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00056428 File Offset: 0x00054628
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(CopyActionResult._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0005645C File Offset: 0x0005465C
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/io/path/CopyActionResult;", "")]
		public unsafe static CopyActionResult ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			CopyActionResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CopyActionResult>(CopyActionResult._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/io/path/CopyActionResult;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x000564C8 File Offset: 0x000546C8
		[Register("values", "()[Lkotlin/io/path/CopyActionResult;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static CopyActionResult[] Values()
		{
			return (CopyActionResult[])JNIEnv.GetArray(CopyActionResult._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/io/path/CopyActionResult;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CopyActionResult));
		}

		// Token: 0x040007DA RID: 2010
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/path/CopyActionResult", typeof(CopyActionResult));
	}
}
