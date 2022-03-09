class Edge {
    private Integer v, w;
    private int weight;
    // The vertices of the edge.
    // The weight of the edge.
    public Edge(Integer first, Integer second, int edgeWeight) {
        // Constructor. Creates an edge from v tow with weight
        // edgeWeight.
        // Precondition: None.
        // Postcondition: The edge is created.
        v = first;
        w = second;
        weight = edgeWeight;
    } // end constructor
    public int getWeight(){
        // Ret urns t he edge weight
        return weight ;
    } // end getWeight
    public Integer getV() {
        // Returns t he first vertex of the edge
        return v ;
    } // end get v
    public Integer getW( ) {
        // Returns t he second vertex of t he edge
        return w;
    } // end getW
} // end Edge 