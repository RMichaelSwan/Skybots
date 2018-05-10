﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics.GUI.Helpers
{
    public static class Constants
    {
        //Scoring increments for the scoring areas.
        public const uint platInc = 100; //Not sure which platform is the larger one, so use 100 increment for now.
        public const uint obs1Inc = 20; // Moving obstacle
        public const uint obs2Inc = 10; // Fixed obstacle
        public const uint hoverInc = 50; // Hover

        //Red Team Control Pins
        public const short rplat1   = 22; //Platform 1
        public const short rplat2   = 24; //Platform 2
        public const short robs1    = 26; //Obstacle 1
        public const short robs2    = 28; //Obstacle 2
        public const short rhover   = 30; //Hover
        public const short rstart   = 32; //Start
        public const short rmotor1  = 2;  //Motor1
        public const short rmotor2  = 3;  //Motor2

        //Blue Team Control Pins
        public const short bplat1   = 23; //Platform 1
        public const short bplat2   = 25; //Platform 2
        public const short bobs1    = 27; //Obstacle 1
        public const short bobs2    = 29; //Obstacle 2
        public const short bhover   = 31; //Hover
        public const short bstart   = 33; //Start
        public const short bmotor1  = 4;  //Motor1
        public const short bmotor2  = 5;  //Motor2
    }
}
