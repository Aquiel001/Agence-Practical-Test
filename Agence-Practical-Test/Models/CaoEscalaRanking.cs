﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoEscalaRanking
    {
        public CaoEscalaRanking()
        {
            CaoPontosConhecimento = new HashSet<CaoPontosConhecimento>();
        }

        public byte Idescala { get; set; }
        public byte QtdVisual { get; set; }
        public int Pontuacao { get; set; }

        public virtual ICollection<CaoPontosConhecimento> CaoPontosConhecimento { get; set; }
    }
}
