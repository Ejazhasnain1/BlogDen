namespace MindfireSolutions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Message_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BlogDen.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false),
                        Comment = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId);
            
        }
        
        public override void Down()
        {
            DropTable("BlogDen.Messages");
        }
    }
}
