using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Unity;
using FitnessClub.Repositories;

namespace FitnessClub.Forms
{
    public partial class FitnessClassListForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IFitnessClassRepository _classRepository;

        public FitnessClassListForm(IUnityContainer container, IFitnessClassRepository classRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _classRepository = classRepository ?? throw new ArgumentNullException(nameof(classRepository));
        }

        private void FitnessClassListForm_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _classRepository.ReadClasses();

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FitnessClassAddForm>().ShowDialog();
            LoadList();
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            var form = _container.Resolve<FitnessClassAddForm>();
            form.Id = findId; // Передаем ID в форму
            form.ShowDialog();
            LoadList();
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _classRepository.DeleteClass(findId);
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