namespace Lesson1;

internal class Praduct
{
    public Guid PraductId { get; set; }
    public string PraductName { get; set; }
    public string BussinessName { get; set; }
    public decimal Price { get; set; }
    public DateTime term { get; set; }

    override public string ToString()
    {
        return $"Praduct Id: {PraductId}\nPraduct Name: {PraductName}\nBussiness Name: {BussinessName}\nPrice: {Price}\nterm: {term}";
    }

    public int termInDays()
    {
        DateTime Now = DateTime.Now;
        int days = (Now - term).Days;
        return days;
       
    }
}
