using System;
using System.Windows.Forms;
using FitnessClub.Entities;
using FitnessClub.Repositories;
using FitnessClub.Entities.Enum;

namespace FitnessClub.Forms
{
    public partial class ClientEditForm : Form
    {
        private readonly IClientRepository _clientRepository;
        private int? _clientId;

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int Id
        {
            set
            {
                var client = _clientRepository.ReadClientById(value);
                if (client != null)
                {
                    textBoxFullName.Text = client.FullName;
                    textBoxPhone.Text = client.Phone;
                    _clientId = value;
                }
            }
        }

        public ClientEditForm(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text) || string.IsNullOrWhiteSpace(textBoxPhone.Text))
                    throw new Exception("Имеются незаполненные поля");

                var client = Client.CreateEntity(_clientId ?? 0, textBoxFullName.Text, textBoxPhone.Text);

                if (_clientId.HasValue) _clientRepository.UpdateClient(client);
                else _clientRepository.CreateClient(client);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}