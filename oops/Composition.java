import java.util.*;
class College{
    private String name;
    ArrayList<Student> studentList;
    public College(String name) 
    {
       this.name = name;
    }
    public void setStudentList(){
        Student student1 = new Student("Abe");
        Student student2 = new Student("lincoln");
        Student student3 = new Student("Abraham");
        ArrayList<Student> students = new ArrayList<Student>();
        students.add(student1);
        students.add(student2);
        students.add(student3);
        this.studentList = students;
    }
    public String getName(){
      return this.name;
    }
    public List<String> getStudentList(){
    List<Student> students = this.studentList;
    List<String> names = new ArrayList<String>();
    for(Student student : students){
         names.add(student.getName());
    }
     return names;
    }
}

class Student{
    private String name;
    public Student(String name){
      this.name = name;
    }
    public String getName(){
      return this.name;
    }
}
public class Main {
    public static void main(String[] args) {
        College college1 = new College("MIB");
        college1.setStudentList();
        System.out.println("The students studying in " + college1.getName() + " college are " + college1.getStudentList());
    }
}
