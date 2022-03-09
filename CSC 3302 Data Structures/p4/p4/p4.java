/*
 * Purpose: Read in integers and display fibonacci values
 * Programmer:David Garrett
 *Class: CSCI 3302-002
 *Date Started: October 5, 2020
 *Date Completed: October 9, 2020
 *variables used:
        String path: directory path
        Scanner in2 = scanner to read in file
        Scanner in =  scanner to count lines
        int length =  line counter;
        int i = counter;
        int temp = current value of fibonacci sequence;
        int oneBack =  previous value of fibonacci sequence;
        int twoBack = second to previous value of fibonacci sequence;
 *ADTs used: node and stack
 *Sample input:
1
2
3
5
10
12
6
15
 *Sample Output:
Fibonacci value for number: 1 is 1
Fibonacci value for number: 3 is 2
Fibonacci value for number: 5 is 5
Fibonacci value for number: 6 is 8
Fibonacci value for number: 9 is 34
Fibonacci value for number: 7 is 13

 */
import java.util.*;
import java.io.*;

public class p4{
    public static void main(String[] args) throws IOException {
        //initialization for reading in
        String path = "/home/courses/csci3302-002/datafiles/" + args[0];
        Scanner in2 =  new Scanner( new File(path));
        Scanner in =  new Scanner( new File(path));
    //initialization of basic values
        int length = 0;
        int i = 0;
        int temp = 0;
        int oneBack;
        int twoBack;
        //count in the number of lines and read them
        do {
            length++;
            in.next();
        }
        while(in.hasNextLine());
        int[] input = new int[length];
        do{
            input[i] = in2.nextInt();
            i++;
        }
        while(in2.hasNextLine());
        i=0;
        //begin dealing with values
        while(i<input.length){
            System.out.print("Sequence: ");
            temp = 0;
            if(input[i]==0) {//base case #1
                System.out.print("0");
                System.out.println();
                display(0, 0);
            }
            else if (input[i] == 1) {//base case #2
                System.out.print("0 1");
                System.out.println();
                display(1, 1);
            }
            else{// going though and implementing fibo sequence
                FibStack<Integer> list = new FibStack<Integer>();
                list.push(0);
                list.push(1);
                System.out.print("0 1 ");
                for(int j = 2;j<=input[i];j++){
                    oneBack = list.pop();
                    twoBack = list.pop();
                    temp = oneBack + twoBack;
                    list.push(twoBack);
                    list.push(oneBack);
                    list.push(temp);
                    System.out.print(temp + " ");
                }
                System.out.println();
                display(input[i],temp);
            }
            System.out.println();// extra spacing
            i++;//counting array index
        }
    }
    public static void display(int one, int two){ // printing out answer
        System.out.println("Fibonacci value for number: "+one+" is "+two);
    }
}
class Node<T> {//Node
    T value;
    Node next;
}
class FibStack <T> {
    Node head;
    public void push(T v){ //adding value to top of the list
        Node<T> node = new Node<>();
        node.value = v;
        if(head==null) //making head
            head = node;
        else {
            node.next = head;
            head = node;
        }
    }
    public T pop(){ // removing values
        Node<T> top = new Node<>();
        top = head;
        head = head.next;
        return top.value;
    }
    public boolean isEmpty(){// boolean for empty list
        if(head==null)
            return true;
        else
            return false;
    }
}