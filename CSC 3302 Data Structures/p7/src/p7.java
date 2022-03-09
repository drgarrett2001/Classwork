/*
 * Purpose: get experience with using circular linked lists and queues

 * Programmer:David Garrett

 * Class: CSCI 3302-002

 * Date Started: November 15, 2020
 * Date Completed: November 16, 2020

 * variables used:
    String path: directory path
    Scanner in1 =  scanner to read in file
    String line = current line read in
    String temp = temporary value for current variable
    int i = counter for going through the line
    NewStack<BSTree<String>> stax = Stack to hold trees
    BSTree<String> operator = subtree to deal with operators
    BSTree<String> operand = subtree "leaf nodes"
    int total = calculation of the output

 * ADTs used: Stack NewStack
              Tree  BSTree

 * Sample input:
    2 3 * 4 0 * +

 *Sample Output:
    Postfix: 2 3 * 4 0 * +
    Result: 6
    Prefix: + * 4 0 * 2 3


 */
import java.io.*;
import java.util.*;
public class p7 {
    public static void main(String[] args) throws IOException{//main class

        //initialization for reading in
        String path = "/home/courses/csci3302-002/datafiles/" + args[0];
        //String path = args[0];
        Scanner in1 = new Scanner(new File(path));
        Scanner user = new Scanner(System.in);
        String line;
        String temp;
        int increment;
        System.out.println(" Are there spaces between the values? The example on the server indicated there was, but the sheet said no. (y/n)");
        System.out.println(" (y/n)");
        String spaces = user.next();
        if(spaces == "y")
            increment = 2;
        else if (spaces == "n")
            increment = 1;
        //reading in
        while (in1.hasNextLine()){//looping by line

            NewStack<BSTree<String>> stax = new NewStack<BSTree<String>>();
            line= in1.nextLine();

            int i=0;

            while (i<line.length()) {//looping by value on the line
                temp = line.substring(i,i+1);

                //Value is an Operator
                if(temp.equals("+") || temp.equals("-") || temp.equals("/") || temp.equals("*") || temp.equals("^") ){
                    BSTree<String> operator = null;
                    if(temp.equals("+")){
                        operator = new BSTree<String>("+",stax.pop(), stax.pop());
                    }
                    else if(temp.equals("-")){
                        operator = new BSTree<String>("-",stax.pop(), stax.pop());
                    }
                    else if(temp.equals("/")){
                        operator = new BSTree<String>("/",stax.pop(), stax.pop());
                    }
                    else if(temp.equals("*")){
                        operator = new BSTree<String>("*",stax.pop(), stax.pop());
                    }
                    else if(temp.equals("^") ){
                        operator = new BSTree<String>("^",stax.pop(), stax.pop());
                    }
                    stax.push(operator);
                }

                //value is an operand
                else {
                    BSTree<String> operand = new BSTree<String>(temp);
                    stax.push(operand);
                }

                //continue the counter
                i= i+2;

            }//line reading completed

            BSTree<String> root = stax.pop();//final tree

            //final printing
            System.out.println("Postfix: " + line);
            System.out.println("Result: " + solve(root));
            System.out.println("Prefix: " + prefix(root));
            System.out.println();

        }//end of line information

    }//end main method


    public static int solve(BSTree<String> root){//solving method

        //return value
        int total = 0;

        //operator case
        if(root.item.equals("+") || root.item.equals("-") || root.item.equals("/") || root.item.equals("*") || root.item.equals("^") ){
            if(root.item.equals("+")){
                total = solve(root.leftChild) + solve(root.rightChild);
            }
            else if(root.item.equals("-")){
                total = solve(root.leftChild) - solve(root.rightChild);
            }
            else if(root.item.equals("/")){
                total = solve(root.leftChild) / solve(root.rightChild);
            }
            else if(root.item.equals("*")){
                total = solve(root.leftChild) * solve(root.rightChild);
            }
            else {
                total = (int) Math.pow(solve(root.leftChild), solve(root.rightChild));
            }
        }

        //operand case
        else
            total= Integer.parseInt(root.item);

        //final return
        return total;
    }// end solve method


    public static String prefix(BSTree<String> root){// method to convert to prefix

        //operator case
        if(root.item.equals("+") || root.item.equals("-") || root.item.equals("/") || root.item.equals("*") || root.item.equals("^") ){
            return root.item + " " + prefix(root.leftChild) + " " + prefix(root.rightChild);
        }
        //operand case
        else
            return root.item;

    }//end prefix

}//end p7.java

