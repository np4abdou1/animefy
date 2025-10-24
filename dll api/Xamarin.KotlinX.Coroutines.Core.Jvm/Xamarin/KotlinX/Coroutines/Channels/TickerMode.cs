using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000E4 RID: 228
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/TickerMode", DoNotGenerateAcw = true)]
	public sealed class TickerMode : Java.Lang.Enum
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00025F5C File Offset: 0x0002415C
		[Nullable(2)]
		[Register("FIXED_DELAY")]
		public static TickerMode FixedDelay
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<TickerMode>(TickerMode._members.StaticFields.GetObjectValue("FIXED_DELAY.Lkotlinx/coroutines/channels/TickerMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00025F8C File Offset: 0x0002418C
		[Nullable(2)]
		[Register("FIXED_PERIOD")]
		public static TickerMode FixedPeriod
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<TickerMode>(TickerMode._members.StaticFields.GetObjectValue("FIXED_PERIOD.Lkotlinx/coroutines/channels/TickerMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00025FBC File Offset: 0x000241BC
		internal static IntPtr class_ref
		{
			get
			{
				return TickerMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00025FE0 File Offset: 0x000241E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TickerMode._members;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00025FE8 File Offset: 0x000241E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TickerMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0002600C File Offset: 0x0002420C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TickerMode._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00026018 File Offset: 0x00024218
		internal TickerMode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00026024 File Offset: 0x00024224
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlinx/coroutines/channels/TickerMode;", "")]
		public unsafe static TickerMode ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			TickerMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<TickerMode>(TickerMode._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlinx/coroutines/channels/TickerMode;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00026090 File Offset: 0x00024290
		[Register("values", "()[Lkotlinx/coroutines/channels/TickerMode;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static TickerMode[] Values()
		{
			return (TickerMode[])JNIEnv.GetArray(TickerMode._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlinx/coroutines/channels/TickerMode;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(TickerMode));
		}

		// Token: 0x0400037E RID: 894
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/TickerMode", typeof(TickerMode));
	}
}
