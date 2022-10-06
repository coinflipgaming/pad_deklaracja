using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace pad_deklaracja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lista_kwalifikacji_zawodowych.DataSource = lista_kwalifikacji;
        }
        String kwalifikacja = "", radiobutton = "", pisemnepraktyczne = "", symbolzawodu = "";
        public String[] lista_kwalifikacji = {"INF.02","INF.03","INF.04"};
        private void accept_Click(object sender, EventArgs e)
        {
                declaration.ResetText();
                declaration.Text =
                    "Deklaruję przystąpienie do egzaminu potwierdzającego kwalfikacje w zawodzie " + kwalifikacja +
                    " w terminie " + terminy.SelectedItem.ToString() + "\n" +
                    "\n" +
                    "Dane osobowe ucznia\n" +
                    " Nazwisko: " + in_nazwisko.Text + "\n" +
                    " Imię(imiona): " + in_imiona.Text + "\n" +
                    " Data i miejsce urodzenia: " + in_data_ur.Text + ", " + in_miejsce_ur.Text + "\n" +
                    " numer PESEL: " + in_pesel.Text + "\n" +
                    "\n" +
                    "Adres korespondencyjny\n" +
                    " Miejscowość: " + in_miasto.Text + "\n" +
                    " ulica i nr domu: " + in_adres.Text + "\n" +
                    " kod pocztowy i poczta: " + in_kod_pocztowy.Text + ", " + in_poczta_miasto.Text + "\n" +
                    " nr telefonu: " + in_numer_tel.Text + "\n" +
                    " email: " + in_numer_tel.Text + "\n\n\n" +
                    "Deklaruję przystąpienie do egzaminu " + radiobutton + " do części " + pisemnepraktyczne + "\n\n" +
                    "Oznaczenie kwalifikacji zgodne z podstawą programową" + lista_kwalifikacji_zawodowych.SelectedItem.ToString() + ".\n" +
                    "Nazwa kwalifikacji: " + opis_kwalifikacji.Text + ".\n\n" +
                    "Symbol cyfrowy zawodu: " + symbolzawodu + "\n" +
                    "Nazwa zawodu: " + kwalifikacja + "";
        }

        private void in_kwalifikacja1_CheckedChanged(object sender, EventArgs e)
        {
            kwalifikacja = in_kwalifikacja1.Text;
        }

        private void in_kwalifikacja2_CheckedChanged(object sender, EventArgs e)
        {
            kwalifikacja = in_kwalifikacja2.Text;
        }
        private void in_radiobutton1_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = in_radiobutton1.Text;
            in_radiobutton2.Checked=false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            declaration.Clear();
        }

        private void in_radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = in_radiobutton2.Text;
            in_radiobutton1.Checked = false;
        }
        private void in_czypraktyczne_CheckedChanged(object sender, EventArgs e)
        {
            pisemnepraktyczne = in_czypraktyczne.Text;
            in_czypisemne.Checked = false;
        }
        private void in_czypisemne_CheckedChanged(object sender, EventArgs e)
        {
            pisemnepraktyczne = in_czypisemne.Text;
            in_czypraktyczne.Checked = false;
        }
    }
}
