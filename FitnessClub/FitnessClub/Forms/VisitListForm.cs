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

namespace FitnessClub.Forms
{
    public partial class VisitListForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IVisitRepository _visitRepository;

        public VisitListForm(IUnityContainer container, IVisitRepository visitRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _visitRepository = visitRepository ?? throw new ArgumentNullException(nameof(visitRepository));
        }

        private void VisitListForm_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _visitRepository.ReadVisits();

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<VisitAddForm>().ShowDialog();
            LoadList();
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            var form = _container.Resolve<VisitAddForm>();
            form.Id = findId;
            form.ShowDialog();
            LoadList();
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _visitRepository.DeleteVisit(findId);
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