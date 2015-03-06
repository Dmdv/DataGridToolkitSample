using System.Collections.ObjectModel;
using System.Linq;
using ContractService.Repository;
using GalaSoft.MvvmLight;
using JetBrains.Annotations;
using Net.Common.Contracts;

namespace ContractComponents.ViewModel
{
	[UsedImplicitly]
	public class ContractsViewModel : ViewModelBase
	{
		/// <summary>
		/// Initializes a new instance of the ContractsViewModel class.
		/// </summary>
		public ContractsViewModel([NotNull] IContractsRepository repository)
		{
			Guard.CheckNotNull(repository, "repository");
			InitContracts(repository);
		}
		
		// ReSharper disable once CollectionNeverQueried.Global
		public ObservableCollection<ContractViewModel> Contracts { get; set; }

		private void InitContracts(IContractsRepository factory)
		{
			Contracts = new ObservableCollection<ContractViewModel>(
				factory.All()
					.Select(
						x => new ContractViewModel(x)));
		}
	}
}