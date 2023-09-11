using _11._09.House;
using _11._09.Workers;


House house = new House();

IWorker teamLeader = new TeamLeader(house);
teamLeader.Work();

IWorker team = new Team(house);
for(int i = 0; i < 11; i++)
    team.Work();

teamLeader.Work();