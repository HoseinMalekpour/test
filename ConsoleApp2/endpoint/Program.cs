meno();


void meno()
{
    Console.WriteLine("welcome");
    Console.WriteLine("chose your action");

    Console.WriteLine("1-add row in file");
    Console.WriteLine("2-show information");
    Console.WriteLine("3-Bubble Sort");
    var m = Console.ReadKey();
    switch (m.Key) 
    {
        case (ConsoleKey.NumPad1):
            add();
            break;
        case(ConsoleKey.NumPad2):
            mainmeno();
            break;
        case(ConsoleKey.NumPad3):
            sortt();
            break;
        default:
            break;
    }
}

void mainmeno()
{

    Console.WriteLine("information");
    Console.WriteLine("1-info of indiviful");
    Console.WriteLine("2-info of legal");
    var k = Console.ReadKey();
    switch(k.Key)
    {
        case (ConsoleKey.NumPad1):
           
            List<LegalProfile> listsoflegal = new List<LegalProfile>();
            Console.WriteLine("enter your patch");
            string pat = Console.ReadLine();
            try
            {
                var line = File.ReadAllLines(pat);

            }
            catch (IOException ex )
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("******");
                Console.WriteLine("file nist ");
                mainmeno();
            }
            var linee = File.ReadAllLines(pat);
            foreach (var item in linee)
            {
                var data = item.Split(",").ToList<string>();
                LegalProfile oneperson = new LegalProfile();
                oneperson.Name = data[0];
                oneperson.Family = data[1];
                oneperson.Adress = data[2];
                oneperson.NasionalCode = data[3];
                oneperson.job = data[4];
                oneperson.BrithDate = DateTime.Parse(data[6]);
                listsoflegal.Add(oneperson);
            }
            foreach(var item in listsoflegal)
            {
                Console.WriteLine($"name = {item.Name} *** family = {item.Family} **** age ={item.AGE()}  ");

            }
            break;
        case (ConsoleKey.NumPad2):
            List<IndividualProfile> listofindividal = new List<IndividualProfile>();
            Console.WriteLine("enter your patch");
            string pat2 = Console.ReadLine();
            var line2 = File.ReadAllLines(pat2);
            foreach (var item in line2)
            {
                var data = item.Split(",").ToList<string>();
                IndividualProfile oneperson = new IndividualProfile();
                oneperson.Name = data[0];
                oneperson.Adress = data[1];
                if (data[2] == "Exempt")
                {
                    oneperson.Worth = TypeOFWorth.Exempt;
                }
                else
                    oneperson.Worth = TypeOFWorth.Notexempt;
                oneperson.DateofRegistration = DateTime.Parse(data[3]);
                listofindividal.Add(oneperson);
            }
            foreach (var item in listofindividal)
            {
                Console.WriteLine($"name = {item.Name} *** family = {item.Adress} ****  age ={item.AGE()}  Worth={item.Worth.ToString()}");

            }
            break;
    }

}
    void add(){

    Console.WriteLine("add row");
    Console.WriteLine("enter role ");
    Console.WriteLine("1_LegalProfile");
    Console.WriteLine("2_IndividualProfile");
    var x = Console.ReadKey();
    switch (x.Key)
    {
        case (ConsoleKey.NumPad1):
            LegalProfile legal2 = new();
            legal2.SetPATCH();
            for (int i = 0; ; i++)
            {
                LegalProfile legal = new();

                legal.AppendAllText(legal2.Patch);
                Console.WriteLine("enter N for end");
                var ent = Console.ReadKey();
                if (ent.Key == ConsoleKey.N)
                    break;
                Console.Clear();
            }

            break;
        case (ConsoleKey.NumPad2):
            IndividualProfile individual2 = new();
            individual2.SetPATCH();
            for (int i = 0; ; i++)
            {
                LegalProfile legal = new();

                legal.AppendAllText(individual2.Patch);
                Console.WriteLine("enter N for end");
                var ent = Console.ReadKey();
                if (ent.Key == ConsoleKey.N)
                    break;
                Console.Clear();
            }

            break;
        default:
            break;
    }

}
void sortt()
{

    Console.WriteLine("1-info of indiviful");
    Console.WriteLine("2-info of legal");
    var k = Console.ReadKey();
    switch (k.Key)
    {
        case (ConsoleKey.NumPad1):

            List<LegalProfile> listsoflegal = new List<LegalProfile>();
            Console.WriteLine("enter your patch");
            string pat = Console.ReadLine();
            try
            {
                var line = File.ReadAllLines(pat);

            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("******");
                Console.WriteLine("file nist ");
                mainmeno();
            }
            var linee = File.ReadAllLines(pat);
            foreach (var item in linee)
            {
                var data = item.Split(",").ToList<string>();
                LegalProfile oneperson = new LegalProfile();
                oneperson.Name = data[0];
                oneperson.Family = data[1];
                oneperson.Adress = data[2];
                oneperson.NasionalCode = data[3];
                oneperson.job = data[4];
                oneperson.BrithDate = DateTime.Parse(data[6]);

                listsoflegal.Add(oneperson);
            }
            var dd = listsoflegal.Select(x => new { x.age }).ToList();
            int[] intArray1 = new int[dd.Count()];

            for(int i = 0 ; i<dd.Count; i++)
            {
                intArray1[i] =Convert.ToInt32(dd[i]);
            }
            babelsort(intArray1);


            break;
        case (ConsoleKey.NumPad2):
            List<IndividualProfile> listofindividal = new List<IndividualProfile>();
            Console.WriteLine("enter your patch");
            string pat2 = Console.ReadLine();
            var line2 = File.ReadAllLines(pat2);
            foreach (var item in line2)
            {
                var data = item.Split(",").ToList<string>();
                IndividualProfile oneperson = new IndividualProfile();
                oneperson.Name = data[0];
                oneperson.Adress = data[1];
                if (data[2] == "Exempt")
                {
                    oneperson.Worth = TypeOFWorth.Exempt;
                }
                else
                    oneperson.Worth = TypeOFWorth.Notexempt;
                oneperson.DateofRegistration = DateTime.Parse(data[3]);
                listofindividal.Add(oneperson);
            }
            var ddd = listofindividal.Select(x => new { x.age }).ToList();
            int[] intArray2 = new int[ddd.Count()];

            for (int i = 0; i < ddd.Count; i++)
            {
                intArray2[i] = Convert.ToInt32(ddd[i]);
            }
            babelsort(intArray2);
            break;
    }
}

void babelsort(int[]  a )
{

    int t;
    Console.WriteLine("The Array is : ");
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
    for (int j = 0; j <= a.Length - 2; j++)
    {
        for (int i = 0; i <= a.Length - 2; i++)
        {
            if (a[i] > a[i + 1])
            {
                t = a[i + 1];
                a[i + 1] = a[i];
                a[i] = t;
            }
        }
    }
    Console.WriteLine("The Sorted Array :");
    foreach (int aray in a)
        Console.Write(aray + " ");



}


