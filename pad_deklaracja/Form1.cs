using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pad_deklaracja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String kwalifikacja="", radiobutton="", pisemnepraktyczne="";
        private void accept_Click(object sender, EventArgs e)
        {
            declaration.ResetText();
            declaration.Text =
                "Deklaruję przystąpienie do egzaminu potwierdzającego kwalfikacje w zawodzie " + kwalifikacja +"\n"+
                " w terminie " + terminy.SelectedItem.ToString() + "\n" +
                "\n" +
                "Dane osobowe ucznia\n" +
                " Nazwisko: " + in_nazwisko.Text + "\n" +
                " Imię(imiona): " + in_imiona.Text + "\n" +
                " Data i miejsce urodzenia: "+in_data_ur.ToString()+", "+in_miejsce_ur.Text + "\n" +
                " numer PESEL: "+in_pesel.Text + "\n" +
                "\n"+
                "Adres korespondencyjny\n"+
                " Miejscowość: "+in_miasto.Text + "\n" +
                " ulica i nr domu: "+in_adres.Text + "\n" +
                " kod pocztowy i poczta: "+in_kod_pocztowy.Text+", "+in_poczta_miasto.Text + "\n" +
                " nr telefonu: " + in_numer_tel.Text + "\n" +
                " email: " + in_numer_tel.Text + "\n\n\n" +
                "Deklaruję przystąpienie do egzaminu " + radiobutton + " do części " + pisemnepraktyczne + "\n\n" +
                "Oznaczenie kwalifikacji zgodne z podstawą programową"
                

                ;
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
        }
        private void in_radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = in_radiobutton2.Text;
        }
        private void in_czypraktyczne_CheckedChanged(object sender, EventArgs e)
        {
            pisemnepraktyczne = in_czypraktyczne.Text;
        }
        private void in_czypisemne_CheckedChanged(object sender, EventArgs e)
        {
            pisemnepraktyczne = in_czypisemne.Text;
        }
    }
}
