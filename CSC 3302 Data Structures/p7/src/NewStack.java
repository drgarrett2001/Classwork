
class Node<T> {//Node
    T value;
    Node next;
}//end Node class

class NewStack <T> {
    //initialize head
    Node head;

    public void push(T v){ //adding value to top of the list
        Node<T> node = new Node<T>();
        node.value = v;

        if(head==null) //making head
            head = node;
        else {
            node.next = head;
            head = node;
        }
    }//end push method
    public T pop(){ // removing values
        Node<T> top = new Node<T>();
        top = head;
        head = head.next;
        return top.value;
    }//end pop method
}//end class NewStack