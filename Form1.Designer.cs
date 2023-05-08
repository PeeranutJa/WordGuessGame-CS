namespace CS_Program01
{
    partial class Form1
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
            this.Show_word = new System.Windows.Forms.Label();
            this.Input_word = new System.Windows.Forms.TextBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_quit = new System.Windows.Forms.Button();
            this.gamename = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.Score_text = new System.Windows.Forms.Label();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Show_word
            // 
            this.Show_word.BackColor = System.Drawing.Color.Silver;
            this.Show_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_word.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Show_word.Location = new System.Drawing.Point(45, 75);
            this.Show_word.Name = "Show_word";
            this.Show_word.Size = new System.Drawing.Size(300, 75);
            this.Show_word.TabIndex = 0;
            this.Show_word.Text = "W_RD";
            this.Show_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Input_word
            // 
            this.Input_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_word.Location = new System.Drawing.Point(69, 175);
            this.Input_word.Name = "Input_word";
            this.Input_word.Size = new System.Drawing.Size(250, 38);
            this.Input_word.TabIndex = 1;
            this.Input_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input_word.UseWaitCursor = true;
            this.Input_word.TextChanged += new System.EventHandler(this.Input_text);
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.SaddleBrown;
            this.Button_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Start.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Button_Start.Location = new System.Drawing.Point(95, 230);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(200, 75);
            this.Button_Start.TabIndex = 2;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_quit
            // 
            this.Button_quit.BackColor = System.Drawing.Color.LightCyan;
            this.Button_quit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_quit.Location = new System.Drawing.Point(108, 311);
            this.Button_quit.Name = "Button_quit";
            this.Button_quit.Size = new System.Drawing.Size(85, 60);
            this.Button_quit.TabIndex = 3;
            this.Button_quit.Text = "Quit";
            this.Button_quit.UseVisualStyleBackColor = false;
            this.Button_quit.Click += new System.EventHandler(this.Button_quit_Click);
            // 
            // gamename
            // 
            this.gamename.AutoSize = true;
            this.gamename.BackColor = System.Drawing.Color.Tan;
            this.gamename.Font = new System.Drawing.Font("MV Boli", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamename.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gamename.Location = new System.Drawing.Point(20, 10);
            this.gamename.Name = "gamename";
            this.gamename.Size = new System.Drawing.Size(361, 52);
            this.gamename.TabIndex = 4;
            this.gamename.Text = "Word guess game";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_result.Location = new System.Drawing.Point(42, 391);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(93, 25);
            this.label_result.TabIndex = 5;
            this.label_result.Text = "Result :";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_score.Location = new System.Drawing.Point(42, 434);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(94, 25);
            this.label_score.TabIndex = 6;
            this.label_score.Text = "Score : ";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(141, 391);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(93, 25);
            this.result.TabIndex = 7;
            this.result.Text = "Result :";
            // 
            // Score_text
            // 
            this.Score_text.AutoSize = true;
            this.Score_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_text.Location = new System.Drawing.Point(142, 434);
            this.Score_text.Name = "Score_text";
            this.Score_text.Size = new System.Drawing.Size(93, 25);
            this.Score_text.TabIndex = 8;
            this.Score_text.Text = "Result :";
            // 
            // Button_Next
            // 
            this.Button_Next.BackColor = System.Drawing.Color.Turquoise;
            this.Button_Next.Enabled = false;
            this.Button_Next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Next.Location = new System.Drawing.Point(199, 311);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(85, 60);
            this.Button_Next.TabIndex = 9;
            this.Button_Next.Text = "Next";
            this.Button_Next.UseVisualStyleBackColor = false;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hint.ForeColor = System.Drawing.SystemColors.Control;
            this.Hint.Location = new System.Drawing.Point(119, 152);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(156, 20);
            this.Hint.TabIndex = 10;
            this.Hint.Text = "3 Letters are missing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(400, 502);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.Score_text);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.gamename);
            this.Controls.Add(this.Button_quit);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Input_word);
            this.Controls.Add(this.Show_word);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Guess Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Show_word;
        private System.Windows.Forms.TextBox Input_word;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_quit;
        private System.Windows.Forms.Label gamename;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label Score_text;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Label Hint;
    }
}

