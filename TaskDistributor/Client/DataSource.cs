using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace TaskDistributor.Client
{
    internal class DataSource
    {
        public Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

        public DataSource(StreamReader reader)
        {
            this.ParseData(reader);
        }

        private void ParseData(StreamReader reader)
        {
            string currentGroup = null; // текущая группа
            string line;

            // Для групп (в квадратных скобках)
            Regex groupRegex = new Regex(@"^\[(.+)\]$");

            // Для строк с нумерацией
            Regex numberedDataRegex = new Regex(@"^\d+\.\s*(.+)$");

            while ((line = reader.ReadLine()) != null)
            {
                line = line.Trim(); // удалить пробелы

                // Пропуск пустых строк
                if (string.IsNullOrEmpty(line)) continue;

                // Проверяем группу (в квадратных скобках)
                var groupMatch = groupRegex.Match(line);
                if (groupMatch.Success)
                {
                    currentGroup = groupMatch.Groups[1].Value;
                    // Создаем новую группу, если её еще нет
                    if (!data.ContainsKey(currentGroup))
                    {
                        data[currentGroup] = new List<string>();
                    }
                    continue;
                }

                // Если группа уже определена, проверяем строки с нумерацией
                if (currentGroup != null)
                {
                    var dataMatch = numberedDataRegex.Match(line);
                    if (dataMatch.Success)
                    {
                        // Добавляем данные в текущую группу
                        data[currentGroup].Add(dataMatch.Groups[1].Value);
                    }
                    else
                    {
                        // Если строка не с нумерацией, но принадлежит текущей группе,
                        // добавляем её как продолжение последнего элемента
                        if (data[currentGroup].Count > 0)
                        {
                            int lastIndex = data[currentGroup].Count - 1;
                            data[currentGroup][lastIndex] += " " + line;
                        }
                    }
                }
            }
        }

        public List<string> GetDataByGroup(string groupName)
        {
            if (data.ContainsKey(groupName))
            {
                return data[groupName];
            }
            return null;
        }

        public List<string> GetGroups()
        {
            return new List<string>(data.Keys);
        }
    }
}
