public interface Stack{
	public int _length(); //Stack's max length
	public boolean _isEmpty(); //True if the stack is empty -- False if the stack has data
	public void push(Object o); //Adds an element in the top of the stack
	public Object pop(); //Removes the element on the top of the stack
	public Object first(); //First element of the stack, the one that could be affected by push or pop
}