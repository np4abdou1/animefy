using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Supplies an explicit <see cref="T:System.Guid" /> when an automatic GUID is undesirable.</summary>
	// Token: 0x0200040E RID: 1038
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	public sealed class GuidAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.GuidAttribute" /> class with the specified GUID.</summary>
		/// <param name="guid">The <see cref="T:System.Guid" /> to be assigned. </param>
		// Token: 0x06001F46 RID: 8006 RVA: 0x00086722 File Offset: 0x00084922
		public GuidAttribute(string guid)
		{
			this._val = guid;
		}

		/// <summary>Gets the <see cref="T:System.Guid" /> of the class.</summary>
		/// <returns>The <see cref="T:System.Guid" /> of the class.</returns>
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x00086731 File Offset: 0x00084931
		public string Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04000EEC RID: 3820
		internal string _val;
	}
}
