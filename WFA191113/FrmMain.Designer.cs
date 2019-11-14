namespace WFA191113
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.nudJegy = new System.Windows.Forms.NumericUpDown();
            this.cbTz = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTema = new System.Windows.Forms.TextBox();
            this.rtbJegyek = new System.Windows.Forms.RichTextBox();
            this.btnUjJegy = new System.Windows.Forms.Button();
            this.dgvJegyek = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudJegy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJegyek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(80, 23);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(272, 34);
            this.tbNev.TabIndex = 1;
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatum.Location = new System.Drawing.Point(452, 21);
            this.dtpDatum.MaxDate = new System.DateTime(2020, 6, 15, 0, 0, 0, 0);
            this.dtpDatum.MinDate = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(417, 34);
            this.dtpDatum.TabIndex = 2;
            // 
            // nudJegy
            // 
            this.nudJegy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudJegy.Location = new System.Drawing.Point(535, 86);
            this.nudJegy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudJegy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJegy.Name = "nudJegy";
            this.nudJegy.ReadOnly = true;
            this.nudJegy.Size = new System.Drawing.Size(120, 34);
            this.nudJegy.TabIndex = 3;
            this.nudJegy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbTz
            // 
            this.cbTz.AutoSize = true;
            this.cbTz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTz.Location = new System.Drawing.Point(760, 87);
            this.cbTz.Name = "cbTz";
            this.cbTz.Size = new System.Drawing.Size(77, 33);
            this.cbTz.TabIndex = 4;
            this.cbTz.Text = "TZ?";
            this.cbTz.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Téma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(358, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dátum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(459, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jegy:";
            // 
            // tbTema
            // 
            this.tbTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTema.Location = new System.Drawing.Point(100, 85);
            this.tbTema.Name = "tbTema";
            this.tbTema.Size = new System.Drawing.Size(272, 34);
            this.tbTema.TabIndex = 1;
            // 
            // rtbJegyek
            // 
            this.rtbJegyek.Font = new System.Drawing.Font("Consolas", 14F);
            this.rtbJegyek.Location = new System.Drawing.Point(12, 217);
            this.rtbJegyek.Name = "rtbJegyek";
            this.rtbJegyek.Size = new System.Drawing.Size(857, 141);
            this.rtbJegyek.TabIndex = 5;
            this.rtbJegyek.Text = "";
            // 
            // btnUjJegy
            // 
            this.btnUjJegy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjJegy.Location = new System.Drawing.Point(211, 146);
            this.btnUjJegy.Name = "btnUjJegy";
            this.btnUjJegy.Size = new System.Drawing.Size(457, 51);
            this.btnUjJegy.TabIndex = 6;
            this.btnUjJegy.Text = "Új jegy rögzítése!";
            this.btnUjJegy.UseVisualStyleBackColor = true;
            this.btnUjJegy.Click += new System.EventHandler(this.btnUjJegy_Click);
            // 
            // dgvJegyek
            // 
            this.dgvJegyek.AllowUserToAddRows = false;
            this.dgvJegyek.AllowUserToDeleteRows = false;
            this.dgvJegyek.AllowUserToResizeColumns = false;
            this.dgvJegyek.AllowUserToResizeRows = false;
            this.dgvJegyek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJegyek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJegyek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJegyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJegyek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJegyek.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJegyek.Location = new System.Drawing.Point(12, 377);
            this.dgvJegyek.Name = "dgvJegyek";
            this.dgvJegyek.RowHeadersVisible = false;
            this.dgvJegyek.RowHeadersWidth = 51;
            this.dgvJegyek.RowTemplate.Height = 24;
            this.dgvJegyek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJegyek.Size = new System.Drawing.Size(857, 257);
            this.dgvJegyek.TabIndex = 7;
            this.dgvJegyek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJegyek_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dátum";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Téma";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "TZ?";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 30F;
            this.Column6.HeaderText = "Jegy";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 646);
            this.Controls.Add(this.dgvJegyek);
            this.Controls.Add(this.btnUjJegy);
            this.Controls.Add(this.rtbJegyek);
            this.Controls.Add(this.cbTz);
            this.Controls.Add(this.nudJegy);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbTema);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Naplo";
            ((System.ComponentModel.ISupportInitialize)(this.nudJegy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJegyek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.NumericUpDown nudJegy;
        private System.Windows.Forms.CheckBox cbTz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTema;
        private System.Windows.Forms.RichTextBox rtbJegyek;
        private System.Windows.Forms.Button btnUjJegy;
        private System.Windows.Forms.DataGridView dgvJegyek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

