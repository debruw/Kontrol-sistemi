namespace Venes_projesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lbl_ParcaNo = new System.Windows.Forms.Label();
            this.Lbl_ParcaAdi = new System.Windows.Forms.Label();
            this.txtbox_ParcaNo = new System.Windows.Forms.TextBox();
            this.txtbox_ParcaAdi = new System.Windows.Forms.TextBox();
            this.Lbl_IsEmriNo = new System.Windows.Forms.Label();
            this.Lbl_is_EmriAdet = new System.Windows.Forms.Label();
            this.txtbox_IsEmriNo = new System.Windows.Forms.TextBox();
            this.txtbox_IsEmriAdet = new System.Windows.Forms.TextBox();
            this.Lbl_BasTarih = new System.Windows.Forms.Label();
            this.Lbl_BitTarih = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txtbox_VNS = new System.Windows.Forms.TextBox();
            this.Tp_BasTarih = new System.Windows.Forms.DateTimePicker();
            this.Tp_BitTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_ParcaNo
            // 
            resources.ApplyResources(this.Lbl_ParcaNo, "Lbl_ParcaNo");
            this.Lbl_ParcaNo.Name = "Lbl_ParcaNo";
            // 
            // Lbl_ParcaAdi
            // 
            resources.ApplyResources(this.Lbl_ParcaAdi, "Lbl_ParcaAdi");
            this.Lbl_ParcaAdi.Name = "Lbl_ParcaAdi";
            // 
            // txtbox_ParcaNo
            // 
            resources.ApplyResources(this.txtbox_ParcaNo, "txtbox_ParcaNo");
            this.txtbox_ParcaNo.Name = "txtbox_ParcaNo";
            this.txtbox_ParcaNo.TextChanged += new System.EventHandler(this.txtbox_ParcaNo_TextChanged);
            // 
            // txtbox_ParcaAdi
            // 
            resources.ApplyResources(this.txtbox_ParcaAdi, "txtbox_ParcaAdi");
            this.txtbox_ParcaAdi.Name = "txtbox_ParcaAdi";
            // 
            // Lbl_IsEmriNo
            // 
            resources.ApplyResources(this.Lbl_IsEmriNo, "Lbl_IsEmriNo");
            this.Lbl_IsEmriNo.Name = "Lbl_IsEmriNo";
            // 
            // Lbl_is_EmriAdet
            // 
            resources.ApplyResources(this.Lbl_is_EmriAdet, "Lbl_is_EmriAdet");
            this.Lbl_is_EmriAdet.Name = "Lbl_is_EmriAdet";
            // 
            // txtbox_IsEmriNo
            // 
            resources.ApplyResources(this.txtbox_IsEmriNo, "txtbox_IsEmriNo");
            this.txtbox_IsEmriNo.Name = "txtbox_IsEmriNo";
            // 
            // txtbox_IsEmriAdet
            // 
            resources.ApplyResources(this.txtbox_IsEmriAdet, "txtbox_IsEmriAdet");
            this.txtbox_IsEmriAdet.Name = "txtbox_IsEmriAdet";
            // 
            // Lbl_BasTarih
            // 
            resources.ApplyResources(this.Lbl_BasTarih, "Lbl_BasTarih");
            this.Lbl_BasTarih.Name = "Lbl_BasTarih";
            // 
            // Lbl_BitTarih
            // 
            resources.ApplyResources(this.Lbl_BitTarih, "Lbl_BitTarih");
            this.Lbl_BitTarih.Name = "Lbl_BitTarih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Txtbox_VNS
            // 
            resources.ApplyResources(this.Txtbox_VNS, "Txtbox_VNS");
            this.Txtbox_VNS.Name = "Txtbox_VNS";
            // 
            // Tp_BasTarih
            // 
            resources.ApplyResources(this.Tp_BasTarih, "Tp_BasTarih");
            this.Tp_BasTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tp_BasTarih.Name = "Tp_BasTarih";
            // 
            // Tp_BitTarih
            // 
            resources.ApplyResources(this.Tp_BitTarih, "Tp_BitTarih");
            this.Tp_BitTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tp_BitTarih.Name = "Tp_BitTarih";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_ParcaNo);
            this.groupBox1.Controls.Add(this.Lbl_ParcaAdi);
            this.groupBox1.Controls.Add(this.txtbox_ParcaNo);
            this.groupBox1.Controls.Add(this.Tp_BitTarih);
            this.groupBox1.Controls.Add(this.txtbox_ParcaAdi);
            this.groupBox1.Controls.Add(this.Tp_BasTarih);
            this.groupBox1.Controls.Add(this.Lbl_IsEmriNo);
            this.groupBox1.Controls.Add(this.Txtbox_VNS);
            this.groupBox1.Controls.Add(this.Lbl_is_EmriAdet);
            this.groupBox1.Controls.Add(this.txtbox_IsEmriNo);
            this.groupBox1.Controls.Add(this.Lbl_BitTarih);
            this.groupBox1.Controls.Add(this.txtbox_IsEmriAdet);
            this.groupBox1.Controls.Add(this.Lbl_BasTarih);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ParcaNo;
        private System.Windows.Forms.Label Lbl_ParcaAdi;
        private System.Windows.Forms.TextBox txtbox_ParcaNo;
        private System.Windows.Forms.TextBox txtbox_ParcaAdi;
        private System.Windows.Forms.Label Lbl_IsEmriNo;
        private System.Windows.Forms.Label Lbl_is_EmriAdet;
        private System.Windows.Forms.TextBox txtbox_IsEmriNo;
        private System.Windows.Forms.TextBox txtbox_IsEmriAdet;
        private System.Windows.Forms.Label Lbl_BasTarih;
        private System.Windows.Forms.Label Lbl_BitTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txtbox_VNS;
        private System.Windows.Forms.DateTimePicker Tp_BasTarih;
        private System.Windows.Forms.DateTimePicker Tp_BitTarih;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

