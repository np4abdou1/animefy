using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x02000090 RID: 144
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectBuilder$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class SelectBuilderDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00014EB4 File Offset: 0x000130B4
		internal static IntPtr class_ref
		{
			get
			{
				return SelectBuilderDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00014ED8 File Offset: 0x000130D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SelectBuilderDefaultImpls._members;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00014EE0 File Offset: 0x000130E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SelectBuilderDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00014F04 File Offset: 0x00013104
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SelectBuilderDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00014F10 File Offset: 0x00013110
		internal SelectBuilderDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00014F1C File Offset: 0x0001311C
		[Register("invoke", "(Lkotlinx/coroutines/selects/SelectBuilder;Lkotlinx/coroutines/selects/SelectClause2;Lkotlin/jvm/functions/Function2;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"R",
			"P",
			"Q"
		})]
		public unsafe static void Invoke(ISelectBuilder _this, ISelectClause2 _receiver, IFunction2 block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((_receiver == null) ? IntPtr.Zero : ((Java.Lang.Object)_receiver).Handle);
				ptr[2] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				SelectBuilderDefaultImpls._members.StaticMethods.InvokeVoidMethod("invoke.(Lkotlinx/coroutines/selects/SelectBuilder;Lkotlinx/coroutines/selects/SelectClause2;Lkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(_receiver);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00014FE0 File Offset: 0x000131E0
		[Obsolete("deprecated")]
		[Register("onTimeout", "(Lkotlinx/coroutines/selects/SelectBuilder;JLkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static void OnTimeout(ISelectBuilder _this, long timeMillis, IFunction1 block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(timeMillis);
				ptr[2] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				SelectBuilderDefaultImpls._members.StaticMethods.InvokeVoidMethod("onTimeout.(Lkotlinx/coroutines/selects/SelectBuilder;JLkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x0400022D RID: 557
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectBuilder$DefaultImpls", typeof(SelectBuilderDefaultImpls));
	}
}
