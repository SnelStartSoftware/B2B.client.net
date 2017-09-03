using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een relatie.
    /// </summary>
    public class RelatieModel: IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "relaties";

        /// <summary>
        /// Geeft een instantie van een <see cref="RelatieModel"/> terug.
        /// </summary>
        public RelatieModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Datum waarop de gegevens van deze relatie zijn aangepast
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Het relatienummer
        /// </summary>
        public int Relatiecode { get; set; }

        /// <summary>
        /// De volledige naam van de relatie.
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// Geeft een instantie van een {SnelStart.B2B.Api.V1.Models.Relaties.RelatiesoortModel} terug.
        /// </summary>
        //[JsonConverter(typeof(StringEnumConverter))]
        public List<string> RelatieSoort { get; set; }

        /// <summary>
        /// Het vestigingsadres ({SnelStart.B2B.Api.V1.Models.Relaties.AdresModel}) van de relatie.
        /// </summary>
        public AdresModel VestigingsAdres { get; set; }

        /// <summary>
        /// Het correspondentieadres ({SnelStart.B2B.Api.V1.Models.Relaties.AdresModel}) van de relatie.
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
        public double? FactuurKorting { get; set; }

        /// <summary>
        /// Het standaard aantal dagen krediettermijn van aan deze relatie wordt gegeven (optioneel).
        /// </summary>
        public int? KredietTermijn { get; set; }

        /// <summary>
        /// Geeft <see langword=\"true\" /> terug als {SnelStart.B2B.Api.V1.Models.Relaties.RelatieModel.IncassoSoort}{SnelStart.B2B.Api.V1.Models.Relaties.IncassosoortModel.Core} of {SnelStart.B2B.Api.V1.Models.Relaties.IncassosoortModel.B2B} is.
        /// </summary>
        public bool Bankieren { get; set; }

        /// <summary>
        /// Een vlag dat aangeeft of een relatie niet meer actief is binnen de administratie.
        /// Indien <see langword=\"true\" />, dan kan de relatie als \"verwijderd\" worden beschouwd.
        /// </summary>
        public bool Nonactief { get; set; }

        /// <summary>
        /// Het standaard kredietlimiet (in €) van aan deze relatie wordt gegeven (optioneel).
        /// </summary>
        public double? KredietLimiet { get; set; }

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
        /// Het soort aanmaning ({SnelStart.B2B.Api.V1.Models.Relaties.AanmaningsoortModel}) dat van toepassing is op de relatie (optioneel).
        /// </summary>
        public AanmaningsoortModel? AanmaningSoort { get; set; }

        /// <summary>
        /// De emailgegevens voor het versturen van offertes.
        /// </summary>
        public EmailVersturen OfferteEmailVersturen { get; set; }

        /// <summary>
        /// De emailgegevens voor het versturen van bevestigingen.
        /// </summary>
        public EmailVersturen BevestigingsEmailVersturen { get; set; }

        /// <summary>
        /// De emailgegevens voor het versturen van facturen.
        /// </summary>
        public EmailVersturen FactuurEmailVersturen { get; set; }

        /// <summary>
        /// De emailgegevens voor het versturen van aanmaningen.
        /// </summary>
        public EmailVersturen AanmaningEmailVersturen { get; set; }

        /// <summary>
        /// Een vlag dat aangeeft of een UBL-bestand als bijlage bij een email moet worden toegevoegd bij het versturen van facturen.
        /// </summary>
        public bool UblBestandAlsBijlage { get; set; }

        /// <summary>
        /// Het IBAN-rekeningnummer van de relatie.
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// De BIC-code van de bank van het {SnelStart.B2B.Api.V1.Models.Relaties.RelatieModel.Iban}-nummer.
        /// </summary>
        public string Bic { get; set; }

        /// <summary>
        /// Het soort incasso ({SnelStart.B2B.Api.V1.Models.Relaties.IncassosoortModel}) dat van toepassing is op de relatie (optioneel).
        /// </summary>
        public IncassosoortModel? IncassoSoort{ get; set; }

        /// <summary>
        /// Indien aan de relatie (deze instantie) een factuur wordt verstuurd, dan wordt de betreffende factuur doorgestuurd
        /// naar de relatie met deze identifier.
        /// </summary>
        public RelatieIdentifierModel FactuurRelatie { get; set; }

        /// <summary>
        /// Verwijzing naar de inkoopboekingen voor de relatie
        /// </summary>
        public string InkoopBoekingUri { get; set; }

        /// <summary>
        /// Verwijzing naar de verkoopboekingen voor de relatie
        /// </summary>
        public string VerkoopBoekingUri { get; set; }
    }

    public class EmailVersturen
    {
        /// <summary>
        /// Geeft aan (lezen/schrijven) of er email moet worden verstuurd.
        /// </summary>
        public bool ShouldSend { get; set; }

        /// <summary>
        /// Het email adres waarnaar email moeten worden verstuurd.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Het (optionele) email adres waarnaar email moeten worden ge-Cc-eed.
        /// </summary>
        public string CcEmail { get; set; }
    }
}
