using System;
using System.Windows.Forms;

namespace _41016_Ex10 {

    class Sort {
        public Form1 S;

        public string Sorted() {
            double average = S.aver;
            string result;
            string line = "-------------------------------------------------------------------\r\n";

            result = "學號\t姓名\t國文\t英文\t數學\t總分\r\n";
            result += line;
            BubbleSort(S.grade, S.person);
            for (int i = 0; i < S.person.GetLength(0); i++) {
                int sub = 0;
                result += S.person[i, 0] + "\t";
                result += S.person[i, 1] + "\t";
                result += S.grade[i, 0].ToString() + "\t";
                result += S.grade[i, 1].ToString() + "\t";
                result += S.grade[i, 2].ToString() + "\t";
                for (int k = 0; k < S.grade.GetLength(1); k++) {
                    sub += S.grade[i, k];
                }
                result += sub.ToString() + "\r\n";
            }
            result += line;
            result += "平均 : " + average.ToString("n2") + "\t\t\t總分 : " + S.total;

            return result;
        }

        public void BubbleSort(int[,] list, string[,] student) {
            int len = list.GetLength(0);
            for (int i = 1; i < len; i++) {//執行的回數
                for (int j = 1; j < len; j++)//執行的次數{ 
                    if (Convert.ToInt32(student[j, 0]) < Convert.ToInt32(student[j - 1, 0])) {
                        //二數交換
                        int tempChi = list[j, 0];
                        list[j, 0] = list[j - 1, 0];
                        list[j - 1, 0] = tempChi;

                        int tempEng = list[j, 1];
                        list[j, 1] = list[j - 1, 1];
                        list[j - 1, 1] = tempEng;

                        int tempMath = list[j, 2];
                        list[j, 2] = list[j - 1, 2];
                        list[j - 1, 2] = tempMath;

                        string tempId = student[j, 0];
                        student[j, 0] = student[j - 1, 0];
                        student[j - 1, 0] = tempId;

                        string tempName = student[j, 1];
                        student[j, 1] = student[j - 1, 1];
                        student[j - 1, 1] = tempName;
                    }
            }
        }
    }
}
