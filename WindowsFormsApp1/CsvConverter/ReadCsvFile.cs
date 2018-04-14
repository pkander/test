using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace CsvConverter
{
    class ReadCsvFile
    {
        private String filePath;
        private List<Row> rows;
        public ReadCsvFile(String filePath)
        {
            this.filePath = filePath;
        }
        public void readfile()
        {
            rows = new List<Row>();
            using (var reader = new StreamReader(filePath))
            {
                String readLine;
                while (!reader.EndOfStream)
                {
                    readLine = reader.ReadLine();
                    rows.Add(new Row(readLine));
                }
            }
        }
        public Row getRow(int index)
        { 
          return rows.ElementAt(index);
        }
    }
}
