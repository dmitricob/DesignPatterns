using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solId_InterfaceSegregation.noSOLID
{
    class Class2
    {
    }
    class Photograph
    {
        public void TakePhoto(Phone phone)
        {
            phone.TakePhoto();
        }
    }
    interface IPhone
    {
        void Call();
        void TakePhoto();
        void MakeVideo();
        void BrowseInternet();
    }
    class Phone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Звоним");
        }
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
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
    class Camera : IPhone
    {
        public void Call() { }
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
        }
        public void MakeVideo() { }
        public void BrowseInternet() { }
    }
}
