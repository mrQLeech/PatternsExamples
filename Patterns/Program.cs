﻿using AbstractFactory;
using Decorator;
using FabricMethod;
using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryTest();
            FabricMethodTest();
            TestSingleton();
            TestingDecorator();

            Console.ReadKey();
        }

        

        private static void FactoryTest()
        {
            Console.WriteLine("Testing WeaponFactory");
            Console.WriteLine("Testing classic weapons");
            IWeaponFactory factory = new ClassicWeaponFactory();
            var fireStarter = new FireStarter(factory);

            fireStarter.UseGun();
            fireStarter.UseRifle();
            fireStarter.UseCanon();

            Console.WriteLine("Testing fantastic weapons");

            factory = new FantasticWeaponFactory();
            fireStarter = new FireStarter(factory);

            fireStarter.UseGun();
            fireStarter.UseRifle();
            fireStarter.UseCanon();
            Console.WriteLine("Testing weapons ended");
            Console.WriteLine();
            Console.WriteLine();
        }


        private static void FabricMethodTest()
        {
            Console.WriteLine("Testing FabricMethod");
            Console.WriteLine("Testing export to pdf");
            var exporter = Exporter.Create(FileType.Pdf);
            exporter.Export();

            Console.WriteLine("Testing export to excel");
            exporter = Exporter.Create(FileType.Excel);
            exporter.Export();

            Console.WriteLine("Testing exporters ended");
            Console.WriteLine();
            Console.WriteLine();
        }


        private static void TestSingleton()
        {
            Console.WriteLine("Test singleton");
            
            var singleton = TestingInstance.Instance;
            var single2 = TestingInstance.Instance;

            if (singleton == single2)
            {
                singleton.Test();
            }
            else
            {
                Console.WriteLine("I am not alone!!!");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void TestingDecorator()
        {
            Console.WriteLine("Test decorator");

            var glass = new CocktailGlass();
            var ingredient1 = new IngredientVodka(glass);
            ingredient1.VolumeMilliliters = 500;

            var ingredient2 = new IngredientMartini(ingredient1);
            ingredient2.VolumeMilliliters = 500;
            ingredient2.Mix();

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}