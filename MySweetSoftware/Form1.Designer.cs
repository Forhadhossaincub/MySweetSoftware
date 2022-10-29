namespace MySweetSoftware
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPriceGrater50 = new System.Windows.Forms.Button();
            this.btnAllProduct = new System.Windows.Forms.Button();
            this.btnProductAvaible = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCount);
            this.groupBox1.Controls.Add(this.btnProductAvaible);
            this.groupBox1.Controls.Add(this.btnAllProduct);
            this.groupBox1.Controls.Add(this.btnPriceGrater50);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPriceGrater50
            // 
            this.btnPriceGrater50.Location = new System.Drawing.Point(12, 85);
            this.btnPriceGrater50.Name = "btnPriceGrater50";
            this.btnPriceGrater50.Size = new System.Drawing.Size(164, 31);
            this.btnPriceGrater50.TabIndex = 0;
            this.btnPriceGrater50.Text = "&Product Price > 50";
            this.btnPriceGrater50.UseVisualStyleBackColor = true;
            this.btnPriceGrater50.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAllProduct
            // 
            this.btnAllProduct.Location = new System.Drawing.Point(12, 39);
            this.btnAllProduct.Name = "btnAllProduct";
            this.btnAllProduct.Size = new System.Drawing.Size(164, 31);
            this.btnAllProduct.TabIndex = 1;
            this.btnAllProduct.Text = "&Show All Product";
            this.btnAllProduct.UseVisualStyleBackColor = true;
            this.btnAllProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProductAvaible
            // 
            this.btnProductAvaible.Location = new System.Drawing.Point(12, 133);
            this.btnProductAvaible.Name = "btnProductAvaible";
            this.btnProductAvaible.Size = new System.Drawing.Size(164, 31);
            this.btnProductAvaible.TabIndex = 2;
            this.btnProductAvaible.Text = "&Product Avaiable";
            this.btnProductAvaible.UseVisualStyleBackColor = true;
            this.btnProductAvaible.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(220, 39);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(145, 31);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "&Product Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Avaiable Product Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LINQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPriceGrater50;
        private System.Windows.Forms.Button btnAllProduct;
        private System.Windows.Forms.Button btnProductAvaible;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button button1;
    }
}

