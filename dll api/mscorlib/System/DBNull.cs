using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a nonexistent value. This class cannot be inherited.</summary>
	// Token: 0x0200008E RID: 142
	[Serializable]
	public sealed class DBNull : ISerializable, IConvertible
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00003ACD File Offset: 0x00001CCD
		private DBNull()
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00011C00 File Offset: 0x0000FE00
		private DBNull(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException("Only one DBNull instance may exist, and calls to DBNull deserialization methods are not allowed.");
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.DBNull" /> object.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing information required to serialize the <see cref="T:System.DBNull" /> object. </param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.DBNull" /> object. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06000461 RID: 1121 RVA: 0x00011C12 File Offset: 0x0000FE12
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			UnitySerializationHolder.GetUnitySerializationInfo(info, 2);
		}

		/// <summary>Returns an empty string (<see cref="F:System.String.Empty" />).</summary>
		/// <returns>An empty string (<see cref="F:System.String.Empty" />).</returns>
		// Token: 0x06000462 RID: 1122 RVA: 0x00011C1B File Offset: 0x0000FE1B
		public override string ToString()
		{
			return string.Empty;
		}

		/// <summary>Returns an empty string using the specified <see cref="T:System.IFormatProvider" />.</summary>
		/// <param name="provider">The <see cref="T:System.IFormatProvider" /> to be used to format the return value.-or- 
		///       <see langword="null" /> to obtain the format information from the current locale setting of the operating system. </param>
		/// <returns>An empty string (<see cref="F:System.String.Empty" />).</returns>
		// Token: 0x06000463 RID: 1123 RVA: 0x00011C1B File Offset: 0x0000FE1B
		public string ToString(IFormatProvider provider)
		{
			return string.Empty;
		}

		/// <summary>Gets the <see cref="T:System.TypeCode" /> value for <see cref="T:System.DBNull" />.</summary>
		/// <returns>The <see cref="T:System.TypeCode" /> value for <see cref="T:System.DBNull" />, which is <see cref="F:System.TypeCode.DBNull" />.</returns>
		// Token: 0x06000464 RID: 1124 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
		public TypeCode GetTypeCode()
		{
			return TypeCode.DBNull;
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x06000465 RID: 1125 RVA: 0x00011C22 File Offset: 0x0000FE22
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x06000466 RID: 1126 RVA: 0x00011C22 File Offset: 0x0000FE22
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x06000467 RID: 1127 RVA: 0x00011C22 File Offset: 0x0000FE22
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x06000468 RID: 1128 RVA: 0x00011C22 File Offset: 0x0000FE22
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x06000469 RID: 1129 RVA: 0x00011C22 File Offset: 0x0000FE22
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x0600046A RID: 1130 RVA: 0x00011C22 File Offset: 0x0000FE22
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x0600046B RID: 1131 RVA: 0x00011C22 File Offset: 0x0000FE22
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x0600046C RID: 1132 RVA: 0x00011C22 File Offset: 0x0000FE22
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x0600046D RID: 1133 RVA: 0x00011C22 File Offset: 0x0000FE22
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x0600046E RID: 1134 RVA: 0x00011C22 File Offset: 0x0000FE22
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x0600046F RID: 1135 RVA: 0x00011C22 File Offset: 0x0000FE22
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x06000470 RID: 1136 RVA: 0x00011C22 File Offset: 0x0000FE22
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x06000471 RID: 1137 RVA: 0x00011C22 File Offset: 0x0000FE22
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>None. The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		// Token: 0x06000472 RID: 1138 RVA: 0x00011C22 File Offset: 0x0000FE22
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Converts the current <see cref="T:System.DBNull" /> object to the specified type.</summary>
		/// <param name="type">The type to convert the current <see cref="T:System.DBNull" /> object to. </param>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface and is used to augment the conversion. If <see langword="null" /> is specified, format information is obtained from the current culture. </param>
		/// <returns>The boxed equivalent of the current <see cref="T:System.DBNull" /> object, if that conversion is supported; otherwise, an exception is thrown and no value is returned. </returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.</exception>
		// Token: 0x06000473 RID: 1139 RVA: 0x00011C2E File Offset: 0x0000FE2E
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		/// <summary>Represents the sole instance of the <see cref="T:System.DBNull" /> class.</summary>
		// Token: 0x040001E0 RID: 480
		public static readonly DBNull Value = new DBNull();
	}
}
