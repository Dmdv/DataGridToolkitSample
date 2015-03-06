using System;
using System.Collections.Generic;
using System.Linq;
using ContractService.Model;
using JetBrains.Annotations;
using Net.Common.Extensions;

namespace ContractService.Repository
{
	[UsedImplicitly]
	public class ContractFakeFactory : IContractsRepository
	{
		public const int MaxValue = 1000;

		[NotNull]
		public IEnumerable<Contract> All()
		{
			var random = new Random();

			return Enumerable
				.Range(0, MaxValue)
				.Select(_ =>
				{
					var clientId = random.Next(0, MaxValue);

					return new Contract
					{
						Id = clientId,
						ClientId = clientId,
						ClientName = "Person {0}".FormatString(clientId),
						IsVip = true,
						PresentationDate = DateTime.Now
					};
				});
		}
	}
}