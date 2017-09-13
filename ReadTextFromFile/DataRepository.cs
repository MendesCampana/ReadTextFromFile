using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFromFile
{
    public class DataRepository
    {
        private SortedDictionary<string, List<int>> words = new SortedDictionary<string, List<int>>();
        public void AddWord(string word, int line)
        {
            word = word.ToLower();
            if(words.Keys.Any(x=>x==word))            
                words[word].Add(line);            
            else
            {
                words.Add(word, new List<int>());
                words[word].Add(line);
            }
        }
        public void PrintCollection()
        {
            foreach (var key in words.Keys)
            {
                Console.Write(key + " ");
                foreach(var lines in words[key])                
                    Console.Write(lines + ", ");                
                Console.WriteLine();
            }
        }
        public void SaveResult(string filename)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"d:\" + filename+".txt");
            if (file != null)
            {
                foreach (var key in words.Keys)
                {
                    file.Write(key+" ");
                    foreach (var lines in words[key])                    
                        file.Write(lines + " ");       
                    file.WriteLine();
                }
                Console.WriteLine("Executed");
            }
            else
            {
                Console.WriteLine("Can't save result with such file name");
            }
            file.Close();
        }
    }
}
