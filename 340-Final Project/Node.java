/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package final_project;



public class Node {
   public int iData;              // data item (key)
   public String Questions;
   public double dData;           // data item
   public Node leftChild;         // this node's left child
   //this is Yes
   public Node rightChild;        // this node's right child
   //This is No
        
        public void displayNode()
        {
            System.out.print('{');
            System.out.print(iData);
            System.out.print(", ");
            System.out.print(dData);
            System.out.print("} ");
        }
        public void DisplayNodeQuestion()
   {
       System.out.print(Questions);
   }
}
