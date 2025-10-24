using System;
using System.Reflection;

namespace System
{
	/// <summary>Provides data for loader resolution events, such as the <see cref="E:System.AppDomain.TypeResolve" />, <see cref="E:System.AppDomain.ResourceResolve" />, <see cref="E:System.AppDomain.ReflectionOnlyAssemblyResolve" />, and <see cref="E:System.AppDomain.AssemblyResolve" /> events.</summary>
	// Token: 0x020000EF RID: 239
	public class ResolveEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ResolveEventArgs" /> class, specifying the name of the item to resolve.</summary>
		/// <param name="name">The name of an item to resolve. </param>
		// Token: 0x060007FD RID: 2045 RVA: 0x00023FCA File Offset: 0x000221CA
		public ResolveEventArgs(string name)
		{
			this.<Name>k__BackingField = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ResolveEventArgs" /> class, specifying the name of the item to resolve and the assembly whose dependency is being resolved.</summary>
		/// <param name="name">The name of an item to resolve. </param>
		/// <param name="requestingAssembly">The assembly whose dependency is being resolved.</param>
		// Token: 0x060007FE RID: 2046 RVA: 0x00023FD9 File Offset: 0x000221D9
		public ResolveEventArgs(string name, Assembly requestingAssembly)
		{
			this.<Name>k__BackingField = name;
			this.<RequestingAssembly>k__BackingField = requestingAssembly;
		}
	}
}
