/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package final_project;
import java.sql.*;


public class Patient {
    private int PatientID;
    private String FirstName;
    private String LastName;
    private String MedID;
    private String MaritalStatus;
    private String Tobacco;
    private String TobaccoQuan;
    private String TobaccoDur;
    private String Alcohol;
    private String AlcoholQuan;
    private String AlcoholDur;
    private String Drug;
    private String Drugtype;
    private String Drugdur;
    private String Bloodtype;
    private String RHfact;
 
    
    public String getFname()
    {
        return FirstName;
    }
    public String getLname()
    {
        return LastName;
    }
    public int getPID()
    {
        return PatientID;
    }
    public String GetMedID()
    {
        return MedID;
    }    
    public String getStatus()
    {
        return MaritalStatus;
    }
    public String getTobacco()
    {
        return Tobacco;
    }
    public String getTobQuan()
    {
        return TobaccoQuan;
    }
    public String getTobDur()
    {
        return TobaccoDur;
    }
    public String getAlcho()
    {
        return Alcohol;
    }
    public String getAlchoQuan()
    {
        return AlcoholQuan;
    }
    public String getAlchoDur()
    {
        return AlcoholDur;
    }
    public String getDrug()
    {
        return Drug;
    }
    public String getDrugtype()
    {
        return Drugtype;
    }
    public String getDrugDur()
    {
        return Drugdur;
    }
    public String getBlood()
    {
        return Bloodtype;
    }
    public String getRH()
    {
        return RHfact;
    }
    public void setPID(int cpid)
    {
        PatientID=cpid;
    }
    public void setFname(String cfname)
    {
        FirstName=cfname;
    }
    public void setLname(String clname)
    {
        LastName=clname;
    }
    public void setMarital(String mair)
    {
        MaritalStatus=mair;
    }
    public void setTob(String tob)
    {
        Tobacco=tob;
    }
    public void setTobQuan(String quan)
    {
        TobaccoQuan=quan;
    }
    public void setTobDur(String dur)
    {
        TobaccoDur=dur;
    }
    public void setAlcho(String alco)
    {
        Alcohol=alco;
    }
    public void setAlcoQuan(String Aquan)
    {
        AlcoholQuan=Aquan;
    }
    public void setAlcoDur(String AlcoD)
    {
        AlcoholDur=AlcoD;
    }
    public void setDrug(String cdrug)
    {
        Drug=cdrug;
    }
    public void setDrugType(String type)
    {
        Drugtype=type;
    }
    public void setDrugdur(String dur)
    {
        Drugdur=dur;
    }
    public void setBlood(String btype)
    {
        Bloodtype=btype;
    }
    public void setRH(String rh)
    {
        RHfact=rh;
    }
    
    
    
    
   public void setData (int PID)
   {
       String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Select * FROM patientdb.patienttable where PatientID ="+PID;
    
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            ResultSet rs = stmt.executeQuery(query);
            
            rs.next();
               PatientID=PID;
               FirstName=rs.getString("PtFirstName");
               LastName=rs.getString("PtLastName");
                
           con.close();
        }
        catch(Exception E)
        {
            System.out.println(E);
        }
        
        
        String query1="Select * FROM patientdb.generalmedicalhistorytable where PatientID ="+PID;
    
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            ResultSet rs = stmt.executeQuery(query1);
            
            rs.next();
            
            MedID=rs.getString("GeneralMedicalHistoryID");
            MaritalStatus=rs.getString("MaritalStatus");
            Tobacco=rs.getString("Tobacco");
            TobaccoQuan=rs.getString("TobaccoQuantity");
            TobaccoDur=rs.getString("Tobaccoduraton");
            Alcohol=rs.getString("Alcohol");
            AlcoholQuan=rs.getString("AlcoholQuantity");
            AlcoholDur=rs.getString("Alcoholduration");
            Drug=rs.getString("Drug");
            Drugtype=rs.getString("DrugType");
            Drugdur=rs.getString("Drugduration");
            Bloodtype=rs.getString("BloodType");
            RHfact=rs.getString("Rh");
            
         
 
            
            
               
                
