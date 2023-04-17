public interface ICar
{
    string GetCarName();
    IEnumerable <string> GetCarNameL();
    IEnumerable <string> GetCarEngineL();
    IEnumerable<string> GetCarAgeL();
}