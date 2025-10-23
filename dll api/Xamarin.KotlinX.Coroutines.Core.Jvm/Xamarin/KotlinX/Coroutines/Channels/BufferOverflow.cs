using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C3 RID: 195
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/BufferOverflow", DoNotGenerateAcw = true)]
	public sealed class BufferOverflow : Java.Lang.Enum
	{
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0001FDCC File Offset: 0x0001DFCC
		[Register("DROP_LATEST")]
		public static BufferOverflow DropLatest
		{
			get
			{
				return Java.Lang.Object.GetObject<BufferOverflow>(BufferOverflow._members.StaticFields.GetObjectValue("DROP_LATEST.Lkotlinx/coroutines/channels/BufferOverflow;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0001FDFC File Offset: 0x0001DFFC
		[Register("DROP_OLDEST")]
		public static BufferOverflow DropOldest
		{
			get
			{
				return Java.Lang.Object.GetObject<BufferOverflow>(BufferOverflow._members.StaticFields.GetObjectValue("DROP_OLDEST.Lkotlinx/coroutines/channels/BufferOverflow;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0001FE2C File Offset: 0x0001E02C
		[Register("SUSPEND")]
		public static BufferOverflow Suspend
		{
			get
			{
				return Java.Lang.Object.GetObject<BufferOverflow>(BufferOverflow._members.StaticFields.GetObjectValue("SUSPEND.Lkotlinx/coroutines/channels/BufferOverflow;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0001FE5C File Offset: 0x0001E05C
		internal static IntPtr class_ref
		{
			get
			{
				return BufferOverflow._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0001FE80 File Offset: 0x0001E080
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return BufferOverflow._members;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0001FE88 File Offset: 0x0001E088
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BufferOverflow._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0001FEAC File Offset: 0x0001E0AC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return BufferOverflow._members.ManagedPeerType;
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0001FEB8 File Offset: 0x0001E0B8
		internal BufferOverflow(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0001FEC4 File Offset: 0x0001E0C4
		[Register("valueOf", "(Ljava/lang/String;)Lkotlinx/coroutines/channels/BufferOverflow;", "")]
		public unsafe static BufferOverflow ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			BufferOverflow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BufferOverflow>(BufferOverflow._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlinx/coroutines/channels/BufferOverflow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0001FF30 File Offset: 0x0001E130
		[Register("values", "()[Lkotlinx/coroutines/channels/BufferOverflow;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static BufferOverflow[] Values()
		{
			return (BufferOverflow[])JNIEnv.GetArray(BufferOverflow._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlinx/coroutines/channels/BufferOverflow;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(BufferOverflow));
		}

		// Token: 0x040002C1 RID: 705
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/BufferOverflow", typeof(BufferOverflow));
	}
}
