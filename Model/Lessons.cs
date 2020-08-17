namespace DCLD.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Lessons : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Lessons”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“DCLD.Model.Lessons”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Lessons”
        //连接字符串。
        public Lessons()
            : base("name=Lessons")
        {
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        public virtual DbSet<LessonEntity> LessonEntities { get; set; }
    }

    public class LessonEntity
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public string Project { get; set; }
        public string VehicleName { get; set; }
        public string OccuredPhase { get; set; }
        public string Axle { get; set; }
        public string ProductType { get; set; }
        public string ProductLine { get; set; }
        public string RodSize { get; set; }
        public string PistonSize { get; set; }
        public string Status { get; set; }
        public DateTime OccuredDate { get; set; }
        public string PrimaryFailure { get; set; }
        public string IssueDescription { get; set; }
        public string FailedBySystem1 { get; set; }
        public string FailedByComponent1 { get; set; }
        public string FailedByComponent2 { get; set; }
        public string FailedBySystem2 { get; set; }
        public string FailedByComponent3 { get; set; }
        public string RootCause { get; set; }
        public string CorrectiveAction { get; set; }
        public string Responsible { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public string FailureAttachment { get; set; }
    }
}