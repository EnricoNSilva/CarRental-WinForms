using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    internal class CsvHelper
    {
        public static void ExportDataTableToCsv(DataTable dt, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // 1. Escreve o cabeçalho (nomes das colunas)
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sb.Append(EscapeCsvField(dt.Columns[i].ColumnName));
                if (i < dt.Columns.Count - 1)
                    sb.Append(',');
            }
            sb.AppendLine();

            // 2. Escreve as linhas de dados
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sb.Append(EscapeCsvField(row[i].ToString()));
                    if (i < dt.Columns.Count - 1)
                        sb.Append(',');
                }
                sb.AppendLine();
            }

            // 3. Salva o conteúdo no arquivo
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        // Função auxiliar para tratar campos que contêm vírgulas ou aspas
        private static string EscapeCsvField(string field)
        {
            if (field.Contains(",") || field.Contains("\""))
            {
                // Coloca o campo entre aspas duplas e duplica as aspas internas
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }
            return field;
        }
    }
}
