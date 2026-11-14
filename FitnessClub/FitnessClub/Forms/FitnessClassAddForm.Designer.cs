namespace FitnessClub.Forms
{
    partial class FitnessClassAddForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.labelTrainer = new System.Windows.Forms.Label();
            this.comboBoxTrainer = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.checkedListBoxDays = new System.Windows.Forms.CheckedListBox();
            this.labelPlaces = new System.Windows.Forms.Label();
            this.numericUpDownPlaces = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaces)).BeginInit();
            this.SuspendLayout();

            this.labelTrainer.AutoSize = true; this.labelTrainer.Location = new System.Drawing.Point(30, 30); this.labelTrainer.Text = "Тренер:";
            this.comboBoxTrainer.Location = new System.Drawing.Point(140, 27); this.comboBoxTrainer.Size = new System.Drawing.Size(200, 23); this.comboBoxTrainer.Name = "comboBoxTrainer"; this.comboBoxTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.labelName.AutoSize = true; this.labelName.Location = new System.Drawing.Point(30, 70); this.labelName.Text = "Название:";
            this.textBoxName.Location = new System.Drawing.Point(140, 67); this.textBoxName.Size = new System.Drawing.Size(200, 23); this.textBoxName.Name = "textBoxName";

            this.labelDays.AutoSize = true; this.labelDays.Location = new System.Drawing.Point(30, 110); this.labelDays.Text = "Дни недели:";
            this.checkedListBoxDays.Location = new System.Drawing.Point(140, 110); this.checkedListBoxDays.Size = new System.Drawing.Size(200, 94); this.checkedListBoxDays.Name = "checkedListBoxDays"; this.checkedListBoxDays.CheckOnClick = true;

            this.labelPlaces.AutoSize = true; this.labelPlaces.Location = new System.Drawing.Point(30, 230); this.labelPlaces.Text = "Мест:";
            this.numericUpDownPlaces.Location = new System.Drawing.Point(140, 228); this.numericUpDownPlaces.Size = new System.Drawing.Size(200, 23); this.numericUpDownPlaces.Name = "numericUpDownPlaces"; this.numericUpDownPlaces.Minimum = new decimal(new int[] { 1, 0, 0, 0 }); this.numericUpDownPlaces.Value = new decimal(new int[] { 10, 0, 0, 0 });

            this.buttonSave.Location = new System.Drawing.Point(140, 280); this.buttonSave.Size = new System.Drawing.Size(90, 30); this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            this.buttonCancel.Location = new System.Drawing.Point(250, 280); this.buttonCancel.Size = new System.Drawing.Size(90, 30); this.buttonCancel.Text = "Отмена";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.buttonCancel); this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownPlaces); this.Controls.Add(this.labelPlaces);
            this.Controls.Add(this.checkedListBoxDays); this.Controls.Add(this.labelDays);
            this.Controls.Add(this.textBoxName); this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxTrainer); this.Controls.Add(this.labelTrainer);
            this.Text = "Добавление занятия";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaces)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.Label labelTrainer; private System.Windows.Forms.ComboBox comboBoxTrainer;
        private System.Windows.Forms.Label labelName; private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDays; private System.Windows.Forms.CheckedListBox checkedListBoxDays;
        private System.Windows.Forms.Label labelPlaces; private System.Windows.Forms.NumericUpDown numericUpDownPlaces;
        private System.Windows.Forms.Button buttonSave; private System.Windows.Forms.Button buttonCancel;
    }
}