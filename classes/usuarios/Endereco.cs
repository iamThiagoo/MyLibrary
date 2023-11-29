using System;
using System.Text.RegularExpressions;

namespace trabalho_oop.classes.usuarios
{
    public class Endereco
    {

        private string rua;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;

        public Endereco (
            string rua,
            int numero,
            string complemento,
            string bairro,
            string cidade,
            string uf,
            string cep
        ) {
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Uf
        {
            get { return uf; }
            set {
                if (value.Length == 2) {
                    uf = value;
                }
            }
        }

        public string Cep
        {
            get { return cep; }
            set {
                string cepRegex = @"^\d{5}-\d{3}$";

                if (Regex.IsMatch(value, cepRegex)) {
                    cep = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Rua: {rua};" +
                   $"Numero: {numero};" +
                   $"Complemento: {complemento};" +
                   $"Bairro: {bairro};" +
                   $"Cidade: {cidade};" +
                   $"Uf: {uf};" +
                   $"Cep: {cep}";
        }
    }
}