﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoValorDescanso
    {
        public int Id { get; set; }
        public string CoUsuario { get; set; }
        public string Segundos { get; set; }
        public string MesReferencia { get; set; }
    }
}
