namespace wform_test
{
    public partial class Form1 : Form
    {
        /**
         * KONSTRUKTOR RAZREDA 
         * 
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             * ustvarila boma instanco človeka, 
             * prvi človek bo Aleksander, 
             * drugi človek bo Edina
             * */
            Clovek edina = new Clovek();
            // ker imama spremenljivke z javnim dostopom, jih lahkoo spreminjava in bereva zunaj originalnega razreda
            edina.starost = 33;
            edina.ime = "Edina";
            edina.spol = "Ž";

            Clovek alex = new Clovek();
            alex.ime = "aleksander";
            alex.starost = 38;
            alex.spol = "M";

            //izpisi podatke  za instanco človeka edina 
            izpisiPodatkeCloveka(edina, textBox1);

            
            
        }

        //funkcija izpisa za človeka
        private void izpisiPodatkeCloveka(Clovek clovek, TextBox biloka)
        {
            string izpis = "Hallo. Moje ime je " + clovek.ime + ". Sem " + clovek.starost.ToString() + " let star(a). Sem " + clovek.spol + " spola!";
            biloka.Text = izpis;
        }


    }

    /**
     * Osnova objektnega programiranja je razred
     * če hočeš da je razred javno dostopen oz ga lahko uporabljajo drugi razredi uporabiš public modifier
     * če hočeš da je razred privatno dostopen je private
     * če hočeš da razred uporabijo drugi razredi z dedovanjem uporabiš protected 
     * */
    public class Clovek
    {
        /*
         * OSNOVNI (PRIMITIVNI) PODATKOVNI TIPI:
         * integer oz int - to so cela števila - 101
         * float - realna števila 1.232323
         * double - dolga realna števila 42.434234234234234827374384573485738457384573845738457385738
         * string - znakovni niz oz beseda "lalalala lalala skflsdfkslfk"
         * char - znak - 'a', '1'
         * boolean - bool - true ali false (1, 0)
         * 
         * */
        /*
         * večina razredov ima konstruktor. konstruktor je posebna metoda (ki to ni), ki se imenuje isto kot razred v katerem je
         * vsak konstruktor imora imeti vidljivostni parameter (kot je public, private, protected), in ne rabi vrniti vrednosti, kot je to značilno za metode (funkcije)
         * 
         */


        public Clovek()
        {

        }

        public string spol = "Ž";

        public int starost = 19;

        public string ime = "nekoime";




    }
}