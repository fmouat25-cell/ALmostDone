namespace NEA_Music_Managment_and_reccomendation
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            button3 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SearchBox = new TextBox();
            button2 = new Button();
            FilterBox = new ComboBox();
            label7 = new Label();
            button4 = new Button();
            panel2 = new Panel();
            progressBar2 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(270, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(518, 329);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 6;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 7;
            label2.Text = "Albums listened to :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleTurquoise;
            label3.Location = new Point(77, 6);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleTurquoise;
            label4.Location = new Point(121, 38);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 74);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 10;
            label5.Text = "Average Rating : ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PaleTurquoise;
            label6.Location = new Point(105, 74);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 389);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.IndianRed;
            label10.Location = new Point(-1, 77);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 20;
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.IndianRed;
            label9.Location = new Point(-1, 49);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.IndianRed;
            label8.Location = new Point(-1, 22);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(3, 104);
            button3.Name = "button3";
            button3.Size = new Size(230, 23);
            button3.TabIndex = 12;
            button3.Text = "Generate Recommendation";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SearchBox
            // 
            SearchBox.BorderStyle = BorderStyle.FixedSingle;
            SearchBox.Location = new Point(270, 43);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search Albums/Artists Here...";
            SearchBox.Size = new Size(342, 23);
            SearchBox.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(618, 43);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 15;
            button2.Text = "🔍";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FilterBox
            // 
            FilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterBox.FormattingEnabled = true;
            FilterBox.Items.AddRange(new object[] { "", "AlternativeRock", "ArtPop", "ArtRock", "Dubstep", "Electronic", "Folk", "FolkRock", "GlamRock", "Grunge", "HardRock", "HeartlandRock", "HeavyMetal", "HipHop", "IndiePop", "IndieRock", "Jazz", "JazzFusion", "NeoSoul", "NewWave", "NoisePop", "Pop", "PopRock", "PostPunk", "ProgressiveRock", "PsychedelicRock", "R&B", "Rock", "Shoegaze", "SoftRock", "Soul", "ThrashMetal" });
            FilterBox.Location = new Point(647, 42);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(84, 23);
            FilterBox.TabIndex = 16;
            FilterBox.SelectedIndexChanged += FilterBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(647, 24);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 17;
            label7.Text = "Filter:";
            // 
            // button4
            // 
            button4.Location = new Point(270, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 18;
            button4.Text = "SaveRatings";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(progressBar2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(12, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 135);
            panel2.TabIndex = 21;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(5, 3);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(218, 23);
            progressBar2.Step = 5;
            progressBar2.TabIndex = 21;
            progressBar2.Click += progressBar2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(FilterBox);
            Controls.Add(button2);
            Controls.Add(SearchBox);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private SaveFileDialog saveFileDialog1;
        private TextBox SearchBox;
        private Button button2;
        private ComboBox FilterBox;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private ProgressBar progressBar2;
    }
}