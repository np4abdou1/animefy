using System;

namespace System.Runtime.Serialization
{
	/// <summary>Provides the connection between an instance of <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the formatter-provided class best suited to parse the data inside the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
	// Token: 0x0200038F RID: 911
	[CLSCompliant(false)]
	public interface IFormatterConverter
	{
		/// <summary>Converts a value to the given <see cref="T:System.Type" />.</summary>
		/// <param name="value">The object to be converted. </param>
		/// <param name="type">The <see cref="T:System.Type" /> into which <paramref name="value" /> is to be converted. </param>
		/// <returns>The converted <paramref name="value" />.</returns>
		// Token: 0x06001C6A RID: 7274
		object Convert(object value, Type type);

		/// <summary>Converts a value to a <see cref="T:System.Boolean" />.</summary>
		/// <param name="value">The object to be converted. </param>
		/// <returns>The converted <paramref name="value" />.</returns>
		// Token: 0x06001C6B RID: 7275
		bool ToBoolean(object value);

		/// <summary>Converts a value to a 32-bit signed integer.</summary>
		/// <param name="value">The object to be converted. </param>
		/// <returns>The converted <paramref name="value" />.</returns>
		// Token: 0x06001C6C RID: 7276
		int ToInt32(object value);

		/// <summary>Converts a value to a 64-bit signed integer.</summary>
		/// <param name="value">The object to be converted. </param>
		/// <returns>The converted <paramref name="value" />.</returns>
		// Token: 0x06001C6D RID: 7277
		long ToInt64(object value);

		/// <summary>Converts a value to a single-precision floating-point number.</summary>
		/// <param name="value">The object to be converted. </param>
		/// <returns>The converted <paramref name="value" />.</returns>
		// Token: 0x06001C6E RID: 7278
		float ToSingle(object value);

		/// <summary>Converts a value to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The object to be converted. </param>
		/// <returns>The converted <paramref name="value" />.</returns>
		// Token: 0x06001C6F RID: 7279
		string ToString(object value);
	}
}
