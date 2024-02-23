using System.Runtime.CompilerServices;

namespace DLWMS.WinForms.Helpers
{
    public class Validator
    {
        public static bool ValidirajKontrolu(Control kontrola, ErrorProvider err, string kljuc)
        {
            var valid = true;
            if(kontrola is TextBox  && string.IsNullOrWhiteSpace(kontrola.Text))
                valid = false;
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                valid = false;
            else if (kontrola is PictureBox && (kontrola as PictureBox).Image ==null)
                valid = false;            

            if(!valid)            
                err.SetError(kontrola, Resursi.Get(kljuc));
            else
                err.Clear();
            return valid;
        }
    }

}
