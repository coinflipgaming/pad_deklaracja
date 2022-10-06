namespace pad_deklaracja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.in_pesel = new System.Windows.Forms.MaskedTextBox();
            this.in_data_ur = new System.Windows.Forms.MaskedTextBox();
            this.in_miejsce_ur = new System.Windows.Forms.TextBox();
            this.in_imie = new System.Windows.Forms.TextBox();
            this.in_nazwisko = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.in_kod_pocztowy = new System.Windows.Forms.MaskedTextBox();
            this.in_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.in_poczta_miasto = new System.Windows.Forms.TextBox();
            this.in_numer_tel = new System.Windows.Forms.TextBox();
            this.in_adres = new System.Windows.Forms.TextBox();
            this.in_miasto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.terminy = new System.Windows.Forms.ComboBox();
            this.in_kwalifikacja1 = new System.Windows.Forms.RadioButton();
            this.in_kwalifikacja2 = new System.Windows.Forms.RadioButton();
            this.lista_kwalifikacji_zawodowych = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.in_radiobutton2 = new System.Windows.Forms.RadioButton();
            this.in_radiobutton1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.in_czypraktyczne = new System.Windows.Forms.CheckBox();
            this.in_czypisemne = new System.Windows.Forms.CheckBox();
            this.accept = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.opis_kwalifikacji = new System.Windows.Forms.Label();
            this.declaration = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(162, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEKLARACJA PRZYSTĄPIENA DO EGZAMINU";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.in_pesel);
            this.groupBox1.Controls.Add(this.in_data_ur);
            this.groupBox1.Controls.Add(this.in_miejsce_ur);
            this.groupBox1.Controls.Add(this.in_imie);
            this.groupBox1.Controls.Add(this.in_nazwisko);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(17, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane osobowe ucznia";
            // 
            // in_pesel
            // 
            this.in_pesel.Location = new System.Drawing.Point(187, 110);
            this.in_pesel.Mask = "000000000";
            this.in_pesel.Name = "in_pesel";
            this.in_pesel.Size = new System.Drawing.Size(74, 20);
            this.in_pesel.TabIndex = 10;
            this.in_pesel.ValidatingType = typeof(int);
            // 
            // in_data_ur
            // 
            this.in_data_ur.Location = new System.Drawing.Point(187, 81);
            this.in_data_ur.Mask = "00/00/0000";
            this.in_data_ur.Name = "in_data_ur";
            this.in_data_ur.Size = new System.Drawing.Size(74, 20);
            this.in_data_ur.TabIndex = 9;
            this.in_data_ur.ValidatingType = typeof(System.DateTime);
            // 
            // in_miejsce_ur
            // 
            this.in_miejsce_ur.Location = new System.Drawing.Point(297, 81);
            this.in_miejsce_ur.Name = "in_miejsce_ur";
            this.in_miejsce_ur.Size = new System.Drawing.Size(266, 20);
            this.in_miejsce_ur.TabIndex = 8;
            // 
            // in_imie
            // 
            this.in_imie.Location = new System.Drawing.Point(186, 51);
            this.in_imie.Name = "in_imie";
            this.in_imie.Size = new System.Drawing.Size(377, 20);
            this.in_imie.TabIndex = 5;
            // 
            // in_nazwisko
            // 
            this.in_nazwisko.Location = new System.Drawing.Point(186, 21);
            this.in_nazwisko.Name = "in_nazwisko";
            this.in_nazwisko.Size = new System.Drawing.Size(377, 20);
            this.in_nazwisko.TabIndex = 4;
            this.in_nazwisko.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(31, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data i miejsce urodzenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numer PESEL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Imię (imiona):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.in_kod_pocztowy);
            this.groupBox2.Controls.Add(this.in_email);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.in_poczta_miasto);
            this.groupBox2.Controls.Add(this.in_numer_tel);
            this.groupBox2.Controls.Add(this.in_adres);
            this.groupBox2.Controls.Add(this.in_miasto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(17, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 150);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane osobowe ucznia";
            // 
            // in_kod_pocztowy
            // 
            this.in_kod_pocztowy.Location = new System.Drawing.Point(186, 81);
            this.in_kod_pocztowy.Mask = "00-000";
            this.in_kod_pocztowy.Name = "in_kod_pocztowy";
            this.in_kod_pocztowy.Size = new System.Drawing.Size(55, 20);
            this.in_kod_pocztowy.TabIndex = 11;
            this.in_kod_pocztowy.ValidatingType = typeof(int);
            // 
            // in_email
            // 
            this.in_email.Location = new System.Drawing.Point(371, 110);
            this.in_email.Name = "in_email";
            this.in_email.Size = new System.Drawing.Size(192, 20);
            this.in_email.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(322, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "mail:";
            // 
            // in_poczta_miasto
            // 
            this.in_poczta_miasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.in_poczta_miasto.Location = new System.Drawing.Point(268, 81);
            this.in_poczta_miasto.Name = "in_poczta_miasto";
            this.in_poczta_miasto.Size = new System.Drawing.Size(294, 20);
            this.in_poczta_miasto.TabIndex = 8;
            // 
            // in_numer_tel
            // 
            this.in_numer_tel.AllowDrop = true;
            this.in_numer_tel.Location = new System.Drawing.Point(186, 110);
            this.in_numer_tel.MaxLength = 11;
            this.in_numer_tel.Name = "in_numer_tel";
            this.in_numer_tel.Size = new System.Drawing.Size(130, 20);
            this.in_numer_tel.TabIndex = 7;
            // 
            // in_adres
            // 
            this.in_adres.Location = new System.Drawing.Point(186, 51);
            this.in_adres.Name = "in_adres";
            this.in_adres.Size = new System.Drawing.Size(377, 20);
            this.in_adres.TabIndex = 5;
            // 
            // in_miasto
            // 
            this.in_miasto.Location = new System.Drawing.Point(186, 21);
            this.in_miasto.Name = "in_miasto";
            this.in_miasto.Size = new System.Drawing.Size(377, 20);
            this.in_miasto.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(30, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "kod pocztowy i poczta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(30, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "nr telefonu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(30, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ulica i numer domu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(30, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "miejscowość:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(85, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(457, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(85, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "przeprowadzanego w terminie";
            // 
            // terminy
            // 
            this.terminy.FormattingEnabled = true;
            this.terminy.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.terminy.Location = new System.Drawing.Point(328, 427);
            this.terminy.Name = "terminy";
            this.terminy.Size = new System.Drawing.Size(121, 21);
            this.terminy.TabIndex = 12;
            this.terminy.Text = "styczeń";
            // 
            // in_kwalifikacja1
            // 
            this.in_kwalifikacja1.AutoSize = true;
            this.in_kwalifikacja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.in_kwalifikacja1.Location = new System.Drawing.Point(129, 473);
            this.in_kwalifikacja1.Name = "in_kwalifikacja1";
            this.in_kwalifikacja1.Size = new System.Drawing.Size(129, 17);
            this.in_kwalifikacja1.TabIndex = 13;
            this.in_kwalifikacja1.TabStop = true;
            this.in_kwalifikacja1.Text = "technik informatyk";
            this.in_kwalifikacja1.UseVisualStyleBackColor = true;
            this.in_kwalifikacja1.CheckedChanged += new System.EventHandler(this.in_kwalifikacja1_CheckedChanged);
            // 
            // in_kwalifikacja2
            // 
            this.in_kwalifikacja2.AutoSize = true;
            this.in_kwalifikacja2.BackColor = System.Drawing.Color.Transparent;
            this.in_kwalifikacja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.in_kwalifikacja2.Location = new System.Drawing.Point(327, 473);
            this.in_kwalifikacja2.Name = "in_kwalifikacja2";
            this.in_kwalifikacja2.Size = new System.Drawing.Size(136, 17);
            this.in_kwalifikacja2.TabIndex = 14;
            this.in_kwalifikacja2.TabStop = true;
            this.in_kwalifikacja2.Text = "technik programista";
            this.in_kwalifikacja2.UseVisualStyleBackColor = false;
            this.in_kwalifikacja2.CheckedChanged += new System.EventHandler(this.in_kwalifikacja2_CheckedChanged);
            // 
            // lista_kwalifikacji_zawodowych
            // 
            this.lista_kwalifikacji_zawodowych.FormattingEnabled = true;
            this.lista_kwalifikacji_zawodowych.Location = new System.Drawing.Point(32, 513);
            this.lista_kwalifikacji_zawodowych.Name = "lista_kwalifikacji_zawodowych";
            this.lista_kwalifikacji_zawodowych.Size = new System.Drawing.Size(121, 21);
            this.lista_kwalifikacji_zawodowych.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.in_radiobutton2);
            this.panel2.Controls.Add(this.in_radiobutton1);
            this.panel2.Location = new System.Drawing.Point(32, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 41);
            this.panel2.TabIndex = 19;
            // 
            // in_radiobutton2
            // 
            this.in_radiobutton2.AutoSize = true;
            this.in_radiobutton2.Location = new System.Drawing.Point(127, 12);
            this.in_radiobutton2.Name = "in_radiobutton2";
            this.in_radiobutton2.Size = new System.Drawing.Size(90, 17);
            this.in_radiobutton2.TabIndex = 1;
            this.in_radiobutton2.TabStop = true;
            this.in_radiobutton2.Text = "po raz kolejny";
            this.in_radiobutton2.UseVisualStyleBackColor = true;
            this.in_radiobutton2.CheckedChanged += new System.EventHandler(this.in_radiobutton1_CheckedChanged);
            // 
            // in_radiobutton1
            // 
            this.in_radiobutton1.AutoSize = true;
            this.in_radiobutton1.Location = new System.Drawing.Point(10, 12);
            this.in_radiobutton1.Name = "in_radiobutton1";
            this.in_radiobutton1.Size = new System.Drawing.Size(97, 17);
            this.in_radiobutton1.TabIndex = 0;
            this.in_radiobutton1.TabStop = true;
            this.in_radiobutton1.Text = "po raz pierwszy";
            this.in_radiobutton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.in_czypraktyczne);
            this.panel3.Controls.Add(this.in_czypisemne);
            this.panel3.Location = new System.Drawing.Point(327, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 41);
            this.panel3.TabIndex = 20;
            // 
            // in_czypraktyczne
            // 
            this.in_czypraktyczne.AutoSize = true;
            this.in_czypraktyczne.Location = new System.Drawing.Point(145, 13);
            this.in_czypraktyczne.Name = "in_czypraktyczne";
            this.in_czypraktyczne.Size = new System.Drawing.Size(80, 17);
            this.in_czypraktyczne.TabIndex = 1;
            this.in_czypraktyczne.Text = "praktycznej";
            this.in_czypraktyczne.UseVisualStyleBackColor = true;
            this.in_czypraktyczne.CheckedChanged += new System.EventHandler(this.in_czypraktyczne_CheckedChanged);
            // 
            // in_czypisemne
            // 
            this.in_czypisemne.AutoSize = true;
            this.in_czypisemne.Location = new System.Drawing.Point(13, 12);
            this.in_czypisemne.Name = "in_czypisemne";
            this.in_czypisemne.Size = new System.Drawing.Size(67, 17);
            this.in_czypisemne.TabIndex = 0;
            this.in_czypisemne.Text = "pisemnej";
            this.in_czypisemne.UseVisualStyleBackColor = true;
            this.in_czypisemne.CheckedChanged += new System.EventHandler(this.in_czypisemne_CheckedChanged);
            // 
            // accept
            // 
            this.accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accept.Location = new System.Drawing.Point(366, 597);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(220, 23);
            this.accept.TabIndex = 21;
            this.accept.Text = "Zatwierdź";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.Location = new System.Drawing.Point(592, 597);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(220, 23);
            this.clear.TabIndex = 22;
            this.clear.Text = "Wyczyść";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save.Location = new System.Drawing.Point(822, 597);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(220, 23);
            this.save.TabIndex = 23;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            // 
            // opis_kwalifikacji
            // 
            this.opis_kwalifikacji.AutoSize = true;
            this.opis_kwalifikacji.BackColor = System.Drawing.Color.Transparent;
            this.opis_kwalifikacji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opis_kwalifikacji.Location = new System.Drawing.Point(159, 516);
            this.opis_kwalifikacji.Name = "opis_kwalifikacji";
            this.opis_kwalifikacji.Size = new System.Drawing.Size(307, 13);
            this.opis_kwalifikacji.TabIndex = 24;
            this.opis_kwalifikacji.Text = "Projektowanie, programowanie i testowanie aplikacji.";
            // 
            // declaration
            // 
            this.declaration.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.declaration.Location = new System.Drawing.Point(592, 49);
            this.declaration.Name = "declaration";
            this.declaration.Size = new System.Drawing.Size(450, 542);
            this.declaration.TabIndex = 25;
            this.declaration.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1054, 631);
            this.Controls.Add(this.declaration);
            this.Controls.Add(this.opis_kwalifikacji);
            this.Controls.Add(this.in_kwalifikacja2);
            this.Controls.Add(this.in_kwalifikacja1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lista_kwalifikacji_zawodowych);
            this.Controls.Add(this.terminy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Deklaracja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox in_pesel;
        private System.Windows.Forms.MaskedTextBox in_data_ur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox in_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox in_numer_tel;
        private System.Windows.Forms.TextBox in_adres;
        private System.Windows.Forms.TextBox in_miasto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox terminy;
        private System.Windows.Forms.RadioButton in_kwalifikacja1;
        private System.Windows.Forms.RadioButton in_kwalifikacja2;
        private System.Windows.Forms.TextBox in_miejsce_ur;
        private System.Windows.Forms.TextBox in_imie;
        private System.Windows.Forms.TextBox in_nazwisko;
        private System.Windows.Forms.MaskedTextBox in_kod_pocztowy;
        private System.Windows.Forms.TextBox in_poczta_miasto;
        private System.Windows.Forms.ComboBox lista_kwalifikacji_zawodowych;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton in_radiobutton2;
        private System.Windows.Forms.RadioButton in_radiobutton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox in_czypraktyczne;
        private System.Windows.Forms.CheckBox in_czypisemne;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label opis_kwalifikacji;
        private System.Windows.Forms.RichTextBox declaration;
    }
}