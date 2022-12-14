namespace Zh_YROEIM_FormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Nev = new System.Windows.Forms.ListBox();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.dataGridView_Rendelesek = new System.Windows.Forms.DataGridView();
            this.button_Plusz = new System.Windows.Forms.Button();
            this.button_Torles = new System.Windows.Forms.Button();
            this.groupBox_Form1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rendelesek)).BeginInit();
            this.groupBox_Form1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Nev
            // 
            this.listBox_Nev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_Nev.FormattingEnabled = true;
            this.listBox_Nev.ItemHeight = 15;
            this.listBox_Nev.Location = new System.Drawing.Point(16, 54);
            this.listBox_Nev.Name = "listBox_Nev";
            this.listBox_Nev.Size = new System.Drawing.Size(282, 469);
            this.listBox_Nev.TabIndex = 0;
            this.listBox_Nev.SelectedIndexChanged += new System.EventHandler(this.listBox_Nev_SelectedIndexChanged);
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Nev.Location = new System.Drawing.Point(16, 13);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(282, 23);
            this.textBox_Nev.TabIndex = 1;
            this.textBox_Nev.TextChanged += new System.EventHandler(this.textBox_Nev_TextChanged);
            // 
            // dataGridView_Rendelesek
            // 
            this.dataGridView_Rendelesek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_Rendelesek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Rendelesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rendelesek.Location = new System.Drawing.Point(314, 54);
            this.dataGridView_Rendelesek.Name = "dataGridView_Rendelesek";
            this.dataGridView_Rendelesek.RowTemplate.Height = 25;
            this.dataGridView_Rendelesek.Size = new System.Drawing.Size(661, 469);
            this.dataGridView_Rendelesek.TabIndex = 2;
            // 
            // button_Plusz
            // 
            this.button_Plusz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Plusz.Location = new System.Drawing.Point(16, 530);
            this.button_Plusz.Name = "button_Plusz";
            this.button_Plusz.Size = new System.Drawing.Size(120, 75);
            this.button_Plusz.TabIndex = 3;
            this.button_Plusz.Text = "Új rendelés hozzáadása";
            this.button_Plusz.UseVisualStyleBackColor = true;
            this.button_Plusz.Click += new System.EventHandler(this.button_Plusz_Click);
            // 
            // button_Torles
            // 
            this.button_Torles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Torles.Location = new System.Drawing.Point(178, 530);
            this.button_Torles.Name = "button_Torles";
            this.button_Torles.Size = new System.Drawing.Size(120, 75);
            this.button_Torles.TabIndex = 4;
            this.button_Torles.Text = "Rendelés tőrlése";
            this.button_Torles.UseVisualStyleBackColor = true;
            this.button_Torles.Click += new System.EventHandler(this.button_Torles_Click);
            // 
            // groupBox_Form1
            // 
            this.groupBox_Form1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Form1.Controls.Add(this.button_Torles);
            this.groupBox_Form1.Controls.Add(this.button_Plusz);
            this.groupBox_Form1.Controls.Add(this.dataGridView_Rendelesek);
            this.groupBox_Form1.Controls.Add(this.textBox_Nev);
            this.groupBox_Form1.Controls.Add(this.listBox_Nev);
            this.groupBox_Form1.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Form1.Name = "groupBox_Form1";
            this.groupBox_Form1.Size = new System.Drawing.Size(988, 609);
            this.groupBox_Form1.TabIndex = 5;
            this.groupBox_Form1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 624);
            this.Controls.Add(this.groupBox_Form1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rendelesek)).EndInit();
            this.groupBox_Form1.ResumeLayout(false);
            this.groupBox_Form1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox_Nev;
        private TextBox textBox_Nev;
        private DataGridView dataGridView_Rendelesek;
        private Button button_Plusz;
        private Button button_Torles;
        private GroupBox groupBox_Form1;
    }
}