using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x0200013B RID: 315
	[Register("android/view/MotionEvent", DoNotGenerateAcw = true)]
	public sealed class MotionEvent : InputEvent, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0001A623 File Offset: 0x00018823
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MotionEvent._members;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0001A62C File Offset: 0x0001882C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MotionEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0001A650 File Offset: 0x00018850
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MotionEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000150C1 File Offset: 0x000132C1
		internal MotionEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0001A65C File Offset: 0x0001885C
		public unsafe override void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				MotionEvent._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x0400036C RID: 876
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/MotionEvent", typeof(MotionEvent));
	}
}
