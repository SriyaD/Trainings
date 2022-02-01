class Person
{
  String name="John";
  public void show()
  {
    System.out.println("Student inheriting properties from Person");
  }
}
public class Student extends Person
{
  String course = "Java";
  public void show1()
  {
    System.out.println("I am a Student who belongs to Person class");
  }
  public static void main(String args[])
  {
    Student obj = new Student();
    obj.show();
    obj.show1();
    System.out.println("Name of student: " +obj.name);
    System.out.println("Course opted by the student: " +obj.course);
  }
}
