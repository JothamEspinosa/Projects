

import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

public class Project1A{

   Project1A(){
       //main class
       JFrame f=new JFrame(); //we are using jframe
       f.setPreferredSize(new Dimension(700,300));
       f.setLayout(null);

       JButton Calculate=new JButton("Calculate");
       Calculate.setBounds(120, 150, 100,30);
       f.add(Calculate);

       JButton help=new JButton("Help");
       help.setBounds(250, 150, 100,30);
       f.add(help);


       JLabel disp=new JLabel("Enter Temperature in Centigrade");
       disp.setBounds(20, 50, 200,30);
       f.add(disp);

       JTextField input=new JTextField();
       input.setBounds(350, 50, 200,30);
       f.add(input);


       JLabel res=new JLabel("Temperature in Fahrenheit");
       res.setBounds(20, 100, 200,30);
       f.add(res);

       JTextField resOut=new JTextField();
       resOut.setBounds(350, 100, 200,30);
       resOut.setEditable(false);
       f.add(resOut);

       Calculate.addActionListener(new ActionListener() {
           @Override
           public void actionPerformed(ActionEvent e) {
               double fromData = Double.parseDouble(input.getText());
               double result = fromData*1.8+32;
               resOut.setText(result+"");
           }
       });
      
       help.addActionListener(new ActionListener() {
           @Override
           public void actionPerformed(ActionEvent e) {
               JOptionPane.showMessageDialog(null, "Enter temprature in Centigrade and press calculte to convert it in Fahrenheit");
           }
       });


       f.pack();
       f.setVisible(true);
   }


   public static void main(String[] args){
       Project1A f = new Project1A();

   }
}