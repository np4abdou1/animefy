using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000F9 RID: 249
	[Register("com/unity3d/services/core/lifecycle/LifecycleEvent", DoNotGenerateAcw = true)]
	public sealed class LifecycleEvent : Java.Lang.Enum
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0001C9D8 File Offset: 0x0001ABD8
		[Register("CREATED")]
		public static LifecycleEvent Created
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleEvent._members.StaticFields.GetObjectValue("CREATED.Lcom/unity3d/services/core/lifecycle/LifecycleEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0001CA08 File Offset: 0x0001AC08
		[Register("DESTROYED")]
		public static LifecycleEvent Destroyed
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleEvent._members.StaticFields.GetObjectValue("DESTROYED.Lcom/unity3d/services/core/lifecycle/LifecycleEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0001CA38 File Offset: 0x0001AC38
		[Register("PAUSED")]
		public static LifecycleEvent Paused
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleEvent._members.StaticFields.GetObjectValue("PAUSED.Lcom/unity3d/services/core/lifecycle/LifecycleEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0001CA68 File Offset: 0x0001AC68
		[Register("RESUMED")]
		public static LifecycleEvent Resumed
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleEvent._members.StaticFields.GetObjectValue("RESUMED.Lcom/unity3d/services/core/lifecycle/LifecycleEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0001CA98 File Offset: 0x0001AC98
		[Register("SAVE_INSTANCE_STATE")]
		public static LifecycleEvent SaveInstanceState
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleEvent._members.StaticFields.GetObjectValue("SAVE_INSTANCE_STATE.Lcom/unity3d/services/core/lifecycle/LifecycleEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0001CAC8 File Offset: 0x0001ACC8
		[Register("STARTED")]
		public static LifecycleEvent Started
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleEvent._members.StaticFields.GetObjectValue("STARTED.Lcom/unity3d/services/core/lifecycle/LifecycleEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		[Register("STOPPED")]
		public static LifecycleEvent Stopped
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleEvent._members.StaticFields.GetObjectValue("STOPPED.Lcom/unity3d/services/core/lifecycle/LifecycleEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0001CB28 File Offset: 0x0001AD28
		internal static IntPtr class_ref
		{
			get
			{
				return LifecycleEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0001CB4C File Offset: 0x0001AD4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LifecycleEvent._members;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0001CB54 File Offset: 0x0001AD54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LifecycleEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0001CB78 File Offset: 0x0001AD78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LifecycleEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0000256C File Offset: 0x0000076C
		internal LifecycleEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0001CB84 File Offset: 0x0001AD84
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/lifecycle/LifecycleEvent;", "")]
		public unsafe static LifecycleEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			LifecycleEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/lifecycle/LifecycleEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		[Register("values", "()[Lcom/unity3d/services/core/lifecycle/LifecycleEvent;", "")]
		public static LifecycleEvent[] Values()
		{
			return (LifecycleEvent[])JNIEnv.GetArray(LifecycleEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/lifecycle/LifecycleEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(LifecycleEvent));
		}

		// Token: 0x04000258 RID: 600
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/lifecycle/LifecycleEvent", typeof(LifecycleEvent));
	}
}
