namespace FitnessClub.Forms
{
    partial class ClientEditForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelFullName.AutoSize = true; this.labelFullName.Location = new System.Drawing.Point(30, 30); this.labelFullName.Text = "ФИО:";
            this.textBoxFullName.Location = new System.Drawing.Point(120, 27); this.textBoxFullName.Size = new System.Drawing.Size(200, 23); this.textBoxFullName.Name = "textBoxFullName";
            this.labelPhone.AutoSize = true; this.labelPhone.Location = new System.Drawing.Point(30, 70); this.labelPhone.Text = "Телефон:";
            this.textBoxPhone.Location = new System.Drawing.Point(120, 67); this.textBoxPhone.Size = new System.Drawing.Size(200, 23); this.textBoxPhone.Name = "textBoxPhone";

            this.buttonSave.Location = new System.Drawing.Point(120, 120); this.buttonSave.Size = new System.Drawing.Size(90, 30); this.buttonSave.Text = "Сохранить"; this.buttonSave.Name = "buttonSave";
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new System.Drawing.Point(230, 120); this.buttonCancel.Size = new System.Drawing.Size(90, 30); this.buttonCancel.Text = "Отмена"; this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.buttonCancel); this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPhone); this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxFullName); this.Controls.Add(this.labelFullName);
            this.Text = "Клиент";
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.Label labelFullName; private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelPhone; private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonSave; private System.Windows.Forms.Button buttonCancel;
    }
}