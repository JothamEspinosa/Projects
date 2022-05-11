import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
 
/** Testing menu-bar of JFrame */
public class TestJMenuBar extends JFrame {
 
   JTextField display;
   int count = 0;
 
   /** Constructor to setup the GUI */
   public TestJMenuBar() {
      // A menu-bar contains menus. A menu contains menu-items (or sub-Menu)
      JMenuBar menuBar;   // the menu-bar
      JMenu menu;         // each menu in the menu-bar
      JMenuItem menuItem; // an item in a menu
 
      menuBar = new JMenuBar();
 
      // First Menu
      menu = new JMenu("Animals");
      menu.setMnemonic(KeyEvent.VK_A);  // alt short-cut key
      menuBar.add(menu);  // the menu-bar adds this menu
 
      menuItem = new JMenuItem("Bird", KeyEvent.VK_U);
      menu.add(menuItem); // the menu adds this item
      menuItem.addActionListener(new ActionListener() {
         @Override
         public void actionPerformed(ActionEvent e) {
            
		
         }
      });
 
      menuItem = new JMenuItem("Fish", KeyEvent.VK_D);
      menu.add(menuItem); // the menu adds this item
      menuItem.addActionListener(new ActionListener() {
         @Override
         public void actionPerformed(ActionEvent e) {
           
         }
      });
     menuItem = new JMenuItem("Reptile", KeyEvent.VK_D);
      menu.add(menuItem); // the menu adds this item
      menuItem.addActionListener(new ActionListener() {
         @Override
         public void actionPerformed(ActionEvent e) {
          BoatsandHoes();
	 
}
      });
     menuItem = new JMenuItem("Mammal", KeyEvent.VK_D);
      menu.add(menuItem); // the menu adds this item
      menuItem.addActionListener(new ActionListener() {
         @Override
         public void actionPerformed(ActionEvent e) {
          BoatsandHoes();
	  
}
      });
              
                setJMenuBar(menuBar);  // "this" JFrame sets its menu-bar
 
      Container cp = getContentPane();
      cp.setLayout(new FlowLayout());
      display = new JTextField("0", 10);
      cp.add(display);
 
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      setTitle("Test MenuBar");
      setSize(300, 100);
      setVisible(true);
   }
public void BoatsandHoes(){
	JFrame H1 = new JFrame("Habitat and food");
        JPanel P2 = new JPanel();
	JTextField P1 = new JTextField("Habitat",30);
   setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      H1.add(P2);
	H1.add(P1);
	setSize(300, 100);
      setVisible(true);
   }
/** The entry main() method */
   public static void main(String[] args) {
      // Run the GUI codes on the event-dispatching thread for thread safety
      SwingUtilities.invokeLater(new Runnable() {
         @Override
         public void run() {
            new TestJMenuBar(); // Let the constructor do the job
         }
      });
   }
}