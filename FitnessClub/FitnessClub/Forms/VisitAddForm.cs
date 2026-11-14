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
    public partial class VisitAddForm : Form
    {
        private readonly IVisitRepository _visitRepository;
        private int? _visitId;

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]

        public int Id
        {
            set
            {
                var visit = _visitRepository.ReadVisitById(value);
                if (visit != null)
                {
                    comboBoxClient.SelectedValue = visit.ClientId;
                    comboBoxClass.SelectedValue = visit.ClassId;
                    _visitId = value;
                }
            }
        }

        public VisitAddForm(IVisitRepository visitRepository, IClientRepository clientRepository, IFitnessClassRepository classRepository)
        {
            InitializeComponent();
            _visitRepository = visitRepository;

            comboBoxClient.DataSource = clientRepository.ReadClients();
            comboBoxClient.DisplayMember = "FullName";
            comboBoxClient.ValueMember = "Id";

            comboBoxClass.DataSource = classRepository.ReadClasses();
            comboBoxClass.DisplayMember = "Name";
            comboBoxClass.ValueMember = "Id";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClient.SelectedIndex < 0 || comboBoxClass.SelectedIndex < 0)
                    throw new Exception("Имеются незаполненные поля");

                var visit = Visit.CreateOperation(
                    _visitId ?? 0,
                    (int)comboBoxClient.SelectedValue!,
                    (int)comboBoxClass.SelectedValue!,
                    DateTime.Now
                );

                if (_visitId.HasValue) _visitRepository.UpdateVisit(visit);
                else _visitRepository.CreateVisit(visit);

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