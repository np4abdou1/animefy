using System;

namespace System.Data.ProviderBase
{
	// Token: 0x020000C9 RID: 201
	internal class BasicFieldNameLookup
	{
		// Token: 0x06000DFA RID: 3578 RVA: 0x00046DDC File Offset: 0x00044FDC
		public BasicFieldNameLookup(IDataReader reader)
		{
			int fieldCount = reader.FieldCount;
			string[] array = new string[fieldCount];
			for (int i = 0; i < fieldCount; i++)
			{
				array[i] = reader.GetName(i);
			}
			this._fieldNames = array;
		}

		// Token: 0x0400046A RID: 1130
		private readonly string[] _fieldNames;
	}
}
