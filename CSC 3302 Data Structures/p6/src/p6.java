/*
 * Purpose: get experience with using circular linked lists and queues
 * Programmer:David Garrett
 *Class: CSCI 3302-002
 *Date Started: October 26, 2020
 *Date Completed: October 30, 2020
 *variables used:
String path: directory path
Scanner in2 = scanner to read in file
Scanner in =  scanner to count lines
Scanner user = user input for the skipping value
int length =  line counter
int i,j, a, b, c = temporary calues and counters
CircleQueue<String, Integer> line = Linked List for the line
value = the value used for skipping intervals
Node point = pointer for queuing and dequeuing variables
 *ADTs used: none
 *Sample input:
q

 *Sample Output:
(S)election Sort
(Q)uick Sort
(E)xit
Enter choice: Q
A :  56  frequency.
AM :  2  frequency.
AND :  25  frequency.
ANYWHERE! :  3  frequency.
ANYWHERE. :  5  frequency.
ARE :  1  frequency.
ARE. :  1  frequency.
BE! :  2  frequency.
BE, :  1  frequency.
BE. :  1  frequency.
BOAT. :  2  frequency.
BOAT? :  1  frequency.
BOX. :  6  frequency.
BOX? :  1  frequency.
CAR! :  3  frequency.
CAR. :  3  frequency.
CAR? :  1  frequency.
COULD :  14  frequency.
DARK! :  2  frequency.
DARK. :  3  frequency.
DARK? :  2  frequency.
DO :  36  frequency.
DO! :  1  frequency.
EAT :  23  frequency.
EGGS :  11  frequency.
FOX. :  6  frequency.
FOX? :  1  frequency.
GOAT! :  1  frequency.
GOAT. :  1  frequency.
GOAT... :  1  frequency.
GOAT? :  1  frequency.
GOOD, :  2  frequency.
GREEM :  1  frequency.
GREEN :  10  frequency.
HAM! :  3  frequency.
HAM. :  6  frequency.
HAM? :  2  frequency.
HERE :  11  frequency.
HOUSE. :  7  frequency.
HOUSE? :  1  frequency.
I :  69  frequency.
IF :  1  frequency.
IN :  40  frequency.
LET :  4  frequency.
LIKE :  44  frequency.
MAY :  2  frequency.
MAY, :  1  frequency.
MAY. :  1  frequency.
ME :  4  frequency.
MOUSE. :  6  frequency.
MOUSE? :  1  frequency.
NOT :  67  frequency.
NOT, :  15  frequency.
ON :  6  frequency.
OR :  8  frequency.
RAIN. :  3  frequency.
RAIN? :  1  frequency.
SAM! :  2  frequency.
SAM, :  1  frequency.
SAM-I-AM! :  4  frequency.
SAM-I-AM. :  9  frequency.
SAM. :  2  frequency.
SAY! :  3  frequency.
SAY. :  2  frequency.
SEE! :  1  frequency.
SEE. :  3  frequency.
SO :  5  frequency.
THANK :  2  frequency.
THAT :  3  frequency.
THE :  11  frequency.
THEM :  40  frequency.
THEM! :  4  frequency.
THEM, :  10  frequency.
THEM,SAM-I-AM. :  1  frequency.
THEM. :  3  frequency.
THEN :  1  frequency.
THERE. :  8  frequency.
THERE? :  1  frequency.
THEY :  2  frequency.
TRAIN! :  5  frequency.
TRAIN. :  2  frequency.
TRAIN? :  1  frequency.
TREE! :  3  frequency.
TREE. :  3  frequency.
TRY :  4  frequency.
WILL :  18  frequency.
WITH :  18  frequency.
WOULD :  27  frequency.
YOU :  23  frequency.
YOU! :  1  frequency.
YOU, :  8  frequency.
YOU? :  2  frequency.

 */
