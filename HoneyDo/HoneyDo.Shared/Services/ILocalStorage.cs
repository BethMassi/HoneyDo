﻿namespace HoneyDo.Shared.Services
{
    public interface ILocalStorage
    {
        public string GetItem(string key);
        public void SetItem(string key, string value);
        public void RemoveItem(string key);
        
    }
}