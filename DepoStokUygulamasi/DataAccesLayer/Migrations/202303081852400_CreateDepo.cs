namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDepo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 30),
                        CategoryId = c.Int(nullable: false),
                        BarkodKodu = c.String(maxLength: 15),
                        StokMiktari = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                        BirimFiyat = c.Double(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        RafNo = c.String(maxLength: 5),
                        MinStok = c.Int(nullable: false),
                        MaxStok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.UnitId)
                .Index(t => t.WarehouseId);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BirimAdi = c.String(nullable: false, maxLength: 10),
                        Aciklama = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepoAdi = c.String(nullable: false, maxLength: 20),
                        Aciklama = c.String(maxLength: 100),
                        DepoYetkilisi = c.String(maxLength: 30),
                        Telefon = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(nullable: false, maxLength: 25),
                        FirmaTuru = c.String(nullable: false, maxLength: 15),
                        Adres = c.String(maxLength: 100),
                        Telefon = c.String(maxLength: 15),
                        Email = c.String(maxLength: 20),
                        YetkiliKisi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 100),
                        VergiNo = c.String(maxLength: 15),
                        HesapNo = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 20),
                        Soyadi = c.String(nullable: false, maxLength: 20),
                        Gorevi = c.String(maxLength: 20),
                        KullaniciAdi = c.String(nullable: false, maxLength: 20),
                        Sifre = c.String(nullable: false, maxLength: 20),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.Products", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "WarehouseId" });
            DropIndex("dbo.Products", new[] { "UnitId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Companies");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Units");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
