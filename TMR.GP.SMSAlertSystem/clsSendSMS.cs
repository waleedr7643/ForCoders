using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMR.GP.SMSAlertSystem
{
        public static class clsSendSMS
        {
            static Type gsmOutType = Type.GetTypeFromProgID("ActiveXperts.GsmOut");
            static Type gsmInType = Type.GetTypeFromProgID("ActiveXperts.GsmIn");
            static Type gsmConstantsType = Type.GetTypeFromProgID("ActiveXperts.SmsConstants");

            static dynamic objGsmOut = Activator.CreateInstance(gsmOutType);
            static dynamic objGsmIn = Activator.CreateInstance(gsmInType);
            static dynamic objConstants = Activator.CreateInstance(gsmConstantsType);
            public static bool SendSMS(string mobNbr, string msg)
            {
               
                clsSalesTransSMS salestrans = new clsSalesTransSMS();
                try
                {
                    string device = "";
                    int deviceCount = objGsmOut.GetDeviceCount();
                    if (deviceCount < 1)
                    {
                        MessageBox.Show("No Device Found");
                        salestrans.updateMSGSTATUS = false;
                        return false;
                    }
                    else
                        device = objGsmOut.GetDevice(0);
                    objGsmOut.Activate("AC11-2C93-43EA-E96DC");
                    objGsmIn.Activate("AC11-2C93-43EA-E96DC");
                    objGsmOut.Device = device;
                    objGsmOut.DeviceSpeed = 0;
                    objGsmOut.MessageRecipient = mobNbr;
                    objGsmOut.MessageData = msg;
                    objGsmOut.MessageType = objConstants.asMESSAGETYPE_UNICODE_MULTIPART;
                    objGsmOut.Send();
                    //Application.DoEvents();
                    //Application.DoEvents();                    
                    int err = objGsmOut.LastError;
                   
                    if (err == 0)
                    {
                        salestrans.updateMSGSTATUS = true;
                        return true;
                    }
                    else
                    {
                        salestrans.updateMSGSTATUS = true;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    salestrans.updateMSGSTATUS = false;
                    return false;
                }
        }
    }
}
