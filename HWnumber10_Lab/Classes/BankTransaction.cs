using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber10_Lab.Classes
{
    internal class BankTransaction
    {
        #region Fields
        readonly DateTime DateTime;
        readonly decimal AmountOfMoney;
        #endregion

        #region Constructors 
        public BankTransaction(decimal amountOfMoney)
        {
            DateTime = DateTime.Now;
            AmountOfMoney = amountOfMoney;
        }
        #endregion

    }
}
