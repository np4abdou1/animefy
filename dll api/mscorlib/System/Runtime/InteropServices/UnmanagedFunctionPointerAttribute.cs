using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Controls the marshaling behavior of a delegate signature passed as an unmanaged function pointer to or from unmanaged code. This class cannot be inherited. </summary>
	// Token: 0x02000403 RID: 1027
	[AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[ComVisible(true)]
	public sealed class UnmanagedFunctionPointerAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute" /> class with the specified calling convention. </summary>
		/// <param name="callingConvention">The specified calling convention.</param>
		// Token: 0x06001F3F RID: 7999 RVA: 0x000866C3 File Offset: 0x000848C3
		public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
		{
			this.m_callingConvention = callingConvention;
		}

		// Token: 0x04000E89 RID: 3721
		private CallingConvention m_callingConvention;
	}
}
