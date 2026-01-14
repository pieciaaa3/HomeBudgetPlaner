using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudgetProject.Enums;

namespace HomeBudgetProject.Classes
{
    public abstract class BudgetItem
    {
        public string Name;
        public float Value;

        public BudgetItem(string name, float value)
        {
            Name = name;
            Value = value;
        }
        
        public abstract float GetValue();

        public override string ToString()
        {
            return $"Element: {Name} Koszt: {Value}";
        }
    }
}
