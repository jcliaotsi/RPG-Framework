using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Utility
{
    public class Settings
    {
        private static object syncLock = new object();
        private static Settings _instance;
        private string _connectionString;

        public Settings()
        {
            _connectionString = "Data Source=.;Initial Catalog=RPGFrameworkDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
        }

        public static Settings Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Settings();
                        }
                    }
                }
                return _instance;
            }
        }

        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
    }
}
