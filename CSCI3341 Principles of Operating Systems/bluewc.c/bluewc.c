// David Garrett
// Section 1
// February 24, 2022

#include <unistd.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include<sys/types.h>
#include<sys/stat.h>
#include<fcntl.h>

int main( int argc, char *argv[] ) {
	//printf("%d arguments detected\n", argc-1); //used for testing
    
	if (argc < 2 ) { //in case of not enough files added
        char fileCountErr[34]= {"Please include at least one file\n"};
        write(2, fileCountErr, 34);//writes to Std Error (I think?);
	}
	
	else {    //all other cases
		//initialization time
        int i = 1; char n; //used for iterations through arguments
		int lineCount = 0; //running line counter
		int wordCount = 0; //running word counter
		int byteCount = 0; //running byte/character counter
		int lastVal= 0;    //was the last char a letter?
		int finalLine = 0; //total line counter
		int finalWord = 0; //total word counter
		int finalByte = 0; //total byte counter
		FILE* inFile; //file time
		
        while(argc>=i+1) {
			//re-zero all the values
			lineCount = 1;
			wordCount = 0;
			lastVal = 0;
			byteCount = 0;
			
	        inFile = fopen(argv[i], "r");  //open the file
            
            while((n = fgetc(inFile))>0){ //read through the file

				if(n=='\n' || n==' '){ //if the character acts like a space
					if(lastVal!=0){ //if the last char was a letter
						lastVal = 0;
						wordCount++;
					}
				}
				else{ //if this char is a letter
					lastVal = 1;
				}	
				
				//check for lines
				if(n=='\n') {
					lineCount++;
				}
				
				byteCount++; //each char = 1 byte, so we add 1
            }
			
            fclose(inFile);//close current file
			
			if(lastVal!=0){ //if the last char was a character, add a word
				wordCount++;
			}
			
			//print info
			printf("%5d %5d %6d %s \n", lineCount, wordCount, byteCount, argv[i]);
			
			//add file values to totals
			finalLine+=lineCount;
			finalWord+=wordCount;
			finalByte+=byteCount;
			
			i=i+1; //increase iterator
        }
		printf("%5d %5d %6d total\n", finalLine, finalWord, finalByte);
    }
	return 0;
}