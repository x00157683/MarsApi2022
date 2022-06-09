

using EAD_Ca3.Data;

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class AppUser : IdentityUser
    {


        [NotMapped]
        public List<Photo> myFavs;

      	public AppUser()
		{


			this.myFavs = new List<Photo>();  //new empty list
		}
    }
}
