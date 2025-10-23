using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Holds a reference to a value.</summary>
	/// <typeparam name="T">The type of the value that the <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> references.</typeparam>
	// Token: 0x0200010E RID: 270
	public class StrongBox<T> : IStrongBox
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> class by using the supplied value. </summary>
		/// <param name="value">A value that the <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> will reference.</param>
		// Token: 0x060008F1 RID: 2289 RVA: 0x00022D02 File Offset: 0x00020F02
		public StrongBox(T value)
		{
			this.Value = value;
		}

		/// <summary>Represents the value that the <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> references.</summary>
		// Token: 0x040002A9 RID: 681
		public T Value;
	}
}
