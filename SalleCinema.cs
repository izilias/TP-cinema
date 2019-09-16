using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCinema
{
    class SalleCinema
    {
        private string titre;
        private int nbplaces;
        private double tarif;
        private int nbplacesvn;
        private int nbplacesvr;

        public SalleCinema(string leTitre, int nombrePlaces, double leTarif)
        {
            this.titre = leTitre;
            this.nbplaces = nombrePlaces;
            this.tarif = leTarif;
            nbplacesvn = 0;
            nbplacesvr = 0;
        }

        public int nbPlacesDisponibles()
        {
            nbplacesvendu = nbplacesvn + nbplacesvr;
            nbplaces = nbplaces - nbplacesvendu;
            return nbplaces;
        }

        public void VendrePlaces(int nbre, bool tarifReduit)
        {
            int nbre;
            bool tarifReduit;
            int reduc;

            if (tarifReduit=true)
            {
             tarif=tarif*0.8;
            }

            if (nbre>nbplaces)
            {
            ("Vente impossible");
            }

            
        }

        public void remiseAZero()
        {
        
        }

        public double chiffreAffaires()
        {
            
        }

        public double tauxRemplissage()

        {

        }        
        
        public string toString()

        {
        
           
        }
    }

}
