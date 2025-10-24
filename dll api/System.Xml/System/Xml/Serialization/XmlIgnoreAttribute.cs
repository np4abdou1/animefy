﻿using System;

namespace System.Xml.Serialization
{
	/// <summary>Instructs the <see cref="M:System.Xml.Serialization.XmlSerializer.Serialize(System.IO.TextWriter,System.Object)" /> method of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> not to serialize the public field or public read/write property value.</summary>
	// Token: 0x020001E9 RID: 489
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlIgnoreAttribute : Attribute
	{
	}
}
