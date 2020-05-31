/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package final_project;

import java.awt.Color;
import java.sql.*;
import java.awt.*;
/**
 *
 * @author michae29
 */
public class Allergy extends javax.swing.JFrame {

    /**
     * Creates new form Allergy
     */
    public Allergy() {
        initComponents();
    }
    public Allergy(Patient P1)
    {
        initComponents();
        
        Fname.setText(P1.getFname());
        Lname.setText(P1.getLname());
        PID.setText(Integer.toString(P1.getPID()));
        
        
        
        int ID=0;
        
        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
        
        String query="Select * FROM `patientdb`.`allergyhistorytable` where PatientID="+PID.getText();
    
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(dbUrl,"root","CNIT350");
            Statement stmt=con.createStatement();
            ResultSet rs = stmt.executeQuery(query);
            
            
            while(rs.next())
            {
               ID=rs.getInt("AllergyID");
               
               Allergybox.addItem(Integer.toString(ID));
                
            }
                
           con.close();
        }
        catch(Exception E)
        {
            System.out.println(E);
            System.out.println("In main allergy page");
        }    
        
       
        PID.setEditable(false);
        Fname.setEditable(false);
        Lname.setEditable(false);
        AllergyID.setEditable(false);
        Allergen.setEditable(false);
        AllergyStart.setEditable(false);
        AllergyEnd.setEditable(false);
        Desc.setEditable(false);
        AllergyHRF.setEditable(false);
        
        
        PID.setBackground(Color.lightGray);
        Fname.setBackground(Color.lightGray);
        Lname.setBackground(Color.lightGray);
        AllergyID.setBackground(Color.lightGray);
        Allergen.setBackground(Color.lightGray);
        AllergyStart.setBackground(Color.lightGray);
        AllergyEnd.setBackground(Color.lightGray);
        Desc.setBackground(Color.lightGray);
        AllergyHRF.setBackground(Color.lightGray);
        
