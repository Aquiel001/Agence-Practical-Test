﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoObsCliente
    {
        public int CoObs { get; set; }
        public string Descricao { get; set; }
        public int CoCliente { get; set; }
        public string CoUsuario { get; set; }
        public DateTime DtObs { get; set; }
    }
}
