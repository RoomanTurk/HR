
using HR;

class Karmand
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Department { get; set; }
}
class Rais:Karmand
{
    public int Sath { get; set; }
}
class Narmafzar
{
    public void Karkonan()
    {
        Karmand karmand1 = new Karmand { Name = "Hossein", Id = 1233, Department = "Hesabdari" };
        Karmand karmand2 = new Karmand { Name = "Ali", Id = 1343, Department = "Negahbani" };
        Karmand karmand3 = new Karmand { Name = "Mahdi", Id = 1143, Department = "Bimeh" };
        Karmand karmand4 = new Karmand { Name = "Davood", Id = 1243, Department = "Hesabdari" };
        Rais rais1 = new Rais { Name = "Morad", Id = 11, Department = "Senf", Sath = 3 };
        Rais rais2 = new Rais { Name = "Morad", Id = 13, Department = "Bimeh", Sath = 2 };
        double Mohasebe1 = Mohasebe.Salary(karmand1);
        double Mohasebe2 = Mohasebe.Salary(karmand2);
        double Mohasebe3 = Mohasebe.Salary(karmand3);
        double Mohasebe4 = Mohasebe.Salary(karmand4);
        double Mohasebe5 = Mohasebe.Salary(rais1);
        double Mohasebe6 = Mohasebe.Salary(rais2);
        Console.WriteLine(karmand1.Name, karmand1.Id, karmand1.Department, Mohasebe1);
        Console.WriteLine(karmand2.Name, karmand2.Id, karmand2.Department, Mohasebe2);
        Console.WriteLine(karmand3.Name, karmand3.Id, karmand3.Department, Mohasebe3);
        Console.WriteLine(karmand4.Name, karmand4.Id, karmand4.Department, Mohasebe4);
        Console.WriteLine(rais1.Name, rais1.Id, rais1.Department, Mohasebe5);
        Console.WriteLine(rais2.Name, rais2.Id, rais2.Department, Mohasebe6);
    }
}