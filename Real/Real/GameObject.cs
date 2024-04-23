namespace Real
{
    public class GameObject
    {
        public string Name { get; }
        public string Description { get; }
        public GameObject(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Draw(Graphics canvas)
        {

        }
    }
}
