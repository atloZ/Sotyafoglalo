using Sotyafoglalo.Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sotyafoglalo.Frontend
{
    public partial class AdatkezeloForm : Form
    {
        private List<Kerdes> kerdesek;
        private List<TippKerdes> tippKerdesek;

        public AdatkezeloForm()
        {
            InitializeComponent();
            loadMinden();
        }

        private void hozzaAddButton_Click(object sender, EventArgs e)
        {
            Boolean uresE =
                String.IsNullOrEmpty(kerdesTextBox.Text) &&
                String.IsNullOrEmpty(helyesValaszTextBox.Text) &&
                String.IsNullOrEmpty(helytelenValasz1TextBox.Text) &&
                String.IsNullOrEmpty(helytelenValasz2TextBox.Text) &&
                String.IsNullOrEmpty(helytelenValasz3TextBox.Text);

            Boolean duplikacioE =
                helyesValaszTextBox.Text != helytelenValasz1TextBox.Text &&
                helyesValaszTextBox.Text != helytelenValasz2TextBox.Text &&
                helyesValaszTextBox.Text != helytelenValasz3TextBox.Text &&
                helytelenValasz2TextBox.Text != helytelenValasz1TextBox.Text &&
                helytelenValasz2TextBox.Text != helytelenValasz3TextBox.Text &&
                helytelenValasz3TextBox.Text != helytelenValasz1TextBox.Text
                    ? false : true;

            if (!uresE)
            {
                try
                {
                    DataBaseHelper.addUjKerdes(
                        kerdesTextBox.Text,
                        helyesValaszTextBox.Text,
                        helytelenValasz1TextBox.Text,
                        helytelenValasz2TextBox.Text,
                        helytelenValasz3TextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("helytelenValasz1Label karakterhasznélat!");
                    hozzaAddButton_Click(sender,e);
                }
                loadMinden();
            }
            else if (uresE)
            {
                MessageBox.Show("Ne hagyj üresen mezőt!");
            }
        }

        private void loadMinden()
        {
            kerdesTextBox.Clear();
            helyesValaszTextBox.Clear();
            helytelenValasz1TextBox.Clear();
            helytelenValasz2TextBox.Clear();
            helytelenValasz3TextBox.Clear();

            kerdeskDataGridView.Rows.Clear();
            tippDataGridView.Rows.Clear();
            
            kerdeskDataGridView.Refresh();
            tippDataGridView.Refresh();

            kerdesek = DataBaseHelper.getKerdesek();
            tippKerdesek = DataBaseHelper.getTippKerdesek();

            for (int i = 0; i < kerdesek.Count; i++)
            {
                kerdeskDataGridView.Rows.Add(
                    kerdesek[i].getKerdes(),
                    kerdesek[i].getJoValasz(),
                    kerdesek[i].getRossz1(),
                    kerdesek[i].getRossz2(),
                    kerdesek[i].getRossz3()
                    );
            }

            for (int i = 0; i < tippKerdesek.Count; i++)
            {
                tippDataGridView.Rows.Add(
                    tippKerdesek[i].getKerdes(),
                    tippKerdesek[i].getValasz()
                    );
            }
        }

        private void TippValaszTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tippHozzadButton_Click(object sender, EventArgs e)
        {
            Boolean uresE =
                String.IsNullOrEmpty(TippKerdesTextBox.Text) &&
                String.IsNullOrEmpty(TippValaszTextBox.Text);

            if (!uresE)
            {
                try
                {
                    DataBaseHelper.addUjTippKerdes(
                        TippKerdesTextBox.Text,
                        Convert.ToInt32(TippValaszTextBox.Text));

                }
                catch (Exception)
                {
                    MessageBox.Show("helytel karakterhasznélat!");
                    tippHozzadButton_Click(sender, e);
                }
                loadMinden();
            }
            else if (uresE)
            {
                MessageBox.Show("Ne hagyj üresen mezőt!");
            }
        }

        private void tippTorlolButton_Click(object sender, EventArgs e)
        {
            int i = tippDataGridView.CurrentCell.RowIndex;
            if (i != 0)
            {
                for (int j = 0; j < tippKerdesek.Count; j++)
                {
                    if (tippKerdesek[j].getKerdes() == tippDataGridView.Rows[i].Cells[0].Value.ToString())
                    {
                        DataBaseHelper.removeTippKerdes(tippDataGridView.Rows[i].Cells[0].Value.ToString());
                    }
                }
                loadMinden();
            }
        }

        private void kerdesTorolButton_Click(object sender, EventArgs e)
        {
            int i = kerdeskDataGridView.CurrentCell.RowIndex;
            if (i != 0)
            {
                for (int j = 0; j < kerdesek.Count; j++)
                {
                    if (kerdesek[j].getKerdes() == kerdeskDataGridView.Rows[i].Cells[0].Value.ToString())
                    {
                        DataBaseHelper.removeKerdes(kerdeskDataGridView.Rows[i].Cells[0].Value.ToString());
                    }
                }
                loadMinden();
            }
        }
    }
}
