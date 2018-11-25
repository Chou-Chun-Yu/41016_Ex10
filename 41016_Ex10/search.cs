using System;
using System.Windows.Forms;

namespace _41016_Ex10
{
    class Search{
        static public Form1 S;

        static internal void Bt_search_Click(object sender, EventArgs e)
        {

            int sum = 0;
            bool found = false;
            for (int i = 0; i < S.person.GetLength(0); i++)
            {
                if (S.Tb_id.Text == S.person[i, 0])
                {
                    found = true;
                    S.Tb_name.Text = S.person[i, 1];
                    S.Tb_Chi.Text = S.grade[i, 0].ToString();
                    S.Tb_Eng.Text = S.grade[i, 1].ToString();
                    S.Tb_Math.Text = S.grade[i, 2].ToString();
                    for (int k = 0; k < S.grade.GetLength(1); k++)
                    {
                        sum += S.grade[i, k];
                    }
                    S.Tb_total.Text = sum.ToString();
                }
            }
            if (!found) MessageBox.Show("不存在" + S.Tb_id.Text);
        }
    }
}
