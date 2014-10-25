using System;
using System.Collections.Generic;
using System.IO;

namespace Nations.Common
{
    public struct Settings // TODO: do error handling for all things (this should be like, done not now)
    {
        public uint Width;
        public uint Height;

        public static Settings Load(string filename)
        {
            Settings settings = new Settings(1280, 720);

            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                string line;
                char[] splitters = { '=', ' ' };
                while ((line = reader.ReadLine()) != null)
                {
                    string[] subStrings = line.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
                    switch (subStrings[0])
                    {
                        case "ResolutionWidth":
                            settings.Width = uint.Parse(subStrings[1]);
                            break;
                        case "ResolutionHeight":
                            settings.Height = uint.Parse(subStrings[1]);
                            break;
                        default:
                            // TODO: throw thingy about unknown settings thingy
                            break;
                    }
                }
                reader.Close();
                return settings;
            }
            else
            {
                StreamWriter writer = new StreamWriter(filename);

                writer.WriteLine("ResolutionWidth = " + settings.Width);
                writer.WriteLine("ResolutionHeight = " + settings.Height);

                writer.Close();
                return settings;
            }
        }
        public Settings(uint width, uint height)
        {
            Width = width;
            Height = height;
        }
    }
}
