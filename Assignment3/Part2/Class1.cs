using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IError
    {
        void ErrorStatus();
    }
    class Device
    {
        public string deviceName { get; set; }
        public int productCode { get; set; }

        public float firmwareVersion { get; set; }
        
        public bool  errorStatus { get; set; }
    }

    class Device1 : Device,IError
    {
        public int switchingFreq { get; set; }
        public int startFreq { get; set; }
        public int delayTime { get; set; }

      public  Device1()
      {
          //inherited property
          this.deviceName = "Motor";
          this.productCode = 2342;
          this.firmwareVersion = 5.4f;
          this.errorStatus = false;

            //own property
          this.switchingFreq =300 ;
          this.startFreq =50 ;
          this.delayTime = 15;
         
      }

      //Error led for device 1
      public void ErrorStatus()
      {
           //Start frequency > 250 Hz and Switching frequency > 500 Hz. 
          if (startFreq > 250 || switchingFreq > 500)
          {
              errorStatus = true;
          }
          else
          {
              errorStatus = false;
          }
      }
    }

    class Device2 : Device,IError
    {
        public int actualTorque { get; set; }
        public int actualSpeed { get; set; }
        public int actualVoltage { get; set; }

        public Device2()
        {
            //inhereted property
            this.deviceName = "Drive";
            this.productCode =532 ;
            this.firmwareVersion = 3.4f;
            this.errorStatus = false;

            //own property
            this.actualTorque = 43;
            this.actualSpeed = 6000;
            this.actualVoltage = 20;
        }

        //Error led for device 2
        public void ErrorStatus()
        {
            //Actual voltage > 25 V and -5000 rpm > Actual speed > 5000 rpm 

            if (actualVoltage > 25 || ((-5000 < actualSpeed) && (actualSpeed < 5000)))
            {
                errorStatus = true;
            }
            else
            {
                errorStatus = false;
            }
        }
    }
}
