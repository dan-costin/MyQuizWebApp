namespace MyQuiz.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(),
                        Answer1 = c.String(),
                        Answer2 = c.String(),
                        Answer3 = c.String(),
                        Answer4 = c.String(),
                        IsAnswer1Correct = c.Boolean(nullable: false),
                        IsAnswer2Correct = c.Boolean(nullable: false),
                        IsAnswer3Correct = c.Boolean(nullable: false),
                        IsAnswer4Correct = c.Boolean(nullable: false),
                        Quiz_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Quizzes", t => t.Quiz_ID)
                .Index(t => t.Quiz_ID);
            
            CreateTable(
                "dbo.Quizzes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfQuestions = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Owner_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.Owner_ID)
                .Index(t => t.Owner_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.QuizzesHistory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        QuizTaken_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Quizzes", t => t.QuizTaken_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.QuizTaken_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuizzesHistory", "User_ID", "dbo.Users");
            DropForeignKey("dbo.QuizzesHistory", "QuizTaken_ID", "dbo.Quizzes");
            DropForeignKey("dbo.Questions", "Quiz_ID", "dbo.Quizzes");
            DropForeignKey("dbo.Quizzes", "Owner_ID", "dbo.Users");
            DropIndex("dbo.QuizzesHistory", new[] { "User_ID" });
            DropIndex("dbo.QuizzesHistory", new[] { "QuizTaken_ID" });
            DropIndex("dbo.Quizzes", new[] { "Owner_ID" });
            DropIndex("dbo.Questions", new[] { "Quiz_ID" });
            DropTable("dbo.QuizzesHistory");
            DropTable("dbo.Users");
            DropTable("dbo.Quizzes");
            DropTable("dbo.Questions");
        }
    }
}
