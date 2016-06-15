using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace MvcApplication1.App_Start
{
    public partial class DataBaseMigration : DbMigration
    {

        public override void Up()
        { 
        }

        public override void Down()
        {
            DropTable("dbo.Livre");
        }
    }
}