#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using RoadRunnerTemplate.DataAccess;

namespace RoadRunnerTemplate.DataAccess	
{
	public partial class Pembelian
	{
		private int _iD;
		public virtual int ID
		{
			get
			{
				return this._iD;
			}
			set
			{
				this._iD = value;
			}
		}
		
		private DateTime _tanggalPembelian;
		public virtual DateTime TanggalPembelian
		{
			get
			{
				return this._tanggalPembelian;
			}
			set
			{
				this._tanggalPembelian = value;
			}
		}
		
		private IList<DetilPembelian> _detilPembelians = new List<DetilPembelian>();
		public virtual IList<DetilPembelian> DetilPembelians
		{
			get
			{
				return this._detilPembelians;
			}
		}
		
	}
}
#pragma warning restore 1591
