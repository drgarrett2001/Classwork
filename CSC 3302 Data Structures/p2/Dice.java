abstract class Dice {
    //initialize attributes
    private int currentSide;
    private int totalRolls = 0;
    private int valueTotal = 0;
    //cosntructors
    protected Dice() {
    }

    protected Dice(int currentSide, int totalRolls, int valueTotal) {
        this.currentSide = currentSide;
        this.totalRolls = totalRolls;
        this.valueTotal = valueTotal;
    }
    //mutators
    public void setCurrentSide(int currentSide){
        this.currentSide = currentSide; 
    }

    public void setTotalRolls(int totalRolls){
        this.totalRolls = totalRolls; 
    }

    public void setValueTotal(int valueTotal){
        this.valueTotal = valueTotal;
    }
    //accessors
    public int getCurrentSide(){
        return this.currentSide;
    }

    public int getTotalRolls(){
        return this.totalRolls;
    }

    public int getValueTotal(){
        return this.valueTotal;
    }
    
} //end Dice

