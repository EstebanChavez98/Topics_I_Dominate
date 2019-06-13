package TreeExample;

public class BinaryTree {
	TreeNode root;
	public BinaryTree() {
		root = null;
	}
	//Method to insert a node in the tree
	public void addNode(int d, String nam) {
		TreeNode _new = new TreeNode(d, nam);
		if(root==null) {
			root = _new;
		}else {
			TreeNode aux = root;
			TreeNode father;
			while(true) {
				father = aux;
				if(d < aux.data) {
					aux = aux.LeftSon;
					if(aux == null) {
						father.LeftSon = _new;
						return;
					}
				}
				else {
					aux = aux.RightSon;
					if(aux == null) {
						father.RightSon = _new;
						return;
					}
				}
			}
		}
	}
	//Method to know if the tree is empty
	public boolean isEmpty() {
		return root == null;
	}
	//Method to travel the tree in inOrder
	public void inOrder(TreeNode r) {
		if(r != null) {
			inOrder(r.LeftSon);
			System.out.println(r.data);
			inOrder(r.RightSon);
		}
	}
}
