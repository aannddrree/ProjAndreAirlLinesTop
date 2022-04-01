namespace ProjAndreAirlLinesTop.Model
{
    public class Client
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public virtual Address Address { get; set; }
        #endregion
    }
}
