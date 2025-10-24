using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Describes the source and destination of a given serialized stream, and provides an additional caller-defined context.</summary>
	// Token: 0x020003B7 RID: 951
	[ComVisible(true)]
	[Serializable]
	public readonly struct StreamingContext
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class with a given context state.</summary>
		/// <param name="state">A bitwise combination of the <see cref="T:System.Runtime.Serialization.StreamingContextStates" /> values that specify the source or destination context for this <see cref="T:System.Runtime.Serialization.StreamingContext" />. </param>
		// Token: 0x06001D77 RID: 7543 RVA: 0x0007C6DA File Offset: 0x0007A8DA
		public StreamingContext(StreamingContextStates state)
		{
			this = new StreamingContext(state, null);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class with a given context state, and some additional information.</summary>
		/// <param name="state">A bitwise combination of the <see cref="T:System.Runtime.Serialization.StreamingContextStates" /> values that specify the source or destination context for this <see cref="T:System.Runtime.Serialization.StreamingContext" />. </param>
		/// <param name="additional">Any additional information to be associated with the <see cref="T:System.Runtime.Serialization.StreamingContext" />. This information is available to any object that implements <see cref="T:System.Runtime.Serialization.ISerializable" /> or any serialization surrogate. Most users do not need to set this parameter. </param>
		// Token: 0x06001D78 RID: 7544 RVA: 0x0007C6E4 File Offset: 0x0007A8E4
		public StreamingContext(StreamingContextStates state, object additional)
		{
			this.m_state = state;
			this.m_additionalContext = additional;
		}

		/// <summary>Gets context specified as part of the additional context.</summary>
		/// <returns>The context specified as part of the additional context.</returns>
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x0007C6F4 File Offset: 0x0007A8F4
		public object Context
		{
			get
			{
				return this.m_additionalContext;
			}
		}

		/// <summary>Determines whether two <see cref="T:System.Runtime.Serialization.StreamingContext" /> instances contain the same values.</summary>
		/// <param name="obj">An object to compare with the current instance. </param>
		/// <returns>
		///     <see langword="true" /> if the specified object is an instance of <see cref="T:System.Runtime.Serialization.StreamingContext" /> and equals the value of the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001D7A RID: 7546 RVA: 0x0007C6FC File Offset: 0x0007A8FC
		public override bool Equals(object obj)
		{
			return obj is StreamingContext && (((StreamingContext)obj).m_additionalContext == this.m_additionalContext && ((StreamingContext)obj).m_state == this.m_state);
		}

		/// <summary>Returns a hash code of this object.</summary>
		/// <returns>The <see cref="T:System.Runtime.Serialization.StreamingContextStates" /> value that contains the source or destination of the serialization for this <see cref="T:System.Runtime.Serialization.StreamingContext" />.</returns>
		// Token: 0x06001D7B RID: 7547 RVA: 0x0007C731 File Offset: 0x0007A931
		public override int GetHashCode()
		{
			return (int)this.m_state;
		}

		/// <summary>Gets the source or destination of the transmitted data.</summary>
		/// <returns>During serialization, the destination of the transmitted data. During deserialization, the source of the data.</returns>
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x0007C731 File Offset: 0x0007A931
		public StreamingContextStates State
		{
			get
			{
				return this.m_state;
			}
		}

		// Token: 0x04000C4F RID: 3151
		internal readonly object m_additionalContext;

		// Token: 0x04000C50 RID: 3152
		internal readonly StreamingContextStates m_state;
	}
}
