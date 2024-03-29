﻿using System;

namespace Singleton
{
    public class SingletonObject
    {
        private static SingletonObject instance = new SingletonObject();

        private SingletonObject(){}

        public static SingletonObject getInstance()
        {
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}
