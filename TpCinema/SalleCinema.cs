using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCinema
{
    class SalleCinema
    {
        public int numsal;
        private string titre;
        private int nbplaces;
        private double tarif;
        private int nbplacesvn;
        private int nbplacesvr;

        public SalleCinema(string leTitre, int nombrePlaces, double leTarif, int sallenumero)
        {
            this.numsal = sallenumero;
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

        public string VendrePlaces(int nbre, bool tarifReduit)
        {
            
            string msg;
            if (this.nbPlacesDisponibles()-nbre>=0)
            {
                 if (tarifReduit)
                 {
                    msg=Convert.ToString(this.tarif*0.8*nbre);
                 }
                 else
                 {
                    msg=Convert.ToString(tarif*nbre);
                 }

            }
            else
            {
            msg=("Vente impossible");
            }

            return msg;
        }

        public void remiseAZero()
        {
        nbplacesvn=0;
        nbplacesvr=0;
        }

        public double chiffreAffaires()
        {
            
         return  (nbplacesvn*tarif) + (nbplacesvr*tarif*0.8);
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
