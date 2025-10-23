using System;
using System.Reflection;

namespace System
{
	/// <summary>Provides data for the <see cref="E:System.AppDomain.AssemblyLoad" /> event.</summary>
	// Token: 0x0200007F RID: 127
	public class AssemblyLoadEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.AssemblyLoadEventArgs" /> class using the specified <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="loadedAssembly">An instance that represents the currently loaded assembly. </param>
		// Token: 0x060002B9 RID: 697 RVA: 0x0000ED13 File Offset: 0x0000CF13
		public AssemblyLoadEventArgs(Assembly loadedAssembly)
		{
			this.<LoadedAssembly>k__BackingField = loadedAssembly;
		}
	}
}
