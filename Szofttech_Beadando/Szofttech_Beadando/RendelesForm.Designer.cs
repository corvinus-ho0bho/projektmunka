
namespace Szofttech_Beadando
{
    partial class RendelesForm
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idRendelesOsszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kedvezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesInfo2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konyvCimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konyvArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kedvezmenyesArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kedvezmenyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesInfo2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.MistyRose;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 148);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.konyvCimDataGridViewTextBoxColumn,
            this.konyvArDataGridViewTextBoxColumn,
            this.kedvezmenyesArDataGridViewTextBoxColumn,
            this.kedvezmenyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rendelesInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(196, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 160);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Szűrés:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(763, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 68);
            this.button1.TabIndex = 15;
            this.button1.Text = "Uj rendeles felvetele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(367, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 78);
            this.button2.TabIndex = 16;
            this.button2.Text = "Uj rendeles felvetele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(756, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 78);
            this.button3.TabIndex = 17;
            this.button3.Text = "Uj rendeles felvetele";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRendelesOsszDataGridViewTextBoxColumn,
            this.rendDatumDataGridViewTextBoxColumn,
            this.kedvezDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rendelesInfo2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(196, 337);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(474, 150);
            this.dataGridView2.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MistyRose;
            this.textBox2.Location = new System.Drawing.Point(763, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 22);
            this.textBox2.TabIndex = 19;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating_1);
            this.textBox2.Validated += new System.EventHandler(this.textBox2_Validated_1);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MistyRose;
            this.textBox3.Location = new System.Drawing.Point(763, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 22);
            this.textBox3.TabIndex = 20;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating_1);
            this.textBox3.Validated += new System.EventHandler(this.textBox3_Validated_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(682, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "KonyvID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(693, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(760, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Törlés:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(283, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 34);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rendelés\r\nösszesítés:";
            // 
            // idRendelesOsszDataGridViewTextBoxColumn
            // 
            this.idRendelesOsszDataGridViewTextBoxColumn.DataPropertyName = "idRendelesOssz";
            this.idRendelesOsszDataGridViewTextBoxColumn.HeaderText = "idRendelesOssz";
            this.idRendelesOsszDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRendelesOsszDataGridViewTextBoxColumn.Name = "idRendelesOsszDataGridViewTextBoxColumn";
            this.idRendelesOsszDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendDatumDataGridViewTextBoxColumn
            // 
            this.rendDatumDataGridViewTextBoxColumn.DataPropertyName = "rendDatum";
            this.rendDatumDataGridViewTextBoxColumn.HeaderText = "rendDatum";
            this.rendDatumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rendDatumDataGridViewTextBoxColumn.Name = "rendDatumDataGridViewTextBoxColumn";
            this.rendDatumDataGridViewTextBoxColumn.Width = 125;
            // 
            // kedvezDataGridViewTextBoxColumn
            // 
            this.kedvezDataGridViewTextBoxColumn.DataPropertyName = "kedvez";
            this.kedvezDataGridViewTextBoxColumn.HeaderText = "kedvez";
            this.kedvezDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kedvezDataGridViewTextBoxColumn.Name = "kedvezDataGridViewTextBoxColumn";
            this.kedvezDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendelesInfo2BindingSource
            // 
            this.rendelesInfo2BindingSource.DataSource = typeof(Szofttech_Beadando.RendelesInfo2);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // konyvCimDataGridViewTextBoxColumn
            // 
            this.konyvCimDataGridViewTextBoxColumn.DataPropertyName = "konyvCim";
            this.konyvCimDataGridViewTextBoxColumn.HeaderText = "konyvCim";
            this.konyvCimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konyvCimDataGridViewTextBoxColumn.Name = "konyvCimDataGridViewTextBoxColumn";
            this.konyvCimDataGridViewTextBoxColumn.Width = 125;
            // 
            // konyvArDataGridViewTextBoxColumn
            // 
            this.konyvArDataGridViewTextBoxColumn.DataPropertyName = "konyvAr";
            this.konyvArDataGridViewTextBoxColumn.HeaderText = "konyvAr";
            this.konyvArDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konyvArDataGridViewTextBoxColumn.Name = "konyvArDataGridViewTextBoxColumn";
            this.konyvArDataGridViewTextBoxColumn.Width = 125;
            // 
            // kedvezmenyesArDataGridViewTextBoxColumn
            // 
            this.kedvezmenyesArDataGridViewTextBoxColumn.DataPropertyName = "kedvezmenyesAr";
            this.kedvezmenyesArDataGridViewTextBoxColumn.HeaderText = "kedvezmenyesAr";
            this.kedvezmenyesArDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kedvezmenyesArDataGridViewTextBoxColumn.Name = "kedvezmenyesArDataGridViewTextBoxColumn";
            this.kedvezmenyesArDataGridViewTextBoxColumn.Width = 125;
            // 
            // kedvezmenyDataGridViewTextBoxColumn
            // 
            this.kedvezmenyDataGridViewTextBoxColumn.DataPropertyName = "kedvezmeny";
            this.kedvezmenyDataGridViewTextBoxColumn.HeaderText = "kedvezmeny";
            this.kedvezmenyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kedvezmenyDataGridViewTextBoxColumn.Name = "kedvezmenyDataGridViewTextBoxColumn";
            this.kedvezmenyDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendelesInfoBindingSource
            // 
            this.rendelesInfoBindingSource.DataSource = typeof(Szofttech_Beadando.RendelesInfo);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(631, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "1. Lépés új rendelés felvétele:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(145, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "2. Lépés a rendelés összesítése:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.IndianRed;
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(713, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 34);
            this.label8.TabIndex = 27;
            this.label8.Text = "3. Lépés ha szükséges \r\na rendelés törlése:";
            // 
            // RendelesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(941, 499);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "RendelesForm";
            this.Text = "RendelesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesInfo2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvCimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kedvezmenyesArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kedvezmenyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rendelesInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRendelesOsszDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kedvezDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rendelesInfo2BindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}