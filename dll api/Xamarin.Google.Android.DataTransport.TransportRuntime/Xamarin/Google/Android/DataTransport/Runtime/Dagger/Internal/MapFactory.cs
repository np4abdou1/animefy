using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000EC RID: 236
	[Register("com/google/android/datatransport/runtime/dagger/internal/MapFactory", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public sealed class MapFactory : Java.Lang.Object
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00017488 File Offset: 0x00015688
		internal static IntPtr class_ref
		{
			get
			{
				return MapFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x000174AC File Offset: 0x000156AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MapFactory._members;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000174B4 File Offset: 0x000156B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MapFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x000174D8 File Offset: 0x000156D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MapFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000026C4 File Offset: 0x000008C4
		internal MapFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000174E4 File Offset: 0x000156E4
		[Register("emptyMapProvider", "()Ljavax/inject/Provider;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public static IProvider EmptyMapProvider()
		{
			return Java.Lang.Object.GetObject<IProvider>(MapFactory._members.StaticMethods.InvokeObjectMethod("emptyMapProvider.()Ljavax/inject/Provider;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00017518 File Offset: 0x00015718
		[Register("get", "()Ljava/util/Map;", "")]
		public IDictionary Get()
		{
			return JavaDictionary.FromJniHandle(MapFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000261 RID: 609
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/MapFactory", typeof(MapFactory));
	}
}
