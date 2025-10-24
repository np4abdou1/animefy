using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000030 RID: 48
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/Dispatchers", DoNotGenerateAcw = true)]
	public sealed class Dispatchers : Java.Lang.Object
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00004BE0 File Offset: 0x00002DE0
		[Register("INSTANCE")]
		public static Dispatchers Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<Dispatchers>(Dispatchers._members.StaticFields.GetObjectValue("INSTANCE.Lkotlinx/coroutines/Dispatchers;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00004C10 File Offset: 0x00002E10
		internal static IntPtr class_ref
		{
			get
			{
				return Dispatchers._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004C34 File Offset: 0x00002E34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Dispatchers._members;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00004C3C File Offset: 0x00002E3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Dispatchers._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00004C60 File Offset: 0x00002E60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Dispatchers._members.ManagedPeerType;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004C6C File Offset: 0x00002E6C
		internal Dispatchers(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00004C78 File Offset: 0x00002E78
		public static CoroutineDispatcher Default
		{
			[Register("getDefault", "()Lkotlinx/coroutines/CoroutineDispatcher;", "")]
			get
			{
				return Java.Lang.Object.GetObject<CoroutineDispatcher>(Dispatchers._members.StaticMethods.InvokeObjectMethod("getDefault.()Lkotlinx/coroutines/CoroutineDispatcher;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00004CAC File Offset: 0x00002EAC
		public static CoroutineDispatcher IO
		{
			[Register("getIO", "()Lkotlinx/coroutines/CoroutineDispatcher;", "")]
			get
			{
				return Java.Lang.Object.GetObject<CoroutineDispatcher>(Dispatchers._members.StaticMethods.InvokeObjectMethod("getIO.()Lkotlinx/coroutines/CoroutineDispatcher;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public static MainCoroutineDispatcher Main
		{
			[Register("getMain", "()Lkotlinx/coroutines/MainCoroutineDispatcher;", "")]
			get
			{
				return Java.Lang.Object.GetObject<MainCoroutineDispatcher>(Dispatchers._members.StaticMethods.InvokeObjectMethod("getMain.()Lkotlinx/coroutines/MainCoroutineDispatcher;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00004D14 File Offset: 0x00002F14
		public static CoroutineDispatcher Unconfined
		{
			[Register("getUnconfined", "()Lkotlinx/coroutines/CoroutineDispatcher;", "")]
			get
			{
				return Java.Lang.Object.GetObject<CoroutineDispatcher>(Dispatchers._members.StaticMethods.InvokeObjectMethod("getUnconfined.()Lkotlinx/coroutines/CoroutineDispatcher;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004D45 File Offset: 0x00002F45
		[Register("shutdown", "()V", "")]
		public void Shutdown()
		{
			Dispatchers._members.InstanceMethods.InvokeNonvirtualVoidMethod("shutdown.()V", this, null);
		}

		// Token: 0x04000025 RID: 37
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Dispatchers", typeof(Dispatchers));
	}
}
