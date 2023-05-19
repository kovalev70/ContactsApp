using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public static class ProjectSerializer
    {
        /// <summary>
        /// Содержит стандартный путь в папку данных <see cref="_directory"/>
        /// </summary>
        public static readonly string Filename =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            + @"\KovalevINC\ContactsApp\ContactsApp.json";

        /// <summary>
        /// Реализует сохранение файла
        /// </summary>
        /// <param name="project"></param>
        /// <param name="path"></param>
        public static void SaveToFile(Project project, string path)
        {
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (StreamWriter file = new StreamWriter(
                path, false, System.Text.Encoding.UTF8))
            {
                file.Write(JsonConvert.SerializeObject(project));
            }
        }

        /// <summary>
        /// Загружает файл из папки
        /// </summary>
        /// <returns>
        /// Все данные проекта
        /// </returns>
        public static Project LoadFromFile(string path)
        {
            var project = new Project();

            if (!File.Exists(path))
            {
                return project;
            }

            try
            {
                var projectText = File.ReadAllText(path);
                project = JsonConvert.DeserializeObject<Project>(projectText);
                if (project == null)
                {
                    return new Project();
                }
            }
            catch
            {
                return new Project();
            }

            return project;
        }
    }
}
