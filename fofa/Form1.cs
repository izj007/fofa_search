
using Common;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Microsoft.Win32;

namespace fofa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.SizeChanged += new Resize(this).Form1_Resize;
        }

        private HashSet<string> jsonArr = new HashSet<string>();

        private delegate void DelSetPro(int pro, ProgressBar proBar);
        private delegate void DelSetProVisi(ProgressBar proBar);

        /// <summary>
        /// 设置ProgressBar的进度。
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="proBar"></param>
        private void SetProgressMessage(int pro, ProgressBar proBar)
        {
            //如果当前调用方不是创建控件的一方，则需要使用this.Invoke()
            //在这里，ProgressBar控件是由主线程创建的，所以子线程要对该控件进行操作
            //必须执行this.InvokeRequired进行判断。
            if (this.InvokeRequired)
            {
                DelSetPro setPro = new DelSetPro(SetProgressMessage);
                this.Invoke(setPro, new object[] { pro, proBar });
            }
            else
            {
                proBar.Value = Convert.ToInt32(pro);
            }
        }

        /// <summary>
        /// 让控件ProgressBar消失。
        /// </summary>
        /// <param name="pro"></param>
        private void SetProgressBarVisi(ProgressBar pro)
        {
            if (this.InvokeRequired)
            {
                DelSetProVisi setProVisi = new DelSetProVisi(SetProgressBarVisi);
                this.Invoke(setProVisi, new object[] { pro });
            }
            else
            {
                pro.Visible = false;
            }
        }

        /// <summary>
        /// 操作ProgressBar01
        /// </summary>
        private void SleepForProgressBar01()
        {
            int total = lb_keyword.Items.Count;
            for (int i = 1; i <= (100-total); i++)
            {
                Thread.Sleep(2);
                SetProgressMessage(i, pb);
            }
            DialogResult dr01 = MessageBox.Show("数据获取完毕！");
            if (dr01.Equals(DialogResult.OK))
            {
                SetProgressBarVisi(pb);
            }
        }

        public void ChangeBtnKeyword(string str)
        {
            lb_keyword.Items.Add(str);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_keyword.Text != "")
            {
                lb_keyword.Items.Add(tb_keyword.Text);
            }
        }

        private void btn_cancelall_Click(object sender, EventArgs e)
        {
            lb_keyword.Items.Clear();
        }

        private void btn_adds_Click(object sender, EventArgs e)
        {
            Form popForm = new PopForm();
            popForm.ShowDialog(this);
        }


        public async Task<string> async_Search(string email, string key, int size, int page, bool full, string keyword,string proxy)
        {
            string fields = "host,ip,port,domain,title,server";
            string url = string.Format("https://fofapro.com/api/v1/search/all?email={0}&key={1}&fields={2}&page={3}&size={4}&qbase64={5}&full={6}", email, key, fields, page, size, Convert.ToBase64String(Encoding.UTF8.GetBytes(keyword)), full);
            string result = await HttpHelperAsync.HttpGetAsync(url,proxy);
            return result;
        }

        private int GetSize(int minsize,string JsonStr)
        {
            JObject jo = (JObject)JsonConvert.DeserializeObject(JsonStr);
            int size = Convert.ToInt32(jo["size"]);
            int pages = 1;
            if (size > minsize)
            {
                pages = Convert.ToInt32(Math.Ceiling((double)size / minsize));
            }
            return pages;
        }



        private async Task fofaSearchAsync()
        {
            jsonArr.Clear();
            //Thread pro01Thread = new Thread(new ThreadStart(SleepForProgressBar01));
            //pro01Thread.Start();
            string email = tb_email.Text;
            string key = tb_key.Text;
            string proxy = tb_proxy.Text;
            int maxpage = Convert.ToInt32(tb_page.Text);
            int size = Convert.ToInt32(tb_size.Text);
            int jc = 1;
            int pbjc = 10;
            if(lb_keyword.Items.Count == 0)
            {
                MessageBox.Show("关键词不能为空");
                return;
            }

            lv_result.Items.Clear();
            foreach (string keyword in lb_keyword.Items)
            {
                string jsonText = await async_Search(email, key, size, 1, cb_searchAllData.Checked, keyword, proxy);
                int pages = GetSize(size, jsonText);
                if(pages > maxpage)
                {
                    pages = maxpage;
                }
                for(int i = 1; i <= pages; i++)
                {
                    if (pbjc < 90)
                    {
                        SetProgressMessage(pbjc, pb);
                        pbjc += 10;
                    }
                    jsonText = await async_Search(email, key, size, i, cb_searchAllData.Checked, keyword, proxy);
                    JObject jo = (JObject)JsonConvert.DeserializeObject(jsonText);
                    JArray arr = (JArray)jo["results"];
                    if (arr.Count > 0)
                    {
                        for (int j = 0; j < arr.Count; j++)
                        {
                            lv_result.BeginUpdate();
                            ListViewItem lvi = new ListViewItem();
                            JArray arrData = (JArray)arr[j];
                            lvi.SubItems[0].Text = jc.ToString();
                            lvi.SubItems.Add((string)arrData[0]);
                            lvi.SubItems.Add((string)arrData[1]);
                            lvi.SubItems.Add((string)arrData[2]);
                            lvi.SubItems.Add((string)arrData[3]);
                            lvi.SubItems.Add((string)arrData[4]);
                            lvi.SubItems.Add((string)arrData[5]);
                            jc += 1;
                            lv_result.EndUpdate();
                            lv_result.Items.Add(lvi);
                        }
                    }

                }
            }
            for (int k = pbjc; k <= 100; k++)
            {
                SetProgressMessage(k, pb);
            }
            DialogResult dr01 = MessageBox.Show("数据获取完毕！");
            if (dr01.Equals(DialogResult.OK))
            {
                SetProgressBarVisi(pb);
            }
            
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            pb.Value = 0;
            pb.Visible = true;
            btn_search.Enabled = false;
            await fofaSearchAsync();
            btn_search.Enabled = true;
        }

        /// <summary>
        /// 执行导出数据
        /// </summary>
        public void ExportToCsv()
        {
            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "csv";
            sfd.Filter = "Csv文件(*.csv)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DoExport(this.lv_result, sfd.FileName);
            }
        }

        /// <summary>
        /// 具体导出的方法
        /// </summary>
        /// <param name="listView">ListView</param>
        /// <param name="strFileName">导出到的文件名</param>
        private void DoExport(ListView listView, string strFileName)
        {
            int rowNum = listView.Items.Count;
            int columnNum = listView.Items[0].SubItems.Count;
            int rowIndex = 1;
            int columnIndex = 0;
            string result = "";
            if (rowNum == 0 || string.IsNullOrEmpty(strFileName))
            {
                return;
            }
            if (rowNum > 0)
            {

                //将ListView的列名导入Excel表第一行
                foreach (ColumnHeader dc in listView.Columns)
                {
                    columnIndex++;
                    result = string.Format("{0},{1}", result, dc.Text);
                }
                result = result.Remove(0, 1)+"\r\n";

                foreach (ListViewItem item in listView.Items)
                {
                    result = string.Format("{0}{1},{2},{3},{4},{5},{6},{7}\r\n",result, item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text, item.SubItems[6].Text);
                }
                StreamWriter sw = new StreamWriter(strFileName);//这里写上你要保存的路径
                sw.WriteLine(result);//按行写
                sw.Close();//关闭
                MessageBox.Show("OK");
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportToCsv();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            lb_keyword.Height = this.pb.Location.Y+190;
            lv_result.Height = this.pb.Location.Y + 230;
            lv_result.Width = this.Size.Width - this.lb_keyword.Width - 60;
        }

        [DllImport("kernel32")]//返回0表示失败，非0为成功
        private static extern long WritePrivateProfileString(string section, string key,
    string val, string filePath);

        [DllImport("kernel32")]//返回取得字符串缓冲区的长度
        private static extern long GetPrivateProfileString(string section, string key,
            string def, StringBuilder retVal, int size, string filePath);

        public void IniWriteValue(string Section, string Key, string Value, string Path)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        /// <summary>
        /// 读取INI文件指定的文件数据
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Path"></param>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key, string Path)
        {
            StringBuilder temp = new StringBuilder(255);
            long i = GetPrivateProfileString(Section, Key, "", temp, 255, Path);
            return temp.ToString();
        }


        private void cb_remember_CheckedChanged(object sender, EventArgs e)
        {
            string Section = "Account";
            string email = tb_email.Text;
            string key = tb_key.Text;
            string proxy = tb_proxy.Text;
            string iniFilePath = Application.StartupPath + @"\Config.ini";
            if (cb_remember.Checked)
            {
                if (File.Exists(iniFilePath))
                {
                    IniWriteValue(Section, "email", email, iniFilePath);
                    IniWriteValue(Section, "key", key, iniFilePath);
                    IniWriteValue(Section, "proxy", proxy, iniFilePath);
                }
            }
            else
            {
                if (File.Exists(iniFilePath))
                {
                    IniWriteValue(Section, "email", "", iniFilePath);
                    IniWriteValue(Section, "key", "", iniFilePath);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string iniFilePath = Application.StartupPath + @"\Config.ini";
            if (File.Exists(iniFilePath))
            {
                tb_email.Text = IniReadValue("Account", "email", iniFilePath);
                tb_key.Text = IniReadValue("Account", "key", iniFilePath);
                tb_proxy.Text = IniReadValue("Account", "proxy", iniFilePath);
                if(!(tb_email.Text ==""|| tb_key.Text == ""|| tb_proxy.Text == ""))
                {
                    cb_remember.Checked = true;
                }
            }

        }

        private void lv_result_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lv_result.Columns[e.Column].Tag == null)
            {
                lv_result.Columns[e.Column].Tag = true;
            }
            bool tabK = (bool)lv_result.Columns[e.Column].Tag;
            if (tabK)
            {
                lv_result.Columns[e.Column].Tag = false;
            }
            else
            {
                lv_result.Columns[e.Column].Tag = true;
            }
            lv_result.ListViewItemSorter = new ListViewSort(e.Column, lv_result.Columns[e.Column].Tag);
            //指定排序器并传送列索引与升序降序关键字
            lv_result.Sort();//对列表进行自定义排序
        }

        public class ListViewSort : IComparer
        {
            private int col;
            private bool descK;

            public ListViewSort()
            {
                col = 0;
            }
            public ListViewSort(int column, object Desc)
            {
                descK = (bool)Desc;
                col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递
            }
            public int Compare(object x, object y)
            {
                int tempInt = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                if (descK)
                {
                    return -tempInt;
                }
                else
                {
                    return tempInt;
                }
            }
        }

        private void lv_result_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lv_result.SelectedItems)
            {
                System.Diagnostics.Process.Start("explorer.exe", item.SubItems[1].Text);
            }
        }

        private void hostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(lv_result.SelectedItems[0].SubItems[1].Text);
        }

        private void iPPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(lv_result.SelectedItems[0].SubItems[2].Text+":"+ lv_result.SelectedItems[0].SubItems[3].Text);
        }

        private void domainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(lv_result.SelectedItems[0].SubItems[4].Text);
        }

        private void lv_result_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in lv_result.SelectedItems)
            {
                System.Diagnostics.Process.Start("explorer.exe", item.SubItems[1].Text);
            }
        }

        private void lb_keyword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lb_keyword.Items.RemoveAt(lb_keyword.SelectedIndex);
        }
    }
}
