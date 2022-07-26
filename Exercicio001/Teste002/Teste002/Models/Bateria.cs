namespace Teste002.Models
{
    class Bateria
    {
        public int Charge { get; set; }

        public Bateria()
        {
            Charge = 10;
        }

        public void ChangeCharge()
        {
            if (Charge == 0)
                return;

            Charge--;
        }
    }
}