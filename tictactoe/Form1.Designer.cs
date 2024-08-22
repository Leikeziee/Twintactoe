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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
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
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetCountWinsToolStripMenuItem
            // 
            this.resetCountWinsToolStripMenuItem.Name = "resetCountWinsToolStripMenuItem";
            this.resetCountWinsToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.resetCountWinsToolStripMenuItem.Text = "Reset Win Count";
            this.resetCountWinsToolStripMenuItem.Click += new System.EventHandler(this.resetCountWinsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
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
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.ForeColor = System.Drawing.Color.DarkBlue;
            this.b3.Location = new System.Drawing.Point(290, 138);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(120, 117);
            this.b3.TabIndex = 1;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            this.b3.MouseEnter += new System.EventHandler(this.button_enter);
            this.b3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.ForeColor = System.Drawing.Color.DarkBlue;
            this.b2.Location = new System.Drawing.Point(164, 138);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(120, 117);
            this.b2.TabIndex = 2;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            this.b2.MouseEnter += new System.EventHandler(this.button_enter);
            this.b2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.ForeColor = System.Drawing.Color.DarkBlue;
            this.b1.Location = new System.Drawing.Point(38, 138);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(120, 117);
            this.b1.TabIndex = 3;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            this.b1.MouseEnter += new System.EventHandler(this.button_enter);
            this.b1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b6.ForeColor = System.Drawing.Color.DarkBlue;
            this.b6.Location = new System.Drawing.Point(290, 261);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(120, 117);
            this.b6.TabIndex = 6;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button_Click);
            this.b6.MouseEnter += new System.EventHandler(this.button_enter);
            this.b6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b5.ForeColor = System.Drawing.Color.DarkBlue;
            this.b5.Location = new System.Drawing.Point(164, 261);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(120, 117);
            this.b5.TabIndex = 5;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button_Click);
            this.b5.MouseEnter += new System.EventHandler(this.button_enter);
            this.b5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b4.ForeColor = System.Drawing.Color.DarkBlue;
            this.b4.Location = new System.Drawing.Point(38, 261);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(120, 117);
            this.b4.TabIndex = 4;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button_Click);
            this.b4.MouseEnter += new System.EventHandler(this.button_enter);
            this.b4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b9.ForeColor = System.Drawing.Color.DarkBlue;
            this.b9.Location = new System.Drawing.Point(290, 384);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(120, 117);
            this.b9.TabIndex = 9;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button_Click);
            this.b9.MouseEnter += new System.EventHandler(this.button_enter);
            this.b9.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b8.ForeColor = System.Drawing.Color.DarkBlue;
            this.b8.Location = new System.Drawing.Point(164, 384);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(120, 117);
            this.b8.TabIndex = 8;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button_Click);
            this.b8.MouseEnter += new System.EventHandler(this.button_enter);
            this.b8.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b7.ForeColor = System.Drawing.Color.DarkBlue;
            this.b7.Location = new System.Drawing.Point(38, 384);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(120, 117);
            this.b7.TabIndex = 7;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button_Click);
            this.b7.MouseEnter += new System.EventHandler(this.button_enter);
            this.b7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b18
            // 
            this.b18.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b18.ForeColor = System.Drawing.Color.DarkBlue;
            this.b18.Location = new System.Drawing.Point(921, 384);
            this.b18.Name = "b18";
            this.b18.Size = new System.Drawing.Size(120, 117);
            this.b18.TabIndex = 19;
            this.b18.UseVisualStyleBackColor = true;
            this.b18.Click += new System.EventHandler(this.button_Click);
            this.b18.MouseEnter += new System.EventHandler(this.button_enter);
            this.b18.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b17
            // 
            this.b17.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b17.ForeColor = System.Drawing.Color.DarkBlue;
            this.b17.Location = new System.Drawing.Point(795, 384);
            this.b17.Name = "b17";
            this.b17.Size = new System.Drawing.Size(120, 117);
            this.b17.TabIndex = 18;
            this.b17.UseVisualStyleBackColor = true;
            this.b17.Click += new System.EventHandler(this.button_Click);
            this.b17.MouseEnter += new System.EventHandler(this.button_enter);
            this.b17.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b16
            // 
            this.b16.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b16.ForeColor = System.Drawing.Color.DarkBlue;
            this.b16.Location = new System.Drawing.Point(669, 384);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(120, 117);
            this.b16.TabIndex = 17;
            this.b16.UseVisualStyleBackColor = true;
            this.b16.Click += new System.EventHandler(this.button_Click);
            this.b16.MouseEnter += new System.EventHandler(this.button_enter);
            this.b16.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b15
            // 
            this.b15.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b15.ForeColor = System.Drawing.Color.DarkBlue;
            this.b15.Location = new System.Drawing.Point(921, 261);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(120, 117);
            this.b15.TabIndex = 16;
            this.b15.UseVisualStyleBackColor = true;
            this.b15.Click += new System.EventHandler(this.button_Click);
            this.b15.MouseEnter += new System.EventHandler(this.button_enter);
            this.b15.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b14
            // 
            this.b14.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b14.ForeColor = System.Drawing.Color.DarkBlue;
            this.b14.Location = new System.Drawing.Point(795, 261);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(120, 117);
            this.b14.TabIndex = 15;
            this.b14.UseVisualStyleBackColor = true;
            this.b14.Click += new System.EventHandler(this.button_Click);
            this.b14.MouseEnter += new System.EventHandler(this.button_enter);
            this.b14.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b13
            // 
            this.b13.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b13.ForeColor = System.Drawing.Color.DarkBlue;
            this.b13.Location = new System.Drawing.Point(669, 261);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(120, 117);
            this.b13.TabIndex = 14;
            this.b13.UseVisualStyleBackColor = true;
            this.b13.Click += new System.EventHandler(this.button_Click);
            this.b13.MouseEnter += new System.EventHandler(this.button_enter);
            this.b13.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b10
            // 
            this.b10.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b10.ForeColor = System.Drawing.Color.DarkBlue;
            this.b10.Location = new System.Drawing.Point(669, 138);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(120, 117);
            this.b10.TabIndex = 13;
            this.b10.UseVisualStyleBackColor = true;
            this.b10.Click += new System.EventHandler(this.button_Click);
            this.b10.MouseEnter += new System.EventHandler(this.button_enter);
            this.b10.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b11
            // 
            this.b11.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b11.ForeColor = System.Drawing.Color.DarkBlue;
            this.b11.Location = new System.Drawing.Point(795, 138);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(120, 117);
            this.b11.TabIndex = 12;
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.button_Click);
            this.b11.MouseEnter += new System.EventHandler(this.button_enter);
            this.b11.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b12
            // 
            this.b12.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b12.ForeColor = System.Drawing.Color.DarkBlue;
            this.b12.Location = new System.Drawing.Point(921, 138);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(120, 117);
            this.b12.TabIndex = 11;
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.button_Click);
            this.b12.MouseEnter += new System.EventHandler(this.button_enter);
            this.b12.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(473, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "X Win Count:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(473, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Draw Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(468, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "O Win Count:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x_win_count.ForeColor = System.Drawing.Color.DarkBlue;
            this.x_win_count.Location = new System.Drawing.Point(615, 206);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(30, 35);
            this.x_win_count.TabIndex = 23;
            this.x_win_count.Text = "0";
            this.x_win_count.Click += new System.EventHandler(this.x_win_count_Click);
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.draw_count.ForeColor = System.Drawing.Color.DarkBlue;
            this.draw_count.Location = new System.Drawing.Point(615, 430);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(30, 35);
            this.draw_count.TabIndex = 24;
            this.draw_count.Text = "0";
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.o_win_count.ForeColor = System.Drawing.Color.DarkBlue;
            this.o_win_count.Location = new System.Drawing.Point(615, 332);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(30, 35);
            this.o_win_count.TabIndex = 25;
            this.o_win_count.Text = "0";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.p1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p1.ForeColor = System.Drawing.Color.DarkBlue;
            this.p1.Location = new System.Drawing.Point(439, 165);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(206, 38);
            this.p1.TabIndex = 26;
            this.p1.Text = "Player X";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.p2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p2.ForeColor = System.Drawing.Color.DarkBlue;
            this.p2.Location = new System.Drawing.Point(439, 293);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(206, 38);
            this.p2.TabIndex = 27;
            this.p2.Text = "Player O";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2.TextChanged += new System.EventHandler(this.p2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(239, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(604, 71);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-96, -268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1338, 841);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(252, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 56);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(204, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 37);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(763, 31);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 37);
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(773, 67);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 51);
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
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
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}