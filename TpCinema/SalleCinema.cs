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
                    this.nbplacesvr += nbre;
                 }
                 else
                 {
                    msg=Convert.ToString(tarif*nbre);
                    this.nbplacesvn += nbre;
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
            
         
            return ("Filme joué : " + this.titre + ", \n Nombre de places : " + this.nbplaces + " , \n Prix d'une place : " + this.tarif + " , \n" + this.nbplacesvn + " places vendues au tarif normal , \n" + this.nbplacesvr + " places vendues au tarif réduit.");

        }

        public int getnumerosalle()
        {
            return this.numsal;
        }

    }

}
