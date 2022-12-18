
namespace Projeto_Finch
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panLogo = new System.Windows.Forms.Panel();
            this.lbSubtitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panLogin = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLogo
            // 
            this.panLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panLogo.Controls.Add(this.lbSubtitulo);
            this.panLogo.Controls.Add(this.pbLogo);
            this.panLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLogo.Location = new System.Drawing.Point(0, 0);
            this.panLogo.Name = "panLogo";
            this.panLogo.Size = new System.Drawing.Size(315, 312);
            this.panLogo.TabIndex = 0;
            // 
            // lbSubtitulo
            // 
            this.lbSubtitulo.AutoSize = true;
            this.lbSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lbSubtitulo.Location = new System.Drawing.Point(11, 219);
            this.lbSubtitulo.Name = "lbSubtitulo";
            this.lbSubtitulo.Size = new System.Drawing.Size(297, 22);
            this.lbSubtitulo.TabIndex = 1;
            this.lbSubtitulo.Text = "_simplificando o mundo jurídico";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(73, 83);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(166, 123);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panLogin
            // 
            this.panLogin.BackColor = System.Drawing.Color.White;
            this.panLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panLogin.Controls.Add(this.btnFechar);
            this.panLogin.Controls.Add(this.txtUsu);
            this.panLogin.Controls.Add(this.label3);
            this.panLogin.Controls.Add(this.txtSenha);
            this.panLogin.Controls.Add(this.btnLogar);
            this.panLogin.Controls.Add(this.label2);
            this.panLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLogin.Location = new System.Drawing.Point(315, 0);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(314, 312);
            this.panLogin.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(265, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 26);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "X";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtUsu
            // 
            this.txtUsu.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.txtUsu.Location = new System.Drawing.Point(29, 118);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(262, 25);
            this.txtUsu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.txtSenha.Location = new System.Drawing.Point(29, 174);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(262, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.Location = new System.Drawing.Point(29, 235);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(262, 40);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "_logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 312);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panLogo.ResumeLayout(false);
            this.panLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.Label lbSubtitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFechar;
    }
}

