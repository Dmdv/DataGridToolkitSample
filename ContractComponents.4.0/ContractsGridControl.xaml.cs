using System.Linq;
using ContractService.Model;
using GalaSoft.MvvmLight;
using Net.Common.Contracts;
using Net.Common.Extensions;
using Net.Common.Monads;

namespace ContractComponents
{
	/// <summary>
	/// Interaction logic for ContractsGridControl.xaml
	/// </summary>
	public partial class ContractsGridControl
	{
		public ContractsGridControl()
		{
			InitializeComponent();

			GridControl.CurrentItem
				.OfType<ViewModelBase>()
				.IfNotNull(item =>
				{
					var itemType = item.GetType();

					foreach (var column in GridControl.Columns)
					{
						Guard.CheckContainsText(column.FieldName, "column.FieldName");

						var propertyInfo = itemType.GetProperty(column.FieldName);

						Guard.CheckNotNull(propertyInfo, "propertyInfo");

						var attribute = propertyInfo
							.GetCustomAttributes(typeof (ColumnAttribute), true)
							.OfType<ColumnAttribute>()
							.FirstOrDefault();

						if (attribute != null)
						{
							column.Title = attribute.Title;
							column.Visible = attribute.IsVisible;

							if (attribute.Width != 0)
							{
								column.Width = attribute.Width;
							}
						}
						else
						{
							column.Visible = false;
							column.Width = 0;
						}
					}
				});
		}
	}
}