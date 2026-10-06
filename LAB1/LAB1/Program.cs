namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = PizzaСalculation.ReadInt("Введите количество гостей: ");
            int slices = PizzaСalculation.ReadInt("Введите количество кусков на одного человека: ");
            int size = PizzaСalculation.ReadPizzaSize("Введите размер пиццы (6, 8 или 10): ");

            PizzaСalculation.Calculate(guests, slices, size);


        }
    }
}
