class Person
{
  public void show()
  {
    System.out.println("Student inheriting properties from Person");
  }
}
class Student extends Person
{
  public void show1()
  {
      System.out.println("I am a Student who belongs to Person class");
  }
}
class EngineeringStudent extends Student
{
  public void show2()
  {
    System.out.println("Engineering Student inheriting properties from Student");
  }
}
public class MultilevelDemo
{
  public static void main(String args[])
  {
    EngineeringStudent obj = new EngineeringStudent();
    obj.show();
    obj.show1();
    obj.show2();
  }
}
