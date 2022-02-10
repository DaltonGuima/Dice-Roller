namespace Dados_Dalton
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panHistorico = new System.Windows.Forms.Panel();
            this.nudTipo = new System.Windows.Forms.NumericUpDown();
            this.nudSoma = new System.Windows.Forms.NumericUpDown();
            this.cbxOrdem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbDado = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(441, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 61);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histórico";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Dados_Dalton.Properties.Resources.kisspng_reset_button_icon_restart_png_photos5_5a7588a58dcdf3_2872202215176521335808;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(414, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(169, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Role!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panHistorico
            // 
            this.panHistorico.AutoScroll = true;
            this.panHistorico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panHistorico.Location = new System.Drawing.Point(441, 69);
            this.panHistorico.Name = "panHistorico";
            this.panHistorico.Size = new System.Drawing.Size(476, 485);
            this.panHistorico.TabIndex = 18;
            // 
            // nudTipo
            // 
            this.nudTipo.BackColor = System.Drawing.SystemColors.Control;
            this.nudTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTipo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTipo.Location = new System.Drawing.Point(230, 46);
            this.nudTipo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTipo.Name = "nudTipo";
            this.nudTipo.Size = new System.Drawing.Size(70, 20);
            this.nudTipo.TabIndex = 19;
            this.nudTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTipo.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudSoma
            // 
            this.nudSoma.BackColor = System.Drawing.SystemColors.Control;
            this.nudSoma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSoma.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoma.Location = new System.Drawing.Point(236, 135);
            this.nudSoma.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSoma.Name = "nudSoma";
            this.nudSoma.Size = new System.Drawing.Size(64, 20);
            this.nudSoma.TabIndex = 21;
            // 
            // cbxOrdem
            // 
            this.cbxOrdem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrdem.FormattingEnabled = true;
            this.cbxOrdem.Items.AddRange(new object[] {
            "Ordem decrescente",
            "Ordem Natural",
            "Ordem Crescente"});
            this.cbxOrdem.Location = new System.Drawing.Point(207, 169);
            this.cbxOrdem.Name = "cbxOrdem";
            this.cbxOrdem.Size = new System.Drawing.Size(121, 21);
            this.cbxOrdem.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Selecione o dado que vai rolar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(227, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "A quantida de dados rolados:";
            // 
            // NudQuantidade
            // 
            this.NudQuantidade.BackColor = System.Drawing.SystemColors.Control;
            this.NudQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NudQuantidade.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudQuantidade.Location = new System.Drawing.Point(236, 92);
            this.NudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQuantidade.Name = "NudQuantidade";
            this.NudQuantidade.Size = new System.Drawing.Size(64, 20);
            this.NudQuantidade.TabIndex = 20;
            this.NudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Modificador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Organização dos elementos:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(432, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 517);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pcbDado
            // 
            this.pcbDado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbDado.Location = new System.Drawing.Point(116, 238);
            this.pcbDado.Name = "pcbDado";
            this.pcbDado.Size = new System.Drawing.Size(184, 151);
            this.pcbDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado.TabIndex = 23;
            this.pcbDado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 566);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbDado);
            this.Controls.Add(this.cbxOrdem);
            this.Controls.Add(this.nudSoma);
            this.Controls.Add(this.NudQuantidade);
            this.Controls.Add(this.nudTipo);
            this.Controls.Add(this.panHistorico);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panHistorico;
        private System.Windows.Forms.NumericUpDown nudTipo;
        private System.Windows.Forms.NumericUpDown nudSoma;
        private System.Windows.Forms.ComboBox cbxOrdem;
        private System.Windows.Forms.PictureBox pcbDado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

