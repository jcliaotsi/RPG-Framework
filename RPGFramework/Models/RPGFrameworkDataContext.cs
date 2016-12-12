using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RPGFramework.Entities;
using System.Data.Sql;
using RPGFramework.Utility;
using System.Data;

namespace RPGFramework.Models
{
    partial class RPGFrameworkDataContext
    {
        public SqlConnection Connection { get; private set; }
        private Settings Settings = new Settings();
        private SqlTransaction Transaction;

        public RPGFrameworkDataContext()
        {
            Connection = new SqlConnection(Settings.ConnectionString);
        }

        public bool AddCharacter(Character c)
        {
            SqlConnection con = (SqlConnection)this.Connection;

            using (SqlCommand cmd = new SqlCommand("exec dbo.usp_AddNewCharacter @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16", con, (SqlTransaction)this.Transaction))
            {
                SqlParameter p0 = cmd.Parameters.Add("@p0", SqlDbType.VarChar);
                p0.Value = c.Name;

                SqlParameter p1 = cmd.Parameters.Add("@p1", SqlDbType.VarChar);
                p1.Value = c.Class;

                SqlParameter p2 = cmd.Parameters.Add("@p2", SqlDbType.Int);
                p2.Value = c.Health;

                SqlParameter p3 = cmd.Parameters.Add("@p3", SqlDbType.Int);
                p3.Value = c.Spirit;

                SqlParameter p4 = cmd.Parameters.Add("@p4", SqlDbType.Int);
                p4.Value = c.Physical;

                SqlParameter p5 = cmd.Parameters.Add("@p5", SqlDbType.Int);
                p5.Value = c.Grit;

                SqlParameter p6 = cmd.Parameters.Add("@p6", SqlDbType.Int);
                p6.Value = c.Magick;

                SqlParameter p7 = cmd.Parameters.Add("@p7", SqlDbType.Int);
                p7.Value = c.Dexterity;

                SqlParameter p8 = cmd.Parameters.Add("@p8", SqlDbType.Int);
                p8.Value = c.Focus;

                SqlParameter p9 = cmd.Parameters.Add("@p9", SqlDbType.Int);
                p9.Value = c.PrimaryAtk;

                SqlParameter p10 = cmd.Parameters.Add("@p10", SqlDbType.Int);
                p10.Value = c.SecondaryAtk;

                SqlParameter p11 = cmd.Parameters.Add("@p11", SqlDbType.VarChar);
                p11.Value = c.PrimaryType;

                SqlParameter p12 = cmd.Parameters.Add("@p12", SqlDbType.VarChar);
                p12.Value = c.SecondaryType;

                SqlParameter p13 = cmd.Parameters.Add("@p13", SqlDbType.VarChar);
                p13.Value = c.Gender;

                SqlParameter p14 = cmd.Parameters.Add("@p14", SqlDbType.VarChar);
                p14.Value = c.Humour;

                SqlParameter p15 = cmd.Parameters.Add("@p15", SqlDbType.Int);
                p15.Value = c.DamageTaken;

                SqlParameter p16 = cmd.Parameters.Add("@p16", SqlDbType.Bit);
                p16.Value = c.Alive;

                con.Open();
                Transaction = Connection.BeginTransaction("Add Character");

                try
                {
                    cmd.Transaction = Transaction;
                    cmd.ExecuteScalar();
                    Transaction.Commit();
                    return true;
                }

                catch (Exception e)
                {
                    // Pokemon exception
                    //TODO: Refacor
                    return false;
                }
            }
        }
    }
}
