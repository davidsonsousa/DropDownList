using DropDownList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownList.Models
{
	public class Product
	{
		public string Name { get; set; }
		public DropDownListViewModel Type { get; set; }
	}
}