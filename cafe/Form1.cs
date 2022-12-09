using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection salesconn;
        OleDbCommand salescomm;
        OleDbCommand aaa;
        string salesfile = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = sales.mdb";

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            salesconn = new OleDbConnection(salesfile);
            salesconn.Open();

            DateTime date = monthCalendar1.SelectionStart; // data에 달력 시작 날짜를 넣음
            string day = date.ToShortDateString().Replace("-", ""); // 달력 시작 날짜를 가져오는데 날짜 형식에서 "-"부분을 ""로 바꿔주는거.

            var future = int.Parse(day);
            ++future;
            var past = int.Parse(day);
            --past;
            string salesok = "select * from " + day;
            string sales = "select * from " + future.ToString();
            string dales = "select * from " + past.ToString();
            

            Int32 ok = 0, ok1 = 0; // 테이블내 날짜와 매출의 값을 저장하는 변수
            Int32 bk = 0, bk1 = 0;
            Int32 ck = 0, ck1 = 0;
            Int32 dk = 0, dk1 = 0;
            Int32 ek = 0, ek1 = 0;
            Int32 fk = 0, fk1 = 0;
            Int32 gk = 0, gk1 = 0;
            salescomm = new OleDbCommand(salesok, salesconn);
            OleDbDataReader sr = salescomm.ExecuteReader();

            while (sr.Read())
            {
                ok = sr.GetInt32(0);// 날짜
                ok1 = sr.GetInt32(1);//매출

            }
            salescomm = new OleDbCommand(sales, salesconn);
            sr = salescomm.ExecuteReader();

            while (sr.Read())
            {
                bk = sr.GetInt32(0);// 날짜
                bk1 = sr.GetInt32(1);//매출

            }
            ++future;
            string sale = "select * from " + future.ToString();
            salescomm = new OleDbCommand(sale, salesconn);
            sr = salescomm.ExecuteReader();
            while (sr.Read())
            {
                ck = sr.GetInt32(0);// 날짜
                ck1 = sr.GetInt32(1);//매출

            }
            ++future;
            string sal = "select * from " + future.ToString();
            salescomm = new OleDbCommand(sal, salesconn);
            sr = salescomm.ExecuteReader();
            while (sr.Read())
            {
                dk = sr.GetInt32(0);// 날짜
                dk1 = sr.GetInt32(1);//매출

            }

            salescomm = new OleDbCommand(dales, salesconn);
            sr = salescomm.ExecuteReader();
            while (sr.Read())
            {
                ek = sr.GetInt32(0);// 날짜
                ek1 = sr.GetInt32(1);//매출

            }
            --past;
            string dale = "select * from " + past.ToString();
            salescomm = new OleDbCommand(dale, salesconn);
            sr = salescomm.ExecuteReader();
            while (sr.Read())
            {
                fk = sr.GetInt32(0);// 날짜
                fk1 = sr.GetInt32(1);//매출

            }
            --past;
            string dal = "select * from " + past.ToString();
            salescomm = new OleDbCommand(dal, salesconn);
            sr = salescomm.ExecuteReader();
            while (sr.Read())
            {
                gk = sr.GetInt32(0);// 날짜
                gk1 = sr.GetInt32(1);//매출

            }
            chart1.Series["Series1"].LegendText = "매출추이";
            chart1.Series["Series1"].Points.AddXY(ok, ok1);
            chart1.Series["Series1"].Points.AddXY(bk, bk1);
            chart1.Series["Series1"].Points.AddXY(ck, ck1);
            chart1.Series["Series1"].Points.AddXY(dk, dk1);
            chart1.Series["Series1"].Points.AddXY(ek, ek1);
            chart1.Series["Series1"].Points.AddXY(fk, fk1);
            chart1.Series["Series1"].Points.AddXY(gk, gk1);





            salesconn.Close();
        }
    }
}
