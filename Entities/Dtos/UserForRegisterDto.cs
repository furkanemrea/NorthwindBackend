using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class UserForRegisterDto
    {
        public string Mail { get; set; }
        public string Password { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
    }
}
