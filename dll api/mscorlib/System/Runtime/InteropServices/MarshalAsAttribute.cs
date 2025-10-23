using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Indicates how to marshal the data between managed and unmanaged code.</summary>
	// Token: 0x02000424 RID: 1060
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	[StructLayout(0)]
	public sealed class MarshalAsAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.MarshalAsAttribute" /> class with the specified <see cref="T:System.Runtime.InteropServices.UnmanagedType" /> value.</summary>
		/// <param name="unmanagedType">The value the data is to be marshaled as. </param>
		// Token: 0x06001FD2 RID: 8146 RVA: 0x000879B4 File Offset: 0x00085BB4
		public MarshalAsAttribute(short unmanagedType)
		{
			this.utype = (UnmanagedType)unmanagedType;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.MarshalAsAttribute" /> class with the specified <see cref="T:System.Runtime.InteropServices.UnmanagedType" /> enumeration member.</summary>
		/// <param name="unmanagedType">The value the data is to be marshaled as. </param>
		// Token: 0x06001FD3 RID: 8147 RVA: 0x000879B4 File Offset: 0x00085BB4
		public MarshalAsAttribute(UnmanagedType unmanagedType)
		{
			this.utype = unmanagedType;
		}

		/// <summary>Gets the <see cref="T:System.Runtime.InteropServices.UnmanagedType" /> value the data is to be marshaled as.</summary>
		/// <returns>The <see cref="T:System.Runtime.InteropServices.UnmanagedType" /> value the data is to be marshaled as.</returns>
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x000879C3 File Offset: 0x00085BC3
		public UnmanagedType Value
		{
			get
			{
				return this.utype;
			}
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x000879CB File Offset: 0x00085BCB
		internal MarshalAsAttribute Copy()
		{
			return (MarshalAsAttribute)base.MemberwiseClone();
		}

		/// <summary>Provides additional information to a custom marshaler.</summary>
		// Token: 0x04000F1B RID: 3867
		public string MarshalCookie;

		/// <summary>Specifies the fully qualified name of a custom marshaler.</summary>
		// Token: 0x04000F1C RID: 3868
		[ComVisible(true)]
		public string MarshalType;

		/// <summary>Implements <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.MarshalType" /> as a type.</summary>
		// Token: 0x04000F1D RID: 3869
		[ComVisible(true)]
		public Type MarshalTypeRef;

		/// <summary>Indicates the user-defined element type of the <see cref="F:System.Runtime.InteropServices.UnmanagedType.SafeArray" />.</summary>
		// Token: 0x04000F1E RID: 3870
		public Type SafeArrayUserDefinedSubType;

		// Token: 0x04000F1F RID: 3871
		private UnmanagedType utype;

		/// <summary>Specifies the element type of the unmanaged <see cref="F:System.Runtime.InteropServices.UnmanagedType.LPArray" /> or <see cref="F:System.Runtime.InteropServices.UnmanagedType.ByValArray" />.</summary>
		// Token: 0x04000F20 RID: 3872
		public UnmanagedType ArraySubType;

		/// <summary>Indicates the element type of the <see cref="F:System.Runtime.InteropServices.UnmanagedType.SafeArray" />.</summary>
		// Token: 0x04000F21 RID: 3873
		public VarEnum SafeArraySubType;

		/// <summary>Indicates the number of elements in the fixed-length array or the number of characters (not bytes) in a string to import.</summary>
		// Token: 0x04000F22 RID: 3874
		public int SizeConst;

		/// <summary>Specifies the parameter index of the unmanaged <see langword="iid_is" /> attribute used by COM.</summary>
		// Token: 0x04000F23 RID: 3875
		public int IidParameterIndex;

		/// <summary>Indicates the zero-based parameter that contains the count of array elements, similar to <see langword="size_is" /> in COM.</summary>
		// Token: 0x04000F24 RID: 3876
		public short SizeParamIndex;
	}
}
