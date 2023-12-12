using System;

// Request class
public class PurchaseRequest
{
    public string Purpose { get; }
    public double Amount { get; }

    public PurchaseRequest(string purpose, double amount)
    {
        Purpose = purpose;
        Amount = amount;
    }
}

// Handler interface
public interface IApprover
{
    void SetNextApprover(IApprover nextApprover);
    void ProcessRequest(PurchaseRequest request);
}

// ConcreteHandler: Manager
public class Manager : IApprover
{
    private IApprover nextApprover;

    public void SetNextApprover(IApprover nextApprover)
    {
        this.nextApprover = nextApprover;
    }

    public void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount <= 1000)
        {
            Console.WriteLine($"Manager approves purchase request for {request.Purpose}");
        }
        else if (nextApprover != null)
        {
            Console.WriteLine($"Manager cannot approve. Passing to the next approver.");
            nextApprover.ProcessRequest(request);
        }
        else
        {
            Console.WriteLine($"Manager cannot approve. End of the chain.");
        }
    }
}

// ConcreteHandler: Director
public class Director : IApprover
{
    private IApprover nextApprover;

    public void SetNextApprover(IApprover nextApprover)
    {
        this.nextApprover = nextApprover;
    }

    public void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount <= 5000)
        {
            Console.WriteLine($"Director approves purchase request for {request.Purpose}");
        }
        else if (nextApprover != null)
        {
            Console.WriteLine($"Director cannot approve. Passing to the next approver.");
            nextApprover.ProcessRequest(request);
        }
        else
        {
            Console.WriteLine($"Director cannot approve. End of the chain.");
        }
    }
}

// ConcreteHandler: VicePresident
public class VicePresident : IApprover
{
    private IApprover nextApprover;

    public void SetNextApprover(IApprover nextApprover)
    {
        this.nextApprover = nextApprover;
    }

    public void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount <= 10000)
        {
            Console.WriteLine($"Vice President approves purchase request for {request.Purpose}");
        }
        else if (nextApprover != null)
        {
            Console.WriteLine($"Vice President cannot approve. Passing to the next approver.");
            nextApprover.ProcessRequest(request);
        }
        else
        {
            Console.WriteLine($"Vice President cannot approve. End of the chain.");
        }
    }
}

// Client
class Program
{
    static void Main()
    {
        // Creating the chain of approvers
        IApprover manager = new Manager();
        IApprover director = new Director();
        IApprover vicePresident = new VicePresident();

        manager.SetNextApprover(director);
        director.SetNextApprover(vicePresident);

        // Processing purchase requests
        PurchaseRequest request1 = new PurchaseRequest("Office supplies", 800);
        manager.ProcessRequest(request1);
        Console.WriteLine("------------------------");

        PurchaseRequest request2 = new PurchaseRequest("New project equipment", 5000);
        manager.ProcessRequest(request2);
        Console.WriteLine("------------------------");

        PurchaseRequest request3 = new PurchaseRequest("Large-scale project funding", 15000);
        manager.ProcessRequest(request3);

        Console.ReadLine();
    }
}