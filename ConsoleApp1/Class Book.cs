using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Public, privat,protected
    public class Book
    {
        //Объявчление переменных
        //int, long, Guid
        private int _id;
        private string article;
        private string autor;
        private string name;
        private double price;


        //модификатор доступа Название_класса ( аргументы) {тело}
        //Модификатор доступа ыозврашаемый тип  Имя(аргумент) {тело}
        //
        public Book()
        {
           //стандартная заглушка характеристик, если нужна
        }

        //Вызывается всего один раз при созданий первого экземпляра
        static Book()
        {

        }
        //МОжно передать любые аргументы
        public Book(int id)
        {
            _id = id;
        }
        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }
        public string GetArticle()
        {
            return article;
        }
        public void SetArticle(string article)
        {
            this.article = article;
        }
    }
}
