using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Funcionario
    {
        private string _Nome;
        private double _SalarioBruto;
        private double _Imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            _Nome = nome;
            _SalarioBruto = salarioBruto;
            _Imposto = imposto;
        }

        public string Nome
        {
            get { return _Nome; }   
            set { _Nome = value; }
        } 

        public double SalarioBruto
        {
            get { return _SalarioBruto; }
            set { _SalarioBruto = value; }
        }

        public double Imposto
        {
            get { return _Imposto; }
            set { _Imposto = value; }
        }

        public double SalarioLiquido()
        {
           return _SalarioBruto - _Imposto;
           
        }

        public void AumentarSalario(double porcentagemDeAumento)
        {
            _SalarioBruto = _SalarioBruto + (_SalarioBruto * (porcentagemDeAumento / 100));
            
        }
    }
}
