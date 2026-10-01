namespace CafeSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCake_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Cake");
        }

        private void picKetchup_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Ketchup");
        }

        private void picJuice_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Juice");
        }

        private void picBurger_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Burger");
        }

        private void picSandwich_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Sandwich");
        }

        private void picPizza_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Pizza");
        }

        private void picMuffin_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Muffin");
        }

        private void picHotDog_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Hot Dog");
        }

        private void picCookies_Click(object sender, EventArgs e)
        {
            lstBasket.Items.Add("Cookies");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBasket.SelectedIndex != -1)
            {
                string foodName = lstBasket.SelectedItem.ToString();

                lstBasket.Items.RemoveAt(lstBasket.SelectedIndex);

                MessageBox.Show(foodName + " səbətdən silindi");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtBalance.Clear();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (lstBasket.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }

            decimal total = 0;

            for (int i = 0; i < lstBasket.Items.Count; i++)
            {
                string food = lstBasket.Items[i].ToString();

                if (food == "Cake")
                {
                    total += 5;
                }
                else if (food == "Ketchup")
                {
                    total += 2;
                }
                else if (food == "Juice")
                {
                    total += 3;
                }
                else if (food == "Burger")
                {
                    total += 7;
                }
                else if (food == "Sandwich")
                {
                    total += 6;
                }
                else if (food == "Pizza")
                {
                    total += 9;
                }
                else if (food == "Muffin")
                {
                    total += 4;
                }
                else if (food == "Hot Dog")
                {
                    total += 5;
                }
                else if (food == "Cookies")
                {
                    total += 3.5m;
                }
            }

            txtTotal.Text = total + " ₼";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Əvvəlcə yekun hesabı hesablayın!");
                return;
            }


            decimal total = decimal.Parse(txtTotal.Text.Replace(" ₼", ""));

            decimal amount;

            if (decimal.TryParse(txtAmount.Text, out amount))
            {
                if (amount < total)
                {
                    MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                    txtBalance.Clear();
                }
                else
                {
                    decimal balance = amount - total;

                    txtBalance.Text = balance + " ₼";
                }
            }
            else
            {
                MessageBox.Show("Məbləği düzgün daxil edin!");
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xanalar sıfırlansınmı?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstBasket.Items.Clear();
                txtAmount.Clear();
                txtBalance.Clear();
                txtTotal.Clear();
            }
        }

        private void lstBasket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
