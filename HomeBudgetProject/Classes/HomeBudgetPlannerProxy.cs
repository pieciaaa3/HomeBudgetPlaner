using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudgetProject.Enums;
using HomeBudgetProject.Interfaces;

namespace HomeBudgetProject.Classes
{
    internal class HomeBudgetPlannerProxy : IHomeBudgetPlanner
    {
        private HomeBudgetPlanner _realService;
        private User user;

        public HomeBudgetPlannerProxy(User user, HomeBudgetPlanner service)
        {
            this.user = user;
            _realService = service;
        }

        public void AddExpense(Expense item)
        {
            _realService.AddExpense(item);
        }

        public void AddIncome(Income item)
        {
            _realService.AddIncome(item);
        }

        public void Attach(IBudgetObserver observer)
        {
            _realService.Attach(observer);
        }

        public void Detach(IBudgetObserver observer)
        {
            _realService.Detach(observer);
        }

        public void GenerateRaport()
        {
            if (!HasPermission(nameof(GenerateRaport)))
            {
                Console.WriteLine("X");
                return;
            }
            _realService.GenerateRaport();
       
        }

        public void Notify()
        {
            _realService.Notify();
        }

        public void SetStrategy(IRaportStrategy strategy)
        {
            if (!HasPermission(nameof(SetStrategy)))
            {
                Console.WriteLine("X");
                return;
            }
            _realService.SetStrategy(strategy);
        }

        private bool HasPermission(string methodName)
        {
            switch (methodName)
            {
                case "GenerateRaport":
                    if (user.Status < StatusLevel.NormalUser)
                    {
                        return false;
                    }
                    break;
                case "SetStrategy":
                    if (user.Status < StatusLevel.VIP)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}
