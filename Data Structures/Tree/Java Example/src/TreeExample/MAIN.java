package TreeExample;

import javax.swing.JOptionPane;

public class MAIN {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int opt = 0, element;
		String name;
		BinaryTree tree = new BinaryTree();
		do {
			try {
				opt = Integer.parseInt(JOptionPane.showInputDialog(null, 
						"1. Add a node\n"
						+ "2. Travel the tree inOrder\n"
						+ "3. Exit\n"
						+ "Select an option...", "Binary Trees", JOptionPane.QUESTION_MESSAGE));
				switch(opt) {
				case 1:
					element = Integer.parseInt(JOptionPane.showInputDialog(null, "Input the number of the node", "Adding node", JOptionPane.QUESTION_MESSAGE));
					name = JOptionPane.showInputDialog(null, "Input the name of the node", "Adding node", JOptionPane.QUESTION_MESSAGE);
					tree.addNode(element, name);
					break;
				case 2:
					if(!tree.isEmpty()) {
						tree.inOrder(tree.root);
					}else {
						JOptionPane.showMessageDialog(null, "The tree is empty", "Warning", JOptionPane.INFORMATION_MESSAGE);
					}
					break;
				case 3:
					JOptionPane.showMessageDialog(null, "App closed", "End", JOptionPane.INFORMATION_MESSAGE);
					break;
				default:
					JOptionPane.showMessageDialog(null, "Incorrect Option", "Warning", JOptionPane.ERROR_MESSAGE);
					break;
				}
			}catch(NumberFormatException n){
				JOptionPane.showMessageDialog(null,  "Error " + n.getMessage());
			}
		}while(opt != 2);
	}

}
