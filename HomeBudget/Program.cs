using HomeBudget.Repositories;
using HomeBudget.Repositories.Implementations;
using Unity;
using Unity.Lifetime;
namespace HomeBudget
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormHomeBudget>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IBudgetPlanRepository, BudgetPlanRepository>(new TransientLifetimeManager());
            container.RegisterType<IExpencesAndRevenuesRepository, ExpencesAndRevenuesRepository>(new TransientLifetimeManager());
            container.RegisterType<IFamilyMemberRepository, FamilyMemberRepository>(new TransientLifetimeManager());
            container.RegisterType<IIncomeSourceRepository, IncomeSourceRepository>(new TransientLifetimeManager());
            return container;
        }
    }
}