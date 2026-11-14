namespace FitnessClub.Forms
{
    partial class MembershipTypeEditForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelDuration = new System.Windows.Forms.Label();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.SuspendLayout();

            this.labelName.AutoSize = true; this.labelName.Location = new System.Drawing.Point(30, 30); this.labelName.Text = "Название:";
            this.textBoxName.Location = new System.Drawing.Point(140, 27); this.textBoxName.Size = new System.Drawing.Size(200, 23); this.textBoxName.Name = "textBoxName";

            this.labelPrice.AutoSize = true; this.labelPrice.Location = new System.Drawing.Point(30, 70); this.labelPrice.Text = "Цена:";
            this.numericUpDownPrice.Location = new System.Drawing.Point(140, 67); this.numericUpDownPrice.Size = new System.Drawing.Size(200, 23); this.numericUpDownPrice.Name = "numericUpDownPrice"; this.numericUpDownPrice.DecimalPlaces = 2;

            this.labelDuration.AutoSize = true; this.labelDuration.Location = new System.Drawing.Point(30, 110); this.labelDuration.Text = "Дней:";
            this.numericUpDownDuration.Location = new System.Drawing.Point(140, 107); this.numericUpDownDuration.Size = new System.Drawing.Size(200, 23); this.numericUpDownDuration.Name = "numericUpDownDuration";

            this.labelCategory.AutoSize = true; this.labelCategory.Location = new System.Drawing.Point(30, 150); this.labelCategory.Text = "Категория:";
            this.comboBoxCategory.Location = new System.Drawing.Point(140, 147); this.comboBoxCategory.Size = new System.Drawing.Size(200, 23); this.comboBoxCategory.Name = "comboBoxCategory"; this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.buttonSave.Location = new System.Drawing.Point(140, 200); this.buttonSave.Size = new System.Drawing.Size(90, 30); this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            this.buttonCancel.Location = new System.Drawing.Point(250, 200); this.buttonCancel.Size = new System.Drawing.Size(90, 30); this.buttonCancel.Text = "Отмена";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.buttonCancel); this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxCategory); this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.numericUpDownDuration); this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.numericUpDownPrice); this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName); this.Controls.Add(this.labelName);
            this.Text = "Тип абонемента";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.Label labelName; private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPrice; private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelDuration; private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.Label labelCategory; private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonSave; private System.Windows.Forms.Button buttonCancel;
    }
}