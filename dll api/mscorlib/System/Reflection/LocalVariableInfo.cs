using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a local variable and provides access to local variable metadata.</summary>
	// Token: 0x020004D4 RID: 1236
	[ComVisible(true)]
	[StructLayout(0)]
	public class LocalVariableInfo
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.LocalVariableInfo" /> class.</summary>
		// Token: 0x06002301 RID: 8961 RVA: 0x00003ACD File Offset: 0x00001CCD
		protected LocalVariableInfo()
		{
		}

		/// <summary>Gets the type of the local variable.</summary>
		/// <returns>The type of the local variable.</returns>
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x0008CE95 File Offset: 0x0008B095
		public virtual Type LocalType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Returns a user-readable string that describes the local variable.</summary>
		/// <returns>A string that displays information about the local variable, including the type name, index, and pinned status.</returns>
		// Token: 0x06002303 RID: 8963 RVA: 0x0008CEA0 File Offset: 0x0008B0A0
		public override string ToString()
		{
			if (this.is_pinned)
			{
				return string.Format("{0} ({1}) (pinned)", this.type, this.position);
			}
			return string.Format("{0} ({1})", this.type, this.position);
		}

		// Token: 0x04001113 RID: 4371
		internal Type type;

		// Token: 0x04001114 RID: 4372
		internal bool is_pinned;

		// Token: 0x04001115 RID: 4373
		internal ushort position;
	}
}
