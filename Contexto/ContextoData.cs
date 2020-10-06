using Prova_Sistema_web_Ex4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prova_Sistema_web_Ex4.Contexto
{
    public class ContextoData : DbContext
    {
        public DbSet<Professor> Professors { get; set; }


    }
}