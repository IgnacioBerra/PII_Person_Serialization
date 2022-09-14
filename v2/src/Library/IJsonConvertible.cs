using System.Text.Json.Serialization;

namespace Person
{
    public interface IJsonConvertible
    {
        string ConvertToJson();

        void LoadFromJson(string json);
    }
}