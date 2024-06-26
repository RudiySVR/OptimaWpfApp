﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OptimaWpfApp.Sevices
{
    public class WorkerManipulation
    {

        public IEnumerable<Employee> ReadJson()
        {
            const string filepath = @"workers.json";
            //IEnumerable<Employee> data = noth;

            // Чтение файла
            FileInfo fileInfo = new FileInfo(filepath);
            string json = File.ReadAllText(filepath);

            // Десериализация строки в объект
            IEnumerable<Employee> data = JsonConvert.DeserializeObject<IEnumerable<Employee>>(json);
            return data;
        }

        public void WriteJson(IEnumerable<Employee> data)
        {
            const string filepath = @"workers.json";
            // Сериализация объекта в строку
            string json = JsonConvert.SerializeObject(data);

            // Сохранение строки в файл
            File.WriteAllText(filepath, json);
            return;
        }
    }
}
