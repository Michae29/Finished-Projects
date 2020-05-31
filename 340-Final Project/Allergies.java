/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package final_project;
import java.sql.*;


public class Allergies {
    private String AID;
    private String Allergen;
    private String AllStart;
    private String AllEnd;
    private String AllDesc;
    private String AllHRF;
    
    
    public String getAID()
    {
        return AID;
    }
    public String getAllergen()
    {
        return Allergen;
    }
    public String getAllStart()
    {
        return AllStart;
    }
    public String getAllEnd()
    {
        return AllEnd;
    }
    public String getAllDesc()
    {
        return AllDesc;
    }
    public String getAllHRF()
    {
        return AllHRF;
    }
    public void setAllg(String Ali){
        Allergen=Ali;
    }
    public void setAlB(String AllB){
        AllStart=AllB;
    }
    public void setAllEnd(String AlE){
        AllEnd=AlE;
    }
    
    
    public void setData(int ALID)
    {
        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Select * FROM patientdb.allergyhistorytable where AllergyID="+ALID;
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            ResultSet rs = stmt.executeQuery(query);
            
            rs.next();
            
             AID=rs.getString(1);
             Allergen=rs.getString(3);
             AllStart=rs.getString(4);
             AllEnd=rs.getString(5);
             AllDesc=rs.getString(6);
             AllHRF=rs.getString(7);
            
            
          
                
           con.close();
        }
        catch(Exception E)
        {
            System.out.println(E);
        }
    }
    public void updateData(String ALID,String pid, String cAllergen,String AlStart,String AlEnd,String Desc,String HRF)
    {
    
        
           AID=ALID;
           Allergen=cAllergen;
           AllStart=AlStart;
           AllEnd=AlEnd;
           AllDesc=Desc;
           AllHRF=HRF;
                   
                   
        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="UPDATE patientdb.allergyhistorytable SET  PatientID = ?, Allergen = ?, AllergyStartDate = ?, AllergyEndDate = ?, AllergyDescription =  ?, AllergyHRF = ?, Deleted = ? WHERE AllergyID = "+Integer.parseInt(AID);
        
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            PreparedStatement pst = con.prepareStatement(query);
           
           pst.setInt(1, Integer.parseInt(pid));
           pst.setString(2, Allergen);
           pst.setString(3, AllStart);
           pst.setString(4, AllEnd);
           pst.setString(5, AllDesc);
           pst.setInt(6, Integer.parseInt(AllHRF));
           pst.setInt(7, 1);
           
           pst.executeUpdate();
            
            con.close();
            
        }
        catch(Exception E)
        {
            System.out.println(E);
            System.out.println("Update data");
        }
        
        
        
        
    }
    public void deletedata(int ALID)
    {
            String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Delete from patientdb.allergyhistorytable where AllergyID="+"'"+ALID+"'";
        
   
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            
            stmt.executeUpdate(query);

            
            con.close();
         
        }
        catch(Exception E)
        {
            System.out.println(E);
        }
    }
    public void insertdata(int PID,String Allergen,String AllergyStart,String AllergyEnd,String Desc,int AllergyHRF)
    {
        
        
         String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
         
         String query="INSERT INTO patientdb.allergyhistorytable (`PatientID`,`Allergen`,`AllergyStartDate`,`AllergyEndDate`,`AllergyDescription`,`AllergyHRF`) VALUES (?,?,?,?,?,?)";
         
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            PreparedStatement PS=con.prepareStatement(query);
            
            PS.setInt(1, PID);
            PS.setString(2, Allergen);
            PS.setString(3, AllergyStart);
            PS.setString(4, AllergyEnd);
            PS.setString(5, Desc);
            PS.setInt(6, AllergyHRF);
            
            PS.executeUpdate();
            
            
            
            con.close();
            
        }
        catch(Exception E)
        {
            System.out.println(E);
            System.out.println("Insert data");
        }
        
    }
    
    

}
