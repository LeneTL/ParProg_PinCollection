using System;
using System.Collections.Generic;
using System.Text;

namespace ParProg_Pins
{
    internal class Bensinstasjon
    {
        private string Navn {  get; set; }
        private Pin Pin {  get; set; }

        public Bensinstasjon(string navn, Pin pin)
        {
            Navn = navn;
            Pin = pin;
        }
    }
}
