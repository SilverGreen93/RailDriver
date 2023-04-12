using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;  //in order to use DllImport 

namespace TrainSim_RailDriverdll_Sample
{
    public partial class Form1 : Form
    {
        List<int> ids;
        List<string> descriptions;
        List<float> mins;
        List<float> maxs;
        List<float> currents;

        Label[] lblids = new Label[500]; //?? max number of control ids ??
        Label[] lbldescriptions = new Label[500];
        Label[] lblmins = new Label[500];
        Label[] lblmaxs = new Label[500];
        Label[] lblcurrents = new Label[500];

        //RailDriver.dll import
        //string Locationdll = "C:\\Program Files\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll";
        //Note add <PlatformTarget>x86</PlatformTarget> to the .csproj file!!

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern void SetRailDriverConnected(bool isConnected);

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        private static extern bool GetRailSimConnected();

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern void SetRailSimValue(int controlID, float value);

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern float GetRailSimValue(int controlID, int type);

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern Boolean GetRailSimLocoChanged();

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern Boolean GetRailSimCombinedThrottleBrake();

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern string GetLocoName();

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern string GetControllerList();

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern float GetControllerValue(int controlID, int type);

        [DllImport("C:\\Program Files (x86)\\Steam\\steamapps\\common\\railworks\\plugins\\RailDriver.dll")]
        static extern void SetControllerValue(int controlID, float value);
        
        public Form1()
        {
            InitializeComponent();
            ids = new List<int>();
            descriptions = new List<string>();
            maxs = new List<float>();
            mins = new List<float>();
            currents = new List<float>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetRailDriverConnected(true);
        }

        private void BtnGetLocoName_Click(object sender, EventArgs e)
        {
            LblLocoName.Text = GetLocoName();
            
        }

        private void BtnGetControllerList_Click(object sender, EventArgs e)
        {
            string controllerlist = GetControllerList();
            string delimit = "::";
            string temp = controllerlist;
            int cnt1 = 0;
            while (temp.Length > 0)
            {
                int pos = temp.IndexOf(delimit);
                if (pos != -1)
                {
                    temp = temp.Remove(0, pos + 2);
                    cnt1++;
                }
                else break;
            }
            //number of controllers cnt1+1
            //int rowCount = dataGridView1.Rows.Count;
            //while (dataGridView1.Rows.Count > 1)
            //{
            //    dataGridView1.Rows.RemoveAt(0);
            //}
            ids.Clear();
            mins.Clear();
            maxs.Clear();
            descriptions.Clear();
            currents.Clear();
            int cnt = 0;
            while (controllerlist.Length > 0)
            {
                int pos = controllerlist.IndexOf(delimit);
                if (pos != -1)
                {
                    //dataGridView1.Rows.Add();
                    //dataGridView1[0, cnt].Value = cnt;
                    //dataGridView1[1, cnt].Value = controllerlist.Substring(0, pos);
                    ////listBox2.Items.Add(cnt.ToString() + "=" + controllerlist.Substring(0, pos));
                    descriptions.Add(controllerlist.Substring(0, pos));
                    controllerlist = controllerlist.Remove(0, pos + 2);
                    ////get vals
                    //int cid = System.Convert.ToInt32(cnt);
                    float retval2 = GetControllerValue(cnt, 0);
                    currents.Add(retval2);
                    //dataGridView1[4, cnt].Value= retval2.ToString();
                    retval2 = GetControllerValue(cnt, 1);
                    mins.Add(retval2);
                    //dataGridView1[2, cnt].Value=retval2.ToString();
                    retval2 = GetControllerValue(cnt, 2);
                    maxs.Add(retval2);
                    //dataGridView1[3, cnt].Value = retval2.ToString();
                    ids.Add(cnt);

                    cnt++;
                }
                else break;
            }
           //add last one
            descriptions.Add(controllerlist.Trim());
            float retval3 = GetControllerValue(cnt, 0);
            currents.Add(retval3);
            //dataGridView1[4, cnt].Value= retval2.ToString();
            retval3 = GetControllerValue(cnt, 1);
            mins.Add(retval3);
            //dataGridView1[2, cnt].Value=retval2.ToString();
            retval3 = GetControllerValue(cnt, 2);
            maxs.Add(retval3);
            ids.Add(cnt);



            int top = BtnGetControllerList.Top + BtnGetControllerList.Height +30;
            for (int i = 0; i < ids.Count; i++)
            {
                lblids[i] = new Label();
                lbldescriptions[i] = new Label();
                lblmaxs[i] = new Label();
                lblmins[i] = new Label();
                lblcurrents[i] = new Label();
                
                lblids[i].Text = ids[i].ToString();
                lbldescriptions[i].Text = descriptions[i];
                lblmins[i].Text = mins[i].ToString();
                lblmaxs[i].Text = maxs[i].ToString();
                lblcurrents[i].Text = currents[i].ToString();

                int w1 = 25;
                int w2 = 175;
                int w3 = 65;
                int w4 = 65;
                int w5 = 80;

                lblids[i].Width = w1;
                lbldescriptions[i].Width = w2;
                lblmins[i].Width = w3;
                lblmaxs[i].Width = w4;
                lblcurrents[i].Width = w5;

                lblids[i].Height = 13;
                lbldescriptions[i].Height = 13;
                lblmins[i].Height = 13;
                lblmaxs[i].Height = 13;
                lblcurrents[i].Height = 13;

                lblids[i].Left = BtnGetControllerList.Left;
                lbldescriptions[i].Left = lblids[i].Left + w1;
                lblmins[i].Left = lblids[i].Left + w1+w2;
                lblmaxs[i].Left = lblids[i].Left + w1+w2+w3;
                lblcurrents[i].Left = lblids[i].Left + w1+w2+w3+w4;

                if (i == 0)
                {
                    lblids[i].Top = top;
                }
                else
                {
                    lblids[i].Top = lblids[i - 1].Top + 12;
                }
                lbldescriptions[i].Top = lblids[i].Top;
                lblmins[i].Top = lblids[i].Top;
                lblmaxs[i].Top = lblids[i].Top;
                lblcurrents[i].Top = lblids[i].Top;

                lblids[i].Visible = true;
                lbldescriptions[i].Visible = true;
                lblmins[i].Visible = true;
                lblmaxs[i].Visible = true;
                lblcurrents[i].Visible = true;

                this.Controls.Add(lblids[i]);
                this.Controls.Add(lbldescriptions[i]);
                this.Controls.Add(lblmins[i]);
                this.Controls.Add(lblmaxs[i]);
                this.Controls.Add(lblcurrents[i]);
            }
            LblID.Left = lblids[0].Left;
            LblDescription.Left = lbldescriptions[0].Left;
            LblMin.Left = lblmins[0].Left;
            LblMax.Left = lblmaxs[0].Left;
            LblCurrent.Left = lblcurrents[0].Left;
            int stop = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cid = System.Convert.ToInt32(TxtControlID.Text);
            float val = (float)System.Convert.ToDouble(TxtValue.Text);
            //SetRailSimValue(cid, val); //doesn't work anymore
            SetControllerValue(cid, val);
            //refresh the list 
            RefreshVals();
        }
        private void RefreshVals()
        {
            int thiscnt = lblids.Count();
            for (int i = 0; i < lblids.Count(); i++)
            {
                if (lblids[i]!=null)
                {
                    float retval2 = GetControllerValue(i, 0);
                    lblcurrents[i].Text = retval2.ToString();
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshVals();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
