using System;
using System.Drawing;
using System.Windows.Forms;

namespace fofa
{
    class Resize
{
    private Form _form;

    public Resize(Form form)
    {
        int count = form.Controls.Count * 2 + 2;
        float[] factor = new float[count];
        int i = 0;
        factor[i++] = form.Size.Width;
        factor[i++] = form.Size.Height;
        foreach (Control ctrl in form.Controls)
        {
            factor[i++] = ctrl.Location.X / (float)form.Size.Width;
            factor[i++] = ctrl.Location.Y / (float)form.Size.Height;
            ctrl.Tag = ctrl.Size;
        }
        form.Tag = factor;
        this._form = form;
    }

    public void Form1_Resize(object sender, EventArgs e)
    {
        float[] scale = (float[])this._form.Tag;
        int i = 2;
        foreach (Control ctrl in this._form.Controls) //panel的长宽增长到一个固定的值就不会再增长了，原因：Panel的宽和高上限是65535像素（https://blog.csdn.net/dufangfeilong/article/details/41805073?utm_source=blogxgwz5）
        {
            ctrl.Left = (int)(this._form.Size.Width * scale[i++]);
            ctrl.Top = (int)(this._form.Size.Height * scale[i++]);
            ctrl.Width = (int)(this._form.Size.Width / (float)scale[0] * ((Size)ctrl.Tag).Width);
            ctrl.Height = (int)(this._form.Size.Height / (float)scale[1] * ((Size)ctrl.Tag).Height);
        }
    }
}
}
