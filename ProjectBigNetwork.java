//BigNetwork is the super class
public class Animals {

    /*
    Class variables that stores the name of the network and the physical
    location
    */
    String ID;
    String PhysicalLocation;
            
    /*
    Constructor that takes the instance variable name and stores it in class
    variable NetworkName
    */
    public Animals(String name){
        NetworkName = name;
    }
    
    //Method that displays the network name
    public void display(){
        System.out.println(NetworkName);
    
    }
    
    /*Method that takes the agrument LocationID.  This argument is the name 
    of the location.  The argument is then stored into the class variable 
    PhysicalLocation.  If the length is more than three, the first three
    characters are moved into a substring and displayed*/
    public void Location(String LocationID){
        PhysicalLocation = LocationID;
        if (PhysicalLocation.length() > 3){
            PhysicalLocation = PhysicalLocation.substring(0, 3) + "  ";
        }
        System.out.println(PhysicalLocation);
        
    }
    
    
    public static void main(String[] args) {
        
        /*
        Object of the class BigNetwork with the value NNMC1 as the name of 
        the network which will go into the constructor and be stored in the 
        class variable NatworkName.  The object then calls the display method
        and the Location method with the argument Administation.  THe argument 
        will be stored in the class variable, and the method will be executed
        */
        Animals obj1 = new Animals("NNMC1");
        obj1.display();
        obj1.Location("Bird");
        
        /*
        Object of the sub class ADMIN.  The network name along with the 
        network and subnet mask id are passed into the constructor and are 
        stored in the class variables.  The object calls the methods display and
        HostIDAssign.  Display shows the different values and HostIDAssign 
        determines the host id by adding the network id and subnet id.
        */
        ADMIN adminobj = new ADMIN("NNMC1", 0, 15);
        adminobj.display();
        adminobj.HostIDAssign();
        
        /*
        Object of the class BigNetwork with the value NNMC2 as the name of 
        the network which will go into the constructor and be stored in the 
        class variable NatworkName.  The object then calls the display method
        and the Location method with the argument High Tech.  THe argument 
        will be stored in the class variable, and the method will be executed
        */        
        Animals obj2 = new Animals("NNMC2");
        obj2.display();
        obj2.Location("Reptile");
        
        /*
        Object of the sub class HT.  The network name along with the 
        network and subnet mask id are passed into the constructor and are 
        stored in the class variables.  The object calls the methods display and
        HostIDAssign.  Display shows the different values and HostIDAssign 
        determines the host id by adding the network id and subnet id.
        */        
        HT htobj = new HT("NNMC2", 15, 15);
        htobj.display();
        htobj.HostIDAssign();
        
        /*
        Object of the class BigNetwork with the value NNMC3 as the name of 
        the network which will go into the constructor and be stored in the 
        class variable NatworkName.  The object then calls the display method
        and the Location method with the argument Library.  THe argument 
        will be stored in the class variable, and the method will be executed
        */         
        Animals obj3 = new Animals("NNMC3");
        obj3.display();
        obj3.Location("Mammal");
        
        /*
        Object of the sub class LIB.  The network name along with the 
        network and subnet mask id are passed into the constructor and are 
        stored in the class variables.  The object calls the methods display and
        HostIDAssign.  Display shows the different values and HostIDAssign 
        determines the host id by adding the network id and subnet id.
        */        
        LIB libobj = new LIB("NNMC3", 30, 15);
        libobj.display();
        libobj.HostIDAssign();
        
        /*
        Object of the class BigNetwork with the value NNMC4 as the name of 
        the network which will go into the constructor and be stored in the 
        class variable NatworkName.  The object then calls the display method
        and the Location method with the argument Solar Energy Research Park.  
        The argument will be stored in the class variable, and the method will 
        be executed
        */         
        Animals obj4 = new Animals("NNMC4");
        obj4.display();
        obj4.Location("Fish");
        
        /*
        Object of the sub class SERPA.  The network name along with the 
        network and subnet mask id are passed into the constructor and are 
        stored in the class variables.  The object calls the methods display and
        HostIDAssign.  Display shows the different values and HostIDAssign 
        determines the host id by adding the network id and subnet id.
        */        
        SERPA serpaobj = new SERPA("NNMC4", 45, 15);
        serpaobj.display();
        serpaobj.HostIDAssign();    
        
    }
    
}

//Subclass ADMIN which extends the superclass BigNetwork
class ADMIN extends Animals {
    
    /*
    Class variables.  The three integer variables store the values from the
    object.  The String variables are predetermined values for the network
    */
    String NetworkIP = "192.168.70.";
    String WildCardMask = "0.0.0.15";
    String SubnetMask = "255.255.255.240";
    int NetworkID;
    int SubnetMaskID;
    int HostID;
    
    /* 
    Constructor that takes the network id and subnet id from the object and 
    stores them in the class variables.  The network name is inherited from the 
    super class
    */
    public ADMIN(String name, int network, int subnet){
        super(name);
        NetworkID  = network;
        SubnetMaskID = subnet;
    }
    
