using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private int pageNumber = 1;

        public Form1()
        {
            InitializeComponent();
            ShowPage(new StandardVersion()); // 시작 시 홈 페이지 표시
        }


        private void ShowPage(UserControl page)
        {
            panelContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }


        // button_mode 클릭시 동작하는 함수 / panel 변환
        private void button_mode_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1)
            {
                //ShowPage(new TempConverter());
                pageNumber = 2;
            }
            else if(pageNumber == 2) 
            {
                ShowPage(new StandardVersion());
                pageNumber = 1;
            }
        }
    }
}