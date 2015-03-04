using System;
using ContractService.Model;
using GalaSoft.MvvmLight;
using JetBrains.Annotations;
using Net.Common.Contracts;

// Не менять порядок свойств, т.к. это влияет на порядок колонок в гриде.

// ReSharper disable UnusedMember.Global
// ReSharper disable CodeCleanup

namespace ContractComponents.ViewModel
{
	public class ContractViewModel : ViewModelBase
	{
		private readonly Contract _contract;

		public ContractViewModel([NotNull] Contract contract)
		{
			_contract = Guard.GetNotNull(contract, "contract");
		}

		[Column("ID", 50)]
		public int Id
		{
			get { return _contract.Id; }
			set
			{
				_contract.Id = value;
				RaisePropertyChanged();
			}
		}

		// TODO: Возможная реализация через аспекты: 1. Windsor. 2. PostSharp.
		[Column("Номер клиента", 50)]
		public int ClientId
		{
			get { return _contract.ClientId; }
			set
			{
				_contract.ClientId = value;
				RaisePropertyChanged();
			}
		}

		[Column("Наименование клиента")]
		public string ClientName
		{
			get { return _contract.ClientName; }
			set
			{
				_contract.ClientName = value;
				RaisePropertyChanged();
			}
		}

		[Column("Приоритет VIP")]
		public bool IsVip
		{
			get { return _contract.IsVip; }
			set
			{
				_contract.IsVip = value;
				RaisePropertyChanged();
			}
		}

		[Column("№ Контракта")]
		public string ContractId
		{
			get { return _contract.ContractId; }
			set
			{
				_contract.ContractId = value;
				RaisePropertyChanged();
			}
		}

		[Column("Дата подписания контракта")]
		public DateTime SignDate
		{
			get { return _contract.SignDate; }
			set
			{
				_contract.SignDate = value;
				RaisePropertyChanged();
			}
		}

		[Column("Сумма контракта")]
		public decimal ContractSum
		{
			get { return _contract.ContractSum; }
			set
			{
				_contract.ContractSum = value;
				RaisePropertyChanged();
			}
		}

		[Column("Код валюты контракта")]
		public string CurrencyCode
		{
			get { return _contract.CurrencyCode; }
			set
			{
				_contract.CurrencyCode = value;
				RaisePropertyChanged();
			}
		}

		[Column("Код страны контрагента")]
		public string ContragetCountryCode
		{
			get { return _contract.ContragetCountryCode; }
			set
			{
				_contract.ContragetCountryCode = value;
				RaisePropertyChanged();
			}
		}

		[Column("Статус")]
		public string Status
		{
			get { return _contract.Status; }
			set
			{
				_contract.Status = value;
				RaisePropertyChanged();
			}
		}

		[Column("Комментарий к статусу")]
		public string StatusComment
		{
			get { return _contract.StatusComment; }
			set
			{
				_contract.StatusComment = value;
				RaisePropertyChanged();
			}
		}

		[Column("Номер паспорта сделки")]
		public string PassportDealNumber
		{
			get { return _contract.PassportDealNumber; }
			set
			{
				_contract.PassportDealNumber = value;
				RaisePropertyChanged();
			}
		}

		[Column("Подразделение")]
		public string Branch
		{
			get { return _contract.Branch; }
			set
			{
				_contract.Branch = value;
				RaisePropertyChanged();
			}
		}

		[Column("Отчётность по 402 ф")]
		public string Form402
		{
			get { return _contract.Form402; }
			set
			{
				_contract.Form402 = value;
				RaisePropertyChanged();
			}
		}

		[Column("Отчётность по 405 ф")]
		public string Form405
		{
			get { return _contract.Form405; }
			set
			{
				_contract.Form405 = value;
				RaisePropertyChanged();
			}
		}

		[Column("Отчётность по 406 ф")]
		public string Form406
		{
			get { return _contract.Form406; }
			set
			{
				_contract.Form406 = value;
				RaisePropertyChanged();
			}
		}

		[Column("№ Документа")]
		public string DocumentNumber
		{
			get { return _contract.DocumentNumber; }
			set
			{
				_contract.DocumentNumber = value;
				RaisePropertyChanged();
			}
		}

		[Column("Дата редактирования")]
		public DateTime EditTime
		{
			get { return _contract.EditTime; }
			set
			{
				_contract.EditTime = value;
				RaisePropertyChanged();
			}
		}

		[Column("Пользователь")]
		public string User
		{
			get { return _contract.User; }
			set
			{
				_contract.User = value;
				RaisePropertyChanged();
			}
		}

		[Column("Дата представления")]
		public DateTime PresentationDate
		{
			get { return _contract.PresentationDate; }
			set
			{
				_contract.PresentationDate = value;
				RaisePropertyChanged();
			}
		}
	}
}