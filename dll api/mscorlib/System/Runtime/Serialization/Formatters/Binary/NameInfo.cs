using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F5 RID: 1013
	internal sealed class NameInfo
	{
		// Token: 0x06001F13 RID: 7955 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal NameInfo()
		{
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00085FE4 File Offset: 0x000841E4
		internal void Init()
		{
			this.NIFullName = null;
			this.NIobjectId = 0L;
			this.NIassemId = 0L;
			this.NIprimitiveTypeEnum = InternalPrimitiveTypeE.Invalid;
			this.NItype = null;
			this.NIisSealed = false;
			this.NItransmitTypeOnObject = false;
			this.NItransmitTypeOnMember = false;
			this.NIisParentTypeOnObject = false;
			this.NIisArray = false;
			this.NIisArrayItem = false;
			this.NIarrayEnum = InternalArrayTypeE.Empty;
			this.NIsealedStatusChecked = false;
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0008604E File Offset: 0x0008424E
		public bool IsSealed
		{
			get
			{
				if (!this.NIsealedStatusChecked)
				{
					this.NIisSealed = this.NItype.IsSealed;
					this.NIsealedStatusChecked = true;
				}
				return this.NIisSealed;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00086076 File Offset: 0x00084276
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00086097 File Offset: 0x00084297
		public string NIname
		{
			get
			{
				if (this.NIFullName == null)
				{
					this.NIFullName = this.NItype.FullName;
				}
				return this.NIFullName;
			}
			set
			{
				this.NIFullName = value;
			}
		}

		// Token: 0x04000E54 RID: 3668
		internal string NIFullName;

		// Token: 0x04000E55 RID: 3669
		internal long NIobjectId;

		// Token: 0x04000E56 RID: 3670
		internal long NIassemId;

		// Token: 0x04000E57 RID: 3671
		internal InternalPrimitiveTypeE NIprimitiveTypeEnum;

		// Token: 0x04000E58 RID: 3672
		internal Type NItype;

		// Token: 0x04000E59 RID: 3673
		internal bool NIisSealed;

		// Token: 0x04000E5A RID: 3674
		internal bool NIisArray;

		// Token: 0x04000E5B RID: 3675
		internal bool NIisArrayItem;

		// Token: 0x04000E5C RID: 3676
		internal bool NItransmitTypeOnObject;

		// Token: 0x04000E5D RID: 3677
		internal bool NItransmitTypeOnMember;

		// Token: 0x04000E5E RID: 3678
		internal bool NIisParentTypeOnObject;

		// Token: 0x04000E5F RID: 3679
		internal InternalArrayTypeE NIarrayEnum;

		// Token: 0x04000E60 RID: 3680
		private bool NIsealedStatusChecked;
	}
}
