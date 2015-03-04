using System.Collections.Generic;
using ContractService.Model;

namespace ContractService.Repository
{
	public interface IContractsRepository
	{
		IEnumerable<Contract> All();
	}
}