using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Represents a label in the instruction stream. <see langword="Label" /> is used in conjunction with the <see cref="T:System.Reflection.Emit.ILGenerator" /> class.</summary>
	// Token: 0x02000509 RID: 1289
	[ComVisible(true)]
	[Serializable]
	public readonly struct Label : IEquatable<Label>
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x000925D9 File Offset: 0x000907D9
		internal Label(int val)
		{
			this.label = val;
		}

		/// <summary>Checks if the given object is an instance of <see langword="Label" /> and is equal to this instance.</summary>
		/// <param name="obj">The object to compare with this <see langword="Label" /> instance. </param>
		/// <returns>Returns <see langword="true" /> if <paramref name="obj" /> is an instance of <see langword="Label" /> and is equal to this object; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600256D RID: 9581 RVA: 0x000925E4 File Offset: 0x000907E4
		public override bool Equals(object obj)
		{
			bool flag = obj is Label;
			if (flag)
			{
				Label label = (Label)obj;
				flag = (this.label == label.label);
			}
			return flag;
		}

		/// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.Label" />.</summary>
		/// <param name="obj">The <see cref="T:System.Reflection.Emit.Label" /> to compare to the current instance.</param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600256E RID: 9582 RVA: 0x00092615 File Offset: 0x00090815
		public bool Equals(Label obj)
		{
			return this.label == obj.label;
		}

		/// <summary>Generates a hash code for this instance.</summary>
		/// <returns>Returns a hash code for this instance.</returns>
		// Token: 0x0600256F RID: 9583 RVA: 0x00092625 File Offset: 0x00090825
		public override int GetHashCode()
		{
			return this.label.GetHashCode();
		}

		// Token: 0x04001259 RID: 4697
		internal readonly int label;
	}
}
