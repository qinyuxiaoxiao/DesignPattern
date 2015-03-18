﻿using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register.Terry
{
    public class Printer
    {
        private static readonly Dictionary<string, Printer> _printers = new Dictionary<string,Printer>();

        /// <summary>
        /// Here should be "protected", because when instantiating its children class, it will call base class' constructor
        /// </summary>
        protected Printer()
        {
        }

        protected void Register(string key)
        {
            if (!_printers.ContainsKey(key))
            {
                _printers.Add(key, this);
            }
            else
            {
                _printers[key] = this;
            }
        }
        
        public static Printer GetInstance(string classFullName)
        {
            return _printers[classFullName];
        }

        /*
        
        /// <summary>
        /// Get instance according to the key stored in Environment variables
        /// </summary>
        public static Printer Instance
        {
            get
            {
                string key = GetEnvKey();
                return _printers[key];
            }
        }       
        
        /// <summary>
        /// Get key from Environment variables
        /// </summary>
        /// <returns></returns>
        private static string GetEnvKey()
        {
            var key = string.Empty;
            // Code to get key from Environment variables
            return key;
        }
        
        */

        public virtual void Print(object printItem)
        {
            Console.WriteLine("Printer is printing: " + printItem.ToString());
        }

    }
}