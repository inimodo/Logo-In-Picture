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
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_Position = new System.Windows.Forms.ComboBox();
            this.e_Run = new System.Windows.Forms.Button();
            this.e_SideOffset = new System.Windows.Forms.NumericUpDown();
            this.e_DestFolder = new System.Windows.Forms.TextBox();
            this.e_SetDestFolder = new System.Windows.Forms.Button();
            this.e_LogoSource = new System.Windows.Forms.TextBox();
            this.e_SelSourceLogo = new System.Windows.Forms.Button();
            this.e_SourceFolder = new System.Windows.Forms.TextBox();
            this.e_SelSourceFolder = new System.Windows.Forms.Button();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            this.e_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_SideOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).BeginInit();
            this.SuspendLayout();
            // 
            // e_nav_title
            // 
            this.e_nav_title.AutoSize = true;
            this.e_nav_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_title.Font = new System.Drawing.Font("Logico Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_nav_title.ForeColor = System.Drawing.Color.White;
            this.e_nav_title.Location = new System.Drawing.Point(47, 6);
            this.e_nav_title.Name = "e_nav_title";
            this.e_nav_title.Size = new System.Drawing.Size(222, 19);
            this.e_nav_title.TabIndex = 18;
            this.e_nav_title.Text = "THENAMEOFTHESOFTWARE";
            // 
            // e_nav_logo
            // 
            this.e_nav_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_logo.Image = global::Logoinprinter.Properties.Resources.logo;
            this.e_nav_logo.Location = new System.Drawing.Point(10, 1);
            this.e_nav_logo.Name = "e_nav_logo";
            this.e_nav_logo.Size = new System.Drawing.Size(30, 30);
            this.e_nav_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_logo.TabIndex = 17;
            this.e_nav_logo.TabStop = false;
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
            this.e_hider.Controls.Add(this.e_Position);
            this.e_hider.Controls.Add(this.e_Run);
            this.e_hider.Controls.Add(this.e_SideOffset);
            this.e_hider.Controls.Add(this.e_DestFolder);
            this.e_hider.Controls.Add(this.e_SetDestFolder);
            this.e_hider.Controls.Add(this.e_LogoSource);
            this.e_hider.Controls.Add(this.e_SelSourceLogo);
            this.e_hider.Controls.Add(this.e_SourceFolder);
            this.e_hider.Controls.Add(this.e_SelSourceFolder);
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(260, 132);
            this.e_hider.TabIndex = 20;
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
            this.e_Position.Location = new System.Drawing.Point(73, 97);
            this.e_Position.Name = "e_Position";
            this.e_Position.Size = new System.Drawing.Size(93, 21);
            this.e_Position.TabIndex = 9;
            // 
            // e_Run
            // 
            this.e_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_Run.Location = new System.Drawing.Point(172, 97);
            this.e_Run.Name = "e_Run";
            this.e_Run.Size = new System.Drawing.Size(70, 20);
            this.e_Run.TabIndex = 8;
            this.e_Run.Text = "Process";
            this.e_Run.UseVisualStyleBackColor = true;
            this.e_Run.Click += new System.EventHandler(this.Run);
            // 
            // e_SideOffset
            // 
            this.e_SideOffset.Location = new System.Drawing.Point(20, 97);
            this.e_SideOffset.Name = "e_SideOffset";
            this.e_SideOffset.Size = new System.Drawing.Size(47, 20);
            this.e_SideOffset.TabIndex = 6;
            // 
            // e_DestFolder
            // 
            this.e_DestFolder.Location = new System.Drawing.Point(20, 71);
            this.e_DestFolder.Name = "e_DestFolder";
            this.e_DestFolder.ReadOnly = true;
            this.e_DestFolder.Size = new System.Drawing.Size(177, 20);
            this.e_DestFolder.TabIndex = 5;
            this.e_DestFolder.Text = "No Output Folder Selected";
            // 
            // e_SetDestFolder
            // 
            this.e_SetDestFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_SetDestFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_SetDestFolder.Location = new System.Drawing.Point(207, 71);
            this.e_SetDestFolder.Name = "e_SetDestFolder";
            this.e_SetDestFolder.Size = new System.Drawing.Size(35, 20);
            this.e_SetDestFolder.TabIndex = 4;
            this.e_SetDestFolder.Text = "...";
            this.e_SetDestFolder.UseVisualStyleBackColor = true;
            this.e_SetDestFolder.Click += new System.EventHandler(this.SelDestFolder);
            // 
            // e_LogoSource
            // 
            this.e_LogoSource.Location = new System.Drawing.Point(20, 45);
            this.e_LogoSource.Name = "e_LogoSource";
            this.e_LogoSource.ReadOnly = true;
            this.e_LogoSource.Size = new System.Drawing.Size(177, 20);
            this.e_LogoSource.TabIndex = 3;
            this.e_LogoSource.Text = "No Logo Loaded";
            // 
            // e_SelSourceLogo
            // 
            this.e_SelSourceLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_SelSourceLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_SelSourceLogo.Location = new System.Drawing.Point(207, 45);
            this.e_SelSourceLogo.Name = "e_SelSourceLogo";
            this.e_SelSourceLogo.Size = new System.Drawing.Size(35, 20);
            this.e_SelSourceLogo.TabIndex = 2;
            this.e_SelSourceLogo.Text = "...";
            this.e_SelSourceLogo.UseVisualStyleBackColor = true;
            this.e_SelSourceLogo.Click += new System.EventHandler(this.SelLogoSource);
            // 
            // e_SourceFolder
            // 
            this.e_SourceFolder.Location = new System.Drawing.Point(20, 19);
            this.e_SourceFolder.Name = "e_SourceFolder";
            this.e_SourceFolder.ReadOnly = true;
            this.e_SourceFolder.Size = new System.Drawing.Size(177, 20);
            this.e_SourceFolder.TabIndex = 1;
            this.e_SourceFolder.Text = "No Images Loaded";
            // 
            // e_SelSourceFolder
            // 
            this.e_SelSourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_SelSourceFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_SelSourceFolder.Location = new System.Drawing.Point(207, 19);
            this.e_SelSourceFolder.Name = "e_SelSourceFolder";
            this.e_SelSourceFolder.Size = new System.Drawing.Size(35, 20);
            this.e_SelSourceFolder.TabIndex = 0;
            this.e_SelSourceFolder.Text = "...";
            this.e_SelSourceFolder.UseVisualStyleBackColor = true;
            this.e_SelSourceFolder.Click += new System.EventHandler(this.SelSourceFolder);
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
            this.e_nav_close.Click += new System.EventHandler(this.event_close);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(360, 509);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_hider);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDOWNAME";
            this.Activated += new System.EventHandler(this.event_focus);
            this.Deactivate += new System.EventHandler(this.event_unfocus);
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            this.e_hider.ResumeLayout(false);
            this.e_hider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_SideOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_nav_title;
        private System.Windows.Forms.PictureBox e_nav_logo;
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
    }
}