using System;
using System.Reflection;

namespace System.Runtime.Serialization
{
	// Token: 0x020003A0 RID: 928
	internal sealed class ValueTypeFixupInfo
	{
		// Token: 0x06001CAE RID: 7342 RVA: 0x0007966C File Offset: 0x0007786C
		public ValueTypeFixupInfo(long containerID, FieldInfo member, int[] parentIndex)
		{
			if (member == null && parentIndex == null)
			{
				throw new ArgumentException("When supplying the ID of a containing object, the FieldInfo that identifies the current field within that object must also be supplied.");
			}
			if (containerID == 0L && member == null)
			{
				this._containerID = containerID;
				this._parentField = member;
				this._parentIndex = parentIndex;
			}
			if (member != null)
			{
				if (parentIndex != null)
				{
					throw new ArgumentException("Cannot supply both a MemberInfo and an Array to indicate the parent of a value type.");
				}
				if (member.FieldType.IsValueType && containerID == 0L)
				{
					throw new ArgumentException("When supplying a FieldInfo for fixing up a nested type, a valid ID for that containing object must also be supplied.");
				}
			}
			this._containerID = containerID;
			this._parentField = member;
			this._parentIndex = parentIndex;
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x000796FE File Offset: 0x000778FE
		public long ContainerID
		{
			get
			{
				return this._containerID;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00079706 File Offset: 0x00077906
		public FieldInfo ParentField
		{
			get
			{
				return this._parentField;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0007970E File Offset: 0x0007790E
		public int[] ParentIndex
		{
			get
			{
				return this._parentIndex;
			}
		}

		// Token: 0x04000C05 RID: 3077
		private readonly long _containerID;

		// Token: 0x04000C06 RID: 3078
		private readonly FieldInfo _parentField;

		// Token: 0x04000C07 RID: 3079
		private readonly int[] _parentIndex;
	}
}
