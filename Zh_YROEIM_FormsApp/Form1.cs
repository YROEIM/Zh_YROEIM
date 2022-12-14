namespace Zh_YROEIM_FormsApp
{
    public partial class Form1 : Form
    {
        Models.ContextTextbook context = new Models.ContextTextbook();

        public static Models.Textbook ujtextbook;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NevSzures();

            RendelesekSzurese();
        }

        private void RendelesekSzurese()
        {
            var selectedstudent = (Models.Student)listBox_Nev.SelectedItem;

            var rendelesek = from x in context.Orders
                             where x.StudentFkNavigation.Name == selectedstudent.Name
                             select new //orderdetail
                             {
                                 OrderSk = x.OrderSk,
                                 Title = x.TextbookFkNavigation.Title,
                                 Price = x.TextbookFkNavigation.Price,
                                 NotAvailable = x.TextbookFkNavigation.NotAvailable
                             };

            dataGridView_Rendelesek.DataSource = rendelesek.ToList();
        }

        private void NevSzures()
        {
            var nevek = from x in context.Students
                        where x.Name.Contains(textBox_Nev.Text)
                        select x;
            listBox_Nev.DataSource = nevek.ToList();
            listBox_Nev.DisplayMember = "Name";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tényleg beakkarja zárni?","Bezárás",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox_Nev_TextChanged(object sender, EventArgs e)
        {
            NevSzures();
        }

        private void listBox_Nev_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelesekSzurese();
        }

        private void button_Plusz_Click(object sender, EventArgs e)
        {
            FormUjRendeles formUjRendeles = new FormUjRendeles();

            if (formUjRendeles.ShowDialog()==DialogResult.OK)
            {
                var selectedstudent = (Models.Student)listBox_Nev.SelectedItem;

                Models.Order ujrendeles = new Models.Order();

                ujrendeles.TextbookFk = ujtextbook.TextbookId;
                ujrendeles.StudentFk = selectedstudent.StudentId;

                try
                {
                    context.Orders.Local.Add(ujrendeles);
                    context.SaveChanges();
                    RendelesekSzurese();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Torles_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView_Rendelesek.CurrentCell.RowIndex;
            int torlendoid = int.Parse(dataGridView_Rendelesek.Rows[rowindex].Cells[0].Value.ToString());

            var torlendo = from x in context.Orders
                           where x.OrderSk == torlendoid
                           select x;

            if (MessageBox.Show("Bitos, hogy tõrõlni szeretné?","Tõrlés",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    context.Orders.Remove(torlendo.FirstOrDefault());
                    context.SaveChanges();
                    RendelesekSzurese();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        class orderdetail
        {
            public int OrderSk { get; set; }
            public string? Title { get; set; }
            public double? Price { get; set; }
            public bool NotAvailable { get; set; }
        }
    }
}