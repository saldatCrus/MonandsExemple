using MonandsExemple;
using MonandsExemple.Models;

public class Program
{
    public static async  Task Main(string[] args)
    {
        TestModel testModel1 = new();

        TestModel testModel2 = new();

        testModel1.Kekw = new();

        testModel1.Kekw.Name = "KEKL";

        testModel2.Kekw = new();

        testModel2.Kekw.Name = "Kik yore ass back heare";

        Console.WriteLine(TestMaybeScenario(testModel2, testModel1));

    }

    public static string TestMaybeScenario(TestModel errModel, TestModel fineModel) 
    {
        string result = fineModel.Kekw.Name;

        result = errModel.With(p => p.Kekw)
            .With(p => p.Name).Return(x => x, result);
        
        return result;
    } 
}