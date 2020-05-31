/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package final_project;
import java.awt.Color;
import java.awt.Dimension;
import java.sql.*;
/**
 *
 * @author michae29
 */
public class Family extends javax.swing.JFrame {

    /**
     * Creates new form Family
     */
    public Family() {
        initComponents();
    }
    public Family(Patient P1) {
        initComponents();
         
        Fname.setText(P1.getFname());
        Lname.setText(P1.getLname());
        PID.setText(Integer.toString(P1.getPID()));
       
        
        
        int ID=0;
        
        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Select * FROM `patientdb`.familyhistorytable where PatientID="+PID.getText();
    
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            ResultSet rs = stmt.executeQuery(query);
            
            
            while(rs.next())
            {
               ID=rs.getInt("FamilyID");
               
               FamBox.addItem(Integer.toString(ID));
                
            }
                
           con.close();
        }
        catch(Exception E)
        {
            System.out.println(E);
            System.out.println("In main fam page");
        }    
        
        
        PID.setEditable(false);
        Fname.setEditable(false);
        Lname.setEditable(false);
        FamilyID.setEditable(false);
        FamName.setEditable(false);
        HRF.setEditable(false);
        Lives_with.setEditable(false);
        MajorDisorder.setEditable(false);
        Relation.setEditable(false);
        SpecDisorder.setEditable(false);
        Alive.setEditable(false);
        
        
        PID.setBackground(Color.lightGray);
        Fname.setBackground(Color.lightGray);
        Lname.setBackground(Color.lightGray);
        FamilyID.setBackground(Color.lightGray);
        FamName.setBackground(Color.lightGray);
        HRF.setBackground(Color.lightGray);
        Lives_with.setBackground(Color.lightGray);
        MajorDisorder.setBackground(Color.lightGray);
        Relation.setBackground(Color.lightGray);
        SpecDisorder.setBackground(Color.lightGray);
        Alive.setBackground(Color.lightGray);
        
