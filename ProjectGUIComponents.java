import java.awt.*;
import javax.swing.*;

public class GUIComponents
{
public static void main ( String[] args )
{
JFrame frame = new JFrame ( "GUI Components" );
// Create buttons
JButton buttonA = new JButton ( "ON" );
JButton buttonB = new JButton ( "OFF" );
// Create a checkbox
JCheckBox option = new JCheckBox ("Subscribe");
// Create radio buttons or check box group
ButtonGroup optionGroup = new ButtonGroup();
JRadioButton cbTrue = new JRadioButton ("Accept");
JRadioButton cbFalse = new JRadioButton ("Decline");
optionGroup.add (cbTrue);
optionGroup.add (cbFalse);
// Create pull down menu
JComboBox colorChoice = new JComboBox ();
colorChoice.addItem ("Red");
colorChoice.addItem ("Blue");
colorChoice.addItem ("Yellow");
colorChoice.addItem ("Green");
// Create labels
JLabel colors = new JLabel ("Colors");
JLabel fruits = new JLabel ("Fruits"); 
// Create list
String fruit[] = {"Apple", "Orange", "Mango", "Banana", "Grape", "Melon"};
JList fruitList = new JList (fruit);
// Create scrollbar
JScrollBar vBar = new JScrollBar (JScrollBar.VERTICAL, 0, 10, 0, 255);
JScrollBar hBar = new JScrollBar (JScrollBar.HORIZONTAL, 0, 10, -127, 127);
// Add Text Field
JTextField entryField = new JTextField (20);
entryField.setFont (new Font ("Times", Font.BOLD, 12));
entryField.setText ("Enter a number");
// Create Text Area
JTextArea area = new JTextArea (3, 6); // rows, columns
area.setFont (new Font("Helvetica", Font.PLAIN, 12));
area.setText ("Animal \n Bird \n Insect \n Fish \n");
area.setEditable (false);
// Create a menu
JMenuBar foodBar = new JMenuBar ();
JMenu soups = new JMenu ("Soups");
soups.add ( new JMenuItem ( "Tomato" ) );
soups.addSeparator();
soups.add ( new JMenuItem ( "Chicken" ) );
soups.addSeparator();
soups.add ( new JMenuItem ( "French Onion" ) );
soups.addSeparator();
soups.add ( new JMenuItem ( "Clam Chowder" ) );
foodBar.add ( soups );
JMenu iceCream = new JMenu ("Ice Creams");
iceCream.add ( new JMenuItem ( "Vanilla" ) );
iceCream.addSeparator();
iceCream.add ( new JMenuItem ( "Strawberry" ) );
iceCream.addSeparator();
iceCream.add ( new JMenuItem ( "Chocolate" ) );
iceCream.addSeparator();
iceCream.add ( new JMenuItem ( "Butter Pecan" ) );
foodBar.add ( iceCream );
frame.setJMenuBar ( foodBar );
// Create and set the GridLayout
frame.setLayout ( new FlowLayout () );
frame.add ( colors );
frame.add ( colorChoice );
frame.add ( fruits );
frame.add ( fruitList );
frame.add ( buttonA );
frame.add ( buttonB );
frame.add ( option );
frame.add ( cbTrue );
frame.add ( cbFalse );
frame.add ( entryField );
frame.add ( area );
frame.add ( vBar );
frame.add ( hBar );
frame.pack ();
frame.setVisible ( true );
}
}
