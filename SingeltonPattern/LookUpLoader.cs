using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern
{
    public class LookUpLoader
    {
        private IEnumerable<LookUp> LookUps { get; set; }

        private static LookUpLoader _instance;

        private static object locker = new();

        public static LookUpLoader Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new();
                        }
                    }
                }
                return _instance;
            }
        }

        private LookUpLoader()
        {
            LoadLookUps();
        }

        private void LoadLookUps() {
            Thread.Sleep(3000);

            LookUps = new[] { 
                new LookUp(1 ,  "first"),
                new LookUp(2 ,  "first"),
                new LookUp(3 ,  "first"),
            };
        }

        public string FindLookUp(int id)
        {
            var result = LookUps.FirstOrDefault(x => x.Id == id);

            return result?.Name;
        }
    }
}
