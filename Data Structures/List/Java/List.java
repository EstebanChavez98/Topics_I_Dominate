package Example;

public class List {
	protected Node start, end;
	public List() {
		start = null;
		end = null;
	}
	public boolean isEmpty() {
		if(start == null) {
			return true;
		}else {
			return false;
		}
	}
	public void addtoEnd(int element) {
		if(!isEmpty()) {
			end.next=new Node(element);
			end = end.next;
		}else {
			start = end = new Node(element);
		}
	}
	public void addtoStart(int element) {
		start = new Node(element, start);
		if(end == null) {
			end = start;
		}
	}
	public void showList() {
		Node travel = start;
		System.out.println("");
		while(travel != null) {
			System.out.print("["+travel.data+"]---->");;
			travel = travel.next;
		}
	}
}

