namespace Trabalho
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_ligar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_rotacao = new System.Windows.Forms.Label();
            this.lb_torque = new System.Windows.Forms.Label();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.label_frente = new System.Windows.Forms.Label();
            this.label_fundo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_volume = new System.Windows.Forms.Label();
            this.lb_vazao = new System.Windows.Forms.Label();
            this.lb_pressao = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label_ip = new System.Windows.Forms.Label();
            this.lb_conexao = new System.Windows.Forms.Label();
            this.bt_conexao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sensor = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_sensor2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.carregarDados = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // principal
            // 
            this.principal.Controls.Add(this.tabPage1);
            this.principal.Controls.Add(this.tabPage3);
            this.principal.Controls.Add(this.tabPage2);
            this.principal.Location = new System.Drawing.Point(0, 0);
            this.principal.Name = "principal";
            this.principal.SelectedIndex = 0;
            this.principal.ShowToolTips = true;
            this.principal.Size = new System.Drawing.Size(904, 550);
            this.principal.TabIndex = 0;
            this.principal.ClientSizeChanged += new System.EventHandler(this.principal_ClientSizeChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.bt_ligar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lb_rotacao);
            this.tabPage1.Controls.Add(this.lb_torque);
            this.tabPage1.Controls.Add(this.tb_porta);
            this.tabPage1.Controls.Add(this.label_frente);
            this.tabPage1.Controls.Add(this.label_fundo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lb_volume);
            this.tabPage1.Controls.Add(this.lb_vazao);
            this.tabPage1.Controls.Add(this.lb_pressao);
            this.tabPage1.Controls.Add(this.tb_ip);
            this.tabPage1.Controls.Add(this.label_ip);
            this.tabPage1.Controls.Add(this.lb_conexao);
            this.tabPage1.Controls.Add(this.bt_conexao);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_ligar
            // 
            this.bt_ligar.Location = new System.Drawing.Point(270, 435);
            this.bt_ligar.Name = "bt_ligar";
            this.bt_ligar.Size = new System.Drawing.Size(75, 23);
            this.bt_ligar.TabIndex = 22;
            this.bt_ligar.Text = "Ligar";
            this.bt_ligar.UseVisualStyleBackColor = true;
            this.bt_ligar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(184, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rotação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(112, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Torque";
            // 
            // lb_rotacao
            // 
            this.lb_rotacao.BackColor = System.Drawing.Color.Black;
            this.lb_rotacao.ForeColor = System.Drawing.Color.Lime;
            this.lb_rotacao.Location = new System.Drawing.Point(184, 459);
            this.lb_rotacao.Name = "lb_rotacao";
            this.lb_rotacao.Size = new System.Drawing.Size(60, 20);
            this.lb_rotacao.TabIndex = 19;
            this.lb_rotacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_torque
            // 
            this.lb_torque.BackColor = System.Drawing.Color.Black;
            this.lb_torque.ForeColor = System.Drawing.Color.Lime;
            this.lb_torque.Location = new System.Drawing.Point(106, 459);
            this.lb_torque.Name = "lb_torque";
            this.lb_torque.Size = new System.Drawing.Size(60, 20);
            this.lb_torque.TabIndex = 18;
            this.lb_torque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_torque.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_porta
            // 
            this.tb_porta.Location = new System.Drawing.Point(802, 341);
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(90, 20);
            this.tb_porta.TabIndex = 15;
            this.tb_porta.Text = "10013";
            // 
            // label_frente
            // 
            this.label_frente.BackColor = System.Drawing.Color.Blue;
            this.label_frente.Location = new System.Drawing.Point(799, 200);
            this.label_frente.Name = "label_frente";
            this.label_frente.Size = new System.Drawing.Size(20, 0);
            this.label_frente.TabIndex = 14;
            // 
            // label_fundo
            // 
            this.label_fundo.BackColor = System.Drawing.Color.Gray;
            this.label_fundo.Location = new System.Drawing.Point(799, 100);
            this.label_fundo.Name = "label_fundo";
            this.label_fundo.Size = new System.Drawing.Size(20, 100);
            this.label_fundo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(761, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Porta:";
            // 
            // lb_volume
            // 
            this.lb_volume.BackColor = System.Drawing.Color.Black;
            this.lb_volume.ForeColor = System.Drawing.Color.Lime;
            this.lb_volume.Location = new System.Drawing.Point(779, 211);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(60, 20);
            this.lb_volume.TabIndex = 11;
            this.lb_volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_volume.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_vazao
            // 
            this.lb_vazao.BackColor = System.Drawing.Color.Black;
            this.lb_vazao.ForeColor = System.Drawing.Color.Lime;
            this.lb_vazao.Location = new System.Drawing.Point(436, 73);
            this.lb_vazao.Name = "lb_vazao";
            this.lb_vazao.Size = new System.Drawing.Size(60, 20);
            this.lb_vazao.TabIndex = 10;
            this.lb_vazao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_pressao
            // 
            this.lb_pressao.BackColor = System.Drawing.Color.Black;
            this.lb_pressao.ForeColor = System.Drawing.Color.Lime;
            this.lb_pressao.Location = new System.Drawing.Point(332, 73);
            this.lb_pressao.Name = "lb_pressao";
            this.lb_pressao.Size = new System.Drawing.Size(60, 20);
            this.lb_pressao.TabIndex = 9;
            this.lb_pressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(787, 314);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(105, 20);
            this.tb_ip.TabIndex = 3;
            this.tb_ip.Text = "10.15.20.17";
            this.tb_ip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.BackColor = System.Drawing.Color.Silver;
            this.label_ip.Location = new System.Drawing.Point(761, 317);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(20, 13);
            this.label_ip.TabIndex = 2;
            this.label_ip.Text = "IP:";
            // 
            // lb_conexao
            // 
            this.lb_conexao.BackColor = System.Drawing.Color.Red;
            this.lb_conexao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_conexao.Location = new System.Drawing.Point(867, 379);
            this.lb_conexao.Name = "lb_conexao";
            this.lb_conexao.Size = new System.Drawing.Size(20, 20);
            this.lb_conexao.TabIndex = 1;
            // 
            // bt_conexao
            // 
            this.bt_conexao.Location = new System.Drawing.Point(764, 376);
            this.bt_conexao.Name = "bt_conexao";
            this.bt_conexao.Size = new System.Drawing.Size(75, 23);
            this.bt_conexao.TabIndex = 0;
            this.bt_conexao.Text = "Conectar";
            this.bt_conexao.UseVisualStyleBackColor = true;
            this.bt_conexao.Click += new System.EventHandler(this.bt_conexao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cb_sensor);
            this.tabPage3.Controls.Add(this.chart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(896, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gráficos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sensor";
            // 
            // cb_sensor
            // 
            this.cb_sensor.FormattingEnabled = true;
            this.cb_sensor.Location = new System.Drawing.Point(150, 39);
            this.cb_sensor.Name = "cb_sensor";
            this.cb_sensor.Size = new System.Drawing.Size(121, 21);
            this.cb_sensor.TabIndex = 5;
            this.cb_sensor.SelectedIndexChanged += new System.EventHandler(this.cb_sensor_SelectedIndexChanged);
            this.cb_sensor.ValueMemberChanged += new System.EventHandler(this.cb_sensor_ValueMemberChanged);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.DimGray;
            this.chart2.BorderlineWidth = 3;
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(96, 115);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.BorderColor = System.Drawing.Color.Black;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.DarkRed;
            series5.LabelBorderWidth = 3;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.LabelBorderWidth = 3;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.LabelBorderWidth = 3;
            series7.Legend = "Legend1";
            series7.Name = "Series3";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(652, 392);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            title2.Name = "Title";
            this.chart2.Titles.Add(title2);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_sensor2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.carregarDados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_sensor2
            // 
            this.cb_sensor2.FormattingEnabled = true;
            this.cb_sensor2.Location = new System.Drawing.Point(668, 79);
            this.cb_sensor2.Name = "cb_sensor2";
            this.cb_sensor2.Size = new System.Drawing.Size(145, 21);
            this.cb_sensor2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(668, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(819, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(71, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            this.chart1.BorderlineWidth = 3;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(18, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series8.BorderColor = System.Drawing.Color.Black;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.DarkRed;
            series8.LabelBorderWidth = 3;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(630, 440);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // carregarDados
            // 
            this.carregarDados.Location = new System.Drawing.Point(797, 118);
            this.carregarDados.Name = "carregarDados";
            this.carregarDados.Size = new System.Drawing.Size(91, 23);
            this.carregarDados.TabIndex = 0;
            this.carregarDados.Text = "CarregarDados";
            this.carregarDados.UseVisualStyleBackColor = true;
            this.carregarDados.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 550);
            this.Controls.Add(this.principal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_conexao;
        private System.Windows.Forms.Button carregarDados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lb_conexao;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label lb_volume;
        private System.Windows.Forms.Label lb_vazao;
        private System.Windows.Forms.Label lb_pressao;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label_frente;
        private System.Windows.Forms.Label label_fundo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_porta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_rotacao;
        private System.Windows.Forms.Label lb_torque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_sensor;
        private System.Windows.Forms.Button bt_ligar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cb_sensor2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

