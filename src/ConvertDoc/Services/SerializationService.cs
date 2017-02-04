using System;
using System.IO;
using Newtonsoft.Json;

namespace ConvertDoc.Services
{
    public class JsonSerializationService
    {
        public T Deserialize<T>(String filePath)
        {
            try
            {
                var fileContent = File.ReadAllText(filePath);
                var result = JsonConvert.DeserializeObject<T>(fileContent);
                return result;
            }
            catch (Exception e)
            {
                
                throw;
            }
        }
    }
}