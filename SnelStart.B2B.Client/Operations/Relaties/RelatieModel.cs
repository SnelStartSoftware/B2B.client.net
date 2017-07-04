using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een relatie.
    /// </summary>
    public class RelatieModel : RelatieIdentifierModel
    {
        /// <summary>
        /// Geeft een instantie van een <see cref="RelatiesoortModel"/> terug.
        /// </summary>
        public RelatiesoortModel[] Relatiesoort { get; set; }

        /// <summary>
        /// Het relatienummer
        /// </summary>
        public int Relatiecode { get; set; }

        /// <summary>
        /// Geeft een instantie van een <see cref="RelatieModel"/> terug.
        /// </summary>
        public RelatieModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// De volledige naam van de relatie.
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// Het vestigingsadres (<see cref="AdresModel"/>) van de relatie.
        /// </summary>
        public AdresModel VestigingsAdres { get; set; }

        /// <summary>
        /// Het correspondentieadres (<see cref="AdresModel"/>) van de relatie.
        /// </summary>
        public AdresModel CorrespondentieAdres { get; set; }

        /// <summary>
        /// Het telefoonnummer van de relatie.
        /// </summary>
        public string Telefoon { get; set; }

        /// <summary>
        /// Het mobiele nummer van de relatie.
        /// </summary>
        public string MobieleTelefoon { get; set; }

        /// <summary>
        /// Het hoofd-emailadres van de relatie.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Het BTW-nummer van de relatie.
        /// </summary>
        public string BtwNummer { get; set; }

        /// <summary>
        /// De standaard factuurkorting die aan deze relatie wordt gegeven (optioneel).
        /// </summary>
        public decimal? Factuurkorting { get; set; }

        /// <summary>
        /// Het standaard aantal dagen krediettermijn van aan deze relatie wordt gegeven (optioneel).
        /// </summary>
        public int? Krediettermijn { get; set; }

        /// <summary>
        /// Geeft <see langword="true"/> terug als <see cref="IncassoSoort"/> <see cref="IncassosoortModel.Core"/> of <see cref="IncassosoortModel.B2B"/> is.
        /// </summary>
        public bool Bankieren { get; set; }

        /// <summary>
        /// Een vlag dat aangeeft of een relatie niet meer actief is binnen de administratie.
        /// Indien <see langword="true" />, dan kan de relatie als "verwijderd" worden beschouwd.
        /// </summary>
        public bool Nonactief { get; set; }

        /// <summary>
        /// Het standaard kredietlimiet (in €) van aan deze relatie wordt gegeven (optioneel).
        /// </summary>
        public decimal? KredietLimiet { get; set; }

        /// <summary>
        /// Een optioneel tekstveld voor aanvullende informatie.
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// Het nummer van de Kamer van Koophandel van de relatie.
        /// </summary>
        public string KvkNummer { get; set; }

        /// <summary>
        /// De URL van de website van de relatie.
        /// </summary>
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Het soort aanmaning (<see cref="AanmaningsoortModel"/>) dat van toepassing is op de relatie (optioneel).
        /// </summary>
        public AanmaningsoortModel? Aanmaningsoort { get; set; }

        /// <summary>
        /// De emailgegevens voor het versturen van offertes.
        /// </summary>
        public EmailVersturenModel OfferteEmailVersturen { get; set; }

        /// <summary>
        /// De emailgegevens voor het versturen van bevestigingen.
        /// </summary>
        public EmailVersturenModel BevestigingsEmailVersturen { get; set; }

        /// <summary>
        /// De emailgegevens voor het versturen van facturen.
        /// </summary>
        public EmailVersturenModel FactuurEmailVersturen { get; set; }

        /// <summary>
        /// De emailgegevens voor het versturen van aanmaningen.
        /// </summary>
        public EmailVersturenModel AanmaningEmailVersturen { get; set; }

        /// <summary>
        /// Een vlag dat aangeeft of een UBL-bestand als bijlage bij een email moet worden toegevoegd bij het versturen van facturen.
        /// </summary>
        public bool UblBestandAlsBijlage { get; set; }

        /// <summary>
        /// Het IBAN-rekeningnummer van de relatie.
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// De BIC-code van de bank van het <see cref="Iban"/>-nummer.
        /// </summary>
        public string Bic { get; set; }

        /// <summary>
        /// Het soort incasso (<see cref="IncassosoortModel"/>) dat van toepassing is op de relatie (optioneel).
        /// </summary>
        public IncassosoortModel? IncassoSoort { get; set; }

        /// <summary>
        /// Indien aan de relatie (deze instantie) een factuur wordt verstuurd, dan wordt de betreffende factuur doorgestuurd 
        /// naar de relatie met deze identifier.
        /// </summary>
        public RelatieIdentifierModel FactuurRelatie { get; set; }

        /// <summary>
        /// Verwijzing naar de inkoopboekingen voor de relatie
        /// </summary>
        public Uri InkoopBoekingenUri => new Uri($"/{Resource()}/{Id}/inkoopboekingen", UriKind.Relative);

        /// <summary>
        /// Verwijzing naar de verkoopboekingen voor de relatie
        /// </summary>
        public Uri VerkoopBoekingenUri => new Uri($"/{Resource()}/{Id}/verkoopboekingen", UriKind.Relative);
    }
}