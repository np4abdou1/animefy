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
	// Token: 0x02000226 RID: 550
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/OnErrorAction", DoNotGenerateAcw = true)]
	public sealed class OnErrorAction : Java.Lang.Enum
	{
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x00055CB0 File Offset: 0x00053EB0
		[Nullable(2)]
		[Register("SKIP")]
		public static OnErrorAction Skip
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<OnErrorAction>(OnErrorAction._members.StaticFields.GetObjectValue("SKIP.Lkotlin/io/OnErrorAction;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00055CE0 File Offset: 0x00053EE0
		[Nullable(2)]
		[Register("TERMINATE")]
		public static OnErrorAction Terminate
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<OnErrorAction>(OnErrorAction._members.StaticFields.GetObjectValue("TERMINATE.Lkotlin/io/OnErrorAction;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x00055D10 File Offset: 0x00053F10
		internal static IntPtr class_ref
		{
			get
			{
				return OnErrorAction._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x00055D34 File Offset: 0x00053F34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OnErrorAction._members;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x00055D3C File Offset: 0x00053F3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OnErrorAction._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x00055D60 File Offset: 0x00053F60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OnErrorAction._members.ManagedPeerType;
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00055D6C File Offset: 0x00053F6C
		internal OnErrorAction(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00055D78 File Offset: 0x00053F78
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(OnErrorAction._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00055DAC File Offset: 0x00053FAC
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/io/OnErrorAction;", "")]
		public unsafe static OnErrorAction ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			OnErrorAction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<OnErrorAction>(OnErrorAction._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/io/OnErrorAction;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00055E18 File Offset: 0x00054018
		[Register("values", "()[Lkotlin/io/OnErrorAction;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static OnErrorAction[] Values()
		{
			return (OnErrorAction[])JNIEnv.GetArray(OnErrorAction._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/io/OnErrorAction;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(OnErrorAction));
		}

		// Token: 0x040007D7 RID: 2007
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/OnErrorAction", typeof(OnErrorAction));
	}
}
