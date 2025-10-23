using System;

namespace System.Reflection.Emit
{
	/// <summary>Specifies one of two factors that determine the memory alignment of fields when a type is marshaled.</summary>
	// Token: 0x020004E8 RID: 1256
	public enum PackingSize
	{
		/// <summary>The packing size is not specified.</summary>
		// Token: 0x04001171 RID: 4465
		Unspecified,
		/// <summary>The packing size is 1 byte.</summary>
		// Token: 0x04001172 RID: 4466
		Size1,
		/// <summary>The packing size is 2 bytes.</summary>
		// Token: 0x04001173 RID: 4467
		Size2,
		/// <summary>The packing size is 4 bytes.</summary>
		// Token: 0x04001174 RID: 4468
		Size4 = 4,
		/// <summary>The packing size is 8 bytes.</summary>
		// Token: 0x04001175 RID: 4469
		Size8 = 8,
		/// <summary>The packing size is 16 bytes.</summary>
		// Token: 0x04001176 RID: 4470
		Size16 = 16,
		/// <summary>The packing size is 32 bytes.</summary>
		// Token: 0x04001177 RID: 4471
		Size32 = 32,
		/// <summary>The packing size is 64 bytes.</summary>
		// Token: 0x04001178 RID: 4472
		Size64 = 64,
		/// <summary>The packing size is 128 bytes.</summary>
		// Token: 0x04001179 RID: 4473
		Size128 = 128
	}
}
