using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using EasyModbus;
using System.Threading;
using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.EventStreaming;
using FireSharp.Exceptions;
using FireSharp;


namespace Trabalho
{
    public partial class Form1 : Form
    {

        ModbusClient modbus;

        List<double> datasPressao = new List<double>();
        List<double> datasVolume = new List<double>();
        List<double> datasVazao = new List<double>();
        List<double> datasRotacao = new List<double>();
        List<double> datasTorque = new List<double>();
        List<double> datasTempS = new List<double>();
        List<double> datasTempR = new List<double>();
        List<double> datasTempT = new List<double>();


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XuYErKENaz4OXJXUZiR6uGAlyOAB55J3gmGDOZxG",
            BasePath = "https://infindu-b4c31.firebaseio.com/"

        }; //Parte 3



        public Form1()
        {
            InitializeComponent();

            string[] sensores = { "Vazão", "Volume", "Pressão", "Torque", "Rotação" };
            cb_sensor.Items.AddRange(sensores);
            cb_sensor2.Items.AddRange(sensores);
        }



        private void principal_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            principal.Height = ClientSize.Height;
            principal.Width = ClientSize.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Queue<double> pointsY = new Queue<double>();
            string[] teste,aux,aux2= { };
            string minute;
            IFirebaseClient client = new FirebaseClient(config);
            
