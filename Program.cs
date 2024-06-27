using Newtonsoft.Json;
using Zelda_Project.DataModels;
using Zelda_Project.Responses;

namespace Zelda_Project;

public class Program
{
    public static void Main(string[] args)
    {
        string url = "https://zelda.fanapis.com/api/characters";

        GetZeldaAPI(url).Wait();
    }

    public static async Task GetZeldaAPI(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string results = await client.GetStringAsync(url);

            SingleResponseCharacter response = JsonConvert.DeserializeObject<SingleResponseCharacter>(results);

            MapToCharacterModel(response);

        }
    }

    public static CharacterModel MapToCharacterModel(SingleResponseCharacter response)
    {
        

        return characterModel;
    }
}
