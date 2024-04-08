namespace FirstApplicationWithWinForms
{
    partial class MainForm
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
            button1 = new Button();
            labelFavoriteSubject = new Label();
            checkBoxMathematics = new CheckBox();
            checkBoxGerman = new CheckBox();
            radioButtonNo = new RadioButton();
            radioButtonYes = new RadioButton();
            labelWhat = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            labelFavoriteGame = new Label();
            comboBoxGames = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Location = new Point(589, 380);
            button1.Name = "button1";
            button1.Size = new Size(156, 49);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonFirst_Click;
            // 
            // labelFavoriteSubject
            // 
            labelFavoriteSubject.AutoSize = true;
            labelFavoriteSubject.Location = new Point(30, 48);
            labelFavoriteSubject.Name = "labelFavoriteSubject";
            labelFavoriteSubject.Size = new Size(109, 15);
            labelFavoriteSubject.TabIndex = 2;
            labelFavoriteSubject.Text = "Wybierz przedmiot ";
            labelFavoriteSubject.Click += label1_Click;
            // 
            // checkBoxMathematics
            // 
            checkBoxMathematics.AutoSize = true;
            checkBoxMathematics.Location = new Point(30, 85);
            checkBoxMathematics.Name = "checkBoxMathematics";
            checkBoxMathematics.Size = new Size(103, 19);
            checkBoxMathematics.TabIndex = 3;
            checkBoxMathematics.Text = "matmematyka";
            checkBoxMathematics.UseVisualStyleBackColor = true;
            // 
            // checkBoxGerman
            // 
            checkBoxGerman.AutoSize = true;
            checkBoxGerman.Location = new Point(30, 110);
            checkBoxGerman.Name = "checkBoxGerman";
            checkBoxGerman.Size = new Size(89, 19);
            checkBoxGerman.TabIndex = 4;
            checkBoxGerman.Text = "Jezyk wroga";
            checkBoxGerman.UseVisualStyleBackColor = true;
            checkBoxGerman.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Location = new Point(320, 85);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(41, 19);
            radioButtonNo.TabIndex = 5;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "nie";
            radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.Location = new Point(219, 85);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(86, 19);
            radioButtonYes.TabIndex = 6;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Oczywiscie ";
            radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // labelWhat
            // 
            labelWhat.AutoSize = true;
            labelWhat.Location = new Point(286, 67);
            labelWhat.Name = "labelWhat";
            labelWhat.Size = new Size(33, 15);
            labelWhat.TabIndex = 7;
            labelWhat.Text = "Piwo";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(37, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(96, 15);
            labelName.TabIndex = 8;
            labelName.Text = "Podaj swoje imie";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(154, 6);
            textBoxName.Name = "textBoxName";
            textBoxName.PasswordChar = '*';
            textBoxName.Size = new Size(151, 23);
            textBoxName.TabIndex = 9;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // labelFavoriteGame
            // 
            labelFavoriteGame.AutoSize = true;
            labelFavoriteGame.Location = new Point(507, 40);
            labelFavoriteGame.Name = "labelFavoriteGame";
            labelFavoriteGame.Size = new Size(75, 15);
            labelFavoriteGame.TabIndex = 10;
            labelFavoriteGame.Text = "Ulubiona gra";
            // 
            // comboBoxGames
            // 
            comboBoxGames.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGames.FormattingEnabled = true;
            comboBoxGames.Items.AddRange(new object[] { "tomrajder", " gta 5", " minecraft", "simis 4", "fortnite ", "bravlstars" });
            comboBoxGames.Location = new Point(507, 67);
            comboBoxGames.Name = "comboBoxGames";
            comboBoxGames.Size = new Size(121, 23);
            comboBoxGames.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxGames);
            Controls.Add(labelFavoriteGame);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelWhat);
            Controls.Add(radioButtonYes);
            Controls.Add(radioButtonNo);
            Controls.Add(checkBoxGerman);
            Controls.Add(checkBoxMathematics);
            Controls.Add(labelFavoriteSubject);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "1 aplikacja";
            Load += Form1_Load;
            Click += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private Label labelFavoriteSubject;
        private CheckBox checkBoxMathematics;
        private CheckBox checkBoxGerman;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonYes;
        private Label labelWhat;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelFavoriteGame;
        private ComboBox comboBoxGames;
    }
}