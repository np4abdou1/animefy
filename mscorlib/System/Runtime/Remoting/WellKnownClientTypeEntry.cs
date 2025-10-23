using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Holds values for an object type registered on the client as a server-activated type (single call or singleton).</summary>
	// Token: 0x0200031B RID: 795
	[ComVisible(true)]
	public class WellKnownClientTypeEntry : TypeEntry
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> class with the given type, assembly name, and URL.</summary>
		/// <param name="typeName">The type name of the server-activated type. </param>
		/// <param name="assemblyName">The assembly name of the server-activated type. </param>
		/// <param name="objectUrl">The URL of the server-activated type. </param>
		// Token: 0x06001A20 RID: 6688 RVA: 0x000721C8 File Offset: 0x000703C8
		public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
		{
			this.obj_url = objectUrl;
			base.AssemblyName = assemblyName;
			base.TypeName = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly.GetType(typeName);
			if (this.obj_type == null)
			{
				throw new RemotingException("Type not found: " + typeName + ", " + assemblyName);
			}
		}

		/// <summary>Gets or sets the URL of the application to activate the type in.</summary>
		/// <returns>The URL of the application to activate the type in.</returns>
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00072229 File Offset: 0x00070429
		public string ApplicationUrl
		{
			get
			{
				return this.app_url;
			}
		}

		/// <summary>Gets the <see cref="T:System.Type" /> of the server-activated client type.</summary>
		/// <returns>Gets the <see cref="T:System.Type" /> of the server-activated client type.</returns>
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00072231 File Offset: 0x00070431
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		/// <summary>Gets the URL of the server-activated client object.</summary>
		/// <returns>The URL of the server-activated client object.</returns>
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00072239 File Offset: 0x00070439
		public string ObjectUrl
		{
			get
			{
				return this.obj_url;
			}
		}

		/// <summary>Returns the full type name, assembly name, and object URL of the server-activated client type as a <see cref="T:System.String" />.</summary>
		/// <returns>The full type name, assembly name, and object URL of the server-activated client type as a <see cref="T:System.String" />.</returns>
		// Token: 0x06001A24 RID: 6692 RVA: 0x00072241 File Offset: 0x00070441
		public override string ToString()
		{
			if (this.ApplicationUrl != null)
			{
				return base.TypeName + base.AssemblyName + this.ObjectUrl + this.ApplicationUrl;
			}
			return base.TypeName + base.AssemblyName + this.ObjectUrl;
		}

		// Token: 0x04000AE4 RID: 2788
		private Type obj_type;

		// Token: 0x04000AE5 RID: 2789
		private string obj_url;

		// Token: 0x04000AE6 RID: 2790
		private string app_url;
	}
}
