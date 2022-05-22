namespace fonction_p
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.txtlogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtmdp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnvalider = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cercle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.SuspendLayout();
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlogin.HintForeColor = System.Drawing.Color.Empty;
            this.txtlogin.HintText = "";
            this.txtlogin.isPassword = false;
            this.txtlogin.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtlogin.LineIdleColor = System.Drawing.Color.Gray;
            this.txtlogin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtlogin.LineThickness = 3;
            this.txtlogin.Location = new System.Drawing.Point(406, 139);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(326, 33);
            this.txtlogin.TabIndex = 0;
            this.txtlogin.Text = "Aa";
            this.txtlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtmdp
            // 
            this.txtmdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmdp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmdp.HintForeColor = System.Drawing.Color.White;
            this.txtmdp.HintText = "";
            this.txtmdp.isPassword = true;
            this.txtmdp.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtmdp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtmdp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtmdp.LineThickness = 3;
            this.txtmdp.Location = new System.Drawing.Point(406, 204);
            this.txtmdp.Margin = new System.Windows.Forms.Padding(4);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(326, 33);
            this.txtmdp.TabIndex = 0;
            this.txtmdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnvalider
            // 
            this.btnvalider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvalider.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnvalider.CheckedState.Parent = this.btnvalider;
            this.btnvalider.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnvalider.HoverState.Parent = this.btnvalider;
            this.btnvalider.Image = global::fonction_p.Properties.Resources.ARMOIRIE_RD_CONGO;
            this.btnvalider.ImageRotate = 0F;
            this.btnvalider.ImageSize = new System.Drawing.Size(50, 50);
            this.btnvalider.Location = new System.Drawing.Point(522, 255);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnvalider.PressedState.Parent = this.btnvalider;
            this.btnvalider.Size = new System.Drawing.Size(96, 87);
            this.btnvalider.TabIndex = 1;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(402, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "veiller vous identifier pour avoir accès";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(30, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "besoin d\'aide ?";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(20)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gestion Retraite";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(20)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(32, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fonction publique logiciel";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(33, 119);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(256, 27);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cercle
            // 
            this.cercle.Location = new System.Drawing.Point(69, 139);
            this.cercle.Name = "cercle";
            this.cercle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cercle.ShadowDecoration.Parent = this.cercle;
            this.cercle.Size = new System.Drawing.Size(159, 160);
            this.cercle.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(779, 398);
            this.Controls.Add(this.cercle);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.txtlogin);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtlogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtmdp;
        private Guna.UI2.WinForms.Guna2ImageButton btnvalider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cercle;
    }
}