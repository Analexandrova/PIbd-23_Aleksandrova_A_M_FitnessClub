using Unity;
using Unity.Lifetime;
using FitnessClub.Repositories;
using FitnessClub.Repositories.Implementations;
using FitnessClub.Forms;

namespace FitnessClub
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<MainForm>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IClientRepository, ClientRepository>(new TransientLifetimeManager());
            container.RegisterType<ITrainerRepository, TrainerRepository>(new TransientLifetimeManager());
            container.RegisterType<IMembershipTypeRepository, MembershipTypeRepository>(new TransientLifetimeManager());
            container.RegisterType<IMembershipRepository, MembershipRepository>(new TransientLifetimeManager());
            container.RegisterType<IFitnessClassRepository, FitnessClassRepository>(new TransientLifetimeManager());
            container.RegisterType<IVisitRepository, VisitRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}