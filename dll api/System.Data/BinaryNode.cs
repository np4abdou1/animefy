﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Globalization;

namespace System.Data
{
	// Token: 0x02000055 RID: 85
	internal class BinaryNode : ExpressionNode
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x0001DC85 File Offset: 0x0001BE85
		internal BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) : base(table)
		{
			this._op = op;
			this._left = left;
			this._right = right;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
			base.BindTable(table);
			this._left.Bind(table, list);
			this._right.Bind(table, list);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001DAEA File Offset: 0x0001BCEA
		internal override object Eval()
		{
			return this.Eval(null, DataRowVersion.Default);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001DCC7 File Offset: 0x0001BEC7
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return this.EvalBinaryOp(this._op, this._left, this._right, row, version, null);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
		internal override object Eval(int[] recordNos)
		{
			return this.EvalBinaryOp(this._op, this._left, this._right, null, DataRowVersion.Default, recordNos);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001DD05 File Offset: 0x0001BF05
		internal override bool IsConstant()
		{
			return this._left.IsConstant() && this._right.IsConstant();
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001DD21 File Offset: 0x0001BF21
		internal override bool IsTableConstant()
		{
			return this._left.IsTableConstant() && this._right.IsTableConstant();
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001DD3D File Offset: 0x0001BF3D
		internal override bool HasLocalAggregate()
		{
			return this._left.HasLocalAggregate() || this._right.HasLocalAggregate();
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001DD59 File Offset: 0x0001BF59
		internal override bool HasRemoteAggregate()
		{
			return this._left.HasRemoteAggregate() || this._right.HasRemoteAggregate();
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001DD75 File Offset: 0x0001BF75
		internal override bool DependsOn(DataColumn column)
		{
			return this._left.DependsOn(column) || this._right.DependsOn(column);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001DD94 File Offset: 0x0001BF94
		internal override ExpressionNode Optimize()
		{
			this._left = this._left.Optimize();
			if (this._op == 13)
			{
				if (this._right is UnaryNode)
				{
					UnaryNode unaryNode = (UnaryNode)this._right;
					if (unaryNode._op != 3)
					{
						throw ExprException.InvalidIsSyntax();
					}
					this._op = 39;
					this._right = unaryNode._right;
				}
				if (!(this._right is ZeroOpNode))
				{
					throw ExprException.InvalidIsSyntax();
				}
				if (((ZeroOpNode)this._right)._op != 32)
				{
					throw ExprException.InvalidIsSyntax();
				}
			}
			else
			{
				this._right = this._right.Optimize();
			}
			if (!this.IsConstant())
			{
				return this;
			}
			object obj = this.Eval();
			if (obj == DBNull.Value)
			{
				return new ZeroOpNode(32);
			}
			if (!(obj is bool))
			{
				return new ConstNode(base.table, ValueType.Object, obj, false);
			}
			if ((bool)obj)
			{
				return new ZeroOpNode(33);
			}
			return new ZeroOpNode(34);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001DE85 File Offset: 0x0001C085
		internal void SetTypeMismatchError(int op, Type left, Type right)
		{
			throw ExprException.TypeMismatchInBinop(op, left, right);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001DE8F File Offset: 0x0001C08F
		private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos)
		{
			if (recordNos == null)
			{
				return expr.Eval(row, version);
			}
			return expr.Eval(recordNos);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001DEA4 File Offset: 0x0001C0A4
		internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op)
		{
			return this.BinaryCompare(vLeft, vRight, resultType, op, null);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001DEB4 File Offset: 0x0001C0B4
		internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer)
		{
			int result = 0;
			try
			{
				if (!DataStorage.IsSqlType(resultType))
				{
					switch (resultType)
					{
					case StorageType.Boolean:
						if (op == 7 || op == 12)
						{
							return Convert.ToInt32(DataExpression.ToBoolean(vLeft), base.FormatProvider) - Convert.ToInt32(DataExpression.ToBoolean(vRight), base.FormatProvider);
						}
						break;
					case StorageType.Char:
						return Convert.ToInt32(vLeft, base.FormatProvider).CompareTo(Convert.ToInt32(vRight, base.FormatProvider));
					case StorageType.SByte:
					case StorageType.Byte:
					case StorageType.Int16:
					case StorageType.UInt16:
					case StorageType.Int32:
						return Convert.ToInt32(vLeft, base.FormatProvider).CompareTo(Convert.ToInt32(vRight, base.FormatProvider));
					case StorageType.UInt32:
					case StorageType.Int64:
					case StorageType.UInt64:
					case StorageType.Decimal:
						return decimal.Compare(Convert.ToDecimal(vLeft, base.FormatProvider), Convert.ToDecimal(vRight, base.FormatProvider));
					case StorageType.Single:
						return Convert.ToSingle(vLeft, base.FormatProvider).CompareTo(Convert.ToSingle(vRight, base.FormatProvider));
					case StorageType.Double:
						return Convert.ToDouble(vLeft, base.FormatProvider).CompareTo(Convert.ToDouble(vRight, base.FormatProvider));
					case StorageType.DateTime:
						return DateTime.Compare(Convert.ToDateTime(vLeft, base.FormatProvider), Convert.ToDateTime(vRight, base.FormatProvider));
					case StorageType.String:
						return base.table.Compare(Convert.ToString(vLeft, base.FormatProvider), Convert.ToString(vRight, base.FormatProvider), comparer);
					case StorageType.Guid:
						return ((Guid)vLeft).CompareTo((Guid)vRight);
					case StorageType.DateTimeOffset:
						return DateTimeOffset.Compare((DateTimeOffset)vLeft, (DateTimeOffset)vRight);
					}
				}
				else
				{
					switch (resultType)
					{
					case StorageType.SByte:
					case StorageType.Byte:
					case StorageType.Int16:
					case StorageType.UInt16:
					case StorageType.Int32:
					case StorageType.SqlByte:
					case StorageType.SqlInt16:
					case StorageType.SqlInt32:
						return SqlConvert.ConvertToSqlInt32(vLeft).CompareTo(SqlConvert.ConvertToSqlInt32(vRight));
					case StorageType.UInt32:
					case StorageType.Int64:
					case StorageType.SqlInt64:
						return SqlConvert.ConvertToSqlInt64(vLeft).CompareTo(SqlConvert.ConvertToSqlInt64(vRight));
					case StorageType.UInt64:
					case StorageType.SqlDecimal:
						return SqlConvert.ConvertToSqlDecimal(vLeft).CompareTo(SqlConvert.ConvertToSqlDecimal(vRight));
					case StorageType.SqlBinary:
						return SqlConvert.ConvertToSqlBinary(vLeft).CompareTo(SqlConvert.ConvertToSqlBinary(vRight));
					case StorageType.SqlBoolean:
						if (op == 7 || op == 12)
						{
							result = 1;
							if ((vLeft.GetType() == typeof(SqlBoolean) && (vRight.GetType() == typeof(SqlBoolean) || vRight.GetType() == typeof(bool))) || (vRight.GetType() == typeof(SqlBoolean) && (vLeft.GetType() == typeof(SqlBoolean) || vLeft.GetType() == typeof(bool))))
							{
								return SqlConvert.ConvertToSqlBoolean(vLeft).CompareTo(SqlConvert.ConvertToSqlBoolean(vRight));
							}
						}
						break;
					case StorageType.SqlDateTime:
						return SqlConvert.ConvertToSqlDateTime(vLeft).CompareTo(SqlConvert.ConvertToSqlDateTime(vRight));
					case StorageType.SqlDouble:
						return SqlConvert.ConvertToSqlDouble(vLeft).CompareTo(SqlConvert.ConvertToSqlDouble(vRight));
					case StorageType.SqlGuid:
						return ((SqlGuid)vLeft).CompareTo(vRight);
					case StorageType.SqlMoney:
						return SqlConvert.ConvertToSqlMoney(vLeft).CompareTo(SqlConvert.ConvertToSqlMoney(vRight));
					case StorageType.SqlSingle:
						return SqlConvert.ConvertToSqlSingle(vLeft).CompareTo(SqlConvert.ConvertToSqlSingle(vRight));
					case StorageType.SqlString:
						return base.table.Compare(vLeft.ToString(), vRight.ToString());
					}
				}
			}
			catch (ArgumentException e)
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e);
			}
			catch (FormatException e2)
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e2);
			}
			catch (InvalidCastException e3)
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e3);
			}
			catch (OverflowException e4)
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e4);
			}
			catch (EvaluateException e5)
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e5);
			}
			this.SetTypeMismatchError(op, vLeft.GetType(), vRight.GetType());
			return result;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos)
		{
			object obj;
			object obj2;
			StorageType storageType3;
			if (op != 27 && op != 26 && op != 5 && op != 13 && op != 39)
			{
				obj = BinaryNode.Eval(left, row, version, recordNos);
				obj2 = BinaryNode.Eval(right, row, version, recordNos);
				Type type = obj.GetType();
				Type type2 = obj2.GetType();
				StorageType storageType = DataStorage.GetStorageType(type);
				StorageType storageType2 = DataStorage.GetStorageType(type2);
				bool flag = DataStorage.IsSqlType(storageType);
				bool flag2 = DataStorage.IsSqlType(storageType2);
				if (flag && DataStorage.IsObjectSqlNull(obj))
				{
					return obj;
				}
				if (flag2 && DataStorage.IsObjectSqlNull(obj2))
				{
					return obj2;
				}
				if (obj == DBNull.Value || obj2 == DBNull.Value)
				{
					return DBNull.Value;
				}
				if (flag || flag2)
				{
					storageType3 = this.ResultSqlType(storageType, storageType2, left is ConstNode, right is ConstNode, op);
				}
				else
				{
					storageType3 = this.ResultType(storageType, storageType2, left is ConstNode, right is ConstNode, op);
				}
				if (storageType3 == StorageType.Empty)
				{
					this.SetTypeMismatchError(op, type, type2);
				}
			}
			else
			{
				obj2 = (obj = DBNull.Value);
				storageType3 = StorageType.Empty;
			}
			object obj3 = DBNull.Value;
			bool flag3 = false;
			try
			{
				switch (op)
				{
				case 5:
				{
					if (!(right is FunctionNode))
					{
						throw ExprException.InWithoutParentheses();
					}
					obj = BinaryNode.Eval(left, row, version, recordNos);
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)))
					{
						return DBNull.Value;
					}
					obj3 = false;
					FunctionNode functionNode = (FunctionNode)right;
					for (int i = 0; i < functionNode._argumentCount; i++)
					{
						obj2 = functionNode._arguments[i].Eval();
						if (obj2 != DBNull.Value && (!right.IsSqlColumn || !DataStorage.IsObjectSqlNull(obj2)))
						{
							storageType3 = DataStorage.GetStorageType(obj.GetType());
							if (this.BinaryCompare(obj, obj2, storageType3, 7) == 0)
							{
								obj3 = true;
								break;
							}
						}
					}
					goto IL_16EB;
				}
				case 6:
				case 14:
				case 19:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
					break;
				case 7:
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)) || obj2 == DBNull.Value || (right.IsSqlColumn && DataStorage.IsObjectSqlNull(obj2)))
					{
						return DBNull.Value;
					}
					return this.BinaryCompare(obj, obj2, storageType3, 7) == 0;
				case 8:
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)) || obj2 == DBNull.Value || (right.IsSqlColumn && DataStorage.IsObjectSqlNull(obj2)))
					{
						return DBNull.Value;
					}
					return 0 < this.BinaryCompare(obj, obj2, storageType3, op);
				case 9:
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)) || obj2 == DBNull.Value || (right.IsSqlColumn && DataStorage.IsObjectSqlNull(obj2)))
					{
						return DBNull.Value;
					}
					return 0 > this.BinaryCompare(obj, obj2, storageType3, op);
				case 10:
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)) || obj2 == DBNull.Value || (right.IsSqlColumn && DataStorage.IsObjectSqlNull(obj2)))
					{
						return DBNull.Value;
					}
					return 0 <= this.BinaryCompare(obj, obj2, storageType3, op);
				case 11:
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)) || obj2 == DBNull.Value || (right.IsSqlColumn && DataStorage.IsObjectSqlNull(obj2)))
					{
						return DBNull.Value;
					}
					return 0 >= this.BinaryCompare(obj, obj2, storageType3, op);
				case 12:
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)) || obj2 == DBNull.Value || (right.IsSqlColumn && DataStorage.IsObjectSqlNull(obj2)))
					{
						return DBNull.Value;
					}
					return this.BinaryCompare(obj, obj2, storageType3, op) != 0;
				case 13:
					obj = BinaryNode.Eval(left, row, version, recordNos);
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)))
					{
						return true;
					}
					return false;
				case 15:
					switch (storageType3)
					{
					case StorageType.Char:
					case StorageType.String:
						obj3 = Convert.ToString(obj, base.FormatProvider) + Convert.ToString(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.SByte:
						obj3 = Convert.ToSByte((int)(Convert.ToSByte(obj, base.FormatProvider) + Convert.ToSByte(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Byte:
						obj3 = Convert.ToByte((int)(Convert.ToByte(obj, base.FormatProvider) + Convert.ToByte(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int16:
						obj3 = Convert.ToInt16((int)(Convert.ToInt16(obj, base.FormatProvider) + Convert.ToInt16(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.UInt16:
						obj3 = Convert.ToUInt16((int)(Convert.ToUInt16(obj, base.FormatProvider) + Convert.ToUInt16(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int32:
						obj3 = checked(Convert.ToInt32(obj, base.FormatProvider) + Convert.ToInt32(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.UInt32:
						obj3 = checked(Convert.ToUInt32(obj, base.FormatProvider) + Convert.ToUInt32(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.Int64:
						obj3 = checked(Convert.ToInt64(obj, base.FormatProvider) + Convert.ToInt64(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.UInt64:
						obj3 = checked(Convert.ToUInt64(obj, base.FormatProvider) + Convert.ToUInt64(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.Single:
						obj3 = Convert.ToSingle(obj, base.FormatProvider) + Convert.ToSingle(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Double:
						obj3 = Convert.ToDouble(obj, base.FormatProvider) + Convert.ToDouble(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Decimal:
						obj3 = Convert.ToDecimal(obj, base.FormatProvider) + Convert.ToDecimal(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.DateTime:
						if (obj is TimeSpan && obj2 is DateTime)
						{
							obj3 = (DateTime)obj2 + (TimeSpan)obj;
							goto IL_16EB;
						}
						if (obj is DateTime && obj2 is TimeSpan)
						{
							obj3 = (DateTime)obj + (TimeSpan)obj2;
							goto IL_16EB;
						}
						flag3 = true;
						goto IL_16EB;
					case StorageType.TimeSpan:
						obj3 = (TimeSpan)obj + (TimeSpan)obj2;
						goto IL_16EB;
					case StorageType.SqlByte:
						obj3 = SqlConvert.ConvertToSqlByte(obj) + SqlConvert.ConvertToSqlByte(obj2);
						goto IL_16EB;
					case StorageType.SqlDateTime:
						if (obj is TimeSpan && obj2 is SqlDateTime)
						{
							obj3 = SqlConvert.ConvertToSqlDateTime(SqlConvert.ConvertToSqlDateTime(obj2).Value + (TimeSpan)obj);
							goto IL_16EB;
						}
						if (obj is SqlDateTime && obj2 is TimeSpan)
						{
							obj3 = SqlConvert.ConvertToSqlDateTime(SqlConvert.ConvertToSqlDateTime(obj).Value + (TimeSpan)obj2);
							goto IL_16EB;
						}
						flag3 = true;
						goto IL_16EB;
					case StorageType.SqlDecimal:
						obj3 = SqlConvert.ConvertToSqlDecimal(obj) + SqlConvert.ConvertToSqlDecimal(obj2);
						goto IL_16EB;
					case StorageType.SqlDouble:
						obj3 = SqlConvert.ConvertToSqlDouble(obj) + SqlConvert.ConvertToSqlDouble(obj2);
						goto IL_16EB;
					case StorageType.SqlInt16:
						obj3 = SqlConvert.ConvertToSqlInt16(obj) + SqlConvert.ConvertToSqlInt16(obj2);
						goto IL_16EB;
					case StorageType.SqlInt32:
						obj3 = SqlConvert.ConvertToSqlInt32(obj) + SqlConvert.ConvertToSqlInt32(obj2);
						goto IL_16EB;
					case StorageType.SqlInt64:
						obj3 = SqlConvert.ConvertToSqlInt64(obj) + SqlConvert.ConvertToSqlInt64(obj2);
						goto IL_16EB;
					case StorageType.SqlMoney:
						obj3 = SqlConvert.ConvertToSqlMoney(obj) + SqlConvert.ConvertToSqlMoney(obj2);
						goto IL_16EB;
					case StorageType.SqlSingle:
						obj3 = SqlConvert.ConvertToSqlSingle(obj) + SqlConvert.ConvertToSqlSingle(obj2);
						goto IL_16EB;
					case StorageType.SqlString:
						obj3 = SqlConvert.ConvertToSqlString(obj) + SqlConvert.ConvertToSqlString(obj2);
						goto IL_16EB;
					}
					flag3 = true;
					goto IL_16EB;
				case 16:
					switch (storageType3)
					{
					case StorageType.SByte:
						obj3 = Convert.ToSByte((int)(Convert.ToSByte(obj, base.FormatProvider) - Convert.ToSByte(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Byte:
						obj3 = Convert.ToByte((int)(Convert.ToByte(obj, base.FormatProvider) - Convert.ToByte(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int16:
						obj3 = Convert.ToInt16((int)(Convert.ToInt16(obj, base.FormatProvider) - Convert.ToInt16(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.UInt16:
						obj3 = Convert.ToUInt16((int)(Convert.ToUInt16(obj, base.FormatProvider) - Convert.ToUInt16(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int32:
						obj3 = checked(Convert.ToInt32(obj, base.FormatProvider) - Convert.ToInt32(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.UInt32:
						obj3 = checked(Convert.ToUInt32(obj, base.FormatProvider) - Convert.ToUInt32(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.Int64:
						obj3 = checked(Convert.ToInt64(obj, base.FormatProvider) - Convert.ToInt64(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.UInt64:
						obj3 = checked(Convert.ToUInt64(obj, base.FormatProvider) - Convert.ToUInt64(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.Single:
						obj3 = Convert.ToSingle(obj, base.FormatProvider) - Convert.ToSingle(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Double:
						obj3 = Convert.ToDouble(obj, base.FormatProvider) - Convert.ToDouble(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Decimal:
						obj3 = Convert.ToDecimal(obj, base.FormatProvider) - Convert.ToDecimal(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.DateTime:
						obj3 = (DateTime)obj - (TimeSpan)obj2;
						goto IL_16EB;
					case StorageType.TimeSpan:
						if (obj is DateTime)
						{
							obj3 = (DateTime)obj - (DateTime)obj2;
							goto IL_16EB;
						}
						obj3 = (TimeSpan)obj - (TimeSpan)obj2;
						goto IL_16EB;
					case StorageType.SqlByte:
						obj3 = SqlConvert.ConvertToSqlByte(obj) - SqlConvert.ConvertToSqlByte(obj2);
						goto IL_16EB;
					case StorageType.SqlDateTime:
						if (obj is TimeSpan && obj2 is SqlDateTime)
						{
							obj3 = SqlConvert.ConvertToSqlDateTime(SqlConvert.ConvertToSqlDateTime(obj2).Value - (TimeSpan)obj);
							goto IL_16EB;
						}
						if (obj is SqlDateTime && obj2 is TimeSpan)
						{
							obj3 = SqlConvert.ConvertToSqlDateTime(SqlConvert.ConvertToSqlDateTime(obj).Value - (TimeSpan)obj2);
							goto IL_16EB;
						}
						flag3 = true;
						goto IL_16EB;
					case StorageType.SqlDecimal:
						obj3 = SqlConvert.ConvertToSqlDecimal(obj) - SqlConvert.ConvertToSqlDecimal(obj2);
						goto IL_16EB;
					case StorageType.SqlDouble:
						obj3 = SqlConvert.ConvertToSqlDouble(obj) - SqlConvert.ConvertToSqlDouble(obj2);
						goto IL_16EB;
					case StorageType.SqlInt16:
						obj3 = SqlConvert.ConvertToSqlInt16(obj) - SqlConvert.ConvertToSqlInt16(obj2);
						goto IL_16EB;
					case StorageType.SqlInt32:
						obj3 = SqlConvert.ConvertToSqlInt32(obj) - SqlConvert.ConvertToSqlInt32(obj2);
						goto IL_16EB;
					case StorageType.SqlInt64:
						obj3 = SqlConvert.ConvertToSqlInt64(obj) - SqlConvert.ConvertToSqlInt64(obj2);
						goto IL_16EB;
					case StorageType.SqlMoney:
						obj3 = SqlConvert.ConvertToSqlMoney(obj) - SqlConvert.ConvertToSqlMoney(obj2);
						goto IL_16EB;
					case StorageType.SqlSingle:
						obj3 = SqlConvert.ConvertToSqlSingle(obj) - SqlConvert.ConvertToSqlSingle(obj2);
						goto IL_16EB;
					}
					flag3 = true;
					goto IL_16EB;
				case 17:
					switch (storageType3)
					{
					case StorageType.SByte:
						obj3 = Convert.ToSByte((int)(Convert.ToSByte(obj, base.FormatProvider) * Convert.ToSByte(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Byte:
						obj3 = Convert.ToByte((int)(Convert.ToByte(obj, base.FormatProvider) * Convert.ToByte(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int16:
						obj3 = Convert.ToInt16((int)(Convert.ToInt16(obj, base.FormatProvider) * Convert.ToInt16(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.UInt16:
						obj3 = Convert.ToUInt16((int)(Convert.ToUInt16(obj, base.FormatProvider) * Convert.ToUInt16(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int32:
						obj3 = checked(Convert.ToInt32(obj, base.FormatProvider) * Convert.ToInt32(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.UInt32:
						obj3 = checked(Convert.ToUInt32(obj, base.FormatProvider) * Convert.ToUInt32(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.Int64:
						obj3 = checked(Convert.ToInt64(obj, base.FormatProvider) * Convert.ToInt64(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.UInt64:
						obj3 = checked(Convert.ToUInt64(obj, base.FormatProvider) * Convert.ToUInt64(obj2, base.FormatProvider));
						goto IL_16EB;
					case StorageType.Single:
						obj3 = Convert.ToSingle(obj, base.FormatProvider) * Convert.ToSingle(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Double:
						obj3 = Convert.ToDouble(obj, base.FormatProvider) * Convert.ToDouble(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Decimal:
						obj3 = Convert.ToDecimal(obj, base.FormatProvider) * Convert.ToDecimal(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.SqlByte:
						obj3 = SqlConvert.ConvertToSqlByte(obj) * SqlConvert.ConvertToSqlByte(obj2);
						goto IL_16EB;
					case StorageType.SqlDecimal:
						obj3 = SqlConvert.ConvertToSqlDecimal(obj) * SqlConvert.ConvertToSqlDecimal(obj2);
						goto IL_16EB;
					case StorageType.SqlDouble:
						obj3 = SqlConvert.ConvertToSqlDouble(obj) * SqlConvert.ConvertToSqlDouble(obj2);
						goto IL_16EB;
					case StorageType.SqlInt16:
						obj3 = SqlConvert.ConvertToSqlInt16(obj) * SqlConvert.ConvertToSqlInt16(obj2);
						goto IL_16EB;
					case StorageType.SqlInt32:
						obj3 = SqlConvert.ConvertToSqlInt32(obj) * SqlConvert.ConvertToSqlInt32(obj2);
						goto IL_16EB;
					case StorageType.SqlInt64:
						obj3 = SqlConvert.ConvertToSqlInt64(obj) * SqlConvert.ConvertToSqlInt64(obj2);
						goto IL_16EB;
					case StorageType.SqlMoney:
						obj3 = SqlConvert.ConvertToSqlMoney(obj) * SqlConvert.ConvertToSqlMoney(obj2);
						goto IL_16EB;
					case StorageType.SqlSingle:
						obj3 = SqlConvert.ConvertToSqlSingle(obj) * SqlConvert.ConvertToSqlSingle(obj2);
						goto IL_16EB;
					}
					flag3 = true;
					goto IL_16EB;
				case 18:
					switch (storageType3)
					{
					case StorageType.SByte:
						obj3 = Convert.ToSByte((int)(Convert.ToSByte(obj, base.FormatProvider) / Convert.ToSByte(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Byte:
						obj3 = Convert.ToByte((int)(Convert.ToByte(obj, base.FormatProvider) / Convert.ToByte(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int16:
						obj3 = Convert.ToInt16((int)(Convert.ToInt16(obj, base.FormatProvider) / Convert.ToInt16(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.UInt16:
						obj3 = Convert.ToUInt16((int)(Convert.ToUInt16(obj, base.FormatProvider) / Convert.ToUInt16(obj2, base.FormatProvider)), base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int32:
						obj3 = Convert.ToInt32(obj, base.FormatProvider) / Convert.ToInt32(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.UInt32:
						obj3 = Convert.ToUInt32(obj, base.FormatProvider) / Convert.ToUInt32(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Int64:
						obj3 = Convert.ToInt64(obj, base.FormatProvider) / Convert.ToInt64(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.UInt64:
						obj3 = Convert.ToUInt64(obj, base.FormatProvider) / Convert.ToUInt64(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Single:
						obj3 = Convert.ToSingle(obj, base.FormatProvider) / Convert.ToSingle(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.Double:
					{
						double num = Convert.ToDouble(obj2, base.FormatProvider);
						obj3 = Convert.ToDouble(obj, base.FormatProvider) / num;
						goto IL_16EB;
					}
					case StorageType.Decimal:
						obj3 = Convert.ToDecimal(obj, base.FormatProvider) / Convert.ToDecimal(obj2, base.FormatProvider);
						goto IL_16EB;
					case StorageType.SqlByte:
						obj3 = SqlConvert.ConvertToSqlByte(obj) / SqlConvert.ConvertToSqlByte(obj2);
						goto IL_16EB;
					case StorageType.SqlDecimal:
						obj3 = SqlConvert.ConvertToSqlDecimal(obj) / SqlConvert.ConvertToSqlDecimal(obj2);
						goto IL_16EB;
					case StorageType.SqlDouble:
						obj3 = SqlConvert.ConvertToSqlDouble(obj) / SqlConvert.ConvertToSqlDouble(obj2);
						goto IL_16EB;
					case StorageType.SqlInt16:
						obj3 = SqlConvert.ConvertToSqlInt16(obj) / SqlConvert.ConvertToSqlInt16(obj2);
						goto IL_16EB;
					case StorageType.SqlInt32:
						obj3 = SqlConvert.ConvertToSqlInt32(obj) / SqlConvert.ConvertToSqlInt32(obj2);
						goto IL_16EB;
					case StorageType.SqlInt64:
						obj3 = SqlConvert.ConvertToSqlInt64(obj) / SqlConvert.ConvertToSqlInt64(obj2);
						goto IL_16EB;
					case StorageType.SqlMoney:
						obj3 = SqlConvert.ConvertToSqlMoney(obj) / SqlConvert.ConvertToSqlMoney(obj2);
						goto IL_16EB;
					case StorageType.SqlSingle:
						obj3 = SqlConvert.ConvertToSqlSingle(obj) / SqlConvert.ConvertToSqlSingle(obj2);
						goto IL_16EB;
					}
					flag3 = true;
					goto IL_16EB;
				case 20:
				{
					if (!ExpressionNode.IsIntegerSql(storageType3))
					{
						flag3 = true;
						goto IL_16EB;
					}
					if (storageType3 == StorageType.UInt64)
					{
						obj3 = Convert.ToUInt64(obj, base.FormatProvider) % Convert.ToUInt64(obj2, base.FormatProvider);
						goto IL_16EB;
					}
					if (!DataStorage.IsSqlType(storageType3))
					{
						obj3 = Convert.ToInt64(obj, base.FormatProvider) % Convert.ToInt64(obj2, base.FormatProvider);
						obj3 = Convert.ChangeType(obj3, DataStorage.GetTypeStorage(storageType3), base.FormatProvider);
						goto IL_16EB;
					}
					SqlInt64 sqlInt = SqlConvert.ConvertToSqlInt64(obj) % SqlConvert.ConvertToSqlInt64(obj2);
					if (storageType3 == StorageType.SqlInt32)
					{
						obj3 = sqlInt.ToSqlInt32();
						goto IL_16EB;
					}
					if (storageType3 == StorageType.SqlInt16)
					{
						obj3 = sqlInt.ToSqlInt16();
						goto IL_16EB;
					}
					if (storageType3 == StorageType.SqlByte)
					{
						obj3 = sqlInt.ToSqlByte();
						goto IL_16EB;
					}
					obj3 = sqlInt;
					goto IL_16EB;
				}
				case 26:
					obj = BinaryNode.Eval(left, row, version, recordNos);
					if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)))
					{
						return DBNull.Value;
					}
					if (!(obj is bool) && !(obj is SqlBoolean))
					{
						obj2 = BinaryNode.Eval(right, row, version, recordNos);
						flag3 = true;
						goto IL_16EB;
					}
					if (obj is bool)
					{
						if (!(bool)obj)
						{
							obj3 = false;
							goto IL_16EB;
						}
					}
					else if (((SqlBoolean)obj).IsFalse)
					{
						obj3 = false;
						goto IL_16EB;
					}
					obj2 = BinaryNode.Eval(right, row, version, recordNos);
					if (obj2 == DBNull.Value || (right.IsSqlColumn && DataStorage.IsObjectSqlNull(obj2)))
					{
						return DBNull.Value;
					}
					if (!(obj2 is bool) && !(obj2 is SqlBoolean))
					{
						flag3 = true;
						goto IL_16EB;
					}
					if (obj2 is bool)
					{
						obj3 = (bool)obj2;
						goto IL_16EB;
					}
					obj3 = ((SqlBoolean)obj2).IsTrue;
					goto IL_16EB;
				case 27:
					obj = BinaryNode.Eval(left, row, version, recordNos);
					if (obj != DBNull.Value && !DataStorage.IsObjectSqlNull(obj))
					{
						if (!(obj is bool) && !(obj is SqlBoolean))
						{
							obj2 = BinaryNode.Eval(right, row, version, recordNos);
							flag3 = true;
							goto IL_16EB;
						}
						if ((bool)obj)
						{
							obj3 = true;
							goto IL_16EB;
						}
					}
					obj2 = BinaryNode.Eval(right, row, version, recordNos);
					if (obj2 == DBNull.Value || DataStorage.IsObjectSqlNull(obj2))
					{
						return obj;
					}
					if (obj == DBNull.Value || DataStorage.IsObjectSqlNull(obj))
					{
						return obj2;
					}
					if (!(obj2 is bool) && !(obj2 is SqlBoolean))
					{
						flag3 = true;
						goto IL_16EB;
					}
					obj3 = ((obj2 is bool) ? ((bool)obj2) : ((SqlBoolean)obj2).IsTrue);
					goto IL_16EB;
				default:
					if (op == 39)
					{
						obj = BinaryNode.Eval(left, row, version, recordNos);
						if (obj == DBNull.Value || (left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj)))
						{
							return false;
						}
						return true;
					}
					break;
				}
				throw ExprException.UnsupportedOperator(op);
				IL_16EB:;
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(DataStorage.GetTypeStorage(storageType3));
			}
			if (flag3)
			{
				this.SetTypeMismatchError(op, obj.GetType(), obj2.GetType());
			}
			return obj3;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001FB00 File Offset: 0x0001DD00
		private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType)
		{
			switch (storageType)
			{
			case StorageType.Boolean:
				return BinaryNode.DataTypePrecedence.Boolean;
			case StorageType.Char:
				return BinaryNode.DataTypePrecedence.Char;
			case StorageType.SByte:
				return BinaryNode.DataTypePrecedence.SByte;
			case StorageType.Byte:
				return BinaryNode.DataTypePrecedence.Byte;
			case StorageType.Int16:
				return BinaryNode.DataTypePrecedence.Int16;
			case StorageType.UInt16:
				return BinaryNode.DataTypePrecedence.UInt16;
			case StorageType.Int32:
				return BinaryNode.DataTypePrecedence.Int32;
			case StorageType.UInt32:
				return BinaryNode.DataTypePrecedence.UInt32;
			case StorageType.Int64:
				return BinaryNode.DataTypePrecedence.Int64;
			case StorageType.UInt64:
				return BinaryNode.DataTypePrecedence.UInt64;
			case StorageType.Single:
				return BinaryNode.DataTypePrecedence.Single;
			case StorageType.Double:
				return BinaryNode.DataTypePrecedence.Double;
			case StorageType.Decimal:
				return BinaryNode.DataTypePrecedence.Decimal;
			case StorageType.DateTime:
				return BinaryNode.DataTypePrecedence.DateTime;
			case StorageType.TimeSpan:
				return BinaryNode.DataTypePrecedence.TimeSpan;
			case StorageType.String:
				return BinaryNode.DataTypePrecedence.String;
			case StorageType.DateTimeOffset:
				return BinaryNode.DataTypePrecedence.DateTimeOffset;
			case StorageType.SqlBinary:
				return BinaryNode.DataTypePrecedence.SqlBinary;
			case StorageType.SqlBoolean:
				return BinaryNode.DataTypePrecedence.SqlBoolean;
			case StorageType.SqlByte:
				return BinaryNode.DataTypePrecedence.SqlByte;
			case StorageType.SqlBytes:
				return BinaryNode.DataTypePrecedence.SqlBytes;
			case StorageType.SqlChars:
				return BinaryNode.DataTypePrecedence.SqlChars;
			case StorageType.SqlDateTime:
				return BinaryNode.DataTypePrecedence.SqlDateTime;
			case StorageType.SqlDecimal:
				return BinaryNode.DataTypePrecedence.SqlDecimal;
			case StorageType.SqlDouble:
				return BinaryNode.DataTypePrecedence.SqlDouble;
			case StorageType.SqlGuid:
				return BinaryNode.DataTypePrecedence.SqlGuid;
			case StorageType.SqlInt16:
				return BinaryNode.DataTypePrecedence.SqlInt16;
			case StorageType.SqlInt32:
				return BinaryNode.DataTypePrecedence.SqlInt32;
			case StorageType.SqlInt64:
				return BinaryNode.DataTypePrecedence.SqlInt64;
			case StorageType.SqlMoney:
				return BinaryNode.DataTypePrecedence.SqlMoney;
			case StorageType.SqlSingle:
				return BinaryNode.DataTypePrecedence.SqlSingle;
			case StorageType.SqlString:
				return BinaryNode.DataTypePrecedence.SqlString;
			}
			return BinaryNode.DataTypePrecedence.Error;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001FC14 File Offset: 0x0001DE14
		private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code)
		{
			switch (code)
			{
			case BinaryNode.DataTypePrecedence.SqlBinary:
				return StorageType.SqlBinary;
			default:
				return StorageType.Empty;
			case BinaryNode.DataTypePrecedence.Char:
				return StorageType.Char;
			case BinaryNode.DataTypePrecedence.String:
				return StorageType.String;
			case BinaryNode.DataTypePrecedence.SqlString:
				return StorageType.SqlString;
			case BinaryNode.DataTypePrecedence.SqlGuid:
				return StorageType.SqlGuid;
			case BinaryNode.DataTypePrecedence.Boolean:
				return StorageType.Boolean;
			case BinaryNode.DataTypePrecedence.SqlBoolean:
				return StorageType.SqlBoolean;
			case BinaryNode.DataTypePrecedence.SByte:
				return StorageType.SByte;
			case BinaryNode.DataTypePrecedence.SqlByte:
				return StorageType.SqlByte;
			case BinaryNode.DataTypePrecedence.Byte:
				return StorageType.Byte;
			case BinaryNode.DataTypePrecedence.Int16:
				return StorageType.Int16;
			case BinaryNode.DataTypePrecedence.SqlInt16:
				return StorageType.SqlInt16;
			case BinaryNode.DataTypePrecedence.UInt16:
				return StorageType.UInt16;
			case BinaryNode.DataTypePrecedence.Int32:
				return StorageType.Int32;
			case BinaryNode.DataTypePrecedence.SqlInt32:
				return StorageType.SqlInt32;
			case BinaryNode.DataTypePrecedence.UInt32:
				return StorageType.UInt32;
			case BinaryNode.DataTypePrecedence.Int64:
				return StorageType.Int64;
			case BinaryNode.DataTypePrecedence.SqlInt64:
				return StorageType.SqlInt64;
			case BinaryNode.DataTypePrecedence.UInt64:
				return StorageType.UInt64;
			case BinaryNode.DataTypePrecedence.SqlMoney:
				return StorageType.SqlMoney;
			case BinaryNode.DataTypePrecedence.Decimal:
				return StorageType.Decimal;
			case BinaryNode.DataTypePrecedence.SqlDecimal:
				return StorageType.SqlDecimal;
			case BinaryNode.DataTypePrecedence.Single:
				return StorageType.Single;
			case BinaryNode.DataTypePrecedence.SqlSingle:
				return StorageType.SqlSingle;
			case BinaryNode.DataTypePrecedence.Double:
				return StorageType.Double;
			case BinaryNode.DataTypePrecedence.SqlDouble:
				return StorageType.SqlDouble;
			case BinaryNode.DataTypePrecedence.TimeSpan:
				return StorageType.TimeSpan;
			case BinaryNode.DataTypePrecedence.DateTime:
				return StorageType.DateTime;
			case BinaryNode.DataTypePrecedence.DateTimeOffset:
				return StorageType.DateTimeOffset;
			case BinaryNode.DataTypePrecedence.SqlDateTime:
				return StorageType.SqlDateTime;
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001FD0F File Offset: 0x0001DF0F
		private bool IsMixed(StorageType left, StorageType right)
		{
			return (ExpressionNode.IsSigned(left) && ExpressionNode.IsUnsigned(right)) || (ExpressionNode.IsUnsigned(left) && ExpressionNode.IsSigned(right));
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001FD33 File Offset: 0x0001DF33
		private bool IsMixedSql(StorageType left, StorageType right)
		{
			return (ExpressionNode.IsSignedSql(left) && ExpressionNode.IsUnsignedSql(right)) || (ExpressionNode.IsUnsignedSql(left) && ExpressionNode.IsSignedSql(right));
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001FD58 File Offset: 0x0001DF58
		internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op)
		{
			if (left == StorageType.Guid && right == StorageType.Guid && Operators.IsRelational(op))
			{
				return left;
			}
			if (left == StorageType.String && right == StorageType.Guid && Operators.IsRelational(op))
			{
				return left;
			}
			if (left == StorageType.Guid && right == StorageType.String && Operators.IsRelational(op))
			{
				return right;
			}
			int precedence = (int)this.GetPrecedence(left);
			if (precedence == 0)
			{
				return StorageType.Empty;
			}
			int precedence2 = (int)this.GetPrecedence(right);
			if (precedence2 == 0)
			{
				return StorageType.Empty;
			}
			if (Operators.IsLogical(op))
			{
				if (left == StorageType.Boolean && right == StorageType.Boolean)
				{
					return StorageType.Boolean;
				}
				return StorageType.Empty;
			}
			else if (left == StorageType.DateTimeOffset || right == StorageType.DateTimeOffset)
			{
				if (Operators.IsRelational(op) && left == StorageType.DateTimeOffset && right == StorageType.DateTimeOffset)
				{
					return StorageType.DateTimeOffset;
				}
				return StorageType.Empty;
			}
			else
			{
				if (op == 15 && (left == StorageType.String || right == StorageType.String))
				{
					return StorageType.String;
				}
				BinaryNode.DataTypePrecedence dataTypePrecedence = (BinaryNode.DataTypePrecedence)Math.Max(precedence, precedence2);
				StorageType precedenceType = BinaryNode.GetPrecedenceType(dataTypePrecedence);
				if (Operators.IsArithmetical(op) && precedenceType != StorageType.String && precedenceType != StorageType.Char)
				{
					if (!ExpressionNode.IsNumeric(left))
					{
						return StorageType.Empty;
					}
					if (!ExpressionNode.IsNumeric(right))
					{
						return StorageType.Empty;
					}
				}
				if (op == 18 && ExpressionNode.IsInteger(precedenceType))
				{
					return StorageType.Double;
				}
				if (this.IsMixed(left, right))
				{
					if (lc && !rc)
					{
						return right;
					}
					if (!lc && rc)
					{
						return left;
					}
					if (ExpressionNode.IsUnsigned(precedenceType))
					{
						if (dataTypePrecedence >= BinaryNode.DataTypePrecedence.UInt64)
						{
							throw ExprException.AmbiguousBinop(op, DataStorage.GetTypeStorage(left), DataStorage.GetTypeStorage(right));
						}
						precedenceType = BinaryNode.GetPrecedenceType(dataTypePrecedence + 1);
					}
				}
				return precedenceType;
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001FE9C File Offset: 0x0001E09C
		internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op)
		{
			int precedence = (int)this.GetPrecedence(left);
			if (precedence == 0)
			{
				return StorageType.Empty;
			}
			int precedence2 = (int)this.GetPrecedence(right);
			if (precedence2 == 0)
			{
				return StorageType.Empty;
			}
			if (Operators.IsLogical(op))
			{
				if ((left != StorageType.Boolean && left != StorageType.SqlBoolean) || (right != StorageType.Boolean && right != StorageType.SqlBoolean))
				{
					return StorageType.Empty;
				}
				if (left == StorageType.Boolean && right == StorageType.Boolean)
				{
					return StorageType.Boolean;
				}
				return StorageType.SqlBoolean;
			}
			else
			{
				if (op == 15)
				{
					if (left == StorageType.SqlString || right == StorageType.SqlString)
					{
						return StorageType.SqlString;
					}
					if (left == StorageType.String || right == StorageType.String)
					{
						return StorageType.String;
					}
				}
				if ((left == StorageType.SqlBinary && right != StorageType.SqlBinary) || (left != StorageType.SqlBinary && right == StorageType.SqlBinary))
				{
					return StorageType.Empty;
				}
				if ((left == StorageType.SqlGuid && right != StorageType.SqlGuid) || (left != StorageType.SqlGuid && right == StorageType.SqlGuid))
				{
					return StorageType.Empty;
				}
				if (precedence > 19 && precedence2 < 20)
				{
					return StorageType.Empty;
				}
				if (precedence < 20 && precedence2 > 19)
				{
					return StorageType.Empty;
				}
				if (precedence > 19)
				{
					if (op == 15 || op == 16)
					{
						if (left == StorageType.TimeSpan)
						{
							return right;
						}
						if (right == StorageType.TimeSpan)
						{
							return left;
						}
						return StorageType.Empty;
					}
					else
					{
						if (!Operators.IsRelational(op))
						{
							return StorageType.Empty;
						}
						return left;
					}
				}
				else
				{
					BinaryNode.DataTypePrecedence dataTypePrecedence = (BinaryNode.DataTypePrecedence)Math.Max(precedence, precedence2);
					StorageType storageType = BinaryNode.GetPrecedenceType(dataTypePrecedence);
					storageType = BinaryNode.GetPrecedenceType((BinaryNode.DataTypePrecedence)this.SqlResultType((int)dataTypePrecedence));
					if (Operators.IsArithmetical(op) && storageType != StorageType.String && storageType != StorageType.Char && storageType != StorageType.SqlString)
					{
						if (!ExpressionNode.IsNumericSql(left))
						{
							return StorageType.Empty;
						}
						if (!ExpressionNode.IsNumericSql(right))
						{
							return StorageType.Empty;
						}
					}
					if (op == 18 && ExpressionNode.IsIntegerSql(storageType))
					{
						return StorageType.SqlDouble;
					}
					if (storageType == StorageType.SqlMoney && left != StorageType.SqlMoney && right != StorageType.SqlMoney)
					{
						storageType = StorageType.SqlDecimal;
					}
					if (this.IsMixedSql(left, right) && ExpressionNode.IsUnsignedSql(storageType))
					{
						if (dataTypePrecedence >= BinaryNode.DataTypePrecedence.UInt64)
						{
							throw ExprException.AmbiguousBinop(op, DataStorage.GetTypeStorage(left), DataStorage.GetTypeStorage(right));
						}
						storageType = BinaryNode.GetPrecedenceType(dataTypePrecedence + 1);
					}
					return storageType;
				}
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00020020 File Offset: 0x0001E220
		private int SqlResultType(int typeCode)
		{
			switch (typeCode)
			{
			case -8:
				return -7;
			case -7:
			case -6:
			case -4:
			case -3:
			case -1:
			case 0:
			case 2:
			case 5:
			case 8:
			case 11:
			case 13:
			case 15:
			case 17:
			case 19:
				break;
			case -5:
				return -4;
			case -2:
				return -1;
			case 1:
				return 2;
			case 3:
			case 4:
				return 5;
			case 6:
			case 7:
				return 8;
			case 9:
			case 10:
				return 11;
			case 12:
				return 13;
			case 14:
				return 15;
			case 16:
				return 17;
			case 18:
				return 19;
			case 20:
				return 21;
			default:
				if (typeCode == 23)
				{
					return 24;
				}
				break;
			}
			return typeCode;
		}

		// Token: 0x040001A3 RID: 419
		internal int _op;

		// Token: 0x040001A4 RID: 420
		internal ExpressionNode _left;

		// Token: 0x040001A5 RID: 421
		internal ExpressionNode _right;

		// Token: 0x02000056 RID: 86
		private enum DataTypePrecedence
		{
			// Token: 0x040001A7 RID: 423
			SqlDateTime = 25,
			// Token: 0x040001A8 RID: 424
			DateTimeOffset = 24,
			// Token: 0x040001A9 RID: 425
			DateTime = 23,
			// Token: 0x040001AA RID: 426
			TimeSpan = 20,
			// Token: 0x040001AB RID: 427
			SqlDouble = 19,
			// Token: 0x040001AC RID: 428
			Double = 18,
			// Token: 0x040001AD RID: 429
			SqlSingle = 17,
			// Token: 0x040001AE RID: 430
			Single = 16,
			// Token: 0x040001AF RID: 431
			SqlDecimal = 15,
			// Token: 0x040001B0 RID: 432
			Decimal = 14,
			// Token: 0x040001B1 RID: 433
			SqlMoney = 13,
			// Token: 0x040001B2 RID: 434
			UInt64 = 12,
			// Token: 0x040001B3 RID: 435
			SqlInt64 = 11,
			// Token: 0x040001B4 RID: 436
			Int64 = 10,
			// Token: 0x040001B5 RID: 437
			UInt32 = 9,
			// Token: 0x040001B6 RID: 438
			SqlInt32 = 8,
			// Token: 0x040001B7 RID: 439
			Int32 = 7,
			// Token: 0x040001B8 RID: 440
			UInt16 = 6,
			// Token: 0x040001B9 RID: 441
			SqlInt16 = 5,
			// Token: 0x040001BA RID: 442
			Int16 = 4,
			// Token: 0x040001BB RID: 443
			Byte = 3,
			// Token: 0x040001BC RID: 444
			SqlByte = 2,
			// Token: 0x040001BD RID: 445
			SByte = 1,
			// Token: 0x040001BE RID: 446
			Error = 0,
			// Token: 0x040001BF RID: 447
			SqlBoolean = -1,
			// Token: 0x040001C0 RID: 448
			Boolean = -2,
			// Token: 0x040001C1 RID: 449
			SqlGuid = -3,
			// Token: 0x040001C2 RID: 450
			SqlString = -4,
			// Token: 0x040001C3 RID: 451
			String = -5,
			// Token: 0x040001C4 RID: 452
			SqlXml = -6,
			// Token: 0x040001C5 RID: 453
			SqlChars = -7,
			// Token: 0x040001C6 RID: 454
			Char = -8,
			// Token: 0x040001C7 RID: 455
			SqlBytes = -9,
			// Token: 0x040001C8 RID: 456
			SqlBinary = -10
		}
	}
}
