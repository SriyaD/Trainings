interface A
{
    public void displayInfo();
}
interface B
{
    public void orderProduct();
}

class productA implements A
{
    public void displayInfo()
    {
        System.out.println("This is product A");
    }
}

class productB implements B
{
    public void orderProduct()
    {
        System.out.println("Product B is ordered");
    }
}
public class IntegrationSegregation {
    public static void main(String[] args)
    {
        productA obj = new productA();
        obj.displayInfo();

        productB obj1 = new productB();
        obj1.orderProduct();
    }
}
