using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x0200010C RID: 268
	[Register("com/bumptech/glide/load/resource/bitmap/DownsampleStrategy", DoNotGenerateAcw = true)]
	internal class DownsampleStrategyInvoker : DownsampleStrategy
	{
		// Token: 0x06000D7D RID: 3453 RVA: 0x0002AAE4 File Offset: 0x00028CE4
		public DownsampleStrategyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0002AAEE File Offset: 0x00028CEE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DownsampleStrategyInvoker._members;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0002AAF5 File Offset: 0x00028CF5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DownsampleStrategyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0002AB04 File Offset: 0x00028D04
		[Register("getSampleSizeRounding", "(IIII)Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;", "GetGetSampleSizeRounding_IIIIHandler")]
		public unsafe override DownsampleStrategy.SampleSizeRounding GetSampleSizeRounding(int p0, int p1, int p2, int p3)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			ptr[2] = new JniArgumentValue(p2);
			ptr[3] = new JniArgumentValue(p3);
			return Java.Lang.Object.GetObject<DownsampleStrategy.SampleSizeRounding>(DownsampleStrategyInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSampleSizeRounding.(IIII)Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0002AB90 File Offset: 0x00028D90
		[Register("getScaleFactor", "(IIII)F", "GetGetScaleFactor_IIIIHandler")]
		public unsafe override float GetScaleFactor(int p0, int p1, int p2, int p3)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			ptr[2] = new JniArgumentValue(p2);
			ptr[3] = new JniArgumentValue(p3);
			return DownsampleStrategyInvoker._members.InstanceMethods.InvokeAbstractSingleMethod("getScaleFactor.(IIII)F", this, ptr);
		}

		// Token: 0x0400032E RID: 814
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/DownsampleStrategy", typeof(DownsampleStrategyInvoker));
	}
}
