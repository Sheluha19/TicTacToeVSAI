namespace _123
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
            components = new System.ComponentModel.Container();
            A1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            B1 = new Button();
            C1 = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            B2 = new Button();
            button8 = new Button();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            A3 = new Button();
            B3 = new Button();
            button9 = new Button();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker9 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker10 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            AITimer = new System.Windows.Forms.Timer(components);
            AImoves = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // A1
            // 
            A1.Location = new Point(51, 150);
            A1.Name = "A1";
            A1.Size = new Size(101, 81);
            A1.TabIndex = 1;
            A1.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            B1.Location = new Point(51, 237);
            B1.Name = "B1";
            B1.Size = new Size(101, 81);
            B1.TabIndex = 2;
            B1.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            C1.Location = new Point(51, 324);
            C1.Name = "C1";
            C1.Size = new Size(101, 81);
            C1.TabIndex = 3;
            C1.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            B2.Location = new Point(158, 237);
            B2.Name = "B2";
            B2.Size = new Size(101, 81);
            B2.TabIndex = 5;
            B2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(158, 324);
            button8.Name = "button8";
            button8.Size = new Size(101, 81);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_click;
            // 
            // A3
            // 
            A3.Location = new Point(265, 150);
            A3.Name = "A3";
            A3.Size = new Size(101, 81);
            A3.TabIndex = 7;
            A3.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            B3.Location = new Point(265, 237);
            B3.Name = "B3";
            B3.Size = new Size(101, 81);
            B3.TabIndex = 8;
            B3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(265, 324);
            button9.Name = "button9";
            button9.Size = new Size(101, 81);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1131, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(165, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(51, 150);
            button1.Name = "button1";
            button1.Size = new Size(101, 81);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_click;
            // 
            // button2
            // 
            button2.Location = new Point(51, 237);
            button2.Name = "button2";
            button2.Size = new Size(101, 81);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_click;
            // 
            // button3
            // 
            button3.Location = new Point(51, 324);
            button3.Name = "button3";
            button3.Size = new Size(101, 81);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_click;
            // 
            // button4
            // 
            button4.Location = new Point(158, 150);
            button4.Name = "button4";
            button4.Size = new Size(101, 81);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_click;
            // 
            // button5
            // 
            button5.Location = new Point(158, 237);
            button5.Name = "button5";
            button5.Size = new Size(101, 81);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_click;
            // 
            // button6
            // 
            button6.Location = new Point(265, 150);
            button6.Name = "button6";
            button6.Size = new Size(101, 81);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_click;
            // 
            // button7
            // 
            button7.Location = new Point(265, 237);
            button7.Name = "button7";
            button7.Size = new Size(101, 81);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 450);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(B3);
            Controls.Add(button6);
            Controls.Add(A3);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(B2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(C1);
            Controls.Add(button1);
            Controls.Add(B1);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button A1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button B1;
        private Button C1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button B2;
        private Button button8;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private Button A3;
        private Button B3;
        private Button button9;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.ComponentModel.BackgroundWorker backgroundWorker9;
        private System.ComponentModel.BackgroundWorker backgroundWorker10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private System.Windows.Forms.Timer AITimer;
        private System.Windows.Forms.Timer AImoves;
    }
}