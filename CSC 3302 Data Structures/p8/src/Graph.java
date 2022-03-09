
import java.util.*;
class Graph {
    //initial values
    private int dimension;
    private LinkedList<Integer> vertex[];
    private Boolean first = true;

    public Graph(int dimension) {//constructor
        this.dimension = dimension;
        vertex = new LinkedList[dimension];
        for (int i = 0; i < dimension; ++i)
            vertex[i] = new LinkedList();
    }

    public void addEdge(int v, int w) {//add edge
        vertex[v].add(w);
    }

    public void dfs() {// main Depth first search method
        //initializations
        int val = 0;
        Boolean[] visited = new Boolean[dimension];
        for(int a = 0; a < dimension; a++)
            visited[a] = false;

        //initial value setup
        visited[val] = true;
        this.first = true;

        //recursive call
        dfsr(val, visited);
    }//end DFS main search


    public void dfsr(int val, Boolean[] visited){ //recursive function
        //print values
        if(val == 0)
            System.out.print(val);
        else
            System.out.print(", " + val);
        //search for future values
        visited[val] = true;
        Iterator<Integer> i = vertex[val].listIterator();
        while (i.hasNext()) {
            int n = i.next();
            if (!visited[n])
                dfsr(n, visited);//main recursive call
        }//end search
    }//end recursive method

    public void bfs() {//breadth first search method
        //initializations
        int val = 0;
        Boolean[] visited = new Boolean[dimension];
        for(int a = 0; a<dimension;a++)
            visited[a] = false;
        LinkedList<Integer> queue = new LinkedList<Integer>();

        // initial value setup
        visited[val] = true;
        queue.add(val);
        this.first = true;
        while (queue.size() != 0) {
            // Dequeue a vertex from queue and print it
            val = queue.poll();
            if(first)
                System.out.print(val);
            else
                System.out.print(", " + val);
            //search for future values
            Iterator<Integer> i = vertex[val].listIterator();
            while (i.hasNext()) {
                int n = i.next();
                if (!visited[n]) {
                    visited[n] = true;
                    queue.add(n);
                }//end if statement
            }//end while loop
            this.first = false;
        }//end full loop
        System.out.println();
    }//end BFS
}//end graph
