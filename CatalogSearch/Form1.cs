using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Linq.Dynamic;

namespace CatalogSearch
{
    public partial class Form1 : Form
    {

        List<Asset> assets = new List<Asset>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            assets.Add(new Book("S&F001", "The Sound & the Fury", "Available", "0394309944", 326, "William Faulkner", "Harrison Smith"));
            assets.Add(new AudioBook("S&F002", "The Sound & the Fury", "Checked Out", 537, "William Faulkner", "Grover Gardner"));
            assets.Add(new Software("MSVS001", "Microsoft Visual Studio 2012", "Remote Location", 64, "Windows XP"));
            assets.Add(new DVD("S&S001", "Sense & Sensibility", "Available", 136, "Ang Lee"));
            assets.Add(new DVD("DH001", "Die Hard", "Checked Out", 132, "John McTiernan"));
            assets.Add(new BluRay("DH002", "Die Hard", "Remote Location", 132, "John McTiernan"));

            string[] searchBy1 = { "Name", "Type", "Identifier" };
            string[] searchBy2 = { "Name", "Type", "Identifier" };
            string[] searchBy3 = { "Name", "Type", "Identifier" };

            cmbSearch.DataSource = searchBy1;
            cmbSearch2.DataSource = searchBy2;
            cmbSearch3.DataSource = searchBy3;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<string> resultList = new List<string>();
            string whereClause = "";

            try
            {

                if (txtSearch1.Text == "" && txtSearch2.Text == "" && txtSearch3.Text == "")
                    whereClause = "Name = Name";

                if (txtSearch1.Text != "")
                    whereClause = whereClause + cmbSearch.SelectedItem.ToString() + ".ToUpper().Contains(@0)";

                if (txtSearch2.Text != "")
                {

                    if (rdoAnd1.Checked)
                        whereClause = whereClause + " And " + cmbSearch2.SelectedItem.ToString() + ".ToUpper().Contains(@1)";
                    else if (rdoOr1.Checked)
                        whereClause = whereClause + " Or " + cmbSearch2.SelectedItem.ToString() + ".ToUpper().Contains(@1)";

                }

                if (txtSearch3.Text != "")
                {

                    if (rdoAnd2.Checked)
                        whereClause = whereClause + " And " + cmbSearch3.SelectedItem.ToString() + ".ToUpper().Contains(@2)";
                    else if (rdoOr2.Checked)
                        whereClause = whereClause + " Or " + cmbSearch3.SelectedItem.ToString() + ".ToUpper().Contains(@2)";

                }


                //whereClause = cmbSearch.SelectedItem.ToString() + ".ToUpper().Contains(@0) Or Name.ToUpper().Contains(@1)";



                /*var results = from asset in assets
                              where(asset.Name == "Die Hard")
                              select asset;*/

                var results = assets.AsQueryable().Where(whereClause, txtSearch1.Text.ToUpper(), txtSearch2.Text.ToUpper(), txtSearch3.Text.ToUpper());

                foreach (var result in results)
                {

                    resultList.Add(result.Identifier);

                }

                lstResults.DataSource = resultList;

                if (resultList.Count == 0)
                    MessageBox.Show("Your search did not return any results.", "Catalog Search", MessageBoxButtons.OK);

            }

            catch (ParseException)
            {

                MessageBox.Show("Search criteria must be entered from top to bottom.", "Input Error", MessageBoxButtons.OK);

            }

        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

            string resultDetail = "";

            if (lstResults.DataSource != null)
            {

                foreach (Asset asset in assets)
                {

                    if (asset.Identifier == lstResults.SelectedItem.ToString())
                        resultDetail = asset.DescribeAsset();

                }

                txtResults.Text = resultDetail;

            }

        }

        private void pnlResultsBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtSearch1.Text = "";
            txtSearch2.Text = "";
            txtSearch3.Text = "";

            lstResults.DataSource = null;
            txtResults.Text = "";

        }

        private void pnlResults_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
