using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class multiline
    {
        String cmds;
        String fillvalue;
        List<string> vrs = new List<string>();
        List<string> vales = new List<string>();
        List<string> mth_vars = new List<string>();
        List<string> mthds = new List<string>();
        List<string> mthds_cmds = new List<string>();
        Graphics j;        
        public multiline(string cmds, Graphics j, String fillvalue)
        {
            this.cmds = cmds;
            this.j = j;
            this.fillvalue = fillvalue;
        }
    }
    }

