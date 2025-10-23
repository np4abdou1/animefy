using System;

namespace System.Xml.Linq
{
	/// <summary>Represents a node or an attribute in an XML tree. </summary>
	// Token: 0x02000033 RID: 51
	public abstract class XObject : IXmlLineInfo
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00007FDD File Offset: 0x000061DD
		internal XObject()
		{
		}

		/// <summary>Gets the base URI for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the base URI for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000861C File Offset: 0x0000681C
		public string BaseUri
		{
			get
			{
				XObject xobject = this;
				BaseUriAnnotation baseUriAnnotation;
				for (;;)
				{
					if (xobject == null || xobject.annotations != null)
					{
						if (xobject == null)
						{
							goto IL_33;
						}
						baseUriAnnotation = xobject.Annotation<BaseUriAnnotation>();
						if (baseUriAnnotation != null)
						{
							break;
						}
						xobject = xobject.parent;
					}
					else
					{
						xobject = xobject.parent;
					}
				}
				return baseUriAnnotation.baseUri;
				IL_33:
				return string.Empty;
			}
		}

		/// <summary>Gets the node type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>The node type for this <see cref="T:System.Xml.Linq.XObject" />. </returns>
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600017C RID: 380
		public abstract XmlNodeType NodeType { get; }

		/// <summary>Gets the parent <see cref="T:System.Xml.Linq.XElement" /> of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>The parent <see cref="T:System.Xml.Linq.XElement" /> of this <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00008661 File Offset: 0x00006861
		public XElement Parent
		{
			get
			{
				return this.parent as XElement;
			}
		}