import java.io.*;
import java.util.*;
public class p6 {
    public static void main(String[] args) throws IOException {
        //initialization for reading in
        //String path = "/home/courses/csci3302-002/datafiles/" + args[0];
        String path = args[0];
        Scanner in1 = new Scanner(new File(path));
        //initialization of basic values
        int length = 0;
        int i;
        String curr;
        Boolean done = false;
        String checker;
        /*String input = in.nextLine();
        String[] words= input.split(" ");
        //count in the number of lines and read them*/
        while(in1.hasNext()) {
            curr = in1.next();
            if(curr != null){
                length++;
            }
        }// end of counting loop
        Scanner in2 = new Scanner(new File(path));
        String[] input = new String[length];
        Integer[] inputInt = new Integer[length];
        Boolean matcher = false;
        i = 0;
        while (in2.hasNext()){//read in only once, with a counter
            curr = in2.next();
            if(curr != null){
                if (i>1){
                    for(int a=0;a<i;a++){
                        if(curr.equals(input[a])){
                            inputInt[a] = inputInt[a] + 1;
                            input[i] = null;
                            matcher = true;
                        }
                    }
                }
                if (!matcher){
                    input[i] = curr;
                    inputInt[i] = 1;
                }
                i++;
                matcher = false;
            }
            else
                in2.next();
        }//end of reading-in loop
        Scanner user = new Scanner(System.in);
        while(!done) {
            Storage data = new Storage(trimString(input), trimInt(inputInt) );
            System.out.println("(I)nsertion Sort");
            System.out.println("(S)election Sort");
            System.out.println("(Q)uick Sort");
            System.out.println("(E)xit");
            System.out.println("Enter choice:");
            checker = user.next();
            if (checker.toUpperCase().matches("E"))
                done = true;
            else if (checker.toUpperCase().matches("I"))
                insertion(data);
            else if (checker.toUpperCase().matches("S"))
                selection(data);
            else if (checker.toUpperCase().matches("Q"))
                quick(data);
            else
                System.out.println("Incorrect value. Please select again.");
        }
    }//end main
    public static String[] trimString(String[] intake){
        int i = 0;
        int length = 0;
        while(i<intake.length){
            if(intake[i]!= null)
                length++;
            i++;
        }
        i=0;
        int j=0;
        String[] back = new String[length];
        while(i<intake.length){
            if(intake[i] != null){
                back[j] = intake[i];
                j++;
            }
            i++;
        }
        return back;
    }//end trimString

    public static Integer[] trimInt( Integer[] intake){
        int i = 0;
        int length = 0;
        while(i<intake.length){
            if(intake[i]!= null)
                length++;
            i++;
        }
        i=0;
        int j = 0;
        Integer[] back = new Integer[length];
        while(i<intake.length){
            if(intake[i] != null) {
                back[j] = intake[i];
                j++;
            }
            i++;
        }
        return back;
    }//end trimInt

