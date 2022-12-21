using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;


namespace WPF_08C_InotyfyPropertyChange
{
    [AddINotifyPropertyChangedInterface]

    public class Sum
    {
        private string num1;
        private string num2;
        private string result;

        public string Num1 { get; set; }
       
           

        public string Num2 { get; set; }
       

        public string Result
        {
            get
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                return res.ToString();
            }
            set
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                Result = res.ToString();
                
            }


        }

        //    public event PropertyChangedEventHandler PropertyChanged;

        //    private void OnPropertyChanged(string property)
        //    {
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs(property));
        //        }

        //    }




    }
}
