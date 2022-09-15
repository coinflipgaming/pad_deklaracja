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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.in_pesel = new System.Windows.Forms.MaskedTextBox();
            this.in_date_of_birth = new System.Windows.Forms.MaskedTextBox();
            this.in_place_of_birth = new System.Windows.Forms.TextBox();
            this.in_names = new System.Windows.Forms.TextBox();
            this.in_surname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.in_mail_code = new System.Windows.Forms.MaskedTextBox();
            this.in_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.in_mail = new System.Windows.Forms.TextBox();
            this.in_phone_number = new System.Windows.Forms.TextBox();
            this.in_adress = new System.Windows.Forms.TextBox();
            this.in_city = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.terms = new System.Windows.Forms.ComboBox();
            this.in_specification1 = new System.Windows.Forms.RadioButton();
            this.in_specification2 = new System.Windows.Forms.RadioButton();
            this.tests_list = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.in_radiobutton2 = new System.Windows.Forms.RadioButton();
            this.in_radiobutton1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.accept = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.in_pesel);
            this.groupBox1.Controls.Add(this.in_date_of_birth);
            this.groupBox1.Controls.Add(this.in_place_of_birth);
            this.groupBox1.Controls.Add(this.in_names);
            this.groupBox1.Controls.Add(this.in_surname);
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
            // in_date_of_birth
            // 
            this.in_date_of_birth.Location = new System.Drawing.Point(187, 81);
            this.in_date_of_birth.Mask = "00/00/0000";
            this.in_date_of_birth.Name = "in_date_of_birth";
            this.in_date_of_birth.Size = new System.Drawing.Size(74, 20);
            this.in_date_of_birth.TabIndex = 9;
            this.in_date_of_birth.ValidatingType = typeof(System.DateTime);
            // 
            // in_place_of_birth
            // 
            this.in_place_of_birth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.in_place_of_birth.Location = new System.Drawing.Point(297, 81);
            this.in_place_of_birth.Name = "in_place_of_birth";
            this.in_place_of_birth.Size = new System.Drawing.Size(266, 20);
            this.in_place_of_birth.TabIndex = 8;
            // 
            // in_names
            // 
            this.in_names.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.in_names.Location = new System.Drawing.Point(186, 51);
            this.in_names.Name = "in_names";
            this.in_names.Size = new System.Drawing.Size(377, 20);
            this.in_names.TabIndex = 5;
            // 
            // in_surname
            // 
            this.in_surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.in_surname.Location = new System.Drawing.Point(186, 21);
            this.in_surname.Name = "in_surname";
            this.in_surname.Size = new System.Drawing.Size(377, 20);
            this.in_surname.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 579);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.in_mail_code);
            this.groupBox2.Controls.Add(this.in_email);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.in_mail);
            this.groupBox2.Controls.Add(this.in_phone_number);
            this.groupBox2.Controls.Add(this.in_adress);
            this.groupBox2.Controls.Add(this.in_city);
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
            // in_mail_code
            // 
            this.in_mail_code.Location = new System.Drawing.Point(186, 81);
            this.in_mail_code.Mask = "00-000";
            this.in_mail_code.Name = "in_mail_code";
            this.in_mail_code.Size = new System.Drawing.Size(55, 20);
            this.in_mail_code.TabIndex = 11;
            this.in_mail_code.ValidatingType = typeof(int);
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
            // in_mail
            // 
            this.in_mail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.in_mail.Location = new System.Drawing.Point(268, 81);
            this.in_mail.Name = "in_mail";
            this.in_mail.Size = new System.Drawing.Size(294, 20);
            this.in_mail.TabIndex = 8;
            // 
            // in_phone_number
            // 
            this.in_phone_number.AllowDrop = true;
            this.in_phone_number.Location = new System.Drawing.Point(186, 110);
            this.in_phone_number.MaxLength = 11;
            this.in_phone_number.Name = "in_phone_number";
            this.in_phone_number.Size = new System.Drawing.Size(130, 20);
            this.in_phone_number.TabIndex = 7;
            // 
            // in_adress
            // 
            this.in_adress.Location = new System.Drawing.Point(186, 51);
            this.in_adress.Name = "in_adress";
            this.in_adress.Size = new System.Drawing.Size(377, 20);
            this.in_adress.TabIndex = 5;
            // 
            // in_city
            // 
            this.in_city.Location = new System.Drawing.Point(186, 21);
            this.in_city.Name = "in_city";
            this.in_city.Size = new System.Drawing.Size(377, 20);
            this.in_city.TabIndex = 4;
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
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "nr telefonu z kierunkowym:";
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
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(85, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "przeprowadzanego w terminie";
            // 
            // terms
            // 
            this.terms.FormattingEnabled = true;
            this.terms.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.terms.Location = new System.Drawing.Point(328, 427);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(121, 21);
            this.terms.TabIndex = 12;
            this.terms.Text = "styczeń";
            // 
            // in_specification1
            // 
            this.in_specification1.AutoSize = true;
            this.in_specification1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.in_specification1.Location = new System.Drawing.Point(129, 473);
            this.in_specification1.Name = "in_specification1";
            this.in_specification1.Size = new System.Drawing.Size(129, 17);
            this.in_specification1.TabIndex = 13;
            this.in_specification1.TabStop = true;
            this.in_specification1.Text = "technik informatyk";
            this.in_specification1.UseVisualStyleBackColor = true;
            // 
            // in_specification2
            // 
            this.in_specification2.AutoSize = true;
            this.in_specification2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.in_specification2.Location = new System.Drawing.Point(327, 473);
            this.in_specification2.Name = "in_specification2";
            this.in_specification2.Size = new System.Drawing.Size(136, 17);
            this.in_specification2.TabIndex = 14;
            this.in_specification2.TabStop = true;
            this.in_specification2.Text = "technik programista";
            this.in_specification2.UseVisualStyleBackColor = true;
            // 
            // tests_list
            // 
            this.tests_list.FormattingEnabled = true;
            this.tests_list.Items.AddRange(new object[] {
            "",
            "INF.02",
            "INF.03",
            "INF.04"});
            this.tests_list.Location = new System.Drawing.Point(32, 513);
            this.tests_list.Name = "tests_list";
            this.tests_list.Size = new System.Drawing.Size(121, 21);
            this.tests_list.TabIndex = 16;
            // 
            // panel2
            // 
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
            this.in_radiobutton2.Size = new System.Drawing.Size(138, 17);
            this.in_radiobutton2.TabIndex = 1;
            this.in_radiobutton2.TabStop = true;
            this.in_radiobutton2.Text = "po raz kolejny do części";
            this.in_radiobutton2.UseVisualStyleBackColor = true;
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
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(327, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 41);
            this.panel3.TabIndex = 20;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(145, 13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "praktycznej";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "pisemnej";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(159, 516);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(307, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Projektowanie, programowanie i testowanie aplikacji.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 631);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.in_specification2);
            this.Controls.Add(this.in_specification1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tests_list);
            this.Controls.Add(this.terms);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox in_pesel;
        private System.Windows.Forms.MaskedTextBox in_date_of_birth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox in_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox in_phone_number;
        private System.Windows.Forms.TextBox in_adress;
        private System.Windows.Forms.TextBox in_city;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox terms;
        private System.Windows.Forms.RadioButton in_specification1;
        private System.Windows.Forms.RadioButton in_specification2;
        private System.Windows.Forms.TextBox in_place_of_birth;
        private System.Windows.Forms.TextBox in_names;
        private System.Windows.Forms.TextBox in_surname;
        private System.Windows.Forms.MaskedTextBox in_mail_code;
        private System.Windows.Forms.TextBox in_mail;
        private System.Windows.Forms.ComboBox tests_list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton in_radiobutton2;
        private System.Windows.Forms.RadioButton in_radiobutton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label13;
    }
}