namespace FitnessClub.Forms
{
    partial class ClientListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

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

            // dataGridViewData
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill; // Растягиваем на всё свободное место!
            this.dataGridViewData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.Size = new System.Drawing.Size(600, 450);
            this.dataGridViewData.TabIndex = 0;
            this.dataGridViewData.AllowUserToAddRows = false;

            // panelRight (Панель для кнопок)
            this.panelRight.Controls.Add(this.buttonDel);
            this.panelRight.Controls.Add(this.buttonUpd);
            this.panelRight.Controls.Add(this.buttonAdd);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right; // Прижимаем к правому краю
            this.panelRight.Location = new System.Drawing.Point(600, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(150, 450);

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(20, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 40);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);

            // buttonUpd
            this.buttonUpd.Location = new System.Drawing.Point(20, 70);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(110, 40);
            this.buttonUpd.TabIndex = 2;
            this.buttonUpd.Text = "Редактировать";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.ButtonUpd_Click);

            // buttonDel
            this.buttonDel.Location = new System.Drawing.Point(20, 120);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(110, 40);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);

            // ClientListForm
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.dataGridViewData); // Сначала таблицу
            this.Controls.Add(this.panelRight);       // Потом панель с кнопками
            this.Name = "ClientListForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientListForm_Load);
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