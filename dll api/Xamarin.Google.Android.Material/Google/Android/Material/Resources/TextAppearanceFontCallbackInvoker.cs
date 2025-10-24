using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace Google.Android.Material.Resources
{
	// Token: 0x02000043 RID: 67
	[Register("com/google/android/material/resources/TextAppearanceFontCallback", DoNotGenerateAcw = true)]
	internal class TextAppearanceFontCallbackInvoker : TextAppearanceFontCallback
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00005E8B File Offset: 0x0000408B
		public TextAppearanceFontCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00005E95 File Offset: 0x00004095
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextAppearanceFontCallbackInvoker._members;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00005E9C File Offset: 0x0000409C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextAppearanceFontCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00005EA8 File Offset: 0x000040A8
		[Register("onFontRetrievalFailed", "(I)V", "GetOnFontRetrievalFailed_IHandler")]
		public unsafe override void OnFontRetrievalFailed(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			TextAppearanceFontCallbackInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onFontRetrievalFailed.(I)V", this, ptr);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00005EE4 File Offset: 0x000040E4
		[Register("onFontRetrieved", "(Landroid/graphics/Typeface;Z)V", "GetOnFontRetrieved_Landroid_graphics_Typeface_ZHandler")]
		public unsafe override void OnFontRetrieved(Typeface p0, bool p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				TextAppearanceFontCallbackInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onFontRetrieved.(Landroid/graphics/Typeface;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000043 RID: 67
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/resources/TextAppearanceFontCallback", typeof(TextAppearanceFontCallbackInvoker));
	}
}
