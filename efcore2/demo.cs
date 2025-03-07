using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore2
{
    internal class demo
    {
        ///data anotation 
        ///[key]  primary key
        ///[databasegenerated(databasegeneratedoption.identity)] make identity by default(1,1)
        ///[required] must be inserted
        ///[range(12,21)] range bet 12,21
        ///[column(typename="varchar")] change datatype
        ///fluent apis
        ///use on moldelingcreating
        ///modelbuilder.entity<student>.property(e=>e.addrress).hasdefaultvalue("cairo");
        ///haskey() primarykey goes to
 
        ///by configuretion type of mapping 
        ///must implement interface identitytypeconfigurtion<student> 
         
    }
}
