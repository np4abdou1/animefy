using System;
using System.Collections.Generic;

namespace System
{
	// Token: 0x0200013A RID: 314
	internal sealed class LocalDataStoreMgr
	{
		// Token: 0x040003F9 RID: 1017
		private bool[] m_SlotInfoTable = new bool[64];

		// Token: 0x040003FA RID: 1018
		private List<LocalDataStore> m_ManagedLocalDataStores = new List<LocalDataStore>();

		// Token: 0x040003FB RID: 1019
		private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap = new Dictionary<string, LocalDataStoreSlot>();
	}
}
