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
	public int deletefromStart() {
		int element = start.data;
		if(start == end) {
			start = null;
			end = null;
		}else {
			start = start.next;
		}
		return element;
	}
	public int deletefromEnd() {
		int element = end.data;
		if(start == end) {
			start = end = null;
		}else {
			Node temp = start;
			while(temp.next != end) {
				temp = temp.next;
			}
			end = temp;
			end.next = null;
		}
		return element;
	}
	public void delete(int element) {
		if(!isEmpty()) {
			if(start == end && element == start.data) {
				start = end = null;
			}else if (element == start.data){
				start = start.next;
			}else {
				Node previous, temp;
				previous = start;
				temp = start.next;
				while(temp != null && temp.data != element) {
					previous = previous.next;
					temp = temp.next;
				}
				if(temp != null) {
					previous.next = temp.next;
					if(temp == end) {
						end = previous;
					}
				}
			}
		}
	}
}

