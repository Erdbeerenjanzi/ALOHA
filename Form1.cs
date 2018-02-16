using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aloha
{
    public partial class ALOHA : Form
    {
        static UInt64 counter=0;
        List<Node> node_list;
        private double PROBABILITY;
        private int NODE_AMOUNT;
        private double packets_send;
        private double throughput;
        private double channelload;
        private int packets_attempts;


        public ALOHA()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            node_list       =   new List<Node>();
            throughput      = 0;
            packets_send    = 0;
            packets_attempts = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool collision = false;           
            String console_text;
            console_text = "Time: " + counter.ToString() + "\n";
            Random rnd = new Random();
            List<Node> wanting_to_send = new List<Node>();

            foreach( Node nod in node_list)
            {
                if (rnd.Next(0, (int)(1.0 / PROBABILITY)) == 0)
                    nod.inc_Packets();

                if(nod.packet_amount > 0)
                {
                    wanting_to_send.Add(nod);
                }

                console_text += nod.node_number.ToString() + ": " + nod.packet_amount.ToString() + "\n";

            }



            if (wanting_to_send.Count > 0)
            {
                if (wanting_to_send.Count == 1)          //No Collision
                {
                    wanting_to_send[0].dec_Packets();
                    packets_send++;
                }
                else
                {
                    collision = true;                   //Collision            
                }
                packets_attempts += wanting_to_send.Count;
            }

            throughput = packets_send / (double)counter;    //Calculate Throughput
            channelload = (double)packets_attempts / (double)counter;

            console_text += "Channel Load:" + channelload.ToString("0.###") + "\n";
            console_text += "Throughput:" + throughput.ToString("0.###") + "\n";
            console_text += "Global amount of packets: " + Node.global_packet_amount.ToString() +  "\n";
            if (collision)
            { console_text += "Collision occured!"; }
            out_console.Text = console_text;
            counter++;
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            PROBABILITY = Convert.ToDouble(textBox_prob.Text);
            NODE_AMOUNT = Convert.ToInt32(textBox_nodeamount.Text);

            for (int i = 0; i < NODE_AMOUNT; i++)
            {
                node_list.Add(new Node());
            }
        }
    }
}
