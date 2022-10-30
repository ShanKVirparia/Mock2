
List<int> driods = new List<int>()
{
    33439483,
    34349384,
    34468868,
    55569690,
    45842490,
    33939359,

};

AverageDroids(driods);

static int AverageDroids(List<int> driodNumbers)
{
    List<int> evenDriod = driodNumbers.Where(x => x % 2 == 0).ToList();

    return (int) evenDriod.Average();
}