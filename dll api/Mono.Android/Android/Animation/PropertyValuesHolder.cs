using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Animation
{
	// Token: 0x02000254 RID: 596
	[Register("android/animation/PropertyValuesHolder", DoNotGenerateAcw = true)]
	public class PropertyValuesHolder : Java.Lang.Object, Java.Lang.ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0003731D File Offset: 0x0003551D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PropertyValuesHolder._members;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00037324 File Offset: 0x00035524
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PropertyValuesHolder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00037348 File Offset: 0x00035548
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PropertyValuesHolder._members.ManagedPeerType;
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000021E0 File Offset: 0x000003E0
		protected PropertyValuesHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400096A RID: 2410
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/PropertyValuesHolder", typeof(PropertyValuesHolder));
	}
}
