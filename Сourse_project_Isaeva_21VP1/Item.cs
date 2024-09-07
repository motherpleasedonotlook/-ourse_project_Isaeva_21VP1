using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Сourse_project_Isaeva_21VP1
{
    /// <summary>
    /// Класс Item - хранит записи о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// поле id товара
        /// </summary>
        public int id;
        /// <summary>
        /// поле наименование товара
        /// </summary>
        public string name;
        /// <summary>
        /// поле дата производства товара
        /// </summary>
        public DateTime productionDate;
        /// <summary>
        /// поле дата истечения срока хранения товара
        /// </summary>
        public DateTime expirationDate;
        /// <summary>
        /// поле количество товара на складе
        /// </summary>
        public int quantity;
        /// <summary>
        /// количество созданных объектов
        /// </summary>
        public static int count = 0;

        /// <summary>
        /// конструктор объекта класса Item. Заполняет поля значениями по умолчанию
        /// </summary>
        public Item()
        {
            id = count++;
            name = "Наименование";
            productionDate = DateTime.Now;
            expirationDate = DateTime.Now;
            quantity = 0;
            count++;
        }
        /// <summary>
        /// конструктор объекта класса Item. Заполняет поля указанными значениями
        /// </summary>
        /// <param name="id">id элемнта, целое число</param>
        /// <param name="name">наименование, строка</param>
        /// <param name="productionDate">дата производства, тип DateTime</param>
        /// <param name="expirationDate">дата истечения срока годности, тип DateTime</param>
        /// <param name="quantity">количество товара, целое число</param>
        public Item(int id, string name, DateTime productionDate, DateTime expirationDate, int quantity)
        {
            this.id = id;
            this.name = name;
            this.productionDate = productionDate;
            this.expirationDate = expirationDate;
            this.quantity = quantity;
            count++;
        }
        /// <summary>
        /// перегружает метод toString для объекта класса Item
        /// </summary>
        /// <returns>возвращает строку</returns>
        public override string ToString()
        {
            return "ID: " + id + "\nНаименование: " + name + "\nКоличество на складе: " + quantity + "\nДата производства: " + productionDate + "\nДата истечения срока: " + expirationDate + "\n\n";
        }
    }

}
