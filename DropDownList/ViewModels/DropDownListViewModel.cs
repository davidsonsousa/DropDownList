using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DropDownList.ViewModels
{
	public class DropDownListViewModel
	{
		/// <summary>
		/// Used when the dropdown list allows only one value to be selected
		/// </summary>
		public string SelectedValue { get; set; }

		public string[] SelectedValues { get; set; }

		public SelectList SelectListItems { get; set; }
	}

	public class DropDownItem
	{
		public string Value { get; set; }
		public string Text { get; set; }
		public string Group { get; set; }
	}
}
