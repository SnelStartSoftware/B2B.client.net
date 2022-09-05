using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een verkooporder.
    /// </summary>
    public class VerkooporderModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "verkooporders";

        /// <summary>
        /// Geeft een instantie van een <see cref="VerkooporderModel"/> terug.
        /// </summary>
        public VerkooporderModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// De relatie ({SnelStart.B2B.Api.V1.Models.IdentifierModel}) waarop de verkooporder wordt aangemaakt.
        /// </summary>
        public RelatieIdentifierModel Relatie { get; set; }

        /// <summary>
        /// Het soort aanmaning ({SnelStart.B2B.Api.V1.Models.Verkooporders.ProcesStatusModel}) dat van toepassing is op de verkooporder (optioneel).
        /// Indien niet ingegeven, dan is het Order (concept)
        /// </summary>
        public ProcesStatusModel? ProcesStatus { get; set; } = ProcesStatusModel.Order;

        /// <summary>
        /// Het ordernummer
        /// </summary>
        public int? Nummer { get; set; }

        /// <summary>
        /// Datum waarop de gegevens van deze order zijn aangepast
        /// </summary>
        public DateTime? ModifiedOn { get; set; }

        /// <summary>
        /// De orderdatum
        /// </summary>
        public DateTime Datum { get; set; }

        /// <summary>
        /// De krediettermijn (in dagen) van de verkooporder. \r\n<remarks>Indien dit veld leeg is dan wordt het krediettermijn van de klant gebruikt.
        /// Waarde moet tussen 0 en 100 liggen.
        /// </summary>
        public int? Krediettermijn { get; set; }

        /// <summary>
        /// De omschrijving van de order
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// Het betalingskenmerk van de order
        /// </summary>
        public string Betalingskenmerk { get; set; }

        /// <summary>
        /// De incassomachtiging voor deze order
        /// </summary>
        public IncassoMachtigingIdentifierModel Incassomachtiging { get; set; }

        /// <summary>
        /// Het aflever-/verzendadres voor deze order
        /// </summary>
        public AdresModel Afleveradres { get; set; }

        /// <summary>
        /// Het factuuradres voor deze order
        /// </summary>
        public AdresModel FactuurAdres { get; set; }

        /// <summary>
        /// Btw-ingavesoort voor deze order.
        /// Indien niet opgegeven, wordt Exclusief gehanteerd.
        /// </summary>
        public string VerkooporderBtwIngaveModel { get; set; } = Operations.VerkooporderBtwIngaveModel.Exclusief.ToString();

        /// <summary>
        /// Kostenplaats
        /// </summary>
        public KostenplaatsIdentifierModel Kostenplaats { get; set; }

        public VerkooporderRegelModel[] Regels { get; set; } = new VerkooporderRegelModel[0];

        /// <summary>
        /// Ordermemo
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// Factuurkorting in procenten
        /// </summary>
        public double? Factuurkorting { get; set; }

        /// <summary>
        /// De verkoopfactuur die bij deze order hoort
        /// </summary>
        public VerkoopFactuurModel Verkoopfactuur { get; set; }

        /// <summary>
        /// Het <see cref="VerkoopordersjabloonModel"/> dat bij deze order hoort
        /// </summary>
        public VerkoopordersjabloonModel Verkoopordersjabloon { get; set; }

    }
}
