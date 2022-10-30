﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoOsObsChamado
    {
        public int CoObs { get; set; }
        public int? CoChamado { get; set; }
        public string CoUsuario { get; set; }
        public string Descricao { get; set; }
        public string Email { get; set; }
        public string ArquivoObs { get; set; }
        public DateTime DtObs { get; set; }
    }
}
