﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoMovimentoOs
    {
        public int CoMovimentoOs { get; set; }
        public int NuOs { get; set; }
        public long CoSistema { get; set; }
        public long? CoTipoMovimento { get; set; }
        public long? NuValor { get; set; }
        public string DsValor { get; set; }
        public string UsuarioObs { get; set; }
    }
}