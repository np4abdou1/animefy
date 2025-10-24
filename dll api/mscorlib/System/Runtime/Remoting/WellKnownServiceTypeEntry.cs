using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Holds values for an object type registered on the service end as a server-activated type object (single call or singleton).</summary>
	// Token: 0x0200031D RID: 797
	[ComVisible(true)]
	public class WellKnownServiceTypeEntry : TypeEntry
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> class with the given type name, assembly name, object URI, and <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" />.</summary>
		/// <param name="typeName">The full type name of the server-activated service type. </param>
		/// <param name="assemblyName">The assembly name of the server-activated service type. </param>
		/// <param name="objectUri">The URI of the server-activated object. </param>
		/// <param name="mode">The <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the type, which defines how the object is activated. </param>
		// Token: 0x06001A25 RID: 6693 RVA: 0x00072280 File Offset: 0x00070480
		public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
		{
			base.AssemblyName = assemblyName;
			base.TypeName = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly.GetType(typeName);
			this.obj_uri = objectUri;
			this.obj_mode = mode;
			if (this.obj_type == null)
			{
				throw new RemotingException("Type not found: " + typeName + ", " + assemblyName);
			}
		}

		/// <summary>Gets the <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated service type.</summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated service type.</returns>
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x000722E9 File Offset: 0x000704E9
		public WellKnownObjectMode Mode
		{
			get
			{
				return this.obj_mode;
			}
		}

		/// <summary>Gets the <see cref="T:System.Type" /> of the server-activated service type.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the server-activated service type.</returns>
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x000722F1 File Offset: 0x000704F1
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		/// <summary>Gets the URI of the well-known service type.</summary>
		/// <returns>The URI of the server-activated service type.</returns>
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x000722F9 File Offset: 0x000704F9
		public string ObjectUri
		{
			get
			{
				return this.obj_uri;
			}
		}

		/// <summary>Returns the type name, assembly name, object URI and the <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated type as a <see cref="T:System.String" />.</summary>
		/// <returns>The type name, assembly name, object URI, and the <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated type as a <see cref="T:System.String" />.</returns>
		// Token: 0x06001A29 RID: 6697 RVA: 0x00072301 File Offset: 0x00070501
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				base.TypeName,
				", ",
				base.AssemblyName,
				" ",
				this.ObjectUri
			});
		}

		// Token: 0x04000AEA RID: 2794
		private Type obj_type;

		// Token: 0x04000AEB RID: 2795
		private string obj_uri;

		// Token: 0x04000AEC RID: 2796
		private WellKnownObjectMode obj_mode;
	}
}
