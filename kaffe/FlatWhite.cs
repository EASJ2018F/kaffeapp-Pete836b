using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
     public class FlatWhite : Kaffe, Imælk
    {
        /// <summary>
        /// methode for at override prisen.
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 45;
        }
        /// <summary>
        /// Methode for milliliter mælken. 
        /// </summary>
        /// <returns></returns>
 public int MlMælk()
        {
            return 160;
        }

        /// <summary>
        /// Methode for Override styrken af Kaffen.
        /// </summary>
        /// <returns></returns>
        public override string Styrke()
        {
            return "Mild";
        }
    }
}
