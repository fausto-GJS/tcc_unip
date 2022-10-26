
namespace Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ID_label = new System.Windows.Forms.Label();
            this.select_comunicacaoSerial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status_comunicacaoSerial = new System.Windows.Forms.Label();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerCheckSerial = new System.Windows.Forms.Timer(this.components);
            this.status_catraca = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_novoCadastro = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.buscaIp = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(80, 35);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(0, 13);
            this.ID_label.TabIndex = 1;
            // 
            // select_comunicacaoSerial
            // 
            this.select_comunicacaoSerial.FormattingEnabled = true;
            this.select_comunicacaoSerial.Location = new System.Drawing.Point(35, 62);
            this.select_comunicacaoSerial.Name = "select_comunicacaoSerial";
            this.select_comunicacaoSerial.Size = new System.Drawing.Size(109, 21);
            this.select_comunicacaoSerial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comunicação Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONFIGURAÇÕES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 107);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // status_comunicacaoSerial
            // 
            this.status_comunicacaoSerial.AutoSize = true;
            this.status_comunicacaoSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_comunicacaoSerial.ForeColor = System.Drawing.Color.Red;
            this.status_comunicacaoSerial.Location = new System.Drawing.Point(62, 120);
            this.status_comunicacaoSerial.Name = "status_comunicacaoSerial";
            this.status_comunicacaoSerial.Size = new System.Drawing.Size(58, 13);
            this.status_comunicacaoSerial.TabIndex = 6;
            this.status_comunicacaoSerial.Text = "OFFLINE";
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.Location = new System.Drawing.Point(35, 89);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(109, 26);
            this.btn_conectar.TabIndex = 7;
            this.btn_conectar.Text = "CONECTAR";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(7, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 139);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // timerCheckSerial
            // 
            this.timerCheckSerial.Enabled = true;
            this.timerCheckSerial.Interval = 1000;
            this.timerCheckSerial.Tick += new System.EventHandler(this.timerCheckSerial_Tick);
            // 
            // status_catraca
            // 
            this.status_catraca.AutoSize = true;
            this.status_catraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_catraca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status_catraca.Location = new System.Drawing.Point(222, 87);
            this.status_catraca.Name = "status_catraca";
            this.status_catraca.Size = new System.Drawing.Size(132, 31);
            this.status_catraca.TabIndex = 14;
            this.status_catraca.Text = "CLOSED";
            this.status_catraca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "STATUS CATRACA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Acesso\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(216, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 107);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(205, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 139);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "CENTRAL CADASTRO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 17;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(414, 35);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(143, 107);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(403, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(166, 139);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // btn_novoCadastro
            // 
            this.btn_novoCadastro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_novoCadastro.Enabled = false;
            this.btn_novoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novoCadastro.Location = new System.Drawing.Point(420, 95);
            this.btn_novoCadastro.Name = "btn_novoCadastro";
            this.btn_novoCadastro.Size = new System.Drawing.Size(132, 26);
            this.btn_novoCadastro.TabIndex = 23;
            this.btn_novoCadastro.Text = "NOVO CADASTRO";
            this.btn_novoCadastro.UseVisualStyleBackColor = false;
            this.btn_novoCadastro.Click += new System.EventHandler(this.btn_novoCadastro_Click);
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(88, 167);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(89, 13);
            this.IP.TabIndex = 24;
            this.IP.Text = "000.000.00.00";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(183, 167);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(141, 13);
            this.linkLabel.TabIndex = 25;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Acessar para cadastro facial";
            this.linkLabel.Visible = false;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // buscaIp
            // 
            this.buscaIp.BackColor = System.Drawing.SystemColors.Control;
            this.buscaIp.Enabled = false;
            this.buscaIp.Location = new System.Drawing.Point(7, 162);
            this.buscaIp.Name = "buscaIp";
            this.buscaIp.Size = new System.Drawing.Size(75, 23);
            this.buscaIp.TabIndex = 26;
            this.buscaIp.Text = "Buscar IP";
            this.buscaIp.UseVisualStyleBackColor = false;
            this.buscaIp.Click += new System.EventHandler(this.BuscarIP_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Red;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(420, 51);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(132, 26);
            this.btn_login.TabIndex = 27;
            this.btn_login.Text = "LOGIN SERVIÇO";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStatus.Enabled = false;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(415, 162);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(154, 23);
            this.btnStatus.TabIndex = 28;
            this.btnStatus.Text = "Ativar status de acesso";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Visible = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 189);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.buscaIp);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.btn_novoCadastro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.status_catraca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.status_comunicacaoSerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_comunicacaoSerial);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.ComboBox select_comunicacaoSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label status_comunicacaoSerial;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerCheckSerial;
        private System.Windows.Forms.Label status_catraca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btn_novoCadastro;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Button buscaIp;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btnStatus;
    }
}

