namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Product))
            {
                return false;
            }

            var other = (Product)obj;

            return this.Name == other.Name && this.Price == other.Price;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + this.Name.GetHashCode();
            hash = hash * 23 + this.Price.GetHashCode();
            return hash;
        }
    }
}
