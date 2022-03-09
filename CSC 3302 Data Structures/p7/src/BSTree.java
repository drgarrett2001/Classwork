class BSTree<T> {
    //initialization of values
    T item;
    BSTree<T> leftChild;
    BSTree<T> rightChild;


    public BSTree(T newItem){//leaf/operator constructor
        item = newItem;
        leftChild = null;
        rightChild = null;
    }//end leaf constructor

    public BSTree(T newItem, BSTree<T> right, BSTree<T> left){//root/operator constructor
        item = newItem;
        rightChild = right;
        leftChild = left;
    }//end root constructor
}//end BSTree class