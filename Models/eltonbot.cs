using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
#pragma warning disable 649


namespace Microsoft.Bot.Sample.FormBot
{

    public enum Options
    {
        Cumplea�os, Familia, Amigos
    };
    public enum Familia
    {
        Mam�, Pap�, Hermanos
    };

    [Serializable]
    public class eltonbot
    {
        public Options? Opcion;
        public Familia? Familia;


        public static IForm<eltonbot> BuildForm()
        {
            return new FormBuilder<eltonbot>()
                    .Message("Hola, no estoy en este momento pero mi nickoeltonbot te ayudara ;) !")
                    .Build();
        }

    };
}