		/// <summary>Adds an object to the annotation list of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <param name="annotation">An <see cref="T:System.Object" /> that contains the annotation to add.</param>
		// Token: 0x0600017E RID: 382 RVA: 0x00008670 File Offset: 0x00006870
		public void AddAnnotation(object annotation)
		{
			if (annotation == null)
			{
				throw new ArgumentNullException("annotation");
			}
			if (this.annotations == null)
			{
				object obj;
				if (!(annotation is object[]))
				{
					obj = annotation;
				}
				else
				{
					(obj = new object[1])[0] = annotation;
				}
				this.annotations = obj;
				return;
			}
			object[] array = this.annotations as object[];
			if (array == null)
			{
				this.annotations = new object[]
				{
					this.annotations,
					annotation
				};
				return;
			}
			int num = 0;
			while (num < array.Length && array[num] != null)
			{
				num++;
			}
			if (num == array.Length)
			{
				Array.Resize<object>(ref array, num * 2);
				this.annotations = array;
			}
			array[num] = annotation;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00008708 File Offset: 0x00006908
		private object AnnotationForSealedType(Type type)
		{
			if (this.annotations != null)
			{
				object[] array = this.annotations as object[];
				if (array == null)
				{
					if (this.annotations.GetType() == type)
					{
						return this.annotations;
					}
				}
				else
				{
					foreach (object obj in array)
					{
						if (obj == null)
						{
							break;
						}
						if (obj.GetType() == type)
						{
							return obj;
						}
					}
				}
			}
			return null;
		}

		/// <summary>Get the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />. </summary>
		/// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
		/// <returns>The first annotation object that matches the specified type, or <see langword="null" /> if no annotation is of the specified type.</returns>
		// Token: 0x06000180 RID: 384 RVA: 0x0000876C File Offset: 0x0000696C
		public T Annotation<T>() where T : class
		{
			if (this.annotations != null)
			{
				object[] array = this.annotations as object[];
				if (array == null)
				{
					return this.annotations as T;
				}
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						return t;
					}
				}
			}
			return default(T);
		}

		/// <summary>Gets a value indicating whether or not this <see cref="T:System.Xml.Linq.XObject" /> has line information.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.Linq.XObject" /> has line information, otherwise <see langword="false" />.</returns>
		// Token: 0x06000181 RID: 385 RVA: 0x000087D6 File Offset: 0x000069D6
		bool IXmlLineInfo.HasLineInfo()
		{
			return this.Annotation<LineInfoAnnotation>() != null;
		}

		/// <summary>Gets the line number that the underlying <see cref="T:System.Xml.XmlReader" /> reported for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the line number reported by the <see cref="T:System.Xml.XmlReader" /> for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000087E4 File Offset: 0x000069E4
		int IXmlLineInfo.LineNumber
		{
			get
			{
				LineInfoAnnotation lineInfoAnnotation = this.Annotation<LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.lineNumber;
				}
				return 0;
			}
		}

		/// <summary>Gets the line position that the underlying <see cref="T:System.Xml.XmlReader" /> reported for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the line position reported by the <see cref="T:System.Xml.XmlReader" /> for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00008804 File Offset: 0x00006A04
		int IXmlLineInfo.LinePosition
		{
			get
			{
				LineInfoAnnotation lineInfoAnnotation = this.Annotation<LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.linePosition;
				}
				return 0;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00008823 File Offset: 0x00006A23
		internal bool HasBaseUri
		{
			get
			{
				return this.Annotation<BaseUriAnnotation>() != null;
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00008830 File Offset: 0x00006A30
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e)
		{
			bool result = false;
			XObject xobject = this;
			for (;;)
			{
				if (xobject == null || xobject.annotations != null)
				{
					if (xobject == null)
					{
						break;
					}
					XObjectChangeAnnotation xobjectChangeAnnotation = xobject.Annotation<XObjectChangeAnnotation>();
					if (xobjectChangeAnnotation != null)
					{
						result = true;
						if (xobjectChangeAnnotation.changed != null)
						{
							xobjectChangeAnnotation.changed(sender, e);
						}
					}
					xobject = xobject.parent;
				}
				else
				{
					xobject = xobject.parent;
				}
			}
			return result;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00008884 File Offset: 0x00006A84
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e)
		{
			bool result = false;
			XObject xobject = this;
			for (;;)
			{
				if (xobject == null || xobject.annotations != null)
				{
					if (xobject == null)
					{
						break;
					}
					XObjectChangeAnnotation xobjectChangeAnnotation = xobject.Annotation<XObjectChangeAnnotation>();
					if (xobjectChangeAnnotation != null)
					{
						result = true;
						if (xobjectChangeAnnotation.changing != null)
						{
							xobjectChangeAnnotation.changing(sender, e);
						}
					}
					xobject = xobject.parent;
				}
				else
				{
					xobject = xobject.parent;
				}
			}
			return result;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000088D7 File Offset: 0x00006AD7
		internal void SetBaseUri(string baseUri)
		{
			this.AddAnnotation(new BaseUriAnnotation(baseUri));
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000088E5 File Offset: 0x00006AE5
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
			this.AddAnnotation(new LineInfoAnnotation(lineNumber, linePosition));
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000088F4 File Offset: 0x00006AF4
		internal bool SkipNotify()
		{
			XObject xobject = this;
			for (;;)
			{
				if (xobject == null || xobject.annotations != null)
				{
					if (xobject == null)
					{
						break;
					}
					if (xobject.Annotation<XObjectChangeAnnotation>() != null)
					{
						return false;
					}
					xobject = xobject.parent;
				}
				else
				{
					xobject = xobject.parent;
				}
			}
			return true;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00008930 File Offset: 0x00006B30
		internal SaveOptions GetSaveOptionsFromAnnotations()
		{
			XObject xobject = this;
			object obj;
			for (;;)
			{
				if (xobject == null || xobject.annotations != null)
				{
					if (xobject == null)
					{
						break;
					}
					obj = xobject.AnnotationForSealedType(typeof(SaveOptions));
					if (obj != null)
					{
						goto Block_3;
					}
					xobject = xobject.parent;
				}
				else
				{
					xobject = xobject.parent;
				}
			}
			return SaveOptions.None;
			Block_3:
			return (SaveOptions)obj;
		}

		// Token: 0x040000D9 RID: 217
		internal XContainer parent;

		// Token: 0x040000DA RID: 218
		internal object annotations;
	}
}
