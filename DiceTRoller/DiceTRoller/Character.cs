using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTRoller
{
    class Character
    {

        public int char_id;
        public string char_name;
        public int char_lvl;
        public int char_str;
        public int char_dex;
        public int char_con;
        public int char_wis;
        public int char_int;
        public int char_cha;
        public int char_profMod;

        public int Save_CharacterData(int _id, string _name, int _lvl, int _str, int _dex, 
            int _con, int _wis, int _int, int _cha, int _profMod)
        {


            return 1;
        }
    }
}
