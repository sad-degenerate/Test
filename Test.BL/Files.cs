using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Test.BL
{
    /// <summary>
    /// Класс загрузки и сохранения данных.
    /// </summary>
    public static class Files
    {
        public static readonly string PATH = @"E:\questions.dat";

        /// <summary>
        /// Сохранение новой коллекции вопросов в бинарный файл.
        /// </summary>
        /// <param name="collection">Новая коллекция вопросов.</param>
        public static void SaveCollection(QuestionsCollection collection)
        {
            var collections = Load();

            collections.Add(collection);

            Save(collections);
        }

        /// <summary>
        /// Сохранение всех коллекций вопросов в бинарный файл.
        /// </summary>
        /// <param name="collections">Все коллекции вопросов.</param>
        public static void Save(List<QuestionsCollection> collections)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(PATH, FileMode.OpenOrCreate))
                formatter.Serialize(fs, collections);
        }

        /// <summary>
        /// Загрузка всех коллекций вопросов.
        /// </summary>
        /// <returns>Все коллекции вопросов.</returns>
        public static List<QuestionsCollection> Load()
        {
            var collections = new List<QuestionsCollection>();
            
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(PATH, FileMode.OpenOrCreate)) 
            {
                if (fs.Length == 0)
                    collections = new List<QuestionsCollection>();
                else
                    collections = formatter.Deserialize(fs) as List<QuestionsCollection>;
            }

            return collections;
        }
    }
}