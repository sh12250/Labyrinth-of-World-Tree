﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class RandomMap
    {
        public string[,] theMap;
        public int MapSize { get; private set; }
        public int MapCoreX { get; private set; }
        public int MapCoreY { get; private set; }

        public List<int> RoomCoreX { get; private set; }
        public List<int> RoomCoreY { get; private set; }

        public string Wall { get; private set; }
        public string Blank { get; private set; }
        public string UpStair { get; private set; }
        public string DownStair { get; private set; }
        public string Treasure { get; private set; }
        public string Character { get; private set; }

        public int PlayerXPos { get; private set; }
        public int PlayerYPos { get; private set; }

        public RandomMap()
        {
            MapSize = 31;

            theMap = new string[MapSize, MapSize];

            MapCoreX = (MapSize - 1) / 2;
            MapCoreY = (MapSize - 1) / 2;

            RoomCoreX = new List<int>();
            RoomCoreY = new List<int>();

            Wall = "■";
            Blank = "　";
            UpStair = "▨";
            DownStair = "▧";
            Treasure = "◈";
            Character = "◎";

            for (int y = 0; y < MapSize; y++)
            {
                for (int x = 0; x < MapSize; x++)
                {
                    theMap[y, x] = Wall;
                }
            }

            LocateRooms();
            LocateUpStair();
            LocateCharacter();
            LocateTreasure();
            LocateRoads();
        }

        public void SetPlayerPosition(int xPos, int yPos)
        {
            theMap[PlayerYPos, PlayerXPos] = Blank;
            theMap[yPos, xPos] = Character;
            PlayerYPos = yPos;
            PlayerXPos = xPos;
        }

        public void LocateRooms()
        {
            Random random = new Random();

            int roomCount = 0;

            int rooomShape;

            while (roomCount < 12)
            {
                RoomCoreX.Add(random.Next(2, MapSize - 2));
                RoomCoreY.Add(random.Next(2, MapSize - 2));

                rooomShape = random.Next(1, 4);

                switch (rooomShape)
                {
                    case 1:
                        if (RoomCoreX[roomCount] < MapSize / 2)
                        {
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] + 2] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] + 2] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] + 2] = Blank;
                        }
                        else
                        {
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] - 2] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] - 2] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] - 2] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] + 1] = Blank;
                        }

                        roomCount += 1;
                        break;
                    case 2:
                        if (RoomCoreY[roomCount] < MapSize / 2)
                        {
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 2, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 2, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] + 2, RoomCoreX[roomCount] + 1] = Blank;
                        }
                        else
                        {
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] + 1] = Blank;
                            theMap[RoomCoreY[roomCount] - 2, RoomCoreX[roomCount] - 1] = Blank;
                            theMap[RoomCoreY[roomCount] - 2, RoomCoreX[roomCount]] = Blank;
                            theMap[RoomCoreY[roomCount] - 2, RoomCoreX[roomCount] + 1] = Blank;
                        }

                        roomCount += 1;
                        break;
                    case 3:
                        theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] - 1] = Blank;
                        theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount]] = Blank;
                        theMap[RoomCoreY[roomCount] - 1, RoomCoreX[roomCount] + 1] = Blank;
                        theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] - 1] = Blank;
                        theMap[RoomCoreY[roomCount], RoomCoreX[roomCount]] = Blank;
                        theMap[RoomCoreY[roomCount], RoomCoreX[roomCount] + 1] = Blank;
                        theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] - 1] = Blank;
                        theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount]] = Blank;
                        theMap[RoomCoreY[roomCount] + 1, RoomCoreX[roomCount] + 1] = Blank;

                        roomCount += 1;
                        break;
                }
            }
        }

        public void LocateUpStair()
        {
            Random random = new Random();

            int randIdx = random.Next(0, 12);

            theMap[RoomCoreY[randIdx], RoomCoreX[randIdx]] = UpStair;
        }

        public void LocateCharacter()
        {
            for(int i = 0;i < 12; i++)
            {
                if(theMap[RoomCoreY[i], RoomCoreX[i]] == UpStair)
                {
                    theMap[RoomCoreY[i] + 1, RoomCoreX[i]] = Character;
                    PlayerYPos = RoomCoreY[i] + 1;
                    PlayerXPos = RoomCoreX[i];
                }
            }
        }

        public void LocateTreasure()
        {
            Random random = new Random();

            int count = 6;

            while (count > 0)
            {
                int randX = random.Next(1, MapSize - 1);
                int randY = random.Next(1, MapSize - 1);

                while (theMap[randY, randX] != Blank || theMap[randY - 1, randX] == UpStair)
                {
                    randX = random.Next(1, MapSize - 1);
                    randY = random.Next(1, MapSize - 1);
                }

                theMap[randY, randX] = Treasure;

                count--;
            }
        }

        public void LocateRoads()
        {
            Random random = new Random();

            int startX;
            int startY;

            int endX;
            int endY;

            for (int roomNum = 0; roomNum < 12; roomNum++)
            {
                startX = RoomCoreX[roomNum];
                startY = RoomCoreY[roomNum];

                int randIdx = random.Next(0, 12);

                while (randIdx == roomNum)
                {
                    randIdx = random.Next(0, 12);
                }

                endX = RoomCoreX[randIdx];
                endY = RoomCoreY[randIdx];

                if ((endX - startX) * (endX - startX) > (endY - startY) * (endY - startY)) // Y값 차이보다 X값 차이가 클 때
                {
                    if (startX > endX)
                    {
                        while (startX != endX)
                        {
                            startX -= 1;
                            if (theMap[startY, startX] == Wall)
                            {
                                theMap[startY, startX] = Blank;
                            }
                        }

                        if (startY > endY)
                        {
                            while (startY != endY)
                            {
                                startY -= 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                        else if (startY < endY)
                        {
                            while (startY != endY)
                            {
                                startY += 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                    }
                    else if (startX < endX)
                    {
                        while (startX != endX)
                        {
                            startX += 1;
                            if (theMap[startY, startX] == Wall)
                            {
                                theMap[startY, startX] = Blank;
                            }
                        }

                        if (startY > endY)
                        {
                            while (startY != endY)
                            {
                                startY -= 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                        else if (startY < endY)
                        {
                            while (startY != endY)
                            {
                                startY += 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                    }
                    else if (startX == endX)
                    {
                        if (startY > endY)
                        {
                            while (startY != endY)
                            {
                                startY -= 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                        else if (startY < endY)
                        {
                            while (startY != endY)
                            {
                                startY += 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                    }
                }           // Y값 차이보다 X값 차이가 클 때
                else if ((endX - startX) * (endX - startX) <= (endY - startY) * (endY - startY)) //(X값 차이보다 Y값 차이가 클 때)
                {
                    if (startY > endY)
                    {
                        while (startY != endY)
                        {
                            startY -= 1;
                            if (theMap[startY, startX] == Wall)
                            {
                                theMap[startY, startX] = Blank;
                            }
                        }

                        if (startX > endX)
                        {
                            while (startX != endX)
                            {
                                startX -= 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                        else if (startX < endX)
                        {
                            while (startX != endX)
                            {
                                startX += 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                    }
                    else if (startY < endY)
                    {
                        while (startY != endY)
                        {
                            startY += 1;
                            if (theMap[startY, startX] == Wall)
                            {
                                theMap[startY, startX] = Blank;
                            }
                        }

                        if (startX > endX)
                        {
                            while (startX != endX)
                            {
                                startX -= 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                        else if (startX < endX)
                        {
                            while (startX != endX)
                            {
                                startX += 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                    }
                    else if (startY == endY)
                    {
                        if (startX > endX)
                        {
                            while (startX != endX)
                            {
                                startX -= 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                        else if (startX < endX)
                        {
                            while (startX != endX)
                            {
                                startX += 1;
                                if (theMap[startY, startX] == Wall)
                                {
                                    theMap[startY, startX] = Blank;
                                }
                            }
                        }
                    }
                }           //(X값 차이보다 Y값 차이가 클 때)
            }
        }

        public void PrintTheMap()
        {
            for (int y = 0; y < MapSize; y++)
            {
                for (int x = 0; x < MapSize; x++)
                {
                    if (theMap[y, x] == Treasure)
                    {
                        Console.SetCursorPosition((x * 2) + 63, y);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(theMap[y, x]);
                    }
                    else if (theMap[y, x] == Character)
                    {
                        Console.SetCursorPosition((x * 2) + 63, y);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(theMap[y, x]);
                    }
                    else if (theMap[y, x] == UpStair)
                    {
                        Console.SetCursorPosition((x * 2) + 63, y);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(theMap[y, x]);
                    }
                    else if (theMap[y, x] == DownStair)
                    {
                        Console.SetCursorPosition((x * 2) + 63, y);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(theMap[y, x]);
                    }
                    else 
                    {
                        Console.SetCursorPosition((x * 2) + 63, y);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(theMap[y, x]);
                    }
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
