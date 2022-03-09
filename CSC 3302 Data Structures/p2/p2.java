/**
 * Purpose: Read in card values, sort cart values, calculate, and print the score to screen
 * Programmer:David Garrett
 *Class: CSCI 3302-002
 *Date Started: September 15, 2020
 *Date Completed: September 16, 2020
 *variables used:
        int i, j: for loops
        Scanner input: reads in user input
        int players: total number of players
        int roll1, roll2 used to store values of the active faces, without calling upon a method
        int[] coins : store number of coins per player
        int[] rollTotal : new int[players]
        Roller diceOne : first die
        Roller diceTwo : second die
        double averageOne: stored the average face value of diceOne
        double averageTwo:stored the average face value of diceTwo
        int highestTotal : stored the highest value that was rolled to decide turn order
        int highestPlayer :stored the player with the highest value that was rolled to decide turn order
        int player: player number for easier time with printing
        int nextPlayer: next player in the circle  for passing coins to
        int totalCoins: total coins remaining outside of the pot
        boolean draw : boolean to skip the end process if the last player has 2 coins and loses them both to pot


 *ADTs used: Class Dice
 *Sample input: 4
 *Sample Output:
       Enter the number of players -
       >>4
       Player 1 rolls -
       Die 1: 3
       Due 2: 4
       Player 2 rolls  -
       Die 1: 6
       Due 2: 4
       Player 3 rolls - 
       Die 1: 4
       Due 2: 1
       Player 4 rolls - 
       Die 1: 5
       Due 2: 6
       Player 4 goes first.

       Player 4 rolls - 
       Die 1: 6
       Due 2: 4
       Player 4 gives 1 coin to Player 1.
       Player 1 rolls - 
       Die 1: 1
       Due 2: 1
       Player 1 gives 2 coin to the Pot.
       Player 2 rolls - 
       Die 1: 1
       Due 2: 6
       Player 2 gives 1 coin to Player 3.
       Player 2 gives 1 coin the Pot.

       Etc...

       Game over.
       Player 1 wins.
       Dice statistics:
            Die 1: rolled x times, average number = 2
            Die 2: rolled y times, average number = 2.75

 */
import java.util.*;
import java.io.*;
public class p2 {
    public static void main(String[] args){
        //initialization of central variables
        Scanner input = new Scanner(System.in);
        System.out.println("Enter the number of players-");
        System.out.print(">>");
        int players = input.nextInt();
        int i, j, roll1, roll2;
        int[] coins = new int[players];
        int[] rollTotal = new int[players];
        Roller diceOne = new Roller();
        Roller diceTwo = new Roller();
        double averageOne;
        double averageTwo;
        int highestTotal = 0;
        int highestPlayer = 0;
        int player=0;
        int nextPlayer;
        int totalCoins=0;
        boolean draw = false;

        //getting a valuable within the range
        while(players>10 || players<4){
            System.out.println("Value must be between 4 and 10.");
            System.out.println("Enter the number of players-");
            System.out.print(">>");
            players = input.nextInt();
        }

        //initial rolls for order, and setting up coins
        for(i=0;i<players;i++){
            player = i+1;
            coins[i] = 2;
            totalCoins+=2;
            System.out.println("Player " + player + " rolls -");
            //roll
            roll1 = diceOne.roll();
            roll2 = diceTwo.roll();
            System.out.println("Die 1: " + roll1);
            System.out.println("Die 2: " + roll2);

            rollTotal[i] = (roll1 + roll2);
            System.out.println("Total: " + rollTotal[i]);
            if(i==0){
                highestTotal = rollTotal[i];
                highestPlayer = 1;
            }
            else if (rollTotal[i] > highestTotal){
                highestTotal = rollTotal[i];
                highestPlayer = player;
            }
            else{}

        }
        System.out.println("Player " + highestPlayer + " goes first.");
        System.out.println();
        i = highestPlayer - 1;

        //the gameplay
        while(totalCoins>1){
            player = i+1;
            nextPlayer = player;
            if(nextPlayer==players)
                nextPlayer=1;

            if (coins[i]>0){
                System.out.println("Player " + player +" rolls-");
                roll1 = diceOne.roll();
                roll2 = diceTwo.roll();
                System.out.println("Die 1: " + roll1);
                System.out.println("Die 2: " + roll2);

                if ((roll1==6 ^ roll2==6) ^ (roll1==6 && roll2==6 && coins[i]<2)){
                    coins[i]=coins[i]-1;
                    if (player==players)
                        coins[0] =coins[0]+1;
                    else
                        coins[i+1] = coins[i+1] + 1;
                    System.out.println("Player " + player + " gives 1 coin to Player  " + nextPlayer + ".");
                }
                else if(roll1==6 && roll2==6){
                    coins[i]=coins[i]-2;
                    if (player==players)
                        coins[0] =coins[0]+2;
                    else
                        coins[i+1] = coins[i+1] + 2;
                    System.out.println("Player " + player + " gives 2 coins to Player  " + nextPlayer + ".");
                }

                if (((roll1==1 ^ roll2==1) ^ (roll1==1 && roll2==1)) && coins[i]>1){
                    coins[i]=coins[i]-1;
                    totalCoins--;
                    System.out.println("Player " + player + " gives 1 coin to the Pot. ");
                }

                else if(roll1==1 && roll2==1 && coins[i]>1){
                    System.out.println("Player " + player + " gives 2 coins to the Pot. ");
                    totalCoins -= 2;
                    coins[i]=coins[i]-2;
                }

            }

            i++;
            if(i==players)
                i=0;
        }

        //endgame scenario
        for(i=0;i<players;i++){
            if (coins[i]>0)
                player=i+1;
            if(i==(players-1)&&players==0)
                draw=true;
        }
        //if last player loses both coins to the pot
        if(draw==false){
            for(i=1;i<4;i++){
                if (i==1){
                    System.out.println("Player " + player +" rolls-");
                }
                roll1 = diceOne.roll();
                roll2 = diceTwo.roll();
                System.out.println("Die 1: " + roll1);
                System.out.println("Die 2: " + roll2);
                if(roll1==6 || roll2==6 ){
                    if(i==players)
                        player=1;
                    else
                        player++;
                    i=0;
                }

            }
        }
        // calculate the averages
        averageOne = (double)diceOne.getValueTotal()/(double)diceOne.getTotalRolls();
        averageTwo = (double)diceTwo.getValueTotal()/(double)diceTwo.getTotalRolls();
        //game over and stats
        System.out.println("Game Over.");
        if (draw==false)
            System.out.println("Player " + player + " wins.");
        else
            System.out.println("Draw.");
        System.out.println("Dice statistics");
        System.out.println("       Die 1: rolled " + diceOne.getTotalRolls() + " times, average number = " + averageOne);
        System.out.println("       Die 2: rolled " + diceTwo.getTotalRolls() + " times, average number = " + averageTwo);
        diceOne.reset();
        diceTwo.reset();
    } //end main
} //end p2