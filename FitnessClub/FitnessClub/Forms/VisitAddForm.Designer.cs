namespace FitnessClub.Forms
{
    partial class VisitAddForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelClient.AutoSize = true; this.labelClient.Location = new System.Drawing.Point(30, 30); this.labelClient.Text = "Клиент:";
            this.comboBoxClient.Location = new System.Drawing.Point(140, 27); this.comboBoxClient.Size = new System.Drawing.Size(200, 23); this.comboBoxClient.Name = "comboBoxClient"; this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.labelClass.AutoSize = true; this.labelClass.Location = new System.Drawing.Point(30, 70); this.labelClass.Text = "Занятие:";
            this.comboBoxClass.Location = new System.Drawing.Point(140, 67); this.comboBoxClass.Size = new System.Drawing.Size(200, 23); this.comboBoxClass.Name = "comboBoxClass"; this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.buttonSave.Location = new System.Drawing.Point(140, 120); this.buttonSave.Size = new System.Drawing.Size(90, 30); this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            this.buttonCancel.Location = new System.Drawing.Point(250, 120); this.buttonCancel.Size = new System.Drawing.Size(90, 30); this.buttonCancel.Text = "Отмена";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.buttonCancel); this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxClass); this.Controls.Add(this.labelClass);
            this.Controls.Add(this.comboBoxClient); this.Controls.Add(this.labelClient);
            this.Text = "Посещение";
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.Label labelClient; private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClass; private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Button buttonSave; private System.Windows.Forms.Button buttonCancel;
    }
}