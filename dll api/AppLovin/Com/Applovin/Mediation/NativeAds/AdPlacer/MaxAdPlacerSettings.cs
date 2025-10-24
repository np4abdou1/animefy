using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.NativeAds.AdPlacer
{
	// Token: 0x020000DD RID: 221
	[Register("com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacerSettings", DoNotGenerateAcw = true)]
	public class MaxAdPlacerSettings : Java.Lang.Object
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00016774 File Offset: 0x00014974
		internal static IntPtr class_ref
		{
			get
			{
				return MaxAdPlacerSettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00016798 File Offset: 0x00014998
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxAdPlacerSettings._members;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x000167A0 File Offset: 0x000149A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxAdPlacerSettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000167C4 File Offset: 0x000149C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxAdPlacerSettings._members.ManagedPeerType;
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxAdPlacerSettings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000167D0 File Offset: 0x000149D0
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MaxAdPlacerSettings(string p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(MaxAdPlacerSettings._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdPlacerSettings._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00016874 File Offset: 0x00014A74
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (MaxAdPlacerSettings.cb_getAdUnitId == null)
			{
				MaxAdPlacerSettings.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdPlacerSettings.n_GetAdUnitId));
			}
			return MaxAdPlacerSettings.cb_getAdUnitId;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00016898 File Offset: 0x00014A98
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x000168AC File Offset: 0x00014AAC
		public virtual string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000168DE File Offset: 0x00014ADE
		private static Delegate GetGetFixedPositionsHandler()
		{
			if (MaxAdPlacerSettings.cb_getFixedPositions == null)
			{
				MaxAdPlacerSettings.cb_getFixedPositions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdPlacerSettings.n_GetFixedPositions));
			}
			return MaxAdPlacerSettings.cb_getFixedPositions;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00016902 File Offset: 0x00014B02
		private static IntPtr n_GetFixedPositions(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<Integer>.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FixedPositions);
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00016918 File Offset: 0x00014B18
		public virtual ICollection<Integer> FixedPositions
		{
			[Register("getFixedPositions", "()Ljava/util/Set;", "GetGetFixedPositionsHandler")]
			get
			{
				return JavaSet<Integer>.FromJniHandle(MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualObjectMethod("getFixedPositions.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0001694A File Offset: 0x00014B4A
		private static Delegate GetHasValidPositioningHandler()
		{
			if (MaxAdPlacerSettings.cb_hasValidPositioning == null)
			{
				MaxAdPlacerSettings.cb_hasValidPositioning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaxAdPlacerSettings.n_HasValidPositioning));
			}
			return MaxAdPlacerSettings.cb_hasValidPositioning;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001696E File Offset: 0x00014B6E
		private static bool n_HasValidPositioning(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasValidPositioning;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0001697D File Offset: 0x00014B7D
		public virtual bool HasValidPositioning
		{
			[Register("hasValidPositioning", "()Z", "GetHasValidPositioningHandler")]
			get
			{
				return MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("hasValidPositioning.()Z", this, null);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00016996 File Offset: 0x00014B96
		private static Delegate GetIsRepeatingEnabledHandler()
		{
			if (MaxAdPlacerSettings.cb_isRepeatingEnabled == null)
			{
				MaxAdPlacerSettings.cb_isRepeatingEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaxAdPlacerSettings.n_IsRepeatingEnabled));
			}
			return MaxAdPlacerSettings.cb_isRepeatingEnabled;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000169BA File Offset: 0x00014BBA
		private static bool n_IsRepeatingEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRepeatingEnabled;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000169C9 File Offset: 0x00014BC9
		public virtual bool IsRepeatingEnabled
		{
			[Register("isRepeatingEnabled", "()Z", "GetIsRepeatingEnabledHandler")]
			get
			{
				return MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isRepeatingEnabled.()Z", this, null);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000169E2 File Offset: 0x00014BE2
		private static Delegate GetGetMaxAdCountHandler()
		{
			if (MaxAdPlacerSettings.cb_getMaxAdCount == null)
			{
				MaxAdPlacerSettings.cb_getMaxAdCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MaxAdPlacerSettings.n_GetMaxAdCount));
			}
			return MaxAdPlacerSettings.cb_getMaxAdCount;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00016A06 File Offset: 0x00014C06
		private static int n_GetMaxAdCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxAdCount;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00016A15 File Offset: 0x00014C15
		private static Delegate GetSetMaxAdCount_IHandler()
		{
			if (MaxAdPlacerSettings.cb_setMaxAdCount_I == null)
			{
				MaxAdPlacerSettings.cb_setMaxAdCount_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaxAdPlacerSettings.n_SetMaxAdCount_I));
			}
			return MaxAdPlacerSettings.cb_setMaxAdCount_I;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00016A39 File Offset: 0x00014C39
		private static void n_SetMaxAdCount_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxAdCount = p0;
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00016A49 File Offset: 0x00014C49
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00016A64 File Offset: 0x00014C64
		public unsafe virtual int MaxAdCount
		{
			[Register("getMaxAdCount", "()I", "GetGetMaxAdCountHandler")]
			get
			{
				return MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualInt32Method("getMaxAdCount.()I", this, null);
			}
			[Register("setMaxAdCount", "(I)V", "GetSetMaxAdCount_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxAdCount.(I)V", this, ptr);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00016A9F File Offset: 0x00014C9F
		private static Delegate GetGetMaxPreloadedAdCountHandler()
		{
			if (MaxAdPlacerSettings.cb_getMaxPreloadedAdCount == null)
			{
				MaxAdPlacerSettings.cb_getMaxPreloadedAdCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MaxAdPlacerSettings.n_GetMaxPreloadedAdCount));
			}
			return MaxAdPlacerSettings.cb_getMaxPreloadedAdCount;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00016AC3 File Offset: 0x00014CC3
		private static int n_GetMaxPreloadedAdCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxPreloadedAdCount;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00016AD2 File Offset: 0x00014CD2
		private static Delegate GetSetMaxPreloadedAdCount_IHandler()
		{
			if (MaxAdPlacerSettings.cb_setMaxPreloadedAdCount_I == null)
			{
				MaxAdPlacerSettings.cb_setMaxPreloadedAdCount_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaxAdPlacerSettings.n_SetMaxPreloadedAdCount_I));
			}
			return MaxAdPlacerSettings.cb_setMaxPreloadedAdCount_I;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00016AF6 File Offset: 0x00014CF6
		private static void n_SetMaxPreloadedAdCount_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxPreloadedAdCount = p0;
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00016B06 File Offset: 0x00014D06
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00016B20 File Offset: 0x00014D20
		public unsafe virtual int MaxPreloadedAdCount
		{
			[Register("getMaxPreloadedAdCount", "()I", "GetGetMaxPreloadedAdCountHandler")]
			get
			{
				return MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualInt32Method("getMaxPreloadedAdCount.()I", this, null);
			}
			[Register("setMaxPreloadedAdCount", "(I)V", "GetSetMaxPreloadedAdCount_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxPreloadedAdCount.(I)V", this, ptr);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00016B5B File Offset: 0x00014D5B
		private static Delegate GetGetRepeatingIntervalHandler()
		{
			if (MaxAdPlacerSettings.cb_getRepeatingInterval == null)
			{
				MaxAdPlacerSettings.cb_getRepeatingInterval = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MaxAdPlacerSettings.n_GetRepeatingInterval));
			}
			return MaxAdPlacerSettings.cb_getRepeatingInterval;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00016B7F File Offset: 0x00014D7F
		private static int n_GetRepeatingInterval(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RepeatingInterval;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00016B8E File Offset: 0x00014D8E
		private static Delegate GetSetRepeatingInterval_IHandler()
		{
			if (MaxAdPlacerSettings.cb_setRepeatingInterval_I == null)
			{
				MaxAdPlacerSettings.cb_setRepeatingInterval_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaxAdPlacerSettings.n_SetRepeatingInterval_I));
			}
			return MaxAdPlacerSettings.cb_setRepeatingInterval_I;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00016BB2 File Offset: 0x00014DB2
		private static void n_SetRepeatingInterval_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RepeatingInterval = p0;
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00016BC2 File Offset: 0x00014DC2
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00016BDC File Offset: 0x00014DDC
		public unsafe virtual int RepeatingInterval
		{
			[Register("getRepeatingInterval", "()I", "GetGetRepeatingIntervalHandler")]
			get
			{
				return MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualInt32Method("getRepeatingInterval.()I", this, null);
			}
			[Register("setRepeatingInterval", "(I)V", "GetSetRepeatingInterval_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setRepeatingInterval.(I)V", this, ptr);
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00016C17 File Offset: 0x00014E17
		private static Delegate GetAddFixedPosition_IHandler()
		{
			if (MaxAdPlacerSettings.cb_addFixedPosition_I == null)
			{
				MaxAdPlacerSettings.cb_addFixedPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaxAdPlacerSettings.n_AddFixedPosition_I));
			}
			return MaxAdPlacerSettings.cb_addFixedPosition_I;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00016C3B File Offset: 0x00014E3B
		private static void n_AddFixedPosition_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddFixedPosition(p0);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00016C4C File Offset: 0x00014E4C
		[Register("addFixedPosition", "(I)V", "GetAddFixedPosition_IHandler")]
		public unsafe virtual void AddFixedPosition(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualVoidMethod("addFixedPosition.(I)V", this, ptr);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00016C87 File Offset: 0x00014E87
		private static Delegate GetResetFixedPositionsHandler()
		{
			if (MaxAdPlacerSettings.cb_resetFixedPositions == null)
			{
				MaxAdPlacerSettings.cb_resetFixedPositions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdPlacerSettings.n_ResetFixedPositions));
			}
			return MaxAdPlacerSettings.cb_resetFixedPositions;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00016CAB File Offset: 0x00014EAB
		private static void n_ResetFixedPositions(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdPlacerSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetFixedPositions();
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00016CBA File Offset: 0x00014EBA
		[Register("resetFixedPositions", "()V", "GetResetFixedPositionsHandler")]
		public virtual void ResetFixedPositions()
		{
			MaxAdPlacerSettings._members.InstanceMethods.InvokeVirtualVoidMethod("resetFixedPositions.()V", this, null);
		}

		// Token: 0x040002D5 RID: 725
		[Register("MIN_REPEATING_INTERVAL")]
		public const int MinRepeatingInterval = 2;

		// Token: 0x040002D6 RID: 726
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacerSettings", typeof(MaxAdPlacerSettings));

		// Token: 0x040002D7 RID: 727
		private static Delegate cb_getAdUnitId;

		// Token: 0x040002D8 RID: 728
		private static Delegate cb_getFixedPositions;

		// Token: 0x040002D9 RID: 729
		private static Delegate cb_hasValidPositioning;

		// Token: 0x040002DA RID: 730
		private static Delegate cb_isRepeatingEnabled;

		// Token: 0x040002DB RID: 731
		private static Delegate cb_getMaxAdCount;

		// Token: 0x040002DC RID: 732
		private static Delegate cb_setMaxAdCount_I;

		// Token: 0x040002DD RID: 733
		private static Delegate cb_getMaxPreloadedAdCount;

		// Token: 0x040002DE RID: 734
		private static Delegate cb_setMaxPreloadedAdCount_I;

		// Token: 0x040002DF RID: 735
		private static Delegate cb_getRepeatingInterval;

		// Token: 0x040002E0 RID: 736
		private static Delegate cb_setRepeatingInterval_I;

		// Token: 0x040002E1 RID: 737
		private static Delegate cb_addFixedPosition_I;

		// Token: 0x040002E2 RID: 738
		private static Delegate cb_resetFixedPositions;
	}
}
