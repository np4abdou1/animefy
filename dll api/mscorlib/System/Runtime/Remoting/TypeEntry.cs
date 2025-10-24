using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Implements a base class that holds the configuration information used to activate an instance of a remote type.</summary>
	// Token: 0x02000319 RID: 793
	[ComVisible(true)]
	public class TypeEntry
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.TypeEntry" /> class.</summary>
		// Token: 0x06001A18 RID: 6680 RVA: 0x00003ACD File Offset: 0x00001CCD
		protected TypeEntry()
		{
		}

		/// <summary>Gets the assembly name of the object type configured to be a remote-activated type.</summary>
		/// <returns>The assembly name of the object type configured to be a remote-activated type.</returns>
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00071F6E File Offset: 0x0007016E
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00071F76 File Offset: 0x00070176
		public string AssemblyName
		{
			get
			{
				return this.assembly_name;
			}
			set
			{
				this.assembly_name = value;
			}
		}

		/// <summary>Gets the full type name of the object type configured to be a remote-activated type.</summary>
		/// <returns>The full type name of the object type configured to be a remote-activated type.</returns>
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00071F7F File Offset: 0x0007017F
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x00071F87 File Offset: 0x00070187
		public string TypeName
		{
			get
			{
				return this.type_name;
			}
			set
			{
				this.type_name = value;
			}
		}

		// Token: 0x04000ADF RID: 2783
		private string assembly_name;

		// Token: 0x04000AE0 RID: 2784
		private string type_name;
	}
}
