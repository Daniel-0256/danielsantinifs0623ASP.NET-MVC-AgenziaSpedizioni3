﻿using AgenziaSpedizioni.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgenziaSpedizioni.Dati
{
    public class MyDbContext : DbContext
    {
        public DbSet<Utente> Utenti { get; set; }
        public DbSet<Spedizione> Spedizioni { get; set; }
        public DbSet<StatoSpedizione> StatoSpedizioni { get; set; }

        // Costruttore che accetta una stringa di connessione
        public MyDbContext() : base("name=ConnectionString")
        {
        }

    }
}