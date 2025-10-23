using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Indicates the physical position of fields within the unmanaged representation of a class or structure.</summary>
	// Token: 0x02000416 RID: 1046
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public sealed class FieldOffsetAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.FieldOffsetAttribute" /> class with the offset in the structure to the beginning of the field.</summary>
		/// <param name="offset">The offset in bytes from the beginning of the structure to the beginning of the field. </param>
		// Token: 0x06001F50 RID: 8016 RVA: 0x000868CB File Offset: 0x00084ACB
		public FieldOffsetAttribute(int offset)
		{
			this._val = offset;
		}

		// Token: 0x04000EFF RID: 3839
		internal int _val;
	}
}
