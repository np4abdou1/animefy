using System;
using System.Collections;

namespace System.Xml.Serialization
{
	// Token: 0x02000211 RID: 529
	internal class XmlTypeMapMemberElement : XmlTypeMapMember
	{
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0006DF4A File Offset: 0x0006C14A
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x0006DF65 File Offset: 0x0006C165
		public XmlTypeMapElementInfoList ElementInfo
		{
			get
			{
				if (this._elementInfo == null)
				{
					this._elementInfo = new XmlTypeMapElementInfoList();
				}
				return this._elementInfo;
			}
			set
			{
				this._elementInfo = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0006DF6E File Offset: 0x0006C16E
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x0006DF76 File Offset: 0x0006C176
		public string ChoiceMember
		{
			get
			{
				return this._choiceMember;
			}
			set
			{
				this._choiceMember = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0006DF7F File Offset: 0x0006C17F
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x0006DF87 File Offset: 0x0006C187
		public TypeData ChoiceTypeData
		{
			get
			{
				return this._choiceTypeData;
			}
			set
			{
				this._choiceTypeData = value;
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0006DF90 File Offset: 0x0006C190
		public XmlTypeMapElementInfo FindElement(object ob, object memberValue)
		{
			if (this._elementInfo.Count == 1)
			{
				return (XmlTypeMapElementInfo)this._elementInfo[0];
			}
			if (this._choiceMember != null)
			{
				object value = XmlTypeMapMember.GetValue(ob, this._choiceMember);
				using (IEnumerator enumerator = this._elementInfo.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)obj;
						if (xmlTypeMapElementInfo.ChoiceValue != null && xmlTypeMapElementInfo.ChoiceValue.Equals(value))
						{
							return xmlTypeMapElementInfo;
						}
					}
					goto IL_11C;
				}
				goto IL_8D;
				IL_11C:
				return null;
			}
			IL_8D:
			if (memberValue == null)
			{
				return (XmlTypeMapElementInfo)this._elementInfo[0];
			}
			XmlTypeMapElementInfo xmlTypeMapElementInfo2 = null;
			foreach (object obj2 in this._elementInfo)
			{
				XmlTypeMapElementInfo xmlTypeMapElementInfo3 = (XmlTypeMapElementInfo)obj2;
				if (xmlTypeMapElementInfo3.TypeData.Type.IsInstanceOfType(memberValue) && (xmlTypeMapElementInfo2 == null || xmlTypeMapElementInfo3.TypeData.Type.IsSubclassOf(xmlTypeMapElementInfo2.TypeData.Type)))
				{
					xmlTypeMapElementInfo2 = xmlTypeMapElementInfo3;
				}
			}
			return xmlTypeMapElementInfo2;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0006E0D8 File Offset: 0x0006C2D8
		public void SetChoice(object ob, object choice)
		{
			XmlTypeMapMember.SetValue(ob, this._choiceMember, choice);
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0006E0E7 File Offset: 0x0006C2E7
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x0006E0EF File Offset: 0x0006C2EF
		public bool IsXmlTextCollector
		{
			get
			{
				return this._isTextCollector;
			}
			set
			{
				this._isTextCollector = value;
			}
		}

		// Token: 0x04000C06 RID: 3078
		private XmlTypeMapElementInfoList _elementInfo;

		// Token: 0x04000C07 RID: 3079
		private string _choiceMember;

		// Token: 0x04000C08 RID: 3080
		private bool _isTextCollector;

		// Token: 0x04000C09 RID: 3081
		private TypeData _choiceTypeData;
	}
}
