// Last updated: 8/1/2025, 5:56:50 PM
using System.Linq;
public class MinStack {
    private List<int> stack;
    private List<int> min ;
    public MinStack() {
        stack = new List<int>();
        min =  new List<int>();
    }
    
    public void Push(int val) {
        Console.WriteLine(val);
        if(min.Count == 0 || min.Last() >= val)
            min.Add(val);
        Console.WriteLine($"Pushed {val}");
        stack.Add(val);        
    }
    
    public void Pop() {
        int value = stack.Last();
        stack.RemoveAt(stack.Count -1);
        Console.WriteLine($"popped {value} remaining {stack.Count}");


        if(min.Last() == value){
            min.RemoveAt(min.Count -1);
          //  Console.WriteLine($"pop min {min.Last()} remaining {min.Count}");
            }
    }
    
    public int Top() {
        return stack.Last();
        
    }
    
    public int GetMin() {
        Console.WriteLine($"getMin min count:{min.Count} last item : {min.Last()}");
        return min.Last();
        
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */