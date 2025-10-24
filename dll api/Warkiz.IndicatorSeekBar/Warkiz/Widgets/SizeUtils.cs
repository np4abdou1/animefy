using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x0200001B RID: 27
	[Register("com/warkiz/widget/SizeUtils", DoNotGenerateAcw = true)]
	public class SizeUtils : Java.Lang.Object
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00006478 File Offset: 0x00004678
		internal static IntPtr class_ref
		{
			get
			{
				return SizeUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000649C File Offset: 0x0000469C
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SizeUtils._members;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000064A4 File Offset: 0x000046A4
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SizeUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000064C8 File Offset: 0x000046C8
		protected override Type ThresholdType
		{
			get
			{
				return SizeUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002370 File Offset: 0x00000570
		protected SizeUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000064D4 File Offset: 0x000046D4
		[Register(".ctor", "()V", "")]
		public SizeUtils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SizeUtils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SizeUtils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006544 File Offset: 0x00004744
		[Register("dp2px", "(Landroid/content/Context;F)I", "")]
		public unsafe static int Dp2Px(Context context, float dpValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue(dpValue);
			int result = SizeUtils._members.StaticMethods.InvokeInt32Method("dp2px.(Landroid/content/Context;F)I", ptr);
			GC.KeepAlive(context);
			return result;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000065A8 File Offset: 0x000047A8
		[Register("px2sp", "(Landroid/content/Context;F)I", "")]
		public unsafe static int Px2Sp(Context context, float pxValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue(pxValue);
			int result = SizeUtils._members.StaticMethods.InvokeInt32Method("px2sp.(Landroid/content/Context;F)I", ptr);
			GC.KeepAlive(context);
			return result;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000660C File Offset: 0x0000480C
		[Register("sp2px", "(Landroid/content/Context;F)I", "")]
		public unsafe static int Sp2Px(Context context, float spValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue(spValue);
			int result = SizeUtils._members.StaticMethods.InvokeInt32Method("sp2px.(Landroid/content/Context;F)I", ptr);
			GC.KeepAlive(context);
			return result;
		}

		// Token: 0x04000086 RID: 134
		internal static readonly JniPeerMembers _members = new XAPeerMembers("com/warkiz/widget/SizeUtils", typeof(SizeUtils));
	}
}
