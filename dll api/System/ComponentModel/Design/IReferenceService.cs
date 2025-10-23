using System;

namespace System.ComponentModel.Design
{
	/// <summary>Provides an interface for obtaining references to objects within a project by name or type, obtaining the name of a specified object, and for locating the parent of a specified object within a designer project.</summary>
	// Token: 0x020002BB RID: 699
	public interface IReferenceService
	{
		/// <summary>Gets a reference to the component whose name matches the specified name.</summary>
		/// <param name="name">The name of the component to return a reference to. </param>
		/// <returns>An object the specified name refers to, or <see langword="null" /> if no reference is found.</returns>
		// Token: 0x0600129F RID: 4767
		object GetReference(string name);

		/// <summary>Gets the name of the specified component.</summary>
		/// <param name="reference">The object to return the name of. </param>
		/// <returns>The name of the object referenced, or <see langword="null" /> if the object reference is not valid.</returns>
		// Token: 0x060012A0 RID: 4768
		string GetName(object reference);

		/// <summary>Gets all available references to components of the specified type.</summary>
		/// <param name="baseType">The type of object to return references to instances of. </param>
		/// <returns>An array of all available objects of the specified type.</returns>
		// Token: 0x060012A1 RID: 4769
		object[] GetReferences(Type baseType);
	}
}
