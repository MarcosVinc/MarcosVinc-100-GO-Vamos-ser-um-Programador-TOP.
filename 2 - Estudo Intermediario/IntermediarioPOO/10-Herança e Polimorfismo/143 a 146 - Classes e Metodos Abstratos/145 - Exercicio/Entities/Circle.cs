using System;

namespace IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_144___Classes_e_Metodos_Abstratos.Exercicios_Abstrato.Entities
{
    class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(Color color, double radius)
        :base(color)
        {
            this.radius = radius;
        }

        public override double area()
        {
            return Math.PI * (radius * radius);
        }
    }
}
