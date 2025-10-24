using System;
using System.Data.Common;

namespace System.Data.ProviderBase
{
	// Token: 0x020000CB RID: 203
	internal abstract class DataReaderContainer
	{
		// Token: 0x06000DFC RID: 3580 RVA: 0x00046E2C File Offset: 0x0004502C
		internal static DataReaderContainer Create(IDataReader dataReader, bool returnProviderSpecificTypes)
		{
			if (returnProviderSpecificTypes)
			{
				DbDataReader dbDataReader = dataReader as DbDataReader;
				if (dbDataReader != null)
				{
					return new DataReaderContainer.ProviderSpecificDataReader(dataReader, dbDataReader);
				}
			}
			return new DataReaderContainer.CommonLanguageSubsetDataReader(dataReader);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00046E54 File Offset: 0x00045054
		protected DataReaderContainer(IDataReader dataReader)
		{
			this._dataReader = dataReader;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00046E63 File Offset: 0x00045063
		internal int FieldCount
		{
			get
			{
				return this._fieldCount;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000DFF RID: 3583
		internal abstract bool ReturnProviderSpecificTypes { get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000E00 RID: 3584
		protected abstract int VisibleFieldCount { get; }

		// Token: 0x06000E01 RID: 3585
		internal abstract Type GetFieldType(int ordinal);

		// Token: 0x06000E02 RID: 3586
		internal abstract int GetValues(object[] values);

		// Token: 0x06000E03 RID: 3587 RVA: 0x00046E6C File Offset: 0x0004506C
		internal string GetName(int ordinal)
		{
			string name = this._dataReader.GetName(ordinal);
			if (name == null)
			{
				return "";
			}
			return name;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00046E90 File Offset: 0x00045090
		internal DataTable GetSchemaTable()
		{
			return this._dataReader.GetSchemaTable();
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00046E9D File Offset: 0x0004509D
		internal bool NextResult()
		{
			this._fieldCount = 0;
			if (this._dataReader.NextResult())
			{
				this._fieldCount = this.VisibleFieldCount;
				return true;
			}
			return false;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00046EC2 File Offset: 0x000450C2
		internal bool Read()
		{
			return this._dataReader.Read();
		}

		// Token: 0x0400046C RID: 1132
		protected readonly IDataReader _dataReader;

		// Token: 0x0400046D RID: 1133
		protected int _fieldCount;

		// Token: 0x020000CC RID: 204
		private sealed class ProviderSpecificDataReader : DataReaderContainer
		{
			// Token: 0x06000E07 RID: 3591 RVA: 0x00046ECF File Offset: 0x000450CF
			internal ProviderSpecificDataReader(IDataReader dataReader, DbDataReader dbDataReader) : base(dataReader)
			{
				this._providerSpecificDataReader = dbDataReader;
				this._fieldCount = this.VisibleFieldCount;
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00002317 File Offset: 0x00000517
			internal override bool ReturnProviderSpecificTypes
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00046EEC File Offset: 0x000450EC
			protected override int VisibleFieldCount
			{
				get
				{
					int visibleFieldCount = this._providerSpecificDataReader.VisibleFieldCount;
					if (0 > visibleFieldCount)
					{
						return 0;
					}
					return visibleFieldCount;
				}
			}

			// Token: 0x06000E0A RID: 3594 RVA: 0x00046F0C File Offset: 0x0004510C
			internal override Type GetFieldType(int ordinal)
			{
				return this._providerSpecificDataReader.GetProviderSpecificFieldType(ordinal);
			}

			// Token: 0x06000E0B RID: 3595 RVA: 0x00046F1A File Offset: 0x0004511A
			internal override int GetValues(object[] values)
			{
				return this._providerSpecificDataReader.GetProviderSpecificValues(values);
			}

			// Token: 0x0400046E RID: 1134
			private DbDataReader _providerSpecificDataReader;
		}

		// Token: 0x020000CD RID: 205
		private sealed class CommonLanguageSubsetDataReader : DataReaderContainer
		{
			// Token: 0x06000E0C RID: 3596 RVA: 0x00046F28 File Offset: 0x00045128
			internal CommonLanguageSubsetDataReader(IDataReader dataReader) : base(dataReader)
			{
				this._fieldCount = this.VisibleFieldCount;
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000E0D RID: 3597 RVA: 0x000020BC File Offset: 0x000002BC
			internal override bool ReturnProviderSpecificTypes
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000E0E RID: 3598 RVA: 0x00046F40 File Offset: 0x00045140
			protected override int VisibleFieldCount
			{
				get
				{
					int fieldCount = this._dataReader.FieldCount;
					if (0 > fieldCount)
					{
						return 0;
					}
					return fieldCount;
				}
			}

			// Token: 0x06000E0F RID: 3599 RVA: 0x00046F60 File Offset: 0x00045160
			internal override Type GetFieldType(int ordinal)
			{
				return this._dataReader.GetFieldType(ordinal);
			}

			// Token: 0x06000E10 RID: 3600 RVA: 0x00046F6E File Offset: 0x0004516E
			internal override int GetValues(object[] values)
			{
				return this._dataReader.GetValues(values);
			}
		}
	}
}
