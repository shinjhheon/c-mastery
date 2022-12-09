using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ORDER
    {
        // 카라멜 마끼야또(HOT, ICE), 카푸치노(HOT, ICE), 브라우니, 머핀, 와플 다른 메뉴로 수정
        // 각 음료 한잔당 곱해야할 가격 종류
        private int won1500 = 1500, won2000 = 2000, won2500 = 2500, won3000 = 3000, won3500 = 3500;
        // 각 음료별 잔수 카운트 (이제 수량이랑 금액 계산때문에 1로 둠)
        private int americanohcoun = 1, cafelattehcoun = 1, jejucoun = 1, cafemochahcoun = 1, strawberrycoun = 1,americanoicoun = 1, cafelatteicoun = 1, cafemochaicoun = 1, mangocoun = 1 , chococakecoun = 1, cheezecakecoun = 1,tiramisucoun = 1, icecoun = 1, bagelcoun = 1;
        // 각 음료별 주문한 총 금액
        private int americanohsu = 0, cafelattehsu = 0, jejusu = 0, cafemochahsu = 0, strawberrysu = 0, americanoisu = 0, cafelatteisu = 0, cafemochaisu = 0, mangosu = 0, chococakesu = 0, cheezecakesu = 0, tiramisusu = 0, icesu = 0, bagelsu = 0;

        //총 금액, 총 커피잔, 총 디저트수 자동 구형 프로퍼티
        public int sumnumber
        {
            get; set;
        }
        public int sumcash {
            get;set;
        }
        public int sumdessert {
            get;set;
        }

        // 메뉴들 카운트에 대한 프로퍼티
        public int americanohcount {
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

        // 메뉴들 금액에 대한 프로퍼티
        public int americanohsum
        {
            get { return americanohsu; }
            set { americanohsu = value; }
        }
        public int cafelattehsum
        {
            get { return cafelattehsu; }
            set { cafelattehsu = value; }
        }
        public int jejusum
        {
            get { return jejusu; }
            set { jejusu = value; }
        }
        public int cafemochahsum
        {
            get { return cafemochahsu; }
            set { cafemochahsu = value; }
        }
        public int strawberrysum
        {
            get { return strawberrysu; }
            set { strawberrysu = value; }
        }
        public int americanoisum
        {
            get { return americanoisu; }
            set { americanoisu = value; }
        }
        public int cafelatteisum
        {
            get { return cafelatteisu; }
            set { cafelatteisu = value; }
        }
        public int cafemochaisum
        {
            get { return cafemochaisu; }
            set { cafemochaisu = value; }
        }
        public int mangosum
        {
            get { return mangosu; }
            set { mangosu = value; }
        }
        public int chococakesum
        {
            get { return chococakesu; }
            set { chococakesu = value; }
        }
        public int cheezecakesum
        {
            get { return cheezecakesu; }
            set { cheezecakesu = value; }
        }
        public int tiramisusum
        {
            get { return tiramisusu; }
            set { tiramisusu = value; }
        }
        public int icesum
        {
            get { return icesu; }
            set { icesu = value; }
        }
        public int bagelsum
        {
            get { return bagelsu; }
            set { bagelsu = value; }
        }

        // 메뉴들 총금액을 계산해서 반환해주는 메소드
        public int AmericanohSum() 
        { 
            americanohsum = americanohcount * won1500;
            return americanohsum;
        }
        public int CafelattehSum() 
        { 
            cafelattehsum = cafelattehcount * won2000;
            return cafelattehsum;
        }
        public int JejuSum()
        {
            jejusum = jejucount * won3500;
            return jejusum;
        }
        public int CafemochahSum()
        {
            cafemochahsum = cafemochahcount * won2500;
            return cafemochahsum;
        }
        public int StrawberrySum()
        {
            strawberrysum = strawberrycount * won3500;
            return strawberrysum;
        }
        public int AmericanoiSum()
        {
            americanoisum = americanoicount * won2000;
            return americanoisum;
        }
        public int CafelatteiSum() 
        {
            cafelatteisum = cafelatteicount * won2500;
            return cafelatteisum;
        }
        public int CafemochaiSum()
        {
            cafemochaisum = cafemochaicount * won3000;
            return cafemochaisum;
        }
        public int MangoSum() 
        {
            mangosum = mangocount * won3500; 
            return mangosum;
        }
        public int SumNumber() 
        {
            sumnumber = americanohcount + cafelattehcount + jejucount + cafemochahcount + strawberrycount + americanoicount + cafelatteicount  + cafemochaicount + mangocount;
            return sumnumber-10;
        }
        public int SumCash() 
        {
            sumcash = americanohsum + cafelattehsum + jejusum + cafemochahsum + strawberrysum + americanoisum + cafelatteisum + cafemochaisum + mangosum + chococakesum + cheezecakesum + tiramisusum + icesum + bagelsum ;
            return sumcash;
        }
        public int Sumdessert() 
        {
            sumdessert = chococakecount + cheezecakecount + tiramisucount + icecount + bagelcount ;
            return sumdessert - 7;
        }
        public int ChococakeSum() 
        {
            chococakesum = chococakecount * won3500;
            return chococakesum;
        }
        public int CheezecakeSum()
        {
            cheezecakesum = cheezecakecount * won3500;
            return cheezecakesum;
        }
        public int TiramisuSum() 
        {
            tiramisusum = tiramisucount * won3000;
            return tiramisusum;
        }
        public int IceSum()
        {
            icesum = icecount * won2000;
            return icesum;
        }
        public int BagelSum() 
        {
            bagelsum = bagelcount * won2000;
            return bagelsum;
        }
    }
}
