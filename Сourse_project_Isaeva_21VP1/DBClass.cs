using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Сourse_project_Isaeva_21VP1
{
    /// <summary>
    /// Класс DBClass предназначен для связи и работы с базой данный MySQL
    /// </summary>
    public class DBClass
    {
        MySql.Data.MySqlClient.MySqlConnection myConnection;
        string myConnectionString;
        /// <summary>
        /// name - имя базы данных, задается пользователем. По умолчанию base_name
        /// </summary>
        public string name;

        /// <summary>
        /// DBClass – конструктор объекта класса. Присваивает полям имени базы и данных для соединения с MySQL значения по умолчанию
        /// </summary>
        public DBClass()
        {
            name = "base_name";
            myConnectionString = "server=127.0.0.1;uid=root;pwd=456FghJ-)$e;";
        }

        /// <summary>
        /// createDB – выполняет команду SQL, которая создает базу данных.
        /// </summary>
        /// <returns>возвращает true в случае успеха, false в случае неудачи</returns>
        public bool createDB()
        {
            try
            {
                MySqlCommand myCommand = createComand(
                    $"CREATE DATABASE `{name}`;" +
                    $"USE `{name}`;" +
                    $"CREATE TABLE notes(" +
                    $"id INTEGER AUTO_INCREMENT PRIMARY KEY," +
                    $" name VARCHAR(50) UNIQUE," +
                    $" productionDate DATE," +
                    $" expirationDate DATE," +
                    $" quantity INTEGER);");
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException) { return false; }
        }

        /// <summary>
        /// создает объект команды к MySQL.
        /// </summary>
        /// <param name="comand"></param>
        /// <returns>возвращает объект команды к MySQL</returns>
        private MySqlCommand createComand(string comand)
        {
            myConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
            myConnection.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = comand;
            return myCommand;
        }

        /// <summary>
        /// openDB – выполняет команду SQL, которая осуществляет открытие существующей базы данных и создание в ней нужной таблицы, если та не существует.
        /// </summary>
        /// <param name="existing_db"></param>
        /// <returns>возвращает true в случае успеха, false в случае неудачи</returns>
        public bool openDB(string existing_db)
        {
            try
            {
                name = existing_db;
                MySqlCommand myCommand = createComand(
                    $"use {name}; " +
                    $"CREATE TABLE IF NOT EXISTS notes" +
                    $"(id INTEGER AUTO_INCREMENT PRIMARY KEY," +
                    $" name VARCHAR(50) UNIQUE," +
                    $" productionDate DATE," +
                    $" expirationDate DATE," +
                    $" quantity INTEGER);");
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException) { return false; }
        }

        /// <summary>
        /// addNote – выполняет команду SQL, которая добавляет запись в таблицу базы данных
        /// </summary>
        /// <param name="item"></param>
        /// <returns>возвращает true в случае успеха, false в случае неудачи</returns>
        public bool addNote(Item item)
        {
            try
            {
                MySqlCommand myCommand = createComand(
                    $"use `{name}`;" +
                    $"insert into notes value (NULL, '{item.name}'," +
                    $" '{item.productionDate:yyyy.MM.dd}'," +
                    $" '{item.expirationDate:yyyy.MM.dd}'," +
                    $"{item.quantity});"
                    );
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException) { return false; }

        }

        /// <summary>
        /// DBToList – преобразует базу данных в список List элементов типа Item.
        /// </summary>
        /// <returns>возвращает список элементов типа Item</returns>
        public List<Item> DBToList()
        {
            MySqlCommand myCommand = createComand(
                $"use `{name}`;" +
                $"select * from notes;");
            return readQuery(myCommand);
        }

        /// <summary>
        /// DBToFile - производит запись базы данных в файл
        /// </summary>
        /// <param name="stream">принимает объект класса Stream</param>
        public void DBToFile(Stream stream)
        {
            using (var writer = new StreamWriter(stream))
            {
                foreach (var item in DBToList().Cast<Item>())
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        /// <summary>
        /// dropDB – выполняет команду SQL, которая удаляет базу данных
        /// </summary>
        /// <returns>возвращает true в случае успеха, false в случае неудачи</returns>
        public bool dropDB()
        {
            try
            {
                MySqlCommand myCommand = createComand($"DROP DATABASE `{name}`;");
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException) { return false; }
        }

        /// <summary>
        /// removeNote – выполняет команду SQL, которая осуществляет поиск элемента по ID.
        /// </summary>
        /// <param name="id">ID элемента - целое число</param>
        /// <returns>возвращает true в случае успеха, false в случае неудачи</returns>
        public bool removeNote(int id)
        {
            try
            {
                MySqlCommand myCommand = createComand(
                    $"use `{name}`;" +
                    $"delete from notes " +
                    $"where notes.id = {id};");
                if (myCommand.ExecuteNonQuery() == 0) return false;
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException) { return false; }
        }

        /// <summary>
        /// editNote – выполняет команду SQL, которая обновляет запись о продукте.
        /// </summary>
        /// <param name="id">ID элемента - целое число</param>
        /// <param name="quantity">новое значение количества продукта</param>
        /// <param name="prod">новое значение даты производства продукта</param>
        /// <param name="exp">новое значение даты истечения срока годности продукта</param>
        public void editNote(int id, int quantity, DateTime prod, DateTime exp)///////
        {
            MySqlCommand myCommand = createComand(
            $"use `{name}`;" +
            $"UPDATE notes " +
                $"SET quantity = {quantity}, " +
                $"productionDate = '{prod:yyyy.MM.dd}', " +
                $"expirationDate = '{exp:yyyy.MM.dd}' " +
                $"WHERE notes.id = {id};");
            myCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// findNoteByID – выполняет команду SQL, которая осуществляет поиск элемента по ID.
        /// </summary>
        /// <param name="id">ID элемента - целое число</param>
        /// <returns>возвращает список List элементов типа Item </returns>
        public List<Item> findNoteByID(int id)
        {
            MySqlCommand myCommand = createComand(
                $"use `{name}`;" +
                $"select * from notes where notes.id = {id};");
            return readQuery(myCommand);
        }

        /// <summary>
        /// findNoteByName – выполняет команду SQL, которая осуществляет поиск элемента по полю количества.
        /// </summary>
        /// <param name="quantity">искомое количество</param>
        /// <returns>возвращает список List элементов типа Item</returns>
        public List<Item> findNoteByName(int quantity)
        {
            MySqlCommand myCommand = createComand(
                $"use `{name}`;" +
                $"select * from notes where notes.quantity = {quantity};");
            return readQuery(myCommand);
        }

        /// <summary>
        /// findNoteByName – выполняет команду SQL, которая осуществляет поиск элемента по полю наименования.
        /// </summary>
        /// <param name="name_">наименование товара</param>
        /// <returns>возвращает список List элементов типа Item</returns>
        public List<Item> findNoteByName(string name_)
        {
            MySqlCommand myCommand = createComand(
                $"use `{name}`;" +
                $"select * from notes where notes.name like '%{name_}%';");
            return readQuery(myCommand);
        }

        /// <summary>
        /// readQuery – возвращает результат выполнения sql-запроса в виде списка элементов типа Item.
        /// </summary>
        /// <param name="myCommand">объект команды MySql</param>
        /// <returns>возвращает список объектов типа Item</returns>
        public List<Item> readQuery(MySqlCommand myCommand)
        {
            List<Item> list = new List<Item>();
            MySqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Item item = new Item();
                    item.id = reader.GetInt32("id");
                    item.name = reader.GetString("name");
                    item.expirationDate = reader.GetDateTime("expirationDate");
                    item.productionDate = reader.GetDateTime("productionDate");
                    item.quantity = reader.GetInt32("quantity");

                    list.Add(item);
                }
                reader.Close();
            }
            return list;
        }

        /// <summary>
        /// sort – выполняет команду SQL, которая осуществляет сортировку записей в таблице по определенному полю в заданном направлении.
        /// </summary>
        /// <param name="field">поле, по которому осуществляется поиск элементов</param>
        /// <param name="direction">направление поиска</param>
        /// <returns>возвращает список List объектов типа Item</returns>
        public List<Item> sort(string field, string direction)
        {
            MySqlCommand myCommand = createComand(
                $"use `{name}`;" +
                $"select * from notes order by {field} " + $"{direction};");
            return readQuery(myCommand);
        }

    }
}
