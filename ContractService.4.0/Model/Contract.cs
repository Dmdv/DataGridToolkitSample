using System;

namespace ContractService.Model
{
	public class Contract
	{
		public int Id { get; set; }
		public int ClientId { get; set; }
		public string ClientName { get; set; }
		public bool IsVip { get; set; }
		public string ContractId { get; set; }
		public DateTime SignDate { get; set; }
		public decimal ContractSum { get; set; }
		public string CurrencyCode { get; set; }
		public string ContragetCountryCode { get; set; }
		public string Status { get; set; }
		public string StatusComment { get; set; }
		public string PassportDealNumber { get; set; }
		public DateTime PresentationDate { get; set; }
		public string Form402 { get; set; }
		public string Form405 { get; set; }
		public string Form406 { get; set; }
		public string DocumentNumber { get; set; }
		public DateTime EditTime { get; set; }
		public string User { get; set; }
		public string Branch { get; set; }
	}
}