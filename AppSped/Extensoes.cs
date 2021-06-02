using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSped
{
    public static class StringExtension
    {

        public static Tags GetTag(this string sender)
        {
            Tags MyTags = new Tags();

            string response = sender.Trim();

            string tag = "";

            string endtag = "";

            if (response.Count() > 1)
            {

                tag = response.Substring(0, response.IndexOf('>') + 1);

                endtag = tag.Replace("<", "</");

                if (!(response.Contains(endtag)))
                {
                    endtag = "";
                }

            }

            MyTags.Tag = tag;
            MyTags.EndTag = endtag;

            return MyTags;

        }
        public static DateTime? StringToDate(this string sender)
        {

            if (sender.Length < 6) return null;

            DateTime? retorno;

            sender = sender.Substring(06,2) + "/" + sender.Substring(04, 2) + "/" + sender.Substring(0, 4);
            
            try
            {
                
                retorno = Convert.ToDateTime(sender);

            } catch
            {
                retorno = null;
            }


            return retorno;
        }
        public static double DoubleParseUSA(this string sender)
        {

            double response = 0.0;

            var culture = new System.Globalization.CultureInfo("en-US");

            try
            {

                response = Convert.ToDouble(sender, culture);

            }
            catch (Exception e)
            {

                response = 0.0;

            }


            return response;
        }

        public static double DoubleParse(this string sender)
        {

            double response = 0.0;

            var culture = new System.Globalization.CultureInfo("pt-BR");

            try
            {

                response = Convert.ToDouble(sender, culture);

            }
            catch (Exception e)
            {

                response = 0.0;

            }


            return response;
        }

        public static string DoubleParseDb(this double sender)
        {

            string response = "0.0";

            var culture = new System.Globalization.CultureInfo("en-US");

            try
            {

                response = Convert.ToString(sender, culture);

            }
            catch (Exception e)
            {

                response = "0.0";

            }


            return response;
        }

        public static int IntParse(this string sender)
        {

            int response = 0;

            try
            {

                response = Convert.ToInt32(sender);

            }
            catch (Exception e)
            {

                response = 0;

            }


            return response;
        }

        public static bool IsCnpjCpf(this string documento)
        {

            bool retorno = false;

            if (documento.Trim().Length == 11)
            {

                retorno = IsCpf(documento.Trim());

            }
            else
            {
                retorno = IsCnpj(documento.Trim());

            }

            return retorno;
        }

        public static String MMAA(this string sender)
        {

            String retorno = "";
            String mes = "";



            switch (sender.Substring(0, 2))
            {
                case "01":
                    mes = "Jan";
                    break;
                case "02":
                    mes = "Fev";
                    break;
                case "03":
                    mes = "Mar";
                    break;
                case "04":
                    mes = "Abr";
                    break;
                case "05":
                    mes = "Mai";
                    break;
                case "06":
                    mes = "Jun";
                    break;
                case "07":
                    mes = "Jul";
                    break;
                case "08":
                    mes = "Ago";
                    break;
                case "09":
                    mes = "Set";
                    break;
                case "10":
                    mes = "Out";
                    break;
                case "11":
                    mes = "Nov";
                    break;
                case "12":
                    mes = "Dez";
                    break;
                default:
                    mes = "";
                    break;
            }

            retorno = mes + "/" + sender.Substring(sender.Length - 2, 2); ;

            return retorno;
        }

        private static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cnpj.EndsWith(digito);
        }

        private static bool IsCpf(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);

        }

        public static string SmartBreak(this string sender, int part)
        {

            int index = -1;

            string response = sender;

            if (response.Trim().Length <= 60)
            {
                index = -1;

            }
            else
            {
                index = response.Substring(0, 60).LastIndexOf(' ');
            }


            if (part == 1)
            {
                if (index == -1)
                {
                    response = response.Trim();
                }
                else
                {
                    response = response.Substring(0, index);
                }

                return response;
            }
            else
            {
                response = sender;

                if (index == -1) return "";

                int Comprimento = response.Length - (index + 1);

                return response.Substring(index + 1, Comprimento).Trim();

            }


        }

        public static string DateToDb(this String sender)
        {

            string response = "";

            response = sender.Substring(06, 04) + "-" + sender.Substring(03, 02) + "-" + sender.Substring(0, 02);

            return response;
        }

        public static string WithMaxLength(this string value, int maxLength)
        {
            return value?.Substring(0, Math.Min(value.Length, maxLength));
        }
    }

    public class Tags
    {
        public string Tag { get; set; }
        public string EndTag { get; set; }

        public Tags()
        {
            Tag = "";
            EndTag = "";
        }
    }
}
