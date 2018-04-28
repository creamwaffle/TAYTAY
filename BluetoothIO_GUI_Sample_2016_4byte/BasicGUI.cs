// Curtin University
// Mechatronics Engineering
// Bluetooth I/O Card - Sample GUI Code

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BluetoothGUISample
{
    

    public partial class Form1 : Form
    {
        // Declare variables to store inputs and outputs.
        bool runBluetooth = true;
        bool byteRead = false;
        bool state = true;
        uint Input1 = 0;
        uint Input2 = 0;
        uint Highvalue = 0;
        uint Lowvalue = 0;
        decimal result;
        decimal a;
        byte[] Outputs = new byte[4];
        byte[] Inputs = new byte[4];
        long count;
        long count_previous = 0;
        long count_current = 0;
        const byte START = 255;
        const byte ZERO = 0;
        double degree = 0;
        double upper_deadband;
        double lower_deadband;
 
        public Form1()
        {
            // Initialize required for form controls.
            InitializeComponent();

            // Establish connection with Bluetooth IOCard
            if (runBluetooth == true)
            {
                if (!bluetooth.IsOpen)                                  // Check if the bluetooth has been connected.
                {
                    try
                    {
                        bluetooth.Open();                               //Try to connect to the bluetooth.
                    }
                    catch
                    {
                        statusBox.Enabled = false;
                        statusBox.Text ="ERROR: Failed to connect.";     //If the bluetooth does not connect return an error.
                    }
                }
            }
        }

        

        // Send a four byte message to the Arduino via serial.
        private void sendIO(byte PORT, byte DATA)
        {
            Outputs[0] = START;    //Set the first byte to the start value that indicates the beginning of the message.
            Outputs[1] = PORT;     //Set the second byte to represent the port where, Input 1 = 0, Input 2 = 1, Output 1 = 2 & Output 2 = 3. This could be enumerated to make writing code simpler... (see Arduino driver)
            Outputs[2] = DATA;  //Set the third byte to the value to be assigned to the port. This is only necessary for outputs, however it is best to assign a consistent value such as 0 for input ports.
            Outputs[3] = (byte)(START + PORT + DATA); //Calculate the checksum byte, the same calculation is performed on the Arduino side to confirm the message was received correctly.

            if (bluetooth.IsOpen)
            {
                bluetooth.Write(Outputs, 0, 4);         //Send all four bytes to the IO card.                      
            }
        }

        private void Send1_Click(object sender, EventArgs e) //Press the button to send the value to Output 1, Arduino Port A.
        {
            if (checkBox1.Checked == true)
            {
                if (OutputBox1.Value <= (decimal)1.8 && OutputBox1.Value > (decimal)0)
                {
                    OutputBox1.Value = (decimal)1.8 + (decimal)13 * (OutputBox1.Value / (decimal)14.8);
                }
                if (OutputBox1.Value == (decimal)0)
                {
                    OutputBox1.Value = 0;
                }
                if (OutputBox1.Value < (decimal)0 && OutputBox1.Value >= (decimal)-1.7)
                {

                    OutputBox1.Value = (decimal)-1.7 + (decimal)-13.1 * (OutputBox1.Value / (decimal)-14.8);
                }
            }
          
           result = (decimal)8.6 * (decimal)(OutputBox1.Value) + (decimal)128;
            int a = (Int32)result; // integerize it
            sendIO(2, (byte)a); // The value 2 indicates Output1, value for output set in OutputBox1.
            
        }

        private void Send2_Click(object sender, EventArgs e) //Press the button to send the value to Output 2, Arduino Port C.
        {
            sendIO(3, (byte)OutputBox2.Value); // The value 3 indicates Output2, value for output set in OutputBox1.
        }

        private void Get1_Click(object sender, EventArgs e) //Press the button to request value from Input 1, Arduino Port F.
        {
            sendIO(0, ZERO);  // The value 0 indicates Input 1, ZERO just maintains a fixed value for the discarded data in order to maintain a consistent package format.
        }

        private void Get2_Click(object sender, EventArgs e) //Press the button to request value from Input 1, Arduino Port K.
        {
            sendIO(1, ZERO);  // The value 1 indicates Input 2, ZERO maintains a consistent value for the message output.
        }

        private void request()
        {

            if (bluetooth.BytesToRead >= 4)  //Check that the buffer contains a full four byte package.
            {
                //statusBox.Text = "Incoming"; // A status box can be used for debugging code.
                Inputs[0] = (byte)bluetooth.ReadByte(); //Read the first byte of the package.

                if (Inputs[0] == START) //Check that the first byte is in fact the start byte.
                {
                    //statusBox.Text = "Start Accepted";

                    //Read the rest of the package.
                    Inputs[1] = (byte)bluetooth.ReadByte();
                    Inputs[2] = (byte)bluetooth.ReadByte();
                    Inputs[3] = (byte)bluetooth.ReadByte();

                    //Calculate the checksum.
                    byte checkSum = (byte)(Inputs[0] + Inputs[1] + Inputs[2]);

                    //Check that the calculated check sum matches the checksum sent with the message.
                    if (Inputs[3] == checkSum)
                    {
                        //statusBox.Text = "CheckSum Accepted";

                        //Check which port the incoming data is associated with.
                        switch (Inputs[1])
                        {
                            case 0: //Save the data to a variable and place in the textbox.
                                    //statusBox.Text = "Input1";
                                Input1 = Inputs[2];
                                //InputBox1.Text = Input1.ToString();
                                break;
                            case 1: //Save the data to a variable and place in the textbox. 
                                    //statusBox.Text = "Input2";
                                Input2 = Inputs[2];
                                // InputBox2.Text = Input2.ToString();
                                break;
                        }
                    }
                }
            }   
        }
        private void Reading()
        {
            if (bluetooth.IsOpen) //Check that a serial connection exists.
            {
                //reset active low
                //set OE low and sel low
                sendIO(3, (byte)32);

                //call request
                sendIO(1, ZERO);
                request();

                //read and store high value
                Highvalue = Input2;
                //set sel high
                sendIO(3, (byte)160);

                //call request
                sendIO(1, ZERO);
                request();

                //read and store low value
                Lowvalue = Input2;
                //set OE high
                sendIO(3, (byte)96);
            }
        }
            
        
        
        private void getIOtimer_Tick(object sender, EventArgs e) //It is best to continuously check for incoming data as handling the buffer or waiting for event is not practical in C#.
        {
            //calling reading function
            Reading();
            //combining high value and lowvalue
            count = 256 * Highvalue + Lowvalue;
            //Overflow and underflow handling
            Overflow();

            Console.WriteLine(count);

            //output to inputbox1
            Count_Box.Text = count.ToString();
            //update position chart
            Updatechart1();
            //random stuff
            degree = (count * 0.18) % 360;
            Degree_Box.Text = string.Format("{0:0.00}", degree);
        }
        
        private void statusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Degree_Box_TextChanged(object sender, EventArgs e)
        {
        
        }
        //update position vs time chart
        private void Updatechart1()
        {
            chart1.Series["Series1"].Points.AddY(count);
            //chart1.Series["Series1"].Points.AddY(gg);
        }


        //deadband detection
        private void Deadband_removal()
        {
            //stop the form timer to avoid confict
            getIOtimer.Stop();
            //checking positive vosltage 
            for (double i = 0; i < 15; i += 0.1)
            {
                result = (decimal)8.6 * (decimal)(i) + (decimal)128;
                int a = (Int32)result; // integerize it
                sendIO(2, (byte)a); // The value 2 indicates Output1, value for output set in OutputBox1.
                Reading(); //reading the decoder input
                count_current = 256 * Highvalue + Lowvalue; //convert low and high value into count
                Overflow(); //overflow and underflow handling

                //checking deadband,only the first encounter count
                if ((count_current - count_previous != 0) && (state == true))
                {
                    upper_deadband = i;
                    state = false;
                }
            }

            state = true; // change back the state to true to process the negative deadband

            //checking negarive voltage
            for (double i = 0; i > -15; i -= 0.1)
            {
                result = (decimal)8.6 * (decimal)(i) + (decimal)128;
                int a = (Int32)result; // integerize it
                sendIO(2, (byte)a); // The value 2 indicates Output1, value for output set in OutputBox1.
                Reading(); //reading the decoder input
                count_current = 256 * Highvalue + Lowvalue; //convert low and high value into count
                Overflow(); //overflow and underflow handling

                //checking deadband,only the first encounter count
                if ((count_current - count_previous != 0) && (state == true))
                {
                    lower_deadband = i;
                    state = false;
                }
            }
            //start the system timer
            getIOtimer.Start();
        }
        //overflow function
        private void Overflow()
        {
            //if current value take away the previous
            //value equal to negativ, that means the motor is running at this direction
            if (count_current - count_previous < -32000)
            {
                count = count_current + (65535 - count_previous);
            }

            //if current value take away the previous
            //value equal to negativ, that means the motor is running at the other direction
            else if (count_current - count_previous > 32000)
            {
                count = count_previous + (65535 - count_current);
            }
            //no overflow occuring
            else
            {
                count = count + count_current - count_previous;
            }
            count_previous = count_current;
        }

        private void Deadband_testing_Click(object sender, EventArgs e)
        {
            //deadband_removal();
            Deadband_removal();
            //i love my life
            //i love my life
        }

        private void OutputBox1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
