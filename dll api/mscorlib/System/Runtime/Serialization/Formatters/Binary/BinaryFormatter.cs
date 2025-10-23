using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	/// <summary>Serializes and deserializes an object, or an entire graph of connected objects, in binary format.</summary>
	// Token: 0x020003DF RID: 991
	[ComVisible(true)]
	public sealed class BinaryFormatter
	{
		/// <summary>Gets or sets the behavior of the deserializer with regards to finding and loading assemblies.</summary>
		/// <returns>One of the <see cref="T:System.Runtime.Serialization.Formatters.FormatterAssemblyStyle" /> values that specifies the deserializer behavior.</returns>
		// Token: 0x170003D5 RID: 981
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0007EF73 File Offset: 0x0007D173
		public FormatterAssemblyStyle AssemblyFormat
		{
			set
			{
				this.m_assemblyFormat = value;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> that controls type substitution during serialization and deserialization.</summary>
		/// <returns>The surrogate selector to use with this formatter.</returns>
		// Token: 0x170003D6 RID: 982
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x0007EF7C File Offset: 0x0007D17C
		public ISurrogateSelector SurrogateSelector
		{
			set
			{
				this.m_surrogates = value;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> class with default values.</summary>
		// Token: 0x06001DFC RID: 7676 RVA: 0x0007EF85 File Offset: 0x0007D185
		public BinaryFormatter()
		{
			this.m_surrogates = null;
			this.m_context = new StreamingContext(StreamingContextStates.All);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> class with a given surrogate selector and streaming context.</summary>
		/// <param name="selector">The <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> to use. Can be <see langword="null" />. </param>
		/// <param name="context">The source and destination for the serialized data. </param>
		// Token: 0x06001DFD RID: 7677 RVA: 0x0007EFB2 File Offset: 0x0007D1B2
		public BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
		{
			this.m_surrogates = selector;
			this.m_context = context;
		}

		/// <summary>Deserializes the specified stream into an object graph.</summary>
		/// <param name="serializationStream">The stream from which to deserialize the object graph. </param>
		/// <returns>The top (root) of the object graph.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0. 
		///         -or-The target type is a <see cref="T:System.Decimal" />, but the value is out of range of the <see cref="T:System.Decimal" /> type.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06001DFE RID: 7678 RVA: 0x0007EFD6 File Offset: 0x0007D1D6
		public object Deserialize(Stream serializationStream)
		{
			return this.Deserialize(serializationStream, null);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0007EFE0 File Offset: 0x0007D1E0
		[SecurityCritical]
		internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck)
		{
			return this.Deserialize(serializationStream, handler, fCheck, null);
		}

		/// <summary>Deserializes the specified stream into an object graph. The provided <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> handles any headers in that stream.</summary>
		/// <param name="serializationStream">The stream from which to deserialize the object graph. </param>
		/// <param name="handler">The <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> that handles any headers in the <paramref name="serializationStream" />. Can be <see langword="null" />. </param>
		/// <returns>The deserialized object or the top object (root) of the object graph.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0. 
		///         -or-The target type is a <see cref="T:System.Decimal" />, but the value is out of range of the <see cref="T:System.Decimal" /> type.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06001E00 RID: 7680 RVA: 0x0007EFEC File Offset: 0x0007D1EC
		[SecuritySafeCritical]
		public object Deserialize(Stream serializationStream, HeaderHandler handler)
		{
			return this.Deserialize(serializationStream, handler, true);
		}

		/// <summary>Deserializes a response to a remote method call from the provided <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="serializationStream">The stream from which to deserialize the object graph. </param>
		/// <param name="handler">The <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> that handles any headers in the <paramref name="serializationStream" />. Can be <see langword="null" />. </param>
		/// <param name="methodCallMessage">The <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> that contains details about where the call came from. </param>
		/// <returns>The deserialized response to the remote method call.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06001E01 RID: 7681 RVA: 0x0007EFF7 File Offset: 0x0007D1F7
		[SecuritySafeCritical]
		public object DeserializeMethodResponse(Stream serializationStream, HeaderHandler handler, IMethodCallMessage methodCallMessage)
		{
			return this.Deserialize(serializationStream, handler, true, methodCallMessage);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0007F003 File Offset: 0x0007D203
		[SecurityCritical]
		internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck, IMethodCallMessage methodCallMessage)
		{
			return this.Deserialize(serializationStream, handler, fCheck, false, methodCallMessage);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0007F014 File Offset: 0x0007D214
		[SecurityCritical]
		internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck, bool isCrossAppDomain, IMethodCallMessage methodCallMessage)
		{
			if (serializationStream == null)
			{
				throw new ArgumentNullException("serializationStream", Environment.GetResourceString("Parameter '{0}' cannot be null.", new object[]
				{
					serializationStream
				}));
			}
			if (serializationStream.CanSeek && serializationStream.Length == 0L)
			{
				throw new SerializationException(Environment.GetResourceString("Attempting to deserialize an empty stream."));
			}
			InternalFE internalFE = new InternalFE();
			internalFE.FEtypeFormat = this.m_typeFormat;
			internalFE.FEserializerTypeEnum = InternalSerializerTypeE.Binary;
			internalFE.FEassemblyFormat = this.m_assemblyFormat;
			internalFE.FEsecurityLevel = this.m_securityLevel;
			ObjectReader objectReader = new ObjectReader(serializationStream, this.m_surrogates, this.m_context, internalFE, this.m_binder);
			objectReader.crossAppDomainArray = this.m_crossAppDomainArray;
			return objectReader.Deserialize(handler, new __BinaryParser(serializationStream, objectReader), fCheck, isCrossAppDomain, methodCallMessage);
		}

		/// <summary>Serializes the object, or graph of objects with the specified top (root), to the given stream.</summary>
		/// <param name="serializationStream">The stream to which the graph is to be serialized. </param>
		/// <param name="graph">The object at the root of the graph to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />. -or-The <paramref name="graph" /> is null.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">An error has occurred during serialization, such as if an object in the <paramref name="graph" /> parameter is not marked as serializable. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06001E04 RID: 7684 RVA: 0x0007F0CD File Offset: 0x0007D2CD
		public void Serialize(Stream serializationStream, object graph)
		{
			this.Serialize(serializationStream, graph, null);
		}

		/// <summary>Serializes the object, or graph of objects with the specified top (root), to the given stream attaching the provided headers.</summary>
		/// <param name="serializationStream">The stream to which the object is to be serialized. </param>
		/// <param name="graph">The object at the root of the graph to serialize. </param>
		/// <param name="headers">Remoting headers to include in the serialization. Can be <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">An error has occurred during serialization, such as if an object in the <paramref name="graph" /> parameter is not marked as serializable. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06001E05 RID: 7685 RVA: 0x0007F0D8 File Offset: 0x0007D2D8
		[SecuritySafeCritical]
		public void Serialize(Stream serializationStream, object graph, Header[] headers)
		{
			this.Serialize(serializationStream, graph, headers, true);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x0007F0E4 File Offset: 0x0007D2E4
		[SecurityCritical]
		internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck)
		{
			if (serializationStream == null)
			{
				throw new ArgumentNullException("serializationStream", Environment.GetResourceString("Parameter '{0}' cannot be null.", new object[]
				{
					serializationStream
				}));
			}
			InternalFE internalFE = new InternalFE();
			internalFE.FEtypeFormat = this.m_typeFormat;
			internalFE.FEserializerTypeEnum = InternalSerializerTypeE.Binary;
			internalFE.FEassemblyFormat = this.m_assemblyFormat;
			ObjectWriter objectWriter = new ObjectWriter(this.m_surrogates, this.m_context, internalFE, this.m_binder);
			__BinaryWriter serWriter = new __BinaryWriter(serializationStream, objectWriter, this.m_typeFormat);
			objectWriter.Serialize(graph, headers, serWriter, fCheck);
			this.m_crossAppDomainArray = objectWriter.crossAppDomainArray;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0007F178 File Offset: 0x0007D378
		internal static TypeInformation GetTypeInformation(Type type)
		{
			Dictionary<Type, TypeInformation> obj = BinaryFormatter.typeNameCache;
			TypeInformation result;
			lock (obj)
			{
				TypeInformation typeInformation = null;
				if (!BinaryFormatter.typeNameCache.TryGetValue(type, out typeInformation))
				{
					bool hasTypeForwardedFrom;
					string clrAssemblyName = FormatterServices.GetClrAssemblyName(type, out hasTypeForwardedFrom);
					typeInformation = new TypeInformation(FormatterServices.GetClrTypeFullName(type), clrAssemblyName, hasTypeForwardedFrom);
					BinaryFormatter.typeNameCache.Add(type, typeInformation);
				}
				result = typeInformation;
			}
			return result;
		}

		// Token: 0x04000D6A RID: 3434
		internal ISurrogateSelector m_surrogates;

		// Token: 0x04000D6B RID: 3435
		internal StreamingContext m_context;

		// Token: 0x04000D6C RID: 3436
		internal SerializationBinder m_binder;

		// Token: 0x04000D6D RID: 3437
		internal FormatterTypeStyle m_typeFormat = FormatterTypeStyle.TypesAlways;

		// Token: 0x04000D6E RID: 3438
		internal FormatterAssemblyStyle m_assemblyFormat;

		// Token: 0x04000D6F RID: 3439
		internal TypeFilterLevel m_securityLevel = TypeFilterLevel.Full;

		// Token: 0x04000D70 RID: 3440
		internal object[] m_crossAppDomainArray;

		// Token: 0x04000D71 RID: 3441
		private static Dictionary<Type, TypeInformation> typeNameCache = new Dictionary<Type, TypeInformation>();
	}
}
