using FitnessClub.Entities;
using FitnessClub.Entities.Enum;
using FitnessClub.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Forms;

public partial class MembershipTypeEditForm : Form
{
    private readonly IMembershipTypeRepository _typeRepository;
    private int? _typeId;

    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            var type = _typeRepository.ReadMembershipTypeById(value);
            textBoxName.Text = type.Name;
            numericUpDownPrice.Value = type.Price;
            numericUpDownDuration.Value = type.DurationDays;
            comboBoxCategory.SelectedItem = type.Category;
            _typeId = value;
        }
    }

    public MembershipTypeEditForm(IMembershipTypeRepository typeRepository)
    {
        InitializeComponent();
        _typeRepository = typeRepository ?? throw new ArgumentNullException(nameof(typeRepository));

        // Заполняем ComboBox значениями перечисления
        comboBoxCategory.DataSource = Enum.GetValues(typeof(MembershipCategory));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || comboBoxCategory.SelectedIndex < 0)
                throw new Exception("Имеются незаполненные поля");

            var type = MembershipType.CreateEntity(
                _typeId ?? 0,
                textBoxName.Text,
                numericUpDownPrice.Value,
                (int)numericUpDownDuration.Value,
                (MembershipCategory)comboBoxCategory.SelectedItem!);

            if (_typeId.HasValue) _typeRepository.UpdateMembershipType(type);
            else _typeRepository.CreateMembershipType(type);

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}