using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200021D RID: 541
	[Register("android/graphics/Color", DoNotGenerateAcw = true)]
	public class ColorObject : Java.Lang.Object
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0003251B File Offset: 0x0003071B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ColorObject._members;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00032524 File Offset: 0x00030724
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ColorObject._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x00032548 File Offset: 0x00030748
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ColorObject._members.ManagedPeerType;
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ColorObject(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00032554 File Offset: 0x00030754
		public unsafe static int ParseColor(string colorString)
		{
			IntPtr intPtr = JNIEnv.NewString(colorString);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ColorObject._members.StaticMethods.InvokeInt32Method("parseColor.(Ljava/lang/String;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x04000895 RID: 2197
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Color", typeof(ColorObject));
	}
}
