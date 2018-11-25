using System;
using System.Windows.Forms;

namespace _41016_Ex10 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            Search.S = this;
        }

        public string[,] person = {
                {"105014", "周峻宇"},
                {"105011", "林彥賓"},
                {"105018", "彭丞浩"},
                {"105016", "周柏晟"},
                {"105047", "徐聖淮"}
        };

        public int[,] grade = {
                {98, 75, 68},
                {85, 97, 66},
                {88, 54, 75},
                {84, 63, 54},
                {58, 88, 94},
        };

        public double total, aver;

        public void Form1_Load(object sender, EventArgs e) {
            for (int i = 0; i < grade.GetLength(0); i++) {
                for (int j = 0; j < grade.GetLength(1); j++) {
                    total += grade[i, j];
                    aver = total / grade.GetLength(0) / grade.GetLength(1);
                }
            }
        }

        public void Bt_sort_Click(object sender, EventArgs e) {
            Sort sort = new Sort();
            Sort result = sort;
            result.S = this;
            Tb_show.Text = result.Sorted();
        }
    }
}