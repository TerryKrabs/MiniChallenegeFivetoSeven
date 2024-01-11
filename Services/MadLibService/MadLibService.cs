namespace MiniChallenegeFivetoSeven.Services.MadLibService;

    public class MadLibService : ImadLibService
    {
         public string MadLib(string Name1, string Noun1, string Adjective1, string Activity, string Verb1, string Name2, string Noun2, string Name3, string Noun3, string ptVerb, string SongName, string Adjective2, string Name4, string Adjective3){
            return $"Yesterday I went to {Name1}'s birthday party. I got him/her a {Noun1}. The party was {Adjective1}. We started by playing {Activity} and then there was a {Verb1} party. Lots of my friends were there but I mostly hung out with {Name2}. We talked about {Noun2} and how our friend {Name3} is a {Noun3}. During cake everyone {ptVerb} and sang {SongName}. I had a {Adjective2} time at the party and enjoyed celebrating {Name4}. He/She is such a {Adjective3} friend. ";
        }
    }
