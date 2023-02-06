using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Models
{
    
    class Saving:Account
    {
        private bool _isWithdraw;
        private static double _defaultBalance=1000;
        private new static string _accountType="Saving Account";
        
        public Saving(int accountNo, string name, double balance) : base(accountNo, name, balance,_accountType)
        {

        }
        public Saving(int accountNo, string name) : this(accountNo, name,_defaultBalance)
        {

        }
        public override void WithdrawAmount(double withdrawAmount)
        {
           if((_balance-withdrawAmount)>=_defaultBalance && _balance!=0) {
                _balance -= withdrawAmount;
                _isWithdraw= true;
                return;
            }

            _isWithdraw= false;
        }
        public bool IsWithdraw { get { return _isWithdraw; } }
    }
}
