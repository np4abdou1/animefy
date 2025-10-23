using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000A7 RID: 167
	[Register("android/widget/AbsSpinner", DoNotGenerateAcw = true)]
	internal class AbsSpinnerInvoker : AbsSpinner
	{
		// Token: 0x060002DB RID: 731 RVA: 0x000041D2 File Offset: 0x000023D2
		public AbsSpinnerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000041DC File Offset: 0x000023DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbsSpinnerInvoker._members;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060002DD RID: 733 RVA: 0x000041E3 File Offset: 0x000023E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbsSpinnerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000037 RID: 55
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000041F0 File Offset: 0x000023F0
		protected unsafe override Java.Lang.Object RawAdapter
		{
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AbsSpinnerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setAdapter.(Landroid/widget/Adapter;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x04000055 RID: 85
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AbsSpinner", typeof(AbsSpinnerInvoker));
	}
}
