namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoDoBancoDeDados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compromissoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Local = c.String(),
                        DataDeInicio = c.DateTime(nullable: false),
                        DataDeTermino = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        SobreNome = c.String(),
                        DataDeNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PessoaCompromissoes",
                c => new
                    {
                        Pessoa_Id = c.Int(nullable: false),
                        Compromisso_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pessoa_Id, t.Compromisso_Id })
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Id, cascadeDelete: true)
                .ForeignKey("dbo.Compromissoes", t => t.Compromisso_Id, cascadeDelete: true)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Compromisso_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaCompromissoes", "Compromisso_Id", "dbo.Compromissoes");
            DropForeignKey("dbo.PessoaCompromissoes", "Pessoa_Id", "dbo.Pessoas");
            DropIndex("dbo.PessoaCompromissoes", new[] { "Compromisso_Id" });
            DropIndex("dbo.PessoaCompromissoes", new[] { "Pessoa_Id" });
            DropTable("dbo.PessoaCompromissoes");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Compromissoes");
        }
    }
}
