using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class GetBetweenStrings
    {
        public static string GetBetweenString(string str1, string str2, string orgStr)
        {
            int orgLen = orgStr.Length; //原文の文字列の長さ
            int str1Len = str1.Length; //str1の長さ

            int str1Num = orgStr.IndexOf(str1); //str1が原文のどの位置にあるか

            string s = ""; //返す文字列

            //例外処理
            try
            {
                s = orgStr.Remove(0, str1Num + str1Len); //原文の初めからstr1のある位置まで削除
                int str2Num = s.IndexOf(str2); //str2がsのどの位置にあるか
                s = s.Remove(str2Num); //sのstr2のある位置から最後まで削除
            }
            catch (Exception)
            {
                return orgStr; //原文を返す
            }

            return s; //戻り値
        }
    }
