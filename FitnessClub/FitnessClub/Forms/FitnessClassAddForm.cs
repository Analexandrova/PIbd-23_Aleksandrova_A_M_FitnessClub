using System;
using System.Windows.Forms;
using FitnessClub.Entities;
using FitnessClub.Entities.Enum;
using FitnessClub.Repositories;


namespace FitnessClub.Forms
{
    public partial class FitnessClassAddForm : Form
    {
        private readonly IFitnessClassRepository _classRepository;
        private int? _classId; // Храним ID (null если создаем)

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]

        public int Id
        {
            set
            {
                var fitnessClass = _classRepository.ReadClassById(value);
                if (fitnessClass != null)
                {
                    textBoxName.Text = fitnessClass.Name;
                    numericUpDownPlaces.Value = fitnessClass.MaxPlaces;
                    // Восстанавливаем выбранные дни в CheckedListBox
                    for (int i = 0; i < checkedListBoxDays.Items.Count; i++)
                    {
                        var day = (WeekDays)checkedListBoxDays.Items[i];
                        if ((fitnessClass.ScheduleDays & day) != 0)
                            checkedListBoxDays.SetItemChecked(i, true);
                    }
                    _classId = value;
                }
            }
        }

        public FitnessClassAddForm(IFitnessClassRepository classRepository, ITrainerRepository trainerRepository)
        {
            InitializeComponent();
            _classRepository = classRepository;

            comboBoxTrainer.DataSource = trainerRepository.ReadTrainers();
            comboBoxTrainer.DisplayMember = "FullName";
            comboBoxTrainer.ValueMember = "Id";

            foreach (WeekDays day in Enum.GetValues<WeekDays>())
            {
                if (day != WeekDays.None)
                    checkedListBoxDays.Items.Add(day);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTrainer.SelectedIndex < 0 || string.IsNullOrWhiteSpace(textBoxName.Text) || checkedListBoxDays.CheckedItems.Count == 0)
                    throw new Exception("Имеются незаполненные поля");

                WeekDays selectedDays = WeekDays.None;
                foreach (var item in checkedListBoxDays.CheckedItems)
                    selectedDays |= (WeekDays)item;

                var fitnessClass = FitnessClass.CreateOperation(
                    _classId ?? 0,
                    (int)comboBoxTrainer.SelectedValue!,
                    textBoxName.Text,
                    selectedDays,
                    (int)numericUpDownPlaces.Value
                );

                if (_classId.HasValue) _classRepository.UpdateClass(fitnessClass);
                else _classRepository.CreateClass(fitnessClass);

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