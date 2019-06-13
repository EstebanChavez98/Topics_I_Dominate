public class StackArray implements Stack {
	private int top = -1;
	private Object s[];
	private int capaacity = 0;

	public StackArray() {
		this(1000);
	}

	public StackArray(int cap) {
		capacity = cap;
		s= new object[capacity];
	}

	public int _length() {
		return (top+1);
	}
	
	public boolean _isEmpty() {
		return (top<0);
	}

	// ...
}