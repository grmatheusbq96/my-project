namespace DemoProject.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        Startup.Config(args).Run();
    }
}