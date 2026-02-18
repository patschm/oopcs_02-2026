namespace TheFirm;


// Overerving gebruik je om structureringsproblemen op te lossen
// Ze noemen dat ook wel een is-a relatie
// Interfaces gebruik je om interactie tussen willekeurig objecten te ontkoppelen.
// Je erft dan ook niet van de interface, maar je implementeert hem.
// De interface beschrijft een can-do relatie
class Werknemer : Persoon, IContract
{
    public void Werk()
    {
        Werken();
    }

    public virtual void Werken()
    {
        
    }
}
