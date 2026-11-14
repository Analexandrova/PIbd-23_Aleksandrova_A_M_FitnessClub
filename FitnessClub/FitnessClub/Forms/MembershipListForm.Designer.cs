namespace FitnessClub.Forms
{
    partial class MembershipListForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();

            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.panelRight.Controls.Add(this.buttonDel);
            this.panelRight.Controls.Add(this.buttonUpd);
            this.panelRight.Controls.Add(this.buttonAdd);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Size = new System.Drawing.Size(180, 450);

            this.buttonAdd.Location = new System.Drawing.Point(20, 20); this.buttonAdd.Size = new System.Drawing.Size(140, 45); this.buttonAdd.Text = "Оформить";
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);

            this.buttonUpd.Location = new System.Drawing.Point(20, 80); this.buttonUpd.Size = new System.Drawing.Size(140, 45); this.buttonUpd.Text = "Редактировать";
            this.buttonUpd.Click += new System.EventHandler(this.ButtonUpd_Click);

            this.buttonDel.Location = new System.Drawing.Point(20, 140); this.buttonDel.Size = new System.Drawing.Size(140, 45); this.buttonDel.Text = "Удалить";
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dataGridViewData);
            this.Text = "Продажи абонементов";
            this.Load += new System.EventHandler(this.MembershipListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
    }
}