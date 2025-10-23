using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Indicates the type of class interface to be generated for a class exposed to COM, if an interface is generated at all.</summary>
	// Token: 0x02000408 RID: 1032
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	public sealed class ClassInterfaceAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ClassInterfaceAttribute" /> class with the specified <see cref="T:System.Runtime.InteropServices.ClassInterfaceType" /> enumeration member.</summary>
		/// <param name="classInterfaceType">One of the <see cref="T:System.Runtime.InteropServices.ClassInterfaceType" /> values that describes the type of interface that is generated for a class. </param>
		// Token: 0x06001F42 RID: 8002 RVA: 0x000866F0 File Offset: 0x000848F0
		public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
		{
			this._val = classInterfaceType;
		}

		// Token: 0x04000E95 RID: 3733
		internal ClassInterfaceType _val;
	}
}
