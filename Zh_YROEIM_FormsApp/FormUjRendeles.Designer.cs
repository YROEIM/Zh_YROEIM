namespace Zh_YROEIM_FormsApp
{
    partial class FormUjRendeles
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
            this.textBox_Konyvek = new System.Windows.Forms.TextBox();
            this.listBox_Konyvek = new System.Windows.Forms.ListBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_FormPlusz = new System.Windows.Forms.GroupBox();
            this.groupBox_FormPlusz.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Konyvek
            // 
            this.textBox_Konyvek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Konyvek.Location = new System.Drawing.Point(27, 17);
            this.textBox_Konyvek.Name = "textBox_Konyvek";
            this.textBox_Konyvek.Size = new System.Drawing.Size(338, 23);
            this.textBox_Konyvek.TabIndex = 0;
            this.textBox_Konyvek.TextChanged += new System.EventHandler(this.textBox_Konyvek_TextChanged);
            // 
            // listBox_Konyvek
            // 
            this.listBox_Konyvek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_Konyvek.FormattingEnabled = true;
            this.listBox_Konyvek.ItemHeight = 15;
            this.listBox_Konyvek.Location = new System.Drawing.Point(27, 62);
            this.listBox_Konyvek.Name = "listBox_Konyvek";
            this.listBox_Konyvek.Size = new System.Drawing.Size(338, 499);
            this.listBox_Konyvek.TabIndex = 1;
            // 
            // button_Ok
            // 
            this.button_Ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Ok.Location = new System.Drawing.Point(27, 572);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(164, 58);
            this.button_Ok.TabIndex = 2;
            this.button_Ok.Text = "Rendelés felvétele";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(197, 572);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(168, 58);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Mégsem";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox_FormPlusz
            // 
            this.groupBox_FormPlusz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_FormPlusz.Controls.Add(this.button_Cancel);
            this.groupBox_FormPlusz.Controls.Add(this.button_Ok);
            this.groupBox_FormPlusz.Controls.Add(this.listBox_Konyvek);
            this.groupBox_FormPlusz.Controls.Add(this.textBox_Konyvek);
            this.groupBox_FormPlusz.Location = new System.Drawing.Point(15, 10);
            this.groupBox_FormPlusz.Name = "groupBox_FormPlusz";
            this.groupBox_FormPlusz.Size = new System.Drawing.Size(396, 639);
            this.groupBox_FormPlusz.TabIndex = 4;
            this.groupBox_FormPlusz.TabStop = false;
            // 
            // FormUjRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 652);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_FormPlusz);
            this.Name = "FormUjRendeles";
            this.Text = "FormUjRendeles";
            this.Load += new System.EventHandler(this.FormUjRendeles_Load);
            this.groupBox_FormPlusz.ResumeLayout(false);
            this.groupBox_FormPlusz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox_Konyvek;
        private ListBox listBox_Konyvek;
        private Button button_Ok;
        private Button button_Cancel;
        private GroupBox groupBox_FormPlusz;
    }
}