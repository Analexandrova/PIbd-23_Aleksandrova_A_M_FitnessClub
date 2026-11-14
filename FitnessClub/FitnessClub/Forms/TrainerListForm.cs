using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using FitnessClub.Repositories;

namespace FitnessClub.Forms;

public partial class TrainerListForm : Form
{
    private readonly IUnityContainer _container;
    private readonly ITrainerRepository _trainerRepository;

    public TrainerListForm(IUnityContainer container, ITrainerRepository trainerRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _trainerRepository = trainerRepository ?? throw new ArgumentNullException(nameof(trainerRepository));
    }

    private void TrainerListForm_Load(object sender, EventArgs e) => LoadList();

    private void LoadList() => dataGridViewData.DataSource = _trainerRepository.ReadTrainers();

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        _container.Resolve<TrainerEditForm>().ShowDialog();
        LoadList();
    }

    private void ButtonUpd_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
        var form = _container.Resolve<TrainerEditForm>();
        form.Id = findId;
        form.ShowDialog();
        LoadList();
    }

    private void ButtonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        _trainerRepository.DeleteTrainer(findId);
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