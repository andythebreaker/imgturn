using CefSharp;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgturn
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();
        private Bitmap Dimg = null; 
   
       
public Form1()
        {
            InitializeComponent();
           var aass= System.Reflection.Assembly.GetExecutingAssembly();
            Dimg = new Bitmap(aass.GetManifestResourceStream("imgturn.Image1.jpg"));
        }
        //Process p = new Process();
        public List<string> aaff = new List<string>();
        public List<string> aaff2 = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<string> alljpgsie = Directory.EnumerateFiles(textBox1.Text, "*.jpg");
            int tmp_count = 0;
            checkedListBox1.Items.Clear();
            aaff.Clear();
            foreach (string item in alljpgsie)
            {
                tmp_count++;
                aaff.Add(item);
                checkedListBox1.Items.Add(Path.GetFileName(item));
            }
                label1.Text = tmp_count.ToString();
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            trigN();
        }

        public void trigN() {
            load_out_dir();
            countDIFF();
            toolStripStatusLabel1.Text = checkedListBox1.SelectedItem.ToString();
            toolStripStatusLabel2.Text = checkedListBox1.SelectedIndex.ToString();
            pictureBox1.Image = Image.FromFile(aaff[checkedListBox1.SelectedIndex]);
            var imageSize = pictureBox1.Image.Size;
            var fitSize = pictureBox1.ClientSize;
            pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            private_void_cHROMEToolStripMenuItem_Click_object_sender_EventArgs_e();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DialogResult Result = MessageBox.Show("歡迎來到C#世界........", "你好 老套但是不會膩顯示", MessageBoxButtons.OKCancel);

            if (Result == DialogResult.OK)
            {
                MessageBox.Show("按下OK", "有回傳值顯示");
            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("按下Cancel", "有回傳值顯示");
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* p.StartInfo.FileName = "cmd.exe";
             p.StartInfo.UseShellExecute = false;
             p.StartInfo.RedirectStandardInput = true;
             p.StartInfo.RedirectStandardOutput = true;
             p.StartInfo.RedirectStandardError = true;
             p.StartInfo.CreateNoWindow = false; //不跳出cmd視窗
             p.Start();
             p.StandardInput.WriteLine("magick "+ aaff[checkedListBox1.SelectedIndex]+ "-rotate 25 "+ aaff[checkedListBox1.SelectedIndex]);//磁碟管理
             p.Close();*/
            /*  System.Diagnostics.Process p = new System.Diagnostics.Process();
              p.StartInfo.FileName = "cmd.exe";
              p.StartInfo.Arguments = @"/c dir";
              p.StartInfo.UseShellExecute = false;
              p.StartInfo.RedirectStandardInput = true;
              p.StartInfo.RedirectStandardOutput = true;
              p.StartInfo.RedirectStandardError = true;
              p.StartInfo.CreateNoWindow = true;
              p.Start();*/
            /* Process process = new Process();
             process.StartInfo.FileName = "cmd.exe";
             process.StartInfo.RedirectStandardOutput = false;
             process.StartInfo.RedirectStandardInput = true;
             process.StartInfo.UseShellExecute = true;
             process.StartInfo.Verb = "runas /profile /user:s2000";
             process.Start();
             process.StandardInput.WriteLine(@"magick " + aaff[checkedListBox1.SelectedIndex] + " -rotate 25 " + aaff[checkedListBox1.SelectedIndex]);
             process.WaitForExit();
             process.Close();*/
            /*   Process process = new System.Diagnostics.Process();
               ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
               startInfo.WindowStyle = ProcessWindowStyle.Hidden;
               startInfo.FileName = "cmd.exe";
               startInfo.Arguments = "runas /profile /user:s2000 '"+"magick " + aaff[checkedListBox1.SelectedIndex] + " - rotate 25 " + textBox1.Text + '\\' + "222.jpg" + "'";
    process.StartInfo = startInfo;
               process.Start();*/
            // Read image from file
            /* MagickReadSettings settings = new MagickReadSettings();
             // Set define that tells the jpeg coder that the output image will be 32x32
             settings.SetDefine(MagickFormat.Jpeg, "rotate", "25");
             MagickImage image = new MagickImage(aaff[checkedListBox1.SelectedIndex]);

                // image.Settings.SetDefine(MagickFormat.Dds, "rotate", "25");
                 // Write the image
                 image.Write(textBox1.Text+'\\'+"222.jpg");*/
            //string rrr = RandomString(10);
            /* pictureBox1.Image = Dimg;
             var imageSize = pictureBox1.Image.Size;
             var fitSize = pictureBox1.ClientSize;
             pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                 PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;*/
            mainps("");
            //ExecuteCommand("magick " + aaff[checkedListBox1.SelectedIndex] + " -rotate 25 " + aaff[checkedListBox1.SelectedIndex]);
            ExecuteCommand("magick " + aaff[checkedListBox1.SelectedIndex] + " -rotate 25 " + textBox2.Text+'\\'+ toolStripStatusLabel1);
            /* ExecuteCommand("magick " + aaff[checkedListBox1.SelectedIndex] + " -rotate 25 " + textBox1.Text + '\\' + rrr+".jpg");
              ExecuteCommand("del " + aaff[checkedListBox1.SelectedIndex]);
              ExecuteCommand("move " + textBox1.Text + '\\' + rrr + ".jpg " + aaff[checkedListBox1.SelectedIndex]);
              ExecuteCommand("del " + textBox1.Text + '\\' + rrr + ".jpg");*/

            mainps(aaff[checkedListBox1.SelectedIndex]);
            pictureBox2.Image = Image.FromFile(textBox2.Text + '\\' + toolStripStatusLabel1);
            var imageSize = pictureBox2.Image.Size;
            var fitSize = pictureBox2.ClientSize;
            pictureBox2.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }
        static void ExecuteCommand(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            process.Close();
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_out_dir();
        }

        public void load_out_dir() {
            IEnumerable<string> alljpgsie = Directory.EnumerateFiles(textBox2.Text, "*.jpg");
            int tmp_count = 0;
            checkedListBox2.Items.Clear();
            aaff2.Clear();
            foreach (string item in alljpgsie)
            {
                tmp_count++;
                aaff2.Add(item);
                checkedListBox2.Items.Add(Path.GetFileName(item));
            }
            label4.Text = tmp_count.ToString();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void mainps(string pa) {
            if (pa == "") {
            pictureBox1.Image = Dimg;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(pa);
            }
            var imageSize = pictureBox1.Image.Size;
            var fitSize = pictureBox1.ClientSize;
            pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        public void mainps2(string pa)
        {
            if (pa == "")
            {
                pictureBox2.Image = Dimg;
            }
            else
            {
                pictureBox2.Image = Image.FromFile(pa);
            }
            var imageSize = pictureBox2.Image.Size;
            var fitSize = pictureBox2.ClientSize;
            pictureBox2.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        private void 瀏覽器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*   webBrowser1.DocumentText =
       "<html><head></head><body>Please enter your name:<br/><style>.frame {  height: 160px;  width: 160px;  position: relative; }\n img {   max-height: 100%;  max-width: 100%;  width: auto;height: auto;position: absolute;   top: 0;      bottom: 0;      left: 0;      right: 0;      margin: auto;}</style><div class=\"frame\">" +
       "<img src=\"data:image/png;base64," + ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg) + "\" />" +
       "</div><a href='http://www.microsoft.com'>continue</a>" +
       "</body></html>";*/
            webBrowser1.DocumentText =
"<html><head></head><body>Please enter your name:<br/><div class=\"frame\">" +
"<img width=\"300\" height=\"300\" src=\"data:image/png;base64," + ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg) + "\" />" +
"</div><h3>continue</h3>" +
"<button style=\"background:#3630a3;color:white;\" " +
    "    onclick=\"var div = document.getElementsByTagName('img')[0];div.style.webkitTransform = 'rotate('+5+'deg)'; div.style.mozTransform = 'rotate(' + 5 + 'deg)';div.style.msTransform = 'rotate(' + 5 + 'deg)';div.style.oTransform = 'rotate(' + 5 + 'deg)';div.style.transform = 'rotate(' + 5 + 'deg)'; \">" +
   "     Save</button>" +
"<button style=\"background:#3630a3;color:white;\" " +
    "    onclick=\"alert('Action cancelled.')\" >" +
     "   Cancel </button>" +
"</body></html>";//作廢
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to base 64 string
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void cHROMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            private_void_cHROMEToolStripMenuItem_Click_object_sender_EventArgs_e();
        }

        public void private_void_cHROMEToolStripMenuItem_Click_object_sender_EventArgs_e() {
            //chromiumWebBrowser1.LoadUrl("https://stackoverflow.com/questions/27659086/cefsharp-loadhtml");
            /* string htmlIN =
  "<html><head><style>.frame {  height: 160px;  width: 160px;  position: relative; }\n img {   max-height: 100%;  max-width: 100%;  width: auto;height: auto;position: absolute;   top: 0;      bottom: 0;      left: 0;      right: 0;      margin: auto;}</style></head><body>aspect ratio compression<br/><div class=\"frame\">" +
  "<img width=\""+numericUpDown2.Value.ToString()+"\" height=\""+ numericUpDown1.Value.ToString() + "\" src=\"data:image/png;base64," + ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg) + "\" />" +
  "</div><h3 id=\"ctrdeg\">0</h3>" +
  "<button style=\"background:#3630a3;color:white;\" " +
      "    onclick=\"var div = document.getElementsByTagName('img')[0];div.style.webkitTransform = 'rotate('+(parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString()+'deg)'; div.style.mozTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString() + 'deg)';div.style.msTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString() + 'deg)';div.style.oTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString() + 'deg)';div.style.transform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString() + 'deg)'; document.getElementById('ctrdeg').innerText=(parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString()\">" +
     "     &#10136;</button>" +
  "<button style=\"background:#3630a3;color:white;\" " +
     "    onclick=\"var div = document.getElementsByTagName('img')[0];div.style.webkitTransform = 'rotate('+(parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString()+'deg)'; div.style.mozTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString() + 'deg)';div.style.msTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString() + 'deg)';div.style.oTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString() + 'deg)';div.style.transform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString() + 'deg)'; document.getElementById('ctrdeg').innerText=(parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString()\">" +
       "   &#8601; </button>" +
  "</body></html>";*/

             string htmlIN =
"<html><head><style>.frame {  height: " + numericUpDown1.Value.ToString() + "px;  width: " + numericUpDown2.Value.ToString() + "px;  position: relative; }\n img {   max-height: 100%;  max-width: 100%;  width: auto;height: auto;position: absolute;   top: 0;      bottom: 0;      left: 0;      right: 0;      margin: auto;}</style></head><body>aspect ratio compression<br/><div class=\"frame\">" +
"<img src=\"data:image/png;base64," + ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg) + "\" />" +
"</div><h3 id=\"ctrdeg\">0</h3>" +
"<button style=\"background:#3630a3;color:white;\" " +
   "    onclick=\"var div = document.getElementsByTagName('img')[0];div.style.webkitTransform = 'rotate('+(parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString()+'deg)'; div.style.mozTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString() + 'deg)';div.style.msTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString() + 'deg)';div.style.oTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString() + 'deg)';div.style.transform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString() + 'deg)'; document.getElementById('ctrdeg').innerText=(parseInt(document.getElementById('ctrdeg').innerText,10)+5).toString()\">" +
  "     &#10136;</button>" +
"<button style=\"background:#3630a3;color:white;\" " +
  "    onclick=\"var div = document.getElementsByTagName('img')[0];div.style.webkitTransform = 'rotate('+(parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString()+'deg)'; div.style.mozTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString() + 'deg)';div.style.msTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString() + 'deg)';div.style.oTransform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString() + 'deg)';div.style.transform = 'rotate(' + (parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString() + 'deg)'; document.getElementById('ctrdeg').innerText=(parseInt(document.getElementById('ctrdeg').innerText,10)-5).toString()\">" +
    "   &#8601; </button>" +
"</body></html>";
            var base64EncodedHtml = Convert.ToBase64String(Encoding.UTF8.GetBytes(htmlIN));
            chromiumWebBrowser1.Load("data:text/html;base64," + base64EncodedHtml);
        }

        private void button4_ClickAsync(object sender, EventArgs e)
        {
            OUTPUTF();


        }

        public void OUTPUTF() {
            string textBox2_Text = textBox2.Text;
            int checkedListBox1_SelectedIndex = checkedListBox1.SelectedIndex;
            string script = string.Format("document.getElementById('ctrdeg').innerText;");
            chromiumWebBrowser1.EvaluateScriptAsync(script).ContinueWith(x =>
            {

                var response = x.Result;

                if (response.Success && response.Result != null)
                {
                    var startDate = response.Result;
                    //startDate is the value of a HTML element.

                    /* DialogResult Result = MessageBox.Show("歡迎來到C#世界........", "你好 老套但是不會膩顯示", MessageBoxButtons.OKCancel);

                     if (Result == DialogResult.OK)
                     {
                         MessageBox.Show(startDate.ToString());
                     }
                     else if (Result == DialogResult.Cancel)
                     {
                         MessageBox.Show(startDate.ToString());
                     }
                    */

                    mainps("");
                    ExecuteCommand("magick " + aaff[checkedListBox1_SelectedIndex] + " -rotate " + startDate.ToString() + " " + textBox2_Text + '\\' + toolStripStatusLabel1);
                    mainps(aaff[checkedListBox1_SelectedIndex]);
                    mainps2(textBox2_Text + '\\' + toolStripStatusLabel1);
                }
            });
        }

        public void NEXTSEL()
        {
            checkedListBox1.Invoke((Action)delegate
             {
                 if (checkedListBox1.SelectedIndex < checkedListBox1.Items.Count - 1)
                 {
                     checkedListBox1.SelectedIndex = checkedListBox1.SelectedIndex + 1;
                 }
             });
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string textBox2_Text = textBox2.Text;
            int checkedListBox1_SelectedIndex = checkedListBox1.SelectedIndex;
            string script = string.Format("document.getElementById('ctrdeg').innerText;");
            chromiumWebBrowser1.EvaluateScriptAsync(script).ContinueWith(x =>
            {

                var response = x.Result;

                if (response.Success && response.Result != null)
                {
                    var startDate = response.Result;
                    //startDate is the value of a HTML element.

                    /* DialogResult Result = MessageBox.Show("歡迎來到C#世界........", "你好 老套但是不會膩顯示", MessageBoxButtons.OKCancel);

                     if (Result == DialogResult.OK)
                     {
                         MessageBox.Show(startDate.ToString());
                     }
                     else if (Result == DialogResult.Cancel)
                     {
                         MessageBox.Show(startDate.ToString());
                     }
                    */

                    mainps("");
                    ExecuteCommand("magick " + aaff[checkedListBox1_SelectedIndex] + " -rotate " + startDate.ToString() + " " + textBox2_Text + '\\' + toolStripStatusLabel1);
                    mainps(aaff[checkedListBox1_SelectedIndex]);
                    mainps2(textBox2_Text + '\\' + toolStripStatusLabel1);

                    NEXTSEL();
                }
            });
        }

        private void 檔案指標下移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NEXTSEL();
        }

        private void 檔案指標上移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex > 0)
            {
                checkedListBox1.SelectedIndex = checkedListBox1.SelectedIndex - 1;
            }
        }

        private void 差數計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countDIFF();
        }

        public void countDIFF() {
            label8.Text = (int.Parse(label1.Text) - int.Parse(label4.Text)).ToString();
        }

        private void 去除空白VBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
              var aass = System.Reflection.Assembly.GetExecutingAssembly();
            Stream tss=aass.GetManifestResourceStream("imgturn.TextFile1.txt");
           /* string test = "Testing 1-2-3";

            // convert string to stream
            byte[] byteArray = Encoding.ASCII.GetBytes(test);
            MemoryStream stream = new MemoryStream(byteArray);
            */
            // convert stream to string
           StreamReader reader = new StreamReader(tss);
            string text = reader.ReadToEnd();
            DialogResult Result = MessageBox.Show("歡迎來到C#世界........", "你好 老套但是不會膩顯示", MessageBoxButtons.OKCancel);

            if (Result == DialogResult.OK)
            {
                MessageBox.Show(text);
            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show(text);
            }
            Clipboard.SetText(text);
            /* System.Diagnostics.Process.Start(@"cscript //B //Nologo c:\scripts\vbscript.vbs");

             FileStream fileStream = new FileStream("[path]", FileMode.Open, FileAccess.Read, FileShare.Read, 64 * 1024,
        (FileOptions)0x20000000 | FileOptions.WriteThrough & FileOptions.SequentialScan);

             string fileContents;
             using (StreamReader reader = new StreamReader(fileStream))
             {
                 fileContents = reader.ReadToEnd();
             }*/


            //  bool assignedvariable = Convert.ToBoolean(fileContents);

            /*       Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));

                   dynamic obj = Activator.CreateInstance(scriptType, false);
                   obj.Language = "vbscript";
                 string vbscript = "msgbox(\"wait it to run finish\")"+ System.Environment.NewLine+
                       "Set objFso = CreateObject(\"Scripting.FileSystemObject\")" + System.Environment.NewLine+
       "Set Folder = objFSO.GetFolder(\""+textBox1.Text +"\\\")" + System.Environment.NewLine+
       "For Each File In Folder.Files" + System.Environment.NewLine+
       "    sNewFile = File.Name" + System.Environment.NewLine+
       "    sNewFile = Replace(sNewFile, \" \", \"_\")" + System.Environment.NewLine+
       "    if (sNewFile <> File.Name) then" + System.Environment.NewLine+
       "        File.Move(File.ParentFolder + \"\\\"+sNewFile)" + System.Environment.NewLine+
       "    end if" + System.Environment.NewLine+
       "Next";
                   obj.Eval(text);*/
        }
    }


}
