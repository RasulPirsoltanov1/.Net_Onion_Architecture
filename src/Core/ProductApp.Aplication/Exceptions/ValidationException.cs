using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Exceptions
{
	public class ValidationException:Exception
	{
        public ValidationException(string message="Validation occured"):base(message)
        {
            
        }
    }
}
