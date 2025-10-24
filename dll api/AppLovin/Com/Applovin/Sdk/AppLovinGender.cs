using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000056 RID: 86
	[Register("com/applovin/sdk/AppLovinGender", DoNotGenerateAcw = true)]
	public sealed class AppLovinGender : Java.Lang.Enum
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00006EA8 File Offset: 0x000050A8
		[Register("FEMALE")]
		public static AppLovinGender Female
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinGender>(AppLovinGender._members.StaticFields.GetObjectValue("FEMALE.Lcom/applovin/sdk/AppLovinGender;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00006ED8 File Offset: 0x000050D8
		[Register("MALE")]
		public static AppLovinGender Male
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinGender>(AppLovinGender._members.StaticFields.GetObjectValue("MALE.Lcom/applovin/sdk/AppLovinGender;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00006F08 File Offset: 0x00005108
		[Register("OTHER")]
		public static AppLovinGender Other
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinGender>(AppLovinGender._members.StaticFields.GetObjectValue("OTHER.Lcom/applovin/sdk/AppLovinGender;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00006F38 File Offset: 0x00005138
		[Register("UNKNOWN")]
		public static AppLovinGender Unknown
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinGender>(AppLovinGender._members.StaticFields.GetObjectValue("UNKNOWN.Lcom/applovin/sdk/AppLovinGender;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00006F68 File Offset: 0x00005168
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinGender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00006F8C File Offset: 0x0000518C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinGender._members;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00006F94 File Offset: 0x00005194
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinGender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00006FB8 File Offset: 0x000051B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinGender._members.ManagedPeerType;
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal AppLovinGender(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00006FC4 File Offset: 0x000051C4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinGender;", "")]
		public unsafe static AppLovinGender ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AppLovinGender @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AppLovinGender>(AppLovinGender._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinGender;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00007030 File Offset: 0x00005230
		[Register("values", "()[Lcom/applovin/sdk/AppLovinGender;", "")]
		public static AppLovinGender[] Values()
		{
			return (AppLovinGender[])JNIEnv.GetArray(AppLovinGender._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/applovin/sdk/AppLovinGender;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AppLovinGender));
		}

		// Token: 0x0400009A RID: 154
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinGender", typeof(AppLovinGender));
	}
}
