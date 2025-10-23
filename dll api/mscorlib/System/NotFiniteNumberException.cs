using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a floating-point value is positive infinity, negative infinity, or Not-a-Number (NaN).</summary>
	// Token: 0x020000DA RID: 218
	[Serializable]
	public class NotFiniteNumberException : ArithmeticException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.NotFiniteNumberException" /> class.</summary>
		// Token: 0x0600072D RID: 1837 RVA: 0x0001DFD4 File Offset: 0x0001C1D4
		public NotFiniteNumberException() : base("Arg_NotFiniteNumberException = Number encountered was not a finite quantity.")
		{
			this._offendingNumber = 0.0;
			base.HResult = -2146233048;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NotFiniteNumberException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x0600072E RID: 1838 RVA: 0x0001DFFB File Offset: 0x0001C1FB
		protected NotFiniteNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._offendingNumber = (double)info.GetInt32("OffendingNumber");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the invalid number and additional exception information.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is <see langword="null" />. </exception>
		// Token: 0x0600072F RID: 1839 RVA: 0x0001E017 File Offset: 0x0001C217
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("OffendingNumber", this._offendingNumber, typeof(int));
		}

		// Token: 0x04000333 RID: 819
		private double _offendingNumber;
	}
}
