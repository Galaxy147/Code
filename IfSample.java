class IfSample
{
    
    public static void main(String[] args) {
        int x,y;
        x = 10;
        y = 20;
        x = x * 4;
        if (x > y) System.out.println("x is greater than y");
        x = x / 4;
        if (x < y) System.out.println("x is less than y");
        x = x * 2;
        if (x == y) System.out.println("x is equal than y");
        x = x * 100;
        if (x == y) System.out.println("You won't see this");  
    }

}