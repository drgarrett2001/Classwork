/*
 * Purpose: get experience with using graphs when given a matrix

 * Programmer:David Garrett

 * Class: CSCI 3302-002

 * Date Started: December 3, 2020
 * Date Completed: December 4, 2020

 * variables used:
        String path: directory path
        Scanner in = file reader
        int graphTotal = numbered graph;
        Boolean done = loop criteria;
        int dimension = number of vertices;
        Boolean nextCheck = checks if there is another chart
        LinkedList<Integer> vertex[] =
        Boolean first = printing formatting thing
        int val = current value
        Boolean[] visited = array for values visited
        int n = counter

 * ADTs used: LinkedList vertex
              LinkedList queue

 * Sample input:
    6
    0 1 0 0 1 0
    1 0 1 1 1 1
    0 1 0 1 1 0
    0 1 1 0 0 1
    1 1 1 0 0 0
    0 1 0 1 0 0
    -1
    8
    0 1 1 0 0 0 0 0
    1 0 0 0 1 0 1 0
    1 0 0 0 1 0 1 0
    0 0 0 0 0 0 0 1
    0 1 1 0 0 1 1 0
    0 0 0 0 1 0 0 0
    0 1 1 0 1 0 0 1
    0 0 0 1 0 0 1 0
    -1

 *Sample Output:
    Graph 1:
    Breadth First Search: 0, 1, 4, 2, 3, 5
    Depth First Search: 0, 1, 2, 3, 5, 4

    Graph 2:
    Breadth First Search: 0, 1, 2, 4, 6, 5, 7, 3
    Depth First Search: 0, 1, 4, 2, 6, 7, 3, 5



 */
import java.io.*;
import java.util.*;
public class p8 {// p8
    public static void main(String[] args) throws IOException {//main class

        //initialization for reading in
        //String path = "/home/courses/csci3302-002/datafiles/" + args[0];
        String path = args[0];
        Scanner in = new Scanner(new File(path));
        //initialize basic values
        int graphTotal = 0;
        Boolean done = false;
        int dimension = in.nextInt();
        Boolean nextCheck;

        while (!done) {//read in the matrix
            graphTotal+=1;
            int[][] matrix= new int[dimension][dimension];
            Graph g1 = new Graph(dimension);
            for(int i = 0; i<dimension;i++){//read rows
                for(int j= 0; j<dimension;j++){//read colums
                    matrix[i][j] = in.nextInt();
                    if (matrix[i][j] == 1){
                        g1.addEdge(i, j);
                    }
                }
            }

            dimension = in.nextInt();//check if done reading matrix

            //print statements
            System.out.println();
            System.out.println("Graph " + graphTotal + ":");
            System.out.print("Breadth First Search: ");
            g1.bfs();
            System.out.print("Depth First Search: ");
            g1.dfs();
            System.out.println();
            //see if there are more matrices
            nextCheck = in.hasNext();
            if(!nextCheck)
                done = true;
            else
                dimension = in.nextInt();
        }
    }//end main
}//end p8