package Example;

public class Node {
	public int data;
	public Node next;
	public Node(int d) {
		this.data = d;
		this.next = null;
	}
	public Node(int d, Node n) {
		data = d;
		next = n;
	}
}
