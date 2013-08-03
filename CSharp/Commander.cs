using CruiseControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CruiseControl
{
    public class Commander
    {
        public BoardStatus _currentBoard;

        public Commander()
        {
            _currentBoard = new BoardStatus();
        }

        // Do not alter/remove this method signature
        public List<Command> GiveCommands()
        {
            var cmds = new List<Command>();

            var Targets = new List<Coordinate>();

            // Add Commands Here.
            // You can only give as many commands as you have un-sunk vessels. Powerup commands do not count against this number. 
            // You are free to use as many powerup commands at any time. Any additional commands you give (past the number of active vessels) will be ignored.

          //			cmds.Add(new Command { vesselid = 1, action = "fire", coordinate = new Coordinate { X = 1, Y = 1 } });
 /*

          if (_currentBoard.TurnsUntilBoardShrink < 2)
            {
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < _currentBoard.MyVesselStatuses[i].Location.Count; j++)
                    {
                        if (_currentBoard.MyVesselStatuses[i].Location[j].X <= _currentBoard.BoardMinCoordinate.X +1 )
                        {
                            cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[i].Id, action = "move:east"});
                            break;
                        }

                        if (_currentBoard.MyVesselStatuses[i].Location[j].Y <= _currentBoard.BoardMinCoordinate.Y + 1)
                        {
                            cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[i].Id, action = "move:south" });
                            break;
                        }

                        if (_currentBoard.MyVesselStatuses[i].Location[j].X >= _currentBoard.BoardMaxCoordinate.X - 1)
                        {
                            cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[i].Id, action = "move:west" });
                            break;
                        }

                        if (_currentBoard.MyVesselStatuses[i].Location[j].Y >= _currentBoard.BoardMinCoordinate.Y - 1)
                        {
                            cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[i].Id, action = "move:north" });
                            break;
                        }


                    }
                }
            }


         for (int i = 0; i < 3; i++)
            {

                Random random = new Random();
                int randomNumber = random.Next(0, 100);
                if (randomNumber / 2 == 1)
                {
                    cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[i].Id, action = "load_countermeasures" });
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (_currentBoard.MyVesselStatuses[i].Health / _currentBoard.MyVesselStatuses[i].MaxHealth <= .5)
                {
                    cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[i].Id, action = "repair" });
                }
            }


                for (int i = 0; i < _currentBoard.CoordinatesFromTruces.Count; i++)
            {
                Targets.Add(_currentBoard.CoordinatesFromTruces[i]);
                
            }


            for (int ship = 0; ship < 3; ship++) {
                for (int targetNo = 0; ship < _currentBoard.MyVesselStatuses[ship].SonarReport.Count;targetNo++)
                {
                    Targets.Add(_currentBoard.MyVesselStatuses[ship].SonarReport[targetNo]);
                    
                }

            }

           for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < _currentBoard.MyVesselStatuses[i].Location.Count; j++)
                {
                    Targets.Remove(_currentBoard.MyVesselStatuses[i].Location[j]);
                }

            }

            for (int i = 0; i < Targets.Count; i++) { 
                for (int j = 0; j < 3; j++){

                   cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[j].Id, action = "fire", coordinate = Targets[i] });
                }
            }

 */
            cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[0].Id, action = "move:east" });
            cmds.Add(new Command { vesselid = _currentBoard.MyVesselStatuses[1].Id, action = "move:east" });
            return cmds;
        }

        // Do NOT modify or remove! This is where you will receive the new board status after each round.
        public void GetBoardStatus(BoardStatus board)
        {
            _currentBoard = board;
        }

        // This method runs at the start of a new game, do any initialization or resetting here 
        public void Reset()
        {

        }
    }
}