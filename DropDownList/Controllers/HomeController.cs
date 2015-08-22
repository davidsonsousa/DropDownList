using DropDownList.Models;
using DropDownList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownList.Controllers
{
	public class HomeController : Controller
	{
		#region Helper methods

		private DropDownListViewModel AllTypeItems(string[] selectedValues = null)
		{
			var ddList = new DropDownListViewModel();

			// Add the values to be used in the checkbox list
			// The values can come from anywhere
			var selectListItems = new List<SelectListItem> {
																new SelectListItem { Text = "Computer", Value = "Computer" },
																new SelectListItem { Text = "Mobile", Value = "Mobile" },
																new SelectListItem { Text = "Electronic", Value = "Electronic" }
															};

			// Concatenating with our DefaultItem so we have that classic "- SELECT -"
			ddList.SelectListItems = new SelectList(DefaultItem.Concat(selectListItems), "Value", "Text");

			if (selectedValues != null)
			{
				ddList.SelectedValues = selectedValues;
			}

			return ddList;
		}

		private IEnumerable<SelectListItem> DefaultItem
		{
			get
			{
				return Enumerable.Repeat(new SelectListItem
				{
					Value = "",
					Text = "- SELECT -"
				}, count: 1);
			}
		}

		#endregion


		// GET: Home
		public ActionResult Index()
		{
			// Setup product
			var product = new Product();

			// Setup the checkbox list
			product.Type = AllTypeItems();

			return View(product);
		}

		[HttpPost]
		public ActionResult Index(Product product)
		{
			// Show the values we selected
			Response.Write(product.Type.SelectedValue);

			// Set the items again as they are null and also set the selected values
			product.Type = AllTypeItems(product.Type.SelectedValues);

			return View(product);
		}

		public ActionResult Multiple()
		{
			// Setup product
			var product = new Product();

			// Setup the checkbox list
			product.Type = AllTypeItems();

			return View(product);
		}

		[HttpPost]
		public ActionResult Multiple(Product product)
		{
			// Show the values we selected
			Response.Write(string.Join(", ", product.Type.SelectedValues));

			// Set the items again as they are null and also set the selected values
			product.Type = AllTypeItems(product.Type.SelectedValues);

			return View(product);
		}
	}
}