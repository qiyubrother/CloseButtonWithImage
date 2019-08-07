using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloseButtonWithImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNavigation_Paint(object sender, PaintEventArgs e)
        {
            var btn = sender as Button;
            var bmp = Properties.Resources.close_default;
            e.Graphics.DrawImage(bmp, new Rectangle(btn.Width - 20, 4, 16, 16));
        }

        private void btnNavigation_MouseClick(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            var rect = new Rectangle(btn.Width - 20, 4, 16, 16);
            if (rect.Contains(e.X, e.Y))
            {
                MessageBox.Show("关闭按钮被点击！");
            }
        }
    }
}
