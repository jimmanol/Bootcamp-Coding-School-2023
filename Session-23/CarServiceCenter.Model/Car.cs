namespace CarServiceCenter.Model
{
    public class Car
    {
        //properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarRegistrationNumber { get; set; }


        // Relations
        public List<Transaction> Transactions { get; set; }

        //constructor
        public Car(string brand, string model, string carRegistrationNumber)
        {
            Brand = brand;
            Model = model;
            CarRegistrationNumber = carRegistrationNumber;

            Transactions = new List<Transaction>();
        }

        public class CarCreateDto {
            public String Brand { get; set; } = null!;
            public String Model { get; set; } = null!;
            public String CarRegistrationNumber { get; set; } = null!;
        }

        public class CarEditDto {
            public int Id { get; set; }
            public String Brand { get; set; } = null!;
            public String Model { get; set; } = null!;
            public String CarRegistrationNumber { get; set; } = null!;
        }

    }
}
