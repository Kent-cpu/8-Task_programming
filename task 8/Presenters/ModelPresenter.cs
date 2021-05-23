using System;
using System.Xml;
using System.IO;
using task_8.Views;
using task_8.Models;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace task_8.Presenters
{
    public class ModelPresenter
    {
        IModel modelView;

        public ModelPresenter(IModel view)
        {
            modelView = view;
        }

        public void logging(string currentAction)
        {
            Model model = new Model
            {
                firstPath = modelView.firstPathText,
                secondPath = modelView.secondPathText,
                fileText = modelView.modifiedText,
                action = currentAction,
                fileName = modelView.fileNameText,
                date = DateTime.Now.ToShortDateString(),
                time = DateTime.Now.ToShortTimeString()
            };

            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\rusla\Source\Repos\8-Task_programming\task 8\LoggingFiles\Logging.xml");
            XmlElement log = document.CreateElement("log");
            XmlElement date = document.CreateElement("date");
            date.InnerText = model.date;
            XmlElement time = document.CreateElement("time");
            time.InnerText = model.time;
            XmlElement commit = document.CreateElement("commit");
            commit.InnerText = model.action;
            XmlElement textFile = document.CreateElement("textFile");
            textFile.InnerText = model.fileText;
            XmlElement fPath = document.CreateElement("firstPath");
            fPath.InnerText = model.firstPath;
            XmlElement sPath = document.CreateElement("secondPath");
            sPath.InnerText = model.secondPath;
            XmlElement fileName = document.CreateElement("fileName");
            fileName.InnerText = model.fileName;
            log.AppendChild(fPath);
            log.AppendChild(sPath);
            log.AppendChild(fileName);
            log.AppendChild(date);
            log.AppendChild(time);
            log.AppendChild(textFile);
            log.AppendChild(commit);
            document.DocumentElement.AppendChild(log);
            document.Save(@"C:\Users\rusla\Source\Repos\8-Task_programming\task 8\LoggingFiles\Logging.xml");

            var jsonData = File.ReadAllText(@"C:\Users\rusla\Source\Repos\8-Task_programming\task 8\LoggingFiles\Logging.json");
            var employeeList = JsonConvert.DeserializeObject<List<Model>>(jsonData) ?? new List<Model>();
            // Add any new employees
            employeeList.Add(model);

            // Update json data string
            jsonData = JsonConvert.SerializeObject(employeeList, Formatting.Indented);
            File.WriteAllText(@"C:\Users\rusla\Source\Repos\8-Task_programming\task 8\LoggingFiles\Logging.json", jsonData);
        }

        public void deleteFiles()
        {
            Model model = new Model
            {
                firstPath = modelView.firstPathText,
                secondPath = modelView.secondPathText,
                fileName = modelView.fileNameText
            };
            if (File.Exists($"{model.firstPath}/{model.fileName}") && File.Exists($"{model.secondPath}/{model.fileName}"))
            {
                string[] filesFirstFolder = Directory.GetFiles(model.firstPath);
                foreach (string nameFiles in filesFirstFolder)
                {
                    if (Path.GetFileName(nameFiles) == model.fileName)
                    {
                        File.Delete($"{model.firstPath}/{model.fileName}");
                    }
                }

                string[] filesSecondFolder = Directory.GetFiles(model.secondPath);
                foreach (string nameFiles in filesSecondFolder)
                {
                    if (Path.GetFileName(nameFiles) == model.fileName)
                    {
                        File.Delete($"{model.secondPath}/{model.fileName}");
                    }
                }
                logging("Удаление файлов");
            }
            else
            {
                MessageBox.Show("Одного или двух файлов не существует");
            }
            
        }

        public void createFiles()
        {
            
            Model model = new Model
            {
                firstPath = modelView.firstPathText,
                secondPath = modelView.secondPathText,
                fileName = modelView.fileNameText,
                fileText = modelView.modifiedText
            };
            string fPath = $"{model.firstPath}/{model.fileName}";
            string sPath = $"{model.secondPath}/{model.fileName}";

            if( (!File.Exists(fPath) && !File.Exists(sPath)) || (!File.Exists(fPath) || !File.Exists(sPath)) )
            {
                File.WriteAllText($"{model.firstPath}/{model.fileName}", model.fileText);
                File.WriteAllText($"{model.secondPath}/{model.fileName}", model.fileText);
                logging("Создание файлов");
            }
            else
            {
                MessageBox.Show("Файлы уже созданы");
            }
            
        }

        public void changingFiles()
        {
            //bool end = false;
            Model model = new Model
            {
                firstPath = modelView.firstPathText,
                secondPath = modelView.secondPathText,
                fileName = modelView.fileNameText,
                fileText = modelView.modifiedText
            };
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load(@"C:\Users\rusla\Source\Repos\8-Task_programming\task 8\LoggingFiles\Logging.xml");
            //XmlElement xRoot = xDoc.DocumentElement;
            //foreach (XmlNode xnode in xRoot)
            //{
            //    foreach(XmlNode childnode in xnode.ChildNodes)
            //    {
            //        if (childnode.Name == "firstPath")
            //        {
            //            if (childnode.InnerText == model.firstPath)
            //            {
            //                end = true;
            //            }
            //        }

            //        if (childnode.Name == "textFile" && end)
            //        {
            //            if(childnode.InnerText == model.fileText)
            //            {
            //                end = true;
            //            }
            //        }



            //        if (childnode.Name == "secondPath" && end)
            //        {
            //            if (childnode.InnerText == model.secondPath)
            //            {
            //                end = true;
            //            }
            //        }

            //        if(childnode.Name == "fileName" && end)
            //        {
            //            if (childnode.InnerText == model.fileName)
            //            {
            //                end = true;
            //            }
            //        }
            //    }
            //}

            //if (end)
            //{
            //    model.firstPath = Convert.ToString( end);
            //    return ;
            //}

            if (File.Exists($"{model.firstPath}/{model.fileName}") && File.Exists($"{model.secondPath}/{model.fileName}"))
            {
                using (FileStream sw = new FileStream($"{model.firstPath}/{model.fileName}", FileMode.Open))
                {
                    UnicodeEncoding uniencoding = new UnicodeEncoding();
                    byte[] bText = uniencoding.GetBytes(model.fileText);
                    sw.Write(bText);
                }
                using (FileStream sw = new FileStream($"{model.secondPath}/{model.fileName}", FileMode.Open))
                {
                    UnicodeEncoding uniencoding = new UnicodeEncoding();
                    byte[] bText = uniencoding.GetBytes(model.fileText);
                    sw.Write(bText);
                }
                logging("Изменение файлов");
            }
            else
            {
                MessageBox.Show("Одного или двух файлов не существует");
            }
       
        }
    }
}