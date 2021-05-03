using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class New_InstType : Form
    {
        public New_InstType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox_InstType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Model1Container db = new Model1Container();
            //choose type
            if (comboBox_InstType.SelectedIndex != -1)
            {
                if ((from i in db.InstTypeSet where i.TypeName == comboBox_InstType.Text select i).Count() != 0)
                    MessageBox.Show("This type have exist");
                else
                {
                    db.InstTypeSet.Add(new InstType() { TypeName = comboBox_InstType.Text });
                    MessageBox.Show("Add successfully!");
                }
                db.SaveChanges();
                //another method still considered
                //string a = comboBox_InstType.Text;
                //string ConString = "data source=DESKTOP-SDBL0O9;initial catalog=OPMdb;integrated security=True;";

                //string sql = "SELECT count (*) FROM [InstTypeSet] WHERE TypeName = @a";
                //using (SqlConnection cn = new SqlConnection(ConString))
                //{
                //    cn.Open();
                //    using (SqlCommand cmd = new SqlCommand(sql, cn))
                //    {
                //        cmd.Parameters.AddWithValue("@a", a);
                //        SqlDataReader reader = cmd.ExecuteReader();

                //        if (reader.HasRows)
                //        {

                //            MessageBox.Show("This type have exist");

                //        }
                //        else
                //        {
                //            db.InstTypeSet.Add(new InstType() { TypeName = comboBox_InstType.Text });
                //            MessageBox.Show("Add successfully!");

                //        }
                //    }
                //}
                //db.SaveChanges();

            }
            else
                MessageBox.Show("You don't choose type");
        }
    }
}
