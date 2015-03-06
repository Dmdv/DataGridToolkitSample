using System;
using ContractService.Model;
using GalaSoft.MvvmLight;
using JetBrains.Annotations;
using Net.Common.Contracts;

// �� ������ ������� �������, �.�. ��� ������ �� ������� ������� � �����.

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
				RaisePropertyChanged("Id");
			}
		}

		// TODO: ��������� ���������� ����� �������: 1. Windsor. 2. PostSharp.
		[Column("����� �������", 50)]
		public int ClientId
		{
			get { return _contract.ClientId; }
			set
			{
				_contract.ClientId = value;
				RaisePropertyChanged("ClientId");
			}
		}

		[Column("������������ �������")]
		public string ClientName
		{
			get { return _contract.ClientName; }
			set
			{
				_contract.ClientName = value;
				RaisePropertyChanged("ClientName");
			}
		}

		[Column("��������� VIP")]
		public bool IsVip
		{
			get { return _contract.IsVip; }
			set
			{
				_contract.IsVip = value;
				RaisePropertyChanged("IsVip");
			}
		}

		[Column("� ���������")]
		public string ContractId
		{
			get { return _contract.ContractId; }
			set
			{
				_contract.ContractId = value;
				RaisePropertyChanged("ContractId");
			}
		}

		[Column("���� ���������� ���������")]
		public DateTime SignDate
		{
			get { return _contract.SignDate; }
			set
			{
				_contract.SignDate = value;
				RaisePropertyChanged("SignDate");
			}
		}

		[Column("����� ���������")]
		public decimal ContractSum
		{
			get { return _contract.ContractSum; }
			set
			{
				_contract.ContractSum = value;
				RaisePropertyChanged("ContractSum");
			}
		}

		[Column("��� ������ ���������")]
		public string CurrencyCode
		{
			get { return _contract.CurrencyCode; }
			set
			{
				_contract.CurrencyCode = value;
				RaisePropertyChanged("CurrencyCode");
			}
		}

		[Column("��� ������ �����������")]
		public string ContragetCountryCode
		{
			get { return _contract.ContragetCountryCode; }
			set
			{
				_contract.ContragetCountryCode = value;
				RaisePropertyChanged("ContragetCountryCode");
			}
		}

		[Column("������")]
		public string Status
		{
			get { return _contract.Status; }
			set
			{
				_contract.Status = value;
				RaisePropertyChanged("Status");
			}
		}

		[Column("����������� � �������")]
		public string StatusComment
		{
			get { return _contract.StatusComment; }
			set
			{
				_contract.StatusComment = value;
				RaisePropertyChanged("StatusComment");
			}
		}

		[Column("����� �������� ������")]
		public string PassportDealNumber
		{
			get { return _contract.PassportDealNumber; }
			set
			{
				_contract.PassportDealNumber = value;
				RaisePropertyChanged("PassportDealNumber");
			}
		}

		[Column("�������������")]
		public string Branch
		{
			get { return _contract.Branch; }
			set
			{
				_contract.Branch = value;
				RaisePropertyChanged("Branch");
			}
		}

		[Column("���������� �� 402 �")]
		public string Form402
		{
			get { return _contract.Form402; }
			set
			{
				_contract.Form402 = value;
				RaisePropertyChanged("Form402");
			}
		}

		[Column("���������� �� 405 �")]
		public string Form405
		{
			get { return _contract.Form405; }
			set
			{
				_contract.Form405 = value;
				RaisePropertyChanged("Form405");
			}
		}

		[Column("���������� �� 406 �")]
		public string Form406
		{
			get { return _contract.Form406; }
			set
			{
				_contract.Form406 = value;
				RaisePropertyChanged("Form406");
			}
		}

		[Column("� ���������")]
		public string DocumentNumber
		{
			get { return _contract.DocumentNumber; }
			set
			{
				_contract.DocumentNumber = value;
				RaisePropertyChanged("DocumentNumber");
			}
		}

		[Column("���� ��������������")]
		public DateTime EditTime
		{
			get { return _contract.EditTime; }
			set
			{
				_contract.EditTime = value;
				RaisePropertyChanged("EditTime");
			}
		}

		[Column("������������")]
		public string User
		{
			get { return _contract.User; }
			set
			{
				_contract.User = value;
				RaisePropertyChanged("User");
			}
		}

		[Column("���� �������������")]
		public DateTime PresentationDate
		{
			get { return _contract.PresentationDate; }
			set
			{
				_contract.PresentationDate = value;
				RaisePropertyChanged("PresentationDate");
			}
		}
	}
}