namespace AppAvaliacaoAtividade1.Formularios
{
    partial class FormInicial
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
            this.desing03 = new System.Windows.Forms.Label();
            this.desing05 = new System.Windows.Forms.Label();
            this.desing04 = new System.Windows.Forms.Label();
            this.txt_comicoes = new System.Windows.Forms.Label();
            this.cbTipoCargo = new System.Windows.Forms.ComboBox();
            this.txt_cargo = new System.Windows.Forms.Label();
            this.bt_Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desing03
            // 
            this.desing03.BackColor = System.Drawing.Color.CornflowerBlue;
            this.desing03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desing03.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desing03.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.desing03.Location = new System.Drawing.Point(80, 113);
            this.desing03.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.desing03.Name = "desing03";
            this.desing03.Size = new System.Drawing.Size(194, 356);
            this.desing03.TabIndex = 70;
            this.desing03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desing05
            // 
            this.desing05.BackColor = System.Drawing.Color.WhiteSmoke;
            this.desing05.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desing05.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desing05.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.desing05.Location = new System.Drawing.Point(106, 113);
            this.desing05.Name = "desing05";
            this.desing05.Size = new System.Drawing.Size(501, 356);
            this.desing05.TabIndex = 67;
            this.desing05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desing04
            // 
            this.desing04.BackColor = System.Drawing.SystemColors.ControlLight;
            this.desing04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desing04.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desing04.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.desing04.Location = new System.Drawing.Point(68, 103);
            this.desing04.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.desing04.Name = "desing04";
            this.desing04.Size = new System.Drawing.Size(602, 375);
            this.desing04.TabIndex = 66;
            this.desing04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_comicoes
            // 
            this.txt_comicoes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txt_comicoes.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comicoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_comicoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_comicoes.Location = new System.Drawing.Point(206, 169);
            this.txt_comicoes.Name = "txt_comicoes";
            this.txt_comicoes.Size = new System.Drawing.Size(492, 71);
            this.txt_comicoes.TabIndex = 71;
            this.txt_comicoes.Text = "Cálculo de Comissões";
            this.txt_comicoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTipoCargo
            // 
            this.cbTipoCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCargo.FormattingEnabled = true;
            this.cbTipoCargo.Items.AddRange(new object[] {
            "Vendedor Junior",
            "Vendedor Padrão",
            "Vendedor Master",
            "Supervisor de Vendas",
            "Gerente"});
            this.cbTipoCargo.Location = new System.Drawing.Point(302, 319);
            this.cbTipoCargo.Name = "cbTipoCargo";
            this.cbTipoCargo.Size = new System.Drawing.Size(275, 28);
            this.cbTipoCargo.TabIndex = 100;
            this.cbTipoCargo.SelectedIndexChanged += new System.EventHandler(this.cbTipoCargo_SelectedIndexChanged);
            // 
            // txt_cargo
            // 
            this.txt_cargo.AutoSize = true;
            this.txt_cargo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo.ForeColor = System.Drawing.Color.Black;
            this.txt_cargo.Location = new System.Drawing.Point(297, 291);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(221, 25);
            this.txt_cargo.TabIndex = 99;
            this.txt_cargo.Text = "Selecione o seu Cargo:";
            // 
            // bt_Entrar
            // 
            this.bt_Entrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Entrar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Entrar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Entrar.Location = new System.Drawing.Point(464, 410);
            this.bt_Entrar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Entrar.Name = "bt_Entrar";
            this.bt_Entrar.Size = new System.Drawing.Size(113, 33);
            this.bt_Entrar.TabIndex = 101;
            this.bt_Entrar.Text = "Entrar";
            this.bt_Entrar.UseVisualStyleBackColor = false;
            this.bt_Entrar.Click += new System.EventHandler(this.bt_Entrar_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 582);
            this.Controls.Add(this.bt_Entrar);
            this.Controls.Add(this.cbTipoCargo);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.txt_comicoes);
            this.Controls.Add(this.desing03);
            this.Controls.Add(this.desing05);
            this.Controls.Add(this.desing04);
            this.Name = "FormInicial";
            this.Text = "Form_atvidade1";
            this.Load += new System.EventHandler(this.Form_atvidade1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desing03;
        private System.Windows.Forms.Label desing05;
        private System.Windows.Forms.Label desing04;
        private System.Windows.Forms.Label txt_comicoes;
        private System.Windows.Forms.ComboBox cbTipoCargo;
        private System.Windows.Forms.Label txt_cargo;
        private System.Windows.Forms.Button bt_Entrar;
    }
}