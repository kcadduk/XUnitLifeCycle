namespace TestProjectLifeTime;

public static class Write
{
    static Write()
    {

    }


    public static void Line(string text)
    {
        File.AppendAllLines("TestOutput.txt", new [] {text});
    }
}