import java.util.*;
class Country{
    private String name;
    List<SportPerson> sportPersons;
    public Country(String name)  {
        this.name = name;
    }
    public void setSportPersons(List<SportPerson> sportPersons) {
        this.sportPersons = sportPersons;
    }
    public List<String> getSportPersons()
    {
      List<SportPerson> listOfSportPersons = this.sportPersons;
      List<String> names = new ArrayList<String>();
      for(SportPerson sportPerson : listOfSportPersons){
          names.add(sportPerson.getName());
      } 
      return names;
    }
     public String getName(){
      return this.name;
     }
}
class SportPerson{
    private String name;
    public SportPerson(String name){
      this.name = name;
    }
    public String getName(){
      return this.name;
    }
}
public class Main {
public static void main(String[] args) {
  SportPerson macculum = new SportPerson("Mccullum");
  SportPerson dhoni = new SportPerson("Dhoni");
  SportPerson kohli = new SportPerson("Kohli");
  Country india = new Country("India");
  List<SportPerson> sportPersons = new ArrayList<SportPerson>();
  sportPersons.add(macculum);
  sportPersons.add(dhoni);
  sportPersons.add(kohli);
  india.setSportPersons(sportPersons);
  System.out.println("The sports people from country " + india.getName() + " are " + india.getSportPersons());
}
}

