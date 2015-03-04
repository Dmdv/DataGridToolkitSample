using ContractService.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace ContractComponents.ViewModel
{
	/// <summary>
	/// This class contains static references to all the view models in the
	/// application and provides an entry point for the bindings.
	/// </summary>
	public class ViewModelLocator
	{
		/// <summary>
		/// Initializes a new instance of the ViewModelLocator class.
		/// </summary>
		public ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			if (ViewModelBase.IsInDesignModeStatic)
			{
				SimpleIoc.Default.Register<IContractsRepository, ContractFakeFactory>();
			}
			else
			{
				SimpleIoc.Default.Register<IContractsRepository, ContractFakeFactory>();
			}

			SimpleIoc.Default.Register<ContractsViewModel>();
		}

		public ContractsViewModel ContractsViewModel
		{
			get { return ServiceLocator.Current.GetInstance<ContractsViewModel>(); }
		}

		public static void Cleanup()
		{
		}
	}
}