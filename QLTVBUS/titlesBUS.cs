using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTVDTO;
using QLTVDAL;
namespace QLTVBUS
{
    public class titlesBUS
    {
        private titlesDAL titlesDAL;
        public titlesBUS()
        {
            titlesDAL = new titlesDAL();
        }
        public bool add(titlesDTO titles)
        {
            bool isAdd = titlesDAL.add(titles);
            return true;
        }
        public List<titlesDTO> selectedTitle()
        {
            return titlesDAL.selectedTitle();
        }
    }
}
