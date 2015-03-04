using System;
using Net.Common.Contracts;

namespace ContractService.Model
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class ColumnAttribute : Attribute
	{
		private const int DefaultWidth = 0;

		public ColumnAttribute(string title, int width = DefaultWidth, bool isVisible = true)
		{
			Guard.CheckContainsText(title, "title");

			Title = title;
			Width = width;
			IsVisible = isVisible;
		}

		// See the attribute guidelines at 
		//  http://go.microsoft.com/fwlink/?LinkId=85236

		public int Width { get; private set; }
		public string Title { get; private set; }
		public string FieldName { get; set; }
		public bool IsVisible { get; private set; }
	}
}