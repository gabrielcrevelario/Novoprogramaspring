using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities
{
    public class User
    {
        #region Contructor
        public User (long IdUser, string Name, string Username,
            string Email, bool ManualLogger,
            bool PIVisionEditor, bool PowerBiView)
        {
            this.IdUser = IdUser;
            this.Name = Name;
            this.Username = Username;
            this.Email = Email;
            this.ManualLogger = ManualLogger;
            this.PIVisionEditor = PIVisionEditor;
            this.PowerBiView = PowerBiView;


        }
        #endregion

        #region Properties
        public virtual long IdUser { get; set; }
        public virtual string Name { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual bool ManualLogger { get; set; }
        public virtual bool PIVisionEditor { get; set; }
        public virtual bool PowerBiView { get; set; }
        public virtual Custumer Custumer { get; set; }
        public virtual long idCustumer { get; set; }
        public virtual Site Site { get; set; }
        public virtual long IdSite { get; set; }
        #endregion
    }
}
