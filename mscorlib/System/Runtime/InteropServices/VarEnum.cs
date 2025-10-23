using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Indicates how to marshal the array elements when an array is marshaled from managed to unmanaged code as a <see cref="F:System.Runtime.InteropServices.UnmanagedType.SafeArray" />.</summary>
	// Token: 0x0200040B RID: 1035
	[ComVisible(true)]
	[Serializable]
	public enum VarEnum
	{
		/// <summary>Indicates that a value was not specified.</summary>
		// Token: 0x04000E99 RID: 3737
		VT_EMPTY,
		/// <summary>Indicates a null value, similar to a null value in SQL.</summary>
		// Token: 0x04000E9A RID: 3738
		VT_NULL,
		/// <summary>Indicates a <see langword="short" /> integer.</summary>
		// Token: 0x04000E9B RID: 3739
		VT_I2,
		/// <summary>Indicates a <see langword="long" /> integer.</summary>
		// Token: 0x04000E9C RID: 3740
		VT_I4,
		/// <summary>Indicates a <see langword="float" /> value.</summary>
		// Token: 0x04000E9D RID: 3741
		VT_R4,
		/// <summary>Indicates a <see langword="double" /> value.</summary>
		// Token: 0x04000E9E RID: 3742
		VT_R8,
		/// <summary>Indicates a currency value.</summary>
		// Token: 0x04000E9F RID: 3743
		VT_CY,
		/// <summary>Indicates a DATE value.</summary>
		// Token: 0x04000EA0 RID: 3744
		VT_DATE,
		/// <summary>Indicates a BSTR string.</summary>
		// Token: 0x04000EA1 RID: 3745
		VT_BSTR,
		/// <summary>Indicates an <see langword="IDispatch" /> pointer.</summary>
		// Token: 0x04000EA2 RID: 3746
		VT_DISPATCH,
		/// <summary>Indicates an SCODE.</summary>
		// Token: 0x04000EA3 RID: 3747
		VT_ERROR,
		/// <summary>Indicates a Boolean value.</summary>
		// Token: 0x04000EA4 RID: 3748
		VT_BOOL,
		/// <summary>Indicates a VARIANT <see langword="far" /> pointer.</summary>
		// Token: 0x04000EA5 RID: 3749
		VT_VARIANT,
		/// <summary>Indicates an <see langword="IUnknown" /> pointer.</summary>
		// Token: 0x04000EA6 RID: 3750
		VT_UNKNOWN,
		/// <summary>Indicates a <see langword="decimal" /> value.</summary>
		// Token: 0x04000EA7 RID: 3751
		VT_DECIMAL,
		/// <summary>Indicates a <see langword="char" /> value.</summary>
		// Token: 0x04000EA8 RID: 3752
		VT_I1 = 16,
		/// <summary>Indicates a <see langword="byte" />.</summary>
		// Token: 0x04000EA9 RID: 3753
		VT_UI1,
		/// <summary>Indicates an <see langword="unsigned" /><see langword="short" />.</summary>
		// Token: 0x04000EAA RID: 3754
		VT_UI2,
		/// <summary>Indicates an <see langword="unsigned" /><see langword="long" />.</summary>
		// Token: 0x04000EAB RID: 3755
		VT_UI4,
		/// <summary>Indicates a 64-bit integer.</summary>
		// Token: 0x04000EAC RID: 3756
		VT_I8,
		/// <summary>Indicates an 64-bit unsigned integer.</summary>
		// Token: 0x04000EAD RID: 3757
		VT_UI8,
		/// <summary>Indicates an integer value.</summary>
		// Token: 0x04000EAE RID: 3758
		VT_INT,
		/// <summary>Indicates an <see langword="unsigned" /> integer value.</summary>
		// Token: 0x04000EAF RID: 3759
		VT_UINT,
		/// <summary>Indicates a C style <see langword="void" />.</summary>
		// Token: 0x04000EB0 RID: 3760
		VT_VOID,
		/// <summary>Indicates an HRESULT.</summary>
		// Token: 0x04000EB1 RID: 3761
		VT_HRESULT,
		/// <summary>Indicates a pointer type.</summary>
		// Token: 0x04000EB2 RID: 3762
		VT_PTR,
		/// <summary>Indicates a SAFEARRAY. Not valid in a VARIANT.</summary>
		// Token: 0x04000EB3 RID: 3763
		VT_SAFEARRAY,
		/// <summary>Indicates a C style array.</summary>
		// Token: 0x04000EB4 RID: 3764
		VT_CARRAY,
		/// <summary>Indicates a user defined type.</summary>
		// Token: 0x04000EB5 RID: 3765
		VT_USERDEFINED,
		/// <summary>Indicates a null-terminated string.</summary>
		// Token: 0x04000EB6 RID: 3766
		VT_LPSTR,
		/// <summary>Indicates a wide string terminated by <see langword="null" />.</summary>
		// Token: 0x04000EB7 RID: 3767
		VT_LPWSTR,
		/// <summary>Indicates a user defined type.</summary>
		// Token: 0x04000EB8 RID: 3768
		VT_RECORD = 36,
		/// <summary>Indicates a FILETIME value.</summary>
		// Token: 0x04000EB9 RID: 3769
		VT_FILETIME = 64,
		/// <summary>Indicates length prefixed bytes.</summary>
		// Token: 0x04000EBA RID: 3770
		VT_BLOB,
		/// <summary>Indicates that the name of a stream follows.</summary>
		// Token: 0x04000EBB RID: 3771
		VT_STREAM,
		/// <summary>Indicates that the name of a storage follows.</summary>
		// Token: 0x04000EBC RID: 3772
		VT_STORAGE,
		/// <summary>Indicates that a stream contains an object.</summary>
		// Token: 0x04000EBD RID: 3773
		VT_STREAMED_OBJECT,
		/// <summary>Indicates that a storage contains an object.</summary>
		// Token: 0x04000EBE RID: 3774
		VT_STORED_OBJECT,
		/// <summary>Indicates that a blob contains an object.</summary>
		// Token: 0x04000EBF RID: 3775
		VT_BLOB_OBJECT,
		/// <summary>Indicates the clipboard format.</summary>
		// Token: 0x04000EC0 RID: 3776
		VT_CF,
		/// <summary>Indicates a class ID.</summary>
		// Token: 0x04000EC1 RID: 3777
		VT_CLSID,
		/// <summary>Indicates a simple, counted array.</summary>
		// Token: 0x04000EC2 RID: 3778
		VT_VECTOR = 4096,
		/// <summary>Indicates a <see langword="SAFEARRAY" /> pointer.</summary>
		// Token: 0x04000EC3 RID: 3779
		VT_ARRAY = 8192,
		/// <summary>Indicates that a value is a reference.</summary>
		// Token: 0x04000EC4 RID: 3780
		VT_BYREF = 16384
	}
}
