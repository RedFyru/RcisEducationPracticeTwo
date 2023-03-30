using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
//Задание 2.6

namespace WetherApp
{
    class RKIS
    {
        static void Main()
        {
            Console.Write("Введите название города: ");
            string city = Console.ReadLine();
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=121b99524c6ee2041f69964391811935&units=metric&lang=ru";
            HttpWebRequest WeatherSet = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse WeatherGet = (HttpWebResponse)WeatherSet.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(WeatherGet.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            Weather weather = JsonConvert.DeserializeObject<Weather>(response);
            Console.WriteLine($"\nПогода в {weather.Name} \nТемператру: {weather.Main.Temp}°C " +
                $"\nОщущается как: {weather.Main.feels_like}°C \nВетер: {weather.wind.speed} м/с " +
                $"\nВидимость: {weather.visibility} м \n{weather.weather[0].description}");
        }
    }
}