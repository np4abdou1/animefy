using System;

namespace System.Linq.Expressions
{
	/// <summary>Used to represent the target of a <see cref="T:System.Linq.Expressions.GotoExpression" />.</summary>
	// Token: 0x0200009A RID: 154
	public sealed class LabelTarget
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x00012864 File Offset: 0x00010A64
		internal LabelTarget(Type type, string name)
		{
			this.Type = type;
			this.Name = name;
		}

		/// <summary>Gets the name of the label.</summary>
		/// <returns>The name of the label.</returns>
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0001287A File Offset: 0x00010A7A
		public string Name { get; }

		/// <summary>The type of value that is passed when jumping to the label (or <see cref="T:System.Void" /> if no value should be passed).</summary>
		/// <returns>The <see cref="T:System.Type" /> object representing the type of the value that is passed when jumping to the label or <see cref="T:System.Void" /> if no value should be passed</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00012882 File Offset: 0x00010A82
		public Type Type { get; }

		/// <summary>Returns a <see cref="T:System.String" /> that represents the current <see cref="T:System.Object" />.</summary>
		/// <returns>A <see cref="T:System.String" /> that represents the current <see cref="T:System.Object" />.</returns>
		// Token: 0x060004E4 RID: 1252 RVA: 0x0001288A File Offset: 0x00010A8A
		public override string ToString()
		{
			if (!string.IsNullOrEmpty(this.Name))
			{
				return this.Name;
			}
			return "UnamedLabel";
		}
	}
}
