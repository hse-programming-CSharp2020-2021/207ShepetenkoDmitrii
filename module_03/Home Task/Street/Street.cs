namespace Street
{
    public class Street
    {
        public string Name { get; set; }

        public int[] Houses { get; set; }

        public Street(string name, int[] houses)
        {
            Name = name;
            Houses = houses;
        }

        public static int operator ~(Street street)
        {
            return street.Houses.Length;
        }

        public static bool operator !(Street street)
        {
            foreach (int house in street.Houses)
                if (house.ToString().Contains("7"))
                    return true;
            return false;
        }

        public override string ToString()
        {
            string res = $"{Name} ";
            foreach (int house in Houses)
                res += $"{house} ";
            res = res.Trim();
            return res;
        }
    }
}
