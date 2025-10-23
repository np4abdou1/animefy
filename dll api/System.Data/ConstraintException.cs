using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when attempting an action that violates a constraint.</summary>
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class ConstraintException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ConstraintException" /> class using the specified serialization and stream context.</summary>
		/// <param name="info">The data necessary to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x0600014F RID: 335 RVA: 0x00007060 File Offset: 0x00005260
		protected ConstraintException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ConstraintException" /> class. This is the default constructor.</summary>
		// Token: 0x06000150 RID: 336 RVA: 0x0000706A File Offset: 0x0000526A
		public ConstraintException() : base("Constraint Exception.")
		{
			base.HResult = -2146232022;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ConstraintException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000151 RID: 337 RVA: 0x00007082 File Offset: 0x00005282
		public ConstraintException(string s) : base(s)
		{
			base.HResult = -2146232022;
		}
	}
}
