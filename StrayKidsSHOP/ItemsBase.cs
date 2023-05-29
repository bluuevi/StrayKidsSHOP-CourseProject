using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayKidsSHOP
{
    sealed class ItemsBase //класс базы товаров, имеющихся в магазине
    {
        //ИСПОЛЬЗУЕТСЯ ПАТТЕРН ОДИНОЧКА, БАЗА ТОВАРОВ МОЖЕТ БЫТЬ ТОЛЬКО ОДНА
        private static ItemsBase itemsBase; //класс хранит в себе объект самого себя, который не может быть изменен

        internal List<Lightstick> Lightsticks; //коллекция лайтстиков
        internal List<Album> Albums; //коллекция альбомов
        internal List<Card> Cards; //коллекция карточек 
        internal List<Skzoo> SKZOO; //коллекция игрушек SKZOO
        internal List<string> Categories; //коллекция названий категорий товаров
        private ItemsBase() //приватный конструктор, не может быть вызван извне (паттерн одиночка)
        {

        }

        public static ItemsBase GetInstance() //метод создания объекта базы товаров
        {
            if (itemsBase == null) //если база товаров еще не создана
            {
                itemsBase = new ItemsBase(); //создается и заполняется

                itemsBase.Lightsticks = itemsBase.getLightsticks();
                itemsBase.Albums = itemsBase.getAlbums();
                itemsBase.Cards = itemsBase.getCards();
                itemsBase.SKZOO = itemsBase.getSkzoos();

                itemsBase.Categories = itemsBase.getCategories();
            }
            return itemsBase; //иначе возврат существующей базы товаров
        }


        //метод заполнения коллекции названий категорий товаров
        internal List<string> getCategories() 
        {
            List<string> categories = new List<string>();
            categories.Add("Lightstick");
            categories.Add("Albums");
            categories.Add("Cards");
            categories.Add("SKZOO");
            return categories;
        }

        //метод заполнения коллекции лайтстиков
        internal List<Lightstick> getLightsticks()
        {
            List<Lightstick> lightsticks = new List<Lightstick>();

            //добавление лайтстика в коллекцию
            lightsticks.Add(new Lightstick("Stray Kids OFFICIAL LIGHT STICK", 3270,
                "It features a “compass without direction” and the words “You make Stray Kids Stay” as a sweet message to Stray Kids’s fans Stays. " +
                "\nStray Kids official lightstick has three different modes: Normal Mode, activated by pressing the button on the lightstick handle; Central Control Mode, used during performances; Bluetooth Control Mode, controllable via a dedicated application." +
                "\nComponents: Out Box, Light Stick, Strap" +
                "\nLight Mode: ON - BLINK - FLICKER - OFF" +
                "\nPower: 3 AAA batteries" +
                "\nWireless Control: Displays various effects by being interconnected with stage lightings, Works together with performance management via central control. (While wireless control mode is on, the general model is not available)", "Lightsticks\\0.jpg"));
            return lightsticks;
        }


        //метод заполнения коллекции альбомов
        internal List<Album> getAlbums()
        {
            List<Album> albums = new List<Album>();

            //добавление альбома в коллекцию
            albums.Add(new Album("5 STAR ★★★★★ VER. A", 2464, "Release Date: June 2, 2023" +
                "\nContents: \nPhotobook, 1 Type / W164xH224xT10(mm) / 104 Pages \nCD, 1 Type \nPhotocard, W55xH85 / Random 2 of 24 \nCartoon Postcard, 1 Type / W100xH150  \nOOTD Mini Poster, W150xH210 / Random 1 of 8 " +
                "\nSticker Set, W150xH100 / 2 Sheets", "Albums\\5starA.jpg"));
            //добавление подписанного (с помощью декоратора) альбома в коллекцию
            albums.Add(new SignedAlbum(albums[0]));

            albums.Add(new Album("5 STAR ★★★★★ VER. B", 2464, "Release Date: June 2, 2023" +
                "\nContents: \nPhotobook, 1 Type / W164xH224xT10(mm) / 104 Pages \nCD, 1 Type \nPhotocard, W55xH85 / Random 2 of 24 \nCartoon Postcard, 1 Type / W100xH150  \nOOTD Mini Poster, W150xH210 / Random 1 of 8 " +
                "\nSticker Set, W150xH100 / 2 Sheets", "Albums\\5starB.jpg"));

            albums.Add(new SignedAlbum(albums[2]));

            albums.Add(new Album("5 STAR ★★★★★ VER. C", 2464, "Release Date: June 2, 2023" +
                "\nContents: \nPhotobook, 1 Type / W164xH224xT10(mm) / 104 Pages \nCD, 1 Type \nPhotocard, W55xH85 / Random 2 of 24 \nCartoon Postcard, 1 Type / W100xH150  \nOOTD Mini Poster, W150xH210 / Random 1 of 8 " +
                "\nSticker Set, W150xH100 / 2 Sheets", "Albums\\5starC.jpg"));

            albums.Add(new SignedAlbum(albums[4]));

            albums.Add(new Album("5 STAR ★★★★★ LIMITED VER.", 3118, "Release Date: June 2, 2023" +
               "\nContents: \nPhotobook, 1 Type / W164xH224xT10(mm) / 104 Pages \nCD, 1 Type \nPhotocard, W55xH85 / Random 2 of 24 / Same as Normal Ver. \nCartoon Postcard, 1 Type / W100xH150 / Same as Normal Ver. \nOOTD Mini Poster, W150xH210 / Random 1 of 8 / Same as Normal Ver." +
               "\nSticker Set, W150xH100 / 2 Sheets / Same as Normal Ver. \n \nLimited Ver.only: \nSpecial Folded Poster, W600xH420 / Random 1 of 8 \nB - Cut Film Postcard, 1 Type / W100xH1540", "Albums\\5starL.jpg"));

            albums.Add(new SignedAlbum(albums[6]));

            albums.Add(new Album("MAXIDENT T-CRUSH ver.", 2167, "Release Date: October 8, 2022"+
                 "\nContents : Photobook, CD, Lyrics Paper, Photocards(2 of 24), Mini Poster, Face Sticker" +
                 "\nTrack list \n01.CASE 143 \n02.식혀 \n03.Give Me Your TMI \n04.SUPER BOARD \n05. 3RACHA(방찬, 창빈, 한) \n06.TASTE(리노, 현진, 필릭스) \n07.나 너 좋아하나봐(승민, 아이엔) \n08.CIRCUS(Korean Ver.)", "Albums\\MaxidentT.jpg"));

            albums.Add(new SignedAlbum(albums[8]));

            albums.Add(new Album("MAXIDENT HEART ver.", 2167, "Release Date: October 8, 2022" +
                "\nContents : Photobook, CD, Lyrics Paper, Photocards(2 of 24), Mini Poster, Face Sticker" +
                "\nTrack list \n01.CASE 143 \n02.식혀 \n03.Give Me Your TMI \n04.SUPER BOARD \n05. 3RACHA(방찬, 창빈, 한) \n06.TASTE(리노, 현진, 필릭스) \n07.나 너 좋아하나봐(승민, 아이엔) \n08.CIRCUS(Korean Ver.)", "Albums\\MaxidentH.jpg"));

            albums.Add(new SignedAlbum(albums[10]));

            albums.Add(new Album("MAXIDENT LIMITED EDITION", 3217, "Release Date: October 8, 2022" +
               "\nContents : Photobook, CD, Lyrics Paper, Photocards(2 of 24), Mini Poster, Face Sticker" + "\nLimited Edition Only : Mini Folded Poster(1 of 8), 4-Cut Photo" +
               "\nTrack list \n01.CASE 143 \n02.식혀 \n03.Give Me Your TMI \n04.SUPER BOARD \n05. 3RACHA(방찬, 창빈, 한) \n06.TASTE(리노, 현진, 필릭스) \n07.나 너 좋아하나봐(승민, 아이엔) \n08.CIRCUS(Korean Ver.)", "Albums\\MaxidentL.jpg"));

            albums.Add(new SignedAlbum(albums[12]));

            return albums;
        }

        //метод заполнения коллекции карточек
        internal List<Card> getCards()
        {
            List<Card> cards = new List<Card>();
            Card card; 
            //создание безличной карточки (она не добавляется в коллекцию)
            card = new Card("Nacific SCHOOL CONCEPT", 180, "Double-sided Lomo card \nDimensions: 5.4 * 8.6cm / 2.13 * 3.39in \nMaterial: coated paper", "Cards\\school.jpg");
            //создание 8 карточек на которых изображены конкретные люди, на основе созданной выше
            cards = create8cards(cards, card);

            card = new Card("Nacific TASTY KITCHEN", 230, "NACIFIC 18th anniversary Official selfie photo card", "Cards\\kitchen.jpg");
            cards = create8cards(cards, card);

            card = new Card("NOEASY LIMITED Cards", 340, "Official Limited cards \nSize: 54 * 86mm", "Cards\\noeasy.jpg");
            cards = create8cards(cards, card);

            return cards;
        }

        //метод создания 8 карт на которых изображены люди с конкретными именами
        internal List<Card> create8cards(List<Card> cards, Card card)
        {
            //создание 8 карт с помощью декоратора 
            cards.Add(new PersonCard(card, "Bang Chan"));
            cards.Add(new PersonCard(card, "Lee Know"));
            cards.Add(new PersonCard(card, "Changbin"));
            cards.Add(new PersonCard(card, "Hyunjin"));
            cards.Add(new PersonCard(card, "Han"));
            cards.Add(new PersonCard(card, "Felix"));
            cards.Add(new PersonCard(card, "Seungmin"));
            cards.Add(new PersonCard(card, "I.N"));
            return cards;
        }

        //метод заполнения коллекции игрушек SKZOO
        internal List<Skzoo> getSkzoos()
        {
            List<Skzoo> skzoos = new List<Skzoo>();
            //добавление игрушки в оригинальной одежде
            skzoos.Add(new Skzoo("Wolf Chan", 780, "Main material: plush \nSize: about 20cm", "Skzoos\\WolfChan.jpg"));
            //добавление игрушек с одеждой измененной с помощью декоратора
            skzoos.Add(new SharkSkzoo(skzoos[0], "Skzoos\\WolfChanS.jpg"));
            skzoos.Add(new DinosaurSkzoo(skzoos[0], "Skzoos\\WolfChanD.jpg"));

            skzoos.Add(new Skzoo("Leebit", 780, "Main material: plush \nSize: about 20cm", "Skzoos\\Leebit.jpg"));
            skzoos.Add(new SharkSkzoo(skzoos[3], "Skzoos\\LeebitS.jpg"));
            skzoos.Add(new DinosaurSkzoo(skzoos[3], "Skzoos\\LeebitD.jpg"));

            skzoos.Add(new Skzoo("DWAEKKI", 780, "Main material: plush \nSize: about 20cm", "Skzoos\\DWAEKKI.jpg"));
            skzoos.Add(new SharkSkzoo(skzoos[6], "Skzoos\\DWAEKKIS.jpg"));
            skzoos.Add(new DinosaurSkzoo(skzoos[6], "Skzoos\\DWAEKKID.jpg"));

            skzoos.Add(new Skzoo("Jiniret", 780, "Main material: plush \nSize: about 20cm", "Skzoos\\Jiniret.jpg"));
            skzoos.Add(new SharkSkzoo(skzoos[9], "Skzoos\\JiniretS.jpg"));
            skzoos.Add(new DinosaurSkzoo(skzoos[9], "Skzoos\\JiniretD.jpg"));

            skzoos.Add(new Skzoo("HAN QUOKKA", 780, "Main material: plush \nSize: about 20cm", "Skzoos\\HANQUOKKA.jpg"));
            skzoos.Add(new SharkSkzoo(skzoos[12], "Skzoos\\HANQUOKKAS.jpg"));
            skzoos.Add(new DinosaurSkzoo(skzoos[12], "Skzoos\\HANQUOKKAD.jpg"));

            skzoos.Add(new Skzoo("BbokAri", 780, "Main material: plush \nSize: about 20cm", "Skzoos\\BbokAri.jpg"));
            skzoos.Add(new SharkSkzoo(skzoos[15], "Skzoos\\BbokAriS.jpg"));
            skzoos.Add(new DinosaurSkzoo(skzoos[15], "Skzoos\\BbokAriD.jpg"));

            skzoos.Add(new Skzoo("PuppyM", 780, "Main material: plush \nSize: about 20cm", "Skzoos\\PuppyM.jpg"));
            skzoos.Add(new SharkSkzoo(skzoos[18], "Skzoos\\PuppyMS.jpg"));
            skzoos.Add(new DinosaurSkzoo(skzoos[18], "Skzoos\\PuppyMD.jpg"));

            skzoos.Add(new Skzoo("FoxI.Ny", 780, "Main material: plush \nSize: about 20cm", "Skzoos\\FoxINy.jpg"));
            skzoos.Add(new SharkSkzoo(skzoos[21], "Skzoos\\FoxINyS.jpg"));
            skzoos.Add(new DinosaurSkzoo(skzoos[21], "Skzoos\\FoxINyD.jpg"));

            return skzoos;
        }


    }


}
 