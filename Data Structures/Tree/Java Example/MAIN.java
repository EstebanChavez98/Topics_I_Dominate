package BinaryTree;

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
						+ "3. Travel the tree preOrder\n"
						+ "4. Travel the tree postOrder\n"
						+ "5. Search a node in the tree\n"
						+ "6. Delete a node in the tree\n"
						+ "7. Exit\n"
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
					if(!tree.isEmpty()) {
						tree.preOrder(tree.root);
					}else {
						JOptionPane.showMessageDialog(null, "The tree is empty", "Warning", JOptionPane.INFORMATION_MESSAGE);
					}
					break;
				case 4:
					if(!tree.isEmpty()) {
						tree.postOrder(tree.root);
					}else {
						JOptionPane.showMessageDialog(null, "The tree is empty", "Warning", JOptionPane.INFORMATION_MESSAGE);
					}
					break;
				case 5:
					if(!tree.isEmpty()) {
						element = Integer.parseInt(JOptionPane.showInputDialog(null, "Input the node number to search", "Searching node", JOptionPane.QUESTION_MESSAGE));
						if(tree.searchNode(element)==null) {
							JOptionPane.showMessageDialog(null, "Node not found in the tree", "Warning", JOptionPane.INFORMATION_MESSAGE);
						}
						else {
							System.out.println("Node founded, it's name is: " + tree.searchNode(element));
						}
					}else {
						JOptionPane.showMessageDialog(null, "The tree is empty", "Warning", JOptionPane.INFORMATION_MESSAGE);
					}
					break;
				case 6:
					if(!tree.isEmpty()) {
						element = Integer.parseInt(JOptionPane.showInputDialog(null, "Input the node number to delete", "Deleting node", JOptionPane.QUESTION_MESSAGE));
						if(tree.delete(element)==false) {
							JOptionPane.showMessageDialog(null, "Node not found in the tree", "Warning", JOptionPane.INFORMATION_MESSAGE);
						}
						else {
							JOptionPane.showMessageDialog(null, "Node has ben deleted in the tree", "Node deleted", JOptionPane.INFORMATION_MESSAGE);
						}
					}else {
						JOptionPane.showMessageDialog(null, "The tree is empty", "Warning", JOptionPane.INFORMATION_MESSAGE);
					}
					break;
				case 7:
					JOptionPane.showMessageDialog(null, "App closed", "End", JOptionPane.INFORMATION_MESSAGE);
					break;
				default:
					JOptionPane.showMessageDialog(null, "Incorrect Option", "Warning", JOptionPane.ERROR_MESSAGE);
					break;
				}
			}catch(NumberFormatException n){
				JOptionPane.showMessageDialog(null,  "Error " + n.getMessage());
			}
		}while(opt != 7);
	}

}