    public static void insertion(Storage data){
        data.setMethod("Insertion");
        int i;
        int j;
        String a;
        int b;
        int c;
        for(i=0;i<data.getWordsLength();i++){
            System.out.println(i + " i loops");
            j=0;
            while(j<i){
                System.out.println(j + " j loops");
                data.setSteps(data.getSteps() + 1);
                System.out.println(data.getWords(i) + data.getWords(j));
                c = data.getWords(i).compareTo(data.getWords(j));
                if(c>0){}
                else if(c<0){
                    a = data.getWords(j);
                    b = data.getCount(j);
                    data.setWords(j,data.getWords(i));
                    data.setCount(j,data.getCount(i));
                    data.setWords(i,a);
                    data.setCount(i,b);
                }
                else
                    System.out.println("error in trimming method?");
                j++;
            }
        }
        output(data);
    }//end insertion
    public static void selection(Storage data){
        data.setMethod("Selection");
        int i;
        int j;
        String a;
        int b;
        int c;
        String mins;
        int mini;
        for(i=0;i<data.getWordsLength();i++){
            System.out.println(i + " i loops");
            j=i;
            mini=i;
            mins = data.getWords(i);
            while(j<data.getWordsLength()){
                System.out.println(j + " j loops");
                data.setSteps(data.getSteps() + 1);
                System.out.println(data.getWords(i) + data.getWords(j));
                c= mins.compareTo(data.getWords(j));
                if(c<0){
                    mins = data.getWords(j);
                    mini = j;

                }
                else if(c>0){

                }
                else
                    System.out.println("error in trimming method?");
                a = data.getWords(j);
                b = data.getCount(j);
                data.setWords(j,data.getWords(mini));
                data.setCount(j,data.getCount(mini));
                data.setWords(mini,a);
                data.setCount(mini,b);
                j++;
            }
        }
        output(data);
    }//end selection
    public static void quick(Storage data){
        data.setMethod("Quicksort");
        for (int i=0; i<data.getWordsLength();i++){
            System.out.println(data.getWords(i));
        }
        output(sort(data));

    }//end quick
    public static Storage sort(Storage data){
        String pivot = data.getWords(data.getWordsLength()-1);
        int pivotCount = data.getCount(data.getWordsLength()-1);
        int i;
        int j;
        String a;
        int b;
        int c;
        int index;
        //System.out.println("pivot: " + pivot);
        for (i=0; i<data.getWordsLength()-1;i++){
            c = data.getWords(i).compareTo(pivot);
            if(c<0) {
                data.setSteps(data.getSteps() +1);
            }
            else if(c>0){
                Boolean done = false;
                j=i;
                while(j<data.getWordsLength()-1 && !done){
                    if(data.getWords(j).compareTo(pivot)<0){
                        a = data.getWords(i);
                        b = data.getCount(i);
                        data.setWords(i, data.getWords(j));
                        data.setCount(i, data.getCount(j));
                        data.setWords(j, a);
                        data.setCount(j, b);
                        done = true;
                    }
                    else
                        j++;
                    data.setSteps(data.getSteps() + 1);
                }
            }
        }
        index = 0;
        for(i=0;i<data.getWordsLength();i++){
            if(data.getWords(i).compareTo(pivot)<0)
                index++;
        }

        if(data.getSection(0,index).getWordsLength()>=1)
            data.setSection(0,index,sort(data.getSection(0, index)));
        if(data.getSection(index+1,data.getWordsLength()).getWordsLength()>=1)
            data.setSection(index+1, data.getWordsLength(), sort(data.getSection(index, data.getWordsLength()-1)));
        data.setWords(index,pivot);
        data.setCount(index,pivotCount);
        return data;

    }//end quicksort
    public static void output(Storage data){
        int i = 0;
        while(i<data.getCountLength()){
            System.out.println(data.getWords(i) + ": " + data.getCount(i) + " frequency.");
            i++;
        }
        System.out.println(data.getMethod() + " finished in " + data.getSteps()+ " steps.");
    }//printing completed
}//end p6

class Storage {
    private String[] words;
    private Integer[] count;
    private String method;
    private int steps;

    public Storage(String[] words, Integer[] count) {
        this.words = words;
        this.count = count;
    }

    public void setWords(int i, String a) {
        this.words[i] = a;
    }

    public void setSection(int i, int j, Storage a) {
        int b = 0;

        for(int count =i;count<j;count++) {
            this.words[count] = a.getWords(b);
            this.count[count] = a.getCount(b);
            b++;
        }
    }

    public void setCount(int i, int c) {
        this.count[i] = c;
    }

    public void setMethod(String method) {
        this.method = method;
    }

    public void setSteps(int steps) {
        this.steps = steps;
    }

    public String getWords(int i) {
        return this.words[i];
    }

    public int getWordsLength() {
        return this.words.length;
    }

    public Storage getSection(int i, int j) {
        Integer[] backI = new Integer[j-i];
        String[] backS = new String[j-i];
        Storage a = new Storage(backS, backI);
        int b = 0;

        for(int count =i;count<j;count++) {
            a.setWords(b,this.words[count]);
            a.setCount(b,this.count[count]) ;
            b++;
        }
        return a;
    }

    public Integer getCount(int i) {
        return this.count[i];
    }

    public Integer getCountLength() {
        return this.count.length;
    }

    public String getMethod() {
        return this.method;
    }

    public int getSteps() {
        return this.steps;
    }

} //end Storage