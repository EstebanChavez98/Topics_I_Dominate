package Example;

import javax.swing.JOptionPane;

public class Main {
	public static void main(String[] args) {
		List list = new List();
		int opt = 0, el;
		do {
			try {
				opt = Integer.parseInt(JOptionPane.showInputDialog(null, 						"1. Add an element to the start of the list\n"
					+   "2. Show the list data\n"
				    +   "3. Exit", "Option Menu", 3));
				switch(opt) {
					case 1:
						try {
						el=Integer.parseInt(JOptionPane.showInputDialog(null, "Input the element:", "Adding to the start", 3));
						list.addtoStart(el);
						}catch(NumberFormatException n) {
							JOptionPane.showMessageDialog(null, "Error" + n.getMessage());
						}
						break;
					case 2:
						list.showList();
						break;
					case 3:
						break;
					default:
						JOptionPane.showMessageDialog(null, "Incorrect option");
						break;
					
				}
			}catch(Exception e) {
				JOptionPane.showMessageDialog(null, "Error" + e.getMessage());
			}
		}while(opt != 3);
	}
}
