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

public partial class MembershipTypeListForm : Form
{
    private readonly IUnityContainer _container;
    private readonly IMembershipTypeRepository _typeRepository;

    public MembershipTypeListForm(IUnityContainer container, IMembershipTypeRepository typeRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _typeRepository = typeRepository ?? throw new ArgumentNullException(nameof(typeRepository));
    }

    private void MembershipTypeListForm_Load(object sender, EventArgs e) => LoadList();

    private void LoadList() => dataGridViewData.DataSource = _typeRepository.ReadMembershipTypes();

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        _container.Resolve<MembershipTypeEditForm>().ShowDialog();
        LoadList();
    }

    private void ButtonUpd_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
        var form = _container.Resolve<MembershipTypeEditForm>();
        form.Id = findId;
        form.ShowDialog();
        LoadList();
    }

    private void ButtonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        _typeRepository.DeleteMembershipType(findId);
        LoadList();
    }

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewData.SelectedRows.Count < 1) return false;
        id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
        return true;
    }
}