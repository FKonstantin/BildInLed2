using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BildInLed2
{
    public partial class Form1 : Form
    {
        private SerialPort ComPort;
        int bautRate = 0;
        Parity parity = Parity.None;
        int data = 0;
        StopBits stopBits = StopBits.One;


        public Form1()
        {
            InitializeComponent();

            btnSend.Enabled = false;
            btnClosePort.Enabled = false;

            PrepareTable();
            PrepareComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void PrepareTable()
        {
            dgLeds.ColumnCount = 8;
            dgLeds.RowCount = 8;

            for (int i = 0; i < dgLeds.RowCount; i++)
            {
                dgLeds.Columns[i].Width = 25;
            }

            dgLeds.ReadOnly = true;
            this.dgLeds.MultiSelect = false;

        }

        /// <summary>
        /// Обработчик клика по ячейке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgLeds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (dgLeds.Rows[row].Cells[col].Style.BackColor == Color.Empty)
            {
                dgLeds.Rows[row].Cells[col].Style.BackColor = Color.Green;
            }
            else
            {
                dgLeds.Rows[row].Cells[col].Style.BackColor = Color.Empty;
            }

            dgLeds.ClearSelection();
        }

        /// <summary>
        /// Обработчик кнопки "Clear"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgLeds.Rows.Count; i++)
            {
                for (int j = 0; j < dgLeds.Columns.Count; j++)
                {
                    dgLeds.Rows[i].Cells[j].Style.BackColor = Color.Empty;
                }
            }
        }

        private void PrepareComboBox()
        {
            //--- ComboBox Port
            string[] Ports = SerialPort.GetPortNames();
            cbPort.Items.AddRange(Ports);

            if (Ports.Length > 0)
            {
                cbPort.SelectedIndex = 0;
            }

            //--- ComboBox Baudrate
            cbBaudrate.Items.AddRange(new string[] { "9600", "57600", "115200" });
            cbBaudrate.SelectedIndex = 0;

            //--- ComboBox Parity
            cbParity.Items.AddRange(new string[] { "No", "Odd", "Even", "Mark", "Space" });
            cbParity.SelectedIndex = 0;

            //--- ComboBox Data
            cbData.Items.AddRange(new string[] { "5", "6", "7", "8" });
            cbData.SelectedIndex = 3;

            //--- ComboBox StopBit
            cbStopBit.Items.AddRange(new string[] { "1", "1,5", "2" });
            cbStopBit.SelectedIndex = 0;

        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            ReadComboBox();

            ComPort = new SerialPort(cbPort.SelectedItem.ToString(),
                                        bautRate,
                                        parity,
                                        data,
                                        stopBits);
            ComPort.Handshake = Handshake.None;

            try
            {
                ComPort.Open();
            }
            catch(Exception ex) 
            {
                rtbInfo.AppendText("[" + DateTime.Now.Hour + ":"
                + DateTime.Now.Minute + ":"
                + DateTime.Now.Second + "] " + cbPort.SelectedText
                + ex.Message + "\n");

                return;
            }
            

            if (ComPort.IsOpen)
            {
                SetFormPortOpen();
                rtbInfo.AppendText("[" + DateTime.Now.Hour + ":"
                    + DateTime.Now.Minute + ":"
                    + DateTime.Now.Second + "] " + cbPort.SelectedItem.ToString()
                    + " Open \n");
            }
            else
            {
                rtbInfo.AppendText("[" + DateTime.Now.Hour + ":"
                    + DateTime.Now.Minute + ":"
                    + DateTime.Now.Second + "] " + cbPort.SelectedText 
                    + " opening error! \n");
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            ComPort.Close();
            SetFormPortClose();
            rtbInfo.AppendText("[" + DateTime.Now.Hour + ":"
                    + DateTime.Now.Minute + ":"
                    + DateTime.Now.Second + "] " + "Port Close \n");
        }

        private void ReadComboBox()
        {
            //--- Bautrate
            int.TryParse(cbBaudrate.SelectedItem.ToString(), out bautRate);
            
            //--- Parity
            switch (cbParity.SelectedItem.ToString())
            {
                case "No":
                    parity = Parity.None;
                    break;

                case "Odd":
                    parity = Parity.Odd;
                    break;

                case "Even":
                    parity = Parity.Even;
                    break;

                case "Mark":
                    parity = Parity.Mark;
                    break;

                case "Space":
                    parity = Parity.Space;
                    break;

                default:
                    parity = Parity.None;
                    break;
            }

            //--- Data
            switch (cbData.SelectedItem.ToString())
            {
                case "5":
                    data = 5;
                    break;

                case "6":
                    data = 6;
                    break;

                case "7":
                    data = 7;
                    break;

                case "8":
                    data = 8;
                    break;

                default:
                    data = 8;
                    break;
            }

            //--- StopBit
            switch (cbStopBit.SelectedItem.ToString())
            {
                case "1":
                    stopBits = StopBits.One;
                    break;

                case "1,5":
                    stopBits = StopBits.OnePointFive;
                    break;

                case "2":
                    stopBits = StopBits.Two;
                    break;

                default:
                    stopBits = StopBits.One;
                    break;
            }
        }

        private void btnReScan_Click(object sender, EventArgs e)
        {
            cbPort.Items.Clear();
            cbBaudrate.Items.Clear();
            cbParity.Items.Clear();
            cbData.Items.Clear();
            cbStopBit.Items.Clear();
            PrepareComboBox();
        }

        private void SetFormPortOpen()
        {
            //--- ComboBox
            cbPort.Enabled = false;
            cbBaudrate.Enabled = false;
            cbParity.Enabled = false;
            cbData.Enabled = false;
            cbStopBit.Enabled = false;
            //--- Buttons
            btnOpenPort.Enabled = false;
            btnReScan.Enabled = false;
            btnSend.Enabled = true;
            btnClosePort.Enabled = true;
        }

        private void SetFormPortClose()
        {
            //--- ComboBox
            cbPort.Enabled = true;
            cbBaudrate.Enabled = true;
            cbParity.Enabled = true;
            cbData.Enabled = true;
            cbStopBit.Enabled = true;
            //--- Buttons
            btnOpenPort.Enabled = true;
            btnReScan.Enabled = true;
            btnSend.Enabled = false;
            btnClosePort.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] gridData = new byte[66];
            //--- Packet start label
            gridData[0] = 0x11;
            //--- Packet end label
            gridData[65] = 0x12;

            //--- Read grid data
            int counter = 0;
            for (int i = 0; i < dgLeds.Rows.Count; i++)
            {
                for (int j = 0; j < dgLeds.Columns.Count; j++)
                {
                    counter++;
                    if (dgLeds.Rows[i].Cells[j].Style.BackColor == Color.Empty)
                        gridData[counter] = 0x00;
                    else
                        gridData[counter] = 0x01;
                }
            }

            ComPort.Write(gridData, 0, 66);

            rtbInfo.AppendText("[" + DateTime.Now.Hour + ":"
                    + DateTime.Now.Minute + ":"
                    + DateTime.Now.Second + "] " 
                    + "Send data to MCU(RAW): \n");
            rtbInfo.AppendText("11 ");

            for (int i = 1; i < (gridData.Length - 1); i++)
            {
                rtbInfo.AppendText("0" + gridData[i] + " ");
            }
            rtbInfo.AppendText("12");
            rtbInfo.AppendText("\n");
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            rtbInfo.Clear();
        }
    }
}