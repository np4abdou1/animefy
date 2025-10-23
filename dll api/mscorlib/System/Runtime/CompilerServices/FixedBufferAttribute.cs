using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Indicates that a field should be treated as containing a fixed number of elements of the specified primitive type. This class cannot be inherited. </summary>
	// Token: 0x02000444 RID: 1092
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class FixedBufferAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.FixedBufferAttribute" /> class. </summary>
		/// <param name="elementType">The type of the elements contained in the buffer.</param>
		/// <param name="length">The number of elements in the buffer.</param>
		// Token: 0x06002005 RID: 8197 RVA: 0x00087EDD File Offset: 0x000860DD
		public FixedBufferAttribute(Type elementType, int length)
		{
			this.<ElementType>k__BackingField = elementType;
			this.<Length>k__BackingField = length;
		}
	}
}
