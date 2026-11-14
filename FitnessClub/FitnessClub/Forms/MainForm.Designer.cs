namespace FitnessClub.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuDirectories = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTrainers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMembershipTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMemberships = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFitnessClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemVisits = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();

            // menuStripMain
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuDirectories,
                this.menuOperations,
                this.menuReports});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;

            // menuDirectories
            this.menuDirectories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemClients,
                this.menuItemTrainers,
                this.menuItemMembershipTypes});
            this.menuDirectories.Name = "menuDirectories";
            this.menuDirectories.Text = "Справочники";

            // menuItemClients
            this.menuItemClients.Name = "menuItemClients";
            this.menuItemClients.Text = "Клиенты";
            this.menuItemClients.Click += new System.EventHandler(this.ClientsMenuItem_Click);

            // menuItemTrainers
            this.menuItemTrainers.Name = "menuItemTrainers";
            this.menuItemTrainers.Text = "Тренеры";
            this.menuItemTrainers.Click += new System.EventHandler(this.TrainersMenuItem_Click);

            // menuItemMembershipTypes
            this.menuItemMembershipTypes.Name = "menuItemMembershipTypes";
            this.menuItemMembershipTypes.Text = "Типы абонементов";
            this.menuItemMembershipTypes.Click += new System.EventHandler(this.MembershipTypesMenuItem_Click);

            // menuOperations
            this.menuOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemMemberships,
                this.menuItemFitnessClasses,
                this.menuItemVisits});
            this.menuOperations.Name = "menuOperations";
            this.menuOperations.Text = "Операции";

            // menuItemMemberships
            this.menuItemMemberships.Name = "menuItemMemberships";
            this.menuItemMemberships.Text = "Продажа абонемента";
            this.menuItemMemberships.Click += new System.EventHandler(this.MembershipsMenuItem_Click);

            // menuItemFitnessClasses
            this.menuItemFitnessClasses.Name = "menuItemFitnessClasses";
            this.menuItemFitnessClasses.Text = "Занятия";
            this.menuItemFitnessClasses.Click += new System.EventHandler(this.FitnessClassesMenuItem_Click);

            // menuItemVisits
            this.menuItemVisits.Name = "menuItemVisits";
            this.menuItemVisits.Text = "Посещения";
            this.menuItemVisits.Click += new System.EventHandler(this.VisitsMenuItem_Click);

            // menuReports
            this.menuReports.Name = "menuReports";
            this.menuReports.Text = "Отчеты";

            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Фитнес-клуб";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuDirectories;
        private System.Windows.Forms.ToolStripMenuItem menuItemClients;
        private System.Windows.Forms.ToolStripMenuItem menuItemTrainers;
        private System.Windows.Forms.ToolStripMenuItem menuItemMembershipTypes;
        private System.Windows.Forms.ToolStripMenuItem menuOperations;
        private System.Windows.Forms.ToolStripMenuItem menuItemMemberships;
        private System.Windows.Forms.ToolStripMenuItem menuItemFitnessClasses;
        private System.Windows.Forms.ToolStripMenuItem menuItemVisits;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
    }
}