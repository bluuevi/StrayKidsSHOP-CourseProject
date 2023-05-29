using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayKidsSHOP
{
    internal abstract class Item //абстрактный класс товар
    {
        internal abstract string Name { get; set; } 
        internal abstract decimal Price { get; set; } 
        internal abstract string Description { get; set; } 
        internal abstract string PicturePath { get; set; } 
    }
    

    internal  class Lightstick : Item //класс товаров лайтстик, наследник абстрактного товара
    {
        internal override string Name { get; set; } 
        internal override decimal Price { get; set; } 
        internal override string Description { get; set; } 
        internal override string PicturePath { get; set; } 

        //конструктор лайтстика
        internal Lightstick( string name, decimal price, string description, string picture )
        {
            Name = name;
            Price = price;
            Description = description;
            PicturePath = picture;
        }
    }


    internal class Album : Item //класс товаров альбом, наследник абстрактного товара
    {
        internal override string Name { get; set; } 
        internal override decimal Price { get; set; } 
        internal override string Description { get; set; } 
        internal override string PicturePath { get; set; } 


        internal string Type { get; set; } //тип альбома (собственное свойство, не унаследованное от родительского классса)
        
        //конструктор альбома
        internal Album(string name, decimal price, string description, string picture)
        {
            Name = name;
            Price = price;
            Description = description;
            PicturePath = picture;
            Type = "unsigned"; //по умолчанию создается неподписанный альбоом, это свойство изменяется при помощи декоратора альбомов

        }
    }

    
    abstract class AlbumDecorator : Album //абстрактный класс декоратора альбомов
    {
        // Класс декоратора также хранит ссылку на декорируемый объект
        protected Album album;

        public AlbumDecorator(Album album, string name, decimal price, string description, string picture) : base(name, price, description, picture)
        {
            this.album = album;
        }
    }

    class SignedAlbum : AlbumDecorator //конкретный декоратор альбомов
    {
        public SignedAlbum(Album album) : base(album, album.Name, album.Price, album.Description, album.PicturePath)
        {
            this.Type = "signed";  //изменяет тип альбома на подписанный
            this.Price += 3000; //увеличивает цену альбома 
            this.Description += "\n\nEXCLUSIVE VERSION IS SIGNED RANDOMLY BY 1 MEMBER"; //добавляет в описание альбома информацию о том, что он подписанный
        }
    }

    internal class Card : Item //класс товаров карточка, наследник абстрактного товара
    {
        internal override string Name { get; set; } 
        internal override decimal Price { get; set; } 
        internal override string Description { get; set; } 
        internal override string PicturePath { get; set; } 


        internal string Person { get; set; } //имя человека, который изображен на карточке (собственное свойство, не унаследованное от родительского классса)

        internal Card( string name, decimal price, string description, string picture) //конструктор карточки 
        {
            Name=name;
            Price = price;
            Description=description;
            PicturePath = picture;
            //свойство Person заполняется при помощи декоратора, недекорированных карточек в магазине нет
        }

    }

    abstract class CardDecorator : Card //абстрактный класс декоратора карточек
    {
        // Класс декоратора также хранит ссылку на декорируемый объект
        protected Card card;

        public CardDecorator(Card card, string name, decimal price, string description, string picture) : base(name, price, description, picture)
        {
            this.card = card;
        }
    }

    class PersonCard : CardDecorator //конкретный класс декоратора карточек
    {
        public PersonCard(Card card, string person) : base(card, card.Name, card.Price, card.Description, card.PicturePath)
        {
            this.Person = person; //заполняет свойство имени человека, изображенного на карточке
        }
    }

    internal class Skzoo : Item //класс товаров игрушка SKZOO, наследник абстрактного товара
    {
        internal override string Name { get; set; } 
        internal override decimal Price { get; set; } 
        internal override string Description { get; set; } 
        internal override string PicturePath { get; set; } 
        internal string Clothes { get; set; } //одежда игрушки (собственное свойство, не унаследованное от родительского классса)


        internal Skzoo( string name, decimal price, string description, string picture) //конструктор игрушки
        {
            Name = name;
            Price = price;
            Description = description;
            PicturePath= picture;
            Clothes = "Original"; //по умолчанию одежда игрушки оригинальная, изменяется в декораторе
        }


    }


    abstract class SkzooDecorator : Skzoo //абстрактный класс декоратора игрушек SKZOO
    {
        // Класс декоратора также хранит ссылку на декорируемый объект
        protected Skzoo skzoo;

        public SkzooDecorator(Skzoo skzoo, string name, decimal price, string description, string picture) : base(name, price, description, picture)
        {
            this.skzoo = skzoo;
        }
    }

    class SharkSkzoo : SkzooDecorator //конкретный декоратор игрушек. меняет одежду на акулу
    {
        public SharkSkzoo(Skzoo skzoo, string picture) : base(skzoo, skzoo.Name, skzoo.Price, skzoo.Description, skzoo.PicturePath)
        {
            this.Clothes = "Shark"; //изменение одежды
            this.Description += "\nClothes material: plush"; //добавление в описание информации об одежде
            this.Price += 200; //изменение цены
            this.PicturePath = picture; //изменение картинки
        }
    }

    class DinosaurSkzoo : SkzooDecorator //конкретный декоратор игрушек. меняет одежду на динозавра
    {
        public DinosaurSkzoo(Skzoo skzoo, string picture) : base(skzoo, skzoo.Name, skzoo.Price, skzoo.Description, skzoo.PicturePath)
        {
            this.Clothes = "Dinosaur"; //изменение одежды
            this.Description += "\nClothes material: plush"; //добавление в описание информации об одежде
            this.Price += 250; //изменение цены
            this.PicturePath = picture; //изменение картинки

        }
    }

}
