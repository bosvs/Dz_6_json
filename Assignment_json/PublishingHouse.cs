namespace Assignment_json
{
    internal class PublishingHouse
    {
        private static int Id = 0;
        public readonly int _id;
        public string Name { get; set; }
        public string Address { get; set; }

        public PublishingHouse()
        {
            _id = ++Id;
        }
        public void GetInfo()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine($" Інфомація про друк (ID: {_id})");
            Console.WriteLine("**************************************************");
            Console.WriteLine($" Ім'я: {Name}");
            Console.WriteLine($" Адреса: {Address}");
            Console.WriteLine("**************************************************");
        }
    }
}
