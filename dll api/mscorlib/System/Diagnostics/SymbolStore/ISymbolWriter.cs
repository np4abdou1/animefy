using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Represents a symbol writer for managed code.</summary>
	// Token: 0x020005C5 RID: 1477
	[ComVisible(true)]
	public interface ISymbolWriter
	{
		/// <summary>Sets the metadata emitter interface to associate with a writer.</summary>
		/// <param name="emitter">The metadata emitter interface. </param>
		/// <param name="filename">The file name for which the debugging symbols are written. Some writers require a file name, and others do not. If a file name is specified for a writer that does not use file names, this parameter is ignored. </param>
		/// <param name="fFullBuild">
		///       <see langword="true" /> indicates that this is a full rebuild; <see langword="false" /> indicates that this is an incremental compilation. </param>
		// Token: 0x06002C53 RID: 11347
		void Initialize(IntPtr emitter, string filename, bool fFullBuild);
	}
}
