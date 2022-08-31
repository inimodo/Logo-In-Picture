namespace User
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.e_nav_title = new System.Windows.Forms.Label();
            this.e_nav = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.e_CoverScale = new System.Windows.Forms.NumericUpDown();
            this.e_StreamEndcolor = new System.Windows.Forms.PictureBox();
            this.e_StreamVariation = new System.Windows.Forms.NumericUpDown();
            this.e_StreamLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.e_SideOffset = new System.Windows.Forms.NumericUpDown();
            this.e_Opacity = new System.Windows.Forms.NumericUpDown();
            this.e_Modi = new System.Windows.Forms.ComboBox();
            this.e_Position = new System.Windows.Forms.ComboBox();
            this.e_ = new System.Windows.Forms.GroupBox();
            this.e_SourceFolder = new System.Windows.Forms.TextBox();
            this.e_SelSourceFolder = new System.Windows.Forms.Button();
            this.e_SelSourceLogo = new System.Windows.Forms.Button();
            this.e_LogoSource = new System.Windows.Forms.TextBox();
            this.e_SetDestFolder = new System.Windows.Forms.Button();
            this.e_DestFolder = new System.Windows.Forms.TextBox();
            this.e_Run = new System.Windows.Forms.Button();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            this.e_hider.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_CoverScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_StreamEndcolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_StreamVariation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_StreamLength)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_SideOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Opacity)).BeginInit();
            this.e_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).BeginInit();
            this.SuspendLayout();
            // 
            // e_nav_title
            // 
            this.e_nav_title.AutoSize = true;
            this.e_nav_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_title.Font = new System.Drawing.Font("Logico Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_nav_title.ForeColor = System.Drawing.Color.White;
            this.e_nav_title.Location = new System.Drawing.Point(12, 6);
            this.e_nav_title.Name = "e_nav_title";
            this.e_nav_title.Size = new System.Drawing.Size(222, 19);
            this.e_nav_title.TabIndex = 18;
            this.e_nav_title.Text = "THENAMEOFTHESOFTWARE";
            // 
            // e_nav
            // 
            this.e_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav.Location = new System.Drawing.Point(1, 1);
            this.e_nav.Name = "e_nav";
            this.e_nav.Size = new System.Drawing.Size(358, 30);
            this.e_nav.TabIndex = 16;
            this.e_nav.TabStop = false;
            this.e_nav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_start);
            this.e_nav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_run);
            this.e_nav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_stop);
            // 
            // e_hider
            // 
            this.e_hider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.e_hider.Controls.Add(this.e_CoverScale);
            this.e_hider.Controls.Add(this.groupBox1);
            this.e_hider.Controls.Add(this.groupBox2);
            this.e_hider.Controls.Add(this.e_);
            this.e_hider.Controls.Add(this.e_Run);
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(271, 333);
            this.e_hider.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.e_StreamEndcolor);
            this.groupBox1.Controls.Add(this.e_StreamVariation);
            this.groupBox1.Controls.Add(this.e_StreamLength);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream Options";
            // 
            // e_CoverScale
            // 
            this.e_CoverScale.Location = new System.Drawing.Point(91, 299);
            this.e_CoverScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.e_CoverScale.Name = "e_CoverScale";
            this.e_CoverScale.Size = new System.Drawing.Size(91, 20);
            this.e_CoverScale.TabIndex = 14;
            this.e_CoverScale.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // e_StreamEndcolor
            // 
            this.e_StreamEndcolor.BackColor = System.Drawing.Color.Black;
            this.e_StreamEndcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.e_StreamEndcolor.Location = new System.Drawing.Point(122, 20);
            this.e_StreamEndcolor.Name = "e_StreamEndcolor";
            this.e_StreamEndcolor.Size = new System.Drawing.Size(115, 21);
            this.e_StreamEndcolor.TabIndex = 13;
            this.e_StreamEndcolor.TabStop = false;
            this.e_StreamEndcolor.Click += new System.EventHandler(this.OpenColorDialog);
            // 
            // e_StreamVariation
            // 
            this.e_StreamVariation.Location = new System.Drawing.Point(10, 46);
            this.e_StreamVariation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.e_StreamVariation.Name = "e_StreamVariation";
            this.e_StreamVariation.Size = new System.Drawing.Size(91, 20);
            this.e_StreamVariation.TabIndex = 12;
            this.e_StreamVariation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // e_StreamLength
            // 
            this.e_StreamLength.Location = new System.Drawing.Point(10, 20);
            this.e_StreamLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.e_StreamLength.Name = "e_StreamLength";
            this.e_StreamLength.Size = new System.Drawing.Size(91, 20);
            this.e_StreamLength.TabIndex = 11;
            this.e_StreamLength.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.e_SideOffset);
            this.groupBox2.Controls.Add(this.e_Opacity);
            this.groupBox2.Controls.Add(this.e_Modi);
            this.groupBox2.Controls.Add(this.e_Position);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(15, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 78);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logo Options";
            // 
            // e_SideOffset
            // 
            this.e_SideOffset.Location = new System.Drawing.Point(10, 19);
            this.e_SideOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.e_SideOffset.Name = "e_SideOffset";
            this.e_SideOffset.Size = new System.Drawing.Size(91, 20);
            this.e_SideOffset.TabIndex = 6;
            this.e_SideOffset.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // e_Opacity
            // 
            this.e_Opacity.Location = new System.Drawing.Point(10, 45);
            this.e_Opacity.Name = "e_Opacity";
            this.e_Opacity.Size = new System.Drawing.Size(91, 20);
            this.e_Opacity.TabIndex = 6;
            this.e_Opacity.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // e_Modi
            // 
            this.e_Modi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_Modi.FormattingEnabled = true;
            this.e_Modi.Location = new System.Drawing.Point(116, 45);
            this.e_Modi.Name = "e_Modi";
            this.e_Modi.Size = new System.Drawing.Size(115, 21);
            this.e_Modi.TabIndex = 9;
            // 
            // e_Position
            // 
            this.e_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_Position.FormattingEnabled = true;
            this.e_Position.Items.AddRange(new object[] {
            "Left Top",
            "Left Bottom",
            "Right Top",
            "Right Bottom"});
            this.e_Position.Location = new System.Drawing.Point(116, 18);
            this.e_Position.Name = "e_Position";
            this.e_Position.Size = new System.Drawing.Size(115, 21);
            this.e_Position.TabIndex = 9;
            // 
            // e_
            // 
            this.e_.Controls.Add(this.e_SourceFolder);
            this.e_.Controls.Add(this.e_SelSourceFolder);
            this.e_.Controls.Add(this.e_SelSourceLogo);
            this.e_.Controls.Add(this.e_LogoSource);
            this.e_.Controls.Add(this.e_SetDestFolder);
            this.e_.Controls.Add(this.e_DestFolder);
            this.e_.ForeColor = System.Drawing.Color.White;
            this.e_.Location = new System.Drawing.Point(15, 6);
            this.e_.Name = "e_";
            this.e_.Size = new System.Drawing.Size(243, 103);
            this.e_.TabIndex = 10;
            this.e_.TabStop = false;
            this.e_.Text = "IO";
            // 
            // e_SourceFolder
            // 
            this.e_SourceFolder.Location = new System.Drawing.Point(10, 17);
            this.e_SourceFolder.Name = "e_SourceFolder";
            this.e_SourceFolder.ReadOnly = true;
            this.e_SourceFolder.Size = new System.Drawing.Size(177, 20);
            this.e_SourceFolder.TabIndex = 1;
            this.e_SourceFolder.Text = "No Images Loaded";
            this.e_SourceFolder.Click += new System.EventHandler(this.OpenFolder);
            // 
            // e_SelSourceFolder
            // 
            this.e_SelSourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_SelSourceFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_SelSourceFolder.Location = new System.Drawing.Point(197, 17);
            this.e_SelSourceFolder.Name = "e_SelSourceFolder";
            this.e_SelSourceFolder.Size = new System.Drawing.Size(35, 20);
            this.e_SelSourceFolder.TabIndex = 0;
            this.e_SelSourceFolder.Text = "...";
            this.e_SelSourceFolder.UseVisualStyleBackColor = true;
            this.e_SelSourceFolder.Click += new System.EventHandler(this.OpenFolder);
            // 
            // e_SelSourceLogo
            // 
            this.e_SelSourceLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_SelSourceLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_SelSourceLogo.Location = new System.Drawing.Point(197, 43);
            this.e_SelSourceLogo.Name = "e_SelSourceLogo";
            this.e_SelSourceLogo.Size = new System.Drawing.Size(35, 20);
            this.e_SelSourceLogo.TabIndex = 2;
            this.e_SelSourceLogo.Text = "...";
            this.e_SelSourceLogo.UseVisualStyleBackColor = true;
            this.e_SelSourceLogo.Click += new System.EventHandler(this.SelLogoSource);
            // 
            // e_LogoSource
            // 
            this.e_LogoSource.Location = new System.Drawing.Point(10, 43);
            this.e_LogoSource.Name = "e_LogoSource";
            this.e_LogoSource.ReadOnly = true;
            this.e_LogoSource.Size = new System.Drawing.Size(177, 20);
            this.e_LogoSource.TabIndex = 3;
            this.e_LogoSource.Text = "No Logo Loaded";
            // 
            // e_SetDestFolder
            // 
            this.e_SetDestFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_SetDestFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_SetDestFolder.Location = new System.Drawing.Point(197, 69);
            this.e_SetDestFolder.Name = "e_SetDestFolder";
            this.e_SetDestFolder.Size = new System.Drawing.Size(35, 20);
            this.e_SetDestFolder.TabIndex = 4;
            this.e_SetDestFolder.Text = "...";
            this.e_SetDestFolder.UseVisualStyleBackColor = true;
            this.e_SetDestFolder.Click += new System.EventHandler(this.SelDestFolder);
            // 
            // e_DestFolder
            // 
            this.e_DestFolder.Location = new System.Drawing.Point(10, 69);
            this.e_DestFolder.Name = "e_DestFolder";
            this.e_DestFolder.ReadOnly = true;
            this.e_DestFolder.Size = new System.Drawing.Size(177, 20);
            this.e_DestFolder.TabIndex = 5;
            this.e_DestFolder.Text = "No Output Folder Selected";
            // 
            // e_Run
            // 
            this.e_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_Run.Location = new System.Drawing.Point(188, 298);
            this.e_Run.Name = "e_Run";
            this.e_Run.Size = new System.Drawing.Size(70, 20);
            this.e_Run.TabIndex = 8;
            this.e_Run.Text = "Process";
            this.e_Run.UseVisualStyleBackColor = true;
            this.e_Run.Click += new System.EventHandler(this.Run);
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(335, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 22;
            this.e_nav_close.TabStop = false;
            this.e_nav_close.Click += new System.EventHandler(this.Close);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 509);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_hider);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDOWNAME";
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            this.e_hider.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_CoverScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_StreamEndcolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_StreamVariation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_StreamLength)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_SideOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Opacity)).EndInit();
            this.e_.ResumeLayout(false);
            this.e_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_nav_title;
        private System.Windows.Forms.PictureBox e_nav;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.PictureBox e_nav_close;
        private System.Windows.Forms.Button e_Run;
        private System.Windows.Forms.NumericUpDown e_SideOffset;
        private System.Windows.Forms.TextBox e_DestFolder;
        private System.Windows.Forms.Button e_SetDestFolder;
        private System.Windows.Forms.TextBox e_LogoSource;
        private System.Windows.Forms.Button e_SelSourceLogo;
        private System.Windows.Forms.TextBox e_SourceFolder;
        private System.Windows.Forms.Button e_SelSourceFolder;
        private System.Windows.Forms.ComboBox e_Position;
        private System.Windows.Forms.NumericUpDown e_Opacity;
        private System.Windows.Forms.ComboBox e_Modi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox e_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox e_StreamEndcolor;
        private System.Windows.Forms.NumericUpDown e_StreamVariation;
        private System.Windows.Forms.NumericUpDown e_StreamLength;
        private System.Windows.Forms.NumericUpDown e_CoverScale;
    }
}