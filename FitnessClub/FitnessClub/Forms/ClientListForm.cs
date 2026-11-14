using System;
using System.Windows.Forms;
using Unity;
using FitnessClub.Repositories;

namespace FitnessClub.Forms
{
    public partial class ClientListForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IClientRepository _clientRepository;

        public ClientListForm(IUnityContainer container, IClientRepository clientRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }

        private void ClientListForm_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _clientRepository.ReadClients();

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<ClientEditForm>().ShowDialog();
            LoadList();
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;

            var form = _container.Resolve<ClientEditForm>();
            form.Id = findId; // Вот тут возникала ошибка, потому что в EditForm не было Id
            form.ShowDialog();
            LoadList();
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _clientRepository.DeleteClient(findId);
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