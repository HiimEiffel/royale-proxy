﻿// *******************************************************
// Created at 22/08/2017
// *******************************************************

namespace Royale_Proxy
{
    class Resources
    {
        public static Definition Definition;
        public static Logger Logger;
        public static Server Server;

        public Resources()
        {
            Definition = new Definition();

            Logger = new Logger();

            Server = new Server();
        }
    }
}