﻿using CadastroDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options):base(options)
        {
            
        }
      
        public DbSet<ContatoModel> Contato { get; set; }
        
        public DbSet<UsuarioModel> Usuarios { get; set; }



    }
}