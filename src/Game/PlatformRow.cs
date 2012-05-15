﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;



namespace Game
{
    class PlatformRow
    {
        public PlatformRow(bool[] platformSettings)
        {
            if (platformSettings.Length != RowLength)
            {
                throw new ArgumentException();
            }
            this.platformSettings = platformSettings;
        }


        public PlatformRow()
        {
            for (int i = 0; i < RowLength; i++)
            {
                this.platformSettings[i] = true;
            }
        }



        public const int RowLength = 5;
        private readonly bool[] platformSettings = new bool[RowLength];
        public bool this[int i]
        {
            get { return platformSettings[i]; }
        }

        public bool IsEmpty()
        {
            for (int i = 0; i < RowLength; i++)
            {
                if (platformSettings[i]) { return false; }
            }

            return true;
        }


    }
}
