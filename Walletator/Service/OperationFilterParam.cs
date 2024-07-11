using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walletator.Service
{
    // класс содержащий параметры фильтрации операций
    public class OperationFilterParam
    {
        // поля
        private DateTime periodFrom; // период от
        private DateTime periodTo; // период до
        private string comment; // комментарий
        private string category;//категории
        private string amountFrom; //сумма от
        private string amountTo;// сумма до
        private bool isAdd; //зачисление
        private bool isWithdraw; // списание
        
        //свойства
        public DateTime PeriodFrom { get { return periodFrom; }  }
        public DateTime PeriodTo { get { return periodTo; } }
        public string Comment { get { return comment; } }
        public bool IsNoComment { get { return comment == null || comment == ""; } }
        public string Category { get { return category; } }
        public bool IsNoCategory { get { return category == null || category == ""; } }
        public decimal AmountFrom { get { return Convert.ToDecimal(amountFrom); } }
        public decimal AmountTo { get { return Convert.ToDecimal(amountTo); } }
        public bool IsNoAmountTo { get { return amountTo == null || amountTo == ""; } }
        public bool IsNoAmountFrom { get { return amountFrom == null || amountFrom == ""; } }
        public bool IsAdd { get { return isAdd; } }
        public bool IsWithdraw { get { return isWithdraw; } }
        public bool IsAll { get { return IsAdd && IsWithdraw; } }

        //конструктор
        public OperationFilterParam(
            DateTime periodFrom,
            DateTime periodTo, 
            string comment, 
            string category,
            string amountFrom,
            string amountTo, 
            bool isAdd,
            bool isWithdraw)
        {
            this.periodFrom = new DateTime(periodFrom.Year, periodFrom.Month, periodFrom.Day, 0, 0, 0);
            this.periodTo = new DateTime(periodTo.Year, periodTo.Month, periodTo.Day, 0, 0, 0);
            
            if(this.periodFrom > this.periodTo)
            {
                throw new ArgumentException("Начало периода не может быть позже конца периода");
            }
            
            this.comment = comment;
            this.category = category;

            this.amountTo = amountTo;
            decimal amountToValue = 0;
            if (!IsNoAmountTo && (!decimal.TryParse(amountTo, out amountToValue) || amountToValue < 0)) 
            {
                throw new ArgumentException("Значение суммы должно быть положительным числом");
            }

            this.amountFrom = amountFrom;
            decimal amountFromValue = 0;
            if (!IsNoAmountFrom && (!decimal.TryParse(amountFrom, out amountFromValue) || amountFromValue < 0))
            {
                throw new ArgumentException("Значение суммы должно быть положительным числом");
            }
            
            if(!IsNoAmountTo && !IsNoAmountFrom && amountFromValue > amountToValue)
            {
                throw new ArgumentException("Конечная сумма не может быть меньше начальной");
            }

            if(!isAdd && !isWithdraw)
            {
                throw new ArgumentException("Некорректное значение параметра фильтра зачисления/списания");
            }
            this.isAdd = isAdd;
            this.isWithdraw = isWithdraw;

        }

       
        

    }

}