        New.setVisible(false);
        Save.setVisible(false);
        Delete.setVisible(false);
        Save2.setVisible(false);
        
        
    }
    
    public Family(Patient P1, FamClass F1)
    {
        initComponents();
         
        Fname.setText(P1.getFname());
        Lname.setText(P1.getLname());
        PID.setText(Integer.toString(P1.getPID()));
        
        FamName.setText(F1.getName());
        Relation.setText(F1.getRelation());
        Alive.setText(Integer.toString(F1.getAlive()));
        Lives_with.setText(Integer.toString(F1.getLives()));
        MajorDisorder.setText(F1.getDisorder());
        HRF.setText(F1.getHRF());
        
        
//        int ID=0;
//        
//        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
//        
//        String query="Select * FROM `patientdb`.familyhistorytable where PatientID="+PID.getText();
//    
//        
//        try{
//            Class.forName("com.mysql.jdbc.Driver");
//            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
//            Statement stmt=con.createStatement();
//            ResultSet rs = stmt.executeQuery(query);
//            
//            
//            while(rs.next())
//            {
//               ID=rs.getInt("FamilyID");
//               
//               FamBox.addItem(Integer.toString(ID));
//                
//            }
//                
//           con.close();
//        }
//        catch(Exception E)
//        {
//            System.out.println(E);
//            System.out.println("In main fam page");
//        }    
        
        
        PID.setEditable(false);
        Fname.setEditable(false);
        Lname.setEditable(false);
        FamilyID.setEditable(false);
        FamName.setEditable(false);
        HRF.setEditable(false);
        Lives_with.setEditable(false);
        MajorDisorder.setEditable(false);
        Relation.setEditable(false);
        SpecDisorder.setEditable(false);
        Alive.setEditable(false);
        
        
        PID.setBackground(Color.lightGray);
        Fname.setBackground(Color.lightGray);
        Lname.setBackground(Color.lightGray);
        FamilyID.setBackground(Color.lightGray);
        FamName.setBackground(Color.lightGray);
        HRF.setBackground(Color.lightGray);
        Lives_with.setBackground(Color.lightGray);
        MajorDisorder.setBackground(Color.lightGray);
        Relation.setBackground(Color.lightGray);
        SpecDisorder.setBackground(Color.lightGray);
        Alive.setBackground(Color.lightGray);
        
        New.setVisible(false);
        Save.setVisible(false);
        Delete.setVisible(false);
        Save2.setVisible(false);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        PID = new javax.swing.JTextField();
        Fname = new javax.swing.JTextField();
        Lname = new javax.swing.JTextField();
        FamBox = new javax.swing.JComboBox<>();
        jPanel2 = new javax.swing.JPanel();
        FamName = new javax.swing.JTextField();
        Relation = new javax.swing.JTextField();
        Alive = new javax.swing.JTextField();
        Lives_with = new javax.swing.JTextField();
        MajorDisorder = new javax.swing.JTextField();
        SpecDisorder = new javax.swing.JTextField();
        HRF = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        FamilyID = new javax.swing.JTextField();
        Return = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        Edit = new javax.swing.JButton();
        New = new javax.swing.JButton();
        Delete = new javax.swing.JButton();
        Save = new javax.swing.JButton();
        Save2 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        PID.setText("Patient ID");
        PID.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                PIDActionPerformed(evt);
            }
        });

        Fname.setText("Patient First Name");
        Fname.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                FnameActionPerformed(evt);
            }
        });

        Lname.setText("Patient Last Name");
        Lname.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                LnameActionPerformed(evt);
            }
        });

        FamBox.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                FamBoxItemStateChanged(evt);
            }
        });
        FamBox.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                FamBoxActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(FamBox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(40, 40, 40)
                .addComponent(PID, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(53, 53, 53)
                .addComponent(Fname, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(Lname, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(24, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(35, 35, 35)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(PID, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(Fname, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(Lname, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(FamBox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(43, Short.MAX_VALUE))
        );

        jPanel2.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        FamName.setText("jTextField1");
        jPanel2.add(FamName, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 70, -1, -1));

        Relation.setText("jTextField1");
        jPanel2.add(Relation, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 70, -1, -1));

        Alive.setText("jTextField1");
        jPanel2.add(Alive, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 70, -1, -1));

        Lives_with.setText("jTextField1");
        jPanel2.add(Lives_with, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 120, -1, -1));

        MajorDisorder.setText("jTextField1");
        jPanel2.add(MajorDisorder, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 120, -1, -1));

        SpecDisorder.setText("jTextField1");
        jPanel2.add(SpecDisorder, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 120, -1, -1));

        HRF.setText("jTextField1");
        jPanel2.add(HRF, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 170, -1, -1));

        jLabel1.setText("Family Name");
        jPanel2.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 50, -1, -1));

        jLabel2.setText("Family Relation");
        jPanel2.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 50, -1, -1));

        jLabel3.setText("Alive");
        jPanel2.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 50, -1, -1));

        jLabel4.setText("Lives with patient");
        jPanel2.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 100, -1, -1));

        jLabel5.setText("Major Disorder");
        jPanel2.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 100, -1, -1));

        jLabel6.setText("Specific Disorder");
        jPanel2.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 100, -1, -1));

        jLabel7.setText("HRF");
        jPanel2.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 150, -1, -1));

        jLabel8.setText("Family ID");
        jPanel2.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 0, -1, -1));

        FamilyID.setText("jTextField1");
        jPanel2.add(FamilyID, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 20, -1, -1));

        Return.setText("Return");
        Return.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                ReturnMouseClicked(evt);
            }
        });

        Edit.setText("Edit");
        Edit.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                EditMouseClicked(evt);
            }
        });

        New.setText("New");
        New.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                NewMouseClicked(evt);
            }
        });

        Delete.setText("Delete");
        Delete.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                DeleteMouseClicked(evt);
            }
        });

        Save.setText("Save");
        Save.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                SaveMouseClicked(evt);
            }
        });

        Save2.setText("New Family");
        Save2.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                Save2MouseClicked(evt);
            }
        });

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(25, 25, 25)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(Delete, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(Edit, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(New, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(Save, javax.swing.GroupLayout.PREFERRED_SIZE, 66, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(Save2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addComponent(Save)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(Delete)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(New)
                    .addComponent(Save2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(Edit)
                .addContainerGap(23, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 68, Short.MAX_VALUE)
                .addComponent(Return)
                .addGap(18, 18, 18))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(144, 144, 144))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(28, 28, 28)
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(29, 29, 29)
                        .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 54, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(27, 27, 27))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addComponent(Return)
                                .addGap(151, 151, 151))))))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void PIDActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_PIDActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_PIDActionPerformed

    private void FnameActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_FnameActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_FnameActionPerformed

    private void LnameActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_LnameActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_LnameActionPerformed

    private void FamBoxItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_FamBoxItemStateChanged
       FamClass FC = new FamClass();
       
      int FID=Integer.parseInt(FamBox.getSelectedItem().toString());
          FC.setData(FID);
          
          FamilyID.setText(FamBox.getSelectedItem().toString());
       
       FamName.setText(FC.getName());
       Relation.setText(FC.getRelation());
       Alive.setText(Integer.toString(FC.getAlive()));
       Lives_with.setText(Integer.toString(FC.getLives()));
       MajorDisorder.setText(FC.getDisorder());
       SpecDisorder.setText(FC.getSorder());
       HRF.setText(FC.getHRF());
       
       
       
    }//GEN-LAST:event_FamBoxItemStateChanged

    private void FamBoxActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_FamBoxActionPerformed

    }//GEN-LAST:event_FamBoxActionPerformed

    private void ReturnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ReturnMouseClicked
        this.hide();
        New_Main MP = new New_Main();
        MP.setVisible(true);        // TODO add your handling code here:
    }//GEN-LAST:event_ReturnMouseClicked

    private void EditMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_EditMouseClicked
       
        FamName.setEditable(true);
        HRF.setEditable(true);
        Lives_with.setEditable(true);
        MajorDisorder.setEditable(true);
        Relation.setEditable(true);
        SpecDisorder.setEditable(true);
        Alive.setEditable(true);
        
        FamName.setBackground(Color.white);
        HRF.setBackground(Color.white);
        Lives_with.setBackground(Color.white);
        MajorDisorder.setBackground(Color.white);
        Relation.setBackground(Color.white);
        SpecDisorder.setBackground(Color.white);
        Alive.setBackground(Color.white);
        
        Save.setVisible(true);
        Save2.setVisible(true);
        Delete.setVisible(true);
        New.setVisible(true);

    }//GEN-LAST:event_EditMouseClicked

    private void NewMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_NewMouseClicked

        FamName.setText("");
        HRF.setText("");
        Lives_with.setText("");
        MajorDisorder.setText("");
        Relation.setText("");
        SpecDisorder.setText("");
        Alive.setText("");
        
        FamName.setPreferredSize(new Dimension(73, 24));
        HRF.setPreferredSize(new Dimension(73, 24));
        Lives_with.setPreferredSize(new Dimension(73, 24));
        MajorDisorder.setPreferredSize(new Dimension(73, 24));
        Relation.setPreferredSize(new Dimension(73, 24));
        SpecDisorder.setPreferredSize(new Dimension(73, 24));
        Alive.setPreferredSize(new Dimension(73, 24));
        
        New.setVisible(false);
        Save.setVisible(false);
        Delete.setVisible(false);
        Save2.setVisible(true);
    }//GEN-LAST:event_NewMouseClicked

    private void DeleteMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_DeleteMouseClicked
            FamClass f1=new FamClass();
            f1.DeleteData(Integer.parseInt(FamilyID.getText()));
        
        
        
        
        PID.setEditable(false);
        Fname.setEditable(false);
        Lname.setEditable(false);
        FamName.setEditable(false);
        HRF.setEditable(false);
        Lives_with.setEditable(false);
        MajorDisorder.setEditable(false);
        Relation.setEditable(false);
        SpecDisorder.setEditable(false);
        Alive.setEditable(false);
        
        
        PID.setBackground(Color.lightGray);
        Fname.setBackground(Color.lightGray);
        Lname.setBackground(Color.lightGray);
        FamName.setBackground(Color.lightGray);
        HRF.setBackground(Color.lightGray);
        Lives_with.setBackground(Color.lightGray);
        MajorDisorder.setBackground(Color.lightGray);
        Relation.setBackground(Color.lightGray);
        SpecDisorder.setBackground(Color.lightGray);
        Alive.setBackground(Color.lightGray);
        
        
        New.setVisible(false);
        Save.setVisible(false);
        Delete.setVisible(false);

    }//GEN-LAST:event_DeleteMouseClicked

    private void SaveMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_SaveMouseClicked
       FamClass f1= new FamClass();
      int FID=Integer.parseInt(FamilyID.getText());
       
      f1.UpdateData(FID, FamName.getText(), Relation.getText(), Integer.parseInt(Alive.getText()),Integer.parseInt(Lives_with.getText()) , MajorDisorder.getText(), SpecDisorder.getText(), Integer.parseInt(HRF.getText()));
        
        
        
        
        
        PID.setEditable(false);
        Fname.setEditable(false);
        Lname.setEditable(false);
        FamName.setEditable(false);
        HRF.setEditable(false);
        Lives_with.setEditable(false);
        MajorDisorder.setEditable(false);
        Relation.setEditable(false);
        SpecDisorder.setEditable(false);
        Alive.setEditable(false);
        
        
        PID.setBackground(Color.lightGray);
        Fname.setBackground(Color.lightGray);
        Lname.setBackground(Color.lightGray);
        FamName.setBackground(Color.lightGray);
        HRF.setBackground(Color.lightGray);
        Lives_with.setBackground(Color.lightGray);
        MajorDisorder.setBackground(Color.lightGray);
        Relation.setBackground(Color.lightGray);
        SpecDisorder.setBackground(Color.lightGray);
        Alive.setBackground(Color.lightGray);
        
        New.setVisible(false);
        Save.setVisible(false);
        Delete.setVisible(false);

    }//GEN-LAST:event_SaveMouseClicked

    private void Save2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_Save2MouseClicked
       
        FamClass f1=new FamClass();
        
        f1.InsertData(Integer.parseInt(PID.getText()), FamName.getText(), Relation.getText(), Integer.parseInt(Alive.getText()), Integer.parseInt(Lives_with.getText()), MajorDisorder.getText(), SpecDisorder.getText(), Integer.parseInt(HRF.getText()));
        
        
        PID.setEditable(false);
        Fname.setEditable(false);
        Lname.setEditable(false);
        FamName.setEditable(false);
        HRF.setEditable(false);
        Lives_with.setEditable(false);
        MajorDisorder.setEditable(false);
        Relation.setEditable(false);
        SpecDisorder.setEditable(false);
        Alive.setEditable(false);
        
        
        PID.setBackground(Color.lightGray);
        Fname.setBackground(Color.lightGray);
        Lname.setBackground(Color.lightGray);
        FamName.setBackground(Color.lightGray);
        HRF.setBackground(Color.lightGray);
        Lives_with.setBackground(Color.lightGray);
        MajorDisorder.setBackground(Color.lightGray);
        Relation.setBackground(Color.lightGray);
        SpecDisorder.setBackground(Color.lightGray);
        Alive.setBackground(Color.lightGray);
        
        
        Save2.setVisible(false);
    }//GEN-LAST:event_Save2MouseClicked

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Family.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Family.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Family.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Family.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Family().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextField Alive;
    private javax.swing.JButton Delete;
    private javax.swing.JButton Edit;
    private javax.swing.JComboBox<String> FamBox;
    private javax.swing.JTextField FamName;
    private javax.swing.JTextField FamilyID;
    private javax.swing.JTextField Fname;
    private javax.swing.JTextField HRF;
    private javax.swing.JTextField Lives_with;
    private javax.swing.JTextField Lname;
    private javax.swing.JTextField MajorDisorder;
    private javax.swing.JButton New;
    private javax.swing.JTextField PID;
    private javax.swing.JTextField Relation;
    private javax.swing.JButton Return;
    private javax.swing.JButton Save;
    private javax.swing.JButton Save2;
    private javax.swing.JTextField SpecDisorder;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    // End of variables declaration//GEN-END:variables
}
