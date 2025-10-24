using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Specifies a default interface to expose to COM. This class cannot be inherited.</summary>
	// Token: 0x02000406 RID: 1030
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComDefaultInterfaceAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ComDefaultInterfaceAttribute" /> class with the specified <see cref="T:System.Type" /> object as the default interface exposed to COM.</summary>
		/// <param name="defaultInterface">A <see cref="T:System.Type" /> value indicating the default interface to expose to COM. </param>
		// Token: 0x06001F41 RID: 8001 RVA: 0x000866E1 File Offset: 0x000848E1
		public ComDefaultInterfaceAttribute(Type defaultInterface)
		{
			this._val = defaultInterface;
		}

		// Token: 0x04000E90 RID: 3728
		internal Type _val;
	}
}
