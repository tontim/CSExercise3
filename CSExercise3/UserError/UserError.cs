using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercise3.UserError
{
    abstract class UserError
    {
        public abstract string UEMessage();

    }
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            throw new NotImplementedException("You tried to use a text input in a numeric only field. This fired an error!");
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            throw new NotImplementedException("You tried to use a textinput in a numeric only field. This fired an error!");
        }
    }

}
