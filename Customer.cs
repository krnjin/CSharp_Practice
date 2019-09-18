namespace CSharp_Practice{
    public class Customer{
        public int ID;
        public string Name;

        public Customer(){
        }
        public Customer(int id){
            this.ID = id;
        }
        public Customer(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}