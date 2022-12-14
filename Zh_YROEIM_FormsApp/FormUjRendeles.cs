using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zh_YROEIM_FormsApp
{
    public partial class FormUjRendeles : Form
    {
        Models.ContextTextbook context = new Models.ContextTextbook();

        public FormUjRendeles()
        {
            InitializeComponent();
        }

        private void FormUjRendeles_Load(object sender, EventArgs e)
        {
            KonyvSzures();
        }

        private void KonyvSzures()
        {
            var konyvek = from x in context.Textbooks
                          where x.Title.Contains(textBox_Konyvek.Text)
                          select x;
            listBox_Konyvek.DataSource = konyvek.ToList();
            listBox_Konyvek.DisplayMember = "Title";
        }

        private void textBox_Konyvek_TextChanged(object sender, EventArgs e)
        {
            KonyvSzures();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Form1.ujtextbook = (Models.Textbook)listBox_Konyvek.SelectedItem;

            this.DialogResult = DialogResult.OK;
        }
    }
}
