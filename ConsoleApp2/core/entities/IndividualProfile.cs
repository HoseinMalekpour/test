public class IndividualProfile : Profile , WriteForFile
{
    public DateTime DateofRegistration { get; set; }
    
    public long Income { get; set; }    

    public TypeOFWorth Worth { get; set; }
    public string Patch { get; set; }

    public int age { get; set; }
    public void AppendAllText(string PA)
    {
        Console.WriteLine($"enter name");
        Name = Console.ReadLine();
        Console.WriteLine($"enter adres");
        Adress = Console.ReadLine();
    
        for(int i = 0; ; i++)
        {
            Console.WriteLine("DateofRegistration");
            DateofRegistration = DateTime.Parse(Console.ReadLine());
            if (checkDATE())
            {
                break;
            }
        }
        Console.WriteLine("what your TypeOFWorth");
        Console.WriteLine("1_Exempt");
        Console.WriteLine("2_Notexempt");
        var x = Console.ReadKey();
        switch (x.Key)
        {
            case (ConsoleKey.NumPad1):
                Worth = TypeOFWorth.Exempt;
                break;
            case (ConsoleKey.NumPad2):
                Worth = TypeOFWorth.Exempt;
                break;
            default:
                break;
        }
        string str = $"{Name},{Adress},{Worth.ToString()},{DateofRegistration.ToString()} ,  \n";
        File.AppendAllText(PA, str);

    }

    public void SetPATCH()
    {
        {
            Console.WriteLine("enter your patch");
            string p = Console.ReadLine() + ", individual.TXT";
            Patch = Path.Combine(p);

        }
    }
    public override int AGE()
    {
        var date1 = DateofRegistration;
        DateTime date2 = DateTime.Today;
        int daysDiff = ((TimeSpan)(date2 - date1)).Days;
        return (daysDiff/365);
    }

    public override bool checkDATE()
    {
        var date1 = DateofRegistration;
        if (date1 > DateTime.Today)
        {
            return false;
        }
        return true;

    }
    public void setage()
    {

        age = AGE();
    }


}