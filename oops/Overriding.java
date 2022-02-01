class Parent {
void show(){
System.out.println("parent class method");
}
class Child extends Parent {
void show(){
super.show();
System.out.println("child class method");
}
public static void main(String args[]){
Parent ob = new Child();
ob.show();
}
}

