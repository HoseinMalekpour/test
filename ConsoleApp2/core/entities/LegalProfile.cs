public class LegalProfile:Profile , WriteForFile
{
    public string Family { get; set; }
    public DateTime BrithDate { get; set; } 
    public string PhoneNumber { get; set; }

    public Gender gender { get; set; }  

    public string job { get; set; }

    public string Patch { get; set; }

    public int age { get; set; } 

  
    public void SetPATCH()
    {
        Console.WriteLine("enter your patch");
        string p = Console.ReadLine() + ", Legal.TXT";
        Patch = Path.Combine(p);
        var importfile = File.Create(Patch);
        importfile.Close();

    }
    public void AppendAllText(string PA)
    {
        Console.WriteLine($"enter name" );
        Name = Console.ReadLine();
        Console.WriteLine($"enter family");
        Family= Console.ReadLine();
        Console.WriteLine("enter Adress");
        Adress= Console.ReadLine();
        Console.WriteLine("enter NasionalCode");
        NasionalCode = Console.ReadLine();

        for (int i = 0; ; i++)
        {
            Console.WriteLine("BrithDate");
            BrithDate = DateTime.Parse(Console.ReadLine());
            if (checkDATE())
            {
                break;
            }
        }
        Console.WriteLine("enter Your job");
        job = Console.ReadLine();
        Console.WriteLine("what your gender");
        Console.WriteLine("1_male");
        Console.WriteLine("2_famale");
        var x = Console.ReadKey();
        switch (x.Key)
        {
            case (ConsoleKey.NumPad1):
                gender= Gender.male;
                break;
            case(ConsoleKey.NumPad2):
                gender = Gender.famale;
                break;
            default:
                break;
        }
        string str = $"{Name},{Family},{Adress},{NasionalCode},{job},{AGE()},{gender.ToString()} , {BrithDate.ToString()} \n";
        File.AppendAllText(PA,str);
    }

    public override int AGE()
    {
        var date1 = BrithDate;
        DateTime date2 = DateTime.Today;
        int daysDiff = ((TimeSpan)(date2 - date1)).Days;
        return(daysDiff/365);
    }

    public void setage()
    {

        age = AGE();
    }
    

    public override bool checkDATE()
    {
        var date1 = BrithDate;
        if (date1 > DateTime.Today)
        {
            return false;
        }
        return true;

    }


    //public static LegalProfile operator +(LegalProfile b, LegalProfile c)
    //{
    //    LegalProfile box = new LegalProfile();
    //    box.AGE() = b.AGE() * c.AGE();

    //    return box;
    //}


}
}