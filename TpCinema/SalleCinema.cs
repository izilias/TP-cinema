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
            int nbplacesvendu;
            nbplacesvendu = nbplacesvn + nbplacesvr;
            nbplaces = nbplaces - nbplacesvendu;
            return nbplaces;
        }

        public void VendrePlaces(int nbre, bool tarifReduit)
        {
            int reduc;

            if (this.nbPlacesDisponibles()-nbre>=0)
            {
                 if (tarifReduit)
                 {
                    reduc=this.tarif*0.8*nbre;
                 }
                 else
                 {
                    reduc=tarif*nbre;
                 }

            }
            else
            {
            ("Vente impossible");
            }

            
        }

        public void remiseAZero()
        {
        nbplacesvn=0;
        nbplacesvr=0;
        }

        public double chiffreAffaires()
        {
            
         return  (nbplacevn*tarif) + (nbplacesvr*tarif*0.8);
        }

        public double tauxRemplissage()

        {
            return (nbplacesvn+nbplacesvr)/nbplaces*100;

        }        
        
        public string toString()

        {
            return
         ("Film joué : "+titre+(",")); 
         ("Nombre de places"+nbplaces);
         ("Prix d'une place :"+tarif);
         (nbplacesvn+"vendues au tarif normal");
         (nbplacesvr+ "vendues au tarif réduit"); 
        }

    }

}
