using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayKidsSHOP
{
    internal abstract class Item
    {
        internal abstract string Name { get; set; }
        internal abstract decimal Price { get; set; }
        internal abstract string Description { get; set; }
        internal abstract string PicturePath { get; set; }
    }
    

    internal  class Lightstick : Item
    {
        internal override string Name { get; set; }
        internal override decimal Price { get; set; }
        internal override string Description { get; set; }
        internal override string PicturePath { get; set; }


        internal Lightstick( string name, decimal price, string description, string picture )
        {
            Name = name;
            Price = price;
            Description = description;
            PicturePath = picture;
        }
    }


    internal class Album : Item
    {
        internal override string Name { get; set; }
        internal override decimal Price { get; set; }
        internal override string Description { get; set; }
        internal override string PicturePath { get; set; }


        internal string Type { get; set; }
        
        internal Album(string name, decimal price, string description, string picture)
        {
            Name = name;
            Price = price;
            Description = description;
            PicturePath = picture;
            Type = "unsigned";

        }
    }


    abstract class AlbumDecorator : Album
    {
        // Класс декоратора также хранит ссылку на декорируемый объект
        protected Album album;

        public AlbumDecorator(Album album, string name, decimal price, string description, string picture) : base(name, price, description, picture)
        {
            this.album = album;
        }
    }

    class SignedAlbum : AlbumDecorator
    {
        public SignedAlbum(Album album) : base(album, album.Name, album.Price, album.Description, album.PicturePath)
        {
            this.Type = "signed";
            this.Price += 3000;
            this.Description += "\n\nEXCLUSIVE VERSION IS SIGNED RANDOMLY BY 1 MEMBER";
        }
    }

    internal class Card : Item
    {
        internal override string Name { get; set; }
        internal override decimal Price { get; set; }
        internal override string Description { get; set; }
        internal override string PicturePath { get; set; }


        internal string Person { get; set; }

        internal Card( string name, decimal price, string description, string picture)
        {
            Name=name;
            Price = price;
            Description=description;
            PicturePath = picture;
        }

    }

    abstract class CardDecorator : Card
    {
        // Класс декоратора также хранит ссылку на декорируемый объект
        protected Card card;

        public CardDecorator(Card card, string name, decimal price, string description, string picture) : base(name, price, description, picture)
        {
            this.card = card;
        }
    }

    class PersonCard : CardDecorator
    {
        public PersonCard(Card card, string person) : base(card, card.Name, card.Price, card.Description, card.PicturePath)
        {
            this.Person = person;
        }
    }

    internal class Skzoo : Item
    {
        internal override string Name { get; set; }
        internal override decimal Price { get; set; }
        internal override string Description { get; set; }
        internal override string PicturePath { get; set; }
        internal string Clothes { get; set; }


        internal Skzoo( string name, decimal price, string description, string picture)
        {
            Name = name;
            Price = price;
            Description = description;
            PicturePath= picture;
            Clothes = "Original";
        }


    }


    abstract class SkzooDecorator : Skzoo
    {
        // Класс декоратора также хранит ссылку на декорируемый объект
        protected Skzoo skzoo;

        public SkzooDecorator(Skzoo skzoo, string name, decimal price, string description, string picture) : base(name, price, description, picture)
        {
            this.skzoo = skzoo;
        }
    }

    class SharkSkzoo : SkzooDecorator
    {
        public SharkSkzoo(Skzoo skzoo) : base(skzoo, skzoo.Name, skzoo.Price, skzoo.Description, skzoo.PicturePath)
        {
            this.Clothes = "Shark";
            this.Description += "\nClothes material: plush";
            this.Price += 200;
        }
    }

    class DinosaurSkzoo : SkzooDecorator
    {
        public DinosaurSkzoo(Skzoo skzoo) : base(skzoo, skzoo.Name, skzoo.Price, skzoo.Description, skzoo.PicturePath)
        {
            this.Clothes = "Dinosaur";
            this.Description += "\nClothes material: plush";
            this.Price += 250;
        }
    }

}
