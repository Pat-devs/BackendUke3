namespace BackendUke3;

class Program
{
    static void Main(string[] args)
    {
        Person personJohn = new Person("John", 20); // invoke the constructor of the person class

        // personJohn.InstanceGreeter();

        Person personAnna = new Person("Anna", 30);

        personAnna.Name = "Hanna";

        personAnna.InstanceGreeter();

        BankAccount bankAccount = new BankAccount(personAnna.Name);

        bankAccount.ShowBalance();
    }
}