    /*
    Method that displays the values of the class variables. Note: this method 
    is overridden from the superclass
    */
    public void display(){
        System.out.println("The network portion of the IP Address is " 
                + NetworkIP);
        System.out.println("The Wildcard Mask is " + WildCardMask);
        System.out.println("The Subnet Mask is " + SubnetMask);
        System.out.println("The Network ID is " + NetworkID);
        System.out.println("The Subnet Mask ID is " + SubnetMaskID);
    }
    
    /*
    Method that calculates the value of the host id by adding the network id and
    subnet mask id which are stored in the class variables by the constructor
    */
    public int HostIDAssign(){
        HostID = NetworkID + SubnetMaskID; 
        System.out.printf("The Host ID for this network is %s%d%n", 
            NetworkIP, HostID);
        System.out.println();
        return HostID;
    }
}

//Subclass HT which extends the superclass BigNetwork
class HT extends Animals {
    
    /*
    Class variables.  The three integer variables store the values from the
    object.  The String variables are predetermined values for the network
    */    
    String NetworkIP = "192.168.70.";
    String WildCardMask = "0.0.0.15";
    String SubnetMask = "255.255.255.240";
    int NetworkID;
    int SubnetMaskID;
    int HostID;
    
    /* 
    Constructor that takes the network id and subnet id from the object and 
    stores them in the class variables.  The network name is inherited from the 
    super class
    */
    public HT(String name, int network, int subnet){
        super(name);
        NetworkID  = network;
        SubnetMaskID = subnet;
    }
    
    /*
    Method that displays the values of the class variables. Note: this method 
    is overridden from the superclass
    */
    public void display(){
        System.out.println("The network portion of the IP Address is " 
                + NetworkIP);
        System.out.println("The Wildcard Mask is " + WildCardMask);
        System.out.println("The Subnet Mask is " + SubnetMask);
        System.out.println("The Network ID is " + NetworkID);
        System.out.println("The Subnet Mask ID is " + SubnetMaskID);
    }
    
    /*
    Method that calculates the value of the host id by adding the network id and
    subnet mask id which are stored in the class variables by the constructor
    */    
    public int HostIDAssign(){
        HostID = NetworkID + SubnetMaskID; 
        System.out.printf("The Host ID for this network is %s%d%n", 
            NetworkIP, HostID);
        System.out.println();
        return HostID;
    }
}

//Subclass LIB which extends the superclass BigNetwork
class LIB extends Animals {
    
    /*
    Class variables.  The three integer variables store the values from the
    object.  The String variables are predetermined values for the network
    */    
    String NetworkIP = "192.168.70.";
    String WildCardMask = "0.0.0.15";
    String SubnetMask = "255.255.255.240";
    int NetworkID;
    int SubnetMaskID;
    int HostID;
    
    /* 
    Constructor that takes the network id and subnet id from the object and 
    stores them in the class variables.  The network name is inherited from the 
    super class
    */    
    public LIB(String name, int network, int subnet){
        super(name);
        NetworkID  = network;
        SubnetMaskID = subnet;
    }
    
    /*
    Method that displays the values of the class variables. Note: this method 
    is overridden from the superclass
    */    
    public void display(){
        System.out.println("The network portion of the IP Address is " 
                + NetworkIP);
        System.out.println("The Wildcard Mask is " + WildCardMask);
        System.out.println("The Subnet Mask is " + SubnetMask);
        System.out.println("The Network ID is " + NetworkID);
        System.out.println("The Subnet Mask ID is " + SubnetMaskID);
    }

    /*
    Method that calculates the value of the host id by adding the network id and
    subnet mask id which are stored in the class variables by the constructor
    */    
    public int HostIDAssign(){
        HostID = NetworkID + SubnetMaskID; 
        System.out.printf("The Host ID for this network is %s%d%n", 
            NetworkIP, HostID);
        System.out.println();
        return HostID;
    }
}

//Subclass SERPA which extends the superclass BigNetwork
class SERPA extends Animals {
    
    /*
    Class variables.  The three integer variables store the values from the
    object.  The String variables are predetermined values for the network
    */    
    String NetworkIP = "192.168.70.";
    String WildCardMask = "0.0.0.15";
    String SubnetMask = "255.255.255.240";
    int NetworkID;
    int SubnetMaskID;
    int HostID;
    
    /* 
    Constructor that takes the network id and subnet id from the object and 
    stores them in the class variables.  The network name is inherited from the 
    super class
    */    
    public SERPA(String name, int network, int subnet){
        super(name);
        NetworkID  = network;
        SubnetMaskID = subnet;
    }
    
    /*
    Method that displays the values of the class variables. Note: this method 
    is overridden from the superclass
    */    
    public void display(){
        System.out.println("The network portion of the IP Address is " 
                + NetworkIP);
        System.out.println("The Wildcard Mask is " + WildCardMask);
        System.out.println("The Subnet Mask is " + SubnetMask);
        System.out.println("The Network ID is " + NetworkID);
        System.out.println("The Subnet Mask ID is " + SubnetMaskID);
    }
    
    /*
    Method that calculates the value of the host id by adding the network id and
    subnet mask id which are stored in the class variables by the constructor
    */    
    public int HostIDAssign(){
        HostID = NetworkID + SubnetMaskID; 
        System.out.printf("The Host ID for this network is %s%d%n", 
            NetworkIP, HostID);
        return HostID;
    }
}