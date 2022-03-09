// David Garrett
// Section 1
// February 1, 2022

#include<sys/types.h>
#include<sys/stat.h>
#include<fcntl.h>
#include<stdlib.h>
#include<unistd.h>


int main( int argc, char *argv[] ) {
    
	if (argc < 2 ) { //in case of not enough files added
        char fileCountErr[34]= {"Please include at least one file\n"};
        write(2, fileCountErr, 34);//writes to Std Error (I think?)


    } else {    //all other cases
        int i = 1; int n;  //used for iterations through arguments
        while(argc>i) {

            int openVal;// initial variable
            char buffAry[1024];

	        openVal = open(argv[i], O_RDONLY);  //open the file
            
            while((n = read(openVal, buffAry, 1024))>0){ //read through the file
                write(1, buffAry, n);
            }
                close(openVal);//close current file

            i=i+1; //increase iterator
        }
    }
	return 0;
}