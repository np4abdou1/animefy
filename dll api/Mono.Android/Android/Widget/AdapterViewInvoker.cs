using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000B1 RID: 177
	[Register("android/widget/AdapterView", DoNotGenerateAcw = true)]
	internal class AdapterViewInvoker : AdapterView
	{
		// Token: 0x06000314 RID: 788 RVA: 0x00004B6A File Offset: 0x00002D6A
		public AdapterViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00004B74 File Offset: 0x00002D74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdapterViewInvoker._members;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00004B7B File Offset: 0x00002D7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdapterViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000045 RID: 69
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00004B88 File Offset: 0x00002D88
		protected unsafe override Java.Lang.Object RawAdapter
		{
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AdapterViewInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setAdapter.(Landroid/widget/Adapter;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00004BEC File Offset: 0x00002DEC
		public unsafe override void SetSelection(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			AdapterViewInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setSelection.(I)V", this, ptr);
		}

		// Token: 0x0400006F RID: 111
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AdapterView", typeof(AdapterViewInvoker));
	}
}