        Save.setVisible(false);
        Delete.setVisible(false);
        New.setVisible(false);
        Save2.setVisible(false);
    }
    
    public Allergy(Patient P1, Allergies A1)
    {
        initComponents();
        
        Allergen.setText(A1.getAllergen());
        AllergyStart.setText(A1.getAllStart());
        AllergyEnd.setText(A1.getAllEnd());
        Desc.setText((A1.getAllDesc()));
        AllergyHRF.setText(A1.getAllHRF());
        
        Fname.setText(P1.getFname());
        Lname.setText(P1.getLname());
        PID.setText(Integer.toString(P1.getPID()));
        
        
        
//        int ID=0;
//        
//        String dbUrl="jdbc:mysql://localhost:3306/PatientDB?autoReconnect=true&useSSL=false";
//        
//        String query="Select * FROM `patientdb`.`allergyhistorytable` where PatientID="+PID.getText();
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
//               ID=rs.getInt("AllergyID");
//               
//               Allergybox.addItem(Integer.toString(ID));
//                
//            }
//                
//           con.close();
//        }
//        catch(Exception E)
//        {
//            System.out.println(E);
//            System.out.println("In main allergy page");
//        }    
        
       
        PID.setEditable(false);
        Fname.setEditable(false);
        Lname.setEditable(false);
        AllergyID.setEditable(false);
        Allergen.setEditable(false);
        AllergyStart.setEditable(false);
        AllergyEnd.setEditable(false);
        Desc.setEditable(false);
        AllergyHRF.setEditable(false);
        
        
        PID.setBackground(Color.lightGray);
        Fname.setBackground(Color.lightGray);
        Lname.setBackground(Color.lightGray);
        AllergyID.setBackground(Color.lightGray);
        Allergen.setBackground(Color.lightGray);
        AllergyStart.setBackground(Color.lightGray);
        AllergyEnd.setBackground(Color.lightGray);
        Desc.setBackground(Color.lightGray);
        AllergyHRF.setBackground(Color.lightGray);
        
        Save.setVisible(false);
        Delete.setVisible(false);
        New.setVisible(false);
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
        Allergybox = new javax.swing.JComboBox<>();
        jPanel2 = new javax.swing.JPanel();
        AllergyEnd = new javax.swing.JTextField();
        AllergyHRF = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        AllergyID = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        Allergen = new javax.swing.JTextField();
        AllergyStart = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        Desc = new javax.swing.JTextArea();
        Return = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        Save = new javax.swing.JButton();
        Delete = new javax.swing.JButton();
        New = new javax.swing.JButton();
        Edit = new javax.swing.JButton();
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

        Allergybox.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                AllergyboxItemStateChanged(evt);
            }
        });
        Allergybox.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                AllergyboxActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(Allergybox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
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
                    .addComponent(Allergybox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(43, Short.MAX_VALUE))
        );

        AllergyEnd.setText("jTextField1");

        AllergyHRF.setText("jTextField1");

        jLabel1.setText("Allergy ID");

        jLabel2.setText("Description");

        jLabel3.setText("End");

        jLabel4.setText("Allergen");

        jLabel5.setText("Start");

        AllergyID.setText("jTextField1");

        jLabel6.setText("Allergy HRF");

        Allergen.setText("jTextField1");

        AllergyStart.setText("jTextField1");

        Desc.setColumns(20);
        Desc.setRows(5);
        jScrollPane1.setViewportView(Desc);

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(54, 54, 54)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(AllergyID, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(AllergyStart, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGroup(jPanel2Layout.createSequentialGroup()
                                        .addGap(6, 6, 6)
                                        .addComponent(jLabel2)))
                                .addGap(61, 61, 61)
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(jPanel2Layout.createSequentialGroup()
                                        .addGap(6, 6, 6)
                                        .addComponent(jLabel6))
                                    .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(AllergyEnd, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(Allergen, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addGap(11, 11, 11)
                                .addComponent(jLabel1)
                                .addGap(78, 78, 78)
                                .addComponent(jLabel4))
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addGap(22, 22, 22)
                                .addComponent(jLabel5)
                                .addGap(112, 112, 112)
                                .addComponent(jLabel3))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                                .addComponent(AllergyHRF, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(3, 3, 3))))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 154, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(72, Short.MAX_VALUE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGap(16, 16, 16)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(jLabel1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(AllergyID, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(Allergen, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(4, 4, 4)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(jLabel3))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(AllergyStart, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(AllergyEnd, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(jLabel6))
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addComponent(AllergyHRF, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(4, 4, 4)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 106, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        Return.setText("Return");
        Return.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                ReturnMouseClicked(evt);
            }
        });

        Save.setText("Save");
        Save.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                SaveMouseClicked(evt);
            }
        });

        Delete.setText("Delete");
        Delete.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                DeleteMouseClicked(evt);
            }
        });

        New.setText("New");
        New.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                NewMouseClicked(evt);
            }
        });

        Edit.setText("Edit");
        Edit.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                EditMouseClicked(evt);
            }
        });

        Save2.setText("New Allergy");
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
                .addGap(16, 16, 16)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(New, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(Save, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(Delete, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(Edit, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(Save2)
                .addContainerGap(19, Short.MAX_VALUE))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(15, 15, 15)
                .addComponent(Save)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(Delete)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(New)
                    .addComponent(Save2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(Edit)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(220, 220, 220)
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(25, 25, 25)
                        .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(13, 13, 13)))
                .addGap(54, 54, 54)
                .addComponent(Return)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(29, 29, 29)
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(91, 91, 91)
                                .addComponent(Return))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap(91, Short.MAX_VALUE))))
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

    private void AllergyboxActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_AllergyboxActionPerformed
     
        
        
    }//GEN-LAST:event_AllergyboxActionPerformed

    private void AllergyboxItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_AllergyboxItemStateChanged
        Allergies A1 = new Allergies();
        int Alid=Integer.parseInt(Allergybox.getSelectedItem().toString());
       
        A1.setData(Alid);
       
        AllergyID.setText(A1.getAID());
        Allergen.setText(A1.getAllergen());
        AllergyStart.setText(A1.getAllStart());
        AllergyEnd.setText(A1.getAllEnd());
        Desc.setText(A1.getAllDesc());
        AllergyHRF.setText(A1.getAllHRF());
    }//GEN-LAST:event_AllergyboxItemStateChanged

    private void EditMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_EditMouseClicked
        
        Allergen.setEditable(true);
        AllergyStart.setEditable(true);
        AllergyEnd.setEditable(true);
        Desc.setEditable(true);
        AllergyHRF.setEditable(true);
        
        Allergen.setBackground(Color.white);
        AllergyStart.setBackground(Color.white);
        AllergyEnd.setBackground(Color.white);
        Desc.setBackground(Color.white);
        AllergyHRF.setBackground(Color.white);
        
        
        Save.setVisible(true);
        Save2.setVisible(true);
        Delete.setVisible(true);
        New.setVisible(true);
    }//GEN-LAST:event_EditMouseClicked

    private void NewMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_NewMouseClicked
        
        
        
        Allergen.setText("");
        AllergyStart.setText("");
        AllergyEnd.setText("");
        Desc.setText("");
        AllergyHRF.setText("");
        
        Allergen.setPreferredSize(new Dimension(73, 24));
        AllergyStart.setPreferredSize(new Dimension(73, 24));
        AllergyEnd.setPreferredSize(new Dimension(73, 24));
        Desc.setPreferredSize(new Dimension(73, 24));
        AllergyHRF.setPreferredSize(new Dimension(73, 24));
        

        
    }//GEN-LAST:event_NewMouseClicked
        //Save button
    private void SaveMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_SaveMouseClicked
        Allergies A1 = new Allergies();
       
        
        A1.updateData(AllergyID.getText(),PID.getText(),Allergen.getText(),AllergyStart.getText(),AllergyEnd.getText(),Desc.getText(),AllergyHRF.getText());
        
        Save.setVisible(false);
        Delete.setVisible(false);
        New.setVisible(false);
        
        Allergen.setBackground(Color.lightGray);
        AllergyStart.setBackground(Color.lightGray);
        AllergyEnd.setBackground(Color.lightGray);
        Desc.setBackground(Color.lightGray);
        AllergyHRF.setBackground(Color.lightGray);
        
         Allergen.setEditable(false);
        AllergyStart.setEditable(false);
        AllergyEnd.setEditable(false);
        Desc.setEditable(false);
        AllergyHRF.setEditable(false);
    }//GEN-LAST:event_SaveMouseClicked

    private void DeleteMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_DeleteMouseClicked
        Allergies A1 = new Allergies();
        
        A1.deletedata(Integer.parseInt(AllergyID.getText()));
        
        Save.setVisible(false);
        Delete.setVisible(false);
        New.setVisible(false);
        
        Allergen.setBackground(Color.lightGray);
        AllergyStart.setBackground(Color.lightGray);
        AllergyEnd.setBackground(Color.lightGray);
        Desc.setBackground(Color.lightGray);
        AllergyHRF.setBackground(Color.lightGray);
        
        Allergen.setEditable(false);
        AllergyStart.setEditable(false);
        AllergyEnd.setEditable(false);
        Desc.setEditable(false);
        AllergyHRF.setEditable(false);
        
    }//GEN-LAST:event_DeleteMouseClicked

    private void ReturnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ReturnMouseClicked
          this.hide();
        New_Main MP = new New_Main();
        MP.setVisible(true);
    }//GEN-LAST:event_ReturnMouseClicked

    private void Save2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_Save2MouseClicked

        Allergies A1 = new Allergies();
        
        A1.insertdata(Integer.parseInt(PID.getText()),Allergen.getText(),AllergyStart.getText(),AllergyEnd.getText(),Desc.getText(),Integer.parseInt(AllergyHRF.getText()));
        
        Save2.setVisible(false);
        Save.setVisible(false);
        Delete.setVisible(false);
        New.setVisible(false);
        
        
        Allergen.setBackground(Color.lightGray);
        AllergyStart.setBackground(Color.lightGray);
        AllergyEnd.setBackground(Color.lightGray);
        Desc.setBackground(Color.lightGray);
        AllergyHRF.setBackground(Color.lightGray);
        
        Allergen.setEditable(false);
        AllergyStart.setEditable(false);
        AllergyEnd.setEditable(false);
        Desc.setEditable(false);
        AllergyHRF.setEditable(false);
        
        
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
            java.util.logging.Logger.getLogger(Allergy.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Allergy.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Allergy.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Allergy.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Allergy().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextField Allergen;
    private javax.swing.JTextField AllergyEnd;
    private javax.swing.JTextField AllergyHRF;
    private javax.swing.JTextField AllergyID;
    private javax.swing.JTextField AllergyStart;
    private javax.swing.JComboBox<String> Allergybox;
    private javax.swing.JButton Delete;
    private javax.swing.JTextArea Desc;
    private javax.swing.JButton Edit;
    private javax.swing.JTextField Fname;
    private javax.swing.JTextField Lname;
    private javax.swing.JButton New;
    private javax.swing.JTextField PID;
    private javax.swing.JButton Return;
    private javax.swing.JButton Save;
    private javax.swing.JButton Save2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JScrollPane jScrollPane1;
    // End of variables declaration//GEN-END:variables
}
