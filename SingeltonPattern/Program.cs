﻿// See https://aka.ms/new-console-template for more information
using SingeltonPattern;


while (true)
{
    Console.WriteLine("Please Enter the Id");

    int id = int.Parse(Console.ReadLine());

    //LookUpLoader lookUpLoader = lookUp

    string name = LookUpLoader.Instance.FindLookUp(id);

    Console.WriteLine($"Name = {name}");
}

