﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5472
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.Collections.Generic;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class ArticleFileConnections
	{

		private List<ArticleFileConnectionSubset> articleFileConnectionSubsetField;

		private string totalResourcesField;

		private string totalPagesField;

		private string currentPageField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ArticleFileConnectionSubset")]
		public List<ArticleFileConnectionSubset> ArticleFileConnectionSubset
		{
			get
			{
				return this.articleFileConnectionSubsetField;
			}
			set
			{
				this.articleFileConnectionSubsetField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalResources
		{
			get
			{
				return this.totalResourcesField;
			}
			set
			{
				this.totalResourcesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalPages
		{
			get
			{
				return this.totalPagesField;
			}
			set
			{
				this.totalPagesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CurrentPage
		{
			get
			{
				return this.currentPageField;
			}
			set
			{
				this.currentPageField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ArticleFileConnectionSubset
	{

		private string fileIdField;

		private string articleNumberField;

		private string urlField;

		/// <remarks/>
		public string FileId
		{
			get
			{
				return this.fileIdField;
			}
			set
			{
				this.fileIdField = value;
			}
		}

		/// <remarks/>
		public string ArticleNumber
		{
			get
			{
				return this.articleNumberField;
			}
			set
			{
				this.articleNumberField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}
}