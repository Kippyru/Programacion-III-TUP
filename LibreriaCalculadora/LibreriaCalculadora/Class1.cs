using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCalculadora
{
    public class libCalculadora
    {
        private double _resultado;
        private string _operacion;

        public double Resultado => _resultado;

        public void SetNumero(double numero)
        {
            _resultado = numero;
        }

        public void SetOperacion(string operacion)
        {
            _operacion = operacion;
        }

        public double Calcular(double segundoNumero)
        {
            switch (_operacion)
            {
                case "+":
                    _resultado = _resultado + segundoNumero;
                    break;
                case "-":
                    _resultado = _resultado - segundoNumero;
                    break;
                case "*":
                    _resultado = _resultado * segundoNumero;
                    break;
                case "/":
                    _resultado = segundoNumero == 0
                        ? (_resultado >= 0 ? double.PositiveInfinity : double.NegativeInfinity)
                        : _resultado / segundoNumero;
                    break;
                default:
                    break;
            }
            return _resultado;
        }

        public void Limpiar()
        {
            _resultado = 0;
            _operacion = string.Empty;
        }
    }
}

