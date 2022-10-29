namespace IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_144___Classes_e_Metodos_Abstratos.Exercicios_Abstrato.Entities
{
    class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(Color color, double width, double height) 
        :base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double area()
        {
            return width * height;
        }
    }
}
