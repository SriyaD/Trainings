import java.io.*;
class Bank {
	// Private data (data hiding)  Bank_id is checked for authentication
	private long CurBalance = 0;
	long bank_id;
	String name;
	public long get_balance(long Id)
	{
		if (this.bank_id == Id) 
			return CurBalance;
		return -1;
	}
	public void set_balance(long balance, long Id)
	{
		if (this.bank_id == Id) 
			CurBalance = CurBalance + balance;
	}
}
 
public class Emp {
	public static void main(String[] args)
	{

		Bank _emp = new Bank();
		_emp.bank_id = 12345;
		_emp.name = "Roshan";
		_emp.set_balance(10000, 12345);
		long emp_balance = _emp.get_balance(12345);
		System.out.println("User Name"+ " " + _emp.name);
		System.out.println("Bank_ID"+ " " + _emp.bank_id);
		System.out.println("Current Balance"+ " " + emp_balance);
	}
}
