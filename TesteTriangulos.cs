using NUnit.Framework;


namespace TestesUnitariosNUnit.Test
{
    [TestFixture]

    public class Inexistente1    
    {
        [Test]

        public void Calculo()
        {
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;

            string resultado = new Triangulo().DeterminaTipoTriangulo(n1, n2, n3);
        }
    }

    [TestFixture]

    public class Inexistente2
    {
        [Test]

        public void Calculo()
        {
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;

            string resultado = new Triangulo().DeterminaTipoTriangulo(n1, n2, n3);
        }
    }

    [TestFixture]

    public class Isosceles
    {
        [Test]

        public void Calculo()
        {
            int n1 = 1;
            int n2 = 2;
            int n3 = 2;

            string resultado = new Triangulo().DeterminaTipoTriangulo(n1, n2, n3);
        }
    }

    [TestFixture]

    public class Equilatero
    {
        [Test]

        public void Calculo()
        {
            int n1 = 1;
            int n2 = 1;
            int n3 = 1;

            string resultado = new Triangulo().DeterminaTipoTriangulo(n1, n2, n3);
        }
    }

    [TestFixture]

    public class Isosceles2
    {
        [Test]

        public void Calculo()
        {
            int n1 = 2;
            int n2 = 2;
            int n3 = 1;

            string resultado = new Triangulo().DeterminaTipoTriangulo(n1, n2, n3);
        }
    }

    [TestFixture]

    public class Escaleno
    {
        [Test]

        public void Calculo()
        {
            int n1 = 2;
            int n2 = 3;
            int n3 = 4;

            string resultado = new Triangulo().DeterminaTipoTriangulo(n1, n2, n3);
        }
    }
}
