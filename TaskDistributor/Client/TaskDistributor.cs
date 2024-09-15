using System;
using System.Collections.Generic;

namespace TaskDistributor.Client
{
    public class TaskDistributorManager
    {
        private List<string> students;
        private Dictionary<string, List<string>> taskPacks;

        public TaskDistributorManager(List<string> students, Dictionary<string, List<string>> taskPacks)
        {
            this.students = students;
            this.taskPacks = taskPacks;
        }

        public Dictionary<string, Dictionary<string, DistributionInfo>> DistributeTasks(bool randomize)
        {
            Dictionary<string, Dictionary<string, DistributionInfo>> outputValue = new Dictionary<string, Dictionary<string, DistributionInfo>>();

            foreach (var student in students)
            {
                outputValue[student] = new Dictionary<string, DistributionInfo>();
            }

            Random random = new Random();

            foreach (var pack in taskPacks)
            {
                string packName = pack.Key;
                if (packName == "Discription") continue;
                List<string> variants = new List<string>(pack.Value);

                if (randomize) ShuffleList(variants, random); // Перемешиваем варианты

                int numVariants = variants.Count;

                List<string> studentOrder = new List<string>(students);
                if (randomize) ShuffleList(studentOrder, random); // Перемешиваем порядок студентов

                for (int i = 0; i < studentOrder.Count; i++)
                {
                    string student = studentOrder[i];
                    string variant = variants[i % numVariants]; // Назначаем рандомизированный вариант
                    outputValue[student][packName] = new DistributionInfo(variant, i % numVariants + 1);
                }
            }

            return outputValue;
        }

        private void ShuffleList(List<string> list, Random random)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                string temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }

    public class DistributionInfo
    {
        public string distributionText { get; private set; }
        public int distributionIndex { get; private set; }

        public DistributionInfo(string distributionText, int distributionIndex)
        {
            this.distributionText = distributionText;
            this.distributionIndex = distributionIndex;
        }
    }
}