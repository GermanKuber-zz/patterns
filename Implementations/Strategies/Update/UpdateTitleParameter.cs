namespace ConsoleApp3
{
    public class UpdateTitleParameter : IParameters
    {
        public string Name { get; set; }
        public UpdateTitleParameter(string name)
        {
            Name = name;
        }
    }
}
