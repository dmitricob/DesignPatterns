using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solId_InterfaceSegregation.withSOLID
{
    class Class2
    {
    }

    class Photograph
    {
        public void TakePhoto(IPhoto photoMaker)
        {
            photoMaker.TakePhoto();
        }
    }

    interface ICall
    {
        void Call();
    }
    interface IPhoto
    {
        void TakePhoto();
    }
    interface IVideo
    {
        void MakeVideo();
    }
    interface IWeb
    {
        void BrowseInternet();
    }

    class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем с помощью фотокамеры");
        }
    }

    class Phone : ICall, IPhoto, IVideo, IWeb
    {
        public void Call()
        {
            Console.WriteLine("Звоним");
        }
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем с помощью смартфона");
        }
        public void MakeVideo()
        {
            Console.WriteLine("Снимаем видео");
        }
        public void BrowseInternet()
        {
            Console.WriteLine("Серфим в интернете");
        }
    }
}
