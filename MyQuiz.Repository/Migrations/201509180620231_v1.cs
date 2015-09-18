namespace MyQuiz.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AnswerText = c.String(),
                        IsAnswerCorrect = c.Boolean(nullable: false),
                        Question_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Questions", t => t.Question_ID)
                .Index(t => t.Question_ID);
            
            DropColumn("dbo.Questions", "Answer1");
            DropColumn("dbo.Questions", "Answer2");
            DropColumn("dbo.Questions", "Answer3");
            DropColumn("dbo.Questions", "Answer4");
            DropColumn("dbo.Questions", "IsAnswer1Correct");
            DropColumn("dbo.Questions", "IsAnswer2Correct");
            DropColumn("dbo.Questions", "IsAnswer3Correct");
            DropColumn("dbo.Questions", "IsAnswer4Correct");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "IsAnswer4Correct", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "IsAnswer3Correct", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "IsAnswer2Correct", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "IsAnswer1Correct", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "Answer4", c => c.String());
            AddColumn("dbo.Questions", "Answer3", c => c.String());
            AddColumn("dbo.Questions", "Answer2", c => c.String());
            AddColumn("dbo.Questions", "Answer1", c => c.String());
            DropForeignKey("dbo.Answers", "Question_ID", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "Question_ID" });
            DropTable("dbo.Answers");
        }
    }
}
