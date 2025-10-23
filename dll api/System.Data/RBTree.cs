using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Data
{
	// Token: 0x0200007F RID: 127
	internal abstract class RBTree<K> : IEnumerable
	{
		// Token: 0x060007DB RID: 2011
		protected abstract int CompareNode(K record1, K record2);

		// Token: 0x060007DC RID: 2012
		protected abstract int CompareSateliteTreeNode(K record1, K record2);

		// Token: 0x060007DD RID: 2013 RVA: 0x00026B31 File Offset: 0x00024D31
		protected RBTree(TreeAccessMethod accessMethod)
		{
			this._accessMethod = accessMethod;
			this.InitTree();
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00026B48 File Offset: 0x00024D48
		private void InitTree()
		{
			this.root = 0;
			this._pageTable = new RBTree<K>.TreePage[32];
			this._pageTableMap = new int[(this._pageTable.Length + 32 - 1) / 32];
			this._inUsePageCount = 0;
			this._nextFreePageLine = 0;
			this.AllocPage(32);
			this._pageTable[0]._slots[0]._nodeColor = RBTree<K>.NodeColor.black;
			this._pageTable[0]._slotMap[0] = 1;
			this._pageTable[0].InUseCount = 1;
			this._inUseNodeCount = 1;
			this._inUseSatelliteTreeCount = 0;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00026BE0 File Offset: 0x00024DE0
		private void FreePage(RBTree<K>.TreePage page)
		{
			this.MarkPageFree(page);
			this._pageTable[page.PageId] = null;
			this._inUsePageCount--;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00026C08 File Offset: 0x00024E08
		private RBTree<K>.TreePage AllocPage(int size)
		{
			int num = this.GetIndexOfPageWithFreeSlot(false);
			if (num != -1)
			{
				this._pageTable[num] = new RBTree<K>.TreePage(size);
				this._nextFreePageLine = num / 32;
			}
			else
			{
				RBTree<K>.TreePage[] array = new RBTree<K>.TreePage[this._pageTable.Length * 2];
				Array.Copy(this._pageTable, 0, array, 0, this._pageTable.Length);
				int[] array2 = new int[(array.Length + 32 - 1) / 32];
				Array.Copy(this._pageTableMap, 0, array2, 0, this._pageTableMap.Length);
				this._nextFreePageLine = this._pageTableMap.Length;
				num = this._pageTable.Length;
				this._pageTable = array;
				this._pageTableMap = array2;
				this._pageTable[num] = new RBTree<K>.TreePage(size);
			}
			this._pageTable[num].PageId = num;
			this._inUsePageCount++;
			return this._pageTable[num];
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00026CE2 File Offset: 0x00024EE2
		private void MarkPageFull(RBTree<K>.TreePage page)
		{
			this._pageTableMap[page.PageId / 32] |= 1 << page.PageId % 32;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00026D0A File Offset: 0x00024F0A
		private void MarkPageFree(RBTree<K>.TreePage page)
		{
			this._pageTableMap[page.PageId / 32] &= ~(1 << page.PageId % 32);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00026D34 File Offset: 0x00024F34
		private static int GetIntValueFromBitMap(uint bitMap)
		{
			int num = 0;
			if ((bitMap & 4294901760U) != 0U)
			{
				num += 16;
				bitMap >>= 16;
			}
			if ((bitMap & 65280U) != 0U)
			{
				num += 8;
				bitMap >>= 8;
			}
			if ((bitMap & 240U) != 0U)
			{
				num += 4;
				bitMap >>= 4;
			}
			if ((bitMap & 12U) != 0U)
			{
				num += 2;
				bitMap >>= 2;
			}
			if ((bitMap & 2U) != 0U)
			{
				num++;
			}
			return num;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00026D94 File Offset: 0x00024F94
		private void FreeNode(int nodeId)
		{
			RBTree<K>.TreePage treePage = this._pageTable[nodeId >> 16];
			int num = nodeId & 65535;
			treePage._slots[num] = default(RBTree<K>.Node);
			treePage._slotMap[num / 32] &= ~(1 << num % 32);
			RBTree<K>.TreePage treePage2 = treePage;
			int inUseCount = treePage2.InUseCount;
			treePage2.InUseCount = inUseCount - 1;
			this._inUseNodeCount--;
			if (treePage.InUseCount == 0)
			{
				this.FreePage(treePage);
				return;
			}
			if (treePage.InUseCount == treePage._slots.Length - 1)
			{
				this.MarkPageFree(treePage);
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00026E2C File Offset: 0x0002502C
		private int GetIndexOfPageWithFreeSlot(bool allocatedPage)
		{
			int i = this._nextFreePageLine;
			int num = -1;
			while (i < this._pageTableMap.Length)
			{
				if (this._pageTableMap[i] < -1)
				{
					uint num2 = (uint)this._pageTableMap[i];
					while ((num2 ^ 4294967295U) != 0U)
					{
						uint num3 = ~num2 & num2 + 1U;
						if (((long)this._pageTableMap[i] & (long)((ulong)num3)) != 0L)
						{
							throw ExceptionBuilder.InternalRBTreeError(RBTreeError.PagePositionInSlotInUse);
						}
						num = i * 32 + RBTree<K>.GetIntValueFromBitMap(num3);
						if (allocatedPage)
						{
							if (this._pageTable[num] != null)
							{
								return num;
							}
						}
						else if (this._pageTable[num] == null)
						{
							return num;
						}
						num = -1;
						num2 |= num3;
					}
				}
				i++;
			}
			if (this._nextFreePageLine != 0)
			{
				this._nextFreePageLine = 0;
				num = this.GetIndexOfPageWithFreeSlot(allocatedPage);
			}
			return num;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00026ECF File Offset: 0x000250CF
		public int Count
		{
			get
			{
				return this._inUseNodeCount - 1;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00026ED9 File Offset: 0x000250D9
		public bool HasDuplicates
		{
			get
			{
				return this._inUseSatelliteTreeCount != 0;
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00026EE4 File Offset: 0x000250E4
		private int GetNewNode(K key)
		{
			int indexOfPageWithFreeSlot = this.GetIndexOfPageWithFreeSlot(true);
			RBTree<K>.TreePage treePage;
			if (indexOfPageWithFreeSlot != -1)
			{
				treePage = this._pageTable[indexOfPageWithFreeSlot];
			}
			else if (this._inUsePageCount < 4)
			{
				treePage = this.AllocPage(32);
			}
			else if (this._inUsePageCount < 32)
			{
				treePage = this.AllocPage(256);
			}
			else if (this._inUsePageCount < 128)
			{
				treePage = this.AllocPage(1024);
			}
			else if (this._inUsePageCount < 4096)
			{
				treePage = this.AllocPage(4096);
			}
			else if (this._inUsePageCount < 32768)
			{
				treePage = this.AllocPage(8192);
			}
			else
			{
				treePage = this.AllocPage(65536);
			}
			int num = treePage.AllocSlot(this);
			if (num == -1)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.NoFreeSlots);
			}
			treePage._slots[num]._selfId = (treePage.PageId << 16 | num);
			treePage._slots[num]._subTreeSize = 1;
			treePage._slots[num]._keyOfNode = key;
			return treePage._slots[num]._selfId;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00026FFC File Offset: 0x000251FC
		private int Successor(int x_id)
		{
			if (this.Right(x_id) != 0)
			{
				return this.Minimum(this.Right(x_id));
			}
			int num = this.Parent(x_id);
			while (num != 0 && x_id == this.Right(num))
			{
				x_id = num;
				num = this.Parent(num);
			}
			return num;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00027044 File Offset: 0x00025244
		private bool Successor(ref int nodeId, ref int mainTreeNodeId)
		{
			if (nodeId == 0)
			{
				nodeId = this.Minimum(mainTreeNodeId);
				mainTreeNodeId = 0;
			}
			else
			{
				nodeId = this.Successor(nodeId);
				if (nodeId == 0 && mainTreeNodeId != 0)
				{
					nodeId = this.Successor(mainTreeNodeId);
					mainTreeNodeId = 0;
				}
			}
			if (nodeId != 0)
			{
				if (this.Next(nodeId) != 0)
				{
					if (mainTreeNodeId != 0)
					{
						throw ExceptionBuilder.InternalRBTreeError(RBTreeError.NestedSatelliteTreeEnumerator);
					}
					mainTreeNodeId = nodeId;
					nodeId = this.Minimum(this.Next(nodeId));
				}
				return true;
			}
			return false;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000270B4 File Offset: 0x000252B4
		private int Minimum(int x_id)
		{
			while (this.Left(x_id) != 0)
			{
				x_id = this.Left(x_id);
			}
			return x_id;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000270CC File Offset: 0x000252CC
		private int LeftRotate(int root_id, int x_id, int mainTreeNode)
		{
			int num = this.Right(x_id);
			this.SetRight(x_id, this.Left(num));
			if (this.Left(num) != 0)
			{
				this.SetParent(this.Left(num), x_id);
			}
			this.SetParent(num, this.Parent(x_id));
			if (this.Parent(x_id) == 0)
			{
				if (root_id == 0)
				{
					this.root = num;
				}
				else
				{
					this.SetNext(mainTreeNode, num);
					this.SetKey(mainTreeNode, this.Key(num));
					root_id = num;
				}
			}
			else if (x_id == this.Left(this.Parent(x_id)))
			{
				this.SetLeft(this.Parent(x_id), num);
			}
			else
			{
				this.SetRight(this.Parent(x_id), num);
			}
			this.SetLeft(num, x_id);
			this.SetParent(x_id, num);
			if (x_id != 0)
			{
				this.SetSubTreeSize(x_id, this.SubTreeSize(this.Left(x_id)) + this.SubTreeSize(this.Right(x_id)) + ((this.Next(x_id) == 0) ? 1 : this.SubTreeSize(this.Next(x_id))));
			}
			if (num != 0)
			{
				this.SetSubTreeSize(num, this.SubTreeSize(this.Left(num)) + this.SubTreeSize(this.Right(num)) + ((this.Next(num) == 0) ? 1 : this.SubTreeSize(this.Next(num))));
			}
			return root_id;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00027204 File Offset: 0x00025404
		private int RightRotate(int root_id, int x_id, int mainTreeNode)
		{
			int num = this.Left(x_id);
			this.SetLeft(x_id, this.Right(num));
			if (this.Right(num) != 0)
			{
				this.SetParent(this.Right(num), x_id);
			}
			this.SetParent(num, this.Parent(x_id));
			if (this.Parent(x_id) == 0)
			{
				if (root_id == 0)
				{
					this.root = num;
				}
				else
				{
					this.SetNext(mainTreeNode, num);
					this.SetKey(mainTreeNode, this.Key(num));
					root_id = num;
				}
			}
			else if (x_id == this.Left(this.Parent(x_id)))
			{
				this.SetLeft(this.Parent(x_id), num);
			}
			else
			{
				this.SetRight(this.Parent(x_id), num);
			}
			this.SetRight(num, x_id);
			this.SetParent(x_id, num);
			if (x_id != 0)
			{
				this.SetSubTreeSize(x_id, this.SubTreeSize(this.Left(x_id)) + this.SubTreeSize(this.Right(x_id)) + ((this.Next(x_id) == 0) ? 1 : this.SubTreeSize(this.Next(x_id))));
			}
			if (num != 0)
			{
				this.SetSubTreeSize(num, this.SubTreeSize(this.Left(num)) + this.SubTreeSize(this.Right(num)) + ((this.Next(num) == 0) ? 1 : this.SubTreeSize(this.Next(num))));
			}
			return root_id;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0002733C File Offset: 0x0002553C
		private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append)
		{
			this._version++;
			int num = 0;
			int num2 = (root_id == 0) ? this.root : root_id;
			if (this._accessMethod == TreeAccessMethod.KEY_SEARCH_AND_INDEX && !append)
			{
				while (num2 != 0)
				{
					this.IncreaseSize(num2);
					num = num2;
					int num3 = (root_id == 0) ? this.CompareNode(this.Key(x_id), this.Key(num2)) : this.CompareSateliteTreeNode(this.Key(x_id), this.Key(num2));
					if (num3 < 0)
					{
						num2 = this.Left(num2);
					}
					else if (num3 > 0)
					{
						num2 = this.Right(num2);
					}
					else
					{
						if (root_id != 0)
						{
							throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidStateinInsert);
						}
						if (this.Next(num2) != 0)
						{
							root_id = this.RBInsert(this.Next(num2), x_id, num2, -1, false);
							this.SetKey(num2, this.Key(this.Next(num2)));
						}
						else
						{
							int newNode = this.GetNewNode(this.Key(num2));
							this._inUseSatelliteTreeCount++;
							this.SetNext(newNode, num2);
							this.SetColor(newNode, this.color(num2));
							this.SetParent(newNode, this.Parent(num2));
							this.SetLeft(newNode, this.Left(num2));
							this.SetRight(newNode, this.Right(num2));
							if (this.Left(this.Parent(num2)) == num2)
							{
								this.SetLeft(this.Parent(num2), newNode);
							}
							else if (this.Right(this.Parent(num2)) == num2)
							{
								this.SetRight(this.Parent(num2), newNode);
							}
							if (this.Left(num2) != 0)
							{
								this.SetParent(this.Left(num2), newNode);
							}
							if (this.Right(num2) != 0)
							{
								this.SetParent(this.Right(num2), newNode);
							}
							if (this.root == num2)
							{
								this.root = newNode;
							}
							this.SetColor(num2, RBTree<K>.NodeColor.black);
							this.SetParent(num2, 0);
							this.SetLeft(num2, 0);
							this.SetRight(num2, 0);
							int size = this.SubTreeSize(num2);
							this.SetSubTreeSize(num2, 1);
							root_id = this.RBInsert(num2, x_id, newNode, -1, false);
							this.SetSubTreeSize(newNode, size);
						}
						return root_id;
					}
				}
			}
			else
			{
				if (this._accessMethod != TreeAccessMethod.INDEX_ONLY && !append)
				{
					throw ExceptionBuilder.InternalRBTreeError(RBTreeError.UnsupportedAccessMethod1);
				}
				if (position == -1)
				{
					position = this.SubTreeSize(this.root);
				}
				while (num2 != 0)
				{
					this.IncreaseSize(num2);
					num = num2;
					int num4 = position - this.SubTreeSize(this.Left(num));
					if (num4 <= 0)
					{
						num2 = this.Left(num2);
					}
					else
					{
						num2 = this.Right(num2);
						if (num2 != 0)
						{
							position = num4 - 1;
						}
					}
				}
			}
			this.SetParent(x_id, num);
			if (num == 0)
			{
				if (root_id == 0)
				{
					this.root = x_id;
				}
				else
				{
					this.SetNext(mainTreeNodeID, x_id);
					this.SetKey(mainTreeNodeID, this.Key(x_id));
					root_id = x_id;
				}
			}
			else
			{
				int num5;
				if (this._accessMethod == TreeAccessMethod.KEY_SEARCH_AND_INDEX)
				{
					num5 = ((root_id == 0) ? this.CompareNode(this.Key(x_id), this.Key(num)) : this.CompareSateliteTreeNode(this.Key(x_id), this.Key(num)));
				}
				else
				{
					if (this._accessMethod != TreeAccessMethod.INDEX_ONLY)
					{
						throw ExceptionBuilder.InternalRBTreeError(RBTreeError.UnsupportedAccessMethod2);
					}
					num5 = ((position <= 0) ? -1 : 1);
				}
				if (num5 < 0)
				{
					this.SetLeft(num, x_id);
				}
				else
				{
					this.SetRight(num, x_id);
				}
			}
			this.SetLeft(x_id, 0);
			this.SetRight(x_id, 0);
			this.SetColor(x_id, RBTree<K>.NodeColor.red);
			while (this.color(this.Parent(x_id)) == RBTree<K>.NodeColor.red)
			{
				if (this.Parent(x_id) == this.Left(this.Parent(this.Parent(x_id))))
				{
					num = this.Right(this.Parent(this.Parent(x_id)));
					if (this.color(num) == RBTree<K>.NodeColor.red)
					{
						this.SetColor(this.Parent(x_id), RBTree<K>.NodeColor.black);
						this.SetColor(num, RBTree<K>.NodeColor.black);
						this.SetColor(this.Parent(this.Parent(x_id)), RBTree<K>.NodeColor.red);
						x_id = this.Parent(this.Parent(x_id));
					}
					else
					{
						if (x_id == this.Right(this.Parent(x_id)))
						{
							x_id = this.Parent(x_id);
							root_id = this.LeftRotate(root_id, x_id, mainTreeNodeID);
						}
						this.SetColor(this.Parent(x_id), RBTree<K>.NodeColor.black);
						this.SetColor(this.Parent(this.Parent(x_id)), RBTree<K>.NodeColor.red);
						root_id = this.RightRotate(root_id, this.Parent(this.Parent(x_id)), mainTreeNodeID);
					}
				}
				else
				{
					num = this.Left(this.Parent(this.Parent(x_id)));
					if (this.color(num) == RBTree<K>.NodeColor.red)
					{
						this.SetColor(this.Parent(x_id), RBTree<K>.NodeColor.black);
						this.SetColor(num, RBTree<K>.NodeColor.black);
						this.SetColor(this.Parent(this.Parent(x_id)), RBTree<K>.NodeColor.red);
						x_id = this.Parent(this.Parent(x_id));
					}
					else
					{
						if (x_id == this.Left(this.Parent(x_id)))
						{
							x_id = this.Parent(x_id);
							root_id = this.RightRotate(root_id, x_id, mainTreeNodeID);
						}
						this.SetColor(this.Parent(x_id), RBTree<K>.NodeColor.black);
						this.SetColor(this.Parent(this.Parent(x_id)), RBTree<K>.NodeColor.red);
						root_id = this.LeftRotate(root_id, this.Parent(this.Parent(x_id)), mainTreeNodeID);
					}
				}
			}
			if (root_id == 0)
			{
				this.SetColor(this.root, RBTree<K>.NodeColor.black);
			}
			else
			{
				this.SetColor(root_id, RBTree<K>.NodeColor.black);
			}
			return root_id;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00027830 File Offset: 0x00025A30
		public void UpdateNodeKey(K currentKey, K newKey)
		{
			RBTree<K>.NodePath nodeByKey = this.GetNodeByKey(currentKey);
			if (this.Parent(nodeByKey._nodeID) == 0 && nodeByKey._nodeID != this.root)
			{
				this.SetKey(nodeByKey._mainTreeNodeID, newKey);
			}
			this.SetKey(nodeByKey._nodeID, newKey);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0002787C File Offset: 0x00025A7C
		public K DeleteByIndex(int i)
		{
			RBTree<K>.NodePath nodeByIndex = this.GetNodeByIndex(i);
			K result = this.Key(nodeByIndex._nodeID);
			this.RBDeleteX(0, nodeByIndex._nodeID, nodeByIndex._mainTreeNodeID);
			return result;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000278B1 File Offset: 0x00025AB1
		public int RBDelete(int z_id)
		{
			return this.RBDeleteX(0, z_id, 0);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000278BC File Offset: 0x00025ABC
		private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID)
		{
			if (this.Next(z_id) != 0)
			{
				return this.RBDeleteX(this.Next(z_id), this.Next(z_id), z_id);
			}
			bool flag = false;
			int num = (this._accessMethod == TreeAccessMethod.KEY_SEARCH_AND_INDEX) ? mainTreeNodeID : z_id;
			if (this.Next(num) != 0)
			{
				root_id = this.Next(num);
			}
			if (this.SubTreeSize(this.Next(num)) == 2)
			{
				flag = true;
			}
			else if (this.SubTreeSize(this.Next(num)) == 1)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidNextSizeInDelete);
			}
			int num2;
			if (this.Left(z_id) == 0 || this.Right(z_id) == 0)
			{
				num2 = z_id;
			}
			else
			{
				num2 = this.Successor(z_id);
			}
			int num3;
			if (this.Left(num2) != 0)
			{
				num3 = this.Left(num2);
			}
			else
			{
				num3 = this.Right(num2);
			}
			int num4 = this.Parent(num2);
			if (num3 != 0)
			{
				this.SetParent(num3, num4);
			}
			if (num4 == 0)
			{
				if (root_id == 0)
				{
					this.root = num3;
				}
				else
				{
					root_id = num3;
				}
			}
			else if (num2 == this.Left(num4))
			{
				this.SetLeft(num4, num3);
			}
			else
			{
				this.SetRight(num4, num3);
			}
			if (num2 != z_id)
			{
				this.SetKey(z_id, this.Key(num2));
				this.SetNext(z_id, this.Next(num2));
			}
			if (this.Next(num) != 0)
			{
				if (root_id == 0 && z_id != num)
				{
					throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidStateinDelete);
				}
				if (root_id != 0)
				{
					this.SetNext(num, root_id);
					this.SetKey(num, this.Key(root_id));
				}
			}
			for (int nodeId = num4; nodeId != 0; nodeId = this.Parent(nodeId))
			{
				this.RecomputeSize(nodeId);
			}
			if (root_id != 0)
			{
				for (int nodeId2 = num; nodeId2 != 0; nodeId2 = this.Parent(nodeId2))
				{
					this.DecreaseSize(nodeId2);
				}
			}
			if (this.color(num2) == RBTree<K>.NodeColor.black)
			{
				root_id = this.RBDeleteFixup(root_id, num3, num4, mainTreeNodeID);
			}
			if (flag)
			{
				if (num == 0 || this.SubTreeSize(this.Next(num)) != 1)
				{
					throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidNodeSizeinDelete);
				}
				this._inUseSatelliteTreeCount--;
				int num5 = this.Next(num);
				this.SetLeft(num5, this.Left(num));
				this.SetRight(num5, this.Right(num));
				this.SetSubTreeSize(num5, this.SubTreeSize(num));
				this.SetColor(num5, this.color(num));
				if (this.Parent(num) != 0)
				{
					this.SetParent(num5, this.Parent(num));
					if (this.Left(this.Parent(num)) == num)
					{
						this.SetLeft(this.Parent(num), num5);
					}
					else
					{
						this.SetRight(this.Parent(num), num5);
					}
				}
				if (this.Left(num) != 0)
				{
					this.SetParent(this.Left(num), num5);
				}
				if (this.Right(num) != 0)
				{
					this.SetParent(this.Right(num), num5);
				}
				if (this.root == num)
				{
					this.root = num5;
				}
				this.FreeNode(num);
				num = 0;
			}
			else if (this.Next(num) != 0)
			{
				if (root_id == 0 && z_id != num)
				{
					throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidStateinEndDelete);
				}
				if (root_id != 0)
				{
					this.SetNext(num, root_id);
					this.SetKey(num, this.Key(root_id));
				}
			}
			if (num2 != z_id)
			{
				this.SetLeft(num2, this.Left(z_id));
				this.SetRight(num2, this.Right(z_id));
				this.SetColor(num2, this.color(z_id));
				this.SetSubTreeSize(num2, this.SubTreeSize(z_id));
				if (this.Parent(z_id) != 0)
				{
					this.SetParent(num2, this.Parent(z_id));
					if (this.Left(this.Parent(z_id)) == z_id)
					{
						this.SetLeft(this.Parent(z_id), num2);
					}
					else
					{
						this.SetRight(this.Parent(z_id), num2);
					}
				}
				else
				{
					this.SetParent(num2, 0);
				}
				if (this.Left(z_id) != 0)
				{
					this.SetParent(this.Left(z_id), num2);
				}
				if (this.Right(z_id) != 0)
				{
					this.SetParent(this.Right(z_id), num2);
				}
				if (this.root == z_id)
				{
					this.root = num2;
				}
				else if (root_id == z_id)
				{
					root_id = num2;
				}
				if (num != 0 && this.Next(num) == z_id)
				{
					this.SetNext(num, num2);
				}
			}
			this.FreeNode(z_id);
			this._version++;
			return z_id;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00027CB0 File Offset: 0x00025EB0
		private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID)
		{
			if (x_id == 0 && px_id == 0)
			{
				return 0;
			}
			while (((root_id == 0) ? this.root : root_id) != x_id && this.color(x_id) == RBTree<K>.NodeColor.black)
			{
				if ((x_id != 0 && x_id == this.Left(this.Parent(x_id))) || (x_id == 0 && this.Left(px_id) == 0))
				{
					int num = (x_id == 0) ? this.Right(px_id) : this.Right(this.Parent(x_id));
					if (num == 0)
					{
						throw ExceptionBuilder.InternalRBTreeError(RBTreeError.RBDeleteFixup);
					}
					if (this.color(num) == RBTree<K>.NodeColor.red)
					{
						this.SetColor(num, RBTree<K>.NodeColor.black);
						this.SetColor(px_id, RBTree<K>.NodeColor.red);
						root_id = this.LeftRotate(root_id, px_id, mainTreeNodeID);
						num = ((x_id == 0) ? this.Right(px_id) : this.Right(this.Parent(x_id)));
					}
					if (this.color(this.Left(num)) == RBTree<K>.NodeColor.black && this.color(this.Right(num)) == RBTree<K>.NodeColor.black)
					{
						this.SetColor(num, RBTree<K>.NodeColor.red);
						x_id = px_id;
						px_id = this.Parent(px_id);
					}
					else
					{
						if (this.color(this.Right(num)) == RBTree<K>.NodeColor.black)
						{
							this.SetColor(this.Left(num), RBTree<K>.NodeColor.black);
							this.SetColor(num, RBTree<K>.NodeColor.red);
							root_id = this.RightRotate(root_id, num, mainTreeNodeID);
							num = ((x_id == 0) ? this.Right(px_id) : this.Right(this.Parent(x_id)));
						}
						this.SetColor(num, this.color(px_id));
						this.SetColor(px_id, RBTree<K>.NodeColor.black);
						this.SetColor(this.Right(num), RBTree<K>.NodeColor.black);
						root_id = this.LeftRotate(root_id, px_id, mainTreeNodeID);
						x_id = ((root_id == 0) ? this.root : root_id);
						px_id = this.Parent(x_id);
					}
				}
				else
				{
					int num = this.Left(px_id);
					if (this.color(num) == RBTree<K>.NodeColor.red)
					{
						this.SetColor(num, RBTree<K>.NodeColor.black);
						if (x_id != 0)
						{
							this.SetColor(px_id, RBTree<K>.NodeColor.red);
							root_id = this.RightRotate(root_id, px_id, mainTreeNodeID);
							num = ((x_id == 0) ? this.Left(px_id) : this.Left(this.Parent(x_id)));
						}
						else
						{
							this.SetColor(px_id, RBTree<K>.NodeColor.red);
							root_id = this.RightRotate(root_id, px_id, mainTreeNodeID);
							num = ((x_id == 0) ? this.Left(px_id) : this.Left(this.Parent(x_id)));
							if (num == 0)
							{
								throw ExceptionBuilder.InternalRBTreeError(RBTreeError.CannotRotateInvalidsuccessorNodeinDelete);
							}
						}
					}
					if (this.color(this.Right(num)) == RBTree<K>.NodeColor.black && this.color(this.Left(num)) == RBTree<K>.NodeColor.black)
					{
						this.SetColor(num, RBTree<K>.NodeColor.red);
						x_id = px_id;
						px_id = this.Parent(px_id);
					}
					else
					{
						if (this.color(this.Left(num)) == RBTree<K>.NodeColor.black)
						{
							this.SetColor(this.Right(num), RBTree<K>.NodeColor.black);
							this.SetColor(num, RBTree<K>.NodeColor.red);
							root_id = this.LeftRotate(root_id, num, mainTreeNodeID);
							num = ((x_id == 0) ? this.Left(px_id) : this.Left(this.Parent(x_id)));
						}
						if (x_id != 0)
						{
							this.SetColor(num, this.color(px_id));
							this.SetColor(px_id, RBTree<K>.NodeColor.black);
							this.SetColor(this.Left(num), RBTree<K>.NodeColor.black);
							root_id = this.RightRotate(root_id, px_id, mainTreeNodeID);
							x_id = ((root_id == 0) ? this.root : root_id);
							px_id = this.Parent(x_id);
						}
						else
						{
							this.SetColor(num, this.color(px_id));
							this.SetColor(px_id, RBTree<K>.NodeColor.black);
							this.SetColor(this.Left(num), RBTree<K>.NodeColor.black);
							root_id = this.RightRotate(root_id, px_id, mainTreeNodeID);
							x_id = ((root_id == 0) ? this.root : root_id);
							px_id = this.Parent(x_id);
						}
					}
				}
			}
			this.SetColor(x_id, RBTree<K>.NodeColor.black);
			return root_id;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00027FE8 File Offset: 0x000261E8
		private int SearchSubTree(int root_id, K key)
		{
			if (root_id != 0 && this._accessMethod != TreeAccessMethod.KEY_SEARCH_AND_INDEX)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.UnsupportedAccessMethodInNonNillRootSubtree);
			}
			int num = (root_id == 0) ? this.root : root_id;
			while (num != 0)
			{
				int num2 = (root_id == 0) ? this.CompareNode(key, this.Key(num)) : this.CompareSateliteTreeNode(key, this.Key(num));
				if (num2 == 0)
				{
					break;
				}
				if (num2 < 0)
				{
					num = this.Left(num);
				}
				else
				{
					num = this.Right(num);
				}
			}
			return num;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00028058 File Offset: 0x00026258
		public int Search(K key)
		{
			int num = this.root;
			while (num != 0)
			{
				int num2 = this.CompareNode(key, this.Key(num));
				if (num2 == 0)
				{
					break;
				}
				if (num2 < 0)
				{
					num = this.Left(num);
				}
				else
				{
					num = this.Right(num);
				}
			}
			return num;
		}

		// Token: 0x17000133 RID: 307
		public K this[int index]
		{
			get
			{
				return this.Key(this.GetNodeByIndex(index)._nodeID);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000280B0 File Offset: 0x000262B0
		private RBTree<K>.NodePath GetNodeByKey(K key)
		{
			int num = this.SearchSubTree(0, key);
			if (this.Next(num) != 0)
			{
				return new RBTree<K>.NodePath(this.SearchSubTree(this.Next(num), key), num);
			}
			K k = this.Key(num);
			if (!k.Equals(key))
			{
				num = 0;
			}
			return new RBTree<K>.NodePath(num, 0);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0002810C File Offset: 0x0002630C
		public int GetIndexByKey(K key)
		{
			int result = -1;
			RBTree<K>.NodePath nodeByKey = this.GetNodeByKey(key);
			if (nodeByKey._nodeID != 0)
			{
				result = this.GetIndexByNodePath(nodeByKey);
			}
			return result;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00028134 File Offset: 0x00026334
		public int GetIndexByNode(int node)
		{
			if (this._inUseSatelliteTreeCount == 0)
			{
				return this.ComputeIndexByNode(node);
			}
			if (this.Next(node) != 0)
			{
				return this.ComputeIndexWithSatelliteByNode(node);
			}
			int num = this.SearchSubTree(0, this.Key(node));
			if (num == node)
			{
				return this.ComputeIndexWithSatelliteByNode(node);
			}
			return this.ComputeIndexWithSatelliteByNode(num) + this.ComputeIndexByNode(node);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0002818C File Offset: 0x0002638C
		private int GetIndexByNodePath(RBTree<K>.NodePath path)
		{
			if (this._inUseSatelliteTreeCount == 0)
			{
				return this.ComputeIndexByNode(path._nodeID);
			}
			if (path._mainTreeNodeID == 0)
			{
				return this.ComputeIndexWithSatelliteByNode(path._nodeID);
			}
			return this.ComputeIndexWithSatelliteByNode(path._mainTreeNodeID) + this.ComputeIndexByNode(path._nodeID);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000281DC File Offset: 0x000263DC
		private int ComputeIndexByNode(int nodeId)
		{
			int num = this.SubTreeSize(this.Left(nodeId));
			while (nodeId != 0)
			{
				int num2 = this.Parent(nodeId);
				if (nodeId == this.Right(num2))
				{
					num += this.SubTreeSize(this.Left(num2)) + 1;
				}
				nodeId = num2;
			}
			return num;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00028224 File Offset: 0x00026424
		private int ComputeIndexWithSatelliteByNode(int nodeId)
		{
			int num = this.SubTreeSize(this.Left(nodeId));
			while (nodeId != 0)
			{
				int num2 = this.Parent(nodeId);
				if (nodeId == this.Right(num2))
				{
					num += this.SubTreeSize(this.Left(num2)) + ((this.Next(num2) == 0) ? 1 : this.SubTreeSize(this.Next(num2)));
				}
				nodeId = num2;
			}
			return num;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00028284 File Offset: 0x00026484
		private RBTree<K>.NodePath GetNodeByIndex(int userIndex)
		{
			int num;
			int mainTreeNodeID;
			if (this._inUseSatelliteTreeCount == 0)
			{
				num = this.ComputeNodeByIndex(this.root, userIndex + 1);
				mainTreeNodeID = 0;
			}
			else
			{
				num = this.ComputeNodeByIndex(userIndex, out mainTreeNodeID);
			}
			if (num != 0)
			{
				return new RBTree<K>.NodePath(num, mainTreeNodeID);
			}
			if (TreeAccessMethod.INDEX_ONLY == this._accessMethod)
			{
				throw ExceptionBuilder.RowOutOfRange(userIndex);
			}
			throw ExceptionBuilder.InternalRBTreeError(RBTreeError.IndexOutOFRangeinGetNodeByIndex);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000282DC File Offset: 0x000264DC
		private int ComputeNodeByIndex(int index, out int satelliteRootId)
		{
			index++;
			satelliteRootId = 0;
			int num = this.root;
			int num2;
			while (num != 0 && ((num2 = this.SubTreeSize(this.Left(num)) + 1) != index || this.Next(num) != 0))
			{
				if (index < num2)
				{
					num = this.Left(num);
				}
				else
				{
					if (this.Next(num) != 0 && index >= num2 && index <= num2 + this.SubTreeSize(this.Next(num)) - 1)
					{
						satelliteRootId = num;
						index = index - num2 + 1;
						return this.ComputeNodeByIndex(this.Next(num), index);
					}
					if (this.Next(num) == 0)
					{
						index -= num2;
					}
					else
					{
						index -= num2 + this.SubTreeSize(this.Next(num)) - 1;
					}
					num = this.Right(num);
				}
			}
			return num;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00028398 File Offset: 0x00026598
		private int ComputeNodeByIndex(int x_id, int index)
		{
			while (x_id != 0)
			{
				int num = this.Left(x_id);
				int num2 = this.SubTreeSize(num) + 1;
				if (index < num2)
				{
					x_id = num;
				}
				else
				{
					if (num2 >= index)
					{
						break;
					}
					x_id = this.Right(x_id);
					index -= num2;
				}
			}
			return x_id;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000283D8 File Offset: 0x000265D8
		public int Insert(K item)
		{
			int newNode = this.GetNewNode(item);
			this.RBInsert(0, newNode, 0, -1, false);
			return newNode;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000283FC File Offset: 0x000265FC
		public int Add(K item)
		{
			int newNode = this.GetNewNode(item);
			this.RBInsert(0, newNode, 0, -1, false);
			return newNode;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0002841E File Offset: 0x0002661E
		public IEnumerator GetEnumerator()
		{
			return new RBTree<K>.RBTreeEnumerator(this);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0002842C File Offset: 0x0002662C
		public int IndexOf(int nodeId, K item)
		{
			int result = -1;
			if (nodeId == 0)
			{
				return result;
			}
			if (this.Key(nodeId) == item)
			{
				return this.GetIndexByNode(nodeId);
			}
			if ((result = this.IndexOf(this.Left(nodeId), item)) != -1)
			{
				return result;
			}
			return this.IndexOf(this.Right(nodeId), item);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00028485 File Offset: 0x00026685
		public int Insert(int position, K item)
		{
			return this.InsertAt(position, item, false);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00028490 File Offset: 0x00026690
		public int InsertAt(int position, K item, bool append)
		{
			int newNode = this.GetNewNode(item);
			this.RBInsert(0, newNode, 0, position, append);
			return newNode;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000284B2 File Offset: 0x000266B2
		public void RemoveAt(int position)
		{
			this.DeleteByIndex(position);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000284BC File Offset: 0x000266BC
		public void Clear()
		{
			this.InitTree();
			this._version++;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000284D4 File Offset: 0x000266D4
		public void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw ExceptionBuilder.ArgumentNull("array");
			}
			if (index < 0)
			{
				throw ExceptionBuilder.ArgumentOutOfRange("index");
			}
			int count = this.Count;
			if (array.Length - index < this.Count)
			{
				throw ExceptionBuilder.InvalidOffsetLength();
			}
			int num = this.Minimum(this.root);
			for (int i = 0; i < count; i++)
			{
				array.SetValue(this.Key(num), index + i);
				num = this.Successor(num);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00028554 File Offset: 0x00026754
		public void CopyTo(K[] array, int index)
		{
			if (array == null)
			{
				throw ExceptionBuilder.ArgumentNull("array");
			}
			if (index < 0)
			{
				throw ExceptionBuilder.ArgumentOutOfRange("index");
			}
			int count = this.Count;
			if (array.Length - index < this.Count)
			{
				throw ExceptionBuilder.InvalidOffsetLength();
			}
			int num = this.Minimum(this.root);
			for (int i = 0; i < count; i++)
			{
				array[index + i] = this.Key(num);
				num = this.Successor(num);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000285C9 File Offset: 0x000267C9
		private void SetRight(int nodeId, int rightNodeId)
		{
			this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._rightId = rightNodeId;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000285ED File Offset: 0x000267ED
		private void SetLeft(int nodeId, int leftNodeId)
		{
			this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._leftId = leftNodeId;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00028611 File Offset: 0x00026811
		private void SetParent(int nodeId, int parentNodeId)
		{
			this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._parentId = parentNodeId;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00028635 File Offset: 0x00026835
		private void SetColor(int nodeId, RBTree<K>.NodeColor color)
		{
			this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._nodeColor = color;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00028659 File Offset: 0x00026859
		private void SetKey(int nodeId, K key)
		{
			this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._keyOfNode = key;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0002867D File Offset: 0x0002687D
		private void SetNext(int nodeId, int nextNodeId)
		{
			this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._nextId = nextNodeId;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000286A1 File Offset: 0x000268A1
		private void SetSubTreeSize(int nodeId, int size)
		{
			this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._subTreeSize = size;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000286C5 File Offset: 0x000268C5
		private void IncreaseSize(int nodeId)
		{
			RBTree<K>.Node[] slots = this._pageTable[nodeId >> 16]._slots;
			int num = nodeId & 65535;
			slots[num]._subTreeSize = slots[num]._subTreeSize + 1;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000286F0 File Offset: 0x000268F0
		private void RecomputeSize(int nodeId)
		{
			int subTreeSize = this.SubTreeSize(this.Left(nodeId)) + this.SubTreeSize(this.Right(nodeId)) + ((this.Next(nodeId) == 0) ? 1 : this.SubTreeSize(this.Next(nodeId)));
			this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._subTreeSize = subTreeSize;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00028755 File Offset: 0x00026955
		private void DecreaseSize(int nodeId)
		{
			RBTree<K>.Node[] slots = this._pageTable[nodeId >> 16]._slots;
			int num = nodeId & 65535;
			slots[num]._subTreeSize = slots[num]._subTreeSize - 1;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0002877D File Offset: 0x0002697D
		public int Right(int nodeId)
		{
			return this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._rightId;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000287A0 File Offset: 0x000269A0
		public int Left(int nodeId)
		{
			return this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._leftId;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000287C3 File Offset: 0x000269C3
		public int Parent(int nodeId)
		{
			return this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._parentId;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000287E6 File Offset: 0x000269E6
		private RBTree<K>.NodeColor color(int nodeId)
		{
			return this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._nodeColor;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00028809 File Offset: 0x00026A09
		public int Next(int nodeId)
		{
			return this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._nextId;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0002882C File Offset: 0x00026A2C
		public int SubTreeSize(int nodeId)
		{
			return this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._subTreeSize;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0002884F File Offset: 0x00026A4F
		public K Key(int nodeId)
		{
			return this._pageTable[nodeId >> 16]._slots[nodeId & 65535]._keyOfNode;
		}

		// Token: 0x04000295 RID: 661
		private RBTree<K>.TreePage[] _pageTable;

		// Token: 0x04000296 RID: 662
		private int[] _pageTableMap;

		// Token: 0x04000297 RID: 663
		private int _inUsePageCount;

		// Token: 0x04000298 RID: 664
		private int _nextFreePageLine;

		// Token: 0x04000299 RID: 665
		public int root;

		// Token: 0x0400029A RID: 666
		private int _version;

		// Token: 0x0400029B RID: 667
		private int _inUseNodeCount;

		// Token: 0x0400029C RID: 668
		private int _inUseSatelliteTreeCount;

		// Token: 0x0400029D RID: 669
		private readonly TreeAccessMethod _accessMethod;

		// Token: 0x02000080 RID: 128
		private enum NodeColor
		{
			// Token: 0x0400029F RID: 671
			red,
			// Token: 0x040002A0 RID: 672
			black
		}

		// Token: 0x02000081 RID: 129
		private struct Node
		{
			// Token: 0x040002A1 RID: 673
			internal int _selfId;

			// Token: 0x040002A2 RID: 674
			internal int _leftId;

			// Token: 0x040002A3 RID: 675
			internal int _rightId;

			// Token: 0x040002A4 RID: 676
			internal int _parentId;

			// Token: 0x040002A5 RID: 677
			internal int _nextId;

			// Token: 0x040002A6 RID: 678
			internal int _subTreeSize;

			// Token: 0x040002A7 RID: 679
			internal K _keyOfNode;

			// Token: 0x040002A8 RID: 680
			internal RBTree<K>.NodeColor _nodeColor;
		}

		// Token: 0x02000082 RID: 130
		private readonly struct NodePath
		{
			// Token: 0x0600081B RID: 2075 RVA: 0x00028872 File Offset: 0x00026A72
			internal NodePath(int nodeID, int mainTreeNodeID)
			{
				this._nodeID = nodeID;
				this._mainTreeNodeID = mainTreeNodeID;
			}

			// Token: 0x040002A9 RID: 681
			internal readonly int _nodeID;

			// Token: 0x040002AA RID: 682
			internal readonly int _mainTreeNodeID;
		}

		// Token: 0x02000083 RID: 131
		private sealed class TreePage
		{
			// Token: 0x0600081C RID: 2076 RVA: 0x00028882 File Offset: 0x00026A82
			internal TreePage(int size)
			{
				if (size > 65536)
				{
					throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidPageSize);
				}
				this._slots = new RBTree<K>.Node[size];
				this._slotMap = new int[(size + 32 - 1) / 32];
			}

			// Token: 0x0600081D RID: 2077 RVA: 0x000288BC File Offset: 0x00026ABC
			internal int AllocSlot(RBTree<K> tree)
			{
				int num = -1;
				if (this._inUseCount < this._slots.Length)
				{
					for (int i = this._nextFreeSlotLine; i < this._slotMap.Length; i++)
					{
						if (this._slotMap[i] < -1)
						{
							int num2 = ~this._slotMap[i] & this._slotMap[i] + 1;
							this._slotMap[i] |= num2;
							this._inUseCount++;
							if (this._inUseCount == this._slots.Length)
							{
								tree.MarkPageFull(this);
							}
							tree._inUseNodeCount++;
							num = RBTree<K>.GetIntValueFromBitMap((uint)num2);
							this._nextFreeSlotLine = i;
							num = i * 32 + num;
							break;
						}
					}
					if (num == -1 && this._nextFreeSlotLine != 0)
					{
						this._nextFreeSlotLine = 0;
						num = this.AllocSlot(tree);
					}
				}
				return num;
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x0600081E RID: 2078 RVA: 0x00028999 File Offset: 0x00026B99
			// (set) Token: 0x0600081F RID: 2079 RVA: 0x000289A1 File Offset: 0x00026BA1
			internal int InUseCount
			{
				get
				{
					return this._inUseCount;
				}
				set
				{
					this._inUseCount = value;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000820 RID: 2080 RVA: 0x000289AA File Offset: 0x00026BAA
			// (set) Token: 0x06000821 RID: 2081 RVA: 0x000289B2 File Offset: 0x00026BB2
			internal int PageId
			{
				get
				{
					return this._pageId;
				}
				set
				{
					this._pageId = value;
				}
			}

			// Token: 0x040002AB RID: 683
			internal readonly RBTree<K>.Node[] _slots;

			// Token: 0x040002AC RID: 684
			internal readonly int[] _slotMap;

			// Token: 0x040002AD RID: 685
			private int _inUseCount;

			// Token: 0x040002AE RID: 686
			private int _pageId;

			// Token: 0x040002AF RID: 687
			private int _nextFreeSlotLine;
		}

		// Token: 0x02000084 RID: 132
		internal struct RBTreeEnumerator : IEnumerator<K>, IDisposable, IEnumerator
		{
			// Token: 0x06000822 RID: 2082 RVA: 0x000289BB File Offset: 0x00026BBB
			internal RBTreeEnumerator(RBTree<K> tree)
			{
				this._tree = tree;
				this._version = tree._version;
				this._index = 0;
				this._mainTreeNodeId = tree.root;
				this._current = default(K);
			}

			// Token: 0x06000823 RID: 2083 RVA: 0x000289F0 File Offset: 0x00026BF0
			internal RBTreeEnumerator(RBTree<K> tree, int position)
			{
				this._tree = tree;
				this._version = tree._version;
				if (position == 0)
				{
					this._index = 0;
					this._mainTreeNodeId = tree.root;
				}
				else
				{
					this._index = tree.ComputeNodeByIndex(position - 1, out this._mainTreeNodeId);
					if (this._index == 0)
					{
						throw ExceptionBuilder.InternalRBTreeError(RBTreeError.IndexOutOFRangeinGetNodeByIndex);
					}
				}
				this._current = default(K);
			}

			// Token: 0x06000824 RID: 2084 RVA: 0x000057B2 File Offset: 0x000039B2
			public void Dispose()
			{
			}

			// Token: 0x06000825 RID: 2085 RVA: 0x00028A5C File Offset: 0x00026C5C
			public bool MoveNext()
			{
				if (this._version != this._tree._version)
				{
					throw ExceptionBuilder.EnumeratorModified();
				}
				bool result = this._tree.Successor(ref this._index, ref this._mainTreeNodeId);
				this._current = this._tree.Key(this._index);
				return result;
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000826 RID: 2086 RVA: 0x00028AB0 File Offset: 0x00026CB0
			public K Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000827 RID: 2087 RVA: 0x00028AB8 File Offset: 0x00026CB8
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000828 RID: 2088 RVA: 0x00028AC5 File Offset: 0x00026CC5
			void IEnumerator.Reset()
			{
				if (this._version != this._tree._version)
				{
					throw ExceptionBuilder.EnumeratorModified();
				}
				this._index = 0;
				this._mainTreeNodeId = this._tree.root;
				this._current = default(K);
			}

			// Token: 0x040002B0 RID: 688
			private readonly RBTree<K> _tree;

			// Token: 0x040002B1 RID: 689
			private readonly int _version;

			// Token: 0x040002B2 RID: 690
			private int _index;

			// Token: 0x040002B3 RID: 691
			private int _mainTreeNodeId;

			// Token: 0x040002B4 RID: 692
			private K _current;
		}
	}
}
