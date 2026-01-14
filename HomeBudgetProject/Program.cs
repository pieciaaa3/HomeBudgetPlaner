using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;
using HomeBudgetProject.Classes;
using HomeBudgetProject.Enums;

namespace HomeBudgetProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            User guest = new User("guest", "guest", StatusLevel.Guest);

            HomeBudgetPlanner planner = new HomeBudgetPlanner();
            HomeBudgetPlannerProxy plannerProxy = new HomeBudgetPlannerProxy(guest, planner);

            
            plannerProxy.AddExpense(new Expense("Wengiel", 300));
            display.ShowPlan(planner);


            BudgetGroup group = new BudgetGroup("Damian", "Rozrywka");
            BudgetGroup group2 = new BudgetGroup("1.", " Piwko");
            group.Add(new Expense("Wyjście z dziewczyną", 75));
            group2.Add(new Expense("Piwo z chłopakami", 50));
            group2.Add(new Expense("Drugie piwo z chłopakami", 70));
            group.Add(group2);
            planner.AddGroup(group);

            display.ShowPlan(planner);





            
        }
    }
}