            try
            {
                for (UInt16 i = 0; i <5; i++)
                {
                    minute = Convert.ToString(Convert.ToUInt16(dateTimePicker2.Value.Minute.ToString()) + i);

                    FirebaseResponse response = client.Get(cb_sensor2.Text+"/"+dateTimePicker1.Value.Year.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker2.Value.Hour.ToString() + "/" + minute);
                    aux = response.ResultAs<String[]>();

                    foreach (string k in aux)
                    {
                        pointsY.Enqueue(Convert.ToDouble(k));

                    }
                }
               chart1.Series["Series1"].Points.DataBindY(pointsY);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erro:"+ex.Message);
            }

        }//Parte 3

        private void bt_conexao_Click(object sender, EventArgs e)
        {
            if (ValidateIPv4(tb_ip.Text))
            {
                modbus = new ModbusClient(tb_ip.Text, Convert.ToInt32(tb_porta.Text));
                modbus.ConnectionTimeout = 3000;
                try
                {
                    modbus.Connect();
                    lb_conexao.BackColor = Color.Green;
                    timer1.Enabled = Convert.ToBoolean("TRUE");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return;
                }

            }
            else
            {
                MessageBox.Show("ERROR: IP Inválido");
            }
        } //Parte 1

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }//Parte 1

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread atualizarT = new Thread(atualizar);
            atualizarT.Start();
            chart2.Series["Series3"].Enabled = false;
            chart2.Series["Series2"].Enabled = false;
            
            switch (cb_sensor.SelectedItem)
            {
                case "Pressão":
                    chart2.Titles["Title"].Text = "Pressão x Tempo";
                    chart2.Series["Series1"].LegendText = "Pressão (kgf/cm²)";
                    chart2.Series["Series1"].Points.DataBindY(datasPressao);
                    
                    break;
                case "Volume":
                    chart2.Titles["Title"].Text = "Volume x Tempo";
                    chart2.Series["Series1"].LegendText = "Volume (%)";
                    chart2.Series["Series1"].Points.DataBindY(datasVolume);
                    break;
                case "Torque":
                    chart2.Titles["Title"].Text = "Torque x Tempo";
                    chart2.Series["Series1"].LegendText = "Torque (Nm)";
                    chart2.Series["Series1"].Points.DataBindY(datasTorque);
                    break;
                case "Rotação":
                    chart2.Titles["Title"].Text = "Rotação x Tempo";
                    chart2.Series["Series1"].LegendText = "Rotação (RPM)";
                    chart2.Series["Series1"].Points.DataBindY(datasRotacao);
                    break;
                
                case "Vazão":
                    chart2.Titles["Title"].Text = "Vazão x Tempo";
                    chart2.Series["Series1"].LegendText = "Vazão (m³/h)";
                    chart2.Series["Series1"].Points.DataBindY(datasVazao);
                    break;

                default:
                    break;

            }
        }//Parte 1 e 2
        
        private void atualizar()
        {
            int[] dadopressao;
            int[] dadovazao;
            int[] dadovolume;
          int[] dadotorque;
            int[] dadorotacao;


            string tempo = "/"+DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Hour.ToString() + "/" + DateTime.Now.Minute.ToString() + "/" + DateTime.Now.Second.ToString() ;
            IFirebaseClient client = new FirebaseClient(config);

            try
            {
                //Ler os dados
                dadopressao = modbus.ReadHoldingRegisters(710, 2);
                dadovazao = modbus.ReadHoldingRegisters(712, 2);
                dadovolume = modbus.ReadHoldingRegisters(714, 2);
                dadotorque = modbus.ReadHoldingRegisters(1334, 2);
                dadorotacao = modbus.ReadHoldingRegisters(727, 2);

                //Formata os dados
                float datavolume = ModbusClient.ConvertRegistersToFloat(dadovolume, ModbusClient.RegisterOrder.LowHigh);
                float datapressao = ModbusClient.ConvertRegistersToFloat(dadopressao, ModbusClient.RegisterOrder.LowHigh);
                float datavazao = ModbusClient.ConvertRegistersToFloat(dadovazao, ModbusClient.RegisterOrder.LowHigh);
                float datatorque = ModbusClient.ConvertRegistersToFloat(dadotorque, ModbusClient.RegisterOrder.LowHigh);
                float datarotacao = ModbusClient.ConvertRegistersToFloat(dadorotacao, ModbusClient.RegisterOrder.LowHigh);


                //atualiza os label
                this.Invoke((MethodInvoker)delegate { lb_pressao.Text = datapressao.ToString() + "kgf/cm²"; });
                this.Invoke((MethodInvoker)delegate { lb_vazao.Text = datavazao.ToString() + "m³/h"; });
                this.Invoke((MethodInvoker)delegate { lb_volume.Text = datavolume.ToString() + "%"; });
                this.Invoke((MethodInvoker)delegate { lb_torque.Text = datatorque.ToString() + "Nm"; });
                this.Invoke((MethodInvoker)delegate { lb_rotacao.Text = datarotacao.ToString()+"RPM"; });

                //Barrinha do volume
                this.Invoke((MethodInvoker)delegate { label_frente.Location = new Point(799, Convert.ToInt16(100 +(100 - datavolume))); });
                this.Invoke((MethodInvoker)delegate { label_frente.Size= new Size(20, Convert.ToInt16(datavolume)); });
                

                //parte 3 gravar no banco de dados
                client.Set<String>("Vazão"+tempo, datavazao.ToString());
                client.Set<String>("Volume"+tempo , datavolume.ToString());
                client.Set<String>("Pressão"+tempo , datapressao.ToString());
                client.Set<String>("Torque"+tempo, datatorque.ToString());
                client.Set<String>("Rotação"+tempo, datarotacao.ToString());


                //Parte 2 -salva em uma lista para plotar depois
                datasPressao.Add(datapressao);
                datasVolume.Add(datavolume);
                datasVazao.Add(datavazao);
                datasRotacao.Add(datarotacao);
                datasTorque.Add(datatorque);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                timer1.Enabled = Convert.ToBoolean("FALSE");
            }


        }//Parte 1 2 3

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_sensor_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void cb_sensor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bt_ligar.Text == "Ligar")
            {
                try {
                    Thread ligarT = new Thread(ligar);
                    ligarT.Start();  //inicia a thread ligarT
                    bt_ligar.Text = "Desligar";
                }
                catch (System.Exception ex) {

                }
                
            }
            else {
                modbus.WriteSingleRegister(1316, 0);
                bt_ligar.Text = "Ligar";
            }
            
            
        }//parte 1
        private void ligar() {
            modbus.WriteSingleRegister(1324, 1); //seta o tipo de partida
            Thread.Sleep(500);
            modbus.WriteSingleRegister(1316, 1);//Liga o motor
            
        } //Parte 1
        
    }

}
