namespace tictactoe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountWinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b18 = new System.Windows.Forms.Button();
            this.b17 = new System.Windows.Forms.Button();
            this.b16 = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Button();
            this.b14 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCountWinsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetCountWinsToolStripMenuItem
            // 
            this.resetCountWinsToolStripMenuItem.Name = "resetCountWinsToolStripMenuItem";
            this.resetCountWinsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.resetCountWinsToolStripMenuItem.Text = "Reset Win Count";
            this.resetCountWinsToolStripMenuItem.Click += new System.EventHandler(this.resetCountWinsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(132, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(284, 51);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(120, 111);
            this.b3.TabIndex = 1;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            this.b3.MouseEnter += new System.EventHandler(this.button_enter);
            this.b3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(158, 51);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(120, 111);
            this.b2.TabIndex = 2;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            this.b2.MouseEnter += new System.EventHandler(this.button_enter);
            this.b2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(32, 51);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(120, 111);
            this.b1.TabIndex = 3;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            this.b1.MouseEnter += new System.EventHandler(this.button_enter);
            this.b1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b6.Location = new System.Drawing.Point(284, 168);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(120, 111);
            this.b6.TabIndex = 6;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button_Click);
            this.b6.MouseEnter += new System.EventHandler(this.button_enter);
            this.b6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b5.Location = new System.Drawing.Point(158, 168);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(120, 111);
            this.b5.TabIndex = 5;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button_Click);
            this.b5.MouseEnter += new System.EventHandler(this.button_enter);
            this.b5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b4.Location = new System.Drawing.Point(32, 168);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(120, 111);
            this.b4.TabIndex = 4;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button_Click);
            this.b4.MouseEnter += new System.EventHandler(this.button_enter);
            this.b4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b9.Location = new System.Drawing.Point(284, 285);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(120, 111);
            this.b9.TabIndex = 9;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button_Click);
            this.b9.MouseEnter += new System.EventHandler(this.button_enter);
            this.b9.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b8.Location = new System.Drawing.Point(158, 285);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(120, 111);
            this.b8.TabIndex = 8;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button_Click);
            this.b8.MouseEnter += new System.EventHandler(this.button_enter);
            this.b8.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b7.Location = new System.Drawing.Point(32, 285);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(120, 111);
            this.b7.TabIndex = 7;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button_Click);
            this.b7.MouseEnter += new System.EventHandler(this.button_enter);
            this.b7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(437, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 56);
            this.label1.TabIndex = 10;
            this.label1.Text = "Twin Tac Toe\r\n\r\n";
            // 
            // b18
            // 
            this.b18.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b18.Location = new System.Drawing.Point(874, 285);
            this.b18.Name = "b18";
            this.b18.Size = new System.Drawing.Size(120, 111);
            this.b18.TabIndex = 19;
            this.b18.UseVisualStyleBackColor = true;
            this.b18.Click += new System.EventHandler(this.button_Click);
            this.b18.MouseEnter += new System.EventHandler(this.button_enter);
            this.b18.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b17
            // 
            this.b17.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b17.Location = new System.Drawing.Point(748, 285);
            this.b17.Name = "b17";
            this.b17.Size = new System.Drawing.Size(120, 111);
            this.b17.TabIndex = 18;
            this.b17.UseVisualStyleBackColor = true;
            this.b17.Click += new System.EventHandler(this.button_Click);
            this.b17.MouseEnter += new System.EventHandler(this.button_enter);
            this.b17.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b16
            // 
            this.b16.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b16.Location = new System.Drawing.Point(622, 285);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(120, 111);
            this.b16.TabIndex = 17;
            this.b16.UseVisualStyleBackColor = true;
            this.b16.Click += new System.EventHandler(this.button_Click);
            this.b16.MouseEnter += new System.EventHandler(this.button_enter);
            this.b16.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b15
            // 
            this.b15.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b15.Location = new System.Drawing.Point(874, 168);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(120, 111);
            this.b15.TabIndex = 16;
            this.b15.UseVisualStyleBackColor = true;
            this.b15.Click += new System.EventHandler(this.button_Click);
            this.b15.MouseEnter += new System.EventHandler(this.button_enter);
            this.b15.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b14
            // 
            this.b14.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b14.Location = new System.Drawing.Point(748, 168);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(120, 111);
            this.b14.TabIndex = 15;
            this.b14.UseVisualStyleBackColor = true;
            this.b14.Click += new System.EventHandler(this.button_Click);
            this.b14.MouseEnter += new System.EventHandler(this.button_enter);
            this.b14.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b13
            // 
            this.b13.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b13.Location = new System.Drawing.Point(622, 168);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(120, 111);
            this.b13.TabIndex = 14;
            this.b13.UseVisualStyleBackColor = true;
            this.b13.Click += new System.EventHandler(this.button_Click);
            this.b13.MouseEnter += new System.EventHandler(this.button_enter);
            this.b13.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b10
            // 
            this.b10.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b10.Location = new System.Drawing.Point(622, 51);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(120, 111);
            this.b10.TabIndex = 13;
            this.b10.UseVisualStyleBackColor = true;
            this.b10.Click += new System.EventHandler(this.button_Click);
            this.b10.MouseEnter += new System.EventHandler(this.button_enter);
            this.b10.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b11
            // 
            this.b11.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b11.Location = new System.Drawing.Point(748, 51);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(120, 111);
            this.b11.TabIndex = 12;
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.button_Click);
            this.b11.MouseEnter += new System.EventHandler(this.button_enter);
            this.b11.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b12
            // 
            this.b12.Font = new System.Drawing.Font("Segoe UI", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b12.Location = new System.Drawing.Point(874, 51);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(120, 111);
            this.b12.TabIndex = 11;
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.button_Click);
            this.b12.MouseEnter += new System.EventHandler(this.button_enter);
            this.b12.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(464, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "X Win Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(464, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Draw Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(463, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "O Win Count";
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Location = new System.Drawing.Point(501, 185);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(17, 20);
            this.x_win_count.TabIndex = 23;
            this.x_win_count.Text = "0";
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(501, 272);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(17, 20);
            this.draw_count.TabIndex = 24;
            this.draw_count.Text = "0";
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Location = new System.Drawing.Point(500, 384);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(17, 20);
            this.o_win_count.TabIndex = 25;
            this.o_win_count.Text = "0";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(452, 126);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(120, 26);
            this.p1.TabIndex = 26;
            this.p1.Text = "Player X";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(451, 325);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(120, 26);
            this.p2.TabIndex = 27;
            this.p2.Text = "Player O";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 431);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b18);
            this.Controls.Add(this.b17);
            this.Controls.Add(this.b16);
            this.Controls.Add(this.b15);
            this.Controls.Add(this.b14);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b9;
        private Button b8;
        private Button b7;
        private Label label1;
        private Button b18;
        private Button b17;
        private Button b16;
        private Button b15;
        private Button b14;
        private Button b13;
        private Button b10;
        private Button b11;
        private Button b12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label x_win_count;
        private Label draw_count;
        private Label o_win_count;
        private ToolStripMenuItem resetCountWinsToolStripMenuItem;
        private TextBox p1;
        private TextBox p2;
    }
}