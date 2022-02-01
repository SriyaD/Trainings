/* public class AddOperation {
    public double add(double numA, double numB){
        return numA + numB;
    }
}

public class SubtractOperation {
    public double subtract(double numA, double numB){
        return numA - numB;
    }
}

public class MultiplyOperation {
    public double multiply(double numA, double numB){
        return numA * numB;
    }
}

public class DivideOperation {
    public double divide double numA, double numB){
        return numA / numB;
    }
public class Calculator {
    public enum Operation{
        ADD, SUBTRACT, MULTIPLY, DIVIDE
    }

    public double calculate(double numA, double numB, Operation operation){
        double result = 0;
        switch(operation){
            case ADD:
                AddOperation addOp = new AddOperation();
                result = addOp.add(numA, numB);
                break;
            case SUBTRACT:
                SubtractOperation subOp = new SubtractOperation();
                result = subOp.subtract(numA, numB);
                break;
            case MULTIPLY:
                MultiplyOperation multOp = new MultiplyOperation();
                result = multOp.multiply(numA, numB);
                break;
            case DIVIDE:
                DivideOperation divOp = new DivideOperation();
                result = divOp.divide(numA, numB);
                break;
        }
        return result;
    }
}
} */
 

public interface CalculatorOperation {
    public double calculate(double numbA, double numB);
}
public class AddOperation implements CalculatorOperation {
    @Override
    public double calculate(double numbA, double numB) {
        return numbA + numB;
    }   
}

public class SubtractOperation implements CalculatorOperation {
    @Override
    public double calculate(double numbA, double numB) {
        return numbA - numB;
    }
}
public class MultiplyOperation implements CalculatorOperation {
    @Override
    public double calculate(double numbA, double numB) {
        return numbA * numB;
    }  
}
public class DivideOperation implements CalculatorOperation {
    @Override
    public double calculate(double numbA, double numB) {
        return numbA / numB;
    }
}
public class Calculator {
    public double calculate(double numA, double numB, CalculatorOperation operation){
        return operation.calculate(numB, numB);
    }
}
