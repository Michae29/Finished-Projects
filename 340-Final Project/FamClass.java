/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package final_project;
import java.sql.*;


public class FamClass {
    
    private int FamID;
    private int PatientID;
    private String Name;
    private String relation;
    private int Alive;
    private int Liveswith;
    private String disorder;
    private String Sdisorder;
    private String HRF;
    
    public int getFamID()
    {
        return FamID;
    }
    public int getPID()
    {
        return PatientID;
    }
    public String getName()
    {
        return Name;
    }
    public String getRelation()
    {
        return relation;
    }
    public int getAlive()
    {
        return Alive;
    }
    public int getLives()
    {
        return Liveswith;
    }
    public String getDisorder()
    {
        return disorder;
    }
    //for specific disorder
    public String getSorder()
    {
        return Sdisorder;
    }
    public String getHRF()
    {
        return HRF;
    }
    public void setName(String cname)
    {
        Name=cname;
    }
    public void setRelation(String crelation)
    {
        relation=crelation;
    }
    public void setAliver(int calive)
    {
        Alive=calive;
    }
    public void setLiveswith(int clives)
    {
        Liveswith=clives;
    }
    public void SetDisorder(String cdisorder)
    {
        disorder=cdisorder;
    }
    public void setSorder(String csorder)
    {
        Sdisorder=csorder;
    }
    public void setHRF(String cHRF)
    {
        HRF=cHRF;
    }
    
    public void setData(int FamID)
    {
        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Select * FROM patientdb.familyhistorytable where FamilyID ="+FamID;
    
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            ResultSet rs = stmt.executeQuery(query);
            
           rs.next();
            
            Name=rs.getString("Name");
            relation=rs.getString("Relation");
            Alive=rs.getInt("Alive");
            Liveswith=rs.getInt("Lives with patient");
            disorder=rs.getString("MajorDisorder");
            Sdisorder=rs.getString("SpecificTypeDisorder");
            HRF=rs.getString("DisorderHRF");
            
             
                
           con.close();
        }
        catch(Exception E)
        {
            System.out.println(E);
            System.out.println("Set Fam data");
        }
    }
    
    public void UpdateData(int FamID,String FamName,String Relation,int Alive,int Lives,String Disorder,String specOrder,int cHRF)
    {
        
        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="UPDATE patientdb.familyhistorytable SET Name = ?, Relation = ?, Alive = ?, Lives with patient = ?, MajorDisorder = ?, SpecificDisorderType = ?, DisorderHRF = ? WHERE FamilyID = "+FamID;
        
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            PreparedStatement pst = con.prepareStatement(query);
           
           pst.setString(1, FamName);
           pst.setString(2, Relation);
           pst.setInt(3, Alive);
           pst.setInt(4, Lives);
           pst.setString(5, Disorder);
           pst.setString(6, specOrder);
           pst.setInt(7, cHRF);
           
           pst.executeUpdate();
            
            con.close();
            
        }
        catch(Exception E)
        {
            System.out.println(E);
            System.out.println("Update data");
        }
    }
    public void InsertData(int PID, String FamName,String Relation,int Alive,int Lives,String Disorder,String specOrder,int cHRF)
    {      
       String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="INSERT INTO `patientdb`.`familyhistorytable`\n" +
"(`PatientID`,\n" +
"`Name`,\n" +
"`Relation`,\n" +
"`Alive`,\n" +
"`Lives with patient`,\n" +
"`MajorDisorder`,\n" +
"`SpecificTypeDisorder`,\n" +
"`DisorderHRF`)\n" +
"VALUES\n" +
"(\n" +
"<{PatientID: ?}>,\n" +
"<{Name: ?}>,\n" +
"<{Relation: ?}>,\n" +
"<{Alive: ?}>,\n" +
"<{Lives with patient:?}>,\n" +
"<{MajorDisorder:? }>,\n" +
"<{SpecificTypeDisorder: ?}>,\n" +
"<{DisorderHRF:?}>);";
        
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            PreparedStatement pst = con.prepareStatement(query);
           
            pst.setInt(1, PID);
            pst.setString(2,FamName);
            pst.setString(3, Relation);
            pst.setInt(4, Alive);
            pst.setInt(5, Lives);
            pst.setString(6, Disorder);
            pst.setString(7, specOrder);
            pst.setInt(8, cHRF);
            
            pst.executeUpdate();
           
            con.close();
            
        } 
        catch(Exception E)
        {
            System.out.println(E);
            System.out.println("Insert Data");
        }
    }
    public void DeleteData(int FID)
    {
        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Delete from patientdb.familyhistory table where FamilyID="+"'"+FID+"'";
        
   
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

}
