using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    class STOCK
    {
        // 각 음료별 잔수 카운트하는 부분
        private int americanohcoun = 0, cafelattehcoun = 0, jejucoun = 0, cafemochahcoun = 0, strawberrycoun = 0, americanoicoun = 0, cafelatteicoun = 0, cafemochaicoun = 0, mangocoun = 0, chococakecoun = 0, cheezecakecoun = 0, tiramisucoun = 0, icecoun = 0, bagelcoun = 0;
        private string[] name = new string[50]; // sales 파일에 Stockname 저장
        private Int32[] count = new Int32[50]; // sales 파일에 Stockcount 저장
        private string[] note = new string[50];// sales 파일에 Stocknote 저장
        private int i = 0; // 데이터베이스 파일을 읽어 안에 필드들을 저장할때 그 수만큼 카운트 해주는 변수
        string stockfile = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stock.mdb";
       
        // count 배열에 대한 인덱스
        public Int32 this[int index]
        { 
            get { return count[index]; }
            set { count[index] = value; }
        }

        // 메뉴들 카운트에 대한 프로퍼티
        public int americanohcount
        {
            get { return americanohcoun; }
            set { americanohcoun = value; }
        }
        public int cafelattehcount
        {
            get { return cafelattehcoun; }
            set { cafelattehcoun = value; }
        }
        public int jejucount
        {
            get { return jejucoun; }
            set { jejucoun = value; }
        }
        public int cafemochahcount
        {
            get { return cafemochahcoun; }
            set { cafemochahcoun = value; }
        }
        public int strawberrycount
        {
            get { return strawberrycoun; }
            set { strawberrycoun = value; }
        }
        public int americanoicount
        {
            get { return americanoicoun; }
            set { americanoicoun = value; }
        }
        public int cafelatteicount
        {
            get { return cafelatteicoun; }
            set { cafelatteicoun = value; }
        }
        public int cafemochaicount
        {
            get { return cafemochaicoun; }
            set { cafemochaicoun = value; }
        }
        public int mangocount
        {
            get { return mangocoun; }
            set { mangocoun = value; }
        }
        public int chococakecount
        {
            get { return chococakecoun; }
            set { chococakecoun = value; }
        }
        public int cheezecakecount
        {
            get { return cheezecakecoun; }
            set { cheezecakecoun = value; }
        }
        public int tiramisucount
        {
            get { return tiramisucoun; }
            set { tiramisucoun = value; }
        }
        public int icecount
        {
            get { return icecoun; }
            set { icecoun = value; }
        }
        public int bagelcount
        {
            get { return bagelcoun; }
            set { bagelcoun = value; }
        }

        public void Stockopen() // sales 파일에 내용을 배열에 저장하는 메소드
        {
            string aaa = "select * from stock";
            OleDbConnection stockconn = new OleDbConnection(stockfile);
            stockconn.Open();
            OleDbCommand stockcomm = new OleDbCommand(aaa, stockconn);
            OleDbDataReader sr = stockcomm.ExecuteReader();
            while (sr.Read()) 
            {
                name[i] = sr.GetString(0);
                count[i] = sr.GetInt32(1);
                note[i] = sr.GetString(2);
                i++;
            }
            sr.Close();
            stockconn.Close();
        }
        public void Stockstart() // 재고 감소시켜주는 메소드
        {
            count[0] -= americanohcount + americanoicount + cafelattehcount + cafelatteicount + jejucount  + cafemochahcount + cafemochaicount + strawberrycount + mangocount;
            count[1] -= cafelattehcount + cafelatteicount + jejucount +  cafemochahcount + cafemochaicount + strawberrycount + mangocount;
            count[2] -= cafemochahcount + cafemochaicount;
            count[3] -= strawberrycount + mangocount;
            count[4] -= chococakecount;
            count[5] -= cheezecakecount ;
            count[7] -= tiramisucount ;
            count[8] -= icecount;
            count[9] -= bagelcount ;
        }
        public void Stocksave() // 재고 감소 된거 다시 데이터 베이스에 저장하는 메소드
        {
            OleDbConnection stockconn = new OleDbConnection(stockfile);
            stockconn.Open();
            for (int i = 0; i < this.i; i++)
            {
                string Sql = "update stock set Stockname='" + name[i] + "',Stockcount=" + count[i] + ",Stocknote='" + note[i] + "'";
                Sql += "where Stockname = '" + name[i] + "' and Stocknote='" + note[i] + "'";

                OleDbCommand stockcomm = new OleDbCommand(Sql, stockconn);
                stockcomm.ExecuteNonQuery();
            }
            stockconn.Close();
            this.i = 0;
        }

    }
}