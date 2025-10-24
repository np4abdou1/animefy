using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Holds values for an object type registered on the service end as one that can be activated on request from a client.</summary>
	// Token: 0x02000300 RID: 768
	[ComVisible(true)]
	public class ActivatedServiceTypeEntry : TypeEntry
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> class with the given type name and assembly name.</summary>
		/// <param name="typeName">The type name of the client-activated service type. </param>
		/// <param name="assemblyName">The assembly name of the client-activated service type. </param>
		// Token: 0x06001957 RID: 6487 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
		public ActivatedServiceTypeEntry(string typeName, string assemblyName)
		{
			base.AssemblyName = assemblyName;
			base.TypeName = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly.GetType(typeName);
			if (this.obj_type == null)
			{
				throw new RemotingException("Type not found: " + typeName + ", " + assemblyName);
			}
		}

		/// <summary>Gets the <see cref="T:System.Type" /> of the client-activated service type.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the client-activated service type.</returns>
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x0006E9FA File Offset: 0x0006CBFA
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		/// <summary>Returns the type and assembly name of the client-activated service type as a <see cref="T:System.String" />.</summary>
		/// <returns>The type and assembly name of the client-activated service type as a <see cref="T:System.String" />.</returns>
		// Token: 0x06001959 RID: 6489 RVA: 0x0006EA02 File Offset: 0x0006CC02
		public override string ToString()
		{
			return base.AssemblyName + base.TypeName;
		}

		// Token: 0x04000A8E RID: 2702
		private Type obj_type;
	}
}
