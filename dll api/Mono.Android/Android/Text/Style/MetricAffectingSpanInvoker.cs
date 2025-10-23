using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Text.Style
{
	// Token: 0x020001CB RID: 459
	[Register("android/text/style/MetricAffectingSpan", DoNotGenerateAcw = true)]
	internal class MetricAffectingSpanInvoker : MetricAffectingSpan
	{
		// Token: 0x06001070 RID: 4208 RVA: 0x0002ACEB File Offset: 0x00028EEB
		public MetricAffectingSpanInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0002ACF5 File Offset: 0x00028EF5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetricAffectingSpanInvoker._members;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0002ACFC File Offset: 0x00028EFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetricAffectingSpanInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0002AD08 File Offset: 0x00028F08
		public unsafe override void UpdateDrawState(TextPaint tp)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tp == null) ? IntPtr.Zero : tp.Handle);
				MetricAffectingSpanInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("updateDrawState.(Landroid/text/TextPaint;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tp);
			}
		}

		// Token: 0x04000787 RID: 1927
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/MetricAffectingSpan", typeof(MetricAffectingSpanInvoker));
	}
}
