using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_OOPTwo
{
    class MyFirm
    {
        private int _id;

        private string _directorName;

        private int _employesNumber;

        private string _adress;

        private string _phone;

        private string _workDone;
        /// <summary>
        ///  We used Properties here
        /// </summary>
        public int Id 
        {
            get 
            {
                return _id; 
            }      
            
            set 
            {
                if (value > 12345)
                    _id = value;

                _id = 123456;
            }
                       
        }
  
        public string DirectorName 
        {
            get
            {
                return _directorName;
                             
            }

            set 
            {
                _directorName = value;
            }
                             
        
        }
        
        public int EmployesNumber 
        {
            get
            {
                return _employesNumber;
            
            }
            set 
            {
                if (value > 3)
                    _employesNumber = value;

                _employesNumber = 5;
            }         
        }

        public string Adress
        {
            get 
            {
                return _adress; 
            
            }
            set 
            {
                _adress = value; 
            } 
        
        } 

        public string Phones
        {
            get 
            {
                return _phone;
           
            }
            set 
            {
                _phone = value;  
            }     


        }
        public string Workdone 
        {
            get 
            {
                return _workDone;

            }
            set 
            {
                _workDone = value; 
            } 
      
        
        }

        ///
        /// We used Auto - Properties here   
        ///
        /*public int Id { get; set; }

        public string DirectorName { get; set; }
 
        public int EmployesNumber { get; set; }
        
        public string Adress { get; set; }

        public string Phones { get; set; }

        public string WorkDone { get; set; } */












    }
}
