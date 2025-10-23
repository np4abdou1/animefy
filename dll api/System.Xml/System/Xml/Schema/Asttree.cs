using System;
using System.Collections;
using System.Xml.XPath;
using MS.Internal.Xml.XPath;

namespace System.Xml.Schema
{
	// Token: 0x02000225 RID: 549
	internal class Asttree
	{
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0006FD02 File Offset: 0x0006DF02
		internal ArrayList SubtreeArray
		{
			get
			{
				return this._fAxisArray;
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0006FD0A File Offset: 0x0006DF0A
		public Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr)
		{
			this._xpathexpr = xPath;
			this._isField = isField;
			this._nsmgr = nsmgr;
			this.CompileXPath(xPath, isField, nsmgr);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0006FD30 File Offset: 0x0006DF30
		private static bool IsNameTest(Axis ast)
		{
			return ast.TypeOfAxis == Axis.AxisType.Child && ast.NodeType == XPathNodeType.Element;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0006FD46 File Offset: 0x0006DF46
		internal static bool IsAttribute(Axis ast)
		{
			return ast.TypeOfAxis == Axis.AxisType.Attribute && ast.NodeType == XPathNodeType.Attribute;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0006FD5C File Offset: 0x0006DF5C
		private static bool IsDescendantOrSelf(Axis ast)
		{
			return ast.TypeOfAxis == Axis.AxisType.DescendantOrSelf && ast.NodeType == XPathNodeType.All && ast.AbbrAxis;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0006FD79 File Offset: 0x0006DF79
		internal static bool IsSelf(Axis ast)
		{
			return ast.TypeOfAxis == Axis.AxisType.Self && ast.NodeType == XPathNodeType.All && ast.AbbrAxis;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0006FD98 File Offset: 0x0006DF98
		public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr)
		{
			if (xPath == null || xPath.Length == 0)
			{
				throw new XmlSchemaException("The XPath for selector or field cannot be empty.", string.Empty);
			}
			string[] array = xPath.Split('|', StringSplitOptions.None);
			ArrayList arrayList = new ArrayList(array.Length);
			this._fAxisArray = new ArrayList(array.Length);
			try
			{
				for (int i = 0; i < array.Length; i++)
				{
					Axis value = (Axis)XPathParser.ParseXPathExpression(array[i]);
					arrayList.Add(value);
				}
			}
			catch
			{
				throw new XmlSchemaException("'{0}' is an invalid XPath for selector or field.", xPath);
			}
			int j = 0;
			while (j < arrayList.Count)
			{
				Axis axis = (Axis)arrayList[j];
				Axis axis2;
				if ((axis2 = axis) == null)
				{
					throw new XmlSchemaException("'{0}' is an invalid XPath for selector or field.", xPath);
				}
				Axis axis3 = axis2;
				if (Asttree.IsAttribute(axis2))
				{
					if (!isField)
					{
						throw new XmlSchemaException("'{0}' is an invalid XPath for selector. Selector cannot have an XPath selection with an attribute node.", xPath);
					}
					this.SetURN(axis2, nsmgr);
					try
					{
						axis2 = (Axis)axis2.Input;
						goto IL_122;
					}
					catch
					{
						throw new XmlSchemaException("'{0}' is an invalid XPath for selector or field.", xPath);
					}
					goto IL_D7;
				}
				IL_122:
				if (axis2 == null || (!Asttree.IsNameTest(axis2) && !Asttree.IsSelf(axis2)))
				{
					axis3.Input = null;
					if (axis2 == null)
					{
						if (Asttree.IsSelf(axis) && axis.Input != null)
						{
							this._fAxisArray.Add(new ForwardAxis(DoubleLinkAxis.ConvertTree((Axis)axis.Input), false));
						}
						else
						{
							this._fAxisArray.Add(new ForwardAxis(DoubleLinkAxis.ConvertTree(axis), false));
						}
					}
					else
					{
						if (!Asttree.IsDescendantOrSelf(axis2))
						{
							throw new XmlSchemaException("'{0}' is an invalid XPath for selector or field.", xPath);
						}
						try
						{
							axis2 = (Axis)axis2.Input;
						}
						catch
						{
							throw new XmlSchemaException("'{0}' is an invalid XPath for selector or field.", xPath);
						}
						if (axis2 == null || !Asttree.IsSelf(axis2) || axis2.Input != null)
						{
							throw new XmlSchemaException("'{0}' is an invalid XPath for selector or field.", xPath);
						}
						if (Asttree.IsSelf(axis) && axis.Input != null)
						{
							this._fAxisArray.Add(new ForwardAxis(DoubleLinkAxis.ConvertTree((Axis)axis.Input), true));
						}
						else
						{
							this._fAxisArray.Add(new ForwardAxis(DoubleLinkAxis.ConvertTree(axis), true));
						}
					}
					j++;
					continue;
				}
				IL_D7:
				if (Asttree.IsSelf(axis2) && axis != axis2)
				{
					axis3.Input = axis2.Input;
				}
				else
				{
					axis3 = axis2;
					if (Asttree.IsNameTest(axis2))
					{
						this.SetURN(axis2, nsmgr);
					}
				}
				try
				{
					axis2 = (Axis)axis2.Input;
				}
				catch
				{
					throw new XmlSchemaException("'{0}' is an invalid XPath for selector or field.", xPath);
				}
				goto IL_122;
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00070024 File Offset: 0x0006E224
		private void SetURN(Axis axis, XmlNamespaceManager nsmgr)
		{
			if (axis.Prefix.Length != 0)
			{
				axis.Urn = nsmgr.LookupNamespace(axis.Prefix);
				if (axis.Urn == null)
				{
					throw new XmlSchemaException("The prefix '{0}' in XPath cannot be resolved.", axis.Prefix);
				}
			}
			else
			{
				if (axis.Name.Length != 0)
				{
					axis.Urn = null;
					return;
				}
				axis.Urn = "";
			}
		}

		// Token: 0x04000C4A RID: 3146
		private ArrayList _fAxisArray;

		// Token: 0x04000C4B RID: 3147
		private string _xpathexpr;

		// Token: 0x04000C4C RID: 3148
		private bool _isField;

		// Token: 0x04000C4D RID: 3149
		private XmlNamespaceManager _nsmgr;
	}
}
