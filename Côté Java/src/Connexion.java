

//inspired from : http://stackoverflow.com/questions/29548559/how-to-send-simple-data-from-javascript-to-java-application
//http://stackoverflow.com/questions/12078744/inserting-variable-values-into-sql-server-using-java
//http://www.rgagnon.com/javadetails/java-0183.html
//http://stackoverflow.com/questions/1485708/how-do-i-do-a-http-get-in-java
//http://www.java2s.com/Code/Java/Network-Protocol/AverysimpleWebserverWhenitreceivesaHTTPrequestitsendstherequestbackasthereply.htm

import java.io.*; 
import java.net.*;
import java.sql.*;

import com.microsoft.sqlserver.jdbc.*;

public class Connexion {
	private void connexionHttpAJava(int port) throws Exception
	{ 
		ServerSocket socketServer = new ServerSocket(port);
		
		for(;;){
			Socket socketClient = socketServer.accept();
			BufferedReader recuGet = new BufferedReader(new InputStreamReader(socketClient.getInputStream()));
			
			String nouvelUtilisateur;
			while((nouvelUtilisateur = recuGet.readLine()) != null){
				
				if(nouvelUtilisateur.length() == 0)
					break;
				
				connexionJavaASql("nom", "mot de passe", "type d'utilisateur");
			}
			
			recuGet.close();
		}
		
	}
	
	private void connexionJavaASql(String nom, String motDePasse, String typeUtilisateur) throws Exception
	{
		Connection connexion = DriverManager.getConnection("jdbc:sqlserver://servername;database=databasename;integratedSecurity=true");
		
		Statement nouvelUtilisateur = connexion.createStatement();
		
		nouvelUtilisateur.executeUpdate("INSERT INTO ListeUtilisateurs(Adresse Courriel, Mot de passe, Type de compte)" + "VALUES(" + nom + ", " + motDePasse + ", " + typeUtilisateur + ")");
		
		connexion.close();
	}
}
