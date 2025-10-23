using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Specifies that a field can be missing from a serialization stream so that the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> and the <see cref="T:System.Runtime.Serialization.Formatters.Soap.SoapFormatter" /> does not throw an exception. </summary>
	// Token: 0x020003B0 RID: 944
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public sealed class OptionalFieldAttribute : Attribute
	{
		/// <summary>This property is unused and is reserved.</summary>
		/// <returns>This property is reserved.</returns>
		// Token: 0x170003C3 RID: 963
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x0007BE37 File Offset: 0x0007A037
		public int VersionAdded
		{
			set
			{
				if (value < 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Version value must be positive."));
				}
				this.versionAdded = value;
			}
		}

		// Token: 0x04000C40 RID: 3136
		private int versionAdded = 1;
	}
}
