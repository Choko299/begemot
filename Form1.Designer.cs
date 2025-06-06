namespace LaptopManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // txtBrand
            this.txtBrand.Location = new System.Drawing.Point(30, 20);
            this.txtBrand.Size = new System.Drawing.Size(200, 22);
            this.txtBrand.PlaceholderText = "Brand";

            // txtModel
            this.txtModel.Location = new System.Drawing.Point(30, 50);
            this.txtModel.Size = new System.Drawing.Size(200, 22);
            this.txtModel.PlaceholderText = "Model";

            // txtCPU
            this.txtCPU.Location = new System.Drawing.Point(30, 80);
            this.txtCPU.Size = new System.Drawing.Size(200, 22);
            this.txtCPU.PlaceholderText = "CPU";

            // txtRAM
            this.txtRAM.Location = new System.Drawing.Point(30, 110);
            this.txtRAM.Size = new System.Drawing.Size(200, 22);
            this.txtRAM.PlaceholderText = "RAM (GB)";

            // txtStorage
            this.txtStorage.Location = new System.Drawing.Point(30, 140);
            this.txtStorage.Size = new System.Drawing.Size(200, 22);
            this.txtStorage.PlaceholderText = "Storage (GB)";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(30, 170);
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.PlaceholderText = "Price";

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(250, 20);
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "დამატება";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(250, 60);
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "წაშლა";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(30, 210);
            this.dataGridView1.Size = new System.Drawing.Size(600, 200);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Form1
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Text = "Laptop Manager";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
