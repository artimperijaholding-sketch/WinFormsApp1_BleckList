using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1_lesson4;

public class DBHadlerBleckList : DbContext
{
    public DbSet<BlackList> BlackLists { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=BlackList.db");
    }

}
public class BlackList
{
    public int Id { get; set; }
    public string BlackListName { get; set; }=string.Empty;
    
}
public class DBHandler
{
    public DBHadlerBleckList DB { get; private set; }
    public DBHandler(DBHadlerBleckList db,bool isCreate=false)
    {
        DB = db;
        if(isCreate)
        {
            DB.Database.EnsureDeleted();
        }
        DB.Database.EnsureCreated();
        
    }
}