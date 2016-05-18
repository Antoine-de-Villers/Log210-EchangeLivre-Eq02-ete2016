

public class System implements SystemInterface {

	public DataBaseInterface dataBase;
	
	public System(){
		dataBase = new DataBaseAdaptator();
	}


	public void addUser() {
		dataBase.addUser();
	}

	public void connectUser() {
		//dataBase.();
	}

}
