namespace NEA_Music_Managment_and_reccomendation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            Passwordbox = new TextBox();
            UsernameBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 252);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(278, 275);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 208);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 10;
            label2.Text = "Enter New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 96);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 9;
            label1.Text = "Enter New Username";
            label1.Click += label1_Click;
            // 
            // Passwordbox
            // 
            Passwordbox.Location = new Point(278, 226);
            Passwordbox.Name = "Passwordbox";
            Passwordbox.PlaceholderText = "New Password...";
            Passwordbox.Size = new Size(245, 23);
            Passwordbox.TabIndex = 8;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(278, 114);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "New Username...";
            UsernameBox.Size = new Size(245, 23);
            UsernameBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 252);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Passwordbox);
            Controls.Add(UsernameBox);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox Passwordbox;
        private TextBox UsernameBox;
        private Label label4;
    }
}