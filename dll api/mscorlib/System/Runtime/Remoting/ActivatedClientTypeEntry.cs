using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
	/// <summary>Holds values for an object type registered on the client end as a type that can be activated on the server.</summary>
	// Token: 0x020002FF RID: 767
	[ComVisible(true)]
	public class ActivatedClientTypeEntry : TypeEntry
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> class with the given type name, assembly name, and application URL.</summary>
		/// <param name="typeName">The type name of the client activated type. </param>
		/// <param name="assemblyName">The assembly name of the client activated type. </param>
		/// <param name="appUrl">The URL of the application to activate the type in. </param>
		// Token: 0x06001952 RID: 6482 RVA: 0x0006E914 File Offset: 0x0006CB14
		public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
		{
			base.AssemblyName = assemblyName;
			base.TypeName = typeName;
			this.applicationUrl = appUrl;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly.GetType(typeName);
			if (this.obj_type == null)
			{
				throw new RemotingException("Type not found: " + typeName + ", " + assemblyName);
			}
		}

		/// <summary>Gets the URL of the application to activate the type in.</summary>
		/// <returns>The URL of the application to activate the type in.</returns>
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x0006E975 File Offset: 0x0006CB75
		public string ApplicationUrl
		{
			get
			{
				return this.applicationUrl;
			}
		}

		/// <summary>Gets or sets the context attributes for the client-activated type.</summary>
		/// <returns>The context attributes for the client activated type.</returns>
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x0002AC82 File Offset: 0x00028E82
		public IContextAttribute[] ContextAttributes
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the <see cref="T:System.Type" /> of the client-activated type.</summary>
		/// <returns>Gets the <see cref="T:System.Type" /> of the client-activated type.</returns>
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x0006E97D File Offset: 0x0006CB7D
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		/// <summary>Returns the type name, assembly name, and application URL of the client-activated type as a <see cref="T:System.String" />.</summary>
		/// <returns>The type name, assembly name, and application URL of the client-activated type as a <see cref="T:System.String" />.</returns>
		// Token: 0x06001956 RID: 6486 RVA: 0x0006E985 File Offset: 0x0006CB85
		public override string ToString()
		{
			return base.TypeName + base.AssemblyName + this.ApplicationUrl;
		}

		// Token: 0x04000A8C RID: 2700
		private string applicationUrl;

		// Token: 0x04000A8D RID: 2701
		private Type obj_type;
	}
}
