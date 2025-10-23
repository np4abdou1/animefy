using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views.InputMethods
{
	// Token: 0x0200017E RID: 382
	[Register("android/view/inputmethod/InputMethodManager", DoNotGenerateAcw = true)]
	public sealed class InputMethodManager : Java.Lang.Object
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0002290F File Offset: 0x00020B0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InputMethodManager._members;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00022918 File Offset: 0x00020B18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InputMethodManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0002293C File Offset: 0x00020B3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InputMethodManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000021E0 File Offset: 0x000003E0
		internal InputMethodManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00022948 File Offset: 0x00020B48
		public unsafe bool HideSoftInputFromWindow(IBinder windowToken, [GeneratedEnum] HideSoftInputFlags flags)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((windowToken == null) ? IntPtr.Zero : ((Java.Lang.Object)windowToken).Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				result = InputMethodManager._members.InstanceMethods.InvokeAbstractBooleanMethod("hideSoftInputFromWindow.(Landroid/os/IBinder;I)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(windowToken);
			}
			return result;
		}

		// Token: 0x0400060D RID: 1549
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/inputmethod/InputMethodManager", typeof(InputMethodManager));
	}
}
