class CircleQueue < T, U>{
    Node head;
    Node tail;
    public void queue(T n, U p) {
        Node<T, U> node = new Node<>();
        Node point;
        node.name = n;
        node.placement = p;
        if (head == null) { //making head
            head = node;
            node.next = head;
        }
        else if (head.next == head) {
            head.next = node;
            node.next = head;
            tail = node;
        } else {
            node.next = head;
            tail.next = node;
            tail = node;
        }
    }
    public Node dequeue() {
        Node out;
        out = head;
        head = head.next;
        tail.next = head;
        return out;

    }
    public Boolean oneLeft(){
        if(tail==head)
            return true;
        else
            return false;
    }

}
class Node<T, U> {//Node
    T name;
    U placement;
    Node next;
}