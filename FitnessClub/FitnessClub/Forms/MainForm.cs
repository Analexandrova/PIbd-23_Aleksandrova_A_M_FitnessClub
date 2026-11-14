using System;
using System.Windows.Forms;
using Unity;

namespace FitnessClub.Forms
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void ClientsMenuItem_Click(object sender, EventArgs e) => _container.Resolve<ClientListForm>().ShowDialog();
        private void TrainersMenuItem_Click(object sender, EventArgs e) => _container.Resolve<TrainerListForm>().ShowDialog();
        private void MembershipTypesMenuItem_Click(object sender, EventArgs e) => _container.Resolve<MembershipTypeListForm>().ShowDialog();

        private void MembershipsMenuItem_Click(object sender, EventArgs e) => _container.Resolve<MembershipListForm>().ShowDialog();
        private void FitnessClassesMenuItem_Click(object sender, EventArgs e) => _container.Resolve<FitnessClassListForm>().ShowDialog();
        private void VisitsMenuItem_Click(object sender, EventArgs e) => _container.Resolve<VisitListForm>().ShowDialog();
    }
}