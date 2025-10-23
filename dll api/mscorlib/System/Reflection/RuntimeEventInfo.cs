using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004D7 RID: 1239
	[Serializable]
	[StructLayout(0)]
	internal sealed class RuntimeEventInfo : EventInfo, ISerializable
	{
		// Token: 0x0600231E RID: 8990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info);

		// Token: 0x0600231F RID: 8991 RVA: 0x0008D0D8 File Offset: 0x0008B2D8
		internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev)
		{
			MonoEventInfo result;
			RuntimeEventInfo.get_event_info(ev, out result);
			return result;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x0008D0EE File Offset: 0x0008B2EE
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x0008D0F6 File Offset: 0x0008B2F6
		internal BindingFlags BindingFlags
		{
			get
			{
				return this.GetBindingFlags();
			}
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x0008D0FE File Offset: 0x0008B2FE
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return (RuntimeType)this.DeclaringType;
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x0008D10B File Offset: 0x0008B30B
		private RuntimeType ReflectedTypeInternal
		{
			get
			{
				return (RuntimeType)this.ReflectedType;
			}
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x0008D118 File Offset: 0x0008B318
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0008D125 File Offset: 0x0008B325
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			MemberInfoSerializationHolder.GetSerializationInfo(info, this.Name, this.ReflectedTypeInternal, null, MemberTypes.Event);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x0008D14C File Offset: 0x0008B34C
		internal BindingFlags GetBindingFlags()
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			MethodInfo methodInfo = eventInfo.add_method;
			if (methodInfo == null)
			{
				methodInfo = eventInfo.remove_method;
			}
			if (methodInfo == null)
			{
				methodInfo = eventInfo.raise_method;
			}
			return RuntimeType.FilterPreCalculate(methodInfo != null && methodInfo.IsPublic, this.GetDeclaringTypeInternal() != this.ReflectedType, methodInfo != null && methodInfo.IsStatic);
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0008D1C4 File Offset: 0x0008B3C4
		public override MethodInfo GetAddMethod(bool nonPublic)
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			if (nonPublic || (eventInfo.add_method != null && eventInfo.add_method.IsPublic))
			{
				return eventInfo.add_method;
			}
			return null;
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x0008D200 File Offset: 0x0008B400
		public override MethodInfo GetRaiseMethod(bool nonPublic)
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			if (nonPublic || (eventInfo.raise_method != null && eventInfo.raise_method.IsPublic))
			{
				return eventInfo.raise_method;
			}
			return null;
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x0008D23C File Offset: 0x0008B43C
		public override MethodInfo GetRemoveMethod(bool nonPublic)
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			if (nonPublic || (eventInfo.remove_method != null && eventInfo.remove_method.IsPublic))
			{
				return eventInfo.remove_method;
			}
			return null;
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x0008D276 File Offset: 0x0008B476
		public override Type DeclaringType
		{
			get
			{
				return RuntimeEventInfo.GetEventInfo(this).declaring_type;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x0008D283 File Offset: 0x0008B483
		public override Type ReflectedType
		{
			get
			{
				return RuntimeEventInfo.GetEventInfo(this).reflected_type;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x0008D290 File Offset: 0x0008B490
		public override string Name
		{
			get
			{
				return RuntimeEventInfo.GetEventInfo(this).name;
			}
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0008D29D File Offset: 0x0008B49D
		public override string ToString()
		{
			Type eventHandlerType = this.EventHandlerType;
			return ((eventHandlerType != null) ? eventHandlerType.ToString() : null) + " " + this.Name;
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00032332 File Offset: 0x00030532
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0008D062 File Offset: 0x0008B262
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0008D06B File Offset: 0x0008B26B
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0008D2C1 File Offset: 0x0008B4C1
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return CustomAttributeData.GetCustomAttributes(this);
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x0008D2C9 File Offset: 0x0008B4C9
		public override int MetadataToken
		{
			get
			{
				return RuntimeEventInfo.get_metadata_token(this);
			}
		}

		// Token: 0x06002333 RID: 9011
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimeEventInfo monoEvent);

		// Token: 0x04001128 RID: 4392
		private IntPtr klass;

		// Token: 0x04001129 RID: 4393
		private IntPtr handle;
	}
}
