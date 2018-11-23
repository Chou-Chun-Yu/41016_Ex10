using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41016_Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string [,] person = { 
            {"105014", "周峻宇"}, 
            {"105011", "林彥賓"}, 
            {"105018", "彭丞浩"}, 
            {"105016", "周柏晟"}, 
            {"105047", "徐聖淮"} 
        };

        int [,] grade = { 
            {98, 75, 68}, 
            {85, 97, 66}, 
            {88, 54, 75}, 
            {84, 63, 54}, 
            {58, 88, 94},         
        };

        double total, aver;

        public void Form1_Load(object sender, EventArgs e) {
            for(int i = 0; i < grade.GetLength(0); i++){
                for (int j = 0; j < grade.GetLength(1); j++){
                    total += grade[i, j];
                    aver = total / grade.GetLength(0) / grade.GetLength(1);
                }
            }
        }

        public void Bt_search_Click(object sender, EventArgs e) {
            int sum = 0;
            bool found = false;
            for (int i = 0; i < person.GetLength(0); i++) {
                if (Tb_id.Text == person[i, 0]) {
                    found = true;
                    Tb_name.Text = person[i, 1];
                    Tb_Chi.Text = grade[i, 0].ToString();
                    Tb_Eng.Text = grade[i, 1].ToString();
                    Tb_Math.Text = grade[i, 2].ToString();
                    for (int k = 0; k < grade.GetLength(1); k++) {
                        sum += grade[i, k];
                    }
                    Tb_total.Text = sum.ToString();
                }
            }
            if(!found) MessageBox.Show("不存在" + Tb_id.Text);
        }

        public void Bt_sort_Click(object sender, EventArgs e) {
            Tb_show.Text = "學號\t姓名\t國文\t英文\t數學\t總分\r\n";
            Tb_show.Text += "-------------------------------------------------------------------\r\n";
            BubbleSort(grade,person);
            for (int i = 0; i < person.GetLength(0); i++) {
                int sub = 0;
                Tb_show.Text += person[i, 0] + "\t";
                Tb_show.Text += person[i, 1] + "\t";
                Tb_show.Text += grade[i, 0].ToString() + "\t";
                Tb_show.Text += grade[i, 1].ToString() + "\t";
                Tb_show.Text += grade[i, 2].ToString() + "\t";
                for (int k = 0; k < grade.GetLength(1); k++) {
                    sub += grade[i, k];
                }
                Tb_show.Text += sub.ToString() + "\r\n";
            }
            Tb_show.Text += "-------------------------------------------------------------------\r\n";
            Tb_show.Text += "平均 : " + aver.ToString("n2") + "\t\t\t總分 : " + total;
        }

        public void BubbleSort(int[,] list, string[,] student) {
            int len = list.GetLength(0);  
            for (int i = 1; i < len; i++){//執行的回數
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