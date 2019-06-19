package Example;

import javax.swing.JOptionPane;

public class Main {
	public static void main(String[] args) {
		List list = new List();
		int opt = 0, el;
		do {
			try {
				opt = Integer.parseInt(JOptionPane.showInputDialog(null, 						
						"1. Add an element to the start of the list\n"
					+   "2. Show the list data\n"
					+   "3. Add an element to the end of the list\n"
					+   "4. Erase an element from the start\n"
					+   "5. Erase an element from the end\n"
					+   "6. Erase an element from the list\n"
				    +   "7. Exit", "Option Menu", 3));
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
						try {
							el=Integer.parseInt(JOptionPane.showInputDialog(null, "Input the element:", "Adding to the end", 3));
							list.addtoEnd(el);
							}catch(NumberFormatException n) {
								JOptionPane.showMessageDialog(null, "Error" + n.getMessage());
							}
						break;
					case 4:
						el=list.deletefromStart();
						JOptionPane.showMessageDialog(null, "The deleted element is " + el, "Deleting node in the start", JOptionPane.INFORMATION_MESSAGE);
						break;
					case 5:
						el=list.deletefromEnd();
						JOptionPane.showMessageDialog(null, "The deleted element is " + el, "Deleting node in the end"
								+ "", JOptionPane.INFORMATION_MESSAGE);
						break;
					case 6:
						el = Integer.parseInt(JOptionPane.showInputDialog(null, "Imput an element to erase"));
						list.delete(el);
						break;
					case 7:
						JOptionPane.showMessageDialog(null, "Closing program...");
						break;
					default:
						JOptionPane.showMessageDialog(null, "Incorrect option");
						break;
					
				}
			}catch(Exception e) {
				JOptionPane.showMessageDialog(null, "Error" + e.getMessage());
			}
		}while(opt != 7);
	}
}
