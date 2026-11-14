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

namespace FitnessClub.Forms;

public partial class TrainerEditForm : Form
{
    private readonly ITrainerRepository _trainerRepository;
    private int? _trainerId;

    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            var trainer = _trainerRepository.ReadTrainerById(value);
            textBoxFullName.Text = trainer.FullName;
            textBoxSpecialization.Text = trainer.Specialization;
            _trainerId = value;
        }
    }

    public TrainerEditForm(ITrainerRepository trainerRepository)
    {
        InitializeComponent();
        _trainerRepository = trainerRepository ?? throw new ArgumentNullException(nameof(trainerRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) || string.IsNullOrWhiteSpace(textBoxSpecialization.Text))
                throw new Exception("Имеются незаполненные поля");

            var trainer = Trainer.CreateEntity(_trainerId ?? 0, textBoxFullName.Text, textBoxSpecialization.Text);

            if (_trainerId.HasValue) _trainerRepository.UpdateTrainer(trainer);
            else _trainerRepository.CreateTrainer(trainer);

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}