using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when you try to return a version of a <see cref="T:System.Data.DataRow" /> that has been deleted.</summary>
	// Token: 0x02000023 RID: 35
	[Serializable]
	public class VersionNotFoundException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.VersionNotFoundException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x0600016A RID: 362 RVA: 0x00007060 File Offset: 0x00005260
		protected VersionNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.VersionNotFoundException" /> class.</summary>
		// Token: 0x0600016B RID: 363 RVA: 0x000071F6 File Offset: 0x000053F6
		public VersionNotFoundException() : base("Version not found.")
		{
			base.HResult = -2146232023;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.VersionNotFoundException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x0600016C RID: 364 RVA: 0x0000720E File Offset: 0x0000540E
		public VersionNotFoundException(string s) : base(s)
		{
			base.HResult = -2146232023;
		}
	}
}
