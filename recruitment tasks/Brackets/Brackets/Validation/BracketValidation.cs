using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets.Validation
{
    public class BracketValidation
    {
        public string strForValidation;

        public BracketValidation(string enteredString)
        {
            this.strForValidation = enteredString;
        }

        public bool CountedValuesSame() => CountSelectedElement('(') == CountSelectedElement(')');

        private int CountSelectedElement(char elementToCount)
        {
            int i = 0;

            for(int j = 0; j < strForValidation.Length; j++)
            {
                if (strForValidation[j] == elementToCount)
                    i++;
            }

            return i;
        }
    }
}
