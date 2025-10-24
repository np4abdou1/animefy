using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F3 RID: 1011
	internal sealed class ValueFixup
	{
		// Token: 0x06001F0F RID: 7951 RVA: 0x00085E85 File Offset: 0x00084085
		internal ValueFixup(Array arrayObj, int[] indexMap)
		{
			this.valueFixupEnum = ValueFixupEnum.Array;
			this.arrayObj = arrayObj;
			this.indexMap = indexMap;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00085EA2 File Offset: 0x000840A2
		internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo)
		{
			this.valueFixupEnum = ValueFixupEnum.Member;
			this.memberObject = memberObject;
			this.memberName = memberName;
			this.objectInfo = objectInfo;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00085EC8 File Offset: 0x000840C8
		[SecurityCritical]
		internal void Fixup(ParseRecord record, ParseRecord parent)
		{
			object prnewObj = record.PRnewObj;
			switch (this.valueFixupEnum)
			{
			case ValueFixupEnum.Array:
				this.arrayObj.SetValue(prnewObj, this.indexMap);
				return;
			case ValueFixupEnum.Header:
			{
				Type typeFromHandle = typeof(Header);
				if (ValueFixup.valueInfo == null)
				{
					MemberInfo[] member = typeFromHandle.GetMember("Value");
					if (member.Length != 1)
					{
						throw new SerializationException(Environment.GetResourceString("Header reflection error: number of value members: {0}.", new object[]
						{
							member.Length
						}));
					}
					ValueFixup.valueInfo = member[0];
				}
				FormatterServices.SerializationSetValue(ValueFixup.valueInfo, this.header, prnewObj);
				return;
			}
			case ValueFixupEnum.Member:
			{
				if (this.objectInfo.isSi)
				{
					this.objectInfo.objectManager.RecordDelayedFixup(parent.PRobjectId, this.memberName, record.PRobjectId);
					return;
				}
				MemberInfo memberInfo = this.objectInfo.GetMemberInfo(this.memberName);
				if (memberInfo != null)
				{
					this.objectInfo.objectManager.RecordFixup(parent.PRobjectId, memberInfo, record.PRobjectId);
				}
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x04000E48 RID: 3656
		internal ValueFixupEnum valueFixupEnum;

		// Token: 0x04000E49 RID: 3657
		internal Array arrayObj;

		// Token: 0x04000E4A RID: 3658
		internal int[] indexMap;

		// Token: 0x04000E4B RID: 3659
		internal object header;

		// Token: 0x04000E4C RID: 3660
		internal object memberObject;

		// Token: 0x04000E4D RID: 3661
		internal static volatile MemberInfo valueInfo;

		// Token: 0x04000E4E RID: 3662
		internal ReadObjectInfo objectInfo;

		// Token: 0x04000E4F RID: 3663
		internal string memberName;
	}
}
