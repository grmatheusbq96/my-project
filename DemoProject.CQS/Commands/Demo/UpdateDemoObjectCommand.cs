using System.Security.AccessControl;

namespace DemoProject.CQS.Commands.Demo;

public class UpdateDemoObjectCommand
{
    public string Name { get; set; }

    public UpdateDemoObjectCommand()
    {
    }
}