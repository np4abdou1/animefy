using System;
using System.Collections.Generic;
using Java.Interop;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002F8 RID: 760
	public class XAPeerMembers : JniPeerMembers
	{
		// Token: 0x06001E08 RID: 7688 RVA: 0x00051F6C File Offset: 0x0005016C
		public XAPeerMembers(string jniPeerTypeName, Type managedPeerType) : base(jniPeerTypeName, managedPeerType)
		{
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00051F76 File Offset: 0x00050176
		public XAPeerMembers(string jniPeerTypeName, Type managedPeerType, bool isInterface) : base(jniPeerTypeName, managedPeerType, isInterface)
		{
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00051F84 File Offset: 0x00050184
		protected override bool UsesVirtualDispatch(IJavaPeerable value, Type declaringType)
		{
			Type thresholdType = XAPeerMembers.GetThresholdType(value);
			if (thresholdType != null)
			{
				return thresholdType == value.GetType();
			}
			return base.UsesVirtualDispatch(value, declaringType);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00051FB8 File Offset: 0x000501B8
		protected override JniPeerMembers GetPeerMembers(IJavaPeerable value)
		{
			Type thresholdType = XAPeerMembers.GetThresholdType(value);
			if (thresholdType == null || value.JniPeerMembers.ManagedPeerType == thresholdType)
			{
				return base.GetPeerMembers(value);
			}
			string className = TypeManager.GetClassName(XAPeerMembers.GetThresholdClass(value));
			Dictionary<string, JniPeerMembers> legacyPeerMembers = XAPeerMembers.LegacyPeerMembers;
			JniPeerMembers result;
			lock (legacyPeerMembers)
			{
				JniPeerMembers jniPeerMembers;
				if (!XAPeerMembers.LegacyPeerMembers.TryGetValue(className, out jniPeerMembers))
				{
					jniPeerMembers = new XAPeerMembers(className, thresholdType);
					XAPeerMembers.LegacyPeerMembers.Add(className, jniPeerMembers);
				}
				result = jniPeerMembers;
			}
			return result;
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00052054 File Offset: 0x00050254
		private static Type GetThresholdType(IJavaPeerable value)
		{
			Java.Lang.Object @object = value as Java.Lang.Object;
			if (@object != null)
			{
				return @object.GetThresholdType();
			}
			Throwable throwable = value as Throwable;
			if (throwable != null)
			{
				return throwable.GetThresholdType();
			}
			return null;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00052084 File Offset: 0x00050284
		private static IntPtr GetThresholdClass(IJavaPeerable value)
		{
			Java.Lang.Object @object = value as Java.Lang.Object;
			if (@object != null)
			{
				return @object.GetThresholdClass();
			}
			Throwable throwable = value as Throwable;
			if (throwable != null)
			{
				return throwable.GetThresholdClass();
			}
			return IntPtr.Zero;
		}

		// Token: 0x04000C6C RID: 3180
		private static Dictionary<string, JniPeerMembers> LegacyPeerMembers = new Dictionary<string, JniPeerMembers>(StringComparer.Ordinal);
	}
}
