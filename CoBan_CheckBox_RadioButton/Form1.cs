using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoBan_CheckBox_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoThich_Click(object sender, EventArgs e)
        {
            string str = "Sở thích của bạn là: ";
            int a = str.Length;
            if (ckbDuLich.Checked == true)
                str = str + "Du lịch, ";
            if (ckbGame.Checked == true)
                str = str + "Game, ";
            if (ckbMuaSam.Checked == true)
                str = str + "Mua sắm, ";
            if (ckbNgheNhac.Checked == true)
                str += "Nghe nhạc, ";
            if (ckbTheThao.Checked == true)
                str += "Thể thao, ";
            if (ckbXemPhim.Checked == true)
                str += "Xem phim, ";

            str = str.Substring(0, str.Length - 2);
            if (str.Length <= a)
                str = "Bạn chưa lựa chọn";

            MessageBox.Show(str);
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            if(rdoDen.Checked == true)
            {
                MessageBox.Show("Bạn thích màu Đen");
                return;
            }
            if (rdoTrang.Checked == true)
            {
                MessageBox.Show("Bạn thích màu Trắng");
                return;
            }
            if (rdoHong.Checked == true)
            {
                MessageBox.Show("Bạn thích màu Hồng");
                return;
            }
            if (rdoDo.Checked == true)
            {
                MessageBox.Show("Bạn thích màu Đỏ");
                return;
            }
            if (rdoVang.Checked == true)
            {
                MessageBox.Show("Bạn thích màu Vàng");
                return;
            }
            if (rdoXanh.Checked == true)
            {
                MessageBox.Show("Bạn thích màu Xanh");
                return;
            }
            MessageBox.Show("Bạn chưa chọn màu sắc");
        }
    }
}
