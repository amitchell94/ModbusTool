using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace ModbusApplication
{
    class ModbusDevice
    {
        private string ipAddress;
        private int port;
        private ModbusClient modbusClient;

        ModbusDevice (string ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;

            modbusClient = new ModbusClient(ipAddress, port);
        }

        public void connect ()
        {
            modbusClient.Connect();
        }
    }
}
