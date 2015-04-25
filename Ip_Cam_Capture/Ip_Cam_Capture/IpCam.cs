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
using System.Net;

namespace Ip_Cam_Capture
{
    public partial class IpCam : Form
    {
      
        private bool Enable = false;
        private string Ip = "http://192.168.0.101:8080/photoaf.jpg";
        //        string Ip = @"C:\Users\Alexandar\Downloads\13028_10202673085067988_1347348774731942283_n.jpg";
   
        public IpCam()
        {
            InitializeComponent();
        }

        private void IpCam_Load(object sender, EventArgs e)
        {
            Enable = true;
        }

        private void capture_Click(object sender, EventArgs e)
        {
            if (Enable)
            {

                try
                {
                    WebRequest request = WebRequest.Create(Ip);

                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream stream = response.GetResponseStream())
                        {
                            pbMain.Image = new Bitmap(stream);
                        }
                    }
                }
                catch
                {
                    Enable = false;
                }

                return;
            }
        }  
    }
}
