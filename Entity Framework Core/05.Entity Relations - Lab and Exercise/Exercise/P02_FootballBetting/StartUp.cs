using P02_FootballBetting.Data;
using P02_FootballBetting.Data.Models;

namespace P02_FootballBetting;

public class StartUp
{
    static void Main(string[] args)
    {
       using FootballBettingContext footballBettingContext = new FootballBettingContext();

        Team team = new Team();

        team.Name= "Liverpool";
        team.LogoUrl = "wwwww";
        team.Initials = "LIVR";

        footballBettingContext.Teams.Add(team);
        footballBettingContext.SaveChanges();
    }
}