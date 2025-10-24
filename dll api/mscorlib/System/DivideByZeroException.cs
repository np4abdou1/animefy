using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an attempt to divide an integral or <see cref="T:System.Decimal" /> value by zero.</summary>
	// Token: 0x02000093 RID: 147
	[Serializable]
	public class DivideByZeroException : ArithmeticException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.DivideByZeroException" /> class.</summary>
		// Token: 0x06000505 RID: 1285 RVA: 0x00013632 File Offset: 0x00011832
		public DivideByZeroException() : base("Attempted to divide by zero.")
		{
			base.HResult = -2147352558;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DivideByZeroException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. </param>
		// Token: 0x06000506 RID: 1286 RVA: 0x0001364A File Offset: 0x0001184A
		public DivideByZeroException(string message) : base(message)
		{
			base.HResult = -2147352558;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DivideByZeroException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000507 RID: 1287 RVA: 0x0001365E File Offset: 0x0001185E
		protected DivideByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
