﻿using System.IO;
using System;

namespace CALibrary.Handlers
{
    public class StreamHandler : IStreamHandler, IDisposable 
    {   
        private StreamReader _streamReader;
        
        public void InitializeReader(string path) 
        {
            _streamReader = new StreamReader(path);
        }

        public string ReadLine()
        {
            return  _streamReader.ReadLine();
        }

        public void Dispose()
        {
            _streamReader.Dispose();
        }
    }
}
