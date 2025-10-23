using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000023 RID: 35
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineContextKt", DoNotGenerateAcw = true)]
	public sealed class CoroutineContextKt : Java.Lang.Object
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003120 File Offset: 0x00001320
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineContextKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003144 File Offset: 0x00001344
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineContextKt._members;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000314C File Offset: 0x0000134C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineContextKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003170 File Offset: 0x00001370
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineContextKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000317C File Offset: 0x0000137C
		internal CoroutineContextKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003188 File Offset: 0x00001388
		[Register("getCoroutineName", "(Lkotlin/coroutines/CoroutineContext;)Ljava/lang/String;", "")]
		[return: Nullable(2)]
		public unsafe static string GetCoroutineName(ICoroutineContext obj)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@string = JNIEnv.GetString(CoroutineContextKt._members.StaticMethods.InvokeObjectMethod("getCoroutineName.(Lkotlin/coroutines/CoroutineContext;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @string;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003200 File Offset: 0x00001400
		[Register("newCoroutineContext", "(Lkotlin/coroutines/CoroutineContext;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext NewCoroutineContext(ICoroutineContext obj, ICoroutineContext addedContext)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((addedContext == null) ? IntPtr.Zero : ((Java.Lang.Object)addedContext).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CoroutineContextKt._members.StaticMethods.InvokeObjectMethod("newCoroutineContext.(Lkotlin/coroutines/CoroutineContext;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(addedContext);
			}
			return @object;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000032A4 File Offset: 0x000014A4
		[Register("newCoroutineContext", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext NewCoroutineContext(ICoroutineScope obj, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CoroutineContextKt._members.StaticMethods.InvokeObjectMethod("newCoroutineContext.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0400000F RID: 15
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineContextKt", typeof(CoroutineContextKt));
	}
}
