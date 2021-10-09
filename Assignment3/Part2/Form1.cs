using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Device1 device1 = new Device1();

            form2.nameTextBox.Text = device1.deviceName;
            form2.prodTextBox.Text = device1.productCode.ToString();
            form2.FirmwareVersion.Text = device1.firmwareVersion.ToString();

            form2.com1.Text = device1.switchingFreq.ToString();
            form2.com2.Text = device1.startFreq.ToString();
            form2.com3.Text = device1.delayTime.ToString();
            
            //checks for error
            device1.ErrorStatus();


            //if status true
            if (device1.errorStatus)
            {
                form2.circleButton1.BackColor = Color.Crimson;
            }
            else
            {
                form2.circleButton1.BackColor = Color.White;
            }
               
            form2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Device2 device2 = new Device2();

            form2.title.Text = "Device 2";

            form2.nameTextBox.Text = device2.deviceName;
            form2.prodTextBox.Text = device2.productCode.ToString();
            form2.FirmwareVersion.Text = device2.firmwareVersion.ToString();

            form2.com1L.Text = "Actual torque";
            form2.com1.Text = device2.actualTorque.ToString();

            form2.com2L.Text = "Actual Speed";
            form2.com2.Text = device2.actualSpeed.ToString();

            form2.com3L.Text = "Actual voltage";
            form2.com3.Text = device2.actualVoltage.ToString();


            //checks for error
            device2.ErrorStatus();


            //if status true
            if (device2.errorStatus)
            {
                form2.circleButton1.BackColor = Color.Crimson;
            }
            else
            {
                form2.circleButton1.BackColor = Color.White;
            }

            form2.ShowDialog();
        }
    }
}
