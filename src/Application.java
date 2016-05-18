
public class Application {

	private SystemInterface system;
	private WebInterface web;
	
	public static void main(String[] args) {
		new Application();
	}
	
	public Application(){
		system = new System();
		web = new WebAdaptator(system);
	}
	
}
