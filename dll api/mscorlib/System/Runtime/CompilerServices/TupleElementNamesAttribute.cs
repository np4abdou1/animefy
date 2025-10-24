using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Indicates that the use of a value tuple on a member is meant to be treated as a tuple with element names. </summary>
	// Token: 0x02000454 RID: 1108
	[CLSCompliant(false)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public sealed class TupleElementNamesAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.TupleElementNamesAttribute" /> class.</summary>
		/// <param name="transformNames">A string array that specifies, in a pre-order depth-first traversal of a type's construction, which value tuple occurrences are meant to carry element names.</param>
		// Token: 0x0600201E RID: 8222 RVA: 0x00087FEF File Offset: 0x000861EF
		public TupleElementNamesAttribute(string[] transformNames)
		{
			if (transformNames == null)
			{
				throw new ArgumentNullException("transformNames");
			}
			this._transformNames = transformNames;
		}

		// Token: 0x04000F49 RID: 3913
		private readonly string[] _transformNames;
	}
}
