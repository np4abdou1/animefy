using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x0200022B RID: 555
	[Register("com/unity3d/services/ads/adunit/AdUnitMotionEvent", DoNotGenerateAcw = true)]
	public class AdUnitMotionEvent : Java.Lang.Object
	{
		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0004D930 File Offset: 0x0004BB30
		internal static IntPtr class_ref
		{
			get
			{
				return AdUnitMotionEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0004D954 File Offset: 0x0004BB54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitMotionEvent._members;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0004D95C File Offset: 0x0004BB5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitMotionEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x0004D980 File Offset: 0x0004BB80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitMotionEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdUnitMotionEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0004D98C File Offset: 0x0004BB8C
		[Register(".ctor", "(IZIIIFFJFF)V", "")]
		public unsafe AdUnitMotionEvent(int action, bool isObscured, int toolType, int source, int deviceId, float x, float y, long eventTime, float pressure, float size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(action);
			ptr[1] = new JniArgumentValue(isObscured);
			ptr[2] = new JniArgumentValue(toolType);
			ptr[3] = new JniArgumentValue(source);
			ptr[4] = new JniArgumentValue(deviceId);
			ptr[5] = new JniArgumentValue(x);
			ptr[6] = new JniArgumentValue(y);
			ptr[7] = new JniArgumentValue(eventTime);
			ptr[8] = new JniArgumentValue(pressure);
			ptr[9] = new JniArgumentValue(size);
			base.SetHandle(AdUnitMotionEvent._members.InstanceMethods.StartCreateInstance("(IZIIIFFJFF)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			AdUnitMotionEvent._members.InstanceMethods.FinishCreateInstance("(IZIIIFFJFF)V", this, ptr);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0004DADC File Offset: 0x0004BCDC
		private static Delegate GetGetActionHandler()
		{
			if (AdUnitMotionEvent.cb_getAction == null)
			{
				AdUnitMotionEvent.cb_getAction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdUnitMotionEvent.n_GetAction));
			}
			return AdUnitMotionEvent.cb_getAction;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0004DB00 File Offset: 0x0004BD00
		private static int n_GetAction(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Action;
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0004DB0F File Offset: 0x0004BD0F
		public virtual int Action
		{
			[Register("getAction", "()I", "GetGetActionHandler")]
			get
			{
				return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualInt32Method("getAction.()I", this, null);
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0004DB28 File Offset: 0x0004BD28
		private static Delegate GetGetDeviceIdHandler()
		{
			if (AdUnitMotionEvent.cb_getDeviceId == null)
			{
				AdUnitMotionEvent.cb_getDeviceId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdUnitMotionEvent.n_GetDeviceId));
			}
			return AdUnitMotionEvent.cb_getDeviceId;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0004DB4C File Offset: 0x0004BD4C
		private static int n_GetDeviceId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceId;
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0004DB5B File Offset: 0x0004BD5B
		public virtual int DeviceId
		{
			[Register("getDeviceId", "()I", "GetGetDeviceIdHandler")]
			get
			{
				return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualInt32Method("getDeviceId.()I", this, null);
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0004DB74 File Offset: 0x0004BD74
		private static Delegate GetGetEventTimeHandler()
		{
			if (AdUnitMotionEvent.cb_getEventTime == null)
			{
				AdUnitMotionEvent.cb_getEventTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AdUnitMotionEvent.n_GetEventTime));
			}
			return AdUnitMotionEvent.cb_getEventTime;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0004DB98 File Offset: 0x0004BD98
		private static long n_GetEventTime(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EventTime;
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0004DBA7 File Offset: 0x0004BDA7
		public virtual long EventTime
		{
			[Register("getEventTime", "()J", "GetGetEventTimeHandler")]
			get
			{
				return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualInt64Method("getEventTime.()J", this, null);
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0004DBC0 File Offset: 0x0004BDC0
		private static Delegate GetIsObscuredHandler()
		{
			if (AdUnitMotionEvent.cb_isObscured == null)
			{
				AdUnitMotionEvent.cb_isObscured = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdUnitMotionEvent.n_IsObscured));
			}
			return AdUnitMotionEvent.cb_isObscured;
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0004DBE4 File Offset: 0x0004BDE4
		private static bool n_IsObscured(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsObscured;
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x0004DBF3 File Offset: 0x0004BDF3
		public virtual bool IsObscured
		{
			[Register("isObscured", "()Z", "GetIsObscuredHandler")]
			get
			{
				return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualBooleanMethod("isObscured.()Z", this, null);
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0004DC0C File Offset: 0x0004BE0C
		private static Delegate GetGetPressureHandler()
		{
			if (AdUnitMotionEvent.cb_getPressure == null)
			{
				AdUnitMotionEvent.cb_getPressure = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(AdUnitMotionEvent.n_GetPressure));
			}
			return AdUnitMotionEvent.cb_getPressure;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0004DC30 File Offset: 0x0004BE30
		private static float n_GetPressure(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pressure;
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0004DC3F File Offset: 0x0004BE3F
		public virtual float Pressure
		{
			[Register("getPressure", "()F", "GetGetPressureHandler")]
			get
			{
				return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualSingleMethod("getPressure.()F", this, null);
			}
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0004DC58 File Offset: 0x0004BE58
		private static Delegate GetGetSizeHandler()
		{
			if (AdUnitMotionEvent.cb_getSize == null)
			{
				AdUnitMotionEvent.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(AdUnitMotionEvent.n_GetSize));
			}
			return AdUnitMotionEvent.cb_getSize;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0004DC7C File Offset: 0x0004BE7C
		private static float n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0004DC8B File Offset: 0x0004BE8B
		public virtual float Size
		{
			[Register("getSize", "()F", "GetGetSizeHandler")]
			get
			{
				return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualSingleMethod("getSize.()F", this, null);
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0004DCA4 File Offset: 0x0004BEA4
		private static Delegate GetGetSourceHandler()
		{
			if (AdUnitMotionEvent.cb_getSource == null)
			{
				AdUnitMotionEvent.cb_getSource = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdUnitMotionEvent.n_GetSource));
			}
			return AdUnitMotionEvent.cb_getSource;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
		private static int n_GetSource(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Source;
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0004DCD7 File Offset: 0x0004BED7
		public virtual int Source
		{
			[Register("getSource", "()I", "GetGetSourceHandler")]
			get
			{
				return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualInt32Method("getSource.()I", this, null);
			}
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0004DCF0 File Offset: 0x0004BEF0
		private static Delegate GetGetToolTypeHandler()
		{
			if (AdUnitMotionEvent.cb_getToolType == null)
			{
				AdUnitMotionEvent.cb_getToolType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdUnitMotionEvent.n_GetToolType));
			}
			return AdUnitMotionEvent.cb_getToolType;
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0004DD14 File Offset: 0x0004BF14
		private static int n_GetToolType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToolType;
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0004DD23 File Offset: 0x0004BF23
		public virtual int ToolType
		{
			[Register("getToolType", "()I", "GetGetToolTypeHandler")]
			get
			{
				return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualInt32Method("getToolType.()I", this, null);
			}
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0004DD3C File Offset: 0x0004BF3C
		private static Delegate GetGetXHandler()
		{
			if (AdUnitMotionEvent.cb_getX == null)
			{
				AdUnitMotionEvent.cb_getX = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(AdUnitMotionEvent.n_GetX));
			}
			return AdUnitMotionEvent.cb_getX;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0004DD60 File Offset: 0x0004BF60
		private static float n_GetX(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetX();
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0004DD6F File Offset: 0x0004BF6F
		[Register("getX", "()F", "GetGetXHandler")]
		public virtual float GetX()
		{
			return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualSingleMethod("getX.()F", this, null);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0004DD88 File Offset: 0x0004BF88
		private static Delegate GetGetYHandler()
		{
			if (AdUnitMotionEvent.cb_getY == null)
			{
				AdUnitMotionEvent.cb_getY = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(AdUnitMotionEvent.n_GetY));
			}
			return AdUnitMotionEvent.cb_getY;
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0004DDAC File Offset: 0x0004BFAC
		private static float n_GetY(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitMotionEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetY();
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0004DDBB File Offset: 0x0004BFBB
		[Register("getY", "()F", "GetGetYHandler")]
		public virtual float GetY()
		{
			return AdUnitMotionEvent._members.InstanceMethods.InvokeVirtualSingleMethod("getY.()F", this, null);
		}

		// Token: 0x04000676 RID: 1654
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitMotionEvent", typeof(AdUnitMotionEvent));

		// Token: 0x04000677 RID: 1655
		private static Delegate cb_getAction;

		// Token: 0x04000678 RID: 1656
		private static Delegate cb_getDeviceId;

		// Token: 0x04000679 RID: 1657
		private static Delegate cb_getEventTime;

		// Token: 0x0400067A RID: 1658
		private static Delegate cb_isObscured;

		// Token: 0x0400067B RID: 1659
		private static Delegate cb_getPressure;

		// Token: 0x0400067C RID: 1660
		private static Delegate cb_getSize;

		// Token: 0x0400067D RID: 1661
		private static Delegate cb_getSource;

		// Token: 0x0400067E RID: 1662
		private static Delegate cb_getToolType;

		// Token: 0x0400067F RID: 1663
		private static Delegate cb_getX;

		// Token: 0x04000680 RID: 1664
		private static Delegate cb_getY;
	}
}
