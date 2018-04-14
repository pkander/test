using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvConverter
{
    class Row
    {
        private String[] column;
        public Row(String csvLine)
        {
            column = csvLine.Split(';');
            foreach (string line in column)
            {
                Console.WriteLine(line);
            }

        }
        public String print()
        {
            String output = "";
            foreach (string word in column)
            {
                output += word + "\n ";
            }
            return output;
        }
    }
}
