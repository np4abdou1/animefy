using System;

namespace System
{
	/// <summary>Represents a method that converts an object from one type to another type.</summary>
	/// <param name="input">The object to convert.</param>
	/// <typeparam name="TInput">The type of object that is to be converted.</typeparam>
	/// <typeparam name="TOutput">The type the input object is to be converted to.</typeparam>
	/// <returns>The <paramref name="TOutput" /> that represents the converted <paramref name="TInput" />.</returns>
	// Token: 0x02000074 RID: 116
	// (Invoke) Token: 0x06000265 RID: 613
	public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
}
