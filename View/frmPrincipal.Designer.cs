
namespace Projeto_Finch.View
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panCabecalho = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panCorpo = new System.Windows.Forms.Panel();
            this.panEventos = new System.Windows.Forms.Panel();
            this.gbEventos = new System.Windows.Forms.GroupBox();
            this.panLinha7 = new System.Windows.Forms.Panel();
            this.lbLink = new System.Windows.Forms.Label();
            this.btnCarregarProxima = new System.Windows.Forms.Button();
            this.panelLinha6 = new System.Windows.Forms.Panel();
            this.panelLinha5 = new System.Windows.Forms.Panel();
            this.panelLinha4 = new System.Windows.Forms.Panel();
            this.panelLinha3 = new System.Windows.Forms.Panel();
            this.panelLinha2 = new System.Windows.Forms.Panel();
            this.panelLinha1 = new System.Windows.Forms.Panel();
            this.lbAccessibility = new System.Windows.Forms.Label();
            this.lbChave = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbParticipants = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbActivity = new System.Windows.Forms.Label();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.txtRespostaAtividade = new System.Windows.Forms.TextBox();
            this.txtRespostaTipo = new System.Windows.Forms.TextBox();
            this.txtRespostaParticipantes = new System.Windows.Forms.TextBox();
            this.txtRespostasPrecos = new System.Windows.Forms.TextBox();
            this.txtRespostaLinks = new System.Windows.Forms.TextBox();
            this.txtRespostaChave = new System.Windows.Forms.TextBox();
            this.txtRespostaAcessibilidade = new System.Windows.Forms.TextBox();
            this.panCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panCorpo.SuspendLayout();
            this.panEventos.SuspendLayout();
            this.gbEventos.SuspendLayout();
            this.panPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCabecalho
            // 
            this.panCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panCabecalho.Controls.Add(this.btnFechar);
            this.panCabecalho.Controls.Add(this.pbLogo);
            this.panCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panCabecalho.Name = "panCabecalho";
            this.panCabecalho.Size = new System.Drawing.Size(486, 37);
            this.panCabecalho.TabIndex = 0;
            this.panCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panCabecalho_MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(451, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 26);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "X";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(72, 37);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // panCorpo
            // 
            this.panCorpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panCorpo.Controls.Add(this.panEventos);
            this.panCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCorpo.Location = new System.Drawing.Point(0, 0);
            this.panCorpo.Name = "panCorpo";
            this.panCorpo.Size = new System.Drawing.Size(486, 406);
            this.panCorpo.TabIndex = 1;
            // 
            // panEventos
            // 
            this.panEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panEventos.BackColor = System.Drawing.Color.White;
            this.panEventos.Controls.Add(this.gbEventos);
            this.panEventos.Location = new System.Drawing.Point(3, 43);
            this.panEventos.Name = "panEventos";
            this.panEventos.Size = new System.Drawing.Size(480, 360);
            this.panEventos.TabIndex = 0;
            // 
            // gbEventos
            // 
            this.gbEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEventos.Controls.Add(this.txtRespostaAcessibilidade);
            this.gbEventos.Controls.Add(this.txtRespostaChave);
            this.gbEventos.Controls.Add(this.txtRespostaLinks);
            this.gbEventos.Controls.Add(this.txtRespostasPrecos);
            this.gbEventos.Controls.Add(this.txtRespostaParticipantes);
            this.gbEventos.Controls.Add(this.txtRespostaTipo);
            this.gbEventos.Controls.Add(this.txtRespostaAtividade);
            this.gbEventos.Controls.Add(this.panLinha7);
            this.gbEventos.Controls.Add(this.lbLink);
            this.gbEventos.Controls.Add(this.btnCarregarProxima);
            this.gbEventos.Controls.Add(this.panelLinha6);
            this.gbEventos.Controls.Add(this.panelLinha5);
            this.gbEventos.Controls.Add(this.panelLinha4);
            this.gbEventos.Controls.Add(this.panelLinha3);
            this.gbEventos.Controls.Add(this.panelLinha2);
            this.gbEventos.Controls.Add(this.panelLinha1);
            this.gbEventos.Controls.Add(this.lbAccessibility);
            this.gbEventos.Controls.Add(this.lbChave);
            this.gbEventos.Controls.Add(this.lbPrice);
            this.gbEventos.Controls.Add(this.lbParticipants);
            this.gbEventos.Controls.Add(this.lbType);
            this.gbEventos.Controls.Add(this.lbActivity);
            this.gbEventos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.gbEventos.Location = new System.Drawing.Point(6, 3);
            this.gbEventos.Name = "gbEventos";
            this.gbEventos.Size = new System.Drawing.Size(468, 351);
            this.gbEventos.TabIndex = 0;
            this.gbEventos.TabStop = false;
            this.gbEventos.Text = "_eventos";
            // 
            // panLinha7
            // 
            this.panLinha7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLinha7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panLinha7.Enabled = false;
            this.panLinha7.Location = new System.Drawing.Point(6, 219);
            this.panLinha7.Name = "panLinha7";
            this.panLinha7.Size = new System.Drawing.Size(456, 1);
            this.panLinha7.TabIndex = 27;
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLink.Location = new System.Drawing.Point(6, 191);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(44, 17);
            this.lbLink.TabIndex = 25;
            this.lbLink.Text = "Link:";
            // 
            // btnCarregarProxima
            // 
            this.btnCarregarProxima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.btnCarregarProxima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregarProxima.FlatAppearance.BorderSize = 0;
            this.btnCarregarProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarProxima.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarProxima.ForeColor = System.Drawing.Color.White;
            this.btnCarregarProxima.Location = new System.Drawing.Point(140, 305);
            this.btnCarregarProxima.Name = "btnCarregarProxima";
            this.btnCarregarProxima.Size = new System.Drawing.Size(189, 40);
            this.btnCarregarProxima.TabIndex = 24;
            this.btnCarregarProxima.Text = "_carregar próxima";
            this.btnCarregarProxima.UseVisualStyleBackColor = false;
            this.btnCarregarProxima.Click += new System.EventHandler(this.btnCarregarProxima_Click);
            // 
            // panelLinha6
            // 
            this.panelLinha6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLinha6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panelLinha6.Enabled = false;
            this.panelLinha6.Location = new System.Drawing.Point(4, 295);
            this.panelLinha6.Name = "panelLinha6";
            this.panelLinha6.Size = new System.Drawing.Size(456, 1);
            this.panelLinha6.TabIndex = 16;
            // 
            // panelLinha5
            // 
            this.panelLinha5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLinha5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panelLinha5.Enabled = false;
            this.panelLinha5.Location = new System.Drawing.Point(4, 257);
            this.panelLinha5.Name = "panelLinha5";
            this.panelLinha5.Size = new System.Drawing.Size(456, 1);
            this.panelLinha5.TabIndex = 15;
            // 
            // panelLinha4
            // 
            this.panelLinha4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLinha4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panelLinha4.Enabled = false;
            this.panelLinha4.Location = new System.Drawing.Point(6, 181);
            this.panelLinha4.Name = "panelLinha4";
            this.panelLinha4.Size = new System.Drawing.Size(456, 1);
            this.panelLinha4.TabIndex = 14;
            // 
            // panelLinha3
            // 
            this.panelLinha3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLinha3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panelLinha3.Enabled = false;
            this.panelLinha3.Location = new System.Drawing.Point(6, 143);
            this.panelLinha3.Name = "panelLinha3";
            this.panelLinha3.Size = new System.Drawing.Size(456, 1);
            this.panelLinha3.TabIndex = 13;
            // 
            // panelLinha2
            // 
            this.panelLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLinha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panelLinha2.Enabled = false;
            this.panelLinha2.Location = new System.Drawing.Point(6, 108);
            this.panelLinha2.Name = "panelLinha2";
            this.panelLinha2.Size = new System.Drawing.Size(456, 1);
            this.panelLinha2.TabIndex = 12;
            // 
            // panelLinha1
            // 
            this.panelLinha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLinha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.panelLinha1.Enabled = false;
            this.panelLinha1.Location = new System.Drawing.Point(4, 70);
            this.panelLinha1.Name = "panelLinha1";
            this.panelLinha1.Size = new System.Drawing.Size(456, 1);
            this.panelLinha1.TabIndex = 11;
            // 
            // lbAccessibility
            // 
            this.lbAccessibility.AutoSize = true;
            this.lbAccessibility.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccessibility.Location = new System.Drawing.Point(6, 267);
            this.lbAccessibility.Name = "lbAccessibility";
            this.lbAccessibility.Size = new System.Drawing.Size(119, 17);
            this.lbAccessibility.TabIndex = 10;
            this.lbAccessibility.Text = "Acessibilidade:";
            // 
            // lbChave
            // 
            this.lbChave.AutoSize = true;
            this.lbChave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChave.Location = new System.Drawing.Point(6, 229);
            this.lbChave.Name = "lbChave";
            this.lbChave.Size = new System.Drawing.Size(59, 17);
            this.lbChave.TabIndex = 9;
            this.lbChave.Text = "Chave:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(6, 153);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(65, 17);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Preços:";
            // 
            // lbParticipants
            // 
            this.lbParticipants.AutoSize = true;
            this.lbParticipants.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParticipants.Location = new System.Drawing.Point(6, 115);
            this.lbParticipants.Name = "lbParticipants";
            this.lbParticipants.Size = new System.Drawing.Size(110, 17);
            this.lbParticipants.TabIndex = 7;
            this.lbParticipants.Text = "Participantes:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(6, 80);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(44, 17);
            this.lbType.TabIndex = 6;
            this.lbType.Text = "Tipo:";
            // 
            // lbActivity
            // 
            this.lbActivity.AutoSize = true;
            this.lbActivity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivity.Location = new System.Drawing.Point(6, 42);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(81, 17);
            this.lbActivity.TabIndex = 5;
            this.lbActivity.Text = "Atividade:";
            // 
            // panPrincipal
            // 
            this.panPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPrincipal.Controls.Add(this.panCabecalho);
            this.panPrincipal.Controls.Add(this.panCorpo);
            this.panPrincipal.Location = new System.Drawing.Point(3, 4);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(486, 406);
            this.panPrincipal.TabIndex = 2;
            // 
            // txtRespostaAtividade
            // 
            this.txtRespostaAtividade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtRespostaAtividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.txtRespostaAtividade.Location = new System.Drawing.Point(131, 39);
            this.txtRespostaAtividade.Name = "txtRespostaAtividade";
            this.txtRespostaAtividade.Size = new System.Drawing.Size(329, 25);
            this.txtRespostaAtividade.TabIndex = 6;
            // 
            // txtRespostaTipo
            // 
            this.txtRespostaTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtRespostaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.txtRespostaTipo.Location = new System.Drawing.Point(131, 77);
            this.txtRespostaTipo.Name = "txtRespostaTipo";
            this.txtRespostaTipo.Size = new System.Drawing.Size(329, 25);
            this.txtRespostaTipo.TabIndex = 28;
            // 
            // txtRespostaParticipantes
            // 
            this.txtRespostaParticipantes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtRespostaParticipantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.txtRespostaParticipantes.Location = new System.Drawing.Point(131, 112);
            this.txtRespostaParticipantes.Name = "txtRespostaParticipantes";
            this.txtRespostaParticipantes.Size = new System.Drawing.Size(329, 25);
            this.txtRespostaParticipantes.TabIndex = 29;
            // 
            // txtRespostasPrecos
            // 
            this.txtRespostasPrecos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtRespostasPrecos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.txtRespostasPrecos.Location = new System.Drawing.Point(131, 150);
            this.txtRespostasPrecos.Name = "txtRespostasPrecos";
            this.txtRespostasPrecos.Size = new System.Drawing.Size(329, 25);
            this.txtRespostasPrecos.TabIndex = 30;
            // 
            // txtRespostaLinks
            // 
            this.txtRespostaLinks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtRespostaLinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.txtRespostaLinks.Location = new System.Drawing.Point(131, 188);
            this.txtRespostaLinks.Name = "txtRespostaLinks";
            this.txtRespostaLinks.Size = new System.Drawing.Size(331, 25);
            this.txtRespostaLinks.TabIndex = 31;
            // 
            // txtRespostaChave
            // 
            this.txtRespostaChave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtRespostaChave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.txtRespostaChave.Location = new System.Drawing.Point(131, 226);
            this.txtRespostaChave.Name = "txtRespostaChave";
            this.txtRespostaChave.Size = new System.Drawing.Size(331, 25);
            this.txtRespostaChave.TabIndex = 32;
            // 
            // txtRespostaAcessibilidade
            // 
            this.txtRespostaAcessibilidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtRespostaAcessibilidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.txtRespostaAcessibilidade.Location = new System.Drawing.Point(131, 264);
            this.txtRespostaAcessibilidade.Name = "txtRespostaAcessibilidade";
            this.txtRespostaAcessibilidade.Size = new System.Drawing.Size(331, 25);
            this.txtRespostaAcessibilidade.TabIndex = 33;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(492, 413);
            this.Controls.Add(this.panPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panCorpo.ResumeLayout(false);
            this.panEventos.ResumeLayout(false);
            this.gbEventos.ResumeLayout(false);
            this.gbEventos.PerformLayout();
            this.panPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCabecalho;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panCorpo;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Panel panEventos;
        private System.Windows.Forms.GroupBox gbEventos;
        private System.Windows.Forms.Label lbAccessibility;
        private System.Windows.Forms.Label lbChave;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbParticipants;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbActivity;
        private System.Windows.Forms.Panel panelLinha6;
        private System.Windows.Forms.Panel panelLinha5;
        private System.Windows.Forms.Panel panelLinha4;
        private System.Windows.Forms.Panel panelLinha3;
        private System.Windows.Forms.Panel panelLinha2;
        private System.Windows.Forms.Panel panelLinha1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCarregarProxima;
        private System.Windows.Forms.Panel panLinha7;
        private System.Windows.Forms.Label lbLink;
        private System.Windows.Forms.TextBox txtRespostaAcessibilidade;
        private System.Windows.Forms.TextBox txtRespostaChave;
        private System.Windows.Forms.TextBox txtRespostaLinks;
        private System.Windows.Forms.TextBox txtRespostasPrecos;
        private System.Windows.Forms.TextBox txtRespostaParticipantes;
        private System.Windows.Forms.TextBox txtRespostaTipo;
        private System.Windows.Forms.TextBox txtRespostaAtividade;
    }
}