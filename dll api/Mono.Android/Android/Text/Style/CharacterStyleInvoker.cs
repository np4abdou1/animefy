using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Text.Style
{
	// Token: 0x020001C2 RID: 450
	[Register("android/text/style/CharacterStyle", DoNotGenerateAcw = true)]
	internal class CharacterStyleInvoker : CharacterStyle
	{
		// Token: 0x06001033 RID: 4147 RVA: 0x0002A4DE File Offset: 0x000286DE
		public CharacterStyleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0002A4E8 File Offset: 0x000286E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharacterStyleInvoker._members;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0002A4EF File Offset: 0x000286EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharacterStyleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0002A4FC File Offset: 0x000286FC
		public unsafe override void UpdateDrawState(TextPaint tp)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tp == null) ? IntPtr.Zero : tp.Handle);
				CharacterStyleInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("updateDrawState.(Landroid/text/TextPaint;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tp);
			}
		}

		// Token: 0x04000778 RID: 1912
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/CharacterStyle", typeof(CharacterStyleInvoker));
	}
}
