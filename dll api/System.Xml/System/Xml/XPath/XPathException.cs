using System;
using System.Resources;
using System.Runtime.Serialization;

namespace System.Xml.XPath
{
	/// <summary>Provides the exception thrown when an error occurs while processing an XPath expression. </summary>
	// Token: 0x020001C0 RID: 448
	[Serializable]
	public class XPathException : SystemException
	{
		/// <summary>Uses the information in the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects to initialize a new instance of the <see cref="T:System.Xml.XPath.XPathException" /> class.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains all the properties of an <see cref="T:System.Xml.XPath.XPathException" />. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object. </param>
		// Token: 0x06000F47 RID: 3911 RVA: 0x000620B8 File Offset: 0x000602B8
		protected XPathException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.res = (string)info.GetValue("res", typeof(string));
			this.args = (string[])info.GetValue("args", typeof(string[]));
			string text = null;
			foreach (SerializationEntry serializationEntry in info)
			{
				if (serializationEntry.Name == "version")
				{
					text = (string)serializationEntry.Value;
				}
			}
			if (text == null)
			{
				this.message = XPathException.CreateMessage(this.res, this.args);
				return;
			}
			this.message = null;
		}

		/// <summary>Streams all the <see cref="T:System.Xml.XPath.XPathException" /> properties into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class for the specified <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
		// Token: 0x06000F48 RID: 3912 RVA: 0x00062169 File Offset: 0x00060369
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("res", this.res);
			info.AddValue("args", this.args);
			info.AddValue("version", "2.0");
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XPath.XPathException" /> class.</summary>
		// Token: 0x06000F49 RID: 3913 RVA: 0x000621A5 File Offset: 0x000603A5
		public XPathException() : this(string.Empty, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XPath.XPathException" /> class using the specified exception message and <see cref="T:System.Exception" /> object.</summary>
		/// <param name="message">The description of the error condition. </param>
		/// <param name="innerException">The <see cref="T:System.Exception" /> that threw the <see cref="T:System.Xml.XPath.XPathException" />, if any. This value can be <see langword="null" />. </param>
		// Token: 0x06000F4A RID: 3914 RVA: 0x000621B3 File Offset: 0x000603B3
		public XPathException(string message, Exception innerException) : this("{0}", new string[]
		{
			message
		}, innerException)
		{
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000621CB File Offset: 0x000603CB
		internal static XPathException Create(string res)
		{
			return new XPathException(res, null);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000621D4 File Offset: 0x000603D4
		internal static XPathException Create(string res, string arg)
		{
			return new XPathException(res, new string[]
			{
				arg
			});
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000621E6 File Offset: 0x000603E6
		internal static XPathException Create(string res, string arg, string arg2)
		{
			return new XPathException(res, new string[]
			{
				arg,
				arg2
			});
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000621FC File Offset: 0x000603FC
		private XPathException(string res, string[] args) : this(res, args, null)
		{
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00062207 File Offset: 0x00060407
		private XPathException(string res, string[] args, Exception inner) : base(XPathException.CreateMessage(res, args), inner)
		{
			base.HResult = -2146231997;
			this.res = res;
			this.args = args;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00062230 File Offset: 0x00060430
		private static string CreateMessage(string res, string[] args)
		{
			string result;
			try
			{
				string text = Res.GetString(res, args);
				if (text == null)
				{
					text = "UNKNOWN(" + res + ")";
				}
				result = text;
			}
			catch (MissingManifestResourceException)
			{
				result = "UNKNOWN(" + res + ")";
			}
			return result;
		}

		/// <summary>Gets the description of the error condition for this exception.</summary>
		/// <returns>The <see langword="string" /> description of the error condition for this exception.</returns>
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00062284 File Offset: 0x00060484
		public override string Message
		{
			get
			{
				if (this.message != null)
				{
					return this.message;
				}
				return base.Message;
			}
		}

		// Token: 0x04000AF5 RID: 2805
		private string res;

		// Token: 0x04000AF6 RID: 2806
		private string[] args;

		// Token: 0x04000AF7 RID: 2807
		private string message;
	}
}
