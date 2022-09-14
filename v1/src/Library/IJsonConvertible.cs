using System;
using System.Text.Json;

namespace Person
{
    public interface IJsonConvertible
    {
        string ConvertToJson();

        void LoadFromJson(string json);
    }
}