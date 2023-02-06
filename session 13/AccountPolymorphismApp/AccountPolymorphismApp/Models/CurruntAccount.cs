using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Models
{
    class CurruntAccount:Account
    {
        public double _overDraftLimit = -5000;
        private static double initialAmount=0;
        private new static string _accountType = "Currunt Account";
        public CurruntAccount(int accountNo,string name):this(accountNo,name,initialAmount)
        {

        }
        public CurruntAccount(int accountNo, string name,double balance):base(accountNo,name,balance,_accountType)
        {

        }

        public override void WithdrawAmount(double amountWithdraw)
        {
            if (_overDraftLimit<0 &&_balance<=0 && /*_overDraftLimit+amountWithdraw<=_overDraftLimit*/ amountWithdraw >= _overDraftLimit) { 
            
                    _balance -= amountWithdraw;
                    _overDraftLimit+= amountWithdraw;
                    return;
                
            }

            if (_overDraftLimit==0 && _balance<=0)
            {

            }
            if(_balance<0 && _overDraftLimit-amountWithdraw>=_overDraftLimit) 
            { 
                _balance-= amountWithdraw;
                _overDraftLimit+= amountWithdraw;
                return;
            }
            
            if(amountWithdraw>=_balance && _overDraftLimit!=0 )
            {                                      //&& amountWithdraw>=_overDraftLimit

                _balance-= amountWithdraw;
                return;
            
            }
            if (_balance > 0 && amountWithdraw>_balance)
            {
                double remainingAmount = _balance - amountWithdraw;
                _balance -= amountWithdraw;
                if(remainingAmount < 0)
                {
                    _overDraftLimit +=(remainingAmount/-1);
                }
            }
            
        }
    }
}
