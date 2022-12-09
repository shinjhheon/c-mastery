using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SALES
    {
        // 총 메뉴별 금액 저장하는 부분
        private int americanohsu = 0, cafelattehsu = 0, jejusu = 0, cafemochahsu = 0, strawberrysu = 0, americanoisu = 0, cafelatteisu = 0, cafemochaisu = 0, mangosu = 0, chococakesu = 0, cheezecakesu = 0, tiramisusu = 0, icesu = 0, bagelsu = 0;
        // 결제한 금액과 오늘 총금액 저장하는 부분
        private int sumcas = 0 , salessu = 0;

        // 결제한 금액이랑 오늘 총금액에 대한 프로퍼티
        public int sumcash {
            get { return sumcas; }
            set { sumcas = value; }
        }
        public int salessum {
            get { return salessu; }
            set { salessu = value; }
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

        // 오늘 총매출 반환하는 메소드
        public int Salessum()
        {
            salessum += sumcash;
            return salessum;
        }
    }
}
