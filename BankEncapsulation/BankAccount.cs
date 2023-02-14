using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}
		private double _balance = 0;

		public void Deposit(double num)
		{
			_balance += num;
		}

		public void Withdraw(double num)
		{
			_balance -= num;
		}

		public void GetBalance()
		{
			Console.WriteLine();
			Console.WriteLine($"Your balance is ${_balance}");
		}
	}
}

