using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Identifies how to expose an interface to COM.</summary>
	// Token: 0x02000404 RID: 1028
	[ComVisible(true)]
	[Serializable]
	public enum ComInterfaceType
	{
		/// <summary>Indicates that the interface is exposed to COM as a dual interface, which enables both early and late binding. <see cref="F:System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual" /> is the default value.</summary>
		// Token: 0x04000E8B RID: 3723
		InterfaceIsDual,
		/// <summary>Indicates that an interface is exposed to COM as an interface that is derived from IUnknown, which enables only early binding.</summary>
		// Token: 0x04000E8C RID: 3724
		InterfaceIsIUnknown,
		/// <summary>Indicates that an interface is exposed to COM as a dispinterface, which enables late binding only.</summary>
		// Token: 0x04000E8D RID: 3725
		InterfaceIsIDispatch,
		/// <summary>Indicates that an interface is exposed to COM as a Windows Runtime interface. </summary>
		// Token: 0x04000E8E RID: 3726
		[ComVisible(false)]
		InterfaceIsIInspectable
	}
}
