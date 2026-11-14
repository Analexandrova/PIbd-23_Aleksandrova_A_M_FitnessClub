using System;
using System.Windows.Forms;
using Unity;
using FitnessClub.Repositories;

namespace FitnessClub.Forms
{
    public partial class MembershipListForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IMembershipRepository _membershipRepository;

        public MembershipListForm(IUnityContainer container, IMembershipRepository membershipRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _membershipRepository = membershipRepository ?? throw new ArgumentNullException(nameof(membershipRepository));
        }

        private void MembershipListForm_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _membershipRepository.ReadMemberships();

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<MembershipAddForm>().ShowDialog();
            LoadList();
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            var form = _container.Resolve<MembershipAddForm>();
            form.Id = findId;
            form.ShowDialog();
            LoadList();
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _membershipRepository.DeleteMembership(findId);
            LoadList();
        }

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}