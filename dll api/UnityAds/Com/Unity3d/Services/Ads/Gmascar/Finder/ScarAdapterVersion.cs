using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Finder
{
	// Token: 0x0200020E RID: 526
	[Register("com/unity3d/services/ads/gmascar/finder/ScarAdapterVersion", DoNotGenerateAcw = true)]
	public sealed class ScarAdapterVersion : Java.Lang.Enum
	{
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00046E0C File Offset: 0x0004500C
		[Register("NA")]
		public static ScarAdapterVersion Na
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdapterVersion>(ScarAdapterVersion._members.StaticFields.GetObjectValue("NA.Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00046E3C File Offset: 0x0004503C
		[Register("V192")]
		public static ScarAdapterVersion V192
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdapterVersion>(ScarAdapterVersion._members.StaticFields.GetObjectValue("V192.Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x00046E6C File Offset: 0x0004506C
		[Register("V195")]
		public static ScarAdapterVersion V195
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdapterVersion>(ScarAdapterVersion._members.StaticFields.GetObjectValue("V195.Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00046E9C File Offset: 0x0004509C
		[Register("V20")]
		public static ScarAdapterVersion V20
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdapterVersion>(ScarAdapterVersion._members.StaticFields.GetObjectValue("V20.Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00046ECC File Offset: 0x000450CC
		[Register("V21")]
		public static ScarAdapterVersion V21
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdapterVersion>(ScarAdapterVersion._members.StaticFields.GetObjectValue("V21.Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00046EFC File Offset: 0x000450FC
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdapterVersion._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00046F20 File Offset: 0x00045120
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdapterVersion._members;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x00046F28 File Offset: 0x00045128
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdapterVersion._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x00046F4C File Offset: 0x0004514C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdapterVersion._members.ManagedPeerType;
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0000256C File Offset: 0x0000076C
		internal ScarAdapterVersion(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00046F58 File Offset: 0x00045158
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", "")]
		public unsafe static ScarAdapterVersion ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ScarAdapterVersion @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ScarAdapterVersion>(ScarAdapterVersion._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00046FC4 File Offset: 0x000451C4
		[Register("values", "()[Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", "")]
		public static ScarAdapterVersion[] Values()
		{
			return (ScarAdapterVersion[])JNIEnv.GetArray(ScarAdapterVersion._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ScarAdapterVersion));
		}

		// Token: 0x040005FB RID: 1531
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/finder/ScarAdapterVersion", typeof(ScarAdapterVersion));
	}
}
