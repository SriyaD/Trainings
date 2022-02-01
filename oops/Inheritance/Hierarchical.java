class Person
{
  public void show()
  {
  System.out.println("I am a Person");
  }
}

class Student extends Person
{
  public void show1()
  {
  System.out.println("I am a Student who is Person ");
  }
}

class Teacher extends Person
{
  public void show2()
  {
    System.out.println("I am a Teacher who is a Person");
  }
}
class Doctor extends Person
{
  public void show3()
  {
    System.out.println("I am a Doctor who is a Person");
  }
}

public class HierarchicalInheritance
{
  public static void main(String args[])
  {
    Teacher teacher = new Teacher();
    Student student = new Student();
    Doctor doctor = new Doctor();
    student.show();
    student.show1();
    teacher.show2();
    doctor.show3();
  }
}
