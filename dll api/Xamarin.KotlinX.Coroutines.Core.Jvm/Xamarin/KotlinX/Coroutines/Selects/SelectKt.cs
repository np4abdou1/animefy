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
	// Token: 0x0200009E RID: 158
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectKt", DoNotGenerateAcw = true)]
	public sealed class SelectKt : Java.Lang.Object
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x000168B4 File Offset: 0x00014AB4
		internal static IntPtr class_ref
		{
			get
			{
				return SelectKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000168D8 File Offset: 0x00014AD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SelectKt._members;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000168E0 File Offset: 0x00014AE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SelectKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00016904 File Offset: 0x00014B04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SelectKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00016910 File Offset: 0x00014B10
		internal SelectKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001691C File Offset: 0x00014B1C
		[Register("select", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Select(IFunction1 builder, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : ((Java.Lang.Object)builder).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SelectKt._members.StaticMethods.InvokeObjectMethod("select.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0400026D RID: 621
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectKt", typeof(SelectKt));
	}
}
