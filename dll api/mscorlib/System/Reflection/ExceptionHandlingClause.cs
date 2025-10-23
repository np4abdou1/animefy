using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Represents a clause in a structured exception-handling block.</summary>
	// Token: 0x020004D3 RID: 1235
	[ComVisible(true)]
	[StructLayout(0)]
	public class ExceptionHandlingClause
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.ExceptionHandlingClause" /> class.</summary>
		// Token: 0x060022FF RID: 8959 RVA: 0x00003ACD File Offset: 0x00001CCD
		protected ExceptionHandlingClause()
		{
		}

		/// <summary>A string representation of the exception-handling clause.</summary>
		/// <returns>A string that lists appropriate property values for the filter clause type.</returns>
		// Token: 0x06002300 RID: 8960 RVA: 0x0008CDF0 File Offset: 0x0008AFF0
		public override string ToString()
		{
			string text = string.Format("Flags={0}, TryOffset={1}, TryLength={2}, HandlerOffset={3}, HandlerLength={4}", new object[]
			{
				this.flags,
				this.try_offset,
				this.try_length,
				this.handler_offset,
				this.handler_length
			});
			if (this.catch_type != null)
			{
				text = string.Format("{0}, CatchType={1}", text, this.catch_type);
			}
			if (this.flags == ExceptionHandlingClauseOptions.Filter)
			{
				text = string.Format("{0}, FilterOffset={1}", text, this.filter_offset);
			}
			return text;
		}

		// Token: 0x0400110C RID: 4364
		internal Type catch_type;

		// Token: 0x0400110D RID: 4365
		internal int filter_offset;

		// Token: 0x0400110E RID: 4366
		internal ExceptionHandlingClauseOptions flags;

		// Token: 0x0400110F RID: 4367
		internal int try_offset;

		// Token: 0x04001110 RID: 4368
		internal int try_length;

		// Token: 0x04001111 RID: 4369
		internal int handler_offset;

		// Token: 0x04001112 RID: 4370
		internal int handler_length;
	}
}
