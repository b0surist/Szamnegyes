using SzamnegyesApi;

namespace SzamnegyesApi;

public class FourNumberService
{
    private readonly List<FourNumber.FourNumbers> _fours = new();
    private int _nextId = 1; 

    public List<FourNumber.FourNumbers> GetAll() => _fours;

    public FourNumber.FourNumbers? GetById(int id) => _fours.FirstOrDefault(f => f.Id == id);

    public string Add(FourNumber.FourNumbers four)
    {
        if (four.Numbers.Length != 4)
            return "Invalid data";
        
        if (_fours.Any(f => f.Numbers.SequenceEqual(four.Numbers)))
            return "Already exists";

        four.Id = _nextId++;
        _fours.Add(four);
        return "Success";
    }
}