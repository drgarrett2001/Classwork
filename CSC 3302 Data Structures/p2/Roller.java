class Roller extends Dice{
//constructors
    public Roller(){
        super();
    }

    public int roll(){
        setTotalRolls(getTotalRolls()+1);
        setCurrentSide( (int)(Math.random()*6)+1 );
        setValueTotal(getValueTotal() + getCurrentSide());
        return getCurrentSide();
    }

    public void reset(){
        setTotalRolls(0);
        setCurrentSide(0);
        setValueTotal(0);
    }
}//ends observer