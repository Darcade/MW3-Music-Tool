//Copyright (C) 2012 Darcade <darcade@darcade.de>
//Project website: http://exe.darcade.de, http://darcade.de
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //bool musikstatus = false;
            //true bedeutet Musik ist an false sie ist aus

            bool systembitstatus = false;
            //false bedeutet System ist 32 bit true es ist 64 bit

            if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\milesEQ.flt"))
            //Es wird gekuckt ,ob das Betriebssystem 32 bit ist
            {
                systembitstatus = false;
            }
            else
            {
                if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\milesEQ.flt"))
                {
                    systembitstatus = true;

                }
            }
            if (systembitstatus == false)
            {
                try
                {
                    if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi"))
                    {
                        label2.Text = "The music ist enabled!";
                        button1.Enabled = false;
                        button2.Enabled = true;
                    }
                    else
                    {
                        label2.Text = "The music ist disabled!";
                        button1.Enabled = true;
                        button2.Enabled = false;
                    }
                }
                catch
                {
                    label2.Text = "Error #001";
                }
            }
            else
            {
                try
                {
                    if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi"))
                    {
                        label2.Text = "The music ist enabled!";
                        button1.Enabled = false;
                        button2.Enabled = true;
                    }
                    else
                    {
                        label2.Text = "The music ist disabled!";
                        button1.Enabled = true;
                        button2.Enabled = false;
                    }
                }
                catch
                {
                    label2.Text = "Error #002";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool systembitstatus = false;
            //false bedeutet System ist 32 bit true es ist 64 bit

            if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\milesEQ.flt"))
            //Es wird gekuckt ,ob das Betriebssystem 32 bit ist
            {
                systembitstatus = false;
            }
            else
            {
                if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\milesEQ.flt"))
                {
                    systembitstatus = true;

                }
            }
            if (systembitstatus == false)
            {
                try
                {
                    if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak"))
                    {
                        File.Copy(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak", @"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi");
                        File.Delete(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak");
                        label2.Text = "The music was enabled!";
                        button1.Enabled = false;
                        button2.Enabled = true;
                    }
                    else
                    {
                        label2.Text = "Error #003";
                    }
                }
                catch
                {
                    label2.Text = "Error #004";
                }
            }
            else
            {
                try
                {
                    if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak"))
                    {
                        File.Copy(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak", @"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi");
                        File.Delete(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak");
                        label2.Text = "The music was enabled!";
                        button1.Enabled = false;
                        button2.Enabled = true;
                    }
                    else
                    {
                        label2.Text = "Error #005";
                    }
                }
                catch
                {
                    label2.Text = "Error #006";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool systembitstatus = false;
            //false bedeutet System ist 32 bit true es ist 64 bit

            if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\milesEQ.flt"))
            //Es wird gekuckt ,ob das Betriebssystem 32 bit ist
            {
                systembitstatus = false;
            }
            else
            {
                if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\milesEQ.flt"))
                {
                    systembitstatus = true;

                }
            }
            if (systembitstatus == false)
            {
                try
                {
                    if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi"))
                    {
                        try
                        {
                            File.Copy(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi", @"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak");
                            File.Delete(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi");
                        }
                        catch { label2.Text = "Error #012"; }
                        label2.Text = "The music was disabled!";
                        button1.Enabled = true;
                        button2.Enabled = false;
                    }
                    else
                    {
                        label2.Text = "Error #007";
                    }
                }
                catch
                {
                    label2.Text = "Error #008";
                }
            }
            else
            {
                try
                {
                    if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi"))
                    {
                        try
                        {
                            File.Copy(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi", @"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak");
                            File.Delete(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi");
                        }
                        catch { label2.Text = "Error #013"; }
                        label2.Text = "The music was disabled!";
                        button1.Enabled = true;
                        button2.Enabled = false;
                    }
                    else
                    {
                        label2.Text = "Error #009";
                    }
                }
                catch
                {
                    label2.Text = "Error #010";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://exe.darcade.de");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://darcade.de");
        }
    }
}
