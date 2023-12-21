using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RestSharp;
using PokeTamagotchi.Controller;
using PokeTamagotchi.Model;
using PokeTamagotchi.Service;
using PokeTamagotchi.View;

namespace PokeTamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            TamagotchiContoller tamagotchiContoller = new TamagotchiContoller();
            tamagotchiContoller.Jogar();
        }
    }
}