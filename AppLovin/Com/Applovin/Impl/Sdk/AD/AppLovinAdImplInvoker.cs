using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Sdk.AD
{
	// Token: 0x02000152 RID: 338
	[Register("com/applovin/impl/sdk/ad/AppLovinAdImpl", DoNotGenerateAcw = true)]
	internal class AppLovinAdImplInvoker : AppLovinAdImpl
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x0002FB3F File Offset: 0x0002DD3F
		public AppLovinAdImplInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0002FB49 File Offset: 0x0002DD49
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdImplInvoker._members;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0002FB50 File Offset: 0x0002DD50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdImplInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0002FB5C File Offset: 0x0002DD5C
		public override JSONObject OriginalFullResponse
		{
			[Register("getOriginalFullResponse", "()Lorg/json/JSONObject;", "GetGetOriginalFullResponseHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(AppLovinAdImplInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getOriginalFullResponse.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400056F RID: 1391
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/ad/AppLovinAdImpl", typeof(AppLovinAdImplInvoker));
	}
}
