package TreeExample;

public class TreeNode {
	int data;
	String name;
	TreeNode LeftSon, RightSon;
	public TreeNode(int d, String nam)
	{
		this.data = d;
		this.name = nam;
		this.LeftSon = null;
		this.RightSon = null;
	}
	public String toString() {
		return name + ": it's data is " + data;
	}
}
