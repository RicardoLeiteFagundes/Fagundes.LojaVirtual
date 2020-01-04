﻿namespace Fagundes.LojaVirtual.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Categoria = c.String(),
                    })
                .PrimaryKey(t => t.ProdutoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
