using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReadTextFromFile
{
    public class TestParcer
    {
        private DataRepository repository = new DataRepository();
        public void ParceFile(string filePath)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                Regex r = new Regex("[a-zA-Z0-9]+");
                var result = r.Matches(line);
                foreach (Match item in result)                
                    repository.AddWord(item.Value, counter);                
                counter++;
            }
            file.Close();
        }
        public void SaveParceResult(string filePath)
        {
            repository.SaveResult(filePath);
        }
    }
}
