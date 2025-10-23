using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Represents a missing <see cref="T:System.Object" />. This class cannot be inherited.</summary>
	// Token: 0x020004AC RID: 1196
	public sealed class Missing : ISerializable
	{
		// Token: 0x06002169 RID: 8553 RVA: 0x00003ACD File Offset: 0x00001CCD
		private Missing()
		{
		}

		/// <summary>Sets a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the logical context information needed to recreate the sole instance of the <see cref="T:System.Reflection.Missing" /> object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to be populated with serialization information.</param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object representing the destination context of the serialization.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x0600216A RID: 8554 RVA: 0x0002FCDD File Offset: 0x0002DEDD
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Represents the sole instance of the <see cref="T:System.Reflection.Missing" /> class.</summary>
		// Token: 0x0400102B RID: 4139
		public static readonly Missing Value = new Missing();
	}
}
