namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelOnTop = new Label();
            labelEmail = new Label();
            labelPass1 = new Label();
            labelPass2 = new Label();
            textBoxMail = new TextBox();
            textBoxPass1 = new TextBox();
            textBoxPass2 = new TextBox();
            buttonOnly = new Button();
            labelShowInfo = new Label();
            SuspendLayout();
            // 
            // labelOnTop
            // 
            labelOnTop.AutoSize = true;
            labelOnTop.BackColor = Color.Teal;
            labelOnTop.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelOnTop.Location = new Point(-1, 0);
            labelOnTop.Name = "labelOnTop";
            labelOnTop.Padding = new Padding(100, 0, 100, 0);
            labelOnTop.Size = new Size(394, 37);
            labelOnTop.TabIndex = 0;
            labelOnTop.Text = "Rejestruj konto";
            labelOnTop.Click += label1_Click_1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(12, 52);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(119, 25);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "podaj e-mail";
            labelEmail.Click += labelEmail_Click;
            // 
            // labelPass1
            // 
            labelPass1.AutoSize = true;
            labelPass1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPass1.Location = new Point(11, 123);
            labelPass1.Name = "labelPass1";
            labelPass1.Size = new Size(109, 25);
            labelPass1.TabIndex = 2;
            labelPass1.Text = "Podaj haslo";
            // 
            // labelPass2
            // 
            labelPass2.AutoSize = true;
            labelPass2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPass2.Location = new Point(13, 213);
            labelPass2.Name = "labelPass2";
            labelPass2.Size = new Size(130, 25);
            labelPass2.TabIndex = 3;
            labelPass2.Text = "Powturz haslo";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(15, 88);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(296, 23);
            textBoxMail.TabIndex = 4;
            textBoxMail.Text = "email";
            // 
            // textBoxPass1
            // 
            textBoxPass1.Location = new Point(15, 164);
            textBoxPass1.Name = "textBoxPass1";
            textBoxPass1.PasswordChar = '*';
            textBoxPass1.Size = new Size(296, 23);
            textBoxPass1.TabIndex = 5;
            textBoxPass1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPass2
            // 
            textBoxPass2.Location = new Point(15, 252);
            textBoxPass2.Name = "textBoxPass2";
            textBoxPass2.PasswordChar = '*';
            textBoxPass2.Size = new Size(296, 23);
            textBoxPass2.TabIndex = 6;
            // 
            // buttonOnly
            // 
            buttonOnly.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOnly.Location = new Point(120, 316);
            buttonOnly.Name = "buttonOnly";
            buttonOnly.Size = new Size(90, 40);
            buttonOnly.TabIndex = 7;
            buttonOnly.Text = "Zatwierdz";
            buttonOnly.UseVisualStyleBackColor = true;
            buttonOnly.Click += buttonOnly_Click;
            // 
            // labelShowInfo
            // 
            labelShowInfo.AutoSize = true;
            labelShowInfo.Location = new Point(122, 381);
            labelShowInfo.Name = "labelShowInfo";
            labelShowInfo.Size = new Size(0, 15);
            labelShowInfo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 427);
            Controls.Add(labelShowInfo);
            Controls.Add(buttonOnly);
            Controls.Add(textBoxPass2);
            Controls.Add(textBoxPass1);
            Controls.Add(textBoxMail);
            Controls.Add(labelPass2);
            Controls.Add(labelPass1);
            Controls.Add(labelEmail);
            Controls.Add(labelOnTop);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOnTop;
        private Label labelEmail;
        private Label labelPass1;
        private Label labelPass2;
        private TextBox textBoxMail;
        private TextBox textBoxPass1;
        private TextBox textBoxPass2;
        private Button buttonOnly;
        private Label labelShowInfo;
    }
}