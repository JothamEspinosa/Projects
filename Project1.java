public class Project1 extends JFrame implements ActionListener {

    JTextField entryField = new JTextField();
    
    JMenuBar Catagories = new JMenuBar();
    
    JMenu clearance = new JMenu("Clearance");
    JMenu specials = new JMenu("Specials");
    JMenu products = new JMenu("Products");
    
    JMenuItem cbooks = new JMenuItem("Books");
    JMenuItem cfolders = new JMenuItem("Folders");
    JMenuItem cdevices = new JMenuItem("Devices");
    
    JMenuItem sbooks = new JMenuItem("Books");
    JMenuItem sfolders = new JMenuItem("Folders");
    JMenuItem sdevices = new JMenuItem("Devices"); 
    
    JMenuItem pbooks = new JMenuItem("Books");
    JMenuItem pfolders = new JMenuItem("Folders");
    JMenuItem pdevices = new JMenuItem("Devices"); 
    
    public Project1(){
        
        super("Main Menu");
        setSize(300,300);
        setLayout(new FlowLayout()); 
        setVisible(true);
        
        entryField.setFont(new Font ("Comic Sans", Font.BOLD, 48));
        entryField.setText("Chima RioView");
        entryField.setBounds(150, 30, 170, 20); 
        add(entryField);
        
        setJMenuBar(Catagories);
        add(Catagories);
        
        clearance.add(cbooks);
        clearance.addSeparator();
        clearance.add(cfolders);
        clearance.addSeparator();
        clearance.add(cdevices);
        clearance.addSeparator();
        Catagories.add(clearance);
        
                
        specials.add(sbooks);
        specials.addSeparator();
        specials.add(sfolders);
        specials.addSeparator();
        specials.add(sdevices);
        specials.addSeparator();
        Catagories.add(specials);        
        
        products.add(pbooks);
        products.addSeparator();
        products.add(pfolders);
        products.addSeparator();
        products.add(pdevices);
        products.addSeparator(); 
        Catagories.add(products);
        
        cbooks.addActionListener(this);
        cfolders.addActionListener(this);
        cdevices.addActionListener(this);
        sbooks.addActionListener(this);
        sfolders.addActionListener(this);
        sdevices.addActionListener(this);
        pbooks.addActionListener(this);
        pfolders.addActionListener(this);
        pdevices.addActionListener(this);        

    }

    public void actionPerformed(ActionEvent e){
        Object source = e.getSource();
        
        if(source == cbooks){
            
            JFrame f1 = new JFrame("Clearance Items");
            f1.setSize(500,500); 
            f1.setVisible(true);
            
            JTextArea ef1 = new JTextArea();
            ef1.setFont(new Font ("Comic Sans", Font.BOLD, 48));
            ef1.setText("Chima RioView");
            ef1.setBounds(150, 30, 170, 20);
            ef1.setEditable(false);
            
            JTextArea ta1 = new JTextArea();
            ta1.setBounds(30, 80, 170, 20);
            ta1.setFont(new Font("Helvetica", Font.PLAIN, 12));
            ta1.setText("Clearance            Books");
            ta1.setEditable(false);     
            
            JTextField c1 = new JTextField();
            c1.setBounds(30, 120, 170, 40);
            JTextField c2 = new JTextField();
            c2.setBounds(250, 120, 80, 40);
            JTextField c3 = new JTextField();
            c3.setBounds(350, 120, 40, 40);
            JTextField c4 = new JTextField();
            c4.setBounds(30, 180, 170, 40);
            JTextField c5 = new JTextField();
            c5.setBounds(250, 180, 80, 40);
            JTextField c6 = new JTextField();
            c6.setBounds(350, 180, 40, 40);
            JTextField c7 = new JTextField();
            c7.setBounds(30, 240, 170, 40);
            JTextField c8 = new JTextField();
            c8.setBounds(250, 240, 80, 40);
            JTextField c9 = new JTextField();
            c9.setBounds(350, 240, 40, 40);
            
            JButton b1 = new JButton("Check Out");
            b1.setBounds(150, 300, 170, 20);
            
            f1.pack();
            f1.add(ta1);
            f1.add(c1);
            f1.add(c2);
            f1.add(c3);
            f1.add(c4);
            f1.add(c5);
            f1.add(c6);
            f1.add(c7);
            f1.add(c8);
            f1.add(c9);
            f1.add(b1);
            f1.add(ef1);
        }
}
}