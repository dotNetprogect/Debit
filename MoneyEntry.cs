using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Debit
{
    class MoneyEntry
    {
        private double _amount;
        ///
        /// Стандартный конструктор
        /// 
        public MoneyEntry()
        {
            _amount = 0;
            EntryDate = DateTime.Now;
        }
        ///
        /// Конструктор
        ///
        /// Сумма записи
        /// Дата записи
        public MoneyEntry(double amount, DateTime date)
        {
            _amount = amount;
            EntryDate = date;
        }
       
        public void InitWithString(string amount, string date)
        {
            Double.TryParse(amount, out _amount);

            DateTime dt;
            DateTime.TryParse(date, out dt);
            EntryDate = dt;
        }
        ///
        /// Перереопределяем toString()
        ///
        /// отформатированная строка
        public override string ToString()
        {
            return string.Format("{0} от {1}", _amount, EntryDate.Date);
        }
        ///
        /// Определяет является ли это доходом
        ///
        public bool IsDebit
        {
            get
            {
                return (_amount >= 0);
            }
            set
            {
                if (value && _amount < 0)
                    _amount = -_amount;
            }
        }

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        ///
        /// дата записи
        ///
        public DateTime EntryDate { get; set; }
        // категория
        public string Category { get; set; }
        // Описание
        public string Description { get; set; }
    } 
}