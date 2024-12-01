using System.Collections;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Xml;

class Math{

    Random rand = new Random();

    private int numOne;
    private int numTwo;

    private int answer;

    private string userAnswer;

public int getNumOne(){
    return numOne;
}

public int getNumTwo(){
    return numTwo;
}

public int getAnswer(){
    return answer;
}
public string getUserInput(){
    return userAnswer;
}

 public void setNumOne(int num){
    this.numOne = num;
}

 public void setNumTwo(int num){
    this.numTwo = num;
}

public void setAnswer(int num){
    this.answer = num;
}

public void setUserInput(string x){
    this.userAnswer = x;
}

void InitializeNumbers(){
    setNumOne(rand.Next(0,100));
    setNumTwo(rand.Next(0,100));
}

public void Multiply(){
    InitializeNumbers();
    MathOperation(3);
    answer = getNumOne() * getNumTwo();
    Console.WriteLine("Input an answer");
    if(UserInput() == answer){
        Console.WriteLine(answer + " you're correct!");
    }
    else{
        Console.WriteLine("Try again!");
    }
}

public int UserInput(){
    String answer = Console.ReadLine();
    while(answer == null){
        answer = Console.ReadLine();
    }
    return Convert.ToInt32(answer);
}

public void MathOperation(int x){
    switch(x){
        case 1: 
        Console.WriteLine(getNumOne() + " + " + getNumTwo());
        break;
        case 2:
        Console.WriteLine(getNumOne() + " - " + getNumTwo());
        break;
        case 3:
        Console.WriteLine(getNumOne() + " x " + getNumTwo());
        break;
        default:
        Console.WriteLine("Wrong selection made");
        break;
    }
}
    
    public int IsZero(){
        while(getNumTwo() == 0){
            setNumTwo(rand.Next(0,100));
        }
        return getNumTwo();
    }

    public int IsDivisible()
    {
        IsZero();
        while(DivideAnswer() !=0){
            IsZero();
        }
        return DivideAnswer();
    }

    private int DivideAnswer()
    {
        return getNumOne() % getNumTwo();
    }
}