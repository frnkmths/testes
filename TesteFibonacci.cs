using NUnit.Framework;


namespace TestesUnitariosNUnit.Test
{
    [TestFixture]

    public class Fibonacci1
    {
        [Test]

        public void Calculo()
        {
            int n1 = 6;

            var resultado = new SeqFibonacci().Fibo(n1);
            Assert.Positive(resultado);
        }  
       
    }

    [TestFixture]

    public class Fibonacci2
    {
        [Test]

        public void Calculo()
        {
            int n1 = -2;

            var resultado = new SeqFibonacci().Fibo(n1);
            Assert.Positive(resultado);
        }

    }

    [TestFixture]

    public class Fibonacci3
    {
        [Test]

        public void Calculo()
        {
            string n1 = "a";
            int n2;

            bool resposta = int.TryParse(n1, out n2);

            if (resposta)
            {
                int resultado = 0;
                Assert.Zero(resultado);
                var envio = new SeqFibonacci().Fibo(resultado);
            }
            else
            {
                int resultado = 1;
                Assert.Zero(resultado);
                var envio = new SeqFibonacci().Fibo(resultado);
            }
        }

    }
}
