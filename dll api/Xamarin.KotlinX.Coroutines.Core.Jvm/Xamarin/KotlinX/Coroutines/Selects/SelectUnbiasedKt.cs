using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x020000A0 RID: 160
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectUnbiasedKt", DoNotGenerateAcw = true)]
	public sealed class SelectUnbiasedKt : Java.Lang.Object
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00016A60 File Offset: 0x00014C60
		internal static IntPtr class_ref
		{
			get
			{
				return SelectUnbiasedKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00016A84 File Offset: 0x00014C84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SelectUnbiasedKt._members;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00016A8C File Offset: 0x00014C8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SelectUnbiasedKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00016AB0 File Offset: 0x00014CB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SelectUnbiasedKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00016ABC File Offset: 0x00014CBC
		internal SelectUnbiasedKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00016AC8 File Offset: 0x00014CC8
		[Register("selectUnbiased", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SelectUnbiased(IFunction1 builder, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : ((Java.Lang.Object)builder).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SelectUnbiasedKt._members.StaticMethods.InvokeObjectMethod("selectUnbiased.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0400026F RID: 623
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectUnbiasedKt", typeof(SelectUnbiasedKt));
	}
}
