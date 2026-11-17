namespace NEA_Music_Managment_and_reccomendation
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
            UsernameBox = new TextBox();
            Passwordbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label4 = new Label();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(285, 132);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "Username...";
            UsernameBox.Size = new Size(245, 23);
            UsernameBox.TabIndex = 0;
            UsernameBox.TextChanged += textBox1_TextChanged;
            // 
            // Passwordbox
            // 
            Passwordbox.Location = new Point(285, 244);
            Passwordbox.Name = "Passwordbox";
            Passwordbox.PlaceholderText = "Password...";
            Passwordbox.Size = new Size(245, 23);
            Passwordbox.TabIndex = 1;
            Passwordbox.TextChanged += Passwordbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 114);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 226);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(285, 293);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 270);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(285, 350);
            button2.Name = "button2";
            button2.Size = new Size(245, 23);
            button2.TabIndex = 6;
            button2.Text = "New? Create A Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 79);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Passwordbox);
            Controls.Add(UsernameBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameBox;
        private TextBox Passwordbox;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private SaveFileDialog saveFileDialog1;
        private Label label4;
    }
}
