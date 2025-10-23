using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views.Animations
{
	// Token: 0x02000184 RID: 388
	[Register("android/view/animation/AnimationUtils", DoNotGenerateAcw = true)]
	public class AnimationUtils : Java.Lang.Object
	{
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00022D84 File Offset: 0x00020F84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnimationUtils._members;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00022D8C File Offset: 0x00020F8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AnimationUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00022DB0 File Offset: 0x00020FB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnimationUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AnimationUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00022DBC File Offset: 0x00020FBC
		public unsafe static Animation LoadAnimation(Context context, int id)
		{
			Animation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(id);
				@object = Java.Lang.Object.GetObject<Animation>(AnimationUtils._members.StaticMethods.InvokeObjectMethod("loadAnimation.(Landroid/content/Context;I)Landroid/view/animation/Animation;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x04000621 RID: 1569
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/animation/AnimationUtils", typeof(AnimationUtils));
	}
}
