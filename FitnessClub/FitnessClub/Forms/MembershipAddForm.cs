using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessClub.Entities;
using FitnessClub.Repositories;

namespace FitnessClub.Forms
{
    public partial class MembershipAddForm : Form
    {
        private readonly IMembershipRepository _membershipRepository;
        private int? _membershipId; // Поле для хранения ID (null, если новая запись)

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]

        public int Id
        {
            set
            {
                var membership = _membershipRepository.ReadMembershipById(value);
                if (membership != null)
                {
                    comboBoxClient.SelectedValue = membership.ClientId;
                    comboBoxType.SelectedValue = membership.MembershipTypeId;
                    _membershipId = value;
                }
            }
        }

        public MembershipAddForm(IMembershipRepository membershipRepository, IClientRepository clientRepository, IMembershipTypeRepository typeRepository)
        {
            InitializeComponent();
            _membershipRepository = membershipRepository;

            comboBoxClient.DataSource = clientRepository.ReadClients();
            comboBoxClient.DisplayMember = "FullName";
            comboBoxClient.ValueMember = "Id";

            comboBoxType.DataSource = typeRepository.ReadMembershipTypes();
            comboBoxType.DisplayMember = "Name";
            comboBoxType.ValueMember = "Id";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClient.SelectedIndex < 0 || comboBoxType.SelectedIndex < 0)
                    throw new Exception("Имеются незаполненные поля");

                // Если _membershipId имеет значение, значит это редактирование, иначе создание
                var membership = Membership.CreateOperation(
                    _membershipId ?? 0,
                    (int)comboBoxClient.SelectedValue!,
                    (int)comboBoxType.SelectedValue!,
                    DateTime.Now
                );

                if (_membershipId.HasValue) _membershipRepository.UpdateMembership(membership);
                else _membershipRepository.CreateMembership(membership);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}