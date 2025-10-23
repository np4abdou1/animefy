﻿using System;

namespace System.Runtime.Serialization
{
	/// <summary>Indicates a serialization surrogate selector class.</summary>
	// Token: 0x02000399 RID: 921
	public interface ISurrogateSelector
	{
		/// <summary>Finds the surrogate that represents the specified object's type, starting with the specified surrogate selector for the specified serialization context.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of object (class) that needs a surrogate. </param>
		/// <param name="context">The source or destination context for the current serialization. </param>
		/// <param name="selector">When this method returns, contains a <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> that holds a reference to the surrogate selector where the appropriate surrogate was found. This parameter is passed uninitialized. </param>
		/// <returns>The appropriate surrogate for the given type in the given context.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06001C94 RID: 7316
		ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
	}
}
