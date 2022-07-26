namespace Teste002.Models
{
    class Lanterna
    {
        public bool IsOn { get; set; }

        public void ChangeStatus()
        {
            IsOn = !IsOn;
        }
    }
}