using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Provides information about a <see cref="T:System.Diagnostics.StackFrame" />, which represents a function call on the call stack for the current thread.</summary>
	// Token: 0x020005C1 RID: 1473
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class StackFrame
	{
		// Token: 0x06002C36 RID: 11318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column);

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class.</summary>
		// Token: 0x06002C37 RID: 11319 RVA: 0x000B7538 File Offset: 0x000B5738
		public StackFrame()
		{
			bool flag = StackFrame.get_frame_info(2, false, out this.methodBase, out this.ilOffset, out this.nativeOffset, out this.fileName, out this.lineNumber, out this.columnNumber);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class that corresponds to a frame above the current stack frame, optionally capturing source information.</summary>
		/// <param name="skipFrames">The number of frames up the stack to skip. </param>
		/// <param name="fNeedFileInfo">
		///       <see langword="true" /> to capture the file name, line number, and column number of the stack frame; otherwise, <see langword="false" />. </param>
		// Token: 0x06002C38 RID: 11320 RVA: 0x000B7588 File Offset: 0x000B5788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(int skipFrames, bool fNeedFileInfo)
		{
			bool flag = StackFrame.get_frame_info(skipFrames + 2, fNeedFileInfo, out this.methodBase, out this.ilOffset, out this.nativeOffset, out this.fileName, out this.lineNumber, out this.columnNumber);
		}

		/// <summary>Gets the line number in the file that contains the code that is executing. This information is typically extracted from the debugging symbols for the executable.</summary>
		/// <returns>The file line number, or 0 (zero) if the file line number cannot be determined.</returns>
		// Token: 0x06002C39 RID: 11321 RVA: 0x000B75D7 File Offset: 0x000B57D7
		public virtual int GetFileLineNumber()
		{
			return this.lineNumber;
		}

		/// <summary>Gets the file name that contains the code that is executing. This information is typically extracted from the debugging symbols for the executable.</summary>
		/// <returns>The file name, or <see langword="null" /> if the file name cannot be determined.</returns>
		// Token: 0x06002C3A RID: 11322 RVA: 0x000B75DF File Offset: 0x000B57DF
		public virtual string GetFileName()
		{
			return this.fileName;
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000B75E8 File Offset: 0x000B57E8
		internal string GetSecureFileName()
		{
			string result = "<filename unknown>";
			if (this.fileName == null)
			{
				return result;
			}
			try
			{
				result = this.GetFileName();
			}
			catch (SecurityException)
			{
			}
			return result;
		}

		/// <summary>Gets the offset from the start of the Microsoft intermediate language (MSIL) code for the method that is executing. This offset might be an approximation depending on whether or not the just-in-time (JIT) compiler is generating debugging code. The generation of this debugging information is controlled by the <see cref="T:System.Diagnostics.DebuggableAttribute" />.</summary>
		/// <returns>The offset from the start of the MSIL code for the method that is executing.</returns>
		// Token: 0x06002C3C RID: 11324 RVA: 0x000B7624 File Offset: 0x000B5824
		public virtual int GetILOffset()
		{
			return this.ilOffset;
		}

		/// <summary>Gets the method in which the frame is executing.</summary>
		/// <returns>The method in which the frame is executing.</returns>
		// Token: 0x06002C3D RID: 11325 RVA: 0x000B762C File Offset: 0x000B582C
		public virtual MethodBase GetMethod()
		{
			return this.methodBase;
		}

		/// <summary>Gets the offset from the start of the native just-in-time (JIT)-compiled code for the method that is being executed. The generation of this debugging information is controlled by the <see cref="T:System.Diagnostics.DebuggableAttribute" /> class.</summary>
		/// <returns>The offset from the start of the JIT-compiled code for the method that is being executed.</returns>
		// Token: 0x06002C3E RID: 11326 RVA: 0x000B7634 File Offset: 0x000B5834
		public virtual int GetNativeOffset()
		{
			return this.nativeOffset;
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000B763C File Offset: 0x000B583C
		internal long GetMethodAddress()
		{
			return this.methodAddress;
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000B7644 File Offset: 0x000B5844
		internal uint GetMethodIndex()
		{
			return this.methodIndex;
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000B764C File Offset: 0x000B584C
		internal string GetInternalMethodName()
		{
			return this.internalMethodName;
		}

		/// <summary>Builds a readable representation of the stack trace.</summary>
		/// <returns>A readable representation of the stack trace.</returns>
		// Token: 0x06002C42 RID: 11330 RVA: 0x000B7654 File Offset: 0x000B5854
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.methodBase == null)
			{
				stringBuilder.Append(Locale.GetText("<unknown method>"));
			}
			else
			{
				stringBuilder.Append(this.methodBase.Name);
			}
			stringBuilder.Append(Locale.GetText(" at "));
			if (this.ilOffset == -1)
			{
				stringBuilder.Append(Locale.GetText("<unknown offset>"));
			}
			else
			{
				stringBuilder.Append(Locale.GetText("offset "));
				stringBuilder.Append(this.ilOffset);
			}
			stringBuilder.Append(Locale.GetText(" in file:line:column "));
			stringBuilder.Append(this.GetSecureFileName());
			stringBuilder.AppendFormat(":{0}:{1}", this.lineNumber, this.columnNumber);
			return stringBuilder.ToString();
		}

		/// <summary>Defines the value that is returned from the <see cref="M:System.Diagnostics.StackFrame.GetNativeOffset" /> or <see cref="M:System.Diagnostics.StackFrame.GetILOffset" /> method when the native or Microsoft intermediate language (MSIL) offset is unknown. This field is constant.</summary>
		// Token: 0x04001827 RID: 6183
		public const int OFFSET_UNKNOWN = -1;

		// Token: 0x04001828 RID: 6184
		private int ilOffset = -1;

		// Token: 0x04001829 RID: 6185
		private int nativeOffset = -1;

		// Token: 0x0400182A RID: 6186
		private long methodAddress;

		// Token: 0x0400182B RID: 6187
		private uint methodIndex;

		// Token: 0x0400182C RID: 6188
		private MethodBase methodBase;

		// Token: 0x0400182D RID: 6189
		private string fileName;

		// Token: 0x0400182E RID: 6190
		private int lineNumber;

		// Token: 0x0400182F RID: 6191
		private int columnNumber;

		// Token: 0x04001830 RID: 6192
		private string internalMethodName;
	}
}
