using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudgetProject.Enums;

namespace HomeBudgetProject.Classes
{
    public class Expense : BudgetItem
    {
        public Expense(string name, float value): base(name, value) {}
        public override float GetValue()
        {
            return Value;
        }

    }
}
