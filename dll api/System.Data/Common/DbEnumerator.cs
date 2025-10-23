using System;
using System.Collections;
using System.ComponentModel;
using System.Data.ProviderBase;

namespace System.Data.Common
{
	/// <summary>Exposes the <see cref="M:System.Collections.IEnumerable.GetEnumerator" /> method, which supports a simple iteration over a collection by a .NET Framework data provider.</summary>
	// Token: 0x020000E7 RID: 231
	public class DbEnumerator : IEnumerator
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.Common.DbEnumerator" /> class using the specified <see langword="DataReader" />.</summary>
		/// <param name="reader">The <see langword="DataReader" /> through which to iterate. </param>
		// Token: 0x06000FD1 RID: 4049 RVA: 0x0004CCEC File Offset: 0x0004AEEC
		public DbEnumerator(IDataReader reader)
		{
			if (reader == null)
			{
				throw ADP.ArgumentNull("reader");
			}
			this._reader = reader;
		}

		/// <summary>Gets the current element in the collection.</summary>
		/// <returns>The current element in the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0004CD09 File Offset: 0x0004AF09
		public object Current
		{
			get
			{
				return this._current;
			}
		}

		/// <summary>Advances the enumerator to the next element of the collection.</summary>
		/// <returns>
		///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06000FD3 RID: 4051 RVA: 0x0004CD14 File Offset: 0x0004AF14
		public bool MoveNext()
		{
			if (this._schemaInfo == null)
			{
				this.BuildSchemaInfo();
			}
			this._current = null;
			if (this._reader.Read())
			{
				object[] values = new object[this._schemaInfo.Length];
				this._reader.GetValues(values);
				this._current = new DataRecordInternal(this._schemaInfo, values, this._descriptors, this._fieldNameLookup);
				return true;
			}
			if (this._closeReader)
			{
				this._reader.Close();
			}
			return false;
		}

		/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06000FD4 RID: 4052 RVA: 0x0004CD92 File Offset: 0x0004AF92
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Reset()
		{
			throw ADP.NotSupported();
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0004CD9C File Offset: 0x0004AF9C
		private void BuildSchemaInfo()
		{
			int fieldCount = this._reader.FieldCount;
			string[] array = new string[fieldCount];
			for (int i = 0; i < fieldCount; i++)
			{
				array[i] = this._reader.GetName(i);
			}
			ADP.BuildSchemaTableInfoTableNames(array);
			SchemaInfo[] array2 = new SchemaInfo[fieldCount];
			PropertyDescriptor[] array3 = new PropertyDescriptor[this._reader.FieldCount];
			for (int j = 0; j < array2.Length; j++)
			{
				SchemaInfo schemaInfo = default(SchemaInfo);
				schemaInfo.name = this._reader.GetName(j);
				schemaInfo.type = this._reader.GetFieldType(j);
				schemaInfo.typeName = this._reader.GetDataTypeName(j);
				array3[j] = new DbEnumerator.DbColumnDescriptor(j, array[j], schemaInfo.type);
				array2[j] = schemaInfo;
			}
			this._schemaInfo = array2;
			this._fieldNameLookup = new FieldNameLookup(this._reader, -1);
			this._descriptors = new PropertyDescriptorCollection(array3);
		}

		// Token: 0x04000501 RID: 1281
		internal IDataReader _reader;

		// Token: 0x04000502 RID: 1282
		internal DbDataRecord _current;

		// Token: 0x04000503 RID: 1283
		internal SchemaInfo[] _schemaInfo;

		// Token: 0x04000504 RID: 1284
		internal PropertyDescriptorCollection _descriptors;

		// Token: 0x04000505 RID: 1285
		private FieldNameLookup _fieldNameLookup;

		// Token: 0x04000506 RID: 1286
		private bool _closeReader;

		// Token: 0x020000E8 RID: 232
		private sealed class DbColumnDescriptor : PropertyDescriptor
		{
			// Token: 0x06000FD6 RID: 4054 RVA: 0x0004CE96 File Offset: 0x0004B096
			internal DbColumnDescriptor(int ordinal, string name, Type type) : base(name, null)
			{
				this._ordinal = ordinal;
				this._type = type;
			}

			// Token: 0x1700021B RID: 539
			// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x0004CEAE File Offset: 0x0004B0AE
			public override Type ComponentType
			{
				get
				{
					return typeof(IDataRecord);
				}
			}

			// Token: 0x1700021C RID: 540
			// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00002317 File Offset: 0x00000517
			public override bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700021D RID: 541
			// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0004CEBA File Offset: 0x0004B0BA
			public override Type PropertyType
			{
				get
				{
					return this._type;
				}
			}

			// Token: 0x06000FDA RID: 4058 RVA: 0x000020BC File Offset: 0x000002BC
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x06000FDB RID: 4059 RVA: 0x0004CEC2 File Offset: 0x0004B0C2
			public override object GetValue(object component)
			{
				return ((IDataRecord)component)[this._ordinal];
			}

			// Token: 0x06000FDC RID: 4060 RVA: 0x0004CD92 File Offset: 0x0004AF92
			public override void ResetValue(object component)
			{
				throw ADP.NotSupported();
			}

			// Token: 0x06000FDD RID: 4061 RVA: 0x0004CD92 File Offset: 0x0004AF92
			public override void SetValue(object component, object value)
			{
				throw ADP.NotSupported();
			}

			// Token: 0x06000FDE RID: 4062 RVA: 0x000020BC File Offset: 0x000002BC
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x04000507 RID: 1287
			private int _ordinal;

			// Token: 0x04000508 RID: 1288
			private Type _type;
		}
	}
}
