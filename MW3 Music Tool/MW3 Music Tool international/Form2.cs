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
            string[] lines = { "32bit", "notdefined"};
            string[] lines2 = { "64bit", "notdefined" };
            string line0 = "0", line1 = "1";


            if (File.Exists(Application.UserAppDataPath + @"\MW3-Tool.txt"))
            {
                // Read the file
                System.IO.StreamReader toolfile =
                new System.IO.StreamReader(Application.UserAppDataPath + @"\MW3-Tool.txt");
                line0 = toolfile.ReadLine();
                line1 = toolfile.ReadLine();
                toolfile.Close();
            }
            else
            {
                FileInfo FI = new FileInfo(Application.UserAppDataPath + @"\MW3-Tool.txt");
                FileStream FS = FI.Create();
                FS.Close();
                string[] lines0 = { "notdefined", "notdefined" };
                System.IO.File.WriteAllLines(Application.UserAppDataPath + @"\MW3-Tool.txt", lines0);
            }
            if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\milesEQ.flt"))
            {
                System.IO.File.WriteAllLines(Application.UserAppDataPath + @"\MW3-Tool.txt", lines);
            }
            else
            {
                if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\milesEQ.flt"))
                {

                    System.IO.File.WriteAllLines(Application.UserAppDataPath + @"\MW3-Tool.txt", lines2);
                }

                else
                {
                    if (line0 == "notdefined")
                    {
                        System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
                        objDialog.Description = "Choose the CoD MW3 Path!";
                        objDialog.SelectedPath = @"C:\";
                        DialogResult objResult = objDialog.ShowDialog(this);
                        if (objResult == DialogResult.OK)
                        {
                            string mw3path = objDialog.SelectedPath;
                            string[] lines3 = { "alreadydefined", mw3path };
                            System.IO.File.WriteAllLines(Application.UserAppDataPath + @"\MW3-Tool.txt", lines3);
                            if (File.Exists(mw3path + @"\miles\milesEQ.flt"))
                            {
                                if (File.Exists(mw3path + @"\miles\mssmp3.asi"))
                                {
                                    if (File.Exists(mw3path + @"\miles\mssmp3.bak"))
                                    {
                                        File.Delete(mw3path + @"\miles\mssmp3.bak");
                                        label2.Text = "The music is enabled!";
                                        button1.Enabled = false;
                                        button2.Enabled = true;
                                    }
                                    else
                                    {
                                        label2.Text = "The music is enabled!";
                                        button1.Enabled = false;
                                        button2.Enabled = true;
                                    }
                                }
                                else
                                {
                                    if (File.Exists(mw3path + @"\miles\mssmp3.bak"))
                                    {
                                        label2.Text = "The music is disabled!";
                                        button1.Enabled = true;
                                        button2.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error #001");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error #002 'no milesEQ.flt in there'");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Canceled!");
                            System.Windows.Forms.Application.Exit();
                        }
                    }
                    if(line1 == "alreadydefined")
                    {
                        string line2 = "0", line3 = "1";
                        System.IO.StreamReader toolfile2 =
                            new System.IO.StreamReader(Application.UserAppDataPath + @"\MW3-Tool.txt");
                        line2 = toolfile2.ReadLine();
                        line3 = toolfile2.ReadLine();
                        toolfile2.Close();

                        if (File.Exists(line3 + @"\miles\milesEQ.flt"))
                        {
                            if (File.Exists(line3 + @"\miles\mssmp3.asi"))
                            {
                                if (File.Exists(line3 + @"\miles\mssmp3.bak"))
                                {
                                    File.Delete(line3 + @"\miles\mssmp3.bak");
                                    label2.Text = "The music is enabled!";
                                    button1.Enabled = false;
                                    button2.Enabled = true;
                                }
                                else
                                {
                                    label2.Text = "The music is enabled!";
                                    button1.Enabled = false;
                                    button2.Enabled = true;
                                }
                            }
                            else
                            {
                                if (File.Exists(line3 + @"\miles\mssmp3.bak"))
                                {
                                    label2.Text = "The music is disabled!";
                                    button1.Enabled = true;
                                    button2.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Error #003");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error #004");
                        }
                    }
                }
            }
            // Read the file
            string line4 = "0", line5 = "1";
            System.IO.StreamReader toolfile3 =
                new System.IO.StreamReader(Application.UserAppDataPath + @"\MW3-Tool.txt");
            line4 = toolfile3.ReadLine();
            line5 = toolfile3.ReadLine();
            toolfile3.Close();

            if (line4 == "32bit")
            {
                try
                {
                    if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi"))
                    {
                        if(File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak"))
                        {
                        label2.Text = "The music is enabled!";
                        button1.Enabled = false;
                        button2.Enabled = true;
                        }
                        else
                        {
                        label2.Text = "The music is enabled!";
                        button1.Enabled = false;
                        button2.Enabled = true;
                        }
                    }
                    else
                    {
                        label2.Text = "The music is disabled!";
                        button1.Enabled = true;
                        button2.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Error #005");
                }
            }
            else
            {
                if (line4 == "64bit")
                {


                    try
                    {
                        if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi"))
                        {
                            if(File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak"))
                            {
                            label2.Text = "The music is enabled!";
                            button1.Enabled = false;
                            button2.Enabled = true;
                            }
                            else
                            {
                            label2.Text = "The music is enabled!";
                            button1.Enabled = false;
                            button2.Enabled = true;
                            }
                        }
                        else
                        {
                            label2.Text = "The music is disabled!";
                            button1.Enabled = true;
                            button2.Enabled = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error #006");
                    }
                }
                else
                {
                    if (line4 == "alreadydefined")
                    {
                        try
                        {
                            if (File.Exists(line5 + @"\miles\\mssmp3.asi"))
                            {
                                label2.Text = "The music is enabled!";
                                button1.Enabled = false;
                                button2.Enabled = true;
                            }
                            else
                            {
                                label2.Text = "The music is disabled!";
                                button1.Enabled = true;
                                button2.Enabled = false;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error #019");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error #016");
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string line0 = "0", line1 = "1";
            System.IO.StreamReader toolfile =
            new System.IO.StreamReader(Application.UserAppDataPath + @"\MW3-Tool.txt");
            line0 = toolfile.ReadLine();
            line1 = toolfile.ReadLine();
            toolfile.Close();
            if (line0 == "32bit")
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
                        MessageBox.Show("Error #007");
                    }
                }
                catch
                {
                    MessageBox.Show("Error #008");
                }
            }
            else
            {
                if (line0 == "64bit")
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
                            MessageBox.Show("Error #009 'Try by startyng the application as admin!'");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error #010");
                    }
                }
                else
                {
                    if (line0 == "alreadydefined")
                    {
                        if (File.Exists(line1 + "/miles/mssmp3.bak"))
                        {
                            File.Copy(line1 + @"\miles\mssmp3.bak", line1 + @"\miles\mssmp3.asi");
                            File.Delete(line1 + @"\miles\mssmp3.bak");
                            label2.Text = "The music was enabled!";
                            button1.Enabled = false;
                            button2.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Error #011");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error #012");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line0 = "0", line1 = "1";
            System.IO.StreamReader toolfile =
            new System.IO.StreamReader(Application.UserAppDataPath + @"\MW3-Tool.txt");
            line0 = toolfile.ReadLine();
            line1 = toolfile.ReadLine();
            toolfile.Close();
            if (line0 == "32bit")
            {
                try
                {
                    if (File.Exists(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi"))
                    {
                        File.Copy(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi", @"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak");
                        File.Delete(@"C:\Program Files\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi");
                        label2.Text = "The music was disabled!";
                        button1.Enabled = true;
                        button2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error #013");
                    }
                }
                catch
                {
                    MessageBox.Show("Error #014");
                }
            }
            else
            {
                if (line0 == "64bit")
                {
                    try
                    {
                        if (File.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi"))
                        {
                            File.Copy(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi", @"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.bak");
                            File.Delete(@"C:\Program Files (x86)\Steam\SteamApps\common\call of duty modern warfare 3\miles\mssmp3.asi");
                            label2.Text = "The music was disabled!";
                            button1.Enabled = true;
                            button2.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error #015");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error #016");
                    }
                }
                else
                {
                    if (line0 == "alreadydefined")
                    {
                        if (File.Exists(line1 + "/miles/mssmp3.asi"))
                        {
                            File.Copy(line1 + @"\miles\mssmp3.asi", line1 + @"\miles\mssmp3.bak");
                            File.Delete(line1 + @"\miles\mssmp3.asi");
                            label2.Text = "The music was disabled!";
                            button1.Enabled = true;
                            button2.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error #017");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error #018");
                    }
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

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
