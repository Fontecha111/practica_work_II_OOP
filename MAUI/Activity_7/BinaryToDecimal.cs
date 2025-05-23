using System;

namespace oppguidedpw
{
    public class BinaryToDecimal : Conversion
    {
        public BinaryToDecimal(string name, string definition) : base(name, definition, new BinaryInputValidator())
        {

        }

        public override string Change(string input)
        {
            int decimalString = 0;
            int length = input.Length;

            for(int i = 0; i < length; i++)
            {
                char bit = input[i];

                int digit = bit - '0';
                int power = length - i - 1;
                
                decimalString += digit * (int) Math.Pow(2,power);
            }

            return decimalString.ToString();
        } 
        /*This code initializes the variable i in the last position of the input and runs it until de last position.
        Inside the loop if the character is 1, then, it sums the current value of the baseValue to decimalValue.
        Then, if the character is not 1 or 0 it exits the loop printing the ERROR.
        Finally, when the outside the if, after every iteraction, the baseValue multiplies itself by 2 because every 
        position in binary system corresponds to a power of 2  */

    }
}