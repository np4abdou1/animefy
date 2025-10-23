using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Defines the basic operations of cryptographic transformations.</summary>
	// Token: 0x020002BE RID: 702
	[ComVisible(true)]
	public interface ICryptoTransform : IDisposable
	{
		/// <summary>Gets the input block size.</summary>
		/// <returns>The size of the input data blocks in bytes.</returns>
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600177A RID: 6010
		int InputBlockSize { get; }

		/// <summary>Gets the output block size.</summary>
		/// <returns>The size of the output data blocks in bytes.</returns>
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600177B RID: 6011
		int OutputBlockSize { get; }

		/// <summary>Gets a value indicating whether multiple blocks can be transformed.</summary>
		/// <returns>
		///     <see langword="true" /> if multiple blocks can be transformed; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600177C RID: 6012
		bool CanTransformMultipleBlocks { get; }

		/// <summary>Transforms the specified region of the input byte array and copies the resulting transform to the specified region of the output byte array.</summary>
		/// <param name="inputBuffer">The input for which to compute the transform. </param>
		/// <param name="inputOffset">The offset into the input byte array from which to begin using data. </param>
		/// <param name="inputCount">The number of bytes in the input byte array to use as data. </param>
		/// <param name="outputBuffer">The output to which to write the transform. </param>
		/// <param name="outputOffset">The offset into the output byte array from which to begin writing data. </param>
		/// <returns>The number of bytes written.</returns>
		// Token: 0x0600177D RID: 6013
		int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

		/// <summary>Transforms the specified region of the specified byte array.</summary>
		/// <param name="inputBuffer">The input for which to compute the transform. </param>
		/// <param name="inputOffset">The offset into the byte array from which to begin using data. </param>
		/// <param name="inputCount">The number of bytes in the byte array to use as data. </param>
		/// <returns>The computed transform.</returns>
		// Token: 0x0600177E RID: 6014
		byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
	}
}
