namespace Entities
{
    public class Custumer
    {
        #region Contructor
        public Custumer(long IdCustumer, string Name, Site Site,string UrlSite, string Country,
                        string State,string SoldToNumber1,string SoldToNumber2, 
                        string SalesDistrict, string SalesOffice)
            {
              this.IdCustumer = IdCustumer;
              this.Name = Name;
              this.Site = Site;
              this.UrlSite = UrlSite;
              this.Country = Country;
              this.State = State;
              this.SoldToNumber1 = SoldToNumber1;
              this.SoldToNumber2 = SoldToNumber2;
              this.SalesDistrict = SalesDistrict;
              this.SalesOffice = SalesOffice;
             }

        #endregion
        #region Properties
        public virtual long   IdCustumer  { get; set; }
        public virtual string Name { get; set; }
        public virtual Site   Site { get; set; }
        public virtual string UrlSite { get; set; }
        public virtual string Country { get; set; }
        public virtual string State { get; set; }
        public virtual string SoldToNumber1 { get; set; }
        public virtual string SoldToNumber2 { get; set; }
        public virtual string SalesDistrict { get; set; }
        public virtual string SalesOffice   { get; set; }
        #endregion
    }
}