           con.close();
        }
        catch(Exception E)
        {
            System.out.println(E);
        }
        
        
   }
   public void UpdateData(int PID, String Fname, String Lname,String cMaritalStatus,String cTobacco ,String cTobaccoQuan ,String cTobaccoDur ,String cAlcohol ,String cAlcoholQuan, String cAlcoholDur, String cDrug,String cDrugtype ,String cDrugdur, String cBloodtype,String cRHfact,String cMedid)
   {
       
       PatientID=PID;
       FirstName=Fname;
       LastName=Lname;
       MaritalStatus=cMaritalStatus;
       Tobacco=cTobacco;
       TobaccoQuan=cTobaccoQuan;
       TobaccoDur=cTobaccoDur;
       Alcohol=cAlcohol;
       AlcoholQuan=cAlcoholQuan;
       AlcoholDur=cAlcoholDur;
       Drug=cDrug;
       Drugtype=cDrugtype;
       Drugdur=cDrugdur;
       Bloodtype=cBloodtype;
       RHfact=cRHfact;
       MedID=cMedid;

            String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";

            String query="update patientdb.patienttable set PtFirstName = "+"'"+FirstName+"'"+","+" PtLastName = "+"'"+LastName+"'"+" where PatientID ="+PatientID;
            
            String query2="UPDATE `patientdb`.`generalmedicalhistorytable`\n" +
"SET\n"  +
"`PatientID` = "+"'"+PatientID+"'"+"," +
"`MaritalStatus` = "+"'"+MaritalStatus+"'"+"," +
"`Tobacco` = "+"'"+Tobacco+"'"+"," +
"`TobaccoQuantity` = "+"'"+TobaccoQuan+"'"+","+
"`Tobaccoduraton` = "+"'"+TobaccoDur+"'"+"," +
"`Alcohol` = "+"'"+Alcohol+"'"+"," +
"`AlcoholQuantity` = "+"'"+AlcoholQuan+"'"+"," +
"`Alcoholduration` = "+"'"+AlcoholDur+"'"+"," +
"`Drug` = "+"'"+Drug+"'"+"," +
"`DrugType` = "+"'"+Drugtype+"'"+"," +
"`Drugduration` = "+"'"+Drugdur+"'"+"," +
"`BloodType` = "+"'"+Bloodtype+"'"+"," +
"`Rh` = "+"'"+RHfact+"'" + " where `GeneralMedicalHistoryID` = "+"'"+Integer.parseInt(MedID)+"'";

            
            


            try{
                Class.forName("com.mysql.jdbc.Driver");
                Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
                Statement stmt=con.createStatement();
                
                stmt.executeUpdate(query);
                
                stmt.executeUpdate(query2);
                   
                con.close();

            }
            catch(Exception E)
            {
                System.out.println(E);
            }
            
            
       
   }
   
   
   public void InsertData(String Fname, String Lname,String cMaritalStatus,String cTobacco ,String cTobaccoQuan ,String cTobaccoDur ,String cAlcohol ,String cAlcoholQuan, String cAlcoholDur, String cDrug,String cDrugtype ,String cDrugdur, String cBloodtype,String cRHfact,String cMedid)
   {
       
       int pid=0;
       
       FirstName=Fname;
       LastName=Lname;
       MaritalStatus=cMaritalStatus;
       Tobacco=cTobacco;
       TobaccoQuan=cTobaccoQuan;
       TobaccoDur=cTobaccoDur;
       Alcohol=cAlcohol;
       AlcoholQuan=cAlcoholQuan;
       AlcoholDur=cAlcoholDur;
       Drug=cDrug;
       Drugtype=cDrugtype;
       Drugdur=cDrugdur;
       Bloodtype=cBloodtype;
       RHfact=cRHfact;
       MedID=cMedid;
       
       String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Insert Into patientdb.patienttable (PtFirstName,PtLastName) Values"+"("+"'"+FirstName+"'"+","+"'"+LastName+"'"+")";
        
        String query1="Select MAX(PatientID) FROM patientdb.patienttable";
             
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            ResultSet rs;
            
            stmt.executeUpdate(query);
            
            rs=stmt.executeQuery(query1);
            
            rs.next();
            
            pid=Integer.parseInt(rs.getString(1));           
            
         con.close();
        }
        catch(Exception E)
        {
            System.out.println(E);
        }
        
        String query2="INSERT INTO `patientdb`.`generalmedicalhistorytable`\n" +
