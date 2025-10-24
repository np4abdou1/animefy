using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Provides functionality required by all components. </summary>
	// Token: 0x0200029D RID: 669
	[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
	[TypeConverter(typeof(ComponentConverter))]
	[ComVisible(true)]
	public interface IComponent : IDisposable
	{
		/// <summary>Gets or sets the <see cref="T:System.ComponentModel.ISite" /> associated with the <see cref="T:System.ComponentModel.IComponent" />.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISite" /> object associated with the component; or <see langword="null" />, if the component does not have a site.</returns>
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060011A1 RID: 4513
		ISite Site { get; }
	}
}
