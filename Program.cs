using System;

class Code{
    static void Main(string[]args){
        Console.Write("row : ");
        int x = int.Parse(Console.ReadLine());
        int row = x + 2;
        int[ , ] row_pascal = new int[row, row];
        
        if (x < 0){
            Console.WriteLine("Invalid Pascal's triangle row number.");
        }else{
            for (int i = 0; i < row; i++){
                for (int j = 0; j < i; j++){
                    if(i <= 1){
                        row_pascal[0,0] = 1;
                        row_pascal[1,0] = 1;
                        row_pascal[0,1] = 1;
                    }else{
                        row_pascal[i,0] = 1;
                        if (j > 0){
                            row_pascal[i,j] = row_pascal[i-1,j-1] + row_pascal[i-1,j];
                        }
                    }
                    Console.Write("{0} ",row_pascal[i,j]);                    
                }
                Console.WriteLine(" ");
            }
        }
    }   
}