"(" +
"`PatientID`,\n" +
"`MaritalStatus`,\n" +
"`Tobacco`,\n" +
"`TobaccoQuantity`,\n" +
"`Tobaccoduraton`,\n" +
"`Alcohol`,\n" +
"`AlcoholQuantity`,\n" +
"`Alcoholduration`,\n" +
"`Drug`,\n" +
"`DrugType`,\n" +
"`Drugduration`,\n" +
"`BloodType`,\n" +
"`Rh`\n" +")"+
"VALUES\n" +
"("+"'"+pid+"'"+","+"'"+MaritalStatus+"'"+","+"'"+Tobacco+"'"+","+"'"+TobaccoQuan+"'"+","+"'"+TobaccoDur+"'"+","+"'"+Alcohol+"'"+","+"'"+AlcoholQuan+"'"+","+"'"+AlcoholDur+"'"+","+"'"+Drug+"'"+","+"'"+Drugtype+"'"+","+"'"+Drugdur+"'"+","+"'"+Bloodtype+"'"+","+"'"+RHfact+"'"+")"+";";
   
        
        
        
        try
        {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            
           stmt.executeUpdate(query2); 
        }
        catch(Exception E)
        {
            System.out.println(E);

        }
   }
   
   public void DeleteData(int PID,String medid)
   {
       PatientID=PID;
       MedID=medid;
       
       String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Delete from patientdb.patienttable where PatientID="+"'"+PatientID+"'";
        
        String query2="Delete from `patientdb`.`generalmedicalhistorytable` where PatientID="+"'"+PatientID+"'";
   
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            
            stmt.executeUpdate(query);
            stmt.executeUpdate(query2);
            
            con.close();
         
        }
        catch(Exception E)
        {
            System.out.println(E);
        }
       
       
   }
//   public void InsertBloodData(String cBloodtype,String cRHfact)
//   {
//       
//       int pid=0;
//       
//       
//       Bloodtype=cBloodtype;
//       RHfact=cRHfact;
//       
//       
//       String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
//        
//        String query="Insert Into patientdb.patienttable (PtFirstName,PtLastName) Values"+"("+"'"+FirstName+"'"+","+"'"+LastName+"'"+")";
//        
//        String query1="Select MAX(PatientID) FROM patientdb.patienttable";
//             
//        try{
//            Class.forName("com.mysql.jdbc.Driver");
//            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
//            Statement stmt=con.createStatement();
//            ResultSet rs;
//            
//            stmt.executeUpdate(query);
//            
//            rs=stmt.executeQuery(query1);
//            
//            rs.next();
//            
//            pid=Integer.parseInt(rs.getString(1));           
//            
//         con.close();
//        }
//        catch(Exception E)
//        {
//            System.out.println(E);
//        }
//        
//        String query2="INSERT INTO `patientdb`.`generalmedicalhistorytable`\n" +
//"(" +
//"`PatientID`,\n" +
//"`MaritalStatus`,\n" +
//"`Tobacco`,\n" +
//"`TobaccoQuantity`,\n" +
//"`Tobaccoduraton`,\n" +
//"`Alcohol`,\n" +
//"`AlcoholQuantity`,\n" +
//"`Alcoholduration`,\n" +
//"`Drug`,\n" +
//"`DrugType`,\n" +
//"`Drugduration`,\n" +
//"`BloodType`,\n" +
//"`Rh`\n" +")"+
//"VALUES\n" +
//"("+"'"+pid+"'"+","+"'"+MaritalStatus+"'"+","+"'"+Tobacco+"'"+","+"'"+TobaccoQuan+"'"+","+"'"+TobaccoDur+"'"+","+"'"+Alcohol+"'"+","+"'"+AlcoholQuan+"'"+","+"'"+AlcoholDur+"'"+","+"'"+Drug+"'"+","+"'"+Drugtype+"'"+","+"'"+Drugdur+"'"+","+"'"+Bloodtype+"'"+","+"'"+RHfact+"'"+")"+";";
//   
//        
//        
//        
//        try
//        {
//            Class.forName("com.mysql.jdbc.Driver");
//            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
//            Statement stmt=con.createStatement();
//            
//           stmt.executeUpdate(query2); 
//        }
//        catch(Exception E)
//        {
//            
//        }
//   }
    

}
