public class Div{
public int div(int a , int b){
         return (a / b); }
 
public int div(int a , int b , int c){
         return ((a + b ) / c); }
 
public static void main(String args[]){
Div ob = new Div();
ob.div(10 , 2);
ob.div(10, 2 , 3);
}
}
