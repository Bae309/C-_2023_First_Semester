internal class Program
{
    class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }
    class Dog : Animal
    {
        
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다.");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
    private static void Main(string[] args)
    {
        List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
        List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
        List<Animal> Animals = new List<Animal>() { new Animal(), new Animal() };
        foreach (var item1 in Animals)
        {
            item1.Eat();
            item1.Sleep();
        }
        foreach (var item in Dogs)
        {
           
            item.Bark();
        }
        foreach (var item in Cats)
        {
            item.Meow();
        }
    }
}
