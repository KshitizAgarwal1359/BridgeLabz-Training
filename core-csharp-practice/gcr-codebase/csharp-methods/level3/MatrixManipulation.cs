//program to perform matrix operations addition, subtraction, multiplication transpose and to find the determinant and inverse of matrices.
using System;
public class MatrixManipulation{
      public static int[,] CreateRandomMatrix(int rows, int cols){
            Random rnd = new Random();
            int[,] matrix = new int[rows, cols];
            for(int i=0; i<rows; i++){
                  for(int j=0; j<cols; j++){
                        matrix[i, j] = rnd.Next(1, 10);
                  }
            }
            return matrix;
    }
    
    public static int[,] AddMatrices(int[,] matrixA, int[,] matrixB){
            int rows = matrixA.GetLength(0);
            int cols = matrixA.GetLength(1);
            int[,] result = new int[rows, cols];
            for(int i=0; i<rows; i++){
                for(int j=0; j<cols; j++){
                        result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return result;
    }
    public static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB){
            int rows = matrixA.GetLength(0);
            int cols = matrixA.GetLength(1);
            int[,] result = new int[rows, cols];
            for(int i=0; i<rows; i++){
                for(int j=0; j<cols; j++){
                        result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
            }
            return result;
    }
    public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB){
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);
            if(colsA != rowsB){
                Console.WriteLine("Matrices cannot be multiplied due to incompatible dimensions.");
                return null;
            }
            int[,] result = new int[rowsA, colsB];
            for(int i=0; i<rowsA; i++){
                for(int j=0; j<colsB; j++){
                        result[i, j] = 0;
                        for(int k=0; k<colsA; k++){
                              result[i, j] += matrixA[i, k] * matrixB[k, j];
                        }
                }
            }
            return result;
    }
    public static int[,] TransposeMatrix(int[,] matrix){
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];
            for(int i=0; i<rows; i++){
                for(int j=0; j<cols; j++){
                        result[j, i] = matrix[i, j];
                }
            }
            return result;
    }
    public static double Determinant2x2(int[,] matrix){
            if(matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2){
                Console.WriteLine("Matrix is not 2x2.");
                return 0;
            }
            return (matrix[0,0] * matrix[1,1]) - (matrix[0,1] * matrix[1,0]);
    }
    public static double Determinant3x3(int[,] matrix){
            if(matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3){
                Console.WriteLine("Matrix is not 3x3.");
                return 0;
            }
            double determinant = matrix[0,0] * (matrix[1,1] * matrix[2,2] - matrix[1,2] * matrix[2,1])
                               - matrix[0,1] * (matrix[1,0] * matrix[2,2] - matrix[1,2] * matrix[2,0])
                               + matrix[0,2] * (matrix[1,0] * matrix[2,1] - matrix[1,1] * matrix[2,0]);
            return determinant;
    }
    public static int[,] Inverse2x2(int[,] matrix){
            if(matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2){
                Console.WriteLine("Matrix is not 2x2.");
                return null;
            }
            double det = Determinant2x2(matrix);
            if(det == 0){
                Console.WriteLine("Matrix is singular and cannot be inverted.");
                return null;
            }
            int[,] inverse = new int[2, 2];
            inverse[0, 0] = matrix[1, 1];
            inverse[0, 1] = -matrix[0, 1];
            inverse[1, 0] = -matrix[1, 0];
            inverse[1, 1] = matrix[0, 0];
            for(int i=0; i<2; i++){
                for(int j=0; j<2; j++){
                        inverse[i, j] = (int)(inverse[i, j] / det);
                }
            }
            return inverse;
    }
    public static int[,] Inverse3x3(int[,] matrix){
            if(matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3){
                Console.WriteLine("Matrix is not 3x3.");
                return null;
            }
            double det = Determinant3x3(matrix);
            if(det == 0){
                Console.WriteLine("Matrix is singular and cannot be inverted.");
                return null;
            }
            int[,] inverse = new int[3, 3];
            for(int i=0; i<3; i++){
            for(int j=0; j<3; j++){
                        int sign = ((i + j) % 2 == 0) ? 1 : -1;
                        inverse[j, i] = sign * (
                              matrix[(i + 1) % 3, (j + 1) % 3] * matrix[(i + 2) % 3, (j + 2) % 3] -
                              matrix[(i + 1) % 3, (j + 2) % 3] * matrix[(i + 2) % 3, (j + 1) % 3]
                        );
                }
            }
            for(int i=0; i<3; i++){
                for(int j=0; j<3; j++){
                        inverse[i, j] = (int)(inverse[i, j] / det);
                }
            }
            return inverse;   
    }
    public static void DisplayMatrix(int[,] matrix){
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for(int i=0; i<rows; i++){
                for(int j=0; j<cols; j++){
                        Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
    }
    public static void Main(string[] args){
            int[,] matrixA = CreateRandomMatrix(3, 3);
            int[,] matrixB = CreateRandomMatrix(3, 3);
            Console.WriteLine("Matrix A:");
            DisplayMatrix(matrixA);
            Console.WriteLine("Matrix B:");
            DisplayMatrix(matrixB);
            Console.WriteLine("A + B:");
            DisplayMatrix(AddMatrices(matrixA, matrixB));
            Console.WriteLine("A - B:");
            DisplayMatrix(SubtractMatrices(matrixA, matrixB));
            Console.WriteLine("A * B:");
            DisplayMatrix(MultiplyMatrices(matrixA, matrixB));
            Console.WriteLine("Transpose of A:");
            DisplayMatrix(TransposeMatrix(matrixA));
            Console.WriteLine("Determinant of A (2x2): " + Determinant2x2(new int[,] { {1, 2}, {3, 4} }));
            Console.WriteLine("Determinant of A (3x3): " + Determinant3x3(matrixA));
            Console.WriteLine("Inverse of A (2x2):");
            DisplayMatrix(Inverse2x2(new int[,] { {4, 7}, {2, 6} }));
            Console.WriteLine("Inverse of A (3x3):");
            DisplayMatrix(Inverse3x3(matrixA));
    }
}
