using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aloha
{
    class Node
    {
        public static int global_node_number = 0;
        public static int global_packet_amount = 0;
        public int packet_amount;
        public int node_number;
        public Node()
        {
            node_number = global_node_number;
            global_node_number++;
            packet_amount = 0;
        }
        public void inc_Packets()
        {
            packet_amount++;
            global_packet_amount++;
        }

        public void dec_Packets()
        {
            packet_amount--;
            global_packet_amount--;
        }
    }
}
