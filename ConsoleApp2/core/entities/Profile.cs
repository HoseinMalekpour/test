public class Profile
{
    public string Name { get; set; }
    public string Adress { get; set; }
    
    public RoleEnum Role {get; set; }   

    public string NasionalCode { get; set; }

    public virtual int AGE()
    {
        return 1;
    }

    public virtual bool checkDATE()
    {
        return true;
    }




}

