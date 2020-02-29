// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Windows.Forms;

namespace Populations.Limitations
{
    static class InputLimitations
    {
        public static void RealNumberInput(object sender, KeyPressEventArgs e) {
            /*
             * Если была нажата точка, заменимее на запятую
             * */
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            /*
             * Проходят только цифры, минус и запятая
             * */
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else {
                /*
                 * Минус не пройдет если его пытаются вставить не в начале или он уже присутствует 
                 * */
                if (e.KeyChar == '-' && 
                    ((sender as TextBox).SelectionStart != 0 ||
                        (sender as TextBox).Text.Contains("-")))
                    e.Handled = true;
                /*
                 * запятая не пройдёт, если...
                 * */
                else if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                    ((sender as TextBox).SelectionStart == 0 ||             //...символ пытаются вставить в начало
                        (sender as TextBox).Text.Contains(",") ||           //...поле уже содержит запятую
                        !char.IsDigit((sender as TextBox).Text[(sender as TextBox).SelectionStart - 1])))       //...перед позицией вставки не цифра
                {
                    e.Handled = true;
                }
            }
        }

        public static void IntegerNumberInput(object sender, KeyPressEventArgs e)
        {
            /*
             * Проходят только цифры и минус
             * */
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                /*
                 * Минус не пройдет если его пытаются вставить не в начале или он уже присутствует 
                 * */
                if (e.KeyChar == '-' &&
                    ((sender as TextBox).SelectionStart != 0 ||
                        (sender as TextBox).Text.Contains("-")))
                    e.Handled = true;
            }
        }
    }
}
