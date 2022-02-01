import java.io.*;
class GrandParent {
    void fun() {
    	System.out.println("Grandparent");
    }
}
class Parent1 extends GrandParent {
    void fun() {
    	System.out.println("Parent1");
    }
}
class Parent2 extends GrandParent {
    void fun() {
    	System.out.println("Parent2");
    }
}
public class Test extends Parent1, Parent2 {
    public static void main(String args[]) {
    	Test t = new Test();
    	t.fun();
    }
}
