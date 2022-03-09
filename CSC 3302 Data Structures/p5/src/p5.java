/*
 * Purpose: get experience with using circular linked lists and queues
 * Programmer:David Garrett
 *Class: CSCI 3302-002
 *Date Started: October 19, 2020
 *Date Completed: October 19, 2020
 *variables used:
        String path: directory path
        Scanner in2 = scanner to read in file
        Scanner in =  scanner to count lines
        Scanner user = user input for the skipping value
        int length =  line counter
        int i = counter
        CircleQueue<String, Integer> line = Linked List for the line
        value = the value used for skipping intervals
        Node point = pointer for queuing and dequeuing variables
 *ADTs used: node and queue
 *Sample input:
Sammy
Susie
Angela S.
George
Thomas the Great
Jack Spratt
Steven
Chuckles the Clown
Joseph
Jim Bob
What's His Name
Eileen
Elizabeth Anne
Kenny
Daniel
Mr. Know-it-All
Ruth
Robert

 *Sample Output:
Enter the number used to remove people from list:
>> 2
Sammy is excused.
Susie is excused.
Angela S. is excused.
George is excused.
Thomas the Great is excused.
Jack Spratt is excused.
Steven is excused.
Chuckles the Clown is excused.
Joseph is excused.
Jim Bob is excused.
What's His Name is excused.
Eileen is excused.
Elizabeth Anne is excused.
Kenny is excused.
Daniel is excused.
Mr. Know-it-All is excused.
Ruth is excused.
Robert : 4 must go talk to the instructor.

 */
import java.io.*;
import java.util.*;
public class p5 {

    public static void main(String[] args) throws IOException {
        //initialization for reading in
        String path = "/home/courses/csci3302-002/datafiles/" + args[0];
        Scanner in2 =  new Scanner( new File(path));
        Scanner in =  new Scanner( new File(path));
        //initialization of basic values
        int length = 0;
        int i = 0;
        //count in the number of lines and read them
        do {
            length++;
            in.nextLine();
        }
        while(in.hasNextLine());// end of counting loop
        String[] input = new String[length];
        do{
            input[i] = in2.nextLine();
            i++;
        }
        while(in2.hasNextLine()); //end of reading-in loop
        i=0;
        CircleQueue<String, Integer> line = new CircleQueue<String, Integer>();
        for(String name : input) {// Adding people to the line
            line.queue(name, i);
            i++;
        }
        System.out.println("Enter the number used to remove people from list: ");//user prompt
        Scanner user = new Scanner(System.in);
        int value = user.nextInt();//user input
        i=1;
        Node point;//initiate pointer for who is being counted
        while(!line.oneLeft()){// while there are more than one person left
            point = line.dequeue();
            if(i % value != 0) //the person is not being pointed to
                line.queue((String)point.name, (Integer)point.placement);
            else //the person is being pointed to
                System.out.println(point.name+ " is excused");
            i++;//increase counter
        }//end while loop
        point = line.dequeue();//final person
        System.out.println(point.name + ": " + point.placement + " must go talk to the instructor");

    }//end main
}//end class p4