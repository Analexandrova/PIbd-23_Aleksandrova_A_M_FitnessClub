namespace FitnessClub.Forms
{
    partial class TrainerEditForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelSpec = new System.Windows.Forms.Label();
            this.textBoxSpecialization = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelFullName.AutoSize = true; this.labelFullName.Location = new System.Drawing.Point(30, 30); this.labelFullName.Text = "ФИО:";
            this.textBoxFullName.Location = new System.Drawing.Point(140, 27); this.textBoxFullName.Size = new System.Drawing.Size(200, 23); this.textBoxFullName.Name = "textBoxFullName";

            this.labelSpec.AutoSize = true; this.labelSpec.Location = new System.Drawing.Point(30, 70); this.labelSpec.Text = "Специализация:";
            this.textBoxSpecialization.Location = new System.Drawing.Point(140, 67); this.textBoxSpecialization.Size = new System.Drawing.Size(200, 23); this.textBoxSpecialization.Name = "textBoxSpecialization";

            this.buttonSave.Location = new System.Drawing.Point(140, 120); this.buttonSave.Size = new System.Drawing.Size(90, 30); this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            this.buttonCancel.Location = new System.Drawing.Point(250, 120); this.buttonCancel.Size = new System.Drawing.Size(90, 30); this.buttonCancel.Text = "Отмена";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.buttonCancel); this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSpecialization); this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.textBoxFullName); this.Controls.Add(this.labelFullName);
            this.Text = "Тренер";
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.Label labelFullName; private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelSpec; private System.Windows.Forms.TextBox textBoxSpecialization;
        private System.Windows.Forms.Button buttonSave; private System.Windows.Forms.Button buttonCancel;
    }
}